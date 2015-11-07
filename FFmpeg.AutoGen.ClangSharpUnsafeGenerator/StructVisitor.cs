using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class StructVisitor
    {
        private readonly Stack<Action> m_defferedVisits = new Stack<Action>();
        private readonly IndentedTextWriter m_tw;
        private readonly ISet<string> m_visitedStructs;
        private bool m_hasChildren;
        private bool m_writingStruct;

        public StructVisitor(IndentedTextWriter tw, ISet<string> visitedStructs)
        {
            m_tw = tw;
            m_visitedStructs = visitedStructs;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr clientData)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var curKind = clang.getCursorKind(cursor);
            if (curKind == CXCursorKind.CXCursor_StructDecl || curKind == CXCursorKind.CXCursor_UnionDecl)
            {
                if (m_writingStruct)
                {
                    Action defferedVisit = () => Visit(cursor, parent, clientData);
                    m_defferedVisits.Push(defferedVisit);
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_writingStruct = true;

                var structName = clang.getCursorSpelling(cursor).ToString();

                // struct names can be empty, and so we visit its sibling to find the name
                if (string.IsNullOrEmpty(structName))
                {
                    var forwardDeclaringVisitor = new ForwardDeclarationVisitor(cursor);
                    clang.visitChildren(clang.getCursorSemanticParent(cursor), forwardDeclaringVisitor.Visit, new CXClientData(IntPtr.Zero));
                    structName = clang.getCursorSpelling(forwardDeclaringVisitor.ForwardDeclarationCursor).ToString();

                    if (string.IsNullOrEmpty(structName))
                    {
                        structName = @"_";
                    }
                }

                if (!m_visitedStructs.Contains(structName))
                {
                    //m_tw.WriteLine(@"[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]");
                    m_tw.WriteLine(@"public unsafe partial struct " + structName);
                    m_tw.WriteLine(@"{");

                    m_hasChildren = false;

                    m_tw.Indent++;
                    clang.visitChildren(cursor, Visit, new CXClientData(IntPtr.Zero));
                    m_tw.Indent--;

                    m_tw.WriteLine(@"}");
                    m_tw.WriteLine();

                    if (m_hasChildren)
                    {
                        m_visitedStructs.Add(structName);
                    }
                }

                m_writingStruct = false;
                while (m_defferedVisits.Count > 0)
                {
                    var defferedVisit = m_defferedVisits.Pop();
                    defferedVisit();
                }

                //var fieldPosition = 0;

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            if (curKind == CXCursorKind.CXCursor_FieldDecl)
            {
                m_hasChildren = true;

                var fieldName = clang.getCursorSpelling(cursor).ToString();
                if (string.IsNullOrEmpty(fieldName))
                {
                    throw new NotSupportedException();
                    //fieldName = @"field" + fieldPosition; // what if they have fields called field*? :)
                }

                //fieldPosition++;

                m_tw.WriteLine(ToMarshalString(cursor, fieldName));

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        public string ToMarshalString(CXCursor cursor, string cursorSpelling)
        {
            var canonical = clang.getCanonicalType(clang.getCursorType(cursor));

            switch (canonical.kind)
            {
                case CXTypeKind.CXType_ConstantArray:
                {
                    var arraySize = clang.getArraySize(canonical);
                    var elementType = clang.getCanonicalType(clang.getArrayElementType(canonical));

                    switch (elementType.kind)
                    {
                        case CXTypeKind.CXType_Bool:
                        case CXTypeKind.CXType_UChar:
                        case CXTypeKind.CXType_Char_U:
                        case CXTypeKind.CXType_SChar:
                        case CXTypeKind.CXType_Char_S:
                        case CXTypeKind.CXType_UShort:
                        case CXTypeKind.CXType_Short:
                        case CXTypeKind.CXType_Float:
                        case CXTypeKind.CXType_Double:
                        case CXTypeKind.CXType_Int:
                        case CXTypeKind.CXType_UInt:
                        case CXTypeKind.CXType_Long:
                        case CXTypeKind.CXType_ULong:
                        case CXTypeKind.CXType_LongLong:
                        case CXTypeKind.CXType_ULongLong:
                        {
                            var typeString = elementType.ToPlainTypeString();
                            return string.Format(@"public fixed {0} @{1}[{2}]; ", typeString, cursorSpelling, arraySize);
                        }
                        case CXTypeKind.CXType_ConstantArray:
                        {
                            var sb = new StringBuilder();
                            var nestedElementType = clang.getCanonicalType(clang.getArrayElementType(elementType));
                            var nestedArraySize = clang.getArraySize(elementType);
                            var typeString = GetTypeName(cursorSpelling, nestedElementType);
                            for (var i = 0; i < arraySize; ++i)
                            {
                                sb.AppendFormat(@"public fixed {0} @{1}{2}[{3}]; ", typeString, cursorSpelling, i, nestedArraySize);
                            }
                            return sb.ToString();
                        }
                        default:
                        {
                            var sb = new StringBuilder();
                            var typeString = GetTypeName(cursorSpelling, elementType);
                            for (var i = 0; i < arraySize; ++i)
                            {
                                sb.AppendFormat(@"public {0} @{1}{2}; ", typeString, cursorSpelling, i);
                            }

                            return sb.ToString();
                        }
                    }
                }
                case CXTypeKind.CXType_Char_S:
                    // todo recheck why
                    //return @"[MarshalAs(UnmanagedType.LPStr)] public string @" + cursorSpelling + @";";
                    return @"public sbyte* @" + cursorSpelling + @"; // ansi string ";
                case CXTypeKind.CXType_WChar:
                    return @"[MarshalAs(UnmanagedType.LPWStr)] public string @" + cursorSpelling + @";";
                default:
                {
                    var typeString = GetTypeName(cursorSpelling, canonical);
                    return @"public " + typeString + @" @" + cursorSpelling + @";";
                }
            }
        }

        private static string GetTypeName(string cursorSpelling, CXType type)
        {
            var canonical = clang.getCanonicalType(type);
            switch (canonical.kind)
            {
                case CXTypeKind.CXType_Pointer:
                    var pointeeType = clang.getCanonicalType(clang.getPointeeType(canonical));
                    switch (pointeeType.kind)
                    {
                        case CXTypeKind.CXType_ConstantArray:
                        case CXTypeKind.CXType_FunctionProto:
                            return @"IntPtr";
                        default:
                            return GetTypeName(cursorSpelling, pointeeType) + @"*";
                    }

                default:
                    var typeString = canonical.ToPlainTypeString();
                    if (typeString.Contains(@"anonymous union at") || typeString.Contains(@"anonymous struct at") || typeString.Contains(@"anonymous enum at"))
                    {
                        typeString = cursorSpelling;
                    }
                    return typeString;
            }
        }
    }
}