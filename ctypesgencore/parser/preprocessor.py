#!/usr/bin/env python

'''Preprocess a C source file using gcc and convert the result into
   a token stream

Reference is C99:
  * http://www.open-std.org/JTC1/SC22/WG14/www/docs/n1124.pdf

'''

__docformat__ = 'restructuredtext'

import os, re, shlex, sys, tokenize, lex, yacc, traceback, subprocess
import ctypes
from lex import TOKEN
import pplexer

# --------------------------------------------------------------------------
# Lexers
# --------------------------------------------------------------------------

class PreprocessorLexer(lex.Lexer):
    def __init__(self):
        lex.Lexer.__init__(self)
        self.filename = '<input>'
        self.in_define = False

    def input(self, data, filename=None):
        if filename:
            self.filename = filename
        self.lasttoken = None
        self.input_stack = []

        lex.Lexer.input(self, data)

    def push_input(self, data, filename):
        self.input_stack.append(
            (self.lexdata, self.lexpos, self.filename, self.lineno))
        self.lexdata = data
        self.lexpos = 0
        self.lineno = 1
        self.filename = filename
        self.lexlen = len(self.lexdata)

    def pop_input(self):
        self.lexdata, self.lexpos, self.filename, self.lineno = \
            self.input_stack.pop()
        self.lexlen = len(self.lexdata)

    def token(self):
        result = lex.Lexer.token(self)
        while result is None and self.input_stack:
            self.pop_input()
            result = lex.Lexer.token(self)

        if result:
            self.lasttoken = result.type
            result.filename = self.filename
        else:
            self.lasttoken = None

        return result

class TokenListLexer(object):
    def __init__(self, tokens):
        self.tokens = tokens
        self.pos = 0

    def token(self):
        if self.pos < len(self.tokens):
            t = self.tokens[self.pos]
            self.pos += 1
            return t
        else:
            return None

def symbol_to_token(sym):
    if isinstance(sym, yacc.YaccSymbol):
        return sym.value
    elif isinstance(sym, lex.LexToken):
        return sym
    else:
        assert False, 'Not a symbol: %r' % sym

def create_token(type, value, production=None):
    '''Create a token of type and value, at the position where 'production'
    was reduced.  Don't specify production if the token is built-in'''
    t = lex.LexToken()
    t.type = type
    t.value = value
    t.lexpos = -1
    if production:
        t.lineno = production.slice[1].lineno
        t.filename = production.slice[1].filename
    else:
        t.lineno = -1
        t.filename = '<builtin>'
    return t

# --------------------------------------------------------------------------
# Grammars
# --------------------------------------------------------------------------

class PreprocessorParser(object):
    def __init__(self,options,cparser):
        self.defines = ["inline=", "__inline__=", "__extension__=",
                        "__const=const", "__asm__(x)=",
                        "__asm(x)=", "CTYPESGEN=1"]

        # On OSX, explicitly add these defines to keep from getting syntax
        # errors in the OSX standard headers.
        if sys.platform == 'darwin':
            self.defines += ["__uint16_t=uint16_t",
                             "__uint32_t=uint32_t",
                             "__uint64_t=uint64_t"]

        self.matches = []
        self.output = []
        self.lexer = lex.lex(cls=PreprocessorLexer,
                             optimize=1,
                             lextab='lextab',
                             outputdir=os.path.dirname(__file__),
                             module=pplexer)

        self.options = options
        self.cparser = cparser # An instance of CParser

    def parse(self, filename):
        """Parse a file and save its output"""

        cmd = self.options.cpp
        cmd += " -U __GNUC__ -dD"

        # This fixes Issue #6 where OS X 10.6+ adds a C extension that breaks
        # the parser.  Blocks shouldn't be needed for ctypesgen support anyway.
        if sys.platform == 'darwin':
            cmd += " -U __BLOCKS__"

        for path in self.options.include_search_paths:
            cmd += " -I%s" % path
        for define in self.defines:
            cmd += ' "-D%s"' % define
        cmd += ' "' + filename + '"'

        self.cparser.handle_status(cmd)

        pp = subprocess.Popen(cmd,
                              shell = True,
                              universal_newlines=True,
                              stdout = subprocess.PIPE,
                              stderr = subprocess.PIPE)
        ppout, pperr = pp.communicate()

        for line in pperr.split("\n"):
            if line:
                self.cparser.handle_pp_error(line)

        # We separate lines that are #defines and lines that are source code
        # We put all the source lines first, then all the #define lines.

        source_lines= []
        define_lines = []

        for line in ppout.split("\n"):
            line = line + "\n"
            if line.startswith("# "):
                # Line number information has to go with both groups
                source_lines.append(line)
                define_lines.append(line)

            elif line.startswith("#define"):
                source_lines.append("\n")
                define_lines.append(line)

            elif line.startswith("#"):
                # It's a directive, but not a #define. Remove it
                source_lines.append("\n")
                define_lines.append("\n")

            else:
                source_lines.append(line)
                define_lines.append("\n")

        text = "".join(source_lines + define_lines)

        if self.options.save_preprocessed_headers:
            self.cparser.handle_status("Saving preprocessed headers to %s." % \
                self.options.save_preprocessed_headers)
            try:
                f = file(self.options.save_preprocessed_headers, "w")
                f.write(text)
                f.close()
            except IOError:
                self.cparser.handle_error("Couldn't save headers.")

        self.lexer.input(text)
        self.output = []

        while True:
            token = self.lexer.token()
            if token is not None:
                self.output.append(token)
            else:
                break
