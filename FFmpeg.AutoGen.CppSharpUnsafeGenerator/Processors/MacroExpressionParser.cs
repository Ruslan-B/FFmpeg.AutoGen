using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroExpressionParser
    {
        private static readonly Regex IdRegex = new Regex(@"^([\w]+)$", RegexOptions.Compiled);
        private static readonly Regex FuncRegex = new Regex(@"^([\w]+)\s?\((.*)\)$", RegexOptions.Compiled);
        private static readonly Regex GroupRegex = new Regex(@"^\((.+)\)$", RegexOptions.Compiled);
        private static readonly Regex BinaryRegex = new Regex(@"^(\w+)\s*(<<|>>|\+|\-|\*|\/|<|>|>=|<=)\s*(\w+)$", RegexOptions.Compiled);

        private static readonly Regex DoubleRegex = new Regex(@"^-?\s*\d\.\d+$", RegexOptions.Compiled);
        private static readonly Regex IntHexRegex = new Regex(@"^(-?)\s*0x([0-9a-fA-F]+)$", RegexOptions.Compiled);
        private static readonly Regex IntDecimalRegex = new Regex(@"^(-?\d+)([uU]|[lL])?$", RegexOptions.Compiled);
        private readonly Dictionary<string, Tuple<Expression, string>> _macroMap;

        public MacroExpressionParser(Dictionary<string, string> macroMap)
        {
            _macroMap = macroMap.ToDictionary(x => x.Key, x => new Tuple<Expression, string>(null, x.Value));
        }

        public bool TryParse(string expression, out Expression result)
        {
            if (TryParseGroup(expression, out result)) return true;
            if (TryParseDouble(expression, out result)) return true;
            if (TryParseInt(expression, out result)) return true;
            if (TryParseBinary(expression, out result)) return true;
            return false;
        }

        private bool TryParseGroup(string expression, out Expression result)
        {
            result = null;
            var match = GroupRegex.Match(expression);
            if (!match.Success) return false;

            var g = match.Groups[1].Value;
            if (TryParse(g, out result)) return true;
            return false;
        }

        private bool TryParseBinary(string expression, out Expression result)
        {
            result = null;
            var match = BinaryRegex.Match(expression);
            if (!match.Success) return false;

            var l = match.Groups[1].Value;
            var o = match.Groups[2].Value;
            var r = match.Groups[3].Value;
            Expression left;
            Expression right;
            if (!TryParse(l, out left) || !TryParse(r, out right)) return false;
            result = new Expression.Binary { Operator = o, Left = left, Right = right, Value = expression };
            switch (o)
            {
                case "<<":
                case ">>":
                    {

                        result.ValueTypeName = left.ValueTypeName;
                        return true;
                    }
                case ">":
                case "<":
                case ">=":
                case "<=":
                    result.ValueTypeName = "bool";
                    return true;
            }
            return false;
        }

        private bool TryParseDouble(string expression, out Expression result)
        {
            result = null;
            var match = DoubleRegex.Match(expression);
            if (!match.Success) return false;

            var value = match.Groups[0].Value;

            float @float;
            if (float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @float))
            {
                result = new Expression.Constant { Value = $"{value}f", ValueTypeName = "float" };
                return true;
            }

            double @double;
            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @double))
            {
                result = new Expression.Constant { Value = expression, ValueTypeName = "double" };
                return true;
            }

            return false;
        }

        private bool TryParseInt(string expression, out Expression result)
        {
            result = null;
            var matchHex = IntHexRegex.Match(expression);
            if (matchHex.Success)
            {
                var sign = matchHex.Groups[1].Value == "-" ? -1 : 1;
                var value = matchHex.Groups[2].Value;

                int @int;
                if (int.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @int) && sign * @int != int.MinValue)
                {
                    result = sign == 1
                        ? new Expression.Constant { Value = expression, ValueTypeName = "int" }
                        : new Expression.Constant { Value = expression, ValueTypeName = "long" };
                    return true;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @long))
                {
                    result = new Expression.Constant { Value = expression, ValueTypeName = "long" };
                    return true;
                }
            }
            else
            {
                var matchDecimal = IntDecimalRegex.Match(expression);
                if (!matchDecimal.Success) return false;

                var value = matchDecimal.Groups[1].Value;
                var sign = string.Equals(matchDecimal.Groups[2].Value, "U", StringComparison.InvariantCultureIgnoreCase) ? "u" : string.Empty;

                int @int;
                if (int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @int) && @int != int.MinValue)
                {
                    result = new Expression.Constant { Value = expression, ValueTypeName = sign + "int" };
                    return true;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @long))
                {
                    result = new Expression.Constant { Value = expression, ValueTypeName = sign + "long" };
                    return true;
                }
            }
            return false;
        }
    }
}