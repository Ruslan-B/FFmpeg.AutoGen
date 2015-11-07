using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class TypeDefVisitor
    {
        private readonly IndentedTextWriter m_tw;
        private readonly ISet<string> m_visitedTypeDefs;

        public TypeDefVisitor(IndentedTextWriter tw, ISet<string> visitedTypeDefs)
        {
            m_tw = tw;
            m_visitedTypeDefs = visitedTypeDefs;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var value = cursor.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                Console.WriteLine(value);

                if (value.Contains(@"SWS_FAST_BILINEAR"))
                {
                    Debug.Assert(false);
                }
            }

            var curKind = clang.getCursorKind(cursor);
            if (curKind == CXCursorKind.CXCursor_TypedefDecl)
            {
                var spelling = clang.getCursorSpelling(cursor).ToString();

                if (m_visitedTypeDefs.Contains(spelling))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                m_visitedTypeDefs.Add(spelling);

                var type = clang.getCanonicalType(clang.getTypedefDeclUnderlyingType(cursor));

                // we handle enums and records in struct and enum visitors with forward declarations also
                if (type.kind == CXTypeKind.CXType_Record || type.kind == CXTypeKind.CXType_Enum)
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                // no idea what this is? -- template stuff?
                if (type.kind == CXTypeKind.CXType_Unexposed)
                {
                    var canonical = clang.getCanonicalType(type);
                    if (canonical.kind == CXTypeKind.CXType_Unexposed)
                    {
                        return CXChildVisitResult.CXChildVisit_Continue;
                    }
                }

                if (type.kind == CXTypeKind.CXType_Pointer)
                {
                    var pointee = clang.getPointeeType(type);
                    if (pointee.kind == CXTypeKind.CXType_Record || pointee.kind == CXTypeKind.CXType_Void)
                    {
                        m_tw.WriteLine(@"public partial struct " + spelling);
                        m_tw.WriteLine(@"{");
                        m_tw.WriteLine(@"    public " + spelling + @"(IntPtr pointer)");
                        m_tw.WriteLine(@"    {");
                        m_tw.WriteLine(@"        this.Pointer = pointer;");
                        m_tw.WriteLine(@"    }");
                        m_tw.WriteLine();
                        m_tw.WriteLine(@"    public IntPtr Pointer;");
                        m_tw.WriteLine(@"}");
                        m_tw.WriteLine();

                        return CXChildVisitResult.CXChildVisit_Continue;
                    }

                    if (pointee.kind == CXTypeKind.CXType_FunctionProto)
                    {
                        m_tw.WriteLine(@"[UnmanagedFunctionPointer(" + pointee.CallingConventionSpelling() + ")]");
                        m_tw.Write(@"public unsafe delegate ");
                        FunctionHelper.WriteReturnType(clang.getResultType(pointee), m_tw);
                        m_tw.Write(@" ");
                        m_tw.Write(spelling);
                        m_tw.Write(@"(");

                        uint argumentCounter = 0;

                        clang.visitChildren(cursor, delegate(CXCursor cxCursor, CXCursor parent1, IntPtr ptr)
                        {
                            if (cxCursor.kind == CXCursorKind.CXCursor_ParmDecl)
                            {
                                FunctionHelper.WriteArgument(pointee, cxCursor, m_tw, argumentCounter++);
                            }

                            return CXChildVisitResult.CXChildVisit_Continue;
                        }, new CXClientData(IntPtr.Zero));

                        m_tw.WriteLine(@");");
                        m_tw.WriteLine();

                        return CXChildVisitResult.CXChildVisit_Continue;
                    }
                }

                if (clang.isPODType(type) != 0)
                {
                    var podType = type.ToPlainTypeString();
                    m_tw.WriteLine(@"public partial struct " + spelling);
                    m_tw.WriteLine(@"{");
                    m_tw.WriteLine(@"    public " + spelling + @"(" + podType + @" value)");
                    m_tw.WriteLine(@"    {");
                    m_tw.WriteLine(@"        this.Value = value;");
                    m_tw.WriteLine(@"    }");
                    m_tw.WriteLine();
                    m_tw.WriteLine(@"    public " + type.ToPlainTypeString() + @" Value;");
                    m_tw.WriteLine(@"}");
                    m_tw.WriteLine();
                }

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }
    }
}