using System;
using System.Drawing;
using System.IO;
using FFmpeg.AutoGen.Abstractions;

namespace FFmpeg.AutoGen.Example;

public sealed unsafe class H264VideoStreamEncoder : IDisposable
{
    private readonly Size _frameSize;
    private readonly int _linesizeU;
    private readonly int _linesizeV;
    private readonly int _linesizeY;
    private readonly AVCodec* _pCodec;
    private readonly AVCodecContext* _pCodecContext;
    private readonly Stream _stream;
    private readonly int _uSize;
    private readonly int _ySize;

    public H264VideoStreamEncoder(Stream stream, int fps, Size frameSize)
    {
        _stream = stream;
        _frameSize = frameSize;

        var codecId = AVCodecID.AV_CODEC_ID_H264;
        _pCodec = ffmpeg.avcodec_find_encoder(codecId);
        if (_pCodec == null) throw new InvalidOperationException("Codec not found.");

        _pCodecContext = ffmpeg.avcodec_alloc_context3(_pCodec);
        _pCodecContext->width = frameSize.Width;
        _pCodecContext->height = frameSize.Height;
        _pCodecContext->time_base = new AVRational { num = 1, den = fps };
        _pCodecContext->pix_fmt = AVPixelFormat.AV_PIX_FMT_YUV420P;
        ffmpeg.av_opt_set(_pCodecContext->priv_data, "preset", "veryslow", 0);

        ffmpeg.avcodec_open2(_pCodecContext, _pCodec, null).ThrowExceptionIfError();

        _linesizeY = frameSize.Width;
        _linesizeU = frameSize.Width / 2;
        _linesizeV = frameSize.Width / 2;

        _ySize = _linesizeY * frameSize.Height;
        _uSize = _linesizeU * frameSize.Height / 2;
    }

    public void Dispose()
    {
        ffmpeg.avcodec_close(_pCodecContext);
        ffmpeg.av_free(_pCodecContext);
    }

    public void Encode(AVFrame frame)
    {
        if (frame.format != (int)_pCodecContext->pix_fmt)
            throw new ArgumentException("Invalid pixel format.", nameof(frame));
        if (frame.width != _frameSize.Width) throw new ArgumentException("Invalid width.", nameof(frame));
        if (frame.height != _frameSize.Height) throw new ArgumentException("Invalid height.", nameof(frame));
        if (frame.linesize[0] < _linesizeY) throw new ArgumentException("Invalid Y linesize.", nameof(frame));
        if (frame.linesize[1] < _linesizeU) throw new ArgumentException("Invalid U linesize.", nameof(frame));
        if (frame.linesize[2] < _linesizeV) throw new ArgumentException("Invalid V linesize.", nameof(frame));
        if (frame.data[1] - frame.data[0] < _ySize)
            throw new ArgumentException("Invalid Y data size.", nameof(frame));
        if (frame.data[2] - frame.data[1] < _uSize)
            throw new ArgumentException("Invalid U data size.", nameof(frame));

        var pPacket = ffmpeg.av_packet_alloc();

        try
        {
            // Basic encoding loop explained: 
            // https://ffmpeg.org/doxygen/4.1/group__lavc__encdec.html

            // Give the encoder a frame to encode
            ffmpeg.avcodec_send_frame(_pCodecContext, &frame).ThrowExceptionIfError();

            // From https://ffmpeg.org/doxygen/4.1/group__lavc__encdec.html:
            // For encoding, call avcodec_receive_packet().  On success, it will return an AVPacket with a compressed frame.
            // Repeat this call until it returns AVERROR(EAGAIN) or an error.
            // The AVERROR(EAGAIN) return value means that new input data is required to return new output.
            // In this case, continue with sending input.
            // For each input frame/packet, the codec will typically return 1 output frame/packet, but it can also be 0 or more than 1.
            bool hasFinishedWithThisFrame;

            do
            {
                // Clear/wipe the receiving packet
                // (not sure if this is needed, since docs for avcoded_receive_packet say that it will call that first-thing
                ffmpeg.av_packet_unref(pPacket);

                // Receive back a packet; there might be 0, 1 or many packets to receive for an input frame.
                var response = ffmpeg.avcodec_receive_packet(_pCodecContext, pPacket);

                bool isPacketValid;

                if (response == 0)
                {
                    // 0 on success; as in, successfully retrieved a packet, and expecting us to retrieve another one.
                    isPacketValid = true;
                    hasFinishedWithThisFrame = false;
                }
                else if (response == ffmpeg.AVERROR(ffmpeg.EAGAIN))
                {
                    // EAGAIN: there's no more output is available in the current state - user must try to send more input
                    isPacketValid = false;
                    hasFinishedWithThisFrame = true;
                }
                else if (response == ffmpeg.AVERROR(ffmpeg.AVERROR_EOF))
                {
                    // EOF: the encoder has been fully flushed, and there will be no more output packets
                    isPacketValid = false;
                    hasFinishedWithThisFrame = true;
                }
                else
                {
                    // AVERROR(EINVAL): codec not opened, or it is a decoder other errors: legitimate encoding errors
                    // , otherwise negative error code:
                    throw new InvalidOperationException($"error from avcodec_receive_packet: {response}");
                }

                if (isPacketValid)
                {
                    using var packetStream = new UnmanagedMemoryStream(pPacket->data, pPacket->size);
                    packetStream.CopyTo(_stream);
                }
            } while (!hasFinishedWithThisFrame);
        }
        finally
        {
            ffmpeg.av_packet_free(&pPacket);
        }
    }

