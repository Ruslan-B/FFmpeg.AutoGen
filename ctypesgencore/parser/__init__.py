#!/usr/bin/env python

"""
This package parses C header files and generates lists of functions, typedefs,
variables, structs, unions, enums, macros, and constants. This package knows
nothing about the libraries themselves.

The public interface for this package is the function "parse". Use as follows:
>>> descriptions = parse(["inputfile1.h","inputfile2.h"], options)
where "options" is an optparse.Values object.

parse() returns a DescriptionCollection object. See ctypesgencore.descriptions
for more information.

"""

from datacollectingparser import DataCollectingParser

def parse(headers, options):
    parser=DataCollectingParser(headers, options)
    parser.parse()
    return parser.data()

__all__ = ["parse"]
