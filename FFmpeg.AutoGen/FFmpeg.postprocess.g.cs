using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe static partial class ffmpeg
    {
        public const ulong LIBPOSTPROC_VERSION_MAJOR = 53;
        public const ulong LIBPOSTPROC_VERSION_MINOR = 3;
        public const ulong LIBPOSTPROC_VERSION_MICRO = 100;
        public const ulong PP_QUALITY_MAX = 6;
        public const ulong PP_CPU_CAPS_MMX = 0x80000000;
        public const ulong PP_CPU_CAPS_MMX2 = 0x20000000;
        public const ulong PP_CPU_CAPS_3DNOW = 0x40000000;
        public const ulong PP_CPU_CAPS_ALTIVEC = 0x10000000;
        public const ulong PP_CPU_CAPS_AUTO = 0x00080000;
        public const ulong PP_FORMAT = 0x00000008;
        public const ulong PP_FORMAT_420 = (0x00000011|PP_FORMAT);
        public const ulong PP_FORMAT_422 = (0x00000001|PP_FORMAT);
        public const ulong PP_FORMAT_411 = (0x00000002|PP_FORMAT);
        public const ulong PP_FORMAT_444 = (0x00000000|PP_FORMAT);
        public const ulong PP_FORMAT_440 = (0x00000010|PP_FORMAT);
        public const ulong PP_PICT_TYPE_QP2 = 0x00000010;
        private const string libpostprocess = "postprocess-53";
        
        [DllImport(libpostprocess, EntryPoint = "postproc_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint postproc_version();
        
        [DllImport(libpostprocess, EntryPoint = "postproc_configuration", CallingConvention = CallingConvention.Cdecl)]
        public static extern string postproc_configuration();
        
        [DllImport(libpostprocess, EntryPoint = "postproc_license", CallingConvention = CallingConvention.Cdecl)]
        public static extern string postproc_license();
        
        [DllImport(libpostprocess, EntryPoint = "pp_postprocess", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pp_postprocess([MarshalAs(UnmanagedType.LPArray, SizeConst=3)] sbyte*[] @src, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] int[] @srcStride, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] sbyte*[] @dst, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] int[] @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        
        [DllImport(libpostprocess, EntryPoint = "pp_get_mode_by_name_and_quality", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* pp_get_mode_by_name_and_quality([MarshalAs(UnmanagedType.LPStr)] string @name, int @quality);
        
        [DllImport(libpostprocess, EntryPoint = "pp_free_mode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pp_free_mode(void* @mode);
        
        [DllImport(libpostprocess, EntryPoint = "pp_get_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* pp_get_context(int @width, int @height, int @flags);
        
        [DllImport(libpostprocess, EntryPoint = "pp_free_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pp_free_context(void* @ppContext);
        
    }
}
