using System.Text;
using ClangSharp;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal static class Extensions
    {
        public static bool IsInSystemHeader(this CXCursor cursor)
        {
            return clang.Location_isInSystemHeader(clang.getCursorLocation(cursor)) != 0;
        }

        public static bool IsPtrToConstChar(this CXType type)
        {
            var pointee = clang.getPointeeType(type);

            if (clang.isConstQualifiedType(pointee) != 0)
            {
                switch (pointee.kind)
                {
                    case CXTypeKind.CXType_Char_S:
                        return true;
                }
            }

            return false;
        }

        public static string ToPlainTypeString(this CXType type)
        {
            var canonical = clang.getCanonicalType(type);
            switch (type.kind)
            {
                case CXTypeKind.CXType_Bool:
                    return @"bool";
                case CXTypeKind.CXType_UChar:
                case CXTypeKind.CXType_Char_U:
                    return @"sbyte";//@"char";
                case CXTypeKind.CXType_SChar:
                case CXTypeKind.CXType_Char_S:
                    return @"sbyte";
                case CXTypeKind.CXType_UShort:
                    return @"ushort";
                case CXTypeKind.CXType_Short:
                    return @"short";
                case CXTypeKind.CXType_Float:
                    return @"float";
                case CXTypeKind.CXType_Double:
                    return @"double";
                case CXTypeKind.CXType_Int:
                    return @"int";
                case CXTypeKind.CXType_UInt:
                    return @"uint";
                case CXTypeKind.CXType_Pointer:
                    var pointee = clang.getPointeeType(canonical);
                    return ToPlainTypeString(pointee) + @"*";
                case CXTypeKind.CXType_NullPtr: // ugh, what else can I do?
                    return @"IntPtr";
                case CXTypeKind.CXType_Long:
                    return @"int";
                case CXTypeKind.CXType_ULong:
                    return @"int";
                case CXTypeKind.CXType_LongLong:
                    return @"long";
                case CXTypeKind.CXType_ULongLong:
                    return @"ulong";
                case CXTypeKind.CXType_Void:
                    return @"void";
                case CXTypeKind.CXType_Unexposed:
                    return canonical.kind == CXTypeKind.CXType_Unexposed ? clang.getTypeSpelling(canonical).ToString() : canonical.ToPlainTypeString();
                default:
                    return ToStringEx(canonical);
            }
        }

        public static string ToStringEx(this CXType type)
        {
            var typeString = type.ToString();

            var isConstQualifiedType = clang.isConstQualifiedType(type) != 0;
            if (isConstQualifiedType)
            {
                typeString = typeString.Replace(@"const ", string.Empty);
            }

            return typeString;
        }
    }
}