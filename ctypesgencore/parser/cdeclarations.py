#!/usr/bin/env python

'''
This file contains classes that represent C declarations. cparser produces
declarations in this format, and ctypesparser reformats them into a format that
is not C-specific. The other modules don't need to touch these.
'''

__docformat__ = 'restructuredtext'

# --------------------------------------------------------------------------
# C Object Model
# --------------------------------------------------------------------------

class Declaration(object):
    def __init__(self):
        self.declarator = None
        self.type = Type()
        self.storage = None

    def __repr__(self):
        d = {
            'declarator': self.declarator,
            'type': self.type,
        }
        if self.storage:
            d['storage'] = self.storage
        l = ['%s=%r' % (k, v) for k, v in d.items()]
        return 'Declaration(%s)' % ', '.join(l)

class Declarator(object):
    pointer = None
    def __init__(self):
        self.identifier = None
        self.initializer = None
        self.array = None
        self.parameters = None
        self.bitfield = None

    # make pointer read-only to catch mistakes early
    pointer = property(lambda self: None)

    def __repr__(self):
        s = self.identifier or ''
        if self.bitfield:
            s += ":%d" % self.bitfield
        if self.array:
            s += repr(self.array)
        if self.initializer:
            s += ' = %r' % self.initializer
        if self.parameters is not None:
            s += '(' + ', '.join([repr(p) for p in self.parameters]) + ')'
        return s

class Pointer(Declarator):
    pointer = None
    def __init__(self):
        super(Pointer, self).__init__()
        self.qualifiers = []

    def __repr__(self):
        q = ''
        if self.qualifiers:
            q = '<%s>' % ' '.join(self.qualifiers)
        return 'POINTER%s(%r)' % (q, self.pointer) + \
            super(Pointer, self).__repr__()

class Array(object):
    def __init__(self):
        self.size = None
        self.array = None

    def __repr__(self):
        if self.size:
            a =  '[%r]' % self.size
        else:
            a = '[]'
        if self.array:
            return repr(self.array) + a
        else:
            return a

class Parameter(object):
    def __init__(self):
        self.type = Type()
        self.storage = None
        self.declarator = None

    def __repr__(self):
        d = {
            'type': self.type,
        }
        if self.declarator:
            d['declarator'] = self.declarator
        if self.storage:
            d['storage'] = self.storage
        l = ['%s=%r' % (k, v) for k, v in d.items()]
        return 'Parameter(%s)' % ', '.join(l)


class Type(object):
    def __init__(self):
        self.qualifiers = []
        self.specifiers = []

    def __repr__(self):
        return ' '.join(self.qualifiers + [str(s) for s in self.specifiers])

# These are used only internally.

class StorageClassSpecifier(str):
    pass

class TypeSpecifier(str):
    pass

class StructTypeSpecifier(object):
    def __init__(self, is_union, tag, declarations):
        self.is_union = is_union
        self.tag = tag
        self.declarations = declarations

    def __repr__(self):
        if self.is_union:
            s = 'union'
        else:
            s = 'struct'
        if self.tag:
            s += ' %s' % self.tag
        if self.declarations:
            s += ' {%s}' % '; '.join([repr(d) for d in self.declarations])
        return s

class EnumSpecifier(object):
    def __init__(self, tag, enumerators, src=None):
        self.tag = tag
        self.enumerators = enumerators
        self.src=src

    def __repr__(self):
        s = 'enum'
        if self.tag:
            s += ' %s' % self.tag
        if self.enumerators:
            s += ' {%s}' % ', '.join([repr(e) for e in self.enumerators])
        return s

class Enumerator(object):
    def __init__(self, name, expression):
        self.name = name
        self.expression = expression

    def __repr__(self):
        s = self.name
        if self.expression:
            s += ' = %r' % self.expression
        return s

class TypeQualifier(str):
    pass

def apply_specifiers(specifiers, declaration):
    '''Apply specifiers to the declaration (declaration may be
    a Parameter instead).'''
    for s in specifiers:
        if type(s) == StorageClassSpecifier:
            if declaration.storage:
                # Multiple storage classes, technically an error... ignore it
                pass
            declaration.storage = s
        elif type(s) in (TypeSpecifier, StructTypeSpecifier, EnumSpecifier):
            declaration.type.specifiers.append(s)
        elif type(s) == TypeQualifier:
            declaration.type.qualifiers.append(s)
