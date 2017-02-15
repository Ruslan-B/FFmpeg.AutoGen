using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroPostProcessor
    {
        private static readonly Regex EolEscapeRegex = new Regex(@"\\\s*[\r\n|\r|\n]\s*", RegexOptions.Compiled | RegexOptions.Multiline);


        private Dictionary<string, MacroDefinition> _macroMap;

        public void Process(IReadOnlyList<MacroDefinition> macros)
        {
            _macroMap = macros.ToDictionary(x => x.Name);
            foreach (var macro in macros) macro.Expression = CleanUp(macro.Expression);
            foreach (var macro in macros) Evaluate(macro);
        }

        private static string CleanUp(string expression)
        {
            var oneline = EolEscapeRegex.Replace(expression, string.Empty);
            var trimmed = oneline.Trim();
            return trimmed;
        }

        private void Evaluate(MacroDefinition macro)
        {
            if (macro.IsEvaluated) return;


            var e = MacroExpression.Parse(macro.Expression);
            if (e == null) return;

            if (!string.IsNullOrWhiteSpace(e.ValueTypeName))
            {
                macro.TypeName = e.ValueTypeName;
                macro.IsValid = true;
                macro.Expression = e.Value.ToString();
            }
        }
    }
}