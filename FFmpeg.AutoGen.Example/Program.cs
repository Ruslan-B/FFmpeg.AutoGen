using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace FFmpeg.AutoGen.Example
{
	internal class Program
	{
		private static unsafe void Main(string[] args)
		{
            // register LD_LIBRARY_PATH on window 
		    InteropHelper.RegisterLibrariesSearchPath(Environment.GetEnvironmentVariable(InteropHelper.LD_LIBRARY_PATH));

            string url = @"http://www.fileformat.info/format/mpeg/sample/031699cb978244b8a3adf1e81cb2ac7c/download";

			FFmpegInvoke.av_register_all();
			FFmpegInvoke.avcodec_register_all();
			FFmpegInvoke.avformat_network_init();


			AVFormatContext* pFormatContext = FFmpegInvoke.avformat_alloc_context();
			if (FFmpegInvoke.avformat_open_input(&pFormatContext, url, null, null) != 0)
				throw new Exception("Could not open file");

			if (FFmpegInvoke.av_find_stream_info(pFormatContext) != 0)
				throw new Exception("Could not find stream info");

			AVStream* pStream = null;
			for (int i = 0; i < pFormatContext->nb_streams; i++)
			{
				if (pFormatContext->streams[0]->codec->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
				{
					pStream = pFormatContext->streams[0];
					break;
				}
			}
			if (pStream == null)
				throw new Exception("Could not found video stream");

			AVCodecContext codecContext = *(pStream->codec);
			int width = codecContext.width;
			int height = codecContext.height;
			AVPixelFormat sourcePixFmt = codecContext.pix_fmt;
			AVCodecID codecId = codecContext.codec_id;
			var convertToPixFmt = AVPixelFormat.PIX_FMT_BGR24;
			SwsContext* pConvertContext = FFmpegInvoke.sws_getContext(width, height, sourcePixFmt,
			                                                           width, height, convertToPixFmt,
			                                                           FFmpegInvoke.SWS_FAST_BILINEAR, null, null, null);
			if (pConvertContext == null)
				throw new Exception("Could not initialize the conversion context");

			var pConvertedFrame = (AVPicture*)FFmpegInvoke.avcodec_alloc_frame();
			int convertedFrameBufferSize = FFmpegInvoke.avpicture_get_size(convertToPixFmt, width, height);
			var pConvertedFrameBuffer = (byte*)FFmpegInvoke.av_malloc((uint) convertedFrameBufferSize);
			FFmpegInvoke.avpicture_fill(pConvertedFrame, pConvertedFrameBuffer, convertToPixFmt, width, height);

			AVCodec* pCodec = FFmpegInvoke.avcodec_find_decoder(codecId);
			if (pCodec == null)
				throw new Exception("Unsupported codec");

			AVCodecContext* pCodecContext = FFmpegInvoke.avcodec_alloc_context3(pCodec);

			if ((pCodec->capabilities & FFmpegInvoke.CODEC_CAP_TRUNCATED) == FFmpegInvoke.CODEC_CAP_TRUNCATED)
				pCodecContext->flags |= FFmpegInvoke.CODEC_FLAG_TRUNCATED;

			if (FFmpegInvoke.avcodec_open2(pCodecContext, pCodec, null) < 0)
				throw new Exception("Could not open codec");

			AVFrame* pDecodedFrame = FFmpegInvoke.avcodec_alloc_frame();

			var packet = new AVPacket();
			AVPacket* pPacket = &packet;
			FFmpegInvoke.av_init_packet(pPacket);

			int frameNumber = 0;
			while (frameNumber < 100)
			{
				Console.WriteLine("frame: {0}", frameNumber);

				if (FFmpegInvoke.av_read_frame(pFormatContext, pPacket) < 0)
					throw new Exception("Could not read frame");

				if (pPacket->stream_index != pStream->index)
					continue;

				int gotPicture = 0;
				int size = FFmpegInvoke.avcodec_decode_video2(pCodecContext, pDecodedFrame, &gotPicture, pPacket);
				if (size < 0)
					throw new Exception(string.Format("Error while decoding frame {0}", frameNumber));

				if (gotPicture == 1)
				{
					byte** src = &pDecodedFrame->data_0;
					byte** dst = &pConvertedFrame->data_0;
					FFmpegInvoke.sws_scale(pConvertContext, src, pDecodedFrame->linesize, 0,
					                        height, dst, pConvertedFrame->linesize);

					byte* convertedFrameAddress = pConvertedFrame->data_0;

					var imageBufferPtr = new IntPtr(convertedFrameAddress);

					using (var bitmap = new Bitmap(width, height, pConvertedFrame->linesize[0], PixelFormat.Format24bppRgb, imageBufferPtr))
					{
						bitmap.Save(@"frame.buffer.jpg", ImageFormat.Jpeg);
					}
				}
				frameNumber++;
			}

			FFmpegInvoke.av_free(pConvertedFrame);
			FFmpegInvoke.av_free(pConvertedFrameBuffer);
			FFmpegInvoke.sws_freeContext(pConvertContext);

			FFmpegInvoke.av_free(pDecodedFrame);
			FFmpegInvoke.avcodec_close(pCodecContext);
			FFmpegInvoke.avformat_close_input(&pFormatContext);
		}
	}
}