using System;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal class EnumerationProcessor
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
                continue;

            MakeDefinition(enumeration, enumerationName);
        }
    }

    public void MakeDefinition(Enumeration enumeration, string name)
    {
        name = string.IsNullOrEmpty(enumeration.Name) ? name : enumeration.Name;
        if (_context.Definitions.Any(d => d.Name == name)) return;

        var definition = new EnumerationDefinition
        {
            Name = name,
            TypeName = TypeHelper.GetTypeName(enumeration.Type),
            Content = enumeration.Comment?.BriefText,
            Obsoletion = ObsoletionHelper.CreateObsoletion(enumeration),
            Items = enumeration.Items
                .Select(x =>
                    new EnumerationItem
                    {
                        Name = x.Name,
                        Value = ConvertValue(x.Value, enumeration.BuiltinType.Type).ToString(),
                        Content = x.Comment?.BriefText
                    })
                .ToArray()
        };

        _context.AddDefinition(definition);
    }

    private static object ConvertValue(ulong value, PrimitiveType primitiveType)
    {
        return primitiveType switch
        {
            PrimitiveType.Int => value > int.MaxValue ? (int)value : value,
            PrimitiveType.UInt => value,
            PrimitiveType.Long => value > long.MaxValue ? (long)value : value,
            PrimitiveType.ULong => value,
            _ => throw new NotSupportedException()
        };
    }
}
