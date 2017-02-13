using System;
using CppSharp.AST;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Builder
{
    internal class TypeHelper
    {
        public static string GetTypeName(Type type)
        {
            if (type is PointerType) return GetTypeName((PointerType) type);
            if (type is BuiltinType) return GetTypeName((BuiltinType) type);
            if (type is TypedefType) return GetTypeName((TypedefType) type);
            if (type is TagType) return GetTypeName((TagType) type);
            if (type is ArrayType) return GetTypeName((ArrayType) type);
            throw new NotSupportedException();
        }

        public static string GetTypeName(ArrayType type)
        {
            return GetTypeName(type.Type) + "[]";
        }

        public static string GetTypeName(TypedefType type)
        {
            if (type.Declaration.Type is BuiltinType) return GetTypeName((BuiltinType) type.Declaration.Type);
            if (type.Declaration.Type is PointerType) return GetTypeName((PointerType) type.Declaration.Type);
            return type.Declaration.Name;
        }

        public static string GetTypeName(TagType type)
        {
            return type.Declaration.Name;
        }

        public static string GetTypeName(PointerType type)
        {
            if (type.QualifiedPointee.Type is BuiltinType) return GetTypeName((BuiltinType) type.QualifiedPointee.Type) + "*";
            if (type.QualifiedPointee.Type is TypedefType) return GetTypeName((TypedefType)type.QualifiedPointee.Type) + "*";
            if (type.QualifiedPointee.Type is PointerType) return GetTypeName((PointerType) type.QualifiedPointee.Type) + "*";
            return "IntPtr";
        }

        public static string GetTypeName(BuiltinType type)
        {
            switch (type.Type)
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
                    throw new ArgumentOutOfRangeException();
            }
            throw new NotSupportedException();
        }
    }
}