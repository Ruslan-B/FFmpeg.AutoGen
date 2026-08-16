using System;
using FFmpeg.AutoGen.Abstractions;

namespace FFmpeg.AutoGen.Example;

/// <summary>
///     Wraps an elementary stream into a container without re-encoding it, which is the
///     muxing side of the API: avformat_alloc_output_context2, avio_open2,
///     avformat_write_header, av_interleaved_write_frame and av_write_trailer.
/// </summary>
/// <remarks>
///     Raw H.264 carries no timestamps, so presentation times are generated from the frame
///     index at a fixed rate and rescaled into whatever time base the muxer settles on.
/// </remarks>
public sealed unsafe class Mp4Muxer : IDisposable
{
    private readonly int _fps;
    private AVFormatContext* _pInputContext;
    private AVFormatContext* _pOutputContext;
    private int _streamIndex;

    public Mp4Muxer(string inputPath, string outputPath, int fps)
    {
        _fps = fps;

        AVFormatContext* pInputContext = null;
        ffmpeg.avformat_open_input(&pInputContext, inputPath, null, null).ThrowExceptionIfError();
        _pInputContext = pInputContext;
        ffmpeg.avformat_find_stream_info(_pInputContext, null).ThrowExceptionIfError();

        AVFormatContext* pOutputContext = null;
        ffmpeg.avformat_alloc_output_context2(&pOutputContext, null, null, outputPath).ThrowExceptionIfError();
        _pOutputContext = pOutputContext;

        var pInputStream = _pInputContext->streams[0];
        var pOutputStream = ffmpeg.avformat_new_stream(_pOutputContext, null);
        if (pOutputStream == null) throw new InvalidOperationException("Could not allocate the output stream.");

        ffmpeg.avcodec_parameters_copy(pOutputStream->codecpar, pInputStream->codecpar).ThrowExceptionIfError();
        pOutputStream->codecpar->codec_tag = 0;
        pOutputStream->time_base = new AVRational { num = 1, den = fps };
        _streamIndex = pOutputStream->index;

        AVIOContext* pIoContext = null;
        ffmpeg.avio_open2(&pIoContext, outputPath, ffmpeg.AVIO_FLAG_WRITE, null, null).ThrowExceptionIfError();
        _pOutputContext->pb = pIoContext;

        // The mov muxer rewinds at trailer time to patch the sizes in moov and mdat, so it
        // needs a seekable sink. A non-seekable one would have to be muxed as fragmented mp4.
        IsSeekable = (_pOutputContext->pb->seekable & ffmpeg.AVIO_SEEKABLE_NORMAL) != 0;
    }

    /// <summary>Whether the muxer can rewind the output to finalise the container in place.</summary>
    public bool IsSeekable { get; }

    public void Dispose()
    {
        if (_pOutputContext != null)
        {
            if (_pOutputContext->pb != null)
            {
                AVIOContext* pIoContext = _pOutputContext->pb;
                ffmpeg.avio_closep(&pIoContext);
                _pOutputContext->pb = null;
            }

            ffmpeg.avformat_free_context(_pOutputContext);
            _pOutputContext = null;
        }

        if (_pInputContext != null)
        {
            AVFormatContext* pInputContext = _pInputContext;
            ffmpeg.avformat_close_input(&pInputContext);
            _pInputContext = null;
        }
    }

    /// <summary>Copies every packet across and finalises the container.</summary>
    /// <returns>The number of packets written.</returns>
    public int Mux()
    {
        ffmpeg.avformat_write_header(_pOutputContext, null).ThrowExceptionIfError();

        // write_header is free to change the time base, so the real one is only known now.
        var sourceTimeBase = new AVRational { num = 1, den = _fps };
        var targetTimeBase = _pOutputContext->streams[_streamIndex]->time_base;

        var pPacket = ffmpeg.av_packet_alloc();
        var packetNumber = 0;

        try
        {
            while (ffmpeg.av_read_frame(_pInputContext, pPacket) >= 0)
            {
                try
                {
                    pPacket->stream_index = _streamIndex;
                    pPacket->pts = pPacket->dts = packetNumber;
                    pPacket->duration = 1;
                    ffmpeg.av_packet_rescale_ts(pPacket, sourceTimeBase, targetTimeBase);
                    pPacket->pos = -1;

                    ffmpeg.av_interleaved_write_frame(_pOutputContext, pPacket).ThrowExceptionIfError();
                    packetNumber++;
                }
                finally
                {
                    ffmpeg.av_packet_unref(pPacket);
                }
            }
        }
        finally
        {
            ffmpeg.av_packet_free(&pPacket);
        }

        ffmpeg.av_write_trailer(_pOutputContext).ThrowExceptionIfError();
        return packetNumber;
    }
}
