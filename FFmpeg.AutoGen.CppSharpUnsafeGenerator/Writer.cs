using System;
using System.CodeDom.Compiler;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Writers;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Writer
    {
        private readonly string _libraryConstantName;
        private readonly IndentedTextWriter _writer;

        public Writer(IndentedTextWriter writer, string libraryConstantName)
        {
            _writer = writer;
            _libraryConstantName = libraryConstantName;
        }

        public void Write(EnumerationDefinition enumeration)
        {
            WriteSummary(enumeration);
            WriteLine($"public enum {enumeration.Name} : {enumeration.TypeName}");
            using (BeginBlock())
            {
                foreach (var item in enumeration.Items)
                {
                    WriteSummary(item);
                    WriteLine($"@{item.Name} = {item.Value},");
                }
            }
        }

        public void Write(StructureDefinition structure)
        {
            WriteSummary(structure);
            WriteLine($"public unsafe struct {structure.Name}");
            using (BeginBlock())
            {
                foreach (var item in structure.Fileds)
                {
                    WriteSummary(item);

                    if (item.IsFixed)
                        WriteLine($"public fixed {item.TypeName} @{item.Name}[{item.FixedSize}];");
                    else
                        WriteLine($"public {item.TypeName} @{item.Name};");
                }
            }
        }

        public void Write(FunctionDefinition function)
        {
            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteLine($"[DllImport({_libraryConstantName}, EntryPoint = \"{function.Name}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            var @params = string.Join(", ", function.Parameters.Select(x => $"{x.TypeName} @{x.Name}"));
            WriteLine($"public static extern {function.ReturnTypeName} {function.Name}({@params});");
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