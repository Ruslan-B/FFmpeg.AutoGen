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

        public Writer(IndentedTextWriter writer)
        {
            _writer = writer;
        }

        public void Write(MacroDefinition macro)
        {
            var valid = macro.IsValid ? string.Empty : "// ";
            WriteLine($"{valid}public static {macro.TypeName} {macro.Name} = {macro.Expression};");
        }

        public void Write(EnumerationDefinition enumeration)
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

        public void Write(StructureDefinition structure)
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

        public void Write(FixedArrayDefinition array)
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

        public void Write(FunctionDefinition function)
        {
            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            if (function.IsObsolete) WriteLine($"[Obsolete(\"{function.ObsoleteMessage}\")]");
            WriteLine($"[DllImport(\"{function.LibraryName}\", EntryPoint = \"{function.Name}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameters = GetParameters(function.Parameters);
            WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({parameters});");
        }

        public void Write(DelegateDefinition @delegate)
        {
            WriteSummary(@delegate);
            @delegate.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteSummary(@delegate);
            var parameters = GetParameters(@delegate.Parameters);
            WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]");
            WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.FunctionName} ({parameters});");

            WriteLine($"public unsafe struct {@delegate.Name}");
            using (BeginBlock())
            {
                WriteLine($"public IntPtr Pointer;");
                Write($"public static implicit operator {@delegate.Name}({@delegate.FunctionName} func) => ");
                Write($"new {@delegate.Name} {{ Pointer = Marshal.GetFunctionPointerForDelegate(func) }};");
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

        public IDisposable BeginBlock()
        {
            WriteLine("{");
            _writer.Indent++;
            return new End(() =>
            {
                _writer.Indent--;
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
                WriteLine($"get {{ if (i > Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ return p->{prefix}[i]; }} }}");
                WriteLine($"set {{ if (i > Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ p->{prefix}[i] = value; }} }}");
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
                WriteLine($"get {{ if (i > Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ return *(p0 + i); }} }}");
                WriteLine($"set {{ if (i > Size) throw new ArgumentOutOfRangeException(); {@fixed} {{ *(p0 + i) = value;  }} }}");
            }

            WriteLine($"public {elementType}[] ToArray()");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ var a = new {elementType}[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }}");

            WriteLine($"public void UpdateFrom({elementType}[] array)");
            using (BeginBlock())
                WriteLine($"{@fixed} {{ uint i = 0; foreach(var value in array) {{ *(p0 + i++) = value; if (i >= Size) return; }} }}");
        }

        private static string GetParameters(FunctionParameter[] parameters)
        {
            return string.Join(", ", parameters.Select(x =>
            {
                var sb = new StringBuilder();
                if (x.Type.Attributes.Any()) sb.Append($"{string.Join("", x.Type.Attributes)} ");
                if (x.Type.ByReference) sb.Append("ref ");
                sb.Append($"{x.Type.Name} @{x.Name}");
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

        private void Write(string value)
        {
            _writer.Write(value);
        }

        private class End : IDisposable
        {
            private readonly Action _action;

            public End(Action action)
            {
                _action = action;
            }

            public void Dispose()
            {
                _action();
            }
        }
    }
}