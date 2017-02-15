using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    /// <summary>stage of the initialization of the link properties (dimensions, etc)</summary>
    public enum AVFilterLink_init_state : int
    {
        /// <summary>not started</summary>
        @AVLINK_UNINIT = 0,
        /// <summary>started, but incomplete</summary>
        @AVLINK_STARTINIT = 1,
        /// <summary>complete</summary>
        @AVLINK_INIT = 2,
    }
    
    public unsafe struct AVFilterPad
    {
    }
    
    /// <summary>An instance of a filter</summary>
    public unsafe struct AVFilterContext
    {
        /// <summary>needed for av_log() and filters common options</summary>
        public AVClass* @av_class;
        /// <summary>the AVFilter of which this is an instance</summary>
        public AVFilter* @filter;
        /// <summary>name of this filter instance</summary>
        public byte* @name;
        /// <summary>array of input pads</summary>
        public AVFilterPad* @input_pads;
        /// <summary>array of pointers to input links</summary>
        public AVFilterLink** @inputs;
        /// <summary>number of input pads</summary>
        public uint @nb_inputs;
        /// <summary>array of output pads</summary>
        public AVFilterPad* @output_pads;
        /// <summary>array of pointers to output links</summary>
        public AVFilterLink** @outputs;
        /// <summary>number of output pads</summary>
        public uint @nb_outputs;
        /// <summary>private data for use by the filter</summary>
        public void* @priv;
        /// <summary>filtergraph this filter belongs to</summary>
        public IntPtr @graph;
        /// <summary>Type of multithreading being allowed/used. A combination of AVFILTER_THREAD_* flags.</summary>
        public int @thread_type;
        /// <summary>An opaque struct for libavfilter internal use.</summary>
        public AVFilterInternal* @internal;
        public IntPtr @command_queue;
        /// <summary>enable expression string</summary>
        public byte* @enable_str;
        /// <summary>parsed expression (AVExpr*)</summary>
        public void* @enable;
        /// <summary>variable values for the enable expression</summary>
        public double* @var_values;
        /// <summary>the enabled state from the last expression evaluation</summary>
        public int @is_disabled;
        /// <summary>For filters which will create hardware frames, sets the device the filter should create them in. All other filters will ignore this field: in particular, a filter which consumes or processes hardware frames will instead use the hw_frames_ctx field in AVFilterLink to carry the hardware context information.</summary>
        public AVBufferRef* @hw_device_ctx;
        /// <summary>Max number of threads allowed in this filter instance. If <= 0, its value is ignored. Overrides global number of threads set per filter graph.</summary>
        public int @nb_threads;
    }
    
    /// <summary>Filter definition. This defines the pads a filter contains, and all the callback functions used to interact with the filter.</summary>
    public unsafe struct AVFilter
    {
        /// <summary>Filter name. Must be non-NULL and unique among filters.</summary>
        public byte* @name;
        /// <summary>A description of the filter. May be NULL.</summary>
        public byte* @description;
        /// <summary>List of inputs, terminated by a zeroed element.</summary>
        public AVFilterPad* @inputs;
        /// <summary>List of outputs, terminated by a zeroed element.</summary>
        public AVFilterPad* @outputs;
        /// <summary>A class for the private data, used to declare filter private AVOptions. This field is NULL for filters that do not declare any options.</summary>
        public AVClass* @priv_class;
        /// <summary>A combination of AVFILTER_FLAG_*</summary>
        public int @flags;
        /// <summary>Filter initialization function.</summary>
        public IntPtr @init;
        /// <summary>Should be set instead of want to pass a dictionary of AVOptions to nested contexts that are allocated during init.</summary>
        public IntPtr @init_dict;
        /// <summary>Filter uninitialization function.</summary>
        public IntPtr @uninit;
        /// <summary>Query formats supported by the filter on its inputs and outputs.</summary>
        public IntPtr @query_formats;
        /// <summary>size of private data to allocate for the filter</summary>
        public int @priv_size;
        /// <summary>Used by the filter registration system. Must not be touched by any other code.</summary>
        public IntPtr @next;
        /// <summary>Make the filter instance process a command.</summary>
        public IntPtr @process_command;
        /// <summary>Filter initialization function, alternative to the init() callback. Args contains the user-supplied parameters, opaque is used for providing binary data.</summary>
        public IntPtr @init_opaque;
    }
    
    public unsafe struct AVFilterFormats
    {
    }
    
    public unsafe struct AVFilterGraphInternal
    {
    }
    
    /// <summary>A link between two filters. This contains pointers to the source and destination filters between which this link exists, and the indexes of the pads involved. In addition, this link also contains the parameters which have been negotiated and agreed upon between the filter, such as image dimensions, format, etc.</summary>
    public unsafe struct AVFilterLink
    {
        /// <summary>source filter</summary>
        public AVFilterContext* @src;
        /// <summary>output pad on the source filter</summary>
        public AVFilterPad* @srcpad;
        /// <summary>dest filter</summary>
        public AVFilterContext* @dst;
        /// <summary>input pad on the dest filter</summary>
        public AVFilterPad* @dstpad;
        /// <summary>filter media type</summary>
        public AVMediaType @type;
        /// <summary>agreed upon image width</summary>
        public int @w;
        /// <summary>agreed upon image height</summary>
        public int @h;
        /// <summary>agreed upon sample aspect ratio</summary>
        public AVRational @sample_aspect_ratio;
        /// <summary>channel layout of current buffer (see libavutil/channel_layout.h)</summary>
        public ulong @channel_layout;
        /// <summary>samples per second</summary>
        public int @sample_rate;
        /// <summary>agreed upon media format</summary>
        public int @format;
        /// <summary>Define the time base used by the PTS of the frames/samples which will pass through this link. During the configuration stage, each filter is supposed to change only the output timebase, while the timebase of the input link is assumed to be an unchangeable property.</summary>
        public AVRational @time_base;
        /// <summary>*************************************************************** All fields below this line are not part of the public API. They may not be used outside of libavfilter and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public AVFilterFormats* @in_formats;
        public AVFilterFormats* @out_formats;
        /// <summary>Lists of channel layouts and sample rates used for automatic negotiation.</summary>
        public AVFilterFormats* @in_samplerates;
        public AVFilterFormats* @out_samplerates;
        public IntPtr @in_channel_layouts;
        public IntPtr @out_channel_layouts;
        /// <summary>Audio only, the destination filter sets this to a non-zero value to request that buffers with the given number of samples should be sent to it. AVFilterPad.needs_fifo must also be set on the corresponding input pad. Last buffer before EOF will be padded with silence.</summary>
        public int @request_samples;
        public AVFilterLink_init_state @init_state;
        /// <summary>Graph the filter belongs to.</summary>
        public IntPtr @graph;
        /// <summary>Current timestamp of the link, as defined by the most recent frame(s), in link time_base units.</summary>
        public long @current_pts;
        /// <summary>Current timestamp of the link, as defined by the most recent frame(s), in AV_TIME_BASE units.</summary>
        public long @current_pts_us;
        /// <summary>Index in the age array.</summary>
        public int @age_index;
        /// <summary>Frame rate of the stream on the link, or 1/0 if unknown or variable; if left to 0/0, will be automatically copied from the first input of the source filter if it exists.</summary>
        public AVRational @frame_rate;
        /// <summary>Buffer partially filled with samples to achieve a fixed/minimum size.</summary>
        public AVFrame* @partial_buf;
        /// <summary>Size of the partial buffer to allocate. Must be between min_samples and max_samples.</summary>
        public int @partial_buf_size;
        /// <summary>Minimum number of samples to filter at once. If filter_frame() is called with fewer samples, it will accumulate them in partial_buf. This field and the related ones must not be changed after filtering has started. If 0, all related fields are ignored.</summary>
        public int @min_samples;
        /// <summary>Maximum number of samples to filter at once. If filter_frame() is called with more samples, it will split them.</summary>
        public int @max_samples;
        /// <summary>Link status. If not zero, all attempts of filter_frame or request_frame will fail with the corresponding code, and if necessary the reference will be destroyed. If request_frame returns an error, the status is set on the corresponding link. It can be set also be set by either the source or the destination filter.</summary>
        public int @status;
        /// <summary>Number of channels.</summary>
        public int @channels;
        /// <summary>Link processing flags.</summary>
        public uint @flags;
        /// <summary>Number of past frames sent through the link.</summary>
        public long @frame_count;
        /// <summary>A pointer to a FFVideoFramePool struct.</summary>
        public void* @video_frame_pool;
        /// <summary>True if a frame is currently wanted on the input of this filter. Set when ff_request_frame() is called by the output, cleared when the request is handled or forwarded.</summary>
        public int @frame_wanted_in;
        /// <summary>True if a frame is currently wanted on the output of this filter. Set when ff_request_frame() is called by the output, cleared when a frame is filtered.</summary>
        public int @frame_wanted_out;
        /// <summary>For hwaccel pixel formats, this should be a reference to the AVHWFramesContext describing the frames.</summary>
        public AVBufferRef* @hw_frames_ctx;
    }
    
    public unsafe struct AVFilterInternal
    {
    }
    
    public unsafe struct AVFilterGraph
    {
        public AVClass* @av_class;
        public AVFilterContext** @filters;
        public uint @nb_filters;
        /// <summary>sws options to use for the auto-inserted scale filters</summary>
        public byte* @scale_sws_opts;
        /// <summary>libavresample options to use for the auto-inserted resample filters</summary>
        public byte* @resample_lavr_opts;
        /// <summary>Type of multithreading allowed for filters in this graph. A combination of AVFILTER_THREAD_* flags.</summary>
        public int @thread_type;
        /// <summary>Maximum number of threads used by filters in this graph. May be set by the caller before adding any filters to the filtergraph. Zero (the default) means that the number of threads is determined automatically.</summary>
        public int @nb_threads;
        /// <summary>Opaque object for libavfilter internal use.</summary>
        public AVFilterGraphInternal* @internal;
        /// <summary>Opaque user data. May be set by the caller to an arbitrary value, e.g. to be used from callbacks like Libavfilter will not touch this field in any way.</summary>
        public void* @opaque;
        /// <summary>This callback may be set by the caller immediately after allocating the graph and before adding any filters to it, to provide a custom multithreading implementation.</summary>
        public avfilter_execute_func* @execute;
        /// <summary>swr options to use for the auto-inserted aresample filters, Access ONLY through AVOptions</summary>
        public byte* @aresample_swr_opts;
        /// <summary>Private fields</summary>
        public AVFilterLink** @sink_links;
        public int @sink_links_count;
        public uint @disable_auto_convert;
    }
    
    /// <summary>A linked-list of the inputs/outputs of the filter chain.</summary>
    public unsafe struct AVFilterInOut
    {
        /// <summary>unique name for this input/output in the list</summary>
        public byte* @name;
        /// <summary>filter context associated to this input/output</summary>
        public AVFilterContext* @filter_ctx;
        /// <summary>index of the filt_ctx pad to use for linking</summary>
        public int @pad_idx;
        /// <summary>next input/input in the list, NULL if this is the last</summary>
        public IntPtr @next;
    }
    
    /// <summary>This structure contains the parameters describing the frames that will be passed to this filter.</summary>
    public unsafe struct AVBufferSrcParameters
    {
        /// <summary>video: the pixel format, value corresponds to enum AVPixelFormat audio: the sample format, value corresponds to enum AVSampleFormat</summary>
        public int @format;
        /// <summary>The timebase to be used for the timestamps on the input frames.</summary>
        public AVRational @time_base;
        /// <summary>Video only, the display dimensions of the input frames.</summary>
        public int @width;
        /// <summary>Video only, the display dimensions of the input frames.</summary>
        public int @height;
        /// <summary>Video only, the sample (pixel) aspect ratio.</summary>
        public AVRational @sample_aspect_ratio;
        /// <summary>Video only, the frame rate of the input video. This field must only be set to a non-zero value if input stream has a known constant framerate and should be left at its initial value if the framerate is variable or unknown.</summary>
        public AVRational @frame_rate;
        /// <summary>Video with a hwaccel pixel format only. This should be a reference to an AVHWFramesContext instance describing the input frames.</summary>
        public AVBufferRef* @hw_frames_ctx;
        /// <summary>Audio only, the audio sampling rate in samples per secon.</summary>
        public int @sample_rate;
        /// <summary>Audio only, the audio channel layout</summary>
        public ulong @channel_layout;
    }
    
    /// <summary>Struct to use for initializing a buffersink context.</summary>
    public unsafe struct AVBufferSinkParams
    {
        /// <summary>list of allowed pixel formats, terminated by AV_PIX_FMT_NONE</summary>
        public IntPtr @pixel_fmts;
    }
    
    /// <summary>Struct to use for initializing an abuffersink context.</summary>
    public unsafe struct AVABufferSinkParams
    {
        /// <summary>list of allowed sample formats, terminated by AV_SAMPLE_FMT_NONE</summary>
        public IntPtr @sample_fmts;
        /// <summary>list of allowed channel layouts, terminated by -1</summary>
        public long* @channel_layouts;
        /// <summary>list of allowed channel counts, terminated by -1</summary>
        public int* @channel_counts;
        /// <summary>if not 0, accept any channel count or layout</summary>
        public int @all_channel_counts;
        /// <summary>list of allowed sample rates, terminated by -1</summary>
        public int* @sample_rates;
    }
    
    public unsafe static partial class ffmpeg
    {
        // public static  AVFILTER_FLAG_DYNAMIC_INPUTS = (1 << 0);
        // public static  AVFILTER_FLAG_DYNAMIC_OUTPUTS = (1 << 1);
        // public static  AVFILTER_FLAG_SLICE_THREADS = (1 << 2);
        // public static  AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = (1 << 16);
        // public static  AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = (1 << 17);
        // public static  AVFILTER_FLAG_SUPPORT_TIMELINE = (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL);
        // public static  AVFILTER_THREAD_SLICE = (1 << 0);
        public static int AVFILTER_CMD_FLAG_ONE = 1;
        public static int AVFILTER_CMD_FLAG_FAST = 2;
        public static int LIBAVFILTER_VERSION_MAJOR = 6;
        public static int LIBAVFILTER_VERSION_MINOR = 65;
        public static int LIBAVFILTER_VERSION_MICRO = 100;
        // public static  LIBAVFILTER_VERSION_INT = AV_VERSION_INT(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO);
        // public static  LIBAVFILTER_VERSION = AV_VERSION(LIBAVFILTER_VERSION_MAJOR,   LIBAVFILTER_VERSION_MINOR,   LIBAVFILTER_VERSION_MICRO);
        // public static  LIBAVFILTER_BUILD = LIBAVFILTER_VERSION_INT;
        // public static  LIBAVFILTER_IDENT = "Lavfi" AV_STRINGIFY(LIBAVFILTER_VERSION);
        // public static  FF_API_OLD_FILTER_OPTS = (LIBAVFILTER_VERSION_MAJOR < 7);
        // public static  FF_API_OLD_FILTER_OPTS_ERROR = (LIBAVFILTER_VERSION_MAJOR < 7);
        // public static  FF_API_AVFILTER_OPEN = (LIBAVFILTER_VERSION_MAJOR < 7);
        // public static  FF_API_AVFILTER_INIT_FILTER = (LIBAVFILTER_VERSION_MAJOR < 7);
        // public static  FF_API_OLD_FILTER_REGISTER = (LIBAVFILTER_VERSION_MAJOR < 7);
        // public static  FF_API_NOCONST_GET_NAME = (LIBAVFILTER_VERSION_MAJOR < 7);
        
        /// <summary>Return the LIBAVFILTER_VERSION_INT constant.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avfilter_version();
        
        /// <summary>Return the libavfilter build-time configuration.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avfilter_configuration();
        
        /// <summary>Return the libavfilter license.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avfilter_license();
        
        /// <summary>Get the number of elements in a NULL-terminated array of AVFilterPads (e.g. AVFilter.inputs/outputs).</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_pad_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_pad_count(AVFilterPad* @pads);
        
        /// <summary>Get the name of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array it; is the caller's responsibility to ensure the index is valid</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_pad_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx);
        
        /// <summary>Get the type of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array; it is the caller's responsibility to ensure the index is valid</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_pad_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx);
        
        /// <summary>Link two filters together.</summary>
        /// <param name="src">the source filter</param>
        /// <param name="srcpad">index of the output pad on the source filter</param>
        /// <param name="dst">the destination filter</param>
        /// <param name="dstpad">index of the input pad on the destination filter</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_link", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
        
        /// <summary>Free the link in *link, and set its pointer to NULL.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_link_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_link_free(AVFilterLink** @link);
        
        /// <summary>Get the number of channels of a link.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_link_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_link_get_channels(AVFilterLink* @link);
        
        /// <summary>Set the closed field of a link.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_link_set_closed", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_link_set_closed(AVFilterLink* @link, int @closed);
        
        /// <summary>Negotiate the media format, dimensions, etc of all inputs to a filter.</summary>
        /// <param name="filter">the filter to negotiate the properties for its inputs</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_config_links", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_config_links(AVFilterContext* @filter);
        
        /// <summary>Make the filter instance process a command. It is recommended to use avfilter_graph_send_command().</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_process_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_process_command(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags);
        
        /// <summary>Initialize the filter system. Register all builtin filters.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_register_all();
        
        /// <summary>Uninitialize the filter system. Unregister all filters.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_uninit();
        
        /// <summary>Register a filter. This is only needed if you plan to use avfilter_get_by_name later to lookup the AVFilter structure by name. A filter can still by instantiated with avfilter_graph_alloc_filter even if it is not registered.</summary>
        /// <param name="filter">the filter to register</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_register(AVFilter* @filter);
        
        [DllImport("avfilter-6", EntryPoint = "avfilter_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilter* avfilter_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Iterate over all registered filters.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilter* avfilter_next(AVFilter* @prev);
        
        /// <summary>If filter is NULL, returns a pointer to the first registered filter pointer, if filter is non-NULL, returns the next pointer after filter. If the returned pointer points to NULL, the last registered filter was already reached.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilter** av_filter_next(AVFilter** @filter);
        
        /// <summary>Create a filter instance.</summary>
        /// <param name="filter_ctx">put here a pointer to the created filter context on success, NULL on failure</param>
        /// <param name="filter">the filter to create an instance of</param>
        /// <param name="inst_name">Name to give to the new instance. Can be NULL for none.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_open(AVFilterContext** @filter_ctx, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @inst_name);
        
        /// <summary>Initialize a filter.</summary>
        /// <param name="filter">the filter to initialize</param>
        /// <param name="args">A string of parameters to use when initializing the filter. The format and meaning of this string varies by filter.</param>
        /// <param name="opaque">Any extra non-string data needed by the filter. The meaning of this parameter varies by filter.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_init_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_init_filter(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque);
        
        /// <summary>Initialize a filter with the supplied parameters.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="args">Options to initialize the filter with. This must be a ':'-separated list of options in the 'key=value' form. May be NULL if the options have been set directly using the AVOptions API or there are no options that need to be set.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_init_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_init_str(AVFilterContext* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @args);
        
        /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="options">An AVDictionary filled with options for this filter. On return this parameter will be destroyed and replaced with a dict containing options that were not found. This dictionary must be freed by the caller. May be NULL, then this function is equivalent to avfilter_init_str() with the second parameter set to NULL.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_init_dict", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options);
        
        /// <summary>Free a filter context. This will also remove the filter from its filtergraph's list of filters.</summary>
        /// <param name="filter">the filter to free</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_free(AVFilterContext* @filter);
        
        /// <summary>Insert a filter in the middle of an existing link.</summary>
        /// <param name="link">the link into which the filter should be inserted</param>
        /// <param name="filt">the filter to be inserted</param>
        /// <param name="filt_srcpad_idx">the input pad on the filter to connect</param>
        /// <param name="filt_dstpad_idx">the output pad on the filter to connect</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_insert_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
        
        /// <summary>Returns AVClass for AVFilterContext.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* avfilter_get_class();
        
        /// <summary>Allocate a filter graph.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilterGraph* avfilter_graph_alloc();
        
        /// <summary>Create a new filter instance in a filter graph.</summary>
        /// <param name="graph">graph in which the new filter will be used</param>
        /// <param name="filter">the filter to create an instance of</param>
        /// <param name="name">Name to give to the new instance (will be copied to AVFilterContext.name). This may be used by the caller to identify different filters, libavfilter itself assigns no semantics to this parameter. May be NULL.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_alloc_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Get a filter instance identified by instance name from graph.</summary>
        /// <param name="graph">filter graph to search through.</param>
        /// <param name="name">filter instance name (should be unique in the graph).</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_get_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Add an existing filter instance to a filter graph.</summary>
        /// <param name="graphctx">the filter graph</param>
        /// <param name="filter">the filter to be added</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_add_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_add_filter(AVFilterGraph* @graphctx, AVFilterContext* @filter);
        
        /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameters args and opaque.</summary>
        /// <param name="name">the instance name to give to the created filter instance</param>
        /// <param name="graph_ctx">the filter graph</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_create_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque, AVFilterGraph* @graph_ctx);
        
        /// <summary>Enable or disable automatic format conversion inside the graph.</summary>
        /// <param name="flags">any of the AVFILTER_AUTO_CONVERT_* constants</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_set_auto_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags);
        
        /// <summary>Check validity and configure all the links and formats in the graph.</summary>
        /// <param name="graphctx">the filter graph</param>
        /// <param name="log_ctx">context used for logging</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_config", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx);
        
        /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_graph_free(AVFilterGraph** @graph);
        
        /// <summary>Allocate a single AVFilterInOut entry. Must be freed with avfilter_inout_free().</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_inout_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFilterInOut* avfilter_inout_alloc();
        
        /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_inout_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avfilter_inout_free(AVFilterInOut** @inout);
        
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">linked list to the inputs of the graph</param>
        /// <param name="outputs">linked list to the outputs of the graph</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_parse", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_parse(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
        
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
        /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_parse_ptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_parse_ptr(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
        
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_parse2(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
        
        /// <summary>Send a command to one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent "all" sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to send, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="res">a buffer with size res_size where the filter(s) can return a response.</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_send_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_send_command(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags);
        
        /// <summary>Queue a command for one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent "all" sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to sent, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="ts">time at which the command should be sent to the filter</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_queue_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_queue_command(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, int @flags, double @ts);
        
        /// <summary>Dump a graph into a human-readable string representation.</summary>
        /// <param name="graph">the graph to dump</param>
        /// <param name="options">formatting options; currently ignored</param>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* avfilter_graph_dump(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @options);
        
        /// <summary>Request a frame on the oldest sink link.</summary>
        [DllImport("avfilter-6", EntryPoint = "avfilter_graph_request_oldest", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avfilter_graph_request_oldest(AVFilterGraph* @graph);
        
        /// <summary>Get the number of failed requests.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_get_nb_failed_requests", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src);
        
        /// <summary>Allocate a new AVBufferSrcParameters instance. It should be freed by the caller with av_free().</summary>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_parameters_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferSrcParameters* av_buffersrc_parameters_alloc();
        
        /// <summary>Initialize the buffersrc or abuffersrc filter with the provided parameters. This function may be called multiple times, the later calls override the previous ones. Some of the parameters may also be set through AVOptions, then whatever method is used last takes precedence.</summary>
        /// <param name="ctx">an instance of the buffersrc or abuffersrc filter</param>
        /// <param name="param">the stream parameters. The frames later passed to this filter must conform to those parameters. All the allocated fields in param remain owned by the caller, libavfilter will make internal copies or references when necessary.</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_parameters_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
        
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will make a new reference to it. Otherwise the frame data will be copied.</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will take ownership of the reference(s) and reset the frame. Otherwise the frame data will be copied. If this function returns an error, the input frame is not touched.</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_add_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="buffer_src">pointer to a buffer source context</param>
        /// <param name="frame">a frame, or NULL to mark EOF</param>
        /// <param name="flags">a combination of AV_BUFFERSRC_FLAG_*</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersrc_add_frame_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
        
        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a buffersink or abuffersink filter context.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        /// <param name="flags">a combination of AV_BUFFERSINK_FLAG_* flags</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_get_frame_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
        
        /// <summary>Create an AVBufferSinkParams structure.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_params_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferSinkParams* av_buffersink_params_alloc();
        
        /// <summary>Create an AVABufferSinkParams structure.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_abuffersink_params_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVABufferSinkParams* av_abuffersink_params_alloc();
        
        /// <summary>Set the frame size for an audio buffer sink.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_set_frame_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size);
        
        /// <summary>Get the frame rate of the input.</summary>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_get_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx);
        
        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a context of a buffersink or abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_get_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        /// <summary>Same as av_buffersink_get_frame(), but with the ability to specify the number of samples read. This function is less efficient than av_buffersink_get_frame(), because it copies the data around.</summary>
        /// <param name="ctx">pointer to a context of the abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free() frame will contain exactly nb_samples audio samples, except at the end of stream, when it can contain less than nb_samples.</param>
        [DllImport("avfilter-6", EntryPoint = "av_buffersink_get_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
        
    }
}
