using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public unsafe partial struct _GUID
{
    public ulong @Data1;
    public ushort @Data2;
    public ushort @Data3;
    public byte_array8 @Data4;
}

public unsafe partial struct _iobuf
{
    public void* @_Placeholder;
}

public unsafe partial struct AVBitStreamFilter
{
    public byte* @name;
    /// <summary>A list of codec ids supported by the filter, terminated by AV_CODEC_ID_NONE. May be NULL, in that case the bitstream filter works with any codec id.</summary>
    public AVCodecID* @codec_ids;
    /// <summary>A class for the private data, used to declare bitstream filter private AVOptions. This field is NULL for bitstream filters that do not declare any options.</summary>
    public AVClass* @priv_class;
}

/// <summary>The bitstream filter state.</summary>
public unsafe partial struct AVBSFContext
{
    /// <summary>A class for logging and AVOptions</summary>
    public AVClass* @av_class;
    /// <summary>The bitstream filter this context is an instance of.</summary>
    public AVBitStreamFilter* @filter;
    /// <summary>Opaque filter-specific private data. If filter-&gt;priv_class is non-NULL, this is an AVOptions-enabled struct.</summary>
    public void* @priv_data;
    /// <summary>Parameters of the input stream. This field is allocated in av_bsf_alloc(), it needs to be filled by the caller before av_bsf_init().</summary>
    public AVCodecParameters* @par_in;
    /// <summary>Parameters of the output stream. This field is allocated in av_bsf_alloc(), it is set by the filter in av_bsf_init().</summary>
    public AVCodecParameters* @par_out;
    /// <summary>The timebase used for the timestamps of the input packets. Set by the caller before av_bsf_init().</summary>
    public AVRational @time_base_in;
    /// <summary>The timebase used for the timestamps of the output packets. Set by the filter in av_bsf_init().</summary>
    public AVRational @time_base_out;
}

/// <summary>A reference to a data buffer.</summary>
public unsafe partial struct AVBufferRef
{
    public AVBuffer* @buffer;
    /// <summary>The data buffer. It is considered writable if and only if this is the only reference to the buffer, in which case av_buffer_is_writable() returns 1.</summary>
    public byte* @data;
    /// <summary>Size of data in bytes.</summary>
    public ulong @size;
}

/// <summary>This structure contains the parameters describing the frames that will be passed to this filter.</summary>
public unsafe partial struct AVBufferSrcParameters
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
    /// <summary>Audio only, the audio sampling rate in samples per second.</summary>
    public int @sample_rate;
    /// <summary>Audio only, the audio channel layout</summary>
    public AVChannelLayout @ch_layout;
    /// <summary>Video only, the YUV colorspace and range.</summary>
    public AVColorSpace @color_space;
    public AVColorRange @color_range;
}

/// <summary>An AVChannelCustom defines a single channel within a custom order layout</summary>
public unsafe partial struct AVChannelCustom
{
    public AVChannel @id;
    public byte_array16 @name;
    public void* @opaque;
}

/// <summary>An AVChannelLayout holds information about the channel layout of audio data.</summary>
public unsafe partial struct AVChannelLayout
{
    /// <summary>Channel order used in this layout. This is a mandatory field.</summary>
    public AVChannelOrder @order;
    /// <summary>Number of channels in this layout. Mandatory field.</summary>
    public int @nb_channels;
    public AVChannelLayout_u @u;
    /// <summary>For some private data of the user.</summary>
    public void* @opaque;
}

/// <summary>Details about which channels are present in this layout. For AV_CHANNEL_ORDER_UNSPEC, this field is undefined and must not be used.</summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct AVChannelLayout_u
{
    /// <summary>This member must be used for AV_CHANNEL_ORDER_NATIVE, and may be used for AV_CHANNEL_ORDER_AMBISONIC to signal non-diegetic channels. It is a bitmask, where the position of each set bit means that the AVChannel with the corresponding value is present.</summary>
    [FieldOffset(0)]
    public ulong @mask;
    /// <summary>This member must be used when the channel order is AV_CHANNEL_ORDER_CUSTOM. It is a nb_channels-sized array, with each element signalling the presence of the AVChannel with the corresponding value in map[i].id.</summary>
    [FieldOffset(0)]
    public AVChannelCustom* @map;
}

public unsafe partial struct AVChapter
{
    /// <summary>unique ID to identify the chapter</summary>
    public long @id;
    /// <summary>time base in which the start/end timestamps are specified</summary>
    public AVRational @time_base;
    /// <summary>chapter start/end time in time_base units</summary>
    public long @start;
    /// <summary>chapter start/end time in time_base units</summary>
    public long @end;
    public AVDictionary* @metadata;
}

/// <summary>Describe the class of an AVClass context structure. That is an arbitrary struct of which the first field is a pointer to an AVClass struct (e.g. AVCodecContext, AVFormatContext etc.).</summary>
public unsafe partial struct AVClass
{
    /// <summary>The name of the class; usually it is the same name as the context structure type to which the AVClass is associated.</summary>
    public byte* @class_name;
    /// <summary>A pointer to a function which returns the name of a context instance ctx associated with the class.</summary>
    public AVClass_item_name_func @item_name;
    /// <summary>a pointer to the first option specified in the class if any or NULL</summary>
    public AVOption* @option;
    /// <summary>LIBAVUTIL_VERSION with which this structure was created. This is used to allow fields to be added without requiring major version bumps everywhere.</summary>
    public int @version;
    /// <summary>Offset in the structure where log_level_offset is stored. 0 means there is no such variable</summary>
    public int @log_level_offset_offset;
    /// <summary>Offset in the structure where a pointer to the parent context for logging is stored. For example a decoder could pass its AVCodecContext to eval as such a parent context, which an av_log() implementation could then leverage to display the parent context. The offset can be NULL.</summary>
    public int @parent_log_context_offset;
    /// <summary>Category used for visualization (like color) This is only set if the category is equal for all objects using this class. available since version (51 &lt;&lt; 16 | 56 &lt;&lt; 8 | 100)</summary>
    public AVClassCategory @category;
    /// <summary>Callback to return the category. available since version (51 &lt;&lt; 16 | 59 &lt;&lt; 8 | 100)</summary>
    public AVClass_get_category_func @get_category;
    /// <summary>Callback to return the supported/allowed ranges. available since version (52.12)</summary>
    public AVClass_query_ranges_func @query_ranges;
    /// <summary>Return next AVOptions-enabled child or NULL</summary>
    public AVClass_child_next_func @child_next;
    /// <summary>Iterate over the AVClasses corresponding to potential AVOptions-enabled children.</summary>
    public AVClass_child_class_iterate_func @child_class_iterate;
}

/// <summary>AVCodec.</summary>
public unsafe partial struct AVCodec
{
    /// <summary>Name of the codec implementation. The name is globally unique among encoders and among decoders (but an encoder and a decoder can share the same name). This is the primary way to find a codec from the user perspective.</summary>
    public byte* @name;
    /// <summary>Descriptive name for the codec, meant to be more human readable than name. You should use the NULL_IF_CONFIG_SMALL() macro to define it.</summary>
    public byte* @long_name;
    public AVMediaType @type;
    public AVCodecID @id;
    /// <summary>Codec capabilities. see AV_CODEC_CAP_*</summary>
    public int @capabilities;
    /// <summary>maximum value for lowres supported by the decoder</summary>
    public byte @max_lowres;
    [Obsolete("use avcodec_get_supported_config()")]
    public AVRational* @supported_framerates;
    [Obsolete("use avcodec_get_supported_config()")]
    public AVPixelFormat* @pix_fmts;
    [Obsolete("use avcodec_get_supported_config()")]
    public int* @supported_samplerates;
    [Obsolete("use avcodec_get_supported_config()")]
    public AVSampleFormat* @sample_fmts;
    /// <summary>AVClass for the private context</summary>
    public AVClass* @priv_class;
    /// <summary>array of recognized profiles, or NULL if unknown, array is terminated by {AV_PROFILE_UNKNOWN}</summary>
    public AVProfile* @profiles;
    /// <summary>Group name of the codec implementation. This is a short symbolic name of the wrapper backing this codec. A wrapper uses some kind of external implementation for the codec, such as an external library, or a codec implementation provided by the OS or the hardware. If this field is NULL, this is a builtin, libavcodec native codec. If non-NULL, this will be the suffix in AVCodec.name in most cases (usually AVCodec.name will be of the form &quot;&lt;codec_name&gt;_&lt;wrapper_name&gt;&quot;).</summary>
    public byte* @wrapper_name;
    /// <summary>Array of supported channel layouts, terminated with a zeroed layout.</summary>
    [Obsolete("use avcodec_get_supported_config()")]
    public AVChannelLayout* @ch_layouts;
}

