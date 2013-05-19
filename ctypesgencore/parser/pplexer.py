#!/usr/bin/env python

'''Preprocess a C source file using gcc and convert the result into
   a token stream

Reference is C99:
  * http://www.open-std.org/JTC1/SC22/WG14/www/docs/n1124.pdf

'''

__docformat__ = 'restructuredtext'

import os, re, shlex, sys, tokenize, lex, yacc, traceback
import ctypes
from lex import TOKEN

tokens = (
    'HEADER_NAME', 'IDENTIFIER', 'PP_NUMBER', 'CHARACTER_CONSTANT',
    'STRING_LITERAL', 'OTHER',

    'PTR_OP', 'INC_OP', 'DEC_OP', 'LEFT_OP', 'RIGHT_OP', 'LE_OP', 'GE_OP',
    'EQ_OP', 'NE_OP', 'AND_OP', 'OR_OP', 'MUL_ASSIGN', 'DIV_ASSIGN',
    'MOD_ASSIGN', 'ADD_ASSIGN', 'SUB_ASSIGN', 'LEFT_ASSIGN', 'RIGHT_ASSIGN',
    'AND_ASSIGN', 'XOR_ASSIGN', 'OR_ASSIGN',  'PERIOD', 'ELLIPSIS',

    'LPAREN', 'NEWLINE',

    'PP_DEFINE', 'PP_DEFINE_NAME', 'PP_DEFINE_MACRO_NAME', 'PP_MACRO_PARAM',
    'PP_STRINGIFY', 'PP_IDENTIFIER_PASTE', 'PP_END_DEFINE'
)

states = [('DEFINE',"exclusive")]

subs = {
    'D': '[0-9]',
    'L': '[a-zA-Z_]',
    'H': '[a-fA-F0-9]',
    'E': '[Ee][+-]?\s*{D}+',
    'FS': '[FflL]',
    'IS': '[uUlL]*',
}
# Helper: substitute {foo} with subs[foo] in string (makes regexes more lexy)
sub_pattern = re.compile('{([^}]*)}')
def sub_repl_match(m):
    return subs[m.groups()[0]]
def sub(s):
    return sub_pattern.sub(sub_repl_match, s)

# --------------------------------------------------------------------------
# Token value types
# --------------------------------------------------------------------------

# Numbers represented as int and float types.
# For all other tokens, type is just str representation.

class StringLiteral(str):
    def __new__(cls, value):
        assert value[0] == '"' and value[-1] == '"'
        # Unescaping probably not perfect but close enough.
        value = value[1:-1].decode('string_escape')
        return str.__new__(cls, value)

# --------------------------------------------------------------------------
# Token declarations
# --------------------------------------------------------------------------

punctuators = {
    # value: (regex, type)
    r'...': (r'\.\.\.', 'ELLIPSIS'),
    r'>>=': (r'>>=', 'RIGHT_ASSIGN'),
    r'<<=': (r'<<=', 'LEFT_ASSIGN'),
    r'+=': (r'\+=', 'ADD_ASSIGN'),
    r'-=': (r'-=', 'SUB_ASSIGN'),
    r'*=': (r'\*=', 'MUL_ASSIGN'),
    r'/=': (r'/=', 'DIV_ASSIGN'),
    r'%=': (r'%=', 'MOD_ASSIGN'),
    r'&=': (r'&=', 'AND_ASSIGN'),
    r'^=': (r'\^=', 'XOR_ASSIGN'),
    r'|=': (r'\|=', 'OR_ASSIGN'),
    r'>>': (r'>>', 'RIGHT_OP'),
    r'<<': (r'<<', 'LEFT_OP'),
    r'++': (r'\+\+', 'INC_OP'),
    r'--': (r'--', 'DEC_OP'),
    r'->': (r'->', 'PTR_OP'),
    r'&&': (r'&&', 'AND_OP'),
    r'||': (r'\|\|', 'OR_OP'),
    r'<=': (r'<=', 'LE_OP'),
    r'>=': (r'>=', 'GE_OP'),
    r'==': (r'==', 'EQ_OP'),
    r'!=': (r'!=', 'NE_OP'),
    r'<:': (r'<:', '['),
    r':>': (r':>', ']'),
    r'<%': (r'<%', '{'),
    r'%>': (r'%>', '}'),
    r';': (r';', ';'),
    r'{': (r'{', '{'),
    r'}': (r'}', '}'),
    r',': (r',', ','),
    r':': (r':', ':'),
    r'=': (r'=', '='),
    r')': (r'\)', ')'),
    r'[': (r'\[', '['),
    r']': (r']', ']'),
    r'.': (r'\.', 'PERIOD'),
    r'&': (r'&', '&'),
    r'!': (r'!', '!'),
    r'~': (r'~', '~'),
    r'-': (r'-', '-'),
    r'+': (r'\+', '+'),
    r'*': (r'\*', '*'),
    r'/': (r'/', '/'),
    r'%': (r'%', '%'),
    r'<': (r'<', '<'),
    r'>': (r'>', '>'),
    r'^': (r'\^', '^'),
    r'|': (r'\|', '|'),
    r'?': (r'\?', '?')
}

def punctuator_regex(punctuators):
    punctuator_regexes = [v[0] for v in punctuators.values()]
    punctuator_regexes.sort(lambda a, b: -cmp(len(a), len(b)))
    return '(%s)' % '|'.join(punctuator_regexes)

