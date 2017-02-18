using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using MacroDefinition = FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions.MacroDefinition;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class ASTProcessor
    {
        private static readonly string[] IgnoreUnits = {"__NSConstantString_tag"};
        private readonly List<ICanGenerateDefinition> _units = new List<ICanGenerateDefinition>();
        public HashSet<string> KnownUnitName = new HashSet<string>(IgnoreUnits);

        public ASTProcessor()
        {
            FunctionProcessor = new FunctionProcessor(this);
            StructureProcessor = new StructureProcessor(this);
            EnumerationProcessor = new EnumerationProcessor(this);
            MacroProcessor = new MacroProcessor(this);
            MacroPostProcessor = new MacroPostProcessor();
        }

        public MacroProcessor MacroProcessor { get; }
        public EnumerationProcessor EnumerationProcessor { get; }
        public StructureProcessor StructureProcessor { get; }
        public FunctionProcessor FunctionProcessor { get; }
        public MacroPostProcessor MacroPostProcessor { get; }

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