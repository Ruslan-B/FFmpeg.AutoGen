#!/usr/bin/env python

"""
All of the components of ctypegencore require an argument called "options".
In command-line usage, this would be an optparser.Values object. However, if
ctypesgencore is used as a standard Python module, constructing this object
would be a pain. So this module exists to provide a "default" options object
for convenience.
"""

import optparse, copy

default_values={
    "other_headers": [],
    "modules": [],
    "include_search_paths": [],
    "compile_libdirs": [],
    "runtime_libdirs": [],
    "cpp": "gcc -E",
    "save_preprocessed_headers": None,
    "all_headers": False,
    "builtin_symbols": False,
    "include_symbols": None,
    "exclude_symbols": None,
    "show_all_errors": False,
    "show_long_errors": False,
    "show_macro_warnings": True,
    "header_template": None,
    "inserted_files": [],
    "other_known_names": [],
    "include_macros": True,
    "libraries": [],
    "strip_build_path": None
}

def get_default_options():
    return optparse.Values(copy.deepcopy(default_values))
