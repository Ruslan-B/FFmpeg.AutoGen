using System;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class EnumerationProcessor
    {
        private readonly ASTProcessor _context;

        public EnumerationProcessor(ASTProcessor context) => _context = context;

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
            if (_context.IsKnownUnitName(name)) return;

            var definition = new EnumerationDefinition
            {
                Name = name,
                TypeName = TypeHelper.GetTypeName(enumeration.Type),
                Content = enumeration.Comment?.BriefText,
                Obsoletion = ObsoletionHelper.CreateObsoletion(enumeration)
            };

            definition.Items = enumeration.Items
                .Select(x =>
                    new EnumerationItem
                    {
                        Name = x.Name,
                        Value = ConvertValue(x.Value, enumeration.BuiltinType.Type).ToString(),
                        Content = x.Comment?.BriefText
                    })
                .ToArray();

            _context.AddUnit(definition);
        }

        private static object ConvertValue(ulong value, PrimitiveType primitiveType)
        {
            switch (primitiveType)
            {
                case PrimitiveType.Int:
                    return (int) value;
                case PrimitiveType.UInt:
                    return (uint) value;
                case PrimitiveType.Long:
                    return (long) value;
                case PrimitiveType.ULong:
                    return value;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}