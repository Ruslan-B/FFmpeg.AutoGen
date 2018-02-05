using System;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class FunctionProcessor
    {
        private readonly ASTProcessor _context;

        public FunctionProcessor(ASTProcessor context)
        {
            _context = context;
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var function in translationUnit.Functions.Where(x => !x.IsInline))
            {
                var functionName = function.Name;
                FunctionExport export;
                if (!_context.FunctionExportMap.TryGetValue(functionName, out export))
                {
                    Console.WriteLine($"Export not found. Skipping {functionName} function.");
                    continue;
                }

                var functionDefinition = new FunctionDefinition
                {
                    Name = functionName,
                    ReturnType = GetReturnTypeName(function.ReturnType.Type, functionName),
                    Content = function.Comment?.BriefText,
                    LibraryName = export.LibraryName,
                    LibraryVersion = export.LibraryVersion,
                    Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray(),
                    IsObsolete = IsObsolete(function),
                    ObsoleteMessage = GetObsoleteMessage(function)
                };
                _context.AddUnit(functionDefinition);
            }
        }

        internal TypeDefinition GetDelegateType(FunctionType functionType, string name)
        {
            var @delegate = new DelegateDefinition
            {
                Name = name + "_func",
                FunctionName = name,
                ReturnType = GetReturnTypeName(functionType.ReturnType.Type, name),
                Parameters = functionType.Parameters.Select(GetParameter).ToArray()
            };
            _context.AddUnit(@delegate);

            return @delegate;
        }

        private FunctionParameter GetParameter(Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(parameter.Type, name)
            };
        }

        private FunctionParameter GetParameter(Function function, Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(parameter.Type, function.Name + "_" + name),
                Content = GetParamComment(function, parameter.Name)
            };
        }

        private TypeDefinition GetReturnTypeName(Type type, string name)
        {
            if (type is PointerType pointerType &&
                pointerType.QualifiedPointee.Qualifiers.IsConst && 
                pointerType.Pointee is BuiltinType builtinType)
            {
                switch (builtinType.Type)
                {
                    case PrimitiveType.Char:
                        return new TypeDefinition
                        {
                            Name = "string",
                            Attributes = new[] {"[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]"}
                        };
                    case PrimitiveType.Void:
                        return new TypeDefinition {Name = "void*"};
                    default:
                        return new TypeDefinition {Name = TypeHelper.GetTypeName(type) };
                }
            }

            return GetParameterType(type, name);
        }

        private TypeDefinition GetParameterType(Type type, string name)
        {
            if (type is PointerType pointerType &&
                pointerType.QualifiedPointee.Qualifiers.IsConst &&
                pointerType.Pointee is BuiltinType builtinType)
            {
                switch (builtinType.Type)
                {
                    case PrimitiveType.Char:
                        return new TypeDefinition {Name = "string", Attributes = new[] {"[MarshalAs(UnmanagedType.LPStr)]"}};
                    case PrimitiveType.Void:
                        return new TypeDefinition {Name = "void*"};
                    default:
                        return new TypeDefinition {Name = TypeHelper.GetTypeName(type) };
                }
            }

            // edge case when type is array of pointers to none builtin type (type[]* -> type**)
            if (type is ArrayType arrayType &&
                arrayType.SizeType == ArrayType.ArraySize.Incomplete &&
                arrayType.Type is PointerType arrayPointerType &&
                !(arrayPointerType.Pointee is BuiltinType || arrayPointerType.Pointee is TypedefType typedefType && typedefType.Declaration.Type is BuiltinType))
            {
                return new TypeDefinition { Name = TypeHelper.GetTypeName(arrayPointerType) + "*" };
            }

            return _context.StructureProcessor.GetTypeDefinition(type, name);
        }

        private static bool IsObsolete(Function function)
        {
            return function.PreprocessedEntities.OfType<MacroExpansion>().Any(x => x.Text == "attribute_deprecated");
        }

        private static string GetObsoleteMessage(Function function)
        {
            var lines = function.Comment?.FullComment?.Blocks
                .OfType<BlockCommandComment>()
                .Where(x => x.CommandKind == CommentCommandKind.Deprecated)
                .SelectMany(x => x.ParagraphComment.Content.OfType<TextComment>().Select(c => c.Text.Trim()));
            var obsoleteMessage = lines == null ? string.Empty : string.Join(" ", lines);
            return obsoleteMessage;
        }

        private static string GetParamComment(Function function, string parameterName)
        {
            var comment = function?.Comment?.FullComment.Blocks
                .OfType<ParamCommandComment>()
                .FirstOrDefault(x => x.Arguments.Count == 1 && x.Arguments[0].Text == parameterName);
            return comment == null ? null : string.Join(" ", comment.ParagraphComment.Content.OfType<TextComment>().Select(x => x.Text.Trim()));
        }
    }
}