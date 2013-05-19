#!/usr/bin/env python

'''
The expressions module contains classes to represent an expression. The main
class is ExpressionNode. ExpressionNode's most useful method is py_string(),
which returns a Python string representing that expression.
'''

import sys

from ctypedescs import *
import keyword

# Right now, the objects in this module are all oriented toward evaluation.
# However, they don't have to be, since ctypes objects are mutable. For example,
# shouldn't it be possible to translate the macro:
#
#   #define INCREMENT(x) ++x
#
# into Python? The resulting code should be:
#
#   def INCREMENT(x):
#       x.value+=1
#       return x.value
#
# On the other hand, this would be a challenge to write.

class EvaluationContext(object):
    '''Interface for evaluating expression nodes.
    '''
    def evaluate_identifier(self, name):
        warnings.warn('Attempt to evaluate identifier "%s" failed' % name)
        return 0

    def evaluate_sizeof(self, type):
        warnings.warn('Attempt to evaluate sizeof "%s" failed' % str(type))
        return 0

    def evaluate_sizeof(self, object):
        warnings.warn('Attempt to evaluate sizeof object "%s" failed' % str(object))
        return 0

    def evaluate_parameter(self, name):
        warnings.warn('Attempt to evaluate parameter "%s" failed' % name)
        return 0

class ExpressionNode(object):
    def __init__(self):
        self.errors = []

    def error(self,message,cls = None):
        self.errors.append((message,cls))

    def __repr__(self):
        try:
            string = repr(self.py_string(True))
        except ValueError:
            string = "<error in expression node>"
        return "<ExpressionNode: %s>" % string

    def visit(self,visitor):
        for error,cls in self.errors:
            visitor.visit_error(error,cls)

class ConstantExpressionNode(ExpressionNode):
    def __init__(self, value):
        ExpressionNode.__init__(self)
        self.value = value

    def evaluate(self, context):
        if isinstance(self.value, basestring) and len(self.value) is 1:
            return ord(self.value)
        return self.value

    def py_string(self, can_be_ctype):
        if sys.platform != 'win32' or (sys.platform == 'win32' and sys.version_info >= (2, 6)):
            # Windows python did not get infinity support until 2.6
            if self.value == float('inf'):
                return "float('inf')"
            elif self.value == float('-inf'):
                return "float('-inf')"
        return repr(self.value)

class IdentifierExpressionNode(ExpressionNode):
    def __init__(self, name):
        ExpressionNode.__init__(self)
        self.name = name

    def evaluate(self, context):
        return context.evaluate_identifier(self.name)

    def visit(self, visitor):
        visitor.visit_identifier(self.name)
        ExpressionNode.visit(self,visitor)

    def py_string(self, can_be_ctype):
        # Errors will be thrown in generated code if identifier evaluates
        # to a ctypes object, and can_be_ctype is False.
        return self.name

class ParameterExpressionNode(ExpressionNode):
    def __init__(self, name):
        ExpressionNode.__init__(self)
        self.name = name

    def evaluate(self, context):
        return context.evaluate_parameter(self.name)

    def visit(self, visitor):
        ExpressionNode.visit(self,visitor)

    def py_string(self, can_be_ctype):
        # Errors will be thrown in generated code if parameter is
        # a ctypes object, and can_be_ctype is False.
        return self.name

class UnaryExpressionNode(ExpressionNode):
    def __init__(self, name, op, format, child_can_be_ctype, child):
        ExpressionNode.__init__(self)
        self.name = name
        self.op = op
        self.format = format
        self.child_can_be_ctype = child_can_be_ctype
        self.child = child

    def visit(self, visitor):
        self.child.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self, context):
        if self.op:
            return self.op(self.child.evaluate(context))
        else:
            raise ValueError("The C operator \"%s\" can't be evaluated right " \
                "now" % self.name)

    def py_string(self, can_be_ctype):
        return self.format % \
            self.child.py_string(self.child_can_be_ctype and can_be_ctype)

class SizeOfExpressionNode(ExpressionNode):
    def __init__(self, child):
        ExpressionNode.__init__(self)
        self.child = child

    def visit(self, visitor):
        self.child.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self, context):
        if isinstance(self.child, CtypesType):
            return context.evaluate_sizeof(self.child)
        else:
            return context.evaluate_sizeof_object(self.child)

    def py_string(self, can_be_ctype):
        if isinstance(self.child, CtypesType):
            return 'sizeof(%s)' % self.child.py_string()
        else:
            return 'sizeof(%s)' % self.child.py_string(True)

