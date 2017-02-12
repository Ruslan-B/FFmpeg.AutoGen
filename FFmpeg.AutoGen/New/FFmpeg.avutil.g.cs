using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.New
{
    /// <summary> Media Type </summary>
    public enum AVMediaType : int
    {
        /// <summary> Usually treated as AVMEDIA_TYPE_DATA </summary>
        @AVMEDIA_TYPE_UNKNOWN = -1,
        @AVMEDIA_TYPE_VIDEO = 0,
        @AVMEDIA_TYPE_AUDIO = 1,
        /// <summary> Opaque data information usually continuous </summary>
        @AVMEDIA_TYPE_DATA = 2,
        @AVMEDIA_TYPE_SUBTITLE = 3,
        /// <summary> Opaque data information usually sparse </summary>
        @AVMEDIA_TYPE_ATTACHMENT = 4,
        @AVMEDIA_TYPE_NB = 5,
    }
    
    /// <summary> @} @} </summary>
    public enum AVPictureType : int
    {
        /// <summary> Undefined </summary>
        @AV_PICTURE_TYPE_NONE = 0,
        /// <summary> Intra </summary>
        @AV_PICTURE_TYPE_I = 1,
        /// <summary> Predicted </summary>
        @AV_PICTURE_TYPE_P = 2,
        /// <summary> Bi-dir predicted </summary>
        @AV_PICTURE_TYPE_B = 3,
        /// <summary> S(GMC)-VOP MPEG-4 </summary>
        @AV_PICTURE_TYPE_S = 4,
        /// <summary> Switching Intra </summary>
        @AV_PICTURE_TYPE_SI = 5,
        /// <summary> Switching Predicted </summary>
        @AV_PICTURE_TYPE_SP = 6,
        /// <summary> BI type </summary>
        @AV_PICTURE_TYPE_BI = 7,
    }
    
    /// <summary> Rounding methods. </summary>
    public enum AVRounding : int
    {
        /// <summary> Round toward zero. </summary>
        @AV_ROUND_ZERO = 0,
        /// <summary> Round away from zero. </summary>
        @AV_ROUND_INF = 1,
        /// <summary> Round toward -infinity. </summary>
        @AV_ROUND_DOWN = 2,
        /// <summary> Round toward +infinity. </summary>
        @AV_ROUND_UP = 3,
        /// <summary> Round to nearest and halfway cases away from zero. </summary>
        @AV_ROUND_NEAR_INF = 5,
        /// <summary> Flag telling rescaling functions to pass `INT64_MIN`/`MAX` through unchanged, avoiding special cases for #AV_NOPTS_VALUE. </summary>
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
        /// <summary> not part of ABI/API </summary>
        @AV_CLASS_CATEGORY_NB = 46,
    }
    
    /// <summary> Pixel format. </summary>
    public enum AVPixelFormat : int
    {
        @AV_PIX_FMT_NONE = -1,
        /// <summary> planar YUV 4:2:0, 12bpp, (1 Cr & Cb sample per 2x2 Y samples) </summary>
        @AV_PIX_FMT_YUV420P = 0,
        /// <summary> packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr </summary>
        @AV_PIX_FMT_YUYV422 = 1,
        /// <summary> packed RGB 8:8:8, 24bpp, RGBRGB... </summary>
        @AV_PIX_FMT_RGB24 = 2,
        /// <summary> packed RGB 8:8:8, 24bpp, BGRBGR... </summary>
        @AV_PIX_FMT_BGR24 = 3,
        /// <summary> planar YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples) </summary>
        @AV_PIX_FMT_YUV422P = 4,
        /// <summary> planar YUV 4:4:4, 24bpp, (1 Cr & Cb sample per 1x1 Y samples) </summary>
        @AV_PIX_FMT_YUV444P = 5,
        /// <summary> planar YUV 4:1:0, 9bpp, (1 Cr & Cb sample per 4x4 Y samples) </summary>
        @AV_PIX_FMT_YUV410P = 6,
        /// <summary> planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples) </summary>
        @AV_PIX_FMT_YUV411P = 7,
        /// <summary> Y , 8bpp </summary>
        @AV_PIX_FMT_GRAY8 = 8,
        /// <summary> Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb </summary>
        @AV_PIX_FMT_MONOWHITE = 9,
        /// <summary> Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb </summary>
        @AV_PIX_FMT_MONOBLACK = 10,
        /// <summary> 8 bits with AV_PIX_FMT_RGB32 palette </summary>
        @AV_PIX_FMT_PAL8 = 11,
        /// <summary> planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range </summary>
        @AV_PIX_FMT_YUVJ420P = 12,
        /// <summary> planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range </summary>
        @AV_PIX_FMT_YUVJ422P = 13,
        /// <summary> planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range </summary>
        @AV_PIX_FMT_YUVJ444P = 14,
        /// <summary> XVideo Motion Acceleration via common packet passing </summary>
        @AV_PIX_FMT_XVMC_MPEG2_MC = 15,
        @AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
        @AV_PIX_FMT_XVMC = 16,
        /// <summary> packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1 </summary>
        @AV_PIX_FMT_UYVY422 = 17,
        /// <summary> packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3 </summary>
        @AV_PIX_FMT_UYYVYY411 = 18,
        /// <summary> packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb) </summary>
        @AV_PIX_FMT_BGR8 = 19,
        /// <summary> packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits </summary>
        @AV_PIX_FMT_BGR4 = 20,
        /// <summary> packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb) </summary>
        @AV_PIX_FMT_BGR4_BYTE = 21,
        /// <summary> packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb) </summary>
        @AV_PIX_FMT_RGB8 = 22,
        /// <summary> packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits </summary>
        @AV_PIX_FMT_RGB4 = 23,
        /// <summary> packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb) </summary>
        @AV_PIX_FMT_RGB4_BYTE = 24,
        /// <summary> planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V) </summary>
        @AV_PIX_FMT_NV12 = 25,
        /// <summary> as above, but U and V bytes are swapped </summary>
        @AV_PIX_FMT_NV21 = 26,
        /// <summary> packed ARGB 8:8:8:8, 32bpp, ARGBARGB... </summary>
        @AV_PIX_FMT_ARGB = 27,
        /// <summary> packed RGBA 8:8:8:8, 32bpp, RGBARGBA... </summary>
        @AV_PIX_FMT_RGBA = 28,
        /// <summary> packed ABGR 8:8:8:8, 32bpp, ABGRABGR... </summary>
        @AV_PIX_FMT_ABGR = 29,
        /// <summary> packed BGRA 8:8:8:8, 32bpp, BGRABGRA... </summary>
        @AV_PIX_FMT_BGRA = 30,
        /// <summary> Y , 16bpp, big-endian </summary>
        @AV_PIX_FMT_GRAY16BE = 31,
        /// <summary> Y , 16bpp, little-endian </summary>
        @AV_PIX_FMT_GRAY16LE = 32,
        /// <summary> planar YUV 4:4:0 (1 Cr & Cb sample per 1x2 Y samples) </summary>
        @AV_PIX_FMT_YUV440P = 33,
        /// <summary> planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range </summary>
        @AV_PIX_FMT_YUVJ440P = 34,
        /// <summary> planar YUV 4:2:0, 20bpp, (1 Cr & Cb sample per 2x2 Y & A samples) </summary>
        @AV_PIX_FMT_YUVA420P = 35,
        /// <summary> H.264 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_H264 = 36,
        /// <summary> MPEG-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_MPEG1 = 37,
        /// <summary> MPEG-2 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_MPEG2 = 38,
        /// <summary> WMV3 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_WMV3 = 39,
        /// <summary> VC-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_VC1 = 40,
        /// <summary> packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian </summary>
        @AV_PIX_FMT_RGB48BE = 41,
        /// <summary> packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian </summary>
        @AV_PIX_FMT_RGB48LE = 42,
        /// <summary> packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian </summary>
        @AV_PIX_FMT_RGB565BE = 43,
        /// <summary> packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian </summary>
        @AV_PIX_FMT_RGB565LE = 44,
        /// <summary> packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined </summary>
        @AV_PIX_FMT_RGB555BE = 45,
        /// <summary> packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_RGB555LE = 46,
        /// <summary> packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian </summary>
        @AV_PIX_FMT_BGR565BE = 47,
        /// <summary> packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian </summary>
        @AV_PIX_FMT_BGR565LE = 48,
        /// <summary> packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined </summary>
        @AV_PIX_FMT_BGR555BE = 49,
        /// <summary> packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_BGR555LE = 50,
        /// <summary> HW acceleration through VA API at motion compensation entry-point, Picture.data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VAAPI_MOCO = 51,
        /// <summary> HW acceleration through VA API at IDCT entry-point, Picture.data[3] contains a vaapi_render_state struct which contains fields extracted from headers </summary>
        @AV_PIX_FMT_VAAPI_IDCT = 52,
        /// <summary> HW decoding through VA API, Picture.data[3] contains a VASurfaceID </summary>
        @AV_PIX_FMT_VAAPI_VLD = 53,
        /// <summary> @} </summary>
        @AV_PIX_FMT_VAAPI = 53,
        /// <summary> planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV420P16LE = 54,
        /// <summary> planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV420P16BE = 55,
        /// <summary> planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV422P16LE = 56,
        /// <summary> planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV422P16BE = 57,
        /// <summary> planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV444P16LE = 58,
        /// <summary> planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV444P16BE = 59,
        /// <summary> MPEG-4 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers </summary>
        @AV_PIX_FMT_VDPAU_MPEG4 = 60,
        /// <summary> HW decoding through DXVA2, Picture.data[3] contains a LPDIRECT3DSURFACE9 pointer </summary>
        @AV_PIX_FMT_DXVA2_VLD = 61,
        /// <summary> packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_RGB444LE = 62,
        /// <summary> packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_RGB444BE = 63,
        /// <summary> packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_BGR444LE = 64,
        /// <summary> packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined </summary>
        @AV_PIX_FMT_BGR444BE = 65,
        /// <summary> 8 bits gray, 8 bits alpha </summary>
        @AV_PIX_FMT_YA8 = 66,
        /// <summary> alias for AV_PIX_FMT_YA8 </summary>
        @AV_PIX_FMT_Y400A = 66,
        /// <summary> alias for AV_PIX_FMT_YA8 </summary>
        @AV_PIX_FMT_GRAY8A = 66,
        /// <summary> packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian </summary>
        @AV_PIX_FMT_BGR48BE = 67,
        /// <summary> packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian </summary>
        @AV_PIX_FMT_BGR48LE = 68,
        /// <summary> planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV420P9BE = 69,
        /// <summary> planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV420P9LE = 70,
        /// <summary> planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV420P10BE = 71,
        /// <summary> planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV420P10LE = 72,
        /// <summary> planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV422P10BE = 73,
        /// <summary> planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV422P10LE = 74,
        /// <summary> planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV444P9BE = 75,
        /// <summary> planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV444P9LE = 76,
        /// <summary> planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV444P10BE = 77,
        /// <summary> planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV444P10LE = 78,
        /// <summary> planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV422P9BE = 79,
        /// <summary> planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV422P9LE = 80,
        /// <summary> hardware decoding through VDA </summary>
        @AV_PIX_FMT_VDA_VLD = 81,
        /// <summary> planar GBR 4:4:4 24bpp </summary>
        @AV_PIX_FMT_GBRP = 82,
        @AV_PIX_FMT_GBR24P = 82,
        /// <summary> planar GBR 4:4:4 27bpp, big-endian </summary>
        @AV_PIX_FMT_GBRP9BE = 83,
        /// <summary> planar GBR 4:4:4 27bpp, little-endian </summary>
        @AV_PIX_FMT_GBRP9LE = 84,
        /// <summary> planar GBR 4:4:4 30bpp, big-endian </summary>
        @AV_PIX_FMT_GBRP10BE = 85,
        /// <summary> planar GBR 4:4:4 30bpp, little-endian </summary>
        @AV_PIX_FMT_GBRP10LE = 86,
        /// <summary> planar GBR 4:4:4 48bpp, big-endian </summary>
        @AV_PIX_FMT_GBRP16BE = 87,
        /// <summary> planar GBR 4:4:4 48bpp, little-endian </summary>
        @AV_PIX_FMT_GBRP16LE = 88,
        /// <summary> planar YUV 4:2:2 24bpp, (1 Cr & Cb sample per 2x1 Y & A samples) </summary>
        @AV_PIX_FMT_YUVA422P = 89,
        /// <summary> planar YUV 4:4:4 32bpp, (1 Cr & Cb sample per 1x1 Y & A samples) </summary>
        @AV_PIX_FMT_YUVA444P = 90,
        /// <summary> planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), big-endian </summary>
        @AV_PIX_FMT_YUVA420P9BE = 91,
        /// <summary> planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), little-endian </summary>
        @AV_PIX_FMT_YUVA420P9LE = 92,
        /// <summary> planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), big-endian </summary>
        @AV_PIX_FMT_YUVA422P9BE = 93,
        /// <summary> planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), little-endian </summary>
        @AV_PIX_FMT_YUVA422P9LE = 94,
        /// <summary> planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), big-endian </summary>
        @AV_PIX_FMT_YUVA444P9BE = 95,
        /// <summary> planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), little-endian </summary>
        @AV_PIX_FMT_YUVA444P9LE = 96,
        /// <summary> planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA420P10BE = 97,
        /// <summary> planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA420P10LE = 98,
        /// <summary> planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA422P10BE = 99,
        /// <summary> planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA422P10LE = 100,
        /// <summary> planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA444P10BE = 101,
        /// <summary> planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA444P10LE = 102,
        /// <summary> planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA420P16BE = 103,
        /// <summary> planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA420P16LE = 104,
        /// <summary> planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA422P16BE = 105,
        /// <summary> planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA422P16LE = 106,
        /// <summary> planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian) </summary>
        @AV_PIX_FMT_YUVA444P16BE = 107,
        /// <summary> planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian) </summary>
        @AV_PIX_FMT_YUVA444P16LE = 108,
        /// <summary> HW acceleration through VDPAU, Picture.data[3] contains a VdpVideoSurface </summary>
        @AV_PIX_FMT_VDPAU = 109,
        /// <summary> packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0 </summary>
        @AV_PIX_FMT_XYZ12LE = 110,
        /// <summary> packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0 </summary>
        @AV_PIX_FMT_XYZ12BE = 111,
        /// <summary> interleaved chroma YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples) </summary>
        @AV_PIX_FMT_NV16 = 112,
        /// <summary> interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_NV20LE = 113,
        /// <summary> interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_NV20BE = 114,
        /// <summary> packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian </summary>
        @AV_PIX_FMT_RGBA64BE = 115,
        /// <summary> packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian </summary>
        @AV_PIX_FMT_RGBA64LE = 116,
        /// <summary> packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian </summary>
        @AV_PIX_FMT_BGRA64BE = 117,
        /// <summary> packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian </summary>
        @AV_PIX_FMT_BGRA64LE = 118,
        /// <summary> packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb </summary>
        @AV_PIX_FMT_YVYU422 = 119,
        /// <summary> HW acceleration through VDA, data[3] contains a CVPixelBufferRef </summary>
        @AV_PIX_FMT_VDA = 120,
        /// <summary> 16 bits gray, 16 bits alpha (big-endian) </summary>
        @AV_PIX_FMT_YA16BE = 121,
        /// <summary> 16 bits gray, 16 bits alpha (little-endian) </summary>
        @AV_PIX_FMT_YA16LE = 122,
        /// <summary> planar GBRA 4:4:4:4 32bpp </summary>
        @AV_PIX_FMT_GBRAP = 123,
        /// <summary> planar GBRA 4:4:4:4 64bpp, big-endian </summary>
        @AV_PIX_FMT_GBRAP16BE = 124,
        /// <summary> planar GBRA 4:4:4:4 64bpp, little-endian </summary>
        @AV_PIX_FMT_GBRAP16LE = 125,
        /// <summary> HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure. </summary>
        @AV_PIX_FMT_QSV = 126,
        /// <summary> HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure. </summary>
        @AV_PIX_FMT_MMAL = 127,
        /// <summary> HW decoding through Direct3D11, Picture.data[3] contains a ID3D11VideoDecoderOutputView pointer </summary>
        @AV_PIX_FMT_D3D11VA_VLD = 128,
        /// <summary> HW acceleration through CUDA. data[i] contain CUdeviceptr pointers exactly as for system memory frames. </summary>
        @AV_PIX_FMT_CUDA = 129,
        /// <summary> packed RGB 8:8:8, 32bpp, XRGBXRGB... X=unused/undefined </summary>
        @AV_PIX_FMT_0RGB = 295,
        /// <summary> packed RGB 8:8:8, 32bpp, RGBXRGBX... X=unused/undefined </summary>
        @AV_PIX_FMT_RGB0 = 296,
        /// <summary> packed BGR 8:8:8, 32bpp, XBGRXBGR... X=unused/undefined </summary>
        @AV_PIX_FMT_0BGR = 297,
        /// <summary> packed BGR 8:8:8, 32bpp, BGRXBGRX... X=unused/undefined </summary>
        @AV_PIX_FMT_BGR0 = 298,
        /// <summary> planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV420P12BE = 299,
        /// <summary> planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV420P12LE = 300,
        /// <summary> planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV420P14BE = 301,
        /// <summary> planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV420P14LE = 302,
        /// <summary> planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV422P12BE = 303,
        /// <summary> planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV422P12LE = 304,
        /// <summary> planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV422P14BE = 305,
        /// <summary> planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV422P14LE = 306,
        /// <summary> planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV444P12BE = 307,
        /// <summary> planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV444P12LE = 308,
        /// <summary> planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV444P14BE = 309,
        /// <summary> planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV444P14LE = 310,
        /// <summary> planar GBR 4:4:4 36bpp, big-endian </summary>
        @AV_PIX_FMT_GBRP12BE = 311,
        /// <summary> planar GBR 4:4:4 36bpp, little-endian </summary>
        @AV_PIX_FMT_GBRP12LE = 312,
        /// <summary> planar GBR 4:4:4 42bpp, big-endian </summary>
        @AV_PIX_FMT_GBRP14BE = 313,
        /// <summary> planar GBR 4:4:4 42bpp, little-endian </summary>
        @AV_PIX_FMT_GBRP14LE = 314,
        /// <summary> planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range </summary>
        @AV_PIX_FMT_YUVJ411P = 315,
        /// <summary> bayer, BGBG..(odd line), GRGR..(even line), 8-bit samples */ </summary>
        @AV_PIX_FMT_BAYER_BGGR8 = 316,
        /// <summary> bayer, RGRG..(odd line), GBGB..(even line), 8-bit samples */ </summary>
        @AV_PIX_FMT_BAYER_RGGB8 = 317,
        /// <summary> bayer, GBGB..(odd line), RGRG..(even line), 8-bit samples */ </summary>
        @AV_PIX_FMT_BAYER_GBRG8 = 318,
        /// <summary> bayer, GRGR..(odd line), BGBG..(even line), 8-bit samples */ </summary>
        @AV_PIX_FMT_BAYER_GRBG8 = 319,
        /// <summary> bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, little-endian */ </summary>
        @AV_PIX_FMT_BAYER_BGGR16LE = 320,
        /// <summary> bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, big-endian */ </summary>
        @AV_PIX_FMT_BAYER_BGGR16BE = 321,
        /// <summary> bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, little-endian */ </summary>
        @AV_PIX_FMT_BAYER_RGGB16LE = 322,
        /// <summary> bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, big-endian */ </summary>
        @AV_PIX_FMT_BAYER_RGGB16BE = 323,
        /// <summary> bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, little-endian */ </summary>
        @AV_PIX_FMT_BAYER_GBRG16LE = 324,
        /// <summary> bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, big-endian */ </summary>
        @AV_PIX_FMT_BAYER_GBRG16BE = 325,
        /// <summary> bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, little-endian */ </summary>
        @AV_PIX_FMT_BAYER_GRBG16LE = 326,
        /// <summary> bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, big-endian */ </summary>
        @AV_PIX_FMT_BAYER_GRBG16BE = 327,
        /// <summary> planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV440P10LE = 328,
        /// <summary> planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV440P10BE = 329,
        /// <summary> planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian </summary>
        @AV_PIX_FMT_YUV440P12LE = 330,
        /// <summary> planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian </summary>
        @AV_PIX_FMT_YUV440P12BE = 331,
        /// <summary> packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), little-endian </summary>
        @AV_PIX_FMT_AYUV64LE = 332,
        /// <summary> packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), big-endian </summary>
        @AV_PIX_FMT_AYUV64BE = 333,
        /// <summary> hardware decoding through Videotoolbox </summary>
        @AV_PIX_FMT_VIDEOTOOLBOX = 334,
        /// <summary> like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian </summary>
        @AV_PIX_FMT_P010LE = 335,
        /// <summary> like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian </summary>
        @AV_PIX_FMT_P010BE = 336,
        /// <summary> planar GBR 4:4:4:4 48bpp, big-endian </summary>
        @AV_PIX_FMT_GBRAP12BE = 337,
        /// <summary> planar GBR 4:4:4:4 48bpp, little-endian </summary>
        @AV_PIX_FMT_GBRAP12LE = 338,
        /// <summary> planar GBR 4:4:4:4 40bpp, big-endian </summary>
        @AV_PIX_FMT_GBRAP10BE = 339,
        /// <summary> planar GBR 4:4:4:4 40bpp, little-endian </summary>
        @AV_PIX_FMT_GBRAP10LE = 340,
        /// <summary> hardware decoding through MediaCodec </summary>
        @AV_PIX_FMT_MEDIACODEC = 341,
        /// <summary> number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions </summary>
        @AV_PIX_FMT_NB = 342,
    }
    
    /// <summary> Chromaticity coordinates of the source primaries. </summary>
    public enum AVColorPrimaries : int
    {
        @AVCOL_PRI_RESERVED0 = 0,
        /// <summary> also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP177 Annex B </summary>
        @AVCOL_PRI_BT709 = 1,
        @AVCOL_PRI_UNSPECIFIED = 2,
        @AVCOL_PRI_RESERVED = 3,
        /// <summary> also FCC Title 47 Code of Federal Regulations 73.682 (a)(20) </summary>
        @AVCOL_PRI_BT470M = 4,
        /// <summary> also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM </summary>
        @AVCOL_PRI_BT470BG = 5,
        /// <summary> also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC </summary>
        @AVCOL_PRI_SMPTE170M = 6,
        /// <summary> functionally identical to above </summary>
        @AVCOL_PRI_SMPTE240M = 7,
        /// <summary> colour filters using Illuminant C </summary>
        @AVCOL_PRI_FILM = 8,
        /// <summary> ITU-R BT2020 </summary>
        @AVCOL_PRI_BT2020 = 9,
        /// <summary> SMPTE ST 428-1 (CIE 1931 XYZ) </summary>
        @AVCOL_PRI_SMPTEST428_1 = 10,
        /// <summary> SMPTE ST 431-2 (2011) </summary>
        @AVCOL_PRI_SMPTE431 = 11,
        /// <summary> SMPTE ST 432-1 D65 (2010) </summary>
        @AVCOL_PRI_SMPTE432 = 12,
        /// <summary> Not part of ABI </summary>
        @AVCOL_PRI_NB = 13,
    }
    
    /// <summary> Color Transfer Characteristic. </summary>
    public enum AVColorTransferCharacteristic : int
    {
        @AVCOL_TRC_RESERVED0 = 0,
        /// <summary> also ITU-R BT1361 </summary>
        @AVCOL_TRC_BT709 = 1,
        @AVCOL_TRC_UNSPECIFIED = 2,
        @AVCOL_TRC_RESERVED = 3,
        /// <summary> also ITU-R BT470M / ITU-R BT1700 625 PAL & SECAM </summary>
        @AVCOL_TRC_GAMMA22 = 4,
        /// <summary> also ITU-R BT470BG </summary>
        @AVCOL_TRC_GAMMA28 = 5,
        /// <summary> also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC </summary>
        @AVCOL_TRC_SMPTE170M = 6,
        @AVCOL_TRC_SMPTE240M = 7,
        /// <summary> "Linear transfer characteristics" </summary>
        @AVCOL_TRC_LINEAR = 8,
        /// <summary> "Logarithmic transfer characteristic (100:1 range)" </summary>
        @AVCOL_TRC_LOG = 9,
        /// <summary> "Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)" </summary>
        @AVCOL_TRC_LOG_SQRT = 10,
        /// <summary> IEC 61966-2-4 </summary>
        @AVCOL_TRC_IEC61966_2_4 = 11,
        /// <summary> ITU-R BT1361 Extended Colour Gamut </summary>
        @AVCOL_TRC_BT1361_ECG = 12,
        /// <summary> IEC 61966-2-1 (sRGB or sYCC) </summary>
        @AVCOL_TRC_IEC61966_2_1 = 13,
        /// <summary> ITU-R BT2020 for 10-bit system </summary>
        @AVCOL_TRC_BT2020_10 = 14,
        /// <summary> ITU-R BT2020 for 12-bit system </summary>
        @AVCOL_TRC_BT2020_12 = 15,
        /// <summary> SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems </summary>
        @AVCOL_TRC_SMPTEST2084 = 16,
        /// <summary> SMPTE ST 428-1 </summary>
        @AVCOL_TRC_SMPTEST428_1 = 17,
        /// <summary> ARIB STD-B67, known as "Hybrid log-gamma" </summary>
        @AVCOL_TRC_ARIB_STD_B67 = 18,
        /// <summary> Not part of ABI </summary>
        @AVCOL_TRC_NB = 19,
    }
    
    /// <summary> YUV colorspace type. </summary>
    public enum AVColorSpace : int
    {
        /// <summary> order of coefficients is actually GBR, also IEC 61966-2-1 (sRGB) </summary>
        @AVCOL_SPC_RGB = 0,
        /// <summary> also ITU-R BT1361 / IEC 61966-2-4 xvYCC709 / SMPTE RP177 Annex B </summary>
        @AVCOL_SPC_BT709 = 1,
        @AVCOL_SPC_UNSPECIFIED = 2,
        @AVCOL_SPC_RESERVED = 3,
        /// <summary> FCC Title 47 Code of Federal Regulations 73.682 (a)(20) </summary>
        @AVCOL_SPC_FCC = 4,
        /// <summary> also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM / IEC 61966-2-4 xvYCC601 </summary>
        @AVCOL_SPC_BT470BG = 5,
        /// <summary> also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC </summary>
        @AVCOL_SPC_SMPTE170M = 6,
        /// <summary> functionally identical to above </summary>
        @AVCOL_SPC_SMPTE240M = 7,
        /// <summary> Used by Dirac / VC-2 and H.264 FRext, see ITU-T SG16 </summary>
        @AVCOL_SPC_YCOCG = 8,
        /// <summary> ITU-R BT2020 non-constant luminance system </summary>
        @AVCOL_SPC_BT2020_NCL = 9,
        /// <summary> ITU-R BT2020 constant luminance system </summary>
        @AVCOL_SPC_BT2020_CL = 10,
        /// <summary> SMPTE 2085, Y'D'zD'x </summary>
        @AVCOL_SPC_SMPTE2085 = 11,
        /// <summary> Not part of ABI </summary>
        @AVCOL_SPC_NB = 12,
    }
    
    /// <summary> MPEG vs JPEG YUV range. </summary>
    public enum AVColorRange : int
    {
        @AVCOL_RANGE_UNSPECIFIED = 0,
        /// <summary> the normal 219*2^(n-8) "MPEG" YUV ranges </summary>
        @AVCOL_RANGE_MPEG = 1,
        /// <summary> the normal 2^n-1 "JPEG" YUV ranges </summary>
        @AVCOL_RANGE_JPEG = 2,
        /// <summary> Not part of ABI </summary>
        @AVCOL_RANGE_NB = 3,
    }
    
    /// <summary> Location of chroma samples. </summary>
    public enum AVChromaLocation : int
    {
        @AVCHROMA_LOC_UNSPECIFIED = 0,
        /// <summary> MPEG-2/4 4:2:0, H.264 default for 4:2:0 </summary>
        @AVCHROMA_LOC_LEFT = 1,
        /// <summary> MPEG-1 4:2:0, JPEG 4:2:0, H.263 4:2:0 </summary>
        @AVCHROMA_LOC_CENTER = 2,
        /// <summary> ITU-R 601, SMPTE 274M 296M S314M(DV 4:1:1), mpeg2 4:2:2 </summary>
        @AVCHROMA_LOC_TOPLEFT = 3,
        @AVCHROMA_LOC_TOP = 4,
        @AVCHROMA_LOC_BOTTOMLEFT = 5,
        @AVCHROMA_LOC_BOTTOM = 6,
        /// <summary> Not part of ABI </summary>
        @AVCHROMA_LOC_NB = 7,
    }
    
    /// <summary> Audio sample formats </summary>
    public enum AVSampleFormat : int
    {
        @AV_SAMPLE_FMT_NONE = -1,
        /// <summary> unsigned 8 bits </summary>
        @AV_SAMPLE_FMT_U8 = 0,
        /// <summary> signed 16 bits </summary>
        @AV_SAMPLE_FMT_S16 = 1,
        /// <summary> signed 32 bits </summary>
        @AV_SAMPLE_FMT_S32 = 2,
        /// <summary> float </summary>
        @AV_SAMPLE_FMT_FLT = 3,
        /// <summary> double </summary>
        @AV_SAMPLE_FMT_DBL = 4,
        /// <summary> unsigned 8 bits, planar </summary>
        @AV_SAMPLE_FMT_U8P = 5,
        /// <summary> signed 16 bits, planar </summary>
        @AV_SAMPLE_FMT_S16P = 6,
        /// <summary> signed 32 bits, planar </summary>
        @AV_SAMPLE_FMT_S32P = 7,
        /// <summary> float, planar </summary>
        @AV_SAMPLE_FMT_FLTP = 8,
        /// <summary> double, planar </summary>
        @AV_SAMPLE_FMT_DBLP = 9,
        /// <summary> signed 64 bits </summary>
        @AV_SAMPLE_FMT_S64 = 10,
        /// <summary> signed 64 bits, planar </summary>
        @AV_SAMPLE_FMT_S64P = 11,
        /// <summary> Number of sample formats. DO NOT USE if linking dynamically </summary>
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
    
    /// <summary> @{ AVFrame is an abstraction for reference-counted raw multimedia data. </summary>
    public enum AVFrameSideDataType : int
    {
        /// <summary> The data is the AVPanScan struct defined in libavcodec. </summary>
        @AV_FRAME_DATA_PANSCAN = 0,
        /// <summary> ATSC A53 Part 4 Closed Captions. A53 CC bitstream is stored as uint8_t in AVFrameSideData.data. The number of bytes of CC data is AVFrameSideData.size. </summary>
        @AV_FRAME_DATA_A53_CC = 1,
        /// <summary> Stereoscopic 3d metadata. The data is the AVStereo3D struct defined in libavutil/stereo3d.h. </summary>
        @AV_FRAME_DATA_STEREO3D = 2,
        /// <summary> The data is the AVMatrixEncoding enum defined in libavutil/channel_layout.h. </summary>
        @AV_FRAME_DATA_MATRIXENCODING = 3,
        /// <summary> Metadata relevant to a downmix procedure. The data is the AVDownmixInfo struct defined in libavutil/downmix_info.h. </summary>
        @AV_FRAME_DATA_DOWNMIX_INFO = 4,
        /// <summary> ReplayGain information in the form of the AVReplayGain struct. </summary>
        @AV_FRAME_DATA_REPLAYGAIN = 5,
        /// <summary> This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the frame for correct presentation. </summary>
        @AV_FRAME_DATA_DISPLAYMATRIX = 6,
        /// <summary> Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum. </summary>
        @AV_FRAME_DATA_AFD = 7,
        /// <summary> Motion vectors exported by some codecs (on demand through the export_mvs flag set in the libavcodec AVCodecContext flags2 option). The data is the AVMotionVector struct defined in libavutil/motion_vector.h. </summary>
        @AV_FRAME_DATA_MOTION_VECTORS = 8,
        /// <summary> Recommmends skipping the specified number of samples. This is exported only if the "skip_manual" AVOption is set in libavcodec. This has the same format as AV_PKT_DATA_SKIP_SAMPLES. </summary>
        @AV_FRAME_DATA_SKIP_SAMPLES = 9,
        /// <summary> This side data must be associated with an audio frame and corresponds to enum AVAudioServiceType defined in avcodec.h. </summary>
        @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
        /// <summary> Mastering display metadata associated with a video frame. The payload is an AVMasteringDisplayMetadata type and contains information about the mastering display color volume. </summary>
        @AV_FRAME_DATA_MASTERING_DISPLAY_METADATA = 11,
        /// <summary> The GOP timecode in 25 bit timecode format. Data format is 64-bit integer. This is set on the first frame of a GOP that has a temporal reference of 0. </summary>
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
    
    /// <summary> @{ AVOptions provide a generic system to declare options on arbitrary structs ("objects"). An option can have a help text, a type and a range of possible values. Options may then be enumerated, read and written to. </summary>
    public enum AVOptionType : int
    {
        @AV_OPT_TYPE_FLAGS = 0,
        @AV_OPT_TYPE_INT = 1,
        @AV_OPT_TYPE_INT64 = 2,
        @AV_OPT_TYPE_DOUBLE = 3,
        @AV_OPT_TYPE_FLOAT = 4,
        @AV_OPT_TYPE_STRING = 5,
        @AV_OPT_TYPE_RATIONAL = 6,
        /// <summary> offset must point to a pointer immediately followed by an int for the length </summary>
        @AV_OPT_TYPE_BINARY = 7,
        @AV_OPT_TYPE_DICT = 8,
        @AV_OPT_TYPE_CONST = 128,
        /// <summary> offset must point to two consecutive integers </summary>
        @AV_OPT_TYPE_IMAGE_SIZE = 1397316165,
        @AV_OPT_TYPE_PIXEL_FMT = 1346784596,
        @AV_OPT_TYPE_SAMPLE_FMT = 1397116244,
        /// <summary> offset must point to AVRational </summary>
        @AV_OPT_TYPE_VIDEO_RATE = 1448231252,
        @AV_OPT_TYPE_DURATION = 1146442272,
        @AV_OPT_TYPE_COLOR = 1129270354,
        @AV_OPT_TYPE_CHANNEL_LAYOUT = 1128811585,
        @AV_OPT_TYPE_BOOL = 1112493900,
    }
    
    /// <summary> Rational number (pair of numerator and denominator). </summary>
    public unsafe struct AVRational
    {
        /// <summary> Numerator </summary>
        public int @num;
        /// <summary> Denominator </summary>
        public int @den;
    }
    
    /// <summary> Describe the class of an AVClass context structure. That is an arbitrary struct of which the first field is a pointer to an AVClass struct (e.g. AVCodecContext, AVFormatContext etc.). </summary>
    public unsafe struct AVClass
    {
        /// <summary> The name of the class; usually it is the same name as the context structure type to which the AVClass is associated. </summary>
        public byte* @class_name;
        /// <summary> A pointer to a function which returns the name of a context instance ctx associated with the class. </summary>
        public IntPtr @item_name;
        /// <summary> a pointer to the first option specified in the class if any or NULL </summary>
        public IntPtr @option;
        /// <summary> LIBAVUTIL_VERSION with which this structure was created. This is used to allow fields to be added without requiring major version bumps everywhere. </summary>
        public int @version;
        /// <summary> Offset in the structure where log_level_offset is stored. 0 means there is no such variable </summary>
        public int @log_level_offset_offset;
        /// <summary> Offset in the structure where a pointer to the parent context for logging is stored. For example a decoder could pass its AVCodecContext to eval as such a parent context, which an av_log() implementation could then leverage to display the parent context. The offset can be NULL. </summary>
        public int @parent_log_context_offset;
        /// <summary> Return next AVOptions-enabled child or NULL </summary>
        public IntPtr @child_next;
        /// <summary> Return an AVClass corresponding to the next potential AVOptions-enabled child. </summary>
        public IntPtr @child_class_next;
        /// <summary> Category used for visualization (like color) This is only set if the category is equal for all objects using this class. available since version (51 << 16 | 56 << 8 | 100) </summary>
        public AVClassCategory @category;
        /// <summary> Callback to return the category. available since version (51 << 16 | 59 << 8 | 100) </summary>
        public IntPtr @get_category;
        /// <summary> Callback to return the supported/allowed ranges. available since version (52.12) </summary>
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
    
    /// <summary> A reference to a data buffer. </summary>
    public unsafe struct AVBufferRef
    {
        public AVBuffer* @buffer;
        /// <summary> The data buffer. It is considered writable if and only if this is the only reference to the buffer, in which case av_buffer_is_writable() returns 1. </summary>
        public byte* @data;
        /// <summary> Size of data in bytes. </summary>
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
    
    /// <summary> Structure to hold side data for an AVFrame. </summary>
    public unsafe struct AVFrameSideData
    {
        public AVFrameSideDataType @type;
        public byte* @data;
        public int @size;
        public AVDictionary* @metadata;
        public AVBufferRef* @buf;
    }
    
    /// <summary> This structure describes decoded (raw) audio or video data. </summary>
    public unsafe struct AVFrame
    {
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data0;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data1;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data2;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data3;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data4;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data5;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data6;
        /// <summary> pointer to the picture/channel planes. This might be different from the first allocated byte </summary>
        public byte* @data7;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize0;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize1;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize2;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize3;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize4;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize5;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize6;
        /// <summary> For video, size in bytes of each picture line. For audio, size in bytes of each plane. </summary>
        public int @linesize7;
        /// <summary> pointers to the data planes/channels. </summary>
        public IntPtr @extended_data;
        /// <summary> width and height of the video frame </summary>
        public int @width;
        /// <summary> width and height of the video frame </summary>
        public int @height;
        /// <summary> number of audio samples (per channel) described by this frame </summary>
        public int @nb_samples;
        /// <summary> format of the frame, -1 if unknown or unset Values correspond to enum AVPixelFormat for video frames, enum AVSampleFormat for audio) </summary>
        public int @format;
        /// <summary> 1 -> keyframe, 0-> not </summary>
        public int @key_frame;
        /// <summary> Picture type of the frame. </summary>
        public AVPictureType @pict_type;
        /// <summary> Sample aspect ratio for the video frame, 0/1 if unknown/unspecified. </summary>
        public AVRational @sample_aspect_ratio;
        /// <summary> Presentation timestamp in time_base units (time when frame should be shown to user). </summary>
        public long @pts;
        /// <summary> PTS copied from the AVPacket that was decoded to produce this frame. </summary>
        public long @pkt_pts;
        /// <summary> DTS copied from the AVPacket that triggered returning this frame. (if frame threading isn't used) This is also the Presentation time of this AVFrame calculated from only AVPacket.dts values without pts values. </summary>
        public long @pkt_dts;
        /// <summary> picture number in bitstream order </summary>
        public int @coded_picture_number;
        /// <summary> picture number in display order </summary>
        public int @display_picture_number;
        /// <summary> quality (between 1 (good) and FF_LAMBDA_MAX (bad)) </summary>
        public int @quality;
        /// <summary> for some private data of the user </summary>
        public void* @opaque;
        public ulong @error0;
        public ulong @error1;
        public ulong @error2;
        public ulong @error3;
        public ulong @error4;
        public ulong @error5;
        public ulong @error6;
        public ulong @error7;
        /// <summary> When decoding, this signals how much the picture must be delayed. extra_delay = repeat_pict / (2*fps) </summary>
        public int @repeat_pict;
        /// <summary> The content of the picture is interlaced. </summary>
        public int @interlaced_frame;
        /// <summary> If the content is interlaced, is top field displayed first. </summary>
        public int @top_field_first;
        /// <summary> Tell user application that palette has changed from previous frame. </summary>
        public int @palette_has_changed;
        /// <summary> reordered opaque 64 bits (generally an integer or a double precision float PTS but can be anything). The user sets AVCodecContext.reordered_opaque to represent the input at that time, the decoder reorders values as needed and sets AVFrame.reordered_opaque to exactly one of the values provided by the user through AVCodecContext.reordered_opaque </summary>
        public long @reordered_opaque;
        /// <summary> Sample rate of the audio data. </summary>
        public int @sample_rate;
        /// <summary> Channel layout of the audio data. </summary>
        public ulong @channel_layout;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf0;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf1;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf2;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf3;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf4;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf5;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf6;
        /// <summary> AVBuffer references backing the data for this frame. If all elements of this array are NULL, then this frame is not reference counted. This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j < i. </summary>
        public AVBufferRef* @buf7;
        /// <summary> For planar audio which requires more than AV_NUM_DATA_POINTERS AVBufferRef pointers, this array will hold all the references which cannot fit into AVFrame.buf. </summary>
        public IntPtr @extended_buf;
        /// <summary> Number of elements in extended_buf. </summary>
        public int @nb_extended_buf;
        public IntPtr @side_data;
        public int @nb_side_data;
        /// <summary> Frame flags, a combination of </summary>
        public int @flags;
        /// <summary> MPEG vs JPEG YUV range. It must be accessed using av_frame_get_color_range() and av_frame_set_color_range(). - encoding: Set by user - decoding: Set by libavcodec </summary>
        public AVColorRange @color_range;
        public AVColorPrimaries @color_primaries;
        public AVColorTransferCharacteristic @color_trc;
        /// <summary> YUV colorspace type. It must be accessed using av_frame_get_colorspace() and av_frame_set_colorspace(). - encoding: Set by user - decoding: Set by libavcodec </summary>
        public AVColorSpace @colorspace;
        public AVChromaLocation @chroma_location;
        /// <summary> frame timestamp estimated using various heuristics, in stream time base Code outside libavutil should access this field using: av_frame_get_best_effort_timestamp(frame) - encoding: unused - decoding: set by libavcodec, read by user. </summary>
        public long @best_effort_timestamp;
        /// <summary> reordered pos from the last AVPacket that has been input into the decoder Code outside libavutil should access this field using: av_frame_get_pkt_pos(frame) - encoding: unused - decoding: Read by user. </summary>
        public long @pkt_pos;
        /// <summary> duration of the corresponding packet, expressed in AVStream->time_base units, 0 if unknown. Code outside libavutil should access this field using: av_frame_get_pkt_duration(frame) - encoding: unused - decoding: Read by user. </summary>
        public long @pkt_duration;
        /// <summary> metadata. Code outside libavutil should access this field using: av_frame_get_metadata(frame) - encoding: Set by user. - decoding: Set by libavcodec. </summary>
        public AVDictionary* @metadata;
        /// <summary> decode error flags of the frame, set to a combination of FF_DECODE_ERROR_xxx flags if the decoder produced a frame, but there were errors during the decoding. Code outside libavutil should access this field using: av_frame_get_decode_error_flags(frame) - encoding: unused - decoding: set by libavcodec, read by user. </summary>
        public int @decode_error_flags;
        /// <summary> number of audio channels, only used for audio. Code outside libavutil should access this field using: av_frame_get_channels(frame) - encoding: unused - decoding: Read by user. </summary>
        public int @channels;
        /// <summary> size of the corresponding packet containing the compressed frame. It must be accessed using av_frame_get_pkt_size() and av_frame_set_pkt_size(). It is set to a negative value if unknown. - encoding: unused - decoding: set by libavcodec, read by user. </summary>
        public int @pkt_size;
        /// <summary> QP table Not to be accessed directly from outside libavutil </summary>
        public sbyte* @qscale_table;
        /// <summary> QP store stride Not to be accessed directly from outside libavutil </summary>
        public int @qstride;
        public int @qscale_type;
        /// <summary> Not to be accessed directly from outside libavutil </summary>
        public AVBufferRef* @qp_table_buf;
        /// <summary> For hwaccel-format frames, this should be a reference to the AVHWFramesContext describing the frame. </summary>
        public AVBufferRef* @hw_frames_ctx;
    }
    
    /// <summary> the default value for scalar options </summary>
    public unsafe struct AVOption_default_val
    {
        public long @i64;
        public double @dbl;
        public byte* @str;
        public AVRational @q;
    }
    
    /// <summary> AVOption </summary>
    public unsafe struct AVOption
    {
        public byte* @name;
        /// <summary> short English help text </summary>
        public byte* @help;
        /// <summary> The offset relative to the context structure where the option value is stored. It should be 0 for named constants. </summary>
        public int @offset;
        public AVOptionType @type;
        public AVOption_default_val @default_val;
        /// <summary> minimum valid value for the option </summary>
        public double @min;
        /// <summary> maximum valid value for the option </summary>
        public double @max;
        public int @flags;
        /// <summary> The logical unit to which the option belongs. Non-constant options and corresponding named constants share the same unit. May be NULL. </summary>
        public byte* @unit;
    }
    
    /// <summary> A single allowed range of values, or a single allowed value. </summary>
    public unsafe struct AVOptionRange
    {
        public byte* @str;
        /// <summary> Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case. </summary>
        public double @value_min;
        /// <summary> Value range. For string ranges this represents the min/max length. For dimensions this represents the min/max pixel count or width/height in multi-component case. </summary>
        public double @value_max;
        /// <summary> Value's component range. For string this represents the unicode range for chars, 0-127 limits to ASCII. </summary>
        public double @component_min;
        /// <summary> Value's component range. For string this represents the unicode range for chars, 0-127 limits to ASCII. </summary>
        public double @component_max;
        /// <summary> Range flag. If set to 1 the struct encodes a range, if set to 0 a single value. </summary>
        public int @is_range;
    }
    
    /// <summary> List of AVOptionRange structs. </summary>
    public unsafe struct AVOptionRanges
    {
        /// <summary> Array of option ranges. </summary>
        public IntPtr @range;
        /// <summary> Number of ranges per component. </summary>
        public int @nb_ranges;
        /// <summary> Number of componentes. </summary>
        public int @nb_components;
    }
    
    public unsafe struct AVComponentDescriptor
    {
        /// <summary> Which of the 4 planes contains the component. </summary>
        public int @plane;
        /// <summary> Number of elements between 2 horizontally consecutive pixels. Elements are bits for bitstream formats, bytes otherwise. </summary>
        public int @step;
        /// <summary> Number of elements before the component of the first pixel. Elements are bits for bitstream formats, bytes otherwise. </summary>
        public int @offset;
        /// <summary> Number of least significant bits that must be shifted away to get the value. </summary>
        public int @shift;
        /// <summary> Number of bits in the component. </summary>
        public int @depth;
        /// <summary> deprecated, use step instead </summary>
        public int @step_minus1;
        /// <summary> deprecated, use depth instead </summary>
        public int @depth_minus1;
        /// <summary> deprecated, use offset instead </summary>
        public int @offset_plus1;
    }
    
    /// <summary> Descriptor that unambiguously describes how the bits of a pixel are stored in the up to 4 data planes of an image. It also stores the subsampling factors and number of components. </summary>
    public unsafe struct AVPixFmtDescriptor
    {
        public byte* @name;
        /// <summary> The number of components each pixel has, (1-4) </summary>
        public byte @nb_components;
        /// <summary> Amount to shift the luma width right to find the chroma width. For YV12 this is 1 for example. chroma_width = AV_CEIL_RSHIFT(luma_width, log2_chroma_w) The note above is needed to ensure rounding up. This value only refers to the chroma components. </summary>
        public byte @log2_chroma_w;
        /// <summary> Amount to shift the luma height right to find the chroma height. For YV12 this is 1 for example. chroma_height= AV_CEIL_RSHIFT(luma_height, log2_chroma_h) The note above is needed to ensure rounding up. This value only refers to the chroma components. </summary>
        public byte @log2_chroma_h;
        /// <summary> Combination of AV_PIX_FMT_FLAG_... flags. </summary>
        public ulong @flags;
        /// <summary> Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V. </summary>
        public AVComponentDescriptor @comp0;
        /// <summary> Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V. </summary>
        public AVComponentDescriptor @comp1;
        /// <summary> Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V. </summary>
        public AVComponentDescriptor @comp2;
        /// <summary> Parameters that describe how pixels are packed. If the format has 1 or 2 components, then luma is 0. If the format has 3 or 4 components: if the RGB flag is set then 0 is red, 1 is green and 2 is blue; otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V. </summary>
        public AVComponentDescriptor @comp3;
        /// <summary> Alternative comma-separated names. </summary>
        public byte* @alias;
    }
    
    public unsafe static partial class ffmpeg
    {
        /// <summary> Return the LIBAVUTIL_VERSION_INT constant. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint avutil_version();
        
        /// <summary> Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_version_info();
        
        /// <summary> Return the libavutil build-time configuration. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* avutil_configuration();
        
        /// <summary> Return the libavutil license. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* avutil_license();
        
        /// <summary> Return a string describing the media_type enum, NULL if media_type is unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_media_type_string();
        
        /// <summary> Return a single letter to describe the given picture type pict_type. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte av_get_picture_type_char();
        
        /// <summary> Return x default pointer in case p is NULL. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_x_if_null();
        
        /// <summary> Compute the length of an integer list. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_int_list_length_for_size();
        
        /// <summary> Open a file using a UTF-8 filename. The API of this function matches POSIX fopen(), errors are returned through errno. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern FILE* av_fopen_utf8();
        
        /// <summary> Return the fractional representation of the internal time base. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_get_time_base_q();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log2();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log2_16bit();
        
        /// <summary> Clip a signed integer value into the amin-amax range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_clip_c();
        
        /// <summary> Clip a signed 64bit integer value into the amin-amax range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_clip64_c();
        
        /// <summary> Clip a signed integer value into the 0-255 range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte av_clip_uint8_c();
        
        /// <summary> Clip a signed integer value into the -128,127 range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern sbyte av_clip_int8_c();
        
        /// <summary> Clip a signed integer value into the 0-65535 range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ushort av_clip_uint16_c();
        
        /// <summary> Clip a signed integer value into the -32768,32767 range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern short av_clip_int16_c();
        
        /// <summary> Clip a signed 64-bit integer value into the -2147483648,2147483647 range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_clipl_int32_c();
        
        /// <summary> Clip a signed integer into the -(2^p),(2^p-1) range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_clip_intp2_c();
        
        /// <summary> Clip a signed integer to an unsigned power of two range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_clip_uintp2_c();
        
        /// <summary> Clear high bits from an unsigned integer starting with specific bit position </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_mod_uintp2_c();
        
        /// <summary> Add two signed 32-bit values with saturation. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_sat_add32_c();
        
        /// <summary> Add a doubled value to another value with saturation at both stages. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_sat_dadd32_c();
        
        /// <summary> Clip a float value into the amin-amax range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern float av_clipf_c();
        
        /// <summary> Clip a double value into the amin-amax range. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern double av_clipd_c();
        
        /// <summary> Compute ceil(log2(x)). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_ceil_log2_c();
        
        /// <summary> Count number of bits set to one in x </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_popcount_c();
        
        /// <summary> Count number of bits set to one in x </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_popcount64_c();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parity_c();
        
        /// <summary> Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_strerror();
        
        /// <summary> Fill the provided buffer with a string containing an error string corresponding to the AVERROR code errnum. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_make_error_string();
        
        /// <summary> Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_malloc();
        
        /// <summary> Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_mallocz();
        
        /// <summary> Allocate a memory block for an array with av_malloc(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_malloc_array();
        
        /// <summary> Allocate a memory block for an array with av_mallocz(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_mallocz_array();
        
        /// <summary> Non-inlined equivalent of av_mallocz_array(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_calloc();
        
        /// <summary> Allocate, reallocate, or free a block of memory. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc();
        
        /// <summary> Allocate, reallocate, or free a block of memory through a pointer to a pointer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reallocp();
        
        /// <summary> Allocate, reallocate, or free a block of memory. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc_f();
        
        /// <summary> Allocate, reallocate, or free an array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_realloc_array();
        
        /// <summary> Allocate, reallocate, or free an array through a pointer to a pointer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reallocp_array();
        
        /// <summary> Reallocate the given buffer if it is not large enough, otherwise do nothing. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_fast_realloc();
        
        /// <summary> Allocate a buffer, reusing the given one if large enough. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_malloc();
        
        /// <summary> Allocate and clear a buffer, reusing the given one if large enough. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fast_mallocz();
        
        /// <summary> Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_free();
        
        /// <summary> Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_freep();
        
        /// <summary> Duplicate a string. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_strdup();
        
        /// <summary> Duplicate a substring of a string. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_strndup();
        
        /// <summary> Duplicate a buffer with av_malloc(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_memdup();
        
        /// <summary> Overlapping memcpy() implementation. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_memcpy_backptr();
        
        /// <summary> Add the pointer to an element to a dynamic array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_dynarray_add();
        
        /// <summary> Add an element to a dynamic array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dynarray_add_nofree();
        
        /// <summary> Add an element of size `elem_size` to a dynamic array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_dynarray2_add();
        
        /// <summary> Multiply two `size_t` values checking for overflow. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_size_mult();
        
        /// <summary> Set the maximum size that may be allocated in one block. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_max_alloc();
        
        /// <summary> Create an AVRational. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_make_q();
        
        /// <summary> Compare two rationals. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_cmp_q();
        
        /// <summary> Convert an AVRational to a `double`. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern double av_q2d();
        
        /// <summary> Reduce a fraction. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_reduce();
        
        /// <summary> Multiply two rationals. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_mul_q();
        
        /// <summary> Divide one rational by another. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_div_q();
        
        /// <summary> Add two rationals. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_add_q();
        
        /// <summary> Subtract one rational from another. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_sub_q();
        
        /// <summary> Invert a rational. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_inv_q();
        
        /// <summary> Convert a double precision floating point number to a rational. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVRational av_d2q();
        
        /// <summary> Find which of the two rationals is closer to another rational. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_nearer_q();
        
        /// <summary> Find the value in a list of rationals nearest a given reference rational. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_find_nearest_q_idx();
        
        /// <summary> Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_q2intfloat();
        
        /// <summary> Reinterpret a 32-bit integer as a float. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern float av_int2float();
        
        /// <summary> Reinterpret a float as a 32-bit integer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint av_float2int();
        
        /// <summary> Reinterpret a 64-bit integer as a double. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern double av_int2double();
        
        /// <summary> Reinterpret a double as a 64-bit integer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_double2int();
        
        /// <summary> Compute the greatest common divisor of two integer operands. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_gcd();
        
        /// <summary> Rescale a 64-bit integer with rounding to nearest. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale();
        
        /// <summary> Rescale a 64-bit integer with specified rounding. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_rnd();
        
        /// <summary> Rescale a 64-bit integer by 2 rational numbers. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_q();
        
        /// <summary> Rescale a 64-bit integer by 2 rational numbers with specified rounding. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_q_rnd();
        
        /// <summary> Compare two timestamps each in its own time base. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_compare_ts();
        
        /// <summary> Compare the remainders of two integer operands divided by a common divisor. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_compare_mod();
        
        /// <summary> Rescale a timestamp while preserving known durations. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_rescale_delta();
        
        /// <summary> Add a value to a timestamp. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_add_stable();
        
        /// <summary> Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log();
        
        /// <summary> Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_vlog();
        
        /// <summary> Get the current log level </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_get_level();
        
        /// <summary> Set the log level </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_level();
        
        /// <summary> Set the logging callback </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_callback();
        
        /// <summary> Default logging callback </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_default_callback();
        
        /// <summary> Return the context name </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_default_item_name();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClassCategory av_default_get_category();
        
        /// <summary> Format a line of log the same way as the default callback. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_format_line();
        
        /// <summary> Format a line of log the same way as the default callback. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_format_line2();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_log_set_flags();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_log_get_flags();
        
        /// <summary> Initialize an AVFifoBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFifoBuffer* av_fifo_alloc();
        
        /// <summary> Initialize an AVFifoBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFifoBuffer* av_fifo_alloc_array();
        
        /// <summary> Free an AVFifoBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_free();
        
        /// <summary> Free an AVFifoBuffer and reset pointer to NULL. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_freep();
        
        /// <summary> Reset the AVFifoBuffer to the state right after av_fifo_alloc, in particular it is emptied. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_reset();
        
        /// <summary> Return the amount of data in bytes in the AVFifoBuffer, that is the amount of data you can read from it. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_size();
        
        /// <summary> Return the amount of space in bytes in the AVFifoBuffer, that is the amount of data you can write into it. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_space();
        
        /// <summary> Feed data at specific position from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_peek_at();
        
        /// <summary> Feed data from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_peek();
        
        /// <summary> Feed data from an AVFifoBuffer to a user-supplied callback. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_read();
        
        /// <summary> Feed data from a user-supplied callback to an AVFifoBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_generic_write();
        
        /// <summary> Resize an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_realloc2();
        
        /// <summary> Enlarge an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged. The new fifo size may be larger than the requested size. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_fifo_grow();
        
        /// <summary> Read and discard the specified amount of data from an AVFifoBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_fifo_drain();
        
        /// <summary> Return a pointer to the data stored in a FIFO buffer at a certain offset. The FIFO buffer is not modified. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_fifo_peek2();
        
        /// <summary> Return the name of sample_fmt, or NULL if sample_fmt is not recognized. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_sample_fmt_name();
        
        /// <summary> Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_sample_fmt();
        
        /// <summary> Return the planar<->packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_alt_sample_fmt();
        
        /// <summary> Get the packed alternative form of the given sample format. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_packed_sample_fmt();
        
        /// <summary> Get the planar alternative form of the given sample format. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVSampleFormat av_get_planar_sample_fmt();
        
        /// <summary> Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_sample_fmt_string();
        
        /// <summary> Return number of bytes per sample. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_bytes_per_sample();
        
        /// <summary> Check if the sample format is planar. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_sample_fmt_is_planar();
        
        /// <summary> Get the required buffer size for the given audio parameters. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_get_buffer_size();
        
        /// <summary> Fill plane data pointers and linesize for samples with sample format sample_fmt. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_fill_arrays();
        
        /// <summary> Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&audio_data[0]) Allocated data will be initialized to silence. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_alloc();
        
        /// <summary> Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_alloc_array_and_samples();
        
        /// <summary> Copy samples from src to dst. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_copy();
        
        /// <summary> Fill an audio buffer with silence. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_samples_set_silence();
        
        /// <summary> Free an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_audio_fifo_free();
        
        /// <summary> Allocate an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVAudioFifo* av_audio_fifo_alloc();
        
        /// <summary> Reallocate an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_realloc();
        
        /// <summary> Write data to an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_write();
        
        /// <summary> Peek data from an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_peek();
        
        /// <summary> Peek data from an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_peek_at();
        
        /// <summary> Read data from an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_read();
        
        /// <summary> Drain data from an AVAudioFifo. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_drain();
        
        /// <summary> Reset the AVAudioFifo buffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_audio_fifo_reset();
        
        /// <summary> Get the current number of samples in the AVAudioFifo available for reading. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_size();
        
        /// <summary> Get the current number of samples in the AVAudioFifo available for writing. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_audio_fifo_space();
        
        /// <summary> Return a channel layout id that matches name, or 0 if no match is found. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_get_channel_layout();
        
        /// <summary> Return a description of a channel layout. If nb_channels is <= 0, it is guessed from the channel_layout. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_get_channel_layout_string();
        
        /// <summary> Append a description of a channel layout to a bprint buffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_bprint_channel_layout();
        
        /// <summary> Return the number of channels in the channel layout. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_channel_layout_nb_channels();
        
        /// <summary> Return default channel layout for a given number of channels. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_get_default_channel_layout();
        
        /// <summary> Get the index of a channel in channel_layout. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_channel_layout_channel_index();
        
        /// <summary> Get the channel with the given index in channel_layout. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong av_channel_layout_extract_channel();
        
        /// <summary> Get the name of a given channel. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_channel_name();
        
        /// <summary> Get the description of a given channel. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_channel_description();
        
        /// <summary> Get the value and name of a standard channel layout. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_standard_channel_layout();
        
        /// <summary> Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_cpu_flags();
        
        /// <summary> Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_force_cpu_flags();
        
        /// <summary> Set a mask on flags returned by av_get_cpu_flags(). This function is mainly useful for testing. Please use av_force_cpu_flags() and av_get_cpu_flags() instead which are more flexible </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_set_cpu_flags_mask();
        
        /// <summary> Parse CPU flags from a string. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parse_cpu_flags();
        
        /// <summary> Parse CPU caps from a string and update the given AV_CPU_* flags based on that. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_parse_cpu_caps();
        
        /// <summary> Returns the number of logical CPU cores present. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_cpu_count();
        
        /// <summary> Allocate an AVBuffer of the given size using av_malloc(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_alloc();
        
        /// <summary> Same as av_buffer_alloc(), except the returned buffer will be initialized to zero. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_allocz();
        
        /// <summary> Create an AVBuffer from an existing array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_create();
        
        /// <summary> Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_default_free();
        
        /// <summary> Create a new reference to an AVBuffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_ref();
        
        /// <summary> Free a given reference and automatically free the buffer if there are no more references to it. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_unref();
        
        /// <summary> Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_is_writable();
        
        /// <summary> Returns the opaque parameter set by av_buffer_create. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_buffer_get_opaque();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_get_ref_count();
        
        /// <summary> Create a writable reference from a given buffer reference, avoiding data copy if possible. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_make_writable();
        
        /// <summary> Reallocate a given buffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_buffer_realloc();
        
        /// <summary> Allocate and initialize a buffer pool. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferPool* av_buffer_pool_init();
        
        /// <summary> Allocate and initialize a buffer pool with a more complex allocator. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferPool* av_buffer_pool_init2();
        
        /// <summary> Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_buffer_pool_uninit();
        
        /// <summary> Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_buffer_pool_get();
        
        /// <summary> Get a dictionary entry with matching key. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDictionaryEntry* av_dict_get();
        
        /// <summary> Get number of entries in dictionary. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_count();
        
        /// <summary> Set the given entry in *pm, overwriting an existing entry. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_set();
        
        /// <summary> Convenience wrapper for av_dict_set that converts the value to a string and stores it. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_set_int();
        
        /// <summary> Parse the key/value pairs list and add the parsed entries to a dictionary. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_parse_string();
        
        /// <summary> Copy entries from one AVDictionary struct into another. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_copy();
        
        /// <summary> Free all the memory allocated for an AVDictionary struct and all keys and values. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_dict_free();
        
        /// <summary> Get dictionary entries as a string. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_dict_get_string();
        
        /// <summary> Accessors for some AVFrame fields. The position of these field in the structure is not part of the ABI, they should not be accessed directly outside libavutil. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_best_effort_timestamp();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_best_effort_timestamp();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_pkt_duration();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_duration();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_pkt_pos();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_pos();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long av_frame_get_channel_layout();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_channel_layout();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_channels();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_channels();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_sample_rate();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_sample_rate();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVDictionary* av_frame_get_metadata();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_metadata();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_decode_error_flags();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_decode_error_flags();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_pkt_size();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_pkt_size();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr avpriv_frame_get_metadatap();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern sbyte* av_frame_get_qp_table();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_set_qp_table();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVColorSpace av_frame_get_colorspace();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_colorspace();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVColorRange av_frame_get_color_range();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_set_color_range();
        
        /// <summary> Get the name of a colorspace. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_colorspace_name();
        
        /// <summary> Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free(). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrame* av_frame_alloc();
        
        /// <summary> Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_free();
        
        /// <summary> Set up a new reference to the data described by the source frame. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_ref();
        
        /// <summary> Create a new frame that references the same data as src. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrame* av_frame_clone();
        
        /// <summary> Unreference all the buffers referenced by frame and reset the frame fields. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_unref();
        
        /// <summary> Move everything contained in src to dst and reset src. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_move_ref();
        
        /// <summary> Allocate new buffer(s) for audio or video data. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_get_buffer();
        
        /// <summary> Check if the frame data is writable. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_is_writable();
        
        /// <summary> Ensure that the frame data is writable, avoiding data copy if possible. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_make_writable();
        
        /// <summary> Copy the frame data from src to dst. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_copy();
        
        /// <summary> Copy only "metadata" fields from src to dst. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_frame_copy_props();
        
        /// <summary> Get the buffer reference a given data plane is stored in. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVBufferRef* av_frame_get_plane_buffer();
        
        /// <summary> Add a new side data to a frame. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrameSideData* av_frame_new_side_data();
        
        /// <summary> Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVFrameSideData* av_frame_get_side_data();
        
        /// <summary> If side data of the supplied type exists in the frame, free it and remove it from the frame. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_frame_remove_side_data();
        
        /// <summary> Returns a string identifying the side data type </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_frame_side_data_name();
        
        /// <summary> Show the obj options. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_show2();
        
        /// <summary> Set the values of all AVOption fields to their default values. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_set_defaults();
        
        /// <summary> Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt->flags & mask) == flags will have their default applied to s. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_set_defaults2();
        
        /// <summary> Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_set_options_string();
        
        /// <summary> Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_from_string();
        
        /// <summary> Free all allocated objects in obj. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_free();
        
        /// <summary> Check whether a particular flag is set in a flags field. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_flag_is_set();
        
        /// <summary> Set all the options from a given dictionary on an object. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict();
        
        /// <summary> Set all the options from a given dictionary on an object. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict2();
        
        /// <summary> Extract a key-value pair from the beginning of a string. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_key_value();
        
        /// <summary> @{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_flags();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_int();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_int64();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_float();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_double();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_eval_q();
        
        /// <summary> Look for an option in an object. Consider only options which have all the specified flags set. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_find();
        
        /// <summary> Look for an option in an object. Consider only options which have all the specified flags set. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_find2();
        
        /// <summary> Iterate over all AVOptions belonging to obj. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVOption* av_opt_next();
        
        /// <summary> Iterate over AVOptions-enabled children of obj. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_opt_child_next();
        
        /// <summary> Iterate over potential AVOptions-enabled children of parent. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVClass* av_opt_child_class_next();
        
        /// <summary> @{ Those functions set the field of obj with the given name to value. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_int();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_double();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_q();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_bin();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_image_size();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_pixel_fmt();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_sample_fmt();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_video_rate();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_channel_layout();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_set_dict_val();
        
        /// <summary> @{ Those functions get a value of the option with the given name from an object. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_int();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_double();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_q();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_image_size();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_pixel_fmt();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_sample_fmt();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_video_rate();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_channel_layout();
        
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_get_dict_val();
        
        /// <summary> @} </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* av_opt_ptr();
        
        /// <summary> Free an AVOptionRanges struct and set it to NULL. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_opt_freep_ranges();
        
        /// <summary> Get a list of allowed ranges for the given option. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_query_ranges();
        
        /// <summary> Copy options from src object into dest object. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_copy();
        
        /// <summary> Get a default list of allowed ranges for the given option. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_query_ranges_default();
        
        /// <summary> Check if given option is set to its default value. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_is_set_to_default();
        
        /// <summary> Check if given option is set to its default value. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_is_set_to_default_by_name();
        
        /// <summary> Serialize object's options. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_opt_serialize();
        
        /// <summary> Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_bits_per_pixel();
        
        /// <summary> Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_padded_bits_per_pixel();
        
        /// <summary> Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get();
        
        /// <summary> Iterate over all pixel format descriptors known to libavutil. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next();
        
        /// <summary> Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_pix_fmt_desc_get_id();
        
        /// <summary> Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_pix_fmt_get_chroma_sub_sample();
        
        /// <summary> Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_pix_fmt_count_planes();
        
        /// <summary> Returns the name for provided color range or NULL if unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_color_range_name();
        
        /// <summary> Returns the name for provided color primaries or NULL if unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_color_primaries_name();
        
        /// <summary> Returns the name for provided color transfer or NULL if unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_color_transfer_name();
        
        /// <summary> Returns the name for provided color space or NULL if unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_color_space_name();
        
        /// <summary> Returns the name for provided chroma location or NULL if unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_chroma_location_name();
        
        /// <summary> Return the pixel format corresponding to name. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_get_pix_fmt();
        
        /// <summary> Return the short name for a pixel format, NULL in case pix_fmt is unknown. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_pix_fmt_name();
        
        /// <summary> Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern byte* av_get_pix_fmt_string();
        
        /// <summary> Read a line from an image, and write the values of the pixel format component c to dst. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_read_image_line();
        
        /// <summary> Write the values from src to the pixel format component c of an image line. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_write_image_line();
        
        /// <summary> Utility function to swap the endianness of a pixel format. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_pix_fmt_swap_endianness();
        
        /// <summary> Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_get_pix_fmt_loss();
        
        /// <summary> Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AVPixelFormat av_find_best_pix_fmt_of_2();
        
        /// <summary> Compute the max pixel step for each plane of an image with a format described by pixdesc. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_fill_max_pixsteps();
        
        /// <summary> Compute the size of an image line with format pix_fmt and width width for the plane plane. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_get_linesize();
        
        /// <summary> Fill plane linesizes for an image with pixel format pix_fmt and width width. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_linesizes();
        
        /// <summary> Fill plane data pointers for an image with pixel format pix_fmt and height height. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_pointers();
        
        /// <summary> Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&pointers[0]). </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_alloc();
        
        /// <summary> Copy image plane from src to dst. That is, copy "height" number of lines of "bytewidth" bytes each. The first byte of each successive line is separated by *_linesize bytes. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_copy_plane();
        
        /// <summary> Copy image in src_data to dst_data. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void av_image_copy();
        
        /// <summary> Setup the data pointers and linesizes based on the specified image parameters and the provided array. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_fill_arrays();
        
        /// <summary> Return the size in bytes of the amount of data required to store an image with the given parameters. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_get_buffer_size();
        
        /// <summary> Copy image data from an image into a buffer. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_copy_to_buffer();
        
        /// <summary> Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_check_size();
        
        /// <summary> Check if the given sample aspect ratio of an image is valid. </summary>
        [DllImport(todo, EntryPoint = "todo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int av_image_check_sar();
        
    }
}