/// <summary>main external API structure. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. You can use AVOptions (av_opt* / av_set/get*()) to access these fields from user applications. The name string for AVOptions options matches the associated command line parameter name and can be found in libavcodec/options_table.h The AVOption/command line parameter names differ in some cases from the C structure field names for historic reasons or brevity. sizeof(AVCodecContext) must not be used outside libav*.</summary>
public unsafe partial struct AVCodecContext
{
    /// <summary>information on struct for av_log - set by avcodec_alloc_context3</summary>
    public AVClass* @av_class;
    public int @log_level_offset;
    public AVMediaType @codec_type;
    public AVCodec* @codec;
    public AVCodecID @codec_id;
    /// <summary>fourcc (LSB first, so &quot;ABCD&quot; -&gt; (&apos;D&apos;&lt;&lt;24) + (&apos;C&apos;&lt;&lt;16) + (&apos;B&apos;&lt;&lt;8) + &apos;A&apos;). This is used to work around some encoder bugs. A demuxer should set this to what is stored in the field used to identify the codec. If there are multiple such fields in a container then the demuxer should choose the one which maximizes the information about the used codec. If the codec tag field in a container is larger than 32 bits then the demuxer should remap the longer ID to 32 bits with a table or other structure. Alternatively a new extra_codec_tag + size could be added but for this a clear advantage must be demonstrated first. - encoding: Set by user, if not then the default based on codec_id will be used. - decoding: Set by user, will be converted to uppercase by libavcodec during init.</summary>
    public uint @codec_tag;
    public void* @priv_data;
    /// <summary>Private context used for internal data.</summary>
    public AVCodecInternal* @internal;
    /// <summary>Private data of the user, can be used to carry app specific stuff. - encoding: Set by user. - decoding: Set by user.</summary>
    public void* @opaque;
    /// <summary>the average bitrate - encoding: Set by user; unused for constant quantizer encoding. - decoding: Set by user, may be overwritten by libavcodec if this info is available in the stream</summary>
    public long @bit_rate;
    /// <summary>AV_CODEC_FLAG_*. - encoding: Set by user. - decoding: Set by user.</summary>
    public int @flags;
    /// <summary>AV_CODEC_FLAG2_* - encoding: Set by user. - decoding: Set by user.</summary>
    public int @flags2;
    /// <summary>some codecs need / can use extradata like Huffman tables. MJPEG: Huffman tables rv10: additional flags MPEG-4: global headers (they can be in the bitstream or here) The allocated memory should be AV_INPUT_BUFFER_PADDING_SIZE bytes larger than extradata_size to avoid problems if it is read with the bitstream reader. The bytewise contents of extradata must not depend on the architecture or CPU endianness. Must be allocated with the av_malloc() family of functions. - encoding: Set/allocated/freed by libavcodec. - decoding: Set/allocated/freed by user.</summary>
    public byte* @extradata;
    public int @extradata_size;
    /// <summary>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented. For fixed-fps content, timebase should be 1/framerate and timestamp increments should be identically 1. This often, but not always is the inverse of the frame rate or field rate for video. 1/time_base is not the average frame rate if the frame rate is not constant.</summary>
    public AVRational @time_base;
    /// <summary>Timebase in which pkt_dts/pts and AVPacket.dts/pts are expressed. - encoding: unused. - decoding: set by user.</summary>
    public AVRational @pkt_timebase;
    /// <summary>- decoding: For codecs that store a framerate value in the compressed bitstream, the decoder may export it here. { 0, 1} when unknown. - encoding: May be used to signal the framerate of CFR content to an encoder.</summary>
    public AVRational @framerate;
    /// <summary>For some codecs, the time base is closer to the field rate than the frame rate. Most notably, H.264 and MPEG-2 specify time_base as half of frame duration if no telecine is used ...</summary>
    [Obsolete("- decoding: Use AVCodecDescriptor.props & AV_CODEC_PROP_FIELDS - encoding: Set AVCodecContext.framerate instead")]
    public int @ticks_per_frame;
    /// <summary>Codec delay.</summary>
    public int @delay;
    /// <summary>picture width / height.</summary>
    public int @width;
    /// <summary>picture width / height.</summary>
    public int @height;
    /// <summary>Bitstream width / height, may be different from width/height e.g. when the decoded frame is cropped before being output or lowres is enabled.</summary>
    public int @coded_width;
    /// <summary>Bitstream width / height, may be different from width/height e.g. when the decoded frame is cropped before being output or lowres is enabled.</summary>
    public int @coded_height;
    /// <summary>sample aspect ratio (0 if unknown) That is the width of a pixel divided by the height of the pixel. Numerator and denominator must be relatively prime and smaller than 256 for some video standards. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public AVRational @sample_aspect_ratio;
    /// <summary>Pixel format, see AV_PIX_FMT_xxx. May be set by the demuxer if known from headers. May be overridden by the decoder if it knows better.</summary>
    public AVPixelFormat @pix_fmt;
    /// <summary>Nominal unaccelerated pixel format, see AV_PIX_FMT_xxx. - encoding: unused. - decoding: Set by libavcodec before calling get_format()</summary>
    public AVPixelFormat @sw_pix_fmt;
    /// <summary>Chromaticity coordinates of the source primaries. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVColorPrimaries @color_primaries;
    /// <summary>Color Transfer Characteristic. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVColorTransferCharacteristic @color_trc;
    /// <summary>YUV colorspace type. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVColorSpace @colorspace;
    /// <summary>MPEG vs JPEG YUV range. - encoding: Set by user to override the default output color range value, If not specified, libavcodec sets the color range depending on the output format. - decoding: Set by libavcodec, can be set by the user to propagate the color range to components reading from the decoder context.</summary>
    public AVColorRange @color_range;
    /// <summary>This defines the location of chroma samples. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVChromaLocation @chroma_sample_location;
    /// <summary>Field order - encoding: set by libavcodec - decoding: Set by user.</summary>
    public AVFieldOrder @field_order;
    /// <summary>number of reference frames - encoding: Set by user. - decoding: Set by lavc.</summary>
    public int @refs;
    /// <summary>Size of the frame reordering buffer in the decoder. For MPEG-2 it is 1 IPB or 0 low delay IP. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
    public int @has_b_frames;
    /// <summary>slice flags - encoding: unused - decoding: Set by user.</summary>
    public int @slice_flags;
    /// <summary>If non NULL, &apos;draw_horiz_band&apos; is called by the libavcodec decoder to draw a horizontal band. It improves cache usage. Not all codecs can do that. You must check the codec capabilities beforehand. When multithreading is used, it may be called from multiple threads at the same time; threads might draw different parts of the same AVFrame, or multiple AVFrames, and there is no guarantee that slices will be drawn in order. The function is also used by hardware acceleration APIs. It is called at least once during frame decoding to pass the data needed for hardware render. In that mode instead of pixel data, AVFrame points to a structure specific to the acceleration API. The application reads the structure and can change some fields to indicate progress or mark state. - encoding: unused - decoding: Set by user.</summary>
    public AVCodecContext_draw_horiz_band_func @draw_horiz_band;
    /// <summary>Callback to negotiate the pixel format. Decoding only, may be set by the caller before avcodec_open2().</summary>
    public AVCodecContext_get_format_func @get_format;
    /// <summary>maximum number of B-frames between non-B-frames Note: The output will be delayed by max_b_frames+1 relative to the input. - encoding: Set by user. - decoding: unused</summary>
    public int @max_b_frames;
    /// <summary>qscale factor between IP and B-frames If &gt; 0 then the last P-frame quantizer will be used (q= lastp_q*factor+offset). If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
    public float @b_quant_factor;
    /// <summary>qscale offset between IP and B-frames - encoding: Set by user. - decoding: unused</summary>
    public float @b_quant_offset;
    /// <summary>qscale factor between P- and I-frames If &gt; 0 then the last P-frame quantizer will be used (q = lastp_q * factor + offset). If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
    public float @i_quant_factor;
    /// <summary>qscale offset between P and I-frames - encoding: Set by user. - decoding: unused</summary>
    public float @i_quant_offset;
    /// <summary>luminance masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
    public float @lumi_masking;
    /// <summary>temporary complexity masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
    public float @temporal_cplx_masking;
    /// <summary>spatial complexity masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
    public float @spatial_cplx_masking;
    /// <summary>p block masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
    public float @p_masking;
    /// <summary>darkness masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
    public float @dark_masking;
    /// <summary>noise vs. sse weight for the nsse comparison function - encoding: Set by user. - decoding: unused</summary>
    public int @nsse_weight;
    /// <summary>motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
    public int @me_cmp;
    /// <summary>subpixel motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
    public int @me_sub_cmp;
    /// <summary>macroblock comparison function (not supported yet) - encoding: Set by user. - decoding: unused</summary>
    public int @mb_cmp;
    /// <summary>interlaced DCT comparison function - encoding: Set by user. - decoding: unused</summary>
    public int @ildct_cmp;
    /// <summary>ME diamond size &amp; shape - encoding: Set by user. - decoding: unused</summary>
    public int @dia_size;
    /// <summary>amount of previous MV predictors (2a+1 x 2a+1 square) - encoding: Set by user. - decoding: unused</summary>
    public int @last_predictor_count;
    /// <summary>motion estimation prepass comparison function - encoding: Set by user. - decoding: unused</summary>
    public int @me_pre_cmp;
    /// <summary>ME prepass diamond size &amp; shape - encoding: Set by user. - decoding: unused</summary>
    public int @pre_dia_size;
    /// <summary>subpel ME quality - encoding: Set by user. - decoding: unused</summary>
    public int @me_subpel_quality;
    /// <summary>maximum motion estimation search range in subpel units If 0 then no limit.</summary>
    public int @me_range;
    /// <summary>macroblock decision mode - encoding: Set by user. - decoding: unused</summary>
    public int @mb_decision;
    /// <summary>custom intra quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context(). - encoding: Set/allocated by user, freed by libavcodec. Can be NULL. - decoding: Set/allocated/freed by libavcodec.</summary>
    public ushort* @intra_matrix;
    /// <summary>custom inter quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context(). - encoding: Set/allocated by user, freed by libavcodec. Can be NULL. - decoding: Set/allocated/freed by libavcodec.</summary>
    public ushort* @inter_matrix;
    /// <summary>custom intra quantization matrix - encoding: Set by user, can be NULL. - decoding: unused.</summary>
    public ushort* @chroma_intra_matrix;
    /// <summary>precision of the intra DC coefficient - 8 - encoding: Set by user. - decoding: Set by libavcodec</summary>
    public int @intra_dc_precision;
    /// <summary>minimum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
    public int @mb_lmin;
    /// <summary>maximum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
    public int @mb_lmax;
    /// <summary>- encoding: Set by user. - decoding: unused</summary>
    public int @bidir_refine;
    /// <summary>minimum GOP size - encoding: Set by user. - decoding: unused</summary>
    public int @keyint_min;
    /// <summary>the number of pictures in a group of pictures, or 0 for intra_only - encoding: Set by user. - decoding: unused</summary>
    public int @gop_size;
    /// <summary>Note: Value depends upon the compare function used for fullpel ME. - encoding: Set by user. - decoding: unused</summary>
    public int @mv0_threshold;
    /// <summary>Number of slices. Indicates number of picture subdivisions. Used for parallelized decoding. - encoding: Set by user - decoding: unused</summary>
    public int @slices;
    /// <summary>samples per second</summary>
    public int @sample_rate;
    /// <summary>sample format</summary>
    public AVSampleFormat @sample_fmt;
    /// <summary>Audio channel layout. - encoding: must be set by the caller, to one of AVCodec.ch_layouts. - decoding: may be set by the caller if known e.g. from the container. The decoder can then override during decoding as needed.</summary>
    public AVChannelLayout @ch_layout;
    /// <summary>Number of samples per channel in an audio frame.</summary>
    public int @frame_size;
    /// <summary>number of bytes per packet if constant and known or 0 Used by some WAV based audio codecs.</summary>
    public int @block_align;
    /// <summary>Audio cutoff bandwidth (0 means &quot;automatic&quot;) - encoding: Set by user. - decoding: unused</summary>
    public int @cutoff;
    /// <summary>Type of service that the audio stream conveys. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public AVAudioServiceType @audio_service_type;
    /// <summary>desired sample format - encoding: Not used. - decoding: Set by user. Decoder will decode to this format if it can.</summary>
    public AVSampleFormat @request_sample_fmt;
    /// <summary>Audio only. The number of &quot;priming&quot; samples (padding) inserted by the encoder at the beginning of the audio. I.e. this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</summary>
    public int @initial_padding;
    /// <summary>Audio only. The amount of padding (in samples) appended by the encoder to the end of the audio. I.e. this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</summary>
    public int @trailing_padding;
    /// <summary>Number of samples to skip after a discontinuity - decoding: unused - encoding: set by libavcodec</summary>
    public int @seek_preroll;
    /// <summary>This callback is called at the beginning of each frame to get data buffer(s) for it. There may be one contiguous buffer for all the data or there may be a buffer per each data plane or anything in between. What this means is, you may set however many entries in buf[] you feel necessary. Each buffer must be reference-counted using the AVBuffer API (see description of buf[] below).</summary>
    public AVCodecContext_get_buffer2_func @get_buffer2;
    /// <summary>number of bits the bitstream is allowed to diverge from the reference. the reference can be CBR (for CBR pass1) or VBR (for pass2) - encoding: Set by user; unused for constant quantizer encoding. - decoding: unused</summary>
    public int @bit_rate_tolerance;
    /// <summary>Global quality for codecs which cannot change it per frame. This should be proportional to MPEG-1/2/4 qscale. - encoding: Set by user. - decoding: unused</summary>
    public int @global_quality;
    /// <summary>- encoding: Set by user. - decoding: unused</summary>
    public int @compression_level;
    /// <summary>amount of qscale change between easy &amp; hard scenes (0.0-1.0)</summary>
    public float @qcompress;
    /// <summary>amount of qscale smoothing over time (0.0-1.0)</summary>
    public float @qblur;
    /// <summary>minimum quantizer - encoding: Set by user. - decoding: unused</summary>
    public int @qmin;
    /// <summary>maximum quantizer - encoding: Set by user. - decoding: unused</summary>
    public int @qmax;
    /// <summary>maximum quantizer difference between frames - encoding: Set by user. - decoding: unused</summary>
    public int @max_qdiff;
    /// <summary>decoder bitstream buffer size - encoding: Set by user. - decoding: May be set by libavcodec.</summary>
    public int @rc_buffer_size;
    /// <summary>ratecontrol override, see RcOverride - encoding: Allocated/set/freed by user. - decoding: unused</summary>
    public int @rc_override_count;
    public RcOverride* @rc_override;
    /// <summary>maximum bitrate - encoding: Set by user. - decoding: Set by user, may be overwritten by libavcodec.</summary>
    public long @rc_max_rate;
    /// <summary>minimum bitrate - encoding: Set by user. - decoding: unused</summary>
    public long @rc_min_rate;
    /// <summary>Ratecontrol attempt to use, at maximum, &lt;value&gt; of what can be used without an underflow. - encoding: Set by user. - decoding: unused.</summary>
    public float @rc_max_available_vbv_use;
    /// <summary>Ratecontrol attempt to use, at least, &lt;value&gt; times the amount needed to prevent a vbv overflow. - encoding: Set by user. - decoding: unused.</summary>
    public float @rc_min_vbv_overflow_use;
    /// <summary>Number of bits which should be loaded into the rc buffer before decoding starts. - encoding: Set by user. - decoding: unused</summary>
    public int @rc_initial_buffer_occupancy;
    /// <summary>trellis RD quantization - encoding: Set by user. - decoding: unused</summary>
    public int @trellis;
    /// <summary>pass1 encoding statistics output buffer - encoding: Set by libavcodec. - decoding: unused</summary>
    public byte* @stats_out;
    /// <summary>pass2 encoding statistics input buffer Concatenated stuff from stats_out of pass1 should be placed here. - encoding: Allocated/set/freed by user. - decoding: unused</summary>
    public byte* @stats_in;
    /// <summary>Work around bugs in encoders which sometimes cannot be detected automatically. - encoding: Set by user - decoding: Set by user</summary>
    public int @workaround_bugs;
    /// <summary>strictly follow the standard (MPEG-4, ...). - encoding: Set by user. - decoding: Set by user. Setting this to STRICT or higher means the encoder and decoder will generally do stupid things, whereas setting it to unofficial or lower will mean the encoder might produce output that is not supported by all spec-compliant decoders. Decoders don&apos;t differentiate between normal, unofficial and experimental (that is, they always try to decode things when they can) unless they are explicitly asked to behave stupidly (=strictly conform to the specs) This may only be set to one of the FF_COMPLIANCE_* values in defs.h.</summary>
    public int @strict_std_compliance;
    /// <summary>error concealment flags - encoding: unused - decoding: Set by user.</summary>
    public int @error_concealment;
    /// <summary>debug - encoding: Set by user. - decoding: Set by user.</summary>
    public int @debug;
    /// <summary>Error recognition; may misdetect some more or less valid parts as errors. This is a bitfield of the AV_EF_* values defined in defs.h.</summary>
    public int @err_recognition;
    /// <summary>Hardware accelerator in use - encoding: unused. - decoding: Set by libavcodec</summary>
    public AVHWAccel* @hwaccel;
    /// <summary>Legacy hardware accelerator context.</summary>
    public void* @hwaccel_context;
    /// <summary>A reference to the AVHWFramesContext describing the input (for encoding) or output (decoding) frames. The reference is set by the caller and afterwards owned (and freed) by libavcodec - it should never be read by the caller after being set.</summary>
    public AVBufferRef* @hw_frames_ctx;
    /// <summary>A reference to the AVHWDeviceContext describing the device which will be used by a hardware encoder/decoder. The reference is set by the caller and afterwards owned (and freed) by libavcodec.</summary>
    public AVBufferRef* @hw_device_ctx;
    /// <summary>Bit set of AV_HWACCEL_FLAG_* flags, which affect hardware accelerated decoding (if active). - encoding: unused - decoding: Set by user (either before avcodec_open2(), or in the AVCodecContext.get_format callback)</summary>
    public int @hwaccel_flags;
    /// <summary>Video decoding only. Sets the number of extra hardware frames which the decoder will allocate for use by the caller. This must be set before avcodec_open2() is called.</summary>
    public int @extra_hw_frames;
    /// <summary>error - encoding: Set by libavcodec if flags &amp; AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
    public ulong_array8 @error;
    /// <summary>DCT algorithm, see FF_DCT_* below - encoding: Set by user. - decoding: unused</summary>
    public int @dct_algo;
    /// <summary>IDCT algorithm, see FF_IDCT_* below. - encoding: Set by user. - decoding: Set by user.</summary>
    public int @idct_algo;
    /// <summary>bits per sample/pixel from the demuxer (needed for huffyuv). - encoding: Set by libavcodec. - decoding: Set by user.</summary>
    public int @bits_per_coded_sample;
    /// <summary>Bits per sample/pixel of internal libavcodec pixel/sample format. - encoding: set by user. - decoding: set by libavcodec.</summary>
    public int @bits_per_raw_sample;
    /// <summary>thread count is used to decide how many independent tasks should be passed to execute() - encoding: Set by user. - decoding: Set by user.</summary>
    public int @thread_count;
    /// <summary>Which multithreading methods to use. Use of FF_THREAD_FRAME will increase decoding delay by one frame per thread, so clients which cannot provide future frames should not use it.</summary>
    public int @thread_type;
    /// <summary>Which multithreading methods are in use by the codec. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
    public int @active_thread_type;
    /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially.</summary>
    public AVCodecContext_execute_func @execute;
    /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially.</summary>
    public AVCodecContext_execute2_func @execute2;
    /// <summary>profile - encoding: Set by user. - decoding: Set by libavcodec. See the AV_PROFILE_* defines in defs.h.</summary>
    public int @profile;
    /// <summary>Encoding level descriptor. - encoding: Set by user, corresponds to a specific level defined by the codec, usually corresponding to the profile level, if not specified it is set to FF_LEVEL_UNKNOWN. - decoding: Set by libavcodec. See AV_LEVEL_* in defs.h.</summary>
    public int @level;
    /// <summary>Properties of the stream that gets decoded - encoding: unused - decoding: set by libavcodec</summary>
    public uint @properties;
    /// <summary>Skip loop filtering for selected frames. - encoding: unused - decoding: Set by user.</summary>
    public AVDiscard @skip_loop_filter;
    /// <summary>Skip IDCT/dequantization for selected frames. - encoding: unused - decoding: Set by user.</summary>
    public AVDiscard @skip_idct;
    /// <summary>Skip decoding for selected frames. - encoding: unused - decoding: Set by user.</summary>
    public AVDiscard @skip_frame;
    /// <summary>Skip processing alpha if supported by codec. Note that if the format uses pre-multiplied alpha (common with VP6, and recommended due to better video quality/compression) the image will look as if alpha-blended onto a black background. However for formats that do not use pre-multiplied alpha there might be serious artefacts (though e.g. libswscale currently assumes pre-multiplied alpha anyway).</summary>
    public int @skip_alpha;
    /// <summary>Number of macroblock rows at the top which are skipped. - encoding: unused - decoding: Set by user.</summary>
    public int @skip_top;
    /// <summary>Number of macroblock rows at the bottom which are skipped. - encoding: unused - decoding: Set by user.</summary>
    public int @skip_bottom;
    /// <summary>low resolution decoding, 1-&gt; 1/2 size, 2-&gt;1/4 size - encoding: unused - decoding: Set by user.</summary>
    public int @lowres;
    /// <summary>AVCodecDescriptor - encoding: unused. - decoding: set by libavcodec.</summary>
    public AVCodecDescriptor* @codec_descriptor;
    /// <summary>Character encoding of the input subtitles file. - decoding: set by user - encoding: unused</summary>
    public byte* @sub_charenc;
    /// <summary>Subtitles character encoding mode. Formats or codecs might be adjusting this setting (if they are doing the conversion themselves for instance). - decoding: set by libavcodec - encoding: unused</summary>
    public int @sub_charenc_mode;
    /// <summary>Header containing style information for text subtitles. For SUBTITLE_ASS subtitle type, it should contain the whole ASS [Script Info] and [V4+ Styles] section, plus the [Events] line and the Format line following. It shouldn&apos;t include any Dialogue line. - encoding: Set/allocated/freed by user (before avcodec_open2()) - decoding: Set/allocated/freed by libavcodec (by avcodec_open2())</summary>
    public int @subtitle_header_size;
    public byte* @subtitle_header;
    /// <summary>dump format separator. can be &quot;, &quot; or &quot; &quot; or anything else - encoding: Set by user. - decoding: Set by user.</summary>
    public byte* @dump_separator;
    /// <summary>&apos;,&apos; separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user</summary>
    public byte* @codec_whitelist;
    /// <summary>Additional data associated with the entire coded stream.</summary>
    public AVPacketSideData* @coded_side_data;
    public int @nb_coded_side_data;
    /// <summary>Bit set of AV_CODEC_EXPORT_DATA_* flags, which affects the kind of metadata exported in frame, packet, or coded stream side data by decoders and encoders.</summary>
    public int @export_side_data;
    /// <summary>The number of pixels per image to maximally accept.</summary>
    public long @max_pixels;
    /// <summary>Video decoding only. Certain video codecs support cropping, meaning that only a sub-rectangle of the decoded frame is intended for display. This option controls how cropping is handled by libavcodec.</summary>
    public int @apply_cropping;
    /// <summary>The percentage of damaged samples to discard a frame.</summary>
    public int @discard_damaged_percentage;
    /// <summary>The number of samples per frame to maximally accept.</summary>
    public long @max_samples;
    /// <summary>This callback is called at the beginning of each packet to get a data buffer for it.</summary>
    public AVCodecContext_get_encode_buffer_func @get_encode_buffer;
    /// <summary>Frame counter, set by libavcodec.</summary>
    public long @frame_num;
    /// <summary>Decoding only. May be set by the caller before avcodec_open2() to an av_malloc()&apos;ed array (or via AVOptions). Owned and freed by the decoder afterwards.</summary>
    public int* @side_data_prefer_packet;
    /// <summary>Number of entries in side_data_prefer_packet.</summary>
    public uint @nb_side_data_prefer_packet;
    /// <summary>Array containing static side data, such as HDR10 CLL / MDCV structures. Side data entries should be allocated by usage of helpers defined in libavutil/frame.h.</summary>
    public AVFrameSideData** @decoded_side_data;
    public int @nb_decoded_side_data;
}

