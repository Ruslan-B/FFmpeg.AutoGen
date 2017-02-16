using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroPostProcessor
    {
        private static readonly Regex EolEscapeRegex = new Regex(@"\\\s*[\r\n|\r|\n]\s*", RegexOptions.Compiled | RegexOptions.Multiline);


        private Dictionary<string, string> _macroMap;
        private MacroExpressionParser _parser;

        public void Process(IReadOnlyList<MacroDefinition> macros)
        {
            foreach (var macro in macros) macro.Expression = CleanUp(macro.Expression);

            _macroMap = macros.ToDictionary(x => x.Name, x => x.Expression);
            _parser = new MacroExpressionParser(_macroMap);
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

            macro.IsEvaluated = true;
            
            Expression expression;
            if (!_parser.TryParse(macro.Expression, out expression)) return;


            macro.TypeName = expression.ValueTypeName;
            macro.IsValid = true;
            macro.Expression = expression.Value.ToString();
        }
    }
}