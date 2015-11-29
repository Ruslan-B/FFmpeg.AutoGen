using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class FunctionVisitor
    {
        private readonly string m_libraryName;
        private readonly string m_libraryVarName;
        private readonly Dictionary<string, string> m_exportMap;
        private readonly string m_prefixStrip;
        private readonly IndentedTextWriter m_tw;
        private readonly ISet<string> m_visitedFunctions;

        public FunctionVisitor(IndentedTextWriter tw,
            ISet<string> visitedFunctions,
            string libraryName,
            string libraryVarName,
            Dictionary<string, string> exportMap,
            string prefixStrip = @"")
        {
            m_tw = tw;
            m_visitedFunctions = visitedFunctions;
            m_libraryName = libraryName;
            m_libraryVarName = libraryVarName;
            m_exportMap = exportMap;
            m_prefixStrip = prefixStrip;

            m_tw.WriteLine(@"private const string {0} = ""{1}"";", m_libraryVarName, m_libraryName);
            m_tw.WriteLine();
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var cursorKind = clang.getCursorKind(cursor);

            // look only at function decls
            if (cursorKind == CXCursorKind.CXCursor_FunctionDecl)
            {
                var functionName = clang.getCursorSpelling(cursor).ToString();
                
                if (m_visitedFunctions.Contains(functionName))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                string libraryName;
                if (m_exportMap.TryGetValue(functionName, out libraryName))
                {
                    if (!string.Equals(libraryName, m_libraryName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        string message = string.Format(@"Warning: Function {0} belongs to {1}. Skipping generation for {2}.",
                            functionName, libraryName, m_libraryName);
                        Console.WriteLine(message);
                        return CXChildVisitResult.CXChildVisit_Continue;
                    }
                }
                else
                {
                    m_visitedFunctions.Add(functionName);

                    string message = string.Format(@"Info: Unknow function export {0}. Skipping generation for {1}.",
                           functionName, m_libraryName);
                    Console.WriteLine(message);
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_visitedFunctions.Add(functionName);

                WriteFunction(cursor, m_prefixStrip);

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        public void WriteFunction(CXCursor cursor, string prefixStrip)
        {
            var functionType = clang.getCursorType(cursor);
            var functionName = clang.getCursorSpelling(cursor).ToString();
            var resultType = clang.getCursorResultType(cursor);

            m_tw.WriteLine(@"[DllImport({0}, EntryPoint = ""{1}"", CallingConvention = {2})]",
                m_libraryVarName,
                functionName,
                functionType.CallingConventionSpelling());
            m_tw.Write(@"public static extern ");

            FunctionHelper.WriteReturnType(resultType, m_tw);

            if (functionName.StartsWith(prefixStrip))
            {
                functionName = functionName.Substring(prefixStrip.Length);
            }

            m_tw.Write(@" " + functionName + @"(");

            var numArgTypes = clang.getNumArgTypes(functionType);

            for (uint i = 0; i < numArgTypes; ++i)
            {
                FunctionHelper.WriteArgument(functionType, clang.Cursor_getArgument(cursor, i), m_tw, i);
            }

            m_tw.WriteLine(@");");
            m_tw.WriteLine();
        }
    }
}