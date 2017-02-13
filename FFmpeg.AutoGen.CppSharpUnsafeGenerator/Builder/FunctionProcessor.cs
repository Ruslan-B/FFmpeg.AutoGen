using System;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Builder
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
            int counter = 0;
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
                    ReturnTypeName = TypeHelper.GetTypeName(function.ReturnType.Type),
                    Content = function.Comment?.BriefText,
                    LibraryName = export.Library,
                    Parameters = function.Parameters.Select(x => new FunctionParameter
                    {
                        Name = string.IsNullOrEmpty(x.Name) ? $"p{counter}" : x.Name,
                        TypeName = TypeHelper.GetTypeName(x.Type),
                        Content = GetParamComment(function,x)
                    }).ToArray()
                };
                _context.Units.Add(functionDefinition);
                counter++;
            }
        }

        private static string GetParamComment(Function function, Parameter parameter)
        {
            var comment = function.Comment?.FullComment.Blocks
                .OfType<ParamCommandComment>()
                .FirstOrDefault(x => x.Arguments.Count == 1 && x.Arguments[0].Text == parameter.Name);
            return comment == null ? null : string.Join(" ", comment.ParagraphComment.Content.OfType<TextComment>().Select(x=>x.Text.Trim()));
        }
    }
}