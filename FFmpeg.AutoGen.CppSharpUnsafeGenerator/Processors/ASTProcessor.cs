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
            WellKnownMacros = new Dictionary<string, TypeOrAlias>();
            FunctionProcessor = new FunctionProcessor(this);
            StructureProcessor = new StructureProcessor(this);
            EnumerationProcessor = new EnumerationProcessor(this);
            MacroProcessor = new MacroProcessor(this);
            MacroPostProcessor = new MacroPostProcessor(this);
        }

        public HashSet<string> IgnoreUnitNames { get; }
        public Dictionary<string, TypeOrAlias> TypeAliases { get; }
        public Dictionary<string, TypeOrAlias> WellKnownMacros { get; }
        public MacroProcessor MacroProcessor { get; }
        public EnumerationProcessor EnumerationProcessor { get; }
        public StructureProcessor StructureProcessor { get; }
        public FunctionProcessor FunctionProcessor { get; }
        public MacroPostProcessor MacroPostProcessor { get; }

        public Dictionary<string, FunctionExport> FunctionExportMap { get; init; }
        public IReadOnlyList<IDefinition> Units => _units;

        public bool IsKnownUnitName(string name)
        {
            return _units.Any(x => x.Name == name);
        }

        public void AddUnit(IDefinition definition)
        {
            if (IgnoreUnitNames.Contains(definition.Name)) return;

            switch (definition)
            {
                // for
                case FunctionDefinitionBase df:
                {
                    // check for existing functions with same parameters
                    // we care about the parameters, as we want to allow functions with same name but different parameters (overloads)
                    var existing = _units.Where(v => v is FunctionDefinitionBase vf
                                                     && v.Name == definition.Name
                                                     && vf.Parameters.SequenceEqual(df.Parameters)).ToList();

                    foreach (var d in existing)
                    {
                        _units.Remove(d);
                    }

                    break;
                }
                default:
                {
                    // don't allow adding if existing definition with same name
                    var existing = _units.FirstOrDefault(x => x.Name == definition.Name);
                    if (existing != null)
                        _units.Remove(existing);
                    break;
                }
            }
            _units.Add(definition);
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