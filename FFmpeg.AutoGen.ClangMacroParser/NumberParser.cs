using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FFmpeg.AutoGen.ClangMacroParser
{
    public static class NumberParser
    {
        private static readonly HashSet<char> IntegerNumberEnd = new("ul");
        private static readonly HashSet<char> DecimalNumberEnd = new("fd");

        public static object Parse(string value)
        {
            var isHex = value.StartsWith("0x", StringComparison.InvariantCultureIgnoreCase);

            if (isHex)
            {
                value = value.Substring(2);
                return ParseInteger(value, NumberStyles.HexNumber);
            }

            var isFloat = value.Contains(".") || value.EndsWith("f", StringComparison.InvariantCultureIgnoreCase) ||
                          value.EndsWith("d", StringComparison.InvariantCultureIgnoreCase);

            return isFloat ? ParseDecimal(value) : ParseInteger(value, NumberStyles.Integer);
        }

        private static object ParseDecimal(string value)
        {
            var typeHint = GetDecimalTypeHint(value);

            value = new string(value.Where(x => !DecimalNumberEnd.Contains(char.ToLower(x))).ToArray());

            if (typeHint == typeof(float)) return float.Parse(value, CultureInfo.InvariantCulture);
            if (typeHint == typeof(double)) return double.Parse(value, CultureInfo.InvariantCulture);
            throw new NotSupportedException();
        }

        private static object ParseInteger(string value, NumberStyles numberStyles)
        {
            var typeHint = GetIntegerTypeHint(value);

            value = new string(value.Where(x => !IntegerNumberEnd.Contains(char.ToLower(x))).ToArray());

            if (typeHint == typeof(int))
            {
                if (int.TryParse(value, numberStyles, CultureInfo.InvariantCulture, out var r) && r >= 0) return r;
                typeHint = typeof(uint);
            }

            if (typeHint == typeof(uint))
            {
                if (uint.TryParse(value, numberStyles, CultureInfo.InvariantCulture, out var r)) return r;
                typeHint = typeof(long);
            }

            if (typeHint == typeof(long))
                if (long.TryParse(value, numberStyles, CultureInfo.InvariantCulture, out var r))
                    return r;
            if (typeHint == typeof(ulong)) return ulong.Parse(value, numberStyles, CultureInfo.InvariantCulture);
            throw new NotSupportedException();
        }

        private static Type GetDecimalTypeHint(string value)
        {
            if (value.EndsWith("f", StringComparison.InvariantCultureIgnoreCase)) return typeof(float);
            if (value.EndsWith("d", StringComparison.InvariantCultureIgnoreCase)) return typeof(double);
            return typeof(double);
        }

        private static Type GetIntegerTypeHint(string value)
        {
            if (value.EndsWith("u", StringComparison.InvariantCultureIgnoreCase)) return typeof(uint);
            if (value.EndsWith("ul", StringComparison.InvariantCultureIgnoreCase)) return typeof(ulong);
            if (value.EndsWith("ull", StringComparison.InvariantCultureIgnoreCase)) return typeof(ulong);
            if (value.EndsWith("l", StringComparison.InvariantCultureIgnoreCase)) return typeof(long);
            return typeof(int);
        }
    }
}