/// <summary>This struct describes the properties of a single codec described by an AVCodecID.</summary>
public unsafe partial struct AVCodecDescriptor
{
    public AVCodecID @id;
    public AVMediaType @type;
    /// <summary>Name of the codec described by this descriptor. It is non-empty and unique for each codec descriptor. It should contain alphanumeric characters and &apos;_&apos; only.</summary>
    public byte* @name;
    /// <summary>A more descriptive name for this codec. May be NULL.</summary>
    public byte* @long_name;
    /// <summary>Codec properties, a combination of AV_CODEC_PROP_* flags.</summary>
    public int @props;
    /// <summary>MIME type(s) associated with the codec. May be NULL; if not, a NULL-terminated array of MIME types. The first item is always non-NULL and is the preferred MIME type.</summary>
    public byte** @mime_types;
    /// <summary>If non-NULL, an array of profiles recognized for this codec. Terminated with AV_PROFILE_UNKNOWN.</summary>
    public AVProfile* @profiles;
}

public unsafe partial struct AVCodecHWConfig
{
    /// <summary>For decoders, a hardware pixel format which that decoder may be able to decode to if suitable hardware is available.</summary>
    public AVPixelFormat @pix_fmt;
    /// <summary>Bit set of AV_CODEC_HW_CONFIG_METHOD_* flags, describing the possible setup methods which can be used with this configuration.</summary>
    public int @methods;
    /// <summary>The device type associated with the configuration.</summary>
    public AVHWDeviceType @device_type;
}

/// <summary>This struct describes the properties of an encoded stream.</summary>
public unsafe partial struct AVCodecParameters
{
    /// <summary>General type of the encoded data.</summary>
    public AVMediaType @codec_type;
    /// <summary>Specific type of the encoded data (the codec used).</summary>
    public AVCodecID @codec_id;
    /// <summary>Additional information about the codec (corresponds to the AVI FOURCC).</summary>
    public uint @codec_tag;
    /// <summary>Extra binary data needed for initializing the decoder, codec-dependent.</summary>
    public byte* @extradata;
    /// <summary>Size of the extradata content in bytes.</summary>
    public int @extradata_size;
    /// <summary>Additional data associated with the entire stream.</summary>
    public AVPacketSideData* @coded_side_data;
    /// <summary>Amount of entries in coded_side_data.</summary>
    public int @nb_coded_side_data;
    /// <summary>- video: the pixel format, the value corresponds to enum AVPixelFormat. - audio: the sample format, the value corresponds to enum AVSampleFormat.</summary>
    public int @format;
    /// <summary>The average bitrate of the encoded data (in bits per second).</summary>
    public long @bit_rate;
    /// <summary>The number of bits per sample in the codedwords.</summary>
    public int @bits_per_coded_sample;
    /// <summary>This is the number of valid bits in each output sample. If the sample format has more bits, the least significant bits are additional padding bits, which are always 0. Use right shifts to reduce the sample to its actual size. For example, audio formats with 24 bit samples will have bits_per_raw_sample set to 24, and format set to AV_SAMPLE_FMT_S32. To get the original sample use &quot;(int32_t)sample &gt;&gt; 8&quot;.&quot;</summary>
    public int @bits_per_raw_sample;
    /// <summary>Codec-specific bitstream restrictions that the stream conforms to.</summary>
    public int @profile;
    public int @level;
    /// <summary>Video only. The dimensions of the video frame in pixels.</summary>
    public int @width;
    public int @height;
    /// <summary>Video only. The aspect ratio (width / height) which a single pixel should have when displayed.</summary>
    public AVRational @sample_aspect_ratio;
    /// <summary>Video only. Number of frames per second, for streams with constant frame durations. Should be set to { 0, 1 } when some frames have differing durations or if the value is not known.</summary>
    public AVRational @framerate;
    /// <summary>Video only. The order of the fields in interlaced video.</summary>
    public AVFieldOrder @field_order;
    /// <summary>Video only. Additional colorspace characteristics.</summary>
    public AVColorRange @color_range;
    public AVColorPrimaries @color_primaries;
    public AVColorTransferCharacteristic @color_trc;
    public AVColorSpace @color_space;
    public AVChromaLocation @chroma_location;
    /// <summary>Video only. Number of delayed frames.</summary>
    public int @video_delay;
    /// <summary>Audio only. The channel layout and number of channels.</summary>
    public AVChannelLayout @ch_layout;
    /// <summary>Audio only. The number of audio samples per second.</summary>
    public int @sample_rate;
    /// <summary>Audio only. The number of bytes per coded audio frame, required by some formats.</summary>
    public int @block_align;
    /// <summary>Audio only. Audio frame size, if known. Required by some formats to be static.</summary>
    public int @frame_size;
    /// <summary>Audio only. The amount of padding (in samples) inserted by the encoder at the beginning of the audio. I.e. this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</summary>
    public int @initial_padding;
    /// <summary>Audio only. The amount of padding (in samples) appended by the encoder to the end of the audio. I.e. this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</summary>
    public int @trailing_padding;
    /// <summary>Audio only. Number of samples to skip after a discontinuity.</summary>
    public int @seek_preroll;
}

public unsafe partial struct AVCodecParser
{
    public int_array7 @codec_ids;
    public int @priv_data_size;
    public AVCodecParser_parser_init_func @parser_init;
    public AVCodecParser_parser_parse_func @parser_parse;
    public AVCodecParser_parser_close_func @parser_close;
    public AVCodecParser_split_func @split;
}

public unsafe partial struct AVCodecParserContext
{
    public void* @priv_data;
    public AVCodecParser* @parser;
    public long @frame_offset;
    public long @cur_offset;
    public long @next_frame_offset;
    public int @pict_type;
    /// <summary>This field is used for proper frame duration computation in lavf. It signals, how much longer the frame duration of the current frame is compared to normal frame duration.</summary>
    public int @repeat_pict;
    public long @pts;
    public long @dts;
    public long @last_pts;
    public long @last_dts;
    public int @fetch_timestamp;
    public int @cur_frame_start_index;
    public long_array4 @cur_frame_offset;
    public long_array4 @cur_frame_pts;
    public long_array4 @cur_frame_dts;
    public int @flags;
    /// <summary>byte offset from starting packet start</summary>
    public long @offset;
    public long_array4 @cur_frame_end;
    /// <summary>Set by parser to 1 for key frames and 0 for non-key frames. It is initialized to -1, so if the parser doesn&apos;t set this flag, old-style fallback using AV_PICTURE_TYPE_I picture type as key frames will be used.</summary>
    public int @key_frame;
    /// <summary>Synchronization point for start of timestamp generation.</summary>
    public int @dts_sync_point;
    /// <summary>Offset of the current timestamp against last timestamp sync point in units of AVCodecContext.time_base.</summary>
    public int @dts_ref_dts_delta;
    /// <summary>Presentation delay of current frame in units of AVCodecContext.time_base.</summary>
    public int @pts_dts_delta;
    /// <summary>Position of the packet in file.</summary>
    public long_array4 @cur_frame_pos;
    /// <summary>Byte position of currently parsed frame in stream.</summary>
    public long @pos;
    /// <summary>Previous frame byte position.</summary>
    public long @last_pos;
    /// <summary>Duration of the current frame. For audio, this is in units of 1 / AVCodecContext.sample_rate. For all other types, this is in units of AVCodecContext.time_base.</summary>
    public int @duration;
    public AVFieldOrder @field_order;
    /// <summary>Indicate whether a picture is coded as a frame, top field or bottom field.</summary>
    public AVPictureStructure @picture_structure;
    /// <summary>Picture number incremented in presentation or output order. This field may be reinitialized at the first picture of a new sequence.</summary>
    public int @output_picture_number;
    /// <summary>Dimensions of the decoded video intended for presentation.</summary>
    public int @width;
    public int @height;
    /// <summary>Dimensions of the coded video.</summary>
    public int @coded_width;
    public int @coded_height;
    /// <summary>The format of the coded data, corresponds to enum AVPixelFormat for video and for enum AVSampleFormat for audio.</summary>
    public int @format;
}

public unsafe partial struct AVComponentDescriptor
{
    /// <summary>Which of the 4 planes contains the component.</summary>
    public int @plane;
    /// <summary>Number of elements between 2 horizontally consecutive pixels. Elements are bits for bitstream formats, bytes otherwise.</summary>
    public int @step;
    /// <summary>Number of elements before the component of the first pixel. Elements are bits for bitstream formats, bytes otherwise.</summary>
    public int @offset;
    /// <summary>Number of least significant bits that must be shifted away to get the value.</summary>
    public int @shift;
    /// <summary>Number of bits in the component.</summary>
    public int @depth;
}

/// <summary>Content light level needed by to transmit HDR over HDMI (CTA-861.3).</summary>
public unsafe partial struct AVContentLightMetadata
{
    /// <summary>Max content light level (cd/m^2).</summary>
    public uint @MaxCLL;
    /// <summary>Max average light level per frame (cd/m^2).</summary>
    public uint @MaxFALL;
}

/// <summary>This structure describes the bitrate properties of an encoded bitstream. It roughly corresponds to a subset the VBV parameters for MPEG-2 or HRD parameters for H.264/HEVC.</summary>
public unsafe partial struct AVCPBProperties
{
    /// <summary>Maximum bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
    public long @max_bitrate;
    /// <summary>Minimum bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
    public long @min_bitrate;
    /// <summary>Average bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
    public long @avg_bitrate;
    /// <summary>The size of the buffer to which the ratecontrol is applied, in bits. Zero if unknown or unspecified.</summary>
    public long @buffer_size;
    /// <summary>The delay between the time the packet this structure is associated with is received and the time when it should be decoded, in periods of a 27MHz clock.</summary>
    public ulong @vbv_delay;
}

/// <summary>D3D11 frame descriptor for pool allocation.</summary>
public unsafe partial struct AVD3D11FrameDescriptor
{
    /// <summary>The texture in which the frame is located. The reference count is managed by the AVBufferRef, and destroying the reference will release the interface.</summary>
    public ID3D11Texture2D* @texture;
    /// <summary>The index into the array texture element representing the frame, or 0 if the texture is not an array texture.</summary>
    public long @index;
}

/// <summary>This structure is used to provides the necessary configurations and data to the Direct3D11 FFmpeg HWAccel implementation.</summary>
public unsafe partial struct AVD3D11VAContext
{
    /// <summary>D3D11 decoder object</summary>
    public ID3D11VideoDecoder* @decoder;
    /// <summary>D3D11 VideoContext</summary>
    public ID3D11VideoContext* @video_context;
    /// <summary>D3D11 configuration used to create the decoder</summary>
    public D3D11_VIDEO_DECODER_CONFIG* @cfg;
    /// <summary>The number of surface in the surface array</summary>
    public uint @surface_count;
    /// <summary>The array of Direct3D surfaces used to create the decoder</summary>
    public ID3D11VideoDecoderOutputView** @surface;
    /// <summary>A bit field configuring the workarounds needed for using the decoder</summary>
    public ulong @workaround;
    /// <summary>Private to the FFmpeg AVHWAccel implementation</summary>
    public uint @report_id;
    /// <summary>Mutex to access video_context</summary>
    public void* @context_mutex;
}

/// <summary>This struct is allocated as AVHWDeviceContext.hwctx</summary>
public unsafe partial struct AVD3D11VADeviceContext
{
    /// <summary>Device used for texture creation and access. This can also be used to set the libavcodec decoding device.</summary>
    public ID3D11Device* @device;
    /// <summary>If unset, this will be set from the device field on init.</summary>
    public ID3D11DeviceContext* @device_context;
    /// <summary>If unset, this will be set from the device field on init.</summary>
    public ID3D11VideoDevice* @video_device;
    /// <summary>If unset, this will be set from the device_context field on init.</summary>
    public ID3D11VideoContext* @video_context;
    /// <summary>Callbacks for locking. They protect accesses to device_context and video_context calls. They also protect access to the internal staging texture (for av_hwframe_transfer_data() calls). They do NOT protect access to hwcontext or decoder state in general.</summary>
    public AVD3D11VADeviceContext_lock_func @lock;
    public AVD3D11VADeviceContext_unlock_func @unlock;
    public void* @lock_ctx;
}

/// <summary>This struct is allocated as AVHWFramesContext.hwctx</summary>
public unsafe partial struct AVD3D11VAFramesContext
{
    /// <summary>The canonical texture used for pool allocation. If this is set to NULL on init, the hwframes implementation will allocate and set an array texture if initial_pool_size &gt; 0.</summary>
    public ID3D11Texture2D* @texture;
    /// <summary>D3D11_TEXTURE2D_DESC.BindFlags used for texture creation. The user must at least set D3D11_BIND_DECODER if the frames context is to be used for video decoding. This field is ignored/invalid if a user-allocated texture is provided.</summary>
    public uint @BindFlags;
    /// <summary>D3D11_TEXTURE2D_DESC.MiscFlags used for texture creation. This field is ignored/invalid if a user-allocated texture is provided.</summary>
    public uint @MiscFlags;
    /// <summary>In case if texture structure member above is not NULL contains the same texture pointer for all elements and different indexes into the array texture. In case if texture structure member above is NULL, all elements contains pointers to separate non-array textures and 0 indexes. This field is ignored/invalid if a user-allocated texture is provided.</summary>
    public AVD3D11FrameDescriptor* @texture_infos;
}

/// <summary>Structure describes basic parameters of the device.</summary>
public unsafe partial struct AVDeviceInfo
{
    /// <summary>device name, format depends on device</summary>
    public byte* @device_name;
    /// <summary>human friendly name</summary>
    public byte* @device_description;
    /// <summary>array indicating what media types(s), if any, a device can provide. If null, cannot provide any</summary>
    public AVMediaType* @media_types;
    /// <summary>length of media_types array, 0 if device cannot provide any media types</summary>
    public int @nb_media_types;
}

/// <summary>List of devices.</summary>
public unsafe partial struct AVDeviceInfoList
{
    /// <summary>list of autodetected devices</summary>
    public AVDeviceInfo** @devices;
    /// <summary>number of autodetected devices</summary>
    public int @nb_devices;
    /// <summary>index of default device or -1 if no default</summary>
    public int @default_device;
}

public unsafe partial struct AVDeviceRect
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

/// <summary>@}</summary>
public unsafe partial struct AVDictionaryEntry
{
    public byte* @key;
    public byte* @value;
}

/// <summary>This struct is allocated as AVHWDeviceContext.hwctx</summary>
public unsafe partial struct AVDXVA2DeviceContext
{
    public IDirect3DDeviceManager9* @devmgr;
}

/// <summary>This struct is allocated as AVHWFramesContext.hwctx</summary>
public unsafe partial struct AVDXVA2FramesContext
{
    /// <summary>The surface type (e.g. DXVA2_VideoProcessorRenderTarget or DXVA2_VideoDecoderRenderTarget). Must be set by the caller.</summary>
    public ulong @surface_type;
    /// <summary>The surface pool. When an external pool is not provided by the caller, this will be managed (allocated and filled on init, freed on uninit) by libavutil.</summary>
    public IDirect3DSurface9** @surfaces;
    public int @nb_surfaces;
    /// <summary>Certain drivers require the decoder to be destroyed before the surfaces. To allow internally managed pools to work properly in such cases, this field is provided.</summary>
    public IDirectXVideoDecoder* @decoder_to_release;
}

