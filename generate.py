import os
import ctypesgencore
import ctypesgencore.ctypedescs as ctypedescs


class DescriptionsEvaluationContext(ctypesgencore.expressions.EvaluationContext):
    def __init__(self, descriptions):
        self.descriptions = descriptions
        self.ids_map = dict((c.name, c) for c in descriptions.constants)

    def evaluate_identifier(self, name):
        if name in self.ids_map:
            expression = self.ids_map[name].value
            return expression.evaluate(self)
            #warnings.warn('Attempt to evaluate identifier "%s" failed' % name)
        return 0


class FileWriter:
    def __init__(self, filename):
        self.filename = filename
        self.indentation_level = 0

    def out(self, line=''):
        print >> self.f, ('\t' * self.indentation_level) + line

    def begin_block(self):
        self.out('{')
        self.indentation_level += 1

    def end_block(self):
        self.indentation_level -= 1
        self.out('}')

    def __enter__(self):
        self.f = file(self.filename, 'w')

    def __exit__(self, exc_type, exc_val, exc_tb):
        self.f.__exit__(exc_type, exc_val, exc_tb)


class GeneratorBase:
    name_conversions = {'base', 'internal', 'in', 'out', 'ref'}

    def escape_id_if_needed(self, name):
        if name in self.name_conversions:
            return '@' + name
        return name

    type_conversions = {'int8_t': 'sbyte', 'uint8_t': 'byte',
                        'int16_t': 'short', 'uint16_t': 'ushort',
                        'int32_t': 'int', 'uint32_t': 'uint',
                        'int64_t': 'long', 'uint64_t': 'ulong',
                        'float32_t': 'float',
                        'char': 'byte',
                        'intmax_t': 'long', 'uintmax_t': 'ulong',
                        'size_t': 'uint', 'SIZE_T': 'uint',
                        'va_list': 'void*',
                        'FILE': 'void'}

    def get_type_name(self, ctype):
        if isinstance(ctype, ctypedescs.CtypesPointer):
            dst_type = ctype.destination
            return '%s*' % self.get_type_name(dst_type)
        if isinstance(ctype, ctypedescs.CtypesSimple) or isinstance(ctype, ctypedescs.CtypesTypedef):
            if ctype.name in self.type_conversions:
                return self.type_conversions[ctype.name]
            else:
                return ctype.name
        if isinstance(ctype, ctypedescs.CtypesSpecial):
            return ctype.name
        if isinstance(ctype, ctypedescs.CtypesEnum):
            return ctype.tag
        if isinstance(ctype, ctypedescs.CtypesStruct):
            return ctype.tag
        if isinstance(ctype, ctypedescs.CtypesFunction):
            restype_name = self.get_type_name(ctype.restype)
            params = ', '.join(self.get_type_name(p) for p in ctype.argtypes)
            if restype_name == 'void':
                return "Action<%s>" % params
            else:
                return "Func<%s, %s>" % (params, restype_name)
        if isinstance(ctype, ctypedescs.CtypesArray):
            return "%s*" % self.get_type_name(ctype.base)
        else:
            return ctype.name

    def write_to(self, writer):
        pass


class LibraryGenerator(GeneratorBase):
    def __init__(self, name):
        self.id = self.escape_id_if_needed("%s_LIBRARY" % name.upper())
        self.name = name

    def write_to(self, writer):
        writer.out('public const string %s = "%s";' % (self.id, self.name))


class ConstGenerator(GeneratorBase):
    def __init__(self, name, value, comment=None):
        self.id = self.escape_id_if_needed(name)
        self.value = value
        self.comment = comment
        pass

    def write_to(self, writer):
        value = self.value
        if isinstance(value, int):
            if value < 0x80000000L:
                const_type = 'int'
            else:
                const_type = 'uint'
            value = hex(value)
        elif isinstance(value, long):
            if value < 0x8000000000000000L:
                const_type = 'long'
            else:
                const_type = 'ulong'
            value = hex(value)
        elif isinstance(value, float):
            const_type = 'float'
            value = "%ff" % value
        elif isinstance(value, basestring):
            const_type = 'string'
            value = '"' + value + '"'
        else:
            const_type = '<unknown>'

        if self.comment:
            writer.out('public const %s %s = %s; // %s' % (const_type, self.id, value, self.comment))
        else:
            writer.out('public const %s %s = %s;' % (const_type, self.id, value))


class MethodGenerator(GeneratorBase):
    def __init__(self, description, library):
        self.id = self.escape_id_if_needed(description.name)
        self.description = description
        self.library = library

    def write_to(self, writer):

        writer.out(
            '[DllImport(%s, EntryPoint="%s", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]'
            % (self.library.id, self.description.name))

        params = []
        i = 0
        for arg_type in self.description.argtypes:
            arg_name = self.description.argnames[i]
            arg_name = self.escape_id_if_needed(arg_name)

            if isinstance(arg_type, ctypedescs.CtypesFunction):
                p_type_name = "IntPtr"
            else:
                p_type_name = self.get_type_name(arg_type)

            params.append('%s %s' % (p_type_name, arg_name))
            i += 1

        r_type_name = self.get_type_name(self.description.restype)

        params_out = ', '.join(x for x in params)
        writer.out('public static extern %s %s(%s);' % (r_type_name, self.id, params_out))


