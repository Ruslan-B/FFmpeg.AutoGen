using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal abstract class MacroExpression
    {
        private static readonly Regex IdRegex = new Regex(@"([a-zA-z]+)$", RegexOptions.Compiled);
        private static readonly Regex GroupRegex = new Regex(@"(\(.+\))$", RegexOptions.Compiled);

        private static readonly Regex ShifLeftRegex = new Regex(@"<<$", RegexOptions.Compiled);
        private static readonly Regex ShifRightRegex = new Regex(@">>$", RegexOptions.Compiled);
        private static readonly Regex MulRegex = new Regex(@"\*$", RegexOptions.Compiled);
        private static readonly Regex DivRegex = new Regex(@"\/$", RegexOptions.Compiled);
        private static readonly Regex SumRegex = new Regex(@"\+$", RegexOptions.Compiled);
        private static readonly Regex SubRegex = new Regex(@"\-$", RegexOptions.Compiled);
        private static readonly Regex GtRegex = new Regex(@">$", RegexOptions.Compiled);
        private static readonly Regex LsRegex = new Regex(@"<$", RegexOptions.Compiled);

        internal static readonly Func<string, Expression>[] Expressions =
        {
            s => new Hex(s),
            s => new Double(s),
            s => new Int(s)
        };

        public static Expression Parse(string expression)
        {
            Expression result = null;
            foreach (var e in Expressions)
                {
                    result = e(expression);
                    if (!result.IsValid) continue;
                    return result;
                }
            return null;
        }

        internal class Expression
        {
            public object Value { get; protected set; }
            public string ValueTypeName { get; protected set; }
            public bool IsValid { get; protected set; }
        }

        internal class Double : Expression
        {
            private static readonly Regex Regex = new Regex(@"^-?0.\d+$", RegexOptions.Compiled);

            public Double(string expression)
            {
                var match = Regex.Match(expression);
                IsValid = match.Success;
                if (!IsValid) return;

                var value = match.Groups[0].Value;

                float @float;
                if (float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @float))
                {
                    Value = $"{value}f";
                    ValueTypeName = "float";
                    return;
                }

                double @double;
                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @double))
                {
                    Value = @double;
                    ValueTypeName = "double";
                }
            }
        }

        public class Hex : Expression
        {
            private static readonly Regex Regex = new Regex(@"^0x(\d+)$", RegexOptions.Compiled);

            public Hex(string expression)
            {
                var match = Regex.Match(expression);
                IsValid = match.Success;
                if (!IsValid) return;

                var value = match.Groups[1].Value;

                int @int;
                if (int.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @int))
                {
                    Value = @int;
                    ValueTypeName = "int";
                    return;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out @long))
                {
                    Value = @long;
                    ValueTypeName = "long";
                }
            }
        }

        internal class Int : Expression
        {
            private static readonly Regex Regex = new Regex(@"^-?\d+$", RegexOptions.Compiled);

            public Int(string expression)
            {
                var match = Regex.Match(expression);
                IsValid = match.Success;
                if (!IsValid) return;

                var value = match.Groups[0].Value;

                int @int;
                if (int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @int))
                {
                    Value = @int;
                    ValueTypeName = "int";
                    return;
                }

                long @long;
                if (long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out @long))
                {
                    Value = @long;
                    ValueTypeName = "long";
                }
            }
        }
    }
}