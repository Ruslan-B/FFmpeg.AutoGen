using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Security;
using System.Text;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Writer
    {
        private readonly IndentedTextWriter _writer;

        public Writer(IndentedTextWriter writer) => _writer = writer;

        public bool SuppressUnmanagedCodeSecurity { get; set; }

        public void WriteMacro(MacroDefinition macro)
        {
            if (macro.IsValid)
            {
                WriteSummary(macro);
                var constOrStatic = macro.IsConst ? "const" : "static";
                WriteLine($"public {constOrStatic} {macro.TypeName} {macro.Name} = {macro.Expression};");
            }
            else
                WriteLine($"// public static {macro.Name} = {macro.Expression};");
        }

        public void WriteEnumeration(EnumerationDefinition enumeration)
        {
            WriteSummary(enumeration);
            WriteLine($"public enum {enumeration.Name} : {enumeration.TypeName}");
            using (BeginBlock())
                foreach (var item in enumeration.Items)
                {
                    WriteSummary(item);
                    WriteLine($"@{item.Name} = {item.Value},");
                }
        }

        public void WriteStructure(StructureDefinition structure)
        {
            WriteSummary(structure);
            WriteLine($"public unsafe struct {structure.Name}");
            using (BeginBlock())
                foreach (var item in structure.Fileds)
                {
                    WriteSummary(item);
                    WriteLine($"public {item.FieldType.Name} @{item.Name};");
                }
        }

        public void WriteFixedArray(FixedArrayDefinition array)
        {
            WriteLine($"public unsafe struct {array.Name}");
            using (BeginBlock())
            {
                var prefix = "_";
                var size = array.Size;
                var elementType = array.ElementType.Name;

                WriteLine($"public static readonly int Size = {size};");

                if (array.IsPrimitive) WritePrimitiveFixedArray(array.Name, elementType, size, prefix);
                else WriteComplexFixedArray(elementType, size, prefix);

                WriteLine($"public static implicit operator {elementType}[]({array.Name} @struct) => @struct.ToArray();");
            }
        }

        public void WriteFunction(ExportFunctionDefinition function)
        {
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameterNames = GetParameterNames(function.Parameters);
            var parameters = GetParameters(function.Parameters);
            var functionPtrName = function.Name + "_fptr";
            var functionDelegateName = function.Name + "_delegate";
            var returnCommand = function.ReturnType.Name == "void" ? string.Empty : "return ";

            if (SuppressUnmanagedCodeSecurity) WriteLine("[SuppressUnmanagedCodeSecurity]");
            WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            WriteLine($"private delegate {function.ReturnType.Name} {functionDelegateName}({parameters});");
            Write($"private static {functionDelegateName} {functionPtrName} = ");
            WriteDefaultFunctionDelegateExpression(function, parameterNames, functionDelegateName, functionPtrName, returnCommand);
            WriteLine(";");

            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteReturnComment(function.ReturnComment);

            if (function.IsObsolete) WriteLine($"[Obsolete(\"{function.ObsoleteMessage}\")]");
            WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");
            using (BeginBlock()) WriteLine($"{returnCommand}{functionPtrName}({parameterNames});");
            WriteLine();
        }

        public void WriteFunction(InlineFunctionDefinition function)
        {
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameters = GetParameters(function.Parameters);

            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteReturnComment(function.ReturnComment);

            if (function.IsObsolete) WriteLine($"[Obsolete(\"{function.ObsoleteMessage}\")]");
            WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");
            var lines = function.Body.Split(new [] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines.ForEach(WriteLine);
            WriteLine($"// original body hash: {function.Sha256}");
            WriteLine();
        }


        private void WriteDefaultFunctionDelegateExpression(ExportFunctionDefinition function,
            string parameterNames, string functionDelegateName, string functionPtrName, string returnCommand)
        {
            var delegateParameters = GetParameters(function.Parameters, false);

            WriteLine($"({delegateParameters}) =>");
            using (BeginBlock(true))
            {
                var getOrLoadLibrary = $"GetOrLoadLibrary(\"{function.LibraryName}\")";
                var getDelegate = $"GetFunctionDelegate<{functionDelegateName}>({getOrLoadLibrary}, \"{function.Name}\")";

                WriteLine($"{functionPtrName} = {getDelegate};");
                WriteLine($"if ({functionPtrName} == null)");
                using (BeginBlock())
                {
                    Write($"{functionPtrName} = ");
                    WriteNotSupportedFunctionDelegateExpression(function);
                    WriteLine(";");
                }

                WriteLine($"{returnCommand}{functionPtrName}({parameterNames});");
            }
        }

        private void WriteNotSupportedFunctionDelegateExpression(ExportFunctionDefinition function)
        {
            WriteLine("delegate ");
            using (BeginBlock(true))
                WriteLine(
                    $"throw new PlatformNotSupportedException(\"{function.Name} is not supported on this platform.\");");
        }

        public void WriteDelegate(DelegateDefinition @delegate)
        {
            WriteSummary(@delegate);
            @delegate.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));

            var parameters = GetParameters(@delegate.Parameters);
            WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]");
            WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.FunctionName} ({parameters});");

            WriteLine($"public unsafe struct {@delegate.Name}");
            using (BeginBlock())
            {
                WriteLine("public IntPtr Pointer;");
                Write($"public static implicit operator {@delegate.Name}({@delegate.FunctionName} func) => ");
                Write($"new {@delegate.Name} {{ Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) }};");
                WriteLine();
            }
        }

        public void WriteLine()
        {
            _writer.WriteLine();
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
        }

        public IDisposable BeginBlock(bool inline = false)
        {
            WriteLine("{");
            _writer.Indent++;
            return new End(() =>
            {
                _writer.Indent--;

                if (inline)
                    _writer.Write("}");
                else
                    _writer.WriteLine("}");
            });
        }

        private void WritePrimitiveFixedArray(string arrayName, string elementType, int size, string prefix)
        {
            WriteLine($"fixed {elementType} {prefix}[{size}];");
            WriteLine();

            var @fixed = $"fixed ({arrayName}* p = &this)";

            WriteLine($"public {elementType} this[uint i]");
            using (BeginBlock())
            {
                WriteLine($"get {{ if (i >= Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ return p->{prefix}[i]; }} }}");
                WriteLine($"set {{ if (i >= Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ p->{prefix}[i] = value; }} }}");
            }

            WriteLine($"public {elementType}[] ToArray()");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ var a = new {elementType}[Size]; for (uint i = 0; i < Size; i++) a[i] = p->{prefix}[i]; return a; }}");

            WriteLine($"public void UpdateFrom({elementType}[] array)");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ uint i = 0; foreach(var value in array) {{ p->{prefix}[i++] = value; if (i >= Size) return; }} }}");
        }

        private void WriteComplexFixedArray(string elementType, int size, string prefix)
        {
            WriteLine(string.Join(" ", Enumerable.Range(0, size).Select(i => $"{elementType} {prefix}{i};")));
            WriteLine();

            var @fixed = $"fixed ({elementType}* p0 = &{prefix}0)";

            WriteLine($"public {elementType} this[uint i]");
            using (BeginBlock())
            {
                WriteLine($"get {{ if (i >= Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ return *(p0 + i); }} }}");
                WriteLine($"set {{ if (i >= Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ *(p0 + i) = value;  }} }}");
            }

            WriteLine($"public {elementType}[] ToArray()");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ var a = new {elementType}[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }}");

            WriteLine($"public void UpdateFrom({elementType}[] array)");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ uint i = 0; foreach(var value in array) {{ *(p0 + i++) = value; if (i >= Size) return; }} }}");
        }

        private static string GetParameters(FunctionParameter[] parameters, bool withAttributes = true)
        {
            return string.Join(", ", parameters.Select(x =>
            {
                var sb = new StringBuilder();
                if (withAttributes && x.Type.Attributes.Any()) sb.Append($"{string.Join("", x.Type.Attributes)} ");
                if (x.Type.ByReference) sb.Append("ref ");
                sb.Append($"{x.Type.Name} @{x.Name}");
                return sb.ToString();
            }));
        }

        private static string GetParameterNames(FunctionParameter[] parameters)
        {
            return string.Join(", ", parameters.Select(x =>
            {
                var sb = new StringBuilder();
                if (x.Type.ByReference) sb.Append("ref ");
                sb.Append($"@{x.Name}");
                return sb.ToString();
            }));
        }

        private void WriteSummary(ICanGenerateXmlDoc value)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <summary>{SecurityElement.Escape(value.Content.Trim())}</summary>");
        }

        private void WriteParam(ICanGenerateXmlDoc value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <param name=\"{name}\">{SecurityElement.Escape(value.Content.Trim())}</param>");
        }

        private void WriteReturnComment(string content)
        {
            if (!string.IsNullOrWhiteSpace(content)) WriteLine($"/// <returns>{SecurityElement.Escape(content.Trim())}</returns>");
        }

        private void Write(string value)
        {
            _writer.Write(value);
        }

        private class End : IDisposable
        {
            private readonly Action _action;

            public End(Action action) => _action = action;

            public void Dispose() => _action();
        }
    }
}