class WrapperGenerator(GeneratorBase):
    def __init__(self, descriptions, options):
        self.descriptions = descriptions
        self.options = options
        self.typedefs_map = dict((td.name, td) for td in descriptions.typedefs)
        self.evaluation_context = DescriptionsEvaluationContext(self.descriptions)
        self.indentation_level = 0

    def type_was_included(self, ctype):
        source_path, line_number = ctype.src
        source_path = os.path.abspath(source_path).lower()
        for output_only_from_path in options.output_only_from_paths:
            output_only_from_path = os.path.abspath(output_only_from_path).lower()
            if source_path.startswith(output_only_from_path):
                return True
        return False

    def evaluate_expression(self, expression):
        if isinstance(expression, ctypesgencore.expressions.TypeCastExpressionNode):
            if isinstance(expression.base, ctypesgencore.expressions.CallExpressionNode):
                expression = expression.base.arguments[0]
        return expression.evaluate(self.evaluation_context)

    def write_enum(self, enum_name, enum_type, writer):
        writer.out('public enum %s' % self.escape_id_if_needed(enum_name))
        writer.begin_block()

        last_value = -1
        for item in enum_type.enumerators:
            name, expression = item
            name = self.escape_id_if_needed(name)
            value = self.evaluate_expression(expression)
            if value == (last_value + 1):
                writer.out('%s,' % name)
            else:
                writer.out('%s = %s, // %s' % (name, hex(value), expression.py_string(False)))
            last_value = value

        writer.end_block()
        writer.out()

    def write_struct(self, struct_name, struct, writer):
        writer.out('[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]')
        writer.out('public unsafe struct %s' % struct_name)
        writer.begin_block()

        bit_field = None
        bit_field_count = 0
        bit_field_shift = 0
        if struct.members:
            for member in struct.members:
                name, ctype = member
                name = self.escape_id_if_needed(name)
                if isinstance(ctype, ctypedescs.CtypesFunction):
                    writer.out('public IntPtr %s; // %s' % (name, self.get_type_name(ctype)))
                    continue
                if isinstance(ctype, ctypedescs.CtypesBitfield):
                    size = self.evaluate_expression(ctype.bitfield)
                    ctype_name = ctype.base.name

                    if not bit_field:
                        bit_field = '_bitfield0x%0.2X;' % bit_field_count
                        writer.out('public uint %s' % bit_field)
                        bit_field_count += 1

                    bit_field_shift += size
                    if bit_field_shift > 32:
                        raise Exception('Bit field allocation size error.', name)
                    elif bit_field_shift == 32:
                        bit_field = None
                        bit_field_shift = 0

                    writer.out('//bit field %s %s:%d' % (name, ctype_name, size))
                    continue
                    # review
                if isinstance(ctype, ctypedescs.CtypesArray):
                    if ctype.count:
                        size = self.evaluate_expression(ctype.count)
                        base_type = ctype.base
                        if isinstance(base_type, ctypedescs.CtypesPointer) or isinstance(base_type,
                                                                                         ctypedescs.CtypesStruct):
                            # unfold fixed pointer array or structure array to set of indexed fields
                            ctype_name = self.get_type_name(base_type)
                            writer.out('// fixed %s %s[%d] - %s' % (ctype_name, name, size, ctype))
                            for i in range(size):
                                writer.out('public %s %s_%d;' % (ctype_name, name, i))
                            continue
                        else:
                            while isinstance(base_type, ctypedescs.CtypesArray) and base_type.count:
                                size *= self.evaluate_expression(ctype.base.count)
                                base_type = base_type.base
                            ctype_name = self.get_type_name(base_type)

                            #if isinstance(base_type, ctypedescs.CtypesTypedef):
                            #    if base_type.name in self.typedefs_map:
                            #        typedef = self.typedefs_map[base_type.name]
                            #        base_type = typedef.ctype

                        #if isinstance(base_type, ctypedescs.CtypesStruct):
                        #    self.out('[MarshalAs(UnmanagedType.ByValArray, SizeConst = %d)]' % size)
                        #    self.out('public %s[] %s; // %s' % (ctype_name, name, ctype))
                        #else:
                        writer.out('public fixed %s %s[%d]; // %s' % (ctype_name, name, size, ctype))

                        continue
                    else:
                        ctype_name = self.get_type_name(ctype)
                else:
                    ctype_name = self.get_type_name(ctype)

                if ctype_name == 'String':
                    ctype_name = 'byte*'

                writer.out('public %s %s;' % (ctype_name, name))

        writer.end_block()
        writer.out()

    def get_typedef(self, ctype):
        for typedef in self.descriptions.typedefs:
            if typedef.ctype is ctype:
                return typedef
        return None

    def write_to(self, writer):
        writer.out('using System;')
        writer.out('using System.Runtime.InteropServices;')
        writer.out()
        writer.out('namespace %s' % self.options.namespace)
        writer.begin_block()

        # aliases
        for typedef in self.descriptions.typedefs:
            if self.type_was_included(typedef):
                if isinstance(typedef.ctype, ctypedescs.CtypesEnum) or \
                        isinstance(typedef.ctype, ctypedescs.CtypesStruct):
                    type_name = typedef.ctype.tag
                else:
                    # ignore rest
                    continue

                if typedef.name != type_name:
                    writer.out('using %s=%s;' % (typedef.name, type_name))

        writer.out()

        # form functions and libraries list
        methods = []
        libraries_map = {}
        for description in self.descriptions.functions:
            if description.source_library is not None and self.type_was_included(description):
                library_name = description.source_library

                if library_name in libraries_map:
                    library = libraries_map[library_name]
                else:
                    library = LibraryGenerator(library_name)
                    libraries_map[library.name] = library

                method = MethodGenerator(description, library)
                methods.append(method)

        libraries = libraries_map.values()

        constants = []
        for macros in descriptions.macros:
            if macros.expr and self.type_was_included(macros):
                try:
                    value = self.evaluate_expression(macros.expr)
                    comment = macros.expr.py_string(False)
                    if str(value) == comment:
                        comment = None
                    constant = ConstGenerator(macros.name, value, comment)
                    constants.append(constant)
                except (TypeError, ZeroDivisionError, AttributeError, ValueError):
                    print "Warning: Could not evaluate macro:", macros.name

        for enum in self.descriptions.enums:
            if self.type_was_included(enum):
                enum_name = self.escape_id_if_needed(enum.tag)
                self.write_enum(enum_name, enum.ctype, writer)

        for struct in self.descriptions.structs:
            if self.type_was_included(struct):
                struct_name = self.escape_id_if_needed(struct.tag)
                self.write_struct(struct_name, struct, writer)

        # generate empty structures for void typedefs
        for typedef in self.descriptions.typedefs:
            if self.type_was_included(typedef):
                if isinstance(typedef.ctype, ctypedescs.CtypesSimple) and typedef.ctype.name == 'void':
                    struct_name = self.escape_id_if_needed(typedef.name)
                    self.write_struct(struct_name, ctypedescs.CtypesStruct(struct_name, None, None), writer)

        writer.out('public static unsafe partial class %s' % self.options.class_name)
        writer.begin_block()

        for library in libraries:
            library.write_to(writer)
        writer.out()

        for constant in constants:
            constant.write_to(writer)
        writer.out()

        for method in methods:
            method.write_to(writer)

        writer.end_block()
        writer.end_block()