/// <summary>This struct represents dynamic metadata for color volume transform - application 4 of SMPTE 2094-40:2016 standard.</summary>
public unsafe partial struct AVDynamicHDRPlus
{
    /// <summary>Country code by Rec. ITU-T T.35 Annex A. The value shall be 0xB5.</summary>
    public byte @itu_t_t35_country_code;
    /// <summary>Application version in the application defining document in ST-2094 suite. The value shall be set to 0.</summary>
    public byte @application_version;
    /// <summary>The number of processing windows. The value shall be in the range of 1 to 3, inclusive.</summary>
    public byte @num_windows;
    /// <summary>The color transform parameters for every processing window.</summary>
    public AVHDRPlusColorTransformParams_array3 @params;
    /// <summary>The nominal maximum display luminance of the targeted system display, in units of 0.0001 candelas per square metre. The value shall be in the range of 0 to 10000, inclusive.</summary>
    public AVRational @targeted_system_display_maximum_luminance;
    /// <summary>This flag shall be equal to 0 in bit streams conforming to this version of this Specification. The value 1 is reserved for future use.</summary>
    public byte @targeted_system_display_actual_peak_luminance_flag;
    /// <summary>The number of rows in the targeted system_display_actual_peak_luminance array. The value shall be in the range of 2 to 25, inclusive.</summary>
    public byte @num_rows_targeted_system_display_actual_peak_luminance;
    /// <summary>The number of columns in the targeted_system_display_actual_peak_luminance array. The value shall be in the range of 2 to 25, inclusive.</summary>
    public byte @num_cols_targeted_system_display_actual_peak_luminance;
    /// <summary>The normalized actual peak luminance of the targeted system display. The values should be in the range of 0 to 1, inclusive and in multiples of 1/15.</summary>
    public AVRational_array25x25 @targeted_system_display_actual_peak_luminance;
    /// <summary>This flag shall be equal to 0 in bitstreams conforming to this version of this Specification. The value 1 is reserved for future use.</summary>
    public byte @mastering_display_actual_peak_luminance_flag;
    /// <summary>The number of rows in the mastering_display_actual_peak_luminance array. The value shall be in the range of 2 to 25, inclusive.</summary>
    public byte @num_rows_mastering_display_actual_peak_luminance;
    /// <summary>The number of columns in the mastering_display_actual_peak_luminance array. The value shall be in the range of 2 to 25, inclusive.</summary>
    public byte @num_cols_mastering_display_actual_peak_luminance;
    /// <summary>The normalized actual peak luminance of the mastering display used for mastering the image essence. The values should be in the range of 0 to 1, inclusive and in multiples of 1/15.</summary>
    public AVRational_array25x25 @mastering_display_actual_peak_luminance;
}

/// <summary>Filter definition. This defines the pads a filter contains, and all the callback functions used to interact with the filter.</summary>
public unsafe partial struct AVFilter
{
    /// <summary>Filter name. Must be non-NULL and unique among filters.</summary>
    public byte* @name;
    /// <summary>A description of the filter. May be NULL.</summary>
    public byte* @description;
    /// <summary>List of static inputs.</summary>
    public AVFilterPad* @inputs;
    /// <summary>List of static outputs.</summary>
    public AVFilterPad* @outputs;
    /// <summary>A class for the private data, used to declare filter private AVOptions. This field is NULL for filters that do not declare any options.</summary>
    public AVClass* @priv_class;
    /// <summary>A combination of AVFILTER_FLAG_*</summary>
    public int @flags;
    /// <summary>The number of entries in the list of inputs.</summary>
    public byte @nb_inputs;
    /// <summary>The number of entries in the list of outputs.</summary>
    public byte @nb_outputs;
    /// <summary>This field determines the state of the formats union. It is an enum FilterFormatsState value.</summary>
    public byte @formats_state;
    /// <summary>Filter pre-initialization function</summary>
    public AVFilter_preinit_func @preinit;
    /// <summary>Filter initialization function.</summary>
    public AVFilter_init_func @init;
    /// <summary>Filter uninitialization function.</summary>
    public AVFilter_uninit_func @uninit;
    public AVFilter_formats @formats;
    /// <summary>size of private data to allocate for the filter</summary>
    public int @priv_size;
    /// <summary>Additional flags for avfilter internal use only.</summary>
    public int @flags_internal;
    /// <summary>Make the filter instance process a command.</summary>
    public AVFilter_process_command_func @process_command;
    /// <summary>Filter activation function.</summary>
    public AVFilter_activate_func @activate;
}

/// <summary>The state of the following union is determined by formats_state. See the documentation of enum FilterFormatsState in internal.h.</summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct AVFilter_formats
{
    /// <summary>Query formats supported by the filter on its inputs and outputs.</summary>
    [FieldOffset(0)]
    public _query_func_func @query_func;
    /// <summary>Same as query_func(), except this function writes the results into provided arrays.</summary>
    [FieldOffset(0)]
    public _query_func2_func @query_func2;
    /// <summary>A pointer to an array of admissible pixel formats delimited by AV_PIX_FMT_NONE. The generic code will use this list to indicate that this filter supports each of these pixel formats, provided that all inputs and outputs use the same pixel format.</summary>
    [FieldOffset(0)]
    public AVPixelFormat* @pixels_list;
    /// <summary>Analogous to pixels, but delimited by AV_SAMPLE_FMT_NONE and restricted to filters that only have AVMEDIA_TYPE_AUDIO inputs and outputs.</summary>
    [FieldOffset(0)]
    public AVSampleFormat* @samples_list;
    /// <summary>Equivalent to { pix_fmt, AV_PIX_FMT_NONE } as pixels_list.</summary>
    [FieldOffset(0)]
    public AVPixelFormat @pix_fmt;
    /// <summary>Equivalent to { sample_fmt, AV_SAMPLE_FMT_NONE } as samples_list.</summary>
    [FieldOffset(0)]
    public AVSampleFormat @sample_fmt;
}

/// <summary>A filterchain is a list of filter specifications.</summary>
public unsafe partial struct AVFilterChain
{
    public AVFilterParams** @filters;
    public ulong @nb_filters;
}

/// <summary>An instance of a filter</summary>
public unsafe partial struct AVFilterContext
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
    public AVFilterGraph* @graph;
    /// <summary>Type of multithreading being allowed/used. A combination of AVFILTER_THREAD_* flags.</summary>
    public int @thread_type;
    /// <summary>Max number of threads allowed in this filter instance. If &lt;= 0, its value is ignored. Overrides global number of threads set per filter graph.</summary>
    public int @nb_threads;
    public AVFilterCommand* @command_queue;
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
    /// <summary>Ready status of the filter. A non-0 value means that the filter needs activating; a higher value suggests a more urgent activation.</summary>
    public uint @ready;
    /// <summary>Sets the number of extra hardware frames which the filter will allocate on its output links for use in following filters or by the caller.</summary>
    public int @extra_hw_frames;
}

/// <summary>Lists of formats / etc. supported by an end of a link.</summary>
public unsafe partial struct AVFilterFormatsConfig
{
    /// <summary>List of supported formats (pixel or sample).</summary>
    public AVFilterFormats* @formats;
    /// <summary>Lists of supported sample rates, only for audio.</summary>
    public AVFilterFormats* @samplerates;
    /// <summary>Lists of supported channel layouts, only for audio.</summary>
    public AVFilterChannelLayouts* @channel_layouts;
    /// <summary>AVColorSpace</summary>
    public AVFilterFormats* @color_spaces;
    /// <summary>AVColorRange</summary>
    public AVFilterFormats* @color_ranges;
}

public unsafe partial struct AVFilterGraph
{
    public AVClass* @av_class;
    public AVFilterContext** @filters;
    public uint @nb_filters;
    /// <summary>sws options to use for the auto-inserted scale filters</summary>
    public byte* @scale_sws_opts;
    /// <summary>Type of multithreading allowed for filters in this graph. A combination of AVFILTER_THREAD_* flags.</summary>
    public int @thread_type;
    /// <summary>Maximum number of threads used by filters in this graph. May be set by the caller before adding any filters to the filtergraph. Zero (the default) means that the number of threads is determined automatically.</summary>
    public int @nb_threads;
    /// <summary>Opaque user data. May be set by the caller to an arbitrary value, e.g. to be used from callbacks like AVFilterGraph.execute. Libavfilter will not touch this field in any way.</summary>
    public void* @opaque;
    /// <summary>This callback may be set by the caller immediately after allocating the graph and before adding any filters to it, to provide a custom multithreading implementation.</summary>
    public AVFilterGraph_execute_func @execute;
    /// <summary>swr options to use for the auto-inserted aresample filters, Access ONLY through AVOptions</summary>
    public byte* @aresample_swr_opts;
}

/// <summary>A parsed representation of a filtergraph segment.</summary>
public unsafe partial struct AVFilterGraphSegment
{
    /// <summary>The filtergraph this segment is associated with. Set by avfilter_graph_segment_parse().</summary>
    public AVFilterGraph* @graph;
    /// <summary>A list of filter chain contained in this segment. Set in avfilter_graph_segment_parse().</summary>
    public AVFilterChain** @chains;
    public ulong @nb_chains;
    /// <summary>A string containing a colon-separated list of key=value options applied to all scale filters in this segment.</summary>
    public byte* @scale_sws_opts;
}

/// <summary>A linked-list of the inputs/outputs of the filter chain.</summary>
public unsafe partial struct AVFilterInOut
{
    /// <summary>unique name for this input/output in the list</summary>
    public byte* @name;
    /// <summary>filter context associated to this input/output</summary>
    public AVFilterContext* @filter_ctx;
    /// <summary>index of the filt_ctx pad to use for linking</summary>
    public int @pad_idx;
    /// <summary>next input/input in the list, NULL if this is the last</summary>
    public AVFilterInOut* @next;
}

/// <summary>A link between two filters. This contains pointers to the source and destination filters between which this link exists, and the indexes of the pads involved. In addition, this link also contains the parameters which have been negotiated and agreed upon between the filter, such as image dimensions, format, etc.</summary>
public unsafe partial struct AVFilterLink
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
    /// <summary>agreed upon media format</summary>
    public int @format;
    /// <summary>agreed upon image width</summary>
    public int @w;
    /// <summary>agreed upon image height</summary>
    public int @h;
    /// <summary>agreed upon sample aspect ratio</summary>
    public AVRational @sample_aspect_ratio;
    /// <summary>agreed upon YUV color space</summary>
    public AVColorSpace @colorspace;
    /// <summary>agreed upon YUV color range</summary>
    public AVColorRange @color_range;
    /// <summary>samples per second</summary>
    public int @sample_rate;
    /// <summary>channel layout of current buffer (see libavutil/channel_layout.h)</summary>
    public AVChannelLayout @ch_layout;
    /// <summary>Define the time base used by the PTS of the frames/samples which will pass through this link. During the configuration stage, each filter is supposed to change only the output timebase, while the timebase of the input link is assumed to be an unchangeable property.</summary>
    public AVRational @time_base;
    /// <summary>Lists of supported formats / etc. supported by the input filter.</summary>
    public AVFilterFormatsConfig @incfg;
    /// <summary>Lists of supported formats / etc. supported by the output filter.</summary>
    public AVFilterFormatsConfig @outcfg;
}

/// <summary>Parameters of a filter&apos;s input or output pad.</summary>
public unsafe partial struct AVFilterPadParams
{
    /// <summary>An av_malloc()&apos;ed string containing the pad label.</summary>
    public byte* @label;
}

/// <summary>Parameters describing a filter to be created in a filtergraph.</summary>
public unsafe partial struct AVFilterParams
{
    /// <summary>The filter context.</summary>
    public AVFilterContext* @filter;
    /// <summary>Name of the AVFilter to be used.</summary>
    public byte* @filter_name;
    /// <summary>Name to be used for this filter instance.</summary>
    public byte* @instance_name;
    /// <summary>Options to be apllied to the filter.</summary>
    public AVDictionary* @opts;
    public AVFilterPadParams** @inputs;
    public uint @nb_inputs;
    public AVFilterPadParams** @outputs;
    public uint @nb_outputs;
}

