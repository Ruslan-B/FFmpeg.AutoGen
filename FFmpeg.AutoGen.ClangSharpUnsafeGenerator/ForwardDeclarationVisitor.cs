using System;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class ForwardDeclarationVisitor
    {
        private readonly CXCursor m_beginningCursor;

        private bool m_beginningCursorReached;

        public ForwardDeclarationVisitor(CXCursor beginningCursor)
        {
            m_beginningCursor = beginningCursor;
        }

        public CXCursor ForwardDeclarationCursor { get; private set; }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            if (clang.equalCursors(cursor, m_beginningCursor) != 0)
            {
                m_beginningCursorReached = true;
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            if (m_beginningCursorReached)
            {
                ForwardDeclarationCursor = cursor;
                return CXChildVisitResult.CXChildVisit_Break;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }
    }
}