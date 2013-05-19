#!/usr/bin/env python

'''
ctypesgencore.ctypedescs contains classes to represent a C type. All of them
classes are subclasses of CtypesType.

Unlike in previous versions of ctypesgen, CtypesType and its subclasses are
completely independent of the parser module.

The most important method of CtypesType and its subclasses is the py_string
method. str(ctype) returns a string which, when evaluated in the wrapper
at runtime, results in a ctypes type object.

For example, a CtypesType
representing an array of four integers could be created using:

>>> ctype = CtypesArray(CtypesSimple("int",True,0),4)

str(ctype) would evaluate to "c_int * 4".
'''

import warnings

__docformat__ = 'restructuredtext'

ctypes_type_map = {
   # typename   signed  longs
    ('void',    True,   0): 'None',
    ('int',     True,   0): 'c_int',
    ('int',     False,  0): 'c_uint',
    ('int',     True,   1): 'c_long',
    ('int',     False,  1): 'c_ulong',
    ('int',     True,   2): 'c_longlong',
    ('int',     False,  2): 'c_ulonglong',
    ('char',    True,   0): 'c_char',
    ('char',    False,  0): 'c_ubyte',
    ('short',   True,   0): 'c_short',
    ('short',   False,  0): 'c_ushort',
    ('float',   True,   0): 'c_float',
    ('double',  True,   0): 'c_double',
    ('size_t',  True,   0): 'c_size_t',
    ('int8_t',  True,   0): 'c_int8',
    ('int16_t', True,   0): 'c_int16',
    ('int32_t', True,   0): 'c_int32',
    ('int64_t', True,   0): 'c_int64',
    ('apr_int64_t',True,0): 'c_int64',
    ('off64_t', True,   0): 'c_int64',
    ('uint8_t', True,   0): 'c_uint8',
    ('uint16_t',True,   0): 'c_uint16',
    ('uint32_t',True,   0): 'c_uint32',
    ('uint64_t',True,   0): 'c_uint64',
    ('apr_uint64_t',True,0): 'c_uint64',
    ('wchar_t', True,   0): 'c_wchar',
    ('ptrdiff_t',True,  0): 'c_ptrdiff_t',  # Requires definition in preamble
    ('ssize_t', True,   0): 'c_ptrdiff_t',  # Requires definition in preamble
    ('va_list', True,   0): 'c_void_p',
}

# This protocol is used for walking type trees.
class CtypesTypeVisitor(object):
    def visit_struct(self, struct):
        pass

    def visit_enum(self, enum):
        pass

    def visit_typedef(self, name):
        pass

    def visit_error(self, error, cls):
        pass

    def visit_identifier(self, identifier):
        # This one comes from inside ExpressionNodes. There may be
        # ExpressionNode objects in array count expressions.
        pass

def visit_type_and_collect_info(ctype):
    class Visitor(CtypesTypeVisitor):
        def visit_struct(self,struct):
            structs.append(struct)
        def visit_enum(self,enum):
            enums.append(enum)
        def visit_typedef(self,typedef):
            typedefs.append(typedef)
        def visit_error(self,error,cls):
            errors.append((error,cls))
        def visit_identifier(self,identifier):
            identifiers.append(identifier)
    structs = []
    enums = []
    typedefs = []
    errors = []
    identifiers = []
    v = Visitor()
    ctype.visit(v)
    return structs,enums,typedefs,errors,identifiers

# Remove one level of indirection from funtion pointer; needed for typedefs
# and function parameters.
def remove_function_pointer(t):
    if type(t) == CtypesPointer and type(t.destination) == CtypesFunction:
        return t.destination
    elif type(t) == CtypesPointer:
        t.destination = remove_function_pointer(t.destination)
        return t
    else:
        return t

class CtypesType(object):
    def __init__(self):
        self.errors=[]

    def __repr__(self):
        return "<Ctype \"%s\">" % self.py_string()

    def error(self,message,cls=None):
        self.errors.append((message,cls))

    def visit(self,visitor):
        for error,cls in self.errors:
            visitor.visit_error(error,cls)

class CtypesSimple(CtypesType):
    """Represents a builtin type, like "char" or "int"."""
    def __init__(self, name, signed, longs):
        CtypesType.__init__(self)
        self.name = name
        self.signed = signed
        self.longs = longs

    def py_string(self):
        return ctypes_type_map[(self.name,self.signed,self.longs)]

class CtypesSpecial(CtypesType):
    def __init__(self,name):
        CtypesType.__init__(self)
        self.name = name

    def py_string(self):
        return self.name

