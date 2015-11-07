using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe partial struct AVRational
    {
        public int @num;
        public int @den;
    }
    
    public unsafe partial struct av_intfloat32
    {
        public uint @i;
        public float @f;
    }
    
    public unsafe partial struct av_intfloat64
    {
        public ulong @i;
        public double @f;
    }
    
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVClass
    {
        public sbyte* @class_name;
        public IntPtr @item_name;
        public AVOption* @option;
        public int @version;
        public int @log_level_offset_offset;
        public int @parent_log_context_offset;
        public IntPtr @child_next;
        public IntPtr @child_class_next;
        public AVClassCategory @category;
        public IntPtr @get_category;
        public IntPtr @query_ranges;
    }
    
    public unsafe partial struct AVOption
    {
    }
    
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVFifoBuffer
    {
        public sbyte* @buffer;
        public sbyte* @rptr;
        public sbyte* @wptr;
        public sbyte* @end;
        public uint @rndx;
        public uint @wndx;
    }
    
    public unsafe partial struct AVAudioFifo
    {
    }
    
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVComponentDescriptor
    {
        public ushort @plane;
        public ushort @step_minus1;
        public ushort @offset_plus1;
        public ushort @shift;
        public ushort @depth_minus1;
    }
    
    public unsafe partial struct AVPixFmtDescriptor
    {
        public sbyte* @name;
        public sbyte @nb_components;
        public sbyte @log2_chroma_w;
        public sbyte @log2_chroma_h;
        public sbyte @flags;
        public AVComponentDescriptor @comp0; public AVComponentDescriptor @comp1; public AVComponentDescriptor @comp2; public AVComponentDescriptor @comp3; 
        public sbyte* @alias;
    }
    
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVBuffer
    {
    }
    
    public unsafe partial struct AVBufferRef
    {
        public AVBuffer* @buffer;
        public sbyte* @data;
        public int @size;
    }
    
    public unsafe partial struct AVBufferPool
    {
    }
    
    public unsafe partial struct AVDictionaryEntry
    {
        public sbyte* @key;
        public sbyte* @value;
    }
    
    public unsafe partial struct AVDictionary
    {
    }
    
    public unsafe partial struct AVFrameSideData
    {
        public AVFrameSideDataType @type;
        public sbyte* @data;
        public int @size;
        public AVDictionary* @metadata;
        public AVBufferRef* @buf;
    }
    
    public unsafe partial struct AVFrame
    {
        public sbyte* @data0; public sbyte* @data1; public sbyte* @data2; public sbyte* @data3; public sbyte* @data4; public sbyte* @data5; public sbyte* @data6; public sbyte* @data7; 
        public fixed int @linesize[8]; 
        public sbyte** @extended_data;
        public int @width;
        public int @height;
        public int @nb_samples;
        public int @format;
        public int @key_frame;
        public AVPictureType @pict_type;
        public sbyte* @base0; public sbyte* @base1; public sbyte* @base2; public sbyte* @base3; public sbyte* @base4; public sbyte* @base5; public sbyte* @base6; public sbyte* @base7; 
        public AVRational @sample_aspect_ratio;
        public long @pts;
        public long @pkt_pts;
        public long @pkt_dts;
        public int @coded_picture_number;
        public int @display_picture_number;
        public int @quality;
        public int @reference;
        public sbyte* @qscale_table;
        public int @qstride;
        public int @qscale_type;
        public sbyte* @mbskip_table;
        public IntPtr @motion_val0; public IntPtr @motion_val1; 
        public uint* @mb_type;
        public short* @dct_coeff;
        public sbyte* @ref_index0; public sbyte* @ref_index1; 
        public void* @opaque;
        public fixed ulong @error[8]; 
        public int @type;
        public int @repeat_pict;
        public int @interlaced_frame;
        public int @top_field_first;
        public int @palette_has_changed;
        public int @buffer_hints;
        public AVPanScan* @pan_scan;
        public long @reordered_opaque;
        public void* @hwaccel_picture_private;
        public AVCodecContext* @owner;
        public void* @thread_opaque;
        public sbyte @motion_subsample_log2;
        public int @sample_rate;
        public ulong @channel_layout;
        public AVBufferRef* @buf0; public AVBufferRef* @buf1; public AVBufferRef* @buf2; public AVBufferRef* @buf3; public AVBufferRef* @buf4; public AVBufferRef* @buf5; public AVBufferRef* @buf6; public AVBufferRef* @buf7; 
        public AVBufferRef** @extended_buf;
        public int @nb_extended_buf;
        public AVFrameSideData** @side_data;
        public int @nb_side_data;
        public int @flags;
        public AVColorRange @color_range;
        public AVColorPrimaries @color_primaries;
        public AVColorTransferCharacteristic @color_trc;
        public AVColorSpace @colorspace;
        public AVChromaLocation @chroma_location;
        public long @best_effort_timestamp;
        public long @pkt_pos;
        public long @pkt_duration;
        public AVDictionary* @metadata;
        public int @decode_error_flags;
        public int @channels;
        public int @pkt_size;
        public AVBufferRef* @qp_table_buf;
    }
    
    public unsafe partial struct AVCodecContext
    {
    }
    
    public unsafe partial struct AVPanScan
    {
    }
    
    public enum AVMediaType : int
    {
        @AVMEDIA_TYPE_UNKNOWN = -1,
        @AVMEDIA_TYPE_VIDEO = 0,
        @AVMEDIA_TYPE_AUDIO = 1,
        @AVMEDIA_TYPE_DATA = 2,
        @AVMEDIA_TYPE_SUBTITLE = 3,
        @AVMEDIA_TYPE_ATTACHMENT = 4,
        @AVMEDIA_TYPE_NB = 5,
    }
    
    public enum AVPictureType : int
    {
        @AV_PICTURE_TYPE_NONE = 0,
        @AV_PICTURE_TYPE_I = 1,
        @AV_PICTURE_TYPE_P = 2,
        @AV_PICTURE_TYPE_B = 3,
        @AV_PICTURE_TYPE_S = 4,
        @AV_PICTURE_TYPE_SI = 5,
        @AV_PICTURE_TYPE_SP = 6,
        @AV_PICTURE_TYPE_BI = 7,
    }
    
    public enum AVRounding : int
    {
        @AV_ROUND_ZERO = 0,
        @AV_ROUND_INF = 1,
        @AV_ROUND_DOWN = 2,
        @AV_ROUND_UP = 3,
        @AV_ROUND_NEAR_INF = 5,
        @AV_ROUND_PASS_MINMAX = 8192,
    }
    
    public enum AVClassCategory : int
    {
        @AV_CLASS_CATEGORY_NA = 0,
        @AV_CLASS_CATEGORY_INPUT = 1,
        @AV_CLASS_CATEGORY_OUTPUT = 2,
        @AV_CLASS_CATEGORY_MUXER = 3,
        @AV_CLASS_CATEGORY_DEMUXER = 4,
        @AV_CLASS_CATEGORY_ENCODER = 5,
        @AV_CLASS_CATEGORY_DECODER = 6,
        @AV_CLASS_CATEGORY_FILTER = 7,
        @AV_CLASS_CATEGORY_BITSTREAM_FILTER = 8,
        @AV_CLASS_CATEGORY_SWSCALER = 9,
        @AV_CLASS_CATEGORY_SWRESAMPLER = 10,
        @AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT = 40,
        @AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT = 41,
        @AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT = 42,
        @AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT = 43,
        @AV_CLASS_CATEGORY_DEVICE_OUTPUT = 44,
        @AV_CLASS_CATEGORY_DEVICE_INPUT = 45,
        @AV_CLASS_CATEGORY_NB = 46,
    }
    
    public enum AVPixelFormat : int
    {
        @AV_PIX_FMT_NONE = -1,
        @AV_PIX_FMT_YUV420P = 0,
        @AV_PIX_FMT_YUYV422 = 1,
        @AV_PIX_FMT_RGB24 = 2,
        @AV_PIX_FMT_BGR24 = 3,
        @AV_PIX_FMT_YUV422P = 4,
        @AV_PIX_FMT_YUV444P = 5,
        @AV_PIX_FMT_YUV410P = 6,
        @AV_PIX_FMT_YUV411P = 7,
        @AV_PIX_FMT_GRAY8 = 8,
        @AV_PIX_FMT_MONOWHITE = 9,
        @AV_PIX_FMT_MONOBLACK = 10,
        @AV_PIX_FMT_PAL8 = 11,
        @AV_PIX_FMT_YUVJ420P = 12,
        @AV_PIX_FMT_YUVJ422P = 13,
        @AV_PIX_FMT_YUVJ444P = 14,
        @AV_PIX_FMT_XVMC_MPEG2_MC = 15,
        @AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
        @AV_PIX_FMT_UYVY422 = 17,
        @AV_PIX_FMT_UYYVYY411 = 18,
        @AV_PIX_FMT_BGR8 = 19,
        @AV_PIX_FMT_BGR4 = 20,
        @AV_PIX_FMT_BGR4_BYTE = 21,
        @AV_PIX_FMT_RGB8 = 22,
        @AV_PIX_FMT_RGB4 = 23,
        @AV_PIX_FMT_RGB4_BYTE = 24,
        @AV_PIX_FMT_NV12 = 25,
        @AV_PIX_FMT_NV21 = 26,
        @AV_PIX_FMT_ARGB = 27,
        @AV_PIX_FMT_RGBA = 28,
        @AV_PIX_FMT_ABGR = 29,
        @AV_PIX_FMT_BGRA = 30,
        @AV_PIX_FMT_GRAY16BE = 31,
        @AV_PIX_FMT_GRAY16LE = 32,
        @AV_PIX_FMT_YUV440P = 33,
        @AV_PIX_FMT_YUVJ440P = 34,
        @AV_PIX_FMT_YUVA420P = 35,
        @AV_PIX_FMT_VDPAU_H264 = 36,
        @AV_PIX_FMT_VDPAU_MPEG1 = 37,
        @AV_PIX_FMT_VDPAU_MPEG2 = 38,
        @AV_PIX_FMT_VDPAU_WMV3 = 39,
        @AV_PIX_FMT_VDPAU_VC1 = 40,
        @AV_PIX_FMT_RGB48BE = 41,
        @AV_PIX_FMT_RGB48LE = 42,
        @AV_PIX_FMT_RGB565BE = 43,
        @AV_PIX_FMT_RGB565LE = 44,
        @AV_PIX_FMT_RGB555BE = 45,
        @AV_PIX_FMT_RGB555LE = 46,
        @AV_PIX_FMT_BGR565BE = 47,
        @AV_PIX_FMT_BGR565LE = 48,
        @AV_PIX_FMT_BGR555BE = 49,
        @AV_PIX_FMT_BGR555LE = 50,
        @AV_PIX_FMT_VAAPI_MOCO = 51,
        @AV_PIX_FMT_VAAPI_IDCT = 52,
        @AV_PIX_FMT_VAAPI_VLD = 53,
        @AV_PIX_FMT_VAAPI = 53,
        @AV_PIX_FMT_YUV420P16LE = 54,
        @AV_PIX_FMT_YUV420P16BE = 55,
        @AV_PIX_FMT_YUV422P16LE = 56,
        @AV_PIX_FMT_YUV422P16BE = 57,
        @AV_PIX_FMT_YUV444P16LE = 58,
        @AV_PIX_FMT_YUV444P16BE = 59,
        @AV_PIX_FMT_VDPAU_MPEG4 = 60,
        @AV_PIX_FMT_DXVA2_VLD = 61,
        @AV_PIX_FMT_RGB444LE = 62,
        @AV_PIX_FMT_RGB444BE = 63,
        @AV_PIX_FMT_BGR444LE = 64,
        @AV_PIX_FMT_BGR444BE = 65,
        @AV_PIX_FMT_YA8 = 66,
        @AV_PIX_FMT_Y400A = 66,
        @AV_PIX_FMT_GRAY8A = 66,
        @AV_PIX_FMT_BGR48BE = 67,
        @AV_PIX_FMT_BGR48LE = 68,
        @AV_PIX_FMT_YUV420P9BE = 69,
        @AV_PIX_FMT_YUV420P9LE = 70,
        @AV_PIX_FMT_YUV420P10BE = 71,
        @AV_PIX_FMT_YUV420P10LE = 72,
        @AV_PIX_FMT_YUV422P10BE = 73,
        @AV_PIX_FMT_YUV422P10LE = 74,
        @AV_PIX_FMT_YUV444P9BE = 75,
        @AV_PIX_FMT_YUV444P9LE = 76,
        @AV_PIX_FMT_YUV444P10BE = 77,
        @AV_PIX_FMT_YUV444P10LE = 78,
        @AV_PIX_FMT_YUV422P9BE = 79,
        @AV_PIX_FMT_YUV422P9LE = 80,
        @AV_PIX_FMT_VDA_VLD = 81,
        @AV_PIX_FMT_GBRP = 82,
        @AV_PIX_FMT_GBRP9BE = 83,
        @AV_PIX_FMT_GBRP9LE = 84,
        @AV_PIX_FMT_GBRP10BE = 85,
        @AV_PIX_FMT_GBRP10LE = 86,
        @AV_PIX_FMT_GBRP16BE = 87,
        @AV_PIX_FMT_GBRP16LE = 88,
        @AV_PIX_FMT_YUVA422P_LIBAV = 89,
        @AV_PIX_FMT_YUVA444P_LIBAV = 90,
        @AV_PIX_FMT_YUVA420P9BE = 91,
        @AV_PIX_FMT_YUVA420P9LE = 92,
        @AV_PIX_FMT_YUVA422P9BE = 93,
        @AV_PIX_FMT_YUVA422P9LE = 94,
        @AV_PIX_FMT_YUVA444P9BE = 95,
        @AV_PIX_FMT_YUVA444P9LE = 96,
        @AV_PIX_FMT_YUVA420P10BE = 97,
        @AV_PIX_FMT_YUVA420P10LE = 98,
        @AV_PIX_FMT_YUVA422P10BE = 99,
        @AV_PIX_FMT_YUVA422P10LE = 100,
        @AV_PIX_FMT_YUVA444P10BE = 101,
        @AV_PIX_FMT_YUVA444P10LE = 102,
        @AV_PIX_FMT_YUVA420P16BE = 103,
        @AV_PIX_FMT_YUVA420P16LE = 104,
        @AV_PIX_FMT_YUVA422P16BE = 105,
        @AV_PIX_FMT_YUVA422P16LE = 106,
        @AV_PIX_FMT_YUVA444P16BE = 107,
        @AV_PIX_FMT_YUVA444P16LE = 108,
        @AV_PIX_FMT_VDPAU = 109,
        @AV_PIX_FMT_XYZ12LE = 110,
        @AV_PIX_FMT_XYZ12BE = 111,
        @AV_PIX_FMT_NV16 = 112,
        @AV_PIX_FMT_NV20LE = 113,
        @AV_PIX_FMT_NV20BE = 114,
        @AV_PIX_FMT_RGBA64BE_LIBAV = 115,
        @AV_PIX_FMT_RGBA64LE_LIBAV = 116,
        @AV_PIX_FMT_BGRA64BE_LIBAV = 117,
        @AV_PIX_FMT_BGRA64LE_LIBAV = 118,
        @AV_PIX_FMT_YVYU422 = 119,
        @AV_PIX_FMT_VDA = 120,
        @AV_PIX_FMT_YA16BE = 121,
        @AV_PIX_FMT_YA16LE = 122,
        @AV_PIX_FMT_GBRAP_LIBAV = 123,
        @AV_PIX_FMT_GBRAP16BE_LIBAV = 124,
        @AV_PIX_FMT_GBRAP16LE_LIBAV = 125,
        @AV_PIX_FMT_QSV = 126,
        @AV_PIX_FMT_MMAL = 127,
        @AV_PIX_FMT_D3D11VA_VLD = 128,
        @AV_PIX_FMT_RGBA64BE = 291,
        @AV_PIX_FMT_RGBA64LE = 292,
        @AV_PIX_FMT_BGRA64BE = 293,
        @AV_PIX_FMT_BGRA64LE = 294,
        @AV_PIX_FMT_0RGB = 295,
        @AV_PIX_FMT_RGB0 = 296,
        @AV_PIX_FMT_0BGR = 297,
        @AV_PIX_FMT_BGR0 = 298,
        @AV_PIX_FMT_YUVA444P = 299,
        @AV_PIX_FMT_YUVA422P = 300,
        @AV_PIX_FMT_YUV420P12BE = 301,
        @AV_PIX_FMT_YUV420P12LE = 302,
        @AV_PIX_FMT_YUV420P14BE = 303,
        @AV_PIX_FMT_YUV420P14LE = 304,
        @AV_PIX_FMT_YUV422P12BE = 305,
        @AV_PIX_FMT_YUV422P12LE = 306,
        @AV_PIX_FMT_YUV422P14BE = 307,
        @AV_PIX_FMT_YUV422P14LE = 308,
        @AV_PIX_FMT_YUV444P12BE = 309,
        @AV_PIX_FMT_YUV444P12LE = 310,
        @AV_PIX_FMT_YUV444P14BE = 311,
        @AV_PIX_FMT_YUV444P14LE = 312,
        @AV_PIX_FMT_GBRP12BE = 313,
        @AV_PIX_FMT_GBRP12LE = 314,
        @AV_PIX_FMT_GBRP14BE = 315,
        @AV_PIX_FMT_GBRP14LE = 316,
        @AV_PIX_FMT_GBRAP = 317,
        @AV_PIX_FMT_GBRAP16BE = 318,
        @AV_PIX_FMT_GBRAP16LE = 319,
        @AV_PIX_FMT_YUVJ411P = 320,
        @AV_PIX_FMT_BAYER_BGGR8 = 321,
        @AV_PIX_FMT_BAYER_RGGB8 = 322,
        @AV_PIX_FMT_BAYER_GBRG8 = 323,
        @AV_PIX_FMT_BAYER_GRBG8 = 324,
        @AV_PIX_FMT_BAYER_BGGR16LE = 325,
        @AV_PIX_FMT_BAYER_BGGR16BE = 326,
        @AV_PIX_FMT_BAYER_RGGB16LE = 327,
        @AV_PIX_FMT_BAYER_RGGB16BE = 328,
        @AV_PIX_FMT_BAYER_GBRG16LE = 329,
        @AV_PIX_FMT_BAYER_GBRG16BE = 330,
        @AV_PIX_FMT_BAYER_GRBG16LE = 331,
        @AV_PIX_FMT_BAYER_GRBG16BE = 332,
        @AV_PIX_FMT_YUV440P10LE = 333,
        @AV_PIX_FMT_YUV440P10BE = 334,
        @AV_PIX_FMT_YUV440P12LE = 335,
        @AV_PIX_FMT_YUV440P12BE = 336,
        @AV_PIX_FMT_AYUV64LE = 337,
        @AV_PIX_FMT_AYUV64BE = 338,
        @AV_PIX_FMT_VIDEOTOOLBOX = 339,
        @AV_PIX_FMT_NB = 340,
        @PIX_FMT_NONE = -1,
        @PIX_FMT_YUV420P = 0,
        @PIX_FMT_YUYV422 = 1,
        @PIX_FMT_RGB24 = 2,
        @PIX_FMT_BGR24 = 3,
        @PIX_FMT_YUV422P = 4,
        @PIX_FMT_YUV444P = 5,
        @PIX_FMT_YUV410P = 6,
        @PIX_FMT_YUV411P = 7,
        @PIX_FMT_GRAY8 = 8,
        @PIX_FMT_MONOWHITE = 9,
        @PIX_FMT_MONOBLACK = 10,
        @PIX_FMT_PAL8 = 11,
        @PIX_FMT_YUVJ420P = 12,
        @PIX_FMT_YUVJ422P = 13,
        @PIX_FMT_YUVJ444P = 14,
        @PIX_FMT_XVMC_MPEG2_MC = 15,
        @PIX_FMT_XVMC_MPEG2_IDCT = 16,
        @PIX_FMT_UYVY422 = 17,
        @PIX_FMT_UYYVYY411 = 18,
        @PIX_FMT_BGR8 = 19,
        @PIX_FMT_BGR4 = 20,
        @PIX_FMT_BGR4_BYTE = 21,
        @PIX_FMT_RGB8 = 22,
        @PIX_FMT_RGB4 = 23,
        @PIX_FMT_RGB4_BYTE = 24,
        @PIX_FMT_NV12 = 25,
        @PIX_FMT_NV21 = 26,
        @PIX_FMT_ARGB = 27,
        @PIX_FMT_RGBA = 28,
        @PIX_FMT_ABGR = 29,
        @PIX_FMT_BGRA = 30,
        @PIX_FMT_GRAY16BE = 31,
        @PIX_FMT_GRAY16LE = 32,
        @PIX_FMT_YUV440P = 33,
        @PIX_FMT_YUVJ440P = 34,
        @PIX_FMT_YUVA420P = 35,
        @PIX_FMT_VDPAU_H264 = 36,
        @PIX_FMT_VDPAU_MPEG1 = 37,
        @PIX_FMT_VDPAU_MPEG2 = 38,
        @PIX_FMT_VDPAU_WMV3 = 39,
        @PIX_FMT_VDPAU_VC1 = 40,
        @PIX_FMT_RGB48BE = 41,
        @PIX_FMT_RGB48LE = 42,
        @PIX_FMT_RGB565BE = 43,
        @PIX_FMT_RGB565LE = 44,
        @PIX_FMT_RGB555BE = 45,
        @PIX_FMT_RGB555LE = 46,
        @PIX_FMT_BGR565BE = 47,
        @PIX_FMT_BGR565LE = 48,
        @PIX_FMT_BGR555BE = 49,
        @PIX_FMT_BGR555LE = 50,
        @PIX_FMT_VAAPI_MOCO = 51,
        @PIX_FMT_VAAPI_IDCT = 52,
        @PIX_FMT_VAAPI_VLD = 53,
        @PIX_FMT_YUV420P16LE = 54,
        @PIX_FMT_YUV420P16BE = 55,
        @PIX_FMT_YUV422P16LE = 56,
        @PIX_FMT_YUV422P16BE = 57,
        @PIX_FMT_YUV444P16LE = 58,
        @PIX_FMT_YUV444P16BE = 59,
        @PIX_FMT_VDPAU_MPEG4 = 60,
        @PIX_FMT_DXVA2_VLD = 61,
        @PIX_FMT_RGB444LE = 62,
        @PIX_FMT_RGB444BE = 63,
        @PIX_FMT_BGR444LE = 64,
        @PIX_FMT_BGR444BE = 65,
        @PIX_FMT_GRAY8A = 66,
        @PIX_FMT_BGR48BE = 67,
        @PIX_FMT_BGR48LE = 68,
        @PIX_FMT_YUV420P9BE = 69,
        @PIX_FMT_YUV420P9LE = 70,
        @PIX_FMT_YUV420P10BE = 71,
        @PIX_FMT_YUV420P10LE = 72,
        @PIX_FMT_YUV422P10BE = 73,
        @PIX_FMT_YUV422P10LE = 74,
        @PIX_FMT_YUV444P9BE = 75,
        @PIX_FMT_YUV444P9LE = 76,
        @PIX_FMT_YUV444P10BE = 77,
        @PIX_FMT_YUV444P10LE = 78,
        @PIX_FMT_YUV422P9BE = 79,
        @PIX_FMT_YUV422P9LE = 80,
        @PIX_FMT_VDA_VLD = 81,
        @PIX_FMT_GBRP = 82,
        @PIX_FMT_GBRP9BE = 83,
        @PIX_FMT_GBRP9LE = 84,
        @PIX_FMT_GBRP10BE = 85,
        @PIX_FMT_GBRP10LE = 86,
        @PIX_FMT_GBRP16BE = 87,
        @PIX_FMT_GBRP16LE = 88,
        @PIX_FMT_RGBA64BE = 291,
        @PIX_FMT_RGBA64LE = 292,
        @PIX_FMT_BGRA64BE = 293,
        @PIX_FMT_BGRA64LE = 294,
        @PIX_FMT_0RGB = 295,
        @PIX_FMT_RGB0 = 296,
        @PIX_FMT_0BGR = 297,
        @PIX_FMT_BGR0 = 298,
        @PIX_FMT_YUVA444P = 299,
        @PIX_FMT_YUVA422P = 300,
        @PIX_FMT_YUV420P12BE = 301,
        @PIX_FMT_YUV420P12LE = 302,
        @PIX_FMT_YUV420P14BE = 303,
        @PIX_FMT_YUV420P14LE = 304,
        @PIX_FMT_YUV422P12BE = 305,
        @PIX_FMT_YUV422P12LE = 306,
        @PIX_FMT_YUV422P14BE = 307,
        @PIX_FMT_YUV422P14LE = 308,
        @PIX_FMT_YUV444P12BE = 309,
        @PIX_FMT_YUV444P12LE = 310,
        @PIX_FMT_YUV444P14BE = 311,
        @PIX_FMT_YUV444P14LE = 312,
        @PIX_FMT_GBRP12BE = 313,
        @PIX_FMT_GBRP12LE = 314,
        @PIX_FMT_GBRP14BE = 315,
        @PIX_FMT_GBRP14LE = 316,
        @PIX_FMT_NB = 317,
    }
    
    public enum AVColorPrimaries : int
    {
        @AVCOL_PRI_RESERVED0 = 0,
        @AVCOL_PRI_BT709 = 1,
        @AVCOL_PRI_UNSPECIFIED = 2,
        @AVCOL_PRI_RESERVED = 3,
        @AVCOL_PRI_BT470M = 4,
        @AVCOL_PRI_BT470BG = 5,
        @AVCOL_PRI_SMPTE170M = 6,
        @AVCOL_PRI_SMPTE240M = 7,
        @AVCOL_PRI_FILM = 8,
        @AVCOL_PRI_BT2020 = 9,
        @AVCOL_PRI_NB = 10,
    }
    
    public enum AVColorTransferCharacteristic : int
    {
        @AVCOL_TRC_RESERVED0 = 0,
        @AVCOL_TRC_BT709 = 1,
        @AVCOL_TRC_UNSPECIFIED = 2,
        @AVCOL_TRC_RESERVED = 3,
        @AVCOL_TRC_GAMMA22 = 4,
        @AVCOL_TRC_GAMMA28 = 5,
        @AVCOL_TRC_SMPTE170M = 6,
        @AVCOL_TRC_SMPTE240M = 7,
        @AVCOL_TRC_LINEAR = 8,
        @AVCOL_TRC_LOG = 9,
        @AVCOL_TRC_LOG_SQRT = 10,
        @AVCOL_TRC_IEC61966_2_4 = 11,
        @AVCOL_TRC_BT1361_ECG = 12,
        @AVCOL_TRC_IEC61966_2_1 = 13,
        @AVCOL_TRC_BT2020_10 = 14,
        @AVCOL_TRC_BT2020_12 = 15,
        @AVCOL_TRC_NB = 16,
    }
    
    public enum AVColorSpace : int
    {
        @AVCOL_SPC_RGB = 0,
        @AVCOL_SPC_BT709 = 1,
        @AVCOL_SPC_UNSPECIFIED = 2,
        @AVCOL_SPC_RESERVED = 3,
        @AVCOL_SPC_FCC = 4,
        @AVCOL_SPC_BT470BG = 5,
        @AVCOL_SPC_SMPTE170M = 6,
        @AVCOL_SPC_SMPTE240M = 7,
        @AVCOL_SPC_YCOCG = 8,
        @AVCOL_SPC_BT2020_NCL = 9,
        @AVCOL_SPC_BT2020_CL = 10,
        @AVCOL_SPC_NB = 11,
    }
    
    public enum AVColorRange : int
    {
        @AVCOL_RANGE_UNSPECIFIED = 0,
        @AVCOL_RANGE_MPEG = 1,
        @AVCOL_RANGE_JPEG = 2,
        @AVCOL_RANGE_NB = 3,
    }
    
    public enum AVChromaLocation : int
    {
        @AVCHROMA_LOC_UNSPECIFIED = 0,
        @AVCHROMA_LOC_LEFT = 1,
        @AVCHROMA_LOC_CENTER = 2,
        @AVCHROMA_LOC_TOPLEFT = 3,
        @AVCHROMA_LOC_TOP = 4,
        @AVCHROMA_LOC_BOTTOMLEFT = 5,
        @AVCHROMA_LOC_BOTTOM = 6,
        @AVCHROMA_LOC_NB = 7,
    }
    
    public enum AVSampleFormat : int
    {
        @AV_SAMPLE_FMT_NONE = -1,
        @AV_SAMPLE_FMT_U8 = 0,
        @AV_SAMPLE_FMT_S16 = 1,
        @AV_SAMPLE_FMT_S32 = 2,
        @AV_SAMPLE_FMT_FLT = 3,
        @AV_SAMPLE_FMT_DBL = 4,
        @AV_SAMPLE_FMT_U8P = 5,
        @AV_SAMPLE_FMT_S16P = 6,
        @AV_SAMPLE_FMT_S32P = 7,
        @AV_SAMPLE_FMT_FLTP = 8,
        @AV_SAMPLE_FMT_DBLP = 9,
        @AV_SAMPLE_FMT_NB = 10,
    }
    
    public enum AVFrameSideDataType : int
    {
        @AV_FRAME_DATA_PANSCAN = 0,
        @AV_FRAME_DATA_A53_CC = 1,
        @AV_FRAME_DATA_STEREO3D = 2,
        @AV_FRAME_DATA_MATRIXENCODING = 3,
        @AV_FRAME_DATA_DOWNMIX_INFO = 4,
        @AV_FRAME_DATA_REPLAYGAIN = 5,
        @AV_FRAME_DATA_DISPLAYMATRIX = 6,
        @AV_FRAME_DATA_AFD = 7,
        @AV_FRAME_DATA_MOTION_VECTORS = 8,
        @AV_FRAME_DATA_SKIP_SAMPLES = 9,
        @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
    }
    
    public enum AVActiveFormatDescription : int
    {
        @AV_AFD_SAME = 8,
        @AV_AFD_4_3 = 9,
        @AV_AFD_16_9 = 10,
        @AV_AFD_14_9 = 11,
        @AV_AFD_4_3_SP_14_9 = 13,
        @AV_AFD_16_9_SP_14_9 = 14,
        @AV_AFD_SP_4_3 = 15,
    }
    
    public unsafe static partial class ffmpeg
    {
        private const string libavutil = "avutil-54";
        
        [DllImport(libavutil, EntryPoint = "avutil_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint avutil_version();
        
        [DllImport(libavutil, EntryPoint = "av_version_info", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_version_info();
        
        [DllImport(libavutil, EntryPoint = "avutil_configuration", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avutil_configuration();
        
        [DllImport(libavutil, EntryPoint = "avutil_license", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avutil_license();
        
        [DllImport(libavutil, EntryPoint = "av_get_media_type_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_media_type_string(AVMediaType @media_type);
        
        [DllImport(libavutil, EntryPoint = "av_get_picture_type_char", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte av_get_picture_type_char(AVPictureType @pict_type);
        
        [DllImport(libavutil, EntryPoint = "av_log2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_log2(uint @v);
        
        [DllImport(libavutil, EntryPoint = "av_log2_16bit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_log2_16bit(uint @v);
        
        [DllImport(libavutil, EntryPoint = "av_clip_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_clip_c(int @a, int @amin, int @amax);
        
        [DllImport(libavutil, EntryPoint = "av_clip64_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_clip64_c(long @a, long @amin, long @amax);
        
        [DllImport(libavutil, EntryPoint = "av_clip_uint8_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte av_clip_uint8_c(int @a);
        
        [DllImport(libavutil, EntryPoint = "av_clip_int8_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte av_clip_int8_c(int @a);
        
        [DllImport(libavutil, EntryPoint = "av_clip_uint16_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort av_clip_uint16_c(int @a);
        
        [DllImport(libavutil, EntryPoint = "av_clip_int16_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern short av_clip_int16_c(int @a);
        
        [DllImport(libavutil, EntryPoint = "av_clipl_int32_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_clipl_int32_c(long @a);
        
        [DllImport(libavutil, EntryPoint = "av_clip_intp2_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_clip_intp2_c(int @a, int @p);
        
        [DllImport(libavutil, EntryPoint = "av_clip_uintp2_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_clip_uintp2_c(int @a, int @p);
        
        [DllImport(libavutil, EntryPoint = "av_mod_uintp2_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_mod_uintp2_c(uint @a, uint @p);
        
        [DllImport(libavutil, EntryPoint = "av_sat_add32_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_sat_add32_c(int @a, int @b);
        
        [DllImport(libavutil, EntryPoint = "av_sat_dadd32_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_sat_dadd32_c(int @a, int @b);
        
        [DllImport(libavutil, EntryPoint = "av_clipf_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern float av_clipf_c(float @a, float @amin, float @amax);
        
        [DllImport(libavutil, EntryPoint = "av_clipd_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern double av_clipd_c(double @a, double @amin, double @amax);
        
        [DllImport(libavutil, EntryPoint = "av_ceil_log2_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_ceil_log2_c(int @x);
        
        [DllImport(libavutil, EntryPoint = "av_popcount_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_popcount_c(uint @x);
        
        [DllImport(libavutil, EntryPoint = "av_popcount64_c", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_popcount64_c(ulong @x);
        
        [DllImport(libavutil, EntryPoint = "av_strerror", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_strerror(int @errnum, IntPtr @errbuf, ulong @errbuf_size);
        
        [DllImport(libavutil, EntryPoint = "av_make_error_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_make_error_string(IntPtr @errbuf, ulong @errbuf_size, int @errnum);
        
        [DllImport(libavutil, EntryPoint = "av_malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_malloc(ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_malloc_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_malloc_array(ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_realloc(void* @ptr, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_realloc_f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize);
        
        [DllImport(libavutil, EntryPoint = "av_reallocp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_reallocp(void* @ptr, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_realloc_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_reallocp_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_free(void* @ptr);
        
        [DllImport(libavutil, EntryPoint = "av_mallocz", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_mallocz(ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_calloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_calloc(ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_mallocz_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_mallocz_array(ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_strdup", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_strdup([MarshalAs(UnmanagedType.LPStr)] string @s);
        
        [DllImport(libavutil, EntryPoint = "av_strndup", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_strndup([MarshalAs(UnmanagedType.LPStr)] string @s, ulong @len);
        
        [DllImport(libavutil, EntryPoint = "av_memdup", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_memdup(void* @p, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_freep", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_freep(void* @ptr);
        
        [DllImport(libavutil, EntryPoint = "av_dynarray_add", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        [DllImport(libavutil, EntryPoint = "av_dynarray_add_nofree", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        [DllImport(libavutil, EntryPoint = "av_dynarray2_add", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, sbyte* @elem_data);
        
        [DllImport(libavutil, EntryPoint = "av_size_mult", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_size_mult(ulong @a, ulong @b, ulong* @r);
        
        [DllImport(libavutil, EntryPoint = "av_max_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_max_alloc(ulong @max);
        
        [DllImport(libavutil, EntryPoint = "av_memcpy_backptr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_memcpy_backptr(sbyte* @dst, int @back, int @cnt);
        
        [DllImport(libavutil, EntryPoint = "av_fast_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size);
        
        [DllImport(libavutil, EntryPoint = "av_fast_malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        [DllImport(libavutil, EntryPoint = "av_make_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_make_q(int @num, int @den);
        
        [DllImport(libavutil, EntryPoint = "av_cmp_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_cmp_q(AVRational @a, AVRational @b);
        
        [DllImport(libavutil, EntryPoint = "av_q2d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double av_q2d(AVRational @a);
        
        [DllImport(libavutil, EntryPoint = "av_reduce", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
        
        [DllImport(libavutil, EntryPoint = "av_mul_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_mul_q(AVRational @b, AVRational @c);
        
        [DllImport(libavutil, EntryPoint = "av_div_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_div_q(AVRational @b, AVRational @c);
        
        [DllImport(libavutil, EntryPoint = "av_add_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_add_q(AVRational @b, AVRational @c);
        
        [DllImport(libavutil, EntryPoint = "av_sub_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_sub_q(AVRational @b, AVRational @c);
        
        [DllImport(libavutil, EntryPoint = "av_inv_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_inv_q(AVRational @q);
        
        [DllImport(libavutil, EntryPoint = "av_d2q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_d2q(double @d, int @max);
        
        [DllImport(libavutil, EntryPoint = "av_nearer_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2);
        
        [DllImport(libavutil, EntryPoint = "av_find_nearest_q_idx", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list);
        
        [DllImport(libavutil, EntryPoint = "av_q2intfloat", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_q2intfloat(AVRational @q);
        
        [DllImport(libavutil, EntryPoint = "av_int2float", CallingConvention = CallingConvention.Cdecl)]
        public static extern float av_int2float(uint @i);
        
        [DllImport(libavutil, EntryPoint = "av_float2int", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_float2int(float @f);
        
        [DllImport(libavutil, EntryPoint = "av_int2double", CallingConvention = CallingConvention.Cdecl)]
        public static extern double av_int2double(ulong @i);
        
        [DllImport(libavutil, EntryPoint = "av_double2int", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong av_double2int(double @f);
        
        [DllImport(libavutil, EntryPoint = "av_gcd", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_gcd(long @a, long @b);
        
        [DllImport(libavutil, EntryPoint = "av_rescale", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_rescale(long @a, long @b, long @c);
        
        [DllImport(libavutil, EntryPoint = "av_rescale_rnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_rescale_rnd(long @a, long @b, long @c, AVRounding @param3);
        
        [DllImport(libavutil, EntryPoint = "av_rescale_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_rescale_q(long @a, AVRational @bq, AVRational @cq);
        
        [DllImport(libavutil, EntryPoint = "av_rescale_q_rnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @param3);
        
        [DllImport(libavutil, EntryPoint = "av_compare_ts", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
        
        [DllImport(libavutil, EntryPoint = "av_compare_mod", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_compare_mod(ulong @a, ulong @b, ulong @mod);
        
        [DllImport(libavutil, EntryPoint = "av_rescale_delta", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
        
        [DllImport(libavutil, EntryPoint = "av_add_stable", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
        
        [DllImport(libavutil, EntryPoint = "av_log", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt);
        
        [DllImport(libavutil, EntryPoint = "av_vlog", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_vlog(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, sbyte* @vl);
        
        [DllImport(libavutil, EntryPoint = "av_log_get_level", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_log_get_level();
        
        [DllImport(libavutil, EntryPoint = "av_log_set_level", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_set_level(int @level);
        
        [DllImport(libavutil, EntryPoint = "av_log_set_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_set_callback(IntPtr* @callback);
        
        [DllImport(libavutil, EntryPoint = "av_log_default_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_default_callback(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, sbyte* @vl);
        
        [DllImport(libavutil, EntryPoint = "av_default_item_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_default_item_name(void* @ctx);
        
        [DllImport(libavutil, EntryPoint = "av_default_get_category", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVClassCategory av_default_get_category(void* @ptr);
        
        [DllImport(libavutil, EntryPoint = "av_log_format_line", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_format_line(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, sbyte* @vl, IntPtr @line, int @line_size, int* @print_prefix);
        
        [DllImport(libavutil, EntryPoint = "av_log_set_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_set_flags(int @arg);
        
        [DllImport(libavutil, EntryPoint = "av_log_get_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_log_get_flags();
        
        [DllImport(libavutil, EntryPoint = "av_x_if_null", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_x_if_null(void* @p, void* @x);
        
        [DllImport(libavutil, EntryPoint = "av_int_list_length_for_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term);
        
        [DllImport(libavutil, EntryPoint = "av_fopen_utf8", CallingConvention = CallingConvention.Cdecl)]
        public static extern _iobuf* av_fopen_utf8([MarshalAs(UnmanagedType.LPStr)] string @path, [MarshalAs(UnmanagedType.LPStr)] string @mode);
        
        [DllImport(libavutil, EntryPoint = "av_get_time_base_q", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_get_time_base_q();
        
        [DllImport(libavutil, EntryPoint = "av_fifo_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFifoBuffer* av_fifo_alloc(uint @size);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_alloc_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFifoBuffer* av_fifo_alloc_array(ulong @nmemb, ulong @size);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fifo_free(AVFifoBuffer* @f);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_freep", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fifo_freep(AVFifoBuffer** @f);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_reset", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fifo_reset(AVFifoBuffer* @f);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_size(AVFifoBuffer* @f);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_space", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_space(AVFifoBuffer* @f);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_generic_peek", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_generic_peek(AVFifoBuffer* @f, void* @dest, int @buf_size, IntPtr* @func);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_generic_read", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_generic_read(AVFifoBuffer* @f, void* @dest, int @buf_size, IntPtr* @func);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_generic_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_generic_write(AVFifoBuffer* @f, void* @src, int @size, IntPtr* @func);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_realloc2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_realloc2(AVFifoBuffer* @f, uint @size);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_grow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_fifo_grow(AVFifoBuffer* @f, uint @additional_space);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_drain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fifo_drain(AVFifoBuffer* @f, int @size);
        
        [DllImport(libavutil, EntryPoint = "av_fifo_peek2", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_fifo_peek2(AVFifoBuffer* @f, int @offs);
        
        [DllImport(libavutil, EntryPoint = "av_get_sample_fmt_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_sample_fmt_name(AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVSampleFormat av_get_sample_fmt([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavutil, EntryPoint = "av_get_alt_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar);
        
        [DllImport(libavutil, EntryPoint = "av_get_packed_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_planar_sample_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_sample_fmt_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_get_sample_fmt_string(IntPtr @buf, int @buf_size, AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_bytes_per_sample(AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_sample_fmt_is_planar", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_samples_get_buffer_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_samples_fill_arrays", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_fill_arrays(sbyte** @audio_data, int* @linesize, sbyte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_samples_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_alloc(sbyte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_samples_alloc_array_and_samples", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_alloc_array_and_samples(sbyte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_samples_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_copy(sbyte** @dst, sbyte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_samples_set_silence", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_samples_set_silence(sbyte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_audio_fifo_free(AVAudioFifo* @af);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_peek", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_read", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_drain", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_reset", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_audio_fifo_reset(AVAudioFifo* @af);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_size(AVAudioFifo* @af);
        
        [DllImport(libavutil, EntryPoint = "av_audio_fifo_space", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_audio_fifo_space(AVAudioFifo* @af);
        
        [DllImport(libavutil, EntryPoint = "av_read_image_line", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_read_image_line(ushort* @dst, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
        
        [DllImport(libavutil, EntryPoint = "av_write_image_line", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_write_image_line(ushort* @src, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
        
        [DllImport(libavutil, EntryPoint = "av_get_pix_fmt", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat av_get_pix_fmt([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavutil, EntryPoint = "av_get_pix_fmt_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_pix_fmt_name(AVPixelFormat @pix_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_pix_fmt_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_get_pix_fmt_string(IntPtr @buf, int @buf_size, AVPixelFormat @pix_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_bits_per_pixel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        [DllImport(libavutil, EntryPoint = "av_get_padded_bits_per_pixel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_desc_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_desc_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_desc_get_id", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_count_planes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_pix_fmt_swap_endianness", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt);
        
        [DllImport(libavutil, EntryPoint = "av_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        [DllImport(libavutil, EntryPoint = "av_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport(libavutil, EntryPoint = "av_color_range_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_color_range_name(AVColorRange @range);
        
        [DllImport(libavutil, EntryPoint = "av_color_primaries_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_color_primaries_name(AVColorPrimaries @primaries);
        
        [DllImport(libavutil, EntryPoint = "av_color_transfer_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_color_transfer_name(AVColorTransferCharacteristic @transfer);
        
        [DllImport(libavutil, EntryPoint = "av_color_space_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_color_space_name(AVColorSpace @space);
        
        [DllImport(libavutil, EntryPoint = "av_chroma_location_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_chroma_location_name(AVChromaLocation @location);
        
        [DllImport(libavutil, EntryPoint = "av_image_fill_max_pixsteps", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_image_fill_max_pixsteps([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @max_pixsteps, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
        
        [DllImport(libavutil, EntryPoint = "av_image_get_linesize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane);
        
        [DllImport(libavutil, EntryPoint = "av_image_fill_linesizes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_fill_linesizes([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @linesizes, AVPixelFormat @pix_fmt, int @width);
        
        [DllImport(libavutil, EntryPoint = "av_image_fill_pointers", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_fill_pointers([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @data, AVPixelFormat @pix_fmt, int @height, sbyte* @ptr, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @linesizes);
        
        [DllImport(libavutil, EntryPoint = "av_image_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_alloc([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @pointers, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_image_copy_plane", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_image_copy_plane(sbyte* @dst, int @dst_linesize, sbyte* @src, int @src_linesize, int @bytewidth, int @height);
        
        [DllImport(libavutil, EntryPoint = "av_image_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_image_copy([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @dst_data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @dst_linesizes, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @src_data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavutil, EntryPoint = "av_image_fill_arrays", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_fill_arrays([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @dst_data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @dst_linesize, sbyte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_image_get_buffer_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_image_copy_to_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_copy_to_buffer(sbyte* @dst, int @dst_size, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] sbyte*[] @src_data, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] int[] @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_image_check_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx);
        
        [DllImport(libavutil, EntryPoint = "av_image_check_sar", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_image_check_sar(uint @w, uint @h, AVRational @sar);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_buffer_alloc(int @size);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_allocz", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_buffer_allocz(int @size);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_buffer_create(sbyte* @data, int @size, IntPtr* @free, void* @opaque, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_default_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_buffer_default_free(void* @opaque, sbyte* @data);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_ref", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_buffer_ref(AVBufferRef* @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_buffer_unref(AVBufferRef** @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_is_writable", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_buffer_is_writable(AVBufferRef* @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_get_opaque", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* av_buffer_get_opaque(AVBufferRef* @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_get_ref_count", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_buffer_get_ref_count(AVBufferRef* @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_make_writable", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_buffer_make_writable(AVBufferRef** @buf);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_buffer_realloc(AVBufferRef** @buf, int @size);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_pool_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferPool* av_buffer_pool_init(int @size, IntPtr* @alloc);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_pool_uninit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_buffer_pool_uninit(AVBufferPool** @pool);
        
        [DllImport(libavutil, EntryPoint = "av_buffer_pool_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool);
        
        [DllImport(libavutil, EntryPoint = "av_dict_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVDictionaryEntry* av_dict_get(AVDictionary* @m, [MarshalAs(UnmanagedType.LPStr)] string @key, AVDictionaryEntry* @prev, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_dict_count", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dict_count(AVDictionary* @m);
        
        [DllImport(libavutil, EntryPoint = "av_dict_set", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dict_set(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, [MarshalAs(UnmanagedType.LPStr)] string @value, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_dict_set_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dict_set_int(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, long @value, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_dict_parse_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dict_parse_string(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @str, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_dict_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags);
        
        [DllImport(libavutil, EntryPoint = "av_dict_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_dict_free(AVDictionary** @m);
        
        [DllImport(libavutil, EntryPoint = "av_dict_get_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dict_get_string(AVDictionary* @m, sbyte** @buffer, sbyte @key_val_sep, sbyte @pairs_sep);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_frame_get_best_effort_timestamp(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_best_effort_timestamp(AVFrame* @frame, long @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_pkt_duration", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_frame_get_pkt_duration(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_pkt_duration", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_pkt_duration(AVFrame* @frame, long @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_pkt_pos", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_frame_get_pkt_pos(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_pkt_pos", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_pkt_pos(AVFrame* @frame, long @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_frame_get_channel_layout(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_channel_layout(AVFrame* @frame, long @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_channels", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_get_channels(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_channels", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_channels(AVFrame* @frame, int @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_sample_rate", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_get_sample_rate(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_sample_rate(AVFrame* @frame, int @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_metadata", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVDictionary* av_frame_get_metadata(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_metadata", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_metadata(AVFrame* @frame, AVDictionary* @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_decode_error_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_get_decode_error_flags(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_decode_error_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_decode_error_flags(AVFrame* @frame, int @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_pkt_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_get_pkt_size(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_pkt_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_pkt_size(AVFrame* @frame, int @val);
        
        [DllImport(libavutil, EntryPoint = "avpriv_frame_get_metadatap", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVDictionary** avpriv_frame_get_metadatap(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_qp_table", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_frame_get_qp_table(AVFrame* @f, int* @stride, int* @type);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_qp_table", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_set_qp_table(AVFrame* @f, AVBufferRef* @buf, int @stride, int @type);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_colorspace", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVColorSpace av_frame_get_colorspace(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_colorspace", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_colorspace(AVFrame* @frame, AVColorSpace @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_color_range", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVColorRange av_frame_get_color_range(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_set_color_range", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_set_color_range(AVFrame* @frame, AVColorRange @val);
        
        [DllImport(libavutil, EntryPoint = "av_get_colorspace_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_colorspace_name(AVColorSpace @val);
        
        [DllImport(libavutil, EntryPoint = "av_frame_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFrame* av_frame_alloc();
        
        [DllImport(libavutil, EntryPoint = "av_frame_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_free(AVFrame** @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_ref", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_ref(AVFrame* @dst, AVFrame* @src);
        
        [DllImport(libavutil, EntryPoint = "av_frame_clone", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFrame* av_frame_clone(AVFrame* @src);
        
        [DllImport(libavutil, EntryPoint = "av_frame_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_unref(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_move_ref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_move_ref(AVFrame* @dst, AVFrame* @src);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_get_buffer(AVFrame* @frame, int @align);
        
        [DllImport(libavutil, EntryPoint = "av_frame_is_writable", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_is_writable(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_make_writable", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_make_writable(AVFrame* @frame);
        
        [DllImport(libavutil, EntryPoint = "av_frame_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_copy(AVFrame* @dst, AVFrame* @src);
        
        [DllImport(libavutil, EntryPoint = "av_frame_copy_props", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_frame_copy_props(AVFrame* @dst, AVFrame* @src);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_plane_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane);
        
        [DllImport(libavutil, EntryPoint = "av_frame_new_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, int @size);
        
        [DllImport(libavutil, EntryPoint = "av_frame_get_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        [DllImport(libavutil, EntryPoint = "av_frame_remove_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        [DllImport(libavutil, EntryPoint = "av_frame_side_data_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_frame_side_data_name(AVFrameSideDataType @type);
        
    }
}