/// <summary>Format I/O context. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVFormatContext) must not be used outside libav*, use avformat_alloc_context() to create an AVFormatContext.</summary>
public unsafe partial struct AVFormatContext
{
    /// <summary>A class for logging and avoptions. Set by avformat_alloc_context(). Exports (de)muxer private options if they exist.</summary>
    public AVClass* @av_class;
    /// <summary>The input container format.</summary>
    public AVInputFormat* @iformat;
    /// <summary>The output container format.</summary>
    public AVOutputFormat* @oformat;
    /// <summary>Format private data. This is an AVOptions-enabled struct if and only if iformat/oformat.priv_class is not NULL.</summary>
    public void* @priv_data;
    /// <summary>I/O context.</summary>
    public AVIOContext* @pb;
    /// <summary>Flags signalling stream properties. A combination of AVFMTCTX_*. Set by libavformat.</summary>
    public int @ctx_flags;
    /// <summary>Number of elements in AVFormatContext.streams.</summary>
    public uint @nb_streams;
    /// <summary>A list of all streams in the file. New streams are created with avformat_new_stream().</summary>
    public AVStream** @streams;
    /// <summary>Number of elements in AVFormatContext.stream_groups.</summary>
    public uint @nb_stream_groups;
    /// <summary>A list of all stream groups in the file. New groups are created with avformat_stream_group_create(), and filled with avformat_stream_group_add_stream().</summary>
    public AVStreamGroup** @stream_groups;
    /// <summary>Number of chapters in AVChapter array. When muxing, chapters are normally written in the file header, so nb_chapters should normally be initialized before write_header is called. Some muxers (e.g. mov and mkv) can also write chapters in the trailer. To write chapters in the trailer, nb_chapters must be zero when write_header is called and non-zero when write_trailer is called. - muxing: set by user - demuxing: set by libavformat</summary>
    public uint @nb_chapters;
    public AVChapter** @chapters;
    /// <summary>input or output URL. Unlike the old filename field, this field has no length restriction.</summary>
    public byte* @url;
    /// <summary>Position of the first frame of the component, in AV_TIME_BASE fractional seconds. NEVER set this value directly: It is deduced from the AVStream values.</summary>
    public long @start_time;
    /// <summary>Duration of the stream, in AV_TIME_BASE fractional seconds. Only set this value if you know none of the individual stream durations and also do not set any of them. This is deduced from the AVStream values if not set.</summary>
    public long @duration;
    /// <summary>Total stream bitrate in bit/s, 0 if not available. Never set it directly if the file_size and the duration are known as FFmpeg can compute it automatically.</summary>
    public long @bit_rate;
    public uint @packet_size;
    public int @max_delay;
    /// <summary>Flags modifying the (de)muxer behaviour. A combination of AVFMT_FLAG_*. Set by the user before avformat_open_input() / avformat_write_header().</summary>
    public int @flags;
    /// <summary>Maximum number of bytes read from input in order to determine stream properties. Used when reading the global header and in avformat_find_stream_info().</summary>
    public long @probesize;
    /// <summary>Maximum duration (in AV_TIME_BASE units) of the data read from input in avformat_find_stream_info(). Demuxing only, set by the caller before avformat_find_stream_info(). Can be set to 0 to let avformat choose using a heuristic.</summary>
    public long @max_analyze_duration;
    public byte* @key;
    public int @keylen;
    public uint @nb_programs;
    public AVProgram** @programs;
    /// <summary>Forced video codec_id. Demuxing: Set by user.</summary>
    public AVCodecID @video_codec_id;
    /// <summary>Forced audio codec_id. Demuxing: Set by user.</summary>
    public AVCodecID @audio_codec_id;
    /// <summary>Forced subtitle codec_id. Demuxing: Set by user.</summary>
    public AVCodecID @subtitle_codec_id;
    /// <summary>Forced Data codec_id. Demuxing: Set by user.</summary>
    public AVCodecID @data_codec_id;
    /// <summary>Metadata that applies to the whole file.</summary>
    public AVDictionary* @metadata;
    /// <summary>Start time of the stream in real world time, in microseconds since the Unix epoch (00:00 1st January 1970). That is, pts=0 in the stream was captured at this real world time. - muxing: Set by the caller before avformat_write_header(). If set to either 0 or AV_NOPTS_VALUE, then the current wall-time will be used. - demuxing: Set by libavformat. AV_NOPTS_VALUE if unknown. Note that the value may become known after some number of frames have been received.</summary>
    public long @start_time_realtime;
    /// <summary>The number of frames used for determining the framerate in avformat_find_stream_info(). Demuxing only, set by the caller before avformat_find_stream_info().</summary>
    public int @fps_probe_size;
    /// <summary>Error recognition; higher values will detect more errors but may misdetect some more or less valid parts as errors. Demuxing only, set by the caller before avformat_open_input().</summary>
    public int @error_recognition;
    /// <summary>Custom interrupt callbacks for the I/O layer.</summary>
    public AVIOInterruptCB @interrupt_callback;
    /// <summary>Flags to enable debugging.</summary>
    public int @debug;
    /// <summary>The maximum number of streams. - encoding: unused - decoding: set by user</summary>
    public int @max_streams;
    /// <summary>Maximum amount of memory in bytes to use for the index of each stream. If the index exceeds this size, entries will be discarded as needed to maintain a smaller size. This can lead to slower or less accurate seeking (depends on demuxer). Demuxers for which a full in-memory index is mandatory will ignore this. - muxing: unused - demuxing: set by user</summary>
    public uint @max_index_size;
    /// <summary>Maximum amount of memory in bytes to use for buffering frames obtained from realtime capture devices.</summary>
    public uint @max_picture_buffer;
    /// <summary>Maximum buffering duration for interleaving.</summary>
    public long @max_interleave_delta;
    /// <summary>Maximum number of packets to read while waiting for the first timestamp. Decoding only.</summary>
    public int @max_ts_probe;
    /// <summary>Max chunk time in microseconds. Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user - decoding: unused</summary>
    public int @max_chunk_duration;
    /// <summary>Max chunk size in bytes Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user - decoding: unused</summary>
    public int @max_chunk_size;
    /// <summary>Maximum number of packets that can be probed - encoding: unused - decoding: set by user</summary>
    public int @max_probe_packets;
    /// <summary>Allow non-standard and experimental extension</summary>
    public int @strict_std_compliance;
    /// <summary>Flags indicating events happening on the file, a combination of AVFMT_EVENT_FLAG_*.</summary>
    public int @event_flags;
    /// <summary>Avoid negative timestamps during muxing. Any value of the AVFMT_AVOID_NEG_TS_* constants. Note, this works better when using av_interleaved_write_frame(). - muxing: Set by user - demuxing: unused</summary>
    public int @avoid_negative_ts;
    /// <summary>Audio preload in microseconds. Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user - decoding: unused</summary>
    public int @audio_preload;
    /// <summary>forces the use of wallclock timestamps as pts/dts of packets This has undefined results in the presence of B frames. - encoding: unused - decoding: Set by user</summary>
    public int @use_wallclock_as_timestamps;
    /// <summary>Skip duration calcuation in estimate_timings_from_pts. - encoding: unused - decoding: set by user</summary>
    public int @skip_estimate_duration_from_pts;
    /// <summary>avio flags, used to force AVIO_FLAG_DIRECT. - encoding: unused - decoding: Set by user</summary>
    public int @avio_flags;
    /// <summary>The duration field can be estimated through various ways, and this field can be used to know how the duration was estimated. - encoding: unused - decoding: Read by user</summary>
    public AVDurationEstimationMethod @duration_estimation_method;
    /// <summary>Skip initial bytes when opening stream - encoding: unused - decoding: Set by user</summary>
    public long @skip_initial_bytes;
    /// <summary>Correct single timestamp overflows - encoding: unused - decoding: Set by user</summary>
    public uint @correct_ts_overflow;
    /// <summary>Force seeking to any (also non key) frames. - encoding: unused - decoding: Set by user</summary>
    public int @seek2any;
    /// <summary>Flush the I/O context after each packet. - encoding: Set by user - decoding: unused</summary>
    public int @flush_packets;
    /// <summary>format probing score. The maximal score is AVPROBE_SCORE_MAX, its set when the demuxer probes the format. - encoding: unused - decoding: set by avformat, read by user</summary>
    public int @probe_score;
    /// <summary>Maximum number of bytes read from input in order to identify the AVInputFormat &quot;input format&quot;. Only used when the format is not set explicitly by the caller.</summary>
    public int @format_probesize;
    /// <summary>&apos;,&apos; separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user</summary>
    public byte* @codec_whitelist;
    /// <summary>&apos;,&apos; separated list of allowed demuxers. If NULL then all are allowed - encoding: unused - decoding: set by user</summary>
    public byte* @format_whitelist;
    /// <summary>&apos;,&apos; separated list of allowed protocols. - encoding: unused - decoding: set by user</summary>
    public byte* @protocol_whitelist;
    /// <summary>&apos;,&apos; separated list of disallowed protocols. - encoding: unused - decoding: set by user</summary>
    public byte* @protocol_blacklist;
    /// <summary>IO repositioned flag. This is set by avformat when the underlaying IO context read pointer is repositioned, for example when doing byte based seeking. Demuxers can use the flag to detect such changes.</summary>
    public int @io_repositioned;
    /// <summary>Forced video codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user</summary>
    public AVCodec* @video_codec;
    /// <summary>Forced audio codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user</summary>
    public AVCodec* @audio_codec;
    /// <summary>Forced subtitle codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user</summary>
    public AVCodec* @subtitle_codec;
    /// <summary>Forced data codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user</summary>
    public AVCodec* @data_codec;
    /// <summary>Number of bytes to be written as padding in a metadata header. Demuxing: Unused. Muxing: Set by user.</summary>
    public int @metadata_header_padding;
    /// <summary>User data. This is a place for some private data of the user.</summary>
    public void* @opaque;
    /// <summary>Callback used by devices to communicate with application.</summary>
    public AVFormatContext_control_message_cb_func @control_message_cb;
    /// <summary>Output timestamp offset, in microseconds. Muxing: set by user</summary>
    public long @output_ts_offset;
    /// <summary>dump format separator. can be &quot;, &quot; or &quot; &quot; or anything else - muxing: Set by user. - demuxing: Set by user.</summary>
    public byte* @dump_separator;
    /// <summary>A callback for opening new IO streams.</summary>
    public AVFormatContext_io_open_func @io_open;
    /// <summary>A callback for closing the streams opened with AVFormatContext.io_open().</summary>
    public AVFormatContext_io_close2_func @io_close2;
    /// <summary>Maximum number of bytes read from input in order to determine stream durations when using estimate_timings_from_pts in avformat_find_stream_info(). Demuxing only, set by the caller before avformat_find_stream_info(). Can be set to 0 to let avformat choose using a heuristic.</summary>
    public long @duration_probesize;
}

/// <summary>This structure describes decoded (raw) audio or video data.</summary>
public unsafe partial struct AVFrame
{
    /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte. For video, it could even point to the end of the image data.</summary>
    public byte_ptrArray8 @data;
    /// <summary>For video, a positive or negative value, which is typically indicating the size in bytes of each picture line, but it can also be: - the negative byte size of lines for vertical flipping (with data[n] pointing to the end of the data - a positive or negative multiple of the byte size as for accessing even and odd fields of a frame (possibly flipped)</summary>
    public int_array8 @linesize;
    /// <summary>pointers to the data planes/channels.</summary>
    public byte** @extended_data;
    /// <summary>Video frames only. The coded dimensions (in pixels) of the video frame, i.e. the size of the rectangle that contains some well-defined values.</summary>
    public int @width;
    /// <summary>Video frames only. The coded dimensions (in pixels) of the video frame, i.e. the size of the rectangle that contains some well-defined values.</summary>
    public int @height;
    /// <summary>number of audio samples (per channel) described by this frame</summary>
    public int @nb_samples;
    /// <summary>format of the frame, -1 if unknown or unset Values correspond to enum AVPixelFormat for video frames, enum AVSampleFormat for audio)</summary>
    public int @format;
    /// <summary>1 -&gt; keyframe, 0-&gt; not</summary>
    [Obsolete("Use AV_FRAME_FLAG_KEY instead")]
    public int @key_frame;
    /// <summary>Picture type of the frame.</summary>
    public AVPictureType @pict_type;
    /// <summary>Sample aspect ratio for the video frame, 0/1 if unknown/unspecified.</summary>
    public AVRational @sample_aspect_ratio;
    /// <summary>Presentation timestamp in time_base units (time when frame should be shown to user).</summary>
    public long @pts;
    /// <summary>DTS copied from the AVPacket that triggered returning this frame. (if frame threading isn&apos;t used) This is also the Presentation time of this AVFrame calculated from only AVPacket.dts values without pts values.</summary>
    public long @pkt_dts;
    /// <summary>Time base for the timestamps in this frame. In the future, this field may be set on frames output by decoders or filters, but its value will be by default ignored on input to encoders or filters.</summary>
    public AVRational @time_base;
    /// <summary>quality (between 1 (good) and FF_LAMBDA_MAX (bad))</summary>
    public int @quality;
    /// <summary>Frame owner&apos;s private data.</summary>
    public void* @opaque;
    /// <summary>Number of fields in this frame which should be repeated, i.e. the total duration of this frame should be repeat_pict + 2 normal field durations.</summary>
    public int @repeat_pict;
    /// <summary>The content of the picture is interlaced.</summary>
    [Obsolete("Use AV_FRAME_FLAG_INTERLACED instead")]
    public int @interlaced_frame;
    /// <summary>If the content is interlaced, is top field displayed first.</summary>
    [Obsolete("Use AV_FRAME_FLAG_TOP_FIELD_FIRST instead")]
    public int @top_field_first;
    /// <summary>Tell user application that palette has changed from previous frame.</summary>
    public int @palette_has_changed;
    /// <summary>Sample rate of the audio data.</summary>
    public int @sample_rate;
    /// <summary>AVBuffer references backing the data for this frame. All the pointers in data and extended_data must point inside one of the buffers in buf or extended_buf. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j &lt; i.</summary>
    public AVBufferRef_ptrArray8 @buf;
    /// <summary>For planar audio which requires more than AV_NUM_DATA_POINTERS AVBufferRef pointers, this array will hold all the references which cannot fit into AVFrame.buf.</summary>
    public AVBufferRef** @extended_buf;
    /// <summary>Number of elements in extended_buf.</summary>
    public int @nb_extended_buf;
    public AVFrameSideData** @side_data;
    public int @nb_side_data;
    /// <summary>Frame flags, a combination of lavu_frame_flags</summary>
    public int @flags;
    /// <summary>MPEG vs JPEG YUV range. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVColorRange @color_range;
    public AVColorPrimaries @color_primaries;
    public AVColorTransferCharacteristic @color_trc;
    /// <summary>YUV colorspace type. - encoding: Set by user - decoding: Set by libavcodec</summary>
    public AVColorSpace @colorspace;
    public AVChromaLocation @chroma_location;
    /// <summary>frame timestamp estimated using various heuristics, in stream time base - encoding: unused - decoding: set by libavcodec, read by user.</summary>
    public long @best_effort_timestamp;
    /// <summary>reordered pos from the last AVPacket that has been input into the decoder - encoding: unused - decoding: Read by user.</summary>
    [Obsolete("use AV_CODEC_FLAG_COPY_OPAQUE to pass through arbitrary user data from packets to frames")]
    public long @pkt_pos;
    /// <summary>metadata. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public AVDictionary* @metadata;
    /// <summary>decode error flags of the frame, set to a combination of FF_DECODE_ERROR_xxx flags if the decoder produced a frame, but there were errors during the decoding. - encoding: unused - decoding: set by libavcodec, read by user.</summary>
    public int @decode_error_flags;
    /// <summary>size of the corresponding packet containing the compressed frame. It is set to a negative value if unknown. - encoding: unused - decoding: set by libavcodec, read by user.</summary>
    [Obsolete("use AV_CODEC_FLAG_COPY_OPAQUE to pass through arbitrary user data from packets to frames")]
    public int @pkt_size;
    /// <summary>For hwaccel-format frames, this should be a reference to the AVHWFramesContext describing the frame.</summary>
    public AVBufferRef* @hw_frames_ctx;
    /// <summary>Frame owner&apos;s private data.</summary>
    public AVBufferRef* @opaque_ref;
    /// <summary>cropping Video frames only. The number of pixels to discard from the the top/bottom/left/right border of the frame to obtain the sub-rectangle of the frame intended for presentation. @{</summary>
    public ulong @crop_top;
    public ulong @crop_bottom;
    public ulong @crop_left;
    public ulong @crop_right;
    /// <summary>AVBufferRef for internal use by a single libav* library. Must not be used to transfer data between libraries. Has to be NULL when ownership of the frame leaves the respective library.</summary>
    public AVBufferRef* @private_ref;
    /// <summary>Channel layout of the audio data.</summary>
    public AVChannelLayout @ch_layout;
    /// <summary>Duration of the frame, in the same units as pts. 0 if unknown.</summary>
    public long @duration;
}

/// <summary>Structure to hold side data for an AVFrame.</summary>
public unsafe partial struct AVFrameSideData
{
    public AVFrameSideDataType @type;
    public byte* @data;
    public ulong @size;
    public AVDictionary* @metadata;
    public AVBufferRef* @buf;
}

/// <summary>Color transform parameters at a processing window in a dynamic metadata for SMPTE 2094-40.</summary>
public unsafe partial struct AVHDRPlusColorTransformParams
{
    /// <summary>The relative x coordinate of the top left pixel of the processing window. The value shall be in the range of 0 and 1, inclusive and in multiples of 1/(width of Picture - 1). The value 1 corresponds to the absolute coordinate of width of Picture - 1. The value for first processing window shall be 0.</summary>
    public AVRational @window_upper_left_corner_x;
    /// <summary>The relative y coordinate of the top left pixel of the processing window. The value shall be in the range of 0 and 1, inclusive and in multiples of 1/(height of Picture - 1). The value 1 corresponds to the absolute coordinate of height of Picture - 1. The value for first processing window shall be 0.</summary>
    public AVRational @window_upper_left_corner_y;
    /// <summary>The relative x coordinate of the bottom right pixel of the processing window. The value shall be in the range of 0 and 1, inclusive and in multiples of 1/(width of Picture - 1). The value 1 corresponds to the absolute coordinate of width of Picture - 1. The value for first processing window shall be 1.</summary>
    public AVRational @window_lower_right_corner_x;
    /// <summary>The relative y coordinate of the bottom right pixel of the processing window. The value shall be in the range of 0 and 1, inclusive and in multiples of 1/(height of Picture - 1). The value 1 corresponds to the absolute coordinate of height of Picture - 1. The value for first processing window shall be 1.</summary>
    public AVRational @window_lower_right_corner_y;
    /// <summary>The x coordinate of the center position of the concentric internal and external ellipses of the elliptical pixel selector in the processing window. The value shall be in the range of 0 to (width of Picture - 1), inclusive and in multiples of 1 pixel.</summary>
    public ushort @center_of_ellipse_x;
    /// <summary>The y coordinate of the center position of the concentric internal and external ellipses of the elliptical pixel selector in the processing window. The value shall be in the range of 0 to (height of Picture - 1), inclusive and in multiples of 1 pixel.</summary>
    public ushort @center_of_ellipse_y;
    /// <summary>The clockwise rotation angle in degree of arc with respect to the positive direction of the x-axis of the concentric internal and external ellipses of the elliptical pixel selector in the processing window. The value shall be in the range of 0 to 180, inclusive and in multiples of 1.</summary>
    public byte @rotation_angle;
    /// <summary>The semi-major axis value of the internal ellipse of the elliptical pixel selector in amount of pixels in the processing window. The value shall be in the range of 1 to 65535, inclusive and in multiples of 1 pixel.</summary>
    public ushort @semimajor_axis_internal_ellipse;
    /// <summary>The semi-major axis value of the external ellipse of the elliptical pixel selector in amount of pixels in the processing window. The value shall not be less than semimajor_axis_internal_ellipse of the current processing window. The value shall be in the range of 1 to 65535, inclusive and in multiples of 1 pixel.</summary>
    public ushort @semimajor_axis_external_ellipse;
    /// <summary>The semi-minor axis value of the external ellipse of the elliptical pixel selector in amount of pixels in the processing window. The value shall be in the range of 1 to 65535, inclusive and in multiples of 1 pixel.</summary>
    public ushort @semiminor_axis_external_ellipse;
    /// <summary>Overlap process option indicates one of the two methods of combining rendered pixels in the processing window in an image with at least one elliptical pixel selector. For overlapping elliptical pixel selectors in an image, overlap_process_option shall have the same value.</summary>
    public AVHDRPlusOverlapProcessOption @overlap_process_option;
    /// <summary>The maximum of the color components of linearized RGB values in the processing window in the scene. The values should be in the range of 0 to 1, inclusive and in multiples of 0.00001. maxscl[ 0 ], maxscl[ 1 ], and maxscl[ 2 ] are corresponding to R, G, B color components respectively.</summary>
    public AVRational_array3 @maxscl;
    /// <summary>The average of linearized maxRGB values in the processing window in the scene. The value should be in the range of 0 to 1, inclusive and in multiples of 0.00001.</summary>
    public AVRational @average_maxrgb;
    /// <summary>The number of linearized maxRGB values at given percentiles in the processing window in the scene. The maximum value shall be 15.</summary>
    public byte @num_distribution_maxrgb_percentiles;
    /// <summary>The linearized maxRGB values at given percentiles in the processing window in the scene.</summary>
    public AVHDRPlusPercentile_array15 @distribution_maxrgb;
    /// <summary>The fraction of selected pixels in the image that contains the brightest pixel in the scene. The value shall be in the range of 0 to 1, inclusive and in multiples of 0.001.</summary>
    public AVRational @fraction_bright_pixels;
    /// <summary>This flag indicates that the metadata for the tone mapping function in the processing window is present (for value of 1).</summary>
    public byte @tone_mapping_flag;
    /// <summary>The x coordinate of the separation point between the linear part and the curved part of the tone mapping function. The value shall be in the range of 0 to 1, excluding 0 and in multiples of 1/4095.</summary>
    public AVRational @knee_point_x;
    /// <summary>The y coordinate of the separation point between the linear part and the curved part of the tone mapping function. The value shall be in the range of 0 to 1, excluding 0 and in multiples of 1/4095.</summary>
    public AVRational @knee_point_y;
    /// <summary>The number of the intermediate anchor parameters of the tone mapping function in the processing window. The maximum value shall be 15.</summary>
    public byte @num_bezier_curve_anchors;
    /// <summary>The intermediate anchor parameters of the tone mapping function in the processing window in the scene. The values should be in the range of 0 to 1, inclusive and in multiples of 1/1023.</summary>
    public AVRational_array15 @bezier_curve_anchors;
    /// <summary>This flag shall be equal to 0 in bitstreams conforming to this version of this Specification. Other values are reserved for future use.</summary>
    public byte @color_saturation_mapping_flag;
    /// <summary>The color saturation gain in the processing window in the scene. The value shall be in the range of 0 to 63/8, inclusive and in multiples of 1/8. The default value shall be 1.</summary>
    public AVRational @color_saturation_weight;
}

