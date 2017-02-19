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

        public EnumerationProcessor(ASTProcessor context)
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

                MakeDefinition(enumeration, enumerationName);
            }
        }

        public EnumerationDefinition MakeDefinition(Enumeration enumeration, string name)
        {
            name = string.IsNullOrEmpty(enumeration.Name) ? name : enumeration.Name;
            var result = new EnumerationDefinition {Name = name};
            if (_context.IsKnownUnitName(name)) return result;
            _context.AddUnit(result);

            result.TypeName = TypeHelper.GetTypeName(enumeration.Type);
            result.Content = enumeration.Comment?.BriefText;
            result.Items = enumeration.Items
                .Select(x =>
                    new EnumerationItem
                    {
                        Name = x.Name,
                        Value = ConvertValue(x.Value, enumeration.BuiltinType.Type).ToString(),
                        Content = x.Comment?.BriefText
                    })
                .ToArray();
            return result;
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