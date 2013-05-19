#!/usr/bin/env python

import os, sys, time
from ctypesgencore.descriptions import *
from ctypesgencore.ctypedescs import *
from ctypesgencore.messages import *

import ctypesgencore.libraryloader # So we can get the path to it
import test # So we can find the path to local files in the printer package

def path_to_local_file(name,known_local_module = test):
    basedir=os.path.dirname(known_local_module.__file__)
    return os.path.join(basedir,name)

class WrapperPrinter:
    def __init__(self,outpath,options,data):
        status_message("Writing to %s." % outpath)

        self.file=file(outpath,"w")
        self.options=options

        if self.options.strip_build_path and \
          self.options.strip_build_path[-1] != os.path.sep:
            self.options.strip_build_path += os.path.sep

        self.print_header()
        print >>self.file

        self.print_preamble()
        print >>self.file

        self.print_loader()
        print >>self.file

        self.print_group(self.options.libraries,"libraries",self.print_library)
        self.print_group(self.options.modules,"modules",self.print_module)

        method_table = {
            'function': self.print_function,
            'macro': self.print_macro,
            'struct': self.print_struct,
            'struct-body': self.print_struct_members,
            'typedef': self.print_typedef,
            'variable': self.print_variable,
            'enum': self.print_enum,
            'constant': self.print_constant
        }

        for kind,desc in data.output_order:
            if desc.included:
                method_table[kind](desc)
                print >>self.file

        self.print_group(self.options.inserted_files,"inserted files",
                         self.insert_file)

    def print_group(self,list,name,function):
        if list:
            print >>self.file,"# Begin %s" % name
            print >>self.file
            for obj in list:
                function(obj)
            print >>self.file
            print >>self.file,"# %d %s" % (len(list),name)
            print >>self.file,"# End %s" % name
        else:
            print >>self.file,"# No %s" % name
        print >>self.file

    def srcinfo(self,src):
        if src==None:
            print >>self.file
        else:
            filename,lineno = src
            if filename in ("<built-in>","<command line>"):
                print >>self.file, "# %s" % filename
            else:
                if self.options.strip_build_path and \
                  filename.startswith(self.options.strip_build_path):
                    filename = filename[len(self.options.strip_build_path):]
                print >>self.file, "# %s: %s" % (filename, lineno)

    def template_subs(self):
        template_subs={
            'date': time.ctime(),
            'argv': ' '.join([x for x in sys.argv if not x.startswith("--strip-build-path")]),
            'name': os.path.basename(self.options.headers[0])
        }

        for opt,value in self.options.__dict__.iteritems():
            if type(value)==str:
                template_subs[opt]=value
            elif isinstance(value,(list,tuple)):
                template_subs[opt]=(os.path.sep).join(value)
            else:
                template_subs[opt]=repr(value)

        return template_subs

    def print_header(self):
        template_file = None

        if self.options.header_template:
            path = self.options.header_template
            try:
                template_file = file(path,"r")
            except IOError:
                error_message("Cannot load header template from file \"%s\" " \
                    " - using default template." % path, cls = 'missing-file')

        if not template_file:
            path = path_to_local_file("defaultheader.py")
            template_file = file(path,"r")

        template_subs=self.template_subs()
        self.file.write(template_file.read() % template_subs)

        template_file.close()

    def print_preamble(self):
        path = path_to_local_file("preamble.py")

        print >>self.file, "# Begin preamble"
        print >>self.file
        preamble_file=file(path,"r")
        self.file.write(preamble_file.read())
        preamble_file.close()
        print >>self.file
        print >>self.file, "# End preamble"

    def print_loader(self):
        print >>self.file, "_libs = {}"
        print >>self.file, "_libdirs = %s" % self.options.compile_libdirs
        print >>self.file
        print >>self.file, "# Begin loader"
        print >>self.file
        path = path_to_local_file("libraryloader.py",
                                      ctypesgencore.libraryloader)
        loader_file=file(path,"r")
        self.file.write(loader_file.read())
        loader_file.close()
        print >>self.file
        print >>self.file, "# End loader"
        print >>self.file
        print >>self.file, "add_library_search_dirs([%s])" % \
                ", ".join([repr(d) for d in self.options.runtime_libdirs])

    def print_library(self,library):
        print >>self.file, '_libs["%s"] = load_library("%s")'%(library,library)

    def print_module(self,module):
        print >>self.file, 'from %s import *' % name

    def print_constant(self,constant):
        print >>self.file, '%s = %s' % \
            (constant.name,constant.value.py_string(False)),
        self.srcinfo(constant.src)

    def print_typedef(self,typedef):
        print >>self.file, '%s = %s' % \
            (typedef.name,typedef.ctype.py_string()),
        self.srcinfo(typedef.src)

    def print_struct(self, struct):
        self.srcinfo(struct.src)
        base = {'union': 'Union', 'struct': 'Structure'}[struct.variety]
        print >>self.file, 'class %s_%s(%s):' % \
            (struct.variety, struct.tag, base)
        print >>self.file, '    pass'

    def print_struct_members(self, struct):
        if struct.opaque: return
        print >>self.file, '%s_%s.__slots__ = [' % (struct.variety, struct.tag)
        for name,ctype in struct.members:
            print >>self.file, "    '%s'," % name
        print >>self.file, ']'
        print >>self.file, '%s_%s._fields_ = [' % (struct.variety, struct.tag)
        for name,ctype in struct.members:
            if isinstance(ctype,CtypesBitfield):
                print >>self.file, "    ('%s', %s, %s)," % \
                    (name, ctype.py_string(), ctype.bitfield.py_string(False))
            else:
                print >>self.file, "    ('%s', %s)," % (name, ctype.py_string())
        print >>self.file, ']'

    def print_enum(self,enum):
        print >>self.file, 'enum_%s = c_int' % enum.tag,
        self.srcinfo(enum.src)
        # Values of enumerator are output as constants.

    def print_function(self, function):
        if function.variadic:
            self.print_variadic_function(function)
        else:
            self.print_fixed_function(function)

    def print_fixed_function(self, function):
        self.srcinfo(function.src)

        # If we know what library the function lives in, look there.
        # Otherwise, check all the libraries.
        if function.source_library:
            print >>self.file, "if hasattr(_libs[%r], %r):" % \
                (function.source_library,function.c_name())
            print >>self.file, "    %s = _libs[%r].%s" % \
               (function.py_name(),function.source_library,function.c_name())
        else:
            print >>self.file, "for _lib in _libs.itervalues():"
            print >>self.file, "    if not hasattr(_lib, %r):" % function.c_name()
            print >>self.file, "        continue"
            print >>self.file, "    %s = _lib.%s" % \
               (function.py_name(),function.c_name())

        # Argument types
        print >>self.file, "    %s.argtypes = [%s]" % (function.py_name(),
            ', '.join([a.py_string() for a in function.argtypes]))

        # Return value
        if function.restype.py_string() == "String":
            print >>self.file, "    if sizeof(c_int) == sizeof(c_void_p):"
            print >>self.file, "        %s.restype = ReturnString" % \
                (function.py_name())
            print >>self.file, "    else:"
            print >>self.file, "        %s.restype = %s" % \
                (function.py_name(),function.restype.py_string())
            print >>self.file, "        %s.errcheck = ReturnString" % \
                (function.py_name())
        else:
            print >>self.file, "    %s.restype = %s" % \
                (function.py_name(),function.restype.py_string())

        if not function.source_library:
            print >>self.file, "    break"

    def print_variadic_function(self,function):
        self.srcinfo(function.src)
        if function.source_library:
            print >>self.file, "if hasattr(_libs[%r], %r):" % \
                (function.source_library,function.c_name())
            print >>self.file, "    _func = _libs[%r].%s" % \
                (function.source_library,function.c_name())
            print >>self.file, "    _restype = %s" % function.restype.py_string()
            print >>self.file, "    _argtypes = [%s]" % \
                ', '.join([a.py_string() for a in function.argtypes])
            print >>self.file, "    %s = _variadic_function(_func,_restype,_argtypes)" % \
                function.py_name()
        else:
            print >>self.file, "for _lib in _libs.values():"
            print >>self.file, "    if hasattr(_lib, %r):" % function.c_name()
            print >>self.file, "        _func = _lib.%s" % \
                (function.c_name())
            print >>self.file, "        _restype = %s" % function.restype.py_string()
            print >>self.file, "        _argtypes = [%s]" % \
                ', '.join([a.py_string() for a in function.argtypes])
            print >>self.file, "        %s = _variadic_function(_func,_restype,_argtypes)" % \
                function.py_name()


    def print_variable(self, variable):
        self.srcinfo(variable.src)
        if variable.source_library:
            print >>self.file, 'try:'
            print >>self.file, '    %s = (%s).in_dll(_libs[%r], %r)' % \
                (variable.py_name(),
                 variable.ctype.py_string(),
                 variable.source_library,
                 variable.c_name())
            print >>self.file, 'except:'
            print >>self.file, '    pass'
        else:
            print >>self.file, "for _lib in _libs.values():"
            print >>self.file, '    try:'
            print >>self.file, '        %s = (%s).in_dll(_lib, %r)' % \
                (variable.py_name(),
                 variable.ctype.py_string(),
                 variable.c_name())
            print >>self.file, "        break"
            print >>self.file, '    except:'
            print >>self.file, '        pass'

    def print_macro(self, macro):
        if macro.params:
            self.print_func_macro(macro)
        else:
            self.print_simple_macro(macro)

    def print_simple_macro(self, macro):
        # The macro translator makes heroic efforts but it occasionally fails.
        # We want to contain the failures as much as possible.
        # Hence the try statement.
        self.srcinfo(macro.src)
        print >>self.file, "try:"
        print >>self.file, "    %s = %s" % (macro.name,macro.expr.py_string(True))
        print >>self.file, "except:"
        print >>self.file, "    pass"

    def print_func_macro(self, macro):
        self.srcinfo(macro.src)
        print >>self.file, "def %s(%s):" % \
            (macro.name,", ".join(macro.params))
        print >>self.file, "    return %s" % macro.expr.py_string(True)

    def insert_file(self,filename):
        try:
            inserted_file = file(filename,"r")
        except IOError:
            error_message("Cannot open file \"%s\". Skipped it." % filename,
                          cls = 'missing-file')

        print >>self.file,"# Begin \"%s\"" % filename
        print >>self.file
        self.file.write(inserted_file.read())
        print >>self.file
        print >>self.file,"# End \"%s\"" % filename

        inserted_file.close()
