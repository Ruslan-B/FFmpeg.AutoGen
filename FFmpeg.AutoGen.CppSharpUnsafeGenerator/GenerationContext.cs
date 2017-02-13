using System.Collections.Generic;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class GenerationContext
    {
        public List<ICanGenerateDefinition> Units { get; } = new List<ICanGenerateDefinition>();
        public Dictionary<string, FunctionExport> FunctionExportMap { get; set; }
    }
}