class BinaryExpressionNode(ExpressionNode):
    def __init__(self, name, op, format, can_be_ctype, left, right):
        ExpressionNode.__init__(self)
        self.name = name
        self.op = op
        self.format = format
        self.can_be_ctype = can_be_ctype
        self.left = left
        self.right = right

    def visit(self, visitor):
        self.left.visit(visitor)
        self.right.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self, context):
        if self.op:
            return self.op(self.left.evaluate(context),
                           self.right.evaluate(context))
        else:
            raise ValueError("The C operator \"%s\" can't be evaluated right " \
                "now" % self.name)

    def py_string(self, can_be_ctype):
        return self.format % \
            (self.left.py_string(self.can_be_ctype[0] and can_be_ctype),
             self.right.py_string(self.can_be_ctype[0] and can_be_ctype))

class ConditionalExpressionNode(ExpressionNode):
    def __init__(self, cond, yes, no):
        ExpressionNode.__init__(self)
        self.cond = cond
        self.yes = yes
        self.no = no

    def visit(self, visitor):
        self.cond.visit(visitor)
        self.yes.visit(visitor)
        self.no.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self, context):
        if self.cond.evaluate(context):
            return self.yes.evaluate(context)
        else:
            return self.no.evaluate(context)

    def py_string(self, can_be_ctype):
        return "%s and %s or %s" % \
            (self.cond.py_string(True),
             self.yes.py_string(can_be_ctype),
             self.no.py_string(can_be_ctype))

class AttributeExpressionNode(ExpressionNode):
    def __init__(self, op, format, base, attribute):
        ExpressionNode.__init__(self)
        self.op = op
        self.format = format
        self.base = base
        self.attribute = attribute

        # Attribute access will raise parse errors if you don't do this.
        # Fortunately, the processor module does the same thing to
        # the struct member name.
        if self.attribute in keyword.kwlist:
            self.attribute = "_"+self.attribute

    def visit(self,visitor):
        self.base.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self, context):
        return self.op(self.base.evalute(context),self.attribute)

    def py_string(self, can_be_ctype):
        if can_be_ctype:
            return self.format % (self.base.py_string(can_be_ctype),
                                  self.attribute)
        else:
            return "(%s.value)" % (self.format % \
                    (self.base.py_string(can_be_ctype), self.attribute))

class CallExpressionNode(ExpressionNode):
    def __init__(self,function,arguments):
        ExpressionNode.__init__(self)
        self.function = function
        self.arguments = arguments

    def visit(self,visitor):
        self.function.visit(visitor)
        for arg in self.arguments:
            arg.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self,context):
        arguments = [arg.evaluate(context) for arg in self.arguments]
        return self.function.evaluate(context)(*arguments)

    def py_string(self, can_be_ctype):
        function = self.function.py_string(can_be_ctype)
        arguments = [x.py_string(can_be_ctype) for x in self.arguments]
        if can_be_ctype:
            return '(%s (%s))' % (function,", ".join(arguments))
        else:
            return '((%s (%s)).value)' % (function,", ".join(arguments))

# There seems not to be any reasonable way to translate C typecasts
# into Python. Ctypesgen doesn't try, except for the special case of NULL.
class TypeCastExpressionNode(ExpressionNode):
    def __init__(self, base, ctype):
        ExpressionNode.__init__(self)
        self.base = base
        self.ctype = ctype
        self.isnull = isinstance(ctype, CtypesPointer) and \
                      isinstance(base, ConstantExpressionNode) and \
                      base.value == 0

    def visit(self,visitor):
        # No need to visit ctype because it isn't actually used
        self.base.visit(visitor)
        ExpressionNode.visit(self,visitor)

    def evaluate(self,context):
        if self.isnull:
            return None
        else:
            return self.base.evaluate(context)

    def py_string(self, can_be_ctype):
        if self.isnull:
            return "None"
        else:
            return self.base.py_string(can_be_ctype)

class UnsupportedExpressionNode(ExpressionNode):
    def __init__(self,message):
        ExpressionNode.__init__(self)
        self.message = message
        self.error(message,'unsupported-type')

    def evaluate(self,context):
        raise ValueError("Tried to evaluate an unsupported expression " \
            "node: %s" % self.message)

    def __repr__(self):
        return "<UnsupportedExpressionNode>"

    def py_string(self, can_be_ctype):
        raise ValueError("Called py_string() an unsupported expression " \
            "node: %s" % self.message)