# Process line-number directives from the preprocessor
# See http://docs.freebsd.org/info/cpp/cpp.info.Output.html
DIRECTIVE = r'\#\s+(\d+)\s+"([^"]+)"[ \d]*\n'
@TOKEN(DIRECTIVE)
def t_ANY_directive(t):
    t.lexer.filename = t.groups[2]
    t.lexer.lineno = int(t.groups[1])
    return None

@TOKEN(punctuator_regex(punctuators))
def t_ANY_punctuator(t):
    t.type = punctuators[t.value][1]
    return t

IDENTIFIER = sub('{L}({L}|{D})*')
@TOKEN(IDENTIFIER)
def t_INITIAL_identifier(t):
    t.type = 'IDENTIFIER'
    return t

@TOKEN(IDENTIFIER)
def t_DEFINE_identifier(t):
    if t.lexer.next_is_define_name:
        # This identifier is the name of a macro
        # We need to look ahead and see if this macro takes parameters or not.
        if t.lexpos + len(t.value) < t.lexer.lexlen and \
            t.lexer.lexdata[t.lexpos + len(t.value)] == '(':

            t.type = 'PP_DEFINE_MACRO_NAME'

            # Look ahead and read macro parameter list
            lexdata = t.lexer.lexdata
            pos = t.lexpos + len(t.value) + 1
            while lexdata[pos] not in '\n)':
                pos+=1
            params = lexdata[t.lexpos+len(t.value)+1 : pos]
            paramlist = [x.strip() for x in params.split(",") if x.strip()]
            t.lexer.macro_params = paramlist

        else:
            t.type = 'PP_DEFINE_NAME'

        t.lexer.next_is_define_name = False
    elif t.value in t.lexer.macro_params:
        t.type = 'PP_MACRO_PARAM'
    else:
        t.type = 'IDENTIFIER'
    return t

FLOAT_LITERAL = sub(r"(?P<p1>{D}+)?(?P<dp>[.]?)(?P<p2>(?(p1){D}*|{D}+))" \
                    r"(?P<exp>(?:[Ee][+-]?{D}+)?)(?P<suf>{FS}?)(?!\w)")
@TOKEN(FLOAT_LITERAL)
def t_ANY_float(t):
    t.type = 'PP_NUMBER'
    m = t.lexer.lexmatch

    p1 = m.group("p1")
    dp = m.group("dp")
    p2 = m.group("p2")
    exp = m.group("exp")
    suf = m.group("suf")

    if dp or exp or (suf and suf in ("Ff")):
        s = m.group(0)
        if suf:
            s = s[:-1]
        # Attach a prefix so the parser can figure out if should become an
        # integer, float, or long
        t.value = "f" + s
    elif (suf and suf in ("Ll")):
        t.value = "l" + p1
    else:
        t.value = "i" + p1

    return t

INT_LITERAL = sub(r"(?P<p1>(?:0x{H}+)|(?:{D}+))(?P<suf>{IS})")
@TOKEN(INT_LITERAL)
def t_ANY_int(t):
    t.type = 'PP_NUMBER'
    m = t.lexer.lexmatch

    if "L" in m.group(3) or "l" in m.group(2):
        prefix = "l"
    else:
        prefix = "i"

    g1 = m.group(2)
    if g1.startswith("0x"):
        # Convert base from hexadecimal
        g1 = str(long(g1[2:],16))
    elif g1[0]=="0":
        # Convert base from octal
        g1 = str(long(g1,8))

    t.value = prefix + g1

    return t

CHARACTER_CONSTANT = sub(r"L?'(\\.|[^\\'])+'")
@TOKEN(CHARACTER_CONSTANT)
def t_ANY_character_constant(t):
    t.type = 'CHARACTER_CONSTANT'
    return t

STRING_LITERAL = sub(r'L?"(\\.|[^\\"])*"')
@TOKEN(STRING_LITERAL)
def t_ANY_string_literal(t):
    t.type = 'STRING_LITERAL'
    t.value = StringLiteral(t.value)
    return t

@TOKEN(r'\(')
def t_ANY_lparen(t):
    if t.lexpos == 0 or t.lexer.lexdata[t.lexpos-1] not in (' \t\f\v\n'):
        t.type = 'LPAREN'
    else:
        t.type = '('
    return t

@TOKEN(r'\n')
def t_INITIAL_newline(t):
    t.lexer.lineno += 1
    return None

@TOKEN(r'\#define')
def t_INITIAL_pp_define(t):
    t.type = 'PP_DEFINE'
    t.lexer.begin("DEFINE")
    t.lexer.next_is_define_name = True
    t.lexer.macro_params = set()
    return t

@TOKEN(r'\n')
def t_DEFINE_newline(t):
    t.type = 'PP_END_DEFINE'
    t.lexer.begin("INITIAL")
    t.lexer.lineno += 1
    del t.lexer.macro_params

    # Damage control in case the token immediately after the #define failed
    # to handle this
    t.lexer.next_is_define_name = False
    return t

@TOKEN(r'(\#\#)|(\#)')
def t_DEFINE_pp_param_op(t):
    if t.value=='#':
        t.type = 'PP_STRINGIFY'
    else:
        t.type = 'PP_IDENTIFIER_PASTE'
    return t

def t_INITIAL_error(t):
    t.type = 'OTHER'
    return t

def t_DEFINE_error(t):
    t.type = 'OTHER'
    t.value = t.value[0]
    t.lexer.lexpos+=1 # Skip it if it's an error in a #define
    return t

t_ANY_ignore = ' \t\v\f\r'
