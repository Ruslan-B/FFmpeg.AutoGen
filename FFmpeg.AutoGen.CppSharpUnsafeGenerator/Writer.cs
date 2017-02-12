using System;
using System.CodeDom.Compiler;
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
            var entryPoint = "todo";
            string library = "todo";
            WriteLine($"[DllImport({library}, EntryPoint = \"{entryPoint}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            WriteLine($"public static extern {function.ReturnTypeName} {function.Name}();");
        }
        
        private void WriteSummary(ICanGenerateSummary value)
        {
            if (!string.IsNullOrWhiteSpace(value.Summary)) WriteLine($"/// <summary> {value.Summary} </summary>");
        }
        
        private void WriteLine(string line) => _writer.WriteLine(line);
        private IDisposable BeginBlock() => _writer.BeginBlock();
    }
}