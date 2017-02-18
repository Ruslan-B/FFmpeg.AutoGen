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
            var counter = 0;
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
                    ReturnType = TypeHelper.GetReturnTypeName(function.ReturnType.Type),
                    Content = function.Comment?.BriefText,
                    LibraryName = export.Library,
                    Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray(),
                    IsObsolete = IsObsolete(function),
                    ObsoleteMessage = GetObsoleteMessage(function)
                };
                _context.AddUnit(functionDefinition);
                counter++;
            }
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

        internal FunctionParameter GetParameter(Function function, Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(function.Name + "_" + name, parameter.Type),
                Content = GetParamComment(function, parameter.Name)
            };
        }


        internal TypeDefinition GetParameterType(string name, Type type)
        {
            var arrayType = type as ArrayType;
            if (arrayType != null && arrayType.SizeType == ArrayType.ArraySize.Constant)
            {
                return new TypeDefinition
                {
                    Name = TypeHelper.GetTypeName(type),
                    Attributes = new[] {$"[MarshalAs(UnmanagedType.LPArray, SizeConst={arrayType.Size})]"}
                };
            }

            var pointerType = type as PointerType;
            if (pointerType != null)
            {
                var builtinType = pointerType.Pointee as BuiltinType;
                if (builtinType != null && builtinType.Type == PrimitiveType.Char)
                {
                    if (pointerType.QualifiedPointee.Qualifiers.IsConst)
                    {
                        return new TypeDefinition
                        {
                            Name = "string",
                            Attributes = new[] {"[MarshalAs(UnmanagedType.LPStr)]"}
                        };
                    }
                }

                var functionType = pointerType.Pointee as FunctionType;
                if (functionType != null)
                {
                    var @delegate = GetDelegate(name, functionType);
                    _context.AddUnit(@delegate);

                    return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
                }
            }
            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
        }

        internal FunctionParameter GetParameter(Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(name, parameter.Type)
            };
        }

        private DelegateDefinition GetDelegate(string name, FunctionType functionType)
        {
            return new DelegateDefinition
            {
                Name = name,
                ReturnType = TypeHelper.GetReturnTypeName(functionType.ReturnType.Type),
                Parameters = functionType.Parameters.Select(GetParameter).ToArray()
            };
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