    public void Drain()
    {
        // From https://ffmpeg.org/doxygen/4.1/group__lavc__encdec.html:
        // End of stream situations. These require "flushing" (aka draining) the codec, as the codec might buffer multiple frames or packets internally for performance or out of necessity (consider B-frames). This is handled as follows:
        // Instead of valid input, send NULL to the avcodec_send_packet() (decoding) or avcodec_send_frame() (encoding) functions. This will enter draining mode.
        // 	Call avcodec_receive_frame() (decoding) or avcodec_receive_packet() (encoding) in a loop until AVERROR_EOF is returned. The functions will not return AVERROR(EAGAIN), unless you forgot to enter draining mode.

        var pPacket = ffmpeg.av_packet_alloc();

        try
        {
            // Send a null frame to enter draining mode
            ffmpeg.avcodec_send_frame(_pCodecContext, null).ThrowExceptionIfError();

            bool hasFinishedDraining;

            do
            {
                // Clear/wipe the receiving packet
                // (not sure if this is needed, since docs for avcoded_receive_packet say that it will call that first-thing
                ffmpeg.av_packet_unref(pPacket);

                var response = ffmpeg.avcodec_receive_packet(_pCodecContext, pPacket);

                bool isPacketValid;

                if (response == 0)
                {
                    // 0 on success; as in, successfully retrieved a packet, and expecting us to retrieve another one.
                    isPacketValid = true;
                    hasFinishedDraining = false;
                }
                else if (response == ffmpeg.AVERROR(ffmpeg.AVERROR_EOF))
                {
                    // EOF: the encoder has been fully flushed, and there will be no more output packets
                    isPacketValid = false;
                    hasFinishedDraining = true;
                }
                else
                {
                    // Some other error.
                    // Should probably throw here, but in testing we get error -541478725
                    isPacketValid = false;
                    hasFinishedDraining = true;
                }

                if (isPacketValid)
                {
                    using var packetStream = new UnmanagedMemoryStream(pPacket->data, pPacket->size);
                    packetStream.CopyTo(_stream);
                }
            } while (!hasFinishedDraining);
        }
        finally
        {
            ffmpeg.av_packet_free(&pPacket);
        }
    }
}
