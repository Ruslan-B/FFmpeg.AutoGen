using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    /// <summary>Dithering algorithms</summary>
    public enum SwrDitherType : int
    {
        @SWR_DITHER_NONE = 0,
        @SWR_DITHER_RECTANGULAR = 1,
        @SWR_DITHER_TRIANGULAR = 2,
        @SWR_DITHER_TRIANGULAR_HIGHPASS = 3,
        /// <summary>not part of API/ABI</summary>
        @SWR_DITHER_NS = 64,
        @SWR_DITHER_NS_LIPSHITZ = 65,
        @SWR_DITHER_NS_F_WEIGHTED = 66,
        @SWR_DITHER_NS_MODIFIED_E_WEIGHTED = 67,
        @SWR_DITHER_NS_IMPROVED_E_WEIGHTED = 68,
        @SWR_DITHER_NS_SHIBATA = 69,
        @SWR_DITHER_NS_LOW_SHIBATA = 70,
        @SWR_DITHER_NS_HIGH_SHIBATA = 71,
        /// <summary>not part of API/ABI</summary>
        @SWR_DITHER_NB = 72,
    }
    
    /// <summary>Resampling Engines</summary>
    public enum SwrEngine : int
    {
        /// <summary>SW Resampler</summary>
        @SWR_ENGINE_SWR = 0,
        /// <summary>SoX Resampler</summary>
        @SWR_ENGINE_SOXR = 1,
        /// <summary>not part of API/ABI</summary>
        @SWR_ENGINE_NB = 2,
    }
    
    /// <summary>Resampling Filter Types</summary>
    public enum SwrFilterType : int
    {
        /// <summary>Cubic</summary>
        @SWR_FILTER_TYPE_CUBIC = 0,
        /// <summary>Blackman Nuttall windowed sinc</summary>
        @SWR_FILTER_TYPE_BLACKMAN_NUTTALL = 1,
        /// <summary>Kaiser windowed sinc</summary>
        @SWR_FILTER_TYPE_KAISER = 2,
    }
    
    public unsafe struct SwrContext
    {
    }
    
    public unsafe static partial class ffmpeg
    {
        public static int SWR_FLAG_RESAMPLE = 1;
        public static int AV_CH_FRONT_LEFT = 1;
        public static int AV_CH_FRONT_RIGHT = 2;
        public static int AV_CH_FRONT_CENTER = 4;
        public static int AV_CH_LOW_FREQUENCY = 8;
        public static int AV_CH_BACK_LEFT = 16;
        public static int AV_CH_BACK_RIGHT = 32;
        public static int AV_CH_FRONT_LEFT_OF_CENTER = 64;
        public static int AV_CH_FRONT_RIGHT_OF_CENTER = 128;
        public static int AV_CH_BACK_CENTER = 256;
        public static int AV_CH_SIDE_LEFT = 512;
        public static int AV_CH_SIDE_RIGHT = 1024;
        public static int AV_CH_TOP_CENTER = 2048;
        public static int AV_CH_TOP_FRONT_LEFT = 4096;
        public static int AV_CH_TOP_FRONT_CENTER = 8192;
        public static int AV_CH_TOP_FRONT_RIGHT = 16384;
        public static int AV_CH_TOP_BACK_LEFT = 32768;
        public static int AV_CH_TOP_BACK_CENTER = 65536;
        public static int AV_CH_TOP_BACK_RIGHT = 131072;
        public static int AV_CH_STEREO_LEFT = 536870912;
        public static int AV_CH_STEREO_RIGHT = 1073741824;
        // public static  AV_CH_WIDE_LEFT = 0x0000000080000000ULL;
        // public static  AV_CH_WIDE_RIGHT = 0x0000000100000000ULL;
        // public static  AV_CH_SURROUND_DIRECT_LEFT = 0x0000000200000000ULL;
        // public static  AV_CH_SURROUND_DIRECT_RIGHT = 0x0000000400000000ULL;
        // public static  AV_CH_LOW_FREQUENCY_2 = 0x0000000800000000ULL;
        // public static  AV_CH_LAYOUT_NATIVE = 0x8000000000000000ULL;
        // public static  AV_CH_LAYOUT_MONO = (AV_CH_FRONT_CENTER);
        // public static  AV_CH_LAYOUT_STEREO = (AV_CH_FRONT_LEFT|AV_CH_FRONT_RIGHT);
        // public static  AV_CH_LAYOUT_2POINT1 = (AV_CH_LAYOUT_STEREO|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_2_1 = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_SURROUND = (AV_CH_LAYOUT_STEREO|AV_CH_FRONT_CENTER);
        // public static  AV_CH_LAYOUT_3POINT1 = (AV_CH_LAYOUT_SURROUND|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_4POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_4POINT1 = (AV_CH_LAYOUT_4POINT0|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_2_2 = (AV_CH_LAYOUT_STEREO|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT);
        // public static  AV_CH_LAYOUT_QUAD = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        // public static  AV_CH_LAYOUT_5POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT);
        // public static  AV_CH_LAYOUT_5POINT1 = (AV_CH_LAYOUT_5POINT0|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_5POINT0_BACK = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        // public static  AV_CH_LAYOUT_5POINT1_BACK = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_6POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_6POINT0_FRONT = (AV_CH_LAYOUT_2_2|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        // public static  AV_CH_LAYOUT_HEXAGONAL = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_6POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_6POINT1_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_BACK_CENTER);
        // public static  AV_CH_LAYOUT_6POINT1_FRONT = (AV_CH_LAYOUT_6POINT0_FRONT|AV_CH_LOW_FREQUENCY);
        // public static  AV_CH_LAYOUT_7POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        // public static  AV_CH_LAYOUT_7POINT0_FRONT = (AV_CH_LAYOUT_5POINT0|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        // public static  AV_CH_LAYOUT_7POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        // public static  AV_CH_LAYOUT_7POINT1_WIDE = (AV_CH_LAYOUT_5POINT1|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        // public static  AV_CH_LAYOUT_7POINT1_WIDE_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        // public static  AV_CH_LAYOUT_OCTAGONAL = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_CENTER|AV_CH_BACK_RIGHT);
        // public static  AV_CH_LAYOUT_HEXADECAGONAL = (AV_CH_LAYOUT_OCTAGONAL|AV_CH_WIDE_LEFT|AV_CH_WIDE_RIGHT|AV_CH_TOP_BACK_LEFT|AV_CH_TOP_BACK_RIGHT|AV_CH_TOP_BACK_CENTER|AV_CH_TOP_FRONT_CENTER|AV_CH_TOP_FRONT_LEFT|AV_CH_TOP_FRONT_RIGHT);
        // public static  AV_CH_LAYOUT_STEREO_DOWNMIX = (AV_CH_STEREO_LEFT|AV_CH_STEREO_RIGHT);
        // public static  AV_BUFFER_FLAG_READONLY = (1 << 0);
        public static int AV_DICT_MATCH_CASE = 1;
        public static int AV_DICT_IGNORE_SUFFIX = 2;
        public static int AV_DICT_DONT_STRDUP_KEY = 4;
        public static int AV_DICT_DONT_STRDUP_VAL = 8;
        public static int AV_DICT_DONT_OVERWRITE = 16;
        public static int AV_DICT_APPEND = 32;
        public static int AV_DICT_MULTIKEY = 64;
        public static int AV_NUM_DATA_POINTERS = 8;
        // public static  AV_FRAME_FLAG_CORRUPT = (1 << 0);
        // public static  AV_FRAME_FLAG_DISCARD = (1 << 2);
        public static int FF_DECODE_ERROR_INVALID_BITSTREAM = 1;
        public static int FF_DECODE_ERROR_MISSING_REFERENCE = 2;
        public static int LIBSWRESAMPLE_VERSION_MAJOR = 2;
        public static int LIBSWRESAMPLE_VERSION_MINOR = 3;
        public static int LIBSWRESAMPLE_VERSION_MICRO = 100;
        // public static  LIBSWRESAMPLE_VERSION_INT = AV_VERSION_INT(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        // public static  LIBSWRESAMPLE_VERSION = AV_VERSION(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        // public static  LIBSWRESAMPLE_BUILD = LIBSWRESAMPLE_VERSION_INT;
        // public static  LIBSWRESAMPLE_IDENT = "SwR" AV_STRINGIFY(LIBSWRESAMPLE_VERSION);
        
        /// <summary>Get the AVClass for SwrContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("swresample-2", EntryPoint = "swr_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* swr_get_class();
        
        /// <summary>Allocate SwrContext.</summary>
        [DllImport("swresample-2", EntryPoint = "swr_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr swr_alloc();
        
        /// <summary>Initialize context after user parameters have been set.</summary>
        /// <param name="s">Swr context to initialize</param>
        [DllImport("swresample-2", EntryPoint = "swr_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_init(IntPtr @s);
        
        /// <summary>Check whether an swr context has been initialized or not.</summary>
        /// <param name="s">Swr context to check</param>
        [DllImport("swresample-2", EntryPoint = "swr_is_initialized", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_is_initialized(IntPtr @s);
        
        /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
        /// <param name="s">existing Swr context if available, or NULL if not</param>
        /// <param name="out_ch_layout">output channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
        /// <param name="in_ch_layout">input channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
        /// <param name="log_offset">logging level offset</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        [DllImport("swresample-2", EntryPoint = "swr_alloc_set_opts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr swr_alloc_set_opts(IntPtr @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
        
        /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
        /// <param name="s">a pointer to a pointer to Swr context</param>
        [DllImport("swresample-2", EntryPoint = "swr_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void swr_free(IntPtr* @s);
        
        /// <summary>Closes the context so that swr_is_initialized() returns 0.</summary>
        /// <param name="s">Swr context to be closed</param>
        [DllImport("swresample-2", EntryPoint = "swr_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void swr_close(IntPtr @s);
        
        /// <summary>Convert audio.</summary>
        /// <param name="s">allocated Swr context, with parameters set</param>
        /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
        /// <param name="out_count">amount of space available for output in samples per channel</param>
        /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
        /// <param name="in_count">number of input samples available in one channel</param>
        [DllImport("swresample-2", EntryPoint = "swr_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_convert(IntPtr @s, byte** @out, int @out_count, byte** @in, int @in_count);
        
        /// <summary>Convert the next timestamp from input to output timestamps are in 1/(in_sample_rate * out_sample_rate) units.</summary>
        [DllImport("swresample-2", EntryPoint = "swr_next_pts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long swr_next_pts(IntPtr @s, long @pts);
        
        /// <summary>Activate resampling compensation ("soft" compensation). This function is internally called when needed in swr_next_pts().</summary>
        /// <param name="s">allocated Swr context. If it is not initialized, or SWR_FLAG_RESAMPLE is not set, swr_init() is called with the flag set.</param>
        /// <param name="sample_delta">delta in PTS per sample</param>
        /// <param name="compensation_distance">number of samples to compensate for</param>
        [DllImport("swresample-2", EntryPoint = "swr_set_compensation", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_set_compensation(IntPtr @s, int @sample_delta, int @compensation_distance);
        
        /// <summary>Set a customized input channel mapping.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="channel_map">customized input channel mapping (array of channel indexes, -1 for a muted channel)</param>
        [DllImport("swresample-2", EntryPoint = "swr_set_channel_mapping", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_set_channel_mapping(IntPtr @s, int* @channel_map);
        
        /// <summary>Generate a channel mixing matrix.</summary>
        /// <param name="in_layout">input channel layout</param>
        /// <param name="out_layout">output channel layout</param>
        /// <param name="center_mix_level">mix level for the center channel</param>
        /// <param name="surround_mix_level">mix level for the surround channel(s)</param>
        /// <param name="lfe_mix_level">mix level for the low-frequency effects channel</param>
        /// <param name="rematrix_maxval">if 1.0, coefficients will be normalized to prevent overflow. if INT_MAX, coefficients will not be normalized.</param>
        /// <param name="matrix">mixing coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o.</param>
        /// <param name="stride">distance between adjacent input channels in the matrix array</param>
        /// <param name="matrix_encoding">matrixed stereo downmix mode (e.g. dplii)</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        [DllImport("swresample-2", EntryPoint = "swr_build_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_build_matrix(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx);
        
        /// <summary>Set a customized remix matrix.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="matrix">remix coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o</param>
        /// <param name="stride">offset between lines of the matrix</param>
        [DllImport("swresample-2", EntryPoint = "swr_set_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_set_matrix(IntPtr @s, double* @matrix, int @stride);
        
        /// <summary>Drops the specified number of output samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        [DllImport("swresample-2", EntryPoint = "swr_drop_output", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_drop_output(IntPtr @s, int @count);
        
        /// <summary>Injects the specified number of silence samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        [DllImport("swresample-2", EntryPoint = "swr_inject_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_inject_silence(IntPtr @s, int @count);
        
        /// <summary>Gets the delay the next input sample will experience relative to the next output sample.</summary>
        /// <param name="s">swr context</param>
        /// <param name="base">timebase in which the returned delay will be:</param>
        [DllImport("swresample-2", EntryPoint = "swr_get_delay", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long swr_get_delay(IntPtr @s, long @base);
        
        /// <summary>Find an upper bound on the number of samples that the next swr_convert call will output, if called with in_samples of input samples. This depends on the internal state, and anything changing the internal state (like further swr_convert() calls) will may change the number of samples swr_get_out_samples() returns for the same number of input samples.</summary>
        /// <param name="in_samples">number of input samples.</param>
        [DllImport("swresample-2", EntryPoint = "swr_get_out_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_get_out_samples(IntPtr @s, int @in_samples);
        
        /// <summary>Return the</summary>
        [DllImport("swresample-2", EntryPoint = "swresample_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint swresample_version();
        
        /// <summary>Return the swr build-time configuration.</summary>
        [DllImport("swresample-2", EntryPoint = "swresample_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string swresample_configuration();
        
        /// <summary>Return the swr license.</summary>
        [DllImport("swresample-2", EntryPoint = "swresample_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string swresample_license();
        
        /// <summary>Convert the samples in the input AVFrame and write them to the output AVFrame.</summary>
        /// <param name="swr">audio resample context</param>
        /// <param name="output">output AVFrame</param>
        /// <param name="input">input AVFrame</param>
        [DllImport("swresample-2", EntryPoint = "swr_convert_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
        
        /// <summary>Configure or reconfigure the SwrContext using the information provided by the AVFrames.</summary>
        /// <param name="swr">audio resample context</param>
        [DllImport("swresample-2", EntryPoint = "swr_config_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
        
    }
}
