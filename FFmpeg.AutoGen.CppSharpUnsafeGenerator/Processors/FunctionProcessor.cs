using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class FunctionProcessor
    {
        private readonly ASTProcessor _context;

        public FunctionProcessor(ASTProcessor context) => _context = context;

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var function in translationUnit.Functions)
            {
                var functionName = function.Name;

                void PopulateCommon(FunctionDefinitionBase inline)
                {
                    inline.Name = functionName;
                    inline.ReturnType = GetReturnTypeName(function.ReturnType.Type, functionName);
                    inline.Content = function.Comment?.BriefText;
                    inline.ReturnComment = GetReturnComment(function);
                    inline.Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray();
                    inline.IsObsolete = IsObsolete(function);
                    inline.ObsoleteMessage = GetObsoleteMessage(function);
                }

                if (function.IsInline)
                {
                    var inlineDefinition = new InlineFunctionDefinition();
                    PopulateCommon(inlineDefinition);
                    inlineDefinition.Body = function.Body;
                    inlineDefinition.Sha256 = GetSha256(function.Body);
                    _context.AddUnit(inlineDefinition);
                    continue;
                }

                if (!_context.FunctionExportMap.TryGetValue(functionName, out var export))
                {
                    Console.WriteLine($"Export not found. Skipping {functionName} function.");
                    continue;
                }

                var exportDefinition = new ExportFunctionDefinition();
                PopulateCommon(exportDefinition);
                exportDefinition.LibraryName = export.LibraryName;
                exportDefinition.LibraryVersion = export.LibraryVersion;
                _context.AddUnit(exportDefinition);
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
                        return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
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
                        return new TypeDefinition {Name = "string", Attributes = new[] { "[MarshalAs((UnmanagedType)48)]" } };
                    case PrimitiveType.Void:
                        return new TypeDefinition {Name = "void*"};
                    default:
                        return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
                }
            }

            // edge case when type is array of pointers to none builtin type (type[]* -> type**)
            if (type is ArrayType arrayType &&
                arrayType.SizeType == ArrayType.ArraySize.Incomplete &&
                arrayType.Type is PointerType arrayPointerType &&
                !(arrayPointerType.Pointee is BuiltinType || arrayPointerType.Pointee is TypedefType typedefType && typedefType.Declaration.Type is BuiltinType))
                return new TypeDefinition {Name = TypeHelper.GetTypeName(arrayPointerType) + "*"};

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
            return GetCommentString(comment);
        }

        private string GetReturnComment(Function function)
        {
            var comment = function?.Comment?.FullComment.Blocks
                .OfType<BlockCommandComment>()
                .FirstOrDefault(x => x.CommandKind == CommentCommandKind.Return);
            return GetCommentString(comment);
        }

        private static string GetCommentString(BlockCommandComment comment)
        {
            return comment == null ? null : string.Join(" ", comment.ParagraphComment.Content.OfType<TextComment>().Select(x => x.Text.Trim()));
        }

        private static string GetSha256(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            var sha256Managed = new SHA256Managed();
            var hash = sha256Managed.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}