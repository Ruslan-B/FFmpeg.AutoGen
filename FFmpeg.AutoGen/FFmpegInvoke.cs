using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
	using AVClassCategory=anon_9;
	
	public enum AVMediaType
	{
		AVMEDIA_TYPE_UNKNOWN = -0x1, // (-1)
		AVMEDIA_TYPE_VIDEO,
		AVMEDIA_TYPE_AUDIO,
		AVMEDIA_TYPE_DATA,
		AVMEDIA_TYPE_SUBTITLE,
		AVMEDIA_TYPE_ATTACHMENT,
		AVMEDIA_TYPE_NB,
	}
	
	public enum AVPictureType
	{
		AV_PICTURE_TYPE_NONE,
		AV_PICTURE_TYPE_I,
		AV_PICTURE_TYPE_P,
		AV_PICTURE_TYPE_B,
		AV_PICTURE_TYPE_S,
		AV_PICTURE_TYPE_SI,
		AV_PICTURE_TYPE_SP,
		AV_PICTURE_TYPE_BI,
	}
	
	public enum AVRounding
	{
		AV_ROUND_ZERO,
		AV_ROUND_INF,
		AV_ROUND_DOWN,
		AV_ROUND_UP,
		AV_ROUND_NEAR_INF = 0x5, // 5
		AV_ROUND_PASS_MINMAX = 0x2000, // 8192
	}
	
	public enum anon_9
	{
		AV_CLASS_CATEGORY_NA,
		AV_CLASS_CATEGORY_INPUT,
		AV_CLASS_CATEGORY_OUTPUT,
		AV_CLASS_CATEGORY_MUXER,
		AV_CLASS_CATEGORY_DEMUXER,
		AV_CLASS_CATEGORY_ENCODER,
		AV_CLASS_CATEGORY_DECODER,
		AV_CLASS_CATEGORY_FILTER,
		AV_CLASS_CATEGORY_BITSTREAM_FILTER,
		AV_CLASS_CATEGORY_SWSCALER,
		AV_CLASS_CATEGORY_SWRESAMPLER,
		AV_CLASS_CATEGORY_NB,
	}
	
	public enum AVPixelFormat
	{
		AV_PIX_FMT_NONE = -0x1, // (-1)
		AV_PIX_FMT_YUV420P,
		AV_PIX_FMT_YUYV422,
		AV_PIX_FMT_RGB24,
		AV_PIX_FMT_BGR24,
		AV_PIX_FMT_YUV422P,
		AV_PIX_FMT_YUV444P,
		AV_PIX_FMT_YUV410P,
		AV_PIX_FMT_YUV411P,
		AV_PIX_FMT_GRAY8,
		AV_PIX_FMT_MONOWHITE,
		AV_PIX_FMT_MONOBLACK,
		AV_PIX_FMT_PAL8,
		AV_PIX_FMT_YUVJ420P,
		AV_PIX_FMT_YUVJ422P,
		AV_PIX_FMT_YUVJ444P,
		AV_PIX_FMT_XVMC_MPEG2_MC,
		AV_PIX_FMT_XVMC_MPEG2_IDCT,
		AV_PIX_FMT_UYVY422,
		AV_PIX_FMT_UYYVYY411,
		AV_PIX_FMT_BGR8,
		AV_PIX_FMT_BGR4,
		AV_PIX_FMT_BGR4_BYTE,
		AV_PIX_FMT_RGB8,
		AV_PIX_FMT_RGB4,
		AV_PIX_FMT_RGB4_BYTE,
		AV_PIX_FMT_NV12,
		AV_PIX_FMT_NV21,
		AV_PIX_FMT_ARGB,
		AV_PIX_FMT_RGBA,
		AV_PIX_FMT_ABGR,
		AV_PIX_FMT_BGRA,
		AV_PIX_FMT_GRAY16BE,
		AV_PIX_FMT_GRAY16LE,
		AV_PIX_FMT_YUV440P,
		AV_PIX_FMT_YUVJ440P,
		AV_PIX_FMT_YUVA420P,
		AV_PIX_FMT_VDPAU_H264,
		AV_PIX_FMT_VDPAU_MPEG1,
		AV_PIX_FMT_VDPAU_MPEG2,
		AV_PIX_FMT_VDPAU_WMV3,
		AV_PIX_FMT_VDPAU_VC1,
		AV_PIX_FMT_RGB48BE,
		AV_PIX_FMT_RGB48LE,
		AV_PIX_FMT_RGB565BE,
		AV_PIX_FMT_RGB565LE,
		AV_PIX_FMT_RGB555BE,
		AV_PIX_FMT_RGB555LE,
		AV_PIX_FMT_BGR565BE,
		AV_PIX_FMT_BGR565LE,
		AV_PIX_FMT_BGR555BE,
		AV_PIX_FMT_BGR555LE,
		AV_PIX_FMT_VAAPI_MOCO,
		AV_PIX_FMT_VAAPI_IDCT,
		AV_PIX_FMT_VAAPI_VLD,
		AV_PIX_FMT_YUV420P16LE,
		AV_PIX_FMT_YUV420P16BE,
		AV_PIX_FMT_YUV422P16LE,
		AV_PIX_FMT_YUV422P16BE,
		AV_PIX_FMT_YUV444P16LE,
		AV_PIX_FMT_YUV444P16BE,
		AV_PIX_FMT_VDPAU_MPEG4,
		AV_PIX_FMT_DXVA2_VLD,
		AV_PIX_FMT_RGB444LE,
		AV_PIX_FMT_RGB444BE,
		AV_PIX_FMT_BGR444LE,
		AV_PIX_FMT_BGR444BE,
		AV_PIX_FMT_GRAY8A,
		AV_PIX_FMT_BGR48BE,
		AV_PIX_FMT_BGR48LE,
		AV_PIX_FMT_YUV420P9BE,
		AV_PIX_FMT_YUV420P9LE,
		AV_PIX_FMT_YUV420P10BE,
		AV_PIX_FMT_YUV420P10LE,
		AV_PIX_FMT_YUV422P10BE,
		AV_PIX_FMT_YUV422P10LE,
		AV_PIX_FMT_YUV444P9BE,
		AV_PIX_FMT_YUV444P9LE,
		AV_PIX_FMT_YUV444P10BE,
		AV_PIX_FMT_YUV444P10LE,
		AV_PIX_FMT_YUV422P9BE,
		AV_PIX_FMT_YUV422P9LE,
		AV_PIX_FMT_VDA_VLD,
		AV_PIX_FMT_GBRP,
		AV_PIX_FMT_GBRP9BE,
		AV_PIX_FMT_GBRP9LE,
		AV_PIX_FMT_GBRP10BE,
		AV_PIX_FMT_GBRP10LE,
		AV_PIX_FMT_GBRP16BE,
		AV_PIX_FMT_GBRP16LE,
		AV_PIX_FMT_YUVA422P_LIBAV,
		AV_PIX_FMT_YUVA444P_LIBAV,
		AV_PIX_FMT_YUVA420P9BE,
		AV_PIX_FMT_YUVA420P9LE,
		AV_PIX_FMT_YUVA422P9BE,
		AV_PIX_FMT_YUVA422P9LE,
		AV_PIX_FMT_YUVA444P9BE,
		AV_PIX_FMT_YUVA444P9LE,
		AV_PIX_FMT_YUVA420P10BE,
		AV_PIX_FMT_YUVA420P10LE,
		AV_PIX_FMT_YUVA422P10BE,
		AV_PIX_FMT_YUVA422P10LE,
		AV_PIX_FMT_YUVA444P10BE,
		AV_PIX_FMT_YUVA444P10LE,
		AV_PIX_FMT_YUVA420P16BE,
		AV_PIX_FMT_YUVA420P16LE,
		AV_PIX_FMT_YUVA422P16BE,
		AV_PIX_FMT_YUVA422P16LE,
		AV_PIX_FMT_YUVA444P16BE,
		AV_PIX_FMT_YUVA444P16LE,
		AV_PIX_FMT_VDPAU,
		AV_PIX_FMT_XYZ12LE,
		AV_PIX_FMT_XYZ12BE,
		AV_PIX_FMT_RGBA64BE = 0x123, // 291
		AV_PIX_FMT_RGBA64LE,
		AV_PIX_FMT_BGRA64BE,
		AV_PIX_FMT_BGRA64LE,
		AV_PIX_FMT_0RGB,
		AV_PIX_FMT_RGB0,
		AV_PIX_FMT_0BGR,
		AV_PIX_FMT_BGR0,
		AV_PIX_FMT_YUVA444P,
		AV_PIX_FMT_YUVA422P,
		AV_PIX_FMT_YUV420P12BE,
		AV_PIX_FMT_YUV420P12LE,
		AV_PIX_FMT_YUV420P14BE,
		AV_PIX_FMT_YUV420P14LE,
		AV_PIX_FMT_YUV422P12BE,
		AV_PIX_FMT_YUV422P12LE,
		AV_PIX_FMT_YUV422P14BE,
		AV_PIX_FMT_YUV422P14LE,
		AV_PIX_FMT_YUV444P12BE,
		AV_PIX_FMT_YUV444P12LE,
		AV_PIX_FMT_YUV444P14BE,
		AV_PIX_FMT_YUV444P14LE,
		AV_PIX_FMT_GBRP12BE,
		AV_PIX_FMT_GBRP12LE,
		AV_PIX_FMT_GBRP14BE,
		AV_PIX_FMT_GBRP14LE,
		AV_PIX_FMT_GBRAP,
		AV_PIX_FMT_GBRAP16BE,
		AV_PIX_FMT_GBRAP16LE,
		AV_PIX_FMT_YUVJ411P,
		AV_PIX_FMT_NB,
		PIX_FMT_NONE = -0x1, // AV_PIX_FMT_NONE
		PIX_FMT_YUV420P,
		PIX_FMT_YUYV422,
		PIX_FMT_RGB24,
		PIX_FMT_BGR24,
		PIX_FMT_YUV422P,
		PIX_FMT_YUV444P,
		PIX_FMT_YUV410P,
		PIX_FMT_YUV411P,
		PIX_FMT_GRAY8,
		PIX_FMT_MONOWHITE,
		PIX_FMT_MONOBLACK,
		PIX_FMT_PAL8,
		PIX_FMT_YUVJ420P,
		PIX_FMT_YUVJ422P,
		PIX_FMT_YUVJ444P,
		PIX_FMT_XVMC_MPEG2_MC,
		PIX_FMT_XVMC_MPEG2_IDCT,
		PIX_FMT_UYVY422,
		PIX_FMT_UYYVYY411,
		PIX_FMT_BGR8,
		PIX_FMT_BGR4,
		PIX_FMT_BGR4_BYTE,
		PIX_FMT_RGB8,
		PIX_FMT_RGB4,
		PIX_FMT_RGB4_BYTE,
		PIX_FMT_NV12,
		PIX_FMT_NV21,
		PIX_FMT_ARGB,
		PIX_FMT_RGBA,
		PIX_FMT_ABGR,
		PIX_FMT_BGRA,
		PIX_FMT_GRAY16BE,
		PIX_FMT_GRAY16LE,
		PIX_FMT_YUV440P,
		PIX_FMT_YUVJ440P,
		PIX_FMT_YUVA420P,
		PIX_FMT_VDPAU_H264,
		PIX_FMT_VDPAU_MPEG1,
		PIX_FMT_VDPAU_MPEG2,
		PIX_FMT_VDPAU_WMV3,
		PIX_FMT_VDPAU_VC1,
		PIX_FMT_RGB48BE,
		PIX_FMT_RGB48LE,
		PIX_FMT_RGB565BE,
		PIX_FMT_RGB565LE,
		PIX_FMT_RGB555BE,
		PIX_FMT_RGB555LE,
		PIX_FMT_BGR565BE,
		PIX_FMT_BGR565LE,
		PIX_FMT_BGR555BE,
		PIX_FMT_BGR555LE,
		PIX_FMT_VAAPI_MOCO,
		PIX_FMT_VAAPI_IDCT,
		PIX_FMT_VAAPI_VLD,
		PIX_FMT_YUV420P16LE,
		PIX_FMT_YUV420P16BE,
		PIX_FMT_YUV422P16LE,
		PIX_FMT_YUV422P16BE,
		PIX_FMT_YUV444P16LE,
		PIX_FMT_YUV444P16BE,
		PIX_FMT_VDPAU_MPEG4,
		PIX_FMT_DXVA2_VLD,
		PIX_FMT_RGB444LE,
		PIX_FMT_RGB444BE,
		PIX_FMT_BGR444LE,
		PIX_FMT_BGR444BE,
		PIX_FMT_GRAY8A,
		PIX_FMT_BGR48BE,
		PIX_FMT_BGR48LE,
		PIX_FMT_YUV420P9BE,
		PIX_FMT_YUV420P9LE,
		PIX_FMT_YUV420P10BE,
		PIX_FMT_YUV420P10LE,
		PIX_FMT_YUV422P10BE,
		PIX_FMT_YUV422P10LE,
		PIX_FMT_YUV444P9BE,
		PIX_FMT_YUV444P9LE,
		PIX_FMT_YUV444P10BE,
		PIX_FMT_YUV444P10LE,
		PIX_FMT_YUV422P9BE,
		PIX_FMT_YUV422P9LE,
		PIX_FMT_VDA_VLD,
		PIX_FMT_GBRP,
		PIX_FMT_GBRP9BE,
		PIX_FMT_GBRP9LE,
		PIX_FMT_GBRP10BE,
		PIX_FMT_GBRP10LE,
		PIX_FMT_GBRP16BE,
		PIX_FMT_GBRP16LE,
		PIX_FMT_RGBA64BE = 0x123, // 291
		PIX_FMT_RGBA64LE,
		PIX_FMT_BGRA64BE,
		PIX_FMT_BGRA64LE,
		PIX_FMT_0RGB,
		PIX_FMT_RGB0,
		PIX_FMT_0BGR,
		PIX_FMT_BGR0,
		PIX_FMT_YUVA444P,
		PIX_FMT_YUVA422P,
		PIX_FMT_YUV420P12BE,
		PIX_FMT_YUV420P12LE,
		PIX_FMT_YUV420P14BE,
		PIX_FMT_YUV420P14LE,
		PIX_FMT_YUV422P12BE,
		PIX_FMT_YUV422P12LE,
		PIX_FMT_YUV422P14BE,
		PIX_FMT_YUV422P14LE,
		PIX_FMT_YUV444P12BE,
		PIX_FMT_YUV444P12LE,
		PIX_FMT_YUV444P14BE,
		PIX_FMT_YUV444P14LE,
		PIX_FMT_GBRP12BE,
		PIX_FMT_GBRP12LE,
		PIX_FMT_GBRP14BE,
		PIX_FMT_GBRP14LE,
		PIX_FMT_NB,
	}
	
	public enum AVSampleFormat
	{
		AV_SAMPLE_FMT_NONE = -0x1, // (-1)
		AV_SAMPLE_FMT_U8,
		AV_SAMPLE_FMT_S16,
		AV_SAMPLE_FMT_S32,
		AV_SAMPLE_FMT_FLT,
		AV_SAMPLE_FMT_DBL,
		AV_SAMPLE_FMT_U8P,
		AV_SAMPLE_FMT_S16P,
		AV_SAMPLE_FMT_S32P,
		AV_SAMPLE_FMT_FLTP,
		AV_SAMPLE_FMT_DBLP,
		AV_SAMPLE_FMT_NB,
	}
	
	public enum AVMatrixEncoding
	{
		AV_MATRIX_ENCODING_NONE,
		AV_MATRIX_ENCODING_DOLBY,
		AV_MATRIX_ENCODING_DPLII,
		AV_MATRIX_ENCODING_NB,
	}
	
	public enum AVFrameSideDataType
	{
		AV_FRAME_DATA_PANSCAN,
	}
	
	public enum AVCodecID
	{
		AV_CODEC_ID_NONE,
		AV_CODEC_ID_MPEG1VIDEO,
		AV_CODEC_ID_MPEG2VIDEO,
		AV_CODEC_ID_MPEG2VIDEO_XVMC,
		AV_CODEC_ID_H261,
		AV_CODEC_ID_H263,
		AV_CODEC_ID_RV10,
		AV_CODEC_ID_RV20,
		AV_CODEC_ID_MJPEG,
		AV_CODEC_ID_MJPEGB,
		AV_CODEC_ID_LJPEG,
		AV_CODEC_ID_SP5X,
		AV_CODEC_ID_JPEGLS,
		AV_CODEC_ID_MPEG4,
		AV_CODEC_ID_RAWVIDEO,
		AV_CODEC_ID_MSMPEG4V1,
		AV_CODEC_ID_MSMPEG4V2,
		AV_CODEC_ID_MSMPEG4V3,
		AV_CODEC_ID_WMV1,
		AV_CODEC_ID_WMV2,
		AV_CODEC_ID_H263P,
		AV_CODEC_ID_H263I,
		AV_CODEC_ID_FLV1,
		AV_CODEC_ID_SVQ1,
		AV_CODEC_ID_SVQ3,
		AV_CODEC_ID_DVVIDEO,
		AV_CODEC_ID_HUFFYUV,
		AV_CODEC_ID_CYUV,
		AV_CODEC_ID_H264,
		AV_CODEC_ID_INDEO3,
		AV_CODEC_ID_VP3,
		AV_CODEC_ID_THEORA,
		AV_CODEC_ID_ASV1,
		AV_CODEC_ID_ASV2,
		AV_CODEC_ID_FFV1,
		AV_CODEC_ID_4XM,
		AV_CODEC_ID_VCR1,
		AV_CODEC_ID_CLJR,
		AV_CODEC_ID_MDEC,
		AV_CODEC_ID_ROQ,
		AV_CODEC_ID_INTERPLAY_VIDEO,
		AV_CODEC_ID_XAN_WC3,
		AV_CODEC_ID_XAN_WC4,
		AV_CODEC_ID_RPZA,
		AV_CODEC_ID_CINEPAK,
		AV_CODEC_ID_WS_VQA,
		AV_CODEC_ID_MSRLE,
		AV_CODEC_ID_MSVIDEO1,
		AV_CODEC_ID_IDCIN,
		AV_CODEC_ID_8BPS,
		AV_CODEC_ID_SMC,
		AV_CODEC_ID_FLIC,
		AV_CODEC_ID_TRUEMOTION1,
		AV_CODEC_ID_VMDVIDEO,
		AV_CODEC_ID_MSZH,
		AV_CODEC_ID_ZLIB,
		AV_CODEC_ID_QTRLE,
		AV_CODEC_ID_TSCC,
		AV_CODEC_ID_ULTI,
		AV_CODEC_ID_QDRAW,
		AV_CODEC_ID_VIXL,
		AV_CODEC_ID_QPEG,
		AV_CODEC_ID_PNG,
		AV_CODEC_ID_PPM,
		AV_CODEC_ID_PBM,
		AV_CODEC_ID_PGM,
		AV_CODEC_ID_PGMYUV,
		AV_CODEC_ID_PAM,
		AV_CODEC_ID_FFVHUFF,
		AV_CODEC_ID_RV30,
		AV_CODEC_ID_RV40,
		AV_CODEC_ID_VC1,
		AV_CODEC_ID_WMV3,
		AV_CODEC_ID_LOCO,
		AV_CODEC_ID_WNV1,
		AV_CODEC_ID_AASC,
		AV_CODEC_ID_INDEO2,
		AV_CODEC_ID_FRAPS,
		AV_CODEC_ID_TRUEMOTION2,
		AV_CODEC_ID_BMP,
		AV_CODEC_ID_CSCD,
		AV_CODEC_ID_MMVIDEO,
		AV_CODEC_ID_ZMBV,
		AV_CODEC_ID_AVS,
		AV_CODEC_ID_SMACKVIDEO,
		AV_CODEC_ID_NUV,
		AV_CODEC_ID_KMVC,
		AV_CODEC_ID_FLASHSV,
		AV_CODEC_ID_CAVS,
		AV_CODEC_ID_JPEG2000,
		AV_CODEC_ID_VMNC,
		AV_CODEC_ID_VP5,
		AV_CODEC_ID_VP6,
		AV_CODEC_ID_VP6F,
		AV_CODEC_ID_TARGA,
		AV_CODEC_ID_DSICINVIDEO,
		AV_CODEC_ID_TIERTEXSEQVIDEO,
		AV_CODEC_ID_TIFF,
		AV_CODEC_ID_GIF,
		AV_CODEC_ID_DXA,
		AV_CODEC_ID_DNXHD,
		AV_CODEC_ID_THP,
		AV_CODEC_ID_SGI,
		AV_CODEC_ID_C93,
		AV_CODEC_ID_BETHSOFTVID,
		AV_CODEC_ID_PTX,
		AV_CODEC_ID_TXD,
		AV_CODEC_ID_VP6A,
		AV_CODEC_ID_AMV,
		AV_CODEC_ID_VB,
		AV_CODEC_ID_PCX,
		AV_CODEC_ID_SUNRAST,
		AV_CODEC_ID_INDEO4,
		AV_CODEC_ID_INDEO5,
		AV_CODEC_ID_MIMIC,
		AV_CODEC_ID_RL2,
		AV_CODEC_ID_ESCAPE124,
		AV_CODEC_ID_DIRAC,
		AV_CODEC_ID_BFI,
		AV_CODEC_ID_CMV,
		AV_CODEC_ID_MOTIONPIXELS,
		AV_CODEC_ID_TGV,
		AV_CODEC_ID_TGQ,
		AV_CODEC_ID_TQI,
		AV_CODEC_ID_AURA,
		AV_CODEC_ID_AURA2,
		AV_CODEC_ID_V210X,
		AV_CODEC_ID_TMV,
		AV_CODEC_ID_V210,
		AV_CODEC_ID_DPX,
		AV_CODEC_ID_MAD,
		AV_CODEC_ID_FRWU,
		AV_CODEC_ID_FLASHSV2,
		AV_CODEC_ID_CDGRAPHICS,
		AV_CODEC_ID_R210,
		AV_CODEC_ID_ANM,
		AV_CODEC_ID_BINKVIDEO,
		AV_CODEC_ID_IFF_ILBM,
		AV_CODEC_ID_IFF_BYTERUN1,
		AV_CODEC_ID_KGV1,
		AV_CODEC_ID_YOP,
		AV_CODEC_ID_VP8,
		AV_CODEC_ID_PICTOR,
		AV_CODEC_ID_ANSI,
		AV_CODEC_ID_A64_MULTI,
		AV_CODEC_ID_A64_MULTI5,
		AV_CODEC_ID_R10K,
		AV_CODEC_ID_MXPEG,
		AV_CODEC_ID_LAGARITH,
		AV_CODEC_ID_PRORES,
		AV_CODEC_ID_JV,
		AV_CODEC_ID_DFA,
		AV_CODEC_ID_WMV3IMAGE,
		AV_CODEC_ID_VC1IMAGE,
		AV_CODEC_ID_UTVIDEO,
		AV_CODEC_ID_BMV_VIDEO,
		AV_CODEC_ID_VBLE,
		AV_CODEC_ID_DXTORY,
		AV_CODEC_ID_V410,
		AV_CODEC_ID_XWD,
		AV_CODEC_ID_CDXL,
		AV_CODEC_ID_XBM,
		AV_CODEC_ID_ZEROCODEC,
		AV_CODEC_ID_MSS1,
		AV_CODEC_ID_MSA1,
		AV_CODEC_ID_TSCC2,
		AV_CODEC_ID_MTS2,
		AV_CODEC_ID_CLLC,
		AV_CODEC_ID_MSS2,
		AV_CODEC_ID_VP9,
		AV_CODEC_ID_AIC,
		AV_CODEC_ID_ESCAPE130_DEPRECATED,
		AV_CODEC_ID_G2M_DEPRECATED,
		AV_CODEC_ID_BRENDER_PIX = 0x42504958, // ((('X' | ('I' << 8)) | ('P' << 16)) | ('B' << 24))
		AV_CODEC_ID_Y41P = 0x59343150, // ((('P' | ('1' << 8)) | ('4' << 16)) | ('Y' << 24))
		AV_CODEC_ID_ESCAPE130 = 0x45313330, // ((('0' | ('3' << 8)) | ('1' << 16)) | ('E' << 24))
		AV_CODEC_ID_EXR = 0x30455852, // ((('R' | ('X' << 8)) | ('E' << 16)) | ('0' << 24))
		AV_CODEC_ID_AVRP = 0x41565250, // ((('P' | ('R' << 8)) | ('V' << 16)) | ('A' << 24))
		AV_CODEC_ID_012V = 0x30313256, // ((('V' | ('2' << 8)) | ('1' << 16)) | ('0' << 24))
		AV_CODEC_ID_G2M = 0x47324d, // ((('M' | ('2' << 8)) | ('G' << 16)) | (0 << 24))
		AV_CODEC_ID_AVUI = 0x41565549, // ((('I' | ('U' << 8)) | ('V' << 16)) | ('A' << 24))
		AV_CODEC_ID_AYUV = 0x41595556, // ((('V' | ('U' << 8)) | ('Y' << 16)) | ('A' << 24))
		AV_CODEC_ID_TARGA_Y216 = 0x54323136, // ((('6' | ('1' << 8)) | ('2' << 16)) | ('T' << 24))
		AV_CODEC_ID_V308 = 0x56333038, // ((('8' | ('0' << 8)) | ('3' << 16)) | ('V' << 24))
		AV_CODEC_ID_V408 = 0x56343038, // ((('8' | ('0' << 8)) | ('4' << 16)) | ('V' << 24))
		AV_CODEC_ID_YUV4 = 0x59555634, // ((('4' | ('V' << 8)) | ('U' << 16)) | ('Y' << 24))
		AV_CODEC_ID_SANM = 0x53414e4d, // ((('M' | ('N' << 8)) | ('A' << 16)) | ('S' << 24))
		AV_CODEC_ID_PAF_VIDEO = 0x50414656, // ((('V' | ('F' << 8)) | ('A' << 16)) | ('P' << 24))
		AV_CODEC_ID_AVRN = 0x4156526e, // ((('n' | ('R' << 8)) | ('V' << 16)) | ('A' << 24))
		AV_CODEC_ID_CPIA = 0x43504941, // ((('A' | ('I' << 8)) | ('P' << 16)) | ('C' << 24))
		AV_CODEC_ID_XFACE = 0x58464143, // ((('C' | ('A' << 8)) | ('F' << 16)) | ('X' << 24))
		AV_CODEC_ID_SGIRLE = 0x53474952, // ((('R' | ('I' << 8)) | ('G' << 16)) | ('S' << 24))
		AV_CODEC_ID_MVC1 = 0x4d564331, // ((('1' | ('C' << 8)) | ('V' << 16)) | ('M' << 24))
		AV_CODEC_ID_MVC2,
		AV_CODEC_ID_SNOW = 0x534e4f57, // ((('W' | ('O' << 8)) | ('N' << 16)) | ('S' << 24))
		AV_CODEC_ID_WEBP = 0x57454250, // ((('P' | ('B' << 8)) | ('E' << 16)) | ('W' << 24))
		AV_CODEC_ID_SMVJPEG = 0x534d564a, // ((('J' | ('V' << 8)) | ('M' << 16)) | ('S' << 24))
		AV_CODEC_ID_FIRST_AUDIO = 0x10000, // 65536
		AV_CODEC_ID_PCM_S16LE = 0x10000, // 65536
		AV_CODEC_ID_PCM_S16BE,
		AV_CODEC_ID_PCM_U16LE,
		AV_CODEC_ID_PCM_U16BE,
		AV_CODEC_ID_PCM_S8,
		AV_CODEC_ID_PCM_U8,
		AV_CODEC_ID_PCM_MULAW,
		AV_CODEC_ID_PCM_ALAW,
		AV_CODEC_ID_PCM_S32LE,
		AV_CODEC_ID_PCM_S32BE,
		AV_CODEC_ID_PCM_U32LE,
		AV_CODEC_ID_PCM_U32BE,
		AV_CODEC_ID_PCM_S24LE,
		AV_CODEC_ID_PCM_S24BE,
		AV_CODEC_ID_PCM_U24LE,
		AV_CODEC_ID_PCM_U24BE,
		AV_CODEC_ID_PCM_S24DAUD,
		AV_CODEC_ID_PCM_ZORK,
		AV_CODEC_ID_PCM_S16LE_PLANAR,
		AV_CODEC_ID_PCM_DVD,
		AV_CODEC_ID_PCM_F32BE,
		AV_CODEC_ID_PCM_F32LE,
		AV_CODEC_ID_PCM_F64BE,
		AV_CODEC_ID_PCM_F64LE,
		AV_CODEC_ID_PCM_BLURAY,
		AV_CODEC_ID_PCM_LXF,
		AV_CODEC_ID_S302M,
		AV_CODEC_ID_PCM_S8_PLANAR,
		AV_CODEC_ID_PCM_S24LE_PLANAR = 0x18505350, // ((('P' | ('S' << 8)) | ('P' << 16)) | (24 << 24))
		AV_CODEC_ID_PCM_S32LE_PLANAR = 0x20505350, // ((('P' | ('S' << 8)) | ('P' << 16)) | (32 << 24))
		AV_CODEC_ID_PCM_S16BE_PLANAR = 0x50535010, // (((16 | ('P' << 8)) | ('S' << 16)) | ('P' << 24))
		AV_CODEC_ID_ADPCM_IMA_QT = 0x11000, // 69632
		AV_CODEC_ID_ADPCM_IMA_WAV,
		AV_CODEC_ID_ADPCM_IMA_DK3,
		AV_CODEC_ID_ADPCM_IMA_DK4,
		AV_CODEC_ID_ADPCM_IMA_WS,
		AV_CODEC_ID_ADPCM_IMA_SMJPEG,
		AV_CODEC_ID_ADPCM_MS,
		AV_CODEC_ID_ADPCM_4XM,
		AV_CODEC_ID_ADPCM_XA,
		AV_CODEC_ID_ADPCM_ADX,
		AV_CODEC_ID_ADPCM_EA,
		AV_CODEC_ID_ADPCM_G726,
		AV_CODEC_ID_ADPCM_CT,
		AV_CODEC_ID_ADPCM_SWF,
		AV_CODEC_ID_ADPCM_YAMAHA,
		AV_CODEC_ID_ADPCM_SBPRO_4,
		AV_CODEC_ID_ADPCM_SBPRO_3,
		AV_CODEC_ID_ADPCM_SBPRO_2,
		AV_CODEC_ID_ADPCM_THP,
		AV_CODEC_ID_ADPCM_IMA_AMV,
		AV_CODEC_ID_ADPCM_EA_R1,
		AV_CODEC_ID_ADPCM_EA_R3,
		AV_CODEC_ID_ADPCM_EA_R2,
		AV_CODEC_ID_ADPCM_IMA_EA_SEAD,
		AV_CODEC_ID_ADPCM_IMA_EA_EACS,
		AV_CODEC_ID_ADPCM_EA_XAS,
		AV_CODEC_ID_ADPCM_EA_MAXIS_XA,
		AV_CODEC_ID_ADPCM_IMA_ISS,
		AV_CODEC_ID_ADPCM_G722,
		AV_CODEC_ID_ADPCM_IMA_APC,
		AV_CODEC_ID_VIMA = 0x56494d41, // ((('A' | ('M' << 8)) | ('I' << 16)) | ('V' << 24))
		AV_CODEC_ID_ADPCM_AFC = 0x41464320, // (((' ' | ('C' << 8)) | ('F' << 16)) | ('A' << 24))
		AV_CODEC_ID_ADPCM_IMA_OKI = 0x4f4b4920, // (((' ' | ('I' << 8)) | ('K' << 16)) | ('O' << 24))
		AV_CODEC_ID_ADPCM_DTK = 0x44544b20, // (((' ' | ('K' << 8)) | ('T' << 16)) | ('D' << 24))
		AV_CODEC_ID_ADPCM_IMA_RAD = 0x52414420, // (((' ' | ('D' << 8)) | ('A' << 16)) | ('R' << 24))
		AV_CODEC_ID_AMR_NB = 0x12000, // 73728
		AV_CODEC_ID_AMR_WB,
		AV_CODEC_ID_RA_144 = 0x13000, // 77824
		AV_CODEC_ID_RA_288,
		AV_CODEC_ID_ROQ_DPCM = 0x14000, // 81920
		AV_CODEC_ID_INTERPLAY_DPCM,
		AV_CODEC_ID_XAN_DPCM,
		AV_CODEC_ID_SOL_DPCM,
		AV_CODEC_ID_MP2 = 0x15000, // 86016
		AV_CODEC_ID_MP3,
		AV_CODEC_ID_AAC,
		AV_CODEC_ID_AC3,
		AV_CODEC_ID_DTS,
		AV_CODEC_ID_VORBIS,
		AV_CODEC_ID_DVAUDIO,
		AV_CODEC_ID_WMAV1,
		AV_CODEC_ID_WMAV2,
		AV_CODEC_ID_MACE3,
		AV_CODEC_ID_MACE6,
		AV_CODEC_ID_VMDAUDIO,
		AV_CODEC_ID_FLAC,
		AV_CODEC_ID_MP3ADU,
		AV_CODEC_ID_MP3ON4,
		AV_CODEC_ID_SHORTEN,
		AV_CODEC_ID_ALAC,
		AV_CODEC_ID_WESTWOOD_SND1,
		AV_CODEC_ID_GSM,
		AV_CODEC_ID_QDM2,
		AV_CODEC_ID_COOK,
		AV_CODEC_ID_TRUESPEECH,
		AV_CODEC_ID_TTA,
		AV_CODEC_ID_SMACKAUDIO,
		AV_CODEC_ID_QCELP,
		AV_CODEC_ID_WAVPACK,
		AV_CODEC_ID_DSICINAUDIO,
		AV_CODEC_ID_IMC,
		AV_CODEC_ID_MUSEPACK7,
		AV_CODEC_ID_MLP,
		AV_CODEC_ID_GSM_MS,
		AV_CODEC_ID_ATRAC3,
		AV_CODEC_ID_VOXWARE,
		AV_CODEC_ID_APE,
		AV_CODEC_ID_NELLYMOSER,
		AV_CODEC_ID_MUSEPACK8,
		AV_CODEC_ID_SPEEX,
		AV_CODEC_ID_WMAVOICE,
		AV_CODEC_ID_WMAPRO,
		AV_CODEC_ID_WMALOSSLESS,
		AV_CODEC_ID_ATRAC3P,
		AV_CODEC_ID_EAC3,
		AV_CODEC_ID_SIPR,
		AV_CODEC_ID_MP1,
		AV_CODEC_ID_TWINVQ,
		AV_CODEC_ID_TRUEHD,
		AV_CODEC_ID_MP4ALS,
		AV_CODEC_ID_ATRAC1,
		AV_CODEC_ID_BINKAUDIO_RDFT,
		AV_CODEC_ID_BINKAUDIO_DCT,
		AV_CODEC_ID_AAC_LATM,
		AV_CODEC_ID_QDMC,
		AV_CODEC_ID_CELT,
		AV_CODEC_ID_G723_1,
		AV_CODEC_ID_G729,
		AV_CODEC_ID_8SVX_EXP,
		AV_CODEC_ID_8SVX_FIB,
		AV_CODEC_ID_BMV_AUDIO,
		AV_CODEC_ID_RALF,
		AV_CODEC_ID_IAC,
		AV_CODEC_ID_ILBC,
		AV_CODEC_ID_OPUS_DEPRECATED,
		AV_CODEC_ID_COMFORT_NOISE,
		AV_CODEC_ID_TAK_DEPRECATED,
		AV_CODEC_ID_FFWAVESYNTH = 0x46465753, // ((('S' | ('W' << 8)) | ('F' << 16)) | ('F' << 24))
		AV_CODEC_ID_SONIC = 0x534f4e43, // ((('C' | ('N' << 8)) | ('O' << 16)) | ('S' << 24))
		AV_CODEC_ID_SONIC_LS = 0x534f4e4c, // ((('L' | ('N' << 8)) | ('O' << 16)) | ('S' << 24))
		AV_CODEC_ID_PAF_AUDIO = 0x50414641, // ((('A' | ('F' << 8)) | ('A' << 16)) | ('P' << 24))
		AV_CODEC_ID_OPUS = 0x4f505553, // ((('S' | ('U' << 8)) | ('P' << 16)) | ('O' << 24))
		AV_CODEC_ID_TAK = 0x7442614b, // ((('K' | ('a' << 8)) | ('B' << 16)) | ('t' << 24))
		AV_CODEC_ID_EVRC = 0x73657663, // ((('c' | ('v' << 8)) | ('e' << 16)) | ('s' << 24))
		AV_CODEC_ID_SMV = 0x73736d76, // ((('v' | ('m' << 8)) | ('s' << 16)) | ('s' << 24))
		AV_CODEC_ID_FIRST_SUBTITLE = 0x17000, // 94208
		AV_CODEC_ID_DVD_SUBTITLE = 0x17000, // 94208
		AV_CODEC_ID_DVB_SUBTITLE,
		AV_CODEC_ID_TEXT,
		AV_CODEC_ID_XSUB,
		AV_CODEC_ID_SSA,
		AV_CODEC_ID_MOV_TEXT,
		AV_CODEC_ID_HDMV_PGS_SUBTITLE,
		AV_CODEC_ID_DVB_TELETEXT,
		AV_CODEC_ID_SRT,
		AV_CODEC_ID_MICRODVD = 0x6d445644, // ((('D' | ('V' << 8)) | ('D' << 16)) | ('m' << 24))
		AV_CODEC_ID_EIA_608 = 0x63363038, // ((('8' | ('0' << 8)) | ('6' << 16)) | ('c' << 24))
		AV_CODEC_ID_JACOSUB = 0x4a535542, // ((('B' | ('U' << 8)) | ('S' << 16)) | ('J' << 24))
		AV_CODEC_ID_SAMI = 0x53414d49, // ((('I' | ('M' << 8)) | ('A' << 16)) | ('S' << 24))
		AV_CODEC_ID_REALTEXT = 0x52545854, // ((('T' | ('X' << 8)) | ('T' << 16)) | ('R' << 24))
		AV_CODEC_ID_SUBVIEWER1 = 0x53625631, // ((('1' | ('V' << 8)) | ('b' << 16)) | ('S' << 24))
		AV_CODEC_ID_SUBVIEWER = 0x53756256, // ((('V' | ('b' << 8)) | ('u' << 16)) | ('S' << 24))
		AV_CODEC_ID_SUBRIP = 0x53526970, // ((('p' | ('i' << 8)) | ('R' << 16)) | ('S' << 24))
		AV_CODEC_ID_WEBVTT = 0x57565454, // ((('T' | ('T' << 8)) | ('V' << 16)) | ('W' << 24))
		AV_CODEC_ID_MPL2 = 0x4d504c32, // ((('2' | ('L' << 8)) | ('P' << 16)) | ('M' << 24))
		AV_CODEC_ID_VPLAYER = 0x56506c72, // ((('r' | ('l' << 8)) | ('P' << 16)) | ('V' << 24))
		AV_CODEC_ID_PJS = 0x50684a53, // ((('S' | ('J' << 8)) | ('h' << 16)) | ('P' << 24))
		AV_CODEC_ID_ASS = 0x41535320, // (((' ' | ('S' << 8)) | ('S' << 16)) | ('A' << 24))
		AV_CODEC_ID_FIRST_UNKNOWN = 0x18000, // 98304
		AV_CODEC_ID_TTF = 0x18000, // 98304
		AV_CODEC_ID_BINTEXT = 0x42545854, // ((('T' | ('X' << 8)) | ('T' << 16)) | ('B' << 24))
		AV_CODEC_ID_XBIN = 0x5842494e, // ((('N' | ('I' << 8)) | ('B' << 16)) | ('X' << 24))
		AV_CODEC_ID_IDF = 0x494446, // ((('F' | ('D' << 8)) | ('I' << 16)) | (0 << 24))
		AV_CODEC_ID_OTF = 0x4f5446, // ((('F' | ('T' << 8)) | ('O' << 16)) | (0 << 24))
		AV_CODEC_ID_SMPTE_KLV = 0x4b4c5641, // ((('A' | ('V' << 8)) | ('L' << 16)) | ('K' << 24))
		AV_CODEC_ID_DVD_NAV = 0x444e4156, // ((('V' | ('A' << 8)) | ('N' << 16)) | ('D' << 24))
		AV_CODEC_ID_PROBE = 0x19000, // 102400
		AV_CODEC_ID_MPEG2TS = 0x20000, // 131072
		AV_CODEC_ID_MPEG4SYSTEMS,
		AV_CODEC_ID_FFMETADATA = 0x21000, // 135168
		CODEC_ID_NONE = 0x0, // AV_CODEC_ID_NONE
		CODEC_ID_MPEG1VIDEO,
		CODEC_ID_MPEG2VIDEO,
		CODEC_ID_MPEG2VIDEO_XVMC,
		CODEC_ID_H261,
		CODEC_ID_H263,
		CODEC_ID_RV10,
		CODEC_ID_RV20,
		CODEC_ID_MJPEG,
		CODEC_ID_MJPEGB,
		CODEC_ID_LJPEG,
		CODEC_ID_SP5X,
		CODEC_ID_JPEGLS,
		CODEC_ID_MPEG4,
		CODEC_ID_RAWVIDEO,
		CODEC_ID_MSMPEG4V1,
		CODEC_ID_MSMPEG4V2,
		CODEC_ID_MSMPEG4V3,
		CODEC_ID_WMV1,
		CODEC_ID_WMV2,
		CODEC_ID_H263P,
		CODEC_ID_H263I,
		CODEC_ID_FLV1,
		CODEC_ID_SVQ1,
		CODEC_ID_SVQ3,
		CODEC_ID_DVVIDEO,
		CODEC_ID_HUFFYUV,
		CODEC_ID_CYUV,
		CODEC_ID_H264,
		CODEC_ID_INDEO3,
		CODEC_ID_VP3,
		CODEC_ID_THEORA,
		CODEC_ID_ASV1,
		CODEC_ID_ASV2,
		CODEC_ID_FFV1,
		CODEC_ID_4XM,
		CODEC_ID_VCR1,
		CODEC_ID_CLJR,
		CODEC_ID_MDEC,
		CODEC_ID_ROQ,
		CODEC_ID_INTERPLAY_VIDEO,
		CODEC_ID_XAN_WC3,
		CODEC_ID_XAN_WC4,
		CODEC_ID_RPZA,
		CODEC_ID_CINEPAK,
		CODEC_ID_WS_VQA,
		CODEC_ID_MSRLE,
		CODEC_ID_MSVIDEO1,
		CODEC_ID_IDCIN,
		CODEC_ID_8BPS,
		CODEC_ID_SMC,
		CODEC_ID_FLIC,
		CODEC_ID_TRUEMOTION1,
		CODEC_ID_VMDVIDEO,
		CODEC_ID_MSZH,
		CODEC_ID_ZLIB,
		CODEC_ID_QTRLE,
		CODEC_ID_TSCC,
		CODEC_ID_ULTI,
		CODEC_ID_QDRAW,
		CODEC_ID_VIXL,
		CODEC_ID_QPEG,
		CODEC_ID_PNG,
		CODEC_ID_PPM,
		CODEC_ID_PBM,
		CODEC_ID_PGM,
		CODEC_ID_PGMYUV,
		CODEC_ID_PAM,
		CODEC_ID_FFVHUFF,
		CODEC_ID_RV30,
		CODEC_ID_RV40,
		CODEC_ID_VC1,
		CODEC_ID_WMV3,
		CODEC_ID_LOCO,
		CODEC_ID_WNV1,
		CODEC_ID_AASC,
		CODEC_ID_INDEO2,
		CODEC_ID_FRAPS,
		CODEC_ID_TRUEMOTION2,
		CODEC_ID_BMP,
		CODEC_ID_CSCD,
		CODEC_ID_MMVIDEO,
		CODEC_ID_ZMBV,
		CODEC_ID_AVS,
		CODEC_ID_SMACKVIDEO,
		CODEC_ID_NUV,
		CODEC_ID_KMVC,
		CODEC_ID_FLASHSV,
		CODEC_ID_CAVS,
		CODEC_ID_JPEG2000,
		CODEC_ID_VMNC,
		CODEC_ID_VP5,
		CODEC_ID_VP6,
		CODEC_ID_VP6F,
		CODEC_ID_TARGA,
		CODEC_ID_DSICINVIDEO,
		CODEC_ID_TIERTEXSEQVIDEO,
		CODEC_ID_TIFF,
		CODEC_ID_GIF,
		CODEC_ID_DXA,
		CODEC_ID_DNXHD,
		CODEC_ID_THP,
		CODEC_ID_SGI,
		CODEC_ID_C93,
		CODEC_ID_BETHSOFTVID,
		CODEC_ID_PTX,
		CODEC_ID_TXD,
		CODEC_ID_VP6A,
		CODEC_ID_AMV,
		CODEC_ID_VB,
		CODEC_ID_PCX,
		CODEC_ID_SUNRAST,
		CODEC_ID_INDEO4,
		CODEC_ID_INDEO5,
		CODEC_ID_MIMIC,
		CODEC_ID_RL2,
		CODEC_ID_ESCAPE124,
		CODEC_ID_DIRAC,
		CODEC_ID_BFI,
		CODEC_ID_CMV,
		CODEC_ID_MOTIONPIXELS,
		CODEC_ID_TGV,
		CODEC_ID_TGQ,
		CODEC_ID_TQI,
		CODEC_ID_AURA,
		CODEC_ID_AURA2,
		CODEC_ID_V210X,
		CODEC_ID_TMV,
		CODEC_ID_V210,
		CODEC_ID_DPX,
		CODEC_ID_MAD,
		CODEC_ID_FRWU,
		CODEC_ID_FLASHSV2,
		CODEC_ID_CDGRAPHICS,
		CODEC_ID_R210,
		CODEC_ID_ANM,
		CODEC_ID_BINKVIDEO,
		CODEC_ID_IFF_ILBM,
		CODEC_ID_IFF_BYTERUN1,
		CODEC_ID_KGV1,
		CODEC_ID_YOP,
		CODEC_ID_VP8,
		CODEC_ID_PICTOR,
		CODEC_ID_ANSI,
		CODEC_ID_A64_MULTI,
		CODEC_ID_A64_MULTI5,
		CODEC_ID_R10K,
		CODEC_ID_MXPEG,
		CODEC_ID_LAGARITH,
		CODEC_ID_PRORES,
		CODEC_ID_JV,
		CODEC_ID_DFA,
		CODEC_ID_WMV3IMAGE,
		CODEC_ID_VC1IMAGE,
		CODEC_ID_UTVIDEO,
		CODEC_ID_BMV_VIDEO,
		CODEC_ID_VBLE,
		CODEC_ID_DXTORY,
		CODEC_ID_V410,
		CODEC_ID_XWD,
		CODEC_ID_CDXL,
		CODEC_ID_XBM,
		CODEC_ID_ZEROCODEC,
		CODEC_ID_MSS1,
		CODEC_ID_MSA1,
		CODEC_ID_TSCC2,
		CODEC_ID_MTS2,
		CODEC_ID_CLLC,
		CODEC_ID_Y41P = 0x59343150, // ((('P' | ('1' << 8)) | ('4' << 16)) | ('Y' << 24))
		CODEC_ID_ESCAPE130 = 0x45313330, // ((('0' | ('3' << 8)) | ('1' << 16)) | ('E' << 24))
		CODEC_ID_EXR = 0x30455852, // ((('R' | ('X' << 8)) | ('E' << 16)) | ('0' << 24))
		CODEC_ID_AVRP = 0x41565250, // ((('P' | ('R' << 8)) | ('V' << 16)) | ('A' << 24))
		CODEC_ID_G2M = 0x47324d, // ((('M' | ('2' << 8)) | ('G' << 16)) | (0 << 24))
		CODEC_ID_AVUI = 0x41565549, // ((('I' | ('U' << 8)) | ('V' << 16)) | ('A' << 24))
		CODEC_ID_AYUV = 0x41595556, // ((('V' | ('U' << 8)) | ('Y' << 16)) | ('A' << 24))
		CODEC_ID_V308 = 0x56333038, // ((('8' | ('0' << 8)) | ('3' << 16)) | ('V' << 24))
		CODEC_ID_V408 = 0x56343038, // ((('8' | ('0' << 8)) | ('4' << 16)) | ('V' << 24))
		CODEC_ID_YUV4 = 0x59555634, // ((('4' | ('V' << 8)) | ('U' << 16)) | ('Y' << 24))
		CODEC_ID_SANM = 0x53414e4d, // ((('M' | ('N' << 8)) | ('A' << 16)) | ('S' << 24))
		CODEC_ID_PAF_VIDEO = 0x50414656, // ((('V' | ('F' << 8)) | ('A' << 16)) | ('P' << 24))
		CODEC_ID_SNOW = 0x534e4f57, // AV_CODEC_ID_SNOW
		CODEC_ID_FIRST_AUDIO = 0x10000, // 65536
		CODEC_ID_PCM_S16LE = 0x10000, // 65536
		CODEC_ID_PCM_S16BE,
		CODEC_ID_PCM_U16LE,
		CODEC_ID_PCM_U16BE,
		CODEC_ID_PCM_S8,
		CODEC_ID_PCM_U8,
		CODEC_ID_PCM_MULAW,
		CODEC_ID_PCM_ALAW,
		CODEC_ID_PCM_S32LE,
		CODEC_ID_PCM_S32BE,
		CODEC_ID_PCM_U32LE,
		CODEC_ID_PCM_U32BE,
		CODEC_ID_PCM_S24LE,
		CODEC_ID_PCM_S24BE,
		CODEC_ID_PCM_U24LE,
		CODEC_ID_PCM_U24BE,
		CODEC_ID_PCM_S24DAUD,
		CODEC_ID_PCM_ZORK,
		CODEC_ID_PCM_S16LE_PLANAR,
		CODEC_ID_PCM_DVD,
		CODEC_ID_PCM_F32BE,
		CODEC_ID_PCM_F32LE,
		CODEC_ID_PCM_F64BE,
		CODEC_ID_PCM_F64LE,
		CODEC_ID_PCM_BLURAY,
		CODEC_ID_PCM_LXF,
		CODEC_ID_S302M,
		CODEC_ID_PCM_S8_PLANAR,
		CODEC_ID_ADPCM_IMA_QT = 0x11000, // 69632
		CODEC_ID_ADPCM_IMA_WAV,
		CODEC_ID_ADPCM_IMA_DK3,
		CODEC_ID_ADPCM_IMA_DK4,
		CODEC_ID_ADPCM_IMA_WS,
		CODEC_ID_ADPCM_IMA_SMJPEG,
		CODEC_ID_ADPCM_MS,
		CODEC_ID_ADPCM_4XM,
		CODEC_ID_ADPCM_XA,
		CODEC_ID_ADPCM_ADX,
		CODEC_ID_ADPCM_EA,
		CODEC_ID_ADPCM_G726,
		CODEC_ID_ADPCM_CT,
		CODEC_ID_ADPCM_SWF,
		CODEC_ID_ADPCM_YAMAHA,
		CODEC_ID_ADPCM_SBPRO_4,
		CODEC_ID_ADPCM_SBPRO_3,
		CODEC_ID_ADPCM_SBPRO_2,
		CODEC_ID_ADPCM_THP,
		CODEC_ID_ADPCM_IMA_AMV,
		CODEC_ID_ADPCM_EA_R1,
		CODEC_ID_ADPCM_EA_R3,
		CODEC_ID_ADPCM_EA_R2,
		CODEC_ID_ADPCM_IMA_EA_SEAD,
		CODEC_ID_ADPCM_IMA_EA_EACS,
		CODEC_ID_ADPCM_EA_XAS,
		CODEC_ID_ADPCM_EA_MAXIS_XA,
		CODEC_ID_ADPCM_IMA_ISS,
		CODEC_ID_ADPCM_G722,
		CODEC_ID_ADPCM_IMA_APC,
		CODEC_ID_VIMA = 0x56494d41, // ((('A' | ('M' << 8)) | ('I' << 16)) | ('V' << 24))
		CODEC_ID_AMR_NB = 0x12000, // 73728
		CODEC_ID_AMR_WB,
		CODEC_ID_RA_144 = 0x13000, // 77824
		CODEC_ID_RA_288,
		CODEC_ID_ROQ_DPCM = 0x14000, // 81920
		CODEC_ID_INTERPLAY_DPCM,
		CODEC_ID_XAN_DPCM,
		CODEC_ID_SOL_DPCM,
		CODEC_ID_MP2 = 0x15000, // 86016
		CODEC_ID_MP3,
		CODEC_ID_AAC,
		CODEC_ID_AC3,
		CODEC_ID_DTS,
		CODEC_ID_VORBIS,
		CODEC_ID_DVAUDIO,
		CODEC_ID_WMAV1,
		CODEC_ID_WMAV2,
		CODEC_ID_MACE3,
		CODEC_ID_MACE6,
		CODEC_ID_VMDAUDIO,
		CODEC_ID_FLAC,
		CODEC_ID_MP3ADU,
		CODEC_ID_MP3ON4,
		CODEC_ID_SHORTEN,
		CODEC_ID_ALAC,
		CODEC_ID_WESTWOOD_SND1,
		CODEC_ID_GSM,
		CODEC_ID_QDM2,
		CODEC_ID_COOK,
		CODEC_ID_TRUESPEECH,
		CODEC_ID_TTA,
		CODEC_ID_SMACKAUDIO,
		CODEC_ID_QCELP,
		CODEC_ID_WAVPACK,
		CODEC_ID_DSICINAUDIO,
		CODEC_ID_IMC,
		CODEC_ID_MUSEPACK7,
		CODEC_ID_MLP,
		CODEC_ID_GSM_MS,
		CODEC_ID_ATRAC3,
		CODEC_ID_VOXWARE,
		CODEC_ID_APE,
		CODEC_ID_NELLYMOSER,
		CODEC_ID_MUSEPACK8,
		CODEC_ID_SPEEX,
		CODEC_ID_WMAVOICE,
		CODEC_ID_WMAPRO,
		CODEC_ID_WMALOSSLESS,
		CODEC_ID_ATRAC3P,
		CODEC_ID_EAC3,
		CODEC_ID_SIPR,
		CODEC_ID_MP1,
		CODEC_ID_TWINVQ,
		CODEC_ID_TRUEHD,
		CODEC_ID_MP4ALS,
		CODEC_ID_ATRAC1,
		CODEC_ID_BINKAUDIO_RDFT,
		CODEC_ID_BINKAUDIO_DCT,
		CODEC_ID_AAC_LATM,
		CODEC_ID_QDMC,
		CODEC_ID_CELT,
		CODEC_ID_G723_1,
		CODEC_ID_G729,
		CODEC_ID_8SVX_EXP,
		CODEC_ID_8SVX_FIB,
		CODEC_ID_BMV_AUDIO,
		CODEC_ID_RALF,
		CODEC_ID_IAC,
		CODEC_ID_ILBC,
		CODEC_ID_FFWAVESYNTH = 0x46465753, // ((('S' | ('W' << 8)) | ('F' << 16)) | ('F' << 24))
		CODEC_ID_SONIC = 0x534f4e43, // ((('C' | ('N' << 8)) | ('O' << 16)) | ('S' << 24))
		CODEC_ID_SONIC_LS = 0x534f4e4c, // ((('L' | ('N' << 8)) | ('O' << 16)) | ('S' << 24))
		CODEC_ID_PAF_AUDIO = 0x50414641, // ((('A' | ('F' << 8)) | ('A' << 16)) | ('P' << 24))
		CODEC_ID_OPUS = 0x4f505553, // ((('S' | ('U' << 8)) | ('P' << 16)) | ('O' << 24))
		CODEC_ID_FIRST_SUBTITLE = 0x17000, // 94208
		CODEC_ID_DVD_SUBTITLE = 0x17000, // 94208
		CODEC_ID_DVB_SUBTITLE,
		CODEC_ID_TEXT,
		CODEC_ID_XSUB,
		CODEC_ID_SSA,
		CODEC_ID_MOV_TEXT,
		CODEC_ID_HDMV_PGS_SUBTITLE,
		CODEC_ID_DVB_TELETEXT,
		CODEC_ID_SRT,
		CODEC_ID_MICRODVD = 0x6d445644, // ((('D' | ('V' << 8)) | ('D' << 16)) | ('m' << 24))
		CODEC_ID_EIA_608 = 0x63363038, // ((('8' | ('0' << 8)) | ('6' << 16)) | ('c' << 24))
		CODEC_ID_JACOSUB = 0x4a535542, // ((('B' | ('U' << 8)) | ('S' << 16)) | ('J' << 24))
		CODEC_ID_SAMI = 0x53414d49, // ((('I' | ('M' << 8)) | ('A' << 16)) | ('S' << 24))
		CODEC_ID_REALTEXT = 0x52545854, // ((('T' | ('X' << 8)) | ('T' << 16)) | ('R' << 24))
		CODEC_ID_SUBVIEWER = 0x53756256, // ((('V' | ('b' << 8)) | ('u' << 16)) | ('S' << 24))
		CODEC_ID_FIRST_UNKNOWN = 0x18000, // 98304
		CODEC_ID_TTF = 0x18000, // 98304
		CODEC_ID_BINTEXT = 0x42545854, // ((('T' | ('X' << 8)) | ('T' << 16)) | ('B' << 24))
		CODEC_ID_XBIN = 0x5842494e, // ((('N' | ('I' << 8)) | ('B' << 16)) | ('X' << 24))
		CODEC_ID_IDF = 0x494446, // ((('F' | ('D' << 8)) | ('I' << 16)) | (0 << 24))
		CODEC_ID_OTF = 0x4f5446, // ((('F' | ('T' << 8)) | ('O' << 16)) | (0 << 24))
		CODEC_ID_PROBE = 0x19000, // 102400
		CODEC_ID_MPEG2TS = 0x20000, // 131072
		CODEC_ID_MPEG4SYSTEMS,
		CODEC_ID_FFMETADATA = 0x21000, // 135168
	}
	
	public enum Motion_Est_ID
	{
		ME_ZERO = 0x1, // 1
		ME_FULL,
		ME_LOG,
		ME_PHODS,
		ME_EPZS,
		ME_X1,
		ME_HEX,
		ME_UMH,
		ME_TESA,
		ME_ITER = 0x32, // 50
	}
	
	public enum AVDiscard
	{
		AVDISCARD_NONE = -0x10, // (-16)
		AVDISCARD_DEFAULT = 0x0, // 0
		AVDISCARD_NONREF = 0x8, // 8
		AVDISCARD_BIDIR = 0x10, // 16
		AVDISCARD_NONKEY = 0x20, // 32
		AVDISCARD_ALL = 0x30, // 48
	}
	
	public enum AVColorPrimaries
	{
		AVCOL_PRI_BT709 = 0x1, // 1
		AVCOL_PRI_UNSPECIFIED,
		AVCOL_PRI_BT470M = 0x4, // 4
		AVCOL_PRI_BT470BG,
		AVCOL_PRI_SMPTE170M,
		AVCOL_PRI_SMPTE240M,
		AVCOL_PRI_FILM,
		AVCOL_PRI_NB,
	}
	
	public enum AVColorTransferCharacteristic
	{
		AVCOL_TRC_BT709 = 0x1, // 1
		AVCOL_TRC_UNSPECIFIED,
		AVCOL_TRC_GAMMA22 = 0x4, // 4
		AVCOL_TRC_GAMMA28,
		AVCOL_TRC_SMPTE240M = 0x7, // 7
		AVCOL_TRC_NB,
	}
	
	public enum AVColorSpace
	{
		AVCOL_SPC_RGB,
		AVCOL_SPC_BT709,
		AVCOL_SPC_UNSPECIFIED,
		AVCOL_SPC_FCC = 0x4, // 4
		AVCOL_SPC_BT470BG,
		AVCOL_SPC_SMPTE170M,
		AVCOL_SPC_SMPTE240M,
		AVCOL_SPC_YCOCG,
		AVCOL_SPC_NB,
	}
	
	public enum AVColorRange
	{
		AVCOL_RANGE_UNSPECIFIED,
		AVCOL_RANGE_MPEG,
		AVCOL_RANGE_JPEG,
		AVCOL_RANGE_NB,
	}
	
	public enum AVChromaLocation
	{
		AVCHROMA_LOC_UNSPECIFIED,
		AVCHROMA_LOC_LEFT,
		AVCHROMA_LOC_CENTER,
		AVCHROMA_LOC_TOPLEFT,
		AVCHROMA_LOC_TOP,
		AVCHROMA_LOC_BOTTOMLEFT,
		AVCHROMA_LOC_BOTTOM,
		AVCHROMA_LOC_NB,
	}
	
	public enum AVAudioServiceType
	{
		AV_AUDIO_SERVICE_TYPE_MAIN,
		AV_AUDIO_SERVICE_TYPE_EFFECTS,
		AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED,
		AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED,
		AV_AUDIO_SERVICE_TYPE_DIALOGUE,
		AV_AUDIO_SERVICE_TYPE_COMMENTARY,
		AV_AUDIO_SERVICE_TYPE_EMERGENCY,
		AV_AUDIO_SERVICE_TYPE_VOICE_OVER,
		AV_AUDIO_SERVICE_TYPE_KARAOKE,
		AV_AUDIO_SERVICE_TYPE_NB,
	}
	
	public enum AVPacketSideDataType
	{
		AV_PKT_DATA_PALETTE,
		AV_PKT_DATA_NEW_EXTRADATA,
		AV_PKT_DATA_PARAM_CHANGE,
		AV_PKT_DATA_H263_MB_INFO,
		AV_PKT_DATA_SKIP_SAMPLES = 0x46, // 70
		AV_PKT_DATA_JP_DUALMONO,
		AV_PKT_DATA_STRINGS_METADATA,
		AV_PKT_DATA_SUBTITLE_POSITION,
		AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL,
		AV_PKT_DATA_WEBVTT_IDENTIFIER,
		AV_PKT_DATA_WEBVTT_SETTINGS,
	}
	
	public enum AVSideDataParamChangeFlags
	{
		AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 0x1, // 1
		AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT,
		AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 0x4, // 4
		AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 0x8, // 8
	}
	
	public enum AVFieldOrder
	{
		AV_FIELD_UNKNOWN,
		AV_FIELD_PROGRESSIVE,
		AV_FIELD_TT,
		AV_FIELD_BB,
		AV_FIELD_TB,
		AV_FIELD_BT,
	}
	
	public enum AVSubtitleType
	{
		SUBTITLE_NONE,
		SUBTITLE_BITMAP,
		SUBTITLE_TEXT,
		SUBTITLE_ASS,
	}
	
	public enum AVPictureStructure
	{
		AV_PICTURE_STRUCTURE_UNKNOWN,
		AV_PICTURE_STRUCTURE_TOP_FIELD,
		AV_PICTURE_STRUCTURE_BOTTOM_FIELD,
		AV_PICTURE_STRUCTURE_FRAME,
	}
	
	public enum AVLockOp
	{
		AV_LOCK_CREATE,
		AV_LOCK_OBTAIN,
		AV_LOCK_RELEASE,
		AV_LOCK_DESTROY,
	}
	
	public enum AVStreamParseType
	{
		AVSTREAM_PARSE_NONE,
		AVSTREAM_PARSE_FULL,
		AVSTREAM_PARSE_HEADERS,
		AVSTREAM_PARSE_TIMESTAMPS,
		AVSTREAM_PARSE_FULL_ONCE,
		AVSTREAM_PARSE_FULL_RAW = 0x57415200, // (((0 | ('R' << 8)) | ('A' << 16)) | ('W' << 24))
	}
	
	public enum AVDurationEstimationMethod
	{
		AVFMT_DURATION_FROM_PTS,
		AVFMT_DURATION_FROM_STREAM,
		AVFMT_DURATION_FROM_BITRATE,
	}
	
	public enum anon_12
	{
		AVLINK_UNINIT,
		AVLINK_STARTINIT,
		AVLINK_INIT,
	}
	
	public enum anon_13
	{
		AVFILTER_AUTO_CONVERT_ALL,
		AVFILTER_AUTO_CONVERT_NONE = -0x1, // (-1)
	}
	
	public enum SwrDitherType
	{
		SWR_DITHER_NONE,
		SWR_DITHER_RECTANGULAR,
		SWR_DITHER_TRIANGULAR,
		SWR_DITHER_TRIANGULAR_HIGHPASS,
		SWR_DITHER_NS = 0x40, // 64
		SWR_DITHER_NS_LIPSHITZ,
		SWR_DITHER_NS_F_WEIGHTED,
		SWR_DITHER_NS_MODIFIED_E_WEIGHTED,
		SWR_DITHER_NS_IMPROVED_E_WEIGHTED,
		SWR_DITHER_NS_SHIBATA,
		SWR_DITHER_NS_LOW_SHIBATA,
		SWR_DITHER_NS_HIGH_SHIBATA,
		SWR_DITHER_NB,
	}
	
	public enum SwrEngine
	{
		SWR_ENGINE_SWR,
		SWR_ENGINE_SOXR,
		SWR_ENGINE_NB,
	}
	
	public enum SwrFilterType
	{
		SWR_FILTER_TYPE_CUBIC,
		SWR_FILTER_TYPE_BLACKMAN_NUTTALL,
		SWR_FILTER_TYPE_KAISER,
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVRational
	{
		public int num;
		public int den;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct av_intfloat32
	{
		public uint i;
		public float f;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct av_intfloat64
	{
		public ulong i;
		public double f;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVExtFloat
	{
		public fixed byte exponent[2]; // <Ctype "c_uint8 * 2">
		public fixed byte mantissa[8]; // <Ctype "c_uint8 * 8">
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVOptionRanges
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVOption
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVClass
	{
		public byte* class_name;
		public IntPtr item_name; // Func<void*, String>
		public AVOption* option;
		public int version;
		public int log_level_offset_offset;
		public int parent_log_context_offset;
		public IntPtr child_next; // Func<void*, void*, void*>
		public IntPtr child_class_next; // Func<AVClass*, AVClass*>
		public AVClassCategory category;
		public IntPtr get_category; // Func<void*, AVClassCategory>
		public IntPtr query_ranges; // Func<AVOptionRanges**, void*, String, int, int>
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBuffer
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBufferRef
	{
		public AVBuffer* buffer;
		public byte* data;
		public int size;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBufferPool
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBPrint
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVDictionaryEntry
	{
		public byte* key;
		public byte* value;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVDictionary
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFrameSideData
	{
		public AVFrameSideDataType type;
		public byte* data;
		public int size;
		public AVDictionary* metadata;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVPanScan
	{
		public int id;
		public int width;
		public int height;
		public fixed short position[6]; // <Ctype "(c_int16 * 2) * 3">
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecContext
	{
		public AVClass* av_class;
		public int log_level_offset;
		public AVMediaType codec_type;
		public AVCodec* codec;
		public fixed byte codec_name[32]; // <Ctype "c_char * 32">
		public AVCodecID codec_id;
		public int codec_tag;
		public int stream_codec_tag;
		public void* priv_data;
		public AVCodecInternal* @internal;
		public void* opaque;
		public int bit_rate;
		public int bit_rate_tolerance;
		public int global_quality;
		public int compression_level;
		public int flags;
		public int flags2;
		public byte* extradata;
		public int extradata_size;
		public AVRational time_base;
		public int ticks_per_frame;
		public int delay;
		public int width;
		public int height;
		public int coded_width;
		public int coded_height;
		public int gop_size;
		public AVPixelFormat pix_fmt;
		public int me_method;
		public IntPtr draw_horiz_band; // Action<AVCodecContext*, AVFrame*, int*, int, int, int>
		public IntPtr get_format; // Func<AVCodecContext*, AVPixelFormat*, AVPixelFormat>
		public int max_b_frames;
		public float b_quant_factor;
		public int rc_strategy;
		public int b_frame_strategy;
		public float b_quant_offset;
		public int has_b_frames;
		public int mpeg_quant;
		public float i_quant_factor;
		public float i_quant_offset;
		public float lumi_masking;
		public float temporal_cplx_masking;
		public float spatial_cplx_masking;
		public float p_masking;
		public float dark_masking;
		public int slice_count;
		public int prediction_method;
		public int* slice_offset;
		public AVRational sample_aspect_ratio;
		public int me_cmp;
		public int me_sub_cmp;
		public int mb_cmp;
		public int ildct_cmp;
		public int dia_size;
		public int last_predictor_count;
		public int pre_me;
		public int me_pre_cmp;
		public int pre_dia_size;
		public int me_subpel_quality;
		public int dtg_active_format;
		public int me_range;
		public int intra_quant_bias;
		public int inter_quant_bias;
		public int slice_flags;
		public int xvmc_acceleration;
		public int mb_decision;
		public ushort* intra_matrix;
		public ushort* inter_matrix;
		public int scenechange_threshold;
		public int noise_reduction;
		public int me_threshold;
		public int mb_threshold;
		public int intra_dc_precision;
		public int skip_top;
		public int skip_bottom;
		public float border_masking;
		public int mb_lmin;
		public int mb_lmax;
		public int me_penalty_compensation;
		public int bidir_refine;
		public int brd_scale;
		public int keyint_min;
		public int refs;
		public int chromaoffset;
		public int scenechange_factor;
		public int mv0_threshold;
		public int b_sensitivity;
		public AVColorPrimaries color_primaries;
		public AVColorTransferCharacteristic color_trc;
		public AVColorSpace colorspace;
		public AVColorRange color_range;
		public AVChromaLocation chroma_sample_location;
		public int slices;
		public AVFieldOrder field_order;
		public int sample_rate;
		public int channels;
		public AVSampleFormat sample_fmt;
		public int frame_size;
		public int frame_number;
		public int block_align;
		public int cutoff;
		public int request_channels;
		public ulong channel_layout;
		public ulong request_channel_layout;
		public AVAudioServiceType audio_service_type;
		public AVSampleFormat request_sample_fmt;
		public IntPtr get_buffer; // Func<AVCodecContext*, AVFrame*, int>
		public IntPtr release_buffer; // Action<AVCodecContext*, AVFrame*>
		public IntPtr reget_buffer; // Func<AVCodecContext*, AVFrame*, int>
		public IntPtr get_buffer2; // Func<AVCodecContext*, AVFrame*, int, int>
		public int refcounted_frames;
		public float qcompress;
		public float qblur;
		public int qmin;
		public int qmax;
		public int max_qdiff;
		public float rc_qsquish;
		public float rc_qmod_amp;
		public int rc_qmod_freq;
		public int rc_buffer_size;
		public int rc_override_count;
		public RcOverride* rc_override;
		public byte* rc_eq;
		public int rc_max_rate;
		public int rc_min_rate;
		public float rc_buffer_aggressivity;
		public float rc_initial_cplx;
		public float rc_max_available_vbv_use;
		public float rc_min_vbv_overflow_use;
		public int rc_initial_buffer_occupancy;
		public int coder_type;
		public int context_model;
		public int lmin;
		public int lmax;
		public int frame_skip_threshold;
		public int frame_skip_factor;
		public int frame_skip_exp;
		public int frame_skip_cmp;
		public int trellis;
		public int min_prediction_order;
		public int max_prediction_order;
		public long timecode_frame_start;
		public IntPtr rtp_callback; // Action<AVCodecContext*, void*, int, int>
		public int rtp_payload_size;
		public int mv_bits;
		public int header_bits;
		public int i_tex_bits;
		public int p_tex_bits;
		public int i_count;
		public int p_count;
		public int skip_count;
		public int misc_bits;
		public int frame_bits;
		public byte* stats_out;
		public byte* stats_in;
		public int workaround_bugs;
		public int strict_std_compliance;
		public int error_concealment;
		public int debug;
		public int debug_mv;
		public int err_recognition;
		public long reordered_opaque;
		public AVHWAccel* hwaccel;
		public void* hwaccel_context;
		public fixed ulong error[8]; // <Ctype "c_uint64 * 8">
		public int dct_algo;
		public int idct_algo;
		public int bits_per_coded_sample;
		public int bits_per_raw_sample;
		public int lowres;
		public AVFrame* coded_frame;
		public int thread_count;
		public int thread_type;
		public int active_thread_type;
		public int thread_safe_callbacks;
		public IntPtr execute; // Func<AVCodecContext*, Func<AVCodecContext*, void*, int>, void*, int*, int, int, int>
		public IntPtr execute2; // Func<AVCodecContext*, Func<AVCodecContext*, void*, int, int, int>, void*, int*, int, int>
		public void* thread_opaque;
		public int nsse_weight;
		public int profile;
		public int level;
		public AVDiscard skip_loop_filter;
		public AVDiscard skip_idct;
		public AVDiscard skip_frame;
		public byte* subtitle_header;
		public int subtitle_header_size;
		public int error_rate;
		public AVPacket* pkt;
		public ulong vbv_delay;
		public AVRational pkt_timebase;
		public AVCodecDescriptor* codec_descriptor;
		public long pts_correction_num_faulty_pts;
		public long pts_correction_num_faulty_dts;
		public long pts_correction_last_pts;
		public long pts_correction_last_dts;
		public byte* sub_charenc;
		public int sub_charenc_mode;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFrame
	{
		// fixed byte* data[8] - <Ctype "POINTER(c_uint8) * 8">
		public byte* data_0;
		public byte* data_1;
		public byte* data_2;
		public byte* data_3;
		public byte* data_4;
		public byte* data_5;
		public byte* data_6;
		public byte* data_7;
		public fixed int linesize[8]; // <Ctype "c_int * 8">
		public byte** extended_data;
		public int width;
		public int height;
		public int nb_samples;
		public int format;
		public int key_frame;
		public AVPictureType pict_type;
		// fixed byte* @base[8] - <Ctype "POINTER(c_uint8) * 8">
		public byte* @base_0;
		public byte* @base_1;
		public byte* @base_2;
		public byte* @base_3;
		public byte* @base_4;
		public byte* @base_5;
		public byte* @base_6;
		public byte* @base_7;
		public AVRational sample_aspect_ratio;
		public long pts;
		public long pkt_pts;
		public long pkt_dts;
		public int coded_picture_number;
		public int display_picture_number;
		public int quality;
		public int reference;
		public sbyte* qscale_table;
		public int qstride;
		public int qscale_type;
		public byte* mbskip_table;
		// fixed short** motion_val[2] - <Ctype "POINTER(c_int16 * 2) * 2">
		public short** motion_val_0;
		public short** motion_val_1;
		public uint* mb_type;
		public short* dct_coeff;
		// fixed sbyte* ref_index[2] - <Ctype "POINTER(c_int8) * 2">
		public sbyte* ref_index_0;
		public sbyte* ref_index_1;
		public void* opaque;
		public fixed ulong error[8]; // <Ctype "c_uint64 * 8">
		public int type;
		public int repeat_pict;
		public int interlaced_frame;
		public int top_field_first;
		public int palette_has_changed;
		public int buffer_hints;
		public AVPanScan* pan_scan;
		public long reordered_opaque;
		public void* hwaccel_picture_private;
		public AVCodecContext* owner;
		public void* thread_opaque;
		public byte motion_subsample_log2;
		public int sample_rate;
		public ulong channel_layout;
		// fixed AVBufferRef* buf[8] - <Ctype "POINTER(AVBufferRef) * 8">
		public AVBufferRef* buf_0;
		public AVBufferRef* buf_1;
		public AVBufferRef* buf_2;
		public AVBufferRef* buf_3;
		public AVBufferRef* buf_4;
		public AVBufferRef* buf_5;
		public AVBufferRef* buf_6;
		public AVBufferRef* buf_7;
		public AVBufferRef** extended_buf;
		public int nb_extended_buf;
		public AVFrameSideData** side_data;
		public int nb_side_data;
		public long best_effort_timestamp;
		public long pkt_pos;
		public long pkt_duration;
		public AVDictionary* metadata;
		public int decode_error_flags;
		public int channels;
		public int pkt_size;
		public AVBufferRef* qp_table_buf;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecDescriptor
	{
		public AVCodecID id;
		public AVMediaType type;
		public byte* name;
		public byte* long_name;
		public int props;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct RcOverride
	{
		public int start_frame;
		public int end_frame;
		public int qscale;
		public float quality_factor;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct anon_10
	{
		public byte* data;
		public int size;
		public AVPacketSideDataType type;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVPacket
	{
		public AVBufferRef* buf;
		public long pts;
		public long dts;
		public byte* data;
		public int size;
		public int stream_index;
		public int flags;
		public anon_10* side_data;
		public int side_data_elems;
		public int duration;
		public IntPtr destruct; // Action<AVPacket*>
		public void* priv;
		public long pos;
		public long convergence_duration;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecInternal
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodec
	{
		public byte* name;
		public byte* long_name;
		public AVMediaType type;
		public AVCodecID id;
		public int capabilities;
		public AVRational* supported_framerates;
		public AVPixelFormat* pix_fmts;
		public int* supported_samplerates;
		public AVSampleFormat* sample_fmts;
		public ulong* channel_layouts;
		public byte max_lowres;
		public AVClass* priv_class;
		public AVProfile* profiles;
		public int priv_data_size;
		public AVCodec* next;
		public IntPtr init_thread_copy; // Func<AVCodecContext*, int>
		public IntPtr update_thread_context; // Func<AVCodecContext*, AVCodecContext*, int>
		public AVCodecDefault* defaults;
		public IntPtr init_static_data; // Action<AVCodec*>
		public IntPtr init; // Func<AVCodecContext*, int>
		public IntPtr encode_sub; // Func<AVCodecContext*, byte*, int, AVSubtitle*, int>
		public IntPtr encode2; // Func<AVCodecContext*, AVPacket*, AVFrame*, int*, int>
		public IntPtr decode; // Func<AVCodecContext*, void*, int*, AVPacket*, int>
		public IntPtr close; // Func<AVCodecContext*, int>
		public IntPtr flush; // Action<AVCodecContext*>
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVHWAccel
	{
		public byte* name;
		public AVMediaType type;
		public AVCodecID id;
		public AVPixelFormat pix_fmt;
		public int capabilities;
		public AVHWAccel* next;
		public IntPtr start_frame; // Func<AVCodecContext*, byte*, uint, int>
		public IntPtr decode_slice; // Func<AVCodecContext*, byte*, uint, int>
		public IntPtr end_frame; // Func<AVCodecContext*, int>
		public int priv_data_size;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVProfile
	{
		public int profile;
		public byte* name;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecDefault
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVSubtitle
	{
		public ushort format;
		public uint start_display_time;
		public uint end_display_time;
		public int num_rects;
		public AVSubtitleRect** rects;
		public long pts;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVPicture
	{
		// fixed byte* data[8] - <Ctype "POINTER(c_uint8) * 8">
		public byte* data_0;
		public byte* data_1;
		public byte* data_2;
		public byte* data_3;
		public byte* data_4;
		public byte* data_5;
		public byte* data_6;
		public byte* data_7;
		public fixed int linesize[8]; // <Ctype "c_int * 8">
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVSubtitleRect
	{
		public int x;
		public int y;
		public int w;
		public int h;
		public int nb_colors;
		public AVPicture pict;
		public AVSubtitleType type;
		public byte* text;
		public byte* ass;
		public int flags;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecParser
	{
		public fixed int codec_ids[5]; // <Ctype "c_int * 5">
		public int priv_data_size;
		public IntPtr parser_init; // Func<AVCodecParserContext*, int>
		public IntPtr parser_parse; // Func<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int>
		public IntPtr parser_close; // Action<AVCodecParserContext*>
		public IntPtr split; // Func<AVCodecContext*, byte*, int, int>
		public AVCodecParser* next;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecParserContext
	{
		public void* priv_data;
		public AVCodecParser* parser;
		public long frame_offset;
		public long cur_offset;
		public long next_frame_offset;
		public int pict_type;
		public int repeat_pict;
		public long pts;
		public long dts;
		public long last_pts;
		public long last_dts;
		public int fetch_timestamp;
		public int cur_frame_start_index;
		public fixed long cur_frame_offset[4]; // <Ctype "c_int64 * 4">
		public fixed long cur_frame_pts[4]; // <Ctype "c_int64 * 4">
		public fixed long cur_frame_dts[4]; // <Ctype "c_int64 * 4">
		public int flags;
		public long offset;
		public fixed long cur_frame_end[4]; // <Ctype "c_int64 * 4">
		public int key_frame;
		public long convergence_duration;
		public int dts_sync_point;
		public int dts_ref_dts_delta;
		public int pts_dts_delta;
		public fixed long cur_frame_pos[4]; // <Ctype "c_int64 * 4">
		public long pos;
		public long last_pos;
		public int duration;
		public AVFieldOrder field_order;
		public AVPictureStructure picture_structure;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct ReSampleContext
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVResampleContext
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBitStreamFilter
	{
		public byte* name;
		public int priv_data_size;
		public IntPtr filter; // Func<AVBitStreamFilterContext*, AVCodecContext*, String, byte**, int*, byte*, int, int, int>
		public IntPtr close; // Action<AVBitStreamFilterContext*>
		public AVBitStreamFilter* next;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVBitStreamFilterContext
	{
		public void* priv_data;
		public AVBitStreamFilter* filter;
		public AVCodecParserContext* parser;
		public AVBitStreamFilterContext* next;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVIOInterruptCB
	{
		public IntPtr callback; // Func<void*, int>
		public void* opaque;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVIOContext
	{
		public AVClass* av_class;
		public byte* buffer;
		public int buffer_size;
		public byte* buf_ptr;
		public byte* buf_end;
		public void* opaque;
		public IntPtr read_packet; // Func<void*, byte*, int, int>
		public IntPtr write_packet; // Func<void*, byte*, int, int>
		public IntPtr seek; // Func<void*, long, int, long>
		public long pos;
		public int must_flush;
		public int eof_reached;
		public int write_flag;
		public int max_packet_size;
		public int checksum;
		public byte* checksum_ptr;
		public IntPtr update_checksum; // Func<int, byte*, int, int>
		public int error;
		public IntPtr read_pause; // Func<void*, int, int>
		public IntPtr read_seek; // Func<void*, int, long, int, long>
		public int seekable;
		public long maxsize;
		public int direct;
		public long bytes_read;
		public int seek_count;
		public int writeout_count;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFormatContext
	{
		public AVClass* av_class;
		public AVInputFormat* iformat;
		public AVOutputFormat* oformat;
		public void* priv_data;
		public AVIOContext* pb;
		public int ctx_flags;
		public int nb_streams;
		public AVStream** streams;
		public fixed byte filename[1024]; // <Ctype "c_char * 1024">
		public long start_time;
		public long duration;
		public int bit_rate;
		public int packet_size;
		public int max_delay;
		public int flags;
		public int probesize;
		public int max_analyze_duration;
		public byte* key;
		public int keylen;
		public int nb_programs;
		public AVProgram** programs;
		public AVCodecID video_codec_id;
		public AVCodecID audio_codec_id;
		public AVCodecID subtitle_codec_id;
		public int max_index_size;
		public int max_picture_buffer;
		public int nb_chapters;
		public AVChapter** chapters;
		public AVDictionary* metadata;
		public long start_time_realtime;
		public int fps_probe_size;
		public int error_recognition;
		public AVIOInterruptCB interrupt_callback;
		public int debug;
		public int ts_id;
		public int audio_preload;
		public int max_chunk_duration;
		public int max_chunk_size;
		public int use_wallclock_as_timestamps;
		public int avoid_negative_ts;
		public int avio_flags;
		public AVDurationEstimationMethod duration_estimation_method;
		public int skip_initial_bytes;
		public int correct_ts_overflow;
		public int seek2any;
		public int flush_packets;
		public AVPacketList* packet_buffer;
		public AVPacketList* packet_buffer_end;
		public long data_offset;
		public AVPacketList* raw_packet_buffer;
		public AVPacketList* raw_packet_buffer_end;
		public AVPacketList* parse_queue;
		public AVPacketList* parse_queue_end;
		public int raw_packet_buffer_remaining_size;
		public long offset;
		public AVRational offset_timebase;
		public int io_repositioned;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFrac
	{
		public long val;
		public long num;
		public long den;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVCodecTag
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVProbeData
	{
		public byte* filename;
		public byte* buf;
		public int buf_size;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVOutputFormat
	{
		public byte* name;
		public byte* long_name;
		public byte* mime_type;
		public byte* extensions;
		public AVCodecID audio_codec;
		public AVCodecID video_codec;
		public AVCodecID subtitle_codec;
		public int flags;
		public AVCodecTag** codec_tag;
		public AVClass* priv_class;
		public AVOutputFormat* next;
		public int priv_data_size;
		public IntPtr write_header; // Func<AVFormatContext*, int>
		public IntPtr write_packet; // Func<AVFormatContext*, AVPacket*, int>
		public IntPtr write_trailer; // Func<AVFormatContext*, int>
		public IntPtr interleave_packet; // Func<AVFormatContext*, AVPacket*, AVPacket*, int, int>
		public IntPtr query_codec; // Func<AVCodecID, int, int>
		public IntPtr get_output_timestamp; // Action<AVFormatContext*, int, long*, long*>
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVInputFormat
	{
		public byte* name;
		public byte* long_name;
		public int flags;
		public byte* extensions;
		public AVCodecTag** codec_tag;
		public AVClass* priv_class;
		public AVInputFormat* next;
		public int raw_codec_id;
		public int priv_data_size;
		public IntPtr read_probe; // Func<AVProbeData*, int>
		public IntPtr read_header; // Func<AVFormatContext*, int>
		public IntPtr read_packet; // Func<AVFormatContext*, AVPacket*, int>
		public IntPtr read_close; // Func<AVFormatContext*, int>
		public IntPtr read_seek; // Func<AVFormatContext*, int, long, int, int>
		public IntPtr read_timestamp; // Func<AVFormatContext*, int, long*, long, long>
		public IntPtr read_play; // Func<AVFormatContext*, int>
		public IntPtr read_pause; // Func<AVFormatContext*, int>
		public IntPtr read_seek2; // Func<AVFormatContext*, int, long, long, long, int, int>
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVIndexEntry
	{
		public long pos;
		public long timestamp;
		public uint _bitfield0x00;
		//bit field flags int:2
		//bit field size int:30
		public int min_distance;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct anon_11
	{
		public long last_dts;
		public long duration_gcd;
		public int duration_count;
		public double*** duration_error;
		public long codec_info_duration;
		public long codec_info_duration_fields;
		public int found_decoder;
		public long last_duration;
		public long fps_first_dts;
		public int fps_first_dts_idx;
		public long fps_last_dts;
		public int fps_last_dts_idx;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVPacketList
	{
		public AVPacket pkt;
		public AVPacketList* next;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVStream
	{
		public int index;
		public int id;
		public AVCodecContext* codec;
		public void* priv_data;
		public AVFrac pts;
		public AVRational time_base;
		public long start_time;
		public long duration;
		public long nb_frames;
		public int disposition;
		public AVDiscard discard;
		public AVRational sample_aspect_ratio;
		public AVDictionary* metadata;
		public AVRational avg_frame_rate;
		public AVPacket attached_pic;
		public anon_11* info;
		public int pts_wrap_bits;
		public long reference_dts;
		public long first_dts;
		public long cur_dts;
		public long last_IP_pts;
		public int last_IP_duration;
		public int probe_packets;
		public int codec_info_nb_frames;
		public AVStreamParseType need_parsing;
		public AVCodecParserContext* parser;
		public AVPacketList* last_in_packet_buffer;
		public AVProbeData probe_data;
		public fixed long pts_buffer[17]; // <Ctype "c_int64 * (16 + 1)">
		public AVIndexEntry* index_entries;
		public int nb_index_entries;
		public int index_entries_allocated_size;
		public AVRational r_frame_rate;
		public int stream_identifier;
		public long interleaver_chunk_size;
		public long interleaver_chunk_duration;
		public int request_probe;
		public int skip_to_keyframe;
		public int skip_samples;
		public int nb_decoded_frames;
		public long mux_ts_offset;
		public long pts_wrap_reference;
		public int pts_wrap_behavior;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVProgram
	{
		public int id;
		public int flags;
		public AVDiscard discard;
		public int* stream_index;
		public int nb_stream_indexes;
		public AVDictionary* metadata;
		public int program_num;
		public int pmt_pid;
		public int pcr_pid;
		public long start_time;
		public long end_time;
		public long pts_wrap_reference;
		public int pts_wrap_behavior;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVChapter
	{
		public int id;
		public AVRational time_base;
		public long start;
		public long end;
		public AVDictionary* metadata;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterContext
	{
		public AVClass* av_class;
		public AVFilter* filter;
		public byte* name;
		public AVFilterPad* input_pads;
		public AVFilterLink** inputs;
		public int input_count;
		public int nb_inputs;
		public AVFilterPad* output_pads;
		public AVFilterLink** outputs;
		public int output_count;
		public int nb_outputs;
		public void* priv;
		public AVFilterGraph* graph;
		public int thread_type;
		public AVFilterInternal* @internal;
		public AVFilterCommand* command_queue;
		public byte* enable_str;
		public void* enable;
		public double* var_values;
		public int is_disabled;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterLink
	{
		public AVFilterContext* src;
		public AVFilterPad* srcpad;
		public AVFilterContext* dst;
		public AVFilterPad* dstpad;
		public AVMediaType type;
		public int w;
		public int h;
		public AVRational sample_aspect_ratio;
		public ulong channel_layout;
		public int sample_rate;
		public int format;
		public AVRational time_base;
		public AVFilterFormats* in_formats;
		public AVFilterFormats* out_formats;
		public AVFilterFormats* in_samplerates;
		public AVFilterFormats* out_samplerates;
		public AVFilterChannelLayouts* in_channel_layouts;
		public AVFilterChannelLayouts* out_channel_layouts;
		public int request_samples;
		public anon_12 init_state;
		public AVFilterPool* pool;
		public AVFilterGraph* graph;
		public long current_pts;
		public int age_index;
		public AVRational frame_rate;
		public AVFrame* partial_buf;
		public int partial_buf_size;
		public int min_samples;
		public int max_samples;
		public AVFilterBufferRef* cur_buf_copy;
		public int closed;
		public int channels;
		public int frame_requested;
		public int flags;
		public long frame_count;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterPad
	{
		public byte* name;
		public AVMediaType type;
		public int min_perms;
		public int rej_perms;
		public IntPtr start_frame; // Func<AVFilterLink*, AVFilterBufferRef*, int>
		public IntPtr get_video_buffer; // Func<AVFilterLink*, int, int, AVFrame*>
		public IntPtr get_audio_buffer; // Func<AVFilterLink*, int, AVFrame*>
		public IntPtr end_frame; // Func<AVFilterLink*, int>
		public IntPtr draw_slice; // Func<AVFilterLink*, int, int, int, int>
		public IntPtr filter_frame; // Func<AVFilterLink*, AVFrame*, int>
		public IntPtr poll_frame; // Func<AVFilterLink*, int>
		public IntPtr request_frame; // Func<AVFilterLink*, int>
		public IntPtr config_props; // Func<AVFilterLink*, int>
		public int needs_fifo;
		public int needs_writable;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterFormats
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterBuffer
	{
		// fixed byte* data[8] - <Ctype "POINTER(c_uint8) * 8">
		public byte* data_0;
		public byte* data_1;
		public byte* data_2;
		public byte* data_3;
		public byte* data_4;
		public byte* data_5;
		public byte* data_6;
		public byte* data_7;
		public byte** extended_data;
		public fixed int linesize[8]; // <Ctype "c_int * 8">
		public void* priv;
		public IntPtr free; // Action<AVFilterBuffer*>
		public int format;
		public int w;
		public int h;
		public int refcount;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterBufferRefAudioProps
	{
		public ulong channel_layout;
		public int nb_samples;
		public int sample_rate;
		public int channels;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterBufferRefVideoProps
	{
		public int w;
		public int h;
		public AVRational sample_aspect_ratio;
		public int interlaced;
		public int top_field_first;
		public AVPictureType pict_type;
		public int key_frame;
		public int qp_table_linesize;
		public int qp_table_size;
		public sbyte* qp_table;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterBufferRef
	{
		public AVFilterBuffer* buf;
		// fixed byte* data[8] - <Ctype "POINTER(c_uint8) * 8">
		public byte* data_0;
		public byte* data_1;
		public byte* data_2;
		public byte* data_3;
		public byte* data_4;
		public byte* data_5;
		public byte* data_6;
		public byte* data_7;
		public byte** extended_data;
		public fixed int linesize[8]; // <Ctype "c_int * 8">
		public AVFilterBufferRefVideoProps* video;
		public AVFilterBufferRefAudioProps* audio;
		public long pts;
		public long pos;
		public int format;
		public int perms;
		public AVMediaType type;
		public AVDictionary* metadata;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilter
	{
		public byte* name;
		public byte* description;
		public AVFilterPad* inputs;
		public AVFilterPad* outputs;
		public AVClass* priv_class;
		public int flags;
		public IntPtr init; // Func<AVFilterContext*, int>
		public IntPtr init_dict; // Func<AVFilterContext*, AVDictionary**, int>
		public IntPtr uninit; // Action<AVFilterContext*>
		public IntPtr query_formats; // Func<AVFilterContext*, int>
		public int priv_size;
		public AVFilter* next;
		public IntPtr process_command; // Func<AVFilterContext*, String, String, String, int, int, int>
		public IntPtr init_opaque; // Func<AVFilterContext*, void*, int>
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterInternal
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterGraph
	{
		public AVClass* av_class;
		public int filter_count_unused;
		public AVFilterContext** filters;
		public byte* scale_sws_opts;
		public byte* resample_lavr_opts;
		public int nb_filters;
		public int thread_type;
		public int nb_threads;
		public AVFilterGraphInternal* @internal;
		public byte* aresample_swr_opts;
		public AVFilterLink** sink_links;
		public int sink_links_count;
		public int disable_auto_convert;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterCommand
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterChannelLayouts
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterPool
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterGraphInternal
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct AVFilterInOut
	{
		public byte* name;
		public AVFilterContext* filter_ctx;
		public int pad_idx;
		public AVFilterInOut* next;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct SwrContext
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct SwsVector
	{
		public double* coeff;
		public int length;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct SwsFilter
	{
		public SwsVector* lumH;
		public SwsVector* lumV;
		public SwsVector* chrH;
		public SwsVector* chrV;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct SwsContext
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct pp_context
	{
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public unsafe struct pp_mode
	{
	}
	
	public static unsafe partial class FFmpegInvoke
	{
		public const string POSTPROC_LIBRARY = "postproc-52";
		public const string SWSCALE_LIBRARY = "swscale-2";
		public const string AVFORMAT_LIBRARY = "avformat-55";
		public const string SWRESAMPLE_LIBRARY = "swresample-0";
		public const string AVUTIL_LIBRARY = "avutil-52";
		public const string AVDEVICE_LIBRARY = "avdevice-55";
		public const string AVCODEC_LIBRARY = "avcodec-55";
		public const string AVFILTER_LIBRARY = "avfilter-3";
		
		public const int FF_LAMBDA_SHIFT = 0x7;
		public const int FF_LAMBDA_SCALE = 0x1; // (1 << FF_LAMBDA_SHIFT)
		public const int FF_QP2LAMBDA = 0x76;
		public const int FF_LAMBDA_MAX = 0x7fff; // ((256 * 128) - 1)
		public const int FF_QUALITY_SCALE = 0x0; // FF_LAMBDA_SCALE
		public const ulong AV_NOPTS_VALUE = 0x8000000000000000L; // ((UINT64_C (9223372036854775808L)).value)
		public const int AV_TIME_BASE = 0xf4240;
		public const int AV_GCC_VERSION_AT_LEAST = 0x0;
		public const int av_always_inline = 0x1; // inline
		public const int av_restrict = 0x0; // restrict
		public const int AV_NOWARN_DEPRECATED = 0x0; // code
		public const int av_uninit = 0x0; // x
		public const int av_builtin_constant_p = 0x0;
		public const int AV_TOSTRING = 0x0; // s
		public const int AV_VERSION_INT = 0x0; // (((a << 16) | (b << 8)) | c)
		public const int LIBAVUTIL_VERSION_MAJOR = 0x34;
		public const int LIBAVUTIL_VERSION_MINOR = 0x26;
		public const int LIBAVUTIL_VERSION_MICRO = 0x64;
		public const int LIBAVUTIL_BUILD = 0x0; // LIBAVUTIL_VERSION_INT
		public const int FF_API_GET_BITS_PER_SAMPLE_FMT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_FIND_OPT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_OLD_AVOPTIONS = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_PIX_FMT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_CONTEXT_SIZE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_PIX_FMT_DESC = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_AV_REVERSE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_AUDIOCONVERT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_CPU_FLAG_MMX2 = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_SAMPLES_UTILS_RETURN_ZERO = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_LLS_PRIVATE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int FF_API_AVFRAME_LAVC = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 53)
		public const int AV_HAVE_BIGENDIAN = 0x0;
		public const int AV_HAVE_FAST_UNALIGNED = 0x1;
		public const int AV_HAVE_INCOMPATIBLE_LIBAV_ABI = 0x0;
		public const int AV_HAVE_INCOMPATIBLE_FORK_ABI = 0x0;
		public const int AV_NE = 0x0; // le
		public const int RSHIFT = -0x1; // (a > 0) and ((a + ((1 << b) >> 1)) >> b) or (((a + ((1 << b) >> 1)) - 1) >> b)
		public const int FFABS = 0x0; // (a >= 0) and a or (-a)
		public const int FFSIGN = -0x1; // (a > 0) and 1 or (-1)
		public const int FFMAX = 0x0; // (a > b) and a or b
		public const int FFMIN = 0x0; // (a > b) and b or a
		public const int FFALIGN = 0x0; // (((x + a) - 1) & (~(a - 1)))
		public const int av_ceil_log2 = 0x0; // av_ceil_log2_c
		public const int av_clip = 0x0; // av_clip_c
		public const int av_clip64 = 0x0; // av_clip64_c
		public const int av_clip_uint8 = 0x0; // av_clip_uint8_c
		public const int av_clip_int8 = 0x0; // av_clip_int8_c
		public const int av_clip_uint16 = 0x0; // av_clip_uint16_c
		public const int av_clip_int16 = 0x0; // av_clip_int16_c
		public const int av_clipl_int32 = 0x0; // av_clipl_int32_c
		public const int av_clip_uintp2 = 0x0; // av_clip_uintp2_c
		public const int av_sat_add32 = 0x0; // av_sat_add32_c
		public const int av_sat_dadd32 = 0x0; // av_sat_dadd32_c
		public const int av_clipf = 0x0; // av_clipf_c
		public const int av_clipd = 0x0; // av_clipd_c
		public const int av_popcount = 0x0; // av_popcount_c
		public const int av_popcount64 = 0x0; // av_popcount64_c
		public const int MKTAG = 0x0; // (((a | (b << 8)) | (c << 16)) | (d << 24))
		public const int MKBETAG = 0x0; // (((d | (c << 8)) | (b << 16)) | (a << 24))
		public const int AVERROR = 0x0; // (-e)
		public const int AVUNERROR = 0x0; // (-e)
		public const int AVERROR_EXPERIMENTAL = -0x2bb2afa8; // (-733130664)
		public const int AV_ERROR_MAX_STRING_SIZE = 0x40;
		public const int DECLARE_ALIGNED = 0x0; // (t + v)
		public const float M_LOG2_10 = 3.321928f; // 3.321928094887362
		public const float M_PHI = 1.618034f; // 1.618033988749895
		public const int AV_LOG_QUIET = -0x8; // (-8)
		public const int AV_LOG_PANIC = 0x0;
		public const int AV_LOG_FATAL = 0x8;
		public const int AV_LOG_ERROR = 0x10;
		public const int AV_LOG_WARNING = 0x18;
		public const int AV_LOG_INFO = 0x20;
		public const int AV_LOG_VERBOSE = 0x28;
		public const int AV_LOG_DEBUG = 0x30;
		public const int AV_LOG_MAX_OFFSET = 0x0; // (AV_LOG_DEBUG - AV_LOG_QUIET)
		public const int AV_LOG_SKIP_REPEATED = 0x1;
		public const int AVPALETTE_SIZE = 0x400;
		public const int AVPALETTE_COUNT = 0x100;
		public const int AV_PIX_FMT_Y400A = 0x42; // AV_PIX_FMT_GRAY8A
		public const int AV_PIX_FMT_GBR24P = 0x52; // AV_PIX_FMT_GBRP
		public const int PixelFormat = 0x0; // AVPixelFormat
		public const int PIX_FMT_Y400A = 0x0; // AV_PIX_FMT_Y400A
		public const int PIX_FMT_GBR24P = 0x0; // AV_PIX_FMT_GBR24P
		public const int PIX_FMT_RGB32 = 0x0; // AV_PIX_FMT_RGB32
		public const int PIX_FMT_RGB32_1 = 0x0; // AV_PIX_FMT_RGB32_1
		public const int PIX_FMT_BGR32 = 0x0; // AV_PIX_FMT_BGR32
		public const int PIX_FMT_BGR32_1 = 0x0; // AV_PIX_FMT_BGR32_1
		public const int PIX_FMT_0RGB32 = 0x0; // AV_PIX_FMT_0RGB32
		public const int PIX_FMT_0BGR32 = 0x0; // AV_PIX_FMT_0BGR32
		public const int PIX_FMT_GRAY16 = 0x0; // AV_PIX_FMT_GRAY16
		public const int PIX_FMT_RGB48 = 0x0; // AV_PIX_FMT_RGB48
		public const int PIX_FMT_RGB565 = 0x0; // AV_PIX_FMT_RGB565
		public const int PIX_FMT_RGB555 = 0x0; // AV_PIX_FMT_RGB555
		public const int PIX_FMT_RGB444 = 0x0; // AV_PIX_FMT_RGB444
		public const int PIX_FMT_BGR48 = 0x0; // AV_PIX_FMT_BGR48
		public const int PIX_FMT_BGR565 = 0x0; // AV_PIX_FMT_BGR565
		public const int PIX_FMT_BGR555 = 0x0; // AV_PIX_FMT_BGR555
		public const int PIX_FMT_BGR444 = 0x0; // AV_PIX_FMT_BGR444
		public const int PIX_FMT_YUV420P9 = 0x0; // AV_PIX_FMT_YUV420P9
		public const int PIX_FMT_YUV422P9 = 0x0; // AV_PIX_FMT_YUV422P9
		public const int PIX_FMT_YUV444P9 = 0x0; // AV_PIX_FMT_YUV444P9
		public const int PIX_FMT_YUV420P10 = 0x0; // AV_PIX_FMT_YUV420P10
		public const int PIX_FMT_YUV422P10 = 0x0; // AV_PIX_FMT_YUV422P10
		public const int PIX_FMT_YUV444P10 = 0x0; // AV_PIX_FMT_YUV444P10
		public const int PIX_FMT_YUV420P12 = 0x0; // AV_PIX_FMT_YUV420P12
		public const int PIX_FMT_YUV422P12 = 0x0; // AV_PIX_FMT_YUV422P12
		public const int PIX_FMT_YUV444P12 = 0x0; // AV_PIX_FMT_YUV444P12
		public const int PIX_FMT_YUV420P14 = 0x0; // AV_PIX_FMT_YUV420P14
		public const int PIX_FMT_YUV422P14 = 0x0; // AV_PIX_FMT_YUV422P14
		public const int PIX_FMT_YUV444P14 = 0x0; // AV_PIX_FMT_YUV444P14
		public const int PIX_FMT_YUV420P16 = 0x0; // AV_PIX_FMT_YUV420P16
		public const int PIX_FMT_YUV422P16 = 0x0; // AV_PIX_FMT_YUV422P16
		public const int PIX_FMT_YUV444P16 = 0x0; // AV_PIX_FMT_YUV444P16
		public const int PIX_FMT_RGBA64 = 0x0; // AV_PIX_FMT_RGBA64
		public const int PIX_FMT_BGRA64 = 0x0; // AV_PIX_FMT_BGRA64
		public const int PIX_FMT_GBRP9 = 0x0; // AV_PIX_FMT_GBRP9
		public const int PIX_FMT_GBRP10 = 0x0; // AV_PIX_FMT_GBRP10
		public const int PIX_FMT_GBRP12 = 0x0; // AV_PIX_FMT_GBRP12
		public const int PIX_FMT_GBRP14 = 0x0; // AV_PIX_FMT_GBRP14
		public const int PIX_FMT_GBRP16 = 0x0; // AV_PIX_FMT_GBRP16
		public const int AV_BUFFER_FLAG_READONLY = 0x1; // (1 << 0)
		public const uint AV_CPU_FLAG_FORCE = 0x80000000;
		public const int AV_CPU_FLAG_MMX = 0x1;
		public const int AV_CPU_FLAG_MMXEXT = 0x2;
		public const int AV_CPU_FLAG_MMX2 = 0x2;
		public const int AV_CPU_FLAG_3DNOW = 0x4;
		public const int AV_CPU_FLAG_SSE = 0x8;
		public const int AV_CPU_FLAG_SSE2 = 0x10;
		public const int AV_CPU_FLAG_SSE2SLOW = 0x40000000;
		public const int AV_CPU_FLAG_3DNOWEXT = 0x20;
		public const int AV_CPU_FLAG_SSE3 = 0x40;
		public const int AV_CPU_FLAG_SSE3SLOW = 0x20000000;
		public const int AV_CPU_FLAG_SSSE3 = 0x80;
		public const int AV_CPU_FLAG_ATOM = 0x10000000;
		public const int AV_CPU_FLAG_SSE4 = 0x100;
		public const int AV_CPU_FLAG_SSE42 = 0x200;
		public const int AV_CPU_FLAG_AVX = 0x4000;
		public const int AV_CPU_FLAG_XOP = 0x400;
		public const int AV_CPU_FLAG_FMA4 = 0x800;
		public const int AV_CPU_FLAG_CMOV = 0x1001000;
		public const int AV_CPU_FLAG_ALTIVEC = 0x1;
		public const int AV_CPU_FLAG_ARMV5TE = 0x1; // (1 << 0)
		public const int AV_CPU_FLAG_ARMV6 = 0x2; // (1 << 1)
		public const int AV_CPU_FLAG_ARMV6T2 = 0x4; // (1 << 2)
		public const int AV_CPU_FLAG_VFP = 0x8; // (1 << 3)
		public const int AV_CPU_FLAG_VFPV3 = 0x10; // (1 << 4)
		public const int AV_CPU_FLAG_NEON = 0x20; // (1 << 5)
		public const int AV_CH_FRONT_LEFT = 0x1;
		public const int AV_CH_FRONT_RIGHT = 0x2;
		public const int AV_CH_FRONT_CENTER = 0x4;
		public const int AV_CH_LOW_FREQUENCY = 0x8;
		public const int AV_CH_BACK_LEFT = 0x10;
		public const int AV_CH_BACK_RIGHT = 0x20;
		public const int AV_CH_FRONT_LEFT_OF_CENTER = 0x40;
		public const int AV_CH_FRONT_RIGHT_OF_CENTER = 0x80;
		public const int AV_CH_BACK_CENTER = 0x100;
		public const int AV_CH_SIDE_LEFT = 0x200;
		public const int AV_CH_SIDE_RIGHT = 0x400;
		public const int AV_CH_TOP_CENTER = 0x800;
		public const int AV_CH_TOP_FRONT_LEFT = 0x1000;
		public const int AV_CH_TOP_FRONT_CENTER = 0x2000;
		public const int AV_CH_TOP_FRONT_RIGHT = 0x4000;
		public const int AV_CH_TOP_BACK_LEFT = 0x8000;
		public const int AV_CH_TOP_BACK_CENTER = 0x10000;
		public const int AV_CH_TOP_BACK_RIGHT = 0x20000;
		public const int AV_CH_STEREO_LEFT = 0x20000000;
		public const int AV_CH_STEREO_RIGHT = 0x40000000;
		public const long AV_CH_WIDE_LEFT = 0x80000000L; // 2147483648L
		public const long AV_CH_WIDE_RIGHT = 0x100000000L; // 4294967296L
		public const long AV_CH_SURROUND_DIRECT_LEFT = 0x200000000L; // 8589934592L
		public const long AV_CH_SURROUND_DIRECT_RIGHT = 0x400000000L; // 17179869184L
		public const long AV_CH_LOW_FREQUENCY_2 = 0x800000000L; // 34359738368L
		public const ulong AV_CH_LAYOUT_NATIVE = 0x8000000000000000L; // 9223372036854775808L
		public const int AV_CH_LAYOUT_MONO = 0x0; // AV_CH_FRONT_CENTER
		public const int AV_CH_LAYOUT_STEREO = 0x0; // (AV_CH_FRONT_LEFT | AV_CH_FRONT_RIGHT)
		public const int AV_CH_LAYOUT_2POINT1 = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_2_1 = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_SURROUND = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_FRONT_CENTER)
		public const int AV_CH_LAYOUT_3POINT1 = 0x0; // (AV_CH_LAYOUT_SURROUND | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_4POINT0 = 0x0; // (AV_CH_LAYOUT_SURROUND | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_4POINT1 = 0x0; // (AV_CH_LAYOUT_4POINT0 | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_2_2 = 0x0; // ((AV_CH_LAYOUT_STEREO | AV_CH_SIDE_LEFT) | AV_CH_SIDE_RIGHT)
		public const int AV_CH_LAYOUT_QUAD = 0x0; // ((AV_CH_LAYOUT_STEREO | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_5POINT0 = 0x0; // ((AV_CH_LAYOUT_SURROUND | AV_CH_SIDE_LEFT) | AV_CH_SIDE_RIGHT)
		public const int AV_CH_LAYOUT_5POINT1 = 0x0; // (AV_CH_LAYOUT_5POINT0 | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_5POINT0_BACK = 0x0; // ((AV_CH_LAYOUT_SURROUND | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_5POINT1_BACK = 0x0; // (AV_CH_LAYOUT_5POINT0_BACK | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_6POINT0 = 0x0; // (AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT0_FRONT = 0x0; // ((AV_CH_LAYOUT_2_2 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_HEXAGONAL = 0x0; // (AV_CH_LAYOUT_5POINT0_BACK | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1 = 0x0; // (AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1_BACK = 0x0; // (AV_CH_LAYOUT_5POINT1_BACK | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1_FRONT = 0x0; // (AV_CH_LAYOUT_6POINT0_FRONT | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_7POINT0 = 0x0; // ((AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_7POINT0_FRONT = 0x0; // ((AV_CH_LAYOUT_5POINT0 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_7POINT1 = 0x0; // ((AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_7POINT1_WIDE = 0x0; // ((AV_CH_LAYOUT_5POINT1 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_7POINT1_WIDE_BACK = 0x0; // ((AV_CH_LAYOUT_5POINT1_BACK | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_OCTAGONAL = 0x0; // (((AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT) | AV_CH_BACK_CENTER) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_STEREO_DOWNMIX = 0x0; // (AV_CH_STEREO_LEFT | AV_CH_STEREO_RIGHT)
		public const int AV_DICT_MATCH_CASE = 0x1;
		public const int AV_DICT_IGNORE_SUFFIX = 0x2;
		public const int AV_DICT_DONT_STRDUP_KEY = 0x4;
		public const int AV_DICT_DONT_STRDUP_VAL = 0x8;
		public const int AV_DICT_DONT_OVERWRITE = 0x10;
		public const int AV_DICT_APPEND = 0x20;
		public const int LIBAVCODEC_VERSION_MAJOR = 0x37;
		public const int LIBAVCODEC_VERSION_MINOR = 0x12;
		public const int LIBAVCODEC_VERSION_MICRO = 0x66;
		public const int LIBAVCODEC_BUILD = 0x0; // LIBAVCODEC_VERSION_INT
		public const int FF_API_REQUEST_CHANNELS = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_ALLOC_CONTEXT = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 55)
		public const int FF_API_AVCODEC_OPEN = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 55)
		public const int FF_API_OLD_DECODE_AUDIO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_OLD_TIMECODE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 55)
		public const int FF_API_OLD_ENCODE_AUDIO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_OLD_ENCODE_VIDEO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_CODEC_ID = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_AVCODEC_RESAMPLE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_DEINTERLACE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_DESTRUCT_PACKET = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_GET_BUFFER = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_MISSING_SAMPLE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int FF_API_LOWRES = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 56)
		public const int AV_NUM_DATA_POINTERS = 0x8;
		public const int FF_DECODE_ERROR_INVALID_BITSTREAM = 0x1;
		public const int FF_DECODE_ERROR_MISSING_REFERENCE = 0x2;
		public const int AV_CODEC_PROP_INTRA_ONLY = 0x1; // (1 << 0)
		public const int AV_CODEC_PROP_LOSSY = 0x2; // (1 << 1)
		public const int AV_CODEC_PROP_LOSSLESS = 0x4; // (1 << 2)
		public const int AV_CODEC_PROP_BITMAP_SUB = 0x10000; // (1 << 16)
		public const int AV_CODEC_PROP_TEXT_SUB = 0x20000; // (1 << 17)
		public const int FF_INPUT_BUFFER_PADDING_SIZE = 0x10;
		public const int FF_MIN_BUFFER_SIZE = 0x4000;
		public const int AVCOL_SPC_YCGCO = 0x8; // AVCOL_SPC_YCOCG
		public const int FF_MAX_B_FRAMES = 0x10;
		public const int CODEC_FLAG_UNALIGNED = 0x1;
		public const int CODEC_FLAG_QSCALE = 0x2;
		public const int CODEC_FLAG_4MV = 0x4;
		public const int CODEC_FLAG_QPEL = 0x10;
		public const int CODEC_FLAG_GMC = 0x20;
		public const int CODEC_FLAG_MV0 = 0x40;
		public const int CODEC_FLAG_INPUT_PRESERVED = 0x100;
		public const int CODEC_FLAG_PASS1 = 0x200;
		public const int CODEC_FLAG_PASS2 = 0x400;
		public const int CODEC_FLAG_GRAY = 0x2000;
		public const int CODEC_FLAG_EMU_EDGE = 0x4000;
		public const int CODEC_FLAG_PSNR = 0x8000;
		public const int CODEC_FLAG_TRUNCATED = 0x10000;
		public const int CODEC_FLAG_NORMALIZE_AQP = 0x20000;
		public const int CODEC_FLAG_INTERLACED_DCT = 0x40000;
		public const int CODEC_FLAG_LOW_DELAY = 0x80000;
		public const int CODEC_FLAG_GLOBAL_HEADER = 0x400000;
		public const int CODEC_FLAG_BITEXACT = 0x800000;
		public const int CODEC_FLAG_AC_PRED = 0x1000000;
		public const int CODEC_FLAG_LOOP_FILTER = 0x800;
		public const int CODEC_FLAG_INTERLACED_ME = 0x20000000;
		public const uint CODEC_FLAG_CLOSED_GOP = 0x80000000;
		public const int CODEC_FLAG2_FAST = 0x1;
		public const int CODEC_FLAG2_NO_OUTPUT = 0x4;
		public const int CODEC_FLAG2_LOCAL_HEADER = 0x8;
		public const int CODEC_FLAG2_DROP_FRAME_TIMECODE = 0x2000;
		public const int CODEC_FLAG2_IGNORE_CROP = 0x10000;
		public const int CODEC_FLAG2_CHUNKS = 0x8000;
		public const int CODEC_FLAG2_SHOW_ALL = 0x400000;
		public const int CODEC_CAP_DRAW_HORIZ_BAND = 0x1;
		public const int CODEC_CAP_DR1 = 0x2;
		public const int CODEC_CAP_TRUNCATED = 0x8;
		public const int CODEC_CAP_HWACCEL = 0x10;
		public const int CODEC_CAP_DELAY = 0x20;
		public const int CODEC_CAP_SMALL_LAST_FRAME = 0x40;
		public const int CODEC_CAP_HWACCEL_VDPAU = 0x80;
		public const int CODEC_CAP_SUBFRAMES = 0x100;
		public const int CODEC_CAP_EXPERIMENTAL = 0x200;
		public const int CODEC_CAP_CHANNEL_CONF = 0x400;
		public const int CODEC_CAP_NEG_LINESIZES = 0x800;
		public const int CODEC_CAP_FRAME_THREADS = 0x1000;
		public const int CODEC_CAP_SLICE_THREADS = 0x2000;
		public const int CODEC_CAP_PARAM_CHANGE = 0x4000;
		public const int CODEC_CAP_AUTO_THREADS = 0x8000;
		public const int CODEC_CAP_VARIABLE_FRAME_SIZE = 0x10000;
		public const int CODEC_CAP_INTRA_ONLY = 0x40000000;
		public const uint CODEC_CAP_LOSSLESS = 0x80000000;
		public const int MB_TYPE_INTRA4x4 = 0x1;
		public const int MB_TYPE_INTRA16x16 = 0x2;
		public const int MB_TYPE_INTRA_PCM = 0x4;
		public const int MB_TYPE_16x16 = 0x8;
		public const int MB_TYPE_16x8 = 0x10;
		public const int MB_TYPE_8x16 = 0x20;
		public const int MB_TYPE_8x8 = 0x40;
		public const int MB_TYPE_INTERLACED = 0x80;
		public const int MB_TYPE_DIRECT2 = 0x100;
		public const int MB_TYPE_ACPRED = 0x200;
		public const int MB_TYPE_GMC = 0x400;
		public const int MB_TYPE_SKIP = 0x800;
		public const int MB_TYPE_P0L0 = 0x1000;
		public const int MB_TYPE_P1L0 = 0x2000;
		public const int MB_TYPE_P0L1 = 0x4000;
		public const int MB_TYPE_P1L1 = 0x8000;
		public const int MB_TYPE_L0 = 0x0; // (MB_TYPE_P0L0 | MB_TYPE_P1L0)
		public const int MB_TYPE_L1 = 0x0; // (MB_TYPE_P0L1 | MB_TYPE_P1L1)
		public const int MB_TYPE_L0L1 = 0x0; // (MB_TYPE_L0 | MB_TYPE_L1)
		public const int MB_TYPE_QUANT = 0x10000;
		public const int MB_TYPE_CBP = 0x20000;
		public const int FF_QSCALE_TYPE_MPEG1 = 0x0;
		public const int FF_QSCALE_TYPE_MPEG2 = 0x1;
		public const int FF_QSCALE_TYPE_H264 = 0x2;
		public const int FF_QSCALE_TYPE_VP56 = 0x3;
		public const int FF_BUFFER_TYPE_INTERNAL = 0x1;
		public const int FF_BUFFER_TYPE_USER = 0x2;
		public const int FF_BUFFER_TYPE_SHARED = 0x4;
		public const int FF_BUFFER_TYPE_COPY = 0x8;
		public const int FF_BUFFER_HINTS_VALID = 0x1;
		public const int FF_BUFFER_HINTS_READABLE = 0x2;
		public const int FF_BUFFER_HINTS_PRESERVE = 0x4;
		public const int FF_BUFFER_HINTS_REUSABLE = 0x8;
		public const int AV_GET_BUFFER_FLAG_REF = 0x1; // (1 << 0)
		public const int AV_PKT_FLAG_KEY = 0x1;
		public const int AV_PKT_FLAG_CORRUPT = 0x2;
		public const int FF_COMPRESSION_DEFAULT = -0x1; // (-1)
		public const int FF_ASPECT_EXTENDED = 0xf;
		public const int FF_RC_STRATEGY_XVID = 0x1;
		public const int FF_PRED_LEFT = 0x0;
		public const int FF_PRED_PLANE = 0x1;
		public const int FF_PRED_MEDIAN = 0x2;
		public const int FF_CMP_SAD = 0x0;
		public const int FF_CMP_SSE = 0x1;
		public const int FF_CMP_SATD = 0x2;
		public const int FF_CMP_DCT = 0x3;
		public const int FF_CMP_PSNR = 0x4;
		public const int FF_CMP_BIT = 0x5;
		public const int FF_CMP_RD = 0x6;
		public const int FF_CMP_ZERO = 0x7;
		public const int FF_CMP_VSAD = 0x8;
		public const int FF_CMP_VSSE = 0x9;
		public const int FF_CMP_NSSE = 0xa;
		public const int FF_CMP_W53 = 0xb;
		public const int FF_CMP_W97 = 0xc;
		public const int FF_CMP_DCTMAX = 0xd;
		public const int FF_CMP_DCT264 = 0xe;
		public const int FF_CMP_CHROMA = 0x100;
		public const int FF_DTG_AFD_SAME = 0x8;
		public const int FF_DTG_AFD_4_3 = 0x9;
		public const int FF_DTG_AFD_16_9 = 0xa;
		public const int FF_DTG_AFD_14_9 = 0xb;
		public const int FF_DTG_AFD_4_3_SP_14_9 = 0xd;
		public const int FF_DTG_AFD_16_9_SP_14_9 = 0xe;
		public const int FF_DTG_AFD_SP_4_3 = 0xf;
		public const int FF_DEFAULT_QUANT_BIAS = 0xf423f;
		public const int SLICE_FLAG_CODED_ORDER = 0x1;
		public const int SLICE_FLAG_ALLOW_FIELD = 0x2;
		public const int SLICE_FLAG_ALLOW_PLANE = 0x4;
		public const int FF_MB_DECISION_SIMPLE = 0x0;
		public const int FF_MB_DECISION_BITS = 0x1;
		public const int FF_MB_DECISION_RD = 0x2;
		public const int FF_CODER_TYPE_VLC = 0x0;
		public const int FF_CODER_TYPE_AC = 0x1;
		public const int FF_CODER_TYPE_RAW = 0x2;
		public const int FF_CODER_TYPE_RLE = 0x3;
		public const int FF_CODER_TYPE_DEFLATE = 0x4;
		public const int FF_BUG_AUTODETECT = 0x1;
		public const int FF_BUG_OLD_MSMPEG4 = 0x2;
		public const int FF_BUG_XVID_ILACE = 0x4;
		public const int FF_BUG_UMP4 = 0x8;
		public const int FF_BUG_NO_PADDING = 0x10;
		public const int FF_BUG_AMV = 0x20;
		public const int FF_BUG_AC_VLC = 0x0;
		public const int FF_BUG_QPEL_CHROMA = 0x40;
		public const int FF_BUG_STD_QPEL = 0x80;
		public const int FF_BUG_QPEL_CHROMA2 = 0x100;
		public const int FF_BUG_DIRECT_BLOCKSIZE = 0x200;
		public const int FF_BUG_EDGE = 0x400;
		public const int FF_BUG_HPEL_CHROMA = 0x800;
		public const int FF_BUG_DC_CLIP = 0x1000;
		public const int FF_BUG_MS = 0x2000;
		public const int FF_BUG_TRUNCATED = 0x4000;
		public const int FF_COMPLIANCE_VERY_STRICT = 0x2;
		public const int FF_COMPLIANCE_STRICT = 0x1;
		public const int FF_COMPLIANCE_NORMAL = 0x0;
		public const int FF_COMPLIANCE_UNOFFICIAL = -0x1; // (-1)
		public const int FF_COMPLIANCE_EXPERIMENTAL = -0x2; // (-2)
		public const int FF_EC_GUESS_MVS = 0x1;
		public const int FF_EC_DEBLOCK = 0x2;
		public const int FF_DEBUG_PICT_INFO = 0x1;
		public const int FF_DEBUG_RC = 0x2;
		public const int FF_DEBUG_BITSTREAM = 0x4;
		public const int FF_DEBUG_MB_TYPE = 0x8;
		public const int FF_DEBUG_QP = 0x10;
		public const int FF_DEBUG_MV = 0x20;
		public const int FF_DEBUG_DCT_COEFF = 0x40;
		public const int FF_DEBUG_SKIP = 0x80;
		public const int FF_DEBUG_STARTCODE = 0x100;
		public const int FF_DEBUG_PTS = 0x200;
		public const int FF_DEBUG_ER = 0x400;
		public const int FF_DEBUG_MMCO = 0x800;
		public const int FF_DEBUG_BUGS = 0x1000;
		public const int FF_DEBUG_VIS_QP = 0x2000;
		public const int FF_DEBUG_VIS_MB_TYPE = 0x4000;
		public const int FF_DEBUG_BUFFERS = 0x8000;
		public const int FF_DEBUG_THREADS = 0x10000;
		public const int FF_DEBUG_VIS_MV_P_FOR = 0x1;
		public const int FF_DEBUG_VIS_MV_B_FOR = 0x2;
		public const int FF_DEBUG_VIS_MV_B_BACK = 0x4;
		public const int AV_EF_CRCCHECK = 0x1; // (1 << 0)
		public const int AV_EF_BITSTREAM = 0x2; // (1 << 1)
		public const int AV_EF_BUFFER = 0x4; // (1 << 2)
		public const int AV_EF_EXPLODE = 0x8; // (1 << 3)
		public const int AV_EF_CAREFUL = 0x10000; // (1 << 16)
		public const int AV_EF_COMPLIANT = 0x20000; // (1 << 17)
		public const int AV_EF_AGGRESSIVE = 0x40000; // (1 << 18)
		public const int FF_DCT_AUTO = 0x0;
		public const int FF_DCT_FASTINT = 0x1;
		public const int FF_DCT_INT = 0x2;
		public const int FF_DCT_MMX = 0x3;
		public const int FF_DCT_ALTIVEC = 0x5;
		public const int FF_DCT_FAAN = 0x6;
		public const int FF_IDCT_AUTO = 0x0;
		public const int FF_IDCT_INT = 0x1;
		public const int FF_IDCT_SIMPLE = 0x2;
		public const int FF_IDCT_SIMPLEMMX = 0x3;
		public const int FF_IDCT_ARM = 0x7;
		public const int FF_IDCT_ALTIVEC = 0x8;
		public const int FF_IDCT_SH4 = 0x9;
		public const int FF_IDCT_SIMPLEARM = 0xa;
		public const int FF_IDCT_IPP = 0xd;
		public const int FF_IDCT_XVIDMMX = 0xe;
		public const int FF_IDCT_SIMPLEARMV5TE = 0x10;
		public const int FF_IDCT_SIMPLEARMV6 = 0x11;
		public const int FF_IDCT_SIMPLEVIS = 0x12;
		public const int FF_IDCT_FAAN = 0x14;
		public const int FF_IDCT_SIMPLENEON = 0x16;
		public const int FF_IDCT_SIMPLEALPHA = 0x17;
		public const int FF_THREAD_FRAME = 0x1;
		public const int FF_THREAD_SLICE = 0x2;
		public const int FF_PROFILE_UNKNOWN = -0x63; // (-99)
		public const int FF_PROFILE_RESERVED = -0x64; // (-100)
		public const int FF_PROFILE_AAC_MAIN = 0x0;
		public const int FF_PROFILE_AAC_LOW = 0x1;
		public const int FF_PROFILE_AAC_SSR = 0x2;
		public const int FF_PROFILE_AAC_LTP = 0x3;
		public const int FF_PROFILE_AAC_HE = 0x4;
		public const int FF_PROFILE_AAC_HE_V2 = 0x1c;
		public const int FF_PROFILE_AAC_LD = 0x16;
		public const int FF_PROFILE_AAC_ELD = 0x26;
		public const int FF_PROFILE_MPEG2_AAC_LOW = 0x80;
		public const int FF_PROFILE_MPEG2_AAC_HE = 0x83;
		public const int FF_PROFILE_DTS = 0x14;
		public const int FF_PROFILE_DTS_ES = 0x1e;
		public const int FF_PROFILE_DTS_96_24 = 0x28;
		public const int FF_PROFILE_DTS_HD_HRA = 0x32;
		public const int FF_PROFILE_DTS_HD_MA = 0x3c;
		public const int FF_PROFILE_MPEG2_422 = 0x0;
		public const int FF_PROFILE_MPEG2_HIGH = 0x1;
		public const int FF_PROFILE_MPEG2_SS = 0x2;
		public const int FF_PROFILE_MPEG2_SNR_SCALABLE = 0x3;
		public const int FF_PROFILE_MPEG2_MAIN = 0x4;
		public const int FF_PROFILE_MPEG2_SIMPLE = 0x5;
		public const int FF_PROFILE_H264_CONSTRAINED = 0x200; // (1 << 9)
		public const int FF_PROFILE_H264_INTRA = 0x800; // (1 << 11)
		public const int FF_PROFILE_H264_BASELINE = 0x42;
		public const int FF_PROFILE_H264_CONSTRAINED_BASELINE = 0x42; // (66 | FF_PROFILE_H264_CONSTRAINED)
		public const int FF_PROFILE_H264_MAIN = 0x4d;
		public const int FF_PROFILE_H264_EXTENDED = 0x58;
		public const int FF_PROFILE_H264_HIGH = 0x64;
		public const int FF_PROFILE_H264_HIGH_10 = 0x6e;
		public const int FF_PROFILE_H264_HIGH_10_INTRA = 0x6e; // (110 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_HIGH_422 = 0x7a;
		public const int FF_PROFILE_H264_HIGH_422_INTRA = 0x7a; // (122 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_HIGH_444 = 0x90;
		public const int FF_PROFILE_H264_HIGH_444_PREDICTIVE = 0xf4;
		public const int FF_PROFILE_H264_HIGH_444_INTRA = 0xf4; // (244 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_CAVLC_444 = 0x2c;
		public const int FF_PROFILE_VC1_SIMPLE = 0x0;
		public const int FF_PROFILE_VC1_MAIN = 0x1;
		public const int FF_PROFILE_VC1_COMPLEX = 0x2;
		public const int FF_PROFILE_VC1_ADVANCED = 0x3;
		public const int FF_PROFILE_MPEG4_SIMPLE = 0x0;
		public const int FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 0x1;
		public const int FF_PROFILE_MPEG4_CORE = 0x2;
		public const int FF_PROFILE_MPEG4_MAIN = 0x3;
		public const int FF_PROFILE_MPEG4_N_BIT = 0x4;
		public const int FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 0x5;
		public const int FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 0x6;
		public const int FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 0x7;
		public const int FF_PROFILE_MPEG4_HYBRID = 0x8;
		public const int FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 0x9;
		public const int FF_PROFILE_MPEG4_CORE_SCALABLE = 0xa;
		public const int FF_PROFILE_MPEG4_ADVANCED_CODING = 0xb;
		public const int FF_PROFILE_MPEG4_ADVANCED_CORE = 0xc;
		public const int FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 0xd;
		public const int FF_PROFILE_MPEG4_SIMPLE_STUDIO = 0xe;
		public const int FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 0xf;
		public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 0x0;
		public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 0x1;
		public const int FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 0x2;
		public const int FF_PROFILE_JPEG2000_DCINEMA_2K = 0x3;
		public const int FF_PROFILE_JPEG2000_DCINEMA_4K = 0x4;
		public const int FF_LEVEL_UNKNOWN = -0x63; // (-99)
		public const int FF_SUB_CHARENC_MODE_DO_NOTHING = -0x1; // (-1)
		public const int FF_SUB_CHARENC_MODE_AUTOMATIC = 0x0;
		public const int FF_SUB_CHARENC_MODE_PRE_DECODER = 0x1;
		public const int AV_SUBTITLE_FLAG_FORCED = 0x1;
		public const int AV_PARSER_PTS_NB = 0x4;
		public const int PARSER_FLAG_COMPLETE_FRAMES = 0x1;
		public const int PARSER_FLAG_ONCE = 0x2;
		public const int PARSER_FLAG_FETCHED_OFFSET = 0x4;
		public const int PARSER_FLAG_USE_CODEC_TS = 0x1000;
		public const int FF_LOSS_RESOLUTION = 0x1;
		public const int FF_LOSS_DEPTH = 0x2;
		public const int FF_LOSS_COLORSPACE = 0x4;
		public const int FF_LOSS_ALPHA = 0x8;
		public const int FF_LOSS_COLORQUANT = 0x10;
		public const int FF_LOSS_CHROMA = 0x20;
		public const int LIBAVDEVICE_VERSION_MAJOR = 0x37;
		public const int LIBAVDEVICE_VERSION_MINOR = 0x3;
		public const int LIBAVDEVICE_VERSION_MICRO = 0x64;
		public const int LIBAVDEVICE_BUILD = 0x0; // LIBAVDEVICE_VERSION_INT
		public const int LIBAVFORMAT_VERSION_MAJOR = 0x37;
		public const int LIBAVFORMAT_VERSION_MINOR = 0xc;
		public const int LIBAVFORMAT_VERSION_MICRO = 0x64;
		public const int LIBAVFORMAT_BUILD = 0x0; // LIBAVFORMAT_VERSION_INT
		public const int FF_API_OLD_AVIO = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 55)
		public const int FF_API_PKT_DUMP = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 54)
		public const int FF_API_ALLOC_OUTPUT_CONTEXT = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_FORMAT_PARAMETERS = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_NEW_STREAM = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_SET_PTS_INFO = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_CLOSE_INPUT_FILE = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_READ_PACKET = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_ASS_SSA = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 56)
		public const int FF_API_R_FRAME_RATE = 0x1;
		public const int AVIO_SEEKABLE_NORMAL = 0x1;
		public const int AVSEEK_SIZE = 0x10000;
		public const int AVSEEK_FORCE = 0x20000;
		public const int AVIO_FLAG_READ = 0x1;
		public const int AVIO_FLAG_WRITE = 0x2;
		public const int AVIO_FLAG_READ_WRITE = 0x0; // (AVIO_FLAG_READ | AVIO_FLAG_WRITE)
		public const int AVIO_FLAG_NONBLOCK = 0x8;
		public const int AVIO_FLAG_DIRECT = 0x8000;
		public const int AVPROBE_SCORE_RETRY = 0x0; // (AVPROBE_SCORE_MAX / 4)
		public const int AVPROBE_SCORE_EXTENSION = 0x32;
		public const int AVPROBE_SCORE_MAX = 0x64;
		public const int AVPROBE_PADDING_SIZE = 0x20;
		public const int AVFMT_NOFILE = 0x1;
		public const int AVFMT_NEEDNUMBER = 0x2;
		public const int AVFMT_SHOW_IDS = 0x8;
		public const int AVFMT_RAWPICTURE = 0x20;
		public const int AVFMT_GLOBALHEADER = 0x40;
		public const int AVFMT_NOTIMESTAMPS = 0x80;
		public const int AVFMT_GENERIC_INDEX = 0x100;
		public const int AVFMT_TS_DISCONT = 0x200;
		public const int AVFMT_VARIABLE_FPS = 0x400;
		public const int AVFMT_NODIMENSIONS = 0x800;
		public const int AVFMT_NOSTREAMS = 0x1000;
		public const int AVFMT_NOBINSEARCH = 0x2000;
		public const int AVFMT_NOGENSEARCH = 0x4000;
		public const int AVFMT_NO_BYTE_SEEK = 0x8000;
		public const int AVFMT_ALLOW_FLUSH = 0x10000;
		public const int AVFMT_TS_NONSTRICT = 0x20000;
		public const int AVFMT_TS_NEGATIVE = 0x40000;
		public const int AVFMT_SEEK_TO_PTS = 0x4000000;
		public const int AVINDEX_KEYFRAME = 0x1;
		public const int AV_DISPOSITION_DEFAULT = 0x1;
		public const int AV_DISPOSITION_DUB = 0x2;
		public const int AV_DISPOSITION_ORIGINAL = 0x4;
		public const int AV_DISPOSITION_COMMENT = 0x8;
		public const int AV_DISPOSITION_LYRICS = 0x10;
		public const int AV_DISPOSITION_KARAOKE = 0x20;
		public const int AV_DISPOSITION_FORCED = 0x40;
		public const int AV_DISPOSITION_HEARING_IMPAIRED = 0x80;
		public const int AV_DISPOSITION_VISUAL_IMPAIRED = 0x100;
		public const int AV_DISPOSITION_CLEAN_EFFECTS = 0x200;
		public const int AV_DISPOSITION_ATTACHED_PIC = 0x400;
		public const int AV_DISPOSITION_CAPTIONS = 0x10000;
		public const int AV_DISPOSITION_DESCRIPTIONS = 0x20000;
		public const int AV_DISPOSITION_METADATA = 0x40000;
		public const int AV_PTS_WRAP_IGNORE = 0x0;
		public const int AV_PTS_WRAP_ADD_OFFSET = 0x1;
		public const int AV_PTS_WRAP_SUB_OFFSET = -0x1; // (-1)
		public const int MAX_STD_TIMEBASES = 0x2d6; // ((60 * 12) + 6)
		public const int MAX_PROBE_PACKETS = 0x9c4;
		public const int MAX_REORDER_DELAY = 0x10;
		public const int AV_PROGRAM_RUNNING = 0x1;
		public const int AVFMTCTX_NOHEADER = 0x1;
		public const int AVFMT_FLAG_GENPTS = 0x1;
		public const int AVFMT_FLAG_IGNIDX = 0x2;
		public const int AVFMT_FLAG_NONBLOCK = 0x4;
		public const int AVFMT_FLAG_IGNDTS = 0x8;
		public const int AVFMT_FLAG_NOFILLIN = 0x10;
		public const int AVFMT_FLAG_NOPARSE = 0x20;
		public const int AVFMT_FLAG_NOBUFFER = 0x40;
		public const int AVFMT_FLAG_CUSTOM_IO = 0x80;
		public const int AVFMT_FLAG_DISCARD_CORRUPT = 0x100;
		public const int AVFMT_FLAG_MP4A_LATM = 0x8000;
		public const int AVFMT_FLAG_SORT_DTS = 0x10000;
		public const int AVFMT_FLAG_PRIV_OPT = 0x20000;
		public const int AVFMT_FLAG_KEEP_SIDE_DATA = 0x40000;
		public const int FF_FDEBUG_TS = 0x1;
		public const int RAW_PACKET_BUFFER_SIZE = 0x2625a0;
		public const int AVSEEK_FLAG_BACKWARD = 0x1;
		public const int AVSEEK_FLAG_BYTE = 0x2;
		public const int AVSEEK_FLAG_ANY = 0x4;
		public const int AVSEEK_FLAG_FRAME = 0x8;
		public const int LIBAVFILTER_VERSION_MAJOR = 0x3;
		public const int LIBAVFILTER_VERSION_MINOR = 0x4f;
		public const int LIBAVFILTER_VERSION_MICRO = 0x65;
		public const int LIBAVFILTER_BUILD = 0x0; // LIBAVFILTER_VERSION_INT
		public const int FF_API_AVFILTERPAD_PUBLIC = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_FOO_COUNT = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_FILL_FRAME = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_BUFFERSRC_BUFFER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_AVFILTERBUFFER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_OLD_FILTER_OPTS = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_ACONVERT_FILTER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_AVFILTER_OPEN = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_AVFILTER_INIT_FILTER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_OLD_FILTER_REGISTER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int FF_API_OLD_GRAPH_PARSE = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 4)
		public const int AV_PERM_READ = 0x1;
		public const int AV_PERM_WRITE = 0x2;
		public const int AV_PERM_PRESERVE = 0x4;
		public const int AV_PERM_REUSE = 0x8;
		public const int AV_PERM_REUSE2 = 0x10;
		public const int AV_PERM_NEG_LINESIZES = 0x20;
		public const int AV_PERM_ALIGN = 0x40;
		public const int AVFILTER_ALIGN = 0x10;
		public const int AVFILTER_FLAG_DYNAMIC_INPUTS = 0x1; // (1 << 0)
		public const int AVFILTER_FLAG_DYNAMIC_OUTPUTS = 0x2; // (1 << 1)
		public const int AVFILTER_FLAG_SLICE_THREADS = 0x4; // (1 << 2)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = 0x10000; // (1 << 16)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = 0x20000; // (1 << 17)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE = 0x0; // (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL)
		public const int AVFILTER_THREAD_SLICE = 0x1; // (1 << 0)
		public const int AVFILTER_CMD_FLAG_ONE = 0x1;
		public const int AVFILTER_CMD_FLAG_FAST = 0x2;
		public const int LIBPOSTPROC_VERSION_MAJOR = 0x34;
		public const int LIBPOSTPROC_VERSION_MINOR = 0x3;
		public const int LIBPOSTPROC_VERSION_MICRO = 0x64;
		public const int LIBPOSTPROC_BUILD = 0x0; // LIBPOSTPROC_VERSION_INT
		public const int PP_QUALITY_MAX = 0x6;
		public const uint PP_CPU_CAPS_MMX = 0x80000000;
		public const int PP_CPU_CAPS_MMX2 = 0x20000000;
		public const int PP_CPU_CAPS_3DNOW = 0x40000000;
		public const int PP_CPU_CAPS_ALTIVEC = 0x10000000;
		public const int PP_CPU_CAPS_AUTO = 0x80000;
		public const int PP_FORMAT = 0x8;
		public const int PP_FORMAT_420 = 0x11; // (17 | PP_FORMAT)
		public const int PP_FORMAT_422 = 0x1; // (1 | PP_FORMAT)
		public const int PP_FORMAT_411 = 0x2; // (2 | PP_FORMAT)
		public const int PP_FORMAT_444 = 0x0; // (0 | PP_FORMAT)
		public const int PP_PICT_TYPE_QP2 = 0x10;
		public const int LIBSWRESAMPLE_VERSION_MAJOR = 0x0;
		public const int LIBSWRESAMPLE_VERSION_MINOR = 0x11;
		public const int LIBSWRESAMPLE_VERSION_MICRO = 0x66;
		public const int LIBSWRESAMPLE_BUILD = 0x0; // LIBSWRESAMPLE_VERSION_INT
		public const int SWR_CH_MAX = 0x20;
		public const int SWR_FLAG_RESAMPLE = 0x1;
		public const int LIBSWSCALE_VERSION_MAJOR = 0x2;
		public const int LIBSWSCALE_VERSION_MINOR = 0x3;
		public const int LIBSWSCALE_VERSION_MICRO = 0x64;
		public const int LIBSWSCALE_BUILD = 0x0; // LIBSWSCALE_VERSION_INT
		public const int FF_API_SWS_GETCONTEXT = 0x1; // (LIBSWSCALE_VERSION_MAJOR < 3)
		public const int FF_API_SWS_CPU_CAPS = 0x1; // (LIBSWSCALE_VERSION_MAJOR < 3)
		public const int FF_API_SWS_FORMAT_NAME = 0x1; // (LIBSWSCALE_VERSION_MAJOR < 3)
		public const int SWS_FAST_BILINEAR = 0x1;
		public const int SWS_BILINEAR = 0x2;
		public const int SWS_BICUBIC = 0x4;
		public const int SWS_X = 0x8;
		public const int SWS_POINT = 0x10;
		public const int SWS_AREA = 0x20;
		public const int SWS_BICUBLIN = 0x40;
		public const int SWS_GAUSS = 0x80;
		public const int SWS_SINC = 0x100;
		public const int SWS_LANCZOS = 0x200;
		public const int SWS_SPLINE = 0x400;
		public const int SWS_SRC_V_CHR_DROP_MASK = 0x30000;
		public const int SWS_SRC_V_CHR_DROP_SHIFT = 0x10;
		public const int SWS_PARAM_DEFAULT = 0x1e240;
		public const int SWS_PRINT_INFO = 0x1000;
		public const int SWS_FULL_CHR_H_INT = 0x2000;
		public const int SWS_FULL_CHR_H_INP = 0x4000;
		public const int SWS_DIRECT_BGR = 0x8000;
		public const int SWS_ACCURATE_RND = 0x40000;
		public const int SWS_BITEXACT = 0x80000;
		public const int SWS_ERROR_DIFFUSION = 0x800000;
		public const uint SWS_CPU_CAPS_MMX = 0x80000000;
		public const int SWS_CPU_CAPS_MMXEXT = 0x20000000;
		public const int SWS_CPU_CAPS_MMX2 = 0x20000000;
		public const int SWS_CPU_CAPS_3DNOW = 0x40000000;
		public const int SWS_CPU_CAPS_ALTIVEC = 0x10000000;
		public const int SWS_CPU_CAPS_BFIN = 0x1000000;
		public const int SWS_CPU_CAPS_SSE2 = 0x2000000;
		public const float SWS_MAX_REDUCE_CUTOFF = 0.002000f;
		public const int SWS_CS_ITU709 = 0x1;
		public const int SWS_CS_FCC = 0x4;
		public const int SWS_CS_ITU601 = 0x5;
		public const int SWS_CS_ITU624 = 0x5;
		public const int SWS_CS_SMPTE170M = 0x5;
		public const int SWS_CS_SMPTE240M = 0x7;
		public const int SWS_CS_DEFAULT = 0x5;
		
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avutil_version();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avutil_configuration();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avutil_license();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_media_type_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_media_type_string(AVMediaType media_type);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_picture_type_char", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte av_get_picture_type_char(AVPictureType pict_type);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log2(int v);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log2_16bit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log2_16bit(int v);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_strerror", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_strerror(int errnum, String errbuf, uint errbuf_size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_malloc(uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc(void* ptr, uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc_f", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc_f(void* ptr, uint nelem, uint elsize);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc_array(void* ptr, uint nmemb, uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_reallocp_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_reallocp_array(void* ptr, uint nmemb, uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_free(void* ptr);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_mallocz(uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_calloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_calloc(uint nmemb, uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_strdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_strdup(String s);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_memdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_memdup(void* p, uint size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_freep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_freep(void* ptr);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dynarray_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dynarray_add(void* tab_ptr, int* nb_ptr, void* elem);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dynarray2_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_dynarray2_add(void** tab_ptr, int* nb_ptr, uint elem_size, byte* elem_data);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_max_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_max_alloc(uint max);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_memcpy_backptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_memcpy_backptr(byte* dst, int back, int cnt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_reduce", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_reduce(int* dst_num, int* dst_den, long num, long den, long max);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_mul_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_mul_q(AVRational b, AVRational c);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_div_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_div_q(AVRational b, AVRational c);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_add_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_add_q(AVRational b, AVRational c);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_sub_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_sub_q(AVRational b, AVRational c);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_d2q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_d2q(double d, int max);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_nearer_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_nearer_q(AVRational q, AVRational q1, AVRational q2);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_find_nearest_q_idx", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_nearest_q_idx(AVRational q, AVRational* q_list);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_gcd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_gcd(long a, long b);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale(long a, long b, long c);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_rnd(long a, long b, long c, AVRounding p3);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_q(long a, AVRational bq, AVRational cq);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_q_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_q_rnd(long a, AVRational bq, AVRational cq, AVRounding p3);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_compare_ts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_compare_ts(long ts_a, AVRational tb_a, long ts_b, AVRational tb_b);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_compare_mod", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_compare_mod(ulong a, ulong b, ulong mod);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_delta", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_delta(AVRational in_tb, long in_ts, AVRational fs_tb, int duration, long* last, AVRational out_tb);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_int2dbl", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double av_int2dbl(long v);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_int2flt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern float av_int2flt(int v);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_ext2dbl", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double av_ext2dbl(AVExtFloat ext);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dbl2int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_dbl2int(double d);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_flt2int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_flt2int(float d);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dbl2ext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVExtFloat av_dbl2ext(double d);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log(void* avcl, int level, String fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_vlog", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_vlog(void* avcl, int level, String fmt, void* p3);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_get_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log_get_level();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_set_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_set_level(int p0);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_set_callback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_set_callback(IntPtr None);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_default_callback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_default_callback(void* ptr, int level, String fmt, void* vl);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_default_item_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_default_item_name(void* ctx);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_default_get_category", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClassCategory av_default_get_category(void* ptr);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_format_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_format_line(void* ptr, int level, String fmt, void* vl, String line, int line_size, int* print_prefix);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_set_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_set_flags(int arg);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_int_list_length_for_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_int_list_length_for_size(int elsize, void* list, ulong term);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_sample_fmt_name(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_sample_fmt(String name);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_alt_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat sample_fmt, int planar);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_packed_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_planar_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_sample_fmt_string(String buf, int buf_size, AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_bits_per_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bits_per_sample_fmt(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bytes_per_sample(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_sample_fmt_is_planar", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_sample_fmt_is_planar(AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_get_buffer_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_get_buffer_size(int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_fill_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_fill_arrays(byte** audio_data, int* linesize, byte* buf, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_alloc(byte** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_alloc_array_and_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_alloc_array_and_samples(byte*** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_copy(byte** dst, byte** src, int dst_offset, int src_offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_set_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_set_silence(byte** audio_data, int offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_alloc(int size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_allocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_allocz(int size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_create(byte* data, int size, IntPtr free, void* opaque, int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_default_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_default_free(void* opaque, byte* data);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_ref(AVBufferRef* buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_unref(AVBufferRef** buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_is_writable(AVBufferRef* buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_get_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_buffer_get_opaque(AVBufferRef* buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_get_ref_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_get_ref_count(AVBufferRef* buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_make_writable(AVBufferRef** buf);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_realloc(AVBufferRef** buf, int size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferPool* av_buffer_pool_init(int size, IntPtr alloc);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_pool_uninit(AVBufferPool** pool);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* pool);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_cpu_flags();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_force_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_force_cpu_flags(int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_cpu_flags_mask", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_set_cpu_flags_mask(int mask);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_parse_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parse_cpu_flags(String s);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_parse_cpu_caps", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parse_cpu_caps(int* flags, String s);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_cpu_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_cpu_count();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="ff_get_cpu_flags_x86", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int ff_get_cpu_flags_x86();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong av_get_channel_layout(String name);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_get_channel_layout_string(String buf, int buf_size, int nb_channels, ulong channel_layout);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_bprint_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_bprint_channel_layout(AVBPrint* bp, int nb_channels, ulong channel_layout);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_nb_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_channel_layout_nb_channels(ulong channel_layout);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_default_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_get_default_channel_layout(int nb_channels);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_channel_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_channel_layout_channel_index(ulong channel_layout, ulong channel);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_channel_layout_extract_channel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong av_channel_layout_extract_channel(ulong channel_layout, int index);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_channel_name(ulong channel);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_description", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_channel_description(ulong channel);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_standard_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_standard_channel_layout(int index, ulong* layout, byte** name);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionaryEntry* av_dict_get(AVDictionary* m, String key, AVDictionaryEntry* prev, int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_count(AVDictionary* m);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_set(AVDictionary** pm, String key, String value, int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_parse_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_parse_string(AVDictionary** pm, String str, String key_val_sep, String pairs_sep, int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dict_copy(AVDictionary** dst, AVDictionary* src, int flags);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dict_free(AVDictionary** m);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_best_effort_timestamp(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_best_effort_timestamp(AVFrame* frame, long val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_pkt_duration(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_duration(AVFrame* frame, long val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_pkt_pos(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_pos(AVFrame* frame, long val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_channel_layout(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_channel_layout(AVFrame* frame, long val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_channels(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_channels(AVFrame* frame, int val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_sample_rate(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_sample_rate(AVFrame* frame, int val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionary* av_frame_get_metadata(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_metadata(AVFrame* frame, AVDictionary* val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_decode_error_flags(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_decode_error_flags(AVFrame* frame, int val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_pkt_size(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_size(AVFrame* frame, int val);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avpriv_frame_get_metadatap", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionary** avpriv_frame_get_metadatap(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern sbyte* av_frame_get_qp_table(AVFrame* f, int* stride, int* type);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_set_qp_table(AVFrame* f, AVBufferRef* buf, int stride, int type);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* av_frame_alloc();
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_free(AVFrame** frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_ref(AVFrame* dst, AVFrame* src);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_clone", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* av_frame_clone(AVFrame* src);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_unref(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_move_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_move_ref(AVFrame* dst, AVFrame* src);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_buffer(AVFrame* frame, int align);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_is_writable(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_make_writable(AVFrame* frame);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_copy_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_copy_props(AVFrame* dst, AVFrame* src);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_plane_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* frame, int plane);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* frame, AVFrameSideDataType type, int size);
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* frame, AVFrameSideDataType type);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_codec_get_pkt_timebase(AVCodecContext* avctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_pkt_timebase(AVCodecContext* avctx, AVRational val);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* avctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_codec_descriptor(AVCodecContext* avctx, AVCodecDescriptor* desc);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_lowres(AVCodecContext* avctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_lowres(AVCodecContext* avctx, int val);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* av_codec_next(AVCodec* c);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_version();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_configuration();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_license();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_register(AVCodec* codec);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_register_all();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_alloc_context3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* codec);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_context_defaults3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_context_defaults3(AVCodecContext* s, AVCodec* codec);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_class();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_frame_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_frame_class();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_subtitle_rect_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_subtitle_rect_class();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_copy_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_copy_context(AVCodecContext* dest, AVCodecContext* src);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_alloc_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* avcodec_alloc_frame();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_frame_defaults", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_get_frame_defaults(AVFrame* frame);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_free_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_free_frame(AVFrame** frame);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_open2(AVCodecContext* avctx, AVCodec* codec, AVDictionary** options);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_close(AVCodecContext* avctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avsubtitle_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avsubtitle_free(AVSubtitle* sub);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_destruct_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_destruct_packet(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_init_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_init_packet(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_new_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_new_packet(AVPacket* pkt, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_shrink_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_shrink_packet(AVPacket* pkt, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_grow_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_grow_packet(AVPacket* pkt, int grow_by);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_from_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_from_data(AVPacket* pkt, byte* data, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_dup_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dup_packet(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_copy_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_copy_packet(AVPacket* dst, AVPacket* src);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_copy_packet_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_copy_packet_side_data(AVPacket* dst, AVPacket* src);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_free_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_free_packet(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_packet_new_side_data(AVPacket* pkt, AVPacketSideDataType type, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_shrink_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_shrink_side_data(AVPacket* pkt, AVPacketSideDataType type, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_packet_get_side_data(AVPacket* pkt, AVPacketSideDataType type, int* size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_merge_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_merge_side_data(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_split_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_split_side_data(AVPacket* pkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_decoder(AVCodecID id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_decoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_decoder_by_name(String name);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_get_buffer(AVCodecContext* s, AVFrame* pic);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_release_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_default_release_buffer(AVCodecContext* s, AVFrame* pic);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_reget_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_reget_buffer(AVCodecContext* s, AVFrame* pic);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_buffer2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_get_buffer2(AVCodecContext* s, AVFrame* frame, int flags);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_edge_width", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_edge_width();
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_align_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_align_dimensions(AVCodecContext* s, int* width, int* height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_align_dimensions2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_align_dimensions2(AVCodecContext* s, int* width, int* height, int* linesize_align);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_audio3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_audio3(AVCodecContext* avctx, short* samples, int* frame_size_ptr, AVPacket* avpkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_audio4", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_audio4(AVCodecContext* avctx, AVFrame* frame, int* got_frame_ptr, AVPacket* avpkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_video2(AVCodecContext* avctx, AVFrame* picture, int* got_picture_ptr, AVPacket* avpkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_subtitle2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_subtitle2(AVCodecContext* avctx, AVSubtitle* sub, int* got_sub_ptr, AVPacket* avpkt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecParser* av_parser_next(AVCodecParser* c);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_codec_parser", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_codec_parser(AVCodecParser* parser);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecParserContext* av_parser_init(int codec_id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parser_parse2(AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, long pts, long dts, long pos);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_change", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parser_change(AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, int keyframe);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_parser_close(AVCodecParserContext* s);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_encoder(AVCodecID id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_encoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_encoder_by_name(String name);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_audio(AVCodecContext* avctx, byte* buf, int buf_size, short* samples);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_audio2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_audio2(AVCodecContext* avctx, AVPacket* avpkt, AVFrame* frame, int* got_packet_ptr);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_video", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_video(AVCodecContext* avctx, byte* buf, int buf_size, AVFrame* pict);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_video2(AVCodecContext* avctx, AVPacket* avpkt, AVFrame* frame, int* got_packet_ptr);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_subtitle", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_subtitle(AVCodecContext* avctx, byte* buf, int buf_size, AVSubtitle* sub);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_audio_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ReSampleContext* av_audio_resample_init(int output_channels, int input_channels, int output_rate, int input_rate, AVSampleFormat sample_fmt_out, AVSampleFormat sample_fmt_in, int filter_length, int log2_phase_count, int linear, double cutoff);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="audio_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int audio_resample(ReSampleContext* s, short* output, short* input, int nb_samples);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="audio_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void audio_resample_close(ReSampleContext* s);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVResampleContext* av_resample_init(int out_rate, int in_rate, int filter_length, int log2_phase_count, int linear, double cutoff);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_resample(AVResampleContext* c, short* dst, short* src, int* consumed, int src_size, int dst_size, int update_ctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_compensate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_resample_compensate(AVResampleContext* c, int sample_delta, int compensation_distance);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_resample_close(AVResampleContext* c);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_alloc(AVPicture* picture, AVPixelFormat pix_fmt, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avpicture_free(AVPicture* picture);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_fill", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_fill(AVPicture* picture, byte* ptr, AVPixelFormat pix_fmt, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_layout(AVPicture* src, AVPixelFormat pix_fmt, int width, int height, byte* dest, int dest_size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_get_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_get_size(AVPixelFormat pix_fmt, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_deinterlace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_deinterlace(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_picture_copy(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_crop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_picture_crop(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int top_band, int left_band);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_pad", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_picture_pad(AVPicture* dst, AVPicture* src, int height, int width, AVPixelFormat pix_fmt, int padtop, int padbottom, int padleft, int padright, int* color);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_get_chroma_sub_sample(AVPixelFormat pix_fmt, int* h_shift, int* v_shift);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_pix_fmt_to_codec_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_pix_fmt_to_codec_tag(AVPixelFormat pix_fmt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_pix_fmt_loss(AVPixelFormat dst_pix_fmt, AVPixelFormat src_pix_fmt, int has_alpha);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt_of_list", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* pix_fmt_list, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_default_get_format(AVCodecContext* s, AVPixelFormat* fmt);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_set_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_set_dimensions(AVCodecContext* s, int width, int height);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_codec_tag_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern uint av_get_codec_tag_string(String buf, uint buf_size, int codec_tag);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_string(String buf, int buf_size, AVCodecContext* enc, int encode);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_profile_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_profile_name(AVCodec* codec, int profile);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_execute", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_execute(AVCodecContext* c, IntPtr func, void* arg, int* ret, int count, int size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_execute2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_execute2(AVCodecContext* c, IntPtr func, void* arg, int* ret, int count);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_fill_audio_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_fill_audio_frame(AVFrame* frame, int nb_channels, AVSampleFormat sample_fmt, byte* buf, int buf_size, int align);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_flush_buffers", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_flush_buffers(AVCodecContext* avctx);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bits_per_sample(AVCodecID codec_id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_pcm_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_get_pcm_codec(AVSampleFormat fmt, int be);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_exact_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_exact_bits_per_sample(AVCodecID codec_id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_audio_frame_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_audio_frame_duration(AVCodecContext* avctx, int frame_bytes);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_bitstream_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_bitstream_filter(AVBitStreamFilter* bsf);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBitStreamFilterContext* av_bitstream_filter_init(String name);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* bsfc, AVCodecContext* avctx, String args, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, int keyframe);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* bsf);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* f);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_fast_realloc(void* ptr, int* size, uint min_size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_malloc(void* ptr, int* size, uint min_size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_padded_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_padded_malloc(void* ptr, int* size, uint min_size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_padded_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_padded_mallocz(void* ptr, int* size, uint min_size);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_xiphlacing", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_xiphlacing(byte* s, int v);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_log_missing_feature", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_missing_feature(void* avc, String feature, int want_sample);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_log_ask_for_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_ask_for_sample(void* avc, String msg);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_hwaccel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_hwaccel(AVHWAccel* hwaccel);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_hwaccel_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVHWAccel* av_hwaccel_next(AVHWAccel* hwaccel);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_lockmgr_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_lockmgr_register(IntPtr cb);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVMediaType avcodec_get_type(AVCodecID codec_id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_get_name(AVCodecID id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_is_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_is_open(AVCodecContext* s);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_is_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_is_encoder(AVCodec* codec);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_is_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_is_decoder(AVCodec* codec);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID id);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* prev);
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name(String name);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_check", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_check(String url, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVIOContext* avio_alloc_context(byte* buffer, int buffer_size, int write_flag, void* opaque, IntPtr read_packet, IntPtr write_packet, IntPtr seek);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_w8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_w8(AVIOContext* s, int b);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_write(AVIOContext* s, byte* buf, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl64(AVIOContext* s, ulong val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb64(AVIOContext* s, ulong val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl32(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb32(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl24(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb24(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl16(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb16(AVIOContext* s, int val);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_put_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_put_str(AVIOContext* s, String str);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_put_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_put_str16le(AVIOContext* s, String str);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_seek", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_seek(AVIOContext* s, long offset, int whence);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_skip", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_skip(AVIOContext* s, long offset);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_size(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="url_feof", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int url_feof(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_printf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_printf(AVIOContext* s, String fmt);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_flush", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_flush(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_read(AVIOContext* s, byte* buf, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_r8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_r8(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl16(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl24(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl32(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong avio_rl64(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb16(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb24(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb32(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong avio_rb64(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str(AVIOContext* pb, int maxlen, String buf, int buflen);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str16le(AVIOContext* pb, int maxlen, String buf, int buflen);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str16be", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str16be(AVIOContext* pb, int maxlen, String buf, int buflen);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open(AVIOContext** s, String url, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open2(AVIOContext** s, String url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_close(AVIOContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_closep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_closep(AVIOContext** s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open_dyn_buf(AVIOContext** s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_close_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_close_dyn_buf(AVIOContext* s, byte** pbuffer);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_enum_protocols", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avio_enum_protocols(void** opaque, int output);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_pause(AVIOContext* h, int pause);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_seek_time", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_seek_time(AVIOContext* h, int stream_index, long timestamp, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_packet(AVIOContext* s, AVPacket* pkt, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_append_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_append_packet(AVIOContext* s, AVPacket* pkt, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_stream_get_r_frame_rate(AVStream* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_set_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_stream_set_r_frame_rate(AVStream* s, AVRational r);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_fmt_ctx_get_duration_estimation_method", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* ctx);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_version();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avformat_configuration();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avformat_license();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_all();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_input_format(AVInputFormat* format);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_output_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_output_format(AVOutputFormat* format);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_network_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_network_init();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_network_deinit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_network_deinit();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_iformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_iformat_next(AVInputFormat* f);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_oformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_oformat_next(AVOutputFormat* f);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFormatContext* avformat_alloc_context();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avformat_free_context(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avformat_get_class();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_new_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVStream* avformat_new_stream(AVFormatContext* s, AVCodec* c);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_new_program", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVProgram* av_new_program(AVFormatContext* s, int id);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_alloc_output_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFormatContext* avformat_alloc_output_context(String format, AVOutputFormat* oformat, String filename);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_alloc_output_context2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_alloc_output_context2(AVFormatContext** ctx, AVOutputFormat* oformat, String format_name, String filename);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_find_input_format(String short_name);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format(AVProbeData* pd, int is_opened);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format2(AVProbeData* pd, int is_opened, int* score_max);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format3(AVProbeData* pd, int is_opened, int* score_ret);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_probe_input_buffer(AVIOContext* pb, AVInputFormat** fmt, String filename, void* logctx, int offset, int max_probe_size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_open_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_open_input(AVFormatContext** ps, String filename, AVInputFormat* fmt, AVDictionary** options);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_demuxer_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_demuxer_open(AVFormatContext* ic);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_stream_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_stream_info(AVFormatContext* ic);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_find_stream_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_find_stream_info(AVFormatContext* ic, AVDictionary** options);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_program_from_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVProgram* av_find_program_from_stream(AVFormatContext* ic, AVProgram* last, int s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_best_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_best_stream(AVFormatContext* ic, AVMediaType type, int wanted_stream_nb, int related_stream, AVCodec** decoder_ret, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_packet(AVFormatContext* s, AVPacket* pkt);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_frame(AVFormatContext* s, AVPacket* pkt);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_seek_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_seek_frame(AVFormatContext* s, int stream_index, long timestamp, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_seek_file", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_seek_file(AVFormatContext* s, int stream_index, long min_ts, long ts, long max_ts, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_play", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_play(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_pause(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_close_input_file", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_close_input_file(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_close_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avformat_close_input(AVFormatContext** s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_new_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVStream* av_new_stream(AVFormatContext* s, int id);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_set_pts_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_set_pts_info(AVStream* s, int pts_wrap_bits, int pts_num, int pts_den);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_write_header", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_write_header(AVFormatContext* s, AVDictionary** options);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_frame(AVFormatContext* s, AVPacket* pkt);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_interleaved_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_interleaved_write_frame(AVFormatContext* s, AVPacket* pkt);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_trailer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_trailer(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_guess_format(String short_name, String filename, String mime_type);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_guess_codec(AVOutputFormat* fmt, String short_name, String filename, String mime_type, AVMediaType type);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_output_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_output_timestamp(AVFormatContext* s, int stream, long* dts, long* wall);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_hex_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_hex_dump(void* f, byte* buf, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_hex_dump_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_hex_dump_log(void* avcl, int level, byte* buf, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_pkt_dump2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_pkt_dump2(void* f, AVPacket* pkt, int dump_payload, AVStream* st);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_pkt_dump_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_pkt_dump_log2(void* avcl, int level, AVPacket* pkt, int dump_payload, AVStream* st);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_id", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_codec_get_id(AVCodecTag** tags, int tag);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_tag(AVCodecTag** tags, AVCodecID id);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_tag2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_tag2(AVCodecTag** tags, AVCodecID id, int* tag);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_default_stream_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_default_stream_index(AVFormatContext* s);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_index_search_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_index_search_timestamp(AVStream* st, long timestamp, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_add_index_entry", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_add_index_entry(AVStream* st, long pos, long timestamp, int size, int distance, int flags);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_url_split", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_url_split(String proto, int proto_size, String authorization, int authorization_size, String hostname, int hostname_size, int* port_ptr, String path, int path_size, String url);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_dump_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dump_format(AVFormatContext* ic, int index, String url, int is_output);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_frame_filename", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_frame_filename(String buf, int buf_size, String path, int number);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_filename_number_test", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_filename_number_test(String filename);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_sdp_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_sdp_create(AVFormatContext** ac, int n_files, String buf, int size);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_match_ext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_match_ext(String filename, String extensions);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_query_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_query_codec(AVOutputFormat* ofmt, AVCodecID codec_id, int std_compliance);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_riff_video_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_riff_video_tags();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_riff_audio_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_riff_audio_tags();
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_sample_aspect_ratio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* format, AVStream* stream, AVFrame* frame);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_guess_frame_rate(AVFormatContext* ctx, AVStream* stream, AVFrame* frame);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_match_stream_specifier", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_match_stream_specifier(AVFormatContext* s, AVStream* st, String spec);
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_queue_attached_pictures", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_queue_attached_pictures(AVFormatContext* s);
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_version();
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avdevice_configuration();
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avdevice_license();
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avdevice_register_all();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_version();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_configuration();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_license();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_buffer_ref_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_copy_buffer_ref_props(AVFilterBufferRef* dst, AVFilterBufferRef* src);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_ref_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_ref_buffer(AVFilterBufferRef* @ref, int pmask);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_unref_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_unref_buffer(AVFilterBufferRef* @ref);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_unref_bufferp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_unref_bufferp(AVFilterBufferRef** @ref);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_ref_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_ref_get_channels(AVFilterBufferRef* @ref);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_pad_count(AVFilterPad* pads);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_pad_get_name(AVFilterPad* pads, int pad_idx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVMediaType avfilter_pad_get_type(AVFilterPad* pads, int pad_idx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_link(AVFilterContext* src, int srcpad, AVFilterContext* dst, int dstpad);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_link_free(AVFilterLink** link);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_link_get_channels(AVFilterLink* link);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_set_closed", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_link_set_closed(AVFilterLink* link, int closed);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_config_links", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_config_links(AVFilterContext* filter);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_video_buffer_ref_from_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_video_buffer_ref_from_arrays(byte** data, int* linesize, int perms, int w, int h, AVPixelFormat format);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_audio_buffer_ref_from_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_audio_buffer_ref_from_arrays(byte** data, int linesize, int perms, int nb_samples, AVSampleFormat sample_fmt, ulong channel_layout);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_audio_buffer_ref_from_arrays_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_audio_buffer_ref_from_arrays_channels(byte** data, int linesize, int perms, int nb_samples, AVSampleFormat sample_fmt, int channels, ulong channel_layout);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_process_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_process_command(AVFilterContext* filter, String cmd, String arg, String res, int res_len, int flags);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_register_all();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_uninit();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_register(AVFilter* filter);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter* avfilter_get_by_name(String name);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter* avfilter_next(AVFilter* prev);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter** av_filter_next(AVFilter** filter);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_open(AVFilterContext** filter_ctx, AVFilter* filter, String inst_name);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_filter(AVFilterContext* filter, String args, void* opaque);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_str(AVFilterContext* ctx, String args);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_dict", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_dict(AVFilterContext* ctx, AVDictionary** options);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_free(AVFilterContext* filter);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_insert_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_insert_filter(AVFilterLink* link, AVFilterContext* filt, int filt_srcpad_idx, int filt_dstpad_idx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_frame_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_copy_frame_props(AVFilterBufferRef* dst, AVFrame* src);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_buf_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_copy_buf_props(AVFrame* dst, AVFilterBufferRef* src);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avfilter_get_class();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterGraph* avfilter_graph_alloc();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_alloc_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* graph, AVFilter* filter, String name);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_get_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* graph, String name);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_add_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_add_filter(AVFilterGraph* graphctx, AVFilterContext* filter);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_create_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_create_filter(AVFilterContext** filt_ctx, AVFilter* filt, String name, String args, void* opaque, AVFilterGraph* graph_ctx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_set_auto_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* graph, int flags);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_config", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_config(AVFilterGraph* graphctx, void* log_ctx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_graph_free(AVFilterGraph** graph);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_inout_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterInOut* avfilter_inout_alloc();
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_inout_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_inout_free(AVFilterInOut** inout);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse(AVFilterGraph* graph, String filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse_ptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse_ptr(AVFilterGraph* graph, String filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse2(AVFilterGraph* graph, String filters, AVFilterInOut** inputs, AVFilterInOut** outputs);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_send_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_send_command(AVFilterGraph* graph, String target, String cmd, String arg, String res, int res_len, int flags);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_queue_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_queue_command(AVFilterGraph* graph, String target, String cmd, String arg, int flags, double ts);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_graph_dump(AVFilterGraph* graph, String options);
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_request_oldest", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_request_oldest(AVFilterGraph* graph);
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int postproc_version();
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String postproc_configuration();
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String postproc_license();
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_postprocess", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_postprocess(byte** src, int* srcStride, byte** dst, int* dstStride, int horizontalSize, int verticalSize, sbyte* QP_store, int QP_stride, pp_mode* mode, pp_context* ppContext, int pict_type);
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_get_mode_by_name_and_quality", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern pp_mode* pp_get_mode_by_name_and_quality(String name, int quality);
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_free_mode", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_free_mode(pp_mode* mode);
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_get_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern pp_context* pp_get_context(int width, int height, int flags);
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_free_context(pp_context* ppContext);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* swr_get_class();
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwrContext* swr_alloc();
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_init(SwrContext* s);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_alloc_set_opts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwrContext* swr_alloc_set_opts(SwrContext* s, long out_ch_layout, AVSampleFormat out_sample_fmt, int out_sample_rate, long in_ch_layout, AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, void* log_ctx);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void swr_free(SwrContext** s);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_convert(SwrContext* s, byte** @out, int out_count, byte** @in, int in_count);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_next_pts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long swr_next_pts(SwrContext* s, long pts);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_compensation", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_compensation(SwrContext* s, int sample_delta, int compensation_distance);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_channel_mapping", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_channel_mapping(SwrContext* s, int* channel_map);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_matrix(SwrContext* s, double* matrix, int stride);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_drop_output", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_drop_output(SwrContext* s, int count);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_inject_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_inject_silence(SwrContext* s, int count);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_get_delay", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long swr_get_delay(SwrContext* s, long @base);
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swresample_version();
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swresample_configuration();
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swresample_license();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swscale_version();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swscale_configuration();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swscale_license();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getCoefficients", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int* sws_getCoefficients(int colorspace);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedInput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedInput(AVPixelFormat pix_fmt);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedOutput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedOutput(AVPixelFormat pix_fmt);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedEndiannessConversion", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedEndiannessConversion(AVPixelFormat pix_fmt);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_alloc_context();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_init_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_init_context(SwsContext* sws_context, SwsFilter* srcFilter, SwsFilter* dstFilter);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeContext(SwsContext* swsContext);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_getContext(int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_scale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_scale(SwsContext* c, byte** srcSlice, int* srcStride, int srcSliceY, int srcSliceH, byte** dst, int* dstStride);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_setColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_setColorspaceDetails(SwsContext* c, int* inv_table, int srcRange, int* table, int dstRange, int brightness, int contrast, int saturation);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_getColorspaceDetails(SwsContext* c, int** inv_table, int* srcRange, int** table, int* dstRange, int* brightness, int* contrast, int* saturation);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_allocVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_allocVec(int length);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getGaussianVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getGaussianVec(double variance, double quality);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getConstVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getConstVec(double c, int length);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getIdentityVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getIdentityVec();
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_scaleVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_scaleVec(SwsVector* a, double scalar);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_normalizeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_normalizeVec(SwsVector* a, double height);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convVec(SwsVector* a, SwsVector* b);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_addVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_addVec(SwsVector* a, SwsVector* b);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_subVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_subVec(SwsVector* a, SwsVector* b);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_shiftVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_shiftVec(SwsVector* a, int shift);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_cloneVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_cloneVec(SwsVector* a);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_printVec2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_printVec2(SwsVector* a, AVClass* log_ctx, int log_level);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeVec(SwsVector* a);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getDefaultFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsFilter* sws_getDefaultFilter(float lumaGBlur, float chromaGBlur, float lumaSharpen, float chromaSharpen, float chromaHShift, float chromaVShift, int verbose);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeFilter(SwsFilter* filter);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getCachedContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_getCachedContext(SwsContext* context, int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convertPalette8ToPacked32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convertPalette8ToPacked32(byte* src, byte* dst, int num_pixels, byte* palette);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convertPalette8ToPacked24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convertPalette8ToPacked24(byte* src, byte* dst, int num_pixels, byte* palette);
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* sws_get_class();
	}
}
