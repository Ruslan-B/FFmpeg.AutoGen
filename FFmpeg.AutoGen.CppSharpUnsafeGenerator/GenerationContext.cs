using System.Collections.Generic;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class GenerationContext
    {
        private readonly List<ICanGenerateDefinition> _units = new List<ICanGenerateDefinition>();

        public HashSet<string> KnownUnitName = new HashSet<string>();
        public Dictionary<string, FunctionExport> FunctionExportMap { get; set; }
        public IReadOnlyList<ICanGenerateDefinition> Units => _units;

        public void AddUnit(ICanGenerateDefinition definition)
        {
            var definitionName = definition.Name;
            if (KnownUnitName.Contains(definitionName)) return;
            KnownUnitName.Add(definitionName);
            _units.Add(definition);
        }

        public void ClearUnits() => _units.Clear();
    }
}