using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CppSharp;
using CppSharp.AST;
using CppSharp.Parser;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Builder;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Writers;
using ClangParser = CppSharp.ClangParser;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class GenerationContext
    {
        public List<ICanGenerateDefinition> Units { get; } = new List<ICanGenerateDefinition>();
    }

    internal class Generator
    {
        private readonly GenerationContext _generationContext = new GenerationContext();
        private ASTContext _astContext;
        private bool _hasParsingErrors;
        private ParserTargetInfo _targetInfo;


        public string[] Defines { get; set; } = {};
        public string[] IncludeDirs { get; set; } = {};
        public string[] SourceFiles { get; set; } = {};
        public FunctionExport[] Exports { get; set; }

        public string Namespace { get; set; }
        public string LibraryName { get; set; }
        public string OutputFile { get; set; }
        public string LibraryConstantName { get; set; }

        public void Run()
        {
            _hasParsingErrors = false;
            Parse();
            if (_hasParsingErrors) return;

            Generate();

            Write();
        }

        private void Parse()
        {
            var parserOptions = new ParserOptions();
            parserOptions.SetupIncludes();
            parserOptions.ASTContext = new CppSharp.Parser.AST.ASTContext();


            foreach (var includeDir in IncludeDirs)
                parserOptions.AddIncludeDirs(includeDir);

            foreach (var define in Defines)
                parserOptions.AddDefines(define);

            var project = new Project();
            foreach (var filePath in SourceFiles)
            {
                var sourceFile = project.AddFile(filePath);
                sourceFile.Options = parserOptions;
            }

            var clangParser = new ClangParser(new CppSharp.Parser.AST.ASTContext());
            clangParser.SourcesParsed += OnSourceFileParsed;
            clangParser.ParseProject(project, false);
            _targetInfo = clangParser.GetTargetInfo(parserOptions);
            _astContext = ClangParser.ConvertASTContext(clangParser.ASTContext);
        }

        private void OnSourceFileParsed(IList<SourceFile> files, ParserResult result)
        {
            switch (result.Kind)
            {
                case ParserResultKind.Success:
                    Diagnostics.Message("Parsed '{0}'", string.Join(", ", files));
                    break;
                case ParserResultKind.Error:
                    Diagnostics.Error("Error parsing '{0}'", string.Join(", ", files));
                    _hasParsingErrors = true;
                    break;
                case ParserResultKind.FileNotFound:
                    Diagnostics.Error("A file from '{0}' was not found", string.Join(",", files));
                    break;
            }
            for (uint i = 0; i < result.DiagnosticsCount; ++i)
            {
                var diagnostics = result.GetDiagnostics(i);

                var message = $"{diagnostics.FileName}({diagnostics.LineNumber},{diagnostics.ColumnNumber}): " +
                              $"{diagnostics.Level.ToString().ToLower()}: {diagnostics.Message}";
                Diagnostics.Message(message);
            }
        }

        private void Generate()
        {
            var ep = new EnumerationProcessor(_generationContext);
            var sp = new StructureProcessor(_generationContext);
            var fp = new FunctionProcessor(_generationContext);
            foreach (var translationUnit in _astContext.TranslationUnits.Where(x => !x.IsSystemHeader))
            {
                ep.Process(translationUnit);
                sp.Process(translationUnit);
                fp.Process(translationUnit);
            }
        }


        private void Write()
        {
            using (var streamWriter = File.CreateText(OutputFile))
            using (var textWriter = new IndentedTextWriter(streamWriter))
            {
                var writer = new Writer(textWriter, LibraryConstantName);
                textWriter.WriteLine("using System;");
                textWriter.WriteLine("using System.Runtime.InteropServices;");
                textWriter.WriteLine();
                textWriter.WriteLine($"namespace {Namespace}");
                using (textWriter.BeginBlock())
                {
                    var units = _generationContext.Units;
                    units.OfType<EnumerationDefinition>().ToList().ForEach(x =>
                    {
                        writer.Write(x);
                        textWriter.WriteLine();
                    });

                    units.OfType<StructureDefinition>().ToList().ForEach(x =>
                    {
                        writer.Write(x);
                        textWriter.WriteLine();
                    });

                    string className = "ffmpeg";
                    textWriter.WriteLine($"public unsafe static partial class {className}");
                    using (textWriter.BeginBlock())
                    {
                        textWriter.WriteLine($"public const string {LibraryConstantName} = \"{LibraryName}\";");
                        
                        units.OfType<FunctionDefinition>().ToList().ForEach(x =>
                        {
                            writer.Write(x);
                            textWriter.WriteLine();
                        });
                    }
                }
            }
        }
    }
}