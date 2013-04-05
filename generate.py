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


class CSharpGenerator:
    name_conversions = {'base', 'internal', 'in', 'out', 'ref'}

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

    def __init__(self, descriptions, options):
        self.descriptions = descriptions
        self.options = options
        self.typedefs_map = dict((td.name, td) for td in descriptions.typedefs)
        self.evaluation_context = DescriptionsEvaluationContext(self.descriptions)
        self.indentation_level = 0

    def out(self, line=''):
        print >> self.f, ('\t' * self.indentation_level) + line

    def begin_block(self):
        self.out('{')
        self.indentation_level += 1

    def end_block(self):
        self.indentation_level -= 1
        self.out('}')

    def type_was_included(self, ctype):
        source_path, line_number = ctype.src
        if source_path in ['<built-in>', '<command-line>']:
            return False
        source_path = os.path.abspath(source_path).lower()
        for output_only_from_path in options.output_only_from_paths:
            output_only_from_path = os.path.abspath(output_only_from_path).lower()
            if source_path.startswith(output_only_from_path):
                return True
        return False

    def escape_id_if_needed(self, name):
        if name in self.name_conversions:
            return '@' + name
        return name

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

    def evaluate_expression(self, expression):
        if isinstance(expression, ctypesgencore.expressions.TypeCastExpressionNode):
            if isinstance(expression.base, ctypesgencore.expressions.CallExpressionNode):
                expression = expression.base.arguments[0]
        return expression.evaluate(self.evaluation_context)

    def write_macros(self, macros_name, macros):
        try:
            value = self.evaluate_expression(macros.expr)
        except (TypeError, ZeroDivisionError, AttributeError, ValueError):
            print "Warning: Could not evaluate macro:", macros_name
            return

        if isinstance(value, int):
            if value < 0x80000000L:
                macros_type = 'int'
            else:
                macros_type = 'uint'
            value = hex(value)
        elif isinstance(value, long):
            if value < 0x8000000000000000L:
                macros_type = 'long'
            else:
                macros_type = 'ulong'
            value = hex(value)
        elif isinstance(value, float):
            macros_type = 'float'
            value = "%ff" % value
        elif isinstance(value, basestring):
            macros_type = 'string'
            value = '"' + value + '"'
        else:
            macros_type = '<unknown>'

        raw = macros.expr.py_string(False)
        self.out('public const %s %s = %s; // %s' % (macros_type, macros_name, value, raw))
        self.out()

    def write_enum(self, enum_name, enum_type):
        self.out('public enum %s' % self.escape_id_if_needed(enum_name))
        self.begin_block()

        last_value = -1
        for item in enum_type.enumerators:
            name, expression = item
            name = self.escape_id_if_needed(name)
            value = self.evaluate_expression(expression)
            if value == (last_value + 1):
                self.out('%s,' % name)
            else:
                self.out('%s = %s, // %s' % (name, hex(value), expression.py_string(False)))
            last_value = value

        self.end_block()
        self.out()

    def write_struct(self, struct_name, struct):
        self.out('[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]')
        self.out('public struct %s' % struct_name)
        self.begin_block()

        bit_field = None
        bit_field_count = 0
        bit_field_shift = 0
        if struct.members:
            for member in struct.members:
                name, ctype = member
                name = self.escape_id_if_needed(name)
                if isinstance(ctype, ctypedescs.CtypesFunction):
                    self.out('public IntPtr %s; // %s' % (name, self.get_type_name(ctype)))
                    continue
                if isinstance(ctype, ctypedescs.CtypesBitfield):
                    size = self.evaluate_expression(ctype.bitfield)
                    ctype_name = ctype.base.name

                    if not bit_field:
                        bit_field = '_bitfield0x%0.2X;' % bit_field_count
                        self.out('public uint %s' % bit_field)
                        bit_field_count += 1

                    bit_field_shift += size
                    if bit_field_shift > 32:
                        raise Exception('Bit field allocation size error.', name)
                    elif bit_field_shift == 32:
                        bit_field = None
                        bit_field_shift = 0

                    self.out('//bit field %s %s:%d' % (name, ctype_name, size))
                    continue
                    # review
                if isinstance(ctype, ctypedescs.CtypesArray):
                    if ctype.count:
                        size = self.evaluate_expression(ctype.count)
                        base_type = ctype.base
                        if isinstance(base_type, ctypedescs.CtypesPointer) or isinstance(base_type, ctypedescs.CtypesStruct):
                            # unfold fixed pointer array or structure array to set of indexed fields
                            ctype_name = self.get_type_name(base_type)
                            self.out('// fixed %s %s[%d] - %s' % (ctype_name, name, size, ctype))
                            for i in range(size):
                                self.out('public %s %s_%d;' % (ctype_name, name, i))
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
                        self.out('public fixed %s %s[%d]; // %s' % (ctype_name, name, size, ctype))

                        continue
                    else:
                        ctype_name = self.get_type_name(ctype)
                else:
                    ctype_name = self.get_type_name(ctype)

                if ctype_name == 'String':
                    ctype_name = 'byte*'

                self.out('public %s %s;' % (ctype_name, name))

        self.end_block()
        self.out()

    def write_method(self, function_name, function):
        self.out(
            '[DllImport("%s", EntryPoint="%s", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]'
            % (function.source_library, function_name))

        params = []
        i = 0
        for arg_type in function.argtypes:
            arg_name = function.argnames[i]
            arg_name = self.escape_id_if_needed(arg_name)

            if isinstance(arg_type, ctypedescs.CtypesFunction):
                p_type_name = "IntPtr"
            else:
                p_type_name = self.get_type_name(arg_type)

            params.append('%s %s' % (p_type_name, arg_name))
            i += 1

        r_type_name = self.get_type_name(function.restype)

        params_out = ', '.join(x for x in params)
        self.out('public static extern %s %s(%s);' % (r_type_name, function.name, params_out))
        self.out()

    def get_typedef(self, ctype):
        for typedef in self.descriptions.typedefs:
            if typedef.ctype is ctype:
                return typedef
        return None

    def write_to_file(self, filename):
        self.f = file(filename, 'w')

        self.out('using System;')
        self.out('using System.Runtime.InteropServices;')
        self.out()
        self.out('namespace %s' % self.options.namespace)
        self.begin_block()

        for typedef in self.descriptions.typedefs:
            if self.type_was_included(typedef):
                if isinstance(typedef.ctype, ctypedescs.CtypesEnum) or \
                        isinstance(typedef.ctype, ctypedescs.CtypesStruct):
                    type_name = typedef.ctype.tag
                else:
                    # ignore rest
                    continue

                if typedef.name != type_name:
                    self.out('using %s=%s.%s;' % (typedef.name, self.options.class_name, type_name))

        self.out()
        self.out('public static unsafe class %s' % self.options.class_name)
        self.begin_block()

        for macros in descriptions.macros:
            if macros.expr and self.type_was_included(macros):
                macros_name = self.escape_id_if_needed(macros.name)
                self.write_macros(macros_name, macros)

        for enum in self.descriptions.enums:
            if self.type_was_included(enum):
                enum_name = self.escape_id_if_needed(enum.tag)
                self.write_enum(enum_name, enum.ctype)

        for struct in self.descriptions.structs:
            if self.type_was_included(struct):
                struct_name = self.escape_id_if_needed(struct.tag)
                self.write_struct(struct_name, struct)

        # generate empty structures for void typedefs
        for typedef in self.descriptions.typedefs:
            if self.type_was_included(typedef):
                if isinstance(typedef.ctype, ctypedescs.CtypesSimple) and typedef.ctype.name == 'void':
                    struct_name = self.escape_id_if_needed(typedef.name)
                    self.write_struct(struct_name, ctypedescs.CtypesStruct(struct_name, None, None))

        for function in self.descriptions.functions:
            if function.source_library is not None and self.type_was_included(function):
                function_name = self.escape_id_if_needed(function.name)
                self.write_method(function_name, function)

        self.end_block()
        self.end_block()


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
    compile_libdirs = ['./FFmpeg/bin']
    libraries = ['avutil-52', 'avcodec-55', 'avformat-55', 'swresample-0',
                 'swscale-2', 'postproc-52', 'avfilter-3', 'avdevice-55']
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
    class_name = 'FFmpegNative'
    output_only_from_paths = './FFmpeg/include'


options = Options()
# Step 1: Parse
descriptions = ctypesgencore.parser.parse(options.headers, options)

# Step 2: Process
ctypesgencore.processor.process(descriptions, options)

# Step 3: Generate output

csharp_generator = CSharpGenerator(descriptions, options)
csharp_filename = './FFmpeg.AutoGen/FFmpegNative.cs'
csharp_generator.write_to_file(csharp_filename)

#ctypesgencore.printer.WrapperPrinter(options.output, options, descriptions)
