#!/usr/bin/env python

'''
ctypesgencore.parser.ctypesparser contains a class, CtypesParser, which is a
subclass of ctypesgencore.parser.cparser.CParser. CtypesParser overrides the
handle_declaration() method of CParser. It turns the low-level type declarations
produced by CParser into CtypesType instances and breaks the parser's general
declarations into function, variable, typedef, constant, and type descriptions.
'''

__docformat__ = 'restructuredtext'

__all__ = ["CtypesParser"]

from cparser import *
from ctypesgencore.ctypedescs import *
from cdeclarations import *
from ctypesgencore.expressions import *

def get_ctypes_type(typ, declarator, check_qualifiers=False):
    signed = True
    typename = 'int'
    longs = 0
    t = None

    for specifier in typ.specifiers:
        if isinstance(specifier, StructTypeSpecifier):
            t = make_struct_from_specifier(specifier)
        elif isinstance(specifier, EnumSpecifier):
            t = make_enum_from_specifier(specifier)
        elif specifier == 'signed':
            signed = True
        elif specifier == 'unsigned':
            signed = False
        elif specifier == 'long':
            longs += 1
        else:
            typename = str(specifier)

    if not t:
        # It is a numeric type of some sort
        if (typename,signed,longs) in ctypes_type_map:
            t = CtypesSimple(typename,signed,longs)

        elif signed and not longs:
            t = CtypesTypedef(typename)

        else:
            name = " ".join(typ.specifiers)
            if typename in [x[0] for x in ctypes_type_map.keys()]:
                # It's an unsupported variant of a builtin type
                error = "Ctypes does not support the type \"%s\"." % name
            else:
                error = "Ctypes does not support adding additional " \
                    "specifiers to typedefs, such as \"%s\"" % name
            t = CtypesTypedef(name)
            t.error(error,cls='unsupported-type')

        if declarator and declarator.bitfield:
            t = CtypesBitfield(t,declarator.bitfield)

    qualifiers = []
    qualifiers.extend(typ.qualifiers)
    while declarator and declarator.pointer:
        if declarator.parameters is not None:
            variadic = "..." in declarator.parameters

            params = []
            for param in declarator.parameters:
                if param=="...":
                    break
                params.append(get_ctypes_type(param.type, param.declarator))
            t = CtypesFunction(t, params, variadic)

        a = declarator.array
        while a:
            t = CtypesArray(t, a.size)
            a = a.array

        qualifiers.extend(declarator.qualifiers)

        t = CtypesPointer(t, declarator.qualifiers)

        declarator = declarator.pointer

    if declarator and declarator.parameters is not None:
        variadic = "..." in declarator.parameters

        params = []
        for param in declarator.parameters:
            if param=="...":
                break
            params.append(get_ctypes_type(param.type, param.declarator))
        t = CtypesFunction(t, params, variadic)

    if declarator:
        a = declarator.array
        while a:
            t = CtypesArray(t, a.size)
            a = a.array

    if isinstance(t, CtypesPointer) and \
       isinstance(t.destination, CtypesSimple) and \
       t.destination.name=="char" and \
       t.destination.signed:
        t = CtypesSpecial("String")

    return t

def make_struct_from_specifier(specifier):
    variety = {True:"union", False:"struct"}[specifier.is_union]
    tag = specifier.tag

    if specifier.declarations:
        members = []
        for declaration in specifier.declarations:
            t = get_ctypes_type(declaration.type,
                                declaration.declarator,
                                check_qualifiers=True)
            declarator = declaration.declarator
            if declarator is None:
                # XXX TEMPORARY while struct with no typedef not filled in
                break
            while declarator.pointer:
                declarator = declarator.pointer
            name = declarator.identifier
            members.append((name, remove_function_pointer(t)))
    else:
        members = None

    return CtypesStruct(tag,variety,members,
                        src=(specifier.filename,specifier.lineno))

def make_enum_from_specifier(specifier):
    tag = specifier.tag

    enumerators = []
    last_name = None
    for e in specifier.enumerators:
        if e.expression:
            value = e.expression
        else:
            if last_name:
                value = BinaryExpressionNode("addition", (lambda x,y:x+y),
                    "(%s + %s)", (False,False),
                    IdentifierExpressionNode(last_name),
                    ConstantExpressionNode(1))
            else:
                value = ConstantExpressionNode(0)

        enumerators.append((e.name,value))
        last_name = e.name

    return CtypesEnum(tag, enumerators,
                      src=(specifier.filename,specifier.lineno))

class CtypesParser(CParser):
    '''Parse a C file for declarations that can be used by ctypes.

    Subclass and override the handle_ctypes_* methods.
    '''

    def handle_declaration(self, declaration, filename, lineno):
        t = get_ctypes_type(declaration.type, declaration.declarator)

        if type(t) in (CtypesStruct, CtypesEnum):
            self.handle_ctypes_new_type(
                remove_function_pointer(t), filename, lineno)

        declarator = declaration.declarator
        if declarator is None:
            # XXX TEMPORARY while struct with no typedef not filled in
            return
        while declarator.pointer:
            declarator = declarator.pointer
        name = declarator.identifier
        if declaration.storage == 'typedef':
            self.handle_ctypes_typedef(
                name, remove_function_pointer(t), filename, lineno)
        elif type(t) == CtypesFunction:
            parameters = declarator.parameters
            argnames = []
            if parameters:
                i = 0
                for p in parameters:
                    p_name = None
                    if isinstance(p, Parameter) and p.declarator:
                        p_name = self.get_declarator_identifier(p.declarator)
                    else:
                        p_name = "p%d" % i
                    argnames.append(p_name)
                    i += 1

            self.handle_ctypes_function(
                name, t.restype, t.argtypes, t.variadic, argnames, filename, lineno)
        elif declaration.storage != 'static':
            self.handle_ctypes_variable(name, t, filename, lineno)

    def get_declarator_identifier(self, declarator):
        while isinstance(declarator, Pointer):
            declarator = declarator.pointer
        return declarator.identifier

    # ctypes parser interface.  Override these methods in your subclass.

    def handle_ctypes_new_type(self, ctype, filename, lineno):
        pass

    def handle_ctypes_typedef(self, name, ctype, filename, lineno):
        pass

    def handle_ctypes_function(self, name, restype, argtypes, argnames, filename, lineno):
        pass

    def handle_ctypes_variable(self, name, ctype, filename, lineno):
        pass
