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
                    ReturnType = GetReturnTypeName(function.ReturnType.Type),
                    Content = function.Comment?.BriefText,
                    LibraryName = export.Library,
                    Parameters = function.Parameters.Select(x => new FunctionParameter
                    {
                        Name = string.IsNullOrEmpty(x.Name) ? $"p{counter}" : x.Name,
                        Type = GetParameterType(x.Type),
                        Content = GetParamComment(function, x)
                    }).ToArray()
                };
                _context.AddUnit(functionDefinition);
                counter++;
            }
        }

        private static TypeDefinition GetParameterType(Type type)
        {
            var pointerType = type as PointerType;
            var builtinType = pointerType?.Pointee as BuiltinType;
            if (pointerType != null && builtinType != null && builtinType.Type == PrimitiveType.Char)
                if (pointerType.QualifiedPointee.Qualifiers.IsConst)
                    return
                        new TypeDefinition
                        {
                            Name = "string",
                            Attributes = new[] { "[MarshalAs(UnmanagedType.LPStr)] " }
                        };
                else
                {
                    // todo check what to do here

                }
            return new TypeDefinition { Name = TypeHelper.GetTypeName(type) };
        }

        private static TypeDefinition GetReturnTypeName(Type type)
        {
            var pointerType = type as PointerType;
            var builtinType = pointerType?.Pointee as BuiltinType;
            if (pointerType != null && builtinType != null && builtinType.Type == PrimitiveType.Char)
                if (pointerType.QualifiedPointee.Qualifiers.IsConst)
                    return
                        new TypeDefinition
                        {
                            Name = "string",
                            Attributes = new[] { "[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]" }
                        };
                else
                {
                    // todo check what to do here
                    
                }
            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
        }

        private static string GetParamComment(Function function, Parameter parameter)
        {
            var comment = function.Comment?.FullComment.Blocks
                .OfType<ParamCommandComment>()
                .FirstOrDefault(x => x.Arguments.Count == 1 && x.Arguments[0].Text == parameter.Name);
            return comment == null ? null : string.Join(" ", comment.ParagraphComment.Content.OfType<TextComment>().Select(x => x.Text.Trim()));
        }
    }
}