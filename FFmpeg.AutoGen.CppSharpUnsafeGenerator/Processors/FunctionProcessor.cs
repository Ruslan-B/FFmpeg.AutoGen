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
                    Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray(),
                    IsObsolete = function.PreprocessedEntities.OfType<MacroExpansion>().Any(x => x.Text == "attribute_deprecated")
                };
                _context.AddUnit(functionDefinition);
                counter++;
            }
        }

        internal FunctionParameter GetParameter(Function function, Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(_context, function.Name + "_" + name, parameter.Type),
                Content = GetParamComment(function, parameter.Name)
            };
        }


        internal static TypeDefinition GetParameterType(GenerationContext context, string name, Type type)
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
                    var @delegate = GetDelegate(context, name, functionType);
                    context.AddUnit(@delegate);
                    return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
                }
            }
            return new TypeDefinition {Name = TypeHelper.GetTypeName(type)};
        }

        internal static FunctionParameter GetParameter(GenerationContext context, Parameter parameter, int position)
        {
            var name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
            return new FunctionParameter
            {
                Name = name,
                Type = GetParameterType(context, name, parameter.Type)
            };
        }

        private static DelegateDefinition GetDelegate(GenerationContext context, string name, FunctionType functionType)
        {
            return new DelegateDefinition
            {
                Name = name,
                ReturnType = TypeHelper.GetReturnTypeName(functionType.ReturnType.Type),
                Parameters = functionType.Parameters.Select((x, i) => GetParameter(context, x, i)).ToArray()
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