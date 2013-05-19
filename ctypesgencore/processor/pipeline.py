#!/usr/bin/env python

import ctypes, re, os
from ctypesgencore.processor.operations import *
from ctypesgencore.processor.dependencies import find_dependencies
from ctypesgencore.ctypedescs import *
from ctypesgencore.messages import *

"""
A brief explanation of the processing steps:
1. The dependencies module builds a dependency graph for the descriptions.

2. Operation functions are called to perform various operations on the
descriptions. The operation functions are found in operations.py.

3. If an operation function decides to exclude a description from the output, it
sets 'description.include_rule' to "never"; if an operation function decides not
to include a description by default, but to allow if required, it sets
'description.include_rule' to "if_needed".

4. If an operation function encounters an error that makes a description unfit
for output, it appends a string error message to 'description.errors'.
'description.warnings' is a list of warning messages that will be displayed but
will not prevent the description from being output.

5. Based on 'description.include_rule', calculate_final_inclusion() decides
which descriptions to include in the output. It sets 'description.included' to
True or False.

6. For each description, print_errors_encountered() checks if there are error
messages in 'description.errors'. If so, print_errors_encountered() prints the
error messages, but only if 'description.included' is True - it doesn't bother
the user with error messages regarding descriptions that would not be in the
output anyway. It also prints 'description.warnings'.

7. calculate_final_inclusion() is called again to recalculate based on
the errors that print_errors_encountered() has flagged.

"""

def process(data,options):
    status_message("Processing description list.")

    find_dependencies(data,options)

    automatically_typedef_structs(data,options)
    remove_NULL(data, options)
    remove_descriptions_in_system_headers(data,options)
    filter_by_regexes_exclude(data,options)
    filter_by_regexes_include(data,options)
    remove_macros(data,options)
    fix_conflicting_names(data,options)
    find_source_libraries(data,options)

    calculate_final_inclusion(data,options)
    print_errors_encountered(data,options)
    calculate_final_inclusion(data,options)

def calculate_final_inclusion(data,opts):
    """calculate_final_inclusion() calculates which descriptions will be included in the
    output library.

    An object with include_rule="never" is never included.
    An object with include_rule="yes" is included if its requirements can be
        included.
    An object with include_rule="if_needed" is included if an object to be
        included requires it and if its requirements can be included.
    """

    def can_include_desc(desc):
        if desc.can_include==None:
            if desc.include_rule=="no":
                desc.can_include=False
            elif desc.include_rule=="yes" or desc.include_rule=="if_needed":
                desc.can_include=True
                for req in desc.requirements:
                    if not can_include_desc(req):
                        desc.can_include=False
        return desc.can_include

    def do_include_desc(desc):
        if desc.included:
            return # We've already been here
        desc.included = True
        for req in desc.requirements:
            do_include_desc(req)

    for desc in data.all:
        desc.can_include=None # None means "Not Yet Decided"
        desc.included=False

    for desc in data.all:
        if desc.include_rule=="yes":
            if can_include_desc(desc):
                do_include_desc(desc)

def print_errors_encountered(data,opts):
    # See descriptions.py for an explanation of the error-handling mechanism
    for desc in data.all:
        # If description would not have been included, dont bother user by
        # printing warnings.
        if desc.included or opts.show_all_errors:
            if opts.show_long_errors or len(desc.errors)+len(desc.warnings)<=2:
                for (error,cls) in desc.errors:
                    # Macro errors will always be displayed as warnings.
                    if isinstance(desc, MacroDescription):
                        if opts.show_macro_warnings:
                            warning_message(error,cls)
                    else:
                        error_message(error,cls)
                for (warning,cls) in desc.warnings:
                    warning_message(warning,cls)

            else:
                if desc.errors:
                    error1,cls1 = desc.errors[0]
                    error_message(error1,cls1)
                    numerrs = len(desc.errors)-1
                    numwarns = len(desc.warnings)
                    if numwarns:
                        error_message("%d more errors and %d more warnings " \
                            "for %s" % (numerrs,numwarns,desc.casual_name()))
                    else:
                        error_message("%d more errors for %s " % \
                            (numerrs,desc.casual_name()))
                else:
                    warning1,cls1 = desc.warnings[0]
                    warning_message(warning1,cls1)
                    warning_message("%d more errors for %s" % \
                        (len(desc.warnings)-1, desc.casual_name()))
        if desc.errors:
            # process() will recalculate to take this into account
            desc.include_rule = "never"