/// <summary>Represents the percentile at a specific percentage in a distribution.</summary>
public unsafe partial struct AVHDRPlusPercentile
{
    /// <summary>The percentage value corresponding to a specific percentile linearized RGB value in the processing window in the scene. The value shall be in the range of 0 to100, inclusive.</summary>
    public byte @percentage;
    /// <summary>The linearized maxRGB value at a specific percentile in the processing window in the scene. The value shall be in the range of 0 to 1, inclusive and in multiples of 0.00001.</summary>
    public AVRational @percentile;
}

public unsafe partial struct AVHWAccel
{
    /// <summary>Name of the hardware accelerated codec. The name is globally unique among encoders and among decoders (but an encoder and a decoder can share the same name).</summary>
    public byte* @name;
    /// <summary>Type of codec implemented by the hardware accelerator.</summary>
    public AVMediaType @type;
    /// <summary>Codec implemented by the hardware accelerator.</summary>
    public AVCodecID @id;
    /// <summary>Supported pixel format.</summary>
    public AVPixelFormat @pix_fmt;
    /// <summary>Hardware accelerated codec capabilities. see AV_HWACCEL_CODEC_CAP_*</summary>
    public int @capabilities;
}

/// <summary>This struct aggregates all the (hardware/vendor-specific) &quot;high-level&quot; state, i.e. state that is not tied to a concrete processing configuration. E.g., in an API that supports hardware-accelerated encoding and decoding, this struct will (if possible) wrap the state that is common to both encoding and decoding and from which specific instances of encoders or decoders can be derived.</summary>
public unsafe partial struct AVHWDeviceContext
{
    /// <summary>A class for logging. Set by av_hwdevice_ctx_alloc().</summary>
    public AVClass* @av_class;
    /// <summary>This field identifies the underlying API used for hardware access.</summary>
    public AVHWDeviceType @type;
    /// <summary>The format-specific data, allocated and freed by libavutil along with this context.</summary>
    public void* @hwctx;
    /// <summary>This field may be set by the caller before calling av_hwdevice_ctx_init().</summary>
    public AVHWDeviceContext_free_func @free;
    /// <summary>Arbitrary user data, to be used e.g. by the free() callback.</summary>
    public void* @user_opaque;
}

/// <summary>This struct describes the constraints on hardware frames attached to a given device with a hardware-specific configuration. This is returned by av_hwdevice_get_hwframe_constraints() and must be freed by av_hwframe_constraints_free() after use.</summary>
public unsafe partial struct AVHWFramesConstraints
{
    /// <summary>A list of possible values for format in the hw_frames_ctx, terminated by AV_PIX_FMT_NONE. This member will always be filled.</summary>
    public AVPixelFormat* @valid_hw_formats;
    /// <summary>A list of possible values for sw_format in the hw_frames_ctx, terminated by AV_PIX_FMT_NONE. Can be NULL if this information is not known.</summary>
    public AVPixelFormat* @valid_sw_formats;
    /// <summary>The minimum size of frames in this hw_frames_ctx. (Zero if not known.)</summary>
    public int @min_width;
    public int @min_height;
    /// <summary>The maximum size of frames in this hw_frames_ctx. (INT_MAX if not known / no limit.)</summary>
    public int @max_width;
    public int @max_height;
}

/// <summary>This struct describes a set or pool of &quot;hardware&quot; frames (i.e. those with data not located in normal system memory). All the frames in the pool are assumed to be allocated in the same way and interchangeable.</summary>
public unsafe partial struct AVHWFramesContext
{
    /// <summary>A class for logging.</summary>
    public AVClass* @av_class;
    /// <summary>A reference to the parent AVHWDeviceContext. This reference is owned and managed by the enclosing AVHWFramesContext, but the caller may derive additional references from it.</summary>
    public AVBufferRef* @device_ref;
    /// <summary>The parent AVHWDeviceContext. This is simply a pointer to device_ref-&gt;data provided for convenience.</summary>
    public AVHWDeviceContext* @device_ctx;
    /// <summary>The format-specific data, allocated and freed automatically along with this context.</summary>
    public void* @hwctx;
    /// <summary>This field may be set by the caller before calling av_hwframe_ctx_init().</summary>
    public AVHWFramesContext_free_func @free;
    /// <summary>Arbitrary user data, to be used e.g. by the free() callback.</summary>
    public void* @user_opaque;
    /// <summary>A pool from which the frames are allocated by av_hwframe_get_buffer(). This field may be set by the caller before calling av_hwframe_ctx_init(). The buffers returned by calling av_buffer_pool_get() on this pool must have the properties described in the documentation in the corresponding hw type&apos;s header (hwcontext_*.h). The pool will be freed strictly before this struct&apos;s free() callback is invoked.</summary>
    public AVBufferPool* @pool;
    /// <summary>Initial size of the frame pool. If a device type does not support dynamically resizing the pool, then this is also the maximum pool size.</summary>
    public int @initial_pool_size;
    /// <summary>The pixel format identifying the underlying HW surface type.</summary>
    public AVPixelFormat @format;
    /// <summary>The pixel format identifying the actual data layout of the hardware frames.</summary>
    public AVPixelFormat @sw_format;
    /// <summary>The allocated dimensions of the frames in this pool.</summary>
    public int @width;
    /// <summary>The allocated dimensions of the frames in this pool.</summary>
    public int @height;
}

public unsafe partial struct AVIndexEntry
{
    public long @pos;
    /// <summary>Timestamp in AVStream.time_base units, preferably the time from which on correctly decoded frames are available when seeking to this entry. That means preferable PTS on keyframe based formats. But demuxers can choose to store a different timestamp, if it is more convenient for the implementation or nothing better is known</summary>
    public long @timestamp;
    /// <summary>Flag is used to indicate which frame should be discarded after decoding.</summary>
    public int @flags2_size30;
    /// <summary>Minimum distance between this and the previous keyframe, used to avoid unneeded searching.</summary>
    public int @min_distance;
}

/// <summary>@{</summary>
public unsafe partial struct AVInputFormat
{
    /// <summary>A comma separated list of short names for the format. New names may be appended with a minor bump.</summary>
    public byte* @name;
    /// <summary>Descriptive name for the format, meant to be more human-readable than name. You should use the NULL_IF_CONFIG_SMALL() macro to define it.</summary>
    public byte* @long_name;
    /// <summary>Can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_SHOW_IDS, AVFMT_NOTIMESTAMPS, AVFMT_GENERIC_INDEX, AVFMT_TS_DISCONT, AVFMT_NOBINSEARCH, AVFMT_NOGENSEARCH, AVFMT_NO_BYTE_SEEK, AVFMT_SEEK_TO_PTS.</summary>
    public int @flags;
    /// <summary>If extensions are defined, then no probe is done. You should usually not use extension format guessing because it is not reliable enough</summary>
    public byte* @extensions;
    public AVCodecTag** @codec_tag;
    /// <summary>AVClass for the private context</summary>
    public AVClass* @priv_class;
    /// <summary>Comma-separated list of mime types. It is used check for matching mime types while probing.</summary>
    public byte* @mime_type;
}

/// <summary>Bytestream IO Context. New public fields can be added with minor version bumps. Removal, reordering and changes to existing public fields require a major version bump. sizeof(AVIOContext) must not be used outside libav*.</summary>
public unsafe partial struct AVIOContext
{
    /// <summary>A class for private options.</summary>
    public AVClass* @av_class;
    /// <summary>Start of the buffer.</summary>
    public byte* @buffer;
    /// <summary>Maximum buffer size</summary>
    public int @buffer_size;
    /// <summary>Current position in the buffer</summary>
    public byte* @buf_ptr;
    /// <summary>End of the data, may be less than buffer+buffer_size if the read function returned less data than requested, e.g. for streams where no more data has been received yet.</summary>
    public byte* @buf_end;
    /// <summary>A private pointer, passed to the read/write/seek/... functions.</summary>
    public void* @opaque;
    public AVIOContext_read_packet_func @read_packet;
    public AVIOContext_write_packet_func @write_packet;
    public AVIOContext_seek_func @seek;
    /// <summary>position in the file of the current buffer</summary>
    public long @pos;
    /// <summary>true if was unable to read due to error or eof</summary>
    public int @eof_reached;
    /// <summary>contains the error code or 0 if no error happened</summary>
    public int @error;
    /// <summary>true if open for writing</summary>
    public int @write_flag;
    public int @max_packet_size;
    /// <summary>Try to buffer at least this amount of data before flushing it.</summary>
    public int @min_packet_size;
    public ulong @checksum;
    public byte* @checksum_ptr;
    public AVIOContext_update_checksum_func @update_checksum;
    /// <summary>Pause or resume playback for network streaming protocols - e.g. MMS.</summary>
    public AVIOContext_read_pause_func @read_pause;
    /// <summary>Seek to a given timestamp in stream with the specified stream_index. Needed for some network streaming protocols which don&apos;t support seeking to byte position.</summary>
    public AVIOContext_read_seek_func @read_seek;
    /// <summary>A combination of AVIO_SEEKABLE_ flags or 0 when the stream is not seekable.</summary>
    public int @seekable;
    /// <summary>avio_read and avio_write should if possible be satisfied directly instead of going through a buffer, and avio_seek will always call the underlying seek function directly.</summary>
    public int @direct;
    /// <summary>&apos;,&apos; separated list of allowed protocols.</summary>
    public byte* @protocol_whitelist;
    /// <summary>&apos;,&apos; separated list of disallowed protocols.</summary>
    public byte* @protocol_blacklist;
    /// <summary>A callback that is used instead of write_packet.</summary>
    public AVIOContext_write_data_type_func @write_data_type;
    /// <summary>If set, don&apos;t call write_data_type separately for AVIO_DATA_MARKER_BOUNDARY_POINT, but ignore them and treat them as AVIO_DATA_MARKER_UNKNOWN (to avoid needlessly small chunks of data returned from the callback).</summary>
    public int @ignore_boundary_point;
    /// <summary>Maximum reached position before a backward seek in the write buffer, used keeping track of already written data for a later flush.</summary>
    public byte* @buf_ptr_max;
    /// <summary>Read-only statistic of bytes read for this AVIOContext.</summary>
    public long @bytes_read;
    /// <summary>Read-only statistic of bytes written for this AVIOContext.</summary>
    public long @bytes_written;
}

/// <summary>Describes single entry of the directory.</summary>
public unsafe partial struct AVIODirEntry
{
    /// <summary>Filename</summary>
    public byte* @name;
    /// <summary>Type of the entry</summary>
    public int @type;
    /// <summary>Set to 1 when name is encoded with UTF-8, 0 otherwise. Name can be encoded with UTF-8 even though 0 is set.</summary>
    public int @utf8;
    /// <summary>File size in bytes, -1 if unknown.</summary>
    public long @size;
    /// <summary>Time of last modification in microseconds since unix epoch, -1 if unknown.</summary>
    public long @modification_timestamp;
    /// <summary>Time of last access in microseconds since unix epoch, -1 if unknown.</summary>
    public long @access_timestamp;
    /// <summary>Time of last status change in microseconds since unix epoch, -1 if unknown.</summary>
    public long @status_change_timestamp;
    /// <summary>User ID of owner, -1 if unknown.</summary>
    public long @user_id;
    /// <summary>Group ID of owner, -1 if unknown.</summary>
    public long @group_id;
    /// <summary>Unix file mode, -1 if unknown.</summary>
    public long @filemode;
}

/// <summary>Callback for checking whether to abort blocking functions. AVERROR_EXIT is returned in this case by the interrupted function. During blocking operations, callback is called with opaque as parameter. If the callback returns 1, the blocking operation will be aborted.</summary>
public unsafe partial struct AVIOInterruptCB
{
    public AVIOInterruptCB_callback_func @callback;
    public void* @opaque;
}

/// <summary>Mastering display metadata capable of representing the color volume of the display used to master the content (SMPTE 2086:2014).</summary>
public unsafe partial struct AVMasteringDisplayMetadata
{
    /// <summary>CIE 1931 xy chromaticity coords of color primaries (r, g, b order).</summary>
    public AVRational_array3x2 @display_primaries;
    /// <summary>CIE 1931 xy chromaticity coords of white point.</summary>
    public AVRational_array2 @white_point;
    /// <summary>Min luminance of mastering display (cd/m^2).</summary>
    public AVRational @min_luminance;
    /// <summary>Max luminance of mastering display (cd/m^2).</summary>
    public AVRational @max_luminance;
    /// <summary>Flag indicating whether the display primaries (and white point) are set.</summary>
    public int @has_primaries;
    /// <summary>Flag indicating whether the luminance (min_ and max_) have been set.</summary>
    public int @has_luminance;
}

/// <summary>AVOption</summary>
public unsafe partial struct AVOption
{
    public byte* @name;
    /// <summary>short English help text</summary>
    public byte* @help;
    /// <summary>Native access only.</summary>
    public int @offset;
    public AVOptionType @type;
    public AVOption_default_val @default_val;
    /// <summary>minimum valid value for the option</summary>
    public double @min;
    /// <summary>maximum valid value for the option</summary>
    public double @max;
    /// <summary>A combination of AV_OPT_FLAG_*.</summary>
    public int @flags;
    /// <summary>The logical unit to which the option belongs. Non-constant options and corresponding named constants share the same unit. May be NULL.</summary>
    public byte* @unit;
}

/// <summary>Native access only, except when documented otherwise. the default value for scalar options</summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct AVOption_default_val
{
    [FieldOffset(0)]
    public long @i64;
    [FieldOffset(0)]
    public double @dbl;
    [FieldOffset(0)]
    public byte* @str;
    [FieldOffset(0)]
    public AVRational @q;
    /// <summary>Used for AV_OPT_TYPE_FLAG_ARRAY options. May be NULL.</summary>
    [FieldOffset(0)]
    public AVOptionArrayDef* @arr;
}

/// <summary>May be set as default_val for AV_OPT_TYPE_FLAG_ARRAY options.</summary>
public unsafe partial struct AVOptionArrayDef
{
    /// <summary>Native access only.</summary>
    public byte* @def;
    /// <summary>Minimum number of elements in the array. When this field is non-zero, def must be non-NULL and contain at least this number of elements.</summary>
    public uint @size_min;
    /// <summary>Maximum number of elements in the array, 0 when unlimited.</summary>
    public uint @size_max;
    /// <summary>Separator between array elements in string representations of this option, used by av_opt_set() and av_opt_get(). It must be a printable ASCII character, excluding alphanumeric and the backslash. A comma is used when sep=0.</summary>
    public byte @sep;
}

