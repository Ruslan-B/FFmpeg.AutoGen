using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    public unsafe static partial class ffmpeg
    {
        public static int PP_QUALITY_MAX = 6;
        // public static  QP_STORE_T = int8_t;
        public static long PP_CPU_CAPS_MMX = 0x80000000;
        public static int PP_CPU_CAPS_MMX2 = 0x20000000;
        public static int PP_CPU_CAPS_3DNOW = 0x40000000;
        public static int PP_CPU_CAPS_ALTIVEC = 0x10000000;
        public static int PP_CPU_CAPS_AUTO = 0x00080000;
        public static int PP_FORMAT = 0x00000008;
        // public static  PP_FORMAT_420 = (0x00000011|PP_FORMAT);
        // public static  PP_FORMAT_422 = (0x00000001|PP_FORMAT);
        // public static  PP_FORMAT_411 = (0x00000002|PP_FORMAT);
        // public static  PP_FORMAT_444 = (0x00000000|PP_FORMAT);
        // public static  PP_FORMAT_440 = (0x00000010|PP_FORMAT);
        public static int PP_PICT_TYPE_QP2 = 0x00000010;
        public static int LIBPOSTPROC_VERSION_MAJOR = 54;
        public static int LIBPOSTPROC_VERSION_MINOR = 1;
        public static int LIBPOSTPROC_VERSION_MICRO = 100;
        // public static  LIBPOSTPROC_VERSION_INT = AV_VERSION_INT(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        // public static  LIBPOSTPROC_VERSION = AV_VERSION(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        // public static  LIBPOSTPROC_BUILD = LIBPOSTPROC_VERSION_INT;
        // public static  LIBPOSTPROC_IDENT = "postproc" AV_STRINGIFY(LIBPOSTPROC_VERSION);
        // public static  FF_API_QP_TYPE = (LIBPOSTPROC_VERSION_MAJOR < 55);
        
        /// <summary>Return the LIBPOSTPROC_VERSION_INT constant.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint postproc_version();
        
        /// <summary>Return the libpostproc build-time configuration.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string postproc_configuration();
        
        /// <summary>Return the libpostproc license.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string postproc_license();
        
        [DllImport("postproc-54", EntryPoint = "pp_postprocess", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_postprocess(byte*[] @src, int[] @srcStride, byte*[] @dst, int[] @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        
        /// <summary>Return a pp_mode or NULL if an error occurred.</summary>
        /// <param name="name">the string after "-pp" on the command line</param>
        /// <param name="quality">a number from 0 to PP_QUALITY_MAX</param>
        [DllImport("postproc-54", EntryPoint = "pp_get_mode_by_name_and_quality", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* pp_get_mode_by_name_and_quality([MarshalAs(UnmanagedType.LPStr)] string @name, int @quality);
        
        [DllImport("postproc-54", EntryPoint = "pp_free_mode", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_free_mode(void* @mode);
        
        [DllImport("postproc-54", EntryPoint = "pp_get_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* pp_get_context(int @width, int @height, int @flags);
        
        [DllImport("postproc-54", EntryPoint = "pp_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_free_context(void* @ppContext);
        
    }
}
