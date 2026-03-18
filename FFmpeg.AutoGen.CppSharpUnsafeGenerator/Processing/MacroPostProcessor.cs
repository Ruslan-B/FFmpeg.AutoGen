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

    // Regex to parse function-like macro definitions: (param1, param2, ...) body
    private static readonly Regex FunctionMacroRegex =
        new(@"^\(([^)]*)\)\s*(.+)$", RegexOptions.Compiled | RegexOptions.Singleline);

    private readonly ProcessingContext _context;
    private Dictionary<string, IExpression> _macroExpressionMap;

    // Function-like macro definitions with ## token concatenation
    // Key: macro name, Value: (parameter names, raw body string)
    private readonly Dictionary<string, (string[] Params, string Body)> _functionMacroMap = new();

    public MacroPostProcessor(ProcessingContext context) => _context = context;

    public void Process(IReadOnlyList<MacroDefinition> macros)
    {
        _macroExpressionMap = new Dictionary<string, IExpression>(macros.Count);

        foreach (var macro in macros)
        {
            var expression = CleanUp(macro.Expression);

            // Detect function-like macro definitions with ## or struct init body
            var funcMatch = FunctionMacroRegex.Match(expression);
            if (funcMatch.Success && (expression.Contains("##") || expression.Contains("{")))
            {
                var parameters = funcMatch.Groups[1].Value.Split(',').Select(p => p.Trim()).ToArray();
                var body = funcMatch.Groups[2].Value.Trim();
                _functionMacroMap[macro.Name] = (parameters, body);
            }

            try
            {
                _macroExpressionMap.Add(macro.Name, ClangMacroParser.Parser.Parse(expression));
            }
            catch (NotSupportedException)
            {
                Trace.TraceError($"Cannot parse macro expression: {expression}");
            }
            catch (Exception e)
            {
                Trace.TraceError($"Cannot parse macro expression: {expression}: {e.Message}");
            }
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

        // Wrap bare InitializerList with inferred type into CompoundLiteral for proper serialization
        if (expression is InitializerListExpression initList && !typeOrAlias.IsType
            && _context.Definitions.Any(d => d.Name == typeOrAlias.Alias))
            expression = new CompoundLiteralExpression(typeOrAlias.Alias, initList);

        macro.Expression = Serialize(expression);
        macro.IsConst = IsConst(expression);
        macro.IsValid = typeOrAlias.IsType
            || _context.TypeAliases.ContainsKey(typeOrAlias.Alias)
            || (expression is CompoundLiteralExpression && _context.Definitions.Any(d => d.Name == typeOrAlias.Alias));
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
            CompoundLiteralExpression e => new TypeOrAlias(e.TypeName),
            InitializerListExpression e => DeduceStructType(e),
            BinaryExpression e => DeduceType(e),
            UnaryExpression e => DeduceType(e.Operand),
            CastExpression e => GetTypeAlias(e.TargetType),
            CallExpression e => DeduceCallType(e),
            VariableExpression e => DeduceType(e),
            ConstantExpression e => e.Value.GetType(),
            _ => throw new NotSupportedException()
        };
    }

    /// <summary>
    /// Tries to infer struct type from designated initializer field names.
    /// Matches field names against known struct definitions.
    /// </summary>
    private TypeOrAlias DeduceStructType(InitializerListExpression e)
    {
        // Extract top-level field names (e.g. "u.mask" → "u", "order" → "order")
        var fieldNames = e.Fields
            .Where(f => f.Name != null)
            .Select(f => f.Name.Split('.')[0])
            .ToHashSet();
        if (fieldNames.Count == 0) return null;

        var match = _context.Definitions
            .OfType<StructureDefinition>()
            .FirstOrDefault(s => s.Fields != null &&
                fieldNames.All(fn => s.Fields.Any(sf => sf.Name == fn)));

        return match != null ? new TypeOrAlias(match.Name) : null;
    }

    private TypeOrAlias DeduceCallType(CallExpression e)
    {
        // Try to expand function-like macros with ## token concatenation
        var expanded = TryExpandFunctionMacro(e);
        if (expanded != null)
            return DeduceType(expanded);

        return GetWellKnownMacroType(e.Name);
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
            case CallExpression e: return RewriteCall(e);
            case CompoundLiteralExpression e: return new CompoundLiteralExpression(e.TypeName,
                new InitializerListExpression(e.Initializer.Fields.Select(f =>
                    new InitializerField { Name = f.Name, Value = Rewrite(f.Value) })));
            case InitializerListExpression e: return new InitializerListExpression(
                e.Fields.Select(f => new InitializerField { Name = f.Name, Value = Rewrite(f.Value) }));
            case VariableExpression e: return Rewrite(e);
            case ConstantExpression e: return e;
            default: return expression;
        }
    }

    private IExpression RewriteCall(CallExpression e)
    {
        // Try to expand function-like macros with ## token concatenation
        var expanded = TryExpandFunctionMacro(e);
        if (expanded != null)
            return Rewrite(expanded);

        return new CallExpression(e.Name, e.Arguments.Select(Rewrite));
    }

    /// <summary>
    /// Expands function-like macros that use ## token concatenation.
    /// E.g. AV_PIX_FMT_NE(GRAY10BE, GRAY10LE) with body "AV_PIX_FMT_##le"
    /// → substitutes le=GRAY10LE → evaluates ## → "AV_PIX_FMT_GRAY10LE" → VariableExpression
    /// </summary>
    private IExpression TryExpandFunctionMacro(CallExpression call)
    {
        if (!_functionMacroMap.TryGetValue(call.Name, out var macroDef))
            return null;

        var args = call.Arguments.ToArray();
        if (args.Length != macroDef.Params.Length)
            return null;

        // Build parameter → argument name map
        var paramMap = new Dictionary<string, string>();
        for (var i = 0; i < macroDef.Params.Length; i++)
        {
            if (args[i] is VariableExpression varExpr)
                paramMap[macroDef.Params[i]] = varExpr.Name;
            else if (args[i] is ConstantExpression constExpr)
                paramMap[macroDef.Params[i]] = constExpr.Value.ToString();
            else
                return null; // Can't expand non-trivial arguments
        }

        // Substitute parameters in the body and evaluate ## concatenation
        var body = macroDef.Body;

        // First substitute parameters with word-boundary matching
        foreach (var (param, arg) in paramMap)
            body = Regex.Replace(body, $@"\b{Regex.Escape(param)}\b", arg);

        // Then evaluate ## (token concatenation = string join)
        body = body.Replace("##", "");

        // Convert C-style designated init comments to actual designators:
        // { /* .order */ value } → { .order = value }
        body = Regex.Replace(body, @"/\*\s*(\.[\w.]+)\s*\*/", "$1 =");

        body = body.Replace("  ", " ").Trim();

        // Try to parse the result as a single identifier/expression
        if (string.IsNullOrWhiteSpace(body))
            return null;

        // If result is a single token (no spaces, no operators), treat as variable
        if (!body.Contains(' ') && !body.Contains('('))
            return new VariableExpression(body);

        // Otherwise try to parse as expression
        try
        {
            return ClangMacroParser.Parser.Parse(body);
        }
        catch
        {
            return null;
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
            CompoundLiteralExpression e => SerializeCompoundLiteral(e),
            InitializerListExpression e => SerializeInitializerList(e),
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

    private string SerializeCompoundLiteral(CompoundLiteralExpression e)
    {
        var typeName = GetTypeAlias(e.TypeName);
        var fields = e.Initializer.Fields;

        var structDef = _context.Definitions
            .OfType<Definitions.StructureDefinition>()
            .FirstOrDefault(s => s.Name == e.TypeName.ToString());

        // For positional initializers, resolve field names from struct definition
        if (fields.Count > 0 && fields[0].Name == null && structDef?.Fields != null)
        {
            for (var idx = 0; idx < fields.Count && idx < structDef.Fields.Length; idx++)
                fields[idx].Name = structDef.Fields[idx].Name;
        }

        var serialized = fields
            // Skip nested fields (u.mask) — C# doesn't support nested object initializer access
            .Where(f => f.Name == null || !f.Name.Contains('.'))
            // Skip zero-initialized fields (default value)
            .Where(f => !(f.Value is ConstantExpression c && c.Value is int v && v == 0))
            .Select(f => f.Name != null
                ? $"{f.Name} = {SerializeFieldValue(f.Name, f.Value, structDef)}"
                : Serialize(f.Value));
        return $"new {typeName} {{ {string.Join(", ", serialized)} }}";
    }

    private string SerializeFieldValue(string fieldName, IExpression value, Definitions.StructureDefinition structDef)
    {
        // Unwrap single-element initializer list: { x } → x
        if (value is InitializerListExpression initList && initList.Fields.Count == 1)
            value = initList.Fields[0].Value;

        // Cast value to enum type if struct field is an enum
        if (structDef?.Fields != null)
        {
            var field = structDef.Fields.FirstOrDefault(f => f.Name == fieldName);
            if (field != null)
            {
                var enumDef = _context.Definitions
                    .OfType<Definitions.EnumerationDefinition>()
                    .FirstOrDefault(d => d.Name == field.FieldType.Name);
                if (enumDef != null)
                {
                    // Try to find matching enum member by value
                    var serializedValue = Serialize(value);
                    var enumItem = enumDef.Items.FirstOrDefault(i => i.Value == serializedValue);
                    if (enumItem != null)
                        return $"{enumDef.Name}.{enumItem.Name}";
                    return $"({enumDef.Name})({serializedValue})";
                }
            }
        }

        return Serialize(value);
    }

    private string SerializeInitializerList(InitializerListExpression e)
    {
        var fields = e.Fields.Select(f => f.Name != null
            ? $"{f.Name} = {Serialize(f.Value)}"
            : Serialize(f.Value));
        return $"{{ {string.Join(", ", fields)} }}";
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
            CompoundLiteralExpression _ => false,
            InitializerListExpression _ => false,
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
