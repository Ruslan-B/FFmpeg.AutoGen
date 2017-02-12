using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class StructVisitor
    {
        private readonly Stack<Action> _defferedVisits = new Stack<Action>();
        private readonly IndentedTextWriter _tw;
        private readonly ISet<string> _visitedStructs;
        private bool _hasChildren;
        private bool _writingStruct;

        public StructVisitor(IndentedTextWriter tw, ISet<string> visitedStructs)
        {
            _tw = tw;
            _visitedStructs = visitedStructs;
        }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr clientData)
        {
            if (cursor.IsInSystemHeader())
            {
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            var cursorKind = clang.getCursorKind(cursor);
            if (cursorKind == CXCursorKind.CXCursor_StructDecl || cursorKind == CXCursorKind.CXCursor_UnionDecl)
            {
                if (_writingStruct)
                {
                    Action defferedVisit = () => Visit(cursor, parent, clientData);
                    _defferedVisits.Push(defferedVisit);
                    return CXChildVisitResult.CXChildVisit_Continue;
                }

                _writingStruct = true;

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

                if (!_visitedStructs.Contains(structName))
                {
                    //_tw.WriteLine(@"[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]");
                    _tw.WriteLine(@"public unsafe partial struct " + structName);
                    _tw.WriteLine(@"{");

                    _hasChildren = false;

                    _tw.Indent++;
                    clang.visitChildren(cursor, Visit, new CXClientData(IntPtr.Zero));
                    _tw.Indent--;

                    _tw.WriteLine(@"}");
                    _tw.WriteLine();

                    if (_hasChildren)
                    {
                        _visitedStructs.Add(structName);
                    }
                }

                _writingStruct = false;
                while (_defferedVisits.Count > 0)
                {
                    var defferedVisit = _defferedVisits.Pop();
                    defferedVisit();
                }

                //var fieldPosition = 0;

                return CXChildVisitResult.CXChildVisit_Continue;
            }

            if (cursorKind == CXCursorKind.CXCursor_FieldDecl)
            {
                _hasChildren = true;

                var fieldName = clang.getCursorSpelling(cursor).ToString();
                if (string.IsNullOrEmpty(fieldName))
                {
                    throw new NotSupportedException();
                    //fieldName = @"field" + fieldPosition; // what if they have fields called field*? :)
                }

                //fieldPosition++;

                _tw.WriteLine(ToMarshalString(cursor, fieldName));

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
                            var typeString = GetTypeName(cursor, cursorSpelling, nestedElementType);
                            for (var i = 0; i < arraySize; ++i)
                            {
                                sb.AppendFormat(@"public fixed {0} @{1}{2}[{3}]; ", typeString, cursorSpelling, i, nestedArraySize);
                            }
                            return sb.ToString();
                        }
                        default:
                        {
                            var sb = new StringBuilder();
                            var typeString = GetTypeName(cursor, cursorSpelling, elementType);
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
                    var typeString = GetTypeName(cursor, cursorSpelling, canonical);
                    return @"public " + typeString + @" @" + cursorSpelling + @";";
                }
            }
        }

        private string GetTypeName(CXCursor cursor, string cursorSpelling, CXType type)
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
                            var spelling = cursorSpelling + "_func";
                            WriteDelegate(cursor, pointeeType, spelling);
                            return spelling;
                        default:
                            return GetTypeName(cursor, cursorSpelling, pointeeType) + @"*";
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

        private void WriteDelegate(CXCursor cursor, CXType pointee, string spelling)
        {
            _tw.WriteLine(@"[UnmanagedFunctionPointer(" + pointee.CallingConventionSpelling() + ")]");
            _tw.Write(@"public unsafe delegate ");
            FunctionHelper.WriteReturnType(clang.getResultType(pointee), _tw);
            _tw.Write(@" ");
            _tw.Write(spelling);
            _tw.Write(@"(");

            uint argumentCounter = 0;

            clang.visitChildren(cursor, delegate (CXCursor cxCursor, CXCursor parent1, IntPtr ptr)
            {
                if (cxCursor.kind == CXCursorKind.CXCursor_ParmDecl)
                {
                    FunctionHelper.WriteArgument(pointee, cxCursor, _tw, argumentCounter++);
                }

                return CXChildVisitResult.CXChildVisit_Continue;
            }, new CXClientData(IntPtr.Zero));

            _tw.WriteLine(@");");
        }
    }
}