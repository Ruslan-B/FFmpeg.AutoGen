using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    /// <summary>Message types used by avdevice_app_to_dev_control_message().</summary>
    public enum AVAppToDevMessageType : int
    {
        /// <summary>Dummy message.</summary>
        @AV_APP_TO_DEV_NONE = 1313820229,
        /// <summary>Window size change message.</summary>
        @AV_APP_TO_DEV_WINDOW_SIZE = 1195724621,
        /// <summary>Repaint request message.</summary>
        @AV_APP_TO_DEV_WINDOW_REPAINT = 1380274241,
        /// <summary>Request pause/play.</summary>
        @AV_APP_TO_DEV_PAUSE = 1346458912,
        /// <summary>Request pause/play.</summary>
        @AV_APP_TO_DEV_PLAY = 1347174745,
        /// <summary>Request pause/play.</summary>
        @AV_APP_TO_DEV_TOGGLE_PAUSE = 1346458964,
        /// <summary>Volume control message.</summary>
        @AV_APP_TO_DEV_SET_VOLUME = 1398165324,
        /// <summary>Mute control messages.</summary>
        @AV_APP_TO_DEV_MUTE = 541939028,
        /// <summary>Mute control messages.</summary>
        @AV_APP_TO_DEV_UNMUTE = 1431131476,
        /// <summary>Mute control messages.</summary>
        @AV_APP_TO_DEV_TOGGLE_MUTE = 1414354260,
        /// <summary>Get volume/mute messages.</summary>
        @AV_APP_TO_DEV_GET_VOLUME = 1196838732,
        /// <summary>Get volume/mute messages.</summary>
        @AV_APP_TO_DEV_GET_MUTE = 1196250452,
    }
    
    /// <summary>Message types used by avdevice_dev_to_app_control_message().</summary>
    public enum AVDevToAppMessageType : int
    {
        /// <summary>Dummy message.</summary>
        @AV_DEV_TO_APP_NONE = 1313820229,
        /// <summary>Create window buffer message.</summary>
        @AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 1111708229,
        /// <summary>Prepare window buffer message.</summary>
        @AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 1112560197,
        /// <summary>Display window buffer message.</summary>
        @AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 1111771475,
        /// <summary>Destroy window buffer message.</summary>
        @AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 1111770451,
        /// <summary>Buffer fullness status messages.</summary>
        @AV_DEV_TO_APP_BUFFER_OVERFLOW = 1112491596,
        /// <summary>Buffer fullness status messages.</summary>
        @AV_DEV_TO_APP_BUFFER_UNDERFLOW = 1112884812,
        /// <summary>Buffer readable/writable.</summary>
        @AV_DEV_TO_APP_BUFFER_READABLE = 1112687648,
        /// <summary>Buffer readable/writable.</summary>
        @AV_DEV_TO_APP_BUFFER_WRITABLE = 1113018912,
        /// <summary>Mute state change message.</summary>
        @AV_DEV_TO_APP_MUTE_STATE_CHANGED = 1129141588,
        /// <summary>Volume level change message.</summary>
        @AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 1129729868,
    }
    
    /// <summary>Structure describes basic parameters of the device.</summary>
    public unsafe struct AVDeviceInfo
    {
        /// <summary>device name, format depends on device</summary>
        public byte* @device_name;
        /// <summary>human friendly name</summary>
        public byte* @device_description;
    }
    
    public unsafe struct AVDeviceRect
    {
        /// <summary>x coordinate of top left corner</summary>
        public int @x;
        /// <summary>y coordinate of top left corner</summary>
        public int @y;
        /// <summary>width</summary>
        public int @width;
        /// <summary>height</summary>
        public int @height;
    }
    
    /// <summary>Structure describes device capabilities.</summary>
    public unsafe struct AVDeviceCapabilitiesQuery
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
    
    /// <summary>List of devices.</summary>
    public unsafe struct AVDeviceInfoList
    {
        /// <summary>list of autodetected devices</summary>
        public AVDeviceInfo** @devices;
        /// <summary>number of autodetected devices</summary>
        public int @nb_devices;
        /// <summary>index of default device or -1 if no default</summary>
        public int @default_device;
    }
    
    public unsafe static partial class ffmpeg
    {
        public static int LIBAVDEVICE_VERSION_MAJOR = 57;
        public static int LIBAVDEVICE_VERSION_MINOR = 1;
        public static int LIBAVDEVICE_VERSION_MICRO = 100;
        public static int AV_OPT_FLAG_ENCODING_PARAM = 1;
        public static int AV_OPT_FLAG_DECODING_PARAM = 2;
        public static int AV_OPT_FLAG_METADATA = 4;
        public static int AV_OPT_FLAG_AUDIO_PARAM = 8;
        public static int AV_OPT_FLAG_VIDEO_PARAM = 16;
        public static int AV_OPT_FLAG_SUBTITLE_PARAM = 32;
        public static int AV_OPT_FLAG_EXPORT = 64;
        public static int AV_OPT_FLAG_READONLY = 128;
        public static int AV_OPT_FLAG_FILTERING_PARAM = (1<<16);
        public static int AV_OPT_SEARCH_CHILDREN = (1 << 0);
        public static int AV_OPT_SEARCH_FAKE_OBJ = (1 << 1);
        public static int AV_OPT_ALLOW_NULL = (1 << 2);
        public static int AV_OPT_MULTI_COMPONENT_RANGE = (1 << 12);
        public static int AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001;
        public static int AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002;
        
        /// <summary>Return the LIBAVDEVICE_VERSION_INT constant.</summary>
        [DllImport("avdevice-57", EntryPoint = "avdevice_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avdevice_version();
        
        /// <summary>Return the libavdevice build-time configuration.</summary>
        [DllImport("avdevice-57", EntryPoint = "avdevice_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avdevice_configuration();
        
        /// <summary>Return the libavdevice license.</summary>
        [DllImport("avdevice-57", EntryPoint = "avdevice_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avdevice_license();
        
        /// <summary>Initialize libavdevice and register all the input and output devices.</summary>
        [DllImport("avdevice-57", EntryPoint = "avdevice_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avdevice_register_all();
        
        /// <summary>Audio input devices iterator.</summary>
        [DllImport("avdevice-57", EntryPoint = "av_input_audio_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_input_audio_device_next(AVInputFormat* @d);
        
        /// <summary>Video input devices iterator.</summary>
        [DllImport("avdevice-57", EntryPoint = "av_input_video_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_input_video_device_next(AVInputFormat* @d);
        
        /// <summary>Audio output devices iterator.</summary>
        [DllImport("avdevice-57", EntryPoint = "av_output_audio_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d);
        
        /// <summary>Video output devices iterator.</summary>
        [DllImport("avdevice-57", EntryPoint = "av_output_video_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d);
        
        /// <summary>Send control message from application to device.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Exact type depends on message type.</param>
        /// <param name="data_size">size of message data.</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_app_to_dev_control_message", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_app_to_dev_control_message(IntPtr @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
        
        /// <summary>Send control message from device to application.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Can be NULL.</param>
        /// <param name="data_size">size of message data.</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_dev_to_app_control_message", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_dev_to_app_control_message(IntPtr @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
        
        /// <summary>Initialize capabilities probing API based on AVOption API.</summary>
        /// <param name="caps">Device capabilities data. Pointer to a NULL pointer must be passed.</param>
        /// <param name="s">Context of the device.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_capabilities_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);
        
        /// <summary>Free resources created by avdevice_capabilities_create()</summary>
        /// <param name="caps">Device capabilities data to be freed.</param>
        /// <param name="s">Context of the device.</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_capabilities_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);
        
        /// <summary>List devices.</summary>
        /// <param name="s">device context.</param>
        /// <param name="device_list">list of autodetected devices.</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_list_devices", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_list_devices(IntPtr @s, AVDeviceInfoList** @device_list);
        
        /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
        [DllImport("avdevice-57", EntryPoint = "avdevice_free_list_devices", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avdevice_free_list_devices(AVDeviceInfoList** @device_list);
        
        /// <summary>List devices.</summary>
        /// <param name="device">device format. May be NULL if device name is set.</param>
        /// <param name="device_name">device name. May be NULL if device format is set.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        /// <param name="device_list">list of autodetected devices</param>
        [DllImport("avdevice-57", EntryPoint = "avdevice_list_input_sources", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_list_input_sources(IntPtr @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
        [DllImport("avdevice-57", EntryPoint = "avdevice_list_output_sinks", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avdevice_list_output_sinks(IntPtr @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
    }
}
