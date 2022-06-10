using System;
using System.Drawing;

namespace FFmpeg.AutoGen.Example
{
    public sealed unsafe class H264VideoStreamEncoder : IDisposable
    {
        private readonly Size _frameSize;
        private readonly int _linesizeU;
        private readonly int _linesizeV;
        private readonly int _linesizeY;
        private readonly AVFormatContext* _pFormatContext;
        private readonly AVStream* _pStream;
        private readonly AVCodec* _pCodec;
        private readonly AVCodecContext* _pCodecContext;
        private readonly int _uSize;
        private readonly int _ySize;

        public H264VideoStreamEncoder(string filename, int fps, Size frameSize)
        {
            _frameSize = frameSize;
            _linesizeY = frameSize.Width;
            _linesizeU = frameSize.Width / 2;
            _linesizeV = frameSize.Width / 2;
            _ySize = _linesizeY * frameSize.Height;
            _uSize = _linesizeU * frameSize.Height / 2;

            AVFormatContext* ofmt_ctx_fixed = null;
            ffmpeg.avformat_alloc_output_context2(&ofmt_ctx_fixed, null, null, filename);
            if (ofmt_ctx_fixed == null)
                throw new InvalidOperationException("Could not create output context");
            _pFormatContext = ofmt_ctx_fixed;

            var codecId = AVCodecID.AV_CODEC_ID_H264;
            _pCodec = ffmpeg.avcodec_find_encoder(codecId);
            if (_pCodec == null)
                throw new InvalidOperationException("Codec not found.");

            _pStream = ffmpeg.avformat_new_stream(_pFormatContext, _pCodec);
            if (_pStream == null)
                throw new InvalidOperationException("Failed allocating output stream");

            _pCodecContext = ffmpeg.avcodec_alloc_context3(_pCodec);
            if (_pCodecContext == null)
                throw new InvalidOperationException("Failed to allocate the encoder context");

            _pCodecContext->rc_max_rate = 4000000;
            _pCodecContext->width = frameSize.Width;
            _pCodecContext->height = frameSize.Height;
            _pCodecContext->time_base = new AVRational { num = 1, den = fps };
            _pCodecContext->framerate = new AVRational { num = fps, den = 1 };

            if (_pCodec->pix_fmts != null)
                _pCodecContext->pix_fmt = _pCodec->pix_fmts[0];

            _pCodecContext->slices = 4;
            _pCodecContext->gop_size = 12;
            _pCodecContext->max_b_frames = 2;

            ffmpeg.av_opt_set(_pCodecContext->priv_data, "allow_skip_frames", "1", 0);

            // h264 private settings
            if (codecId == AVCodecID.AV_CODEC_ID_H264)
            {
                ffmpeg.av_opt_set(_pCodecContext->priv_data, "preset", "veryslow", 0);
                //ffmpeg.av_opt_set(_pCodecContext->priv_data, "profile", "high", 0);
            }

            ffmpeg.avcodec_open2(_pCodecContext, _pCodec, null)
                .ThrowExceptionIfError("Cannot open video encoder");

            ffmpeg.avcodec_parameters_from_context(_pStream->codecpar, _pCodecContext)
                .ThrowExceptionIfError("Failed to copy encoder parameters to output stream");

            if ((_pFormatContext->oformat->flags & ffmpeg.AVFMT_GLOBALHEADER) != 0)
                _pCodecContext->flags |= ffmpeg.AV_CODEC_FLAG_GLOBAL_HEADER;

            _pStream->time_base = _pCodecContext->time_base;

            ffmpeg.av_dump_format(_pFormatContext, 0, filename, 1);

            if ((_pFormatContext->oformat->flags & ffmpeg.AVFMT_NOFILE) == 0)
                ffmpeg.avio_open(&_pFormatContext->pb, filename, ffmpeg.AVIO_FLAG_WRITE)
                    .ThrowExceptionIfError($"Could not open output file '{filename}'");

            ffmpeg.avformat_write_header(_pFormatContext, null)
                .ThrowExceptionIfError("Error occurred when writing output header");
        }

        public void Dispose()
        {
            Flush();

            ffmpeg.av_write_trailer(_pFormatContext)
                .ThrowExceptionIfError("Error occurred when writing output trailer");

            ffmpeg.avcodec_close(_pCodecContext);
            ffmpeg.av_free(_pCodecContext);

            if (_pFormatContext != null &&
                (_pFormatContext->oformat->flags & ffmpeg.AVFMT_NOFILE) == 0)
                ffmpeg.avio_closep(&_pFormatContext->pb);
            ffmpeg.avformat_free_context(_pFormatContext);
        }

        public void Flush()
        {
            if ((_pCodec->capabilities & ffmpeg.AV_CODEC_CAP_DELAY) == 0)
                return;

            while (true)
            {
                Console.WriteLine($"Flushing stream encoder");
                if (Encode(null, true) < 0)
                    break;
            }
        }

        public int Encode(AVFrame* frame, bool skipFrameCheck = false)
        {
            if (!skipFrameCheck)
                CheckFrame(frame);

            if (frame != null)
                frame->pts = ffmpeg.av_rescale_q(
                    frame->pts,
                    _pCodecContext->time_base,
                    _pStream->time_base);

            int sndErr, recErr;
            var pPacket = ffmpeg.av_packet_alloc();
            try
            {
                do
                {
                    sndErr = ffmpeg.avcodec_send_frame(_pCodecContext, frame);
                    if (sndErr != ffmpeg.AVERROR_EOF)
                        sndErr.ThrowExceptionIfError();

                    ffmpeg.av_packet_unref(pPacket);

                    recErr = ffmpeg.avcodec_receive_packet(_pCodecContext, pPacket);
                } while (recErr == ffmpeg.AVERROR(ffmpeg.EAGAIN));

                if (recErr != ffmpeg.AVERROR_EOF)
                {
                    recErr.ThrowExceptionIfError("Error receiving encoded frame packet");

                    ////pPacket->duration = 1;
                    ////if (frame != null)
                    ////    pPacket->pts = frame->pts;

                    ffmpeg.av_interleaved_write_frame(_pFormatContext, pPacket)
                        .ThrowExceptionIfError("Error writing encoded frame packet");
                }
            }
            finally
            {
                ffmpeg.av_packet_free(&pPacket);
            }

            return recErr;
        }

        private void CheckFrame(AVFrame* frame)
        {
            if (frame->format != (int)_pCodecContext->pix_fmt)
                throw new ArgumentException("Invalid pixel format.", nameof(frame));
            if (frame->width != _frameSize.Width)
                throw new ArgumentException("Invalid width.", nameof(frame));
            if (frame->height != _frameSize.Height)
                throw new ArgumentException("Invalid height.", nameof(frame));
            if (frame->linesize[0] < _linesizeY)
                throw new ArgumentException("Invalid Y linesize.", nameof(frame));
            if (frame->linesize[1] < _linesizeU)
                throw new ArgumentException("Invalid U linesize.", nameof(frame));
            if (frame->linesize[2] < _linesizeV)
                throw new ArgumentException("Invalid V linesize.", nameof(frame));
            if (frame->data[1] - frame->data[0] < _ySize)
                throw new ArgumentException("Invalid Y data size.", nameof(frame));
            if (frame->data[2] - frame->data[1] < _uSize)
                throw new ArgumentException("Invalid U data size.", nameof(frame));
        }
    }
}
