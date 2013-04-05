using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace FFmpeg.AutoGen.Example
{
    internal class Program
    {
        private static unsafe void Main(string[] args)
        {
            string url = @"http://samples.FFmpegNative.org/MPEG1/zelda%20first%20commercial.mpeg";

            FFmpegNative.av_register_all();
            FFmpegNative.avcodec_register_all();
            FFmpegNative.avformat_network_init();


            FFmpegNative.AVFormatContext* pFormatContext = FFmpegNative.avformat_alloc_context();
            if (FFmpegNative.avformat_open_input(&pFormatContext, url, null, null) != 0)
                throw new Exception("Could not open file");

            if (FFmpegNative.av_find_stream_info(pFormatContext) != 0)
                throw new Exception("Could not find stream info");

            FFmpegNative.AVStream* pStream = null;
            for (int i = 0; i < pFormatContext->nb_streams; i++)
            {
                if (pFormatContext->streams[0]->codec->codec_type == FFmpegNative.AVMediaType.AVMEDIA_TYPE_VIDEO)
                {
                    pStream = pFormatContext->streams[0];
                    break;
                }
            }
            if (pStream == null)
                throw new Exception("Could not found video stream");

            FFmpegNative.AVCodecContext* pCodecContext = pStream->codec;

            var convertToPixFmt = FFmpegNative.AVPixelFormat.PIX_FMT_BGR24;
            FFmpegNative.SwsContext* pConvertContext = FFmpegNative.sws_getContext(pCodecContext->width, pCodecContext->height, pCodecContext->pix_fmt,
                                                                                   pCodecContext->width, pCodecContext->height, convertToPixFmt,
                                                                                   FFmpegNative.SWS_FAST_BILINEAR, null, null, null);
            if (pConvertContext == null)
                throw new Exception("Could not initialize the conversion context");

            var pConvertedFrame = (FFmpegNative.AVPicture*) FFmpegNative.avcodec_alloc_frame();
            int convertedFrameBufferSize = FFmpegNative.avpicture_get_size(convertToPixFmt, pCodecContext->width, pCodecContext->height);
            var pConvertedFrameBuffer = (byte*) FFmpegNative.av_malloc((uint) convertedFrameBufferSize);
            FFmpegNative.avpicture_fill(pConvertedFrame, pConvertedFrameBuffer, convertToPixFmt, pCodecContext->width, pCodecContext->height);

            FFmpegNative.AVCodec* pCodec = FFmpegNative.avcodec_find_decoder(pCodecContext->codec_id);
            if (pCodec == null)
                throw new Exception("Unsupported codec");

            pCodecContext = FFmpegNative.avcodec_alloc_context3(pCodec);

            if ((pCodec->capabilities & FFmpegNative.CODEC_CAP_TRUNCATED) == FFmpegNative.CODEC_CAP_TRUNCATED)
                pCodecContext->flags |= FFmpegNative.CODEC_FLAG_TRUNCATED;

            if (FFmpegNative.avcodec_open2(pCodecContext, pCodec, null) < 0)
                throw new Exception("Could not open codec");

            FFmpegNative.AVFrame* pDecodedFrame = FFmpegNative.avcodec_alloc_frame();

            var packet = new FFmpegNative.AVPacket();
            FFmpegNative.AVPacket* pPacket = &packet;
            FFmpegNative.av_init_packet(pPacket);

            int frameNumber = 0;
            while (frameNumber < 100)
            {
                Console.WriteLine("frame: {0}", frameNumber);

                if (FFmpegNative.av_read_frame(pFormatContext, pPacket) < 0)
                    throw new Exception("Could not read frame");

                if (pPacket->stream_index != pStream->index)
                    continue;

                int gotPicture = 0;
                int size = FFmpegNative.avcodec_decode_video2(pCodecContext, pDecodedFrame, &gotPicture, pPacket);
                if (size < 0)
                    throw new Exception(string.Format("Error while decoding frame {0}", frameNumber));

                if (gotPicture == 1)
                {
                    byte** src = &pDecodedFrame->data_0;
                    byte** dst = &pConvertedFrame->data_0;
                    FFmpegNative.sws_scale(pConvertContext, src, pDecodedFrame->linesize, 0,
                                           pCodecContext->height, dst, pConvertedFrame->linesize);

                    byte* convertedFrameAddress = pConvertedFrame->data_0;

                    var imageBufferPtr = new IntPtr(convertedFrameAddress);

                    using (var bitmap = new Bitmap(pCodecContext->width, pCodecContext->height, pConvertedFrame->linesize[0], PixelFormat.Format24bppRgb, imageBufferPtr))
                    {
                        bitmap.Save(@"frame.buffer.jpg", ImageFormat.Jpeg);
                    }
                }
                frameNumber++;
            }

            FFmpegNative.av_free(pConvertedFrame);
            FFmpegNative.av_free(pConvertedFrameBuffer);
            FFmpegNative.sws_freeContext(pConvertContext);

            FFmpegNative.av_free(pDecodedFrame);
            FFmpegNative.avcodec_close(pCodecContext);
            FFmpegNative.avformat_close_input(&pFormatContext);
        }
    }
}