using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppSharp.AST;
using Type = System.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    class TempHelper
    {
        private static Type GetType2(PrimitiveType primitiveType)
        {
            switch (primitiveType)
            {
                //case PrimitiveType.Null:
                //    break;
                case PrimitiveType.Void:
                    return typeof(void);
                case PrimitiveType.Bool:
                    return typeof(bool);
                case PrimitiveType.WideChar:
                    return typeof(char);
                case PrimitiveType.Char:
                    return typeof(byte);
                case PrimitiveType.SChar:
                    return typeof(sbyte);
                case PrimitiveType.UChar:
                    return typeof(byte);
                case PrimitiveType.Char16:
                    return typeof(char);
                case PrimitiveType.Char32:
                    return typeof(char);
                case PrimitiveType.Short:
                    return typeof(short);
                case PrimitiveType.UShort:
                    return typeof(ushort);
                case PrimitiveType.Int:
                    return typeof(int);
                case PrimitiveType.UInt:
                    return typeof(uint);
                case PrimitiveType.Long:
                    return typeof(long);
                case PrimitiveType.ULong:
                    return typeof(ulong);
                //case PrimitiveType.LongLong:
                //    break;
                //case PrimitiveType.ULongLong:
                //    break;
                //case PrimitiveType.Int128:
                //    break;
                //case PrimitiveType.UInt128:
                //    break;
                //case PrimitiveType.Half:
                //    break;
                case PrimitiveType.Float:
                    return typeof(float);
                case PrimitiveType.Double:
                    return typeof(double);
                //case PrimitiveType.LongDouble:
                //    break;
                //case PrimitiveType.Float128:
                //    break;
                case PrimitiveType.IntPtr:
                    return typeof(IntPtr);
                case PrimitiveType.UIntPtr:
                    return typeof(UIntPtr);
                default:
                    throw new ArgumentOutOfRangeException(nameof(primitiveType), primitiveType, null);
            }
        }
    }
}
