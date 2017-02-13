using System;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Builder
{
    internal class EnumerationProcessor
    {
        private readonly GenerationContext _context;

        public EnumerationProcessor(GenerationContext context)
        {
            _context = context;
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var enumeration in translationUnit.Enums)
            {
                if (!enumeration.Type.IsPrimitiveType()) throw new NotSupportedException();

                var enumerationName = enumeration.Name;
                if (string.IsNullOrEmpty(enumerationName))
                    continue;

                var enumerationDefinition = ToDefinition(enumeration, enumerationName);
                _context.Units.Add(enumerationDefinition);
            }
        }

        public static EnumerationDefinition ToDefinition(Enumeration enumeration, string name)
        {
            var enumerationDefinition = new EnumerationDefinition
            {
                Name = name,
                TypeName = TypeHelper.GetTypeName(enumeration.Type),
                Content = enumeration.Comment?.BriefText,
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
            return enumerationDefinition;
        }

        public static object ConvertValue(ulong value, PrimitiveType primitiveType)
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