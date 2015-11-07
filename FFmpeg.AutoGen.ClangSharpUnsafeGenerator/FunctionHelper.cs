using System.IO;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    public static class FunctionHelper
    {
        public static string CallingConventionSpelling(this CXType type)
        {
            var callingConvention = clang.getFunctionTypeCallingConv(type);
            switch (callingConvention)
            {
                case CXCallingConv.CXCallingConv_X86StdCall:
                case CXCallingConv.CXCallingConv_X86_64Win64:
                    return @"CallingConvention.StdCall";
                default:
                    return @"CallingConvention.Cdecl";
            }
        }

        public static void WriteReturnType(CXType resultType, TextWriter tw)
        {
            switch (resultType.kind)
            {
                case CXTypeKind.CXType_Pointer:
                    // const char* gets special treatment
                    var typeString = resultType.IsPtrToConstChar() ? @"string" : resultType.ToPlainTypeString();
                    tw.Write(typeString);
                    break;
                default:
                    WriteCommonType(resultType, tw);
                    break;
            }
        }

        public static void WriteArgument(CXType functionType, CXCursor paramCursor, TextWriter tw, uint index)
        {
            var numArgTypes = clang.getNumArgTypes(functionType);
            var type = clang.getArgType(functionType, index);
            var cursorType = clang.getCursorType(paramCursor);

            var spelling = clang.getCursorSpelling(paramCursor).ToString();
            if (string.IsNullOrEmpty(spelling))
            {
                spelling = @"param" + index;
            }

            switch (type.kind)
            {
                case CXTypeKind.CXType_Pointer:
                    var pointee = clang.getPointeeType(type);
                    switch (pointee.kind)
                    {
                        case CXTypeKind.CXType_Pointer:
                            if (pointee.IsPtrToConstChar() && clang.isConstQualifiedType(pointee) != 0)
                            {
                                var typeName = @"string[]";
                                tw.Write(typeName);
                            }
                            else
                            {
                                var typeName = type.ToPlainTypeString();
                                tw.Write(typeName);
                            }
                            break;
                        case CXTypeKind.CXType_FunctionProto:
                            tw.Write(clang.getTypeSpelling(cursorType).ToString());
                            break;
                        case CXTypeKind.CXType_Char_S:
                            tw.Write(type.IsPtrToConstChar() ? @"[MarshalAs(UnmanagedType.LPStr)] string" : @"IntPtr");
                            // if it's not a const, it's best to go with IntPtr
                            break;
                        case CXTypeKind.CXType_WChar:
                            tw.Write(type.IsPtrToConstChar() ? @"[MarshalAs(UnmanagedType.LPWStr)] string" : @"IntPtr");
                            break;
                        case CXTypeKind.CXType_Void:
                            tw.Write(@"void*");
                            break;
                        case CXTypeKind.CXType_Unexposed:
                            {
                                var declaration = clang.getTypeDeclaration(pointee);
                                if (declaration.kind == CXCursorKind.CXCursor_NoDeclFound)
                                {
                                    tw.Write(@"IntPtr"); // no declaration found
                                }
                                var typeName = clang.getCursorSpelling(declaration) + @"*";
                                tw.Write(typeName);
                                break;
                            }
                        default:
                            {
                                var typeName = type.ToPlainTypeString();
                                tw.Write(typeName);
                                break;
                            }
                    }
                    break;
                //case CXTypeKind.CXType_IncompleteArray:
                //case CXTypeKind.CXType_DependentSizedArray:
                //case CXTypeKind.CXType_VariableArray:
                //{
                //    var elementType = clang.getArrayElementType(type);
                //    var typeName = elementType.ToPlainTypeString();
                //    tw.Write(typeName + @"*");
                //    break;
                //}
                default:
                    WriteCommonType(type, tw);
                    break;
            }

            tw.Write(@" @");
            tw.Write(spelling);

            if (index != numArgTypes - 1)
            {
                tw.Write(@", ");
            }
        }

        private static void WriteCommonType(CXType type, TextWriter tw, string outParam = "")
        {
            tw.Write(outParam);

            var canonical = clang.getCanonicalType(type);

            string spelling;
            switch (type.kind)
            {
                case CXTypeKind.CXType_Typedef:
                    var cursor = clang.getTypeDeclaration(type);
                    if (clang.Location_isInSystemHeader(clang.getCursorLocation(cursor)) != 0)
                    {
                        spelling = canonical.ToPlainTypeString();
                    }
                    else
                    {
                        spelling = type.ToStringEx();
                    }
                    break;
                case CXTypeKind.CXType_Record:
                case CXTypeKind.CXType_Enum:
                    spelling = canonical.ToPlainTypeString();
                    break;
                case CXTypeKind.CXType_IncompleteArray:
                    WriteCommonType(clang.getArrayElementType(type), tw);
                    spelling = @"*";
                    break;
                case CXTypeKind.CXType_ConstantArray:
                    tw.Write(@"[MarshalAs(UnmanagedType.LPArray, SizeConst={0})] ", clang.getArraySize(type));
                    WriteCommonType(clang.getArrayElementType(type), tw);
                    spelling = @"[]";
                    break;
                case CXTypeKind.CXType_Unexposed:
                    // Often these are enums and canonical type gets you the enum spelling
                    // unexposed decl which turns into a function proto seems to be an un-typedef'd fn pointer
                    spelling = canonical.kind == CXTypeKind.CXType_FunctionProto ? @"IntPtr" : canonical.ToPlainTypeString();
                    break;
                default:
                    spelling = canonical.ToPlainTypeString();
                    break;
            }

            tw.Write(spelling);
        }
    }
}