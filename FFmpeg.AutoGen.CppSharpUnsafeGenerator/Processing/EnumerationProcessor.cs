using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal partial class EnumerationProcessor
{
    private readonly ProcessingContext _context;

    public EnumerationProcessor(ProcessingContext context) => _context = context;

    public void Process(TranslationUnit translationUnit)
    {
        foreach (var enumeration in translationUnit.Enums)
        {
            if (!enumeration.Type.IsPrimitiveType()) throw new NotSupportedException();

            var enumerationName = enumeration.Name;
            if (string.IsNullOrEmpty(enumerationName))
            {
                enumerationName = DeriveNameFromMembers(enumeration);
                if (enumerationName == null) continue;
            }

            MakeDefinition(enumeration, enumerationName);
        }
    }

    /// <summary>
    /// Derives a synthetic enum name from member names by finding the longest common prefix.
    /// E.g. AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX, AV_CODEC_HW_CONFIG_METHOD_INTERNAL
    /// → common prefix "AV_CODEC_HW_CONFIG_METHOD_" → PascalCase "AvCodecHwConfigMethod"
    /// </summary>
    private static string DeriveNameFromMembers(Enumeration enumeration)
    {
        var items = enumeration.Items;
        if (items.Count == 0) return null;

        // Find longest common prefix up to last underscore
        var prefix = items[0].Name;
        foreach (var item in items.Skip(1))
        {
            var len = 0;
            while (len < prefix.Length && len < item.Name.Length && prefix[len] == item.Name[len])
                len++;
            prefix = prefix[..len];
        }

        // Trim to last underscore boundary
        var lastUnderscore = prefix.LastIndexOf('_');
        if (lastUnderscore <= 0) return null;
        prefix = prefix[..(lastUnderscore + 1)];

        // Need at least 2 segments (e.g. "AV_SOMETHING_")
        if (prefix.Count(c => c == '_') < 2) return null;

        // Convert to PascalCase: "AV_CODEC_HW_CONFIG_METHOD_" → "AvCodecHwConfigMethod"
        var parts = prefix.TrimEnd('_').Split('_');
        var name = string.Concat(parts.Select(p =>
            p.Length <= 1 ? p.ToUpperInvariant() : char.ToUpperInvariant(p[0]) + p[1..].ToLowerInvariant()));

        return name;
    }

    public void MakeDefinition(Enumeration enumeration, string name)
    {
        name = string.IsNullOrEmpty(enumeration.Name) ? name : enumeration.Name;
        if (_context.Definitions.Any(d => d.Name == name)) return;

        var typeName = TypeHelper.GetTypeName(enumeration.Type);
        var primitiveType = enumeration.BuiltinType.Type;

        var definition = new EnumerationDefinition
        {
            Name = name,
            TypeName = typeName,
            Content = enumeration.Comment?.BriefText,
            Obsoletion = ObsoletionHelper.CreateObsoletion(enumeration),
            IsFlags = IsBitmask(enumeration.Items.Select(x => ToSigned(x.Value, primitiveType))),
            Items = enumeration.Items
                .Select(x =>
                    new EnumerationItem
                    {
                        Name = x.Name,
                        Value = ConvertValue(x.Value, primitiveType),
                        Literal = MakeShiftLiteral(x.Expression, x.Value, typeName) ??
                                  ConvertValue(x.Value, primitiveType),
                        Content = x.Comment?.BriefText
                    })
                .ToArray()
        };

        _context.AddDefinition(definition);
    }

    // Matches a member the header wrote as a bit shift, with or without the surrounding
    // parentheses FFmpeg uses in places: "= 1 << 3", "= (1 << 3)".
    [GeneratedRegex(@"=\s*\(?\s*1\s*<<\s*(?<shift>\d+)\s*\)?\s*$")]
    private static partial Regex ShiftExpression();

    /// <summary>
    ///     Keeps a member the header spelled as a bit shift in that form, so the binding reads the
    ///     way the header does. Returns null when the member is not a plain shift, when the shift
    ///     does not actually produce the value the compiler computed, or when the enum's underlying
    ///     type has no C# literal suffix to hang the shift on.
    /// </summary>
    private static string MakeShiftLiteral(string expression, ulong value, string typeName)
    {
        if (expression == null) return null;

        // C# silently masks the shift count (& 31 for int, & 63 for long), so a shift that does
        // not reproduce the computed value would compile to a different constant.
        if (ShiftExpression().Match(expression) is not { Success: true } match) return null;
        if (!int.TryParse(match.Groups["shift"].Value, NumberStyles.None, CultureInfo.InvariantCulture, out var shift))
            return null;
        if (shift >= 64 || 1UL << shift != value) return null;

        // Derived from the type the enum is actually generated with, rather than from a second
        // table of primitives that could drift away from TypeHelper.
        var suffix = typeName switch
        {
            "int" => "",
            "uint" => "U",
            "long" => "L",
            "ulong" => "UL",
            _ => null
        };

        return suffix == null ? null : $"1{suffix} << {shift}";
    }

    /// <summary>
    ///     Decides whether the members describe a bitmask. This looks at the values rather than at
    ///     how the header happens to spell them, so hex, parenthesised shifts and plain decimals all
    ///     reach the same answer, and reformatting upstream cannot silently change it.
    /// </summary>
    private static bool IsBitmask(IEnumerable<long> values)
    {
        var distinct = values
            .Where(v => v != 0)
            // FFmpeg terminates several enums with a *_MAX_ENUM = INT_MAX sentinel, which is not a
            // member of the bitmask.
            .Where(v => v != int.MaxValue && v != uint.MaxValue && v != long.MaxValue)
            .Distinct()
            .OrderBy(v => v)
            .ToArray();

        if (distinct.Length < 2 || distinct[0] < 0) return false;

        var bits = distinct.Where(v => (v & (v - 1)) == 0).ToArray();
        var combinations = distinct.Except(bits).ToArray();

        // A bitmask is mostly single bits; a handful of named aggregates such as SWS_BACKEND_ALL is
        // still one, but a run of ordinary numbers that happen to be expressible as unions is not.
        if (bits.Length < 2 || combinations.Length > 2) return false;

        var allBits = bits.Aggregate(0L, (acc, v) => acc | v);
        if (combinations.Any(v => (v | allBits) != allBits)) return false;

        // 1, 2, 3 or 0, 1, 2 is a sequence that happens to start with powers of two.
        var isConsecutive = distinct.Select((v, index) => v - index).Distinct().Count() == 1;
        return !isConsecutive;
    }

    private static long ToSigned(ulong value, PrimitiveType primitiveType)
        => primitiveType switch
        {
            PrimitiveType.Int => value > int.MaxValue ? (int)value : (long)value,
            PrimitiveType.Long => value > long.MaxValue ? (long)value : (long)value,
            _ => unchecked((long)value)
        };

    private static string ConvertValue(ulong value, PrimitiveType primitiveType)
    {
        object converted = primitiveType switch
        {
            PrimitiveType.Int => value > int.MaxValue ? (int)value : value,
            PrimitiveType.UInt => value,
            PrimitiveType.Long => value > long.MaxValue ? (long)value : value,
            PrimitiveType.ULong => value,
            _ => throw new NotSupportedException()
        };

        // The generated file is C# source, so it must not pick up the current culture's negative
        // sign - several locales use U+2212, which does not compile.
        return converted switch
        {
            int i => i.ToString(CultureInfo.InvariantCulture),
            long l => l.ToString(CultureInfo.InvariantCulture),
            ulong u => u.ToString(CultureInfo.InvariantCulture),
            _ => Convert.ToString(converted, CultureInfo.InvariantCulture)
        };
    }
}
