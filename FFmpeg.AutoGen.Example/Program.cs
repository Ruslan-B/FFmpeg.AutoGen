using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Example
{
    internal class Program
    {
        private static unsafe void Main(string[] args)
        {
            Console.WriteLine(@"Current directory: " + Environment.CurrentDirectory);
            Console.WriteLine(@"Runnung in {0}-bit mode.", Environment.Is64BitProcess ? @"64" : @"32");

            // register path to ffmpeg
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    string ffmpegPath = string.Format(@"../../../../FFmpeg/bin/{0}", Environment.Is64BitProcess ? @"x64" : @"x86");
                    InteropHelper.RegisterLibrariesSearchPath(ffmpegPath);
                    break;
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    string libraryPath = Environment.GetEnvironmentVariable(InteropHelper.LD_LIBRARY_PATH);
                    InteropHelper.RegisterLibrariesSearchPath(libraryPath);
                    break;
            }

            // decode 100 frame from url or path

            //string url = @"../../sample_mpeg4.mp4";
            string url = @"http://hubblesource.stsci.edu/sources/video/clips/details/images/centaur_1.mpg";

            ffmpeg.av_register_all();
            ffmpeg.avcodec_register_all();
            ffmpeg.avformat_network_init();


            AVFormatContext* pFormatContext = ffmpeg.avformat_alloc_context();
            if (ffmpeg.avformat_open_input(&pFormatContext, url, null, null) != 0)
            {
                throw new ApplicationException(@"Could not open file");
            }

            if (ffmpeg.avformat_find_stream_info(pFormatContext, null) != 0)
            {
                throw new ApplicationException(@"Could not find stream info");
            }

            AVStream* pStream = null;
            for (int i = 0; i < pFormatContext->nb_streams; i++)
            {
                if (pFormatContext->streams[i]->codec->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                {
                    pStream = pFormatContext->streams[i];
                    break;
                }
            }
            if (pStream == null)
            {
                throw new ApplicationException(@"Could not found video stream");
            }

            AVCodecContext codecContext = *(pStream->codec);
            int width = codecContext.width;
            int height = codecContext.height;
            AVPixelFormat sourcePixFmt = codecContext.pix_fmt;
            AVCodecID codecId = codecContext.codec_id;
            var convertToPixFmt = AVPixelFormat.PIX_FMT_BGR24;
            const int SWS_FAST_BILINEAR = 1;
            SwsContext* pConvertContext = ffmpeg.sws_getContext(width, height, sourcePixFmt,
                                                                       width, height, convertToPixFmt,
                                                                       SWS_FAST_BILINEAR, null, null, null);
            if (pConvertContext == null)
            {
                throw new ApplicationException(@"Could not initialize the conversion context");
            }

            var pConvertedFrame = ffmpeg.avcodec_alloc_frame();
            int convertedFrameBufferSize = ffmpeg.avpicture_get_size(convertToPixFmt, width, height);
            char* pConvertedFrameBuffer = (char*)ffmpeg.av_malloc((ulong)convertedFrameBufferSize);
            ffmpeg.avpicture_fill((AVPicture*)pConvertedFrame, pConvertedFrameBuffer, convertToPixFmt, width, height);

            AVCodec* pCodec = ffmpeg.avcodec_find_decoder(codecId);
            if (pCodec == null)
            {
                throw new ApplicationException(@"Unsupported codec");
            }

            // Reusing codec context from stream info, initally it was looking like this: 
            // AVCodecContext* pCodecContext = ffmpeg.avcodec_alloc_context3(pCodec); // but it is not working for all kind of codecs
            AVCodecContext* pCodecContext = &codecContext;

            const int CODEC_CAP_TRUNCATED = (1 << 3);
            const int CODEC_FLAG_TRUNCATED = (1 << 16);
            if ((pCodec->capabilities & CODEC_CAP_TRUNCATED) == CODEC_CAP_TRUNCATED)
            {
                pCodecContext->flags |= CODEC_FLAG_TRUNCATED;
            }

            if (ffmpeg.avcodec_open2(pCodecContext, pCodec, null) < 0)
            {
                throw new ApplicationException(@"Could not open codec");
            }

            AVFrame* pDecodedFrame = ffmpeg.av_frame_alloc();

            var packet = new AVPacket();
            AVPacket* pPacket = &packet;
            ffmpeg.av_init_packet(pPacket);

            int frameNumber = 0;
            while (frameNumber < 100)
            {
                if (ffmpeg.av_read_frame(pFormatContext, pPacket) < 0)
                {
                    throw new ApplicationException(@"Could not read frame");
                }

                if (pPacket->stream_index != pStream->index)
                    continue;

                int gotPicture = 0;
                int size = ffmpeg.avcodec_decode_video2(pCodecContext, pDecodedFrame, &gotPicture, pPacket);
                if (size < 0)
                {
                    throw new ApplicationException(string.Format(@"Error while decoding frame {0}", frameNumber));
                }

                if (gotPicture == 1)
                {
                    Console.WriteLine(@"frame: {0}", frameNumber);

                    char** src = &pDecodedFrame->data0;
                    char** dst = &pConvertedFrame->data0;
                    ffmpeg.sws_scale(pConvertContext, src, pDecodedFrame->linesize, 0,
                                            height, dst, pConvertedFrame->linesize);

                    char* convertedFrameAddress = pConvertedFrame->data0;

                    var imageBufferPtr = new IntPtr(convertedFrameAddress);

                    int linesize = pConvertedFrame->linesize[0];
                    using (var bitmap = new Bitmap(width, height, linesize, PixelFormat.Format24bppRgb, imageBufferPtr))
                    {
                        bitmap.Save(@"frame.buffer.jpg", ImageFormat.Jpeg);
                    }

                    frameNumber++;
                }
            }

            ffmpeg.av_free(pConvertedFrame);
            ffmpeg.av_free(pConvertedFrameBuffer);
            ffmpeg.sws_freeContext(pConvertContext);

            ffmpeg.av_free(pDecodedFrame);
            ffmpeg.avcodec_close(pCodecContext);
            ffmpeg.avformat_close_input(&pFormatContext);
        }
    }
}