/// <summary>A single allowed range of values, or a single allowed value.</summary>
public unsafe partial struct AVOptionRange
{
    public byte* @str;
    /// <summary>Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case.</summary>
    public double @value_min;
    /// <summary>Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case.</summary>
    public double @value_max;
    /// <summary>Value&apos;s component range. For string this represents the unicode range for chars, 0-127 limits to ASCII.</summary>
    public double @component_min;
    /// <summary>Value&apos;s component range. For string this represents the unicode range for chars, 0-127 limits to ASCII.</summary>
    public double @component_max;
    /// <summary>Range flag. If set to 1 the struct encodes a range, if set to 0 a single value.</summary>
    public int @is_range;
}

/// <summary>List of AVOptionRange structs.</summary>
public unsafe partial struct AVOptionRanges
{
    /// <summary>Array of option ranges.</summary>
    public AVOptionRange** @range;
    /// <summary>Number of ranges per component.</summary>
    public int @nb_ranges;
    /// <summary>Number of componentes.</summary>
    public int @nb_components;
}

/// <summary>@{</summary>
public unsafe partial struct AVOutputFormat
{
    public byte* @name;
    /// <summary>Descriptive name for the format, meant to be more human-readable than name. You should use the NULL_IF_CONFIG_SMALL() macro to define it.</summary>
    public byte* @long_name;
    public byte* @mime_type;
    /// <summary>comma-separated filename extensions</summary>
    public byte* @extensions;
    /// <summary>default audio codec</summary>
    public AVCodecID @audio_codec;
    /// <summary>default video codec</summary>
    public AVCodecID @video_codec;
    /// <summary>default subtitle codec</summary>
    public AVCodecID @subtitle_codec;
    /// <summary>can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_GLOBALHEADER, AVFMT_NOTIMESTAMPS, AVFMT_VARIABLE_FPS, AVFMT_NODIMENSIONS, AVFMT_NOSTREAMS, AVFMT_TS_NONSTRICT, AVFMT_TS_NEGATIVE</summary>
    public int @flags;
    /// <summary>List of supported codec_id-codec_tag pairs, ordered by &quot;better choice first&quot;. The arrays are all terminated by AV_CODEC_ID_NONE.</summary>
    public AVCodecTag** @codec_tag;
    /// <summary>AVClass for the private context</summary>
    public AVClass* @priv_class;
}

/// <summary>This structure stores compressed data. It is typically exported by demuxers and then passed as input to decoders, or received as output from encoders and then passed to muxers.</summary>
public unsafe partial struct AVPacket
{
    /// <summary>A reference to the reference-counted buffer where the packet data is stored. May be NULL, then the packet data is not reference-counted.</summary>
    public AVBufferRef* @buf;
    /// <summary>Presentation timestamp in AVStream-&gt;time_base units; the time at which the decompressed packet will be presented to the user. Can be AV_NOPTS_VALUE if it is not stored in the file. pts MUST be larger or equal to dts as presentation cannot happen before decompression, unless one wants to view hex dumps. Some formats misuse the terms dts and pts/cts to mean something different. Such timestamps must be converted to true pts/dts before they are stored in AVPacket.</summary>
    public long @pts;
    /// <summary>Decompression timestamp in AVStream-&gt;time_base units; the time at which the packet is decompressed. Can be AV_NOPTS_VALUE if it is not stored in the file.</summary>
    public long @dts;
    public byte* @data;
    public int @size;
    public int @stream_index;
    /// <summary>A combination of AV_PKT_FLAG values</summary>
    public int @flags;
    /// <summary>Additional packet data that can be provided by the container. Packet can contain several types of side information.</summary>
    public AVPacketSideData* @side_data;
    public int @side_data_elems;
    /// <summary>Duration of this packet in AVStream-&gt;time_base units, 0 if unknown. Equals next_pts - this_pts in presentation order.</summary>
    public long @duration;
    /// <summary>byte position in stream, -1 if unknown</summary>
    public long @pos;
    /// <summary>for some private data of the user</summary>
    public void* @opaque;
    /// <summary>AVBufferRef for free use by the API user. FFmpeg will never check the contents of the buffer ref. FFmpeg calls av_buffer_unref() on it when the packet is unreferenced. av_packet_copy_props() calls create a new reference with av_buffer_ref() for the target packet&apos;s opaque_ref field.</summary>
    public AVBufferRef* @opaque_ref;
    /// <summary>Time base of the packet&apos;s timestamps. In the future, this field may be set on packets output by encoders or demuxers, but its value will be by default ignored on input to decoders or muxers.</summary>
    public AVRational @time_base;
}

public unsafe partial struct AVPacketList
{
    public AVPacket @pkt;
    public AVPacketList* @next;
}

/// <summary>This structure stores auxiliary information for decoding, presenting, or otherwise processing the coded stream. It is typically exported by demuxers and encoders and can be fed to decoders and muxers either in a per packet basis, or as global side data (applying to the entire coded stream).</summary>
public unsafe partial struct AVPacketSideData
{
    public byte* @data;
    public ulong @size;
    public AVPacketSideDataType @type;
}

/// <summary>Pan Scan area. This specifies the area which should be displayed. Note there may be multiple such areas for one frame.</summary>
public unsafe partial struct AVPanScan
{
    /// <summary>id - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public int @id;
    /// <summary>width and height in 1/16 pel - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public int @width;
    public int @height;
    /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public short_array3x2 @position;
}

/// <summary>Descriptor that unambiguously describes how the bits of a pixel are stored in the up to 4 data planes of an image. It also stores the subsampling factors and number of components.</summary>
public unsafe partial struct AVPixFmtDescriptor
{
    public byte* @name;
    /// <summary>The number of components each pixel has, (1-4)</summary>
    public byte @nb_components;
    /// <summary>Amount to shift the luma width right to find the chroma width. For YV12 this is 1 for example. chroma_width = AV_CEIL_RSHIFT(luma_width, log2_chroma_w) The note above is needed to ensure rounding up. This value only refers to the chroma components.</summary>
    public byte @log2_chroma_w;
    /// <summary>Amount to shift the luma height right to find the chroma height. For YV12 this is 1 for example. chroma_height= AV_CEIL_RSHIFT(luma_height, log2_chroma_h) The note above is needed to ensure rounding up. This value only refers to the chroma components.</summary>
    public byte @log2_chroma_h;
    /// <summary>Combination of AV_PIX_FMT_FLAG_... flags.</summary>
    public ulong @flags;
    /// <summary>Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.</summary>
    public AVComponentDescriptor_array4 @comp;
    /// <summary>Alternative comma-separated names.</summary>
    public byte* @alias;
}

/// <summary>This structure contains the data a format has to probe a file.</summary>
public unsafe partial struct AVProbeData
{
    public byte* @filename;
    /// <summary>Buffer must have AVPROBE_PADDING_SIZE of extra allocated bytes filled with zero.</summary>
    public byte* @buf;
    /// <summary>Size of buf except extra allocated bytes</summary>
    public int @buf_size;
    /// <summary>mime_type, when known.</summary>
    public byte* @mime_type;
}

/// <summary>This structure supplies correlation between a packet timestamp and a wall clock production time. The definition follows the Producer Reference Time (&apos;prft&apos;) as defined in ISO/IEC 14496-12</summary>
public unsafe partial struct AVProducerReferenceTime
{
    /// <summary>A UTC timestamp, in microseconds, since Unix epoch (e.g, av_gettime()).</summary>
    public long @wallclock;
    public int @flags;
}

/// <summary>AVProfile.</summary>
public unsafe partial struct AVProfile
{
    public int @profile;
    /// <summary>short name for the profile</summary>
    public byte* @name;
}

/// <summary>New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVProgram) must not be used outside libav*.</summary>
public unsafe partial struct AVProgram
{
    public int @id;
    public int @flags;
    /// <summary>selects which program to discard and which to feed to the caller</summary>
    public AVDiscard @discard;
    public uint* @stream_index;
    public uint @nb_stream_indexes;
    public AVDictionary* @metadata;
    public int @program_num;
    public int @pmt_pid;
    public int @pcr_pid;
    public int @pmt_version;
    /// <summary>*************************************************************** All fields below this line are not part of the public API. They may not be used outside of libavformat and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
    public long @start_time;
    public long @end_time;
    /// <summary>reference dts for wrap detection</summary>
    public long @pts_wrap_reference;
    /// <summary>behavior on wrap detection</summary>
    public int @pts_wrap_behavior;
}

/// <summary>Rational number (pair of numerator and denominator).</summary>
public unsafe partial struct AVRational
{
    /// <summary>Numerator</summary>
    public int @num;
    /// <summary>Denominator</summary>
    public int @den;
}

/// <summary>Structure describing a single Region Of Interest.</summary>
public unsafe partial struct AVRegionOfInterest
{
    /// <summary>Must be set to the size of this data structure (that is, sizeof(AVRegionOfInterest)).</summary>
    public uint @self_size;
    /// <summary>Distance in pixels from the top edge of the frame to the top and bottom edges and from the left edge of the frame to the left and right edges of the rectangle defining this region of interest.</summary>
    public int @top;
    public int @bottom;
    public int @left;
    public int @right;
    /// <summary>Quantisation offset.</summary>
    public AVRational @qoffset;
}

/// <summary>This struct describes the properties of a side data type. Its instance corresponding to a given type can be obtained from av_frame_side_data_desc().</summary>
public unsafe partial struct AVSideDataDescriptor
{
    /// <summary>Human-readable side data description.</summary>
    public byte* @name;
    /// <summary>Side data property flags, a combination of AVSideDataProps values.</summary>
    public uint @props;
}

/// <summary>Stream structure. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVStream) must not be used outside libav*.</summary>
public unsafe partial struct AVStream
{
    /// <summary>A class for avoptions. Set on stream creation.</summary>
    public AVClass* @av_class;
    /// <summary>stream index in AVFormatContext</summary>
    public int @index;
    /// <summary>Format-specific stream ID. decoding: set by libavformat encoding: set by the user, replaced by libavformat if left unset</summary>
    public int @id;
    /// <summary>Codec parameters associated with this stream. Allocated and freed by libavformat in avformat_new_stream() and avformat_free_context() respectively.</summary>
    public AVCodecParameters* @codecpar;
    public void* @priv_data;
    /// <summary>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented.</summary>
    public AVRational @time_base;
    /// <summary>Decoding: pts of the first frame of the stream in presentation order, in stream time base. Only set this if you are absolutely 100% sure that the value you set it to really is the pts of the first frame. This may be undefined (AV_NOPTS_VALUE).</summary>
    public long @start_time;
    /// <summary>Decoding: duration of the stream, in stream time base. If a source file does not specify a duration, but does specify a bitrate, this value will be estimated from bitrate and file size.</summary>
    public long @duration;
    /// <summary>number of frames in this stream if known or 0</summary>
    public long @nb_frames;
    /// <summary>Stream disposition - a combination of AV_DISPOSITION_* flags. - demuxing: set by libavformat when creating the stream or in avformat_find_stream_info(). - muxing: may be set by the caller before avformat_write_header().</summary>
    public int @disposition;
    /// <summary>Selects which packets can be discarded at will and do not need to be demuxed.</summary>
    public AVDiscard @discard;
    /// <summary>sample aspect ratio (0 if unknown) - encoding: Set by user. - decoding: Set by libavformat.</summary>
    public AVRational @sample_aspect_ratio;
    public AVDictionary* @metadata;
    /// <summary>Average framerate</summary>
    public AVRational @avg_frame_rate;
    /// <summary>For streams with AV_DISPOSITION_ATTACHED_PIC disposition, this packet will contain the attached picture.</summary>
    public AVPacket @attached_pic;
    /// <summary>An array of side data that applies to the whole stream (i.e. the container does not allow it to change between packets).</summary>
    [Obsolete("use AVStream's \"codecpar side data\".")]
    public AVPacketSideData* @side_data;
    /// <summary>The number of elements in the AVStream.side_data array.</summary>
    [Obsolete("use AVStream's \"codecpar side data\".")]
    public int @nb_side_data;
    /// <summary>Flags indicating events happening on the stream, a combination of AVSTREAM_EVENT_FLAG_*.</summary>
    public int @event_flags;
    /// <summary>Real base framerate of the stream. This is the lowest framerate with which all timestamps can be represented accurately (it is the least common multiple of all framerates in the stream). Note, this value is just a guess! For example, if the time base is 1/90000 and all frames have either approximately 3600 or 1800 timer ticks, then r_frame_rate will be 50/1.</summary>
    public AVRational @r_frame_rate;
    /// <summary>Number of bits in timestamps. Used for wrapping control.</summary>
    public int @pts_wrap_bits;
}

public unsafe partial struct AVStreamGroup
{
    /// <summary>A class for avoptions. Set by avformat_stream_group_create().</summary>
    public AVClass* @av_class;
    public void* @priv_data;
    /// <summary>Group index in AVFormatContext.</summary>
    public uint @index;
    /// <summary>Group type-specific group ID.</summary>
    public long @id;
    /// <summary>Group type</summary>
    public AVStreamGroupParamsType @type;
    public AVStreamGroup_params @params;
    /// <summary>Metadata that applies to the whole group.</summary>
    public AVDictionary* @metadata;
    /// <summary>Number of elements in AVStreamGroup.streams.</summary>
    public uint @nb_streams;
    /// <summary>A list of streams in the group. New entries are created with avformat_stream_group_add_stream().</summary>
    public AVStream** @streams;
    /// <summary>Stream group disposition - a combination of AV_DISPOSITION_* flags. This field currently applies to all defined AVStreamGroupParamsType.</summary>
    public int @disposition;
}

/// <summary>Group type-specific parameters</summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct AVStreamGroup_params
{
    [FieldOffset(0)]
    public AVIAMFAudioElement* @iamf_audio_element;
    [FieldOffset(0)]
    public AVIAMFMixPresentation* @iamf_mix_presentation;
    [FieldOffset(0)]
    public AVStreamGroupTileGrid* @tile_grid;
    [FieldOffset(0)]
    public AVStreamGroupLCEVC* @lcevc;
}

/// <summary>AVStreamGroupLCEVC is meant to define the relation between video streams and a data stream containing LCEVC enhancement layer NALUs.</summary>
public unsafe partial struct AVStreamGroupLCEVC
{
    public AVClass* @av_class;
    /// <summary>Index of the LCEVC data stream in AVStreamGroup.</summary>
    public uint @lcevc_index;
    /// <summary>Width of the final stream for presentation.</summary>
    public int @width;
    /// <summary>Height of the final image for presentation.</summary>
    public int @height;
}

/// <summary>AVStreamGroupTileGrid holds information on how to combine several independent images on a single canvas for presentation.</summary>
public unsafe partial struct AVStreamGroupTileGrid
{
    public AVClass* @av_class;
    /// <summary>Amount of tiles in the grid.</summary>
    public uint @nb_tiles;
    /// <summary>Width of the canvas.</summary>
    public int @coded_width;
    /// <summary>Width of the canvas.</summary>
    public int @coded_height;
    public AVStreamGroupTileGrid_offsets* @offsets;
    /// <summary>The pixel value per channel in RGBA format used if no pixel of any tile is located at a particular pixel location.</summary>
    public byte_array4 @background;
    /// <summary>Offset in pixels from the left edge of the canvas where the actual image meant for presentation starts.</summary>
    public int @horizontal_offset;
    /// <summary>Offset in pixels from the top edge of the canvas where the actual image meant for presentation starts.</summary>
    public int @vertical_offset;
    /// <summary>Width of the final image for presentation.</summary>
    public int @width;
    /// <summary>Height of the final image for presentation.</summary>
    public int @height;
}

/// <summary>An nb_tiles sized array of offsets in pixels from the topleft edge of the canvas, indicating where each stream should be placed. It must be allocated with the av_malloc() family of functions.</summary>
public unsafe partial struct AVStreamGroupTileGrid_offsets
{
    /// <summary>Index of the stream in the group this tile references.</summary>
    public uint @idx;
    /// <summary>Offset in pixels from the left edge of the canvas where the tile should be placed.</summary>
    public int @horizontal;
    /// <summary>Offset in pixels from the top edge of the canvas where the tile should be placed.</summary>
    public int @vertical;
}

public unsafe partial struct AVSubtitle
{
    public ushort @format;
    public uint @start_display_time;
    public uint @end_display_time;
    public uint @num_rects;
    public AVSubtitleRect** @rects;
    /// <summary>Same as packet pts, in AV_TIME_BASE</summary>
    public long @pts;
}

