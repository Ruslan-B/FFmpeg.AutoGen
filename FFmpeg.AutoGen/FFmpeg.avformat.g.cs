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
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avio_alloc_context_read_packet (void* @opaque, byte* @buf, int @buf_size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avio_alloc_context_write_packet (void* @opaque, byte* @buf, int @buf_size);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long avio_alloc_context_seek (void* @opaque, long @offset, int @whence);
    
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
        /// <summary>Trailer data, which doesn&apos;t contain actual content, but only for finalizing the output file.</summary>
        @AVIO_DATA_MARKER_TRAILER = 4,
    }
    
    public unsafe struct long_array17
    {
        public long @at0; public long @at1; public long @at2; public long @at3; public long @at4; public long @at5; public long @at6; public long @at7; public long @at8; public long @at9; public long @at10; public long @at11; public long @at12; public long @at13; public long @at14; public long @at15; public long @at16;
        
        public static readonly int Size = 17;
        public long this[uint index]
        {
            get { fixed (long* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); return *(p0 + index); } }
            set { fixed (long* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); *(p0 + index) = value;  } }
        }
        public long[] ToArray()
        {
            fixed (long* p0 = &at0) { var array = new long[Size]; for (uint i = 0; i < Size; i++) array[i] = *(p0 + i); return array; }
        }
        public void FromArray(long[] array)
        {
            fixed (long* p0 = &at0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator long[](long_array17 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_array17
    {
        public byte @at0; public byte @at1; public byte @at2; public byte @at3; public byte @at4; public byte @at5; public byte @at6; public byte @at7; public byte @at8; public byte @at9; public byte @at10; public byte @at11; public byte @at12; public byte @at13; public byte @at14; public byte @at15; public byte @at16;
        
        public static readonly int Size = 17;
        public byte this[uint index]
        {
            get { fixed (byte* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); return *(p0 + index); } }
            set { fixed (byte* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); *(p0 + index) = value;  } }
        }
        public byte[] ToArray()
        {
            fixed (byte* p0 = &at0) { var array = new byte[Size]; for (uint i = 0; i < Size; i++) array[i] = *(p0 + i); return array; }
        }
        public void FromArray(byte[] array)
        {
            fixed (byte* p0 = &at0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator byte[](byte_array17 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_array1024
    {
        public byte @at0; public byte @at1; public byte @at2; public byte @at3; public byte @at4; public byte @at5; public byte @at6; public byte @at7; public byte @at8; public byte @at9; public byte @at10; public byte @at11; public byte @at12; public byte @at13; public byte @at14; public byte @at15; public byte @at16; public byte @at17; public byte @at18; public byte @at19; public byte @at20; public byte @at21; public byte @at22; public byte @at23; public byte @at24; public byte @at25; public byte @at26; public byte @at27; public byte @at28; public byte @at29; public byte @at30; public byte @at31; public byte @at32; public byte @at33; public byte @at34; public byte @at35; public byte @at36; public byte @at37; public byte @at38; public byte @at39; public byte @at40; public byte @at41; public byte @at42; public byte @at43; public byte @at44; public byte @at45; public byte @at46; public byte @at47; public byte @at48; public byte @at49; public byte @at50; public byte @at51; public byte @at52; public byte @at53; public byte @at54; public byte @at55; public byte @at56; public byte @at57; public byte @at58; public byte @at59; public byte @at60; public byte @at61; public byte @at62; public byte @at63; public byte @at64; public byte @at65; public byte @at66; public byte @at67; public byte @at68; public byte @at69; public byte @at70; public byte @at71; public byte @at72; public byte @at73; public byte @at74; public byte @at75; public byte @at76; public byte @at77; public byte @at78; public byte @at79; public byte @at80; public byte @at81; public byte @at82; public byte @at83; public byte @at84; public byte @at85; public byte @at86; public byte @at87; public byte @at88; public byte @at89; public byte @at90; public byte @at91; public byte @at92; public byte @at93; public byte @at94; public byte @at95; public byte @at96; public byte @at97; public byte @at98; public byte @at99; public byte @at100; public byte @at101; public byte @at102; public byte @at103; public byte @at104; public byte @at105; public byte @at106; public byte @at107; public byte @at108; public byte @at109; public byte @at110; public byte @at111; public byte @at112; public byte @at113; public byte @at114; public byte @at115; public byte @at116; public byte @at117; public byte @at118; public byte @at119; public byte @at120; public byte @at121; public byte @at122; public byte @at123; public byte @at124; public byte @at125; public byte @at126; public byte @at127; public byte @at128; public byte @at129; public byte @at130; public byte @at131; public byte @at132; public byte @at133; public byte @at134; public byte @at135; public byte @at136; public byte @at137; public byte @at138; public byte @at139; public byte @at140; public byte @at141; public byte @at142; public byte @at143; public byte @at144; public byte @at145; public byte @at146; public byte @at147; public byte @at148; public byte @at149; public byte @at150; public byte @at151; public byte @at152; public byte @at153; public byte @at154; public byte @at155; public byte @at156; public byte @at157; public byte @at158; public byte @at159; public byte @at160; public byte @at161; public byte @at162; public byte @at163; public byte @at164; public byte @at165; public byte @at166; public byte @at167; public byte @at168; public byte @at169; public byte @at170; public byte @at171; public byte @at172; public byte @at173; public byte @at174; public byte @at175; public byte @at176; public byte @at177; public byte @at178; public byte @at179; public byte @at180; public byte @at181; public byte @at182; public byte @at183; public byte @at184; public byte @at185; public byte @at186; public byte @at187; public byte @at188; public byte @at189; public byte @at190; public byte @at191; public byte @at192; public byte @at193; public byte @at194; public byte @at195; public byte @at196; public byte @at197; public byte @at198; public byte @at199; public byte @at200; public byte @at201; public byte @at202; public byte @at203; public byte @at204; public byte @at205; public byte @at206; public byte @at207; public byte @at208; public byte @at209; public byte @at210; public byte @at211; public byte @at212; public byte @at213; public byte @at214; public byte @at215; public byte @at216; public byte @at217; public byte @at218; public byte @at219; public byte @at220; public byte @at221; public byte @at222; public byte @at223; public byte @at224; public byte @at225; public byte @at226; public byte @at227; public byte @at228; public byte @at229; public byte @at230; public byte @at231; public byte @at232; public byte @at233; public byte @at234; public byte @at235; public byte @at236; public byte @at237; public byte @at238; public byte @at239; public byte @at240; public byte @at241; public byte @at242; public byte @at243; public byte @at244; public byte @at245; public byte @at246; public byte @at247; public byte @at248; public byte @at249; public byte @at250; public byte @at251; public byte @at252; public byte @at253; public byte @at254; public byte @at255; public byte @at256; public byte @at257; public byte @at258; public byte @at259; public byte @at260; public byte @at261; public byte @at262; public byte @at263; public byte @at264; public byte @at265; public byte @at266; public byte @at267; public byte @at268; public byte @at269; public byte @at270; public byte @at271; public byte @at272; public byte @at273; public byte @at274; public byte @at275; public byte @at276; public byte @at277; public byte @at278; public byte @at279; public byte @at280; public byte @at281; public byte @at282; public byte @at283; public byte @at284; public byte @at285; public byte @at286; public byte @at287; public byte @at288; public byte @at289; public byte @at290; public byte @at291; public byte @at292; public byte @at293; public byte @at294; public byte @at295; public byte @at296; public byte @at297; public byte @at298; public byte @at299; public byte @at300; public byte @at301; public byte @at302; public byte @at303; public byte @at304; public byte @at305; public byte @at306; public byte @at307; public byte @at308; public byte @at309; public byte @at310; public byte @at311; public byte @at312; public byte @at313; public byte @at314; public byte @at315; public byte @at316; public byte @at317; public byte @at318; public byte @at319; public byte @at320; public byte @at321; public byte @at322; public byte @at323; public byte @at324; public byte @at325; public byte @at326; public byte @at327; public byte @at328; public byte @at329; public byte @at330; public byte @at331; public byte @at332; public byte @at333; public byte @at334; public byte @at335; public byte @at336; public byte @at337; public byte @at338; public byte @at339; public byte @at340; public byte @at341; public byte @at342; public byte @at343; public byte @at344; public byte @at345; public byte @at346; public byte @at347; public byte @at348; public byte @at349; public byte @at350; public byte @at351; public byte @at352; public byte @at353; public byte @at354; public byte @at355; public byte @at356; public byte @at357; public byte @at358; public byte @at359; public byte @at360; public byte @at361; public byte @at362; public byte @at363; public byte @at364; public byte @at365; public byte @at366; public byte @at367; public byte @at368; public byte @at369; public byte @at370; public byte @at371; public byte @at372; public byte @at373; public byte @at374; public byte @at375; public byte @at376; public byte @at377; public byte @at378; public byte @at379; public byte @at380; public byte @at381; public byte @at382; public byte @at383; public byte @at384; public byte @at385; public byte @at386; public byte @at387; public byte @at388; public byte @at389; public byte @at390; public byte @at391; public byte @at392; public byte @at393; public byte @at394; public byte @at395; public byte @at396; public byte @at397; public byte @at398; public byte @at399; public byte @at400; public byte @at401; public byte @at402; public byte @at403; public byte @at404; public byte @at405; public byte @at406; public byte @at407; public byte @at408; public byte @at409; public byte @at410; public byte @at411; public byte @at412; public byte @at413; public byte @at414; public byte @at415; public byte @at416; public byte @at417; public byte @at418; public byte @at419; public byte @at420; public byte @at421; public byte @at422; public byte @at423; public byte @at424; public byte @at425; public byte @at426; public byte @at427; public byte @at428; public byte @at429; public byte @at430; public byte @at431; public byte @at432; public byte @at433; public byte @at434; public byte @at435; public byte @at436; public byte @at437; public byte @at438; public byte @at439; public byte @at440; public byte @at441; public byte @at442; public byte @at443; public byte @at444; public byte @at445; public byte @at446; public byte @at447; public byte @at448; public byte @at449; public byte @at450; public byte @at451; public byte @at452; public byte @at453; public byte @at454; public byte @at455; public byte @at456; public byte @at457; public byte @at458; public byte @at459; public byte @at460; public byte @at461; public byte @at462; public byte @at463; public byte @at464; public byte @at465; public byte @at466; public byte @at467; public byte @at468; public byte @at469; public byte @at470; public byte @at471; public byte @at472; public byte @at473; public byte @at474; public byte @at475; public byte @at476; public byte @at477; public byte @at478; public byte @at479; public byte @at480; public byte @at481; public byte @at482; public byte @at483; public byte @at484; public byte @at485; public byte @at486; public byte @at487; public byte @at488; public byte @at489; public byte @at490; public byte @at491; public byte @at492; public byte @at493; public byte @at494; public byte @at495; public byte @at496; public byte @at497; public byte @at498; public byte @at499; public byte @at500; public byte @at501; public byte @at502; public byte @at503; public byte @at504; public byte @at505; public byte @at506; public byte @at507; public byte @at508; public byte @at509; public byte @at510; public byte @at511; public byte @at512; public byte @at513; public byte @at514; public byte @at515; public byte @at516; public byte @at517; public byte @at518; public byte @at519; public byte @at520; public byte @at521; public byte @at522; public byte @at523; public byte @at524; public byte @at525; public byte @at526; public byte @at527; public byte @at528; public byte @at529; public byte @at530; public byte @at531; public byte @at532; public byte @at533; public byte @at534; public byte @at535; public byte @at536; public byte @at537; public byte @at538; public byte @at539; public byte @at540; public byte @at541; public byte @at542; public byte @at543; public byte @at544; public byte @at545; public byte @at546; public byte @at547; public byte @at548; public byte @at549; public byte @at550; public byte @at551; public byte @at552; public byte @at553; public byte @at554; public byte @at555; public byte @at556; public byte @at557; public byte @at558; public byte @at559; public byte @at560; public byte @at561; public byte @at562; public byte @at563; public byte @at564; public byte @at565; public byte @at566; public byte @at567; public byte @at568; public byte @at569; public byte @at570; public byte @at571; public byte @at572; public byte @at573; public byte @at574; public byte @at575; public byte @at576; public byte @at577; public byte @at578; public byte @at579; public byte @at580; public byte @at581; public byte @at582; public byte @at583; public byte @at584; public byte @at585; public byte @at586; public byte @at587; public byte @at588; public byte @at589; public byte @at590; public byte @at591; public byte @at592; public byte @at593; public byte @at594; public byte @at595; public byte @at596; public byte @at597; public byte @at598; public byte @at599; public byte @at600; public byte @at601; public byte @at602; public byte @at603; public byte @at604; public byte @at605; public byte @at606; public byte @at607; public byte @at608; public byte @at609; public byte @at610; public byte @at611; public byte @at612; public byte @at613; public byte @at614; public byte @at615; public byte @at616; public byte @at617; public byte @at618; public byte @at619; public byte @at620; public byte @at621; public byte @at622; public byte @at623; public byte @at624; public byte @at625; public byte @at626; public byte @at627; public byte @at628; public byte @at629; public byte @at630; public byte @at631; public byte @at632; public byte @at633; public byte @at634; public byte @at635; public byte @at636; public byte @at637; public byte @at638; public byte @at639; public byte @at640; public byte @at641; public byte @at642; public byte @at643; public byte @at644; public byte @at645; public byte @at646; public byte @at647; public byte @at648; public byte @at649; public byte @at650; public byte @at651; public byte @at652; public byte @at653; public byte @at654; public byte @at655; public byte @at656; public byte @at657; public byte @at658; public byte @at659; public byte @at660; public byte @at661; public byte @at662; public byte @at663; public byte @at664; public byte @at665; public byte @at666; public byte @at667; public byte @at668; public byte @at669; public byte @at670; public byte @at671; public byte @at672; public byte @at673; public byte @at674; public byte @at675; public byte @at676; public byte @at677; public byte @at678; public byte @at679; public byte @at680; public byte @at681; public byte @at682; public byte @at683; public byte @at684; public byte @at685; public byte @at686; public byte @at687; public byte @at688; public byte @at689; public byte @at690; public byte @at691; public byte @at692; public byte @at693; public byte @at694; public byte @at695; public byte @at696; public byte @at697; public byte @at698; public byte @at699; public byte @at700; public byte @at701; public byte @at702; public byte @at703; public byte @at704; public byte @at705; public byte @at706; public byte @at707; public byte @at708; public byte @at709; public byte @at710; public byte @at711; public byte @at712; public byte @at713; public byte @at714; public byte @at715; public byte @at716; public byte @at717; public byte @at718; public byte @at719; public byte @at720; public byte @at721; public byte @at722; public byte @at723; public byte @at724; public byte @at725; public byte @at726; public byte @at727; public byte @at728; public byte @at729; public byte @at730; public byte @at731; public byte @at732; public byte @at733; public byte @at734; public byte @at735; public byte @at736; public byte @at737; public byte @at738; public byte @at739; public byte @at740; public byte @at741; public byte @at742; public byte @at743; public byte @at744; public byte @at745; public byte @at746; public byte @at747; public byte @at748; public byte @at749; public byte @at750; public byte @at751; public byte @at752; public byte @at753; public byte @at754; public byte @at755; public byte @at756; public byte @at757; public byte @at758; public byte @at759; public byte @at760; public byte @at761; public byte @at762; public byte @at763; public byte @at764; public byte @at765; public byte @at766; public byte @at767; public byte @at768; public byte @at769; public byte @at770; public byte @at771; public byte @at772; public byte @at773; public byte @at774; public byte @at775; public byte @at776; public byte @at777; public byte @at778; public byte @at779; public byte @at780; public byte @at781; public byte @at782; public byte @at783; public byte @at784; public byte @at785; public byte @at786; public byte @at787; public byte @at788; public byte @at789; public byte @at790; public byte @at791; public byte @at792; public byte @at793; public byte @at794; public byte @at795; public byte @at796; public byte @at797; public byte @at798; public byte @at799; public byte @at800; public byte @at801; public byte @at802; public byte @at803; public byte @at804; public byte @at805; public byte @at806; public byte @at807; public byte @at808; public byte @at809; public byte @at810; public byte @at811; public byte @at812; public byte @at813; public byte @at814; public byte @at815; public byte @at816; public byte @at817; public byte @at818; public byte @at819; public byte @at820; public byte @at821; public byte @at822; public byte @at823; public byte @at824; public byte @at825; public byte @at826; public byte @at827; public byte @at828; public byte @at829; public byte @at830; public byte @at831; public byte @at832; public byte @at833; public byte @at834; public byte @at835; public byte @at836; public byte @at837; public byte @at838; public byte @at839; public byte @at840; public byte @at841; public byte @at842; public byte @at843; public byte @at844; public byte @at845; public byte @at846; public byte @at847; public byte @at848; public byte @at849; public byte @at850; public byte @at851; public byte @at852; public byte @at853; public byte @at854; public byte @at855; public byte @at856; public byte @at857; public byte @at858; public byte @at859; public byte @at860; public byte @at861; public byte @at862; public byte @at863; public byte @at864; public byte @at865; public byte @at866; public byte @at867; public byte @at868; public byte @at869; public byte @at870; public byte @at871; public byte @at872; public byte @at873; public byte @at874; public byte @at875; public byte @at876; public byte @at877; public byte @at878; public byte @at879; public byte @at880; public byte @at881; public byte @at882; public byte @at883; public byte @at884; public byte @at885; public byte @at886; public byte @at887; public byte @at888; public byte @at889; public byte @at890; public byte @at891; public byte @at892; public byte @at893; public byte @at894; public byte @at895; public byte @at896; public byte @at897; public byte @at898; public byte @at899; public byte @at900; public byte @at901; public byte @at902; public byte @at903; public byte @at904; public byte @at905; public byte @at906; public byte @at907; public byte @at908; public byte @at909; public byte @at910; public byte @at911; public byte @at912; public byte @at913; public byte @at914; public byte @at915; public byte @at916; public byte @at917; public byte @at918; public byte @at919; public byte @at920; public byte @at921; public byte @at922; public byte @at923; public byte @at924; public byte @at925; public byte @at926; public byte @at927; public byte @at928; public byte @at929; public byte @at930; public byte @at931; public byte @at932; public byte @at933; public byte @at934; public byte @at935; public byte @at936; public byte @at937; public byte @at938; public byte @at939; public byte @at940; public byte @at941; public byte @at942; public byte @at943; public byte @at944; public byte @at945; public byte @at946; public byte @at947; public byte @at948; public byte @at949; public byte @at950; public byte @at951; public byte @at952; public byte @at953; public byte @at954; public byte @at955; public byte @at956; public byte @at957; public byte @at958; public byte @at959; public byte @at960; public byte @at961; public byte @at962; public byte @at963; public byte @at964; public byte @at965; public byte @at966; public byte @at967; public byte @at968; public byte @at969; public byte @at970; public byte @at971; public byte @at972; public byte @at973; public byte @at974; public byte @at975; public byte @at976; public byte @at977; public byte @at978; public byte @at979; public byte @at980; public byte @at981; public byte @at982; public byte @at983; public byte @at984; public byte @at985; public byte @at986; public byte @at987; public byte @at988; public byte @at989; public byte @at990; public byte @at991; public byte @at992; public byte @at993; public byte @at994; public byte @at995; public byte @at996; public byte @at997; public byte @at998; public byte @at999; public byte @at1000; public byte @at1001; public byte @at1002; public byte @at1003; public byte @at1004; public byte @at1005; public byte @at1006; public byte @at1007; public byte @at1008; public byte @at1009; public byte @at1010; public byte @at1011; public byte @at1012; public byte @at1013; public byte @at1014; public byte @at1015; public byte @at1016; public byte @at1017; public byte @at1018; public byte @at1019; public byte @at1020; public byte @at1021; public byte @at1022; public byte @at1023;
        
        public static readonly int Size = 1024;
        public byte this[uint index]
        {
            get { fixed (byte* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); return *(p0 + index); } }
            set { fixed (byte* p0 = &at0) { if (index > Size) throw new ArgumentOutOfRangeException(); *(p0 + index) = value;  } }
        }
        public byte[] ToArray()
        {
            fixed (byte* p0 = &at0) { var array = new byte[Size]; for (uint i = 0; i < Size; i++) array[i] = *(p0 + i); return array; }
        }
        public void FromArray(byte[] array)
        {
            fixed (byte* p0 = &at0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator byte[](byte_array1024 @struct) => @struct.ToArray();
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
        /// <summary>stream probing state -1 -&gt; probing finished 0 -&gt; no probing requested rest -&gt; perform probing with request_probe being the minimum score to accept. NOT PART OF PUBLIC API</summary>
        public int @request_probe;
        /// <summary>Indicates that everything up to the next keyframe should be discarded.</summary>
        public int @skip_to_keyframe;
        /// <summary>Number of samples to skip at the start of the frame decoded from the next packet.</summary>
        public int @skip_samples;
        /// <summary>If not 0, the number of samples that should be skipped from the start of the stream (the samples are removed from packets with pts==0, which also assumes negative timestamps do not happen). Intended for use with formats such as mp3 with ad-hoc gapless audio support.</summary>
        public long @start_skip_samples;
        /// <summary>If not 0, the first audio sample that should be discarded from the stream. This is broken by design (needs global sample count), but can&apos;t be avoided for broken by design formats such as mp3 with ad-hoc gapless audio support.</summary>
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
        /// <summary>String containing paris of key and values describing recommended encoder configuration. Paris are separated by &apos;,&apos;. Keys are separated from values by &apos;=&apos;.</summary>
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
    
    /// <summary>The exact value of the fractional number is: &apos;val + num / den&apos;. num is assumed to be 0 &lt;= num &lt; den.</summary>
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
        /// <summary>List of supported codec_id-codec_tag pairs, ordered by &quot;better choice first&quot;. The arrays are all terminated by AV_CODEC_ID_NONE.</summary>
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
        /// <summary>Read the format header and initialize the AVFormatContext structure. Return 0 if OK. &apos;avformat_new_stream&apos; should be called to create new streams.</summary>
        public AVInputFormat_read_header_wrapper @read_header;
        /// <summary>Read one packet and put it in &apos;pkt&apos;. pts and flags are also set. &apos;avformat_new_stream&apos; can be called only if the flag AVFMTCTX_NOHEADER is used and only in the calling thread (not in a background thread).</summary>
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
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
        public AVInputFormat_read_seek2_wrapper @read_seek2;
        /// <summary>Returns device list with it properties.</summary>
        public AVInputFormat_get_device_list_wrapper @get_device_list;
        /// <summary>Initialize device capabilities submodule.</summary>
        public AVInputFormat_create_device_capabilities_wrapper @create_device_capabilities;
        /// <summary>Free device capabilities submodule.</summary>
        public AVInputFormat_free_device_capabilities_wrapper @free_device_capabilities;
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
        /// <summary>&apos;,&apos; separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @codec_whitelist;
        /// <summary>&apos;,&apos; separated list of allowed demuxers. If NULL then all are allowed - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
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
        /// <summary>dump format separator. can be &quot;, &quot; or &quot; &quot; or anything else Code outside libavformat should access this field using AVOptions (NO direct access). - muxing: Set by user. - demuxing: Set by user.</summary>
        public byte* @dump_separator;
        /// <summary>Forced Data codec_id. Demuxing: Set by user.</summary>
        public AVCodecID @data_codec_id;
        /// <summary>Called to open further IO contexts when needed for demuxing.</summary>
        public AVFormatContext_open_cb_wrapper @open_cb;
        /// <summary>&apos;,&apos; separated list of allowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @protocol_whitelist;
        public AVFormatContext_io_open_wrapper @io_open;
        /// <summary>A callback for closing the streams opened with AVFormatContext.io_open().</summary>
        public AVFormatContext_io_close_wrapper @io_close;
        /// <summary>&apos;,&apos; separated list of disallowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
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
        /// <summary>Seek to a given timestamp in stream with the specified stream_index. Needed for some network streaming protocols which don&apos;t support seeking to byte position.</summary>
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
        /// <summary>&apos;,&apos; separated list of allowed protocols.</summary>
        public byte* @protocol_whitelist;
        /// <summary>&apos;,&apos; separated list of disallowed protocols.</summary>
        public byte* @protocol_blacklist;
        /// <summary>A callback that is used instead of write_packet.</summary>
        public AVIOContext_write_data_type_wrapper @write_data_type;
        /// <summary>If set, don&apos;t call write_data_type separately for AVIO_DATA_MARKER_BOUNDARY_POINT, but ignore them and treat them as AVIO_DATA_MARKER_UNKNOWN (to avoid needlessly small chunks of data returned from the callback).</summary>
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
        
        /// <summary>Read data and append it to the current content of the AVPacket. If pkt-&gt;size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
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
        
        [Obsolete("")]
        [DllImport("avformat-57", EntryPoint = "av_format_get_open_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr av_format_get_open_cb(AVFormatContext* @s);
        
        [Obsolete("")]
        [DllImport("avformat-57", EntryPoint = "av_format_set_open_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_set_open_cb(AVFormatContext* @s, IntPtr @callback);
        
        /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
        [DllImport("avformat-57", EntryPoint = "av_format_inject_global_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_format_inject_global_side_data(AVFormatContext* @s);
        
        /// <summary>Returns the method used to set ctx-&gt;duration.</summary>
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
        /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is &lt; = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
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
        
        [Obsolete("")]
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
        
        /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
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
        
        /// <summary>Seek to the keyframe at timestamp. &apos;timestamp&apos; in &apos;stream_index&apos;.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
        /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
        /// <param name="flags">flags which select direction and seeking mode</param>
        [DllImport("avformat-57", EntryPoint = "av_seek_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
        
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
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
        /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet).  This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output.  Packet&apos;s</param>
        [DllImport("avformat-57", EntryPoint = "av_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_write_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written.  If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. The caller must not access the data through this reference after this function returns. If the packet is not reference-counted, libavformat will make a copy.  This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues.  Packet&apos;s</param>
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
        
        /// <summary>Get timing information for the data currently output. The exact meaning of &quot;currently output&quot; depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
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
        /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
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
        
        /// <summary>Return in &apos;buf&apos; the path with &apos;%d&apos; replaced by a number.</summary>
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
        
        [Obsolete("")]
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
        
        [Obsolete("use avio_feof()")]
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
        /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index &gt;= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
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
