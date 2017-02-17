using System;
using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class StructureProcessor
    {
        private readonly GenerationContext _context;

        public StructureProcessor(GenerationContext context)
        {
            _context = context;
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var typedef in translationUnit.Typedefs)
            {
                Class @class;
                if (!typedef.Type.TryGetClass(out @class))
                    continue;

                var className = @class.Name;
                _context.AddUnit(ToDefinition(@class, className));
            }
        }

        private StructureDefinition ToDefinition(Class @class, string className)
        {
            return new StructureDefinition
            {
                Name = className,
                Fileds = @class.Fields.SelectMany(ToDefinition).ToArray(),
                Content = @class.Comment?.BriefText
            };
        }

        private IEnumerable<StructureField> ToDefinition(Field field)
        {
            if (field.IsBitField)
            {
                Console.WriteLine("TODO bit fileds processing");
                yield break;
            }

            yield return new StructureField {Name = field.Name, Content = field.Comment?.BriefText, FieldType = GetFieldType(field, field.Name, field.Type)};
        }

        private FieldType GetFieldType(Field field, string name, Type type)
        {
            var arrayType = type as ArrayType;
            if (arrayType != null && arrayType.SizeType == ArrayType.ArraySize.Constant)
                return GetFieldTypeForFixedArray(field, $"{name}_array{arrayType.Size}", arrayType);

            var tagType = type as TagType;
            if (tagType != null && field.Class.Declarations.Contains(tagType.Declaration))
                return GetFieldTypeForNestedDeclaration(field, name, tagType);

            FunctionType functionType;
            if (type.IsPointerTo(out functionType))
                return GetPointerToFunction(field, name, functionType);

            return new FieldType {Name = TypeHelper.GetTypeName(type)};
        }

        private FieldType GetPointerToFunction(Field field, string name, FunctionType functionType)
        {
            var delegateTypeName = field.Class.Name + "_" + name;
            var @delegate = new DelegateDefinition
            {
                Name = delegateTypeName,
                ReturnType = TypeHelper.GetReturnTypeName(functionType.ReturnType.Type),
                Content = field.Comment?.BriefText,
                Parameters = functionType.Parameters.Select((x, i) => FunctionProcessor.GetParameter(null, x, i)).ToArray()
            };
            _context.AddUnit(@delegate);

            var wrapperTypeName = delegateTypeName + "_wrapper";
            var wrapperDefinition = new StructureDefinition
            {
                Name = wrapperTypeName,
                Delegate = @delegate
            };
            _context.AddUnit(wrapperDefinition);

            return new FieldType {Name = wrapperTypeName};
        }

        private FieldType GetFieldTypeForNestedDeclaration(Field field, string name, TagType tagType)
        {
            var typeName = field.Class.Name + "_" + name;
            var @class = tagType.Declaration as Class;
            if (@class != null)
            {
                _context.AddUnit(ToDefinition(@class, typeName));
                return new FieldType {Name = typeName};
            }
            var @enum = tagType.Declaration as Enumeration;
            if (@enum != null)
            {
                _context.AddUnit(EnumerationProcessor.ToDefinition(@enum, typeName));
                return new FieldType {Name = typeName};
            }
            throw new NotSupportedException();
        }

        private FieldType GetFieldTypeForFixedArray(Field field, string name, ArrayType arrayType)
        {
            var fixedSize = (int) arrayType.Size;

            if (arrayType.Type.IsPrimitiveType())
                name = TypeHelper.GetTypeName(arrayType.Type) + "_array" + fixedSize;

            //  var indexerTypeName = field.Class.Name + "_" + name;
            var fieldType = GetFieldType(field, name, arrayType.Type);
            var prefix = "at";
            var indexerDefinition = new StructureDefinition
            {
                Name = name,
                Content = field.Comment?.BriefText,
                Indexer = new StructureIndexer {FieldType = new FieldType {FixedSize = fixedSize, Name = fieldType.Name}, FieldPrefix = prefix},
                Fileds = Enumerable.Range(0, fixedSize)
                    .Select(i => new StructureField {Name = $"{prefix}{i}", FieldType = fieldType})
                    .ToArray()
            };
            _context.AddUnit(indexerDefinition);

            return new FieldType {Name = name};
        }
    }
}