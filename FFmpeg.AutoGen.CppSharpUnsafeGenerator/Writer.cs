using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Security;
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
            {
                Func<StructureField, string> toString = x => x.FieldType.IsFixed
                    ? $"public fixed {x.FieldType.Name} @{x.Name}[{x.FieldType.FixedSize}];"
                    : $"public {x.FieldType.Name} @{x.Name};";

                var indexer = structure.Indexer;
                if (indexer == null)
                {
                    foreach (var item in structure.Fileds)
                    {
                        WriteSummary(item);
                        WriteLine(toString(item));
                    }
                }
                else
                {
                    var size = indexer.FieldType.FixedSize;
                    var prefix = indexer.FieldPrefix;
                    var typeName = indexer.FieldType.Name;

                    WriteLine(string.Join(" ", structure.Fileds.Select(toString)));
                    WriteLine();

                    WriteLine($"public static readonly int Size = {size};");

                    var @fixed = $"fixed ({typeName}* p0 = &{prefix}0)";
                    WriteLine($"public {typeName} this[uint index]");
                    using (BeginBlock())
                    {
                        WriteLine($"get {{ {@fixed} {{ if (index > Size) throw new ArgumentOutOfRangeException(); return *(p0 + index); }} }}");
                        WriteLine($"set {{ {@fixed} {{ if (index > Size) throw new ArgumentOutOfRangeException(); *(p0 + index) = value;  }} }}");
                    }

                    WriteLine($"public {typeName}[] ToArray()");
                    using (BeginBlock())
                    {
                        WriteLine($"{@fixed} {{ var array = new {typeName}[Size]; for (uint i = 0; i < Size; i++) array[i] = *(p0 + i); return array; }}");
                    }
                    WriteLine($"public void FromArray({typeName}[] array)");
                    using (BeginBlock())
                    {
                        WriteLine($"{@fixed} {{ uint i = 0; foreach(var value in array) {{ *(p0 + i++) = value; if (i >= Size) return; }} }}");
                    }
                    WriteLine($"public static implicit operator {typeName}[]({structure.Name} @struct) => @struct.ToArray();");
                }

                var @delegate = structure.Delegate;
                if (@delegate != null)
                {
                    WriteLine($"public IntPtr Pointer;");
                    Write($"public static implicit operator {structure.Name}({@delegate.Name} func) => ");
                    Write($"new {structure.Name} {{ Pointer = Marshal.GetFunctionPointerForDelegate(func) }};");
                    WriteLine();
                }
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
            WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.Name} ({parameters});");
        }

        private static string GetParameters(FunctionParameter[] parameters)
        {
            return string.Join(", ", parameters.Select(x =>
                x.Type.Attributes.Any()
                    ? $"{string.Join("", x.Type.Attributes)} {x.Type.Name} @{x.Name}"
                    : $"{x.Type.Name} @{x.Name}"));
        }

        private void WriteSummary(ICanGenerateXmlDoc value)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <summary>{SecurityElement.Escape(value.Content.Trim())}</summary>");
        }

        private void WriteParam(ICanGenerateXmlDoc value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <param name=\"{name}\">{SecurityElement.Escape(value.Content.Trim())}</param>");
        }

        private void WriteLine() => _writer.WriteLine();
        private void WriteLine(string line) => _writer.WriteLine(line);
        private void Write(string value) => _writer.Write(value);
        private IDisposable BeginBlock() => _writer.BeginBlock();
    }
}