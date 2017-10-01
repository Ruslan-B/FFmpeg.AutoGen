using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using MacroDefinition = FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions.MacroDefinition;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class ASTProcessor
    {
        private readonly List<IDefinition> _units;

        public ASTProcessor()
        {
            _units = new List<IDefinition>();
            IgnoreUnitNames = new HashSet<string>();
            TypeAliases = new Dictionary<string, TypeOrAlias>();
            WellKnownMaros = new Dictionary<string, TypeOrAlias>();
            FunctionProcessor = new FunctionProcessor(this);
            StructureProcessor = new StructureProcessor(this);
            EnumerationProcessor = new EnumerationProcessor(this);
            MacroProcessor = new MacroProcessor(this);
            MacroPostProcessor = new MacroPostProcessor(this);
        }

        public HashSet<string> IgnoreUnitNames { get; }
        public Dictionary<string, TypeOrAlias> TypeAliases { get; }
        public Dictionary<string, TypeOrAlias> WellKnownMaros { get; }
        public MacroProcessor MacroProcessor { get; }
        public EnumerationProcessor EnumerationProcessor { get; }
        public StructureProcessor StructureProcessor { get; }
        public FunctionProcessor FunctionProcessor { get; }
        public MacroPostProcessor MacroPostProcessor { get; }

        public Dictionary<string, FunctionExport> FunctionExportMap { get; set; }
        public IReadOnlyList<IDefinition> Units => _units;

        public bool IsKnownUnitName(string name)
        {
            return _units.Any(x => x.Name == name);
        }

        public T GetUnitByName<T>(string name) where T : IDefinition
        {
            return _units.OfType<T>().FirstOrDefault(x => x.Name == name);
        }

        public void AddUnit(IDefinition definition)
        {
            if (IgnoreUnitNames.Contains(definition.Name)) return;
            var existing = _units.FirstOrDefault(x => x.Name == definition.Name);
            if (existing != null)
                _units.Remove(existing);
            _units.Add(definition);
        }

        public void ClearUnits()
        {
            _units.Clear();
        }

        public void Generate()
        {
        }

        public void Process(IEnumerable<TranslationUnit> units)
        {
            foreach (var translationUnit in units)
            {
                MacroProcessor.Process(translationUnit);
                EnumerationProcessor.Process(translationUnit);
                StructureProcessor.Process(translationUnit);
                FunctionProcessor.Process(translationUnit);
            }

            var macros = Units.OfType<MacroDefinition>().ToArray();
            MacroPostProcessor.Process(macros);
        }
    }
}