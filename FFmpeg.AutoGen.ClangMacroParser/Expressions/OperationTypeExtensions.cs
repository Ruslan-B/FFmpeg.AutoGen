using System;
using System.Collections.Generic;

namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    public static class OperationTypeExtensions
    {
        // http://en.cppreference.com/w/c/language/operator_precedence
        private static readonly Dictionary<OperationType, int> OperationPrecedence = new()
        {
            { OperationType.Add, 4 },
            { OperationType.Divide, 3 },
            { OperationType.Modulo, 3 },
            { OperationType.Multiply, 3 },
            { OperationType.Power, 9 },
            { OperationType.Subtract, 4 },
            { OperationType.And, 11 },
            { OperationType.Or, 10 },
            { OperationType.ExclusiveOr, 9 },
            { OperationType.LeftShift, 5 },
            { OperationType.RightShift, 5 },
            { OperationType.AndAlso, 11 },
            { OperationType.OrElse, 12 },
            { OperationType.Equal, 7 },
            { OperationType.NotEqual, 7 },
            { OperationType.GreaterThanOrEqual, 6 },
            { OperationType.GreaterThan, 6 },
            { OperationType.LessThan, 6 },
            { OperationType.LessThanOrEqual, 6 }
        };

        public static int GetPrecedence(this OperationType operationType) => OperationPrecedence[operationType];

        public static OperationType ToOperationType(this string value)
        {
            switch (value)
            {
                case "+": return OperationType.Add;
                case "/": return OperationType.Divide;
                case "%": return OperationType.Modulo;
                case "*": return OperationType.Multiply;
                case "^": return OperationType.Power;
                case "-": return OperationType.Subtract;
                case "&": return OperationType.And;
                case "|": return OperationType.Or;
                case "~": return OperationType.ExclusiveOr;
                case "<<": return OperationType.LeftShift;
                case ">>": return OperationType.RightShift;
                case "&&": return OperationType.AndAlso;
                case "||": return OperationType.OrElse;
                case "==": return OperationType.Equal;
                case "!=": return OperationType.NotEqual;
                case ">=": return OperationType.GreaterThanOrEqual;
                case ">": return OperationType.GreaterThan;
                case "<": return OperationType.LessThan;
                case "<=": return OperationType.LessThanOrEqual;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static string ToOperationTypeString(this OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Add: return "+";
                case OperationType.Divide: return "/";
                case OperationType.Modulo: return "%";
                case OperationType.Multiply: return "*";
                case OperationType.Power: return "^";
                case OperationType.Subtract: return "-";
                case OperationType.And: return "&";
                case OperationType.Or: return "|";
                case OperationType.ExclusiveOr: return "~";
                case OperationType.LeftShift: return "<<";
                case OperationType.RightShift: return ">>";
                case OperationType.AndAlso: return "&&";
                case OperationType.OrElse: return "||";
                case OperationType.Equal: return "==";
                case OperationType.NotEqual: return "!=";
                case OperationType.GreaterThanOrEqual: return ">=";
                case OperationType.GreaterThan: return ">";
                case OperationType.LessThan: return "<";
                case OperationType.LessThanOrEqual: return "<=";

                default:
                    throw new ArgumentOutOfRangeException(nameof(operationType));
            }
        }

        public static bool IsArithmetic(this OperationType operationType)
            => operationType == OperationType.Add ||
               operationType == OperationType.Divide ||
               operationType == OperationType.Modulo ||
               operationType == OperationType.Multiply ||
               operationType == OperationType.Power ||
               operationType == OperationType.Subtract;

        public static bool IsBitwise(this OperationType operationType)
            => operationType == OperationType.And ||
               operationType == OperationType.Or ||
               operationType == OperationType.ExclusiveOr;

        public static bool IsShift(this OperationType operationType)
            => operationType == OperationType.LeftShift ||
               operationType == OperationType.RightShift;

        public static bool IsConditional(this OperationType operationType)
            => operationType == OperationType.AndAlso ||
               operationType == OperationType.OrElse;

        public static bool IsComparison(this OperationType operationType)
            => operationType == OperationType.Equal ||
               operationType == OperationType.NotEqual ||
               operationType == OperationType.GreaterThan ||
               operationType == OperationType.GreaterThanOrEqual ||
               operationType == OperationType.LessThan ||
               operationType == OperationType.LessThanOrEqual;
    }
}
