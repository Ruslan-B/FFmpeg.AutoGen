using System;
using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Builder
{
    internal  class StructureProcessor
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
                _context.Units.Add(ToDeclaration(className, @class));
            }
        }

        private  IEnumerable<StructureField> ToDefinition(Field field)
        {
            if (field.IsBitField) throw new NotSupportedException();

            var arrayType = field.Type as ArrayType;
            if (arrayType != null && arrayType.SizeType == ArrayType.ArraySize.Constant) return FixedArray(field, arrayType);

            var tagType = field.Type as TagType;
            if (tagType != null && field.Class.Declarations.Contains(tagType.Declaration)) return NestedDefinition(field, tagType);
            
            return new[] { ToDeclaration(field, field.Name, TypeHelper.GetTypeName(field.Type)) };
        }

        private IEnumerable<StructureField> NestedDefinition(Field field, TagType tagType)
        {
            var @class = tagType.Declaration as Class;
            if (@class != null)
            {
                var typeName = field.Class.Name + "_" + field.Name;
                _context.Units.Add(ToDeclaration(typeName, @class));
                return new[] { ToDeclaration(field, field.Name, typeName)};
            }
            throw new NotSupportedException();
        }

        private  IEnumerable<StructureField> FixedArray(Field field, ArrayType arrayType)
        {
            var elementTypeName = TypeHelper.GetTypeName(arrayType.Type);
            
            //if (arrayType.Type.IsPrimitiveType())
            //    yield return
            //        new StructureField
            //        {
            //            Name = field.Name,
            //            TypeName = elementTypeName,
            //            IsFixed = true,
            //            FixedSize = arrayType.Size
            //        };

            for (var i = 0; i < arrayType.Size; i++)
                yield return ToDeclaration(field, $"{field.Name}{i}", elementTypeName);
        }


        private StructureDefinition ToDeclaration(string className, Class @class)
        {
            return new StructureDefinition
            {
                Name = className,
                Fileds = @class.Fields.SelectMany(ToDefinition).ToArray(),
                Content = @class.Comment?.BriefText,
            };
        }

        private static StructureField ToDeclaration(Field field, string name, string typeName)
        {
            return new StructureField
            {
                Name = name,
                TypeName = typeName,
                Content = field.Comment?.BriefText,
            };
        }
    }
}