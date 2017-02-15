using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CppSharp;
using CppSharp.AST;
using CppSharp.Parser;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Writers;
using ClangParser = CppSharp.ClangParser;
using MacroDefinition = FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions.MacroDefinition;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Generator
    {
        private ASTContext _astContext;
        private bool _hasParsingErrors;
        private GenerationContext _generationContext;


        public string[] Defines { get; set; } = {};
        public string[] IncludeDirs { get; set; } = {};
        public string[] SourceFiles { get; set; } = {};
        public FunctionExport[] Exports { get; set; }

        public string Namespace { get; set; }
        public string OutputFile { get; set; }
        public string ClassName { get; set; }

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
            var parserOptions = new ParserOptions
            {
                Verbose = true,
                ASTContext = new CppSharp.Parser.AST.ASTContext(),
                LanguageVersion = LanguageVersion.GNUC,
            };
            parserOptions.SetupIncludes();

            foreach (var includeDir in IncludeDirs) parserOptions.AddIncludeDirs(includeDir);

            foreach (var define in Defines) parserOptions.AddDefines(define);

            var project = new Project();
            foreach (var filePath in SourceFiles)
            {
                var sourceFile = project.AddFile(filePath);
                sourceFile.Options = parserOptions;
            }

            var clangParser = new ClangParser(new CppSharp.Parser.AST.ASTContext());
            clangParser.SourcesParsed += OnSourceFileParsed;
            clangParser.ParseProject(project, false);
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
            if (_generationContext == null)
            {
                _generationContext = new GenerationContext
                {
                    FunctionExportMap = Exports.ToDictionary(x => x.Name)
                };
            }
            _generationContext.ClearUnits();

            var mp = new MacroProcessor(_generationContext);
            var ep = new EnumerationProcessor(_generationContext);
            var sp = new StructureProcessor(_generationContext);
            var fp = new FunctionProcessor(_generationContext);
            foreach (var translationUnit in _astContext.TranslationUnits.Where(x => !x.IsSystemHeader))
            {
                mp.Process(translationUnit);
                ep.Process(translationUnit);
                sp.Process(translationUnit);
                fp.Process(translationUnit);
            }
            var mpp = new MacroPostProcessor();
            var macros = _generationContext.Units.OfType<MacroDefinition>().ToArray();
            mpp.Process(macros);
        }
        
        private void Write()
        {
            using (var streamWriter = File.CreateText(OutputFile))
            using (var textWriter = new IndentedTextWriter(streamWriter))
            {
                var writer = new Writer(textWriter);
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

                    textWriter.WriteLine($"public unsafe static partial class {ClassName}");
                    using (textWriter.BeginBlock())
                    {
                        //textWriter.WriteLine($"public const string {LibraryConstantName} = \"{LibraryName}\";");

                        units.OfType<MacroDefinition>().ToList().ForEach(x => { writer.Write(x); });
                        textWriter.WriteLine();

                        units.OfType<FunctionDefinition>().ToList().ForEach(x =>
                        {
                            //if (x.LibraryName != LibraryName)
                            //{
                            //    Console.WriteLine($"Function {x.Name} exported in {x.LibraryName}.");
                            //}

                            writer.Write(x);
                            textWriter.WriteLine();
                        });
                    }
                }
            }
        }
    }
}