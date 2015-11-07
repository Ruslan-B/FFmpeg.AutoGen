using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class EnumVisitor
    {
        private readonly IndentedTextWriter m_tw;
        private readonly ISet<string> m_visitedEnums;

        public EnumVisitor(IndentedTextWriter tw, ISet<string> visitedEnums)
        {
            m_tw = tw;
            m_visitedEnums = visitedEnums;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var curKind = clang.getCursorKind(cursor);
            if (curKind == CXCursorKind.CXCursor_EnumDecl)
            {
                var kind = clang.getEnumDeclIntegerType(cursor).kind;

                string inheritedEnumType;
                switch (kind)
                {
                    case CXTypeKind.CXType_Int:
                        inheritedEnumType = @"int";
                        break;
                    case CXTypeKind.CXType_UInt:
                        inheritedEnumType = @"uint";
                        break;
                    case CXTypeKind.CXType_Short:
                        inheritedEnumType = @"short";
                        break;
                    case CXTypeKind.CXType_UShort:
                        inheritedEnumType = @"ushort";
                        break;
                    case CXTypeKind.CXType_LongLong:
                        inheritedEnumType = @"long";
                        break;
                    case CXTypeKind.CXType_ULongLong:
                        inheritedEnumType = @"ulong";
                        break;
                    default:
                        inheritedEnumType = @"int";
                        break;
                }

                var enumName = clang.getCursorSpelling(cursor).ToString();

                // enumName can be empty because of typedef enum { .. } enumName;
                // so we have to find the sibling, and this is the only way I've found
                // to do with libclang, maybe there is a better way?
                if (string.IsNullOrEmpty(enumName))
                {
                    var forwardDeclaringVisitor = new ForwardDeclarationVisitor(cursor);
                    clang.visitChildren(clang.getCursorLexicalParent(cursor), forwardDeclaringVisitor.Visit, new CXClientData(IntPtr.Zero));
                    enumName = clang.getCursorSpelling(forwardDeclaringVisitor.ForwardDeclarationCursor).ToString();

                    if (string.IsNullOrEmpty(enumName))
                    {
                        enumName = @"_";
                    }
                }

                // if we've printed these previously, skip them
                if (m_visitedEnums.Contains(enumName))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_visitedEnums.Add(enumName);

                m_tw.WriteLine(@"public enum " + enumName + @" : " + inheritedEnumType);
                m_tw.WriteLine(@"{");

                m_tw.Indent ++;

                // visit all the enum values
                clang.visitChildren(cursor, (cxCursor, _, __) =>
                {
                    m_tw.WriteLine(@"@" + clang.getCursorSpelling(cxCursor).ToString() + @" = " + clang.getEnumConstantDeclValue(cxCursor) + ",");
                    return CXChildVisitResult.CXChildVisit_Continue;
                }, new CXClientData(IntPtr.Zero));

                m_tw.Indent--;

                m_tw.WriteLine(@"}");
                m_tw.WriteLine();
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }
    }
}