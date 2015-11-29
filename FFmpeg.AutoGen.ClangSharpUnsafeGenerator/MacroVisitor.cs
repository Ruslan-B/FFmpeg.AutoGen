using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class MacroVisitor
    {
        private readonly IndentedTextWriter m_tw;
        private readonly ISet<string> m_visitedMacros;

        public MacroVisitor(IndentedTextWriter tw, ISet<string> visitedMacros)
        {
            m_tw = tw;
            m_visitedMacros = visitedMacros;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var cursorKind = cursor.kind;
            if (cursorKind == CXCursorKind.CXCursor_MacroDefinition)
            {
                var macroName = clang.getCursorSpelling(cursor).ToString();

                if (m_visitedMacros.Contains(macroName))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_visitedMacros.Add(macroName);

                var expression = getMacroExpression(cursor);
                if (string.IsNullOrWhiteSpace(expression))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_tw.WriteLine(@"public const int {0} = {1};", macroName, expression);
            }

            return CXChildVisitResult.CXChildVisit_Continue;
        }

        private string getMacroExpression(CXCursor cursor)
        {
            var tu = clang.Cursor_getTranslationUnit(cursor);
            var range = clang.getCursorExtent(cursor);

            IntPtr pTokens;
            uint numTokens;
            clang.tokenize(tu, range, out pTokens, out numTokens);

            var sbValue = new StringBuilder();
            for (var n = 1; n < numTokens; n++)
            {
                var offset = n*Marshal.SizeOf<CXToken>();
                var token = Marshal.PtrToStructure<CXToken>(pTokens + offset);

                var tokenKind = clang.getTokenKind(token);
                if (tokenKind != CXTokenKind.CXToken_Comment)
                {
                    var spelling = clang.getTokenSpelling(tu, token).ToString();
                    if (spelling == @"#" ||
                        spelling == @"}" ||
                        spelling == @"L" ||
                        spelling == @"enum" ||
                        spelling == @"int" ||
                        spelling == @"int8_t" ||
                        spelling == @"int64_t" ||
                        spelling == @"struct" ||
                        spelling == @"typedef")
                    {
                        continue;
                    }
                    sbValue.Append(spelling);
                }
            }

            disposeTokens(tu, pTokens, numTokens);

            return sbValue.ToString();
        }

        [DllImport(@"libclang.dll", EntryPoint = @"clang_disposeTokens", CallingConvention = CallingConvention.Cdecl)]
        private static extern void disposeTokens(CXTranslationUnit tu, IntPtr tokens, uint numTokens);
    }
}