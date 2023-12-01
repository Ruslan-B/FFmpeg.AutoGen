//#if (NETSTANDARD1_3_OR_GREATER) || (NET46_OR_GREATER) || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETSTANDARD2_0 || NETSTANDARD2_1 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48 || NET5_0 || NET6_0
#define HAS_SYSTEM_MEMORY_COPY
//#endif

using System;
using System.Collections.Generic;



namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation
{
    internal interface FixedArraysFunctionBlockGenerator
    {
        string GetBlockOfToArray(string elementType, int length);
        string GetBlockOfUpdateFrom(string elementType, int length);
    }

    internal class PrimitiveFixedArraysGeneratorHelper
    {
        static private readonly string BYTE_KEY = "byte";
        static private Dictionary<string, FixedArraysFunctionBlockGenerator>  fixedArraysBlockGenerators = new Dictionary<string, FixedArraysFunctionBlockGenerator>();
        static PrimitiveFixedArraysGeneratorHelper() {
            fixedArraysBlockGenerators.Add(BYTE_KEY, new ByteFixedArraysFunctionBlockGenerator());
        }

        static public string GetBlockOfToArray(string elementType, int length)
        {
            String result = null;
            if (fixedArraysBlockGenerators.ContainsKey(elementType))
            {
                FixedArraysFunctionBlockGenerator generator = fixedArraysBlockGenerators[elementType];
                result = generator.GetBlockOfToArray(elementType, length);
            }
            if (string.IsNullOrEmpty(result))
            {
                result = $"var a = new {elementType}[{length}]; for (uint i = 0; i < {length}; i++) a[i] = _[i]; return a;";
            }
            return result;
        }


        static public string GetBlockOfUpdateFrom(string elementType, int length)
        {
            String result = null;
            if (fixedArraysBlockGenerators.ContainsKey(elementType))
            {
                FixedArraysFunctionBlockGenerator generator = fixedArraysBlockGenerators[elementType];
                result = generator.GetBlockOfUpdateFrom(elementType, length);
            }
            if (string.IsNullOrEmpty(result))
            {
                result = $"uint i = 0; foreach(var value in array) {{ _[i++] = value; if (i >= {length}) return; }}";
            }
            return result;
        }

    }

    internal class ByteFixedArraysFunctionBlockGenerator : FixedArraysFunctionBlockGenerator
    {   
        static private int USE_COPY_MIN_LENGTH = 256;
        public string GetBlockOfToArray(string elementType, int length)
        {
            if (length >= USE_COPY_MIN_LENGTH)
            {
                //return $"var a = new {elementType}[{length}];Array.Copy(_, a, {length}); return a;";
#if HAS_SYSTEM_MEMORY_COPY
                return $@"var a = new {elementType}[{length}];fixed (byte* src = _, dst = a){{ Buffer.MemoryCopy(src, dst, {length}, {length}); }} return a;";
#endif
            }
            return null;
        }

        public string GetBlockOfUpdateFrom(string elementType, int length)
        {
            if (length >= USE_COPY_MIN_LENGTH)
            {
                //return $"Array.Copy(array, _, Math.Min({length}, array.Length));";
#if HAS_SYSTEM_MEMORY_COPY
                return $@"fixed (byte* src = array, dst = _){{ Buffer.MemoryCopy(src, dst, {length}, Math.Min({length}, array.Length)); }}";
#endif

            }
            return null;
        }
    }


}
