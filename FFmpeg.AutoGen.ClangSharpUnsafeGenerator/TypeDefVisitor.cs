using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class TypeDefVisitor
    {
        private readonly IndentedTextWriter _tw;
        private readonly ISet<string> _visitedTypeDefs;

        public TypeDefVisitor(IndentedTextWriter tw, ISet<string> visitedTypeDefs)
        {
            _tw = tw;
            _visitedTypeDefs = visitedTypeDefs;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var cursorKind = clang.getCursorKind(cursor);
            if (cursorKind == CXCursorKind.CXCursor_TypedefDecl)
            {
                var spelling = clang.getCursorSpelling(cursor).ToString();

                if (_visitedTypeDefs.Contains(spelling))
                {
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                _visitedTypeDefs.Add(spelling);

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
                        _tw.WriteLine(@"public partial struct " + spelling);
                        _tw.WriteLine(@"{");
                        _tw.WriteLine(@"    public " + spelling + @"(IntPtr pointer)");
                        _tw.WriteLine(@"    {");
                        _tw.WriteLine(@"        this.Pointer = pointer;");
                        _tw.WriteLine(@"    }");
                        _tw.WriteLine();
                        _tw.WriteLine(@"    public IntPtr Pointer;");
                        _tw.WriteLine(@"}");
                        _tw.WriteLine();

                        return CXChildVisitResult.CXChildVisit_Continue;
                    }

                    if (pointee.kind == CXTypeKind.CXType_FunctionProto)
                    {
                        WriteSelegate(cursor, pointee, spelling);

                        return CXChildVisitResult.CXChildVisit_Continue;
                    }
                }

                if (clang.isPODType(type) != 0)
                {
                    var podType = type.ToPlainTypeString();
                    _tw.WriteLine(@"public partial struct " + spelling);
                    _tw.WriteLine(@"{");
                    _tw.WriteLine(@"    public " + spelling + @"(" + podType + @" value)");
                    _tw.WriteLine(@"    {");
                    _tw.WriteLine(@"        this.Value = value;");
                    _tw.WriteLine(@"    }");
                    _tw.WriteLine();
                    _tw.WriteLine(@"    public " + type.ToPlainTypeString() + @" Value;");
                    _tw.WriteLine(@"}");
                    _tw.WriteLine();
                }

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        private void WriteSelegate(CXCursor cursor, CXType pointee, string spelling)
        {
            _tw.WriteLine(@"[UnmanagedFunctionPointer(" + pointee.CallingConventionSpelling() + ")]");
            _tw.Write(@"public unsafe delegate ");
            FunctionHelper.WriteReturnType(clang.getResultType(pointee), _tw);
            _tw.Write(@" ");
            _tw.Write(spelling);
            _tw.Write(@"(");

            uint argumentCounter = 0;

            clang.visitChildren(cursor, delegate(CXCursor cxCursor, CXCursor parent1, IntPtr ptr)
            {
                if (cxCursor.kind == CXCursorKind.CXCursor_ParmDecl)
                {
                    FunctionHelper.WriteArgument(pointee, cxCursor, _tw, argumentCounter++);
                }

                return CXChildVisitResult.CXChildVisit_Continue;
            }, new CXClientData(IntPtr.Zero));

            _tw.WriteLine(@");");
            _tw.WriteLine();
        }
    }
}