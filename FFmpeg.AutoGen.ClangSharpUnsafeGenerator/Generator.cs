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
        private readonly string[] m_includeDirs;
        private readonly string m_methodClassName;
        private readonly string m_namespace;
        private readonly ISet<string> m_visitedEnums = new HashSet<string>();
        private readonly ISet<string> m_visitedFunction = new HashSet<string>();
        private readonly ISet<string> m_visitedStructs = new HashSet<string>();
        private readonly ISet<string> m_visitedTypeDefs = new HashSet<string>();
        private readonly ISet<string> m_visitedMacros = new HashSet<string>();

        public Generator(string[] includeDirs, string @namespace, string methodClassName)
        {
            m_includeDirs = includeDirs;
            m_namespace = @namespace;
            m_methodClassName = methodClassName;
        }

        public void Generate(string[] inputFiles, string outputFile, string libraryVarName, string libraryName)
        {
            string[] arr = { @"-x", @"c++" };

            arr = arr.Concat(m_includeDirs.Select(x => @"-I" + x)).ToArray();

            var translationUnits = new List<CXTranslationUnit>();

            var index = clang.createIndex(0, 1);


            foreach (var file in inputFiles)
            {
                CXTranslationUnit translationUnit;
                CXUnsavedFile unsavedFile;
                var options = (uint)CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
                var translationUnitError = clang.parseTranslationUnit2(index, file, arr, 3, out unsavedFile, 0, options, out translationUnit);

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

                        sw.WriteLine(@"namespace " + m_namespace);
                        sw.WriteLine(@"{");

                        sw.Indent++;

                        var structVisitor = new StructVisitor(sw, m_visitedStructs);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), structVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var typeDefVisitor = new TypeDefVisitor(sw, m_visitedTypeDefs);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), typeDefVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var enumVisitor = new EnumVisitor(sw, m_visitedEnums);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), enumVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        sw.WriteLine(@"public unsafe static partial class " + m_methodClassName);
                        sw.WriteLine(@"{");

                        sw.Indent++;

                        var macroVisitor = new MacroVisitor(sw, m_visitedMacros);
                        foreach (var tu in translationUnits)
                        {
                            clang.visitChildren(clang.getTranslationUnitCursor(tu), macroVisitor.Visit, new CXClientData(IntPtr.Zero));
                        }

                        var functionVisitor = new FunctionVisitor(sw, m_visitedFunction, libraryName, libraryVarName);
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
    }
}