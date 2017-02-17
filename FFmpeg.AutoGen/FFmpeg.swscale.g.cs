using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe struct SwsVector
    {
        /// <summary>pointer to the list of coefficients</summary>
        public double* @coeff;
        /// <summary>number of coefficients in the vector</summary>
        public int @length;
    }
    
    public unsafe struct SwsFilter
    {
        public SwsVector* @lumH;
        public SwsVector* @lumV;
        public SwsVector* @chrH;
        public SwsVector* @chrV;
    }
    
    public unsafe static partial class ffmpeg
    {
        public static int SWS_FAST_BILINEAR = 1;
        public static int SWS_BILINEAR = 2;
        public static int SWS_BICUBIC = 4;
        public static int SWS_X = 8;
        public static int SWS_POINT = 0x10;
        public static int SWS_AREA = 0x20;
        public static int SWS_BICUBLIN = 0x40;
        public static int SWS_GAUSS = 0x80;
        public static int SWS_SINC = 0x100;
        public static int SWS_LANCZOS = 0x200;
        public static int SWS_SPLINE = 0x400;
        public static int SWS_SRC_V_CHR_DROP_MASK = 0x30000;
        public static int SWS_SRC_V_CHR_DROP_SHIFT = 16;
        public static int SWS_PARAM_DEFAULT = 123456;
        public static int SWS_PRINT_INFO = 0x1000;
        public static int SWS_FULL_CHR_H_INT = 0x2000;
        public static int SWS_FULL_CHR_H_INP = 0x4000;
        public static int SWS_DIRECT_BGR = 0x8000;
        public static int SWS_ACCURATE_RND = 0x40000;
        public static int SWS_BITEXACT = 0x80000;
        public static int SWS_ERROR_DIFFUSION = 0x800000;
        public static float SWS_MAX_REDUCE_CUTOFF = 0.002f;
        public static int SWS_CS_ITU709 = 1;
        public static int SWS_CS_FCC = 4;
        public static int SWS_CS_ITU601 = 5;
        public static int SWS_CS_ITU624 = 5;
        public static int SWS_CS_SMPTE170M = 5;
        public static int SWS_CS_SMPTE240M = 7;
        public static int SWS_CS_DEFAULT = 5;
        public static int SWS_CS_BT2020 = 9;
        public static int LIBSWSCALE_VERSION_MAJOR = 4;
        public static int LIBSWSCALE_VERSION_MINOR = 2;
        public static int LIBSWSCALE_VERSION_MICRO = 100;
        // public static  LIBSWSCALE_VERSION_INT = AV_VERSION_INT(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        // public static  LIBSWSCALE_VERSION = AV_VERSION(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        // public static  LIBSWSCALE_BUILD = LIBSWSCALE_VERSION_INT;
        // public static  LIBSWSCALE_IDENT = "SwS" AV_STRINGIFY(LIBSWSCALE_VERSION);
        public static bool FF_API_SWS_VECTOR = (LIBSWSCALE_VERSION_MAJOR < 6);
        
        /// <summary>Color conversion and scaling library.</summary>
        [DllImport("swscale-4", EntryPoint = "swscale_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint swscale_version();
        
        /// <summary>Return the libswscale build-time configuration.</summary>
        [DllImport("swscale-4", EntryPoint = "swscale_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string swscale_configuration();
        
        /// <summary>Return the libswscale license.</summary>
        [DllImport("swscale-4", EntryPoint = "swscale_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string swscale_license();
        
        /// <summary>Return a pointer to yuv<->rgb coefficients for the given colorspace suitable for sws_setColorspaceDetails().</summary>
        /// <param name="colorspace">One of the SWS_CS_* macros. If invalid, SWS_CS_DEFAULT is used.</param>
        [DllImport("swscale-4", EntryPoint = "sws_getCoefficients", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int* sws_getCoefficients(int @colorspace);
        
        /// <summary>Return a positive value if pix_fmt is a supported input format, 0 otherwise.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_isSupportedInput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_isSupportedInput(AVPixelFormat @pix_fmt);
        
        /// <summary>Return a positive value if pix_fmt is a supported output format, 0 otherwise.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_isSupportedOutput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_isSupportedOutput(AVPixelFormat @pix_fmt);
        
        /// <summary>Returns a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        [DllImport("swscale-4", EntryPoint = "sws_isSupportedEndiannessConversion", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt);
        
        /// <summary>Allocate an empty SwsContext. This must be filled and passed to sws_init_context(). For filling see AVOptions, options.c and sws_setColorspaceDetails().</summary>
        [DllImport("swscale-4", EntryPoint = "sws_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr sws_alloc_context();
        
        /// <summary>Initialize the swscaler context sws_context.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_init_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_init_context(IntPtr @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
        
        /// <summary>Free the swscaler context swsContext. If swsContext is NULL, then does nothing.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_freeContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_freeContext(IntPtr @swsContext);
        
        /// <summary>Allocate and return an SwsContext. You need it to perform scaling/conversion operations using sws_scale().</summary>
        /// <param name="srcW">the width of the source image</param>
        /// <param name="srcH">the height of the source image</param>
        /// <param name="srcFormat">the source image format</param>
        /// <param name="dstW">the width of the destination image</param>
        /// <param name="dstH">the height of the destination image</param>
        /// <param name="dstFormat">the destination image format</param>
        /// <param name="flags">specify which algorithm and options to use for rescaling</param>
        /// <param name="param">extra parameters to tune the used scaler For SWS_BICUBIC param[0] and [1] tune the shape of the basis function, param[0] tunes f(1) and param[1] f´(1) For SWS_GAUSS param[0] tunes the exponent and thus cutoff frequency For SWS_LANCZOS param[0] tunes the width of the window function</param>
        [DllImport("swscale-4", EntryPoint = "sws_getContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        
        /// <summary>Scale the image slice in srcSlice and put the resulting scaled slice in the image in dst. A slice is a sequence of consecutive rows in an image.</summary>
        /// <param name="c">the scaling context previously created with sws_getContext()</param>
        /// <param name="srcSlice">the array containing the pointers to the planes of the source slice</param>
        /// <param name="srcStride">the array containing the strides for each plane of the source image</param>
        /// <param name="srcSliceY">the position in the source image of the slice to process, that is the number (counted starting from zero) in the image of the first row of the slice</param>
        /// <param name="srcSliceH">the height of the source slice, that is the number of rows in the slice</param>
        /// <param name="dst">the array containing the pointers to the planes of the destination image</param>
        /// <param name="dstStride">the array containing the strides for each plane of the destination image</param>
        [DllImport("swscale-4", EntryPoint = "sws_scale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_scale(IntPtr @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
        
        /// <summary>Returns -1 if not supported</summary>
        /// <param name="inv_table">the yuv2rgb coefficients describing the input yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="srcRange">flag indicating the while-black range of the input (1=jpeg / 0=mpeg)</param>
        /// <param name="table">the yuv2rgb coefficients describing the output yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="dstRange">flag indicating the while-black range of the output (1=jpeg / 0=mpeg)</param>
        /// <param name="brightness">16.16 fixed point brightness correction</param>
        /// <param name="contrast">16.16 fixed point contrast correction</param>
        /// <param name="saturation">16.16 fixed point saturation correction</param>
        [DllImport("swscale-4", EntryPoint = "sws_setColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_setColorspaceDetails(IntPtr @c, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @inv_table, int @srcRange, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @table, int @dstRange, int @brightness, int @contrast, int @saturation);
        
        /// <summary>Returns -1 if not supported</summary>
        [DllImport("swscale-4", EntryPoint = "sws_getColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sws_getColorspaceDetails(IntPtr @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
        
        /// <summary>Allocate and return an uninitialized vector with length coefficients.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_allocVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsVector* sws_allocVec(int @length);
        
        /// <summary>Return a normalized Gaussian curve used to filter stuff quality = 3 is high quality, lower is lower quality.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_getGaussianVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsVector* sws_getGaussianVec(double @variance, double @quality);
        
        /// <summary>Scale all the coefficients of a by the scalar value.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_scaleVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_scaleVec(SwsVector* @a, double @scalar);
        
        /// <summary>Scale all the coefficients of a so that their sum equals height.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_normalizeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_normalizeVec(SwsVector* @a, double @height);
        
        [DllImport("swscale-4", EntryPoint = "sws_getConstVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsVector* sws_getConstVec(double @c, int @length);
        
        [DllImport("swscale-4", EntryPoint = "sws_getIdentityVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsVector* sws_getIdentityVec();
        
        [DllImport("swscale-4", EntryPoint = "sws_convVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_convVec(SwsVector* @a, SwsVector* @b);
        
        [DllImport("swscale-4", EntryPoint = "sws_addVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_addVec(SwsVector* @a, SwsVector* @b);
        
        [DllImport("swscale-4", EntryPoint = "sws_subVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_subVec(SwsVector* @a, SwsVector* @b);
        
        [DllImport("swscale-4", EntryPoint = "sws_shiftVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_shiftVec(SwsVector* @a, int @shift);
        
        [DllImport("swscale-4", EntryPoint = "sws_cloneVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsVector* sws_cloneVec(SwsVector* @a);
        
        [DllImport("swscale-4", EntryPoint = "sws_printVec2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_printVec2(SwsVector* @a, AVClass* @log_ctx, int @log_level);
        
        [DllImport("swscale-4", EntryPoint = "sws_freeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_freeVec(SwsVector* @a);
        
        [DllImport("swscale-4", EntryPoint = "sws_getDefaultFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
        
        [DllImport("swscale-4", EntryPoint = "sws_freeFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_freeFilter(SwsFilter* @filter);
        
        /// <summary>Check if context can be reused, otherwise reallocate a new one.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_getCachedContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr sws_getCachedContext(IntPtr @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        
        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 32 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        [DllImport("swscale-4", EntryPoint = "sws_convertPalette8ToPacked32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        
        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 24 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        [DllImport("swscale-4", EntryPoint = "sws_convertPalette8ToPacked24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        
        /// <summary>Get the AVClass for swsContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("swscale-4", EntryPoint = "sws_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* sws_get_class();
        
    }
}
