using System;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class FunctionProcessor
    {
        private readonly GenerationContext _context;

        public FunctionProcessor(GenerationContext context)
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
                    Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray()
                };
                _context.AddUnit(functionDefinition);
                counter++;
            }
        }

        internal static FunctionParameter GetParameter(Function function, Parameter parameter, int position)
        {
            return new FunctionParameter
            {
                Name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name,
                Type = GetParameterType(parameter.Type),
                Content = GetParamComment(function, parameter.Name)
            };
        }

        private static TypeDefinition GetParameterType(Type type)
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
            var builtinType = pointerType?.Pointee as BuiltinType;
            if (pointerType != null && builtinType != null && builtinType.Type == PrimitiveType.Char)
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
            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
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