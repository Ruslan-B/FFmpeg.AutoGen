#!/usr/bin/env python

"""
ctypesgencore.messages contains functions to display status, error, or warning
messages to the user. Warning and error messages are also associated
with a "message class", which is a string, which currently has no effect.

Error classes are:
'usage' - there was something funny about the command-line parameters
'cparser' - there was a syntax error in the header file
'missing-library' - a library could not be loaded
'macro' - a macro could not be translated to Python
'unsupported-type' - there was a type in the header that ctypes cannot use, like
    "long double".
'other' - catchall.

Warning classes are:
'usage' - there was something funny about the command-line parameters
'rename' - a description has been renamed to avoid a name conflict
'other' - catchall.
"""

import sys

__all__ = ["error_message","warning_message","status_message"]

def error_message(msg,cls=None):
    print "Error: %s" % msg

def warning_message(msg,cls=None):
    print "Warning: %s" % msg

def status_message(msg):
    print "Status: %s" % msg
