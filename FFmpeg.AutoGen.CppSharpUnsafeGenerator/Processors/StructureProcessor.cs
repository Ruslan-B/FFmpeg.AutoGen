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
                MakeDefinition(@class, className);
            }
        }

        private void MakeDefinition(Class @class, string name)
        {
            name = string.IsNullOrEmpty(@class.Name) ? name : @class.Name;

            var definition = _context.Units.OfType<StructureDefinition>().FirstOrDefault(x => x.Name == name);
            if (definition == null)
            {
                definition = new StructureDefinition {Name = name};
                _context.AddUnit(definition);
            }

            if (!@class.IsIncomplete && !definition.IsComplete)
            {
                definition.IsComplete = true;
                definition.Fileds = @class.Fields.SelectMany(ToDefinition).ToArray();
                definition.Content = @class.Comment?.BriefText;
            }
        }

        internal TypeDefinition GetTypeDefinition(Type type, string name = null)
        {
            var typedefType = type as TypedefType;
            if (typedefType != null)
            {
                type = typedefType.Declaration.Type;
            }
            
            var arrayType = type as ArrayType;
            if (arrayType?.SizeType == ArrayType.ArraySize.Constant)
                return GetFieldTypeForFixedArray(arrayType);

            var tagType = type as TagType;
            if (tagType != null)
                return GetFieldTypeForNestedDeclaration(tagType.Declaration, name);

            var pointerType = type as PointerType;
            if (pointerType != null)
                return GetTypeDefinition(pointerType, name);


            var declaration = type as TypedefType;
            if (declaration != null)
                return GetTypeDefinition(declaration.Declaration.Type, name);

            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
        }

        internal TypeDefinition GetTypeDefinition(PointerType pointerType, string name)
        {
            var pointee = pointerType.Pointee;

            var typedefType = pointee as TypedefType;
            if (typedefType != null)
            {
                pointee = typedefType.Declaration.Type;
            }

            var functionType = pointee as FunctionType;
            if (functionType != null)
            {
                return _context.FunctionProcessor.GetDelegateType(functionType, name);
            }

            var pointerTypeDefinition = GetTypeDefinition(pointee, name);
            pointerTypeDefinition.Name += "*";
            return pointerTypeDefinition;
        }
        
        internal TypeDefinition GetFieldTypeForNestedDeclaration(Declaration declaration, string name)
        {
            var typeName = string.IsNullOrEmpty(declaration.Name) ? name : declaration.Name;
            var @class = declaration as Class;
            if (@class != null)
            {
                MakeDefinition(@class, typeName);
                return new TypeDefinition {Name = typeName};
            }
            var @enum = declaration as Enumeration;
            if (@enum != null)
            {
                _context.EnumerationProcessor.MakeDefinition(@enum, typeName);
                return new TypeDefinition {Name = typeName};
            }
            throw new NotSupportedException();
        }

        private IEnumerable<StructureField> ToDefinition(Field field)
        {
            if (field.IsBitField)
            {
                Console.WriteLine("TODO bit fileds processing");
                yield break;
            }

            var typeName = field.Class.Name + "_" + field.Name;
            yield return new StructureField {Name = field.Name, Content = field.Comment?.BriefText, FieldType = GetTypeDefinition(field.Type, typeName)};
        }

        private TypeDefinition GetFieldTypeForFixedArray(ArrayType arrayType)
        {
            var fixedSize = (int) arrayType.Size;

            var elementType = arrayType.Type;
            var elementTypeDefinition = GetTypeDefinition(elementType);
            
            string name = elementTypeDefinition.Name + "_array" + fixedSize;
            if (elementType.IsPointer()) name = TypeHelper.GetTypeName(elementType.GetPointee()) + "_ptrArray" + fixedSize;
            if (elementType is ArrayType) name = TypeHelper.GetTypeName(((ArrayType)elementType).Type) + "_arrayOfArray" + fixedSize;

            if (!_context.IsKnownUnitName(name))
            {
                var fixedArray = new FixedArrayDefinition
                {
                    Name = name,
                    Size = fixedSize,
                    ElementType = elementTypeDefinition,
                    IsPrimitive = elementType.IsPrimitiveType()
                };
                _context.AddUnit(fixedArray);
            }

            return new TypeDefinition {Name = name, ByReference = !arrayType.QualifiedType.Qualifiers.IsConst};
        }
    }
}