using System;
using CppSharp.AST;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal static class TypeHelper
    {
        public static string GetTypeName(Type type)
        {
            switch (type)
            {
                case PointerType x: return GetTypeName(x);
                case BuiltinType x: return GetTypeName(x);
                case TypedefType x: return GetTypeName(x);
                case TagType x: return GetTypeName(x);
                case ArrayType x: return GetTypeName(x);
                case AttributedType x: return GetTypeName(x);
                default:
                    throw new NotSupportedException();
            }
        }

        private static string GetTypeName(ArrayType type)
        {
            return GetTypeName(type.Type) + "[]";
        }

        private static string GetTypeName(TypedefType type)
        {
            switch (type.Declaration.Type)
            {
                case BuiltinType x: return GetTypeName(x);
                case PointerType x: return GetTypeName(x);
                default:
                    return type.Declaration.Name;
            }
        }

        private static string GetTypeName(TagType type)
        {
            return type.Declaration.Name;
        }

        private static string GetTypeName(PointerType type)
        {
            switch (type.QualifiedPointee.Type)
            {
                case BuiltinType x: return GetTypeName(x) + "*";
                case TypedefType x: return GetTypeName(x) + "*";
                case TagType x: return GetTypeName(x) + "*";
                case PointerType x: return GetTypeName(x) + "*";
                default:
                    throw new NotSupportedException();
            }
        }

        private static string GetTypeName(AttributedType type)
        {
            return GetTypeName(PrimitiveType.Void);
        }

        private static string GetTypeName(BuiltinType type)
        {
            return GetTypeName(type.Type);
        }

        private static string GetTypeName(PrimitiveType type)
        {
            switch (type)
            {
                case PrimitiveType.Null:
                    break;
                case PrimitiveType.Void:
                    return "void";
                case PrimitiveType.Bool:
                    return "bool";
                case PrimitiveType.WideChar:
                    break;
                case PrimitiveType.Char:
                    return "byte";
                case PrimitiveType.SChar:
                    return "sbyte";
                case PrimitiveType.UChar:
                    return "byte";
                case PrimitiveType.Char16:
                    break;
                case PrimitiveType.Char32:
                    break;
                case PrimitiveType.Short:
                    return "short";
                case PrimitiveType.UShort:
                    return "ushort";
                case PrimitiveType.Int:
                    return "int";
                case PrimitiveType.UInt:
                    return "uint";
                case PrimitiveType.Long:
                    return "long";
                case PrimitiveType.ULong:
                    return "ulong";
                case PrimitiveType.LongLong:
                    return "long";
                case PrimitiveType.ULongLong:
                    return "ulong";
                case PrimitiveType.Int128:
                    break;
                case PrimitiveType.UInt128:
                    break;
                case PrimitiveType.Half:
                    break;
                case PrimitiveType.Float:
                    return "float";
                case PrimitiveType.Double:
                    return "double";
                case PrimitiveType.LongDouble:
                    break;
                case PrimitiveType.Float128:
                    break;
                case PrimitiveType.IntPtr:
                    return "IntPtr";
                case PrimitiveType.UIntPtr:
                    return "UIntPtr";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
            throw new NotSupportedException();
        }
    }
}