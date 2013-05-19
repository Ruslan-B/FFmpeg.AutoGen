#!/usr/bin/env python

"""
The operations module contains various functions to process the
DescriptionCollection and prepare it for output.
ctypesgencore.processor.pipeline calls the operations module.
"""

import ctypes, re, os, sys, keyword
from ctypesgencore.descriptions import *
from ctypesgencore.messages import *
import ctypesgencore.libraryloader

# Processor functions

def automatically_typedef_structs(data,options):
    """automatically_typedef_structs() aliases "struct_<tag>" to "<tag>" for
    every struct and union."""
    # XXX Check if it has already been aliased in the C code.

    for struct in data.structs:
        if not struct.ctype.anonymous: # Don't alias anonymous structs
            typedef=TypedefDescription(struct.tag,
                                       struct.ctype,
                                       src=struct.src)
            typedef.add_requirements(set([struct]))

            data.typedefs.append(typedef)
            data.all.insert(data.all.index(struct)+1,typedef)
            data.output_order.append(("typedef", typedef))

def remove_NULL(data, options):
    """remove_NULL() removes any NULL definitions from the C headers because
ctypesgen supplies its own NULL definition."""

    for macro in data.macros:
        if macro.name=="NULL":
            macro.include_rule = "never"

def remove_descriptions_in_system_headers(data,opts):
    """remove_descriptions_in_system_headers() removes descriptions if they came
    from files outside of the header files specified from the command line."""

    known_headers = [os.path.basename(x) for x in opts.headers]

    for description in data.all:
        if description.src!=None:
            if description.src[0] == "<command line>":
                description.include_rule = "if_needed"
            elif description.src[0] == "<built-in>":
                if not opts.builtin_symbols:
                    description.include_rule="if_needed"
            elif os.path.basename(description.src[0]) not in known_headers:
                if not opts.all_headers:
                    # If something else requires this, include it even though
                    # it is in a system header file.
                    description.include_rule="if_needed"

def remove_macros(data,opts):
    """remove_macros() removes macros if --no-macros is set."""
    if not opts.include_macros:
        for macro in data.macros:
            macro.include_rule = "never"

def filter_by_regexes_exclude(data,opts):
    """filter_by_regexes_exclude() uses regular expressions specified by options
    dictionary to filter symbols."""
    if opts.exclude_symbols:
        expr=re.compile(opts.exclude_symbols)
        for object in data.all:
            if expr.match(object.py_name()):
                object.include_rule="never"

def filter_by_regexes_include(data,opts):
    """filter_by_regexes_include() uses regular expressions specified by options
    dictionary to re-include symbols previously rejected by other operations."""
    if opts.include_symbols:
        expr=re.compile(opts.include_symbols)
        for object in data.all:
            if object.include_rule!="never":
                if expr.match(object.py_name()):
                    object.include_rule="yes"

def fix_conflicting_names(data,opts):
    """If any descriptions from the C code would overwrite Python builtins or
    other important names, fix_conflicting_names() adds underscores to resolve
    the name conflict."""

    # This is the order of priority for names
    descriptions = data.functions + data.variables + data.structs + \
        data.typedefs + data.enums + data.constants + data.macros

    # This dictionary maps names to a string representing where the name
    # came from.
    important_names={}

    preamble_names=set()
    preamble_names=preamble_names.union(['DarwinLibraryLoader',
        'LibraryLoader', 'LinuxLibraryLoader', 'WindowsLibraryLoader',
        '_WindowsLibrary', 'add_library_search_dirs', '_environ_path', 'ctypes',
        'load_library', 'loader', 'os', 're', 'sys'])
    preamble_names=preamble_names.union(['ArgumentError', 'CFUNCTYPE',
        'POINTER', 'ReturnString', 'String', 'Structure', 'UNCHECKED', 'Union',
        'UserString', '_variadic_function', 'addressof', 'c_buffer', 'c_byte',
        'c_char', 'c_char_p', 'c_double', 'c_float', 'c_int', 'c_int16',
        'c_int32', 'c_int64', 'c_int8', 'c_long', 'c_longlong', 'c_ptrdiff_t',
        'c_short', 'c_size_t', 'c_ubyte', 'c_uint', 'c_uint16', 'c_uint32',
        'c_uint64', 'c_uint8', 'c_ulong', 'c_ulonglong', 'c_ushort', 'c_void',
        'c_void_p', 'c_voidp', 'c_wchar', 'c_wchar_p', 'cast', 'ctypes', 'os',
        'pointer', 'sizeof'])
    for name in preamble_names:
        important_names[name] = "a name needed by ctypes or ctypesgen"
    for name in dir(__builtins__): important_names[name] = "a Python builtin"
    for name in opts.other_known_names:
        important_names[name] = "a name from an included Python module"
    for name in keyword.kwlist: important_names[name] = "a Python keyword"

    for description in descriptions:
        if description.py_name() in important_names:
            conflict_name = important_names[description.py_name()]

            original_name=description.casual_name()
            while description.py_name() in important_names:
                if isinstance(description,
                                (StructDescription, EnumDescription)):
                    description.tag+="_"
                else:
                    description.name="_"+description.name

            if not description.dependents:
                description.warning("%s has been renamed to %s due to a name " \
                    "conflict with %s." % \
                    (original_name,
                    description.casual_name(),
                    conflict_name),
                    cls = 'rename')
            else:
                description.warning("%s has been renamed to %s due to a name " \
                    "conflict with %s. Other objects depend on %s - those " \
                    "objects will be skipped." % \
                    (original_name, description.casual_name(),
                    conflict_name, original_name),
                    cls = 'rename')

                for dependent in description.dependents:
                    dependent.include_rule = "never"

            if description.include_rule=="yes":
                important_names[description.py_name()] = \
                    description.casual_name()

    # Names of struct members don't conflict with much, but they can conflict
    # with Python keywords.

    for struct in data.structs:
        if not struct.opaque:
            for i,(name,type) in enumerate(struct.members):
                if name in keyword.kwlist:
                    struct.members[i] = ("_"+name,type)
                    struct.warning("Member \"%s\" of %s has been renamed to " \
                        "\"%s\" because it has the same name as a Python " \
                        "keyword." % (name, struct.casual_name(), "_"+name),
                        cls = 'rename')

    # Macro arguments may be have names that conflict with Python keywords.
    # In a perfect world, this would simply rename the parameter instead
    # of throwing an error message.

    for macro in data.macros:
        if macro.params:
            for param in macro.params:
                if param in keyword.kwlist:
                    macro.error("One of the parameters to %s, \"%s\" has the " \
                        "same name as a Python keyword. %s will be skipped." % \
                        (macro.casual_name(), param, macro.casual_name()),
                        cls = 'name-conflict')

def find_source_libraries(data,opts):
    """find_source_libraries() determines which library contains each function
    and variable."""

    all_symbols=data.functions+data.variables

    for symbol in all_symbols:
        symbol.source_library=None

    ctypesgencore.libraryloader.add_library_search_dirs(opts.compile_libdirs)

    for library_name in opts.libraries:
        try:
            library=ctypesgencore.libraryloader.load_library(library_name)
        except ImportError,e:
            warning_message("Could not load library \"%s\". Okay, I'll " \
                "try to load it at runtime instead. " % (library_name),
                cls = 'missing-library')
            continue
        for symbol in all_symbols:
            if symbol.source_library==None:
                if hasattr(library,symbol.c_name()):
                    symbol.source_library=library_name
