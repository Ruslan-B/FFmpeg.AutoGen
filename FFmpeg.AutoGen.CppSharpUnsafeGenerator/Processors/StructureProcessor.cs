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
        private readonly ASTProcessor _context;

        public StructureProcessor(ASTProcessor context)
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

        internal FunctionParameter GetParameter(Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = _context.FunctionProcessor.GetParameterType(name, parameter.Type)
            };
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

        private TypeDefinition GetFieldType(Field field, string name, Type type)
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

            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
        }

        private TypeDefinition GetPointerToFunction(Field field, string name, FunctionType functionType)
        {
            var delegateTypeName = field.Class.Name + "_" + name;
            var @delegate = new DelegateDefinition
            {
                Name = delegateTypeName,
                ReturnType = TypeHelper.GetReturnTypeName(functionType.ReturnType.Type),
                Content = field.Comment?.BriefText,
                Parameters = functionType.Parameters.Select(GetParameter).ToArray()
            };
            _context.AddUnit(@delegate);

            var wrapperTypeName = delegateTypeName + "_wrapper";
            var wrapperDefinition = new StructureDefinition
            {
                Name = wrapperTypeName,
                Delegate = @delegate
            };
            _context.AddUnit(wrapperDefinition);

            return new TypeDefinition {Name = wrapperTypeName};
        }


        private TypeDefinition GetFieldTypeForNestedDeclaration(Field field, string name, TagType tagType)
        {
            var typeName = field.Class.Name + "_" + name;
            var @class = tagType.Declaration as Class;
            if (@class != null)
            {
                _context.AddUnit(ToDefinition(@class, typeName));
                return new TypeDefinition {Name = typeName};
            }
            var @enum = tagType.Declaration as Enumeration;
            if (@enum != null)
            {
                _context.AddUnit(EnumerationProcessor.ToDefinition(@enum, typeName));
                return new TypeDefinition {Name = typeName};
            }
            throw new NotSupportedException();
        }

        private TypeDefinition GetFieldTypeForFixedArray(Field field, string name, ArrayType arrayType)
        {
            var fixedSize = (int) arrayType.Size;

            var elementType = arrayType.Type;
            if (elementType.IsPrimitiveType()) name = TypeHelper.GetTypeName(elementType) + "_array" + fixedSize;
            if (elementType.IsPointerToPrimitiveType()) name = TypeHelper.GetTypeName(elementType.GetPointee()) + "_ptr_array" + fixedSize;

            //  var indexerTypeName = field.Class.Name + "_" + name;
            var fieldType = GetFieldType(field, name, elementType);
            var prefix = "at";
            var indexerDefinition = new StructureDefinition
            {
                Name = name,
                Indexer = new StructureIndexer {FieldType = new TypeDefinition {FixedSize = fixedSize, Name = fieldType.Name}, FieldPrefix = prefix},
                Fileds = Enumerable.Range(0, fixedSize)
                    .Select(i => new StructureField {Name = $"{prefix}{i}", FieldType = fieldType})
                    .ToArray()
            };
            _context.AddUnit(indexerDefinition);

            return new TypeDefinition {Name = name};
        }
    }
}