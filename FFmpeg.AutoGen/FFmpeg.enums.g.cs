using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
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
    
    /// <summary>Identify the syntax and semantics of the bitstream. The principle is roughly: Two decoders with the same ID can decode the same streams. Two encoders with the same ID can encode compatible streams. There may be slight deviations from the principle due to implementation details.</summary>
    public enum AVCodecID : int
    {
        @AV_CODEC_ID_NONE = 0,
        @AV_CODEC_ID_MPEG1VIDEO = 1,
        /// <summary>preferred ID for MPEG-1/2 video decoding</summary>
        @AV_CODEC_ID_MPEG2VIDEO = 2,
        @AV_CODEC_ID_H261 = 3,
        @AV_CODEC_ID_H263 = 4,
        @AV_CODEC_ID_RV10 = 5,
        @AV_CODEC_ID_RV20 = 6,
        @AV_CODEC_ID_MJPEG = 7,
        @AV_CODEC_ID_MJPEGB = 8,
        @AV_CODEC_ID_LJPEG = 9,
        @AV_CODEC_ID_SP5X = 10,
        @AV_CODEC_ID_JPEGLS = 11,
        @AV_CODEC_ID_MPEG4 = 12,
        @AV_CODEC_ID_RAWVIDEO = 13,
        @AV_CODEC_ID_MSMPEG4V1 = 14,
        @AV_CODEC_ID_MSMPEG4V2 = 15,
        @AV_CODEC_ID_MSMPEG4V3 = 16,
        @AV_CODEC_ID_WMV1 = 17,
        @AV_CODEC_ID_WMV2 = 18,
        @AV_CODEC_ID_H263P = 19,
        @AV_CODEC_ID_H263I = 20,
        @AV_CODEC_ID_FLV1 = 21,
        @AV_CODEC_ID_SVQ1 = 22,
        @AV_CODEC_ID_SVQ3 = 23,
        @AV_CODEC_ID_DVVIDEO = 24,
        @AV_CODEC_ID_HUFFYUV = 25,
        @AV_CODEC_ID_CYUV = 26,
        @AV_CODEC_ID_H264 = 27,
        @AV_CODEC_ID_INDEO3 = 28,
        @AV_CODEC_ID_VP3 = 29,
        @AV_CODEC_ID_THEORA = 30,
        @AV_CODEC_ID_ASV1 = 31,
        @AV_CODEC_ID_ASV2 = 32,
        @AV_CODEC_ID_FFV1 = 33,
        @AV_CODEC_ID_4XM = 34,
        @AV_CODEC_ID_VCR1 = 35,
        @AV_CODEC_ID_CLJR = 36,
        @AV_CODEC_ID_MDEC = 37,
        @AV_CODEC_ID_ROQ = 38,
        @AV_CODEC_ID_INTERPLAY_VIDEO = 39,
        @AV_CODEC_ID_XAN_WC3 = 40,
        @AV_CODEC_ID_XAN_WC4 = 41,
        @AV_CODEC_ID_RPZA = 42,
        @AV_CODEC_ID_CINEPAK = 43,
        @AV_CODEC_ID_WS_VQA = 44,
        @AV_CODEC_ID_MSRLE = 45,
        @AV_CODEC_ID_MSVIDEO1 = 46,
        @AV_CODEC_ID_IDCIN = 47,
        @AV_CODEC_ID_8BPS = 48,
        @AV_CODEC_ID_SMC = 49,
        @AV_CODEC_ID_FLIC = 50,
        @AV_CODEC_ID_TRUEMOTION1 = 51,
        @AV_CODEC_ID_VMDVIDEO = 52,
        @AV_CODEC_ID_MSZH = 53,
        @AV_CODEC_ID_ZLIB = 54,
        @AV_CODEC_ID_QTRLE = 55,
        @AV_CODEC_ID_TSCC = 56,
        @AV_CODEC_ID_ULTI = 57,
        @AV_CODEC_ID_QDRAW = 58,
        @AV_CODEC_ID_VIXL = 59,
        @AV_CODEC_ID_QPEG = 60,
        @AV_CODEC_ID_PNG = 61,
        @AV_CODEC_ID_PPM = 62,
        @AV_CODEC_ID_PBM = 63,
        @AV_CODEC_ID_PGM = 64,
        @AV_CODEC_ID_PGMYUV = 65,
        @AV_CODEC_ID_PAM = 66,
        @AV_CODEC_ID_FFVHUFF = 67,
        @AV_CODEC_ID_RV30 = 68,
        @AV_CODEC_ID_RV40 = 69,
        @AV_CODEC_ID_VC1 = 70,
        @AV_CODEC_ID_WMV3 = 71,
        @AV_CODEC_ID_LOCO = 72,
        @AV_CODEC_ID_WNV1 = 73,
        @AV_CODEC_ID_AASC = 74,
        @AV_CODEC_ID_INDEO2 = 75,
        @AV_CODEC_ID_FRAPS = 76,
        @AV_CODEC_ID_TRUEMOTION2 = 77,
        @AV_CODEC_ID_BMP = 78,
        @AV_CODEC_ID_CSCD = 79,
        @AV_CODEC_ID_MMVIDEO = 80,
        @AV_CODEC_ID_ZMBV = 81,
        @AV_CODEC_ID_AVS = 82,
        @AV_CODEC_ID_SMACKVIDEO = 83,
        @AV_CODEC_ID_NUV = 84,
        @AV_CODEC_ID_KMVC = 85,
        @AV_CODEC_ID_FLASHSV = 86,
        @AV_CODEC_ID_CAVS = 87,
        @AV_CODEC_ID_JPEG2000 = 88,
        @AV_CODEC_ID_VMNC = 89,
        @AV_CODEC_ID_VP5 = 90,
        @AV_CODEC_ID_VP6 = 91,
        @AV_CODEC_ID_VP6F = 92,
        @AV_CODEC_ID_TARGA = 93,
        @AV_CODEC_ID_DSICINVIDEO = 94,
        @AV_CODEC_ID_TIERTEXSEQVIDEO = 95,
        @AV_CODEC_ID_TIFF = 96,
        @AV_CODEC_ID_GIF = 97,
        @AV_CODEC_ID_DXA = 98,
        @AV_CODEC_ID_DNXHD = 99,
        @AV_CODEC_ID_THP = 100,
        @AV_CODEC_ID_SGI = 101,
        @AV_CODEC_ID_C93 = 102,
        @AV_CODEC_ID_BETHSOFTVID = 103,
        @AV_CODEC_ID_PTX = 104,
        @AV_CODEC_ID_TXD = 105,
        @AV_CODEC_ID_VP6A = 106,
        @AV_CODEC_ID_AMV = 107,
        @AV_CODEC_ID_VB = 108,
        @AV_CODEC_ID_PCX = 109,
        @AV_CODEC_ID_SUNRAST = 110,
        @AV_CODEC_ID_INDEO4 = 111,
        @AV_CODEC_ID_INDEO5 = 112,
        @AV_CODEC_ID_MIMIC = 113,
        @AV_CODEC_ID_RL2 = 114,
        @AV_CODEC_ID_ESCAPE124 = 115,
        @AV_CODEC_ID_DIRAC = 116,
        @AV_CODEC_ID_BFI = 117,
        @AV_CODEC_ID_CMV = 118,
        @AV_CODEC_ID_MOTIONPIXELS = 119,
        @AV_CODEC_ID_TGV = 120,
        @AV_CODEC_ID_TGQ = 121,
        @AV_CODEC_ID_TQI = 122,
        @AV_CODEC_ID_AURA = 123,
        @AV_CODEC_ID_AURA2 = 124,
        @AV_CODEC_ID_V210X = 125,
        @AV_CODEC_ID_TMV = 126,
        @AV_CODEC_ID_V210 = 127,
        @AV_CODEC_ID_DPX = 128,
        @AV_CODEC_ID_MAD = 129,
        @AV_CODEC_ID_FRWU = 130,
        @AV_CODEC_ID_FLASHSV2 = 131,
        @AV_CODEC_ID_CDGRAPHICS = 132,
        @AV_CODEC_ID_R210 = 133,
        @AV_CODEC_ID_ANM = 134,
        @AV_CODEC_ID_BINKVIDEO = 135,
        @AV_CODEC_ID_IFF_ILBM = 136,
        @AV_CODEC_ID_KGV1 = 137,
        @AV_CODEC_ID_YOP = 138,
        @AV_CODEC_ID_VP8 = 139,
        @AV_CODEC_ID_PICTOR = 140,
        @AV_CODEC_ID_ANSI = 141,
        @AV_CODEC_ID_A64_MULTI = 142,
        @AV_CODEC_ID_A64_MULTI5 = 143,
        @AV_CODEC_ID_R10K = 144,
        @AV_CODEC_ID_MXPEG = 145,
        @AV_CODEC_ID_LAGARITH = 146,
        @AV_CODEC_ID_PRORES = 147,
        @AV_CODEC_ID_JV = 148,
        @AV_CODEC_ID_DFA = 149,
        @AV_CODEC_ID_WMV3IMAGE = 150,
        @AV_CODEC_ID_VC1IMAGE = 151,
        @AV_CODEC_ID_UTVIDEO = 152,
        @AV_CODEC_ID_BMV_VIDEO = 153,
        @AV_CODEC_ID_VBLE = 154,
        @AV_CODEC_ID_DXTORY = 155,
        @AV_CODEC_ID_V410 = 156,
        @AV_CODEC_ID_XWD = 157,
        @AV_CODEC_ID_CDXL = 158,
        @AV_CODEC_ID_XBM = 159,
        @AV_CODEC_ID_ZEROCODEC = 160,
        @AV_CODEC_ID_MSS1 = 161,
        @AV_CODEC_ID_MSA1 = 162,
        @AV_CODEC_ID_TSCC2 = 163,
        @AV_CODEC_ID_MTS2 = 164,
        @AV_CODEC_ID_CLLC = 165,
        @AV_CODEC_ID_MSS2 = 166,
        @AV_CODEC_ID_VP9 = 167,
        @AV_CODEC_ID_AIC = 168,
        @AV_CODEC_ID_ESCAPE130 = 169,
        @AV_CODEC_ID_G2M = 170,
        @AV_CODEC_ID_WEBP = 171,
        @AV_CODEC_ID_HNM4_VIDEO = 172,
        @AV_CODEC_ID_HEVC = 173,
        @AV_CODEC_ID_FIC = 174,
        @AV_CODEC_ID_ALIAS_PIX = 175,
        @AV_CODEC_ID_BRENDER_PIX = 176,
        @AV_CODEC_ID_PAF_VIDEO = 177,
        @AV_CODEC_ID_EXR = 178,
        @AV_CODEC_ID_VP7 = 179,
        @AV_CODEC_ID_SANM = 180,
        @AV_CODEC_ID_SGIRLE = 181,
        @AV_CODEC_ID_MVC1 = 182,
        @AV_CODEC_ID_MVC2 = 183,
        @AV_CODEC_ID_HQX = 184,
        @AV_CODEC_ID_TDSC = 185,
        @AV_CODEC_ID_HQ_HQA = 186,
        @AV_CODEC_ID_HAP = 187,
        @AV_CODEC_ID_DDS = 188,
        @AV_CODEC_ID_DXV = 189,
        @AV_CODEC_ID_SCREENPRESSO = 190,
        @AV_CODEC_ID_RSCC = 191,
        @AV_CODEC_ID_AVS2 = 192,
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
        @AV_CODEC_ID_PSD = 32790,
        @AV_CODEC_ID_PIXLET = 32791,
        @AV_CODEC_ID_SPEEDHQ = 32792,
        @AV_CODEC_ID_FMVC = 32793,
        @AV_CODEC_ID_SCPR = 32794,
        @AV_CODEC_ID_CLEARVIDEO = 32795,
        @AV_CODEC_ID_XPM = 32796,
        @AV_CODEC_ID_AV1 = 32797,
        @AV_CODEC_ID_BITPACKED = 32798,
        @AV_CODEC_ID_MSCC = 32799,
        @AV_CODEC_ID_SRGC = 32800,
        @AV_CODEC_ID_SVG = 32801,
        @AV_CODEC_ID_GDV = 32802,
        @AV_CODEC_ID_FITS = 32803,
        @AV_CODEC_ID_IMM4 = 32804,
        @AV_CODEC_ID_PROSUMER = 32805,
        @AV_CODEC_ID_MWSC = 32806,
        @AV_CODEC_ID_WCMV = 32807,
        @AV_CODEC_ID_RASC = 32808,
        @AV_CODEC_ID_HYMT = 32809,
        @AV_CODEC_ID_ARBC = 32810,
        @AV_CODEC_ID_AGM = 32811,
        @AV_CODEC_ID_LSCR = 32812,
        @AV_CODEC_ID_VP4 = 32813,
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
        @AV_CODEC_ID_PCM_F16LE = 67586,
        @AV_CODEC_ID_PCM_F24LE = 67587,
        @AV_CODEC_ID_PCM_VIDC = 67588,
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
        @AV_CODEC_ID_ADPCM_AGM = 71690,
        @AV_CODEC_ID_AMR_NB = 73728,
        @AV_CODEC_ID_AMR_WB = 73729,
        @AV_CODEC_ID_RA_144 = 77824,
        @AV_CODEC_ID_RA_288 = 77825,
        @AV_CODEC_ID_ROQ_DPCM = 81920,
        @AV_CODEC_ID_INTERPLAY_DPCM = 81921,
        @AV_CODEC_ID_XAN_DPCM = 81922,
        @AV_CODEC_ID_SOL_DPCM = 81923,
        @AV_CODEC_ID_SDX2_DPCM = 83968,
        @AV_CODEC_ID_GREMLIN_DPCM = 83969,
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
        @AV_CODEC_ID_APE = 86048,
        @AV_CODEC_ID_NELLYMOSER = 86049,
        @AV_CODEC_ID_MUSEPACK8 = 86050,
        @AV_CODEC_ID_SPEEX = 86051,
        @AV_CODEC_ID_WMAVOICE = 86052,
        @AV_CODEC_ID_WMAPRO = 86053,
        @AV_CODEC_ID_WMALOSSLESS = 86054,
        @AV_CODEC_ID_ATRAC3P = 86055,
        @AV_CODEC_ID_EAC3 = 86056,
        @AV_CODEC_ID_SIPR = 86057,
        @AV_CODEC_ID_MP1 = 86058,
        @AV_CODEC_ID_TWINVQ = 86059,
        @AV_CODEC_ID_TRUEHD = 86060,
        @AV_CODEC_ID_MP4ALS = 86061,
        @AV_CODEC_ID_ATRAC1 = 86062,
        @AV_CODEC_ID_BINKAUDIO_RDFT = 86063,
        @AV_CODEC_ID_BINKAUDIO_DCT = 86064,
        @AV_CODEC_ID_AAC_LATM = 86065,
        @AV_CODEC_ID_QDMC = 86066,
        @AV_CODEC_ID_CELT = 86067,
        @AV_CODEC_ID_G723_1 = 86068,
        @AV_CODEC_ID_G729 = 86069,
        @AV_CODEC_ID_8SVX_EXP = 86070,
        @AV_CODEC_ID_8SVX_FIB = 86071,
        @AV_CODEC_ID_BMV_AUDIO = 86072,
        @AV_CODEC_ID_RALF = 86073,
        @AV_CODEC_ID_IAC = 86074,
        @AV_CODEC_ID_ILBC = 86075,
        @AV_CODEC_ID_OPUS = 86076,
        @AV_CODEC_ID_COMFORT_NOISE = 86077,
        @AV_CODEC_ID_TAK = 86078,
        @AV_CODEC_ID_METASOUND = 86079,
        @AV_CODEC_ID_PAF_AUDIO = 86080,
        @AV_CODEC_ID_ON2AVC = 86081,
        @AV_CODEC_ID_DSS_SP = 86082,
        @AV_CODEC_ID_CODEC2 = 86083,
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
        @AV_CODEC_ID_ATRAC3AL = 88078,
        @AV_CODEC_ID_ATRAC3PAL = 88079,
        @AV_CODEC_ID_DOLBY_E = 88080,
        @AV_CODEC_ID_APTX = 88081,
        @AV_CODEC_ID_APTX_HD = 88082,
        @AV_CODEC_ID_SBC = 88083,
        @AV_CODEC_ID_ATRAC9 = 88084,
        @AV_CODEC_ID_HCOM = 88085,
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
        @AV_CODEC_ID_TTML = 96271,
        @AV_CODEC_ID_ARIB_CAPTION = 96272,
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
    
    /// <summary>Chromaticity coordinates of the source primaries. These values match the ones defined by ISO/IEC 23001-8_2013 § 7.1.</summary>
    public enum AVColorPrimaries : int
    {
        @AVCOL_PRI_RESERVED0 = 0,
        /// <summary>also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP177 Annex B</summary>
        @AVCOL_PRI_BT709 = 1,
        @AVCOL_PRI_UNSPECIFIED = 2,
        @AVCOL_PRI_RESERVED = 3,
        /// <summary>also FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
        @AVCOL_PRI_BT470M = 4,
        /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM</summary>
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
        @AVCOL_PRI_SMPTE428 = 10,
        @AVCOL_PRI_SMPTEST428_1 = 10,
        /// <summary>SMPTE ST 431-2 (2011) / DCI P3</summary>
        @AVCOL_PRI_SMPTE431 = 11,
        /// <summary>SMPTE ST 432-1 (2010) / P3 D65 / Display P3</summary>
        @AVCOL_PRI_SMPTE432 = 12,
        /// <summary>JEDEC P22 phosphors</summary>
        @AVCOL_PRI_JEDEC_P22 = 22,
        /// <summary>Not part of ABI</summary>
        @AVCOL_PRI_NB = 23,
    }
    
    /// <summary>MPEG vs JPEG YUV range.</summary>
    public enum AVColorRange : int
    {
        @AVCOL_RANGE_UNSPECIFIED = 0,
        /// <summary>the normal 219*2^(n-8) &quot;MPEG&quot; YUV ranges</summary>
        @AVCOL_RANGE_MPEG = 1,
        /// <summary>the normal 2^n-1 &quot;JPEG&quot; YUV ranges</summary>
        @AVCOL_RANGE_JPEG = 2,
        /// <summary>Not part of ABI</summary>
        @AVCOL_RANGE_NB = 3,
    }
    
    /// <summary>YUV colorspace type. These values match the ones defined by ISO/IEC 23001-8_2013 § 7.3.</summary>
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
        /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM / IEC 61966-2-4 xvYCC601</summary>
        @AVCOL_SPC_BT470BG = 5,
        /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
        @AVCOL_SPC_SMPTE170M = 6,
        /// <summary>functionally identical to above</summary>
        @AVCOL_SPC_SMPTE240M = 7,
        /// <summary>Used by Dirac / VC-2 and H.264 FRext, see ITU-T SG16</summary>
        @AVCOL_SPC_YCGCO = 8,
        @AVCOL_SPC_YCOCG = 8,
        /// <summary>ITU-R BT2020 non-constant luminance system</summary>
        @AVCOL_SPC_BT2020_NCL = 9,
        /// <summary>ITU-R BT2020 constant luminance system</summary>
        @AVCOL_SPC_BT2020_CL = 10,
        /// <summary>SMPTE 2085, Y&apos;D&apos;zD&apos;x</summary>
        @AVCOL_SPC_SMPTE2085 = 11,
        /// <summary>Chromaticity-derived non-constant luminance system</summary>
        @AVCOL_SPC_CHROMA_DERIVED_NCL = 12,
        /// <summary>Chromaticity-derived constant luminance system</summary>
        @AVCOL_SPC_CHROMA_DERIVED_CL = 13,
        /// <summary>ITU-R BT.2100-0, ICtCp</summary>
        @AVCOL_SPC_ICTCP = 14,
        /// <summary>Not part of ABI</summary>
        @AVCOL_SPC_NB = 15,
    }
    
    /// <summary>Color Transfer Characteristic. These values match the ones defined by ISO/IEC 23001-8_2013 § 7.2.</summary>
    public enum AVColorTransferCharacteristic : int
    {
        @AVCOL_TRC_RESERVED0 = 0,
        /// <summary>also ITU-R BT1361</summary>
        @AVCOL_TRC_BT709 = 1,
        @AVCOL_TRC_UNSPECIFIED = 2,
        @AVCOL_TRC_RESERVED = 3,
        /// <summary>also ITU-R BT470M / ITU-R BT1700 625 PAL &amp; SECAM</summary>
        @AVCOL_TRC_GAMMA22 = 4,
        /// <summary>also ITU-R BT470BG</summary>
        @AVCOL_TRC_GAMMA28 = 5,
        /// <summary>also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC</summary>
        @AVCOL_TRC_SMPTE170M = 6,
        @AVCOL_TRC_SMPTE240M = 7,
        /// <summary>&quot;Linear transfer characteristics&quot;</summary>
        @AVCOL_TRC_LINEAR = 8,
        /// <summary>&quot;Logarithmic transfer characteristic (100:1 range)&quot;</summary>
        @AVCOL_TRC_LOG = 9,
        /// <summary>&quot;Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)&quot;</summary>
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
        @AVCOL_TRC_SMPTE2084 = 16,
        @AVCOL_TRC_SMPTEST2084 = 16,
        /// <summary>SMPTE ST 428-1</summary>
        @AVCOL_TRC_SMPTE428 = 17,
        @AVCOL_TRC_SMPTEST428_1 = 17,
        /// <summary>ARIB STD-B67, known as &quot;Hybrid log-gamma&quot;</summary>
        @AVCOL_TRC_ARIB_STD_B67 = 18,
        /// <summary>Not part of ABI</summary>
        @AVCOL_TRC_NB = 19,
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
    
    public enum AVFieldOrder : int
    {
        @AV_FIELD_UNKNOWN = 0,
        @AV_FIELD_PROGRESSIVE = 1,
        @AV_FIELD_TT = 2,
        @AV_FIELD_BB = 3,
        @AV_FIELD_TB = 4,
        @AV_FIELD_BT = 5,
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
        /// <summary>Recommmends skipping the specified number of samples. This is exported only if the &quot;skip_manual&quot; AVOption is set in libavcodec. This has the same format as AV_PKT_DATA_SKIP_SAMPLES.</summary>
        @AV_FRAME_DATA_SKIP_SAMPLES = 9,
        /// <summary>This side data must be associated with an audio frame and corresponds to enum AVAudioServiceType defined in avcodec.h.</summary>
        @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
        /// <summary>Mastering display metadata associated with a video frame. The payload is an AVMasteringDisplayMetadata type and contains information about the mastering display color volume.</summary>
        @AV_FRAME_DATA_MASTERING_DISPLAY_METADATA = 11,
        /// <summary>The GOP timecode in 25 bit timecode format. Data format is 64-bit integer. This is set on the first frame of a GOP that has a temporal reference of 0.</summary>
        @AV_FRAME_DATA_GOP_TIMECODE = 12,
        /// <summary>The data represents the AVSphericalMapping structure defined in libavutil/spherical.h.</summary>
        @AV_FRAME_DATA_SPHERICAL = 13,
        /// <summary>Content light level (based on CTA-861.3). This payload contains data in the form of the AVContentLightMetadata struct.</summary>
        @AV_FRAME_DATA_CONTENT_LIGHT_LEVEL = 14,
        /// <summary>The data contains an ICC profile as an opaque octet buffer following the format described by ISO 15076-1 with an optional name defined in the metadata key entry &quot;name&quot;.</summary>
        @AV_FRAME_DATA_ICC_PROFILE = 15,
        /// <summary>Implementation-specific description of the format of AV_FRAME_QP_TABLE_DATA. The contents of this side data are undocumented and internal; use av_frame_set_qp_table() and av_frame_get_qp_table() to access this in a meaningful way instead.</summary>
        @AV_FRAME_DATA_QP_TABLE_PROPERTIES = 16,
        /// <summary>Raw QP table data. Its format is described by AV_FRAME_DATA_QP_TABLE_PROPERTIES. Use av_frame_set_qp_table() and av_frame_get_qp_table() to access this instead.</summary>
        @AV_FRAME_DATA_QP_TABLE_DATA = 17,
        /// <summary>Timecode which conforms to SMPTE ST 12-1. The data is an array of 4 uint32_t where the first uint32_t describes how many (1-3) of the other timecodes are used. The timecode format is described in the av_timecode_get_smpte_from_framenum() function in libavutil/timecode.c.</summary>
        @AV_FRAME_DATA_S12M_TIMECODE = 18,
        /// <summary>HDR dynamic metadata associated with a video frame. The payload is an AVDynamicHDRPlus type and contains information for color volume transform - application 4 of SMPTE 2094-40:2016 standard.</summary>
        @AV_FRAME_DATA_DYNAMIC_HDR_PLUS = 19,
        /// <summary>Regions Of Interest, the data is an array of AVRegionOfInterest type, the number of array element is implied by AVFrameSideData.size / AVRegionOfInterest.self_size.</summary>
        @AV_FRAME_DATA_REGIONS_OF_INTEREST = 20,
    }
    
    public enum AVHWDeviceType : int
    {
        @AV_HWDEVICE_TYPE_NONE = 0,
        @AV_HWDEVICE_TYPE_VDPAU = 1,
        @AV_HWDEVICE_TYPE_CUDA = 2,
        @AV_HWDEVICE_TYPE_VAAPI = 3,
        @AV_HWDEVICE_TYPE_DXVA2 = 4,
        @AV_HWDEVICE_TYPE_QSV = 5,
        @AV_HWDEVICE_TYPE_VIDEOTOOLBOX = 6,
        @AV_HWDEVICE_TYPE_D3D11VA = 7,
        @AV_HWDEVICE_TYPE_DRM = 8,
        @AV_HWDEVICE_TYPE_OPENCL = 9,
        @AV_HWDEVICE_TYPE_MEDIACODEC = 10,
    }
    
    public enum AVHWFrameTransferDirection : int
    {
        /// <summary>Transfer the data from the queried hw frame.</summary>
        @AV_HWFRAME_TRANSFER_DIRECTION_FROM = 0,
        /// <summary>Transfer the data to the queried hw frame.</summary>
        @AV_HWFRAME_TRANSFER_DIRECTION_TO = 1,
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
        /// <summary>A point in the output bytestream where the underlying AVIOContext might flush the buffer depending on latency or buffering requirements. Typically means the end of a packet.</summary>
        @AVIO_DATA_MARKER_FLUSH_POINT = 5,
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
    
    /// <summary>@{ AVOptions provide a generic system to declare options on arbitrary structs (&quot;objects&quot;). An option can have a help text, a type and a range of possible values. Options may then be enumerated, read and written to.</summary>
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
        @AV_OPT_TYPE_UINT64 = 9,
        @AV_OPT_TYPE_CONST = 10,
        /// <summary>offset must point to two consecutive integers</summary>
        @AV_OPT_TYPE_IMAGE_SIZE = 11,
        @AV_OPT_TYPE_PIXEL_FMT = 12,
        @AV_OPT_TYPE_SAMPLE_FMT = 13,
        /// <summary>offset must point to AVRational</summary>
        @AV_OPT_TYPE_VIDEO_RATE = 14,
        @AV_OPT_TYPE_DURATION = 15,
        @AV_OPT_TYPE_COLOR = 16,
        @AV_OPT_TYPE_CHANNEL_LAYOUT = 17,
        @AV_OPT_TYPE_BOOL = 18,
    }
    
    /// <summary>Types and functions for working with AVPacket. @{</summary>
    public enum AVPacketSideDataType : int
    {
        /// <summary>An AV_PKT_DATA_PALETTE side data packet contains exactly AVPALETTE_SIZE bytes worth of palette. This side data signals that a new palette is present.</summary>
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
        /// <summary>This side data contains an integer value representing the stream index of a &quot;fallback&quot; track. A fallback track indicates an alternate track to use when the current track can not be decoded for some reason. e.g. no decoder available for codec.</summary>
        @AV_PKT_DATA_FALLBACK_TRACK = 9,
        /// <summary>This side data corresponds to the AVCPBProperties struct.</summary>
        @AV_PKT_DATA_CPB_PROPERTIES = 10,
        /// <summary>Recommmends skipping the specified number of samples</summary>
        @AV_PKT_DATA_SKIP_SAMPLES = 11,
        /// <summary>An AV_PKT_DATA_JP_DUALMONO side data packet indicates that the packet may contain &quot;dual mono&quot; audio specific to Japanese DTV and if it is true, recommends only the selected channel to be used.</summary>
        @AV_PKT_DATA_JP_DUALMONO = 12,
        /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop.</summary>
        @AV_PKT_DATA_STRINGS_METADATA = 13,
        /// <summary>Subtitle event position</summary>
        @AV_PKT_DATA_SUBTITLE_POSITION = 14,
        /// <summary>Data found in BlockAdditional element of matroska container. There is no end marker for the data, so it is required to rely on the side data size to recognize the end. 8 byte id (as found in BlockAddId) followed by data.</summary>
        @AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL = 15,
        /// <summary>The optional first identifier line of a WebVTT cue.</summary>
        @AV_PKT_DATA_WEBVTT_IDENTIFIER = 16,
        /// <summary>The optional settings (rendering instructions) that immediately follow the timestamp specifier of a WebVTT cue.</summary>
        @AV_PKT_DATA_WEBVTT_SETTINGS = 17,
        /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop. This side data includes updated metadata which appeared in the stream.</summary>
        @AV_PKT_DATA_METADATA_UPDATE = 18,
        /// <summary>MPEGTS stream ID as uint8_t, this is required to pass the stream ID information from the demuxer to the corresponding muxer.</summary>
        @AV_PKT_DATA_MPEGTS_STREAM_ID = 19,
        /// <summary>Mastering display metadata (based on SMPTE-2086:2014). This metadata should be associated with a video stream and contains data in the form of the AVMasteringDisplayMetadata struct.</summary>
        @AV_PKT_DATA_MASTERING_DISPLAY_METADATA = 20,
        /// <summary>This side data should be associated with a video stream and corresponds to the AVSphericalMapping structure.</summary>
        @AV_PKT_DATA_SPHERICAL = 21,
        /// <summary>Content light level (based on CTA-861.3). This metadata should be associated with a video stream and contains data in the form of the AVContentLightMetadata struct.</summary>
        @AV_PKT_DATA_CONTENT_LIGHT_LEVEL = 22,
        /// <summary>ATSC A53 Part 4 Closed Captions. This metadata should be associated with a video stream. A53 CC bitstream is stored as uint8_t in AVPacketSideData.data. The number of bytes of CC data is AVPacketSideData.size.</summary>
        @AV_PKT_DATA_A53_CC = 23,
        /// <summary>This side data is encryption initialization data. The format is not part of ABI, use av_encryption_init_info_* methods to access.</summary>
        @AV_PKT_DATA_ENCRYPTION_INIT_INFO = 24,
        /// <summary>This side data contains encryption info for how to decrypt the packet. The format is not part of ABI, use av_encryption_info_* methods to access.</summary>
        @AV_PKT_DATA_ENCRYPTION_INFO = 25,
        /// <summary>Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum.</summary>
        @AV_PKT_DATA_AFD = 26,
        /// <summary>The number of side data types. This is not part of the public API/ABI in the sense that it may change when new side data types are added. This must stay the last enum value. If its value becomes huge, some code using it needs to be updated as it assumes it to be smaller than other limits.</summary>
        @AV_PKT_DATA_NB = 27,
    }
    
    /// <summary>@{</summary>
    public enum AVPictureStructure : int
    {
        @AV_PICTURE_STRUCTURE_UNKNOWN = 0,
        @AV_PICTURE_STRUCTURE_TOP_FIELD = 1,
        @AV_PICTURE_STRUCTURE_BOTTOM_FIELD = 2,
        @AV_PICTURE_STRUCTURE_FRAME = 3,
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
    
    /// <summary>Pixel format.</summary>
    public enum AVPixelFormat : int
    {
        @AV_PIX_FMT_NONE = -1,
        /// <summary>planar YUV 4:2:0, 12bpp, (1 Cr &amp; Cb sample per 2x2 Y samples)</summary>
        @AV_PIX_FMT_YUV420P = 0,
        /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr</summary>
        @AV_PIX_FMT_YUYV422 = 1,
        /// <summary>packed RGB 8:8:8, 24bpp, RGBRGB...</summary>
        @AV_PIX_FMT_RGB24 = 2,
        /// <summary>packed RGB 8:8:8, 24bpp, BGRBGR...</summary>
        @AV_PIX_FMT_BGR24 = 3,
        /// <summary>planar YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples)</summary>
        @AV_PIX_FMT_YUV422P = 4,
        /// <summary>planar YUV 4:4:4, 24bpp, (1 Cr &amp; Cb sample per 1x1 Y samples)</summary>
        @AV_PIX_FMT_YUV444P = 5,
        /// <summary>planar YUV 4:1:0, 9bpp, (1 Cr &amp; Cb sample per 4x4 Y samples)</summary>
        @AV_PIX_FMT_YUV410P = 6,
        /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples)</summary>
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
        /// <summary>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1</summary>
        @AV_PIX_FMT_UYVY422 = 15,
        /// <summary>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3</summary>
        @AV_PIX_FMT_UYYVYY411 = 16,
        /// <summary>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb)</summary>
        @AV_PIX_FMT_BGR8 = 17,
        /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
        @AV_PIX_FMT_BGR4 = 18,
        /// <summary>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb)</summary>
        @AV_PIX_FMT_BGR4_BYTE = 19,
        /// <summary>packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb)</summary>
        @AV_PIX_FMT_RGB8 = 20,
        /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
        @AV_PIX_FMT_RGB4 = 21,
        /// <summary>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb)</summary>
        @AV_PIX_FMT_RGB4_BYTE = 22,
        /// <summary>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
        @AV_PIX_FMT_NV12 = 23,
        /// <summary>as above, but U and V bytes are swapped</summary>
        @AV_PIX_FMT_NV21 = 24,
        /// <summary>packed ARGB 8:8:8:8, 32bpp, ARGBARGB...</summary>
        @AV_PIX_FMT_ARGB = 25,
        /// <summary>packed RGBA 8:8:8:8, 32bpp, RGBARGBA...</summary>
        @AV_PIX_FMT_RGBA = 26,
        /// <summary>packed ABGR 8:8:8:8, 32bpp, ABGRABGR...</summary>
        @AV_PIX_FMT_ABGR = 27,
        /// <summary>packed BGRA 8:8:8:8, 32bpp, BGRABGRA...</summary>
        @AV_PIX_FMT_BGRA = 28,
        /// <summary>Y , 16bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY16BE = 29,
        /// <summary>Y , 16bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY16LE = 30,
        /// <summary>planar YUV 4:4:0 (1 Cr &amp; Cb sample per 1x2 Y samples)</summary>
        @AV_PIX_FMT_YUV440P = 31,
        /// <summary>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ440P = 32,
        /// <summary>planar YUV 4:2:0, 20bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples)</summary>
        @AV_PIX_FMT_YUVA420P = 33,
        /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian</summary>
        @AV_PIX_FMT_RGB48BE = 34,
        /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian</summary>
        @AV_PIX_FMT_RGB48LE = 35,
        /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian</summary>
        @AV_PIX_FMT_RGB565BE = 36,
        /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian</summary>
        @AV_PIX_FMT_RGB565LE = 37,
        /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined</summary>
        @AV_PIX_FMT_RGB555BE = 38,
        /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB555LE = 39,
        /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian</summary>
        @AV_PIX_FMT_BGR565BE = 40,
        /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian</summary>
        @AV_PIX_FMT_BGR565LE = 41,
        /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined</summary>
        @AV_PIX_FMT_BGR555BE = 42,
        /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR555LE = 43,
        /// <summary>HW acceleration through VA API at motion compensation entry-point, Picture.data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers</summary>
        @AV_PIX_FMT_VAAPI_MOCO = 44,
        /// <summary>HW acceleration through VA API at IDCT entry-point, Picture.data[3] contains a vaapi_render_state struct which contains fields extracted from headers</summary>
        @AV_PIX_FMT_VAAPI_IDCT = 45,
        /// <summary>HW decoding through VA API, Picture.data[3] contains a VASurfaceID</summary>
        @AV_PIX_FMT_VAAPI_VLD = 46,
        /// <summary>@}</summary>
        @AV_PIX_FMT_VAAPI = 46,
        /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P16LE = 47,
        /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P16BE = 48,
        /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P16LE = 49,
        /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P16BE = 50,
        /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P16LE = 51,
        /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P16BE = 52,
        /// <summary>HW decoding through DXVA2, Picture.data[3] contains a LPDIRECT3DSURFACE9 pointer</summary>
        @AV_PIX_FMT_DXVA2_VLD = 53,
        /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB444LE = 54,
        /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_RGB444BE = 55,
        /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR444LE = 56,
        /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined</summary>
        @AV_PIX_FMT_BGR444BE = 57,
        /// <summary>8 bits gray, 8 bits alpha</summary>
        @AV_PIX_FMT_YA8 = 58,
        /// <summary>alias for AV_PIX_FMT_YA8</summary>
        @AV_PIX_FMT_Y400A = 58,
        /// <summary>alias for AV_PIX_FMT_YA8</summary>
        @AV_PIX_FMT_GRAY8A = 58,
        /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian</summary>
        @AV_PIX_FMT_BGR48BE = 59,
        /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian</summary>
        @AV_PIX_FMT_BGR48LE = 60,
        /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P9BE = 61,
        /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P9LE = 62,
        /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P10BE = 63,
        /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P10LE = 64,
        /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P10BE = 65,
        /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P10LE = 66,
        /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P9BE = 67,
        /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P9LE = 68,
        /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P10BE = 69,
        /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P10LE = 70,
        /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P9BE = 71,
        /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P9LE = 72,
        /// <summary>planar GBR 4:4:4 24bpp</summary>
        @AV_PIX_FMT_GBRP = 73,
        @AV_PIX_FMT_GBR24P = 73,
        /// <summary>planar GBR 4:4:4 27bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP9BE = 74,
        /// <summary>planar GBR 4:4:4 27bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP9LE = 75,
        /// <summary>planar GBR 4:4:4 30bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP10BE = 76,
        /// <summary>planar GBR 4:4:4 30bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP10LE = 77,
        /// <summary>planar GBR 4:4:4 48bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP16BE = 78,
        /// <summary>planar GBR 4:4:4 48bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP16LE = 79,
        /// <summary>planar YUV 4:2:2 24bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples)</summary>
        @AV_PIX_FMT_YUVA422P = 80,
        /// <summary>planar YUV 4:4:4 32bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples)</summary>
        @AV_PIX_FMT_YUVA444P = 81,
        /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA420P9BE = 82,
        /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA420P9LE = 83,
        /// <summary>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA422P9BE = 84,
        /// <summary>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA422P9LE = 85,
        /// <summary>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian</summary>
        @AV_PIX_FMT_YUVA444P9BE = 86,
        /// <summary>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian</summary>
        @AV_PIX_FMT_YUVA444P9LE = 87,
        /// <summary>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA420P10BE = 88,
        /// <summary>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA420P10LE = 89,
        /// <summary>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA422P10BE = 90,
        /// <summary>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA422P10LE = 91,
        /// <summary>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA444P10BE = 92,
        /// <summary>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA444P10LE = 93,
        /// <summary>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA420P16BE = 94,
        /// <summary>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA420P16LE = 95,
        /// <summary>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA422P16BE = 96,
        /// <summary>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA422P16LE = 97,
        /// <summary>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian)</summary>
        @AV_PIX_FMT_YUVA444P16BE = 98,
        /// <summary>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian)</summary>
        @AV_PIX_FMT_YUVA444P16LE = 99,
        /// <summary>HW acceleration through VDPAU, Picture.data[3] contains a VdpVideoSurface</summary>
        @AV_PIX_FMT_VDPAU = 100,
        /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0</summary>
        @AV_PIX_FMT_XYZ12LE = 101,
        /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0</summary>
        @AV_PIX_FMT_XYZ12BE = 102,
        /// <summary>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples)</summary>
        @AV_PIX_FMT_NV16 = 103,
        /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_NV20LE = 104,
        /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_NV20BE = 105,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
        @AV_PIX_FMT_RGBA64BE = 106,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
        @AV_PIX_FMT_RGBA64LE = 107,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
        @AV_PIX_FMT_BGRA64BE = 108,
        /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
        @AV_PIX_FMT_BGRA64LE = 109,
        /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb</summary>
        @AV_PIX_FMT_YVYU422 = 110,
        /// <summary>16 bits gray, 16 bits alpha (big-endian)</summary>
        @AV_PIX_FMT_YA16BE = 111,
        /// <summary>16 bits gray, 16 bits alpha (little-endian)</summary>
        @AV_PIX_FMT_YA16LE = 112,
        /// <summary>planar GBRA 4:4:4:4 32bpp</summary>
        @AV_PIX_FMT_GBRAP = 113,
        /// <summary>planar GBRA 4:4:4:4 64bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP16BE = 114,
        /// <summary>planar GBRA 4:4:4:4 64bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP16LE = 115,
        /// <summary>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</summary>
        @AV_PIX_FMT_QSV = 116,
        /// <summary>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</summary>
        @AV_PIX_FMT_MMAL = 117,
        /// <summary>HW decoding through Direct3D11 via old API, Picture.data[3] contains a ID3D11VideoDecoderOutputView pointer</summary>
        @AV_PIX_FMT_D3D11VA_VLD = 118,
        /// <summary>HW acceleration through CUDA. data[i] contain CUdeviceptr pointers exactly as for system memory frames.</summary>
        @AV_PIX_FMT_CUDA = 119,
        /// <summary>packed RGB 8:8:8, 32bpp, XRGBXRGB... X=unused/undefined</summary>
        @AV_PIX_FMT_0RGB = 120,
        /// <summary>packed RGB 8:8:8, 32bpp, RGBXRGBX... X=unused/undefined</summary>
        @AV_PIX_FMT_RGB0 = 121,
        /// <summary>packed BGR 8:8:8, 32bpp, XBGRXBGR... X=unused/undefined</summary>
        @AV_PIX_FMT_0BGR = 122,
        /// <summary>packed BGR 8:8:8, 32bpp, BGRXBGRX... X=unused/undefined</summary>
        @AV_PIX_FMT_BGR0 = 123,
        /// <summary>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P12BE = 124,
        /// <summary>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P12LE = 125,
        /// <summary>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV420P14BE = 126,
        /// <summary>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV420P14LE = 127,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P12BE = 128,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P12LE = 129,
        /// <summary>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV422P14BE = 130,
        /// <summary>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV422P14LE = 131,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P12BE = 132,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P12LE = 133,
        /// <summary>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV444P14BE = 134,
        /// <summary>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV444P14LE = 135,
        /// <summary>planar GBR 4:4:4 36bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP12BE = 136,
        /// <summary>planar GBR 4:4:4 36bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP12LE = 137,
        /// <summary>planar GBR 4:4:4 42bpp, big-endian</summary>
        @AV_PIX_FMT_GBRP14BE = 138,
        /// <summary>planar GBR 4:4:4 42bpp, little-endian</summary>
        @AV_PIX_FMT_GBRP14LE = 139,
        /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range</summary>
        @AV_PIX_FMT_YUVJ411P = 140,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_BGGR8 = 141,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_RGGB8 = 142,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_GBRG8 = 143,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 8-bit samples */</summary>
        @AV_PIX_FMT_BAYER_GRBG8 = 144,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_BGGR16LE = 145,
        /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_BGGR16BE = 146,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_RGGB16LE = 147,
        /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_RGGB16BE = 148,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_GBRG16LE = 149,
        /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_GBRG16BE = 150,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, little-endian */</summary>
        @AV_PIX_FMT_BAYER_GRBG16LE = 151,
        /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, big-endian */</summary>
        @AV_PIX_FMT_BAYER_GRBG16BE = 152,
        /// <summary>XVideo Motion Acceleration via common packet passing</summary>
        @AV_PIX_FMT_XVMC = 153,
        /// <summary>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV440P10LE = 154,
        /// <summary>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV440P10BE = 155,
        /// <summary>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian</summary>
        @AV_PIX_FMT_YUV440P12LE = 156,
        /// <summary>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian</summary>
        @AV_PIX_FMT_YUV440P12BE = 157,
        /// <summary>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian</summary>
        @AV_PIX_FMT_AYUV64LE = 158,
        /// <summary>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian</summary>
        @AV_PIX_FMT_AYUV64BE = 159,
        /// <summary>hardware decoding through Videotoolbox</summary>
        @AV_PIX_FMT_VIDEOTOOLBOX = 160,
        /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian</summary>
        @AV_PIX_FMT_P010LE = 161,
        /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian</summary>
        @AV_PIX_FMT_P010BE = 162,
        /// <summary>planar GBR 4:4:4:4 48bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP12BE = 163,
        /// <summary>planar GBR 4:4:4:4 48bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP12LE = 164,
        /// <summary>planar GBR 4:4:4:4 40bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAP10BE = 165,
        /// <summary>planar GBR 4:4:4:4 40bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAP10LE = 166,
        /// <summary>hardware decoding through MediaCodec</summary>
        @AV_PIX_FMT_MEDIACODEC = 167,
        /// <summary>Y , 12bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY12BE = 168,
        /// <summary>Y , 12bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY12LE = 169,
        /// <summary>Y , 10bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY10BE = 170,
        /// <summary>Y , 10bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY10LE = 171,
        /// <summary>like NV12, with 16bpp per component, little-endian</summary>
        @AV_PIX_FMT_P016LE = 172,
        /// <summary>like NV12, with 16bpp per component, big-endian</summary>
        @AV_PIX_FMT_P016BE = 173,
        /// <summary>Hardware surfaces for Direct3D11.</summary>
        @AV_PIX_FMT_D3D11 = 174,
        /// <summary>Y , 9bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY9BE = 175,
        /// <summary>Y , 9bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY9LE = 176,
        /// <summary>IEEE-754 single precision planar GBR 4:4:4, 96bpp, big-endian</summary>
        @AV_PIX_FMT_GBRPF32BE = 177,
        /// <summary>IEEE-754 single precision planar GBR 4:4:4, 96bpp, little-endian</summary>
        @AV_PIX_FMT_GBRPF32LE = 178,
        /// <summary>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, big-endian</summary>
        @AV_PIX_FMT_GBRAPF32BE = 179,
        /// <summary>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, little-endian</summary>
        @AV_PIX_FMT_GBRAPF32LE = 180,
        /// <summary>DRM-managed buffers exposed through PRIME buffer sharing.</summary>
        @AV_PIX_FMT_DRM_PRIME = 181,
        /// <summary>Hardware surfaces for OpenCL.</summary>
        @AV_PIX_FMT_OPENCL = 182,
        /// <summary>Y , 14bpp, big-endian</summary>
        @AV_PIX_FMT_GRAY14BE = 183,
        /// <summary>Y , 14bpp, little-endian</summary>
        @AV_PIX_FMT_GRAY14LE = 184,
        /// <summary>IEEE-754 single precision Y, 32bpp, big-endian</summary>
        @AV_PIX_FMT_GRAYF32BE = 185,
        /// <summary>IEEE-754 single precision Y, 32bpp, little-endian</summary>
        @AV_PIX_FMT_GRAYF32LE = 186,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, big-endian</summary>
        @AV_PIX_FMT_YUVA422P12BE = 187,
        /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, little-endian</summary>
        @AV_PIX_FMT_YUVA422P12LE = 188,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, big-endian</summary>
        @AV_PIX_FMT_YUVA444P12BE = 189,
        /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, little-endian</summary>
        @AV_PIX_FMT_YUVA444P12LE = 190,
        /// <summary>planar YUV 4:4:4, 24bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
        @AV_PIX_FMT_NV24 = 191,
        /// <summary>as above, but U and V bytes are swapped</summary>
        @AV_PIX_FMT_NV42 = 192,
        /// <summary>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions</summary>
        @AV_PIX_FMT_NB = 193,
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
    
    public enum AVSideDataParamChangeFlags : int
    {
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 1,
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 2,
        @AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 4,
        @AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 8,
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
        @AVSTREAM_PARSE_FULL_RAW = 5,
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
    
    public enum AVTimebaseSource : int
    {
        @AVFMT_TBCF_AUTO = -1,
        @AVFMT_TBCF_DECODER = 0,
        @AVFMT_TBCF_DEMUXER = 1,
        @AVFMT_TBCF_R_FRAMERATE = 2,
    }
    
    public enum AVTimecodeFlag : int
    {
        /// <summary>timecode is drop frame</summary>
        @AV_TIMECODE_FLAG_DROPFRAME = 1,
        /// <summary>timecode wraps after 24 hours</summary>
        @AV_TIMECODE_FLAG_24HOURSMAX = 2,
        /// <summary>negative time values are allowed</summary>
        @AV_TIMECODE_FLAG_ALLOWNEGATIVE = 4,
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
    
}
