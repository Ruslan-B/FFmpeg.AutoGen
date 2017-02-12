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

                var enumerationDefinition = new EnumerationDefinition
                {
                    Name = enumerationName,
                    TypeName = TypeHelper.GetTypeName(enumeration.Type),
                    Summary = enumeration.Comment?.BriefText,
                    Items = enumeration.Items
                        .Select(x =>
                            new EnumerationItem
                            {
                                Name = x.Name,
                                Value = ConvertValue(x.Value, enumeration.BuiltinType.Type).ToString(),
                                Summary = x.Comment?.BriefText
                            })
                        .ToArray()
                };
                _context.Units.Add(enumerationDefinition);
            }
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

    internal class FunctionProcessor
    {
        private readonly GenerationContext _context;

        public FunctionProcessor(GenerationContext context)
        {
            _context = context;
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var function in translationUnit.Functions)
            {
                var functionDefinition = new FunctionDefinition
                {
                    Name = function.Name,
                    ReturnTypeName = TypeHelper.GetTypeName(function.ReturnType.Type),
                    Summary = function.Comment?.BriefText
                };
                _context.Units.Add(functionDefinition);
            }
        }
    }
}