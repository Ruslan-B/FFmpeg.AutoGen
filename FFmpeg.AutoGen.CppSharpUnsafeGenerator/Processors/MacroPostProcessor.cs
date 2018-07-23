using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using RCore.ClangMacroParser;
using RCore.ClangMacroParser.Expressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class MacroPostProcessor
    {
        private static readonly Regex EolEscapeRegex = new Regex(@"\\\s*[\r\n|\r|\n]\s*", RegexOptions.Compiled | RegexOptions.Multiline);

        private readonly ASTProcessor _astProcessor;
        private Dictionary<string, IExpression> _macroExpressionMap;

        public MacroPostProcessor(ASTProcessor astProcessor) => _astProcessor = astProcessor;

        public void Process(IReadOnlyList<MacroDefinition> macros)
        {
            _macroExpressionMap = macros.ToDictionary(x => x.Name, x =>
            {
                try
                {
                    return Parser.Parse(x.Expression);
                }
                catch (NotSupportedException)
                {
                    Trace.TraceError($"Cannot parse macro expression: {x.Expression}");
                    return null;
                }
            });

            foreach (var macro in macros) Process(macro);
        }

        private void Process(MacroDefinition macro)
        {
            macro.Expression = CleanUp(macro.Expression);

            if (!_macroExpressionMap.TryGetValue(macro.Name, out var expression) || expression == null) return;

            var typeOrAlias = DeduceType(expression);
            if (typeOrAlias == null) return;

            expression = Rewrite(expression);

            macro.TypeName = typeOrAlias.ToString();
            macro.Content = $"{macro.Name} = {macro.Expression}";
            macro.Expression = Serialize(expression);
            macro.IsConst = IsConst(expression);
            macro.IsValid = true;
        }

        private static string CleanUp(string expression)
        {
            var oneline = EolEscapeRegex.Replace(expression, string.Empty);
            var trimmed = oneline.Trim();
            return trimmed;
        }

        private TypeOrAlias DeduceType(IExpression expression)
        {
            switch (expression)
            {
                case BinaryExpression e: return DeduceType(e);
                case UnaryExpression e: return DeduceType(e.Operand);
                case CastExpression e: return GetTypeAlias(e.TargetType);
                case CallExpression e: return GetWellKnownMaroType(e.Name);
                case VariableExpression e: return DeduceType(e);
                case ConstantExpression e: return e.Value.GetType();
                default: throw new NotSupportedException();
            }
        }

        private TypeOrAlias DeduceType(BinaryExpression expression)
        {
            var operationType = expression.OperationType;
            if (operationType.IsConditional() || operationType.IsComparison()) return typeof(bool);

            var leftType = DeduceType(expression.Left);
            var rightType = DeduceType(expression.Right);
            return leftType.Precedence > rightType.Precedence ? rightType : leftType;
        }


        private TypeOrAlias DeduceType(VariableExpression expression) =>
            _macroExpressionMap.TryGetValue(expression.Name, out var nested) && nested != null ? DeduceType(nested) : GetWellKnownMaroType(expression.Name);

        private IExpression Rewrite(IExpression expression)
        {
            switch (expression)
            {
                case BinaryExpression e:
                {
                    var left = Rewrite(e.Left);
                    var right = Rewrite(e.Right);
                    var leftType = DeduceType(left);
                    var rightType = DeduceType(right);
                    if (e.OperationType.IsBitwise() && leftType.Precedence != rightType.Precedence)
                    {
                        var toType = leftType.Precedence > rightType.Precedence ? rightType : leftType;
                        if (leftType != toType) left = new CastExpression(toType.ToString(), left);
                        if (rightType != toType) right = new CastExpression(toType.ToString(), right);
                    }
                    return new BinaryExpression(left, e.OperationType, right);
                }
                case UnaryExpression e: return new UnaryExpression(e.OperationType, Rewrite(e.Operand));
                case CastExpression e: return new CastExpression(e.TargetType, Rewrite(e.Operand));
                case CallExpression e: return new CallExpression(e.Name, e.Arguments.Select(Rewrite));
                case VariableExpression e: return e;
                case ConstantExpression e: return e;
                default: return expression;
            }
        }

        private string Serialize(IExpression expression)
        {
            switch (expression)
            {
                case BinaryExpression e: return $"{Serialize(e.Left)} {e.OperationType.ToOperationTypeString()} {Serialize(e.Right)}";
                case UnaryExpression e: return $"{e.OperationType.ToOperationTypeString()}{Serialize(e.Operand)}";
                case CastExpression e: return $"({GetTypeAlias(e.TargetType)})({Serialize(e.Operand)})";
                case CallExpression e: return $"{e.Name}({string.Join(", ", e.Arguments.Select(Serialize))})";
                case VariableExpression e: return e.Name;
                case ConstantExpression e: return Serialize(e.Value);
                default: throw new NotSupportedException();
            }
        }

        private string Serialize(object value)
        {
            if (value is double d) return string.Format(CultureInfo.InvariantCulture, "{0}D", d);
            if (value is float f) return string.Format(CultureInfo.InvariantCulture, "{0}F", f);
            if (value is char c) return $"\'{c}\'";
            if (value is string s) return $"\"{s}\"";
            if (value is long l) return string.Format(CultureInfo.InvariantCulture, "0x{0:x}L", l);
            if (value is ulong ul) return string.Format(CultureInfo.InvariantCulture, "0x{0:x}UL", ul);
            if (value is int i) return string.Format(CultureInfo.InvariantCulture, "0x{0:x}", i);
            if (value is uint ui) return string.Format(CultureInfo.InvariantCulture, "0x{0:x}U", ui);
            if (value is bool b) return b ? "true" : "false";
            throw new NotSupportedException();
        }

        private bool IsConst(IExpression expression)
        {
            switch (expression)
            {
                case BinaryExpression e: return IsConst(e.Left) && IsConst(e.Right);
                case UnaryExpression e: return IsConst(e.Operand);
                case CastExpression e: return IsConst(e.Operand);
                case CallExpression e: return false;
                case VariableExpression e: return _macroExpressionMap.TryGetValue(e.Name, out var nested) && nested != null && IsConst(nested);
                case ConstantExpression e: return true;
                default: throw new NotSupportedException();
            }
        }
        private TypeOrAlias GetWellKnownMaroType(string macroName) => _astProcessor.WellKnownMaros.TryGetValue(macroName, out var alias) ? alias : null;
        private TypeOrAlias GetTypeAlias(string typeName) => _astProcessor.TypeAliases.TryGetValue(typeName, out var alias) ? alias : typeName;
    }
}