public unsafe partial struct AVSubtitleRect
{
    /// <summary>top left corner of pict, undefined when pict is not set</summary>
    public int @x;
    /// <summary>top left corner of pict, undefined when pict is not set</summary>
    public int @y;
    /// <summary>width of pict, undefined when pict is not set</summary>
    public int @w;
    /// <summary>height of pict, undefined when pict is not set</summary>
    public int @h;
    /// <summary>number of colors in pict, undefined when pict is not set</summary>
    public int @nb_colors;
    /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
    public byte_ptrArray4 @data;
    public int_array4 @linesize;
    public int @flags;
    public AVSubtitleType @type;
    /// <summary>0 terminated plain UTF-8 text</summary>
    public byte* @text;
    /// <summary>0 terminated ASS/SSA compatible event line. The presentation of this is unaffected by the other values in this struct.</summary>
    public byte* @ass;
}

public unsafe partial struct AVTimecode
{
    /// <summary>timecode frame start (first base frame number)</summary>
    public int @start;
    /// <summary>flags such as drop frame, +24 hours support, ...</summary>
    public uint @flags;
    /// <summary>frame rate in rational form</summary>
    public AVRational @rate;
    /// <summary>frame per second; must be consistent with the rate field</summary>
    public uint @fps;
}

public unsafe partial struct D3D11_VIDEO_DECODER_CONFIG
{
    public _GUID @guidConfigBitstreamEncryption;
    public _GUID @guidConfigMBcontrolEncryption;
    public _GUID @guidConfigResidDiffEncryption;
    public uint @ConfigBitstreamRaw;
    public uint @ConfigMBcontrolRasterOrder;
    public uint @ConfigResidDiffHost;
    public uint @ConfigSpatialResid8;
    public uint @ConfigResid8Subtraction;
    public uint @ConfigSpatialHost8or9Clipping;
    public uint @ConfigSpatialResidInterleaved;
    public uint @ConfigIntraResidUnsigned;
    public uint @ConfigResidDiffAccelerator;
    public uint @ConfigHostInverseScan;
    public uint @ConfigSpecificIDCT;
    public uint @Config4GroupedCoefs;
    public ushort @ConfigMinRenderTargetBuffCount;
    public ushort @ConfigDecoderSpecific;
}

public unsafe partial struct ID3D11Device
{
    public ID3D11DeviceVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11DeviceContext
{
    public ID3D11DeviceContextVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11DeviceContextVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @VSSetConstantBuffers;
    public void* @PSSetShaderResources;
    public void* @PSSetShader;
    public void* @PSSetSamplers;
    public void* @VSSetShader;
    public void* @DrawIndexed;
    public void* @Draw;
    public void* @Map;
    public void* @Unmap;
    public void* @PSSetConstantBuffers;
    public void* @IASetInputLayout;
    public void* @IASetVertexBuffers;
    public void* @IASetIndexBuffer;
    public void* @DrawIndexedInstanced;
    public void* @DrawInstanced;
    public void* @GSSetConstantBuffers;
    public void* @GSSetShader;
    public void* @IASetPrimitiveTopology;
    public void* @VSSetShaderResources;
    public void* @VSSetSamplers;
    public void* @Begin;
    public void* @End;
    public void* @GetData;
    public void* @SetPredication;
    public void* @GSSetShaderResources;
    public void* @GSSetSamplers;
    public void* @OMSetRenderTargets;
    public void* @OMSetRenderTargetsAndUnorderedAccessViews;
    public void* @OMSetBlendState;
    public void* @OMSetDepthStencilState;
    public void* @SOSetTargets;
    public void* @DrawAuto;
    public void* @DrawIndexedInstancedIndirect;
    public void* @DrawInstancedIndirect;
    public void* @Dispatch;
    public void* @DispatchIndirect;
    public void* @RSSetState;
    public void* @RSSetViewports;
    public void* @RSSetScissorRects;
    public void* @CopySubresourceRegion;
    public void* @CopyResource;
    public void* @UpdateSubresource;
    public void* @CopyStructureCount;
    public void* @ClearRenderTargetView;
    public void* @ClearUnorderedAccessViewUint;
    public void* @ClearUnorderedAccessViewFloat;
    public void* @ClearDepthStencilView;
    public void* @GenerateMips;
    public void* @SetResourceMinLOD;
    public void* @GetResourceMinLOD;
    public void* @ResolveSubresource;
    public void* @ExecuteCommandList;
    public void* @HSSetShaderResources;
    public void* @HSSetShader;
    public void* @HSSetSamplers;
    public void* @HSSetConstantBuffers;
    public void* @DSSetShaderResources;
    public void* @DSSetShader;
    public void* @DSSetSamplers;
    public void* @DSSetConstantBuffers;
    public void* @CSSetShaderResources;
    public void* @CSSetUnorderedAccessViews;
    public void* @CSSetShader;
    public void* @CSSetSamplers;
    public void* @CSSetConstantBuffers;
    public void* @VSGetConstantBuffers;
    public void* @PSGetShaderResources;
    public void* @PSGetShader;
    public void* @PSGetSamplers;
    public void* @VSGetShader;
    public void* @PSGetConstantBuffers;
    public void* @IAGetInputLayout;
    public void* @IAGetVertexBuffers;
    public void* @IAGetIndexBuffer;
    public void* @GSGetConstantBuffers;
    public void* @GSGetShader;
    public void* @IAGetPrimitiveTopology;
    public void* @VSGetShaderResources;
    public void* @VSGetSamplers;
    public void* @GetPredication;
    public void* @GSGetShaderResources;
    public void* @GSGetSamplers;
    public void* @OMGetRenderTargets;
    public void* @OMGetRenderTargetsAndUnorderedAccessViews;
    public void* @OMGetBlendState;
    public void* @OMGetDepthStencilState;
    public void* @SOGetTargets;
    public void* @RSGetState;
    public void* @RSGetViewports;
    public void* @RSGetScissorRects;
    public void* @HSGetShaderResources;
    public void* @HSGetShader;
    public void* @HSGetSamplers;
    public void* @HSGetConstantBuffers;
    public void* @DSGetShaderResources;
    public void* @DSGetShader;
    public void* @DSGetSamplers;
    public void* @DSGetConstantBuffers;
    public void* @CSGetShaderResources;
    public void* @CSGetUnorderedAccessViews;
    public void* @CSGetShader;
    public void* @CSGetSamplers;
    public void* @CSGetConstantBuffers;
    public void* @ClearState;
    public void* @Flush;
    public void* @GetType;
    public void* @GetContextFlags;
    public void* @FinishCommandList;
}

public unsafe partial struct ID3D11DeviceVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @CreateBuffer;
    public void* @CreateTexture1D;
    public void* @CreateTexture2D;
    public void* @CreateTexture3D;
    public void* @CreateShaderResourceView;
    public void* @CreateUnorderedAccessView;
    public void* @CreateRenderTargetView;
    public void* @CreateDepthStencilView;
    public void* @CreateInputLayout;
    public void* @CreateVertexShader;
    public void* @CreateGeometryShader;
    public void* @CreateGeometryShaderWithStreamOutput;
    public void* @CreatePixelShader;
    public void* @CreateHullShader;
    public void* @CreateDomainShader;
    public void* @CreateComputeShader;
    public void* @CreateClassLinkage;
    public void* @CreateBlendState;
    public void* @CreateDepthStencilState;
    public void* @CreateRasterizerState;
    public void* @CreateSamplerState;
    public void* @CreateQuery;
    public void* @CreatePredicate;
    public void* @CreateCounter;
    public void* @CreateDeferredContext;
    public void* @OpenSharedResource;
    public void* @CheckFormatSupport;
    public void* @CheckMultisampleQualityLevels;
    public void* @CheckCounterInfo;
    public void* @CheckCounter;
    public void* @CheckFeatureSupport;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @GetFeatureLevel;
    public void* @GetCreationFlags;
    public void* @GetDeviceRemovedReason;
    public void* @GetImmediateContext;
    public void* @SetExceptionMode;
    public void* @GetExceptionMode;
}

public unsafe partial struct ID3D11Texture2D
{
    public ID3D11Texture2DVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11Texture2DVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @GetType;
    public void* @SetEvictionPriority;
    public void* @GetEvictionPriority;
    public void* @GetDesc;
}

public unsafe partial struct ID3D11VideoContext
{
    public ID3D11VideoContextVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11VideoContextVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @GetDecoderBuffer;
    public void* @ReleaseDecoderBuffer;
    public void* @DecoderBeginFrame;
    public void* @DecoderEndFrame;
    public void* @SubmitDecoderBuffers;
    public void* @DecoderExtension;
    public void* @VideoProcessorSetOutputTargetRect;
    public void* @VideoProcessorSetOutputBackgroundColor;
    public void* @VideoProcessorSetOutputColorSpace;
    public void* @VideoProcessorSetOutputAlphaFillMode;
    public void* @VideoProcessorSetOutputConstriction;
    public void* @VideoProcessorSetOutputStereoMode;
    public void* @VideoProcessorSetOutputExtension;
    public void* @VideoProcessorGetOutputTargetRect;
    public void* @VideoProcessorGetOutputBackgroundColor;
    public void* @VideoProcessorGetOutputColorSpace;
    public void* @VideoProcessorGetOutputAlphaFillMode;
    public void* @VideoProcessorGetOutputConstriction;
    public void* @VideoProcessorGetOutputStereoMode;
    public void* @VideoProcessorGetOutputExtension;
    public void* @VideoProcessorSetStreamFrameFormat;
    public void* @VideoProcessorSetStreamColorSpace;
    public void* @VideoProcessorSetStreamOutputRate;
    public void* @VideoProcessorSetStreamSourceRect;
    public void* @VideoProcessorSetStreamDestRect;
    public void* @VideoProcessorSetStreamAlpha;
    public void* @VideoProcessorSetStreamPalette;
    public void* @VideoProcessorSetStreamPixelAspectRatio;
    public void* @VideoProcessorSetStreamLumaKey;
    public void* @VideoProcessorSetStreamStereoFormat;
    public void* @VideoProcessorSetStreamAutoProcessingMode;
    public void* @VideoProcessorSetStreamFilter;
    public void* @VideoProcessorSetStreamExtension;
    public void* @VideoProcessorGetStreamFrameFormat;
    public void* @VideoProcessorGetStreamColorSpace;
    public void* @VideoProcessorGetStreamOutputRate;
    public void* @VideoProcessorGetStreamSourceRect;
    public void* @VideoProcessorGetStreamDestRect;
    public void* @VideoProcessorGetStreamAlpha;
    public void* @VideoProcessorGetStreamPalette;
    public void* @VideoProcessorGetStreamPixelAspectRatio;
    public void* @VideoProcessorGetStreamLumaKey;
    public void* @VideoProcessorGetStreamStereoFormat;
    public void* @VideoProcessorGetStreamAutoProcessingMode;
    public void* @VideoProcessorGetStreamFilter;
    public void* @VideoProcessorGetStreamExtension;
    public void* @VideoProcessorBlt;
    public void* @NegotiateCryptoSessionKeyExchange;
    public void* @EncryptionBlt;
    public void* @DecryptionBlt;
    public void* @StartSessionKeyRefresh;
    public void* @FinishSessionKeyRefresh;
    public void* @GetEncryptionBltKey;
    public void* @NegotiateAuthenticatedChannelKeyExchange;
    public void* @QueryAuthenticatedChannel;
    public void* @ConfigureAuthenticatedChannel;
    public void* @VideoProcessorSetStreamRotation;
    public void* @VideoProcessorGetStreamRotation;
}

public unsafe partial struct ID3D11VideoDecoder
{
    public ID3D11VideoDecoderVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11VideoDecoderOutputView
{
    public ID3D11VideoDecoderOutputViewVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11VideoDecoderOutputViewVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @GetResource;
    public void* @GetDesc;
}

public unsafe partial struct ID3D11VideoDecoderVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @GetPrivateData;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
    public void* @GetCreationParameters;
    public void* @GetDriverHandle;
}

public unsafe partial struct ID3D11VideoDevice
{
    public ID3D11VideoDeviceVtbl* @lpVtbl;
}

public unsafe partial struct ID3D11VideoDeviceVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @CreateVideoDecoder;
    public void* @CreateVideoProcessor;
    public void* @CreateAuthenticatedChannel;
    public void* @CreateCryptoSession;
    public void* @CreateVideoDecoderOutputView;
    public void* @CreateVideoProcessorInputView;
    public void* @CreateVideoProcessorOutputView;
    public void* @CreateVideoProcessorEnumerator;
    public void* @GetVideoDecoderProfileCount;
    public void* @GetVideoDecoderProfile;
    public void* @CheckVideoDecoderFormat;
    public void* @GetVideoDecoderConfigCount;
    public void* @GetVideoDecoderConfig;
    public void* @GetContentProtectionCaps;
    public void* @CheckCryptoKeyExchange;
    public void* @SetPrivateData;
    public void* @SetPrivateDataInterface;
}

public unsafe partial struct IDirect3DDeviceManager9
{
    public IDirect3DDeviceManager9Vtbl* @lpVtbl;
}

public unsafe partial struct IDirect3DDeviceManager9Vtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @ResetDevice;
    public void* @OpenDeviceHandle;
    public void* @CloseDeviceHandle;
    public void* @TestDevice;
    public void* @LockDevice;
    public void* @UnlockDevice;
    public void* @GetVideoService;
}

public unsafe partial struct IDirect3DSurface9
{
    public IDirect3DSurface9Vtbl* @lpVtbl;
}

public unsafe partial struct IDirect3DSurface9Vtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetDevice;
    public void* @SetPrivateData;
    public void* @GetPrivateData;
    public void* @FreePrivateData;
    public void* @SetPriority;
    public void* @GetPriority;
    public void* @PreLoad;
    public void* @GetType;
    public void* @GetContainer;
    public void* @GetDesc;
    public void* @LockRect;
    public void* @UnlockRect;
    public void* @GetDC;
    public void* @ReleaseDC;
}

public unsafe partial struct IDirectXVideoDecoder
{
    public IDirectXVideoDecoderVtbl* @lpVtbl;
}

public unsafe partial struct IDirectXVideoDecoderVtbl
{
    public void* @QueryInterface;
    public void* @AddRef;
    public void* @Release;
    public void* @GetVideoDecoderService;
    public void* @GetCreationParameters;
    public void* @GetBuffer;
    public void* @ReleaseBuffer;
    public void* @BeginFrame;
    public void* @EndFrame;
    public void* @Execute;
}

public unsafe partial struct RcOverride
{
    public int @start_frame;
    public int @end_frame;
    public int @qscale;
    public float @quality_factor;
}

public unsafe partial struct SwsFilter
{
    public SwsVector* @lumH;
    public SwsVector* @lumV;
    public SwsVector* @chrH;
    public SwsVector* @chrV;
}

public unsafe partial struct SwsVector
{
    /// <summary>pointer to the list of coefficients</summary>
    public double* @coeff;
    /// <summary>number of coefficients in the vector</summary>
    public int @length;
}

/// <summary>Context for an Audio FIFO Buffer.</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVAudioFifo
{
}

/// <summary>@}</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVBPrint
{
}

/// <summary>Structure for chain/list of bitstream filters. Empty list can be allocated by av_bsf_list_alloc().</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVBSFList
{
}

/// <summary>A reference counted buffer type. It is opaque and is meant to be used through references (AVBufferRef).</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVBuffer
{
}

/// <summary>The buffer pool. This structure is opaque and not meant to be accessed directly. It is allocated with av_buffer_pool_init() and freed with av_buffer_pool_uninit().</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVBufferPool
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVCodecInternal
{
}

/// <summary>**********************************************</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVCodecTag
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVDictionary
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVFilterChannelLayouts
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVFilterCommand
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVFilterFormats
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVFilterPad
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVIAMFAudioElement
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVIAMFMixPresentation
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVIODirContext
{
}

/// <summary>Low-complexity tree container</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct AVTreeNode
{
}

/// <summary>The libswresample context. Unlike libavcodec and libavformat, this structure is opaque. This means that if you would like to set options, you must use the avoptions API and cannot directly set values to members of the structure.</summary>
/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct SwrContext
{
}

/// <remarks>This struct is incomplete.</remarks>
public unsafe partial struct SwsContext
{
}

