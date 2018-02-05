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

        internal TypeDefinition GetTypeDefinition(Type type, string name = null)
        {
            switch (type)
            {
                case TypedefType declaration:
                    return GetTypeDefinition(declaration.Declaration.Type, name);
                case ArrayType arrayType when arrayType.SizeType == ArrayType.ArraySize.Constant:
                    return GetFieldTypeForFixedArray(arrayType);
                case TagType tagType:
                    return GetFieldTypeForNestedDeclaration(tagType.Declaration, name);
                case PointerType pointerType:
                    return GetTypeDefinition(pointerType, name);
                default:
                    return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
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

                var bitFieldNames = new List<string>();
                var bitFieldComments = new List<string>();
                long bitCounter = 0;
                var fields = new List<StructureField>();
                foreach (var field in @class.Fields)
                {
                    if (field.IsBitField)
                    {
                        bitFieldNames.Add($"{field.Name}{field.BitWidth}");
                        bitFieldComments.Add(field.Comment?.BriefText ?? string.Empty);
                        bitCounter += field.BitWidth;
                        if (bitCounter % 8 == 0)
                        {
                            fields.Add(GetBitField(bitFieldNames, bitCounter, bitFieldComments));
                            bitFieldNames.Clear();
                            bitFieldComments.Clear();
                            bitCounter = 0;
                        }
                        continue;
                    }

                    var typeName = field.Class.Name + "_" + field.Name;
                    fields.Add(new StructureField
                    {
                        Name = field.Name,
                        FieldType = GetTypeDefinition(field.Type, typeName),
                        Content = field.Comment?.BriefText
                    });
                }

                if (bitFieldNames.Any() || bitCounter > 0) throw new InvalidOperationException();

                definition.Fileds = fields.ToArray();
                definition.Content = @class.Comment?.BriefText;
            }
        }

        private static StructureField GetBitField(IEnumerable<string> names, long bitCounter, List<string> comments)
        {
            var fieldName = string.Join("_", names);
            string fieldType;
            switch (bitCounter)
            {
                case 8:
                    fieldType = "byte";
                    break;
                case 16:
                    fieldType = "short";
                    break;
                case 32:
                    fieldType = "int";
                    break;
                case 64:
                    fieldType = "long";
                    break;
                default:
                    throw new NotSupportedException();
            }
            return new StructureField
            {
                Name = fieldName,
                FieldType = new TypeDefinition {Name = fieldType},
                Content = string.Join(" ", comments.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()))
            };
        }

        private TypeDefinition GetTypeDefinition(PointerType pointerType, string name)
        {
            var pointee = pointerType.Pointee;

            var typedefType = pointee as TypedefType;
            if (typedefType != null)
                pointee = typedefType.Declaration.Type;

            var functionType = pointee as FunctionType;
            if (functionType != null)
                return _context.FunctionProcessor.GetDelegateType(functionType, name);

            var pointerTypeDefinition = GetTypeDefinition(pointee, name);
            pointerTypeDefinition.Name += "*";
            return pointerTypeDefinition;
        }

        private TypeDefinition GetFieldTypeForNestedDeclaration(Declaration declaration, string name)
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


        private TypeDefinition GetFieldTypeForFixedArray(ArrayType arrayType)
        {
            var fixedSize = (int) arrayType.Size;

            var elementType = arrayType.Type;
            var elementTypeDefinition = GetTypeDefinition(elementType);

            var name = elementTypeDefinition.Name + "_array" + fixedSize;
            if (elementType.IsPointer()) name = TypeHelper.GetTypeName(elementType.GetPointee()) + "_ptrArray" + fixedSize;
            if (elementType is ArrayType) name = TypeHelper.GetTypeName(((ArrayType) elementType).Type) + "_arrayOfArray" + fixedSize;

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