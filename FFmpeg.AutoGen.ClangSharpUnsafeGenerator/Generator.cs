using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class Generator
    {
        private readonly Dictionary<string, string> _exportMap;
        private readonly string[] _includeDirs;
        private readonly string[] _definitions;
        private readonly string _methodClassName;
        private readonly string _namespace;
        private readonly ISet<string> _visitedEnums = new HashSet<string>();
        private readonly ISet<string> _visitedFunction = new HashSet<string>();
        private readonly ISet<string> _visitedMacros = new HashSet<string>();
        private readonly ISet<string> _visitedStructs = new HashSet<string>();
        private readonly ISet<string> _visitedTypeDefs = new HashSet<string>();

        public Generator(string[] includeDirs, string[] definitions,  string @namespace, string methodClassName, IEnumerable<FunctionExport> exports)
        {
            _includeDirs = includeDirs;
            _definitions = definitions;
            _namespace = @namespace;
            _methodClassName = methodClassName;
            _exportMap = exports.ToDictionary(x => x.Name, x => x.Library);
        }

        public void Generate(string[] inputFiles, string outputFile, string libraryVarName, string libraryName)
        {
            string[] arr = {@"-x", @"c++" };
            arr = arr.Concat(_definitions.Select(x => @"-D" + x)).ToArray();
            arr = arr.Concat(_includeDirs.Select(x => @"-I" + x)).ToArray();

            var translationUnits = new List<CXTranslationUnit>();

            var index = clang.createIndex(0, 1);


            foreach (var file in inputFiles)
            {
                CXTranslationUnit translationUnit;
                CXUnsavedFile unsavedFile;
                var options = (uint) CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
                var translationUnitError = clang.parseTranslationUnit2(index, file, arr, arr.Length, out unsavedFile, 0, options, out translationUnit);

                if (translationUnitError != CXErrorCode.CXError_Success)
                {
                    Console.WriteLine(@"Error: " + translationUnitError);
                    var numDiagnostics = clang.getNumDiagnostics(translationUnit);

                    for (uint i = 0; i < numDiagnostics; ++i)
                    {
                        var diagnostic = clang.getDiagnostic(translationUnit, i);
                        Console.WriteLine(clang.getDiagnosticSpelling(diagnostic).ToString());
                        clang.disposeDiagnostic(diagnostic);
                    }
                }

                translationUnits.Add(translationUnit);
            }

            using (var fileStream = new FileStream(outputFile, FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    using (var sw = new IndentedTextWriter(streamWriter))
                    {
                        sw.WriteLine(@"using System;");
                        sw.WriteLine(@"using System.Runtime.InteropServices;");
                        sw.WriteLine();

                        sw.WriteLine(@"namespace " + _namespace);
                        sw.WriteLine(@"{");

                        sw.Indent++;

                        var structVisitor = new StructVisitor(sw, _visitedStructs);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), structVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var typeDefVisitor = new TypeDefVisitor(sw, _visitedTypeDefs);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), typeDefVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var enumVisitor = new EnumVisitor(sw, _visitedEnums);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), enumVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        sw.WriteLine(@"public unsafe static partial class " + _methodClassName);
                        sw.WriteLine(@"{");

                        sw.Indent++;

                        var macroVisitor = new MacroVisitor(sw, _visitedMacros);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), macroVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var functionVisitor = new FunctionVisitor(sw, _visitedFunction, libraryName, libraryVarName, _exportMap);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), functionVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        sw.Indent--;

                        sw.WriteLine("}");

                        sw.Indent--;

                        sw.WriteLine(@"}");
                    }
                }
            }

            translationUnits.ForEach(clang.disposeTranslationUnit);

            clang.disposeIndex(index);
        }

        public void OutputStatistic()
        {
            Console.WriteLine(@"Enums: {0}.", _visitedEnums.Count);
            Console.WriteLine(@"Structs: {0}.", _visitedStructs.Count);
            Console.WriteLine(@"Defs: {0}.", _visitedTypeDefs.Count);
            Console.WriteLine(@"Macros: {0}.", _visitedMacros.Count);
            Console.WriteLine(@"Functions: {0}.", _visitedFunction.Count);
        }
    }
}