work_path = os.path.dirname(os.path.realpath(__file__))


class Options:
    headers = ['FFmpeg/include/libavcodec/avcodec.h',
               'FFmpeg/include/libavdevice/avdevice.h',
               'FFmpeg/include/libavfilter/avfilter.h',
               'FFmpeg/include/libavformat/avformat.h',
               'FFmpeg/include/libavutil/avutil.h',
               'FFmpeg/include/libpostproc/postprocess.h',
               'FFmpeg/include/libswresample/swresample.h',
               'FFmpeg/include/libswscale/swscale.h']
    other_headers = []
    cpp = 'gcc -E'
    include_search_paths = ['./FFmpeg/include']
    all_headers = True
    save_preprocessed_headers = False
    other_known_names = []
    builtin_symbols = False
    exclude_symbols = []
    include_symbols = []
    include_macros = True
    compile_libdirs = ['./']
    libraries = ['avutil', 'avcodec', 'avformat', 'swresample',
                 'swscale', 'postproc', 'avfilter', 'avdevice']
    show_all_errors = True
    show_long_errors = True
    show_macro_warnings = True
    # printer
    strip_build_path = []
    header_template = False
    runtime_libdirs = []
    modules = []
    inserted_files = []
    #printer
    namespace = 'FFmpeg.AutoGen'
    class_name = 'FFmpegInvoke'
    output_only_from_paths = ['./FFmpeg/include']


options = Options()
# Step 1: Parse
descriptions = ctypesgencore.parser.parse(options.headers, options)

# Step 2: Process
ctypesgencore.processor.process(descriptions, options)

# Step 3: Generate output

output_filename = './FFmpeg.AutoGen/FFmpegInvoke.cs'

writer = FileWriter(output_filename)
with writer:
    generator = WrapperGenerator(descriptions, options)
    generator.write_to(writer)

#ctypesgencore.printer.WrapperPrinter(options.output, options, descriptions)
