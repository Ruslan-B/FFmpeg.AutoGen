using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class FunctionVisitor
    {
        private readonly Dictionary<string, string> _exportMap;
        private readonly string _libraryName;
        private readonly string _libraryVarName;
        private readonly string _prefixStrip;
        private readonly IndentedTextWriter _tw;
        private readonly ISet<string> _visitedFunctions;

        public FunctionVisitor(IndentedTextWriter tw,
            ISet<string> visitedFunctions,
            string libraryName,
            string libraryVarName,
            Dictionary<string, string> exportMap,
            string prefixStrip = @"")
        {
            _tw = tw;
            _visitedFunctions = visitedFunctions;
            _libraryName = libraryName;
            _libraryVarName = libraryVarName;
            _exportMap = exportMap;
            _prefixStrip = prefixStrip;

            _tw.WriteLine($@"private const string {_libraryVarName} = ""{_libraryName}"";");
            _tw.WriteLine();
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
                return CXChildVisitResult.CXChildVisit_Continue;

            var cursorKind = clang.getCursorKind(cursor);

            // look only at function decls
            if (cursorKind == CXCursorKind.CXCursor_FunctionDecl)
            {
                var functionName = clang.getCursorSpelling(cursor).ToString();

                if (_visitedFunctions.Contains(functionName))
                    return CXChildVisitResult.CXChildVisit_Continue;

                string libraryName;
                if (_exportMap.TryGetValue(functionName, out libraryName))
                {
                    if (!string.Equals(libraryName, _libraryName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        string message = $@"Warning: Function {functionName} belongs to {libraryName}. Skipping generation for {_libraryName}.";
                        Console.WriteLine(message);
                        return CXChildVisitResult.CXChildVisit_Continue;
                    }
                }
                else
                {
                    _visitedFunctions.Add(functionName);

                    string message = $@"Info: Unknow function export {functionName}. Skipping generation for {_libraryName}.";
                    Console.WriteLine(message);
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                _visitedFunctions.Add(functionName);

                WriteFunction(cursor, _prefixStrip);

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        private void WriteFunction(CXCursor cursor, string prefixStrip)
        {
            var functionType = clang.getCursorType(cursor);
            var functionName = clang.getCursorSpelling(cursor).ToString();
            var resultType = clang.getCursorResultType(cursor);

            _tw.WriteLine($@"[DllImport({_libraryVarName}, " +
                          $@"EntryPoint = ""{functionName}"", " +
                          $@"CallingConvention = {functionType.CallingConventionSpelling()}, CharSet = CharSet.Ansi)]");

            if (resultType.IsPtrToConstChar())
                _tw.WriteLine(@"[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]");

            _tw.Write(@"public static extern ");

            FunctionHelper.WriteReturnType(resultType, _tw);

            if (functionName.StartsWith(prefixStrip))
                functionName = functionName.Substring(prefixStrip.Length);

            _tw.Write(@" " + functionName + @"(");

            var numArgTypes = clang.getNumArgTypes(functionType);

            for (uint i = 0; i < numArgTypes; ++i)
                FunctionHelper.WriteArgument(functionType, clang.Cursor_getArgument(cursor, i), _tw, i);

            _tw.WriteLine(@");");
            _tw.WriteLine();
        }
    }
}