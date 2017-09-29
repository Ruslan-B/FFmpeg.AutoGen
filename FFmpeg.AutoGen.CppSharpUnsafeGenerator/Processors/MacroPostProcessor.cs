using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.ObjectModel;
using System.Globalization;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroPostProcessor
    {
        private static readonly Regex EolEscapeRegex = new Regex(@"\\\s*[\r\n|\r|\n]\s*", RegexOptions.Compiled | RegexOptions.Multiline);
        private static readonly Collection<string> constantOperators = new Collection<string>()
        {
            "<<",
            "*",
            "+",
            "-",
            "/",
            "|",
            "&"
        };

        private MacroExpressionParser _parser;

        public void Process(IReadOnlyList<MacroDefinition> macros)
        {
            foreach (var macro in macros) macro.Expression = CleanUp(macro.Expression);

            var macroMap = macros.ToDictionary(x => x.Name, x => x.Expression);
            _parser = new MacroExpressionParser(macroMap);
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
            Expression expression;
            if (!_parser.TryParse(macro.Expression, out expression)) return;

            macro.TypeName = expression.TypeName;
            macro.IsValid = true;
            macro.Expression = expression.Value.ToString();

            if (expression is Expression.Constant)
            {
                int value;
                macro.IsConstant = int.TryParse(expression.Value as string,  out value)
                    || int.TryParse(expression.Value as string, NumberStyles.HexNumber | NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out value);
            }
            else if(expression is Expression.Binary)
            {
                int left;
                int right;

                var binaryExpression = (Expression.Binary)expression;
                macro.IsConstant =
                    binaryExpression.Left is Expression.Constant && binaryExpression.Right is Expression.Constant
                    && (int.TryParse(binaryExpression.Left.Value as string, out left) || int.TryParse(binaryExpression.Left.Value as string, NumberStyles.HexNumber | NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out left))
                    && (int.TryParse(binaryExpression.Right.Value as string, out right) || int.TryParse(binaryExpression.Right.Value as string, NumberStyles.HexNumber | NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out right))
                    && constantOperators.Contains(binaryExpression.Operator);
            }
        }
    }
}