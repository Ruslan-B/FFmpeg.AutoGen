using System;
using System.CodeDom.Compiler;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Writers;

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

                    if (item.IsFixed)
                        WriteLine($"public fixed {item.TypeName} @{item.Name}[{item.FixedSize}];");
                    else
                        WriteLine($"public {item.TypeName} @{item.Name};");
                }
        }

        public void Write(FunctionDefinition function)
        {
            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteLine($"[DllImport(\"{function.LibraryName}\", EntryPoint = \"{function.Name}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var @params = string.Join(", ", function.Parameters.Select(x =>
                x.Type.Attributes.Any()
                    ? $"{string.Join("", x.Type.Attributes)} {x.Type.Name} @{x.Name}"
                    : $"{x.Type.Name} @{x.Name}"));
            WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({@params});");
        }

        private void WriteSummary(ICanGenerateXmlDoc value)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <summary>{value.Content.Trim()}</summary>");
        }

        private void WriteParam(ICanGenerateXmlDoc value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <param name=\"{name}\">{value.Content.Trim()}</param>");
        }

        private void WriteLine(string line) => _writer.WriteLine(line);
        private IDisposable BeginBlock() => _writer.BeginBlock();
    }
}