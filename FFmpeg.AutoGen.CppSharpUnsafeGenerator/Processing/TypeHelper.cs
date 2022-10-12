using System;
using CppSharp.AST;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal static class TypeHelper
{
    public static string GetTypeName(Type type)
    {
        return type switch
        {
            PointerType x => $"{GetTypeName(x.QualifiedPointee.Type)}*",
            BuiltinType x => GetTypeName(x.Type),
            TypedefType x => GetTypeName(x),
            TagType x => x.Declaration.Name,
            ArrayType x => $"{GetTypeName(x.Type)}[]",
            AttributedType => GetTypeName(PrimitiveType.Void),
            _ => throw new NotSupportedException()
        };
    }

    private static string GetTypeName(TypedefType type)
    {
        return type.Declaration.Type switch
        {
            BuiltinType x => GetTypeName(x),
            PointerType x => GetTypeName(x),
            _ => type.Declaration.Name
        };
    }

    private static string GetTypeName(PrimitiveType type)
    {
        return type switch
        {
            PrimitiveType.Void => "void",
            PrimitiveType.Bool => "bool",
            PrimitiveType.Char => "byte",
            PrimitiveType.SChar => "sbyte",
            PrimitiveType.UChar => "byte",
            PrimitiveType.Short => "short",
            PrimitiveType.UShort => "ushort",
            PrimitiveType.Int => "int",
            PrimitiveType.UInt => "uint",
            PrimitiveType.Long => "long",
            PrimitiveType.ULong => "ulong",
            PrimitiveType.LongLong => "long",
            PrimitiveType.ULongLong => "ulong",
            PrimitiveType.Float => "float",
            PrimitiveType.Double => "double",
            PrimitiveType.Decimal => "decimal",
            PrimitiveType.IntPtr => "IntPtr",
            PrimitiveType.UIntPtr => "UIntPtr",
            PrimitiveType.Null => throw new NotSupportedException(),
            PrimitiveType.WideChar => throw new NotSupportedException(),
            PrimitiveType.Char16 => throw new NotSupportedException(),
            PrimitiveType.Char32 => throw new NotSupportedException(),
            PrimitiveType.Int128 => throw new NotSupportedException(),
            PrimitiveType.UInt128 => throw new NotSupportedException(),
            PrimitiveType.Half => throw new NotSupportedException(),
            PrimitiveType.LongDouble => "LongDouble",
            PrimitiveType.Float128 => throw new NotSupportedException(),
            PrimitiveType.String => throw new NotSupportedException(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
    }
}
