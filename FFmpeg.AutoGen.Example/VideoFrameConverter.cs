using System;
using System.Drawing;
using System.Runtime.InteropServices;
using FFmpeg.AutoGen.Abstractions;

namespace FFmpeg.AutoGen.Example;

public sealed unsafe class VideoFrameConverter : IDisposable
{
    private readonly IntPtr _convertedFrameBufferPtr;
    private readonly Size _destinationSize;
    private readonly byte_ptr4 _dstData;
    private readonly int4 _dstLinesize;
    private readonly SwsContext* _pConvertContext;

    public VideoFrameConverter(Size sourceSize, AVPixelFormat sourcePixelFormat,
        Size destinationSize, AVPixelFormat destinationPixelFormat)
    {
        _destinationSize = destinationSize;

        _pConvertContext = ffmpeg.sws_getContext(sourceSize.Width,
            sourceSize.Height,
            sourcePixelFormat,
            destinationSize.Width,
            destinationSize.Height,
            destinationPixelFormat,
            ffmpeg.SWS_FAST_BILINEAR,
            null,
            null,
            null);
        if (_pConvertContext == null)
            throw new ApplicationException("Could not initialize the conversion context.");

        var convertedFrameBufferSize = ffmpeg.av_image_get_buffer_size(destinationPixelFormat,
            destinationSize.Width,
            destinationSize.Height,
            1);
        _convertedFrameBufferPtr = Marshal.AllocHGlobal(convertedFrameBufferSize);
        _dstData = new byte_ptr4();
        _dstLinesize = new int4();

        ffmpeg.av_image_fill_arrays(ref _dstData,
            ref _dstLinesize,
            (byte*)_convertedFrameBufferPtr,
            destinationPixelFormat,
            destinationSize.Width,
            destinationSize.Height,
            1);
    }

    public void Dispose()
    {
        Marshal.FreeHGlobal(_convertedFrameBufferPtr);
        ffmpeg.sws_freeContext(_pConvertContext);
    }

    public AVFrame Convert(AVFrame sourceFrame)
    {
        ffmpeg.sws_scale(_pConvertContext,
            sourceFrame.data,
            sourceFrame.linesize,
            0,
            sourceFrame.height,
            _dstData,
            _dstLinesize);

        var data = new byte_ptr8();
        data.UpdateFrom(_dstData);
        var linesize = new int8();
        linesize.UpdateFrom(_dstLinesize);

        return new AVFrame
        {
            data = data,
            linesize = linesize,
            width = _destinationSize.Width,
            height = _destinationSize.Height
        };
    }
}
