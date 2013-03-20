using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using ffmpeg = FFmpeg.AutoGen.Native;

namespace FFmpeg.AutoGen.Example
{
    internal class Program
    {
        private static unsafe void Main(string[] args)
        {
            //rstp
            string url = @"http://samples.ffmpeg.org/MPEG1/zelda%20first%20commercial.mpeg";

            ffmpeg.av_register_all();
            ffmpeg.avcodec_register_all();
            ffmpeg.avformat_network_init();


            ffmpeg.AVFormatContext* pFormatContext = ffmpeg.avformat_alloc_context();
            if (ffmpeg.avformat_open_input(&pFormatContext, url, null, null) != 0)
                throw new Exception("Could not open file");

            if (ffmpeg.av_find_stream_info(pFormatContext) != 0)
                throw new Exception("Could not find stream info");

            ffmpeg.AVStream* pStream = null;
            for (int i = 0; i < pFormatContext->nb_streams; i++)
            {
                if (pFormatContext->streams[0]->codec->codec_type == ffmpeg.AVMediaType.AVMEDIA_TYPE_VIDEO)
                {
                    pStream = pFormatContext->streams[0];
                    break;
                }   
            }
            if (pStream == null)
                throw new Exception("Could not found video stream");

            ffmpeg.AVCodecContext* pCodecContext = pStream->codec;
            
            var convertToPixFmt = ffmpeg.AVPixelFormat.PIX_FMT_BGR24;
            ffmpeg.SwsContext* pConvertContext = ffmpeg.sws_getContext(pCodecContext->width, pCodecContext->height, pCodecContext->pix_fmt,
                                                                         pCodecContext->width, pCodecContext->height, convertToPixFmt,
                                                                         ffmpeg.SWS_FAST_BILINEAR, null, null, null);
            if (pConvertContext == null)
                throw new Exception("Could not initialize the conversion context");

            var pConvertedFrame = (ffmpeg.AVPicture*) ffmpeg.avcodec_alloc_frame();
            int convertedFrameBufferSize = ffmpeg.avpicture_get_size(convertToPixFmt, pCodecContext->width, pCodecContext->height);
            var pConvertedFrameBuffer = (byte*) ffmpeg.av_malloc((uint) convertedFrameBufferSize);
            ffmpeg.avpicture_fill(pConvertedFrame, pConvertedFrameBuffer, convertToPixFmt, pCodecContext->width, pCodecContext->height);

            ffmpeg.AVCodec* pCodec = ffmpeg.avcodec_find_decoder(pCodecContext->codec_id);
            if (pCodec == null)
                throw new Exception("Unsupported codec");

            pCodecContext = ffmpeg.avcodec_alloc_context3(pCodec);

            if ((pCodec->capabilities & ffmpeg.CODEC_CAP_TRUNCATED) == ffmpeg.CODEC_CAP_TRUNCATED)
                pCodecContext->flags |= ffmpeg.CODEC_FLAG_TRUNCATED;

            if (ffmpeg.avcodec_open2(pCodecContext, pCodec, null) < 0)
                throw new Exception("Could not open codec");

            ffmpeg.AVFrame* pDecodedFrame = ffmpeg.avcodec_alloc_frame();

            var packet = new ffmpeg.AVPacket();
            ffmpeg.AVPacket* pPacket = &packet;
            ffmpeg.av_init_packet(pPacket);

            int frameNumber = 0;
            while (frameNumber < 100)
            {
                Console.WriteLine("frame: {0}", frameNumber);

                if (ffmpeg.av_read_frame(pFormatContext, pPacket) < 0)
                    throw new Exception("Could not read frame");

                if (pPacket->stream_index != pStream->index) 
                    continue;
                
                int gotPicture = 0;
                int size = ffmpeg.avcodec_decode_video2(pCodecContext, pDecodedFrame, &gotPicture, pPacket);
                if (size < 0)
                    throw new Exception(string.Format("Error while decoding frame {0}", frameNumber));

                if (gotPicture == 1)
                {
                    var src = (byte**) (&(*pDecodedFrame).data[0]);
                    var dst = (byte**) (&(*pConvertedFrame).data[0]);
                    ffmpeg.sws_scale(pConvertContext, src, pDecodedFrame->linesize, 0,
                                     pCodecContext->height, dst, pConvertedFrame->linesize);

                    int convertedFrameAddress = pConvertedFrame->data[0];

                    var imageBufferPtr = new IntPtr(convertedFrameAddress);

                    using (var bitmap = new Bitmap(pCodecContext->width, pCodecContext->height, pConvertedFrame->linesize[0], PixelFormat.Format24bppRgb, imageBufferPtr))
                    {
                        bitmap.Save(@"frame.buffer.jpg", ImageFormat.Jpeg);
                    }
                }
                frameNumber++;
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