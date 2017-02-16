using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    /// <summary>Media Type</summary>
    public enum AVMediaType : int
    {
        /// <summary>Usually treated as AVMEDIA_TYPE_DATA</summary>
        @AVMEDIA_TYPE_UNKNOWN = -1,
        @AVMEDIA_TYPE_VIDEO = 0,
        @AVMEDIA_TYPE_AUDIO = 1,
        /// <summary>Opaque data information usually continuous</summary>
        @AVMEDIA_TYPE_DATA = 2,
        @AVMEDIA_TYPE_SUBTITLE = 3,
        /// <summary>Opaque data information usually sparse</summary>
        @AVMEDIA_TYPE_ATTACHMENT = 4,
        @AVMEDIA_TYPE_NB = 5,
    }
    
    /// <summary>@} @}</summary>
    public enum AVPictureType : int
    {
        /// <summary>Undefined</summary>
        @AV_PICTURE_TYPE_NONE = 0,
        /// <summary>Intra</summary>
        @AV_PICTURE_TYPE_I = 1,
        /// <summary>Predicted</summary>
        @AV_PICTURE_TYPE_P = 2,
        /// <summary>Bi-dir predicted</summary>
        @AV_PICTURE_TYPE_B = 3,
        /// <summary>S(GMC)-VOP MPEG-4</summary>
        @AV_PICTURE_TYPE_S = 4,
        /// <summary>Switching Intra</summary>
        @AV_PICTURE_TYPE_SI = 5,
        /// <summary>Switching Predicted</summary>
        @AV_PICTURE_TYPE_SP = 6,
        /// <summary>BI type</summary>
        @AV_PICTURE_TYPE_BI = 7,
    }
    
    /// <summary>Rounding methods.</summary>
    public enum AVRounding : int
    {
        /// <summary>Round toward zero.</summary>
        @AV_ROUND_ZERO = 0,
        /// <summary>Round away from zero.</summary>
        @AV_ROUND_INF = 1,
        /// <summary>Round toward -infinity.</summary>
        @AV_ROUND_DOWN = 2,
        /// <summary>Round toward +infinity.</summary>
        @AV_ROUND_UP = 3,
        /// <summary>Round to nearest and halfway cases away from zero.</summary>
        @AV_ROUND_NEAR_INF = 5,
        /// <summary>Flag telling rescaling functions to pass `INT64_MIN`/`MAX` through unchanged, avoiding special cases for #AV_NOPTS_VALUE.</summary>
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
        /// <summary>not part of ABI/API</summary>
        @AV_CLASS_CATEGORY_NB = 46,
    }
    
    /// <summary>Pixel format.</summary>
    public enum AVPixelFormat : int
    {
        @AV_PIX_FMT_NONE = -1,
        /// <summary>planar YUV 4:2:0, 12bpp, (1 Cr & Cb sample per 2x2 Y samples)</summary>
        @AV_PIX_FMT_YUV420P = 0,
        /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr</summary>
        @AV_PIX_FMT_YUYV422 = 1,
        /// <summary>packed RGB 8:8:8, 24bpp, RGBRGB...</summary>
        @AV_PIX_FMT_RGB24 = 2,
        /// <summary>packed RGB 8:8:8, 24bpp, BGRBGR...</summary>
        @AV_PIX_FMT_BGR24 = 3,
        /// <summary>planar YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples)</summary>
        @AV_PIX_FMT_YUV422P = 4,
        /// <summary>planar YUV 4:4:4, 24bpp, (1 Cr & Cb sample per 1x1 Y samples)</summary>
        @AV_PIX_FMT_YUV444P = 5,
        /// <summary>planar YUV 4:1:0, 9bpp, (1 Cr & Cb sample per 4x4 Y samples)</summary>
        @AV_PIX_FMT_YUV410P = 6,
        /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples)</summary>
        @AV_PIX_FMT_YUV411P = 7,
        /// <summary>Y , 8bpp</summary>
        @AV_PIX_FMT_GRAY8 = 8,
        /// <summary>Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb</summary>
        @AV_PIX_FMT_MONOWHITE = 9,
        /// <summary>Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb</summary>
        @AV_PIX_FMT_MONOBLACK = 10,
        /// <summary>8 bits with AV_PIX_FMT_RGB32 palette</summary>
        @AV_PIX_FMT_PAL8 = 11,
        /// <summary>planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ420P = 12,
        /// <summary>planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ422P = 13,
        /// <summary>planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ444P = 14,
        /// <summary>XVideo Motion Acceleration via common packet passing</summary>
        @AV_PIX_FMT_XVMC_MPEG2_MC = 15,
        @AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
        @AV_PIX_FMT_XVMC = 16,
        /// <summary>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1</summary>
        @AV_PIX_FMT_UYVY422 = 17,
        /// <summary>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3</summary>
        @AV_PIX_FMT_UYYVYY411 = 18,
        /// <summary>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb)</summary>
        @AV_PIX_FMT_BGR8 = 19,
        /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
        @AV_PIX_FMT_BGR4 = 20,
        /// <summary>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb)</summary>
        @AV_PIX_FMT_BGR4_BYTE = 21,
        /// <summary>packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb)</summary>
        @AV_PIX_FMT_RGB8 = 22,
        /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
        @AV_PIX_FMT_RGB4 = 23,
        /// <summary>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb)</summary>
        @AV_PIX_FMT_RGB4_BYTE = 24,
        /// <summary>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
        @AV_PIX_FMT_NV12 = 25,
        /// <summary>as above, but U and V bytes are swapped</summary>
        @AV_PIX_FMT_NV21 = 26,
        /// <summary>packed ARGB 8:8:8:8, 32bpp, ARGBARGB...</summary>
        @AV_PIX_FMT_ARGB = 27,
        /// <summary>packed RGBA 8:8:8:8, 32bpp, RGBARGBA...</summary>
        @AV_PIX_FMT_RGBA = 28,
        /// <summary>packed ABGR 8:8:8:8, 32bpp, ABGRABGR...</summary>
        @AV_PIX_FMT_ABGR = 29,
        /// <summary>packed BGRA 8:8:8:8, 32bpp, BGRABGRA...</summary>
        @AV_PIX_FMT_BGRA = 30,
        /// <summary>Y , 16bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY16BE = 31,
        /// <summary>Y , 16bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY16LE = 32,
        /// <summary>planar YUV 4:4:0 (1 Cr & Cb sample per 1x2 Y samples)</summary>
        @AV_PIX_FMT_YUV440P = 33,
        /// <summary>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ440P = 34,
        /// <summary>planar YUV 4:2:0, 20bpp, (1 Cr & Cb sample per 2x2 Y & A samples)</summary>
        @AV_PIX_FMT_YUVA420P = 35,
        /// <summary>H.264 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_H264 = 36,
        /// <summary>MPEG-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_MPEG1 = 37,
        /// <summary>MPEG-2 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_MPEG2 = 38,
        /// <summary>WMV3 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_WMV3 = 39,
        /// <summary>VC-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_VC1 = 40,
        /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian</summary>
        @AV_PIX_FMT_RGB48BE = 41,
        /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian</summary>
        @AV_PIX_FMT_RGB48LE = 42,
        /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian</summary>
        @AV_PIX_FMT_RGB565BE = 43,
        /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian</summary>
        @AV_PIX_FMT_RGB565LE = 44,
        /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined</summary>
        @AV_PIX_FMT_RGB555BE = 45,
        /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB555LE = 46,
        /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian</summary>
        @AV_PIX_FMT_BGR565BE = 47,
        /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian</summary>
        @AV_PIX_FMT_BGR565LE = 48,
        /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined</summary>
        @AV_PIX_FMT_BGR555BE = 49,
        /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR555LE = 50,
        /// <summary>HW acceleration through VA API at motion compensation entry-point, Picture.data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VAAPI_MOCO = 51,
        /// <summary>HW acceleration through VA API at IDCT entry-point, Picture.data[3] contains a vaapi_render_state struct which contains fields extracted from headers</summary>
        @AV_PIX_FMT_VAAPI_IDCT = 52,
        /// <summary>HW decoding through VA API, Picture.data[3] contains a VASurfaceID</summary>
        @AV_PIX_FMT_VAAPI_VLD = 53,
        /// <summary>@}</summary>
        @AV_PIX_FMT_VAAPI = 53,
        /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P16LE = 54,
        /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P16BE = 55,
        /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P16LE = 56,
        /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P16BE = 57,
        /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P16LE = 58,
        /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P16BE = 59,
        /// <summary>MPEG-4 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VDPAU_MPEG4 = 60,
        /// <summary>HW decoding through DXVA2, Picture.data[3] contains a LPDIRECT3DSURFACE9 pointer</summary>
        @AV_PIX_FMT_DXVA2_VLD = 61,
        /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB444LE = 62,
        /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB444BE = 63,
        /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR444LE = 64,
        /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR444BE = 65,
        /// <summary>8 bits gray, 8 bits alpha</summary>
        @AV_PIX_FMT_YA8 = 66,
        /// <summary>alias for AV_PIX_FMT_YA8</summary>
        @AV_PIX_FMT_Y400A = 66,
        /// <summary>alias for AV_PIX_FMT_YA8</summary>
        @AV_PIX_FMT_GRAY8A = 66,
        /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian</summary>
        @AV_PIX_FMT_BGR48BE = 67,
        /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian</summary>
        @AV_PIX_FMT_BGR48LE = 68,
        /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P9BE = 69,
        /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P9LE = 70,
        /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P10BE = 71,
        /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P10LE = 72,
        /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P10BE = 73,
        /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P10LE = 74,
        /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P9BE = 75,
        /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P9LE = 76,
        /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P10BE = 77,
        /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P10LE = 78,
        /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P9BE = 79,
        /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P9LE = 80,
        /// <summary>hardware decoding through VDA</summary>
        @AV_PIX_FMT_VDA_VLD = 81,
        /// <summary>planar GBR 4:4:4 24bpp</summary>
        @AV_PIX_FMT_GBRP = 82,
        @AV_PIX_FMT_GBR24P = 82,
        /// <summary>planar GBR 4:4:4 27bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP9BE = 83,
        /// <summary>planar GBR 4:4:4 27bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP9LE = 84,
        /// <summary>planar GBR 4:4:4 30bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP10BE = 85,
        /// <summary>planar GBR 4:4:4 30bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP10LE = 86,
        /// <summary>planar GBR 4:4:4 48bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP16BE = 87,
        /// <summary>planar GBR 4:4:4 48bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP16LE = 88,
        /// <summary>planar YUV 4:2:2 24bpp, (1 Cr & Cb sample per 2x1 Y & A samples)</summary>
        @AV_PIX_FMT_YUVA422P = 89,
        /// <summary>planar YUV 4:4:4 32bpp, (1 Cr & Cb sample per 1x1 Y & A samples)</summary>
        @AV_PIX_FMT_YUVA444P = 90,
        /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA420P9BE = 91,
        /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA420P9LE = 92,
        /// <summary>planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA422P9BE = 93,
        /// <summary>planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA422P9LE = 94,
        /// <summary>planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA444P9BE = 95,
        /// <summary>planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA444P9LE = 96,
        /// <summary>planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA420P10BE = 97,
        /// <summary>planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA420P10LE = 98,
        /// <summary>planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA422P10BE = 99,
        /// <summary>planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA422P10LE = 100,
        /// <summary>planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA444P10BE = 101,
        /// <summary>planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA444P10LE = 102,
        /// <summary>planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA420P16BE = 103,
        /// <summary>planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA420P16LE = 104,
        /// <summary>planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA422P16BE = 105,
        /// <summary>planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA422P16LE = 106,
        /// <summary>planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA444P16BE = 107,
        /// <summary>planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA444P16LE = 108,
        /// <summary>HW acceleration through VDPAU, Picture.data[3] contains a VdpVideoSurface</summary>
        @AV_PIX_FMT_VDPAU = 109,
        /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0</summary>
        @AV_PIX_FMT_XYZ12LE = 110,
        /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0</summary>
        @AV_PIX_FMT_XYZ12BE = 111,
        /// <summary>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples)</summary>
        @AV_PIX_FMT_NV16 = 112,
        /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_NV20LE = 113,
        /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_NV20BE = 114,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
        @AV_PIX_FMT_RGBA64BE = 115,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
        @AV_PIX_FMT_RGBA64LE = 116,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
        @AV_PIX_FMT_BGRA64BE = 117,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
        @AV_PIX_FMT_BGRA64LE = 118,
        /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb</summary>
        @AV_PIX_FMT_YVYU422 = 119,
        /// <summary>HW acceleration through VDA, data[3] contains a CVPixelBufferRef</summary>
        @AV_PIX_FMT_VDA = 120,
        /// <summary>16 bits gray, 16 bits alpha (big-endian)</summary>
        @AV_PIX_FMT_YA16BE = 121,
        /// <summary>16 bits gray, 16 bits alpha (little-endian)</summary>
        @AV_PIX_FMT_YA16LE = 122,
        /// <summary>planar GBRA 4:4:4:4 32bpp</summary>
        @AV_PIX_FMT_GBRAP = 123,
        /// <summary>planar GBRA 4:4:4:4 64bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP16BE = 124,
        /// <summary>planar GBRA 4:4:4:4 64bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP16LE = 125,
        /// <summary>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</summary>
        @AV_PIX_FMT_QSV = 126,
        /// <summary>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</summary>
        @AV_PIX_FMT_MMAL = 127,
        /// <summary>HW decoding through Direct3D11, Picture.data[3] contains a ID3D11VideoDecoderOutputView pointer</summary>
        @AV_PIX_FMT_D3D11VA_VLD = 128,
        /// <summary>HW acceleration through CUDA. data[i] contain CUdeviceptr pointers exactly as for system memory frames.</summary>
        @AV_PIX_FMT_CUDA = 129,
        /// <summary>packed RGB 8:8:8, 32bpp, XRGBXRGB... X=unused/undefined</summary>
        @AV_PIX_FMT_0RGB = 295,
        /// <summary>packed RGB 8:8:8, 32bpp, RGBXRGBX... X=unused/undefined</summary>
        @AV_PIX_FMT_RGB0 = 296,
        /// <summary>packed BGR 8:8:8, 32bpp, XBGRXBGR... X=unused/undefined</summary>
        @AV_PIX_FMT_0BGR = 297,
        /// <summary>packed BGR 8:8:8, 32bpp, BGRXBGRX... X=unused/undefined</summary>
        @AV_PIX_FMT_BGR0 = 298,
        /// <summary>planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P12BE = 299,
        /// <summary>planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P12LE = 300,
        /// <summary>planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P14BE = 301,
        /// <summary>planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P14LE = 302,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P12BE = 303,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P12LE = 304,
        /// <summary>planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P14BE = 305,
        /// <summary>planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P14LE = 306,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P12BE = 307,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P12LE = 308,
        /// <summary>planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P14BE = 309,
        /// <summary>planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P14LE = 310,
        /// <summary>planar GBR 4:4:4 36bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP12BE = 311,
        /// <summary>planar GBR 4:4:4 36bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP12LE = 312,
        /// <summary>planar GBR 4:4:4 42bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP14BE = 313,
        /// <summary>planar GBR 4:4:4 42bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP14LE = 314,
        /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ411P = 315,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_BGGR8 = 316,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_RGGB8 = 317,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_GBRG8 = 318,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_GRBG8 = 319,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_BGGR16LE = 320,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_BGGR16BE = 321,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_RGGB16LE = 322,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_RGGB16BE = 323,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_GBRG16LE = 324,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_GBRG16BE = 325,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_GRBG16LE = 326,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_GRBG16BE = 327,
        /// <summary>planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV440P10LE = 328,
        /// <summary>planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV440P10BE = 329,
        /// <summary>planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV440P12LE = 330,
        /// <summary>planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV440P12BE = 331,
        /// <summary>packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), little-endian</summary>
        @AV_PIX_FMT_AYUV64LE = 332,
        /// <summary>packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), big-endian</summary>
        @AV_PIX_FMT_AYUV64BE = 333,
        /// <summary>hardware decoding through Videotoolbox</summary>
        @AV_PIX_FMT_VIDEOTOOLBOX = 334,
        /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian</summary>
        @AV_PIX_FMT_P010LE = 335,
        /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian</summary>
        @AV_PIX_FMT_P010BE = 336,
        /// <summary>planar GBR 4:4:4:4 48bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP12BE = 337,
        /// <summary>planar GBR 4:4:4:4 48bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP12LE = 338,
        /// <summary>planar GBR 4:4:4:4 40bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP10BE = 339,
        /// <summary>planar GBR 4:4:4:4 40bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP10LE = 340,
        /// <summary>hardware decoding through MediaCodec</summary>
        @AV_PIX_FMT_MEDIACODEC = 341,
        /// <summary>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions</summary>
        @AV_PIX_FMT_NB = 342,
    }
    
    /// <summary>Chromaticity coordinates of the source primaries.</summary>
    public enum AVColorPrimaries : int
    {
        @AVCOL_PRI_RESERVED0 = 0,
        /// <summary>also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP177 Annex B</summary>
        @AVCOL_PRI_BT709 = 1,
        @AVCOL_PRI_UNSPECIFIED = 2,
        @AVCOL_PRI_RESERVED = 3,
        /// <summary>also FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
        @AVCOL_PRI_BT470M = 4,
        /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM</summary>
        @AVCOL_PRI_BT470BG = 5,
        /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
        @AVCOL_PRI_SMPTE170M = 6,
        /// <summary>functionally identical to above</summary>
        @AVCOL_PRI_SMPTE240M = 7,
        /// <summary>colour filters using Illuminant C</summary>
        @AVCOL_PRI_FILM = 8,
        /// <summary>ITU-R BT2020</summary>
        @AVCOL_PRI_BT2020 = 9,
        /// <summary>SMPTE ST 428-1 (CIE 1931 XYZ)</summary>
        @AVCOL_PRI_SMPTEST428_1 = 10,
        /// <summary>SMPTE ST 431-2 (2011)</summary>
        @AVCOL_PRI_SMPTE431 = 11,
        /// <summary>SMPTE ST 432-1 D65 (2010)</summary>
        @AVCOL_PRI_SMPTE432 = 12,
        /// <summary>Not part of ABI</summary>
        @AVCOL_PRI_NB = 13,
    }
    
    /// <summary>Color Transfer Characteristic.</summary>
    public enum AVColorTransferCharacteristic : int
    {
        @AVCOL_TRC_RESERVED0 = 0,
        /// <summary>also ITU-R BT1361</summary>
        @AVCOL_TRC_BT709 = 1,
        @AVCOL_TRC_UNSPECIFIED = 2,
        @AVCOL_TRC_RESERVED = 3,
        /// <summary>also ITU-R BT470M / ITU-R BT1700 625 PAL & SECAM</summary>
        @AVCOL_TRC_GAMMA22 = 4,
        /// <summary>also ITU-R BT470BG</summary>
        @AVCOL_TRC_GAMMA28 = 5,
        /// <summary>also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC</summary>
        @AVCOL_TRC_SMPTE170M = 6,
        @AVCOL_TRC_SMPTE240M = 7,
        /// <summary>"Linear transfer characteristics"</summary>
        @AVCOL_TRC_LINEAR = 8,
        /// <summary>"Logarithmic transfer characteristic (100:1 range)"</summary>
        @AVCOL_TRC_LOG = 9,
        /// <summary>"Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)"</summary>
        @AVCOL_TRC_LOG_SQRT = 10,
        /// <summary>IEC 61966-2-4</summary>
        @AVCOL_TRC_IEC61966_2_4 = 11,
        /// <summary>ITU-R BT1361 Extended Colour Gamut</summary>
        @AVCOL_TRC_BT1361_ECG = 12,
        /// <summary>IEC 61966-2-1 (sRGB or sYCC)</summary>
        @AVCOL_TRC_IEC61966_2_1 = 13,
        /// <summary>ITU-R BT2020 for 10-bit system</summary>
        @AVCOL_TRC_BT2020_10 = 14,
        /// <summary>ITU-R BT2020 for 12-bit system</summary>
        @AVCOL_TRC_BT2020_12 = 15,
        /// <summary>SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems</summary>
        @AVCOL_TRC_SMPTEST2084 = 16,
        /// <summary>SMPTE ST 428-1</summary>
        @AVCOL_TRC_SMPTEST428_1 = 17,
        /// <summary>ARIB STD-B67, known as "Hybrid log-gamma"</summary>
        @AVCOL_TRC_ARIB_STD_B67 = 18,
        /// <summary>Not part of ABI</summary>
        @AVCOL_TRC_NB = 19,
    }
    
    /// <summary>YUV colorspace type.</summary>
    public enum AVColorSpace : int
    {
        /// <summary>order of coefficients is actually GBR, also IEC 61966-2-1 (sRGB)</summary>
        @AVCOL_SPC_RGB = 0,
        /// <summary>also ITU-R BT1361 / IEC 61966-2-4 xvYCC709 / SMPTE RP177 Annex B</summary>
        @AVCOL_SPC_BT709 = 1,
        @AVCOL_SPC_UNSPECIFIED = 2,
        @AVCOL_SPC_RESERVED = 3,
        /// <summary>FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
        @AVCOL_SPC_FCC = 4,
        /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM / IEC 61966-2-4 xvYCC601</summary>
        @AVCOL_SPC_BT470BG = 5,
        /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
        @AVCOL_SPC_SMPTE170M = 6,
        /// <summary>functionally identical to above</summary>
        @AVCOL_SPC_SMPTE240M = 7,
        /// <summary>Used by Dirac / VC-2 and H.264 FRext, see ITU-T SG16</summary>
        @AVCOL_SPC_YCOCG = 8,
        /// <summary>ITU-R BT2020 non-constant luminance system</summary>
        @AVCOL_SPC_BT2020_NCL = 9,
        /// <summary>ITU-R BT2020 constant luminance system</summary>
        @AVCOL_SPC_BT2020_CL = 10,
        /// <summary>SMPTE 2085, Y'D'zD'x</summary>
        @AVCOL_SPC_SMPTE2085 = 11,
        /// <summary>Not part of ABI</summary>
        @AVCOL_SPC_NB = 12,
    }
    
    /// <summary>MPEG vs JPEG YUV range.</summary>
    public enum AVColorRange : int
    {
        @AVCOL_RANGE_UNSPECIFIED = 0,
        /// <summary>the normal 219*2^(n-8) "MPEG" YUV ranges</summary>
        @AVCOL_RANGE_MPEG = 1,
        /// <summary>the normal 2^n-1 "JPEG" YUV ranges</summary>
        @AVCOL_RANGE_JPEG = 2,
        /// <summary>Not part of ABI</summary>
        @AVCOL_RANGE_NB = 3,
    }
    
    /// <summary>Location of chroma samples.</summary>
    public enum AVChromaLocation : int
    {
        @AVCHROMA_LOC_UNSPECIFIED = 0,
        /// <summary>MPEG-2/4 4:2:0, H.264 default for 4:2:0</summary>
        @AVCHROMA_LOC_LEFT = 1,
        /// <summary>MPEG-1 4:2:0, JPEG 4:2:0, H.263 4:2:0</summary>
        @AVCHROMA_LOC_CENTER = 2,
        /// <summary>ITU-R 601, SMPTE 274M 296M S314M(DV 4:1:1), mpeg2 4:2:2</summary>
        @AVCHROMA_LOC_TOPLEFT = 3,
        @AVCHROMA_LOC_TOP = 4,
        @AVCHROMA_LOC_BOTTOMLEFT = 5,
        @AVCHROMA_LOC_BOTTOM = 6,
        /// <summary>Not part of ABI</summary>
        @AVCHROMA_LOC_NB = 7,
    }
    
    /// <summary>Audio sample formats</summary>
    public enum AVSampleFormat : int
    {
        @AV_SAMPLE_FMT_NONE = -1,
        /// <summary>unsigned 8 bits</summary>
        @AV_SAMPLE_FMT_U8 = 0,
        /// <summary>signed 16 bits</summary>
        @AV_SAMPLE_FMT_S16 = 1,
        /// <summary>signed 32 bits</summary>
        @AV_SAMPLE_FMT_S32 = 2,
        /// <summary>float</summary>
        @AV_SAMPLE_FMT_FLT = 3,
        /// <summary>double</summary>
        @AV_SAMPLE_FMT_DBL = 4,
        /// <summary>unsigned 8 bits, planar</summary>
        @AV_SAMPLE_FMT_U8P = 5,
        /// <summary>signed 16 bits, planar</summary>
        @AV_SAMPLE_FMT_S16P = 6,
        /// <summary>signed 32 bits, planar</summary>
        @AV_SAMPLE_FMT_S32P = 7,
        /// <summary>float, planar</summary>
        @AV_SAMPLE_FMT_FLTP = 8,
        /// <summary>double, planar</summary>
        @AV_SAMPLE_FMT_DBLP = 9,
        /// <summary>signed 64 bits</summary>
        @AV_SAMPLE_FMT_S64 = 10,
        /// <summary>signed 64 bits, planar</summary>
        @AV_SAMPLE_FMT_S64P = 11,
        /// <summary>Number of sample formats. DO NOT USE if linking dynamically</summary>
        @AV_SAMPLE_FMT_NB = 12,
    }
    
    public enum AVMatrixEncoding : int
    {
        @AV_MATRIX_ENCODING_NONE = 0,
        @AV_MATRIX_ENCODING_DOLBY = 1,
        @AV_MATRIX_ENCODING_DPLII = 2,
        @AV_MATRIX_ENCODING_DPLIIX = 3,
        @AV_MATRIX_ENCODING_DPLIIZ = 4,
        @AV_MATRIX_ENCODING_DOLBYEX = 5,
        @AV_MATRIX_ENCODING_DOLBYHEADPHONE = 6,
        @AV_MATRIX_ENCODING_NB = 7,
    }
    
    /// <summary>@{ AVFrame is an abstraction for reference-counted raw multimedia data.</summary>
    public enum AVFrameSideDataType : int
    {
        /// <summary>The data is the AVPanScan struct defined in libavcodec.</summary>
        @AV_FRAME_DATA_PANSCAN = 0,
        /// <summary>ATSC A53 Part 4 Closed Captions. A53 CC bitstream is stored as uint8_t in AVFrameSideData.data. The number of bytes of CC data is AVFrameSideData.size.</summary>
        @AV_FRAME_DATA_A53_CC = 1,
        /// <summary>Stereoscopic 3d metadata. The data is the AVStereo3D struct defined in libavutil/stereo3d.h.</summary>
        @AV_FRAME_DATA_STEREO3D = 2,
        /// <summary>The data is the AVMatrixEncoding enum defined in libavutil/channel_layout.h.</summary>
        @AV_FRAME_DATA_MATRIXENCODING = 3,
        /// <summary>Metadata relevant to a downmix procedure. The data is the AVDownmixInfo struct defined in libavutil/downmix_info.h.</summary>
        @AV_FRAME_DATA_DOWNMIX_INFO = 4,
        /// <summary>ReplayGain information in the form of the AVReplayGain struct.</summary>
        @AV_FRAME_DATA_REPLAYGAIN = 5,
        /// <summary>This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the frame for correct presentation.</summary>
        @AV_FRAME_DATA_DISPLAYMATRIX = 6,
        /// <summary>Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum.</summary>
        @AV_FRAME_DATA_AFD = 7,
        /// <summary>Motion vectors exported by some codecs (on demand through the export_mvs flag set in the libavcodec AVCodecContext flags2 option). The data is the AVMotionVector struct defined in libavutil/motion_vector.h.</summary>
        @AV_FRAME_DATA_MOTION_VECTORS = 8,
        /// <summary>Recommmends skipping the specified number of samples. This is exported only if the "skip_manual" AVOption is set in libavcodec. This has the same format as AV_PKT_DATA_SKIP_SAMPLES.</summary>
        @AV_FRAME_DATA_SKIP_SAMPLES = 9,
        /// <summary>This side data must be associated with an audio frame and corresponds to enum AVAudioServiceType defined in avcodec.h.</summary>
        @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
        /// <summary>Mastering display metadata associated with a video frame. The payload is an AVMasteringDisplayMetadata type and contains information about the mastering display color volume.</summary>
        @AV_FRAME_DATA_MASTERING_DISPLAY_METADATA = 11,
        /// <summary>The GOP timecode in 25 bit timecode format. Data format is 64-bit integer. This is set on the first frame of a GOP that has a temporal reference of 0.</summary>
        @AV_FRAME_DATA_GOP_TIMECODE = 12,
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
    
    /// <summary>@{ AVOptions provide a generic system to declare options on arbitrary structs ("objects"). An option can have a help text, a type and a range of possible values. Options may then be enumerated, read and written to.</summary>
    public enum AVOptionType : int
    {
        @AV_OPT_TYPE_FLAGS = 0,
        @AV_OPT_TYPE_INT = 1,
        @AV_OPT_TYPE_INT64 = 2,
        @AV_OPT_TYPE_DOUBLE = 3,
        @AV_OPT_TYPE_FLOAT = 4,
        @AV_OPT_TYPE_STRING = 5,
        @AV_OPT_TYPE_RATIONAL = 6,
        /// <summary>offset must point to a pointer immediately followed by an int for the length</summary>
        @AV_OPT_TYPE_BINARY = 7,
        @AV_OPT_TYPE_DICT = 8,
        @AV_OPT_TYPE_CONST = 128,
        /// <summary>offset must point to two consecutive integers</summary>
        @AV_OPT_TYPE_IMAGE_SIZE = 1397316165,
        @AV_OPT_TYPE_PIXEL_FMT = 1346784596,
        @AV_OPT_TYPE_SAMPLE_FMT = 1397116244,
        /// <summary>offset must point to AVRational</summary>
        @AV_OPT_TYPE_VIDEO_RATE = 1448231252,
        @AV_OPT_TYPE_DURATION = 1146442272,
        @AV_OPT_TYPE_COLOR = 1129270354,
        @AV_OPT_TYPE_CHANNEL_LAYOUT = 1128811585,
        @AV_OPT_TYPE_BOOL = 1112493900,
    }
    
    /// <summary>Rational number (pair of numerator and denominator).</summary>
    public unsafe struct AVRational
    {
        /// <summary>Numerator</summary>
        public int @num;
        /// <summary>Denominator</summary>
        public int @den;
    }
    
    /// <summary>Describe the class of an AVClass context structure. That is an arbitrary struct of which the first field is a pointer to an AVClass struct (e.g. AVCodecContext, AVFormatContext etc.).</summary>
    public unsafe struct AVClass
    {
        /// <summary>The name of the class; usually it is the same name as the context structure type to which the AVClass is associated.</summary>
        public byte* @class_name;
        /// <summary>A pointer to a function which returns the name of a context instance ctx associated with the class.</summary>
        public IntPtr @item_name;
        /// <summary>a pointer to the first option specified in the class if any or NULL</summary>
        public IntPtr @option;
        /// <summary>LIBAVUTIL_VERSION with which this structure was created. This is used to allow fields to be added without requiring major version bumps everywhere.</summary>
        public int @version;
        /// <summary>Offset in the structure where log_level_offset is stored. 0 means there is no such variable</summary>
        public int @log_level_offset_offset;
        /// <summary>Offset in the structure where a pointer to the parent context for logging is stored. For example a decoder could pass its AVCodecContext to eval as such a parent context, which an av_log() implementation could then leverage to display the parent context. The offset can be NULL.</summary>
        public int @parent_log_context_offset;
        /// <summary>Return next AVOptions-enabled child or NULL</summary>
        public IntPtr @child_next;
        /// <summary>Return an AVClass corresponding to the next potential AVOptions-enabled child.</summary>
        public IntPtr @child_class_next;
        /// <summary>Category used for visualization (like color) This is only set if the category is equal for all objects using this class. available since version (51 << 16 | 56 << 8 | 100)</summary>
        public AVClassCategory @category;
        /// <summary>Callback to return the category. available since version (51 << 16 | 59 << 8 | 100)</summary>
        public IntPtr @get_category;
        /// <summary>Callback to return the supported/allowed ranges. available since version (52.12)</summary>
        public IntPtr @query_ranges;
    }
    
    public unsafe struct __NSConstantString_tag
    {
    }
    
    public unsafe struct AVFifoBuffer
    {
        public byte* @buffer;
        public byte* @rptr;
        public byte* @wptr;
        public byte* @end;
        public uint @rndx;
        public uint @wndx;
    }
    
    public unsafe struct AVAudioFifo
    {
    }
    
    public unsafe struct AVBuffer
    {
    }
    
    /// <summary>A reference to a data buffer.</summary>
    public unsafe struct AVBufferRef
    {
        public AVBuffer* @buffer;
        /// <summary>The data buffer. It is considered writable if and only if this is the only reference to the buffer, in which case av_buffer_is_writable() returns 1.</summary>
        public byte* @data;
        /// <summary>Size of data in bytes.</summary>
        public int @size;
    }
    
    public unsafe struct AVBufferPool
    {
    }
    
    public unsafe struct AVDictionaryEntry
    {
        public byte* @key;
        public byte* @value;
    }
    
    public unsafe struct AVDictionary
    {
    }
    
    /// <summary>Structure to hold side data for an AVFrame.</summary>
    public unsafe struct AVFrameSideData
    {
        public AVFrameSideDataType @type;
        public byte* @data;
        public int @size;
        public AVDictionary* @metadata;
        public AVBufferRef* @buf;
    }
    
    /// <summary>This structure describes decoded (raw) audio or video data.</summary>
    public unsafe struct AVFrame
    {
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data0;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data1;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data2;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data3;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data4;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data5;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data6;
        /// <summary>pointer to the picture/channel planes. This might be different from the first allocated byte</summary>
        public byte* @data7;
        public fixed int @linesize[8];
        /// <summary>pointers to the data planes/channels.</summary>
        public byte** @extended_data;
        /// <summary>width and height of the video frame</summary>
        public int @width;
        /// <summary>width and height of the video frame</summary>
        public int @height;
        /// <summary>number of audio samples (per channel) described by this frame</summary>
        public int @nb_samples;
        /// <summary>format of the frame, -1 if unknown or unset Values correspond to enum AVPixelFormat for video frames, enum AVSampleFormat for audio)</summary>
        public int @format;
        /// <summary>1 -> keyframe, 0-> not</summary>
        public int @key_frame;
        /// <summary>Picture type of the frame.</summary>
        public AVPictureType @pict_type;
        /// <summary>Sample aspect ratio for the video frame, 0/1 if unknown/unspecified.</summary>
        public AVRational @sample_aspect_ratio;
        /// <summary>Presentation timestamp in time_base units (time when frame should be shown to user).</summary>
        public long @pts;
        /// <summary>PTS copied from the AVPacket that was decoded to produce this frame.</summary>
        public long @pkt_pts;
        /// <summary>DTS copied from the AVPacket that triggered returning this frame. (if frame threading isn't used) This is also the Presentation time of this AVFrame calculated from only AVPacket.dts values without pts values.</summary>
        public long @pkt_dts;
        /// <summary>picture number in bitstream order</summary>
        public int @coded_picture_number;
        /// <summary>picture number in display order</summary>
        public int @display_picture_number;
        /// <summary>quality (between 1 (good) and FF_LAMBDA_MAX (bad))</summary>
        public int @quality;
        /// <summary>for some private data of the user</summary>
        public void* @opaque;
        public fixed ulong @error[8];
        /// <summary>When decoding, this signals how much the picture must be delayed. extra_delay = repeat_pict / (2*fps)</summary>
        public int @repeat_pict;
        /// <summary>The content of the picture is interlaced.</summary>
        public int @interlaced_frame;
        /// <summary>If the content is interlaced, is top field displayed first.</summary>
        public int @top_field_first;
        /// <summary>Tell user application that palette has changed from previous frame.</summary>
        public int @palette_has_changed;
        /// <summary>reordered opaque 64 bits (generally an integer or a double precision float PTS but can be anything). The user sets AVCodecContext.reordered_opaque to represent the input at that time, the decoder reorders values as needed and sets AVFrame.reordered_opaque to exactly one of the values provided by the user through AVCodecContext.reordered_opaque</summary>
        public long @reordered_opaque;
        /// <summary>Sample rate of the audio data.</summary>
        public int @sample_rate;
        /// <summary>Channel layout of the audio data.</summary>
        public ulong @channel_layout;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf0;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf1;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf2;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf3;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf4;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf5;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf6;
        /// <summary>AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i.</summary>
        public AVBufferRef* @buf7;
        /// <summary>For planar audio which requires more than AV_NUM_DATA_POINTERS AVBufferRef pointers, this array will hold all the references which cannot fit into AVFrame.buf.</summary>
        public AVBufferRef** @extended_buf;
        /// <summary>Number of elements in extended_buf.</summary>
        public int @nb_extended_buf;
        public AVFrameSideData** @side_data;
        public int @nb_side_data;
        /// <summary>Frame flags, a combination of</summary>
        public int @flags;
        /// <summary>MPEG vs JPEG YUV range. It must be accessed using av_frame_get_color_range() and av_frame_set_color_range(). - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorRange @color_range;
        public AVColorPrimaries @color_primaries;
        public AVColorTransferCharacteristic @color_trc;
        /// <summary>YUV colorspace type. It must be accessed using av_frame_get_colorspace() and av_frame_set_colorspace(). - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorSpace @colorspace;
        public AVChromaLocation @chroma_location;
        /// <summary>frame timestamp estimated using various heuristics, in stream time base Code outside libavutil should access this field using: av_frame_get_best_effort_timestamp(frame) - encoding: unused - decoding: set by libavcodec, read by user.</summary>
        public long @best_effort_timestamp;
        /// <summary>reordered pos from the last AVPacket that has been input into the decoder Code outside libavutil should access this field using: av_frame_get_pkt_pos(frame) - encoding: unused - decoding: Read by user.</summary>
        public long @pkt_pos;
        /// <summary>duration of the corresponding packet, expressed in AVStream->time_base units, 0 if unknown. Code outside libavutil should access this field using: av_frame_get_pkt_duration(frame) - encoding: unused - decoding: Read by user.</summary>
        public long @pkt_duration;
        /// <summary>metadata. Code outside libavutil should access this field using: av_frame_get_metadata(frame) - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public AVDictionary* @metadata;
        /// <summary>decode error flags of the frame, set to a combination of FF_DECODE_ERROR_xxx flags if the decoder produced a frame, but there were errors during the decoding. Code outside libavutil should access this field using: av_frame_get_decode_error_flags(frame) - encoding: unused - decoding: set by libavcodec, read by user.</summary>
        public int @decode_error_flags;
        /// <summary>number of audio channels, only used for audio. Code outside libavutil should access this field using: av_frame_get_channels(frame) - encoding: unused - decoding: Read by user.</summary>
        public int @channels;
        /// <summary>size of the corresponding packet containing the compressed frame. It must be accessed using av_frame_get_pkt_size() and av_frame_set_pkt_size(). It is set to a negative value if unknown. - encoding: unused - decoding: set by libavcodec, read by user.</summary>
        public int @pkt_size;
        /// <summary>QP table Not to be accessed directly from outside libavutil</summary>
        public sbyte* @qscale_table;
        /// <summary>QP store stride Not to be accessed directly from outside libavutil</summary>
        public int @qstride;
        public int @qscale_type;
        /// <summary>Not to be accessed directly from outside libavutil</summary>
        public AVBufferRef* @qp_table_buf;
        /// <summary>For hwaccel-format frames, this should be a reference to the AVHWFramesContext describing the frame.</summary>
        public AVBufferRef* @hw_frames_ctx;
    }
    
    /// <summary>the default value for scalar options</summary>
    public unsafe struct AVOption_default_val
    {
        public long @i64;
        public double @dbl;
        public byte* @str;
        public AVRational @q;
    }
    
    /// <summary>AVOption</summary>
    public unsafe struct AVOption
    {
        public byte* @name;
        /// <summary>short English help text</summary>
        public byte* @help;
        /// <summary>The offset relative to the context structure where the option value is stored. It should be 0 for named constants.</summary>
        public int @offset;
        public AVOptionType @type;
        public AVOption_default_val @default_val;
        /// <summary>minimum valid value for the option</summary>
        public double @min;
        /// <summary>maximum valid value for the option</summary>
        public double @max;
        public int @flags;
        /// <summary>The logical unit to which the option belongs. Non-constant options and corresponding named constants share the same unit. May be NULL.</summary>
        public byte* @unit;
    }
    
    /// <summary>A single allowed range of values, or a single allowed value.</summary>
    public unsafe struct AVOptionRange
    {
        public byte* @str;
        /// <summary>Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case.</summary>
        public double @value_min;
        /// <summary>Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case.</summary>
        public double @value_max;
        /// <summary>Value's component range. For string this represents the unicode range for chars, 0-127 limits to ASCII.</summary>
        public double @component_min;
        /// <summary>Value's component range. For string this represents the unicode range for chars, 0-127 limits to ASCII.</summary>
        public double @component_max;
        /// <summary>Range flag. If set to 1 the struct encodes a range, if set to 0 a single value.</summary>
        public int @is_range;
    }
    
    /// <summary>List of AVOptionRange structs.</summary>
    public unsafe struct AVOptionRanges
    {
        /// <summary>Array of option ranges.</summary>
        public AVOptionRange** @range;
        /// <summary>Number of ranges per component.</summary>
        public int @nb_ranges;
        /// <summary>Number of componentes.</summary>
        public int @nb_components;
    }
    
    public unsafe struct AVComponentDescriptor
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
        /// <summary>deprecated, use step instead</summary>
        public int @step_minus1;
        /// <summary>deprecated, use depth instead</summary>
        public int @depth_minus1;
        /// <summary>deprecated, use offset instead</summary>
        public int @offset_plus1;
    }
    
    /// <summary>Descriptor that unambiguously describes how the bits of a pixel are stored in the up to 4 data planes of an image. It also stores the subsampling factors and number of components.</summary>
    public unsafe struct AVPixFmtDescriptor
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
        public AVComponentDescriptor @comp0;
        /// <summary>Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.</summary>
        public AVComponentDescriptor @comp1;
        /// <summary>Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.</summary>
        public AVComponentDescriptor @comp2;
        /// <summary>Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.</summary>
        public AVComponentDescriptor @comp3;
        /// <summary>Alternative comma-separated names.</summary>
        public byte* @alias;
    }
    
    public unsafe static partial class ffmpeg
    {
        public static int FF_LAMBDA_SHIFT = 7;
        // public static  FF_LAMBDA_SCALE = (1<<FF_LAMBDA_SHIFT);
        public static int FF_QP2LAMBDA = 118;
        // public static  FF_LAMBDA_MAX = (256*128-1);
        // public static  FF_QUALITY_SCALE = FF_LAMBDA_SCALE;
        // public static  AV_NOPTS_VALUE = ((int64_t)UINT64_C(0x8000000000000000));
        public static int AV_TIME_BASE = 1000000;
        // public static  AV_TIME_BASE_Q = (AVRational){1, AV_TIME_BASE};
        // public static  FF_CEIL_RSHIFT = AV_CEIL_RSHIFT;
        // public static  av_ceil_log2 = av_ceil_log2_c;
        // public static  av_clip = av_clip_c;
        // public static  av_clip64 = av_clip64_c;
        // public static  av_clip_uint8 = av_clip_uint8_c;
        // public static  av_clip_int8 = av_clip_int8_c;
        // public static  av_clip_uint16 = av_clip_uint16_c;
        // public static  av_clip_int16 = av_clip_int16_c;
        // public static  av_clipl_int32 = av_clipl_int32_c;
        // public static  av_clip_intp2 = av_clip_intp2_c;
        // public static  av_clip_uintp2 = av_clip_uintp2_c;
        // public static  av_mod_uintp2 = av_mod_uintp2_c;
        // public static  av_sat_add32 = av_sat_add32_c;
        // public static  av_sat_dadd32 = av_sat_dadd32_c;
        // public static  av_clipf = av_clipf_c;
        // public static  av_clipd = av_clipd_c;
        // public static  av_popcount = av_popcount_c;
        // public static  av_popcount64 = av_popcount64_c;
        // public static  av_parity = av_parity_c;
        // public static  av_always_inline = __forceinline;
        // public static  av_extern_inline = inline;
        // public static  av_noinline = __declspec(noinline);
        // public static  attribute_deprecated = __declspec(deprecated);
        public static int LIBAVUTIL_VERSION_MAJOR = 55;
        public static int LIBAVUTIL_VERSION_MINOR = 34;
        public static int LIBAVUTIL_VERSION_MICRO = 100;
        // public static  LIBAVUTIL_VERSION_INT = AV_VERSION_INT(LIBAVUTIL_VERSION_MAJOR, LIBAVUTIL_VERSION_MINOR, LIBAVUTIL_VERSION_MICRO);
        // public static  LIBAVUTIL_VERSION = AV_VERSION(LIBAVUTIL_VERSION_MAJOR,     LIBAVUTIL_VERSION_MINOR,     LIBAVUTIL_VERSION_MICRO);
        // public static  LIBAVUTIL_BUILD = LIBAVUTIL_VERSION_INT;
        // public static  LIBAVUTIL_IDENT = "Lavu" AV_STRINGIFY(LIBAVUTIL_VERSION);
        // public static  FF_API_VDPAU = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_XVMC = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_OPT_TYPE_METADATA = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_DLOG = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_VAAPI = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_FRAME_QP = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_PLUS1_MINUS1 = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_ERROR_FRAME = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_CRC_BIG_TABLE = (LIBAVUTIL_VERSION_MAJOR < 56);
        // public static  FF_API_PKT_PTS = (LIBAVUTIL_VERSION_MAJOR < 56);
        public static int AV_HAVE_BIGENDIAN = 0;
        public static int AV_HAVE_FAST_UNALIGNED = 1;
        // public static  AVERROR_BSF_NOT_FOUND = FFERRTAG(0xF8,'B','S','F');
        // public static  AVERROR_BUG = FFERRTAG( 'B','U','G','!');
        // public static  AVERROR_BUFFER_TOO_SMALL = FFERRTAG( 'B','U','F','S');
        // public static  AVERROR_DECODER_NOT_FOUND = FFERRTAG(0xF8,'D','E','C');
        // public static  AVERROR_DEMUXER_NOT_FOUND = FFERRTAG(0xF8,'D','E','M');
        // public static  AVERROR_ENCODER_NOT_FOUND = FFERRTAG(0xF8,'E','N','C');
        // public static  AVERROR_EOF = FFERRTAG( 'E','O','F',' ');
        // public static  AVERROR_EXIT = FFERRTAG( 'E','X','I','T');
        // public static  AVERROR_EXTERNAL = FFERRTAG( 'E','X','T',' ');
        // public static  AVERROR_FILTER_NOT_FOUND = FFERRTAG(0xF8,'F','I','L');
        // public static  AVERROR_INVALIDDATA = FFERRTAG( 'I','N','D','A');
        // public static  AVERROR_MUXER_NOT_FOUND = FFERRTAG(0xF8,'M','U','X');
        // public static  AVERROR_OPTION_NOT_FOUND = FFERRTAG(0xF8,'O','P','T');
        // public static  AVERROR_PATCHWELCOME = FFERRTAG( 'P','A','W','E');
        // public static  AVERROR_PROTOCOL_NOT_FOUND = FFERRTAG(0xF8,'P','R','O');
        // public static  AVERROR_STREAM_NOT_FOUND = FFERRTAG(0xF8,'S','T','R');
        // public static  AVERROR_BUG2 = FFERRTAG( 'B','U','G',' ');
        // public static  AVERROR_UNKNOWN = FFERRTAG( 'U','N','K','N');
        // public static  AVERROR_EXPERIMENTAL = (-0x2bb2afa8);
        // public static  AVERROR_INPUT_CHANGED = (-0x636e6701);
        // public static  AVERROR_OUTPUT_CHANGED = (-0x636e6702);
        // public static  AVERROR_HTTP_BAD_REQUEST = FFERRTAG(0xF8,'4','0','0');
        // public static  AVERROR_HTTP_UNAUTHORIZED = FFERRTAG(0xF8,'4','0','1');
        // public static  AVERROR_HTTP_FORBIDDEN = FFERRTAG(0xF8,'4','0','3');
        // public static  AVERROR_HTTP_NOT_FOUND = FFERRTAG(0xF8,'4','0','4');
        // public static  AVERROR_HTTP_OTHER_4XX = FFERRTAG(0xF8,'4','X','X');
        // public static  AVERROR_HTTP_SERVER_ERROR = FFERRTAG(0xF8,'5','X','X');
        public static int AV_ERROR_MAX_STRING_SIZE = 64;
        public static float M_E = 2.7182818284590452354f;
        public static float M_LN2 = 0.69314718055994530942f;
        public static float M_LN10 = 2.30258509299404568402f;
        public static float M_LOG2_10 = 3.32192809488736234787f;
        public static float M_PHI = 1.61803398874989484820f;
        public static float M_PI = 3.14159265358979323846f;
        public static float M_PI_2 = 1.57079632679489661923f;
        public static float M_SQRT1_2 = 0.70710678118654752440f;
        public static float M_SQRT2 = 1.41421356237309504880f;
        public static int AV_LOG_QUIET = -8;
        public static int AV_LOG_PANIC = 0;
        public static int AV_LOG_FATAL = 8;
        public static int AV_LOG_ERROR = 16;
        public static int AV_LOG_WARNING = 24;
        public static int AV_LOG_INFO = 32;
        public static int AV_LOG_VERBOSE = 40;
        public static int AV_LOG_DEBUG = 48;
        public static int AV_LOG_TRACE = 56;
        // public static  AV_LOG_MAX_OFFSET = (AV_LOG_TRACE - AV_LOG_QUIET);
        public static int AV_LOG_SKIP_REPEATED = 1;
        public static int AV_LOG_PRINT_LEVEL = 2;
        public static int AVPALETTE_SIZE = 1024;
        public static int AVPALETTE_COUNT = 256;
        // public static  AV_PIX_FMT_RGB32 = AV_PIX_FMT_NE(ARGB, BGRA);
        // public static  AV_PIX_FMT_RGB32_1 = AV_PIX_FMT_NE(RGBA, ABGR);
        // public static  AV_PIX_FMT_BGR32 = AV_PIX_FMT_NE(ABGR, RGBA);
        // public static  AV_PIX_FMT_BGR32_1 = AV_PIX_FMT_NE(BGRA, ARGB);
        // public static  AV_PIX_FMT_0RGB32 = AV_PIX_FMT_NE(0RGB, BGR0);
        // public static  AV_PIX_FMT_0BGR32 = AV_PIX_FMT_NE(0BGR, RGB0);
        // public static  AV_PIX_FMT_GRAY16 = AV_PIX_FMT_NE(GRAY16BE, GRAY16LE);
        // public static  AV_PIX_FMT_YA16 = AV_PIX_FMT_NE(YA16BE,   YA16LE);
        // public static  AV_PIX_FMT_RGB48 = AV_PIX_FMT_NE(RGB48BE,  RGB48LE);
        // public static  AV_PIX_FMT_RGB565 = AV_PIX_FMT_NE(RGB565BE, RGB565LE);
        // public static  AV_PIX_FMT_RGB555 = AV_PIX_FMT_NE(RGB555BE, RGB555LE);
        // public static  AV_PIX_FMT_RGB444 = AV_PIX_FMT_NE(RGB444BE, RGB444LE);
        // public static  AV_PIX_FMT_RGBA64 = AV_PIX_FMT_NE(RGBA64BE, RGBA64LE);
        // public static  AV_PIX_FMT_BGR48 = AV_PIX_FMT_NE(BGR48BE,  BGR48LE);
        // public static  AV_PIX_FMT_BGR565 = AV_PIX_FMT_NE(BGR565BE, BGR565LE);
        // public static  AV_PIX_FMT_BGR555 = AV_PIX_FMT_NE(BGR555BE, BGR555LE);
        // public static  AV_PIX_FMT_BGR444 = AV_PIX_FMT_NE(BGR444BE, BGR444LE);
        // public static  AV_PIX_FMT_BGRA64 = AV_PIX_FMT_NE(BGRA64BE, BGRA64LE);
        // public static  AV_PIX_FMT_YUV420P9 = AV_PIX_FMT_NE(YUV420P9BE , YUV420P9LE);
        // public static  AV_PIX_FMT_YUV422P9 = AV_PIX_FMT_NE(YUV422P9BE , YUV422P9LE);
        // public static  AV_PIX_FMT_YUV444P9 = AV_PIX_FMT_NE(YUV444P9BE , YUV444P9LE);
        // public static  AV_PIX_FMT_YUV420P10 = AV_PIX_FMT_NE(YUV420P10BE, YUV420P10LE);
        // public static  AV_PIX_FMT_YUV422P10 = AV_PIX_FMT_NE(YUV422P10BE, YUV422P10LE);
        // public static  AV_PIX_FMT_YUV440P10 = AV_PIX_FMT_NE(YUV440P10BE, YUV440P10LE);
        // public static  AV_PIX_FMT_YUV444P10 = AV_PIX_FMT_NE(YUV444P10BE, YUV444P10LE);
        // public static  AV_PIX_FMT_YUV420P12 = AV_PIX_FMT_NE(YUV420P12BE, YUV420P12LE);
        // public static  AV_PIX_FMT_YUV422P12 = AV_PIX_FMT_NE(YUV422P12BE, YUV422P12LE);
        // public static  AV_PIX_FMT_YUV440P12 = AV_PIX_FMT_NE(YUV440P12BE, YUV440P12LE);
        // public static  AV_PIX_FMT_YUV444P12 = AV_PIX_FMT_NE(YUV444P12BE, YUV444P12LE);
        // public static  AV_PIX_FMT_YUV420P14 = AV_PIX_FMT_NE(YUV420P14BE, YUV420P14LE);
        // public static  AV_PIX_FMT_YUV422P14 = AV_PIX_FMT_NE(YUV422P14BE, YUV422P14LE);
        // public static  AV_PIX_FMT_YUV444P14 = AV_PIX_FMT_NE(YUV444P14BE, YUV444P14LE);
        // public static  AV_PIX_FMT_YUV420P16 = AV_PIX_FMT_NE(YUV420P16BE, YUV420P16LE);
        // public static  AV_PIX_FMT_YUV422P16 = AV_PIX_FMT_NE(YUV422P16BE, YUV422P16LE);
        // public static  AV_PIX_FMT_YUV444P16 = AV_PIX_FMT_NE(YUV444P16BE, YUV444P16LE);
        // public static  AV_PIX_FMT_GBRP9 = AV_PIX_FMT_NE(GBRP9BE ,    GBRP9LE);
        // public static  AV_PIX_FMT_GBRP10 = AV_PIX_FMT_NE(GBRP10BE,    GBRP10LE);
        // public static  AV_PIX_FMT_GBRP12 = AV_PIX_FMT_NE(GBRP12BE,    GBRP12LE);
        // public static  AV_PIX_FMT_GBRP14 = AV_PIX_FMT_NE(GBRP14BE,    GBRP14LE);
        // public static  AV_PIX_FMT_GBRP16 = AV_PIX_FMT_NE(GBRP16BE,    GBRP16LE);
        // public static  AV_PIX_FMT_GBRAP10 = AV_PIX_FMT_NE(GBRAP10BE,   GBRAP10LE);
        // public static  AV_PIX_FMT_GBRAP12 = AV_PIX_FMT_NE(GBRAP12BE,   GBRAP12LE);
        // public static  AV_PIX_FMT_GBRAP16 = AV_PIX_FMT_NE(GBRAP16BE,   GBRAP16LE);
        // public static  AV_PIX_FMT_BAYER_BGGR16 = AV_PIX_FMT_NE(BAYER_BGGR16BE,    BAYER_BGGR16LE);
        // public static  AV_PIX_FMT_BAYER_RGGB16 = AV_PIX_FMT_NE(BAYER_RGGB16BE,    BAYER_RGGB16LE);
        // public static  AV_PIX_FMT_BAYER_GBRG16 = AV_PIX_FMT_NE(BAYER_GBRG16BE,    BAYER_GBRG16LE);
        // public static  AV_PIX_FMT_BAYER_GRBG16 = AV_PIX_FMT_NE(BAYER_GRBG16BE,    BAYER_GRBG16LE);
        // public static  AV_PIX_FMT_YUVA420P9 = AV_PIX_FMT_NE(YUVA420P9BE , YUVA420P9LE);
        // public static  AV_PIX_FMT_YUVA422P9 = AV_PIX_FMT_NE(YUVA422P9BE , YUVA422P9LE);
        // public static  AV_PIX_FMT_YUVA444P9 = AV_PIX_FMT_NE(YUVA444P9BE , YUVA444P9LE);
        // public static  AV_PIX_FMT_YUVA420P10 = AV_PIX_FMT_NE(YUVA420P10BE, YUVA420P10LE);
        // public static  AV_PIX_FMT_YUVA422P10 = AV_PIX_FMT_NE(YUVA422P10BE, YUVA422P10LE);
        // public static  AV_PIX_FMT_YUVA444P10 = AV_PIX_FMT_NE(YUVA444P10BE, YUVA444P10LE);
        // public static  AV_PIX_FMT_YUVA420P16 = AV_PIX_FMT_NE(YUVA420P16BE, YUVA420P16LE);
        // public static  AV_PIX_FMT_YUVA422P16 = AV_PIX_FMT_NE(YUVA422P16BE, YUVA422P16LE);
        // public static  AV_PIX_FMT_YUVA444P16 = AV_PIX_FMT_NE(YUVA444P16BE, YUVA444P16LE);
        // public static  AV_PIX_FMT_XYZ12 = AV_PIX_FMT_NE(XYZ12BE, XYZ12LE);
        // public static  AV_PIX_FMT_NV20 = AV_PIX_FMT_NE(NV20BE,  NV20LE);
        // public static  AV_PIX_FMT_AYUV64 = AV_PIX_FMT_NE(AYUV64BE, AYUV64LE);
        // public static  AV_PIX_FMT_P010 = AV_PIX_FMT_NE(P010BE,  P010LE);
        // public static  AVCOL_SPC_YCGCO = AVCOL_SPC_YCOCG;
        
        /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
        [DllImport("avutil-55", EntryPoint = "avutil_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avutil_version();
        
        /// <summary>Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.</summary>
        [DllImport("avutil-55", EntryPoint = "av_version_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_version_info();
        
        /// <summary>Return the libavutil build-time configuration.</summary>
        [DllImport("avutil-55", EntryPoint = "avutil_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avutil_configuration();
        
        /// <summary>Return the libavutil license.</summary>
        [DllImport("avutil-55", EntryPoint = "avutil_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avutil_license();
        
        /// <summary>Return a string describing the media_type enum, NULL if media_type is unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_media_type_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_media_type_string(AVMediaType @media_type);
        
        /// <summary>Return a single letter to describe the given picture type pict_type.</summary>
        /// <param name="pict_type">the picture type</param>
        [DllImport("avutil-55", EntryPoint = "av_get_picture_type_char", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte av_get_picture_type_char(AVPictureType @pict_type);
        
        /// <summary>Compute the length of an integer list.</summary>
        /// <param name="elsize">size in bytes of each list element (only 1, 2, 4 or 8)</param>
        /// <param name="list">pointer to the list</param>
        /// <param name="term">list terminator (usually 0 or -1)</param>
        [DllImport("avutil-55", EntryPoint = "av_int_list_length_for_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term);
        
        /// <summary>Open a file using a UTF-8 filename. The API of this function matches POSIX fopen(), errors are returned through errno.</summary>
        [DllImport("avutil-55", EntryPoint = "av_fopen_utf8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern FILE* av_fopen_utf8([MarshalAs(UnmanagedType.LPStr)] string @path, [MarshalAs(UnmanagedType.LPStr)] string @mode);
        
        /// <summary>Return the fractional representation of the internal time base.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_time_base_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_get_time_base_q();
        
        [DllImport("avutil-55", EntryPoint = "av_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log2(uint @v);
        
        [DllImport("avutil-55", EntryPoint = "av_log2_16bit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log2_16bit(uint @v);
        
        /// <summary>Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf.</summary>
        /// <param name="errnum">error code to describe</param>
        /// <param name="errbuf">buffer to which description is written</param>
        /// <param name="errbuf_size">the size in bytes of errbuf</param>
        [DllImport("avutil-55", EntryPoint = "av_strerror", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size);
        
        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU).</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        [DllImport("avutil-55", EntryPoint = "av_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_malloc(ulong @size);
        
        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block.</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        [DllImport("avutil-55", EntryPoint = "av_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_mallocz(ulong @size);
        
        /// <summary>Non-inlined equivalent of av_mallocz_array().</summary>
        [DllImport("avutil-55", EntryPoint = "av_calloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_calloc(ulong @nmemb, ulong @size);
        
        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="size">Size in bytes of the memory block to be allocated or reallocated</param>
        [DllImport("avutil-55", EntryPoint = "av_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc(void* @ptr, ulong @size);
        
        /// <summary>Allocate, reallocate, or free a block of memory through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="size">Size in bytes for the memory block to be allocated or reallocated</param>
        [DllImport("avutil-55", EntryPoint = "av_reallocp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reallocp(void* @ptr, ulong @size);
        
        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        [DllImport("avutil-55", EntryPoint = "av_realloc_f", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize);
        
        /// <summary>Allocate, reallocate, or free an array.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="nmemb">Number of elements in the array</param>
        /// <param name="size">Size of the single element of the array</param>
        [DllImport("avutil-55", EntryPoint = "av_realloc_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size);
        
        /// <summary>Allocate, reallocate, or free an array through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="nmemb">Number of elements</param>
        /// <param name="size">Size of the single element</param>
        [DllImport("avutil-55", EntryPoint = "av_reallocp_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size);
        
        /// <summary>Reallocate the given buffer if it is not large enough, otherwise do nothing.</summary>
        /// <param name="ptr">Already allocated buffer, or `NULL`</param>
        /// <param name="size">Pointer to current size of buffer `ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `ptr`</param>
        [DllImport("avutil-55", EntryPoint = "av_fast_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size);
        
        /// <summary>Allocate a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to current size of buffer `*ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `*ptr`</param>
        [DllImport("avutil-55", EntryPoint = "av_fast_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        /// <summary>Allocate and clear a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to current size of buffer `*ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `*ptr`</param>
        [DllImport("avutil-55", EntryPoint = "av_fast_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size);
        
        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family.</summary>
        /// <param name="ptr">Pointer to the memory block which should be freed.</param>
        [DllImport("avutil-55", EntryPoint = "av_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_free(void* @ptr);
        
        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`.</summary>
        /// <param name="ptr">Pointer to the pointer to the memory block which should be freed</param>
        [DllImport("avutil-55", EntryPoint = "av_freep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_freep(void* @ptr);
        
        /// <summary>Duplicate a string.</summary>
        /// <param name="s">String to be duplicated</param>
        [DllImport("avutil-55", EntryPoint = "av_strdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_strdup([MarshalAs(UnmanagedType.LPStr)] string @s);
        
        /// <summary>Duplicate a substring of a string.</summary>
        /// <param name="s">String to be duplicated</param>
        /// <param name="len">Maximum length of the resulting string (not counting the terminating byte)</param>
        [DllImport("avutil-55", EntryPoint = "av_strndup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_strndup([MarshalAs(UnmanagedType.LPStr)] string @s, ulong @len);
        
        /// <summary>Duplicate a buffer with av_malloc().</summary>
        /// <param name="p">Buffer to be duplicated</param>
        /// <param name="size">Size in bytes of the buffer copied</param>
        [DllImport("avutil-55", EntryPoint = "av_memdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_memdup(void* @p, ulong @size);
        
        /// <summary>Overlapping memcpy() implementation.</summary>
        /// <param name="dst">Destination buffer</param>
        /// <param name="back">Number of bytes back to start copying (i.e. the initial size of the overlapping window); must be > 0</param>
        /// <param name="cnt">Number of bytes to copy; must be >= 0</param>
        [DllImport("avutil-55", EntryPoint = "av_memcpy_backptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_memcpy_backptr(byte* @dst, int @back, int @cnt);
        
        /// <summary>Add the pointer to an element to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem">Element to add</param>
        [DllImport("avutil-55", EntryPoint = "av_dynarray_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        /// <summary>Add an element to a dynamic array.</summary>
        [DllImport("avutil-55", EntryPoint = "av_dynarray_add_nofree", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem_size">Size in bytes of an element in the array</param>
        /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
        [DllImport("avutil-55", EntryPoint = "av_dynarray2_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
        
        /// <summary>Set the maximum size that may be allocated in one block.</summary>
        /// <param name="max">Value to be set as the new maximum size</param>
        [DllImport("avutil-55", EntryPoint = "av_max_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_max_alloc(ulong @max);
        
        /// <summary>Reduce a fraction.</summary>
        /// <param name="dst_num">Destination numerator</param>
        /// <param name="dst_den">Destination denominator</param>
        /// <param name="num">Source numerator</param>
        /// <param name="den">Source denominator</param>
        /// <param name="max">Maximum allowed values for `dst_num` & `dst_den`</param>
        [DllImport("avutil-55", EntryPoint = "av_reduce", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
        
        /// <summary>Multiply two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        [DllImport("avutil-55", EntryPoint = "av_mul_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_mul_q(AVRational @b, AVRational @c);
        
        /// <summary>Divide one rational by another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        [DllImport("avutil-55", EntryPoint = "av_div_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_div_q(AVRational @b, AVRational @c);
        
        /// <summary>Add two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        [DllImport("avutil-55", EntryPoint = "av_add_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_add_q(AVRational @b, AVRational @c);
        
        /// <summary>Subtract one rational from another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        [DllImport("avutil-55", EntryPoint = "av_sub_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_sub_q(AVRational @b, AVRational @c);
        
        /// <summary>Convert a double precision floating point number to a rational.</summary>
        /// <param name="d">`double` to convert</param>
        /// <param name="max">Maximum allowed numerator and denominator</param>
        [DllImport("avutil-55", EntryPoint = "av_d2q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_d2q(double @d, int @max);
        
        /// <summary>Find which of the two rationals is closer to another rational.</summary>
        /// <param name="q">Rational to be compared against</param>
        [DllImport("avutil-55", EntryPoint = "av_nearer_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2);
        
        /// <summary>Find the value in a list of rationals nearest a given reference rational.</summary>
        /// <param name="q">Reference rational</param>
        /// <param name="q_list">Array of rationals terminated by `{0, 0}`</param>
        [DllImport("avutil-55", EntryPoint = "av_find_nearest_q_idx", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list);
        
        /// <summary>Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format.</summary>
        /// <param name="q">Rational to be converted</param>
        [DllImport("avutil-55", EntryPoint = "av_q2intfloat", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_q2intfloat(AVRational @q);
        
        /// <summary>Compute the greatest common divisor of two integer operands.</summary>
        [DllImport("avutil-55", EntryPoint = "av_gcd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_gcd(long @a, long @b);
        
        /// <summary>Rescale a 64-bit integer with rounding to nearest.</summary>
        [DllImport("avutil-55", EntryPoint = "av_rescale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale(long @a, long @b, long @c);
        
        /// <summary>Rescale a 64-bit integer with specified rounding.</summary>
        [DllImport("avutil-55", EntryPoint = "av_rescale_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd);
        
        /// <summary>Rescale a 64-bit integer by 2 rational numbers.</summary>
        [DllImport("avutil-55", EntryPoint = "av_rescale_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_q(long @a, AVRational @bq, AVRational @cq);
        
        /// <summary>Rescale a 64-bit integer by 2 rational numbers with specified rounding.</summary>
        [DllImport("avutil-55", EntryPoint = "av_rescale_q_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
        
        /// <summary>Compare two timestamps each in its own time base.</summary>
        [DllImport("avutil-55", EntryPoint = "av_compare_ts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
        
        /// <summary>Compare the remainders of two integer operands divided by a common divisor.</summary>
        /// <param name="mod">Divisor; must be a power of 2</param>
        [DllImport("avutil-55", EntryPoint = "av_compare_mod", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_compare_mod(ulong @a, ulong @b, ulong @mod);
        
        /// <summary>Rescale a timestamp while preserving known durations.</summary>
        /// <param name="in_tb">Input time base</param>
        /// <param name="in_ts">Input timestamp</param>
        /// <param name="fs_tb">Duration time base; typically this is finer-grained (greater) than `in_tb` and `out_tb`</param>
        /// <param name="duration">Duration till the next call to this function (i.e. duration of the current packet/frame)</param>
        /// <param name="last">Pointer to a timestamp expressed in terms of `fs_tb`, acting as a state variable</param>
        /// <param name="out_tb">Output timebase</param>
        [DllImport("avutil-55", EntryPoint = "av_rescale_delta", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
        
        /// <summary>Add a value to a timestamp.</summary>
        /// <param name="ts_tb">Input timestamp time base</param>
        /// <param name="ts">Input timestamp</param>
        /// <param name="inc_tb">Time base of `inc`</param>
        /// <param name="inc">Value to be added</param>
        [DllImport("avutil-55", EntryPoint = "av_add_stable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
        
        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        [DllImport("avutil-55", EntryPoint = "av_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt);
        
        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        [DllImport("avutil-55", EntryPoint = "av_vlog", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_vlog(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl);
        
        /// <summary>Get the current log level</summary>
        [DllImport("avutil-55", EntryPoint = "av_log_get_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_get_level();
        
        /// <summary>Set the log level</summary>
        /// <param name="level">Logging level</param>
        [DllImport("avutil-55", EntryPoint = "av_log_set_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_level(int @level);
        
        /// <summary>Set the logging callback</summary>
        /// <param name="callback">A logging function with a compatible signature.</param>
        [DllImport("avutil-55", EntryPoint = "av_log_set_callback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_callback(IntPtr @callback);
        
        /// <summary>Default logging callback</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        [DllImport("avutil-55", EntryPoint = "av_log_default_callback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_default_callback(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl);
        
        /// <summary>Return the context name</summary>
        /// <param name="ctx">The AVClass context</param>
        [DllImport("avutil-55", EntryPoint = "av_default_item_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_default_item_name(void* @ctx);
        
        [DllImport("avutil-55", EntryPoint = "av_default_get_category", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClassCategory av_default_get_category(void* @ptr);
        
        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line</param>
        /// <param name="line_size">size of the buffer</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        [DllImport("avutil-55", EntryPoint = "av_log_format_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_format_line(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        
        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line; may be NULL if line_size is 0</param>
        /// <param name="line_size">size of the buffer; at most line_size-1 characters will be written to the buffer, plus one null terminator</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        [DllImport("avutil-55", EntryPoint = "av_log_format_line2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_format_line2(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        
        [DllImport("avutil-55", EntryPoint = "av_log_set_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_flags(int @arg);
        
        [DllImport("avutil-55", EntryPoint = "av_log_get_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_get_flags();
        
        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="size">of FIFO</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFifoBuffer* av_fifo_alloc(uint @size);
        
        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="nmemb">number of elements</param>
        /// <param name="size">size of the single element</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_alloc_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFifoBuffer* av_fifo_alloc_array(ulong @nmemb, ulong @size);
        
        /// <summary>Free an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_free(AVFifoBuffer* @f);
        
        /// <summary>Free an AVFifoBuffer and reset pointer to NULL.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_freep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_freep(AVFifoBuffer** @f);
        
        /// <summary>Reset the AVFifoBuffer to the state right after av_fifo_alloc, in particular it is emptied.</summary>
        /// <param name="f">AVFifoBuffer to reset</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_reset", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_reset(AVFifoBuffer* @f);
        
        /// <summary>Return the amount of data in bytes in the AVFifoBuffer, that is the amount of data you can read from it.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_size(AVFifoBuffer* @f);
        
        /// <summary>Return the amount of space in bytes in the AVFifoBuffer, that is the amount of data you can write into it.</summary>
        /// <param name="f">AVFifoBuffer to write into</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_space", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_space(AVFifoBuffer* @f);
        
        /// <summary>Feed data at specific position from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="offset">offset from current read position</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_generic_peek_at", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_peek_at(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, IntPtr @func);
        
        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_generic_peek", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_peek(AVFifoBuffer* @f, void* @dest, int @buf_size, IntPtr @func);
        
        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_generic_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_read(AVFifoBuffer* @f, void* @dest, int @buf_size, IntPtr @func);
        
        /// <summary>Feed data from a user-supplied callback to an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to write to</param>
        /// <param name="src">data source; non-const since it may be used as a modifiable context by the function defined in func</param>
        /// <param name="size">number of bytes to write</param>
        /// <param name="func">generic write function; the first parameter is src, the second is dest_buf, the third is dest_buf_size. func must return the number of bytes written to dest_buf, or < = 0 to indicate no more data available to write. If func is NULL, src is interpreted as a simple byte array for source data.</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_generic_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_write(AVFifoBuffer* @f, void* @src, int @size, IntPtr @func);
        
        /// <summary>Resize an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="size">new AVFifoBuffer size in bytes</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_realloc2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_realloc2(AVFifoBuffer* @f, uint @size);
        
        /// <summary>Enlarge an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged. The new fifo size may be larger than the requested size.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="additional_space">the amount of space in bytes to allocate in addition to av_fifo_size()</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_grow", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_grow(AVFifoBuffer* @f, uint @additional_space);
        
        /// <summary>Read and discard the specified amount of data from an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="size">amount of data to read in bytes</param>
        [DllImport("avutil-55", EntryPoint = "av_fifo_drain", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_drain(AVFifoBuffer* @f, int @size);
        
        /// <summary>Return the name of sample_fmt, or NULL if sample_fmt is not recognized.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_sample_fmt_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_sample_fmt_name(AVSampleFormat @sample_fmt);
        
        /// <summary>Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_sample_fmt([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Return the planar<->packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_alt_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar);
        
        /// <summary>Get the packed alternative form of the given sample format.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_packed_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt);
        
        /// <summary>Get the planar alternative form of the given sample format.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_planar_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt);
        
        /// <summary>Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="sample_fmt">the number of the sample format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        [DllImport("avutil-55", EntryPoint = "av_get_sample_fmt_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
        
        /// <summary>Return number of bytes per sample.</summary>
        /// <param name="sample_fmt">the sample format</param>
        [DllImport("avutil-55", EntryPoint = "av_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_bytes_per_sample(AVSampleFormat @sample_fmt);
        
        /// <summary>Check if the sample format is planar.</summary>
        /// <param name="sample_fmt">the sample format to inspect</param>
        [DllImport("avutil-55", EntryPoint = "av_sample_fmt_is_planar", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt);
        
        /// <summary>Get the required buffer size for the given audio parameters.</summary>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        [DllImport("avutil-55", EntryPoint = "av_samples_get_buffer_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="buf">the pointer to a buffer containing the samples</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        [DllImport("avutil-55", EntryPoint = "av_samples_fill_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&audio_data[0]) Allocated data will be initialized to silence.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="nb_samples">number of samples per channel</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        [DllImport("avutil-55", EntryPoint = "av_samples_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
        [DllImport("avutil-55", EntryPoint = "av_samples_alloc_array_and_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        /// <summary>Copy samples from src to dst.</summary>
        /// <param name="dst">destination array of pointers to data planes</param>
        /// <param name="src">source array of pointers to data planes</param>
        /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
        /// <param name="src_offset">offset in samples at which the data will be read from src</param>
        /// <param name="nb_samples">number of samples to be copied</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        [DllImport("avutil-55", EntryPoint = "av_samples_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        /// <summary>Fill an audio buffer with silence.</summary>
        /// <param name="audio_data">array of pointers to data planes</param>
        /// <param name="offset">offset in samples at which to start filling</param>
        /// <param name="nb_samples">number of samples to fill</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        [DllImport("avutil-55", EntryPoint = "av_samples_set_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        /// <summary>Free an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to free</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_audio_fifo_free(AVAudioFifo* @af);
        
        /// <summary>Allocate an AVAudioFifo.</summary>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="channels">number of channels</param>
        /// <param name="nb_samples">initial allocation size, in samples</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
        
        /// <summary>Reallocate an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to reallocate</param>
        /// <param name="nb_samples">new allocation size, in samples</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples);
        
        /// <summary>Write data to an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to write to</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to write</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_peek", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        /// <param name="offset">offset from current read position</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_peek_at", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
        
        /// <summary>Read data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to read</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        /// <summary>Drain data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to drain</param>
        /// <param name="nb_samples">number of samples to drain</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_drain", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples);
        
        /// <summary>Reset the AVAudioFifo buffer.</summary>
        /// <param name="af">AVAudioFifo to reset</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_reset", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_audio_fifo_reset(AVAudioFifo* @af);
        
        /// <summary>Get the current number of samples in the AVAudioFifo available for reading.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_size(AVAudioFifo* @af);
        
        /// <summary>Get the current number of samples in the AVAudioFifo available for writing.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        [DllImport("avutil-55", EntryPoint = "av_audio_fifo_space", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_space(AVAudioFifo* @af);
        
        /// <summary>Return a channel layout id that matches name, or 0 if no match is found.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_get_channel_layout([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Return a description of a channel layout. If nb_channels is <= 0, it is guessed from the channel_layout.</summary>
        /// <param name="buf">put here the string containing the channel layout</param>
        /// <param name="buf_size">size in bytes of the buffer</param>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_layout_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_get_channel_layout_string(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout);
        
        /// <summary>Append a description of a channel layout to a bprint buffer.</summary>
        [DllImport("avutil-55", EntryPoint = "av_bprint_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_bprint_channel_layout(IntPtr @bp, int @nb_channels, ulong @channel_layout);
        
        /// <summary>Return the number of channels in the channel layout.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_layout_nb_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_channel_layout_nb_channels(ulong @channel_layout);
        
        /// <summary>Return default channel layout for a given number of channels.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_default_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_get_default_channel_layout(int @nb_channels);
        
        /// <summary>Get the index of a channel in channel_layout.</summary>
        /// <param name="channel">a channel layout describing exactly one channel which must be present in channel_layout.</param>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_layout_channel_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_channel_layout_channel_index(ulong @channel_layout, ulong @channel);
        
        /// <summary>Get the channel with the given index in channel_layout.</summary>
        [DllImport("avutil-55", EntryPoint = "av_channel_layout_extract_channel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_channel_layout_extract_channel(ulong @channel_layout, int @index);
        
        /// <summary>Get the name of a given channel.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_channel_name(ulong @channel);
        
        /// <summary>Get the description of a given channel.</summary>
        /// <param name="channel">a channel layout with a single channel</param>
        [DllImport("avutil-55", EntryPoint = "av_get_channel_description", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_channel_description(ulong @channel);
        
        /// <summary>Get the value and name of a standard channel layout.</summary>
        /// <param name="index">index in an internal list, starting at 0</param>
        /// <param name="layout">channel layout mask</param>
        /// <param name="name">name of the layout</param>
        [DllImport("avutil-55", EntryPoint = "av_get_standard_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_standard_channel_layout(uint @index, ulong* @layout, byte** @name);
        
        /// <summary>Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_cpu_flags();
        
        /// <summary>Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags.</summary>
        [DllImport("avutil-55", EntryPoint = "av_force_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_force_cpu_flags(int @flags);
        
        /// <summary>Set a mask on flags returned by av_get_cpu_flags(). This function is mainly useful for testing. Please use av_force_cpu_flags() and av_get_cpu_flags() instead which are more flexible</summary>
        [DllImport("avutil-55", EntryPoint = "av_set_cpu_flags_mask", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_set_cpu_flags_mask(int @mask);
        
        /// <summary>Parse CPU flags from a string.</summary>
        [DllImport("avutil-55", EntryPoint = "av_parse_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parse_cpu_flags([MarshalAs(UnmanagedType.LPStr)] string @s);
        
        /// <summary>Parse CPU caps from a string and update the given AV_CPU_* flags based on that.</summary>
        [DllImport("avutil-55", EntryPoint = "av_parse_cpu_caps", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parse_cpu_caps(uint* @flags, [MarshalAs(UnmanagedType.LPStr)] string @s);
        
        /// <summary>Returns the number of logical CPU cores present.</summary>
        [DllImport("avutil-55", EntryPoint = "av_cpu_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_cpu_count();
        
        /// <summary>Allocate an AVBuffer of the given size using av_malloc().</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_alloc(int @size);
        
        /// <summary>Same as av_buffer_alloc(), except the returned buffer will be initialized to zero.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_allocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_allocz(int @size);
        
        /// <summary>Create an AVBuffer from an existing array.</summary>
        /// <param name="data">data array</param>
        /// <param name="size">size of data in bytes</param>
        /// <param name="free">a callback for freeing this buffer's data</param>
        /// <param name="opaque">parameter to be got for processing or passed to free</param>
        /// <param name="flags">a combination of AV_BUFFER_FLAG_*</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_create(byte* @data, int @size, IntPtr @free, void* @opaque, int @flags);
        
        /// <summary>Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_default_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_default_free(void* @opaque, byte* @data);
        
        /// <summary>Create a new reference to an AVBuffer.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_ref(AVBufferRef* @buf);
        
        /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
        /// <param name="buf">the reference to be freed. The pointer is set to NULL on return.</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_unref(AVBufferRef** @buf);
        
        /// <summary>Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_is_writable(AVBufferRef* @buf);
        
        /// <summary>Returns the opaque parameter set by av_buffer_create.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_get_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_buffer_get_opaque(AVBufferRef* @buf);
        
        [DllImport("avutil-55", EntryPoint = "av_buffer_get_ref_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_get_ref_count(AVBufferRef* @buf);
        
        /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
        /// <param name="buf">buffer reference to make writable. On success, buf is either left untouched, or it is unreferenced and a new writable AVBufferRef is written in its place. On failure, buf is left untouched.</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_make_writable(AVBufferRef** @buf);
        
        /// <summary>Reallocate a given buffer.</summary>
        /// <param name="buf">a buffer reference to reallocate. On success, buf will be unreferenced and a new reference with the required size will be written in its place. On failure buf will be left untouched. *buf may be NULL, then a new buffer is allocated.</param>
        /// <param name="size">required new buffer size.</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_realloc(AVBufferRef** @buf, int @size);
        
        /// <summary>Allocate and initialize a buffer pool.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_pool_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferPool* av_buffer_pool_init(int @size, IntPtr @alloc);
        
        /// <summary>Allocate and initialize a buffer pool with a more complex allocator.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="opaque">arbitrary user data used by the allocator</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty.</param>
        /// <param name="pool_free">a function that will be called immediately before the pool is freed. I.e. after av_buffer_pool_can_uninit() is called by the pool and all the frames are returned to the pool and freed. It is intended to uninitialize the user opaque data.</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_pool_init2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferPool* av_buffer_pool_init2(int @size, void* @opaque, IntPtr @alloc, IntPtr @pool_free);
        
        /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
        /// <param name="pool">pointer to the pool to be freed. It will be set to NULL.</param>
        [DllImport("avutil-55", EntryPoint = "av_buffer_pool_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_pool_uninit(AVBufferPool** @pool);
        
        /// <summary>Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads.</summary>
        [DllImport("avutil-55", EntryPoint = "av_buffer_pool_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool);
        
        /// <summary>Get a dictionary entry with matching key.</summary>
        /// <param name="key">matching key</param>
        /// <param name="prev">Set to the previous matching element to find the next. If set to NULL the first matching element is returned.</param>
        /// <param name="flags">a collection of AV_DICT_* flags controlling how the entry is retrieved</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDictionaryEntry* av_dict_get(AVDictionary* @m, [MarshalAs(UnmanagedType.LPStr)] string @key, AVDictionaryEntry* @prev, int @flags);
        
        /// <summary>Get number of entries in dictionary.</summary>
        /// <param name="m">dictionary</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_count(AVDictionary* @m);
        
        /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
        /// <param name="pm">pointer to a pointer to a dictionary struct. If *pm is NULL a dictionary struct is allocated and put in *pm.</param>
        /// <param name="key">entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
        /// <param name="value">entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_set(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, [MarshalAs(UnmanagedType.LPStr)] string @value, int @flags);
        
        /// <summary>Convenience wrapper for av_dict_set that converts the value to a string and stores it.</summary>
        [DllImport("avutil-55", EntryPoint = "av_dict_set_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_set_int(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, long @value, int @flags);
        
        /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        /// <param name="flags">flags to use when adding to dictionary. AV_DICT_DONT_STRDUP_KEY and AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_parse_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_parse_string(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @str, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, int @flags);
        
        /// <summary>Copy entries from one AVDictionary struct into another.</summary>
        /// <param name="dst">pointer to a pointer to a AVDictionary struct. If *dst is NULL, this function will allocate a struct for you and put it in *dst</param>
        /// <param name="src">pointer to source AVDictionary struct</param>
        /// <param name="flags">flags to use when setting entries in *dst</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags);
        
        /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
        [DllImport("avutil-55", EntryPoint = "av_dict_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_dict_free(AVDictionary** @m);
        
        /// <summary>Get dictionary entries as a string.</summary>
        /// <param name="m">dictionary</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg entries. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        [DllImport("avutil-55", EntryPoint = "av_dict_get_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        
        /// <summary>Accessors for some AVFrame fields. The position of these field in the structure is not part of the ABI, they should not be accessed directly outside libavutil.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_get_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_best_effort_timestamp(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_best_effort_timestamp(AVFrame* @frame, long @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_pkt_duration(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_duration(AVFrame* @frame, long @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_pkt_pos(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_pos(AVFrame* @frame, long @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_channel_layout(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_channel_layout(AVFrame* @frame, long @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_channels(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_channels(AVFrame* @frame, int @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_sample_rate(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_sample_rate(AVFrame* @frame, int @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDictionary* av_frame_get_metadata(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_metadata(AVFrame* @frame, AVDictionary* @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_decode_error_flags(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_decode_error_flags(AVFrame* @frame, int @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_pkt_size(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_size(AVFrame* @frame, int @val);
        
        [DllImport("avutil-55", EntryPoint = "avpriv_frame_get_metadatap", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDictionary** avpriv_frame_get_metadatap(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern sbyte* av_frame_get_qp_table(AVFrame* @f, int* @stride, int* @type);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_set_qp_table(AVFrame* @f, AVBufferRef* @buf, int @stride, int @type);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_colorspace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVColorSpace av_frame_get_colorspace(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_colorspace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_colorspace(AVFrame* @frame, AVColorSpace @val);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_get_color_range", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVColorRange av_frame_get_color_range(AVFrame* @frame);
        
        [DllImport("avutil-55", EntryPoint = "av_frame_set_color_range", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_color_range(AVFrame* @frame, AVColorRange @val);
        
        /// <summary>Get the name of a colorspace.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_colorspace_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_colorspace_name(AVColorSpace @val);
        
        /// <summary>Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free().</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrame* av_frame_alloc();
        
        /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
        /// <param name="frame">frame to be freed. The pointer will be set to NULL.</param>
        [DllImport("avutil-55", EntryPoint = "av_frame_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_free(AVFrame** @frame);
        
        /// <summary>Set up a new reference to the data described by the source frame.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_ref(AVFrame* @dst, AVFrame* @src);
        
        /// <summary>Create a new frame that references the same data as src.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_clone", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrame* av_frame_clone(AVFrame* @src);
        
        /// <summary>Unreference all the buffers referenced by frame and reset the frame fields.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_unref(AVFrame* @frame);
        
        /// <summary>Move everything contained in src to dst and reset src.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_move_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_move_ref(AVFrame* @dst, AVFrame* @src);
        
        /// <summary>Allocate new buffer(s) for audio or video data.</summary>
        /// <param name="frame">frame in which to store the new buffers.</param>
        /// <param name="align">required buffer size alignment</param>
        [DllImport("avutil-55", EntryPoint = "av_frame_get_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_buffer(AVFrame* @frame, int @align);
        
        /// <summary>Check if the frame data is writable.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_is_writable(AVFrame* @frame);
        
        /// <summary>Ensure that the frame data is writable, avoiding data copy if possible.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_make_writable(AVFrame* @frame);
        
        /// <summary>Copy the frame data from src to dst.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_copy(AVFrame* @dst, AVFrame* @src);
        
        /// <summary>Copy only "metadata" fields from src to dst.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_copy_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_copy_props(AVFrame* @dst, AVFrame* @src);
        
        /// <summary>Get the buffer reference a given data plane is stored in.</summary>
        /// <param name="plane">index of the data plane of interest in frame->extended_data.</param>
        [DllImport("avutil-55", EntryPoint = "av_frame_get_plane_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane);
        
        /// <summary>Add a new side data to a frame.</summary>
        /// <param name="frame">a frame to which the side data should be added</param>
        /// <param name="type">type of the added side data</param>
        /// <param name="size">size of the side data</param>
        [DllImport("avutil-55", EntryPoint = "av_frame_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, int @size);
        
        /// <summary>Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        /// <summary>If side data of the supplied type exists in the frame, free it and remove it from the frame.</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_remove_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        /// <summary>Returns a string identifying the side data type</summary>
        [DllImport("avutil-55", EntryPoint = "av_frame_side_data_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_frame_side_data_name(AVFrameSideDataType @type);
        
        /// <summary>Show the obj options.</summary>
        /// <param name="av_log_obj">log context to use for showing the options</param>
        /// <param name="req_flags">requested flags for the options to show. Show only the options for which it is opt->flags & req_flags.</param>
        /// <param name="rej_flags">rejected flags for the options to show. Show only the options for which it is !(opt->flags & req_flags).</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_show2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
        
        /// <summary>Set the values of all AVOption fields to their default values.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set_defaults", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_set_defaults(void* @s);
        
        /// <summary>Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt->flags & mask) == flags will have their default applied to s.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        /// <param name="mask">combination of AV_OPT_FLAG_*</param>
        /// <param name="flags">combination of AV_OPT_FLAG_*</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set_defaults2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_set_defaults2(void* @s, int @mask, int @flags);
        
        /// <summary>Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions.</summary>
        /// <param name="opts">options string to parse, may be NULL</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        [DllImport("avutil-55", EntryPoint = "av_set_options_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_set_options_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        
        /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
        /// <param name="ctx">the AVClass object to set options on</param>
        /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
        /// <param name="shorthand">a NULL-terminated array of options names for shorthand notation: if the first field in opts has no key part, the key is taken from the first element of shorthand; then again for the second, etc., until either opts is finished, shorthand is finished or a named option is found; after that, all options must be named</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example '='</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example ':' or ','</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set_from_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_from_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, byte** @shorthand, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        
        /// <summary>Free all allocated objects in obj.</summary>
        [DllImport("avutil-55", EntryPoint = "av_opt_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_free(void* @obj);
        
        /// <summary>Check whether a particular flag is set in a flags field.</summary>
        /// <param name="field_name">the name of the flag field option</param>
        /// <param name="flag_name">the name of the flag to check</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_flag_is_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_flag_is_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @field_name, [MarshalAs(UnmanagedType.LPStr)] string @flag_name);
        
        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set_dict", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict(void* @obj, IntPtr* @options);
        
        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set_dict2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict2(void* @obj, IntPtr* @options, int @search_flags);
        
        /// <summary>Extract a key-value pair from the beginning of a string.</summary>
        /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example '='</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example ':' or ','</param>
        /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
        /// <param name="rkey">parsed key; must be freed using av_free()</param>
        /// <param name="rval">parsed value; must be freed using av_free()</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_get_key_value", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_key_value(byte** @ropts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);
        
        /// <summary>@{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass.</param>
        /// <param name="o">an option for which the string is to be evaluated.</param>
        /// <param name="val">string to be evaluated.</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_flags(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @flags_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_int(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @int_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_int64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_int64(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, long* @int64_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_float", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_float(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, float* @float_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_double(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, double* @double_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_eval_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_q(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, AVRational* @q_out);
        
        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_find", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_find(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags);
        
        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        /// <param name="target_obj">if non-NULL, an object to which the option belongs will be written here. It may be different from obj if AV_OPT_SEARCH_CHILDREN is present in search_flags. This parameter is ignored if search_flags contain AV_OPT_SEARCH_FAKE_OBJ.</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_find2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_find2(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags, void** @target_obj);
        
        /// <summary>Iterate over all AVOptions belonging to obj.</summary>
        /// <param name="obj">an AVOptions-enabled struct or a double pointer to an AVClass describing it.</param>
        /// <param name="prev">result of the previous call to av_opt_next() on this object or NULL</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_next(void* @obj, AVOption* @prev);
        
        /// <summary>Iterate over AVOptions-enabled children of obj.</summary>
        /// <param name="prev">result of a previous call to this function or NULL</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_child_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_opt_child_next(void* @obj, void* @prev);
        
        /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
        /// <param name="prev">result of a previous call to this function or NULL</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_child_class_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* av_opt_child_class_next(AVClass* @parent, AVClass* @prev);
        
        /// <summary>@{ Those functions set the field of obj with the given name to value.</summary>
        /// <param name="obj">A struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">the name of the field to set</param>
        /// <param name="val">The value to set. In case of av_opt_set() if the field is not of a string type, then the given string is parsed. SI postfixes and some named scalars are supported. If the field is of a numeric type, it has to be a numeric or named scalar. Behavior with more than one scalar and +- infix operators is undefined. If the field is of a flags type, it has to be a sequence of numeric scalars or named flags separated by '+' or '-'. Prefixing a flag with '+' causes it to be set without affecting the other flags; similarly, '-' unsets a flag.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be set on a child of obj.</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @val, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @val, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, double @val, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_bin", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_bin(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, byte* @val, int @size, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_image_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @w, int @h, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_pixel_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVPixelFormat @fmt, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVSampleFormat @fmt, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_video_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @ch_layout, int @search_flags);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_set_dict_val", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVDictionary* @val, int @search_flags);
        
        /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">name of the option to get.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
        /// <param name="out_val">value of the option will be written here</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, byte** @out_val);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @out_val);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, double* @out_val);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_image_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, int* @w_out, int* @h_out);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_pixel_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, IntPtr @out_fmt);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, IntPtr @out_fmt);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_video_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        
        [DllImport("avutil-55", EntryPoint = "av_opt_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @ch_layout);
        
        /// <param name="out_val">The returned dictionary is a copy of the actual value and must be freed with av_dict_free() by the caller</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_get_dict_val", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVDictionary** @out_val);
        
        /// <summary>@}</summary>
        [DllImport("avutil-55", EntryPoint = "av_opt_ptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_opt_ptr(AVClass* @avclass, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
        [DllImport("avutil-55", EntryPoint = "av_opt_freep_ranges", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_freep_ranges(AVOptionRanges** @ranges);
        
        /// <summary>Get a list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_query_ranges", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_query_ranges(AVOptionRanges** @p44, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        
        /// <summary>Copy options from src object into dest object.</summary>
        /// <param name="dest">Object to copy from</param>
        /// <param name="src">Object to copy into</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_copy(void* @dest, void* @src);
        
        /// <summary>Get a default list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_query_ranges_default", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_query_ranges_default(AVOptionRanges** @p46, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        
        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="o">option to be checked</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_is_set_to_default", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_is_set_to_default(void* @obj, AVOption* @o);
        
        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="name">option name</param>
        /// <param name="search_flags">combination of AV_OPT_SEARCH_*</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_is_set_to_default_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_is_set_to_default_by_name(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags);
        
        /// <summary>Serialize object's options.</summary>
        /// <param name="obj">AVClass object to serialize</param>
        /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
        /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg serialized options. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        [DllImport("avutil-55", EntryPoint = "av_opt_serialize", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        
        /// <summary>Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_bits_per_pixel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        /// <summary>Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_padded_bits_per_pixel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        /// <summary>Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_desc_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt);
        
        /// <summary>Iterate over all pixel format descriptors known to libavutil.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_desc_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev);
        
        /// <summary>Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</summary>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_desc_get_id", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc);
        
        /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <param name="h_shift">store log2_chroma_w (horizontal/width shift)</param>
        /// <param name="v_shift">store log2_chroma_h (vertical/height shift)</param>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        /// <summary>Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</summary>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_count_planes", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt);
        
        /// <summary>Returns the name for provided color range or NULL if unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_color_range_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_color_range_name(AVColorRange @range);
        
        /// <summary>Returns the name for provided color primaries or NULL if unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_color_primaries_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_color_primaries_name(AVColorPrimaries @primaries);
        
        /// <summary>Returns the name for provided color transfer or NULL if unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_color_transfer_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_color_transfer_name(AVColorTransferCharacteristic @transfer);
        
        /// <summary>Returns the name for provided color space or NULL if unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_color_space_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_color_space_name(AVColorSpace @space);
        
        /// <summary>Returns the name for provided chroma location or NULL if unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_chroma_location_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_chroma_location_name(AVChromaLocation @location);
        
        /// <summary>Return the pixel format corresponding to name.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_pix_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_get_pix_fmt([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Return the short name for a pixel format, NULL in case pix_fmt is unknown.</summary>
        [DllImport("avutil-55", EntryPoint = "av_get_pix_fmt_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_pix_fmt_name(AVPixelFormat @pix_fmt);
        
        /// <summary>Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="pix_fmt">the number of the pixel format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        [DllImport("avutil-55", EntryPoint = "av_get_pix_fmt_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
        
        /// <summary>Read a line from an image, and write the values of the pixel format component c to dst.</summary>
        /// <param name="data">the array containing the pointers to the planes of the image</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to read</param>
        /// <param name="y">the vertical coordinate of the first pixel to read</param>
        /// <param name="w">the width of the line to read, that is the number of values to write to dst</param>
        /// <param name="read_pal_component">if not zero and the format is a paletted format writes the values corresponding to the palette component c in data[1] to dst, rather than the palette indexes in data[0]. The behavior is undefined if the format is not paletted.</param>
        [DllImport("avutil-55", EntryPoint = "av_read_image_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_read_image_line(ushort* @dst, byte*[] @data, int[] @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
        
        /// <summary>Write the values from src to the pixel format component c of an image line.</summary>
        /// <param name="src">array containing the values to write</param>
        /// <param name="data">the array containing the pointers to the planes of the image to write into. It is supposed to be zeroed.</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to write</param>
        /// <param name="y">the vertical coordinate of the first pixel to write</param>
        /// <param name="w">the width of the line to write, that is the number of values to write to the image line</param>
        [DllImport("avutil-55", EntryPoint = "av_write_image_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_write_image_line(ushort* @src, byte*[] @data, int[] @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
        
        /// <summary>Utility function to swap the endianness of a pixel format.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        [DllImport("avutil-55", EntryPoint = "av_pix_fmt_swap_endianness", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt);
        
        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="dst_pix_fmt">destination pixel format</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        [DllImport("avutil-55", EntryPoint = "av_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        [DllImport("avutil-55", EntryPoint = "av_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        /// <summary>Compute the max pixel step for each plane of an image with a format described by pixdesc.</summary>
        /// <param name="max_pixsteps">an array which is filled with the max pixel step for each plane. Since a plane may contain different pixel components, the computed max_pixsteps[plane] is relative to the component in the plane with the max pixel step.</param>
        /// <param name="max_pixstep_comps">an array which is filled with the component for each plane which has the max pixel step. May be NULL.</param>
        [DllImport("avutil-55", EntryPoint = "av_image_fill_max_pixsteps", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_fill_max_pixsteps(int[] @max_pixsteps, int[] @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
        
        /// <summary>Compute the size of an image line with format pix_fmt and width width for the plane plane.</summary>
        [DllImport("avutil-55", EntryPoint = "av_image_get_linesize", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane);
        
        /// <summary>Fill plane linesizes for an image with pixel format pix_fmt and width width.</summary>
        /// <param name="linesizes">array to be filled with the linesize for each plane</param>
        [DllImport("avutil-55", EntryPoint = "av_image_fill_linesizes", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_linesizes(int[] @linesizes, AVPixelFormat @pix_fmt, int @width);
        
        /// <summary>Fill plane data pointers for an image with pixel format pix_fmt and height height.</summary>
        /// <param name="data">pointers array to be filled with the pointer for each image plane</param>
        /// <param name="ptr">the pointer to a buffer which will contain the image</param>
        /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
        [DllImport("avutil-55", EntryPoint = "av_image_fill_pointers", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_pointers(byte*[] @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int[] @linesizes);
        
        /// <summary>Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&pointers[0]).</summary>
        /// <param name="align">the value to use for buffer size alignment</param>
        [DllImport("avutil-55", EntryPoint = "av_image_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_alloc(byte*[] @pointers, int[] @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
        
        /// <summary>Copy image plane from src to dst. That is, copy "height" number of lines of "bytewidth" bytes each. The first byte of each successive line is separated by *_linesize bytes.</summary>
        /// <param name="dst_linesize">linesize for the image plane in dst</param>
        /// <param name="src_linesize">linesize for the image plane in src</param>
        [DllImport("avutil-55", EntryPoint = "av_image_copy_plane", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
        
        /// <summary>Copy image in src_data to dst_data.</summary>
        /// <param name="dst_linesizes">linesizes for the image in dst_data</param>
        /// <param name="src_linesizes">linesizes for the image in src_data</param>
        [DllImport("avutil-55", EntryPoint = "av_image_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_copy(byte*[] @dst_data, int[] @dst_linesizes, byte*[] @src_data, int[] @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        
        /// <summary>Setup the data pointers and linesizes based on the specified image parameters and the provided array.</summary>
        /// <param name="dst_data">data pointers to be filled in</param>
        /// <param name="src">buffer which will contain or contains the actual image data, can be NULL</param>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <param name="align">the value used in src for linesize alignment</param>
        [DllImport("avutil-55", EntryPoint = "av_image_fill_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_arrays(byte*[] @dst_data, int[] @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        /// <summary>Return the size in bytes of the amount of data required to store an image with the given parameters.</summary>
        /// <param name="align">the assumed linesize alignment</param>
        [DllImport("avutil-55", EntryPoint = "av_image_get_buffer_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        /// <summary>Copy image data from an image into a buffer.</summary>
        /// <param name="dst">a buffer into which picture data will be copied</param>
        /// <param name="dst_size">the size in bytes of dst</param>
        /// <param name="src_data">pointers containing the source image data</param>
        /// <param name="pix_fmt">the pixel format of the source image</param>
        /// <param name="width">the width of the source image in pixels</param>
        /// <param name="height">the height of the source image in pixels</param>
        /// <param name="align">the assumed linesize alignment for dst</param>
        [DllImport("avutil-55", EntryPoint = "av_image_copy_to_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_copy_to_buffer(byte* @dst, int @dst_size, byte*[] @src_data, int[] @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int.</summary>
        /// <param name="w">the width of the picture</param>
        /// <param name="h">the height of the picture</param>
        /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
        /// <param name="log_ctx">the parent logging context, it may be NULL</param>
        [DllImport("avutil-55", EntryPoint = "av_image_check_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx);
        
        /// <summary>Check if the given sample aspect ratio of an image is valid.</summary>
        /// <param name="w">width of the image</param>
        /// <param name="h">height of the image</param>
        /// <param name="sar">sample aspect ratio of the image</param>
        [DllImport("avutil-55", EntryPoint = "av_image_check_sar", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_check_sar(uint @w, uint @h, AVRational @sar);
        
    }
}
