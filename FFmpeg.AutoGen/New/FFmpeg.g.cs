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
    
    /// <summary>Identify the syntax and semantics of the bitstream. The principle is roughly: Two decoders with the same ID can decode the same streams. Two encoders with the same ID can encode compatible streams. There may be slight deviations from the principle due to implementation details.</summary>
    public enum AVCodecID : int
    {
        @AV_CODEC_ID_NONE = 0,
        @AV_CODEC_ID_MPEG1VIDEO = 1,
        /// <summary>preferred ID for MPEG-1/2 video decoding</summary>
        @AV_CODEC_ID_MPEG2VIDEO = 2,
        @AV_CODEC_ID_MPEG2VIDEO_XVMC = 3,
        @AV_CODEC_ID_H261 = 4,
        @AV_CODEC_ID_H263 = 5,
        @AV_CODEC_ID_RV10 = 6,
        @AV_CODEC_ID_RV20 = 7,
        @AV_CODEC_ID_MJPEG = 8,
        @AV_CODEC_ID_MJPEGB = 9,
        @AV_CODEC_ID_LJPEG = 10,
        @AV_CODEC_ID_SP5X = 11,
        @AV_CODEC_ID_JPEGLS = 12,
        @AV_CODEC_ID_MPEG4 = 13,
        @AV_CODEC_ID_RAWVIDEO = 14,
        @AV_CODEC_ID_MSMPEG4V1 = 15,
        @AV_CODEC_ID_MSMPEG4V2 = 16,
        @AV_CODEC_ID_MSMPEG4V3 = 17,
        @AV_CODEC_ID_WMV1 = 18,
        @AV_CODEC_ID_WMV2 = 19,
        @AV_CODEC_ID_H263P = 20,
        @AV_CODEC_ID_H263I = 21,
        @AV_CODEC_ID_FLV1 = 22,
        @AV_CODEC_ID_SVQ1 = 23,
        @AV_CODEC_ID_SVQ3 = 24,
        @AV_CODEC_ID_DVVIDEO = 25,
        @AV_CODEC_ID_HUFFYUV = 26,
        @AV_CODEC_ID_CYUV = 27,
        @AV_CODEC_ID_H264 = 28,
        @AV_CODEC_ID_INDEO3 = 29,
        @AV_CODEC_ID_VP3 = 30,
        @AV_CODEC_ID_THEORA = 31,
        @AV_CODEC_ID_ASV1 = 32,
        @AV_CODEC_ID_ASV2 = 33,
        @AV_CODEC_ID_FFV1 = 34,
        @AV_CODEC_ID_4XM = 35,
        @AV_CODEC_ID_VCR1 = 36,
        @AV_CODEC_ID_CLJR = 37,
        @AV_CODEC_ID_MDEC = 38,
        @AV_CODEC_ID_ROQ = 39,
        @AV_CODEC_ID_INTERPLAY_VIDEO = 40,
        @AV_CODEC_ID_XAN_WC3 = 41,
        @AV_CODEC_ID_XAN_WC4 = 42,
        @AV_CODEC_ID_RPZA = 43,
        @AV_CODEC_ID_CINEPAK = 44,
        @AV_CODEC_ID_WS_VQA = 45,
        @AV_CODEC_ID_MSRLE = 46,
        @AV_CODEC_ID_MSVIDEO1 = 47,
        @AV_CODEC_ID_IDCIN = 48,
        @AV_CODEC_ID_8BPS = 49,
        @AV_CODEC_ID_SMC = 50,
        @AV_CODEC_ID_FLIC = 51,
        @AV_CODEC_ID_TRUEMOTION1 = 52,
        @AV_CODEC_ID_VMDVIDEO = 53,
        @AV_CODEC_ID_MSZH = 54,
        @AV_CODEC_ID_ZLIB = 55,
        @AV_CODEC_ID_QTRLE = 56,
        @AV_CODEC_ID_TSCC = 57,
        @AV_CODEC_ID_ULTI = 58,
        @AV_CODEC_ID_QDRAW = 59,
        @AV_CODEC_ID_VIXL = 60,
        @AV_CODEC_ID_QPEG = 61,
        @AV_CODEC_ID_PNG = 62,
        @AV_CODEC_ID_PPM = 63,
        @AV_CODEC_ID_PBM = 64,
        @AV_CODEC_ID_PGM = 65,
        @AV_CODEC_ID_PGMYUV = 66,
        @AV_CODEC_ID_PAM = 67,
        @AV_CODEC_ID_FFVHUFF = 68,
        @AV_CODEC_ID_RV30 = 69,
        @AV_CODEC_ID_RV40 = 70,
        @AV_CODEC_ID_VC1 = 71,
        @AV_CODEC_ID_WMV3 = 72,
        @AV_CODEC_ID_LOCO = 73,
        @AV_CODEC_ID_WNV1 = 74,
        @AV_CODEC_ID_AASC = 75,
        @AV_CODEC_ID_INDEO2 = 76,
        @AV_CODEC_ID_FRAPS = 77,
        @AV_CODEC_ID_TRUEMOTION2 = 78,
        @AV_CODEC_ID_BMP = 79,
        @AV_CODEC_ID_CSCD = 80,
        @AV_CODEC_ID_MMVIDEO = 81,
        @AV_CODEC_ID_ZMBV = 82,
        @AV_CODEC_ID_AVS = 83,
        @AV_CODEC_ID_SMACKVIDEO = 84,
        @AV_CODEC_ID_NUV = 85,
        @AV_CODEC_ID_KMVC = 86,
        @AV_CODEC_ID_FLASHSV = 87,
        @AV_CODEC_ID_CAVS = 88,
        @AV_CODEC_ID_JPEG2000 = 89,
        @AV_CODEC_ID_VMNC = 90,
        @AV_CODEC_ID_VP5 = 91,
        @AV_CODEC_ID_VP6 = 92,
        @AV_CODEC_ID_VP6F = 93,
        @AV_CODEC_ID_TARGA = 94,
        @AV_CODEC_ID_DSICINVIDEO = 95,
        @AV_CODEC_ID_TIERTEXSEQVIDEO = 96,
        @AV_CODEC_ID_TIFF = 97,
        @AV_CODEC_ID_GIF = 98,
        @AV_CODEC_ID_DXA = 99,
        @AV_CODEC_ID_DNXHD = 100,
        @AV_CODEC_ID_THP = 101,
        @AV_CODEC_ID_SGI = 102,
        @AV_CODEC_ID_C93 = 103,
        @AV_CODEC_ID_BETHSOFTVID = 104,
        @AV_CODEC_ID_PTX = 105,
        @AV_CODEC_ID_TXD = 106,
        @AV_CODEC_ID_VP6A = 107,
        @AV_CODEC_ID_AMV = 108,
        @AV_CODEC_ID_VB = 109,
        @AV_CODEC_ID_PCX = 110,
        @AV_CODEC_ID_SUNRAST = 111,
        @AV_CODEC_ID_INDEO4 = 112,
        @AV_CODEC_ID_INDEO5 = 113,
        @AV_CODEC_ID_MIMIC = 114,
        @AV_CODEC_ID_RL2 = 115,
        @AV_CODEC_ID_ESCAPE124 = 116,
        @AV_CODEC_ID_DIRAC = 117,
        @AV_CODEC_ID_BFI = 118,
        @AV_CODEC_ID_CMV = 119,
        @AV_CODEC_ID_MOTIONPIXELS = 120,
        @AV_CODEC_ID_TGV = 121,
        @AV_CODEC_ID_TGQ = 122,
        @AV_CODEC_ID_TQI = 123,
        @AV_CODEC_ID_AURA = 124,
        @AV_CODEC_ID_AURA2 = 125,
        @AV_CODEC_ID_V210X = 126,
        @AV_CODEC_ID_TMV = 127,
        @AV_CODEC_ID_V210 = 128,
        @AV_CODEC_ID_DPX = 129,
        @AV_CODEC_ID_MAD = 130,
        @AV_CODEC_ID_FRWU = 131,
        @AV_CODEC_ID_FLASHSV2 = 132,
        @AV_CODEC_ID_CDGRAPHICS = 133,
        @AV_CODEC_ID_R210 = 134,
        @AV_CODEC_ID_ANM = 135,
        @AV_CODEC_ID_BINKVIDEO = 136,
        @AV_CODEC_ID_IFF_ILBM = 137,
        @AV_CODEC_ID_KGV1 = 138,
        @AV_CODEC_ID_YOP = 139,
        @AV_CODEC_ID_VP8 = 140,
        @AV_CODEC_ID_PICTOR = 141,
        @AV_CODEC_ID_ANSI = 142,
        @AV_CODEC_ID_A64_MULTI = 143,
        @AV_CODEC_ID_A64_MULTI5 = 144,
        @AV_CODEC_ID_R10K = 145,
        @AV_CODEC_ID_MXPEG = 146,
        @AV_CODEC_ID_LAGARITH = 147,
        @AV_CODEC_ID_PRORES = 148,
        @AV_CODEC_ID_JV = 149,
        @AV_CODEC_ID_DFA = 150,
        @AV_CODEC_ID_WMV3IMAGE = 151,
        @AV_CODEC_ID_VC1IMAGE = 152,
        @AV_CODEC_ID_UTVIDEO = 153,
        @AV_CODEC_ID_BMV_VIDEO = 154,
        @AV_CODEC_ID_VBLE = 155,
        @AV_CODEC_ID_DXTORY = 156,
        @AV_CODEC_ID_V410 = 157,
        @AV_CODEC_ID_XWD = 158,
        @AV_CODEC_ID_CDXL = 159,
        @AV_CODEC_ID_XBM = 160,
        @AV_CODEC_ID_ZEROCODEC = 161,
        @AV_CODEC_ID_MSS1 = 162,
        @AV_CODEC_ID_MSA1 = 163,
        @AV_CODEC_ID_TSCC2 = 164,
        @AV_CODEC_ID_MTS2 = 165,
        @AV_CODEC_ID_CLLC = 166,
        @AV_CODEC_ID_MSS2 = 167,
        @AV_CODEC_ID_VP9 = 168,
        @AV_CODEC_ID_AIC = 169,
        @AV_CODEC_ID_ESCAPE130 = 170,
        @AV_CODEC_ID_G2M = 171,
        @AV_CODEC_ID_WEBP = 172,
        @AV_CODEC_ID_HNM4_VIDEO = 173,
        @AV_CODEC_ID_HEVC = 174,
        @AV_CODEC_ID_FIC = 175,
        @AV_CODEC_ID_ALIAS_PIX = 176,
        @AV_CODEC_ID_BRENDER_PIX = 177,
        @AV_CODEC_ID_PAF_VIDEO = 178,
        @AV_CODEC_ID_EXR = 179,
        @AV_CODEC_ID_VP7 = 180,
        @AV_CODEC_ID_SANM = 181,
        @AV_CODEC_ID_SGIRLE = 182,
        @AV_CODEC_ID_MVC1 = 183,
        @AV_CODEC_ID_MVC2 = 184,
        @AV_CODEC_ID_HQX = 185,
        @AV_CODEC_ID_TDSC = 186,
        @AV_CODEC_ID_HQ_HQA = 187,
        @AV_CODEC_ID_HAP = 188,
        @AV_CODEC_ID_DDS = 189,
        @AV_CODEC_ID_DXV = 190,
        @AV_CODEC_ID_SCREENPRESSO = 191,
        @AV_CODEC_ID_RSCC = 192,
        @AV_CODEC_ID_Y41P = 32768,
        @AV_CODEC_ID_AVRP = 32769,
        @AV_CODEC_ID_012V = 32770,
        @AV_CODEC_ID_AVUI = 32771,
        @AV_CODEC_ID_AYUV = 32772,
        @AV_CODEC_ID_TARGA_Y216 = 32773,
        @AV_CODEC_ID_V308 = 32774,
        @AV_CODEC_ID_V408 = 32775,
        @AV_CODEC_ID_YUV4 = 32776,
        @AV_CODEC_ID_AVRN = 32777,
        @AV_CODEC_ID_CPIA = 32778,
        @AV_CODEC_ID_XFACE = 32779,
        @AV_CODEC_ID_SNOW = 32780,
        @AV_CODEC_ID_SMVJPEG = 32781,
        @AV_CODEC_ID_APNG = 32782,
        @AV_CODEC_ID_DAALA = 32783,
        @AV_CODEC_ID_CFHD = 32784,
        @AV_CODEC_ID_TRUEMOTION2RT = 32785,
        @AV_CODEC_ID_M101 = 32786,
        @AV_CODEC_ID_MAGICYUV = 32787,
        @AV_CODEC_ID_SHEERVIDEO = 32788,
        @AV_CODEC_ID_YLC = 32789,
        /// <summary>A dummy id pointing at the start of audio codecs</summary>
        @AV_CODEC_ID_FIRST_AUDIO = 65536,
        @AV_CODEC_ID_PCM_S16LE = 65536,
        @AV_CODEC_ID_PCM_S16BE = 65537,
        @AV_CODEC_ID_PCM_U16LE = 65538,
        @AV_CODEC_ID_PCM_U16BE = 65539,
        @AV_CODEC_ID_PCM_S8 = 65540,
        @AV_CODEC_ID_PCM_U8 = 65541,
        @AV_CODEC_ID_PCM_MULAW = 65542,
        @AV_CODEC_ID_PCM_ALAW = 65543,
        @AV_CODEC_ID_PCM_S32LE = 65544,
        @AV_CODEC_ID_PCM_S32BE = 65545,
        @AV_CODEC_ID_PCM_U32LE = 65546,
        @AV_CODEC_ID_PCM_U32BE = 65547,
        @AV_CODEC_ID_PCM_S24LE = 65548,
        @AV_CODEC_ID_PCM_S24BE = 65549,
        @AV_CODEC_ID_PCM_U24LE = 65550,
        @AV_CODEC_ID_PCM_U24BE = 65551,
        @AV_CODEC_ID_PCM_S24DAUD = 65552,
        @AV_CODEC_ID_PCM_ZORK = 65553,
        @AV_CODEC_ID_PCM_S16LE_PLANAR = 65554,
        @AV_CODEC_ID_PCM_DVD = 65555,
        @AV_CODEC_ID_PCM_F32BE = 65556,
        @AV_CODEC_ID_PCM_F32LE = 65557,
        @AV_CODEC_ID_PCM_F64BE = 65558,
        @AV_CODEC_ID_PCM_F64LE = 65559,
        @AV_CODEC_ID_PCM_BLURAY = 65560,
        @AV_CODEC_ID_PCM_LXF = 65561,
        @AV_CODEC_ID_S302M = 65562,
        @AV_CODEC_ID_PCM_S8_PLANAR = 65563,
        @AV_CODEC_ID_PCM_S24LE_PLANAR = 65564,
        @AV_CODEC_ID_PCM_S32LE_PLANAR = 65565,
        @AV_CODEC_ID_PCM_S16BE_PLANAR = 65566,
        @AV_CODEC_ID_PCM_S64LE = 67584,
        @AV_CODEC_ID_PCM_S64BE = 67585,
        @AV_CODEC_ID_ADPCM_IMA_QT = 69632,
        @AV_CODEC_ID_ADPCM_IMA_WAV = 69633,
        @AV_CODEC_ID_ADPCM_IMA_DK3 = 69634,
        @AV_CODEC_ID_ADPCM_IMA_DK4 = 69635,
        @AV_CODEC_ID_ADPCM_IMA_WS = 69636,
        @AV_CODEC_ID_ADPCM_IMA_SMJPEG = 69637,
        @AV_CODEC_ID_ADPCM_MS = 69638,
        @AV_CODEC_ID_ADPCM_4XM = 69639,
        @AV_CODEC_ID_ADPCM_XA = 69640,
        @AV_CODEC_ID_ADPCM_ADX = 69641,
        @AV_CODEC_ID_ADPCM_EA = 69642,
        @AV_CODEC_ID_ADPCM_G726 = 69643,
        @AV_CODEC_ID_ADPCM_CT = 69644,
        @AV_CODEC_ID_ADPCM_SWF = 69645,
        @AV_CODEC_ID_ADPCM_YAMAHA = 69646,
        @AV_CODEC_ID_ADPCM_SBPRO_4 = 69647,
        @AV_CODEC_ID_ADPCM_SBPRO_3 = 69648,
        @AV_CODEC_ID_ADPCM_SBPRO_2 = 69649,
        @AV_CODEC_ID_ADPCM_THP = 69650,
        @AV_CODEC_ID_ADPCM_IMA_AMV = 69651,
        @AV_CODEC_ID_ADPCM_EA_R1 = 69652,
        @AV_CODEC_ID_ADPCM_EA_R3 = 69653,
        @AV_CODEC_ID_ADPCM_EA_R2 = 69654,
        @AV_CODEC_ID_ADPCM_IMA_EA_SEAD = 69655,
        @AV_CODEC_ID_ADPCM_IMA_EA_EACS = 69656,
        @AV_CODEC_ID_ADPCM_EA_XAS = 69657,
        @AV_CODEC_ID_ADPCM_EA_MAXIS_XA = 69658,
        @AV_CODEC_ID_ADPCM_IMA_ISS = 69659,
        @AV_CODEC_ID_ADPCM_G722 = 69660,
        @AV_CODEC_ID_ADPCM_IMA_APC = 69661,
        @AV_CODEC_ID_ADPCM_VIMA = 69662,
        @AV_CODEC_ID_VIMA = 69662,
        @AV_CODEC_ID_ADPCM_AFC = 71680,
        @AV_CODEC_ID_ADPCM_IMA_OKI = 71681,
        @AV_CODEC_ID_ADPCM_DTK = 71682,
        @AV_CODEC_ID_ADPCM_IMA_RAD = 71683,
        @AV_CODEC_ID_ADPCM_G726LE = 71684,
        @AV_CODEC_ID_ADPCM_THP_LE = 71685,
        @AV_CODEC_ID_ADPCM_PSX = 71686,
        @AV_CODEC_ID_ADPCM_AICA = 71687,
        @AV_CODEC_ID_ADPCM_IMA_DAT4 = 71688,
        @AV_CODEC_ID_ADPCM_MTAF = 71689,
        @AV_CODEC_ID_AMR_NB = 73728,
        @AV_CODEC_ID_AMR_WB = 73729,
        @AV_CODEC_ID_RA_144 = 77824,
        @AV_CODEC_ID_RA_288 = 77825,
        @AV_CODEC_ID_ROQ_DPCM = 81920,
        @AV_CODEC_ID_INTERPLAY_DPCM = 81921,
        @AV_CODEC_ID_XAN_DPCM = 81922,
        @AV_CODEC_ID_SOL_DPCM = 81923,
        @AV_CODEC_ID_SDX2_DPCM = 83968,
        @AV_CODEC_ID_MP2 = 86016,
        /// <summary>preferred ID for decoding MPEG audio layer 1, 2 or 3</summary>
        @AV_CODEC_ID_MP3 = 86017,
        @AV_CODEC_ID_AAC = 86018,
        @AV_CODEC_ID_AC3 = 86019,
        @AV_CODEC_ID_DTS = 86020,
        @AV_CODEC_ID_VORBIS = 86021,
        @AV_CODEC_ID_DVAUDIO = 86022,
        @AV_CODEC_ID_WMAV1 = 86023,
        @AV_CODEC_ID_WMAV2 = 86024,
        @AV_CODEC_ID_MACE3 = 86025,
        @AV_CODEC_ID_MACE6 = 86026,
        @AV_CODEC_ID_VMDAUDIO = 86027,
        @AV_CODEC_ID_FLAC = 86028,
        @AV_CODEC_ID_MP3ADU = 86029,
        @AV_CODEC_ID_MP3ON4 = 86030,
        @AV_CODEC_ID_SHORTEN = 86031,
        @AV_CODEC_ID_ALAC = 86032,
        @AV_CODEC_ID_WESTWOOD_SND1 = 86033,
        /// <summary>as in Berlin toast format</summary>
        @AV_CODEC_ID_GSM = 86034,
        @AV_CODEC_ID_QDM2 = 86035,
        @AV_CODEC_ID_COOK = 86036,
        @AV_CODEC_ID_TRUESPEECH = 86037,
        @AV_CODEC_ID_TTA = 86038,
        @AV_CODEC_ID_SMACKAUDIO = 86039,
        @AV_CODEC_ID_QCELP = 86040,
        @AV_CODEC_ID_WAVPACK = 86041,
        @AV_CODEC_ID_DSICINAUDIO = 86042,
        @AV_CODEC_ID_IMC = 86043,
        @AV_CODEC_ID_MUSEPACK7 = 86044,
        @AV_CODEC_ID_MLP = 86045,
        @AV_CODEC_ID_GSM_MS = 86046,
        @AV_CODEC_ID_ATRAC3 = 86047,
        @AV_CODEC_ID_VOXWARE = 86048,
        @AV_CODEC_ID_APE = 86049,
        @AV_CODEC_ID_NELLYMOSER = 86050,
        @AV_CODEC_ID_MUSEPACK8 = 86051,
        @AV_CODEC_ID_SPEEX = 86052,
        @AV_CODEC_ID_WMAVOICE = 86053,
        @AV_CODEC_ID_WMAPRO = 86054,
        @AV_CODEC_ID_WMALOSSLESS = 86055,
        @AV_CODEC_ID_ATRAC3P = 86056,
        @AV_CODEC_ID_EAC3 = 86057,
        @AV_CODEC_ID_SIPR = 86058,
        @AV_CODEC_ID_MP1 = 86059,
        @AV_CODEC_ID_TWINVQ = 86060,
        @AV_CODEC_ID_TRUEHD = 86061,
        @AV_CODEC_ID_MP4ALS = 86062,
        @AV_CODEC_ID_ATRAC1 = 86063,
        @AV_CODEC_ID_BINKAUDIO_RDFT = 86064,
        @AV_CODEC_ID_BINKAUDIO_DCT = 86065,
        @AV_CODEC_ID_AAC_LATM = 86066,
        @AV_CODEC_ID_QDMC = 86067,
        @AV_CODEC_ID_CELT = 86068,
        @AV_CODEC_ID_G723_1 = 86069,
        @AV_CODEC_ID_G729 = 86070,
        @AV_CODEC_ID_8SVX_EXP = 86071,
        @AV_CODEC_ID_8SVX_FIB = 86072,
        @AV_CODEC_ID_BMV_AUDIO = 86073,
        @AV_CODEC_ID_RALF = 86074,
        @AV_CODEC_ID_IAC = 86075,
        @AV_CODEC_ID_ILBC = 86076,
        @AV_CODEC_ID_OPUS = 86077,
        @AV_CODEC_ID_COMFORT_NOISE = 86078,
        @AV_CODEC_ID_TAK = 86079,
        @AV_CODEC_ID_METASOUND = 86080,
        @AV_CODEC_ID_PAF_AUDIO = 86081,
        @AV_CODEC_ID_ON2AVC = 86082,
        @AV_CODEC_ID_DSS_SP = 86083,
        @AV_CODEC_ID_FFWAVESYNTH = 88064,
        @AV_CODEC_ID_SONIC = 88065,
        @AV_CODEC_ID_SONIC_LS = 88066,
        @AV_CODEC_ID_EVRC = 88067,
        @AV_CODEC_ID_SMV = 88068,
        @AV_CODEC_ID_DSD_LSBF = 88069,
        @AV_CODEC_ID_DSD_MSBF = 88070,
        @AV_CODEC_ID_DSD_LSBF_PLANAR = 88071,
        @AV_CODEC_ID_DSD_MSBF_PLANAR = 88072,
        @AV_CODEC_ID_4GV = 88073,
        @AV_CODEC_ID_INTERPLAY_ACM = 88074,
        @AV_CODEC_ID_XMA1 = 88075,
        @AV_CODEC_ID_XMA2 = 88076,
        @AV_CODEC_ID_DST = 88077,
        /// <summary>A dummy ID pointing at the start of subtitle codecs.</summary>
        @AV_CODEC_ID_FIRST_SUBTITLE = 94208,
        @AV_CODEC_ID_DVD_SUBTITLE = 94208,
        @AV_CODEC_ID_DVB_SUBTITLE = 94209,
        /// <summary>raw UTF-8 text</summary>
        @AV_CODEC_ID_TEXT = 94210,
        @AV_CODEC_ID_XSUB = 94211,
        @AV_CODEC_ID_SSA = 94212,
        @AV_CODEC_ID_MOV_TEXT = 94213,
        @AV_CODEC_ID_HDMV_PGS_SUBTITLE = 94214,
        @AV_CODEC_ID_DVB_TELETEXT = 94215,
        @AV_CODEC_ID_SRT = 94216,
        @AV_CODEC_ID_MICRODVD = 96256,
        @AV_CODEC_ID_EIA_608 = 96257,
        @AV_CODEC_ID_JACOSUB = 96258,
        @AV_CODEC_ID_SAMI = 96259,
        @AV_CODEC_ID_REALTEXT = 96260,
        @AV_CODEC_ID_STL = 96261,
        @AV_CODEC_ID_SUBVIEWER1 = 96262,
        @AV_CODEC_ID_SUBVIEWER = 96263,
        @AV_CODEC_ID_SUBRIP = 96264,
        @AV_CODEC_ID_WEBVTT = 96265,
        @AV_CODEC_ID_MPL2 = 96266,
        @AV_CODEC_ID_VPLAYER = 96267,
        @AV_CODEC_ID_PJS = 96268,
        @AV_CODEC_ID_ASS = 96269,
        @AV_CODEC_ID_HDMV_TEXT_SUBTITLE = 96270,
        /// <summary>A dummy ID pointing at the start of various fake codecs.</summary>
        @AV_CODEC_ID_FIRST_UNKNOWN = 98304,
        @AV_CODEC_ID_TTF = 98304,
        /// <summary>Contain timestamp estimated through PCR of program stream.</summary>
        @AV_CODEC_ID_SCTE_35 = 98305,
        @AV_CODEC_ID_BINTEXT = 100352,
        @AV_CODEC_ID_XBIN = 100353,
        @AV_CODEC_ID_IDF = 100354,
        @AV_CODEC_ID_OTF = 100355,
        @AV_CODEC_ID_SMPTE_KLV = 100356,
        @AV_CODEC_ID_DVD_NAV = 100357,
        @AV_CODEC_ID_TIMED_ID3 = 100358,
        @AV_CODEC_ID_BIN_DATA = 100359,
        /// <summary>codec_id is not known (like AV_CODEC_ID_NONE) but lavf should attempt to identify it</summary>
        @AV_CODEC_ID_PROBE = 102400,
        /// <summary>_FAKE_ codec to indicate a raw MPEG-2 TS stream (only used by libavformat)</summary>
        @AV_CODEC_ID_MPEG2TS = 131072,
        /// <summary>_FAKE_ codec to indicate a MPEG-4 Systems stream (only used by libavformat)</summary>
        @AV_CODEC_ID_MPEG4SYSTEMS = 131073,
        /// <summary>Dummy codec for streams containing only metadata information.</summary>
        @AV_CODEC_ID_FFMETADATA = 135168,
        /// <summary>Passthrough codec, AVFrames wrapped in AVPacket</summary>
        @AV_CODEC_ID_WRAPPED_AVFRAME = 135169,
    }
    
    public enum Motion_Est_ID : int
    {
        /// <summary>no search, that is use 0,0 vector whenever one is needed</summary>
        @ME_ZERO = 1,
        @ME_FULL = 2,
        @ME_LOG = 3,
        @ME_PHODS = 4,
        /// <summary>enhanced predictive zonal search</summary>
        @ME_EPZS = 5,
        /// <summary>reserved for experiments</summary>
        @ME_X1 = 6,
        /// <summary>hexagon based search</summary>
        @ME_HEX = 7,
        /// <summary>uneven multi-hexagon search</summary>
        @ME_UMH = 8,
        /// <summary>transformed exhaustive search algorithm</summary>
        @ME_TESA = 9,
        /// <summary>iterative search</summary>
        @ME_ITER = 50,
    }
    
    public enum AVDiscard : int
    {
        /// <summary>discard nothing</summary>
        @AVDISCARD_NONE = -16,
        /// <summary>discard useless packets like 0 size packets in avi</summary>
        @AVDISCARD_DEFAULT = 0,
        /// <summary>discard all non reference</summary>
        @AVDISCARD_NONREF = 8,
        /// <summary>discard all bidirectional frames</summary>
        @AVDISCARD_BIDIR = 16,
        /// <summary>discard all non intra frames</summary>
        @AVDISCARD_NONINTRA = 24,
        /// <summary>discard all frames except keyframes</summary>
        @AVDISCARD_NONKEY = 32,
        /// <summary>discard all</summary>
        @AVDISCARD_ALL = 48,
    }
    
    public enum AVAudioServiceType : int
    {
        @AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        @AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        @AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        @AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        @AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        @AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        @AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        @AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        @AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        /// <summary>Not part of ABI</summary>
        @AV_AUDIO_SERVICE_TYPE_NB = 9,
    }
    
    /// <summary>Types and functions for working with AVPacket. @{</summary>
    public enum AVPacketSideDataType : int
    {
        @AV_PKT_DATA_PALETTE = 0,
        /// <summary>The AV_PKT_DATA_NEW_EXTRADATA is used to notify the codec or the format that the extradata buffer was changed and the receiving side should act upon it appropriately. The new extradata is embedded in the side data buffer and should be immediately used for processing the current frame or packet.</summary>
        @AV_PKT_DATA_NEW_EXTRADATA = 1,
        /// <summary>An AV_PKT_DATA_PARAM_CHANGE side data packet is laid out as follows:</summary>
        @AV_PKT_DATA_PARAM_CHANGE = 2,
        /// <summary>An AV_PKT_DATA_H263_MB_INFO side data packet contains a number of structures with info about macroblocks relevant to splitting the packet into smaller packets on macroblock edges (e.g. as for RFC 2190). That is, it does not necessarily contain info about all macroblocks, as long as the distance between macroblocks in the info is smaller than the target payload size. Each MB info structure is 12 bytes, and is laid out as follows:</summary>
        @AV_PKT_DATA_H263_MB_INFO = 3,
        /// <summary>This side data should be associated with an audio stream and contains ReplayGain information in form of the AVReplayGain struct.</summary>
        @AV_PKT_DATA_REPLAYGAIN = 4,
        /// <summary>This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the decoded video frames for correct presentation.</summary>
        @AV_PKT_DATA_DISPLAYMATRIX = 5,
        /// <summary>This side data should be associated with a video stream and contains Stereoscopic 3D information in form of the AVStereo3D struct.</summary>
        @AV_PKT_DATA_STEREO3D = 6,
        /// <summary>This side data should be associated with an audio stream and corresponds to enum AVAudioServiceType.</summary>
        @AV_PKT_DATA_AUDIO_SERVICE_TYPE = 7,
        /// <summary>This side data contains quality related information from the encoder.</summary>
        @AV_PKT_DATA_QUALITY_STATS = 8,
        /// <summary>This side data contains an integer value representing the stream index of a "fallback" track. A fallback track indicates an alternate track to use when the current track can not be decoded for some reason. e.g. no decoder available for codec.</summary>
        @AV_PKT_DATA_FALLBACK_TRACK = 9,
        /// <summary>This side data corresponds to the AVCPBProperties struct.</summary>
        @AV_PKT_DATA_CPB_PROPERTIES = 10,
        /// <summary>Recommmends skipping the specified number of samples</summary>
        @AV_PKT_DATA_SKIP_SAMPLES = 70,
        /// <summary>An AV_PKT_DATA_JP_DUALMONO side data packet indicates that the packet may contain "dual mono" audio specific to Japanese DTV and if it is true, recommends only the selected channel to be used.</summary>
        @AV_PKT_DATA_JP_DUALMONO = 71,
        /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop.</summary>
        @AV_PKT_DATA_STRINGS_METADATA = 72,
        /// <summary>Subtitle event position</summary>
        @AV_PKT_DATA_SUBTITLE_POSITION = 73,
        /// <summary>Data found in BlockAdditional element of matroska container. There is no end marker for the data, so it is required to rely on the side data size to recognize the end. 8 byte id (as found in BlockAddId) followed by data.</summary>
        @AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL = 74,
        /// <summary>The optional first identifier line of a WebVTT cue.</summary>
        @AV_PKT_DATA_WEBVTT_IDENTIFIER = 75,
        /// <summary>The optional settings (rendering instructions) that immediately follow the timestamp specifier of a WebVTT cue.</summary>
        @AV_PKT_DATA_WEBVTT_SETTINGS = 76,
        /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop. This side data includes updated metadata which appeared in the stream.</summary>
        @AV_PKT_DATA_METADATA_UPDATE = 77,
        /// <summary>MPEGTS stream ID, this is required to pass the stream ID information from the demuxer to the corresponding muxer.</summary>
        @AV_PKT_DATA_MPEGTS_STREAM_ID = 78,
        /// <summary>Mastering display metadata (based on SMPTE-2086:2014). This metadata should be associated with a video stream and containts data in the form of the AVMasteringDisplayMetadata struct.</summary>
        @AV_PKT_DATA_MASTERING_DISPLAY_METADATA = 79,
    }
    
    public enum AVSideDataParamChangeFlags : int
    {
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 1,
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 2,
        @AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 4,
        @AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 8,
    }
    
    public enum AVFieldOrder : int
    {
        @AV_FIELD_UNKNOWN = 0,
        @AV_FIELD_PROGRESSIVE = 1,
        @AV_FIELD_TT = 2,
        @AV_FIELD_BB = 3,
        @AV_FIELD_TB = 4,
        @AV_FIELD_BT = 5,
    }
    
    public enum AVSubtitleType : int
    {
        @SUBTITLE_NONE = 0,
        /// <summary>A bitmap, pict will be set</summary>
        @SUBTITLE_BITMAP = 1,
        /// <summary>Plain text, the text field must be set by the decoder and is authoritative. ass and pict fields may contain approximations.</summary>
        @SUBTITLE_TEXT = 2,
        /// <summary>Formatted text, the ass field must be set by the decoder and is authoritative. pict and text fields may contain approximations.</summary>
        @SUBTITLE_ASS = 3,
    }
    
    /// <summary>@{</summary>
    public enum AVPictureStructure : int
    {
        @AV_PICTURE_STRUCTURE_UNKNOWN = 0,
        @AV_PICTURE_STRUCTURE_TOP_FIELD = 1,
        @AV_PICTURE_STRUCTURE_BOTTOM_FIELD = 2,
        @AV_PICTURE_STRUCTURE_FRAME = 3,
    }
    
    /// <summary>Lock operation used by lockmgr</summary>
    public enum AVLockOp : int
    {
        /// <summary>Create a mutex</summary>
        @AV_LOCK_CREATE = 0,
        /// <summary>Lock the mutex</summary>
        @AV_LOCK_OBTAIN = 1,
        /// <summary>Unlock the mutex</summary>
        @AV_LOCK_RELEASE = 2,
        /// <summary>Free mutex resources</summary>
        @AV_LOCK_DESTROY = 3,
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
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize0;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize1;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize2;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize3;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize4;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize5;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize6;
        /// <summary>For video, size in bytes of each picture line. For audio, size in bytes of each plane.</summary>
        public int @linesize7;
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
        public ulong @error0;
        public ulong @error1;
        public ulong @error2;
        public ulong @error3;
        public ulong @error4;
        public ulong @error5;
        public ulong @error6;
        public ulong @error7;
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
    
    public unsafe struct SwrContext
    {
    }
    
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
    
    /// <summary>This struct describes the properties of a single codec described by an AVCodecID.</summary>
    public unsafe struct AVCodecDescriptor
    {
        public AVCodecID @id;
        public AVMediaType @type;
        /// <summary>Name of the codec described by this descriptor. It is non-empty and unique for each codec descriptor. It should contain alphanumeric characters and '_' only.</summary>
        public byte* @name;
        /// <summary>A more descriptive name for this codec. May be NULL.</summary>
        public byte* @long_name;
        /// <summary>Codec properties, a combination of AV_CODEC_PROP_* flags.</summary>
        public int @props;
        /// <summary>MIME type(s) associated with the codec. May be NULL; if not, a NULL-terminated array of MIME types. The first item is always non-NULL and is the preferred MIME type.</summary>
        public byte** @mime_types;
        /// <summary>If non-NULL, an array of profiles recognized for this codec. Terminated with FF_PROFILE_UNKNOWN.</summary>
        public IntPtr @profiles;
    }
    
    public unsafe struct RcOverride
    {
        public int @start_frame;
        public int @end_frame;
        public int @qscale;
        public float @quality_factor;
    }
    
    /// <summary>Pan Scan area. This specifies the area which should be displayed. Note there may be multiple such areas for one frame.</summary>
    public unsafe struct AVPanScan
    {
        /// <summary>id - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int @id;
        /// <summary>width and height in 1/16 pel - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int @width;
        public int @height;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position0;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position1;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position2;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position3;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position4;
        /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public short[] @position5;
    }
    
    /// <summary>This structure describes the bitrate properties of an encoded bitstream. It roughly corresponds to a subset the VBV parameters for MPEG-2 or HRD parameters for H.264/HEVC.</summary>
    public unsafe struct AVCPBProperties
    {
        /// <summary>Maximum bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
        public int @max_bitrate;
        /// <summary>Minimum bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
        public int @min_bitrate;
        /// <summary>Average bitrate of the stream, in bits per second. Zero if unknown or unspecified.</summary>
        public int @avg_bitrate;
        /// <summary>The size of the buffer to which the ratecontrol is applied, in bits. Zero if unknown or unspecified.</summary>
        public int @buffer_size;
        /// <summary>The delay between the time the packet this structure is associated with is received and the time when it should be decoded, in periods of a 27MHz clock.</summary>
        public ulong @vbv_delay;
    }
    
    public unsafe struct AVPacketSideData
    {
        public byte* @data;
        public int @size;
        public AVPacketSideDataType @type;
    }
    
    /// <summary>This structure stores compressed data. It is typically exported by demuxers and then passed as input to decoders, or received as output from encoders and then passed to muxers.</summary>
    public unsafe struct AVPacket
    {
        /// <summary>A reference to the reference-counted buffer where the packet data is stored. May be NULL, then the packet data is not reference-counted.</summary>
        public AVBufferRef* @buf;
        /// <summary>Presentation timestamp in AVStream->time_base units; the time at which the decompressed packet will be presented to the user. Can be AV_NOPTS_VALUE if it is not stored in the file. pts MUST be larger or equal to dts as presentation cannot happen before decompression, unless one wants to view hex dumps. Some formats misuse the terms dts and pts/cts to mean something different. Such timestamps must be converted to true pts/dts before they are stored in AVPacket.</summary>
        public long @pts;
        /// <summary>Decompression timestamp in AVStream->time_base units; the time at which the packet is decompressed. Can be AV_NOPTS_VALUE if it is not stored in the file.</summary>
        public long @dts;
        public byte* @data;
        public int @size;
        public int @stream_index;
        /// <summary>A combination of AV_PKT_FLAG values</summary>
        public int @flags;
        /// <summary>Additional packet data that can be provided by the container. Packet can contain several types of side information.</summary>
        public AVPacketSideData* @side_data;
        public int @side_data_elems;
        /// <summary>Duration of this packet in AVStream->time_base units, 0 if unknown. Equals next_pts - this_pts in presentation order.</summary>
        public long @duration;
        /// <summary>byte position in stream, -1 if unknown</summary>
        public long @pos;
        public long @convergence_duration;
    }
    
    /// <summary>AVProfile.</summary>
    public unsafe struct AVProfile
    {
        public int @profile;
        /// <summary>short name for the profile</summary>
        public byte* @name;
    }
    
    /// <summary>main external API structure. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. Please use AVOptions (av_opt* / av_set/get*()) to access these fields from user applications. The name string for AVOptions options matches the associated command line parameter name and can be found in libavcodec/options_table.h The AVOption/command line parameter names differ in some cases from the C structure field names for historic reasons or brevity. sizeof(AVCodecContext) must not be used outside libav*.</summary>
    public unsafe struct AVCodecContext
    {
        /// <summary>information on struct for av_log - set by avcodec_alloc_context3</summary>
        public AVClass* @av_class;
        public int @log_level_offset;
        public AVMediaType @codec_type;
        public IntPtr @codec;
        public byte @codec_name0;
        public byte @codec_name1;
        public byte @codec_name2;
        public byte @codec_name3;
        public byte @codec_name4;
        public byte @codec_name5;
        public byte @codec_name6;
        public byte @codec_name7;
        public byte @codec_name8;
        public byte @codec_name9;
        public byte @codec_name10;
        public byte @codec_name11;
        public byte @codec_name12;
        public byte @codec_name13;
        public byte @codec_name14;
        public byte @codec_name15;
        public byte @codec_name16;
        public byte @codec_name17;
        public byte @codec_name18;
        public byte @codec_name19;
        public byte @codec_name20;
        public byte @codec_name21;
        public byte @codec_name22;
        public byte @codec_name23;
        public byte @codec_name24;
        public byte @codec_name25;
        public byte @codec_name26;
        public byte @codec_name27;
        public byte @codec_name28;
        public byte @codec_name29;
        public byte @codec_name30;
        public byte @codec_name31;
        public AVCodecID @codec_id;
        /// <summary>fourcc (LSB first, so "ABCD" -> ('D'<<24) + ('C'<<16) + ('B'<<8) + 'A'). This is used to work around some encoder bugs. A demuxer should set this to what is stored in the field used to identify the codec. If there are multiple such fields in a container then the demuxer should choose the one which maximizes the information about the used codec. If the codec tag field in a container is larger than 32 bits then the demuxer should remap the longer ID to 32 bits with a table or other structure. Alternatively a new extra_codec_tag + size could be added but for this a clear advantage must be demonstrated first. - encoding: Set by user, if not then the default based on codec_id will be used. - decoding: Set by user, will be converted to uppercase by libavcodec during init.</summary>
        public uint @codec_tag;
        public uint @stream_codec_tag;
        public void* @priv_data;
        /// <summary>Private context used for internal data.</summary>
        public IntPtr @internal;
        /// <summary>Private data of the user, can be used to carry app specific stuff. - encoding: Set by user. - decoding: Set by user.</summary>
        public void* @opaque;
        /// <summary>the average bitrate - encoding: Set by user; unused for constant quantizer encoding. - decoding: Set by user, may be overwritten by libavcodec if this info is available in the stream</summary>
        public long @bit_rate;
        /// <summary>number of bits the bitstream is allowed to diverge from the reference. the reference can be CBR (for CBR pass1) or VBR (for pass2) - encoding: Set by user; unused for constant quantizer encoding. - decoding: unused</summary>
        public int @bit_rate_tolerance;
        /// <summary>Global quality for codecs which cannot change it per frame. This should be proportional to MPEG-1/2/4 qscale. - encoding: Set by user. - decoding: unused</summary>
        public int @global_quality;
        /// <summary>- encoding: Set by user. - decoding: unused</summary>
        public int @compression_level;
        /// <summary>AV_CODEC_FLAG_*. - encoding: Set by user. - decoding: Set by user.</summary>
        public int @flags;
        /// <summary>AV_CODEC_FLAG2_* - encoding: Set by user. - decoding: Set by user.</summary>
        public int @flags2;
        /// <summary>some codecs need / can use extradata like Huffman tables. MJPEG: Huffman tables rv10: additional flags MPEG-4: global headers (they can be in the bitstream or here) The allocated memory should be AV_INPUT_BUFFER_PADDING_SIZE bytes larger than extradata_size to avoid problems if it is read with the bitstream reader. The bytewise contents of extradata must not depend on the architecture or CPU endianness. - encoding: Set/allocated/freed by libavcodec. - decoding: Set/allocated/freed by user.</summary>
        public byte* @extradata;
        public int @extradata_size;
        /// <summary>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented. For fixed-fps content, timebase should be 1/framerate and timestamp increments should be identically 1. This often, but not always is the inverse of the frame rate or field rate for video. 1/time_base is not the average frame rate if the frame rate is not constant.</summary>
        public AVRational @time_base;
        /// <summary>For some codecs, the time base is closer to the field rate than the frame rate. Most notably, H.264 and MPEG-2 specify time_base as half of frame duration if no telecine is used ...</summary>
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
        /// <summary>the number of pictures in a group of pictures, or 0 for intra_only - encoding: Set by user. - decoding: unused</summary>
        public int @gop_size;
        /// <summary>Pixel format, see AV_PIX_FMT_xxx. May be set by the demuxer if known from headers. May be overridden by the decoder if it knows better.</summary>
        public AVPixelFormat @pix_fmt;
        /// <summary>This option does nothing</summary>
        public int @me_method;
        /// <summary>If non NULL, 'draw_horiz_band' is called by the libavcodec decoder to draw a horizontal band. It improves cache usage. Not all codecs can do that. You must check the codec capabilities beforehand. When multithreading is used, it may be called from multiple threads at the same time; threads might draw different parts of the same AVFrame, or multiple AVFrames, and there is no guarantee that slices will be drawn in order. The function is also used by hardware acceleration APIs. It is called at least once during frame decoding to pass the data needed for hardware render. In that mode instead of pixel data, AVFrame points to a structure specific to the acceleration API. The application reads the structure and can change some fields to indicate progress or mark state. - encoding: unused - decoding: Set by user.</summary>
        public IntPtr @draw_horiz_band;
        /// <summary>callback to negotiate the pixelFormat</summary>
        public IntPtr @get_format;
        /// <summary>maximum number of B-frames between non-B-frames Note: The output will be delayed by max_b_frames+1 relative to the input. - encoding: Set by user. - decoding: unused</summary>
        public int @max_b_frames;
        /// <summary>qscale factor between IP and B-frames If > 0 then the last P-frame quantizer will be used (q= lastp_q*factor+offset). If < 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
        public float @b_quant_factor;
        public int @rc_strategy;
        public int @b_frame_strategy;
        /// <summary>qscale offset between IP and B-frames - encoding: Set by user. - decoding: unused</summary>
        public float @b_quant_offset;
        /// <summary>Size of the frame reordering buffer in the decoder. For MPEG-2 it is 1 IPB or 0 low delay IP. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
        public int @has_b_frames;
        public int @mpeg_quant;
        /// <summary>qscale factor between P- and I-frames If > 0 then the last P-frame quantizer will be used (q = lastp_q * factor + offset). If < 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
        public float @i_quant_factor;
        /// <summary>qscale offset between P and I-frames - encoding: Set by user. - decoding: unused</summary>
        public float @i_quant_offset;
        /// <summary>luminance masking (0-> disabled) - encoding: Set by user. - decoding: unused</summary>
        public float @lumi_masking;
        /// <summary>temporary complexity masking (0-> disabled) - encoding: Set by user. - decoding: unused</summary>
        public float @temporal_cplx_masking;
        /// <summary>spatial complexity masking (0-> disabled) - encoding: Set by user. - decoding: unused</summary>
        public float @spatial_cplx_masking;
        /// <summary>p block masking (0-> disabled) - encoding: Set by user. - decoding: unused</summary>
        public float @p_masking;
        /// <summary>darkness masking (0-> disabled) - encoding: Set by user. - decoding: unused</summary>
        public float @dark_masking;
        /// <summary>slice count - encoding: Set by libavcodec. - decoding: Set by user (or 0).</summary>
        public int @slice_count;
        public int @prediction_method;
        /// <summary>slice offsets in the frame in bytes - encoding: Set/allocated by libavcodec. - decoding: Set/allocated by user (or NULL).</summary>
        public int* @slice_offset;
        /// <summary>sample aspect ratio (0 if unknown) That is the width of a pixel divided by the height of the pixel. Numerator and denominator must be relatively prime and smaller than 256 for some video standards. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public AVRational @sample_aspect_ratio;
        /// <summary>motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
        public int @me_cmp;
        /// <summary>subpixel motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
        public int @me_sub_cmp;
        /// <summary>macroblock comparison function (not supported yet) - encoding: Set by user. - decoding: unused</summary>
        public int @mb_cmp;
        /// <summary>interlaced DCT comparison function - encoding: Set by user. - decoding: unused</summary>
        public int @ildct_cmp;
        /// <summary>ME diamond size & shape - encoding: Set by user. - decoding: unused</summary>
        public int @dia_size;
        /// <summary>amount of previous MV predictors (2a+1 x 2a+1 square) - encoding: Set by user. - decoding: unused</summary>
        public int @last_predictor_count;
        public int @pre_me;
        /// <summary>motion estimation prepass comparison function - encoding: Set by user. - decoding: unused</summary>
        public int @me_pre_cmp;
        /// <summary>ME prepass diamond size & shape - encoding: Set by user. - decoding: unused</summary>
        public int @pre_dia_size;
        /// <summary>subpel ME quality - encoding: Set by user. - decoding: unused</summary>
        public int @me_subpel_quality;
        /// <summary>DTG active format information (additional aspect ratio information only used in DVB MPEG-2 transport streams) 0 if not set.</summary>
        public int @dtg_active_format;
        /// <summary>maximum motion estimation search range in subpel units If 0 then no limit.</summary>
        public int @me_range;
        public int @intra_quant_bias;
        public int @inter_quant_bias;
        /// <summary>slice flags - encoding: unused - decoding: Set by user.</summary>
        public int @slice_flags;
        /// <summary>XVideo Motion Acceleration - encoding: forbidden - decoding: set by decoder</summary>
        public int @xvmc_acceleration;
        /// <summary>macroblock decision mode - encoding: Set by user. - decoding: unused</summary>
        public int @mb_decision;
        /// <summary>custom intra quantization matrix - encoding: Set by user, can be NULL. - decoding: Set by libavcodec.</summary>
        public ushort* @intra_matrix;
        /// <summary>custom inter quantization matrix - encoding: Set by user, can be NULL. - decoding: Set by libavcodec.</summary>
        public ushort* @inter_matrix;
        public int @scenechange_threshold;
        public int @noise_reduction;
        public int @me_threshold;
        public int @mb_threshold;
        /// <summary>precision of the intra DC coefficient - 8 - encoding: Set by user. - decoding: Set by libavcodec</summary>
        public int @intra_dc_precision;
        /// <summary>Number of macroblock rows at the top which are skipped. - encoding: unused - decoding: Set by user.</summary>
        public int @skip_top;
        /// <summary>Number of macroblock rows at the bottom which are skipped. - encoding: unused - decoding: Set by user.</summary>
        public int @skip_bottom;
        public float @border_masking;
        /// <summary>minimum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
        public int @mb_lmin;
        /// <summary>maximum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
        public int @mb_lmax;
        public int @me_penalty_compensation;
        /// <summary>- encoding: Set by user. - decoding: unused</summary>
        public int @bidir_refine;
        public int @brd_scale;
        /// <summary>minimum GOP size - encoding: Set by user. - decoding: unused</summary>
        public int @keyint_min;
        /// <summary>number of reference frames - encoding: Set by user. - decoding: Set by lavc.</summary>
        public int @refs;
        public int @chromaoffset;
        /// <summary>Multiplied by qscale for each frame and added to scene_change_score. - encoding: Set by user. - decoding: unused</summary>
        public int @scenechange_factor;
        /// <summary>Note: Value depends upon the compare function used for fullpel ME. - encoding: Set by user. - decoding: unused</summary>
        public int @mv0_threshold;
        public int @b_sensitivity;
        /// <summary>Chromaticity coordinates of the source primaries. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorPrimaries @color_primaries;
        /// <summary>Color Transfer Characteristic. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorTransferCharacteristic @color_trc;
        /// <summary>YUV colorspace type. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorSpace @colorspace;
        /// <summary>MPEG vs JPEG YUV range. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorRange @color_range;
        /// <summary>This defines the location of chroma samples. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVChromaLocation @chroma_sample_location;
        /// <summary>Number of slices. Indicates number of picture subdivisions. Used for parallelized decoding. - encoding: Set by user - decoding: unused</summary>
        public int @slices;
        /// <summary>Field order - encoding: set by libavcodec - decoding: Set by user.</summary>
        public AVFieldOrder @field_order;
        /// <summary>samples per second</summary>
        public int @sample_rate;
        /// <summary>number of audio channels</summary>
        public int @channels;
        /// <summary>sample format</summary>
        public AVSampleFormat @sample_fmt;
        /// <summary>Number of samples per channel in an audio frame.</summary>
        public int @frame_size;
        /// <summary>Frame counter, set by libavcodec.</summary>
        public int @frame_number;
        /// <summary>number of bytes per packet if constant and known or 0 Used by some WAV based audio codecs.</summary>
        public int @block_align;
        /// <summary>Audio cutoff bandwidth (0 means "automatic") - encoding: Set by user. - decoding: unused</summary>
        public int @cutoff;
        /// <summary>Audio channel layout. - encoding: set by user. - decoding: set by user, may be overwritten by libavcodec.</summary>
        public ulong @channel_layout;
        /// <summary>Request decoder to use this channel layout if it can (0 for default) - encoding: unused - decoding: Set by user.</summary>
        public ulong @request_channel_layout;
        /// <summary>Type of service that the audio stream conveys. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public AVAudioServiceType @audio_service_type;
        /// <summary>desired sample format - encoding: Not used. - decoding: Set by user. Decoder will decode to this format if it can.</summary>
        public AVSampleFormat @request_sample_fmt;
        /// <summary>This callback is called at the beginning of each frame to get data buffer(s) for it. There may be one contiguous buffer for all the data or there may be a buffer per each data plane or anything in between. What this means is, you may set however many entries in buf[] you feel necessary. Each buffer must be reference-counted using the AVBuffer API (see description of buf[] below).</summary>
        public IntPtr @get_buffer2;
        /// <summary>If non-zero, the decoded audio and video frames returned from avcodec_decode_video2() and avcodec_decode_audio4() are reference-counted and are valid indefinitely. The caller must free them with av_frame_unref() when they are not needed anymore. Otherwise, the decoded frames must not be freed by the caller and are only valid until the next decode call.</summary>
        public int @refcounted_frames;
        /// <summary>amount of qscale change between easy & hard scenes (0.0-1.0)</summary>
        public float @qcompress;
        /// <summary>amount of qscale smoothing over time (0.0-1.0)</summary>
        public float @qblur;
        /// <summary>minimum quantizer - encoding: Set by user. - decoding: unused</summary>
        public int @qmin;
        /// <summary>maximum quantizer - encoding: Set by user. - decoding: unused</summary>
        public int @qmax;
        /// <summary>maximum quantizer difference between frames - encoding: Set by user. - decoding: unused</summary>
        public int @max_qdiff;
        public float @rc_qsquish;
        public float @rc_qmod_amp;
        public int @rc_qmod_freq;
        /// <summary>decoder bitstream buffer size - encoding: Set by user. - decoding: unused</summary>
        public int @rc_buffer_size;
        /// <summary>ratecontrol override, see RcOverride - encoding: Allocated/set/freed by user. - decoding: unused</summary>
        public int @rc_override_count;
        public RcOverride* @rc_override;
        public byte* @rc_eq;
        /// <summary>maximum bitrate - encoding: Set by user. - decoding: Set by user, may be overwritten by libavcodec.</summary>
        public long @rc_max_rate;
        /// <summary>minimum bitrate - encoding: Set by user. - decoding: unused</summary>
        public long @rc_min_rate;
        public float @rc_buffer_aggressivity;
        public float @rc_initial_cplx;
        /// <summary>Ratecontrol attempt to use, at maximum, <value> of what can be used without an underflow. - encoding: Set by user. - decoding: unused.</summary>
        public float @rc_max_available_vbv_use;
        /// <summary>Ratecontrol attempt to use, at least, <value> times the amount needed to prevent a vbv overflow. - encoding: Set by user. - decoding: unused.</summary>
        public float @rc_min_vbv_overflow_use;
        /// <summary>Number of bits which should be loaded into the rc buffer before decoding starts. - encoding: Set by user. - decoding: unused</summary>
        public int @rc_initial_buffer_occupancy;
        public int @coder_type;
        public int @context_model;
        public int @lmin;
        public int @lmax;
        public int @frame_skip_threshold;
        public int @frame_skip_factor;
        public int @frame_skip_exp;
        public int @frame_skip_cmp;
        /// <summary>trellis RD quantization - encoding: Set by user. - decoding: unused</summary>
        public int @trellis;
        public int @min_prediction_order;
        public int @max_prediction_order;
        public long @timecode_frame_start;
        public IntPtr @rtp_callback;
        public int @rtp_payload_size;
        public int @mv_bits;
        public int @header_bits;
        public int @i_tex_bits;
        public int @p_tex_bits;
        public int @i_count;
        public int @p_count;
        public int @skip_count;
        public int @misc_bits;
        public int @frame_bits;
        /// <summary>pass1 encoding statistics output buffer - encoding: Set by libavcodec. - decoding: unused</summary>
        public byte* @stats_out;
        /// <summary>pass2 encoding statistics input buffer Concatenated stuff from stats_out of pass1 should be placed here. - encoding: Allocated/set/freed by user. - decoding: unused</summary>
        public byte* @stats_in;
        /// <summary>Work around bugs in encoders which sometimes cannot be detected automatically. - encoding: Set by user - decoding: Set by user</summary>
        public int @workaround_bugs;
        /// <summary>strictly follow the standard (MPEG-4, ...). - encoding: Set by user. - decoding: Set by user. Setting this to STRICT or higher means the encoder and decoder will generally do stupid things, whereas setting it to unofficial or lower will mean the encoder might produce output that is not supported by all spec-compliant decoders. Decoders don't differentiate between normal, unofficial and experimental (that is, they always try to decode things when they can) unless they are explicitly asked to behave stupidly (=strictly conform to the specs)</summary>
        public int @strict_std_compliance;
        /// <summary>error concealment flags - encoding: unused - decoding: Set by user.</summary>
        public int @error_concealment;
        /// <summary>debug - encoding: Set by user. - decoding: Set by user.</summary>
        public int @debug;
        /// <summary>debug Code outside libavcodec should access this field using AVOptions - encoding: Set by user. - decoding: Set by user.</summary>
        public int @debug_mv;
        /// <summary>Error recognition; may misdetect some more or less valid parts as errors. - encoding: unused - decoding: Set by user.</summary>
        public int @err_recognition;
        /// <summary>opaque 64-bit number (generally a PTS) that will be reordered and output in AVFrame.reordered_opaque - encoding: unused - decoding: Set by user.</summary>
        public long @reordered_opaque;
        /// <summary>Hardware accelerator in use - encoding: unused. - decoding: Set by libavcodec</summary>
        public IntPtr @hwaccel;
        /// <summary>Hardware accelerator context. For some hardware accelerators, a global context needs to be provided by the user. In that case, this holds display-dependent data FFmpeg cannot instantiate itself. Please refer to the FFmpeg HW accelerator documentation to know how to fill this is. e.g. for VA API, this is a struct vaapi_context. - encoding: unused - decoding: Set by user</summary>
        public void* @hwaccel_context;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error0;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error1;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error2;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error3;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error4;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error5;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error6;
        /// <summary>error - encoding: Set by libavcodec if flags & AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong @error7;
        /// <summary>DCT algorithm, see FF_DCT_* below - encoding: Set by user. - decoding: unused</summary>
        public int @dct_algo;
        /// <summary>IDCT algorithm, see FF_IDCT_* below. - encoding: Set by user. - decoding: Set by user.</summary>
        public int @idct_algo;
        /// <summary>bits per sample/pixel from the demuxer (needed for huffyuv). - encoding: Set by libavcodec. - decoding: Set by user.</summary>
        public int @bits_per_coded_sample;
        /// <summary>Bits per sample/pixel of internal libavcodec pixel/sample format. - encoding: set by user. - decoding: set by libavcodec.</summary>
        public int @bits_per_raw_sample;
        /// <summary>low resolution decoding, 1-> 1/2 size, 2->1/4 size - encoding: unused - decoding: Set by user. Code outside libavcodec should access this field using: av_codec_{get,set}_lowres(avctx)</summary>
        public int @lowres;
        /// <summary>the picture in the bitstream - encoding: Set by libavcodec. - decoding: unused</summary>
        public AVFrame* @coded_frame;
        /// <summary>thread count is used to decide how many independent tasks should be passed to execute() - encoding: Set by user. - decoding: Set by user.</summary>
        public int @thread_count;
        /// <summary>Which multithreading methods to use. Use of FF_THREAD_FRAME will increase decoding delay by one frame per thread, so clients which cannot provide future frames should not use it.</summary>
        public int @thread_type;
        /// <summary>Which multithreading methods are in use by the codec. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
        public int @active_thread_type;
        /// <summary>Set by the client if its custom get_buffer() callback can be called synchronously from another thread, which allows faster multithreaded decoding. draw_horiz_band() will be called from other threads regardless of this setting. Ignored if the default get_buffer() is used. - encoding: Set by user. - decoding: Set by user.</summary>
        public int @thread_safe_callbacks;
        /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially.</summary>
        public IntPtr @execute;
        /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially. Also see avcodec_thread_init and e.g. the --enable-pthread configure option.</summary>
        public IntPtr @execute2;
        /// <summary>noise vs. sse weight for the nsse comparison function - encoding: Set by user. - decoding: unused</summary>
        public int @nsse_weight;
        /// <summary>profile - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int @profile;
        /// <summary>level - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int @level;
        /// <summary>Skip loop filtering for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard @skip_loop_filter;
        /// <summary>Skip IDCT/dequantization for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard @skip_idct;
        /// <summary>Skip decoding for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard @skip_frame;
        /// <summary>Header containing style information for text subtitles. For SUBTITLE_ASS subtitle type, it should contain the whole ASS [Script Info] and [V4+ Styles] section, plus the [Events] line and the Format line following. It shouldn't include any Dialogue line. - encoding: Set/allocated/freed by user (before avcodec_open2()) - decoding: Set/allocated/freed by libavcodec (by avcodec_open2())</summary>
        public byte* @subtitle_header;
        public int @subtitle_header_size;
        public int @error_rate;
        /// <summary>VBV delay coded in the last frame (in periods of a 27 MHz clock). Used for compliant TS muxing. - encoding: Set by libavcodec. - decoding: unused.</summary>
        public ulong @vbv_delay;
        /// <summary>Encoding only and set by default. Allow encoders to output packets that do not contain any encoded data, only side data.</summary>
        public int @side_data_only_packets;
        /// <summary>Audio only. The number of "priming" samples (padding) inserted by the encoder at the beginning of the audio. I.e. this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</summary>
        public int @initial_padding;
        /// <summary>- decoding: For codecs that store a framerate value in the compressed bitstream, the decoder may export it here. { 0, 1} when unknown. - encoding: May be used to signal the framerate of CFR content to an encoder.</summary>
        public AVRational @framerate;
        /// <summary>Nominal unaccelerated pixel format, see AV_PIX_FMT_xxx. - encoding: unused. - decoding: Set by libavcodec before calling get_format()</summary>
        public AVPixelFormat @sw_pix_fmt;
        /// <summary>Timebase in which pkt_dts/pts and AVPacket.dts/pts are. Code outside libavcodec should access this field using: av_codec_{get,set}_pkt_timebase(avctx) - encoding unused. - decoding set by user.</summary>
        public AVRational @pkt_timebase;
        /// <summary>AVCodecDescriptor Code outside libavcodec should access this field using: av_codec_{get,set}_codec_descriptor(avctx) - encoding: unused. - decoding: set by libavcodec.</summary>
        public AVCodecDescriptor* @codec_descriptor;
        /// <summary>Current statistics for PTS correction. - decoding: maintained and used by libavcodec, not intended to be used by user apps - encoding: unused</summary>
        public long @pts_correction_num_faulty_pts;
        /// <summary>Number of incorrect PTS values so far</summary>
        public long @pts_correction_num_faulty_dts;
        /// <summary>Number of incorrect DTS values so far</summary>
        public long @pts_correction_last_pts;
        /// <summary>PTS of the last frame</summary>
        public long @pts_correction_last_dts;
        /// <summary>Character encoding of the input subtitles file. - decoding: set by user - encoding: unused</summary>
        public byte* @sub_charenc;
        /// <summary>Subtitles character encoding mode. Formats or codecs might be adjusting this setting (if they are doing the conversion themselves for instance). - decoding: set by libavcodec - encoding: unused</summary>
        public int @sub_charenc_mode;
        /// <summary>Skip processing alpha if supported by codec. Note that if the format uses pre-multiplied alpha (common with VP6, and recommended due to better video quality/compression) the image will look as if alpha-blended onto a black background. However for formats that do not use pre-multiplied alpha there might be serious artefacts (though e.g. libswscale currently assumes pre-multiplied alpha anyway). Code outside libavcodec should access this field using AVOptions</summary>
        public int @skip_alpha;
        /// <summary>Number of samples to skip after a discontinuity - decoding: unused - encoding: set by libavcodec</summary>
        public int @seek_preroll;
        /// <summary>custom intra quantization matrix Code outside libavcodec should access this field using av_codec_g/set_chroma_intra_matrix() - encoding: Set by user, can be NULL. - decoding: unused.</summary>
        public ushort* @chroma_intra_matrix;
        /// <summary>dump format separator. can be ", " or " " or anything else Code outside libavcodec should access this field using AVOptions (NO direct access). - encoding: Set by user. - decoding: Set by user.</summary>
        public byte* @dump_separator;
        /// <summary>',' separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user through AVOPtions (NO direct access)</summary>
        public byte* @codec_whitelist;
        public uint @properties;
        /// <summary>Additional data associated with the entire coded stream.</summary>
        public AVPacketSideData* @coded_side_data;
        public int @nb_coded_side_data;
        /// <summary>A reference to the AVHWFramesContext describing the input (for encoding) or output (decoding) frames. The reference is set by the caller and afterwards owned (and freed) by libavcodec.</summary>
        public AVBufferRef* @hw_frames_ctx;
        /// <summary>Control the form of AVSubtitle.rects[N]->ass - decoding: set by user - encoding: unused</summary>
        public int @sub_text_format;
        /// <summary>Audio only. The amount of padding (in samples) appended by the encoder to the end of the audio. I.e. this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</summary>
        public int @trailing_padding;
    }
    
    public unsafe struct AVCodecDefault
    {
    }
    
    /// <summary>Picture data structure.</summary>
    public unsafe struct AVPicture
    {
        /// <summary>pointers to the image data planes</summary>
        public byte* @data0;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data1;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data2;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data3;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data4;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data5;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data6;
        /// <summary>pointers to the image data planes</summary>
        public byte* @data7;
        /// <summary>number of bytes per line</summary>
        public int @linesize0;
        /// <summary>number of bytes per line</summary>
        public int @linesize1;
        /// <summary>number of bytes per line</summary>
        public int @linesize2;
        /// <summary>number of bytes per line</summary>
        public int @linesize3;
        /// <summary>number of bytes per line</summary>
        public int @linesize4;
        /// <summary>number of bytes per line</summary>
        public int @linesize5;
        /// <summary>number of bytes per line</summary>
        public int @linesize6;
        /// <summary>number of bytes per line</summary>
        public int @linesize7;
    }
    
    public unsafe struct AVSubtitleRect
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
        public AVPicture @pict;
        /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
        public byte* @data0;
        /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
        public byte* @data1;
        /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
        public byte* @data2;
        /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
        public byte* @data3;
        public int @linesize0;
        public int @linesize1;
        public int @linesize2;
        public int @linesize3;
        public AVSubtitleType @type;
        /// <summary>0 terminated plain UTF-8 text</summary>
        public byte* @text;
        /// <summary>0 terminated ASS/SSA compatible event line. The presentation of this is unaffected by the other values in this struct.</summary>
        public byte* @ass;
        public int @flags;
    }
    
    /// <summary>AVCodec.</summary>
    public unsafe struct AVCodec
    {
        /// <summary>Name of the codec implementation. The name is globally unique among encoders and among decoders (but an encoder and a decoder can share the same name). This is the primary way to find a codec from the user perspective.</summary>
        public byte* @name;
        /// <summary>Descriptive name for the codec, meant to be more human readable than name. You should use the NULL_IF_CONFIG_SMALL() macro to define it.</summary>
        public byte* @long_name;
        public AVMediaType @type;
        public AVCodecID @id;
        /// <summary>Codec capabilities. see AV_CODEC_CAP_*</summary>
        public int @capabilities;
        /// <summary>array of supported framerates, or NULL if any, array is terminated by {0,0}</summary>
        public AVRational* @supported_framerates;
        /// <summary>array of supported pixel formats, or NULL if unknown, array is terminated by -1</summary>
        public IntPtr @pix_fmts;
        /// <summary>array of supported audio samplerates, or NULL if unknown, array is terminated by 0</summary>
        public int* @supported_samplerates;
        /// <summary>array of supported sample formats, or NULL if unknown, array is terminated by -1</summary>
        public IntPtr @sample_fmts;
        /// <summary>array of support channel layouts, or NULL if unknown. array is terminated by 0</summary>
        public ulong* @channel_layouts;
        /// <summary>maximum value for lowres supported by the decoder, no direct access, use av_codec_get_max_lowres()</summary>
        public byte @max_lowres;
        /// <summary>AVClass for the private context</summary>
        public AVClass* @priv_class;
        /// <summary>array of recognized profiles, or NULL if unknown, array is terminated by {FF_PROFILE_UNKNOWN}</summary>
        public AVProfile* @profiles;
        /// <summary>*************************************************************** No fields below this line are part of the public API. They may not be used outside of libavcodec and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public int @priv_data_size;
        public IntPtr @next;
        /// <summary>@{</summary>
        public IntPtr @init_thread_copy;
        /// <summary>Copy necessary context variables from a previous thread context to the current one. If not defined, the next thread will start automatically; otherwise, the codec must call ff_thread_finish_setup().</summary>
        public IntPtr @update_thread_context;
        /// <summary>Private codec-specific defaults.</summary>
        public AVCodecDefault* @defaults;
        /// <summary>Initialize codec static data, called from avcodec_register().</summary>
        public IntPtr @init_static_data;
        public IntPtr @init;
        public IntPtr @encode_sub;
        /// <summary>Encode data to an AVPacket.</summary>
        public IntPtr @encode2;
        public IntPtr @decode;
        public IntPtr @close;
        /// <summary>Decode/encode API with decoupled packet/frame dataflow. The API is the same as the avcodec_ prefixed APIs (avcodec_send_frame() etc.), except that: - never called if the codec is closed or the wrong type, - AVPacket parameter change side data is applied right before calling AVCodec->send_packet, - if AV_CODEC_CAP_DELAY is not set, drain packets or frames are never sent, - only one drain packet is ever passed down (until the next flush()), - a drain AVPacket is always NULL (no need to check for avpkt->size).</summary>
        public IntPtr @send_frame;
        public IntPtr @send_packet;
        public IntPtr @receive_frame;
        public IntPtr @receive_packet;
        /// <summary>Flush buffers. Will be called when seeking</summary>
        public IntPtr @flush;
        /// <summary>Internal codec capabilities. See FF_CODEC_CAP_* in internal.h</summary>
        public int @caps_internal;
    }
    
    /// <summary>@{</summary>
    public unsafe struct AVHWAccel
    {
        /// <summary>Name of the hardware accelerated codec. The name is globally unique among encoders and among decoders (but an encoder and a decoder can share the same name).</summary>
        public byte* @name;
        /// <summary>Type of codec implemented by the hardware accelerator.</summary>
        public AVMediaType @type;
        /// <summary>Codec implemented by the hardware accelerator.</summary>
        public AVCodecID @id;
        /// <summary>Supported pixel format.</summary>
        public AVPixelFormat @pix_fmt;
        /// <summary>Hardware accelerated codec capabilities. see HWACCEL_CODEC_CAP_*</summary>
        public int @capabilities;
        /// <summary>*************************************************************** No fields below this line are part of the public API. They may not be used outside of libavcodec and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public IntPtr @next;
        /// <summary>Allocate a custom buffer</summary>
        public IntPtr @alloc_frame;
        /// <summary>Called at the beginning of each frame or field picture.</summary>
        public IntPtr @start_frame;
        /// <summary>Callback for each slice.</summary>
        public IntPtr @decode_slice;
        /// <summary>Called at the end of each frame or field picture.</summary>
        public IntPtr @end_frame;
        /// <summary>Size of per-frame hardware accelerator private data.</summary>
        public int @frame_priv_data_size;
        /// <summary>Called for every Macroblock in a slice.</summary>
        public IntPtr @decode_mb;
        /// <summary>Initialize the hwaccel private data.</summary>
        public IntPtr @init;
        /// <summary>Uninitialize the hwaccel private data.</summary>
        public IntPtr @uninit;
        /// <summary>Size of the private data to allocate in AVCodecInternal.hwaccel_priv_data.</summary>
        public int @priv_data_size;
    }
    
    public unsafe struct AVSubtitle
    {
        public ushort @format;
        public uint @start_display_time;
        public uint @end_display_time;
        public uint @num_rects;
        public AVSubtitleRect** @rects;
        /// <summary>Same as packet pts, in AV_TIME_BASE</summary>
        public long @pts;
    }
    
    /// <summary>This struct describes the properties of an encoded stream.</summary>
    public unsafe struct AVCodecParameters
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
        /// <summary>- video: the pixel format, the value corresponds to enum AVPixelFormat. - audio: the sample format, the value corresponds to enum AVSampleFormat.</summary>
        public int @format;
        /// <summary>The average bitrate of the encoded data (in bits per second).</summary>
        public long @bit_rate;
        /// <summary>The number of bits per sample in the codedwords.</summary>
        public int @bits_per_coded_sample;
        /// <summary>This is the number of valid bits in each output sample. If the sample format has more bits, the least significant bits are additional padding bits, which are always 0. Use right shifts to reduce the sample to its actual size. For example, audio formats with 24 bit samples will have bits_per_raw_sample set to 24, and format set to AV_SAMPLE_FMT_S32. To get the original sample use "(int32_t)sample >> 8"."</summary>
        public int @bits_per_raw_sample;
        /// <summary>Codec-specific bitstream restrictions that the stream conforms to.</summary>
        public int @profile;
        public int @level;
        /// <summary>Video only. The dimensions of the video frame in pixels.</summary>
        public int @width;
        public int @height;
        /// <summary>Video only. The aspect ratio (width / height) which a single pixel should have when displayed.</summary>
        public AVRational @sample_aspect_ratio;
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
        /// <summary>Audio only. The channel layout bitmask. May be 0 if the channel layout is unknown or unspecified, otherwise the number of bits set must be equal to the channels field.</summary>
        public ulong @channel_layout;
        /// <summary>Audio only. The number of audio channels.</summary>
        public int @channels;
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
    
    public unsafe struct AVCodecParserContext
    {
        public void* @priv_data;
        public IntPtr @parser;
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
        public long @cur_frame_offset0;
        public long @cur_frame_offset1;
        public long @cur_frame_offset2;
        public long @cur_frame_offset3;
        public long @cur_frame_pts0;
        public long @cur_frame_pts1;
        public long @cur_frame_pts2;
        public long @cur_frame_pts3;
        public long @cur_frame_dts0;
        public long @cur_frame_dts1;
        public long @cur_frame_dts2;
        public long @cur_frame_dts3;
        public int @flags;
        /// <summary>byte offset from starting packet start</summary>
        public long @offset;
        public long @cur_frame_end0;
        public long @cur_frame_end1;
        public long @cur_frame_end2;
        public long @cur_frame_end3;
        /// <summary>Set by parser to 1 for key frames and 0 for non-key frames. It is initialized to -1, so if the parser doesn't set this flag, old-style fallback using AV_PICTURE_TYPE_I picture type as key frames will be used.</summary>
        public int @key_frame;
        public long @convergence_duration;
        /// <summary>Synchronization point for start of timestamp generation.</summary>
        public int @dts_sync_point;
        /// <summary>Offset of the current timestamp against last timestamp sync point in units of AVCodecContext.time_base.</summary>
        public int @dts_ref_dts_delta;
        /// <summary>Presentation delay of current frame in units of AVCodecContext.time_base.</summary>
        public int @pts_dts_delta;
        /// <summary>Position of the packet in file.</summary>
        public long @cur_frame_pos0;
        /// <summary>Position of the packet in file.</summary>
        public long @cur_frame_pos1;
        /// <summary>Position of the packet in file.</summary>
        public long @cur_frame_pos2;
        /// <summary>Position of the packet in file.</summary>
        public long @cur_frame_pos3;
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
    
    public unsafe struct AVCodecParser
    {
        public int @codec_ids0;
        public int @codec_ids1;
        public int @codec_ids2;
        public int @codec_ids3;
        public int @codec_ids4;
        public int @priv_data_size;
        public IntPtr @parser_init;
        public IntPtr @parser_parse;
        public IntPtr @parser_close;
        public IntPtr @split;
        public IntPtr @next;
    }
    
    public unsafe struct ReSampleContext
    {
    }
    
    public unsafe struct AVBSFInternal
    {
    }
    
    /// <summary>The bitstream filter state.</summary>
    public unsafe struct AVBSFContext
    {
        /// <summary>A class for logging and AVOptions</summary>
        public AVClass* @av_class;
        /// <summary>The bitstream filter this context is an instance of.</summary>
        public IntPtr @filter;
        /// <summary>Opaque libavcodec internal data. Must not be touched by the caller in any way.</summary>
        public AVBSFInternal* @internal;
        /// <summary>Opaque filter-specific private data. If filter->priv_class is non-NULL, this is an AVOptions-enabled struct.</summary>
        public void* @priv_data;
        /// <summary>Parameters of the input stream. Set by the caller before av_bsf_init().</summary>
        public AVCodecParameters* @par_in;
        /// <summary>Parameters of the output stream. Set by the filter in av_bsf_init().</summary>
        public AVCodecParameters* @par_out;
        /// <summary>The timebase used for the timestamps of the input packets. Set by the caller before av_bsf_init().</summary>
        public AVRational @time_base_in;
        /// <summary>The timebase used for the timestamps of the output packets. Set by the filter in av_bsf_init().</summary>
        public AVRational @time_base_out;
    }
    
    public unsafe struct AVBitStreamFilterContext
    {
        public void* @priv_data;
        public IntPtr @filter;
        public AVCodecParserContext* @parser;
        public IntPtr @next;
        /// <summary>Internal default arguments, used if NULL is passed to av_bitstream_filter_filter(). Not for access by library users.</summary>
        public byte* @args;
    }
    
    public unsafe struct AVBitStreamFilter
    {
        public byte* @name;
        /// <summary>A list of codec ids supported by the filter, terminated by AV_CODEC_ID_NONE. May be NULL, in that case the bitstream filter works with any codec id.</summary>
        public IntPtr @codec_ids;
        /// <summary>A class for the private data, used to declare bitstream filter private AVOptions. This field is NULL for bitstream filters that do not declare any options.</summary>
        public AVClass* @priv_class;
        /// <summary>*************************************************************** No fields below this line are part of the public API. They may not be used outside of libavcodec and can be changed and removed at will. New public fields should be added right above. ****************************************************************</summary>
        public int @priv_data_size;
        public IntPtr @init;
        public IntPtr @filter;
        public IntPtr @close;
    }
    
    public unsafe struct AVBSFList
    {
    }
    
    /// <summary>Callback for checking whether to abort blocking functions. AVERROR_EXIT is returned in this case by the interrupted function. During blocking operations, callback is called with opaque as parameter. If the callback returns 1, the blocking operation will be aborted.</summary>
    public unsafe struct AVIOInterruptCB
    {
        public IntPtr @callback;
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
        public IntPtr @read_packet;
        public IntPtr @write_packet;
        public IntPtr @seek;
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
        public IntPtr @update_checksum;
        /// <summary>contains the error code or 0 if no error happened</summary>
        public int @error;
        /// <summary>Pause or resume playback for network streaming protocols - e.g. MMS.</summary>
        public IntPtr @read_pause;
        /// <summary>Seek to a given timestamp in stream with the specified stream_index. Needed for some network streaming protocols which don't support seeking to byte position.</summary>
        public IntPtr @read_seek;
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
        public IntPtr @write_data_type;
        /// <summary>If set, don't call write_data_type separately for AVIO_DATA_MARKER_BOUNDARY_POINT, but ignore them and treat them as AVIO_DATA_MARKER_UNKNOWN (to avoid needlessly small chunks of data returned from the callback).</summary>
        public int @ignore_boundary_point;
        /// <summary>Internal, not meant to be used from outside of AVIOContext.</summary>
        public AVIODataMarkerType @current_type;
        public long @last_time;
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
        /// <summary>Flag is used to indicate which frame should be discarded after decoding.</summary>
        public int @flags;
        public int @size;
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
        public long @pts_buffer0;
        public long @pts_buffer1;
        public long @pts_buffer2;
        public long @pts_buffer3;
        public long @pts_buffer4;
        public long @pts_buffer5;
        public long @pts_buffer6;
        public long @pts_buffer7;
        public long @pts_buffer8;
        public long @pts_buffer9;
        public long @pts_buffer10;
        public long @pts_buffer11;
        public long @pts_buffer12;
        public long @pts_buffer13;
        public long @pts_buffer14;
        public long @pts_buffer15;
        public long @pts_buffer16;
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
        public long @pts_reorder_error0;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error1;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error2;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error3;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error4;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error5;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error6;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error7;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error8;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error9;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error10;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error11;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error12;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error13;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error14;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error15;
        /// <summary>Internal data to generate dts from pts</summary>
        public long @pts_reorder_error16;
        public byte @pts_reorder_error_count0;
        public byte @pts_reorder_error_count1;
        public byte @pts_reorder_error_count2;
        public byte @pts_reorder_error_count3;
        public byte @pts_reorder_error_count4;
        public byte @pts_reorder_error_count5;
        public byte @pts_reorder_error_count6;
        public byte @pts_reorder_error_count7;
        public byte @pts_reorder_error_count8;
        public byte @pts_reorder_error_count9;
        public byte @pts_reorder_error_count10;
        public byte @pts_reorder_error_count11;
        public byte @pts_reorder_error_count12;
        public byte @pts_reorder_error_count13;
        public byte @pts_reorder_error_count14;
        public byte @pts_reorder_error_count15;
        public byte @pts_reorder_error_count16;
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
        public IntPtr @write_header;
        /// <summary>Write a packet. If AVFMT_ALLOW_FLUSH is set in flags, pkt can be NULL in order to flush data buffered in the muxer. When flushing, return 0 if there still is more data to flush, or 1 if everything was flushed and there is no more buffered data.</summary>
        public IntPtr @write_packet;
        public IntPtr @write_trailer;
        /// <summary>Currently only used to set pixel format if not YUV420P.</summary>
        public IntPtr @interleave_packet;
        /// <summary>Test if the given codec can be stored in this container.</summary>
        public IntPtr @query_codec;
        public IntPtr @get_output_timestamp;
        /// <summary>Allows sending messages from application to device.</summary>
        public IntPtr @control_message;
        /// <summary>Write an uncoded AVFrame.</summary>
        public IntPtr @write_uncoded_frame;
        /// <summary>Returns device list with it properties.</summary>
        public IntPtr @get_device_list;
        /// <summary>Initialize device capabilities submodule.</summary>
        public IntPtr @create_device_capabilities;
        /// <summary>Free device capabilities submodule.</summary>
        public IntPtr @free_device_capabilities;
        /// <summary>default data codec</summary>
        public AVCodecID @data_codec;
        /// <summary>Initialize format. May allocate data here, and set any AVFormatContext or AVStream parameters that need to be set before packets are sent. This method must not write output.</summary>
        public IntPtr @init;
        /// <summary>Deinitialize format. If present, this is called whenever the muxer is being destroyed, regardless of whether or not the header has been written.</summary>
        public IntPtr @deinit;
        /// <summary>Set up any necessary bitstream filtering and extract any extra data needed for the global header. Return 0 if more packets from this stream must be checked; 1 if not.</summary>
        public IntPtr @check_bitstream;
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
        public IntPtr @read_probe;
        /// <summary>Read the format header and initialize the AVFormatContext structure. Return 0 if OK. 'avformat_new_stream' should be called to create new streams.</summary>
        public IntPtr @read_header;
        /// <summary>Read one packet and put it in 'pkt'. pts and flags are also set. 'avformat_new_stream' can be called only if the flag AVFMTCTX_NOHEADER is used and only in the calling thread (not in a background thread).</summary>
        public IntPtr @read_packet;
        /// <summary>Close the stream. The AVFormatContext and AVStreams are not freed by this function</summary>
        public IntPtr @read_close;
        /// <summary>Seek to a given timestamp relative to the frames in stream component stream_index.</summary>
        public IntPtr @read_seek;
        /// <summary>Get the next timestamp in stream[stream_index].time_base units.</summary>
        public IntPtr @read_timestamp;
        /// <summary>Start/resume playing - only meaningful if using a network-based format (RTSP).</summary>
        public IntPtr @read_play;
        /// <summary>Pause playing - only meaningful if using a network-based format (RTSP).</summary>
        public IntPtr @read_pause;
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard < AVDISCARD_ALL.</summary>
        public IntPtr @read_seek2;
        /// <summary>Returns device list with it properties.</summary>
        public IntPtr @get_device_list;
        /// <summary>Initialize device capabilities submodule.</summary>
        public IntPtr @create_device_capabilities;
        /// <summary>Free device capabilities submodule.</summary>
        public IntPtr @free_device_capabilities;
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
        public byte @filename0;
        /// <summary>input or output filename</summary>
        public byte @filename1;
        /// <summary>input or output filename</summary>
        public byte @filename2;
        /// <summary>input or output filename</summary>
        public byte @filename3;
        /// <summary>input or output filename</summary>
        public byte @filename4;
        /// <summary>input or output filename</summary>
        public byte @filename5;
        /// <summary>input or output filename</summary>
        public byte @filename6;
        /// <summary>input or output filename</summary>
        public byte @filename7;
        /// <summary>input or output filename</summary>
        public byte @filename8;
        /// <summary>input or output filename</summary>
        public byte @filename9;
        /// <summary>input or output filename</summary>
        public byte @filename10;
        /// <summary>input or output filename</summary>
        public byte @filename11;
        /// <summary>input or output filename</summary>
        public byte @filename12;
        /// <summary>input or output filename</summary>
        public byte @filename13;
        /// <summary>input or output filename</summary>
        public byte @filename14;
        /// <summary>input or output filename</summary>
        public byte @filename15;
        /// <summary>input or output filename</summary>
        public byte @filename16;
        /// <summary>input or output filename</summary>
        public byte @filename17;
        /// <summary>input or output filename</summary>
        public byte @filename18;
        /// <summary>input or output filename</summary>
        public byte @filename19;
        /// <summary>input or output filename</summary>
        public byte @filename20;
        /// <summary>input or output filename</summary>
        public byte @filename21;
        /// <summary>input or output filename</summary>
        public byte @filename22;
        /// <summary>input or output filename</summary>
        public byte @filename23;
        /// <summary>input or output filename</summary>
        public byte @filename24;
        /// <summary>input or output filename</summary>
        public byte @filename25;
        /// <summary>input or output filename</summary>
        public byte @filename26;
        /// <summary>input or output filename</summary>
        public byte @filename27;
        /// <summary>input or output filename</summary>
        public byte @filename28;
        /// <summary>input or output filename</summary>
        public byte @filename29;
        /// <summary>input or output filename</summary>
        public byte @filename30;
        /// <summary>input or output filename</summary>
        public byte @filename31;
        /// <summary>input or output filename</summary>
        public byte @filename32;
        /// <summary>input or output filename</summary>
        public byte @filename33;
        /// <summary>input or output filename</summary>
        public byte @filename34;
        /// <summary>input or output filename</summary>
        public byte @filename35;
        /// <summary>input or output filename</summary>
        public byte @filename36;
        /// <summary>input or output filename</summary>
        public byte @filename37;
        /// <summary>input or output filename</summary>
        public byte @filename38;
        /// <summary>input or output filename</summary>
        public byte @filename39;
        /// <summary>input or output filename</summary>
        public byte @filename40;
        /// <summary>input or output filename</summary>
        public byte @filename41;
        /// <summary>input or output filename</summary>
        public byte @filename42;
        /// <summary>input or output filename</summary>
        public byte @filename43;
        /// <summary>input or output filename</summary>
        public byte @filename44;
        /// <summary>input or output filename</summary>
        public byte @filename45;
        /// <summary>input or output filename</summary>
        public byte @filename46;
        /// <summary>input or output filename</summary>
        public byte @filename47;
        /// <summary>input or output filename</summary>
        public byte @filename48;
        /// <summary>input or output filename</summary>
        public byte @filename49;
        /// <summary>input or output filename</summary>
        public byte @filename50;
        /// <summary>input or output filename</summary>
        public byte @filename51;
        /// <summary>input or output filename</summary>
        public byte @filename52;
        /// <summary>input or output filename</summary>
        public byte @filename53;
        /// <summary>input or output filename</summary>
        public byte @filename54;
        /// <summary>input or output filename</summary>
        public byte @filename55;
        /// <summary>input or output filename</summary>
        public byte @filename56;
        /// <summary>input or output filename</summary>
        public byte @filename57;
        /// <summary>input or output filename</summary>
        public byte @filename58;
        /// <summary>input or output filename</summary>
        public byte @filename59;
        /// <summary>input or output filename</summary>
        public byte @filename60;
        /// <summary>input or output filename</summary>
        public byte @filename61;
        /// <summary>input or output filename</summary>
        public byte @filename62;
        /// <summary>input or output filename</summary>
        public byte @filename63;
        /// <summary>input or output filename</summary>
        public byte @filename64;
        /// <summary>input or output filename</summary>
        public byte @filename65;
        /// <summary>input or output filename</summary>
        public byte @filename66;
        /// <summary>input or output filename</summary>
        public byte @filename67;
        /// <summary>input or output filename</summary>
        public byte @filename68;
        /// <summary>input or output filename</summary>
        public byte @filename69;
        /// <summary>input or output filename</summary>
        public byte @filename70;
        /// <summary>input or output filename</summary>
        public byte @filename71;
        /// <summary>input or output filename</summary>
        public byte @filename72;
        /// <summary>input or output filename</summary>
        public byte @filename73;
        /// <summary>input or output filename</summary>
        public byte @filename74;
        /// <summary>input or output filename</summary>
        public byte @filename75;
        /// <summary>input or output filename</summary>
        public byte @filename76;
        /// <summary>input or output filename</summary>
        public byte @filename77;
        /// <summary>input or output filename</summary>
        public byte @filename78;
        /// <summary>input or output filename</summary>
        public byte @filename79;
        /// <summary>input or output filename</summary>
        public byte @filename80;
        /// <summary>input or output filename</summary>
        public byte @filename81;
        /// <summary>input or output filename</summary>
        public byte @filename82;
        /// <summary>input or output filename</summary>
        public byte @filename83;
        /// <summary>input or output filename</summary>
        public byte @filename84;
        /// <summary>input or output filename</summary>
        public byte @filename85;
        /// <summary>input or output filename</summary>
        public byte @filename86;
        /// <summary>input or output filename</summary>
        public byte @filename87;
        /// <summary>input or output filename</summary>
        public byte @filename88;
        /// <summary>input or output filename</summary>
        public byte @filename89;
        /// <summary>input or output filename</summary>
        public byte @filename90;
        /// <summary>input or output filename</summary>
        public byte @filename91;
        /// <summary>input or output filename</summary>
        public byte @filename92;
        /// <summary>input or output filename</summary>
        public byte @filename93;
        /// <summary>input or output filename</summary>
        public byte @filename94;
        /// <summary>input or output filename</summary>
        public byte @filename95;
        /// <summary>input or output filename</summary>
        public byte @filename96;
        /// <summary>input or output filename</summary>
        public byte @filename97;
        /// <summary>input or output filename</summary>
        public byte @filename98;
        /// <summary>input or output filename</summary>
        public byte @filename99;
        /// <summary>input or output filename</summary>
        public byte @filename100;
        /// <summary>input or output filename</summary>
        public byte @filename101;
        /// <summary>input or output filename</summary>
        public byte @filename102;
        /// <summary>input or output filename</summary>
        public byte @filename103;
        /// <summary>input or output filename</summary>
        public byte @filename104;
        /// <summary>input or output filename</summary>
        public byte @filename105;
        /// <summary>input or output filename</summary>
        public byte @filename106;
        /// <summary>input or output filename</summary>
        public byte @filename107;
        /// <summary>input or output filename</summary>
        public byte @filename108;
        /// <summary>input or output filename</summary>
        public byte @filename109;
        /// <summary>input or output filename</summary>
        public byte @filename110;
        /// <summary>input or output filename</summary>
        public byte @filename111;
        /// <summary>input or output filename</summary>
        public byte @filename112;
        /// <summary>input or output filename</summary>
        public byte @filename113;
        /// <summary>input or output filename</summary>
        public byte @filename114;
        /// <summary>input or output filename</summary>
        public byte @filename115;
        /// <summary>input or output filename</summary>
        public byte @filename116;
        /// <summary>input or output filename</summary>
        public byte @filename117;
        /// <summary>input or output filename</summary>
        public byte @filename118;
        /// <summary>input or output filename</summary>
        public byte @filename119;
        /// <summary>input or output filename</summary>
        public byte @filename120;
        /// <summary>input or output filename</summary>
        public byte @filename121;
        /// <summary>input or output filename</summary>
        public byte @filename122;
        /// <summary>input or output filename</summary>
        public byte @filename123;
        /// <summary>input or output filename</summary>
        public byte @filename124;
        /// <summary>input or output filename</summary>
        public byte @filename125;
        /// <summary>input or output filename</summary>
        public byte @filename126;
        /// <summary>input or output filename</summary>
        public byte @filename127;
        /// <summary>input or output filename</summary>
        public byte @filename128;
        /// <summary>input or output filename</summary>
        public byte @filename129;
        /// <summary>input or output filename</summary>
        public byte @filename130;
        /// <summary>input or output filename</summary>
        public byte @filename131;
        /// <summary>input or output filename</summary>
        public byte @filename132;
        /// <summary>input or output filename</summary>
        public byte @filename133;
        /// <summary>input or output filename</summary>
        public byte @filename134;
        /// <summary>input or output filename</summary>
        public byte @filename135;
        /// <summary>input or output filename</summary>
        public byte @filename136;
        /// <summary>input or output filename</summary>
        public byte @filename137;
        /// <summary>input or output filename</summary>
        public byte @filename138;
        /// <summary>input or output filename</summary>
        public byte @filename139;
        /// <summary>input or output filename</summary>
        public byte @filename140;
        /// <summary>input or output filename</summary>
        public byte @filename141;
        /// <summary>input or output filename</summary>
        public byte @filename142;
        /// <summary>input or output filename</summary>
        public byte @filename143;
        /// <summary>input or output filename</summary>
        public byte @filename144;
        /// <summary>input or output filename</summary>
        public byte @filename145;
        /// <summary>input or output filename</summary>
        public byte @filename146;
        /// <summary>input or output filename</summary>
        public byte @filename147;
        /// <summary>input or output filename</summary>
        public byte @filename148;
        /// <summary>input or output filename</summary>
        public byte @filename149;
        /// <summary>input or output filename</summary>
        public byte @filename150;
        /// <summary>input or output filename</summary>
        public byte @filename151;
        /// <summary>input or output filename</summary>
        public byte @filename152;
        /// <summary>input or output filename</summary>
        public byte @filename153;
        /// <summary>input or output filename</summary>
        public byte @filename154;
        /// <summary>input or output filename</summary>
        public byte @filename155;
        /// <summary>input or output filename</summary>
        public byte @filename156;
        /// <summary>input or output filename</summary>
        public byte @filename157;
        /// <summary>input or output filename</summary>
        public byte @filename158;
        /// <summary>input or output filename</summary>
        public byte @filename159;
        /// <summary>input or output filename</summary>
        public byte @filename160;
        /// <summary>input or output filename</summary>
        public byte @filename161;
        /// <summary>input or output filename</summary>
        public byte @filename162;
        /// <summary>input or output filename</summary>
        public byte @filename163;
        /// <summary>input or output filename</summary>
        public byte @filename164;
        /// <summary>input or output filename</summary>
        public byte @filename165;
        /// <summary>input or output filename</summary>
        public byte @filename166;
        /// <summary>input or output filename</summary>
        public byte @filename167;
        /// <summary>input or output filename</summary>
        public byte @filename168;
        /// <summary>input or output filename</summary>
        public byte @filename169;
        /// <summary>input or output filename</summary>
        public byte @filename170;
        /// <summary>input or output filename</summary>
        public byte @filename171;
        /// <summary>input or output filename</summary>
        public byte @filename172;
        /// <summary>input or output filename</summary>
        public byte @filename173;
        /// <summary>input or output filename</summary>
        public byte @filename174;
        /// <summary>input or output filename</summary>
        public byte @filename175;
        /// <summary>input or output filename</summary>
        public byte @filename176;
        /// <summary>input or output filename</summary>
        public byte @filename177;
        /// <summary>input or output filename</summary>
        public byte @filename178;
        /// <summary>input or output filename</summary>
        public byte @filename179;
        /// <summary>input or output filename</summary>
        public byte @filename180;
        /// <summary>input or output filename</summary>
        public byte @filename181;
        /// <summary>input or output filename</summary>
        public byte @filename182;
        /// <summary>input or output filename</summary>
        public byte @filename183;
        /// <summary>input or output filename</summary>
        public byte @filename184;
        /// <summary>input or output filename</summary>
        public byte @filename185;
        /// <summary>input or output filename</summary>
        public byte @filename186;
        /// <summary>input or output filename</summary>
        public byte @filename187;
        /// <summary>input or output filename</summary>
        public byte @filename188;
        /// <summary>input or output filename</summary>
        public byte @filename189;
        /// <summary>input or output filename</summary>
        public byte @filename190;
        /// <summary>input or output filename</summary>
        public byte @filename191;
        /// <summary>input or output filename</summary>
        public byte @filename192;
        /// <summary>input or output filename</summary>
        public byte @filename193;
        /// <summary>input or output filename</summary>
        public byte @filename194;
        /// <summary>input or output filename</summary>
        public byte @filename195;
        /// <summary>input or output filename</summary>
        public byte @filename196;
        /// <summary>input or output filename</summary>
        public byte @filename197;
        /// <summary>input or output filename</summary>
        public byte @filename198;
        /// <summary>input or output filename</summary>
        public byte @filename199;
        /// <summary>input or output filename</summary>
        public byte @filename200;
        /// <summary>input or output filename</summary>
        public byte @filename201;
        /// <summary>input or output filename</summary>
        public byte @filename202;
        /// <summary>input or output filename</summary>
        public byte @filename203;
        /// <summary>input or output filename</summary>
        public byte @filename204;
        /// <summary>input or output filename</summary>
        public byte @filename205;
        /// <summary>input or output filename</summary>
        public byte @filename206;
        /// <summary>input or output filename</summary>
        public byte @filename207;
        /// <summary>input or output filename</summary>
        public byte @filename208;
        /// <summary>input or output filename</summary>
        public byte @filename209;
        /// <summary>input or output filename</summary>
        public byte @filename210;
        /// <summary>input or output filename</summary>
        public byte @filename211;
        /// <summary>input or output filename</summary>
        public byte @filename212;
        /// <summary>input or output filename</summary>
        public byte @filename213;
        /// <summary>input or output filename</summary>
        public byte @filename214;
        /// <summary>input or output filename</summary>
        public byte @filename215;
        /// <summary>input or output filename</summary>
        public byte @filename216;
        /// <summary>input or output filename</summary>
        public byte @filename217;
        /// <summary>input or output filename</summary>
        public byte @filename218;
        /// <summary>input or output filename</summary>
        public byte @filename219;
        /// <summary>input or output filename</summary>
        public byte @filename220;
        /// <summary>input or output filename</summary>
        public byte @filename221;
        /// <summary>input or output filename</summary>
        public byte @filename222;
        /// <summary>input or output filename</summary>
        public byte @filename223;
        /// <summary>input or output filename</summary>
        public byte @filename224;
        /// <summary>input or output filename</summary>
        public byte @filename225;
        /// <summary>input or output filename</summary>
        public byte @filename226;
        /// <summary>input or output filename</summary>
        public byte @filename227;
        /// <summary>input or output filename</summary>
        public byte @filename228;
        /// <summary>input or output filename</summary>
        public byte @filename229;
        /// <summary>input or output filename</summary>
        public byte @filename230;
        /// <summary>input or output filename</summary>
        public byte @filename231;
        /// <summary>input or output filename</summary>
        public byte @filename232;
        /// <summary>input or output filename</summary>
        public byte @filename233;
        /// <summary>input or output filename</summary>
        public byte @filename234;
        /// <summary>input or output filename</summary>
        public byte @filename235;
        /// <summary>input or output filename</summary>
        public byte @filename236;
        /// <summary>input or output filename</summary>
        public byte @filename237;
        /// <summary>input or output filename</summary>
        public byte @filename238;
        /// <summary>input or output filename</summary>
        public byte @filename239;
        /// <summary>input or output filename</summary>
        public byte @filename240;
        /// <summary>input or output filename</summary>
        public byte @filename241;
        /// <summary>input or output filename</summary>
        public byte @filename242;
        /// <summary>input or output filename</summary>
        public byte @filename243;
        /// <summary>input or output filename</summary>
        public byte @filename244;
        /// <summary>input or output filename</summary>
        public byte @filename245;
        /// <summary>input or output filename</summary>
        public byte @filename246;
        /// <summary>input or output filename</summary>
        public byte @filename247;
        /// <summary>input or output filename</summary>
        public byte @filename248;
        /// <summary>input or output filename</summary>
        public byte @filename249;
        /// <summary>input or output filename</summary>
        public byte @filename250;
        /// <summary>input or output filename</summary>
        public byte @filename251;
        /// <summary>input or output filename</summary>
        public byte @filename252;
        /// <summary>input or output filename</summary>
        public byte @filename253;
        /// <summary>input or output filename</summary>
        public byte @filename254;
        /// <summary>input or output filename</summary>
        public byte @filename255;
        /// <summary>input or output filename</summary>
        public byte @filename256;
        /// <summary>input or output filename</summary>
        public byte @filename257;
        /// <summary>input or output filename</summary>
        public byte @filename258;
        /// <summary>input or output filename</summary>
        public byte @filename259;
        /// <summary>input or output filename</summary>
        public byte @filename260;
        /// <summary>input or output filename</summary>
        public byte @filename261;
        /// <summary>input or output filename</summary>
        public byte @filename262;
        /// <summary>input or output filename</summary>
        public byte @filename263;
        /// <summary>input or output filename</summary>
        public byte @filename264;
        /// <summary>input or output filename</summary>
        public byte @filename265;
        /// <summary>input or output filename</summary>
        public byte @filename266;
        /// <summary>input or output filename</summary>
        public byte @filename267;
        /// <summary>input or output filename</summary>
        public byte @filename268;
        /// <summary>input or output filename</summary>
        public byte @filename269;
        /// <summary>input or output filename</summary>
        public byte @filename270;
        /// <summary>input or output filename</summary>
        public byte @filename271;
        /// <summary>input or output filename</summary>
        public byte @filename272;
        /// <summary>input or output filename</summary>
        public byte @filename273;
        /// <summary>input or output filename</summary>
        public byte @filename274;
        /// <summary>input or output filename</summary>
        public byte @filename275;
        /// <summary>input or output filename</summary>
        public byte @filename276;
        /// <summary>input or output filename</summary>
        public byte @filename277;
        /// <summary>input or output filename</summary>
        public byte @filename278;
        /// <summary>input or output filename</summary>
        public byte @filename279;
        /// <summary>input or output filename</summary>
        public byte @filename280;
        /// <summary>input or output filename</summary>
        public byte @filename281;
        /// <summary>input or output filename</summary>
        public byte @filename282;
        /// <summary>input or output filename</summary>
        public byte @filename283;
        /// <summary>input or output filename</summary>
        public byte @filename284;
        /// <summary>input or output filename</summary>
        public byte @filename285;
        /// <summary>input or output filename</summary>
        public byte @filename286;
        /// <summary>input or output filename</summary>
        public byte @filename287;
        /// <summary>input or output filename</summary>
        public byte @filename288;
        /// <summary>input or output filename</summary>
        public byte @filename289;
        /// <summary>input or output filename</summary>
        public byte @filename290;
        /// <summary>input or output filename</summary>
        public byte @filename291;
        /// <summary>input or output filename</summary>
        public byte @filename292;
        /// <summary>input or output filename</summary>
        public byte @filename293;
        /// <summary>input or output filename</summary>
        public byte @filename294;
        /// <summary>input or output filename</summary>
        public byte @filename295;
        /// <summary>input or output filename</summary>
        public byte @filename296;
        /// <summary>input or output filename</summary>
        public byte @filename297;
        /// <summary>input or output filename</summary>
        public byte @filename298;
        /// <summary>input or output filename</summary>
        public byte @filename299;
        /// <summary>input or output filename</summary>
        public byte @filename300;
        /// <summary>input or output filename</summary>
        public byte @filename301;
        /// <summary>input or output filename</summary>
        public byte @filename302;
        /// <summary>input or output filename</summary>
        public byte @filename303;
        /// <summary>input or output filename</summary>
        public byte @filename304;
        /// <summary>input or output filename</summary>
        public byte @filename305;
        /// <summary>input or output filename</summary>
        public byte @filename306;
        /// <summary>input or output filename</summary>
        public byte @filename307;
        /// <summary>input or output filename</summary>
        public byte @filename308;
        /// <summary>input or output filename</summary>
        public byte @filename309;
        /// <summary>input or output filename</summary>
        public byte @filename310;
        /// <summary>input or output filename</summary>
        public byte @filename311;
        /// <summary>input or output filename</summary>
        public byte @filename312;
        /// <summary>input or output filename</summary>
        public byte @filename313;
        /// <summary>input or output filename</summary>
        public byte @filename314;
        /// <summary>input or output filename</summary>
        public byte @filename315;
        /// <summary>input or output filename</summary>
        public byte @filename316;
        /// <summary>input or output filename</summary>
        public byte @filename317;
        /// <summary>input or output filename</summary>
        public byte @filename318;
        /// <summary>input or output filename</summary>
        public byte @filename319;
        /// <summary>input or output filename</summary>
        public byte @filename320;
        /// <summary>input or output filename</summary>
        public byte @filename321;
        /// <summary>input or output filename</summary>
        public byte @filename322;
        /// <summary>input or output filename</summary>
        public byte @filename323;
        /// <summary>input or output filename</summary>
        public byte @filename324;
        /// <summary>input or output filename</summary>
        public byte @filename325;
        /// <summary>input or output filename</summary>
        public byte @filename326;
        /// <summary>input or output filename</summary>
        public byte @filename327;
        /// <summary>input or output filename</summary>
        public byte @filename328;
        /// <summary>input or output filename</summary>
        public byte @filename329;
        /// <summary>input or output filename</summary>
        public byte @filename330;
        /// <summary>input or output filename</summary>
        public byte @filename331;
        /// <summary>input or output filename</summary>
        public byte @filename332;
        /// <summary>input or output filename</summary>
        public byte @filename333;
        /// <summary>input or output filename</summary>
        public byte @filename334;
        /// <summary>input or output filename</summary>
        public byte @filename335;
        /// <summary>input or output filename</summary>
        public byte @filename336;
        /// <summary>input or output filename</summary>
        public byte @filename337;
        /// <summary>input or output filename</summary>
        public byte @filename338;
        /// <summary>input or output filename</summary>
        public byte @filename339;
        /// <summary>input or output filename</summary>
        public byte @filename340;
        /// <summary>input or output filename</summary>
        public byte @filename341;
        /// <summary>input or output filename</summary>
        public byte @filename342;
        /// <summary>input or output filename</summary>
        public byte @filename343;
        /// <summary>input or output filename</summary>
        public byte @filename344;
        /// <summary>input or output filename</summary>
        public byte @filename345;
        /// <summary>input or output filename</summary>
        public byte @filename346;
        /// <summary>input or output filename</summary>
        public byte @filename347;
        /// <summary>input or output filename</summary>
        public byte @filename348;
        /// <summary>input or output filename</summary>
        public byte @filename349;
        /// <summary>input or output filename</summary>
        public byte @filename350;
        /// <summary>input or output filename</summary>
        public byte @filename351;
        /// <summary>input or output filename</summary>
        public byte @filename352;
        /// <summary>input or output filename</summary>
        public byte @filename353;
        /// <summary>input or output filename</summary>
        public byte @filename354;
        /// <summary>input or output filename</summary>
        public byte @filename355;
        /// <summary>input or output filename</summary>
        public byte @filename356;
        /// <summary>input or output filename</summary>
        public byte @filename357;
        /// <summary>input or output filename</summary>
        public byte @filename358;
        /// <summary>input or output filename</summary>
        public byte @filename359;
        /// <summary>input or output filename</summary>
        public byte @filename360;
        /// <summary>input or output filename</summary>
        public byte @filename361;
        /// <summary>input or output filename</summary>
        public byte @filename362;
        /// <summary>input or output filename</summary>
        public byte @filename363;
        /// <summary>input or output filename</summary>
        public byte @filename364;
        /// <summary>input or output filename</summary>
        public byte @filename365;
        /// <summary>input or output filename</summary>
        public byte @filename366;
        /// <summary>input or output filename</summary>
        public byte @filename367;
        /// <summary>input or output filename</summary>
        public byte @filename368;
        /// <summary>input or output filename</summary>
        public byte @filename369;
        /// <summary>input or output filename</summary>
        public byte @filename370;
        /// <summary>input or output filename</summary>
        public byte @filename371;
        /// <summary>input or output filename</summary>
        public byte @filename372;
        /// <summary>input or output filename</summary>
        public byte @filename373;
        /// <summary>input or output filename</summary>
        public byte @filename374;
        /// <summary>input or output filename</summary>
        public byte @filename375;
        /// <summary>input or output filename</summary>
        public byte @filename376;
        /// <summary>input or output filename</summary>
        public byte @filename377;
        /// <summary>input or output filename</summary>
        public byte @filename378;
        /// <summary>input or output filename</summary>
        public byte @filename379;
        /// <summary>input or output filename</summary>
        public byte @filename380;
        /// <summary>input or output filename</summary>
        public byte @filename381;
        /// <summary>input or output filename</summary>
        public byte @filename382;
        /// <summary>input or output filename</summary>
        public byte @filename383;
        /// <summary>input or output filename</summary>
        public byte @filename384;
        /// <summary>input or output filename</summary>
        public byte @filename385;
        /// <summary>input or output filename</summary>
        public byte @filename386;
        /// <summary>input or output filename</summary>
        public byte @filename387;
        /// <summary>input or output filename</summary>
        public byte @filename388;
        /// <summary>input or output filename</summary>
        public byte @filename389;
        /// <summary>input or output filename</summary>
        public byte @filename390;
        /// <summary>input or output filename</summary>
        public byte @filename391;
        /// <summary>input or output filename</summary>
        public byte @filename392;
        /// <summary>input or output filename</summary>
        public byte @filename393;
        /// <summary>input or output filename</summary>
        public byte @filename394;
        /// <summary>input or output filename</summary>
        public byte @filename395;
        /// <summary>input or output filename</summary>
        public byte @filename396;
        /// <summary>input or output filename</summary>
        public byte @filename397;
        /// <summary>input or output filename</summary>
        public byte @filename398;
        /// <summary>input or output filename</summary>
        public byte @filename399;
        /// <summary>input or output filename</summary>
        public byte @filename400;
        /// <summary>input or output filename</summary>
        public byte @filename401;
        /// <summary>input or output filename</summary>
        public byte @filename402;
        /// <summary>input or output filename</summary>
        public byte @filename403;
        /// <summary>input or output filename</summary>
        public byte @filename404;
        /// <summary>input or output filename</summary>
        public byte @filename405;
        /// <summary>input or output filename</summary>
        public byte @filename406;
        /// <summary>input or output filename</summary>
        public byte @filename407;
        /// <summary>input or output filename</summary>
        public byte @filename408;
        /// <summary>input or output filename</summary>
        public byte @filename409;
        /// <summary>input or output filename</summary>
        public byte @filename410;
        /// <summary>input or output filename</summary>
        public byte @filename411;
        /// <summary>input or output filename</summary>
        public byte @filename412;
        /// <summary>input or output filename</summary>
        public byte @filename413;
        /// <summary>input or output filename</summary>
        public byte @filename414;
        /// <summary>input or output filename</summary>
        public byte @filename415;
        /// <summary>input or output filename</summary>
        public byte @filename416;
        /// <summary>input or output filename</summary>
        public byte @filename417;
        /// <summary>input or output filename</summary>
        public byte @filename418;
        /// <summary>input or output filename</summary>
        public byte @filename419;
        /// <summary>input or output filename</summary>
        public byte @filename420;
        /// <summary>input or output filename</summary>
        public byte @filename421;
        /// <summary>input or output filename</summary>
        public byte @filename422;
        /// <summary>input or output filename</summary>
        public byte @filename423;
        /// <summary>input or output filename</summary>
        public byte @filename424;
        /// <summary>input or output filename</summary>
        public byte @filename425;
        /// <summary>input or output filename</summary>
        public byte @filename426;
        /// <summary>input or output filename</summary>
        public byte @filename427;
        /// <summary>input or output filename</summary>
        public byte @filename428;
        /// <summary>input or output filename</summary>
        public byte @filename429;
        /// <summary>input or output filename</summary>
        public byte @filename430;
        /// <summary>input or output filename</summary>
        public byte @filename431;
        /// <summary>input or output filename</summary>
        public byte @filename432;
        /// <summary>input or output filename</summary>
        public byte @filename433;
        /// <summary>input or output filename</summary>
        public byte @filename434;
        /// <summary>input or output filename</summary>
        public byte @filename435;
        /// <summary>input or output filename</summary>
        public byte @filename436;
        /// <summary>input or output filename</summary>
        public byte @filename437;
        /// <summary>input or output filename</summary>
        public byte @filename438;
        /// <summary>input or output filename</summary>
        public byte @filename439;
        /// <summary>input or output filename</summary>
        public byte @filename440;
        /// <summary>input or output filename</summary>
        public byte @filename441;
        /// <summary>input or output filename</summary>
        public byte @filename442;
        /// <summary>input or output filename</summary>
        public byte @filename443;
        /// <summary>input or output filename</summary>
        public byte @filename444;
        /// <summary>input or output filename</summary>
        public byte @filename445;
        /// <summary>input or output filename</summary>
        public byte @filename446;
        /// <summary>input or output filename</summary>
        public byte @filename447;
        /// <summary>input or output filename</summary>
        public byte @filename448;
        /// <summary>input or output filename</summary>
        public byte @filename449;
        /// <summary>input or output filename</summary>
        public byte @filename450;
        /// <summary>input or output filename</summary>
        public byte @filename451;
        /// <summary>input or output filename</summary>
        public byte @filename452;
        /// <summary>input or output filename</summary>
        public byte @filename453;
        /// <summary>input or output filename</summary>
        public byte @filename454;
        /// <summary>input or output filename</summary>
        public byte @filename455;
        /// <summary>input or output filename</summary>
        public byte @filename456;
        /// <summary>input or output filename</summary>
        public byte @filename457;
        /// <summary>input or output filename</summary>
        public byte @filename458;
        /// <summary>input or output filename</summary>
        public byte @filename459;
        /// <summary>input or output filename</summary>
        public byte @filename460;
        /// <summary>input or output filename</summary>
        public byte @filename461;
        /// <summary>input or output filename</summary>
        public byte @filename462;
        /// <summary>input or output filename</summary>
        public byte @filename463;
        /// <summary>input or output filename</summary>
        public byte @filename464;
        /// <summary>input or output filename</summary>
        public byte @filename465;
        /// <summary>input or output filename</summary>
        public byte @filename466;
        /// <summary>input or output filename</summary>
        public byte @filename467;
        /// <summary>input or output filename</summary>
        public byte @filename468;
        /// <summary>input or output filename</summary>
        public byte @filename469;
        /// <summary>input or output filename</summary>
        public byte @filename470;
        /// <summary>input or output filename</summary>
        public byte @filename471;
        /// <summary>input or output filename</summary>
        public byte @filename472;
        /// <summary>input or output filename</summary>
        public byte @filename473;
        /// <summary>input or output filename</summary>
        public byte @filename474;
        /// <summary>input or output filename</summary>
        public byte @filename475;
        /// <summary>input or output filename</summary>
        public byte @filename476;
        /// <summary>input or output filename</summary>
        public byte @filename477;
        /// <summary>input or output filename</summary>
        public byte @filename478;
        /// <summary>input or output filename</summary>
        public byte @filename479;
        /// <summary>input or output filename</summary>
        public byte @filename480;
        /// <summary>input or output filename</summary>
        public byte @filename481;
        /// <summary>input or output filename</summary>
        public byte @filename482;
        /// <summary>input or output filename</summary>
        public byte @filename483;
        /// <summary>input or output filename</summary>
        public byte @filename484;
        /// <summary>input or output filename</summary>
        public byte @filename485;
        /// <summary>input or output filename</summary>
        public byte @filename486;
        /// <summary>input or output filename</summary>
        public byte @filename487;
        /// <summary>input or output filename</summary>
        public byte @filename488;
        /// <summary>input or output filename</summary>
        public byte @filename489;
        /// <summary>input or output filename</summary>
        public byte @filename490;
        /// <summary>input or output filename</summary>
        public byte @filename491;
        /// <summary>input or output filename</summary>
        public byte @filename492;
        /// <summary>input or output filename</summary>
        public byte @filename493;
        /// <summary>input or output filename</summary>
        public byte @filename494;
        /// <summary>input or output filename</summary>
        public byte @filename495;
        /// <summary>input or output filename</summary>
        public byte @filename496;
        /// <summary>input or output filename</summary>
        public byte @filename497;
        /// <summary>input or output filename</summary>
        public byte @filename498;
        /// <summary>input or output filename</summary>
        public byte @filename499;
        /// <summary>input or output filename</summary>
        public byte @filename500;
        /// <summary>input or output filename</summary>
        public byte @filename501;
        /// <summary>input or output filename</summary>
        public byte @filename502;
        /// <summary>input or output filename</summary>
        public byte @filename503;
        /// <summary>input or output filename</summary>
        public byte @filename504;
        /// <summary>input or output filename</summary>
        public byte @filename505;
        /// <summary>input or output filename</summary>
        public byte @filename506;
        /// <summary>input or output filename</summary>
        public byte @filename507;
        /// <summary>input or output filename</summary>
        public byte @filename508;
        /// <summary>input or output filename</summary>
        public byte @filename509;
        /// <summary>input or output filename</summary>
        public byte @filename510;
        /// <summary>input or output filename</summary>
        public byte @filename511;
        /// <summary>input or output filename</summary>
        public byte @filename512;
        /// <summary>input or output filename</summary>
        public byte @filename513;
        /// <summary>input or output filename</summary>
        public byte @filename514;
        /// <summary>input or output filename</summary>
        public byte @filename515;
        /// <summary>input or output filename</summary>
        public byte @filename516;
        /// <summary>input or output filename</summary>
        public byte @filename517;
        /// <summary>input or output filename</summary>
        public byte @filename518;
        /// <summary>input or output filename</summary>
        public byte @filename519;
        /// <summary>input or output filename</summary>
        public byte @filename520;
        /// <summary>input or output filename</summary>
        public byte @filename521;
        /// <summary>input or output filename</summary>
        public byte @filename522;
        /// <summary>input or output filename</summary>
        public byte @filename523;
        /// <summary>input or output filename</summary>
        public byte @filename524;
        /// <summary>input or output filename</summary>
        public byte @filename525;
        /// <summary>input or output filename</summary>
        public byte @filename526;
        /// <summary>input or output filename</summary>
        public byte @filename527;
        /// <summary>input or output filename</summary>
        public byte @filename528;
        /// <summary>input or output filename</summary>
        public byte @filename529;
        /// <summary>input or output filename</summary>
        public byte @filename530;
        /// <summary>input or output filename</summary>
        public byte @filename531;
        /// <summary>input or output filename</summary>
        public byte @filename532;
        /// <summary>input or output filename</summary>
        public byte @filename533;
        /// <summary>input or output filename</summary>
        public byte @filename534;
        /// <summary>input or output filename</summary>
        public byte @filename535;
        /// <summary>input or output filename</summary>
        public byte @filename536;
        /// <summary>input or output filename</summary>
        public byte @filename537;
        /// <summary>input or output filename</summary>
        public byte @filename538;
        /// <summary>input or output filename</summary>
        public byte @filename539;
        /// <summary>input or output filename</summary>
        public byte @filename540;
        /// <summary>input or output filename</summary>
        public byte @filename541;
        /// <summary>input or output filename</summary>
        public byte @filename542;
        /// <summary>input or output filename</summary>
        public byte @filename543;
        /// <summary>input or output filename</summary>
        public byte @filename544;
        /// <summary>input or output filename</summary>
        public byte @filename545;
        /// <summary>input or output filename</summary>
        public byte @filename546;
        /// <summary>input or output filename</summary>
        public byte @filename547;
        /// <summary>input or output filename</summary>
        public byte @filename548;
        /// <summary>input or output filename</summary>
        public byte @filename549;
        /// <summary>input or output filename</summary>
        public byte @filename550;
        /// <summary>input or output filename</summary>
        public byte @filename551;
        /// <summary>input or output filename</summary>
        public byte @filename552;
        /// <summary>input or output filename</summary>
        public byte @filename553;
        /// <summary>input or output filename</summary>
        public byte @filename554;
        /// <summary>input or output filename</summary>
        public byte @filename555;
        /// <summary>input or output filename</summary>
        public byte @filename556;
        /// <summary>input or output filename</summary>
        public byte @filename557;
        /// <summary>input or output filename</summary>
        public byte @filename558;
        /// <summary>input or output filename</summary>
        public byte @filename559;
        /// <summary>input or output filename</summary>
        public byte @filename560;
        /// <summary>input or output filename</summary>
        public byte @filename561;
        /// <summary>input or output filename</summary>
        public byte @filename562;
        /// <summary>input or output filename</summary>
        public byte @filename563;
        /// <summary>input or output filename</summary>
        public byte @filename564;
        /// <summary>input or output filename</summary>
        public byte @filename565;
        /// <summary>input or output filename</summary>
        public byte @filename566;
        /// <summary>input or output filename</summary>
        public byte @filename567;
        /// <summary>input or output filename</summary>
        public byte @filename568;
        /// <summary>input or output filename</summary>
        public byte @filename569;
        /// <summary>input or output filename</summary>
        public byte @filename570;
        /// <summary>input or output filename</summary>
        public byte @filename571;
        /// <summary>input or output filename</summary>
        public byte @filename572;
        /// <summary>input or output filename</summary>
        public byte @filename573;
        /// <summary>input or output filename</summary>
        public byte @filename574;
        /// <summary>input or output filename</summary>
        public byte @filename575;
        /// <summary>input or output filename</summary>
        public byte @filename576;
        /// <summary>input or output filename</summary>
        public byte @filename577;
        /// <summary>input or output filename</summary>
        public byte @filename578;
        /// <summary>input or output filename</summary>
        public byte @filename579;
        /// <summary>input or output filename</summary>
        public byte @filename580;
        /// <summary>input or output filename</summary>
        public byte @filename581;
        /// <summary>input or output filename</summary>
        public byte @filename582;
        /// <summary>input or output filename</summary>
        public byte @filename583;
        /// <summary>input or output filename</summary>
        public byte @filename584;
        /// <summary>input or output filename</summary>
        public byte @filename585;
        /// <summary>input or output filename</summary>
        public byte @filename586;
        /// <summary>input or output filename</summary>
        public byte @filename587;
        /// <summary>input or output filename</summary>
        public byte @filename588;
        /// <summary>input or output filename</summary>
        public byte @filename589;
        /// <summary>input or output filename</summary>
        public byte @filename590;
        /// <summary>input or output filename</summary>
        public byte @filename591;
        /// <summary>input or output filename</summary>
        public byte @filename592;
        /// <summary>input or output filename</summary>
        public byte @filename593;
        /// <summary>input or output filename</summary>
        public byte @filename594;
        /// <summary>input or output filename</summary>
        public byte @filename595;
        /// <summary>input or output filename</summary>
        public byte @filename596;
        /// <summary>input or output filename</summary>
        public byte @filename597;
        /// <summary>input or output filename</summary>
        public byte @filename598;
        /// <summary>input or output filename</summary>
        public byte @filename599;
        /// <summary>input or output filename</summary>
        public byte @filename600;
        /// <summary>input or output filename</summary>
        public byte @filename601;
        /// <summary>input or output filename</summary>
        public byte @filename602;
        /// <summary>input or output filename</summary>
        public byte @filename603;
        /// <summary>input or output filename</summary>
        public byte @filename604;
        /// <summary>input or output filename</summary>
        public byte @filename605;
        /// <summary>input or output filename</summary>
        public byte @filename606;
        /// <summary>input or output filename</summary>
        public byte @filename607;
        /// <summary>input or output filename</summary>
        public byte @filename608;
        /// <summary>input or output filename</summary>
        public byte @filename609;
        /// <summary>input or output filename</summary>
        public byte @filename610;
        /// <summary>input or output filename</summary>
        public byte @filename611;
        /// <summary>input or output filename</summary>
        public byte @filename612;
        /// <summary>input or output filename</summary>
        public byte @filename613;
        /// <summary>input or output filename</summary>
        public byte @filename614;
        /// <summary>input or output filename</summary>
        public byte @filename615;
        /// <summary>input or output filename</summary>
        public byte @filename616;
        /// <summary>input or output filename</summary>
        public byte @filename617;
        /// <summary>input or output filename</summary>
        public byte @filename618;
        /// <summary>input or output filename</summary>
        public byte @filename619;
        /// <summary>input or output filename</summary>
        public byte @filename620;
        /// <summary>input or output filename</summary>
        public byte @filename621;
        /// <summary>input or output filename</summary>
        public byte @filename622;
        /// <summary>input or output filename</summary>
        public byte @filename623;
        /// <summary>input or output filename</summary>
        public byte @filename624;
        /// <summary>input or output filename</summary>
        public byte @filename625;
        /// <summary>input or output filename</summary>
        public byte @filename626;
        /// <summary>input or output filename</summary>
        public byte @filename627;
        /// <summary>input or output filename</summary>
        public byte @filename628;
        /// <summary>input or output filename</summary>
        public byte @filename629;
        /// <summary>input or output filename</summary>
        public byte @filename630;
        /// <summary>input or output filename</summary>
        public byte @filename631;
        /// <summary>input or output filename</summary>
        public byte @filename632;
        /// <summary>input or output filename</summary>
        public byte @filename633;
        /// <summary>input or output filename</summary>
        public byte @filename634;
        /// <summary>input or output filename</summary>
        public byte @filename635;
        /// <summary>input or output filename</summary>
        public byte @filename636;
        /// <summary>input or output filename</summary>
        public byte @filename637;
        /// <summary>input or output filename</summary>
        public byte @filename638;
        /// <summary>input or output filename</summary>
        public byte @filename639;
        /// <summary>input or output filename</summary>
        public byte @filename640;
        /// <summary>input or output filename</summary>
        public byte @filename641;
        /// <summary>input or output filename</summary>
        public byte @filename642;
        /// <summary>input or output filename</summary>
        public byte @filename643;
        /// <summary>input or output filename</summary>
        public byte @filename644;
        /// <summary>input or output filename</summary>
        public byte @filename645;
        /// <summary>input or output filename</summary>
        public byte @filename646;
        /// <summary>input or output filename</summary>
        public byte @filename647;
        /// <summary>input or output filename</summary>
        public byte @filename648;
        /// <summary>input or output filename</summary>
        public byte @filename649;
        /// <summary>input or output filename</summary>
        public byte @filename650;
        /// <summary>input or output filename</summary>
        public byte @filename651;
        /// <summary>input or output filename</summary>
        public byte @filename652;
        /// <summary>input or output filename</summary>
        public byte @filename653;
        /// <summary>input or output filename</summary>
        public byte @filename654;
        /// <summary>input or output filename</summary>
        public byte @filename655;
        /// <summary>input or output filename</summary>
        public byte @filename656;
        /// <summary>input or output filename</summary>
        public byte @filename657;
        /// <summary>input or output filename</summary>
        public byte @filename658;
        /// <summary>input or output filename</summary>
        public byte @filename659;
        /// <summary>input or output filename</summary>
        public byte @filename660;
        /// <summary>input or output filename</summary>
        public byte @filename661;
        /// <summary>input or output filename</summary>
        public byte @filename662;
        /// <summary>input or output filename</summary>
        public byte @filename663;
        /// <summary>input or output filename</summary>
        public byte @filename664;
        /// <summary>input or output filename</summary>
        public byte @filename665;
        /// <summary>input or output filename</summary>
        public byte @filename666;
        /// <summary>input or output filename</summary>
        public byte @filename667;
        /// <summary>input or output filename</summary>
        public byte @filename668;
        /// <summary>input or output filename</summary>
        public byte @filename669;
        /// <summary>input or output filename</summary>
        public byte @filename670;
        /// <summary>input or output filename</summary>
        public byte @filename671;
        /// <summary>input or output filename</summary>
        public byte @filename672;
        /// <summary>input or output filename</summary>
        public byte @filename673;
        /// <summary>input or output filename</summary>
        public byte @filename674;
        /// <summary>input or output filename</summary>
        public byte @filename675;
        /// <summary>input or output filename</summary>
        public byte @filename676;
        /// <summary>input or output filename</summary>
        public byte @filename677;
        /// <summary>input or output filename</summary>
        public byte @filename678;
        /// <summary>input or output filename</summary>
        public byte @filename679;
        /// <summary>input or output filename</summary>
        public byte @filename680;
        /// <summary>input or output filename</summary>
        public byte @filename681;
        /// <summary>input or output filename</summary>
        public byte @filename682;
        /// <summary>input or output filename</summary>
        public byte @filename683;
        /// <summary>input or output filename</summary>
        public byte @filename684;
        /// <summary>input or output filename</summary>
        public byte @filename685;
        /// <summary>input or output filename</summary>
        public byte @filename686;
        /// <summary>input or output filename</summary>
        public byte @filename687;
        /// <summary>input or output filename</summary>
        public byte @filename688;
        /// <summary>input or output filename</summary>
        public byte @filename689;
        /// <summary>input or output filename</summary>
        public byte @filename690;
        /// <summary>input or output filename</summary>
        public byte @filename691;
        /// <summary>input or output filename</summary>
        public byte @filename692;
        /// <summary>input or output filename</summary>
        public byte @filename693;
        /// <summary>input or output filename</summary>
        public byte @filename694;
        /// <summary>input or output filename</summary>
        public byte @filename695;
        /// <summary>input or output filename</summary>
        public byte @filename696;
        /// <summary>input or output filename</summary>
        public byte @filename697;
        /// <summary>input or output filename</summary>
        public byte @filename698;
        /// <summary>input or output filename</summary>
        public byte @filename699;
        /// <summary>input or output filename</summary>
        public byte @filename700;
        /// <summary>input or output filename</summary>
        public byte @filename701;
        /// <summary>input or output filename</summary>
        public byte @filename702;
        /// <summary>input or output filename</summary>
        public byte @filename703;
        /// <summary>input or output filename</summary>
        public byte @filename704;
        /// <summary>input or output filename</summary>
        public byte @filename705;
        /// <summary>input or output filename</summary>
        public byte @filename706;
        /// <summary>input or output filename</summary>
        public byte @filename707;
        /// <summary>input or output filename</summary>
        public byte @filename708;
        /// <summary>input or output filename</summary>
        public byte @filename709;
        /// <summary>input or output filename</summary>
        public byte @filename710;
        /// <summary>input or output filename</summary>
        public byte @filename711;
        /// <summary>input or output filename</summary>
        public byte @filename712;
        /// <summary>input or output filename</summary>
        public byte @filename713;
        /// <summary>input or output filename</summary>
        public byte @filename714;
        /// <summary>input or output filename</summary>
        public byte @filename715;
        /// <summary>input or output filename</summary>
        public byte @filename716;
        /// <summary>input or output filename</summary>
        public byte @filename717;
        /// <summary>input or output filename</summary>
        public byte @filename718;
        /// <summary>input or output filename</summary>
        public byte @filename719;
        /// <summary>input or output filename</summary>
        public byte @filename720;
        /// <summary>input or output filename</summary>
        public byte @filename721;
        /// <summary>input or output filename</summary>
        public byte @filename722;
        /// <summary>input or output filename</summary>
        public byte @filename723;
        /// <summary>input or output filename</summary>
        public byte @filename724;
        /// <summary>input or output filename</summary>
        public byte @filename725;
        /// <summary>input or output filename</summary>
        public byte @filename726;
        /// <summary>input or output filename</summary>
        public byte @filename727;
        /// <summary>input or output filename</summary>
        public byte @filename728;
        /// <summary>input or output filename</summary>
        public byte @filename729;
        /// <summary>input or output filename</summary>
        public byte @filename730;
        /// <summary>input or output filename</summary>
        public byte @filename731;
        /// <summary>input or output filename</summary>
        public byte @filename732;
        /// <summary>input or output filename</summary>
        public byte @filename733;
        /// <summary>input or output filename</summary>
        public byte @filename734;
        /// <summary>input or output filename</summary>
        public byte @filename735;
        /// <summary>input or output filename</summary>
        public byte @filename736;
        /// <summary>input or output filename</summary>
        public byte @filename737;
        /// <summary>input or output filename</summary>
        public byte @filename738;
        /// <summary>input or output filename</summary>
        public byte @filename739;
        /// <summary>input or output filename</summary>
        public byte @filename740;
        /// <summary>input or output filename</summary>
        public byte @filename741;
        /// <summary>input or output filename</summary>
        public byte @filename742;
        /// <summary>input or output filename</summary>
        public byte @filename743;
        /// <summary>input or output filename</summary>
        public byte @filename744;
        /// <summary>input or output filename</summary>
        public byte @filename745;
        /// <summary>input or output filename</summary>
        public byte @filename746;
        /// <summary>input or output filename</summary>
        public byte @filename747;
        /// <summary>input or output filename</summary>
        public byte @filename748;
        /// <summary>input or output filename</summary>
        public byte @filename749;
        /// <summary>input or output filename</summary>
        public byte @filename750;
        /// <summary>input or output filename</summary>
        public byte @filename751;
        /// <summary>input or output filename</summary>
        public byte @filename752;
        /// <summary>input or output filename</summary>
        public byte @filename753;
        /// <summary>input or output filename</summary>
        public byte @filename754;
        /// <summary>input or output filename</summary>
        public byte @filename755;
        /// <summary>input or output filename</summary>
        public byte @filename756;
        /// <summary>input or output filename</summary>
        public byte @filename757;
        /// <summary>input or output filename</summary>
        public byte @filename758;
        /// <summary>input or output filename</summary>
        public byte @filename759;
        /// <summary>input or output filename</summary>
        public byte @filename760;
        /// <summary>input or output filename</summary>
        public byte @filename761;
        /// <summary>input or output filename</summary>
        public byte @filename762;
        /// <summary>input or output filename</summary>
        public byte @filename763;
        /// <summary>input or output filename</summary>
        public byte @filename764;
        /// <summary>input or output filename</summary>
        public byte @filename765;
        /// <summary>input or output filename</summary>
        public byte @filename766;
        /// <summary>input or output filename</summary>
        public byte @filename767;
        /// <summary>input or output filename</summary>
        public byte @filename768;
        /// <summary>input or output filename</summary>
        public byte @filename769;
        /// <summary>input or output filename</summary>
        public byte @filename770;
        /// <summary>input or output filename</summary>
        public byte @filename771;
        /// <summary>input or output filename</summary>
        public byte @filename772;
        /// <summary>input or output filename</summary>
        public byte @filename773;
        /// <summary>input or output filename</summary>
        public byte @filename774;
        /// <summary>input or output filename</summary>
        public byte @filename775;
        /// <summary>input or output filename</summary>
        public byte @filename776;
        /// <summary>input or output filename</summary>
        public byte @filename777;
        /// <summary>input or output filename</summary>
        public byte @filename778;
        /// <summary>input or output filename</summary>
        public byte @filename779;
        /// <summary>input or output filename</summary>
        public byte @filename780;
        /// <summary>input or output filename</summary>
        public byte @filename781;
        /// <summary>input or output filename</summary>
        public byte @filename782;
        /// <summary>input or output filename</summary>
        public byte @filename783;
        /// <summary>input or output filename</summary>
        public byte @filename784;
        /// <summary>input or output filename</summary>
        public byte @filename785;
        /// <summary>input or output filename</summary>
        public byte @filename786;
        /// <summary>input or output filename</summary>
        public byte @filename787;
        /// <summary>input or output filename</summary>
        public byte @filename788;
        /// <summary>input or output filename</summary>
        public byte @filename789;
        /// <summary>input or output filename</summary>
        public byte @filename790;
        /// <summary>input or output filename</summary>
        public byte @filename791;
        /// <summary>input or output filename</summary>
        public byte @filename792;
        /// <summary>input or output filename</summary>
        public byte @filename793;
        /// <summary>input or output filename</summary>
        public byte @filename794;
        /// <summary>input or output filename</summary>
        public byte @filename795;
        /// <summary>input or output filename</summary>
        public byte @filename796;
        /// <summary>input or output filename</summary>
        public byte @filename797;
        /// <summary>input or output filename</summary>
        public byte @filename798;
        /// <summary>input or output filename</summary>
        public byte @filename799;
        /// <summary>input or output filename</summary>
        public byte @filename800;
        /// <summary>input or output filename</summary>
        public byte @filename801;
        /// <summary>input or output filename</summary>
        public byte @filename802;
        /// <summary>input or output filename</summary>
        public byte @filename803;
        /// <summary>input or output filename</summary>
        public byte @filename804;
        /// <summary>input or output filename</summary>
        public byte @filename805;
        /// <summary>input or output filename</summary>
        public byte @filename806;
        /// <summary>input or output filename</summary>
        public byte @filename807;
        /// <summary>input or output filename</summary>
        public byte @filename808;
        /// <summary>input or output filename</summary>
        public byte @filename809;
        /// <summary>input or output filename</summary>
        public byte @filename810;
        /// <summary>input or output filename</summary>
        public byte @filename811;
        /// <summary>input or output filename</summary>
        public byte @filename812;
        /// <summary>input or output filename</summary>
        public byte @filename813;
        /// <summary>input or output filename</summary>
        public byte @filename814;
        /// <summary>input or output filename</summary>
        public byte @filename815;
        /// <summary>input or output filename</summary>
        public byte @filename816;
        /// <summary>input or output filename</summary>
        public byte @filename817;
        /// <summary>input or output filename</summary>
        public byte @filename818;
        /// <summary>input or output filename</summary>
        public byte @filename819;
        /// <summary>input or output filename</summary>
        public byte @filename820;
        /// <summary>input or output filename</summary>
        public byte @filename821;
        /// <summary>input or output filename</summary>
        public byte @filename822;
        /// <summary>input or output filename</summary>
        public byte @filename823;
        /// <summary>input or output filename</summary>
        public byte @filename824;
        /// <summary>input or output filename</summary>
        public byte @filename825;
        /// <summary>input or output filename</summary>
        public byte @filename826;
        /// <summary>input or output filename</summary>
        public byte @filename827;
        /// <summary>input or output filename</summary>
        public byte @filename828;
        /// <summary>input or output filename</summary>
        public byte @filename829;
        /// <summary>input or output filename</summary>
        public byte @filename830;
        /// <summary>input or output filename</summary>
        public byte @filename831;
        /// <summary>input or output filename</summary>
        public byte @filename832;
        /// <summary>input or output filename</summary>
        public byte @filename833;
        /// <summary>input or output filename</summary>
        public byte @filename834;
        /// <summary>input or output filename</summary>
        public byte @filename835;
        /// <summary>input or output filename</summary>
        public byte @filename836;
        /// <summary>input or output filename</summary>
        public byte @filename837;
        /// <summary>input or output filename</summary>
        public byte @filename838;
        /// <summary>input or output filename</summary>
        public byte @filename839;
        /// <summary>input or output filename</summary>
        public byte @filename840;
        /// <summary>input or output filename</summary>
        public byte @filename841;
        /// <summary>input or output filename</summary>
        public byte @filename842;
        /// <summary>input or output filename</summary>
        public byte @filename843;
        /// <summary>input or output filename</summary>
        public byte @filename844;
        /// <summary>input or output filename</summary>
        public byte @filename845;
        /// <summary>input or output filename</summary>
        public byte @filename846;
        /// <summary>input or output filename</summary>
        public byte @filename847;
        /// <summary>input or output filename</summary>
        public byte @filename848;
        /// <summary>input or output filename</summary>
        public byte @filename849;
        /// <summary>input or output filename</summary>
        public byte @filename850;
        /// <summary>input or output filename</summary>
        public byte @filename851;
        /// <summary>input or output filename</summary>
        public byte @filename852;
        /// <summary>input or output filename</summary>
        public byte @filename853;
        /// <summary>input or output filename</summary>
        public byte @filename854;
        /// <summary>input or output filename</summary>
        public byte @filename855;
        /// <summary>input or output filename</summary>
        public byte @filename856;
        /// <summary>input or output filename</summary>
        public byte @filename857;
        /// <summary>input or output filename</summary>
        public byte @filename858;
        /// <summary>input or output filename</summary>
        public byte @filename859;
        /// <summary>input or output filename</summary>
        public byte @filename860;
        /// <summary>input or output filename</summary>
        public byte @filename861;
        /// <summary>input or output filename</summary>
        public byte @filename862;
        /// <summary>input or output filename</summary>
        public byte @filename863;
        /// <summary>input or output filename</summary>
        public byte @filename864;
        /// <summary>input or output filename</summary>
        public byte @filename865;
        /// <summary>input or output filename</summary>
        public byte @filename866;
        /// <summary>input or output filename</summary>
        public byte @filename867;
        /// <summary>input or output filename</summary>
        public byte @filename868;
        /// <summary>input or output filename</summary>
        public byte @filename869;
        /// <summary>input or output filename</summary>
        public byte @filename870;
        /// <summary>input or output filename</summary>
        public byte @filename871;
        /// <summary>input or output filename</summary>
        public byte @filename872;
        /// <summary>input or output filename</summary>
        public byte @filename873;
        /// <summary>input or output filename</summary>
        public byte @filename874;
        /// <summary>input or output filename</summary>
        public byte @filename875;
        /// <summary>input or output filename</summary>
        public byte @filename876;
        /// <summary>input or output filename</summary>
        public byte @filename877;
        /// <summary>input or output filename</summary>
        public byte @filename878;
        /// <summary>input or output filename</summary>
        public byte @filename879;
        /// <summary>input or output filename</summary>
        public byte @filename880;
        /// <summary>input or output filename</summary>
        public byte @filename881;
        /// <summary>input or output filename</summary>
        public byte @filename882;
        /// <summary>input or output filename</summary>
        public byte @filename883;
        /// <summary>input or output filename</summary>
        public byte @filename884;
        /// <summary>input or output filename</summary>
        public byte @filename885;
        /// <summary>input or output filename</summary>
        public byte @filename886;
        /// <summary>input or output filename</summary>
        public byte @filename887;
        /// <summary>input or output filename</summary>
        public byte @filename888;
        /// <summary>input or output filename</summary>
        public byte @filename889;
        /// <summary>input or output filename</summary>
        public byte @filename890;
        /// <summary>input or output filename</summary>
        public byte @filename891;
        /// <summary>input or output filename</summary>
        public byte @filename892;
        /// <summary>input or output filename</summary>
        public byte @filename893;
        /// <summary>input or output filename</summary>
        public byte @filename894;
        /// <summary>input or output filename</summary>
        public byte @filename895;
        /// <summary>input or output filename</summary>
        public byte @filename896;
        /// <summary>input or output filename</summary>
        public byte @filename897;
        /// <summary>input or output filename</summary>
        public byte @filename898;
        /// <summary>input or output filename</summary>
        public byte @filename899;
        /// <summary>input or output filename</summary>
        public byte @filename900;
        /// <summary>input or output filename</summary>
        public byte @filename901;
        /// <summary>input or output filename</summary>
        public byte @filename902;
        /// <summary>input or output filename</summary>
        public byte @filename903;
        /// <summary>input or output filename</summary>
        public byte @filename904;
        /// <summary>input or output filename</summary>
        public byte @filename905;
        /// <summary>input or output filename</summary>
        public byte @filename906;
        /// <summary>input or output filename</summary>
        public byte @filename907;
        /// <summary>input or output filename</summary>
        public byte @filename908;
        /// <summary>input or output filename</summary>
        public byte @filename909;
        /// <summary>input or output filename</summary>
        public byte @filename910;
        /// <summary>input or output filename</summary>
        public byte @filename911;
        /// <summary>input or output filename</summary>
        public byte @filename912;
        /// <summary>input or output filename</summary>
        public byte @filename913;
        /// <summary>input or output filename</summary>
        public byte @filename914;
        /// <summary>input or output filename</summary>
        public byte @filename915;
        /// <summary>input or output filename</summary>
        public byte @filename916;
        /// <summary>input or output filename</summary>
        public byte @filename917;
        /// <summary>input or output filename</summary>
        public byte @filename918;
        /// <summary>input or output filename</summary>
        public byte @filename919;
        /// <summary>input or output filename</summary>
        public byte @filename920;
        /// <summary>input or output filename</summary>
        public byte @filename921;
        /// <summary>input or output filename</summary>
        public byte @filename922;
        /// <summary>input or output filename</summary>
        public byte @filename923;
        /// <summary>input or output filename</summary>
        public byte @filename924;
        /// <summary>input or output filename</summary>
        public byte @filename925;
        /// <summary>input or output filename</summary>
        public byte @filename926;
        /// <summary>input or output filename</summary>
        public byte @filename927;
        /// <summary>input or output filename</summary>
        public byte @filename928;
        /// <summary>input or output filename</summary>
        public byte @filename929;
        /// <summary>input or output filename</summary>
        public byte @filename930;
        /// <summary>input or output filename</summary>
        public byte @filename931;
        /// <summary>input or output filename</summary>
        public byte @filename932;
        /// <summary>input or output filename</summary>
        public byte @filename933;
        /// <summary>input or output filename</summary>
        public byte @filename934;
        /// <summary>input or output filename</summary>
        public byte @filename935;
        /// <summary>input or output filename</summary>
        public byte @filename936;
        /// <summary>input or output filename</summary>
        public byte @filename937;
        /// <summary>input or output filename</summary>
        public byte @filename938;
        /// <summary>input or output filename</summary>
        public byte @filename939;
        /// <summary>input or output filename</summary>
        public byte @filename940;
        /// <summary>input or output filename</summary>
        public byte @filename941;
        /// <summary>input or output filename</summary>
        public byte @filename942;
        /// <summary>input or output filename</summary>
        public byte @filename943;
        /// <summary>input or output filename</summary>
        public byte @filename944;
        /// <summary>input or output filename</summary>
        public byte @filename945;
        /// <summary>input or output filename</summary>
        public byte @filename946;
        /// <summary>input or output filename</summary>
        public byte @filename947;
        /// <summary>input or output filename</summary>
        public byte @filename948;
        /// <summary>input or output filename</summary>
        public byte @filename949;
        /// <summary>input or output filename</summary>
        public byte @filename950;
        /// <summary>input or output filename</summary>
        public byte @filename951;
        /// <summary>input or output filename</summary>
        public byte @filename952;
        /// <summary>input or output filename</summary>
        public byte @filename953;
        /// <summary>input or output filename</summary>
        public byte @filename954;
        /// <summary>input or output filename</summary>
        public byte @filename955;
        /// <summary>input or output filename</summary>
        public byte @filename956;
        /// <summary>input or output filename</summary>
        public byte @filename957;
        /// <summary>input or output filename</summary>
        public byte @filename958;
        /// <summary>input or output filename</summary>
        public byte @filename959;
        /// <summary>input or output filename</summary>
        public byte @filename960;
        /// <summary>input or output filename</summary>
        public byte @filename961;
        /// <summary>input or output filename</summary>
        public byte @filename962;
        /// <summary>input or output filename</summary>
        public byte @filename963;
        /// <summary>input or output filename</summary>
        public byte @filename964;
        /// <summary>input or output filename</summary>
        public byte @filename965;
        /// <summary>input or output filename</summary>
        public byte @filename966;
        /// <summary>input or output filename</summary>
        public byte @filename967;
        /// <summary>input or output filename</summary>
        public byte @filename968;
        /// <summary>input or output filename</summary>
        public byte @filename969;
        /// <summary>input or output filename</summary>
        public byte @filename970;
        /// <summary>input or output filename</summary>
        public byte @filename971;
        /// <summary>input or output filename</summary>
        public byte @filename972;
        /// <summary>input or output filename</summary>
        public byte @filename973;
        /// <summary>input or output filename</summary>
        public byte @filename974;
        /// <summary>input or output filename</summary>
        public byte @filename975;
        /// <summary>input or output filename</summary>
        public byte @filename976;
        /// <summary>input or output filename</summary>
        public byte @filename977;
        /// <summary>input or output filename</summary>
        public byte @filename978;
        /// <summary>input or output filename</summary>
        public byte @filename979;
        /// <summary>input or output filename</summary>
        public byte @filename980;
        /// <summary>input or output filename</summary>
        public byte @filename981;
        /// <summary>input or output filename</summary>
        public byte @filename982;
        /// <summary>input or output filename</summary>
        public byte @filename983;
        /// <summary>input or output filename</summary>
        public byte @filename984;
        /// <summary>input or output filename</summary>
        public byte @filename985;
        /// <summary>input or output filename</summary>
        public byte @filename986;
        /// <summary>input or output filename</summary>
        public byte @filename987;
        /// <summary>input or output filename</summary>
        public byte @filename988;
        /// <summary>input or output filename</summary>
        public byte @filename989;
        /// <summary>input or output filename</summary>
        public byte @filename990;
        /// <summary>input or output filename</summary>
        public byte @filename991;
        /// <summary>input or output filename</summary>
        public byte @filename992;
        /// <summary>input or output filename</summary>
        public byte @filename993;
        /// <summary>input or output filename</summary>
        public byte @filename994;
        /// <summary>input or output filename</summary>
        public byte @filename995;
        /// <summary>input or output filename</summary>
        public byte @filename996;
        /// <summary>input or output filename</summary>
        public byte @filename997;
        /// <summary>input or output filename</summary>
        public byte @filename998;
        /// <summary>input or output filename</summary>
        public byte @filename999;
        /// <summary>input or output filename</summary>
        public byte @filename1000;
        /// <summary>input or output filename</summary>
        public byte @filename1001;
        /// <summary>input or output filename</summary>
        public byte @filename1002;
        /// <summary>input or output filename</summary>
        public byte @filename1003;
        /// <summary>input or output filename</summary>
        public byte @filename1004;
        /// <summary>input or output filename</summary>
        public byte @filename1005;
        /// <summary>input or output filename</summary>
        public byte @filename1006;
        /// <summary>input or output filename</summary>
        public byte @filename1007;
        /// <summary>input or output filename</summary>
        public byte @filename1008;
        /// <summary>input or output filename</summary>
        public byte @filename1009;
        /// <summary>input or output filename</summary>
        public byte @filename1010;
        /// <summary>input or output filename</summary>
        public byte @filename1011;
        /// <summary>input or output filename</summary>
        public byte @filename1012;
        /// <summary>input or output filename</summary>
        public byte @filename1013;
        /// <summary>input or output filename</summary>
        public byte @filename1014;
        /// <summary>input or output filename</summary>
        public byte @filename1015;
        /// <summary>input or output filename</summary>
        public byte @filename1016;
        /// <summary>input or output filename</summary>
        public byte @filename1017;
        /// <summary>input or output filename</summary>
        public byte @filename1018;
        /// <summary>input or output filename</summary>
        public byte @filename1019;
        /// <summary>input or output filename</summary>
        public byte @filename1020;
        /// <summary>input or output filename</summary>
        public byte @filename1021;
        /// <summary>input or output filename</summary>
        public byte @filename1022;
        /// <summary>input or output filename</summary>
        public byte @filename1023;
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
        public IntPtr @open_cb;
        /// <summary>',' separated list of allowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @protocol_whitelist;
        public IntPtr @io_open;
        /// <summary>A callback for closing the streams opened with AVFormatContext.io_open().</summary>
        public IntPtr @io_close;
        /// <summary>',' separated list of disallowed protocols. - encoding: unused - decoding: set by user through AVOptions (NO direct access)</summary>
        public byte* @protocol_blacklist;
    }
    
    public unsafe struct AVPacketList
    {
        public AVPacket @pkt;
        public IntPtr @next;
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
        public IntPtr @execute;
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
    
    /// <summary>Structure describes basic parameters of the device.</summary>
    public unsafe struct AVDeviceInfo
    {
        /// <summary>device name, format depends on device</summary>
        public byte* @device_name;
        /// <summary>human friendly name</summary>
        public byte* @device_description;
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
        
        /// <summary>Return the LIBPOSTPROC_VERSION_INT constant.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint postproc_version();
        
        /// <summary>Return the libpostproc build-time configuration.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string postproc_configuration();
        
        /// <summary>Return the libpostproc license.</summary>
        [DllImport("postproc-54", EntryPoint = "postproc_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string postproc_license();
        
        [DllImport("postproc-54", EntryPoint = "pp_postprocess", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_postprocess(byte*[] @src, int[] @srcStride, byte*[] @dst, int[] @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        
        /// <summary>Return a pp_mode or NULL if an error occurred.</summary>
        /// <param name="name">the string after "-pp" on the command line</param>
        /// <param name="quality">a number from 0 to PP_QUALITY_MAX</param>
        [DllImport("postproc-54", EntryPoint = "pp_get_mode_by_name_and_quality", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* pp_get_mode_by_name_and_quality([MarshalAs(UnmanagedType.LPStr)] string @name, int @quality);
        
        [DllImport("postproc-54", EntryPoint = "pp_free_mode", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_free_mode(void* @mode);
        
        [DllImport("postproc-54", EntryPoint = "pp_get_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* pp_get_context(int @width, int @height, int @flags);
        
        [DllImport("postproc-54", EntryPoint = "pp_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void pp_free_context(void* @ppContext);
        
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
        public static extern int sws_setColorspaceDetails(IntPtr @c, int[] @inv_table, int @srcRange, int[] @table, int @dstRange, int @brightness, int @contrast, int @saturation);
        
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
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_codec_get_pkt_timebase(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_set_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_codec_set_pkt_timebase(AVCodecContext* @avctx, AVRational @val);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_set_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_codec_set_codec_descriptor(AVCodecContext* @avctx, AVCodecDescriptor* @desc);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_codec_properties", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_codec_get_codec_properties(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_get_lowres(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_set_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_codec_set_lowres(AVCodecContext* @avctx, int @val);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_seek_preroll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_get_seek_preroll(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_set_seek_preroll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_codec_set_seek_preroll(AVCodecContext* @avctx, int @val);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ushort* av_codec_get_chroma_intra_matrix(AVCodecContext* @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_set_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_codec_set_chroma_intra_matrix(AVCodecContext* @avctx, ushort* @val);
        
        [DllImport("avcodec-57", EntryPoint = "av_codec_get_max_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_get_max_lowres(AVCodec* @codec);
        
        /// <summary>If c is NULL, returns the first registered codec, if c is non-NULL, returns the next registered codec after c, or NULL if c is the last one.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_codec_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* av_codec_next(AVCodec* @c);
        
        /// <summary>Return the LIBAVCODEC_VERSION_INT constant.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avcodec_version();
        
        /// <summary>Return the libavcodec build-time configuration.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avcodec_configuration();
        
        /// <summary>Return the libavcodec license.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avcodec_license();
        
        /// <summary>Register the codec codec and initialize libavcodec.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_register(AVCodec* @codec);
        
        /// <summary>Register all the codecs, parsers and bitstream filters which were enabled at configuration time. If you do not call this function you can select exactly which formats you want to support, by using the individual registration functions.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_register_all();
        
        /// <summary>Allocate an AVCodecContext and set its fields to default values. The resulting struct should be freed with avcodec_free_context().</summary>
        /// <param name="codec">if non-NULL, allocate private data and initialize defaults for the given codec. It is illegal to then call avcodec_open2() with a different codec. If NULL, then the codec-specific defaults won't be initialized, which may result in suboptimal default settings (this is important mainly for encoders, e.g. libx264).</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_alloc_context3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* @codec);
        
        /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_free_context(AVCodecContext** @avctx);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_context_defaults3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_get_context_defaults3(AVCodecContext* @s, AVCodec* @codec);
        
        /// <summary>Get the AVClass for AVCodecContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* avcodec_get_class();
        
        /// <summary>Get the AVClass for AVFrame. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_frame_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* avcodec_get_frame_class();
        
        /// <summary>Get the AVClass for AVSubtitleRect. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_subtitle_rect_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* avcodec_get_subtitle_rect_class();
        
        /// <summary>Copy the settings of the source AVCodecContext into the destination AVCodecContext. The resulting destination codec context will be unopened, i.e. you are required to call avcodec_open2() before you can use this AVCodecContext to decode/encode video/audio data.</summary>
        /// <param name="dest">target codec context, should be initialized with avcodec_alloc_context3(NULL), but otherwise uninitialized</param>
        /// <param name="src">source codec context</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_copy_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_copy_context(AVCodecContext* @dest, AVCodecContext* @src);
        
        /// <summary>Allocate a new AVCodecParameters and set its fields to default values (unknown/invalid/0). The returned struct must be freed with avcodec_parameters_free().</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_parameters_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecParameters* avcodec_parameters_alloc();
        
        /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_parameters_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_parameters_free(AVCodecParameters** @par);
        
        /// <summary>Copy the contents of src to dst. Any allocated fields in dst are freed and replaced with newly allocated duplicates of the corresponding fields in src.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_parameters_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src);
        
        /// <summary>Fill the parameters struct based on the values from the supplied codec context. Any allocated fields in par are freed and replaced with duplicates of the corresponding fields in codec.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_parameters_from_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec);
        
        /// <summary>Fill the codec context based on the values from the supplied codec parameters. Any allocated fields in codec that have a corresponding field in par are freed and replaced with duplicates of the corresponding field in par. Fields in codec that do not have a counterpart in par are not touched.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_parameters_to_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par);
        
        /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
        /// <param name="avctx">The context to initialize.</param>
        /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
        /// <param name="options">A dictionary filled with AVCodecContext and codec-private options. On return this object will be filled with options that were not found.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
        
        /// <summary>Close a given AVCodecContext and free all the data associated with it (but not the AVCodecContext itself).</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_close(AVCodecContext* @avctx);
        
        /// <summary>Free all allocated data in the given subtitle struct.</summary>
        /// <param name="sub">AVSubtitle to free.</param>
        [DllImport("avcodec-57", EntryPoint = "avsubtitle_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avsubtitle_free(AVSubtitle* @sub);
        
        /// <summary>Allocate an AVPacket and set its fields to default values. The resulting struct must be freed using av_packet_free().</summary>
        [DllImport("avcodec-57", EntryPoint = "av_packet_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPacket* av_packet_alloc();
        
        /// <summary>Create a new packet that references the same data as src.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_packet_clone", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPacket* av_packet_clone(AVPacket* @src);
        
        /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_packet_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_packet_free(AVPacket** @pkt);
        
        /// <summary>Initialize optional fields of a packet with default values.</summary>
        /// <param name="pkt">packet</param>
        [DllImport("avcodec-57", EntryPoint = "av_init_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_init_packet(AVPacket* @pkt);
        
        /// <summary>Allocate the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">wanted payload size</param>
        [DllImport("avcodec-57", EntryPoint = "av_new_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_new_packet(AVPacket* @pkt, int @size);
        
        /// <summary>Reduce packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">new size</param>
        [DllImport("avcodec-57", EntryPoint = "av_shrink_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_shrink_packet(AVPacket* @pkt, int @size);
        
        /// <summary>Increase packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="grow_by">number of bytes by which to increase the size of the packet</param>
        [DllImport("avcodec-57", EntryPoint = "av_grow_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_grow_packet(AVPacket* @pkt, int @grow_by);
        
        /// <summary>Initialize a reference-counted packet from av_malloc()ed data.</summary>
        /// <param name="pkt">packet to be initialized. This function will set the data, size, buf and destruct fields, all others are left untouched.</param>
        /// <param name="data">Data allocated by av_malloc() to be used as packet data. If this function returns successfully, the data is owned by the underlying AVBuffer. The caller may not access the data through other means.</param>
        /// <param name="size">size of data in bytes, without the padding. I.e. the full buffer size is assumed to be size + AV_INPUT_BUFFER_PADDING_SIZE.</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_from_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size);
        
        [DllImport("avcodec-57", EntryPoint = "av_dup_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dup_packet(AVPacket* @pkt);
        
        /// <summary>Copy packet, including contents</summary>
        [DllImport("avcodec-57", EntryPoint = "av_copy_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_copy_packet(AVPacket* @dst, AVPacket* @src);
        
        /// <summary>Copy packet side data</summary>
        [DllImport("avcodec-57", EntryPoint = "av_copy_packet_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_copy_packet_side_data(AVPacket* @dst, AVPacket* @src);
        
        /// <summary>Free a packet.</summary>
        /// <param name="pkt">packet to free</param>
        [DllImport("avcodec-57", EntryPoint = "av_free_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_free_packet(AVPacket* @pkt);
        
        /// <summary>Allocate new information of a packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">side information size</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        /// <summary>Wrap an existing array as a packet side data.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to pkt.</param>
        /// <param name="size">side information size</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_add_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
        
        /// <summary>Shrink the already allocated side data buffer</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">new side information size</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_shrink_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        /// <summary>Get side information from packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">pointer for side information size to store (optional)</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int* @size);
        
        [DllImport("avcodec-57", EntryPoint = "av_packet_merge_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_merge_side_data(AVPacket* @pkt);
        
        [DllImport("avcodec-57", EntryPoint = "av_packet_split_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_split_side_data(AVPacket* @pkt);
        
        [DllImport("avcodec-57", EntryPoint = "av_packet_side_data_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_packet_side_data_name(AVPacketSideDataType @type);
        
        /// <summary>Pack a dictionary for use in side_data.</summary>
        /// <param name="dict">The dictionary to pack.</param>
        /// <param name="size">pointer to store the size of the returned data</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_pack_dictionary", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_packet_pack_dictionary(AVDictionary* @dict, int* @size);
        
        /// <summary>Unpack a dictionary from side_data.</summary>
        /// <param name="data">data from side_data</param>
        /// <param name="size">size of the data</param>
        /// <param name="dict">the metadata storage dictionary</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_unpack_dictionary", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_unpack_dictionary(byte* @data, int @size, AVDictionary** @dict);
        
        /// <summary>Convenience function to free all the side data stored. All the other fields stay untouched.</summary>
        /// <param name="pkt">packet</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_free_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_packet_free_side_data(AVPacket* @pkt);
        
        /// <summary>Setup a new reference to the data described by a given packet</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_ref(AVPacket* @dst, AVPacket* @src);
        
        /// <summary>Wipe the packet.</summary>
        /// <param name="pkt">The packet to be unreferenced.</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_packet_unref(AVPacket* @pkt);
        
        /// <summary>Move every field in src to dst and reset src.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet, will be reset</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_move_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_packet_move_ref(AVPacket* @dst, AVPacket* @src);
        
        /// <summary>Copy only "properties" fields from src to dst.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_copy_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_packet_copy_props(AVPacket* @dst, AVPacket* @src);
        
        /// <summary>Convert valid timing fields (timestamps / durations) in a packet from one timebase to another. Timestamps with unknown values (AV_NOPTS_VALUE) will be ignored.</summary>
        /// <param name="pkt">packet on which the conversion will be performed</param>
        /// <param name="tb_src">source timebase, in which the timing fields in pkt are expressed</param>
        /// <param name="tb_dst">destination timebase, to which the timing fields will be converted</param>
        [DllImport("avcodec-57", EntryPoint = "av_packet_rescale_ts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
        
        /// <summary>Find a registered decoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested decoder</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* avcodec_find_decoder(AVCodecID @id);
        
        /// <summary>Find a registered decoder with the specified name.</summary>
        /// <param name="name">name of the requested decoder</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_decoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* avcodec_find_decoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>The default callback for AVCodecContext.get_buffer2(). It is made public so it can be called by custom get_buffer2() implementations for decoders without AV_CODEC_CAP_DR1 set.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_default_get_buffer2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags);
        
        /// <summary>Return the amount of padding in pixels which the get_buffer callback must provide around the edge of the image for codecs which do not have the CODEC_FLAG_EMU_EDGE flag.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_edge_width", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avcodec_get_edge_width();
        
        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you do not use any horizontal padding.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_align_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height);
        
        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you also ensure that all line sizes are a multiple of the respective linesize_align[i].</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_align_dimensions2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, int[] @linesize_align);
        
        /// <summary>Converts AVChromaLocation to swscale x/y chroma position.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_enum_to_chroma_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_enum_to_chroma_pos(int* @xpos, int* @ypos, AVChromaLocation @pos);
        
        /// <summary>Converts swscale x/y chroma position to AVChromaLocation.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_chroma_pos_to_enum", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVChromaLocation avcodec_chroma_pos_to_enum(int @xpos, int @ypos);
        
        /// <summary>Decode the audio frame of size avpkt->size from avpkt->data into frame.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="frame">The AVFrame in which to store decoded audio samples. The decoder will allocate a buffer for the decoded frame by calling the AVCodecContext.get_buffer2() callback. When AVCodecContext.refcounted_frames is set to 1, the frame is reference counted and the returned reference belongs to the caller. The caller must release the frame using av_frame_unref() when the frame is no longer needed. The caller may safely write to the frame if av_frame_is_writable() returns 1. When AVCodecContext.refcounted_frames is set to 0, the returned reference belongs to the decoder and is valid only until the next call to this function or until closing or flushing the decoder. The caller may not write to it.</param>
        /// <param name="got_frame_ptr">Zero if no frame could be decoded, otherwise it is non-zero. Note that this field being set to zero does not mean that an error has occurred. For decoders with AV_CODEC_CAP_DELAY set, no given decode call is guaranteed to produce a frame.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer. At least avpkt->data and avpkt->size should be set. Some decoders might also require additional fields to be set.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_decode_audio4", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_decode_audio4(AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt);
        
        /// <summary>Decode the video frame of size avpkt->size from avpkt->data into picture. Some decoders may support multiple frames in a single AVPacket, such decoders would then just decode the first frame.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="picture">The AVFrame in which the decoded video frame will be stored. Use av_frame_alloc() to get an AVFrame. The codec will allocate memory for the actual bitmap by calling the AVCodecContext.get_buffer2() callback. When AVCodecContext.refcounted_frames is set to 1, the frame is reference counted and the returned reference belongs to the caller. The caller must release the frame using av_frame_unref() when the frame is no longer needed. The caller may safely write to the frame if av_frame_is_writable() returns 1. When AVCodecContext.refcounted_frames is set to 0, the returned reference belongs to the decoder and is valid only until the next call to this function or until closing or flushing the decoder. The caller may not write to it.</param>
        /// <param name="got_picture_ptr">Zero if no frame could be decompressed, otherwise, it is nonzero.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer. You can create such packet with av_init_packet() and by then setting data and size, some decoders might in addition need other fields like flags &AV _PKT_FLAG_KEY. All decoders are designed to use the least fields possible.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_decode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_decode_video2(AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt);
        
        /// <summary>Decode a subtitle message. Return a negative value on error, otherwise return the number of bytes used. If no subtitle could be decompressed, got_sub_ptr is zero. Otherwise, the subtitle is stored in *sub. Note that AV_CODEC_CAP_DR1 is not available for subtitle codecs. This is for simplicity, because the performance difference is expect to be negligible and reusing a get_buffer written for video codecs would probably perform badly due to a potentially very different allocation pattern.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="sub">The Preallocated AVSubtitle in which the decoded subtitle will be stored, must be freed with avsubtitle_free if *got_sub_ptr is set.</param>
        /// <param name="got_sub_ptr">Zero if no subtitle could be decompressed, otherwise, it is nonzero.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_decode_subtitle2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
        
        /// <summary>Supply raw packet data as input to a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">The input AVPacket. Usually, this will be a single video frame, or several complete audio frames. Ownership of the packet remains with the caller, and the decoder will not write to the packet. The decoder may create a reference to the packet data (or copy it if the packet is not reference-counted). Unlike with older APIs, the packet is always fully consumed, and if it contains multiple frames (e.g. some audio codecs), will require you to call avcodec_receive_frame() multiple times afterwards before you can send a new packet. It can be NULL (or an AVPacket with data set to NULL and size set to 0); in this case, it is considered a flush packet, which signals the end of the stream. Sending the first flush packet will return success. Subsequent ones are unnecessary and will return AVERROR_EOF. If the decoder still has frames buffered, it will return them after sending a flush packet.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_send_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
        
        /// <summary>Return decoded output data from a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">This will be set to a reference-counted video or audio frame (depending on the decoder type) allocated by the decoder. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_receive_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame);
        
        /// <summary>Supply a raw video or audio frame to the encoder. Use avcodec_receive_packet() to retrieve buffered output packets.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">AVFrame containing the raw audio or video frame to be encoded. Ownership of the frame remains with the caller, and the encoder will not write to the frame. The encoder may create a reference to the frame data (or copy it if the frame is not reference-counted). It can be NULL, in which case it is considered a flush packet.  This signals the end of the stream. If the encoder still has packets buffered, it will return them after this call. Once flushing mode has been entered, additional flush packets are ignored, and sending frames will return AVERROR_EOF.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_send_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame);
        
        /// <summary>Read encoded data from the encoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">This will be set to a reference-counted packet allocated by the encoder. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_receive_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
        
        [DllImport("avcodec-57", EntryPoint = "av_parser_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecParser* av_parser_next(AVCodecParser* @c);
        
        [DllImport("avcodec-57", EntryPoint = "av_register_codec_parser", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_codec_parser(AVCodecParser* @parser);
        
        [DllImport("avcodec-57", EntryPoint = "av_parser_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecParserContext* av_parser_init(int @codec_id);
        
        /// <summary>Parse a packet.</summary>
        /// <param name="s">parser context.</param>
        /// <param name="avctx">codec context.</param>
        /// <param name="poutbuf">set to pointer to parsed buffer or NULL if not yet finished.</param>
        /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
        /// <param name="buf">input buffer.</param>
        /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
        /// <param name="pts">input presentation timestamp.</param>
        /// <param name="dts">input decoding timestamp.</param>
        /// <param name="pos">input byte position in stream.</param>
        [DllImport("avcodec-57", EntryPoint = "av_parser_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
        
        /// <summary>Returns 0 if the output buffer is a subset of the input, 1 if it is allocated and must be freed use AVBitStreamFilter</summary>
        [DllImport("avcodec-57", EntryPoint = "av_parser_change", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parser_change(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        
        [DllImport("avcodec-57", EntryPoint = "av_parser_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_parser_close(AVCodecParserContext* @s);
        
        /// <summary>Find a registered encoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested encoder</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* avcodec_find_encoder(AVCodecID @id);
        
        /// <summary>Find a registered encoder with the specified name.</summary>
        /// <param name="name">name of the requested encoder</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_encoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodec* avcodec_find_encoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Encode a frame of audio.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">output AVPacket. The user can supply an output buffer by setting avpkt->data and avpkt->size prior to calling the function, but if the size of the user-provided data is not large enough, encoding will fail. If avpkt->data and avpkt->size are set, avpkt->destruct must also be set. All other AVPacket fields will be reset by the encoder using av_init_packet(). If avpkt->data is NULL, the encoder will allocate it. The encoder will set avpkt->size to the size of the output packet.</param>
        /// <param name="frame">AVFrame containing the raw audio data to be encoded. May be NULL when flushing an encoder that has the AV_CODEC_CAP_DELAY capability set. If AV_CODEC_CAP_VARIABLE_FRAME_SIZE is set, then each frame can have any number of samples. If it is not set, frame->nb_samples must be equal to avctx->frame_size for all frames except the last. The final frame may be smaller than avctx->frame_size.</param>
        /// <param name="got_packet_ptr">This field is set to 1 by libavcodec if the output packet is non-empty, and to 0 if it is empty. If the function returns an error, the packet can be assumed to be invalid, and the value of got_packet_ptr is undefined and should not be used.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_encode_audio2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_encode_audio2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        /// <summary>Encode a frame of video.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">output AVPacket. The user can supply an output buffer by setting avpkt->data and avpkt->size prior to calling the function, but if the size of the user-provided data is not large enough, encoding will fail. All other AVPacket fields will be reset by the encoder using av_init_packet(). If avpkt->data is NULL, the encoder will allocate it. The encoder will set avpkt->size to the size of the output packet. The returned data (if any) belongs to the caller, he is responsible for freeing it.</param>
        /// <param name="frame">AVFrame containing the raw video data to be encoded. May be NULL when flushing an encoder that has the AV_CODEC_CAP_DELAY capability set.</param>
        /// <param name="got_packet_ptr">This field is set to 1 by libavcodec if the output packet is non-empty, and to 0 if it is empty. If the function returns an error, the packet can be assumed to be invalid, and the value of got_packet_ptr is undefined and should not be used.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_encode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_encode_video2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_encode_subtitle", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
        
        /// <summary>Initialize audio resampling context.</summary>
        /// <param name="output_channels">number of output channels</param>
        /// <param name="input_channels">number of input channels</param>
        /// <param name="output_rate">output sample rate</param>
        /// <param name="input_rate">input sample rate</param>
        /// <param name="sample_fmt_out">requested output sample format</param>
        /// <param name="sample_fmt_in">input sample format</param>
        /// <param name="filter_length">length of each FIR filter in the filterbank relative to the cutoff frequency</param>
        /// <param name="log2_phase_count">log2 of the number of entries in the polyphase filterbank</param>
        /// <param name="linear">if 1 then the used FIR filter will be linearly interpolated between the 2 closest, if 0 the closest will be used</param>
        /// <param name="cutoff">cutoff frequency, 1.0 corresponds to half the output sampling rate</param>
        [DllImport("avcodec-57", EntryPoint = "av_audio_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ReSampleContext* av_audio_resample_init(int @output_channels, int @input_channels, int @output_rate, int @input_rate, AVSampleFormat @sample_fmt_out, AVSampleFormat @sample_fmt_in, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        
        [DllImport("avcodec-57", EntryPoint = "audio_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int audio_resample(ReSampleContext* @s, short* @output, short* @input, int @nb_samples);
        
        /// <summary>Free resample context.</summary>
        /// <param name="s">a non-NULL pointer to a resample context previously created with av_audio_resample_init()</param>
        [DllImport("avcodec-57", EntryPoint = "audio_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void audio_resample_close(ReSampleContext* @s);
        
        /// <summary>Initialize an audio resampler. Note, if either rate is not an integer then simply scale both rates up so they are.</summary>
        /// <param name="filter_length">length of each FIR filter in the filterbank relative to the cutoff freq</param>
        /// <param name="log2_phase_count">log2 of the number of entries in the polyphase filterbank</param>
        /// <param name="linear">If 1 then the used FIR filter will be linearly interpolated between the 2 closest, if 0 the closest will be used</param>
        /// <param name="cutoff">cutoff frequency, 1.0 corresponds to half the output sampling rate</param>
        [DllImport("avcodec-57", EntryPoint = "av_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr av_resample_init(int @out_rate, int @in_rate, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        
        /// <summary>Resample an array of samples using a previously configured context.</summary>
        /// <param name="src">an array of unconsumed samples</param>
        /// <param name="consumed">the number of samples of src which have been consumed are returned here</param>
        /// <param name="src_size">the number of unconsumed samples available</param>
        /// <param name="dst_size">the amount of space in samples available in dst</param>
        /// <param name="update_ctx">If this is 0 then the context will not be modified, that way several channels can be resampled with the same context.</param>
        [DllImport("avcodec-57", EntryPoint = "av_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_resample(IntPtr @c, short* @dst, short* @src, int* @consumed, int @src_size, int @dst_size, int @update_ctx);
        
        /// <summary>Compensate samplerate/timestamp drift. The compensation is done by changing the resampler parameters, so no audible clicks or similar distortions occur</summary>
        /// <param name="sample_delta">number of output samples which should be output less</param>
        /// <param name="compensation_distance">distance in output samples over which the compensation should be performed</param>
        [DllImport("avcodec-57", EntryPoint = "av_resample_compensate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_resample_compensate(IntPtr @c, int @sample_delta, int @compensation_distance);
        
        [DllImport("avcodec-57", EntryPoint = "av_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_resample_close(IntPtr @c);
        
        [DllImport("avcodec-57", EntryPoint = "avpicture_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpicture_alloc(AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport("avcodec-57", EntryPoint = "avpicture_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avpicture_free(AVPicture* @picture);
        
        [DllImport("avcodec-57", EntryPoint = "avpicture_fill", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpicture_fill(AVPicture* @picture, byte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport("avcodec-57", EntryPoint = "avpicture_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpicture_layout(AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, byte* @dest, int @dest_size);
        
        [DllImport("avcodec-57", EntryPoint = "avpicture_get_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avpicture_get_size(AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport("avcodec-57", EntryPoint = "av_picture_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_picture_copy(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport("avcodec-57", EntryPoint = "av_picture_crop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_picture_crop(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band);
        
        [DllImport("avcodec-57", EntryPoint = "av_picture_pad", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_picture_pad(AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color);
        
        /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <param name="h_shift">store log2_chroma_w</param>
        /// <param name="v_shift">store log2_chroma_h</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        /// <summary>Return a value representing the fourCC code associated to the pixel format pix_fmt, or 0 if no associated fourCC code can be found.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_pix_fmt_to_codec_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        /// <summary>Find the best pixel format to convert to given a certain source pixel format. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. avcodec_find_best_pix_fmt_of_2() searches which of the given pixel formats should be used to suffer the least amount of loss. The pixel formats from which it chooses one, are determined by the pix_fmt_list parameter.</summary>
        /// <param name="pix_fmt_list">AV_PIX_FMT_NONE terminated array of pixel formats to choose from</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        /// <param name="loss_ptr">Combination of flags informing you what kind of losses will occur.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_best_pix_fmt_of_list", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(IntPtr @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_find_best_pix_fmt2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_default_get_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat avcodec_default_get_format(IntPtr @s, IntPtr @fmt);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_set_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_set_dimensions(AVCodecContext* @s, int @width, int @height);
        
        /// <summary>Put a string representing the codec tag codec_tag in buf.</summary>
        /// <param name="buf">buffer to place codec tag in</param>
        /// <param name="buf_size">size in bytes of buf</param>
        /// <param name="codec_tag">codec tag to assign</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_codec_tag_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_get_codec_tag_string(byte* @buf, ulong @buf_size, uint @codec_tag);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
        
        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec">the codec that is searched for the given profile</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_profile_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string av_get_profile_name(AVCodec* @codec, int @profile);
        
        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec_id">the ID of the codec to which the requested profile belongs</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_profile_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avcodec_profile_name(AVCodecID @codec_id, int @profile);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_default_execute", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_default_execute(AVCodecContext* @c, IntPtr @func, void* @arg, int* @ret, int @count, int @size);
        
        [DllImport("avcodec-57", EntryPoint = "avcodec_default_execute2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_default_execute2(AVCodecContext* @c, IntPtr @func, void* @arg, int* @ret, int @count);
        
        /// <summary>Fill AVFrame audio data and linesize pointers.</summary>
        /// <param name="frame">the AVFrame frame->nb_samples must be set prior to calling the function. This function fills in frame->data, frame->extended_data, frame->linesize[0].</param>
        /// <param name="nb_channels">channel count</param>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="buf">buffer to use for frame data</param>
        /// <param name="buf_size">size of buffer</param>
        /// <param name="align">plane size sample alignment (0 = default)</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_fill_audio_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
        
        /// <summary>Reset the internal decoder state / flush internal buffers. Should be called e.g. when seeking or when switching to a different stream.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_flush_buffers", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void avcodec_flush_buffers(AVCodecContext* @avctx);
        
        /// <summary>Return codec bits per sample.</summary>
        /// <param name="codec_id">the codec</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_bits_per_sample(AVCodecID @codec_id);
        
        /// <summary>Return the PCM codec associated with a sample format.</summary>
        /// <param name="be">endianness, 0 for little, 1 for big, -1 (or anything else) for native</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_pcm_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be);
        
        /// <summary>Return codec bits per sample. Only return non-zero if the bits per sample is exactly correct, not an approximation.</summary>
        /// <param name="codec_id">the codec</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_exact_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_exact_bits_per_sample(AVCodecID @codec_id);
        
        /// <summary>Return audio frame duration.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame_bytes">size of the frame, or 0 if unknown</param>
        [DllImport("avcodec-57", EntryPoint = "av_get_audio_frame_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes);
        
        /// <summary>This function is the same as av_get_audio_frame_duration(), except it works with AVCodecParameters instead of an AVCodecContext.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_get_audio_frame_duration2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes);
        
        /// <summary>Register a bitstream filter.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_register_bitstream_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_bitstream_filter(AVBitStreamFilter* @bsf);
        
        /// <summary>Create and initialize a bitstream filter context given a bitstream filter name.</summary>
        /// <param name="name">the name of the bitstream filter</param>
        [DllImport("avcodec-57", EntryPoint = "av_bitstream_filter_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBitStreamFilterContext* av_bitstream_filter_init([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Filter bitstream.</summary>
        /// <param name="bsfc">bitstream filter context created by av_bitstream_filter_init()</param>
        /// <param name="avctx">AVCodecContext accessed by the filter, may be NULL. If specified, this must point to the encoder context of the output stream the packet is sent to.</param>
        /// <param name="args">arguments which specify the filter configuration, may be NULL</param>
        /// <param name="poutbuf">pointer which is updated to point to the filtered buffer</param>
        /// <param name="poutbuf_size">pointer which is updated to the filtered buffer size in bytes</param>
        /// <param name="buf">buffer containing the data to filter</param>
        /// <param name="buf_size">size in bytes of buf</param>
        /// <param name="keyframe">set to non-zero if the buffer to filter corresponds to a key-frame packet data</param>
        [DllImport("avcodec-57", EntryPoint = "av_bitstream_filter_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, [MarshalAs(UnmanagedType.LPStr)] string @args, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        
        /// <summary>Release bitstream filter context.</summary>
        /// <param name="bsf">the bitstream filter context created with av_bitstream_filter_init(), can be NULL</param>
        [DllImport("avcodec-57", EntryPoint = "av_bitstream_filter_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* @bsf);
        
        /// <summary>If f is NULL, return the first registered bitstream filter, if f is non-NULL, return the next registered bitstream filter after f, or NULL if f is the last one.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bitstream_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* @f);
        
        /// <summary>Returns a bitstream filter with the specified name or NULL if no such bitstream filter exists.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBitStreamFilter* av_bsf_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Iterate over all registered bitstream filters.</summary>
        /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBitStreamFilter* av_bsf_next(void** @opaque);
        
        /// <summary>Allocate a context for a given bitstream filter. The caller must fill in the context parameters as described in the documentation and then call av_bsf_init() before sending any data to the filter.</summary>
        /// <param name="filter">the filter for which to allocate an instance.</param>
        /// <param name="ctx">a pointer into which the pointer to the newly-allocated context will be written. It must be freed with av_bsf_free() after the filtering is done.</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_alloc(AVBitStreamFilter* @filter, AVBSFContext** @ctx);
        
        /// <summary>Prepare the filter for use, after all the parameters and options have been set.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_init(AVBSFContext* @ctx);
        
        /// <summary>Submit a packet for filtering.</summary>
        /// <param name="pkt">the packet to filter. pkt must contain some payload (i.e data or side data must be present in pkt). The bitstream filter will take ownership of the packet and reset the contents of pkt. pkt is not touched if an error occurs. This parameter may be NULL, which signals the end of the stream (i.e. no more packets will be sent). That will cause the filter to output any packets it may have buffered internally.</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_send_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_send_packet(AVBSFContext* @ctx, AVPacket* @pkt);
        
        /// <summary>Retrieve a filtered packet.</summary>
        /// <param name="pkt">this struct will be filled with the contents of the filtered packet. It is owned by the caller and must be freed using av_packet_unref() when it is no longer needed. This parameter should be "clean" (i.e. freshly allocated with av_packet_alloc() or unreffed with av_packet_unref()) when this function is called. If this function returns successfully, the contents of pkt will be completely overwritten by the returned data. On failure, pkt is not touched.</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_receive_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_receive_packet(AVBSFContext* @ctx, AVPacket* @pkt);
        
        /// <summary>Free a bitstream filter context and everything associated with it; write NULL into the supplied pointer.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_bsf_free(AVBSFContext** @ctx);
        
        /// <summary>Get the AVClass for AVBSFContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* av_bsf_get_class();
        
        /// <summary>Allocate empty list of bitstream filters. The list must be later freed by av_bsf_list_free() or finalized by av_bsf_list_finalize().</summary>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBSFList* av_bsf_list_alloc();
        
        /// <summary>Free list of bitstream filters.</summary>
        /// <param name="lst">Pointer to pointer returned by av_bsf_list_alloc()</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_bsf_list_free(AVBSFList** @lst);
        
        /// <summary>Append bitstream filter to the list of bitstream filters.</summary>
        /// <param name="lst">List to append to</param>
        /// <param name="bsf">Filter context to be appended</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_append", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_list_append(AVBSFList* @lst, AVBSFContext* @bsf);
        
        /// <summary>Construct new bitstream filter context given it's name and options and append it to the list of bitstream filters.</summary>
        /// <param name="lst">List to append to</param>
        /// <param name="bsf_name">Name of the bitstream filter</param>
        /// <param name="options">Options for the bitstream filter, can be set to NULL</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_append2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_list_append2(AVBSFList* @lst, [MarshalAs(UnmanagedType.LPStr)] string @bsf_name, AVDictionary** @options);
        
        /// <summary>Finalize list of bitstream filters.</summary>
        /// <param name="lst">Filter list structure to be transformed</param>
        /// <param name="bsf">Pointer to be set to newly created</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_finalize", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_list_finalize(AVBSFList** @lst, AVBSFContext** @bsf);
        
        /// <summary>Parse string describing list of bitstream filters and create single Resulting allocated by av_bsf_alloc().</summary>
        /// <param name="str">String describing chain of bitstream filters in format `bsf1[=opt1=val1:opt2=val2][,bsf2]`</param>
        /// <param name="bsf">Pointer to be set to newly created</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_list_parse_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_list_parse_str([MarshalAs(UnmanagedType.LPStr)] string @str, AVBSFContext** @bsf);
        
        /// <summary>Get null/pass-through bitstream filter.</summary>
        /// <param name="bsf">Pointer to be set to new instance of pass-through bitstream filter</param>
        [DllImport("avcodec-57", EntryPoint = "av_bsf_get_null_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_bsf_get_null_filter(AVBSFContext** @bsf);
        
        /// <summary>Same behaviour av_fast_malloc but the buffer has additional AV_INPUT_BUFFER_PADDING_SIZE at the end which will always be 0.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_fast_padded_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        /// <summary>Same behaviour av_fast_padded_malloc except that buffer will always be 0-initialized after call.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_fast_padded_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size);
        
        /// <summary>Encode extradata length to a buffer. Used by xiph codecs.</summary>
        /// <param name="s">buffer to write to; must be at least (v/255+1) bytes long</param>
        /// <param name="v">size of extradata in bytes</param>
        [DllImport("avcodec-57", EntryPoint = "av_xiphlacing", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_xiphlacing(byte* @s, uint @v);
        
        /// <summary>Log a generic warning message about a missing feature. This function is intended to be used internally by FFmpeg (libavcodec, libavformat, etc.) only, and would normally not be used by applications.</summary>
        /// <param name="avc">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct</param>
        /// <param name="feature">string containing the name of the missing feature</param>
        /// <param name="want_sample">indicates if samples are wanted which exhibit this feature. If want_sample is non-zero, additional verbiage will be added to the log message which tells the user how to report samples to the development mailing list.</param>
        [DllImport("avcodec-57", EntryPoint = "av_log_missing_feature", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_missing_feature(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @feature, int @want_sample);
        
        /// <summary>Log a generic warning message asking for a sample. This function is intended to be used internally by FFmpeg (libavcodec, libavformat, etc.) only, and would normally not be used by applications.</summary>
        /// <param name="avc">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct</param>
        /// <param name="msg">string containing an optional message, or NULL if no message</param>
        [DllImport("avcodec-57", EntryPoint = "av_log_ask_for_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_ask_for_sample(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @msg);
        
        /// <summary>Register the hardware accelerator hwaccel.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_register_hwaccel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_register_hwaccel(AVHWAccel* @hwaccel);
        
        /// <summary>If hwaccel is NULL, returns the first registered hardware accelerator, if hwaccel is non-NULL, returns the next registered hardware accelerator after hwaccel, or NULL if hwaccel is the last one.</summary>
        [DllImport("avcodec-57", EntryPoint = "av_hwaccel_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVHWAccel* av_hwaccel_next(AVHWAccel* @hwaccel);
        
        /// <summary>Register a user provided lock manager supporting the operations specified by AVLockOp. The "mutex" argument to the function points to a (void *) where the lockmgr should store/get a pointer to a user allocated mutex. It is NULL upon AV_LOCK_CREATE and equal to the value left by the last call for all other ops. If the lock manager is unable to perform the op then it should leave the mutex in the same state as when it was called and return a non-zero value. However, when called with AV_LOCK_DESTROY the mutex will always be assumed to have been successfully destroyed. If av_lockmgr_register succeeds it will return a non-negative value, if it fails it will return a negative value and destroy all mutex and unregister all callbacks. av_lockmgr_register is not thread-safe, it must be called from a single thread before any calls which make use of locking are used.</summary>
        /// <param name="cb">User defined callback. av_lockmgr_register invokes calls to this callback and the previously registered callback. The callback will be used to create more than one mutex each of which must be backed by its own underlying locking mechanism (i.e. do not use a single static object to implement your lock manager). If cb is set to NULL the lockmgr will be unregistered.</param>
        [DllImport("avcodec-57", EntryPoint = "av_lockmgr_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_lockmgr_register(IntPtr @cb);
        
        /// <summary>Get the type of the given codec.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVMediaType avcodec_get_type(AVCodecID @codec_id);
        
        /// <summary>Get the name of a codec.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string avcodec_get_name(AVCodecID @id);
        
        /// <summary>Returns a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_is_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int avcodec_is_open(AVCodecContext* @s);
        
        /// <summary>Returns a non-zero number if codec is an encoder, zero otherwise</summary>
        [DllImport("avcodec-57", EntryPoint = "av_codec_is_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_is_encoder(AVCodec* @codec);
        
        /// <summary>Returns a non-zero number if codec is a decoder, zero otherwise</summary>
        [DllImport("avcodec-57", EntryPoint = "av_codec_is_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_codec_is_decoder(AVCodec* @codec);
        
        /// <summary>Returns descriptor for given codec ID or NULL if no descriptor exists.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_descriptor_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id);
        
        /// <summary>Iterate over all codec descriptors known to libavcodec.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        [DllImport("avcodec-57", EntryPoint = "avcodec_descriptor_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev);
        
        /// <summary>Returns codec descriptor with the given name or NULL if no such descriptor exists.</summary>
        [DllImport("avcodec-57", EntryPoint = "avcodec_descriptor_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        /// <summary>Allocate a CPB properties structure and initialize its fields to default values.</summary>
        /// <param name="size">if non-NULL, the size of the allocated struct will be written here. This is useful for embedding it in side data.</param>
        [DllImport("avcodec-57", EntryPoint = "av_cpb_properties_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVCPBProperties* av_cpb_properties_alloc(ulong* @size);
        
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
