using System.Linq;
using CppSharp.AST;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroProcessor
    {
        private readonly GenerationContext _context;

        public MacroProcessor(GenerationContext context)
        {
            _context = context;
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var macro in translationUnit.PreprocessedEntities.OfType<MacroDefinition>().Where(x => !string.IsNullOrWhiteSpace(x.Expression)))
            {
                var macroDefinition = new Definitions.MacroDefinition
                {
                    Name = macro.Name,
                    Expression = macro.Expression
                };
                _context.AddUnit(macroDefinition);
            }
        }
    }
}