using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpeg.AutoGen.ClangMacroParser.Expressions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal class MacroPostProcessor
{
    private static readonly Regex EolEscapeRegex =
        new(@"\\\s*[\r\n|\r|\n]\s*", RegexOptions.Compiled | RegexOptions.Multiline);

    private readonly ProcessingContext _context;
    private Dictionary<string, IExpression> _macroExpressionMap;

    public MacroPostProcessor(ProcessingContext context) => _context = context;

    public void Process(IReadOnlyList<MacroDefinition> macros)
    {
        _macroExpressionMap = new Dictionary<string, IExpression>(macros.Count);

        foreach (var macro in macros)
            try
            {
                _macroExpressionMap.Add(macro.Name, ClangMacroParser.Parser.Parse(macro.Expression));
            }
            catch (NotSupportedException)
            {
                Trace.TraceError($"Cannot parse macro expression: {macro.Expression}");
            }
            catch (Exception e)
            {
                Trace.TraceError($"Cannot parse macro expression: {macro.Expression}: {e.Message}");
            }

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
        macro.Content = $"{macro.Name} = {CleanUp(macro.Expression)}";
        macro.Expression = Serialize(expression);
        macro.IsConst = IsConst(expression);
        macro.IsValid = typeOrAlias.IsType || _context.TypeAliases.ContainsKey(typeOrAlias.Alias);
    }

    private static string CleanUp(string expression)
    {
        var oneLine = EolEscapeRegex.Replace(expression, string.Empty);
        var trimmed = oneLine.Trim();
        return trimmed;
    }

    private TypeOrAlias DeduceType(IExpression expression)
    {
        return expression switch
        {
            BinaryExpression e => DeduceType(e),
            UnaryExpression e => DeduceType(e.Operand),
            CastExpression e => GetTypeAlias(e.TargetType),
            CallExpression e => GetWellKnownMacroType(e.Name),
            VariableExpression e => DeduceType(e),
            ConstantExpression e => e.Value.GetType(),
            _ => throw new NotSupportedException()
        };
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
        _macroExpressionMap.TryGetValue(expression.Name, out var nested) && nested != null
            ? DeduceType(nested)
            : GetWellKnownMacroType(expression.Name);

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
            case VariableExpression e: return Rewrite(e);
            case ConstantExpression e: return e;
            default: return expression;
        }
    }

    private IExpression Rewrite(VariableExpression expression) =>
        _context.WellKnownEnumItems.TryGetValue(expression.Name, out var fullName)
            ? new VariableExpression(fullName)
            : expression;

    private string Serialize(IExpression expression)
    {
        return expression switch
        {
            BinaryExpression e =>
                $"{Serialize(e.Left)} {e.OperationType.ToOperationTypeString()} {Serialize(e.Right)}",
            UnaryExpression e => $"{e.OperationType.ToOperationTypeString()}{Serialize(e.Operand)}",
            CastExpression e => $"({GetTypeAlias(e.TargetType)})({Serialize(e.Operand)})",
            CallExpression e => $"{e.Name}({string.Join(", ", e.Arguments.Select(Serialize))})",
            VariableExpression e => e.Name,
            ConstantExpression e => Serialize(e.Value),
            _ => throw new NotSupportedException()
        };
    }


    internal TypeOrAlias GetWellKnownMacroType(string macroName)
    {
        if (_context.WellKnownMacros.TryGetValue(macroName, out var alias))
            return alias;
        if (_context.WellKnownEnumItems.TryGetValue(macroName, out _))
            return new TypeOrAlias(typeof(int));
        return new TypeOrAlias(macroName);
    }

    internal TypeOrAlias GetTypeAlias(string typeName) =>
        _context.TypeAliases.TryGetValue(typeName, out var alias) ? alias : typeName;

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
        return expression switch
        {
            BinaryExpression e => IsConst(e.Left) && IsConst(e.Right),
            UnaryExpression e => IsConst(e.Operand),
            CastExpression e => IsConst(e.Operand),
            CallExpression _ => false,
            VariableExpression e => _macroExpressionMap.TryGetValue(e.Name, out var nested) && nested != null &&
                                    IsConst(nested),
            ConstantExpression _ => true,
            _ => throw new NotSupportedException()
        };
    }
}
