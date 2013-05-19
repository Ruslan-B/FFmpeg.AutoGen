#!/usr/bin/env python

"""
ctypesgencore.descriptions contains classes to represent a description of a
struct, union, enum, function, constant, variable, or macro. All the
description classes are subclassed from an abstract base class, Description.
The descriptions module also contains a class, DescriptionCollection, to hold
lists of Description objects.
"""

class DescriptionCollection(object):
    """Represents a collection of Descriptions."""
    def __init__(self,constants,typedefs,structs,enums,functions,variables,
                 macros,all,output_order):
        self.constants=constants
        self.typedefs=typedefs
        self.structs=structs
        self.enums=enums
        self.functions=functions
        self.variables=variables
        self.macros=macros
        self.all=all
        self.output_order=output_order

class Description(object):
    """Represents a constant, typedef, struct, function, variable, enum,
    or macro description. Description is an abstract base class."""
    def __init__(self,src=None):
        self.src=src # A tuple of (filename, lineno)

        # If object will be included in output file. Values are "yes", "never",
        # and "if_needed".
        self.include_rule="yes"

        # A word about requirements, and dependents:
        # If X requires Y, Y is in X.requirements.
        # If X is in Y.requirements, then Y is in X.dependents.
        self.requirements=set()
        self.dependents=set()

        # If the processor module finds a fatal error that prevents a
        # a description from being output, then it appends a string describing
        # the problem to 'errors'. If it finds a nonfatal error, it appends a
        # string to 'warnings'. If the description would have been output, then
        # the errors and warnings are printed.

        # If there is anything in 'errors' after processing is complete, the
        # description is not output.

        self.errors=[]
        self.warnings=[]

    def add_requirements(self,reqs):
        self.requirements = self.requirements.union(reqs)
        for req in reqs:
            req.dependents.add(self)

    def error(self,msg,cls = None):
        self.errors.append((msg,cls))
    def warning(self,msg,cls = None):
        self.warnings.append((msg,cls))

    def __repr__(self):
        return "<Description: %s>" % self.casual_name()

    def casual_name(self):
        """Return a name to show the user."""
    def py_name(self):
        """Return the name associated with this description in Python code."""
    def c_name(self):
        """Return the name associated with this description in C code."""

class ConstantDescription(Description):
    """Simple class to contain information about a constant."""
    def __init__(self,name,value,src=None):
        Description.__init__(self,src)
        # Name of constant, a string
        self.name=name
        # Value of constant, as an ExpressionNode object
        self.value=value
    def casual_name(self):
        return "Constant \"%s\""%self.name
    def py_name(self):
        return self.name
    def c_name(self):
        return self.name

class TypedefDescription(Description):
    """Simple container class for a type definition."""
    def __init__(self,name,ctype,src=None):
        Description.__init__(self,src)
        self.name=name # Name, a string
        self.ctype=ctype # The base type as a ctypedescs.CtypeType object
    def casual_name(self):
        return "Typedef \"%s\""%self.name
    def py_name(self):
        return self.name
    def c_name(self):
        return self.name

class StructDescription(Description):
    """Simple container class for a structure or union definition."""
    def __init__(self,tag,variety,members,opaque,ctype,src=None):
        Description.__init__(self,src)
        # The name of the structure minus the "struct" or "union"
        self.tag=tag
        # A string "struct" or "union"
        self.variety=variety
        # A list of pairs of (name,ctype)
        self.members=members
        # True if struct body was not specified in header file
        self.opaque=opaque
        # The original CtypeStruct that created the struct
        self.ctype=ctype
    def casual_name(self):
        return "%s \"%s\""%(self.variety.capitalize(),self.tag)
    def py_name(self):
        return "%s_%s"%(self.variety,self.tag)
    def c_name(self):
        return "%s %s"%(self.variety,self.tag)

class EnumDescription(Description):
    """Simple container class for an enum definition."""
    def __init__(self,tag,members,ctype,src=None):
        Description.__init__(self,src)
        # The name of the enum, minus the "enum"
        self.tag=tag
        # A list of (name,value) pairs where value is a number
        self.members=members
        # The original CtypeEnum that created the enum
        self.ctype=ctype
    def casual_name(self):
        return "Enum \"%s\""%self.tag
    def py_name(self):
        return "enum_%s"%self.tag
    def c_name(self):
        return "enum %s"%self.tag

class FunctionDescription(Description):
    """Simple container class for a C function."""
    def __init__(self,name,restype,argtypes,argnames=None,variadic=False,src=None):
        Description.__init__(self,src)
        # Name, a string
        self.name=name
        # Name according to C - stored in case description is renamed
        self.cname=name
        # A ctype representing return type
        self.restype=restype
        # A list of ctypes representing the argument types
        self.argtypes=argtypes
        # A list of strings representing the argument names
        self.argnames=argnames
        # Does this function accept a variable number of arguments?
        self.variadic=variadic
    def casual_name(self):
        return "Function \"%s\""%self.name
    def py_name(self):
        return self.name
    def c_name(self):
        return self.cname

class VariableDescription(Description):
    """Simple container class for a C variable declaration."""
    def __init__(self,name,ctype,src=None):
        Description.__init__(self,src)
        # Name, a string
        self.name=name
        # Name according to C - stored in case description is renamed
        self.cname=name
        # The type of the variable
        self.ctype=ctype
    def casual_name(self):
        return "Variable \"%s\""%self.name
    def py_name(self):
        return self.name
    def c_name(self):
        return self.cname

class MacroDescription(Description):
    """Simple container class for a C macro."""
    def __init__(self,name,params,expr,src=None):
        Description.__init__(self,src)
        self.name = name
        self.params = params
        self.expr = expr # ExpressionNode for the macro's body
    def casual_name(self):
        return "Macro \"%s\""%self.name
    def py_name(self):
        return self.name
    def c_name(self):
        return self.name
