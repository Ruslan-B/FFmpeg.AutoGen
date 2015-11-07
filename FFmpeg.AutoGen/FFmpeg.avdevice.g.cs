using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVDictionary
    {
    }
    
    public unsafe partial struct AVOption
    {
        public sbyte* @name;
        public sbyte* @help;
        public int @offset;
        public AVOptionType @type;
        public default_val @default_val;
        public double @min;
        public double @max;
        public int @flags;
        public sbyte* @unit;
    }
    
    public unsafe partial struct default_val
    {
        public long @i64;
        public double @dbl;
        public sbyte* @str;
        public AVRational @q;
    }
    
    public unsafe partial struct AVOptionRange
    {
        public sbyte* @str;
        public double @value_min;
        public double @value_max;
        public double @component_min;
        public double @component_max;
        public int @is_range;
    }
    
    public unsafe partial struct AVOptionRanges
    {
        public AVOptionRange** @range;
        public int @nb_ranges;
        public int @nb_components;
    }
    
    public unsafe partial struct AVBuffer
    {
    }
    
    public unsafe partial struct AVBufferPool
    {
    }
    
    public unsafe partial struct AVBPrint
    {
    }
    
    public unsafe partial struct AVCodecInternal
    {
    }
    
    public unsafe partial struct AVCodecDefault
    {
    }
    
    public unsafe partial struct MpegEncContext
    {
    }
    
    public unsafe partial struct ReSampleContext
    {
    }
    
    public unsafe partial struct AVResampleContext
    {
    }
    
    public unsafe partial struct AVBPrint
    {
    }
    
    public unsafe partial struct AVDeviceInfoList
    {
    }
    
    public unsafe partial struct AVDeviceCapabilitiesQuery
    {
    }
    
    public unsafe partial struct AVCodecTag
    {
    }
    
    public unsafe partial struct AVFormatInternal
    {
    }
    
    public unsafe partial struct AVDeviceRect
    {
        public int @x;
        public int @y;
        public int @width;
        public int @height;
    }
    
    public unsafe partial struct AVDeviceCapabilitiesQuery
    {
        public AVClass* @av_class;
        public AVFormatContext* @device_context;
        public AVCodecID @codec;
        public AVSampleFormat @sample_format;
        public AVPixelFormat @pixel_format;
        public int @sample_rate;
        public int @channels;
        public long @channel_layout;
        public int @window_width;
        public int @window_height;
        public int @frame_width;
        public int @frame_height;
        public AVRational @fps;
    }
    
    public unsafe partial struct AVDeviceInfo
    {
        public sbyte* @device_name;
        public sbyte* @device_description;
    }
    
    public unsafe partial struct AVDeviceInfoList
    {
        public AVDeviceInfo** @devices;
        public int @nb_devices;
        public int @default_device;
    }
    
    public enum AVOptionType : int
    {
        @AV_OPT_TYPE_FLAGS = 0,
        @AV_OPT_TYPE_INT = 1,
        @AV_OPT_TYPE_INT64 = 2,
        @AV_OPT_TYPE_DOUBLE = 3,
        @AV_OPT_TYPE_FLOAT = 4,
        @AV_OPT_TYPE_STRING = 5,
        @AV_OPT_TYPE_RATIONAL = 6,
        @AV_OPT_TYPE_BINARY = 7,
        @AV_OPT_TYPE_DICT = 8,
        @AV_OPT_TYPE_CONST = 128,
        @AV_OPT_TYPE_IMAGE_SIZE = 1397316165,
        @AV_OPT_TYPE_PIXEL_FMT = 1346784596,
        @AV_OPT_TYPE_SAMPLE_FMT = 1397116244,
        @AV_OPT_TYPE_VIDEO_RATE = 1448231252,
        @AV_OPT_TYPE_DURATION = 1146442272,
        @AV_OPT_TYPE_COLOR = 1129270354,
        @AV_OPT_TYPE_CHANNEL_LAYOUT = 1128811585,
        @FF_OPT_TYPE_FLAGS = 0,
        @FF_OPT_TYPE_INT = 1,
        @FF_OPT_TYPE_INT64 = 2,
        @FF_OPT_TYPE_DOUBLE = 3,
        @FF_OPT_TYPE_FLOAT = 4,
        @FF_OPT_TYPE_STRING = 5,
        @FF_OPT_TYPE_RATIONAL = 6,
        @FF_OPT_TYPE_BINARY = 7,
        @FF_OPT_TYPE_CONST = 128,
    }
    
    public enum av_opt_eval_flags : int
    {
        @AV_OPT_FLAG_IMPLICIT_KEY = 1,
    }
    
    public enum AVAppToDevMessageType : int
    {
        @AV_APP_TO_DEV_NONE = 1313820229,
        @AV_APP_TO_DEV_WINDOW_SIZE = 1195724621,
        @AV_APP_TO_DEV_WINDOW_REPAINT = 1380274241,
        @AV_APP_TO_DEV_PAUSE = 1346458912,
        @AV_APP_TO_DEV_PLAY = 1347174745,
        @AV_APP_TO_DEV_TOGGLE_PAUSE = 1346458964,
        @AV_APP_TO_DEV_SET_VOLUME = 1398165324,
        @AV_APP_TO_DEV_MUTE = 541939028,
        @AV_APP_TO_DEV_UNMUTE = 1431131476,
        @AV_APP_TO_DEV_TOGGLE_MUTE = 1414354260,
        @AV_APP_TO_DEV_GET_VOLUME = 1196838732,
        @AV_APP_TO_DEV_GET_MUTE = 1196250452,
    }
    
    public enum AVDevToAppMessageType : int
    {
        @AV_DEV_TO_APP_NONE = 1313820229,
        @AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 1111708229,
        @AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 1112560197,
        @AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 1111771475,
        @AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 1111770451,
        @AV_DEV_TO_APP_BUFFER_OVERFLOW = 1112491596,
        @AV_DEV_TO_APP_BUFFER_UNDERFLOW = 1112884812,
        @AV_DEV_TO_APP_BUFFER_READABLE = 1112687648,
        @AV_DEV_TO_APP_BUFFER_WRITABLE = 1113018912,
        @AV_DEV_TO_APP_MUTE_STATE_CHANGED = 1129141588,
        @AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 1129729868,
    }
    
    public unsafe static partial class ffmpeg
    {
        public const ulong LIBAVDEVICE_VERSION_MAJOR = 56;
        public const ulong LIBAVDEVICE_VERSION_MINOR = 4;
        public const ulong LIBAVDEVICE_VERSION_MICRO = 100;
        public const ulong AV_OPT_FLAG_ENCODING_PARAM = 1;
        public const ulong AV_OPT_FLAG_DECODING_PARAM = 2;
        public const ulong AV_OPT_FLAG_METADATA = 4;
        public const ulong AV_OPT_FLAG_AUDIO_PARAM = 8;
        public const ulong AV_OPT_FLAG_VIDEO_PARAM = 16;
        public const ulong AV_OPT_FLAG_SUBTITLE_PARAM = 32;
        public const ulong AV_OPT_FLAG_EXPORT = 64;
        public const ulong AV_OPT_FLAG_READONLY = 128;
        public const ulong AV_OPT_FLAG_FILTERING_PARAM = (1<<16);
        public const ulong AV_OPT_SEARCH_CHILDREN = 0x0001;
        public const ulong AV_OPT_SEARCH_FAKE_OBJ = 0x0002;
        public const ulong AV_OPT_MULTI_COMPONENT_RANGE = 0x1000;
        public const ulong AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001;
        public const ulong AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002;
        private const string libavdevice = "avdevice-56";
        
        [DllImport(libavdevice, EntryPoint = "av_set_string3", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_set_string3(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @val, int @alloc, AVOption** @o_out);
        
        [DllImport(libavdevice, EntryPoint = "av_set_double", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_set_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, double @n);
        
        [DllImport(libavdevice, EntryPoint = "av_set_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_set_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @n);
        
        [DllImport(libavdevice, EntryPoint = "av_set_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_set_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @n);
        
        [DllImport(libavdevice, EntryPoint = "av_get_double", CallingConvention = CallingConvention.Cdecl)]
        public static extern double av_get_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVOption** @o_out);
        
        [DllImport(libavdevice, EntryPoint = "av_get_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_get_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVOption** @o_out);
        
        [DllImport(libavdevice, EntryPoint = "av_get_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_get_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVOption** @o_out);
        
        [DllImport(libavdevice, EntryPoint = "av_get_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_string(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVOption** @o_out, IntPtr @buf, int @buf_len);
        
        [DllImport(libavdevice, EntryPoint = "av_next_option", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_next_option(void* @obj, AVOption* @last);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_show2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_defaults", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_opt_set_defaults(void* @s);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_defaults2", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_opt_set_defaults2(void* @s, int @mask, int @flags);
        
        [DllImport(libavdevice, EntryPoint = "av_set_options_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_set_options_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_from_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_from_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, string[] @shorthand, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_opt_free(void* @obj);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_flag_is_set", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_flag_is_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @field_name, [MarshalAs(UnmanagedType.LPStr)] string @flag_name);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_dict", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_dict(void* @obj, AVDictionary** @options);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_dict2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_key_value", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_key_value(sbyte** @ropts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, uint @flags, sbyte** @rkey, sbyte** @rval);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_flags(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @flags_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_int(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @int_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_int64", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_int64(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, long* @int64_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_float", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_float(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, float* @float_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_double", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_double(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, double* @double_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_eval_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_eval_q(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, AVRational* @q_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_find", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_opt_find(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_find2", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_opt_find2(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags, void** @target_obj);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOption* av_opt_next(void* @obj, AVOption* @prev);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_child_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_opt_child_next(void* @obj, void* @prev);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_child_class_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVClass* av_opt_child_class_next(AVClass* @parent, AVClass* @prev);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_double", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, double @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_bin(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, sbyte* @val, int @size, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_image_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @w, int @h, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_pixel_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVPixelFormat @fmt, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVSampleFormat @fmt, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_video_rate", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @ch_layout, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_set_dict_val", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_set_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVDictionary* @val, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, sbyte** @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_double", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, double* @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_image_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, int* @w_out, int* @h_out);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_pixel_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVPixelFormat* @out_fmt);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVSampleFormat* @out_fmt);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_video_rate", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @ch_layout);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_get_dict_val", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_get_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVDictionary** @out_val);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_ptr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_opt_ptr(AVClass* @avclass, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_freep_ranges", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_opt_freep_ranges(AVOptionRanges** @ranges);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_query_ranges", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_query_ranges(AVOptionRanges** @param0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_copy(void* @dest, void* @src);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_query_ranges_default", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_query_ranges_default(AVOptionRanges** @param0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_is_set_to_default", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_is_set_to_default(void* @obj, AVOption* @o);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_is_set_to_default_by_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_is_set_to_default_by_name(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags);
        
        [DllImport(libavdevice, EntryPoint = "av_opt_serialize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_opt_serialize(void* @obj, int @opt_flags, int @flags, sbyte** @buffer, sbyte @key_val_sep, sbyte @pairs_sep);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint avdevice_version();
        
        [DllImport(libavdevice, EntryPoint = "avdevice_configuration", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avdevice_configuration();
        
        [DllImport(libavdevice, EntryPoint = "avdevice_license", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avdevice_license();
        
        [DllImport(libavdevice, EntryPoint = "avdevice_register_all", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avdevice_register_all();
        
        [DllImport(libavdevice, EntryPoint = "av_input_audio_device_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVInputFormat* av_input_audio_device_next(AVInputFormat* @d);
        
        [DllImport(libavdevice, EntryPoint = "av_input_video_device_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVInputFormat* av_input_video_device_next(AVInputFormat* @d);
        
        [DllImport(libavdevice, EntryPoint = "av_output_audio_device_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d);
        
        [DllImport(libavdevice, EntryPoint = "av_output_video_device_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_app_to_dev_control_message", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_dev_to_app_control_message", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_capabilities_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_capabilities_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_list_devices", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_free_list_devices", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avdevice_free_list_devices(AVDeviceInfoList** @device_list);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_list_input_sources", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_list_input_sources(AVInputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
        [DllImport(libavdevice, EntryPoint = "avdevice_list_output_sinks", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avdevice_list_output_sinks(AVOutputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
    }
}
