using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe static partial class ffmpeg
    {
        private const string libpostprocess = "postprocess-53";
        
        [DllImport(libpostprocess, EntryPoint = "postproc_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint postproc_version();
        
        [DllImport(libpostprocess, EntryPoint = "postproc_configuration", CallingConvention = CallingConvention.Cdecl)]
        public static extern string postproc_configuration();
        
        [DllImport(libpostprocess, EntryPoint = "postproc_license", CallingConvention = CallingConvention.Cdecl)]
        public static extern string postproc_license();
        
        [DllImport(libpostprocess, EntryPoint = "pp_postprocess", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pp_postprocess([MarshalAs(UnmanagedType.LPArray, SizeConst=3)] char*[] @src, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] int[] @srcStride, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] char*[] @dst, [MarshalAs(UnmanagedType.LPArray, SizeConst=3)] int[] @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        
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
