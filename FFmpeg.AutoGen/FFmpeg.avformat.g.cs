using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_header (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_packet (IntPtr @p0, AVPacket* @pkt);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_trailer (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_interleave_packet (IntPtr @p0, AVPacket* @out, AVPacket* @in, int @flush);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_query_codec (AVCodecID @id, int @std_compliance);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVOutputFormat_get_output_timestamp (IntPtr @s, int @stream, long* @dts, long* @wall);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_control_message (IntPtr @s, int @type, void* @data, ulong @data_size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_uncoded_frame (IntPtr @p0, int @stream_index, AVFrame** @frame, uint @flags);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_get_device_list (IntPtr @s, IntPtr @device_list);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_create_device_capabilities (IntPtr @s, IntPtr @caps);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_free_device_capabilities (IntPtr @s, IntPtr @caps);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_init (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVOutputFormat_deinit (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_check_bitstream (IntPtr @p0, AVPacket* @pkt);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_probe (AVProbeData* @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_header (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_packet (IntPtr @p0, AVPacket* @pkt);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_close (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_seek (IntPtr @p0, int @stream_index, long @timestamp, int @flags);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVInputFormat_read_timestamp (IntPtr @s, int @stream_index, long* @pos, long @pos_limit);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_play (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_pause (IntPtr @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_seek2 (IntPtr @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_get_device_list (IntPtr @s, IntPtr @device_list);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_create_device_capabilities (IntPtr @s, IntPtr @caps);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_free_device_capabilities (IntPtr @s, IntPtr @caps);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFormatContext_open_cb (IntPtr @s, AVIOContext** @p, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFormatContext_io_open (IntPtr @s, AVIOContext** @pb, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags, AVDictionary** @options);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVFormatContext_io_close (IntPtr @s, AVIOContext* @pb);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOInterruptCB_callback (void* @p0);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_read_packet (void* @opaque, byte* @buf, int @buf_size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_write_packet (void* @opaque, byte* @buf, int @buf_size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVIOContext_seek (void* @opaque, long @offset, int @whence);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ulong AVIOContext_update_checksum (ulong @checksum, byte* @buf, uint @size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_read_pause (void* @opaque, int @pause);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVIOContext_read_seek (void* @opaque, int @stream_index, long @timestamp, int @flags);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_write_data_type (void* @opaque, byte* @buf, int @buf_size, AVIODataMarkerType @type, long @time);
    
    /// <summary>@}</summary>
    public enum AVStreamParseType : int
    {
        @AVSTREAM_PARSE_NONE = 0,
        /// <summary>full parsing and repack</summary>
        @AVSTREAM_PARSE_FULL = 1,
        /// <summary>Only parse headers, do not repack.</summary>
        @AVSTREAM_PARSE_HEADERS = 2,
        /// <summary>full parsing and interpolation of timestamps for frames not starting on a packet boundary</summary>
        @AVSTREAM_PARSE_TIMESTAMPS = 3,
        /// <summary>full parsing and repack of the first frame only, only implemented for H.264 currently</summary>
        @AVSTREAM_PARSE_FULL_ONCE = 4,
        /// <summary>full parsing and repack with timestamp and position generation by parser for raw this assumes that each packet in the file contains no demuxer level headers and just codec level data, otherwise position generation would fail</summary>
        @AVSTREAM_PARSE_FULL_RAW = 1463898624,
    }
    
    /// <summary>The duration of a video can be estimated through various ways, and this enum can be used to know how the duration was estimated.</summary>
    public enum AVDurationEstimationMethod : int
    {
        /// <summary>Duration accurately estimated from PTSes</summary>
        @AVFMT_DURATION_FROM_PTS = 0,
        /// <summary>Duration estimated from a stream with a known duration</summary>
        @AVFMT_DURATION_FROM_STREAM = 1,
        /// <summary>Duration estimated from bitrate (less accurate)</summary>
        @AVFMT_DURATION_FROM_BITRATE = 2,
    }
    
    public enum AVTimebaseSource : int
    {
        @AVFMT_TBCF_AUTO = -1,
        @AVFMT_TBCF_DECODER = 0,
        @AVFMT_TBCF_DEMUXER = 1,
        @AVFMT_TBCF_R_FRAMERATE = 2,
    }
    
    /// <summary>Directory entry types.</summary>
    public enum AVIODirEntryType : int
    {
        @AVIO_ENTRY_UNKNOWN = 0,
        @AVIO_ENTRY_BLOCK_DEVICE = 1,
        @AVIO_ENTRY_CHARACTER_DEVICE = 2,
        @AVIO_ENTRY_DIRECTORY = 3,
        @AVIO_ENTRY_NAMED_PIPE = 4,
        @AVIO_ENTRY_SYMBOLIC_LINK = 5,
        @AVIO_ENTRY_SOCKET = 6,
        @AVIO_ENTRY_FILE = 7,
        @AVIO_ENTRY_SERVER = 8,
        @AVIO_ENTRY_SHARE = 9,
        @AVIO_ENTRY_WORKGROUP = 10,
    }
    
    /// <summary>Different data types that can be returned via the AVIO write_data_type callback.</summary>
    public enum AVIODataMarkerType : int
    {
        /// <summary>Header data; this needs to be present for the stream to be decodeable.</summary>
        @AVIO_DATA_MARKER_HEADER = 0,
        /// <summary>A point in the output bytestream where a decoder can start decoding (i.e. a keyframe). A demuxer/decoder given the data flagged with AVIO_DATA_MARKER_HEADER, followed by any AVIO_DATA_MARKER_SYNC_POINT, should give decodeable results.</summary>
        @AVIO_DATA_MARKER_SYNC_POINT = 1,
        /// <summary>A point in the output bytestream where a demuxer can start parsing (for non self synchronizing bytestream formats). That is, any non-keyframe packet start point.</summary>
        @AVIO_DATA_MARKER_BOUNDARY_POINT = 2,
        /// <summary>This is any, unlabelled data. It can either be a muxer not marking any positions at all, it can be an actual boundary/sync point that the muxer chooses not to mark, or a later part of a packet/fragment that is cut into multiple write callbacks due to limited IO buffer size.</summary>
        @AVIO_DATA_MARKER_UNKNOWN = 3,
        /// <summary>Trailer data, which doesn't contain actual content, but only for finalizing the output file.</summary>
        @AVIO_DATA_MARKER_TRAILER = 4,
    }
    
    /// <summary>This structure contains the data a format has to probe a file.</summary>
    public unsafe struct AVProbeData
    {
        public byte* @filename;
        /// <summary>Buffer must have AVPROBE_PADDING_SIZE of extra allocated bytes filled with zero.</summary>
        public byte* @buf;
        /// <summary>Size of buf except extra allocated bytes</summary>
        public int @buf_size;
        /// <summary>mime_type, when known.</summary>
        public byte* @mime_type;
    }
    
    public unsafe struct AVIndexEntry
    {
        public long @pos;
        /// <summary>Timestamp in AVStream.time_base units, preferably the time from which on correctly decoded frames are available when seeking to this entry. That means preferable PTS on keyframe based formats. But demuxers can choose to store a different timestamp, if it is more convenient for the implementation or nothing better is known</summary>
        public long @timestamp;
        /// <summary>Minimum distance between this and the previous keyframe, used to avoid unneeded searching.</summary>
        public int @min_distance;
    }
    
    public unsafe struct AVStreamInternal
    {
    }
    
    public unsafe struct long_array17
    {
        public long @at0; public long @at1; public long @at2; public long @at3; public long @at4; public long @at5; public long @at6; public long @at7; public long @at8; public long @at9; public long @at10; public long @at11; public long @at12; public long @at13; public long @at14; public long @at15; public long @at16;
        
        public long this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; case 5: return at5; case 6: return at6; case 7: return at7; case 8: return at8; case 9: return at9; case 10: return at10; case 11: return at11; case 12: return at12; case 13: return at13; case 14: return at14; case 15: return at15; case 16: return at16; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; case 5: at5 = value; return; case 6: at6 = value; return; case 7: at7 = value; return; case 8: at8 = value; return; case 9: at9 = value; return; case 10: at10 = value; return; case 11: at11 = value; return; case 12: at12 = value; return; case 13: at13 = value; return; case 14: at14 = value; return; case 15: at15 = value; return; case 16: at16 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public long[] ToArray() => new[] {at0, at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at11, at12, at13, at14, at15, at16};
    }
    
    public unsafe struct byte_array17
    {
        public byte @at0; public byte @at1; public byte @at2; public byte @at3; public byte @at4; public byte @at5; public byte @at6; public byte @at7; public byte @at8; public byte @at9; public byte @at10; public byte @at11; public byte @at12; public byte @at13; public byte @at14; public byte @at15; public byte @at16;
        
        public byte this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; case 5: return at5; case 6: return at6; case 7: return at7; case 8: return at8; case 9: return at9; case 10: return at10; case 11: return at11; case 12: return at12; case 13: return at13; case 14: return at14; case 15: return at15; case 16: return at16; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; case 5: at5 = value; return; case 6: at6 = value; return; case 7: at7 = value; return; case 8: at8 = value; return; case 9: at9 = value; return; case 10: at10 = value; return; case 11: at11 = value; return; case 12: at12 = value; return; case 13: at13 = value; return; case 14: at14 = value; return; case 15: at15 = value; return; case 16: at16 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public byte[] ToArray() => new[] {at0, at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at11, at12, at13, at14, at15, at16};
    }
    
    /// <summary>Stream structure. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVStream) must not be used outside libav*.</summary>
    public unsafe struct AVStream
    {
        /// <summary>stream index in AVFormatContext</summary>
        public int @index;
        /// <summary>Format-specific stream ID. decoding: set by libavformat encoding: set by the user, replaced by libavformat if left unset</summary>
        public int @id;
        public AVCodecContext* @codec;
        public void* @priv_data;
        public AVFrac @pts;
        /// <summary>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented.</summary>
        public AVRational @time_base;
        /// <summary>Decoding: pts of the first frame of the stream in presentation order, in stream time base. Only set this if you are absolutely 100% sure that the value you set it to really is the pts of the first frame. This may be undefined (AV_NOPTS_VALUE).</summary>
        public long @start_time;
        /// <summary>Decoding: duration of the stream, in stream time base. If a source file does not specify a duration, but does specify a bitrate, this value will be estimated from bitrate and file size.</summary>
        public long @duration;
        /// <summary>number of frames in this stream if known or 0</summary>
        public long @nb_frames;
        /// <summary>AV_DISPOSITION_* bit field</summary>
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
        public AVPacketSideData* @side_data;
        /// <summary>The number of elements in the AVStream.side_data array.</summary>
        public int @nb_side_data;
        /// <summary>Flags for the user to detect events happening on the stream. Flags must be cleared by the user once the event has been handled. A combination of AVSTREAM_EVENT_FLAG_*.</summary>
        public int @event_flags;
        public IntPtr @info;
        /// <summary>number of bits in pts (used for wrapping control)</summary>
        public int @pts_wrap_bits;
        /// <summary>Timestamp corresponding to the last dts sync point.</summary>
        public long @first_dts;
        public long @cur_dts;
        public long @last_IP_pts;
        public int @last_IP_duration;
        /// <summary>Number of packets to buffer for codec probing</summary>
        public int @probe_packets;
        /// <summary>Number of frames that have been demuxed during av_find_stream_info()</summary>
        public int @codec_info_nb_frames;
        public AVStreamParseType @need_parsing;
        public IntPtr @parser;
        /// <summary>last packet in packet_buffer for this stream when muxing.</summary>
        public IntPtr @last_in_packet_buffer;
        public AVProbeData @probe_data;
        public long_array17 @pts_buffer;
        /// <summary>Only used if the format does not support seeking natively.</summary>
        public AVIndexEntry* @index_entries;
        public int @nb_index_entries;
        public uint @index_entries_allocated_size;
        /// <summary>Real base framerate of the stream. This is the lowest framerate with which all timestamps can be represented accurately (it is the least common multiple of all framerates in the stream). Note, this value is just a guess! For example, if the time base is 1/90000 and all frames have either approximately 3600 or 1800 timer ticks, then r_frame_rate will be 50/1.</summary>
        public AVRational @r_frame_rate;
        /// <summary>Stream Identifier This is the MPEG-TS stream identifier +1 0 means unknown</summary>
        public int @stream_identifier;
        public long @interleaver_chunk_size;
        public long @interleaver_chunk_duration;
        /// <summary>stream probing state -1 -> probing finished 0 -> no probing requested rest -> perform probing with request_probe being the minimum score to accept. NOT PART OF PUBLIC API</summary>
        public int @request_probe;
        /// <summary>Indicates that everything up to the next keyframe should be discarded.</summary>
        public int @skip_to_keyframe;
        /// <summary>Number of samples to skip at the start of the frame decoded from the next packet.</summary>
        public int @skip_samples;
        /// <summary>If not 0, the number of samples that should be skipped from the start of the stream (the samples are removed from packets with pts==0, which also assumes negative timestamps do not happen). Intended for use with formats such as mp3 with ad-hoc gapless audio support.</summary>
        public long @start_skip_samples;
        /// <summary>If not 0, the first audio sample that should be discarded from the stream. This is broken by design (needs global sample count), but can't be avoided for broken by design formats such as mp3 with ad-hoc gapless audio support.</summary>
        public long @first_discard_sample;
        /// <summary>The sample after last sample that is intended to be discarded after first_discard_sample. Works on frame boundaries only. Used to prevent early EOF if the gapless info is broken (considered concatenated mp3s).</summary>
        public long @last_discard_sample;
        /// <summary>Number of internally decoded frames, used internally in libavformat, do not access its lifetime differs from info which is why it is not in that structure.</summary>
        public int @nb_decoded_frames;
        /// <summary>Timestamp offset added to timestamps before muxing NOT PART OF PUBLIC API</summary>
        public long @mux_ts_offset;
        /// <summary>Internal data to check for wrapping of the time stamp</summary>
        public long @pts_wrap_reference;
        /// <summary>Options for behavior, when a wrap is detected.</summary>
        public int @pts_wrap_behavior;
        /// <summary>Internal data to prevent doing update_initial_durations() twice</summary>
        public int @update_initial_durations_done;
        /// <summary>Internal data to generate dts from pts</summary>
        public long_array17 @pts_reorder_error;
        public byte_array17 @pts_reorder_error_count;
        /// <summary>Internal data to analyze DTS and detect faulty mpeg streams</summary>
        public long @last_dts_for_order_check;
        public byte @dts_ordered;
        public byte @dts_misordered;
        /// <summary>Internal data to inject global side data</summary>
        public int @inject_global_side_data;
        /// <summary>String containing paris of key and values describing recommended encoder configuration. Paris are separated by ','. Keys are separated from values by '='.</summary>
        public byte* @recommended_encoder_configuration;
        /// <summary>display aspect ratio (0 if unknown) - encoding: unused - decoding: Set by libavformat to calculate sample_aspect_ratio internally</summary>
        public AVRational @display_aspect_ratio;
        public IntPtr @priv_pts;
        /// <summary>An opaque field for libavformat internal usage. Must not be accessed in any way by callers.</summary>
        public AVStreamInternal* @internal;
        public AVCodecParameters* @codecpar;
    }
    
    /// <summary>New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVProgram) must not be used outside libav*.</summary>
    public unsafe struct AVProgram
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
        /// <summary>*************************************************************** All fields below this line are not part of the public API. They may not be used outside of libavformat and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public long @start_time;
        public long @end_time;
        /// <summary>reference dts for wrap detection</summary>
        public long @pts_wrap_reference;
        /// <summary>behavior on wrap detection</summary>
        public int @pts_wrap_behavior;
    }
    
    public unsafe struct AVChapter
    {
        /// <summary>unique ID to identify the chapter</summary>
        public int @id;
        /// <summary>time base in which the start/end timestamps are specified</summary>
        public AVRational @time_base;
        /// <summary>chapter start/end time in time_base units</summary>
        public long @start;
        /// <summary>chapter start/end time in time_base units</summary>
        public long @end;
        public AVDictionary* @metadata;
    }
    
    public unsafe struct AVFormatInternal
    {
    }
    
    /// <summary>The exact value of the fractional number is: 'val + num / den'. num is assumed to be 0 <= num < den.</summary>
    public unsafe struct AVFrac
    {
        public long @val;
        public long @num;
        public long @den;
    }
    
    public unsafe struct AVOutputFormat_write_header_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_write_header_wrapper(AVOutputFormat_write_header func) => new AVOutputFormat_write_header_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_write_packet_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_write_packet_wrapper(AVOutputFormat_write_packet func) => new AVOutputFormat_write_packet_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_write_trailer_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_write_trailer_wrapper(AVOutputFormat_write_trailer func) => new AVOutputFormat_write_trailer_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_interleave_packet_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_interleave_packet_wrapper(AVOutputFormat_interleave_packet func) => new AVOutputFormat_interleave_packet_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_query_codec_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_query_codec_wrapper(AVOutputFormat_query_codec func) => new AVOutputFormat_query_codec_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_get_output_timestamp_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_get_output_timestamp_wrapper(AVOutputFormat_get_output_timestamp func) => new AVOutputFormat_get_output_timestamp_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_control_message_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_control_message_wrapper(AVOutputFormat_control_message func) => new AVOutputFormat_control_message_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_write_uncoded_frame_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_write_uncoded_frame_wrapper(AVOutputFormat_write_uncoded_frame func) => new AVOutputFormat_write_uncoded_frame_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_get_device_list_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_get_device_list_wrapper(AVOutputFormat_get_device_list func) => new AVOutputFormat_get_device_list_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_create_device_capabilities_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_create_device_capabilities_wrapper(AVOutputFormat_create_device_capabilities func) => new AVOutputFormat_create_device_capabilities_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_free_device_capabilities_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_free_device_capabilities_wrapper(AVOutputFormat_free_device_capabilities func) => new AVOutputFormat_free_device_capabilities_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_init_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_init_wrapper(AVOutputFormat_init func) => new AVOutputFormat_init_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_deinit_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_deinit_wrapper(AVOutputFormat_deinit func) => new AVOutputFormat_deinit_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVOutputFormat_check_bitstream_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVOutputFormat_check_bitstream_wrapper(AVOutputFormat_check_bitstream func) => new AVOutputFormat_check_bitstream_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    /// <summary>@{</summary>
    public unsafe struct AVOutputFormat
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
        /// <summary>can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_GLOBALHEADER, AVFMT_NOTIMESTAMPS, AVFMT_VARIABLE_FPS, AVFMT_NODIMENSIONS, AVFMT_NOSTREAMS, AVFMT_ALLOW_FLUSH, AVFMT_TS_NONSTRICT, AVFMT_TS_NEGATIVE</summary>
        public int @flags;
        /// <summary>List of supported codec_id-codec_tag pairs, ordered by "better choice first". The arrays are all terminated by AV_CODEC_ID_NONE.</summary>
        public IntPtr* @codec_tag;
        /// <summary>AVClass for the private context</summary>
        public AVClass* @priv_class;
        /// <summary>*************************************************************** No fields below this line are part of the public API. They may not be used outside of libavformat and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public IntPtr @next;
        /// <summary>size of private data so that it can be allocated in the wrapper</summary>
        public int @priv_data_size;
        public AVOutputFormat_write_header_wrapper @write_header;
        /// <summary>Write a packet. If AVFMT_ALLOW_FLUSH is set in flags, pkt can be NULL in order to flush data buffered in the muxer. When flushing, return 0 if there still is more data to flush, or 1 if everything was flushed and there is no more buffered data.</summary>
        public AVOutputFormat_write_packet_wrapper @write_packet;
        public AVOutputFormat_write_trailer_wrapper @write_trailer;
        /// <summary>Currently only used to set pixel format if not YUV420P.</summary>
        public AVOutputFormat_interleave_packet_wrapper @interleave_packet;
        /// <summary>Test if the given codec can be stored in this container.</summary>
        public AVOutputFormat_query_codec_wrapper @query_codec;
        public AVOutputFormat_get_output_timestamp_wrapper @get_output_timestamp;
        /// <summary>Allows sending messages from application to device.</summary>
        public AVOutputFormat_control_message_wrapper @control_message;
        /// <summary>Write an uncoded AVFrame.</summary>
        public AVOutputFormat_write_uncoded_frame_wrapper @write_uncoded_frame;
        /// <summary>Returns device list with it properties.</summary>
        public AVOutputFormat_get_device_list_wrapper @get_device_list;
        /// <summary>Initialize device capabilities submodule.</summary>
        public AVOutputFormat_create_device_capabilities_wrapper @create_device_capabilities;
        /// <summary>Free device capabilities submodule.</summary>
        public AVOutputFormat_free_device_capabilities_wrapper @free_device_capabilities;
        /// <summary>default data codec</summary>
        public AVCodecID @data_codec;
        /// <summary>Initialize format. May allocate data here, and set any AVFormatContext or AVStream parameters that need to be set before packets are sent. This method must not write output.</summary>
        public AVOutputFormat_init_wrapper @init;
        /// <summary>Deinitialize format. If present, this is called whenever the muxer is being destroyed, regardless of whether or not the header has been written.</summary>
        public AVOutputFormat_deinit_wrapper @deinit;
        /// <summary>Set up any necessary bitstream filtering and extract any extra data needed for the global header. Return 0 if more packets from this stream must be checked; 1 if not.</summary>
        public AVOutputFormat_check_bitstream_wrapper @check_bitstream;
    }
    
    public unsafe struct AVInputFormat_read_probe_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_probe_wrapper(AVInputFormat_read_probe func) => new AVInputFormat_read_probe_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_header_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_header_wrapper(AVInputFormat_read_header func) => new AVInputFormat_read_header_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_packet_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_packet_wrapper(AVInputFormat_read_packet func) => new AVInputFormat_read_packet_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_close_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_close_wrapper(AVInputFormat_read_close func) => new AVInputFormat_read_close_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_seek_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_seek_wrapper(AVInputFormat_read_seek func) => new AVInputFormat_read_seek_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_timestamp_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_timestamp_wrapper(AVInputFormat_read_timestamp func) => new AVInputFormat_read_timestamp_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_play_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_play_wrapper(AVInputFormat_read_play func) => new AVInputFormat_read_play_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_pause_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_pause_wrapper(AVInputFormat_read_pause func) => new AVInputFormat_read_pause_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_read_seek2_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_read_seek2_wrapper(AVInputFormat_read_seek2 func) => new AVInputFormat_read_seek2_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_get_device_list_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_get_device_list_wrapper(AVInputFormat_get_device_list func) => new AVInputFormat_get_device_list_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_create_device_capabilities_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_create_device_capabilities_wrapper(AVInputFormat_create_device_capabilities func) => new AVInputFormat_create_device_capabilities_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVInputFormat_free_device_capabilities_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVInputFormat_free_device_capabilities_wrapper(AVInputFormat_free_device_capabilities func) => new AVInputFormat_free_device_capabilities_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    /// <summary>@{</summary>
    public unsafe struct AVInputFormat
    {
        /// <summary>A comma separated list of short names for the format. New names may be appended with a minor bump.</summary>
        public byte* @name;
        /// <summary>Descriptive name for the format, meant to be more human-readable than name. You should use the NULL_IF_CONFIG_SMALL() macro to define it.</summary>
        public byte* @long_name;
        /// <summary>Can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_SHOW_IDS, AVFMT_GENERIC_INDEX, AVFMT_TS_DISCONT, AVFMT_NOBINSEARCH, AVFMT_NOGENSEARCH, AVFMT_NO_BYTE_SEEK, AVFMT_SEEK_TO_PTS.</summary>
        public int @flags;
        /// <summary>If extensions are defined, then no probe is done. You should usually not use extension format guessing because it is not reliable enough</summary>
        public byte* @extensions;
        public IntPtr* @codec_tag;
        /// <summary>AVClass for the private context</summary>
        public AVClass* @priv_class;
        /// <summary>Comma-separated list of mime types. It is used check for matching mime types while probing.</summary>
        public byte* @mime_type;
        /// <summary>*************************************************************** No fields below this line are part of the public API. They may not be used outside of libavformat and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public IntPtr @next;
        /// <summary>Raw demuxers store their codec ID here.</summary>
        public int @raw_codec_id;
        /// <summary>Size of private data so that it can be allocated in the wrapper.</summary>
        public int @priv_data_size;
        /// <summary>Tell if a given file has a chance of being parsed as this format. The buffer provided is guaranteed to be AVPROBE_PADDING_SIZE bytes big so you do not have to check for that unless you need more.</summary>
        public AVInputFormat_read_probe_wrapper @read_probe;
        /// <summary>Read the format header and initialize the AVFormatContext structure. Return 0 if OK. 'avformat_new_stream' should be called to create new streams.</summary>
        public AVInputFormat_read_header_wrapper @read_header;
        /// <summary>Read one packet and put it in 'pkt'. pts and flags are also set. 'avformat_new_stream' can be called only if the flag AVFMTCTX_NOHEADER is used and only in the calling thread (not in a background thread).</summary>
        public AVInputFormat_read_packet_wrapper @read_packet;
        /// <summary>Close the stream. The AVFormatContext and AVStreams are not freed by this function</summary>
        public AVInputFormat_read_close_wrapper @read_close;
        /// <summary>Seek to a given timestamp relative to the frames in stream component stream_index.</summary>
        public AVInputFormat_read_seek_wrapper @read_seek;
        /// <summary>Get the next timestamp in stream[stream_index].time_base units.</summary>
        public AVInputFormat_read_timestamp_wrapper @read_timestamp;
        /// <summary>Start/resume playing - only meaningful if using a network-based format (RTSP).</summary>
        public AVInputFormat_read_play_wrapper @read_play;
        /// <summary>Pause playing - only meaningful if using a network-based format (RTSP).</summary>
        public AVInputFormat_read_pause_wrapper @read_pause;
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard < AVDISCARD_ALL.</summary>
        public AVInputFormat_read_seek2_wrapper @read_seek2;
        /// <summary>Returns device list with it properties.</summary>
        public AVInputFormat_get_device_list_wrapper @get_device_list;
        /// <summary>Initialize device capabilities submodule.</summary>
        public AVInputFormat_create_device_capabilities_wrapper @create_device_capabilities;
        /// <summary>Free device capabilities submodule.</summary>
        public AVInputFormat_free_device_capabilities_wrapper @free_device_capabilities;
    }
    
    /// <summary>input or output filename</summary>
    public unsafe struct byte_array1024
    {
        public byte @at0; public byte @at1; public byte @at2; public byte @at3; public byte @at4; public byte @at5; public byte @at6; public byte @at7; public byte @at8; public byte @at9; public byte @at10; public byte @at11; public byte @at12; public byte @at13; public byte @at14; public byte @at15; public byte @at16; public byte @at17; public byte @at18; public byte @at19; public byte @at20; public byte @at21; public byte @at22; public byte @at23; public byte @at24; public byte @at25; public byte @at26; public byte @at27; public byte @at28; public byte @at29; public byte @at30; public byte @at31; public byte @at32; public byte @at33; public byte @at34; public byte @at35; public byte @at36; public byte @at37; public byte @at38; public byte @at39; public byte @at40; public byte @at41; public byte @at42; public byte @at43; public byte @at44; public byte @at45; public byte @at46; public byte @at47; public byte @at48; public byte @at49; public byte @at50; public byte @at51; public byte @at52; public byte @at53; public byte @at54; public byte @at55; public byte @at56; public byte @at57; public byte @at58; public byte @at59; public byte @at60; public byte @at61; public byte @at62; public byte @at63; public byte @at64; public byte @at65; public byte @at66; public byte @at67; public byte @at68; public byte @at69; public byte @at70; public byte @at71; public byte @at72; public byte @at73; public byte @at74; public byte @at75; public byte @at76; public byte @at77; public byte @at78; public byte @at79; public byte @at80; public byte @at81; public byte @at82; public byte @at83; public byte @at84; public byte @at85; public byte @at86; public byte @at87; public byte @at88; public byte @at89; public byte @at90; public byte @at91; public byte @at92; public byte @at93; public byte @at94; public byte @at95; public byte @at96; public byte @at97; public byte @at98; public byte @at99; public byte @at100; public byte @at101; public byte @at102; public byte @at103; public byte @at104; public byte @at105; public byte @at106; public byte @at107; public byte @at108; public byte @at109; public byte @at110; public byte @at111; public byte @at112; public byte @at113; public byte @at114; public byte @at115; public byte @at116; public byte @at117; public byte @at118; public byte @at119; public byte @at120; public byte @at121; public byte @at122; public byte @at123; public byte @at124; public byte @at125; public byte @at126; public byte @at127; public byte @at128; public byte @at129; public byte @at130; public byte @at131; public byte @at132; public byte @at133; public byte @at134; public byte @at135; public byte @at136; public byte @at137; public byte @at138; public byte @at139; public byte @at140; public byte @at141; public byte @at142; public byte @at143; public byte @at144; public byte @at145; public byte @at146; public byte @at147; public byte @at148; public byte @at149; public byte @at150; public byte @at151; public byte @at152; public byte @at153; public byte @at154; public byte @at155; public byte @at156; public byte @at157; public byte @at158; public byte @at159; public byte @at160; public byte @at161; public byte @at162; public byte @at163; public byte @at164; public byte @at165; public byte @at166; public byte @at167; public byte @at168; public byte @at169; public byte @at170; public byte @at171; public byte @at172; public byte @at173; public byte @at174; public byte @at175; public byte @at176; public byte @at177; public byte @at178; public byte @at179; public byte @at180; public byte @at181; public byte @at182; public byte @at183; public byte @at184; public byte @at185; public byte @at186; public byte @at187; public byte @at188; public byte @at189; public byte @at190; public byte @at191; public byte @at192; public byte @at193; public byte @at194; public byte @at195; public byte @at196; public byte @at197; public byte @at198; public byte @at199; public byte @at200; public byte @at201; public byte @at202; public byte @at203; public byte @at204; public byte @at205; public byte @at206; public byte @at207; public byte @at208; public byte @at209; public byte @at210; public byte @at211; public byte @at212; public byte @at213; public byte @at214; public byte @at215; public byte @at216; public byte @at217; public byte @at218; public byte @at219; public byte @at220; public byte @at221; public byte @at222; public byte @at223; public byte @at224; public byte @at225; public byte @at226; public byte @at227; public byte @at228; public byte @at229; public byte @at230; public byte @at231; public byte @at232; public byte @at233; public byte @at234; public byte @at235; public byte @at236; public byte @at237; public byte @at238; public byte @at239; public byte @at240; public byte @at241; public byte @at242; public byte @at243; public byte @at244; public byte @at245; public byte @at246; public byte @at247; public byte @at248; public byte @at249; public byte @at250; public byte @at251; public byte @at252; public byte @at253; public byte @at254; public byte @at255; public byte @at256; public byte @at257; public byte @at258; public byte @at259; public byte @at260; public byte @at261; public byte @at262; public byte @at263; public byte @at264; public byte @at265; public byte @at266; public byte @at267; public byte @at268; public byte @at269; public byte @at270; public byte @at271; public byte @at272; public byte @at273; public byte @at274; public byte @at275; public byte @at276; public byte @at277; public byte @at278; public byte @at279; public byte @at280; public byte @at281; public byte @at282; public byte @at283; public byte @at284; public byte @at285; public byte @at286; public byte @at287; public byte @at288; public byte @at289; public byte @at290; public byte @at291; public byte @at292; public byte @at293; public byte @at294; public byte @at295; public byte @at296; public byte @at297; public byte @at298; public byte @at299; public byte @at300; public byte @at301; public byte @at302; public byte @at303; public byte @at304; public byte @at305; public byte @at306; public byte @at307; public byte @at308; public byte @at309; public byte @at310; public byte @at311; public byte @at312; public byte @at313; public byte @at314; public byte @at315; public byte @at316; public byte @at317; public byte @at318; public byte @at319; public byte @at320; public byte @at321; public byte @at322; public byte @at323; public byte @at324; public byte @at325; public byte @at326; public byte @at327; public byte @at328; public byte @at329; public byte @at330; public byte @at331; public byte @at332; public byte @at333; public byte @at334; public byte @at335; public byte @at336; public byte @at337; public byte @at338; public byte @at339; public byte @at340; public byte @at341; public byte @at342; public byte @at343; public byte @at344; public byte @at345; public byte @at346; public byte @at347; public byte @at348; public byte @at349; public byte @at350; public byte @at351; public byte @at352; public byte @at353; public byte @at354; public byte @at355; public byte @at356; public byte @at357; public byte @at358; public byte @at359; public byte @at360; public byte @at361; public byte @at362; public byte @at363; public byte @at364; public byte @at365; public byte @at366; public byte @at367; public byte @at368; public byte @at369; public byte @at370; public byte @at371; public byte @at372; public byte @at373; public byte @at374; public byte @at375; public byte @at376; public byte @at377; public byte @at378; public byte @at379; public byte @at380; public byte @at381; public byte @at382; public byte @at383; public byte @at384; public byte @at385; public byte @at386; public byte @at387; public byte @at388; public byte @at389; public byte @at390; public byte @at391; public byte @at392; public byte @at393; public byte @at394; public byte @at395; public byte @at396; public byte @at397; public byte @at398; public byte @at399; public byte @at400; public byte @at401; public byte @at402; public byte @at403; public byte @at404; public byte @at405; public byte @at406; public byte @at407; public byte @at408; public byte @at409; public byte @at410; public byte @at411; public byte @at412; public byte @at413; public byte @at414; public byte @at415; public byte @at416; public byte @at417; public byte @at418; public byte @at419; public byte @at420; public byte @at421; public byte @at422; public byte @at423; public byte @at424; public byte @at425; public byte @at426; public byte @at427; public byte @at428; public byte @at429; public byte @at430; public byte @at431; public byte @at432; public byte @at433; public byte @at434; public byte @at435; public byte @at436; public byte @at437; public byte @at438; public byte @at439; public byte @at440; public byte @at441; public byte @at442; public byte @at443; public byte @at444; public byte @at445; public byte @at446; public byte @at447; public byte @at448; public byte @at449; public byte @at450; public byte @at451; public byte @at452; public byte @at453; public byte @at454; public byte @at455; public byte @at456; public byte @at457; public byte @at458; public byte @at459; public byte @at460; public byte @at461; public byte @at462; public byte @at463; public byte @at464; public byte @at465; public byte @at466; public byte @at467; public byte @at468; public byte @at469; public byte @at470; public byte @at471; public byte @at472; public byte @at473; public byte @at474; public byte @at475; public byte @at476; public byte @at477; public byte @at478; public byte @at479; public byte @at480; public byte @at481; public byte @at482; public byte @at483; public byte @at484; public byte @at485; public byte @at486; public byte @at487; public byte @at488; public byte @at489; public byte @at490; public byte @at491; public byte @at492; public byte @at493; public byte @at494; public byte @at495; public byte @at496; public byte @at497; public byte @at498; public byte @at499; public byte @at500; public byte @at501; public byte @at502; public byte @at503; public byte @at504; public byte @at505; public byte @at506; public byte @at507; public byte @at508; public byte @at509; public byte @at510; public byte @at511; public byte @at512; public byte @at513; public byte @at514; public byte @at515; public byte @at516; public byte @at517; public byte @at518; public byte @at519; public byte @at520; public byte @at521; public byte @at522; public byte @at523; public byte @at524; public byte @at525; public byte @at526; public byte @at527; public byte @at528; public byte @at529; public byte @at530; public byte @at531; public byte @at532; public byte @at533; public byte @at534; public byte @at535; public byte @at536; public byte @at537; public byte @at538; public byte @at539; public byte @at540; public byte @at541; public byte @at542; public byte @at543; public byte @at544; public byte @at545; public byte @at546; public byte @at547; public byte @at548; public byte @at549; public byte @at550; public byte @at551; public byte @at552; public byte @at553; public byte @at554; public byte @at555; public byte @at556; public byte @at557; public byte @at558; public byte @at559; public byte @at560; public byte @at561; public byte @at562; public byte @at563; public byte @at564; public byte @at565; public byte @at566; public byte @at567; public byte @at568; public byte @at569; public byte @at570; public byte @at571; public byte @at572; public byte @at573; public byte @at574; public byte @at575; public byte @at576; public byte @at577; public byte @at578; public byte @at579; public byte @at580; public byte @at581; public byte @at582; public byte @at583; public byte @at584; public byte @at585; public byte @at586; public byte @at587; public byte @at588; public byte @at589; public byte @at590; public byte @at591; public byte @at592; public byte @at593; public byte @at594; public byte @at595; public byte @at596; public byte @at597; public byte @at598; public byte @at599; public byte @at600; public byte @at601; public byte @at602; public byte @at603; public byte @at604; public byte @at605; public byte @at606; public byte @at607; public byte @at608; public byte @at609; public byte @at610; public byte @at611; public byte @at612; public byte @at613; public byte @at614; public byte @at615; public byte @at616; public byte @at617; public byte @at618; public byte @at619; public byte @at620; public byte @at621; public byte @at622; public byte @at623; public byte @at624; public byte @at625; public byte @at626; public byte @at627; public byte @at628; public byte @at629; public byte @at630; public byte @at631; public byte @at632; public byte @at633; public byte @at634; public byte @at635; public byte @at636; public byte @at637; public byte @at638; public byte @at639; public byte @at640; public byte @at641; public byte @at642; public byte @at643; public byte @at644; public byte @at645; public byte @at646; public byte @at647; public byte @at648; public byte @at649; public byte @at650; public byte @at651; public byte @at652; public byte @at653; public byte @at654; public byte @at655; public byte @at656; public byte @at657; public byte @at658; public byte @at659; public byte @at660; public byte @at661; public byte @at662; public byte @at663; public byte @at664; public byte @at665; public byte @at666; public byte @at667; public byte @at668; public byte @at669; public byte @at670; public byte @at671; public byte @at672; public byte @at673; public byte @at674; public byte @at675; public byte @at676; public byte @at677; public byte @at678; public byte @at679; public byte @at680; public byte @at681; public byte @at682; public byte @at683; public byte @at684; public byte @at685; public byte @at686; public byte @at687; public byte @at688; public byte @at689; public byte @at690; public byte @at691; public byte @at692; public byte @at693; public byte @at694; public byte @at695; public byte @at696; public byte @at697; public byte @at698; public byte @at699; public byte @at700; public byte @at701; public byte @at702; public byte @at703; public byte @at704; public byte @at705; public byte @at706; public byte @at707; public byte @at708; public byte @at709; public byte @at710; public byte @at711; public byte @at712; public byte @at713; public byte @at714; public byte @at715; public byte @at716; public byte @at717; public byte @at718; public byte @at719; public byte @at720; public byte @at721; public byte @at722; public byte @at723; public byte @at724; public byte @at725; public byte @at726; public byte @at727; public byte @at728; public byte @at729; public byte @at730; public byte @at731; public byte @at732; public byte @at733; public byte @at734; public byte @at735; public byte @at736; public byte @at737; public byte @at738; public byte @at739; public byte @at740; public byte @at741; public byte @at742; public byte @at743; public byte @at744; public byte @at745; public byte @at746; public byte @at747; public byte @at748; public byte @at749; public byte @at750; public byte @at751; public byte @at752; public byte @at753; public byte @at754; public byte @at755; public byte @at756; public byte @at757; public byte @at758; public byte @at759; public byte @at760; public byte @at761; public byte @at762; public byte @at763; public byte @at764; public byte @at765; public byte @at766; public byte @at767; public byte @at768; public byte @at769; public byte @at770; public byte @at771; public byte @at772; public byte @at773; public byte @at774; public byte @at775; public byte @at776; public byte @at777; public byte @at778; public byte @at779; public byte @at780; public byte @at781; public byte @at782; public byte @at783; public byte @at784; public byte @at785; public byte @at786; public byte @at787; public byte @at788; public byte @at789; public byte @at790; public byte @at791; public byte @at792; public byte @at793; public byte @at794; public byte @at795; public byte @at796; public byte @at797; public byte @at798; public byte @at799; public byte @at800; public byte @at801; public byte @at802; public byte @at803; public byte @at804; public byte @at805; public byte @at806; public byte @at807; public byte @at808; public byte @at809; public byte @at810; public byte @at811; public byte @at812; public byte @at813; public byte @at814; public byte @at815; public byte @at816; public byte @at817; public byte @at818; public byte @at819; public byte @at820; public byte @at821; public byte @at822; public byte @at823; public byte @at824; public byte @at825; public byte @at826; public byte @at827; public byte @at828; public byte @at829; public byte @at830; public byte @at831; public byte @at832; public byte @at833; public byte @at834; public byte @at835; public byte @at836; public byte @at837; public byte @at838; public byte @at839; public byte @at840; public byte @at841; public byte @at842; public byte @at843; public byte @at844; public byte @at845; public byte @at846; public byte @at847; public byte @at848; public byte @at849; public byte @at850; public byte @at851; public byte @at852; public byte @at853; public byte @at854; public byte @at855; public byte @at856; public byte @at857; public byte @at858; public byte @at859; public byte @at860; public byte @at861; public byte @at862; public byte @at863; public byte @at864; public byte @at865; public byte @at866; public byte @at867; public byte @at868; public byte @at869; public byte @at870; public byte @at871; public byte @at872; public byte @at873; public byte @at874; public byte @at875; public byte @at876; public byte @at877; public byte @at878; public byte @at879; public byte @at880; public byte @at881; public byte @at882; public byte @at883; public byte @at884; public byte @at885; public byte @at886; public byte @at887; public byte @at888; public byte @at889; public byte @at890; public byte @at891; public byte @at892; public byte @at893; public byte @at894; public byte @at895; public byte @at896; public byte @at897; public byte @at898; public byte @at899; public byte @at900; public byte @at901; public byte @at902; public byte @at903; public byte @at904; public byte @at905; public byte @at906; public byte @at907; public byte @at908; public byte @at909; public byte @at910; public byte @at911; public byte @at912; public byte @at913; public byte @at914; public byte @at915; public byte @at916; public byte @at917; public byte @at918; public byte @at919; public byte @at920; public byte @at921; public byte @at922; public byte @at923; public byte @at924; public byte @at925; public byte @at926; public byte @at927; public byte @at928; public byte @at929; public byte @at930; public byte @at931; public byte @at932; public byte @at933; public byte @at934; public byte @at935; public byte @at936; public byte @at937; public byte @at938; public byte @at939; public byte @at940; public byte @at941; public byte @at942; public byte @at943; public byte @at944; public byte @at945; public byte @at946; public byte @at947; public byte @at948; public byte @at949; public byte @at950; public byte @at951; public byte @at952; public byte @at953; public byte @at954; public byte @at955; public byte @at956; public byte @at957; public byte @at958; public byte @at959; public byte @at960; public byte @at961; public byte @at962; public byte @at963; public byte @at964; public byte @at965; public byte @at966; public byte @at967; public byte @at968; public byte @at969; public byte @at970; public byte @at971; public byte @at972; public byte @at973; public byte @at974; public byte @at975; public byte @at976; public byte @at977; public byte @at978; public byte @at979; public byte @at980; public byte @at981; public byte @at982; public byte @at983; public byte @at984; public byte @at985; public byte @at986; public byte @at987; public byte @at988; public byte @at989; public byte @at990; public byte @at991; public byte @at992; public byte @at993; public byte @at994; public byte @at995; public byte @at996; public byte @at997; public byte @at998; public byte @at999; public byte @at1000; public byte @at1001; public byte @at1002; public byte @at1003; public byte @at1004; public byte @at1005; public byte @at1006; public byte @at1007; public byte @at1008; public byte @at1009; public byte @at1010; public byte @at1011; public byte @at1012; public byte @at1013; public byte @at1014; public byte @at1015; public byte @at1016; public byte @at1017; public byte @at1018; public byte @at1019; public byte @at1020; public byte @at1021; public byte @at1022; public byte @at1023;
        
        public byte this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; case 5: return at5; case 6: return at6; case 7: return at7; case 8: return at8; case 9: return at9; case 10: return at10; case 11: return at11; case 12: return at12; case 13: return at13; case 14: return at14; case 15: return at15; case 16: return at16; case 17: return at17; case 18: return at18; case 19: return at19; case 20: return at20; case 21: return at21; case 22: return at22; case 23: return at23; case 24: return at24; case 25: return at25; case 26: return at26; case 27: return at27; case 28: return at28; case 29: return at29; case 30: return at30; case 31: return at31; case 32: return at32; case 33: return at33; case 34: return at34; case 35: return at35; case 36: return at36; case 37: return at37; case 38: return at38; case 39: return at39; case 40: return at40; case 41: return at41; case 42: return at42; case 43: return at43; case 44: return at44; case 45: return at45; case 46: return at46; case 47: return at47; case 48: return at48; case 49: return at49; case 50: return at50; case 51: return at51; case 52: return at52; case 53: return at53; case 54: return at54; case 55: return at55; case 56: return at56; case 57: return at57; case 58: return at58; case 59: return at59; case 60: return at60; case 61: return at61; case 62: return at62; case 63: return at63; case 64: return at64; case 65: return at65; case 66: return at66; case 67: return at67; case 68: return at68; case 69: return at69; case 70: return at70; case 71: return at71; case 72: return at72; case 73: return at73; case 74: return at74; case 75: return at75; case 76: return at76; case 77: return at77; case 78: return at78; case 79: return at79; case 80: return at80; case 81: return at81; case 82: return at82; case 83: return at83; case 84: return at84; case 85: return at85; case 86: return at86; case 87: return at87; case 88: return at88; case 89: return at89; case 90: return at90; case 91: return at91; case 92: return at92; case 93: return at93; case 94: return at94; case 95: return at95; case 96: return at96; case 97: return at97; case 98: return at98; case 99: return at99; case 100: return at100; case 101: return at101; case 102: return at102; case 103: return at103; case 104: return at104; case 105: return at105; case 106: return at106; case 107: return at107; case 108: return at108; case 109: return at109; case 110: return at110; case 111: return at111; case 112: return at112; case 113: return at113; case 114: return at114; case 115: return at115; case 116: return at116; case 117: return at117; case 118: return at118; case 119: return at119; case 120: return at120; case 121: return at121; case 122: return at122; case 123: return at123; case 124: return at124; case 125: return at125; case 126: return at126; case 127: return at127; case 128: return at128; case 129: return at129; case 130: return at130; case 131: return at131; case 132: return at132; case 133: return at133; case 134: return at134; case 135: return at135; case 136: return at136; case 137: return at137; case 138: return at138; case 139: return at139; case 140: return at140; case 141: return at141; case 142: return at142; case 143: return at143; case 144: return at144; case 145: return at145; case 146: return at146; case 147: return at147; case 148: return at148; case 149: return at149; case 150: return at150; case 151: return at151; case 152: return at152; case 153: return at153; case 154: return at154; case 155: return at155; case 156: return at156; case 157: return at157; case 158: return at158; case 159: return at159; case 160: return at160; case 161: return at161; case 162: return at162; case 163: return at163; case 164: return at164; case 165: return at165; case 166: return at166; case 167: return at167; case 168: return at168; case 169: return at169; case 170: return at170; case 171: return at171; case 172: return at172; case 173: return at173; case 174: return at174; case 175: return at175; case 176: return at176; case 177: return at177; case 178: return at178; case 179: return at179; case 180: return at180; case 181: return at181; case 182: return at182; case 183: return at183; case 184: return at184; case 185: return at185; case 186: return at186; case 187: return at187; case 188: return at188; case 189: return at189; case 190: return at190; case 191: return at191; case 192: return at192; case 193: return at193; case 194: return at194; case 195: return at195; case 196: return at196; case 197: return at197; case 198: return at198; case 199: return at199; case 200: return at200; case 201: return at201; case 202: return at202; case 203: return at203; case 204: return at204; case 205: return at205; case 206: return at206; case 207: return at207; case 208: return at208; case 209: return at209; case 210: return at210; case 211: return at211; case 212: return at212; case 213: return at213; case 214: return at214; case 215: return at215; case 216: return at216; case 217: return at217; case 218: return at218; case 219: return at219; case 220: return at220; case 221: return at221; case 222: return at222; case 223: return at223; case 224: return at224; case 225: return at225; case 226: return at226; case 227: return at227; case 228: return at228; case 229: return at229; case 230: return at230; case 231: return at231; case 232: return at232; case 233: return at233; case 234: return at234; case 235: return at235; case 236: return at236; case 237: return at237; case 238: return at238; case 239: return at239; case 240: return at240; case 241: return at241; case 242: return at242; case 243: return at243; case 244: return at244; case 245: return at245; case 246: return at246; case 247: return at247; case 248: return at248; case 249: return at249; case 250: return at250; case 251: return at251; case 252: return at252; case 253: return at253; case 254: return at254; case 255: return at255; case 256: return at256; case 257: return at257; case 258: return at258; case 259: return at259; case 260: return at260; case 261: return at261; case 262: return at262; case 263: return at263; case 264: return at264; case 265: return at265; case 266: return at266; case 267: return at267; case 268: return at268; case 269: return at269; case 270: return at270; case 271: return at271; case 272: return at272; case 273: return at273; case 274: return at274; case 275: return at275; case 276: return at276; case 277: return at277; case 278: return at278; case 279: return at279; case 280: return at280; case 281: return at281; case 282: return at282; case 283: return at283; case 284: return at284; case 285: return at285; case 286: return at286; case 287: return at287; case 288: return at288; case 289: return at289; case 290: return at290; case 291: return at291; case 292: return at292; case 293: return at293; case 294: return at294; case 295: return at295; case 296: return at296; case 297: return at297; case 298: return at298; case 299: return at299; case 300: return at300; case 301: return at301; case 302: return at302; case 303: return at303; case 304: return at304; case 305: return at305; case 306: return at306; case 307: return at307; case 308: return at308; case 309: return at309; case 310: return at310; case 311: return at311; case 312: return at312; case 313: return at313; case 314: return at314; case 315: return at315; case 316: return at316; case 317: return at317; case 318: return at318; case 319: return at319; case 320: return at320; case 321: return at321; case 322: return at322; case 323: return at323; case 324: return at324; case 325: return at325; case 326: return at326; case 327: return at327; case 328: return at328; case 329: return at329; case 330: return at330; case 331: return at331; case 332: return at332; case 333: return at333; case 334: return at334; case 335: return at335; case 336: return at336; case 337: return at337; case 338: return at338; case 339: return at339; case 340: return at340; case 341: return at341; case 342: return at342; case 343: return at343; case 344: return at344; case 345: return at345; case 346: return at346; case 347: return at347; case 348: return at348; case 349: return at349; case 350: return at350; case 351: return at351; case 352: return at352; case 353: return at353; case 354: return at354; case 355: return at355; case 356: return at356; case 357: return at357; case 358: return at358; case 359: return at359; case 360: return at360; case 361: return at361; case 362: return at362; case 363: return at363; case 364: return at364; case 365: return at365; case 366: return at366; case 367: return at367; case 368: return at368; case 369: return at369; case 370: return at370; case 371: return at371; case 372: return at372; case 373: return at373; case 374: return at374; case 375: return at375; case 376: return at376; case 377: return at377; case 378: return at378; case 379: return at379; case 380: return at380; case 381: return at381; case 382: return at382; case 383: return at383; case 384: return at384; case 385: return at385; case 386: return at386; case 387: return at387; case 388: return at388; case 389: return at389; case 390: return at390; case 391: return at391; case 392: return at392; case 393: return at393; case 394: return at394; case 395: return at395; case 396: return at396; case 397: return at397; case 398: return at398; case 399: return at399; case 400: return at400; case 401: return at401; case 402: return at402; case 403: return at403; case 404: return at404; case 405: return at405; case 406: return at406; case 407: return at407; case 408: return at408; case 409: return at409; case 410: return at410; case 411: return at411; case 412: return at412; case 413: return at413; case 414: return at414; case 415: return at415; case 416: return at416; case 417: return at417; case 418: return at418; case 419: return at419; case 420: return at420; case 421: return at421; case 422: return at422; case 423: return at423; case 424: return at424; case 425: return at425; case 426: return at426; case 427: return at427; case 428: return at428; case 429: return at429; case 430: return at430; case 431: return at431; case 432: return at432; case 433: return at433; case 434: return at434; case 435: return at435; case 436: return at436; case 437: return at437; case 438: return at438; case 439: return at439; case 440: return at440; case 441: return at441; case 442: return at442; case 443: return at443; case 444: return at444; case 445: return at445; case 446: return at446; case 447: return at447; case 448: return at448; case 449: return at449; case 450: return at450; case 451: return at451; case 452: return at452; case 453: return at453; case 454: return at454; case 455: return at455; case 456: return at456; case 457: return at457; case 458: return at458; case 459: return at459; case 460: return at460; case 461: return at461; case 462: return at462; case 463: return at463; case 464: return at464; case 465: return at465; case 466: return at466; case 467: return at467; case 468: return at468; case 469: return at469; case 470: return at470; case 471: return at471; case 472: return at472; case 473: return at473; case 474: return at474; case 475: return at475; case 476: return at476; case 477: return at477; case 478: return at478; case 479: return at479; case 480: return at480; case 481: return at481; case 482: return at482; case 483: return at483; case 484: return at484; case 485: return at485; case 486: return at486; case 487: return at487; case 488: return at488; case 489: return at489; case 490: return at490; case 491: return at491; case 492: return at492; case 493: return at493; case 494: return at494; case 495: return at495; case 496: return at496; case 497: return at497; case 498: return at498; case 499: return at499; case 500: return at500; case 501: return at501; case 502: return at502; case 503: return at503; case 504: return at504; case 505: return at505; case 506: return at506; case 507: return at507; case 508: return at508; case 509: return at509; case 510: return at510; case 511: return at511; case 512: return at512; case 513: return at513; case 514: return at514; case 515: return at515; case 516: return at516; case 517: return at517; case 518: return at518; case 519: return at519; case 520: return at520; case 521: return at521; case 522: return at522; case 523: return at523; case 524: return at524; case 525: return at525; case 526: return at526; case 527: return at527; case 528: return at528; case 529: return at529; case 530: return at530; case 531: return at531; case 532: return at532; case 533: return at533; case 534: return at534; case 535: return at535; case 536: return at536; case 537: return at537; case 538: return at538; case 539: return at539; case 540: return at540; case 541: return at541; case 542: return at542; case 543: return at543; case 544: return at544; case 545: return at545; case 546: return at546; case 547: return at547; case 548: return at548; case 549: return at549; case 550: return at550; case 551: return at551; case 552: return at552; case 553: return at553; case 554: return at554; case 555: return at555; case 556: return at556; case 557: return at557; case 558: return at558; case 559: return at559; case 560: return at560; case 561: return at561; case 562: return at562; case 563: return at563; case 564: return at564; case 565: return at565; case 566: return at566; case 567: return at567; case 568: return at568; case 569: return at569; case 570: return at570; case 571: return at571; case 572: return at572; case 573: return at573; case 574: return at574; case 575: return at575; case 576: return at576; case 577: return at577; case 578: return at578; case 579: return at579; case 580: return at580; case 581: return at581; case 582: return at582; case 583: return at583; case 584: return at584; case 585: return at585; case 586: return at586; case 587: return at587; case 588: return at588; case 589: return at589; case 590: return at590; case 591: return at591; case 592: return at592; case 593: return at593; case 594: return at594; case 595: return at595; case 596: return at596; case 597: return at597; case 598: return at598; case 599: return at599; case 600: return at600; case 601: return at601; case 602: return at602; case 603: return at603; case 604: return at604; case 605: return at605; case 606: return at606; case 607: return at607; case 608: return at608; case 609: return at609; case 610: return at610; case 611: return at611; case 612: return at612; case 613: return at613; case 614: return at614; case 615: return at615; case 616: return at616; case 617: return at617; case 618: return at618; case 619: return at619; case 620: return at620; case 621: return at621; case 622: return at622; case 623: return at623; case 624: return at624; case 625: return at625; case 626: return at626; case 627: return at627; case 628: return at628; case 629: return at629; case 630: return at630; case 631: return at631; case 632: return at632; case 633: return at633; case 634: return at634; case 635: return at635; case 636: return at636; case 637: return at637; case 638: return at638; case 639: return at639; case 640: return at640; case 641: return at641; case 642: return at642; case 643: return at643; case 644: return at644; case 645: return at645; case 646: return at646; case 647: return at647; case 648: return at648; case 649: return at649; case 650: return at650; case 651: return at651; case 652: return at652; case 653: return at653; case 654: return at654; case 655: return at655; case 656: return at656; case 657: return at657; case 658: return at658; case 659: return at659; case 660: return at660; case 661: return at661; case 662: return at662; case 663: return at663; case 664: return at664; case 665: return at665; case 666: return at666; case 667: return at667; case 668: return at668; case 669: return at669; case 670: return at670; case 671: return at671; case 672: return at672; case 673: return at673; case 674: return at674; case 675: return at675; case 676: return at676; case 677: return at677; case 678: return at678; case 679: return at679; case 680: return at680; case 681: return at681; case 682: return at682; case 683: return at683; case 684: return at684; case 685: return at685; case 686: return at686; case 687: return at687; case 688: return at688; case 689: return at689; case 690: return at690; case 691: return at691; case 692: return at692; case 693: return at693; case 694: return at694; case 695: return at695; case 696: return at696; case 697: return at697; case 698: return at698; case 699: return at699; case 700: return at700; case 701: return at701; case 702: return at702; case 703: return at703; case 704: return at704; case 705: return at705; case 706: return at706; case 707: return at707; case 708: return at708; case 709: return at709; case 710: return at710; case 711: return at711; case 712: return at712; case 713: return at713; case 714: return at714; case 715: return at715; case 716: return at716; case 717: return at717; case 718: return at718; case 719: return at719; case 720: return at720; case 721: return at721; case 722: return at722; case 723: return at723; case 724: return at724; case 725: return at725; case 726: return at726; case 727: return at727; case 728: return at728; case 729: return at729; case 730: return at730; case 731: return at731; case 732: return at732; case 733: return at733; case 734: return at734; case 735: return at735; case 736: return at736; case 737: return at737; case 738: return at738; case 739: return at739; case 740: return at740; case 741: return at741; case 742: return at742; case 743: return at743; case 744: return at744; case 745: return at745; case 746: return at746; case 747: return at747; case 748: return at748; case 749: return at749; case 750: return at750; case 751: return at751; case 752: return at752; case 753: return at753; case 754: return at754; case 755: return at755; case 756: return at756; case 757: return at757; case 758: return at758; case 759: return at759; case 760: return at760; case 761: return at761; case 762: return at762; case 763: return at763; case 764: return at764; case 765: return at765; case 766: return at766; case 767: return at767; case 768: return at768; case 769: return at769; case 770: return at770; case 771: return at771; case 772: return at772; case 773: return at773; case 774: return at774; case 775: return at775; case 776: return at776; case 777: return at777; case 778: return at778; case 779: return at779; case 780: return at780; case 781: return at781; case 782: return at782; case 783: return at783; case 784: return at784; case 785: return at785; case 786: return at786; case 787: return at787; case 788: return at788; case 789: return at789; case 790: return at790; case 791: return at791; case 792: return at792; case 793: return at793; case 794: return at794; case 795: return at795; case 796: return at796; case 797: return at797; case 798: return at798; case 799: return at799; case 800: return at800; case 801: return at801; case 802: return at802; case 803: return at803; case 804: return at804; case 805: return at805; case 806: return at806; case 807: return at807; case 808: return at808; case 809: return at809; case 810: return at810; case 811: return at811; case 812: return at812; case 813: return at813; case 814: return at814; case 815: return at815; case 816: return at816; case 817: return at817; case 818: return at818; case 819: return at819; case 820: return at820; case 821: return at821; case 822: return at822; case 823: return at823; case 824: return at824; case 825: return at825; case 826: return at826; case 827: return at827; case 828: return at828; case 829: return at829; case 830: return at830; case 831: return at831; case 832: return at832; case 833: return at833; case 834: return at834; case 835: return at835; case 836: return at836; case 837: return at837; case 838: return at838; case 839: return at839; case 840: return at840; case 841: return at841; case 842: return at842; case 843: return at843; case 844: return at844; case 845: return at845; case 846: return at846; case 847: return at847; case 848: return at848; case 849: return at849; case 850: return at850; case 851: return at851; case 852: return at852; case 853: return at853; case 854: return at854; case 855: return at855; case 856: return at856; case 857: return at857; case 858: return at858; case 859: return at859; case 860: return at860; case 861: return at861; case 862: return at862; case 863: return at863; case 864: return at864; case 865: return at865; case 866: return at866; case 867: return at867; case 868: return at868; case 869: return at869; case 870: return at870; case 871: return at871; case 872: return at872; case 873: return at873; case 874: return at874; case 875: return at875; case 876: return at876; case 877: return at877; case 878: return at878; case 879: return at879; case 880: return at880; case 881: return at881; case 882: return at882; case 883: return at883; case 884: return at884; case 885: return at885; case 886: return at886; case 887: return at887; case 888: return at888; case 889: return at889; case 890: return at890; case 891: return at891; case 892: return at892; case 893: return at893; case 894: return at894; case 895: return at895; case 896: return at896; case 897: return at897; case 898: return at898; case 899: return at899; case 900: return at900; case 901: return at901; case 902: return at902; case 903: return at903; case 904: return at904; case 905: return at905; case 906: return at906; case 907: return at907; case 908: return at908; case 909: return at909; case 910: return at910; case 911: return at911; case 912: return at912; case 913: return at913; case 914: return at914; case 915: return at915; case 916: return at916; case 917: return at917; case 918: return at918; case 919: return at919; case 920: return at920; case 921: return at921; case 922: return at922; case 923: return at923; case 924: return at924; case 925: return at925; case 926: return at926; case 927: return at927; case 928: return at928; case 929: return at929; case 930: return at930; case 931: return at931; case 932: return at932; case 933: return at933; case 934: return at934; case 935: return at935; case 936: return at936; case 937: return at937; case 938: return at938; case 939: return at939; case 940: return at940; case 941: return at941; case 942: return at942; case 943: return at943; case 944: return at944; case 945: return at945; case 946: return at946; case 947: return at947; case 948: return at948; case 949: return at949; case 950: return at950; case 951: return at951; case 952: return at952; case 953: return at953; case 954: return at954; case 955: return at955; case 956: return at956; case 957: return at957; case 958: return at958; case 959: return at959; case 960: return at960; case 961: return at961; case 962: return at962; case 963: return at963; case 964: return at964; case 965: return at965; case 966: return at966; case 967: return at967; case 968: return at968; case 969: return at969; case 970: return at970; case 971: return at971; case 972: return at972; case 973: return at973; case 974: return at974; case 975: return at975; case 976: return at976; case 977: return at977; case 978: return at978; case 979: return at979; case 980: return at980; case 981: return at981; case 982: return at982; case 983: return at983; case 984: return at984; case 985: return at985; case 986: return at986; case 987: return at987; case 988: return at988; case 989: return at989; case 990: return at990; case 991: return at991; case 992: return at992; case 993: return at993; case 994: return at994; case 995: return at995; case 996: return at996; case 997: return at997; case 998: return at998; case 999: return at999; case 1000: return at1000; case 1001: return at1001; case 1002: return at1002; case 1003: return at1003; case 1004: return at1004; case 1005: return at1005; case 1006: return at1006; case 1007: return at1007; case 1008: return at1008; case 1009: return at1009; case 1010: return at1010; case 1011: return at1011; case 1012: return at1012; case 1013: return at1013; case 1014: return at1014; case 1015: return at1015; case 1016: return at1016; case 1017: return at1017; case 1018: return at1018; case 1019: return at1019; case 1020: return at1020; case 1021: return at1021; case 1022: return at1022; case 1023: return at1023; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; case 5: at5 = value; return; case 6: at6 = value; return; case 7: at7 = value; return; case 8: at8 = value; return; case 9: at9 = value; return; case 10: at10 = value; return; case 11: at11 = value; return; case 12: at12 = value; return; case 13: at13 = value; return; case 14: at14 = value; return; case 15: at15 = value; return; case 16: at16 = value; return; case 17: at17 = value; return; case 18: at18 = value; return; case 19: at19 = value; return; case 20: at20 = value; return; case 21: at21 = value; return; case 22: at22 = value; return; case 23: at23 = value; return; case 24: at24 = value; return; case 25: at25 = value; return; case 26: at26 = value; return; case 27: at27 = value; return; case 28: at28 = value; return; case 29: at29 = value; return; case 30: at30 = value; return; case 31: at31 = value; return; case 32: at32 = value; return; case 33: at33 = value; return; case 34: at34 = value; return; case 35: at35 = value; return; case 36: at36 = value; return; case 37: at37 = value; return; case 38: at38 = value; return; case 39: at39 = value; return; case 40: at40 = value; return; case 41: at41 = value; return; case 42: at42 = value; return; case 43: at43 = value; return; case 44: at44 = value; return; case 45: at45 = value; return; case 46: at46 = value; return; case 47: at47 = value; return; case 48: at48 = value; return; case 49: at49 = value; return; case 50: at50 = value; return; case 51: at51 = value; return; case 52: at52 = value; return; case 53: at53 = value; return; case 54: at54 = value; return; case 55: at55 = value; return; case 56: at56 = value; return; case 57: at57 = value; return; case 58: at58 = value; return; case 59: at59 = value; return; case 60: at60 = value; return; case 61: at61 = value; return; case 62: at62 = value; return; case 63: at63 = value; return; case 64: at64 = value; return; case 65: at65 = value; return; case 66: at66 = value; return; case 67: at67 = value; return; case 68: at68 = value; return; case 69: at69 = value; return; case 70: at70 = value; return; case 71: at71 = value; return; case 72: at72 = value; return; case 73: at73 = value; return; case 74: at74 = value; return; case 75: at75 = value; return; case 76: at76 = value; return; case 77: at77 = value; return; case 78: at78 = value; return; case 79: at79 = value; return; case 80: at80 = value; return; case 81: at81 = value; return; case 82: at82 = value; return; case 83: at83 = value; return; case 84: at84 = value; return; case 85: at85 = value; return; case 86: at86 = value; return; case 87: at87 = value; return; case 88: at88 = value; return; case 89: at89 = value; return; case 90: at90 = value; return; case 91: at91 = value; return; case 92: at92 = value; return; case 93: at93 = value; return; case 94: at94 = value; return; case 95: at95 = value; return; case 96: at96 = value; return; case 97: at97 = value; return; case 98: at98 = value; return; case 99: at99 = value; return; case 100: at100 = value; return; case 101: at101 = value; return; case 102: at102 = value; return; case 103: at103 = value; return; case 104: at104 = value; return; case 105: at105 = value; return; case 106: at106 = value; return; case 107: at107 = value; return; case 108: at108 = value; return; case 109: at109 = value; return; case 110: at110 = value; return; case 111: at111 = value; return; case 112: at112 = value; return; case 113: at113 = value; return; case 114: at114 = value; return; case 115: at115 = value; return; case 116: at116 = value; return; case 117: at117 = value; return; case 118: at118 = value; return; case 119: at119 = value; return; case 120: at120 = value; return; case 121: at121 = value; return; case 122: at122 = value; return; case 123: at123 = value; return; case 124: at124 = value; return; case 125: at125 = value; return; case 126: at126 = value; return; case 127: at127 = value; return; case 128: at128 = value; return; case 129: at129 = value; return; case 130: at130 = value; return; case 131: at131 = value; return; case 132: at132 = value; return; case 133: at133 = value; return; case 134: at134 = value; return; case 135: at135 = value; return; case 136: at136 = value; return; case 137: at137 = value; return; case 138: at138 = value; return; case 139: at139 = value; return; case 140: at140 = value; return; case 141: at141 = value; return; case 142: at142 = value; return; case 143: at143 = value; return; case 144: at144 = value; return; case 145: at145 = value; return; case 146: at146 = value; return; case 147: at147 = value; return; case 148: at148 = value; return; case 149: at149 = value; return; case 150: at150 = value; return; case 151: at151 = value; return; case 152: at152 = value; return; case 153: at153 = value; return; case 154: at154 = value; return; case 155: at155 = value; return; case 156: at156 = value; return; case 157: at157 = value; return; case 158: at158 = value; return; case 159: at159 = value; return; case 160: at160 = value; return; case 161: at161 = value; return; case 162: at162 = value; return; case 163: at163 = value; return; case 164: at164 = value; return; case 165: at165 = value; return; case 166: at166 = value; return; case 167: at167 = value; return; case 168: at168 = value; return; case 169: at169 = value; return; case 170: at170 = value; return; case 171: at171 = value; return; case 172: at172 = value; return; case 173: at173 = value; return; case 174: at174 = value; return; case 175: at175 = value; return; case 176: at176 = value; return; case 177: at177 = value; return; case 178: at178 = value; return; case 179: at179 = value; return; case 180: at180 = value; return; case 181: at181 = value; return; case 182: at182 = value; return; case 183: at183 = value; return; case 184: at184 = value; return; case 185: at185 = value; return; case 186: at186 = value; return; case 187: at187 = value; return; case 188: at188 = value; return; case 189: at189 = value; return; case 190: at190 = value; return; case 191: at191 = value; return; case 192: at192 = value; return; case 193: at193 = value; return; case 194: at194 = value; return; case 195: at195 = value; return; case 196: at196 = value; return; case 197: at197 = value; return; case 198: at198 = value; return; case 199: at199 = value; return; case 200: at200 = value; return; case 201: at201 = value; return; case 202: at202 = value; return; case 203: at203 = value; return; case 204: at204 = value; return; case 205: at205 = value; return; case 206: at206 = value; return; case 207: at207 = value; return; case 208: at208 = value; return; case 209: at209 = value; return; case 210: at210 = value; return; case 211: at211 = value; return; case 212: at212 = value; return; case 213: at213 = value; return; case 214: at214 = value; return; case 215: at215 = value; return; case 216: at216 = value; return; case 217: at217 = value; return; case 218: at218 = value; return; case 219: at219 = value; return; case 220: at220 = value; return; case 221: at221 = value; return; case 222: at222 = value; return; case 223: at223 = value; return; case 224: at224 = value; return; case 225: at225 = value; return; case 226: at226 = value; return; case 227: at227 = value; return; case 228: at228 = value; return; case 229: at229 = value; return; case 230: at230 = value; return; case 231: at231 = value; return; case 232: at232 = value; return; case 233: at233 = value; return; case 234: at234 = value; return; case 235: at235 = value; return; case 236: at236 = value; return; case 237: at237 = value; return; case 238: at238 = value; return; case 239: at239 = value; return; case 240: at240 = value; return; case 241: at241 = value; return; case 242: at242 = value; return; case 243: at243 = value; return; case 244: at244 = value; return; case 245: at245 = value; return; case 246: at246 = value; return; case 247: at247 = value; return; case 248: at248 = value; return; case 249: at249 = value; return; case 250: at250 = value; return; case 251: at251 = value; return; case 252: at252 = value; return; case 253: at253 = value; return; case 254: at254 = value; return; case 255: at255 = value; return; case 256: at256 = value; return; case 257: at257 = value; return; case 258: at258 = value; return; case 259: at259 = value; return; case 260: at260 = value; return; case 261: at261 = value; return; case 262: at262 = value; return; case 263: at263 = value; return; case 264: at264 = value; return; case 265: at265 = value; return; case 266: at266 = value; return; case 267: at267 = value; return; case 268: at268 = value; return; case 269: at269 = value; return; case 270: at270 = value; return; case 271: at271 = value; return; case 272: at272 = value; return; case 273: at273 = value; return; case 274: at274 = value; return; case 275: at275 = value; return; case 276: at276 = value; return; case 277: at277 = value; return; case 278: at278 = value; return; case 279: at279 = value; return; case 280: at280 = value; return; case 281: at281 = value; return; case 282: at282 = value; return; case 283: at283 = value; return; case 284: at284 = value; return; case 285: at285 = value; return; case 286: at286 = value; return; case 287: at287 = value; return; case 288: at288 = value; return; case 289: at289 = value; return; case 290: at290 = value; return; case 291: at291 = value; return; case 292: at292 = value; return; case 293: at293 = value; return; case 294: at294 = value; return; case 295: at295 = value; return; case 296: at296 = value; return; case 297: at297 = value; return; case 298: at298 = value; return; case 299: at299 = value; return; case 300: at300 = value; return; case 301: at301 = value; return; case 302: at302 = value; return; case 303: at303 = value; return; case 304: at304 = value; return; case 305: at305 = value; return; case 306: at306 = value; return; case 307: at307 = value; return; case 308: at308 = value; return; case 309: at309 = value; return; case 310: at310 = value; return; case 311: at311 = value; return; case 312: at312 = value; return; case 313: at313 = value; return; case 314: at314 = value; return; case 315: at315 = value; return; case 316: at316 = value; return; case 317: at317 = value; return; case 318: at318 = value; return; case 319: at319 = value; return; case 320: at320 = value; return; case 321: at321 = value; return; case 322: at322 = value; return; case 323: at323 = value; return; case 324: at324 = value; return; case 325: at325 = value; return; case 326: at326 = value; return; case 327: at327 = value; return; case 328: at328 = value; return; case 329: at329 = value; return; case 330: at330 = value; return; case 331: at331 = value; return; case 332: at332 = value; return; case 333: at333 = value; return; case 334: at334 = value; return; case 335: at335 = value; return; case 336: at336 = value; return; case 337: at337 = value; return; case 338: at338 = value; return; case 339: at339 = value; return; case 340: at340 = value; return; case 341: at341 = value; return; case 342: at342 = value; return; case 343: at343 = value; return; case 344: at344 = value; return; case 345: at345 = value; return; case 346: at346 = value; return; case 347: at347 = value; return; case 348: at348 = value; return; case 349: at349 = value; return; case 350: at350 = value; return; case 351: at351 = value; return; case 352: at352 = value; return; case 353: at353 = value; return; case 354: at354 = value; return; case 355: at355 = value; return; case 356: at356 = value; return; case 357: at357 = value; return; case 358: at358 = value; return; case 359: at359 = value; return; case 360: at360 = value; return; case 361: at361 = value; return; case 362: at362 = value; return; case 363: at363 = value; return; case 364: at364 = value; return; case 365: at365 = value; return; case 366: at366 = value; return; case 367: at367 = value; return; case 368: at368 = value; return; case 369: at369 = value; return; case 370: at370 = value; return; case 371: at371 = value; return; case 372: at372 = value; return; case 373: at373 = value; return; case 374: at374 = value; return; case 375: at375 = value; return; case 376: at376 = value; return; case 377: at377 = value; return; case 378: at378 = value; return; case 379: at379 = value; return; case 380: at380 = value; return; case 381: at381 = value; return; case 382: at382 = value; return; case 383: at383 = value; return; case 384: at384 = value; return; case 385: at385 = value; return; case 386: at386 = value; return; case 387: at387 = value; return; case 388: at388 = value; return; case 389: at389 = value; return; case 390: at390 = value; return; case 391: at391 = value; return; case 392: at392 = value; return; case 393: at393 = value; return; case 394: at394 = value; return; case 395: at395 = value; return; case 396: at396 = value; return; case 397: at397 = value; return; case 398: at398 = value; return; case 399: at399 = value; return; case 400: at400 = value; return; case 401: at401 = value; return; case 402: at402 = value; return; case 403: at403 = value; return; case 404: at404 = value; return; case 405: at405 = value; return; case 406: at406 = value; return; case 407: at407 = value; return; case 408: at408 = value; return; case 409: at409 = value; return; case 410: at410 = value; return; case 411: at411 = value; return; case 412: at412 = value; return; case 413: at413 = value; return; case 414: at414 = value; return; case 415: at415 = value; return; case 416: at416 = value; return; case 417: at417 = value; return; case 418: at418 = value; return; case 419: at419 = value; return; case 420: at420 = value; return; case 421: at421 = value; return; case 422: at422 = value; return; case 423: at423 = value; return; case 424: at424 = value; return; case 425: at425 = value; return; case 426: at426 = value; return; case 427: at427 = value; return; case 428: at428 = value; return; case 429: at429 = value; return; case 430: at430 = value; return; case 431: at431 = value; return; case 432: at432 = value; return; case 433: at433 = value; return; case 434: at434 = value; return; case 435: at435 = value; return; case 436: at436 = value; return; case 437: at437 = value; return; case 438: at438 = value; return; case 439: at439 = value; return; case 440: at440 = value; return; case 441: at441 = value; return; case 442: at442 = value; return; case 443: at443 = value; return; case 444: at444 = value; return; case 445: at445 = value; return; case 446: at446 = value; return; case 447: at447 = value; return; case 448: at448 = value; return; case 449: at449 = value; return; case 450: at450 = value; return; case 451: at451 = value; return; case 452: at452 = value; return; case 453: at453 = value; return; case 454: at454 = value; return; case 455: at455 = value; return; case 456: at456 = value; return; case 457: at457 = value; return; case 458: at458 = value; return; case 459: at459 = value; return; case 460: at460 = value; return; case 461: at461 = value; return; case 462: at462 = value; return; case 463: at463 = value; return; case 464: at464 = value; return; case 465: at465 = value; return; case 466: at466 = value; return; case 467: at467 = value; return; case 468: at468 = value; return; case 469: at469 = value; return; case 470: at470 = value; return; case 471: at471 = value; return; case 472: at472 = value; return; case 473: at473 = value; return; case 474: at474 = value; return; case 475: at475 = value; return; case 476: at476 = value; return; case 477: at477 = value; return; case 478: at478 = value; return; case 479: at479 = value; return; case 480: at480 = value; return; case 481: at481 = value; return; case 482: at482 = value; return; case 483: at483 = value; return; case 484: at484 = value; return; case 485: at485 = value; return; case 486: at486 = value; return; case 487: at487 = value; return; case 488: at488 = value; return; case 489: at489 = value; return; case 490: at490 = value; return; case 491: at491 = value; return; case 492: at492 = value; return; case 493: at493 = value; return; case 494: at494 = value; return; case 495: at495 = value; return; case 496: at496 = value; return; case 497: at497 = value; return; case 498: at498 = value; return; case 499: at499 = value; return; case 500: at500 = value; return; case 501: at501 = value; return; case 502: at502 = value; return; case 503: at503 = value; return; case 504: at504 = value; return; case 505: at505 = value; return; case 506: at506 = value; return; case 507: at507 = value; return; case 508: at508 = value; return; case 509: at509 = value; return; case 510: at510 = value; return; case 511: at511 = value; return; case 512: at512 = value; return; case 513: at513 = value; return; case 514: at514 = value; return; case 515: at515 = value; return; case 516: at516 = value; return; case 517: at517 = value; return; case 518: at518 = value; return; case 519: at519 = value; return; case 520: at520 = value; return; case 521: at521 = value; return; case 522: at522 = value; return; case 523: at523 = value; return; case 524: at524 = value; return; case 525: at525 = value; return; case 526: at526 = value; return; case 527: at527 = value; return; case 528: at528 = value; return; case 529: at529 = value; return; case 530: at530 = value; return; case 531: at531 = value; return; case 532: at532 = value; return; case 533: at533 = value; return; case 534: at534 = value; return; case 535: at535 = value; return; case 536: at536 = value; return; case 537: at537 = value; return; case 538: at538 = value; return; case 539: at539 = value; return; case 540: at540 = value; return; case 541: at541 = value; return; case 542: at542 = value; return; case 543: at543 = value; return; case 544: at544 = value; return; case 545: at545 = value; return; case 546: at546 = value; return; case 547: at547 = value; return; case 548: at548 = value; return; case 549: at549 = value; return; case 550: at550 = value; return; case 551: at551 = value; return; case 552: at552 = value; return; case 553: at553 = value; return; case 554: at554 = value; return; case 555: at555 = value; return; case 556: at556 = value; return; case 557: at557 = value; return; case 558: at558 = value; return; case 559: at559 = value; return; case 560: at560 = value; return; case 561: at561 = value; return; case 562: at562 = value; return; case 563: at563 = value; return; case 564: at564 = value; return; case 565: at565 = value; return; case 566: at566 = value; return; case 567: at567 = value; return; case 568: at568 = value; return; case 569: at569 = value; return; case 570: at570 = value; return; case 571: at571 = value; return; case 572: at572 = value; return; case 573: at573 = value; return; case 574: at574 = value; return; case 575: at575 = value; return; case 576: at576 = value; return; case 577: at577 = value; return; case 578: at578 = value; return; case 579: at579 = value; return; case 580: at580 = value; return; case 581: at581 = value; return; case 582: at582 = value; return; case 583: at583 = value; return; case 584: at584 = value; return; case 585: at585 = value; return; case 586: at586 = value; return; case 587: at587 = value; return; case 588: at588 = value; return; case 589: at589 = value; return; case 590: at590 = value; return; case 591: at591 = value; return; case 592: at592 = value; return; case 593: at593 = value; return; case 594: at594 = value; return; case 595: at595 = value; return; case 596: at596 = value; return; case 597: at597 = value; return; case 598: at598 = value; return; case 599: at599 = value; return; case 600: at600 = value; return; case 601: at601 = value; return; case 602: at602 = value; return; case 603: at603 = value; return; case 604: at604 = value; return; case 605: at605 = value; return; case 606: at606 = value; return; case 607: at607 = value; return; case 608: at608 = value; return; case 609: at609 = value; return; case 610: at610 = value; return; case 611: at611 = value; return; case 612: at612 = value; return; case 613: at613 = value; return; case 614: at614 = value; return; case 615: at615 = value; return; case 616: at616 = value; return; case 617: at617 = value; return; case 618: at618 = value; return; case 619: at619 = value; return; case 620: at620 = value; return; case 621: at621 = value; return; case 622: at622 = value; return; case 623: at623 = value; return; case 624: at624 = value; return; case 625: at625 = value; return; case 626: at626 = value; return; case 627: at627 = value; return; case 628: at628 = value; return; case 629: at629 = value; return; case 630: at630 = value; return; case 631: at631 = value; return; case 632: at632 = value; return; case 633: at633 = value; return; case 634: at634 = value; return; case 635: at635 = value; return; case 636: at636 = value; return; case 637: at637 = value; return; case 638: at638 = value; return; case 639: at639 = value; return; case 640: at640 = value; return; case 641: at641 = value; return; case 642: at642 = value; return; case 643: at643 = value; return; case 644: at644 = value; return; case 645: at645 = value; return; case 646: at646 = value; return; case 647: at647 = value; return; case 648: at648 = value; return; case 649: at649 = value; return; case 650: at650 = value; return; case 651: at651 = value; return; case 652: at652 = value; return; case 653: at653 = value; return; case 654: at654 = value; return; case 655: at655 = value; return; case 656: at656 = value; return; case 657: at657 = value; return; case 658: at658 = value; return; case 659: at659 = value; return; case 660: at660 = value; return; case 661: at661 = value; return; case 662: at662 = value; return; case 663: at663 = value; return; case 664: at664 = value; return; case 665: at665 = value; return; case 666: at666 = value; return; case 667: at667 = value; return; case 668: at668 = value; return; case 669: at669 = value; return; case 670: at670 = value; return; case 671: at671 = value; return; case 672: at672 = value; return; case 673: at673 = value; return; case 674: at674 = value; return; case 675: at675 = value; return; case 676: at676 = value; return; case 677: at677 = value; return; case 678: at678 = value; return; case 679: at679 = value; return; case 680: at680 = value; return; case 681: at681 = value; return; case 682: at682 = value; return; case 683: at683 = value; return; case 684: at684 = value; return; case 685: at685 = value; return; case 686: at686 = value; return; case 687: at687 = value; return; case 688: at688 = value; return; case 689: at689 = value; return; case 690: at690 = value; return; case 691: at691 = value; return; case 692: at692 = value; return; case 693: at693 = value; return; case 694: at694 = value; return; case 695: at695 = value; return; case 696: at696 = value; return; case 697: at697 = value; return; case 698: at698 = value; return; case 699: at699 = value; return; case 700: at700 = value; return; case 701: at701 = value; return; case 702: at702 = value; return; case 703: at703 = value; return; case 704: at704 = value; return; case 705: at705 = value; return; case 706: at706 = value; return; case 707: at707 = value; return; case 708: at708 = value; return; case 709: at709 = value; return; case 710: at710 = value; return; case 711: at711 = value; return; case 712: at712 = value; return; case 713: at713 = value; return; case 714: at714 = value; return; case 715: at715 = value; return; case 716: at716 = value; return; case 717: at717 = value; return; case 718: at718 = value; return; case 719: at719 = value; return; case 720: at720 = value; return; case 721: at721 = value; return; case 722: at722 = value; return; case 723: at723 = value; return; case 724: at724 = value; return; case 725: at725 = value; return; case 726: at726 = value; return; case 727: at727 = value; return; case 728: at728 = value; return; case 729: at729 = value; return; case 730: at730 = value; return; case 731: at731 = value; return; case 732: at732 = value; return; case 733: at733 = value; return; case 734: at734 = value; return; case 735: at735 = value; return; case 736: at736 = value; return; case 737: at737 = value; return; case 738: at738 = value; return; case 739: at739 = value; return; case 740: at740 = value; return; case 741: at741 = value; return; case 742: at742 = value; return; case 743: at743 = value; return; case 744: at744 = value; return; case 745: at745 = value; return; case 746: at746 = value; return; case 747: at747 = value; return; case 748: at748 = value; return; case 749: at749 = value; return; case 750: at750 = value; return; case 751: at751 = value; return; case 752: at752 = value; return; case 753: at753 = value; return; case 754: at754 = value; return; case 755: at755 = value; return; case 756: at756 = value; return; case 757: at757 = value; return; case 758: at758 = value; return; case 759: at759 = value; return; case 760: at760 = value; return; case 761: at761 = value; return; case 762: at762 = value; return; case 763: at763 = value; return; case 764: at764 = value; return; case 765: at765 = value; return; case 766: at766 = value; return; case 767: at767 = value; return; case 768: at768 = value; return; case 769: at769 = value; return; case 770: at770 = value; return; case 771: at771 = value; return; case 772: at772 = value; return; case 773: at773 = value; return; case 774: at774 = value; return; case 775: at775 = value; return; case 776: at776 = value; return; case 777: at777 = value; return; case 778: at778 = value; return; case 779: at779 = value; return; case 780: at780 = value; return; case 781: at781 = value; return; case 782: at782 = value; return; case 783: at783 = value; return; case 784: at784 = value; return; case 785: at785 = value; return; case 786: at786 = value; return; case 787: at787 = value; return; case 788: at788 = value; return; case 789: at789 = value; return; case 790: at790 = value; return; case 791: at791 = value; return; case 792: at792 = value; return; case 793: at793 = value; return; case 794: at794 = value; return; case 795: at795 = value; return; case 796: at796 = value; return; case 797: at797 = value; return; case 798: at798 = value; return; case 799: at799 = value; return; case 800: at800 = value; return; case 801: at801 = value; return; case 802: at802 = value; return; case 803: at803 = value; return; case 804: at804 = value; return; case 805: at805 = value; return; case 806: at806 = value; return; case 807: at807 = value; return; case 808: at808 = value; return; case 809: at809 = value; return; case 810: at810 = value; return; case 811: at811 = value; return; case 812: at812 = value; return; case 813: at813 = value; return; case 814: at814 = value; return; case 815: at815 = value; return; case 816: at816 = value; return; case 817: at817 = value; return; case 818: at818 = value; return; case 819: at819 = value; return; case 820: at820 = value; return; case 821: at821 = value; return; case 822: at822 = value; return; case 823: at823 = value; return; case 824: at824 = value; return; case 825: at825 = value; return; case 826: at826 = value; return; case 827: at827 = value; return; case 828: at828 = value; return; case 829: at829 = value; return; case 830: at830 = value; return; case 831: at831 = value; return; case 832: at832 = value; return; case 833: at833 = value; return; case 834: at834 = value; return; case 835: at835 = value; return; case 836: at836 = value; return; case 837: at837 = value; return; case 838: at838 = value; return; case 839: at839 = value; return; case 840: at840 = value; return; case 841: at841 = value; return; case 842: at842 = value; return; case 843: at843 = value; return; case 844: at844 = value; return; case 845: at845 = value; return; case 846: at846 = value; return; case 847: at847 = value; return; case 848: at848 = value; return; case 849: at849 = value; return; case 850: at850 = value; return; case 851: at851 = value; return; case 852: at852 = value; return; case 853: at853 = value; return; case 854: at854 = value; return; case 855: at855 = value; return; case 856: at856 = value; return; case 857: at857 = value; return; case 858: at858 = value; return; case 859: at859 = value; return; case 860: at860 = value; return; case 861: at861 = value; return; case 862: at862 = value; return; case 863: at863 = value; return; case 864: at864 = value; return; case 865: at865 = value; return; case 866: at866 = value; return; case 867: at867 = value; return; case 868: at868 = value; return; case 869: at869 = value; return; case 870: at870 = value; return; case 871: at871 = value; return; case 872: at872 = value; return; case 873: at873 = value; return; case 874: at874 = value; return; case 875: at875 = value; return; case 876: at876 = value; return; case 877: at877 = value; return; case 878: at878 = value; return; case 879: at879 = value; return; case 880: at880 = value; return; case 881: at881 = value; return; case 882: at882 = value; return; case 883: at883 = value; return; case 884: at884 = value; return; case 885: at885 = value; return; case 886: at886 = value; return; case 887: at887 = value; return; case 888: at888 = value; return; case 889: at889 = value; return; case 890: at890 = value; return; case 891: at891 = value; return; case 892: at892 = value; return; case 893: at893 = value; return; case 894: at894 = value; return; case 895: at895 = value; return; case 896: at896 = value; return; case 897: at897 = value; return; case 898: at898 = value; return; case 899: at899 = value; return; case 900: at900 = value; return; case 901: at901 = value; return; case 902: at902 = value; return; case 903: at903 = value; return; case 904: at904 = value; return; case 905: at905 = value; return; case 906: at906 = value; return; case 907: at907 = value; return; case 908: at908 = value; return; case 909: at909 = value; return; case 910: at910 = value; return; case 911: at911 = value; return; case 912: at912 = value; return; case 913: at913 = value; return; case 914: at914 = value; return; case 915: at915 = value; return; case 916: at916 = value; return; case 917: at917 = value; return; case 918: at918 = value; return; case 919: at919 = value; return; case 920: at920 = value; return; case 921: at921 = value; return; case 922: at922 = value; return; case 923: at923 = value; return; case 924: at924 = value; return; case 925: at925 = value; return; case 926: at926 = value; return; case 927: at927 = value; return; case 928: at928 = value; return; case 929: at929 = value; return; case 930: at930 = value; return; case 931: at931 = value; return; case 932: at932 = value; return; case 933: at933 = value; return; case 934: at934 = value; return; case 935: at935 = value; return; case 936: at936 = value; return; case 937: at937 = value; return; case 938: at938 = value; return; case 939: at939 = value; return; case 940: at940 = value; return; case 941: at941 = value; return; case 942: at942 = value; return; case 943: at943 = value; return; case 944: at944 = value; return; case 945: at945 = value; return; case 946: at946 = value; return; case 947: at947 = value; return; case 948: at948 = value; return; case 949: at949 = value; return; case 950: at950 = value; return; case 951: at951 = value; return; case 952: at952 = value; return; case 953: at953 = value; return; case 954: at954 = value; return; case 955: at955 = value; return; case 956: at956 = value; return; case 957: at957 = value; return; case 958: at958 = value; return; case 959: at959 = value; return; case 960: at960 = value; return; case 961: at961 = value; return; case 962: at962 = value; return; case 963: at963 = value; return; case 964: at964 = value; return; case 965: at965 = value; return; case 966: at966 = value; return; case 967: at967 = value; return; case 968: at968 = value; return; case 969: at969 = value; return; case 970: at970 = value; return; case 971: at971 = value; return; case 972: at972 = value; return; case 973: at973 = value; return; case 974: at974 = value; return; case 975: at975 = value; return; case 976: at976 = value; return; case 977: at977 = value; return; case 978: at978 = value; return; case 979: at979 = value; return; case 980: at980 = value; return; case 981: at981 = value; return; case 982: at982 = value; return; case 983: at983 = value; return; case 984: at984 = value; return; case 985: at985 = value; return; case 986: at986 = value; return; case 987: at987 = value; return; case 988: at988 = value; return; case 989: at989 = value; return; case 990: at990 = value; return; case 991: at991 = value; return; case 992: at992 = value; return; case 993: at993 = value; return; case 994: at994 = value; return; case 995: at995 = value; return; case 996: at996 = value; return; case 997: at997 = value; return; case 998: at998 = value; return; case 999: at999 = value; return; case 1000: at1000 = value; return; case 1001: at1001 = value; return; case 1002: at1002 = value; return; case 1003: at1003 = value; return; case 1004: at1004 = value; return; case 1005: at1005 = value; return; case 1006: at1006 = value; return; case 1007: at1007 = value; return; case 1008: at1008 = value; return; case 1009: at1009 = value; return; case 1010: at1010 = value; return; case 1011: at1011 = value; return; case 1012: at1012 = value; return; case 1013: at1013 = value; return; case 1014: at1014 = value; return; case 1015: at1015 = value; return; case 1016: at1016 = value; return; case 1017: at1017 = value; return; case 1018: at1018 = value; return; case 1019: at1019 = value; return; case 1020: at1020 = value; return; case 1021: at1021 = value; return; case 1022: at1022 = value; return; case 1023: at1023 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public byte[] ToArray() => new[] {at0, at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at11, at12, at13, at14, at15, at16, at17, at18, at19, at20, at21, at22, at23, at24, at25, at26, at27, at28, at29, at30, at31, at32, at33, at34, at35, at36, at37, at38, at39, at40, at41, at42, at43, at44, at45, at46, at47, at48, at49, at50, at51, at52, at53, at54, at55, at56, at57, at58, at59, at60, at61, at62, at63, at64, at65, at66, at67, at68, at69, at70, at71, at72, at73, at74, at75, at76, at77, at78, at79, at80, at81, at82, at83, at84, at85, at86, at87, at88, at89, at90, at91, at92, at93, at94, at95, at96, at97, at98, at99, at100, at101, at102, at103, at104, at105, at106, at107, at108, at109, at110, at111, at112, at113, at114, at115, at116, at117, at118, at119, at120, at121, at122, at123, at124, at125, at126, at127, at128, at129, at130, at131, at132, at133, at134, at135, at136, at137, at138, at139, at140, at141, at142, at143, at144, at145, at146, at147, at148, at149, at150, at151, at152, at153, at154, at155, at156, at157, at158, at159, at160, at161, at162, at163, at164, at165, at166, at167, at168, at169, at170, at171, at172, at173, at174, at175, at176, at177, at178, at179, at180, at181, at182, at183, at184, at185, at186, at187, at188, at189, at190, at191, at192, at193, at194, at195, at196, at197, at198, at199, at200, at201, at202, at203, at204, at205, at206, at207, at208, at209, at210, at211, at212, at213, at214, at215, at216, at217, at218, at219, at220, at221, at222, at223, at224, at225, at226, at227, at228, at229, at230, at231, at232, at233, at234, at235, at236, at237, at238, at239, at240, at241, at242, at243, at244, at245, at246, at247, at248, at249, at250, at251, at252, at253, at254, at255, at256, at257, at258, at259, at260, at261, at262, at263, at264, at265, at266, at267, at268, at269, at270, at271, at272, at273, at274, at275, at276, at277, at278, at279, at280, at281, at282, at283, at284, at285, at286, at287, at288, at289, at290, at291, at292, at293, at294, at295, at296, at297, at298, at299, at300, at301, at302, at303, at304, at305, at306, at307, at308, at309, at310, at311, at312, at313, at314, at315, at316, at317, at318, at319, at320, at321, at322, at323, at324, at325, at326, at327, at328, at329, at330, at331, at332, at333, at334, at335, at336, at337, at338, at339, at340, at341, at342, at343, at344, at345, at346, at347, at348, at349, at350, at351, at352, at353, at354, at355, at356, at357, at358, at359, at360, at361, at362, at363, at364, at365, at366, at367, at368, at369, at370, at371, at372, at373, at374, at375, at376, at377, at378, at379, at380, at381, at382, at383, at384, at385, at386, at387, at388, at389, at390, at391, at392, at393, at394, at395, at396, at397, at398, at399, at400, at401, at402, at403, at404, at405, at406, at407, at408, at409, at410, at411, at412, at413, at414, at415, at416, at417, at418, at419, at420, at421, at422, at423, at424, at425, at426, at427, at428, at429, at430, at431, at432, at433, at434, at435, at436, at437, at438, at439, at440, at441, at442, at443, at444, at445, at446, at447, at448, at449, at450, at451, at452, at453, at454, at455, at456, at457, at458, at459, at460, at461, at462, at463, at464, at465, at466, at467, at468, at469, at470, at471, at472, at473, at474, at475, at476, at477, at478, at479, at480, at481, at482, at483, at484, at485, at486, at487, at488, at489, at490, at491, at492, at493, at494, at495, at496, at497, at498, at499, at500, at501, at502, at503, at504, at505, at506, at507, at508, at509, at510, at511, at512, at513, at514, at515, at516, at517, at518, at519, at520, at521, at522, at523, at524, at525, at526, at527, at528, at529, at530, at531, at532, at533, at534, at535, at536, at537, at538, at539, at540, at541, at542, at543, at544, at545, at546, at547, at548, at549, at550, at551, at552, at553, at554, at555, at556, at557, at558, at559, at560, at561, at562, at563, at564, at565, at566, at567, at568, at569, at570, at571, at572, at573, at574, at575, at576, at577, at578, at579, at580, at581, at582, at583, at584, at585, at586, at587, at588, at589, at590, at591, at592, at593, at594, at595, at596, at597, at598, at599, at600, at601, at602, at603, at604, at605, at606, at607, at608, at609, at610, at611, at612, at613, at614, at615, at616, at617, at618, at619, at620, at621, at622, at623, at624, at625, at626, at627, at628, at629, at630, at631, at632, at633, at634, at635, at636, at637, at638, at639, at640, at641, at642, at643, at644, at645, at646, at647, at648, at649, at650, at651, at652, at653, at654, at655, at656, at657, at658, at659, at660, at661, at662, at663, at664, at665, at666, at667, at668, at669, at670, at671, at672, at673, at674, at675, at676, at677, at678, at679, at680, at681, at682, at683, at684, at685, at686, at687, at688, at689, at690, at691, at692, at693, at694, at695, at696, at697, at698, at699, at700, at701, at702, at703, at704, at705, at706, at707, at708, at709, at710, at711, at712, at713, at714, at715, at716, at717, at718, at719, at720, at721, at722, at723, at724, at725, at726, at727, at728, at729, at730, at731, at732, at733, at734, at735, at736, at737, at738, at739, at740, at741, at742, at743, at744, at745, at746, at747, at748, at749, at750, at751, at752, at753, at754, at755, at756, at757, at758, at759, at760, at761, at762, at763, at764, at765, at766, at767, at768, at769, at770, at771, at772, at773, at774, at775, at776, at777, at778, at779, at780, at781, at782, at783, at784, at785, at786, at787, at788, at789, at790, at791, at792, at793, at794, at795, at796, at797, at798, at799, at800, at801, at802, at803, at804, at805, at806, at807, at808, at809, at810, at811, at812, at813, at814, at815, at816, at817, at818, at819, at820, at821, at822, at823, at824, at825, at826, at827, at828, at829, at830, at831, at832, at833, at834, at835, at836, at837, at838, at839, at840, at841, at842, at843, at844, at845, at846, at847, at848, at849, at850, at851, at852, at853, at854, at855, at856, at857, at858, at859, at860, at861, at862, at863, at864, at865, at866, at867, at868, at869, at870, at871, at872, at873, at874, at875, at876, at877, at878, at879, at880, at881, at882, at883, at884, at885, at886, at887, at888, at889, at890, at891, at892, at893, at894, at895, at896, at897, at898, at899, at900, at901, at902, at903, at904, at905, at906, at907, at908, at909, at910, at911, at912, at913, at914, at915, at916, at917, at918, at919, at920, at921, at922, at923, at924, at925, at926, at927, at928, at929, at930, at931, at932, at933, at934, at935, at936, at937, at938, at939, at940, at941, at942, at943, at944, at945, at946, at947, at948, at949, at950, at951, at952, at953, at954, at955, at956, at957, at958, at959, at960, at961, at962, at963, at964, at965, at966, at967, at968, at969, at970, at971, at972, at973, at974, at975, at976, at977, at978, at979, at980, at981, at982, at983, at984, at985, at986, at987, at988, at989, at990, at991, at992, at993, at994, at995, at996, at997, at998, at999, at1000, at1001, at1002, at1003, at1004, at1005, at1006, at1007, at1008, at1009, at1010, at1011, at1012, at1013, at1014, at1015, at1016, at1017, at1018, at1019, at1020, at1021, at1022, at1023};
    }
    
    public unsafe struct AVFormatContext_open_cb_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVFormatContext_open_cb_wrapper(AVFormatContext_open_cb func) => new AVFormatContext_open_cb_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVFormatContext_io_open_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVFormatContext_io_open_wrapper(AVFormatContext_io_open func) => new AVFormatContext_io_open_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVFormatContext_io_close_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVFormatContext_io_close_wrapper(AVFormatContext_io_close func) => new AVFormatContext_io_close_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    /// <summary>Format I/O context. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVFormatContext) must not be used outside libav*, use avformat_alloc_context() to create an AVFormatContext.</summary>
    public unsafe struct AVFormatContext
    {
        /// <summary>A class for logging and Exports (de)muxer private options if they exist.</summary>
        public AVClass* @av_class;
        /// <summary>The input container format.</summary>
        public IntPtr @iformat;
        /// <summary>The output container format.</summary>
        public IntPtr @oformat;
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
        /// <summary>input or output filename</summary>
        public byte_array1024 @filename;
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
        /// <summary>Maximum size of the data read from input for determining the input container format. Demuxing only, set by the caller before avformat_open_input().</summary>
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
        /// <summary>Maximum amount of memory in bytes to use for the index of each stream. If the index exceeds this size, entries will be discarded as needed to maintain a smaller size. This can lead to slower or less accurate seeking (depends on demuxer). Demuxers for which a full in-memory index is mandatory will ignore this. - muxing: unused - demuxing: set by user</summary>
        public uint @max_index_size;
        /// <summary>Maximum amount of memory in bytes to use for buffering frames obtained from realtime capture devices.</summary>
        public uint @max_picture_buffer;
        /// <summary>Number of chapters in AVChapter array. When muxing, chapters are normally written in the file header, so nb_chapters should normally be initialized before write_header is called. Some muxers (e.g. mov and mkv) can also write chapters in the trailer. To write chapters in the trailer, nb_chapters must be zero when write_header is called and non-zero when write_trailer is called. - muxing: set by user - demuxing: set by libavformat</summary>
        public uint @nb_chapters;
        public AVChapter** @chapters;
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
        /// <summary>Maximum buffering duration for interleaving.</summary>
        public long @max_interleave_delta;
        /// <summary>Allow non-standard and experimental extension</summary>
        public int @strict_std_compliance;
        /// <summary>Flags for the user to detect events happening on the file. Flags must be cleared by the user once the event has been handled. A combination of AVFMT_EVENT_FLAG_*.</summary>
        public int @event_flags;
        /// <summary>Maximum number of packets to read while waiting for the first timestamp. Decoding only.</summary>
        public int @max_ts_probe;
        /// <summary>Avoid negative timestamps during muxing. Any value of the AVFMT_AVOID_NEG_TS_* constants. Note, this only works when using av_interleaved_write_frame. (interleave_packet_per_dts is in use) - muxing: Set by user - demuxing: unused</summary>
        public int @avoid_negative_ts;
        /// <summary>Transport stream id. This will be moved into demuxer private options. Thus no API/ABI compatibility</summary>
        public int @ts_id;
        /// <summary>Audio preload in microseconds. Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user via AVOptions (NO direct access) - decoding: unused</summary>
        public int @audio_preload;
        /// <summary>Max chunk time in microseconds. Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user via AVOptions (NO direct access) - decoding: unused</summary>
        public int @max_chunk_duration;
        /// <summary>Max chunk size in bytes Note, not all formats support this and unpredictable things may happen if it is used when not supported. - encoding: Set by user via AVOptions (NO direct access) - decoding: unused</summary>
        public int @max_chunk_size;
        /// <summary>forces the use of wallclock timestamps as pts/dts of packets This has undefined results in the presence of B frames. - encoding: unused - decoding: Set by user via AVOptions (NO direct access)</summary>
        public int @use_wallclock_as_timestamps;
        /// <summary>avio flags, used to force AVIO_FLAG_DIRECT. - encoding: unused - decoding: Set by user via AVOptions (NO direct access)</summary>
        public int @avio_flags;
        /// <summary>The duration field can be estimated through various ways, and this field can be used to know how the duration was estimated. - encoding: unused - decoding: Read by user via AVOptions (NO direct access)</summary>
        public AVDurationEstimationMethod @duration_estimation_method;
        /// <summary>Skip initial bytes when opening stream - encoding: unused - decoding: Set by user via AVOptions (NO direct access)</summary>
        public long @skip_initial_bytes;
        /// <summary>Correct single timestamp overflows - encoding: unused - decoding: Set by user via AVOptions (NO direct access)</summary>
        public uint @correct_ts_overflow;
        /// <summary>Force seeking to any (also non key) frames. - encoding: unused - decoding: Set by user via AVOptions (NO direct access)</summary>
        public int @seek2any;
        /// <summary>Flush the I/O context after each packet. - encoding: Set by user via AVOptions (NO direct access) - decoding: unused</summary>
        public int @flush_packets;
        /// <summary>format probing score. The maximal score is AVPROBE_SCORE_MAX, its set when the demuxer probes the format. - encoding: unused - decoding: set by avformat, read by user via av_format_get_probe_score() (NO direct access)</summary>
        public int @probe_score;
        /// <summary>number of bytes to read maximally to identify format. - encoding: unused - decoding: set by user through AVOPtions (NO direct access)</summary>
        public int @format_probesize;
        /// <summary>',' separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @codec_whitelist;
        /// <summary>',' separated list of allowed demuxers. If NULL then all are allowed - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @format_whitelist;
        /// <summary>An opaque field for libavformat internal usage. Must not be accessed in any way by callers.</summary>
        public AVFormatInternal* @internal;
        /// <summary>IO repositioned flag. This is set by avformat when the underlaying IO context read pointer is repositioned, for example when doing byte based seeking. Demuxers can use the flag to detect such changes.</summary>
        public int @io_repositioned;
        /// <summary>Forced video codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user via av_format_set_video_codec (NO direct access).</summary>
        public AVCodec* @video_codec;
        /// <summary>Forced audio codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user via av_format_set_audio_codec (NO direct access).</summary>
        public AVCodec* @audio_codec;
        /// <summary>Forced subtitle codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user via av_format_set_subtitle_codec (NO direct access).</summary>
        public AVCodec* @subtitle_codec;
        /// <summary>Forced data codec. This allows forcing a specific decoder, even when there are multiple with the same codec_id. Demuxing: Set by user via av_format_set_data_codec (NO direct access).</summary>
        public AVCodec* @data_codec;
        /// <summary>Number of bytes to be written as padding in a metadata header. Demuxing: Unused. Muxing: Set by user via av_format_set_metadata_header_padding.</summary>
        public int @metadata_header_padding;
        /// <summary>User data. This is a place for some private data of the user.</summary>
        public void* @opaque;
        /// <summary>Callback used by devices to communicate with application.</summary>
        public IntPtr @control_message_cb;
        /// <summary>Output timestamp offset, in microseconds. Muxing: set by user via AVOptions (NO direct access)</summary>
        public long @output_ts_offset;
        /// <summary>dump format separator. can be ", " or " " or anything else Code outside libavformat should access this field using AVOptions (NO direct access). - muxing: Set by user. - demuxing: Set by user.</summary>
        public byte* @dump_separator;
        /// <summary>Forced Data codec_id. Demuxing: Set by user.</summary>
        public AVCodecID @data_codec_id;
        /// <summary>Called to open further IO contexts when needed for demuxing.</summary>
        public AVFormatContext_open_cb_wrapper @open_cb;
        /// <summary>',' separated list of allowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @protocol_whitelist;
        public AVFormatContext_io_open_wrapper @io_open;
        /// <summary>A callback for closing the streams opened with AVFormatContext.io_open().</summary>
        public AVFormatContext_io_close_wrapper @io_close;
        /// <summary>',' separated list of disallowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @protocol_blacklist;
    }
    
    public unsafe struct AVPacketList
    {
        public AVPacket @pkt;
        public IntPtr @next;
    }
    
    public unsafe struct AVIOInterruptCB_callback_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOInterruptCB_callback_wrapper(AVIOInterruptCB_callback func) => new AVIOInterruptCB_callback_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    /// <summary>Callback for checking whether to abort blocking functions. AVERROR_EXIT is returned in this case by the interrupted function. During blocking operations, callback is called with opaque as parameter. If the callback returns 1, the blocking operation will be aborted.</summary>
    public unsafe struct AVIOInterruptCB
    {
        public AVIOInterruptCB_callback_wrapper @callback;
        public void* @opaque;
    }
    
    /// <summary>Describes single entry of the directory.</summary>
    public unsafe struct AVIODirEntry
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
    
    public unsafe struct AVIODirContext
    {
        public IntPtr @url_context;
    }
    
    public unsafe struct AVIOContext_read_packet_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_read_packet_wrapper(AVIOContext_read_packet func) => new AVIOContext_read_packet_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_write_packet_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_write_packet_wrapper(AVIOContext_write_packet func) => new AVIOContext_write_packet_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_seek_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_seek_wrapper(AVIOContext_seek func) => new AVIOContext_seek_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_update_checksum_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_update_checksum_wrapper(AVIOContext_update_checksum func) => new AVIOContext_update_checksum_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_read_pause_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_read_pause_wrapper(AVIOContext_read_pause func) => new AVIOContext_read_pause_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_read_seek_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_read_seek_wrapper(AVIOContext_read_seek func) => new AVIOContext_read_seek_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    public unsafe struct AVIOContext_write_data_type_wrapper
    {
        public IntPtr Pointer;
        public static implicit operator AVIOContext_write_data_type_wrapper(AVIOContext_write_data_type func) => new AVIOContext_write_data_type_wrapper { Pointer = Marshal.GetFunctionPointerForDelegate(func) };
    }
    
    /// <summary>Bytestream IO Context. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. sizeof(AVIOContext) must not be used outside libav*.</summary>
    public unsafe struct AVIOContext
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
        public AVIOContext_read_packet_wrapper @read_packet;
        public AVIOContext_write_packet_wrapper @write_packet;
        public AVIOContext_seek_wrapper @seek;
        /// <summary>position in the file of the current buffer</summary>
        public long @pos;
        /// <summary>true if the next seek should flush</summary>
        public int @must_flush;
        /// <summary>true if eof reached</summary>
        public int @eof_reached;
        /// <summary>true if open for writing</summary>
        public int @write_flag;
        public int @max_packet_size;
        public ulong @checksum;
        public byte* @checksum_ptr;
        public AVIOContext_update_checksum_wrapper @update_checksum;
        /// <summary>contains the error code or 0 if no error happened</summary>
        public int @error;
        /// <summary>Pause or resume playback for network streaming protocols - e.g. MMS.</summary>
        public AVIOContext_read_pause_wrapper @read_pause;
        /// <summary>Seek to a given timestamp in stream with the specified stream_index. Needed for some network streaming protocols which don't support seeking to byte position.</summary>
        public AVIOContext_read_seek_wrapper @read_seek;
        /// <summary>A combination of AVIO_SEEKABLE_ flags or 0 when the stream is not seekable.</summary>
        public int @seekable;
        /// <summary>max filesize, used to limit allocations This field is internal to libavformat and access from outside is not allowed.</summary>
        public long @maxsize;
        /// <summary>avio_read and avio_write should if possible be satisfied directly instead of going through a buffer, and avio_seek will always call the underlying seek function directly.</summary>
        public int @direct;
        /// <summary>Bytes read statistic This field is internal to libavformat and access from outside is not allowed.</summary>
        public long @bytes_read;
        /// <summary>seek statistic This field is internal to libavformat and access from outside is not allowed.</summary>
        public int @seek_count;
        /// <summary>writeout statistic This field is internal to libavformat and access from outside is not allowed.</summary>
        public int @writeout_count;
        /// <summary>Original buffer size used internally after probing and ensure seekback to reset the buffer size This field is internal to libavformat and access from outside is not allowed.</summary>
        public int @orig_buffer_size;
        /// <summary>Threshold to favor readahead over seek. This is current internal only, do not use from outside.</summary>
        public int @short_seek_threshold;
        /// <summary>',' separated list of allowed protocols.</summary>
        public byte* @protocol_whitelist;
        /// <summary>',' separated list of disallowed protocols.</summary>
        public byte* @protocol_blacklist;
        /// <summary>A callback that is used instead of write_packet.</summary>
        public AVIOContext_write_data_type_wrapper @write_data_type;
        /// <summary>If set, don't call write_data_type separately for AVIO_DATA_MARKER_BOUNDARY_POINT, but ignore them and treat them as AVIO_DATA_MARKER_UNKNOWN (to avoid needlessly small chunks of data returned from the callback).</summary>
        public int @ignore_boundary_point;
        /// <summary>Internal, not meant to be used from outside of AVIOContext.</summary>
        public AVIODataMarkerType @current_type;
        public long @last_time;
    }
    
    public unsafe static partial class ffmpeg
    {
        public static int AVPROBE_SCORE_RETRY = (AVPROBE_SCORE_MAX / 4);
        public static int AVPROBE_SCORE_STREAM_RETRY = (AVPROBE_SCORE_MAX / 4);
        public static int AVPROBE_SCORE_EXTENSION = 50;
        public static int AVPROBE_SCORE_MIME = 75;
        public static int AVPROBE_SCORE_MAX = 100;
        public static int AVPROBE_PADDING_SIZE = 32;
        public static int AVFMT_NOFILE = 0x0001;
        public static int AVFMT_NEEDNUMBER = 0x0002;
        public static int AVFMT_SHOW_IDS = 0x0008;
        public static int AVFMT_RAWPICTURE = 0x0020;
        public static int AVFMT_GLOBALHEADER = 0x0040;
        public static int AVFMT_NOTIMESTAMPS = 0x0080;
        public static int AVFMT_GENERIC_INDEX = 0x0100;
        public static int AVFMT_TS_DISCONT = 0x0200;
        public static int AVFMT_VARIABLE_FPS = 0x0400;
        public static int AVFMT_NODIMENSIONS = 0x0800;
        public static int AVFMT_NOSTREAMS = 0x1000;
        public static int AVFMT_NOBINSEARCH = 0x2000;
        public static int AVFMT_NOGENSEARCH = 0x4000;
        public static int AVFMT_NO_BYTE_SEEK = 0x8000;
        public static int AVFMT_ALLOW_FLUSH = 0x10000;
        public static int AVFMT_TS_NONSTRICT = 0x20000;
        public static int AVFMT_TS_NEGATIVE = 0x40000;
        public static int AVFMT_SEEK_TO_PTS = 0x4000000;
        public static int AVINDEX_KEYFRAME = 0x0001;
        public static int AVINDEX_DISCARD_FRAME = 0x0002;
        public static int AV_DISPOSITION_DEFAULT = 0x0001;
        public static int AV_DISPOSITION_DUB = 0x0002;
        public static int AV_DISPOSITION_ORIGINAL = 0x0004;
        public static int AV_DISPOSITION_COMMENT = 0x0008;
        public static int AV_DISPOSITION_LYRICS = 0x0010;
        public static int AV_DISPOSITION_KARAOKE = 0x0020;
        public static int AV_DISPOSITION_FORCED = 0x0040;
        public static int AV_DISPOSITION_HEARING_IMPAIRED = 0x0080;
        public static int AV_DISPOSITION_VISUAL_IMPAIRED = 0x0100;
        public static int AV_DISPOSITION_CLEAN_EFFECTS = 0x0200;
        public static int AV_DISPOSITION_ATTACHED_PIC = 0x0400;
        public static int AV_DISPOSITION_TIMED_THUMBNAILS = 0x0800;
        public static int AV_DISPOSITION_CAPTIONS = 0x10000;
        public static int AV_DISPOSITION_DESCRIPTIONS = 0x20000;
        public static int AV_DISPOSITION_METADATA = 0x40000;
        public static int AV_PTS_WRAP_IGNORE = 0;
        public static int AV_PTS_WRAP_ADD_OFFSET = 1;
        public static int AV_PTS_WRAP_SUB_OFFSET = -1;
        public static int AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x0001;
        public static int MAX_STD_TIMEBASES = (30 * 12);
        public static int MAX_REORDER_DELAY = 16;
        public static int AV_PROGRAM_RUNNING = 1;
        public static int AVFMTCTX_NOHEADER = 0x0001;
        public static int AVFMT_FLAG_GENPTS = 0x0001;
        public static int AVFMT_FLAG_IGNIDX = 0x0002;
        public static int AVFMT_FLAG_NONBLOCK = 0x0004;
        public static int AVFMT_FLAG_IGNDTS = 0x0008;
        public static int AVFMT_FLAG_NOFILLIN = 0x0010;
        public static int AVFMT_FLAG_NOPARSE = 0x0020;
        public static int AVFMT_FLAG_NOBUFFER = 0x0040;
        public static int AVFMT_FLAG_CUSTOM_IO = 0x0080;
        public static int AVFMT_FLAG_DISCARD_CORRUPT = 0x0100;
        public static int AVFMT_FLAG_FLUSH_PACKETS = 0x0200;
        public static int AVFMT_FLAG_BITEXACT = 0x0400;
        public static int AVFMT_FLAG_MP4A_LATM = 0x8000;
        public static int AVFMT_FLAG_SORT_DTS = 0x10000;
        public static int AVFMT_FLAG_PRIV_OPT = 0x20000;
        public static int AVFMT_FLAG_KEEP_SIDE_DATA = 0x40000;
        public static int AVFMT_FLAG_FAST_SEEK = 0x80000;
        public static int AVFMT_FLAG_SHORTEST = 0x100000;
        public static int AVFMT_FLAG_AUTO_BSF = 0x200000;
        public static int FF_FDEBUG_TS = 0x0001;
        public static int AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x0001;
        public static int AVFMT_AVOID_NEG_TS_AUTO = -1;
        public static int AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 1;
        public static int AVFMT_AVOID_NEG_TS_MAKE_ZERO = 2;
        public static int AVSEEK_FLAG_BACKWARD = 1;
        public static int AVSEEK_FLAG_BYTE = 2;
        public static int AVSEEK_FLAG_ANY = 4;
        public static int AVSEEK_FLAG_FRAME = 8;
        public static int AVSTREAM_INIT_IN_WRITE_HEADER = 0;
        public static int AVSTREAM_INIT_IN_INIT_OUTPUT = 1;
        public static int AV_FRAME_FILENAME_FLAGS_MULTIPLE = 1;
        public static int LIBAVFORMAT_VERSION_MAJOR = 57;
        public static int LIBAVFORMAT_VERSION_MINOR = 56;
        public static int LIBAVFORMAT_VERSION_MICRO = 100;
        // public static  LIBAVFORMAT_VERSION_INT = AV_VERSION_INT(LIBAVFORMAT_VERSION_MAJOR, LIBAVFORMAT_VERSION_MINOR, LIBAVFORMAT_VERSION_MICRO);
        // public static  LIBAVFORMAT_VERSION = AV_VERSION(LIBAVFORMAT_VERSION_MAJOR,   LIBAVFORMAT_VERSION_MINOR,   LIBAVFORMAT_VERSION_MICRO);
        // public static  LIBAVFORMAT_BUILD = LIBAVFORMAT_VERSION_INT;
        // public static  LIBAVFORMAT_IDENT = "Lavf" AV_STRINGIFY(LIBAVFORMAT_VERSION);
        public static bool FF_API_LAVF_BITEXACT = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_LAVF_FRAC = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_LAVF_CODEC_TB = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_URL_FEOF = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_LAVF_FMT_RAWPICTURE = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_COMPUTE_PKT_FIELDS2 = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_OLD_OPEN_CALLBACKS = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_LAVF_AVCTX = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_NOCONST_GET_SIDE_DATA = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static bool FF_API_HTTP_USER_AGENT = (LIBAVFORMAT_VERSION_MAJOR < 58);
        public static int FF_API_R_FRAME_RATE = 1;
        public static int AVIO_SEEKABLE_NORMAL = 0x0001;
        public static int AVSEEK_SIZE = 0x10000;
        public static int AVSEEK_FORCE = 0x20000;
        public static int AVIO_FLAG_READ = 1;
        public static int AVIO_FLAG_WRITE = 2;
        public static int AVIO_FLAG_READ_WRITE = (AVIO_FLAG_READ | AVIO_FLAG_WRITE);
        public static int AVIO_FLAG_NONBLOCK = 8;
        public static int AVIO_FLAG_DIRECT = 0x8000;
        
        /// <summary>Allocate and read the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">desired payload size</param>
        [DllImport("avformat-57", EntryPoint = "av_get_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
        
        /// <summary>Read data and append it to the current content of the AVPacket. If pkt->size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">amount of data to read</param>
        [DllImport("avformat-57", EntryPoint = "av_append_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_get_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_stream_get_r_frame_rate(AVStream* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_set_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_stream_set_r_frame_rate(AVStream* @s, AVRational @r);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_get_parser", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr av_stream_get_parser(AVStream* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_get_recommended_encoder_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_stream_get_recommended_encoder_configuration(AVStream* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_set_recommended_encoder_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_stream_set_recommended_encoder_configuration(AVStream* @s, byte* @configuration);
        
        /// <summary>Returns the pts of the last muxed packet + its duration</summary>
        [DllImport("avformat-57", EntryPoint = "av_stream_get_end_pts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_stream_get_end_pts(AVStream* @st);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_probe_score", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_format_get_probe_score(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_video_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* av_format_get_video_codec(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_video_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_video_codec(AVFormatContext* @s, AVCodec* @c);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_audio_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* av_format_get_audio_codec(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_audio_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_audio_codec(AVFormatContext* @s, AVCodec* @c);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_subtitle_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* av_format_get_subtitle_codec(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_subtitle_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_subtitle_codec(AVFormatContext* @s, AVCodec* @c);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_data_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* av_format_get_data_codec(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_data_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_data_codec(AVFormatContext* @s, AVCodec* @c);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_metadata_header_padding", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_format_get_metadata_header_padding(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_metadata_header_padding", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_metadata_header_padding(AVFormatContext* @s, int @c);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_format_get_opaque(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_opaque(AVFormatContext* @s, void* @opaque);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_control_message_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr av_format_get_control_message_cb(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_control_message_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_control_message_cb(AVFormatContext* @s, IntPtr @callback);
        
        [DllImport("avformat-57", EntryPoint = "av_format_get_open_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr av_format_get_open_cb(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_format_set_open_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_open_cb(AVFormatContext* @s, IntPtr @callback);
        
        /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
        [DllImport("avformat-57", EntryPoint = "av_format_inject_global_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_inject_global_side_data(AVFormatContext* @s);
        
        /// <summary>Returns the method used to set ctx->duration.</summary>
        [DllImport("avformat-57", EntryPoint = "av_fmt_ctx_get_duration_estimation_method", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx);
        
        /// <summary>Return the LIBAVFORMAT_VERSION_INT constant.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avformat_version();
        
        /// <summary>Return the libavformat build-time configuration.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avformat_configuration();
        
        /// <summary>Return the libavformat license.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avformat_license();
        
        /// <summary>Initialize libavformat and register all the muxers, demuxers and protocols. If you do not call this function, then you can select exactly which formats you want to support.</summary>
        [DllImport("avformat-57", EntryPoint = "av_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_all();
        
        [DllImport("avformat-57", EntryPoint = "av_register_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_input_format(AVInputFormat* @format);
        
        [DllImport("avformat-57", EntryPoint = "av_register_output_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_output_format(AVOutputFormat* @format);
        
        /// <summary>Do global initialization of network components. This is optional, but recommended, since it avoids the overhead of implicitly doing the setup for each session.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_network_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_network_init();
        
        /// <summary>Undo the initialization done by avformat_network_init.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_network_deinit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_network_deinit();
        
        /// <summary>If f is NULL, returns the first registered input format, if f is non-NULL, returns the next registered input format after f or NULL if f is the last one.</summary>
        [DllImport("avformat-57", EntryPoint = "av_iformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_iformat_next(AVInputFormat* @f);
        
        /// <summary>If f is NULL, returns the first registered output format, if f is non-NULL, returns the next registered output format after f or NULL if f is the last one.</summary>
        [DllImport("avformat-57", EntryPoint = "av_oformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOutputFormat* av_oformat_next(AVOutputFormat* @f);
        
        /// <summary>Allocate an AVFormatContext. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFormatContext* avformat_alloc_context();
        
        /// <summary>Free an AVFormatContext and all its streams.</summary>
        /// <param name="s">context to free</param>
        [DllImport("avformat-57", EntryPoint = "avformat_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avformat_free_context(AVFormatContext* @s);
        
        /// <summary>Get the AVClass for AVFormatContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* avformat_get_class();
        
        /// <summary>Add a new stream to a media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="c">If non-NULL, the AVCodecContext corresponding to the new stream will be initialized to use this codec. This is needed for e.g. codec-specific defaults to be set, so codec should be provided if it is known.</param>
        [DllImport("avformat-57", EntryPoint = "avformat_new_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c);
        
        /// <summary>Allocate new information from stream.</summary>
        /// <param name="stream">stream</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">side information size</param>
        [DllImport("avformat-57", EntryPoint = "av_stream_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, int @size);
        
        [DllImport("avformat-57", EntryPoint = "av_stream_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, int* @size);
        
        [DllImport("avformat-57", EntryPoint = "av_new_program", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVProgram* av_new_program(AVFormatContext* @s, int @id);
        
        /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
        /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
        /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
        [DllImport("avformat-57", EntryPoint = "avformat_alloc_output_context2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat, [MarshalAs(UnmanagedType.LPStr)] string @format_name, [MarshalAs(UnmanagedType.LPStr)] string @filename);
        
        /// <summary>Find AVInputFormat based on the short name of the input format.</summary>
        [DllImport("avformat-57", EntryPoint = "av_find_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_find_input_format([MarshalAs(UnmanagedType.LPStr)] string @short_name);
        
        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        [DllImport("avformat-57", EntryPoint = "av_probe_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened);
        
        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is < = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
        [DllImport("avformat-57", EntryPoint = "av_probe_input_format2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max);
        
        /// <summary>Guess the file format.</summary>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_ret">The score of the best detection.</param>
        [DllImport("avformat-57", EntryPoint = "av_probe_input_format3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret);
        
        /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
        /// <param name="pb">the bytestream to probe</param>
        /// <param name="fmt">the input format is put here</param>
        /// <param name="url">the url of the stream</param>
        /// <param name="logctx">the log context</param>
        /// <param name="offset">the offset within the bytestream to probe from</param>
        /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
        [DllImport("avformat-57", EntryPoint = "av_probe_input_buffer2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size);
        
        /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
        [DllImport("avformat-57", EntryPoint = "av_probe_input_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size);
        
        /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
        /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
        /// <param name="url">URL of the stream to open.</param>
        /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
        /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avformat_open_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_open_input(AVFormatContext** @ps, [MarshalAs(UnmanagedType.LPStr)] string @url, AVInputFormat* @fmt, AVDictionary** @options);
        
        [DllImport("avformat-57", EntryPoint = "av_demuxer_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_demuxer_open(AVFormatContext* @ic);
        
        /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="options">If non-NULL, an ic.nb_streams long array of pointers to dictionaries, where i-th member contains options for codec corresponding to i-th stream. On return each dictionary will be filled with options that were not found.</param>
        [DllImport("avformat-57", EntryPoint = "avformat_find_stream_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options);
        
        /// <summary>Find the programs which belong to a given stream.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="last">the last found program, the search will start after this program, or from the beginning if it is NULL</param>
        /// <param name="s">stream index</param>
        [DllImport("avformat-57", EntryPoint = "av_find_program_from_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s);
        
        [DllImport("avformat-57", EntryPoint = "av_program_add_stream_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx);
        
        /// <summary>Find the "best" stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream's codec; streams for which no decoder can be found are ignored.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="type">stream type: video, audio, subtitles, etc.</param>
        /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
        /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
        /// <param name="decoder_ret">if non-NULL, returns the decoder for the selected stream</param>
        /// <param name="flags">flags; none are currently defined</param>
        [DllImport("avformat-57", EntryPoint = "av_find_best_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
        
        /// <summary>Return the next frame of a stream. This function returns what is stored in the file, and does not validate that what is there are valid frames for the decoder. It will split what is stored in the file into frames and return one for each call. It will not omit invalid data between valid frames so as to give the decoder the maximum information possible for decoding.</summary>
        [DllImport("avformat-57", EntryPoint = "av_read_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_read_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        /// <summary>Seek to the keyframe at timestamp. 'timestamp' in 'stream_index'.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
        /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
        /// <param name="flags">flags which select direction and seeking mode</param>
        [DllImport("avformat-57", EntryPoint = "av_seek_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
        
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard < AVDISCARD_ALL.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">index of the stream which is used as time base reference</param>
        /// <param name="min_ts">smallest acceptable timestamp</param>
        /// <param name="ts">target timestamp</param>
        /// <param name="max_ts">largest acceptable timestamp</param>
        /// <param name="flags">flags</param>
        [DllImport("avformat-57", EntryPoint = "avformat_seek_file", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
        
        /// <summary>Discard all internally buffered data. This can be useful when dealing with discontinuities in the byte stream. Generally works only with formats that can resync. This includes headerless formats like MPEG-TS/TS but should also work with NUT, Ogg and in a limited way AVI for example.</summary>
        /// <param name="s">media file handle</param>
        [DllImport("avformat-57", EntryPoint = "avformat_flush", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_flush(AVFormatContext* @s);
        
        /// <summary>Start playing a network-based stream (e.g. RTSP stream) at the current position.</summary>
        [DllImport("avformat-57", EntryPoint = "av_read_play", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_read_play(AVFormatContext* @s);
        
        /// <summary>Pause a network-based stream (e.g. RTSP stream).</summary>
        [DllImport("avformat-57", EntryPoint = "av_read_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_read_pause(AVFormatContext* @s);
        
        /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_close_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avformat_close_input(AVFormatContext** @s);
        
        /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avformat_write_header", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_write_header(AVFormatContext* @s, AVDictionary** @options);
        
        /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avformat_init_output", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_init_output(AVFormatContext* @s, AVDictionary** @options);
        
        /// <summary>Write a packet to an output media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet).  This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output.  Packet's</param>
        [DllImport("avformat-57", EntryPoint = "av_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_write_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written.  If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. The caller must not access the data through this reference after this function returns. If the packet is not reference-counted, libavformat will make a copy.  This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues.  Packet's</param>
        [DllImport("avformat-57", EntryPoint = "av_interleaved_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        /// <summary>Write an uncoded frame to an output media file.</summary>
        [DllImport("avformat-57", EntryPoint = "av_write_uncoded_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        
        /// <summary>Write an uncoded frame to an output media file.</summary>
        [DllImport("avformat-57", EntryPoint = "av_interleaved_write_uncoded_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        
        /// <summary>Test whether a muxer supports uncoded frame.</summary>
        [DllImport("avformat-57", EntryPoint = "av_write_uncoded_frame_query", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index);
        
        /// <summary>Write the stream trailer to an output media file and free the file private data.</summary>
        /// <param name="s">media file handle</param>
        [DllImport("avformat-57", EntryPoint = "av_write_trailer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_write_trailer(AVFormatContext* @s);
        
        /// <summary>Return the output format in the list of registered output formats which best matches the provided parameters, or return NULL if there is no match.</summary>
        /// <param name="short_name">if non-NULL checks if short_name matches with the names of the registered formats</param>
        /// <param name="filename">if non-NULL checks if filename terminates with the extensions of the registered formats</param>
        /// <param name="mime_type">if non-NULL checks if mime_type matches with the MIME type of the registered formats</param>
        [DllImport("avformat-57", EntryPoint = "av_guess_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOutputFormat* av_guess_format([MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type);
        
        /// <summary>Guess the codec ID based upon muxer and filename.</summary>
        [DllImport("avformat-57", EntryPoint = "av_guess_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecID av_guess_codec(AVOutputFormat* @fmt, [MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type, AVMediaType @type);
        
        /// <summary>Get timing information for the data currently output. The exact meaning of "currently output" depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream">stream in the media file</param>
        /// <param name="dts">DTS of the last packet output for the stream, in stream time_base units</param>
        /// <param name="wall">absolute time when that packet whas output, in microsecond</param>
        [DllImport("avformat-57", EntryPoint = "av_get_output_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_output_timestamp(IntPtr @s, int @stream, long* @dts, long* @wall);
        
        /// <summary>Send a nice hexadecimal dump of a buffer to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        [DllImport("avformat-57", EntryPoint = "av_hex_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_hex_dump(FILE* @f, byte* @buf, int @size);
        
        /// <summary>Send a nice hexadecimal dump of a buffer to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        [DllImport("avformat-57", EntryPoint = "av_hex_dump_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size);
        
        /// <summary>Send a nice dump of a packet to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        [DllImport("avformat-57", EntryPoint = "av_pkt_dump2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_pkt_dump2(FILE* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        
        /// <summary>Send a nice dump of a packet to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        [DllImport("avformat-57", EntryPoint = "av_pkt_dump_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        
        /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="tag">codec tag to match to a codec ID</param>
        [DllImport("avformat-57", EntryPoint = "av_codec_get_id", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecID av_codec_get_id(IntPtr* @tags, uint @tag);
        
        /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec ID to match to a codec tag</param>
        [DllImport("avformat-57", EntryPoint = "av_codec_get_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_codec_get_tag(IntPtr* @tags, AVCodecID @id);
        
        /// <summary>Get the codec tag for the given codec id.</summary>
        /// <param name="tags">list of supported codec_id - codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec id that should be searched for in the list</param>
        /// <param name="tag">A pointer to the found tag</param>
        [DllImport("avformat-57", EntryPoint = "av_codec_get_tag2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_get_tag2(IntPtr* @tags, AVCodecID @id, uint* @tag);
        
        [DllImport("avformat-57", EntryPoint = "av_find_default_stream_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_find_default_stream_index(AVFormatContext* @s);
        
        /// <summary>Get the index for a specific timestamp.</summary>
        /// <param name="st">stream that the timestamp belongs to</param>
        /// <param name="timestamp">timestamp to retrieve the index for</param>
        /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is < = the requested one, if backward is 0, then it will be >= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
        [DllImport("avformat-57", EntryPoint = "av_index_search_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags);
        
        /// <summary>Add an index entry into a sorted list. Update the entry if the list already contains it.</summary>
        /// <param name="timestamp">timestamp in the time base of the given stream</param>
        [DllImport("avformat-57", EntryPoint = "av_add_index_entry", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
        
        /// <summary>Split a URL string into components.</summary>
        /// <param name="proto">the buffer for the protocol</param>
        /// <param name="proto_size">the size of the proto buffer</param>
        /// <param name="authorization">the buffer for the authorization</param>
        /// <param name="authorization_size">the size of the authorization buffer</param>
        /// <param name="hostname">the buffer for the host name</param>
        /// <param name="hostname_size">the size of the hostname buffer</param>
        /// <param name="port_ptr">a pointer to store the port number in</param>
        /// <param name="path">the buffer for the path</param>
        /// <param name="path_size">the size of the path buffer</param>
        /// <param name="url">the URL to split</param>
        [DllImport("avformat-57", EntryPoint = "av_url_split", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, [MarshalAs(UnmanagedType.LPStr)] string @url);
        
        /// <summary>Print detailed information about the input or output format, such as duration, bitrate, streams, container, programs, metadata, side data, codec and time base.</summary>
        /// <param name="ic">the context to analyze</param>
        /// <param name="index">index of the stream to dump information about</param>
        /// <param name="url">the URL to print, such as source or destination file</param>
        /// <param name="is_output">Select whether the specified context is an input(0) or output(1)</param>
        [DllImport("avformat-57", EntryPoint = "av_dump_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_dump_format(AVFormatContext* @ic, int @index, [MarshalAs(UnmanagedType.LPStr)] string @url, int @is_output);
        
        /// <summary>Return in 'buf' the path with '%d' replaced by a number.</summary>
        /// <param name="buf">destination buffer</param>
        /// <param name="buf_size">destination buffer size</param>
        /// <param name="path">numbered sequence string</param>
        /// <param name="number">frame number</param>
        /// <param name="flags">AV_FRAME_FILENAME_FLAGS_*</param>
        [DllImport("avformat-57", EntryPoint = "av_get_frame_filename2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_frame_filename2(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number, int @flags);
        
        [DllImport("avformat-57", EntryPoint = "av_get_frame_filename", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_frame_filename(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number);
        
        /// <summary>Check whether filename actually is a numbered sequence generator.</summary>
        /// <param name="filename">possible numbered sequence string</param>
        [DllImport("avformat-57", EntryPoint = "av_filename_number_test", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_filename_number_test([MarshalAs(UnmanagedType.LPStr)] string @filename);
        
        /// <summary>Generate an SDP for an RTP session.</summary>
        /// <param name="ac">array of AVFormatContexts describing the RTP streams. If the array is composed by only one context, such context can contain multiple AVStreams (one AVStream per RTP stream). Otherwise, all the contexts in the array (an AVCodecContext per RTP stream) must contain only one AVStream.</param>
        /// <param name="n_files">number of AVCodecContexts contained in ac</param>
        /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
        /// <param name="size">the size of the buffer</param>
        [DllImport("avformat-57", EntryPoint = "av_sdp_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_sdp_create(AVFormatContext*[] @ac, int @n_files, byte* @buf, int @size);
        
        /// <summary>Return a positive value if the given filename has one of the given extensions, 0 otherwise.</summary>
        /// <param name="filename">file name to check against the given extensions</param>
        /// <param name="extensions">a comma-separated list of filename extensions</param>
        [DllImport("avformat-57", EntryPoint = "av_match_ext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_match_ext([MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @extensions);
        
        /// <summary>Test if the given container can store a codec.</summary>
        /// <param name="ofmt">container to check for compatibility</param>
        /// <param name="codec_id">codec to potentially store in container</param>
        /// <param name="std_compliance">standards compliance level, one of FF_COMPLIANCE_*</param>
        [DllImport("avformat-57", EntryPoint = "avformat_query_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
        
        /// <summary>@{ Get the tables mapping RIFF FourCCs to libavcodec AVCodecIDs. The tables are meant to be passed to av_codec_get_id()/av_codec_get_tag() as in the following code:</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_get_riff_video_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr avformat_get_riff_video_tags();
        
        /// <summary>Returns the table mapping RIFF FourCCs for audio to AVCodecID.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_get_riff_audio_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr avformat_get_riff_audio_tags();
        
        /// <summary>Returns the table mapping MOV FourCCs for video to libavcodec AVCodecID.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_get_mov_video_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr avformat_get_mov_video_tags();
        
        /// <summary>Returns the table mapping MOV FourCCs for audio to AVCodecID.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_get_mov_audio_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr avformat_get_mov_audio_tags();
        
        /// <summary>Guess the sample aspect ratio of a frame, based on both the stream and the frame aspect ratio.</summary>
        /// <param name="format">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame with the aspect ratio to be determined</param>
        [DllImport("avformat-57", EntryPoint = "av_guess_sample_aspect_ratio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
        
        /// <summary>Guess the frame rate, based on both the container and codec information.</summary>
        /// <param name="ctx">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame for which the frame rate should be determined, may be NULL</param>
        [DllImport("avformat-57", EntryPoint = "av_guess_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
        
        /// <summary>Check if the stream st contained in s is matched by the stream specifier spec.</summary>
        [DllImport("avformat-57", EntryPoint = "avformat_match_stream_specifier", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st, [MarshalAs(UnmanagedType.LPStr)] string @spec);
        
        [DllImport("avformat-57", EntryPoint = "avformat_queue_attached_pictures", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_queue_attached_pictures(AVFormatContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "av_apply_bitstream_filters", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_apply_bitstream_filters(AVCodecContext* @codec, AVPacket* @pkt, AVBitStreamFilterContext* @bsfc);
        
        /// <summary>Transfer internal timing information from one stream to another.</summary>
        /// <param name="ofmt">target output format for ost</param>
        /// <param name="ost">output stream which needs timings copy and adjustments</param>
        /// <param name="ist">reference input stream to copy timings from</param>
        /// <param name="copy_tb">define from where the stream codec timebase needs to be imported</param>
        [DllImport("avformat-57", EntryPoint = "avformat_transfer_internal_stream_timing_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
        
        /// <summary>Get the internal codec timebase from a stream.</summary>
        /// <param name="st">input stream to extract the timebase from</param>
        [DllImport("avformat-57", EntryPoint = "av_stream_get_codec_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_stream_get_codec_timebase(AVStream* @st);
        
        /// <summary>Return the name of the protocol that will handle the passed URL.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_find_protocol_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avio_find_protocol_name([MarshalAs(UnmanagedType.LPStr)] string @url);
        
        /// <summary>Return AVIO_FLAG_* access flags corresponding to the access permissions of the resource in url, or a negative value corresponding to an AVERROR code in case of failure. The returned access flags are masked by the value in flags.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_check", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_check([MarshalAs(UnmanagedType.LPStr)] string @url, int @flags);
        
        /// <summary>Move or rename a resource.</summary>
        /// <param name="url_src">url to resource to be moved</param>
        /// <param name="url_dst">new url to resource if the operation succeeded</param>
        [DllImport("avformat-57", EntryPoint = "avpriv_io_move", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpriv_io_move([MarshalAs(UnmanagedType.LPStr)] string @url_src, [MarshalAs(UnmanagedType.LPStr)] string @url_dst);
        
        /// <summary>Delete a resource.</summary>
        /// <param name="url">resource to be deleted.</param>
        [DllImport("avformat-57", EntryPoint = "avpriv_io_delete", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpriv_io_delete([MarshalAs(UnmanagedType.LPStr)] string @url);
        
        /// <summary>Open directory for reading.</summary>
        /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
        /// <param name="url">directory to be listed.</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avio_open_dir", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_open_dir(AVIODirContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, AVDictionary** @options);
        
        /// <summary>Get next directory entry.</summary>
        /// <param name="s">directory read context.</param>
        /// <param name="next">next entry or NULL when no more entries.</param>
        [DllImport("avformat-57", EntryPoint = "avio_read_dir", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next);
        
        /// <summary>Close directory.</summary>
        /// <param name="s">directory read context.</param>
        [DllImport("avformat-57", EntryPoint = "avio_close_dir", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_close_dir(AVIODirContext** @s);
        
        /// <summary>Free entry allocated by avio_read_dir().</summary>
        /// <param name="entry">entry to be freed.</param>
        [DllImport("avformat-57", EntryPoint = "avio_free_directory_entry", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_free_directory_entry(AVIODirEntry** @entry);
        
        /// <summary>Allocate and initialize an AVIOContext for buffered I/O. It must be later freed with av_free().</summary>
        /// <param name="buffer">Memory block for input/output operations via AVIOContext. The buffer must be allocated with av_malloc() and friends. It may be freed and replaced with a new buffer by libavformat. AVIOContext.buffer holds the buffer currently in use, which must be later freed with av_free().</param>
        /// <param name="buffer_size">The buffer size is very important for performance. For protocols with fixed blocksize it should be set to this blocksize. For others a typical size is a cache page, e.g. 4kb.</param>
        /// <param name="write_flag">Set to 1 if the buffer should be writable, 0 otherwise.</param>
        /// <param name="opaque">An opaque pointer to user-specific data.</param>
        /// <param name="read_packet">A function for refilling the buffer, may be NULL.</param>
        /// <param name="write_packet">A function for writing the buffer contents, may be NULL. The function may not change the input buffers content.</param>
        /// <param name="seek">A function for seeking to specified byte position, may be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avio_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, IntPtr @read_packet, IntPtr @write_packet, IntPtr @seek);
        
        [DllImport("avformat-57", EntryPoint = "avio_w8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_w8(AVIOContext* @s, int @b);
        
        [DllImport("avformat-57", EntryPoint = "avio_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_write(AVIOContext* @s, byte* @buf, int @size);
        
        [DllImport("avformat-57", EntryPoint = "avio_wl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wl64(AVIOContext* @s, ulong @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wb64(AVIOContext* @s, ulong @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wl32(AVIOContext* @s, uint @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wb32(AVIOContext* @s, uint @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wl24(AVIOContext* @s, uint @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wb24(AVIOContext* @s, uint @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wl16(AVIOContext* @s, uint @val);
        
        [DllImport("avformat-57", EntryPoint = "avio_wb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_wb16(AVIOContext* @s, uint @val);
        
        /// <summary>Write a NULL-terminated string.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_put_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_put_str(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        
        /// <summary>Convert an UTF-8 string to UTF-16LE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        [DllImport("avformat-57", EntryPoint = "avio_put_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_put_str16le(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        
        /// <summary>Convert an UTF-8 string to UTF-16BE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        [DllImport("avformat-57", EntryPoint = "avio_put_str16be", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_put_str16be(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        
        /// <summary>Mark the written bytestream as a specific type.</summary>
        /// <param name="time">the stream time the current bytestream pos corresponds to (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
        /// <param name="type">the kind of data written starting at the current pos</param>
        [DllImport("avformat-57", EntryPoint = "avio_write_marker", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type);
        
        /// <summary>fseek() equivalent for AVIOContext.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_seek", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long avio_seek(AVIOContext* @s, long @offset, int @whence);
        
        /// <summary>Skip given number of bytes forward</summary>
        [DllImport("avformat-57", EntryPoint = "avio_skip", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long avio_skip(AVIOContext* @s, long @offset);
        
        /// <summary>Get the filesize.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long avio_size(AVIOContext* @s);
        
        /// <summary>feof() equivalent for AVIOContext.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_feof", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_feof(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "url_feof", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int url_feof(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_printf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_printf(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @fmt);
        
        /// <summary>Force flushing of buffered data.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_flush", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avio_flush(AVIOContext* @s);
        
        /// <summary>Read size bytes from AVIOContext into buf.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_read(AVIOContext* @s, byte* @buf, int @size);
        
        /// <summary>@{</summary>
        [DllImport("avformat-57", EntryPoint = "avio_r8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_r8(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rl16(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rl24(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rl32(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong avio_rl64(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rb16(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rb24(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avio_rb32(AVIOContext* @s);
        
        [DllImport("avformat-57", EntryPoint = "avio_rb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong avio_rb64(AVIOContext* @s);
        
        /// <summary>Read a string from pb into buf. The reading will terminate when either a NULL character was encountered, maxlen bytes have been read, or nothing more can be read from pb. The result is guaranteed to be NULL-terminated, it will be truncated if buf is too small. Note that the string is not interpreted or validated in any way, it might get truncated in the middle of a sequence for multi-byte encodings.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_get_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        /// <summary>Read a UTF-16 string from pb and convert it to UTF-8. The reading will terminate when either a null or invalid character was encountered or maxlen bytes have been read.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_get_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        [DllImport("avformat-57", EntryPoint = "avio_get_str16be", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        [DllImport("avformat-57", EntryPoint = "avio_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_open(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags);
        
        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        [DllImport("avformat-57", EntryPoint = "avio_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_open2(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
        
        /// <summary>Close the resource accessed by the AVIOContext s and free it. This function can only be used if s was opened by avio_open().</summary>
        [DllImport("avformat-57", EntryPoint = "avio_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_close(AVIOContext* @s);
        
        /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
        [DllImport("avformat-57", EntryPoint = "avio_closep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_closep(AVIOContext** @s);
        
        /// <summary>Open a write only memory stream.</summary>
        /// <param name="s">new IO context</param>
        [DllImport("avformat-57", EntryPoint = "avio_open_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_open_dyn_buf(AVIOContext** @s);
        
        /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
        /// <param name="s">IO context</param>
        /// <param name="pbuffer">pointer to a byte buffer</param>
        [DllImport("avformat-57", EntryPoint = "avio_close_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer);
        
        /// <summary>Iterate through names of available protocols.</summary>
        /// <param name="opaque">A private pointer representing current protocol. It must be a pointer to NULL on first iteration and will be updated by successive calls to avio_enum_protocols.</param>
        /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
        [DllImport("avformat-57", EntryPoint = "avio_enum_protocols", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avio_enum_protocols(void** @opaque, int @output);
        
        /// <summary>Pause and resume playing - only meaningful if using a network streaming protocol (e.g. MMS).</summary>
        /// <param name="h">IO context from which to call the read_pause function pointer</param>
        /// <param name="pause">1 for pause, 0 for resume</param>
        [DllImport("avformat-57", EntryPoint = "avio_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_pause(AVIOContext* @h, int @pause);
        
        /// <summary>Seek to a given timestamp relative to some component stream. Only meaningful if using a network streaming protocol (e.g. MMS.).</summary>
        /// <param name="h">IO context from which to call the seek function pointers</param>
        /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index >= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
        /// <param name="timestamp">timestamp in AVStream.time_base units or if there is no stream specified then in AV_TIME_BASE units.</param>
        /// <param name="flags">Optional combination of AVSEEK_FLAG_BACKWARD, AVSEEK_FLAG_BYTE and AVSEEK_FLAG_ANY. The protocol may silently ignore AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will fail if used and not supported.</param>
        [DllImport("avformat-57", EntryPoint = "avio_seek_time", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
        
        /// <summary>Read contents of h into print buffer, up to max_size bytes, or up to EOF.</summary>
        [DllImport("avformat-57", EntryPoint = "avio_read_to_bprint", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_read_to_bprint(AVIOContext* @h, IntPtr @pb, ulong @max_size);
        
        /// <summary>Accept and allocate a client context on a server context.</summary>
        /// <param name="s">the server context</param>
        /// <param name="c">the client context, must be unallocated</param>
        [DllImport("avformat-57", EntryPoint = "avio_accept", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_accept(AVIOContext* @s, AVIOContext** @c);
        
        /// <summary>Perform one step of the protocol handshake to accept a new client. This function must be called on a client returned by avio_accept() before using it as a read/write context. It is separate from avio_accept() because it may block. A step of the handshake is defined by places where the application may decide to change the proceedings. For example, on a protocol with a request header and a reply header, each one can constitute a step because the application may use the parameters from the request to change parameters in the reply; or each individual chunk of the request can constitute a step. If the handshake is already finished, avio_handshake() does nothing and returns 0 immediately.</summary>
        /// <param name="c">the client context to perform the handshake on</param>
        [DllImport("avformat-57", EntryPoint = "avio_handshake", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avio_handshake(AVIOContext* @c);
        
    }
}
