using System;
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
        var values = enumeration.Items.Select(x => ToValue(x.Value, primitiveType)).ToArray();

        var definition = new EnumerationDefinition
        {
            Name = name,
            TypeName = typeName,
            Content = enumeration.Comment?.BriefText,
            Obsoletion = ObsoletionHelper.CreateObsoletion(enumeration),
            IsFlags = IsBitmask(values),
            Items = enumeration.Items
                .Zip(values, (item, value) =>
                {
                    var number = Format(value, primitiveType);
                    return new EnumerationItem
                    {
                        Name = item.Name,
                        Value = number,
                        Literal = ShiftLiteral(item.Expression, item.Value, typeName) ?? number,
                        Content = item.Comment?.BriefText
                    };
                })
                .ToArray()
        };

        _context.AddDefinition(definition);
    }

    // Members the header wrote as a bit shift, with or without the parentheses FFmpeg
    // uses in places: "= 1 << 3", "= (1 << 3)".
    [GeneratedRegex(@"=\s*\(?\s*1\s*<<\s*(?<shift>\d+)\s*\)?\s*$")]
    private static partial Regex ShiftExpression();

    // Keeps a shift spelled the way the header spells it, so the binding reads like the header.
    private static string ShiftLiteral(string expression, ulong value, string typeName)
    {
        if (expression is null || ShiftExpression().Match(expression) is not { Success: true } match) return null;

        // C# masks the shift count (& 31 for int, & 63 for long), so a shift that does not
        // reproduce the computed value would quietly compile to a different constant.
        if (!int.TryParse(match.Groups["shift"].ValueSpan, CultureInfo.InvariantCulture, out var shift)) return null;
        if (shift >= 64 || 1UL << shift != value) return null;

        // Taken from the type the enum is generated with, so it cannot drift away from TypeHelper.
        return typeName switch
        {
            "int" => $"1 << {shift}",
            "uint" => $"1U << {shift}",
            "long" => $"1L << {shift}",
            "ulong" => $"1UL << {shift}",
            _ => null
        };
    }

    // Whether the members describe a bitmask. Reads the values rather than how the header
    // happens to spell them, so hex, parenthesised shifts and plain decimals agree, and
    // reformatting upstream cannot silently change the answer.
    private static bool IsBitmask(long[] values)
    {
        // A negative member means the values are a scale rather than a mask, as in AVDiscard.
        if (values.Any(x => x < 0)) return false;

        // FFmpeg closes several enums with a *_MAX_ENUM = INT_MAX sentinel, which is not a member.
        var members = values
            .Where(x => x > 0 && x != int.MaxValue && x != uint.MaxValue && x != long.MaxValue)
            .Distinct()
            .Order()
            .ToArray();

        var bits = members.Where(IsSingleBit).ToArray();
        var aggregates = members.Except(bits).ToArray();
        var mask = bits.Aggregate(0L, (all, bit) => all | bit);

        return bits.Length >= 2
               // A named aggregate such as SWS_BACKEND_ALL is still a bitmask, but a run of
               // ordinary numbers that happen to be unions of earlier ones is not.
               && aggregates.Length <= 2
               && aggregates.All(x => (x | mask) == mask)
               // 1, 2, 3 is a sequence that merely starts with powers of two.
               && !IsConsecutive(members);
    }

    private static bool IsSingleBit(long value) => (value & (value - 1)) == 0;

    private static bool IsConsecutive(long[] sorted)
        => sorted.Length > 1 && sorted[^1] - sorted[0] == sorted.Length - 1;

    // The compiler hands every value over as ulong, whatever the enum is declared as.
    private static long ToValue(ulong value, PrimitiveType primitiveType)
        => primitiveType switch
        {
            PrimitiveType.Int => (int)value,
            PrimitiveType.UInt => (uint)value,
            PrimitiveType.Long or PrimitiveType.ULong => unchecked((long)value),
            _ => throw new NotSupportedException()
        };

    // The generated file is C# source, so it must not pick up the current culture's negative
    // sign - several locales render it as U+2212, which does not compile.
    private static string Format(long value, PrimitiveType primitiveType)
        => primitiveType == PrimitiveType.ULong
            ? unchecked((ulong)value).ToString(CultureInfo.InvariantCulture)
            : value.ToString(CultureInfo.InvariantCulture);
}
