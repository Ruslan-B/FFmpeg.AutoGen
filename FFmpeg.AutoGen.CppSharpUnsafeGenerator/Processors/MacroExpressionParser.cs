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
        private static readonly Regex BinaryRegex = new Regex(@"^(\s*\()?(\w+)\s*(<<|>>|\+|\-|\*|\/|<|>|>=|<=|\|)\s*(\w+)(\)\s*)?", RegexOptions.Compiled);
        private static readonly Regex DoubleRegex = new Regex(@"^-?\s*\d\.\d+$", RegexOptions.Compiled);
        private static readonly Regex IntHexRegex = new Regex(@"^(-?)\s*0x([0-9a-fA-F]+)(u|U)?([l|L]|[l|L][l|L])?$", RegexOptions.Compiled);
        private static readonly Regex IntDecimalRegex = new Regex(@"^(-?\d+)(u|U)?([l|L]|[l|L][l|L])?$", RegexOptions.Compiled);
        private readonly Dictionary<string, string> _macroMap;
        private readonly Dictionary<string, Expression> _expressionMap;

        public MacroExpressionParser(Dictionary<string, string> macroMap)
        {
            _macroMap = macroMap.ToDictionary(x => x.Key, x => x.Value);
            _expressionMap = new Dictionary<string, Expression>();
        }

        public bool TryParse(string expression, out Expression result)
        {
            if (_expressionMap.TryGetValue(expression, out result)) return true;

            if (FuncRegex.IsMatch(expression)) return false; // no support for fuctions

            if (TryParseInternal(expression, out result))
            {
                _expressionMap.Add(expression, result);
                return true;
            }
            return false;
        }

        private bool TryParseInternal(string expression, out Expression result)
        {
            if (TryParseDouble(expression, out result)) return true;
            if (TryParseInt(expression, out result)) return true;
            if (TryParseId(expression, out result)) return true;
            if (TryParseBinary(expression, out result)) return true;
            if (TryParseGroup(expression, out result)) return true;
            return false;
        }

        private bool TryParseBinary(string expression, out Expression result)
        {
            result = null;
            var match = BinaryRegex.Match(expression);
            if (!match.Success) return false;

            var leftExpression = match.Groups[2].Value;
            var @operator = match.Groups[3].Value;
            var rightExpression = match.Groups[4].Value;
            Expression left;
            Expression right;
            if (!TryParse(leftExpression, out left) || !TryParse(rightExpression, out right)) return false;

            string resultTypeName;
            switch (@operator)
            {
                case ">":
                case "<":
                case ">=":
                case "<=":
                    resultTypeName = "bool";
                    break;
                case "|":
                    if (left.TypeName != right.TypeName)
                        return false;
                    resultTypeName = left.TypeName;
                    break;
                default:
                    resultTypeName = left.TypeName;
                    break;
            }
            result = new Expression.Binary
            {
                Operator = @operator,
                Left = left,
                Right = right,
                Value = $"{left.Value} {@operator} {right.Value}",
                TypeName = resultTypeName
            };
            return true;
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
                result = new Expression.Constant {Value = $"{value}f", TypeName = "float"};
                return true;
            }

            double @double;
            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @double))
            {
                result = new Expression.Constant {Value = expression, TypeName = "double"};
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
                var minus = matchHex.Groups[1].Value == "-" ? -1 : 1;
                var value = matchHex.Groups[2].Value;
                var sign = matchHex.Groups[3].Value.ToLower();
                var type = matchHex.Groups[4].Value.ToLower();

                int @int;
                if (int.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @int) && minus * @int != int.MinValue)
                {
                    result = minus == 1
                        ? new Expression.Constant {Value = $"0x{value}", TypeName = sign + "int"}
                        : new Expression.Constant {Value = $"0x{value}", TypeName = sign + "long"};
                    return true;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @long))
                {
                    result = new Expression.Constant {Value = $"0x{value}", TypeName = sign + "long"};
                    return true;
                }

                decimal @decimal;
                if (decimal.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @decimal))
                {
                    result = new Expression.Constant {Value = $"0x{value}", TypeName = sign + "decimal"};
                    return true;
                }
            }
            else
            {
                var matchDecimal = IntDecimalRegex.Match(expression);
                if (!matchDecimal.Success) return false;

                var value = matchDecimal.Groups[1].Value;
                var sign = matchDecimal.Groups[2].Value.ToLower();
                var type = matchHex.Groups[4].Value.ToLower();

                int @int;
                if (int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @int) && @int != int.MinValue)
                {
                    result = new Expression.Constant {Value = expression, TypeName = sign + "int"};
                    return true;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @long))
                {
                    result = new Expression.Constant {Value = expression, TypeName = sign + "long"};
                    return true;
                }

                decimal @decimal;
                if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @decimal))
                {
                    result = new Expression.Constant {Value = expression, TypeName = sign + "decimal"};
                    return true;
                }
            }
            return false;
        }

        private bool TryParseId(string expression, out Expression result)
        {
            result = null;
            var match = IdRegex.Match(expression);
            if (!match.Success) return false;

            var value = match.Groups[0].Value;
            string macroExpression;
            Expression referenceExpression;
            if (!_macroMap.TryGetValue(value, out macroExpression) || !TryParse(macroExpression, out referenceExpression)) return false;
            result = new Expression.Constant {Value = expression, TypeName = referenceExpression.TypeName};
            return true;
        }

        private bool TryParseGroup(string expression, out Expression result)
        {
            result = null;

            var match = GroupRegex.Match(expression);
            if (!match.Success) return false;

            string g;
            do
            {
                g = match.Groups[1].Value;
                match = GroupRegex.Match(g);
            } while (match.Success);

            if (TryParse(g, out result))
            {
                result = new Expression.Group {Value = "(" + result.Value + ")", TypeName = result.TypeName};
                return true;
            }
            return false;
        }
    }
}