class CtypesTypedef(CtypesType):
    """Represents a type defined by a typedef."""
    def __init__(self, name):
        CtypesType.__init__(self)
        self.name = name

    def visit(self,visitor):
        if not self.errors:
            visitor.visit_typedef(self.name)
        CtypesType.visit(self,visitor)

    def py_string(self):
        return self.name

class CtypesBitfield(CtypesType):
    def __init__(self, base, bitfield):
        CtypesType.__init__(self)
        self.base = base
        self.bitfield = bitfield

    def visit(self,visitor):
        self.base.visit(visitor)
        CtypesType.visit(self,visitor)

    def py_string(self):
        return self.base.py_string()

class CtypesPointer(CtypesType):
    def __init__(self, destination, qualifiers):
        CtypesType.__init__(self)
        self.destination = destination
        self.qualifiers = qualifiers

    def visit(self,visitor):
        if self.destination:
            self.destination.visit(visitor)
        CtypesType.visit(self,visitor)

    def py_string(self):
        return 'POINTER(%s)' % self.destination.py_string()

class CtypesArray(CtypesType):
    def __init__(self, base, count):
        CtypesType.__init__(self)
        self.base = base
        self.count = count

    def visit(self,visitor):
        self.base.visit(visitor)
        if self.count:
            self.count.visit(visitor)
        CtypesType.visit(self,visitor)

    def py_string(self):
        if self.count is None:
            return 'POINTER(%s)' % self.base.py_string()
        if type(self.base) == CtypesArray:
            return '(%s) * %s' % (self.base.py_string(),
                                  self.count.py_string(False))
        else:
            return '%s * %s' % (self.base.py_string(),
                                self.count.py_string(False))

class CtypesFunction(CtypesType):
    def __init__(self, restype, parameters, variadic=False):
        CtypesType.__init__(self)
        self.restype = restype

        # Don't allow POINTER(None) (c_void_p) as a restype... causes errors
        # when ctypes automagically returns it as an int.
        # Instead, convert to POINTER(c_void).  c_void is not a ctypes type,
        # you can make it any arbitrary type.
        if type(self.restype) == CtypesPointer and \
           type(self.restype.destination) == CtypesSimple and \
           self.restype.destination.name == 'None':
            self.restype = CtypesPointer(CtypesSpecial('c_void'), ())

        # Return "String" instead of "POINTER(c_char)"
        if self.restype.py_string() == 'POINTER(c_char)':
            self.restype = CtypesSpecial('String')

        self.argtypes = [remove_function_pointer(p) for p in parameters]
        self.variadic = variadic

    def visit(self,visitor):
        self.restype.visit(visitor)
        for a in self.argtypes:
            a.visit(visitor)
        CtypesType.visit(self,visitor)

    def py_string(self):
        return 'CFUNCTYPE(UNCHECKED(%s), %s)' % (self.restype.py_string(),
            ', '.join([a.py_string() for a in self.argtypes]))

last_tagnum = 0
def anonymous_struct_tag():
    global last_tagnum
    last_tagnum += 1
    return 'anon_%d' % last_tagnum

class CtypesStruct(CtypesType):
    def __init__(self, tag, variety, members, src=None):
        CtypesType.__init__(self)
        self.tag = tag
        self.variety = variety # "struct" or "union"
        self.members = members

        if not self.tag:
            self.tag = anonymous_struct_tag()
            self.anonymous = True
        else:
            self.anonymous = False

        if self.members==None:
            self.opaque = True
        else:
            self.opaque = False

        self.src = src

    def get_required_types(self):
        types = CtypesType.get_required_types(self)
        types.add((self.variety,self.tag))
        return types

    def visit(self,visitor):
        visitor.visit_struct(self)
        if not self.opaque:
            for name,ctype in self.members:
                ctype.visit(visitor)
        CtypesType.visit(self,visitor)

    def get_subtypes(self):
        if self.opaque:
            return set()
        else:
            return set([m[1] for m in self.members])

    def py_string(self):
        return "%s_%s" % (self.variety,self.tag)

last_tagnum = 0
def anonymous_enum_tag():
    global last_tagnum
    last_tagnum += 1
    return 'anon_%d' % last_tagnum

class CtypesEnum(CtypesType):
    def __init__(self, tag, enumerators, src=None):
        CtypesType.__init__(self)
        self.tag = tag
        self.enumerators = enumerators

        if not self.tag:
            self.tag = anonymous_enum_tag()
            self.anonymous = True
        else:
            self.anonymous = False

        if self.enumerators==None:
            self.opaque = True
        else:
            self.opaque = False

        self.src = src

    def visit(self,visitor):
        visitor.visit_enum(self)
        CtypesType.visit(self,visitor)

    def py_string(self):
        return 'enum_%s' % self.tag
