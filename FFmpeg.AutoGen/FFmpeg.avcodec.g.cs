using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
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
    
    /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public unsafe struct short_array2
    {
        public short @at0; public short @at1;
        
        public short this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public short[] ToArray() => new[] {at0, at1};
    }
    
    /// <summary>position of the top left corner in 1/16 pel for up to 3 fields/frames - encoding: Set by user. - decoding: Set by libavcodec.</summary>
    public unsafe struct position_array6
    {
        public short_array2 @at0; public short_array2 @at1; public short_array2 @at2; public short_array2 @at3; public short_array2 @at4; public short_array2 @at5;
        
        public short_array2 this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; case 5: return at5; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; case 5: at5 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public short_array2[] ToArray() => new[] {at0, at1, at2, at3, at4, at5};
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
        public position_array6 @position;
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
    
    public unsafe struct byte_array32
    {
        public byte @at0; public byte @at1; public byte @at2; public byte @at3; public byte @at4; public byte @at5; public byte @at6; public byte @at7; public byte @at8; public byte @at9; public byte @at10; public byte @at11; public byte @at12; public byte @at13; public byte @at14; public byte @at15; public byte @at16; public byte @at17; public byte @at18; public byte @at19; public byte @at20; public byte @at21; public byte @at22; public byte @at23; public byte @at24; public byte @at25; public byte @at26; public byte @at27; public byte @at28; public byte @at29; public byte @at30; public byte @at31;
        
        public byte this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; case 5: return at5; case 6: return at6; case 7: return at7; case 8: return at8; case 9: return at9; case 10: return at10; case 11: return at11; case 12: return at12; case 13: return at13; case 14: return at14; case 15: return at15; case 16: return at16; case 17: return at17; case 18: return at18; case 19: return at19; case 20: return at20; case 21: return at21; case 22: return at22; case 23: return at23; case 24: return at24; case 25: return at25; case 26: return at26; case 27: return at27; case 28: return at28; case 29: return at29; case 30: return at30; case 31: return at31; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; case 5: at5 = value; return; case 6: at6 = value; return; case 7: at7 = value; return; case 8: at8 = value; return; case 9: at9 = value; return; case 10: at10 = value; return; case 11: at11 = value; return; case 12: at12 = value; return; case 13: at13 = value; return; case 14: at14 = value; return; case 15: at15 = value; return; case 16: at16 = value; return; case 17: at17 = value; return; case 18: at18 = value; return; case 19: at19 = value; return; case 20: at20 = value; return; case 21: at21 = value; return; case 22: at22 = value; return; case 23: at23 = value; return; case 24: at24 = value; return; case 25: at25 = value; return; case 26: at26 = value; return; case 27: at27 = value; return; case 28: at28 = value; return; case 29: at29 = value; return; case 30: at30 = value; return; case 31: at31 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public byte[] ToArray() => new[] {at0, at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at11, at12, at13, at14, at15, at16, at17, at18, at19, at20, at21, at22, at23, at24, at25, at26, at27, at28, at29, at30, at31};
    }
    
    /// <summary>main external API structure. New fields can be added to the end with minor version bumps. Removal, reordering and changes to existing fields require a major version bump. Please use AVOptions (av_opt* / av_set/get*()) to access these fields from user applications. The name string for AVOptions options matches the associated command line parameter name and can be found in libavcodec/options_table.h The AVOption/command line parameter names differ in some cases from the C structure field names for historic reasons or brevity. sizeof(AVCodecContext) must not be used outside libav*.</summary>
    public unsafe struct AVCodecContext
    {
        /// <summary>information on struct for av_log - set by avcodec_alloc_context3</summary>
        public AVClass* @av_class;
        public int @log_level_offset;
        public AVMediaType @codec_type;
        public IntPtr @codec;
        public byte_array32 @codec_name;
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
        public ulong_array8 @error;
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
        public data_array8 @data;
        /// <summary>number of bytes per line</summary>
        public int_array8 @linesize;
    }
    
    /// <summary>data+linesize for the bitmap of this subtitle. Can be set for text/ass as well once they are rendered.</summary>
    public unsafe struct data_array4
    {
        public byte* @at0; public byte* @at1; public byte* @at2; public byte* @at3;
        
        public byte* this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public byte*[] ToArray() => new[] {at0, at1, at2, at3};
    }
    
    public unsafe struct int_array4
    {
        public int @at0; public int @at1; public int @at2; public int @at3;
        
        public int this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public int[] ToArray() => new[] {at0, at1, at2, at3};
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
        public data_array4 @data;
        public int_array4 @linesize;
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
    
    public unsafe struct long_array4
    {
        public long @at0; public long @at1; public long @at2; public long @at3;
        
        public long this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public long[] ToArray() => new[] {at0, at1, at2, at3};
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
        public long_array4 @cur_frame_offset;
        public long_array4 @cur_frame_pts;
        public long_array4 @cur_frame_dts;
        public int @flags;
        /// <summary>byte offset from starting packet start</summary>
        public long @offset;
        public long_array4 @cur_frame_end;
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
    
    public unsafe struct int_array5
    {
        public int @at0; public int @at1; public int @at2; public int @at3; public int @at4;
        
        public int this[int index]
        {
            get { switch (index) {case 0: return at0; case 1: return at1; case 2: return at2; case 3: return at3; case 4: return at4; default: throw new ArgumentOutOfRangeException(); }}
            set { switch (index) {case 0: at0 = value; return; case 1: at1 = value; return; case 2: at2 = value; return; case 3: at3 = value; return; case 4: at4 = value; return; default: throw new ArgumentOutOfRangeException(); }}
        }
        
        public int[] ToArray() => new[] {at0, at1, at2, at3, at4};
    }
    
    public unsafe struct AVCodecParser
    {
        public int_array5 @codec_ids;
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
    
    public unsafe static partial class ffmpeg
    {
        // public static  AV_CODEC_ID_IFF_BYTERUN1 = AV_CODEC_ID_IFF_ILBM;
        // public static  AV_CODEC_ID_H265 = AV_CODEC_ID_HEVC;
        public static int AV_CODEC_PROP_INTRA_ONLY = (1 << 0);
        public static int AV_CODEC_PROP_LOSSY = (1 << 1);
        public static int AV_CODEC_PROP_LOSSLESS = (1 << 2);
        public static int AV_CODEC_PROP_REORDER = (1 << 3);
        public static int AV_CODEC_PROP_BITMAP_SUB = (1 << 16);
        public static int AV_CODEC_PROP_TEXT_SUB = (1 << 17);
        public static int AV_INPUT_BUFFER_PADDING_SIZE = 32;
        public static int AV_INPUT_BUFFER_MIN_SIZE = 16384;
        public static int FF_INPUT_BUFFER_PADDING_SIZE = 32;
        public static int FF_MIN_BUFFER_SIZE = 16384;
        public static int FF_MAX_B_FRAMES = 16;
        public static int AV_CODEC_FLAG_UNALIGNED = (1 << 0);
        public static int AV_CODEC_FLAG_QSCALE = (1 << 1);
        public static int AV_CODEC_FLAG_4MV = (1 << 2);
        public static int AV_CODEC_FLAG_OUTPUT_CORRUPT = (1 << 3);
        public static int AV_CODEC_FLAG_QPEL = (1 << 4);
        public static int AV_CODEC_FLAG_PASS1 = (1 << 9);
        public static int AV_CODEC_FLAG_PASS2 = (1 << 10);
        public static int AV_CODEC_FLAG_LOOP_FILTER = (1 << 11);
        public static int AV_CODEC_FLAG_GRAY = (1 << 13);
        public static int AV_CODEC_FLAG_PSNR = (1 << 15);
        public static int AV_CODEC_FLAG_TRUNCATED = (1 << 16);
        public static int AV_CODEC_FLAG_INTERLACED_DCT = (1 << 18);
        public static int AV_CODEC_FLAG_LOW_DELAY = (1 << 19);
        public static int AV_CODEC_FLAG_GLOBAL_HEADER = (1 << 22);
        public static int AV_CODEC_FLAG_BITEXACT = (1 << 23);
        public static int AV_CODEC_FLAG_AC_PRED = (1 << 24);
        public static int AV_CODEC_FLAG_INTERLACED_ME = (1 << 29);
        public static uint AV_CODEC_FLAG_CLOSED_GOP = (1U << 31);
        public static int AV_CODEC_FLAG2_FAST = (1 << 0);
        public static int AV_CODEC_FLAG2_NO_OUTPUT = (1 << 2);
        public static int AV_CODEC_FLAG2_LOCAL_HEADER = (1 << 3);
        public static int AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = (1 << 13);
        public static int AV_CODEC_FLAG2_CHUNKS = (1 << 15);
        public static int AV_CODEC_FLAG2_IGNORE_CROP = (1 << 16);
        public static int AV_CODEC_FLAG2_SHOW_ALL = (1 << 22);
        public static int AV_CODEC_FLAG2_EXPORT_MVS = (1 << 28);
        public static int AV_CODEC_FLAG2_SKIP_MANUAL = (1 << 29);
        public static int AV_CODEC_FLAG2_RO_FLUSH_NOOP = (1 << 30);
        public static int AV_CODEC_CAP_DRAW_HORIZ_BAND = (1 << 0);
        public static int AV_CODEC_CAP_DR1 = (1 << 1);
        public static int AV_CODEC_CAP_TRUNCATED = (1 << 3);
        public static int AV_CODEC_CAP_DELAY = (1 << 5);
        public static int AV_CODEC_CAP_SMALL_LAST_FRAME = (1 << 6);
        public static int AV_CODEC_CAP_HWACCEL_VDPAU = (1 << 7);
        public static int AV_CODEC_CAP_SUBFRAMES = (1 << 8);
        public static int AV_CODEC_CAP_EXPERIMENTAL = (1 << 9);
        public static int AV_CODEC_CAP_CHANNEL_CONF = (1 << 10);
        public static int AV_CODEC_CAP_FRAME_THREADS = (1 << 12);
        public static int AV_CODEC_CAP_SLICE_THREADS = (1 << 13);
        public static int AV_CODEC_CAP_PARAM_CHANGE = (1 << 14);
        public static int AV_CODEC_CAP_AUTO_THREADS = (1 << 15);
        public static int AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1 << 16);
        public static int AV_CODEC_CAP_AVOID_PROBING = (1 << 17);
        public static int AV_CODEC_CAP_INTRA_ONLY = 0x40000000;
        public static long AV_CODEC_CAP_LOSSLESS = 0x80000000;
        public static int CODEC_FLAG_UNALIGNED = AV_CODEC_FLAG_UNALIGNED;
        public static int CODEC_FLAG_QSCALE = AV_CODEC_FLAG_QSCALE;
        public static int CODEC_FLAG_4MV = AV_CODEC_FLAG_4MV;
        public static int CODEC_FLAG_OUTPUT_CORRUPT = AV_CODEC_FLAG_OUTPUT_CORRUPT;
        public static int CODEC_FLAG_QPEL = AV_CODEC_FLAG_QPEL;
        public static int CODEC_FLAG_GMC = 0x0020;
        public static int CODEC_FLAG_MV0 = 0x0040;
        public static int CODEC_FLAG_INPUT_PRESERVED = 0x0100;
        public static int CODEC_FLAG_PASS1 = AV_CODEC_FLAG_PASS1;
        public static int CODEC_FLAG_PASS2 = AV_CODEC_FLAG_PASS2;
        public static int CODEC_FLAG_GRAY = AV_CODEC_FLAG_GRAY;
        public static int CODEC_FLAG_EMU_EDGE = 0x4000;
        public static int CODEC_FLAG_PSNR = AV_CODEC_FLAG_PSNR;
        public static int CODEC_FLAG_TRUNCATED = AV_CODEC_FLAG_TRUNCATED;
        public static int CODEC_FLAG_NORMALIZE_AQP = 0x00020000;
        public static int CODEC_FLAG_INTERLACED_DCT = AV_CODEC_FLAG_INTERLACED_DCT;
        public static int CODEC_FLAG_LOW_DELAY = AV_CODEC_FLAG_LOW_DELAY;
        public static int CODEC_FLAG_GLOBAL_HEADER = AV_CODEC_FLAG_GLOBAL_HEADER;
        public static int CODEC_FLAG_BITEXACT = AV_CODEC_FLAG_BITEXACT;
        public static int CODEC_FLAG_AC_PRED = AV_CODEC_FLAG_AC_PRED;
        public static int CODEC_FLAG_LOOP_FILTER = AV_CODEC_FLAG_LOOP_FILTER;
        public static int CODEC_FLAG_INTERLACED_ME = AV_CODEC_FLAG_INTERLACED_ME;
        public static uint CODEC_FLAG_CLOSED_GOP = AV_CODEC_FLAG_CLOSED_GOP;
        public static int CODEC_FLAG2_FAST = AV_CODEC_FLAG2_FAST;
        public static int CODEC_FLAG2_NO_OUTPUT = AV_CODEC_FLAG2_NO_OUTPUT;
        public static int CODEC_FLAG2_LOCAL_HEADER = AV_CODEC_FLAG2_LOCAL_HEADER;
        public static int CODEC_FLAG2_DROP_FRAME_TIMECODE = AV_CODEC_FLAG2_DROP_FRAME_TIMECODE;
        public static int CODEC_FLAG2_IGNORE_CROP = AV_CODEC_FLAG2_IGNORE_CROP;
        public static int CODEC_FLAG2_CHUNKS = AV_CODEC_FLAG2_CHUNKS;
        public static int CODEC_FLAG2_SHOW_ALL = AV_CODEC_FLAG2_SHOW_ALL;
        public static int CODEC_FLAG2_EXPORT_MVS = AV_CODEC_FLAG2_EXPORT_MVS;
        public static int CODEC_FLAG2_SKIP_MANUAL = AV_CODEC_FLAG2_SKIP_MANUAL;
        public static int CODEC_CAP_DRAW_HORIZ_BAND = AV_CODEC_CAP_DRAW_HORIZ_BAND;
        public static int CODEC_CAP_DR1 = AV_CODEC_CAP_DR1;
        public static int CODEC_CAP_TRUNCATED = AV_CODEC_CAP_TRUNCATED;
        public static int CODEC_CAP_HWACCEL = 0x0010;
        public static int CODEC_CAP_DELAY = AV_CODEC_CAP_DELAY;
        public static int CODEC_CAP_SMALL_LAST_FRAME = AV_CODEC_CAP_SMALL_LAST_FRAME;
        public static int CODEC_CAP_HWACCEL_VDPAU = AV_CODEC_CAP_HWACCEL_VDPAU;
        public static int CODEC_CAP_SUBFRAMES = AV_CODEC_CAP_SUBFRAMES;
        public static int CODEC_CAP_EXPERIMENTAL = AV_CODEC_CAP_EXPERIMENTAL;
        public static int CODEC_CAP_CHANNEL_CONF = AV_CODEC_CAP_CHANNEL_CONF;
        public static int CODEC_CAP_NEG_LINESIZES = 0x0800;
        public static int CODEC_CAP_FRAME_THREADS = AV_CODEC_CAP_FRAME_THREADS;
        public static int CODEC_CAP_SLICE_THREADS = AV_CODEC_CAP_SLICE_THREADS;
        public static int CODEC_CAP_PARAM_CHANGE = AV_CODEC_CAP_PARAM_CHANGE;
        public static int CODEC_CAP_AUTO_THREADS = AV_CODEC_CAP_AUTO_THREADS;
        public static int CODEC_CAP_VARIABLE_FRAME_SIZE = AV_CODEC_CAP_VARIABLE_FRAME_SIZE;
        public static int CODEC_CAP_INTRA_ONLY = AV_CODEC_CAP_INTRA_ONLY;
        public static long CODEC_CAP_LOSSLESS = AV_CODEC_CAP_LOSSLESS;
        public static int HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x0200;
        public static int MB_TYPE_INTRA4x4 = 0x0001;
        public static int MB_TYPE_INTRA16x16 = 0x0002;
        public static int MB_TYPE_INTRA_PCM = 0x0004;
        public static int MB_TYPE_16x16 = 0x0008;
        public static int MB_TYPE_16x8 = 0x0010;
        public static int MB_TYPE_8x16 = 0x0020;
        public static int MB_TYPE_8x8 = 0x0040;
        public static int MB_TYPE_INTERLACED = 0x0080;
        public static int MB_TYPE_DIRECT2 = 0x0100;
        public static int MB_TYPE_ACPRED = 0x0200;
        public static int MB_TYPE_GMC = 0x0400;
        public static int MB_TYPE_SKIP = 0x0800;
        public static int MB_TYPE_P0L0 = 0x1000;
        public static int MB_TYPE_P1L0 = 0x2000;
        public static int MB_TYPE_P0L1 = 0x4000;
        public static int MB_TYPE_P1L1 = 0x8000;
        public static int MB_TYPE_L0 = (MB_TYPE_P0L0 | MB_TYPE_P1L0);
        public static int MB_TYPE_L1 = (MB_TYPE_P0L1 | MB_TYPE_P1L1);
        public static int MB_TYPE_L0L1 = (MB_TYPE_L0 | MB_TYPE_L1);
        public static int MB_TYPE_QUANT = 0x00010000;
        public static int MB_TYPE_CBP = 0x00020000;
        public static int FF_QSCALE_TYPE_MPEG1 = 0;
        public static int FF_QSCALE_TYPE_MPEG2 = 1;
        public static int FF_QSCALE_TYPE_H264 = 2;
        public static int FF_QSCALE_TYPE_VP56 = 3;
        public static int AV_GET_BUFFER_FLAG_REF = (1 << 0);
        // public static  AV_PKT_DATA_QUALITY_FACTOR = AV_PKT_DATA_QUALITY_STATS;
        public static int AV_PKT_FLAG_KEY = 0x0001;
        public static int AV_PKT_FLAG_CORRUPT = 0x0002;
        public static int AV_PKT_FLAG_DISCARD = 0x0004;
        public static int FF_COMPRESSION_DEFAULT = -1;
        public static int FF_ASPECT_EXTENDED = 15;
        public static int FF_RC_STRATEGY_XVID = 1;
        public static int FF_PRED_LEFT = 0;
        public static int FF_PRED_PLANE = 1;
        public static int FF_PRED_MEDIAN = 2;
        public static int FF_CMP_SAD = 0;
        public static int FF_CMP_SSE = 1;
        public static int FF_CMP_SATD = 2;
        public static int FF_CMP_DCT = 3;
        public static int FF_CMP_PSNR = 4;
        public static int FF_CMP_BIT = 5;
        public static int FF_CMP_RD = 6;
        public static int FF_CMP_ZERO = 7;
        public static int FF_CMP_VSAD = 8;
        public static int FF_CMP_VSSE = 9;
        public static int FF_CMP_NSSE = 10;
        public static int FF_CMP_W53 = 11;
        public static int FF_CMP_W97 = 12;
        public static int FF_CMP_DCTMAX = 13;
        public static int FF_CMP_DCT264 = 14;
        public static int FF_CMP_MEDIAN_SAD = 15;
        public static int FF_CMP_CHROMA = 256;
        public static int FF_DTG_AFD_SAME = 8;
        public static int FF_DTG_AFD_4_3 = 9;
        public static int FF_DTG_AFD_16_9 = 10;
        public static int FF_DTG_AFD_14_9 = 11;
        public static int FF_DTG_AFD_4_3_SP_14_9 = 13;
        public static int FF_DTG_AFD_16_9_SP_14_9 = 14;
        public static int FF_DTG_AFD_SP_4_3 = 15;
        public static int FF_DEFAULT_QUANT_BIAS = 999999;
        public static int SLICE_FLAG_CODED_ORDER = 0x0001;
        public static int SLICE_FLAG_ALLOW_FIELD = 0x0002;
        public static int SLICE_FLAG_ALLOW_PLANE = 0x0004;
        public static int FF_MB_DECISION_SIMPLE = 0;
        public static int FF_MB_DECISION_BITS = 1;
        public static int FF_MB_DECISION_RD = 2;
        public static int FF_CODER_TYPE_VLC = 0;
        public static int FF_CODER_TYPE_AC = 1;
        public static int FF_CODER_TYPE_RAW = 2;
        public static int FF_CODER_TYPE_RLE = 3;
        public static int FF_CODER_TYPE_DEFLATE = 4;
        public static int FF_BUG_AUTODETECT = 1;
        public static int FF_BUG_OLD_MSMPEG4 = 2;
        public static int FF_BUG_XVID_ILACE = 4;
        public static int FF_BUG_UMP4 = 8;
        public static int FF_BUG_NO_PADDING = 16;
        public static int FF_BUG_AMV = 32;
        public static int FF_BUG_AC_VLC = 0;
        public static int FF_BUG_QPEL_CHROMA = 64;
        public static int FF_BUG_STD_QPEL = 128;
        public static int FF_BUG_QPEL_CHROMA2 = 256;
        public static int FF_BUG_DIRECT_BLOCKSIZE = 512;
        public static int FF_BUG_EDGE = 1024;
        public static int FF_BUG_HPEL_CHROMA = 2048;
        public static int FF_BUG_DC_CLIP = 4096;
        public static int FF_BUG_MS = 8192;
        public static int FF_BUG_TRUNCATED = 16384;
        public static int FF_BUG_IEDGE = 32768;
        public static int FF_COMPLIANCE_VERY_STRICT = 2;
        public static int FF_COMPLIANCE_STRICT = 1;
        public static int FF_COMPLIANCE_NORMAL = 0;
        public static int FF_COMPLIANCE_UNOFFICIAL = -1;
        public static int FF_COMPLIANCE_EXPERIMENTAL = -2;
        public static int FF_EC_GUESS_MVS = 1;
        public static int FF_EC_DEBLOCK = 2;
        public static int FF_EC_FAVOR_INTER = 256;
        public static int FF_DEBUG_PICT_INFO = 1;
        public static int FF_DEBUG_RC = 2;
        public static int FF_DEBUG_BITSTREAM = 4;
        public static int FF_DEBUG_MB_TYPE = 8;
        public static int FF_DEBUG_QP = 16;
        public static int FF_DEBUG_MV = 32;
        public static int FF_DEBUG_DCT_COEFF = 0x00000040;
        public static int FF_DEBUG_SKIP = 0x00000080;
        public static int FF_DEBUG_STARTCODE = 0x00000100;
        public static int FF_DEBUG_PTS = 0x00000200;
        public static int FF_DEBUG_ER = 0x00000400;
        public static int FF_DEBUG_MMCO = 0x00000800;
        public static int FF_DEBUG_BUGS = 0x00001000;
        public static int FF_DEBUG_VIS_QP = 0x00002000;
        public static int FF_DEBUG_VIS_MB_TYPE = 0x00004000;
        public static int FF_DEBUG_BUFFERS = 0x00008000;
        public static int FF_DEBUG_THREADS = 0x00010000;
        public static int FF_DEBUG_GREEN_MD = 0x00800000;
        public static int FF_DEBUG_NOMC = 0x01000000;
        public static int FF_DEBUG_VIS_MV_P_FOR = 0x00000001;
        public static int FF_DEBUG_VIS_MV_B_FOR = 0x00000002;
        public static int FF_DEBUG_VIS_MV_B_BACK = 0x00000004;
        public static int AV_EF_CRCCHECK = (1 << 0);
        public static int AV_EF_BITSTREAM = (1 << 1);
        public static int AV_EF_BUFFER = (1 << 2);
        public static int AV_EF_EXPLODE = (1 << 3);
        public static int AV_EF_IGNORE_ERR = (1 << 15);
        public static int AV_EF_CAREFUL = (1 << 16);
        public static int AV_EF_COMPLIANT = (1 << 17);
        public static int AV_EF_AGGRESSIVE = (1 << 18);
        public static int FF_DCT_AUTO = 0;
        public static int FF_DCT_FASTINT = 1;
        public static int FF_DCT_INT = 2;
        public static int FF_DCT_MMX = 3;
        public static int FF_DCT_ALTIVEC = 5;
        public static int FF_DCT_FAAN = 6;
        public static int FF_IDCT_AUTO = 0;
        public static int FF_IDCT_INT = 1;
        public static int FF_IDCT_SIMPLE = 2;
        public static int FF_IDCT_SIMPLEMMX = 3;
        public static int FF_IDCT_ARM = 7;
        public static int FF_IDCT_ALTIVEC = 8;
        public static int FF_IDCT_SH4 = 9;
        public static int FF_IDCT_SIMPLEARM = 10;
        public static int FF_IDCT_IPP = 13;
        public static int FF_IDCT_XVID = 14;
        public static int FF_IDCT_XVIDMMX = 14;
        public static int FF_IDCT_SIMPLEARMV5TE = 16;
        public static int FF_IDCT_SIMPLEARMV6 = 17;
        public static int FF_IDCT_SIMPLEVIS = 18;
        public static int FF_IDCT_FAAN = 20;
        public static int FF_IDCT_SIMPLENEON = 22;
        public static int FF_IDCT_SIMPLEALPHA = 23;
        public static int FF_IDCT_SIMPLEAUTO = 128;
        public static int FF_THREAD_FRAME = 1;
        public static int FF_THREAD_SLICE = 2;
        public static int FF_PROFILE_UNKNOWN = -99;
        public static int FF_PROFILE_RESERVED = -100;
        public static int FF_PROFILE_AAC_MAIN = 0;
        public static int FF_PROFILE_AAC_LOW = 1;
        public static int FF_PROFILE_AAC_SSR = 2;
        public static int FF_PROFILE_AAC_LTP = 3;
        public static int FF_PROFILE_AAC_HE = 4;
        public static int FF_PROFILE_AAC_HE_V2 = 28;
        public static int FF_PROFILE_AAC_LD = 22;
        public static int FF_PROFILE_AAC_ELD = 38;
        public static int FF_PROFILE_MPEG2_AAC_LOW = 128;
        public static int FF_PROFILE_MPEG2_AAC_HE = 131;
        public static int FF_PROFILE_DNXHD = 0;
        public static int FF_PROFILE_DNXHR_LB = 1;
        public static int FF_PROFILE_DNXHR_SQ = 2;
        public static int FF_PROFILE_DNXHR_HQ = 3;
        public static int FF_PROFILE_DNXHR_HQX = 4;
        public static int FF_PROFILE_DNXHR_444 = 5;
        public static int FF_PROFILE_DTS = 20;
        public static int FF_PROFILE_DTS_ES = 30;
        public static int FF_PROFILE_DTS_96_24 = 40;
        public static int FF_PROFILE_DTS_HD_HRA = 50;
        public static int FF_PROFILE_DTS_HD_MA = 60;
        public static int FF_PROFILE_DTS_EXPRESS = 70;
        public static int FF_PROFILE_MPEG2_422 = 0;
        public static int FF_PROFILE_MPEG2_HIGH = 1;
        public static int FF_PROFILE_MPEG2_SS = 2;
        public static int FF_PROFILE_MPEG2_SNR_SCALABLE = 3;
        public static int FF_PROFILE_MPEG2_MAIN = 4;
        public static int FF_PROFILE_MPEG2_SIMPLE = 5;
        public static int FF_PROFILE_H264_CONSTRAINED = (1 << 9);
        public static int FF_PROFILE_H264_INTRA = (1 << 11);
        public static int FF_PROFILE_H264_BASELINE = 66;
        public static int FF_PROFILE_H264_CONSTRAINED_BASELINE = (66 | FF_PROFILE_H264_CONSTRAINED);
        public static int FF_PROFILE_H264_MAIN = 77;
        public static int FF_PROFILE_H264_EXTENDED = 88;
        public static int FF_PROFILE_H264_HIGH = 100;
        public static int FF_PROFILE_H264_HIGH_10 = 110;
        public static int FF_PROFILE_H264_HIGH_10_INTRA = (110 | FF_PROFILE_H264_INTRA);
        public static int FF_PROFILE_H264_MULTIVIEW_HIGH = 118;
        public static int FF_PROFILE_H264_HIGH_422 = 122;
        public static int FF_PROFILE_H264_HIGH_422_INTRA = (122 | FF_PROFILE_H264_INTRA);
        public static int FF_PROFILE_H264_STEREO_HIGH = 128;
        public static int FF_PROFILE_H264_HIGH_444 = 144;
        public static int FF_PROFILE_H264_HIGH_444_PREDICTIVE = 244;
        public static int FF_PROFILE_H264_HIGH_444_INTRA = (244 | FF_PROFILE_H264_INTRA);
        public static int FF_PROFILE_H264_CAVLC_444 = 44;
        public static int FF_PROFILE_VC1_SIMPLE = 0;
        public static int FF_PROFILE_VC1_MAIN = 1;
        public static int FF_PROFILE_VC1_COMPLEX = 2;
        public static int FF_PROFILE_VC1_ADVANCED = 3;
        public static int FF_PROFILE_MPEG4_SIMPLE = 0;
        public static int FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 1;
        public static int FF_PROFILE_MPEG4_CORE = 2;
        public static int FF_PROFILE_MPEG4_MAIN = 3;
        public static int FF_PROFILE_MPEG4_N_BIT = 4;
        public static int FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 5;
        public static int FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 6;
        public static int FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 7;
        public static int FF_PROFILE_MPEG4_HYBRID = 8;
        public static int FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 9;
        public static int FF_PROFILE_MPEG4_CORE_SCALABLE = 10;
        public static int FF_PROFILE_MPEG4_ADVANCED_CODING = 11;
        public static int FF_PROFILE_MPEG4_ADVANCED_CORE = 12;
        public static int FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 13;
        public static int FF_PROFILE_MPEG4_SIMPLE_STUDIO = 14;
        public static int FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 15;
        public static int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 1;
        public static int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 2;
        public static int FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 32768;
        public static int FF_PROFILE_JPEG2000_DCINEMA_2K = 3;
        public static int FF_PROFILE_JPEG2000_DCINEMA_4K = 4;
        public static int FF_PROFILE_VP9_0 = 0;
        public static int FF_PROFILE_VP9_1 = 1;
        public static int FF_PROFILE_VP9_2 = 2;
        public static int FF_PROFILE_VP9_3 = 3;
        public static int FF_PROFILE_HEVC_MAIN = 1;
        public static int FF_PROFILE_HEVC_MAIN_10 = 2;
        public static int FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 3;
        public static int FF_PROFILE_HEVC_REXT = 4;
        public static int FF_LEVEL_UNKNOWN = -99;
        public static int FF_SUB_CHARENC_MODE_DO_NOTHING = -1;
        public static int FF_SUB_CHARENC_MODE_AUTOMATIC = 0;
        public static int FF_SUB_CHARENC_MODE_PRE_DECODER = 1;
        public static int FF_CODEC_PROPERTY_LOSSLESS = 0x00000001;
        public static int FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x00000002;
        public static int FF_SUB_TEXT_FMT_ASS = 0;
        public static int FF_SUB_TEXT_FMT_ASS_WITH_TIMINGS = 1;
        public static int AV_HWACCEL_FLAG_IGNORE_LEVEL = (1 << 0);
        public static int AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = (1 << 1);
        public static int AV_SUBTITLE_FLAG_FORCED = 0x00000001;
        public static int AV_PARSER_PTS_NB = 4;
        public static int PARSER_FLAG_COMPLETE_FRAMES = 0x0001;
        public static int PARSER_FLAG_ONCE = 0x0002;
        public static int PARSER_FLAG_FETCHED_OFFSET = 0x0004;
        public static int PARSER_FLAG_USE_CODEC_TS = 0x1000;
        public static long AV_CPU_FLAG_FORCE = 0x80000000;
        public static int AV_CPU_FLAG_MMX = 0x0001;
        public static int AV_CPU_FLAG_MMXEXT = 0x0002;
        public static int AV_CPU_FLAG_MMX2 = 0x0002;
        public static int AV_CPU_FLAG_3DNOW = 0x0004;
        public static int AV_CPU_FLAG_SSE = 0x0008;
        public static int AV_CPU_FLAG_SSE2 = 0x0010;
        public static int AV_CPU_FLAG_SSE2SLOW = 0x40000000;
        public static int AV_CPU_FLAG_3DNOWEXT = 0x0020;
        public static int AV_CPU_FLAG_SSE3 = 0x0040;
        public static int AV_CPU_FLAG_SSE3SLOW = 0x20000000;
        public static int AV_CPU_FLAG_SSSE3 = 0x0080;
        public static int AV_CPU_FLAG_ATOM = 0x10000000;
        public static int AV_CPU_FLAG_SSE4 = 0x0100;
        public static int AV_CPU_FLAG_SSE42 = 0x0200;
        public static int AV_CPU_FLAG_AESNI = 0x80000;
        public static int AV_CPU_FLAG_AVX = 0x4000;
        public static int AV_CPU_FLAG_AVXSLOW = 0x8000000;
        public static int AV_CPU_FLAG_XOP = 0x0400;
        public static int AV_CPU_FLAG_FMA4 = 0x0800;
        public static int AV_CPU_FLAG_CMOV = 0x1000;
        public static int AV_CPU_FLAG_AVX2 = 0x8000;
        public static int AV_CPU_FLAG_FMA3 = 0x10000;
        public static int AV_CPU_FLAG_BMI1 = 0x20000;
        public static int AV_CPU_FLAG_BMI2 = 0x40000;
        public static int AV_CPU_FLAG_ALTIVEC = 0x0001;
        public static int AV_CPU_FLAG_VSX = 0x0002;
        public static int AV_CPU_FLAG_POWER8 = 0x0004;
        public static int AV_CPU_FLAG_ARMV5TE = (1 << 0);
        public static int AV_CPU_FLAG_ARMV6 = (1 << 1);
        public static int AV_CPU_FLAG_ARMV6T2 = (1 << 2);
        public static int AV_CPU_FLAG_VFP = (1 << 3);
        public static int AV_CPU_FLAG_VFPV3 = (1 << 4);
        public static int AV_CPU_FLAG_NEON = (1 << 5);
        public static int AV_CPU_FLAG_ARMV8 = (1 << 6);
        public static int AV_CPU_FLAG_VFP_VM = (1 << 7);
        public static int AV_CPU_FLAG_SETEND = (1 << 16);
        public static int LIBAVCODEC_VERSION_MAJOR = 57;
        public static int LIBAVCODEC_VERSION_MINOR = 64;
        public static int LIBAVCODEC_VERSION_MICRO = 101;
        // public static  LIBAVCODEC_VERSION_INT = AV_VERSION_INT(LIBAVCODEC_VERSION_MAJOR, LIBAVCODEC_VERSION_MINOR, LIBAVCODEC_VERSION_MICRO);
        // public static  LIBAVCODEC_VERSION = AV_VERSION(LIBAVCODEC_VERSION_MAJOR,    LIBAVCODEC_VERSION_MINOR,    LIBAVCODEC_VERSION_MICRO);
        // public static  LIBAVCODEC_BUILD = LIBAVCODEC_VERSION_INT;
        // public static  LIBAVCODEC_IDENT = "Lavc" AV_STRINGIFY(LIBAVCODEC_VERSION);
        public static bool FF_API_VIMA_DECODER = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AUDIO_CONVERT = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AVCODEC_RESAMPLE = FF_API_AUDIO_CONVERT;
        public static bool FF_API_GETCHROMA = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_MISSING_SAMPLE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_LOWRES = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_CAP_VDPAU = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_BUFS_VDPAU = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_VOXWARE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_SET_DIMENSIONS = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_DEBUG_MV = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AC_VLC = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_OLD_MSMPEG4 = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_ASPECT_EXTENDED = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_ARCH_ALPHA = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_ERROR_RATE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_QSCALE_TYPE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_MB_TYPE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_MAX_BFRAMES = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_NEG_LINESIZES = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_EMU_EDGE = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_ARCH_SH4 = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_ARCH_SPARC = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_UNUSED_MEMBERS = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_IDCT_XVIDMMX = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_INPUT_PRESERVED = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_NORMALIZE_AQP = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_GMC = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_MV0 = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_CODEC_NAME = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AFD = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_VISMV = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AUDIOENC_DELAY = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_VAAPI_CONTEXT = (LIBAVCODEC_VERSION_MAJOR < 58);
        public static bool FF_API_AVCTX_TIMEBASE = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_MPV_OPT = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_STREAM_CODEC_TAG = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_QUANT_BIAS = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_RC_STRATEGY = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_CODED_FRAME = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_MOTION_EST = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_WITHOUT_PREFIX = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_SIDEDATA_ONLY_PKT = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_VDPAU_PROFILE = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_CONVERGENCE_DURATION = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_AVPICTURE = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_AVPACKET_OLD_API = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_RTP_CALLBACK = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_VBV_DELAY = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_CODER_TYPE = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_STAT_BITS = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_PRIVATE_OPT = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_ASS_TIMING = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_OLD_BSF = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_COPY_CONTEXT = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_GET_CONTEXT_DEFAULTS = (LIBAVCODEC_VERSION_MAJOR < 59);
        public static bool FF_API_NVENC_OLD_NAME = (LIBAVCODEC_VERSION_MAJOR < 59);
        
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
        public static extern void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, [MarshalAs(UnmanagedType.LPArray, SizeConst=8)] int[] @linesize_align);
        
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
        
    }
}
