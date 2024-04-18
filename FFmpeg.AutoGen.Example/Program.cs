using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using FFmpeg.AutoGen.Abstractions;
using FFmpeg.AutoGen.Bindings.DynamicallyLoaded;
using SkiaSharp;

namespace FFmpeg.AutoGen.Example;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Current directory: " + Environment.CurrentDirectory);
        Console.WriteLine("Running in {0}-bit mode.", Environment.Is64BitProcess ? "64" : "32");

        FFmpegBinariesHelper.RegisterFFmpegBinaries();
        
        DynamicallyLoadedBindings.Initialize();

        Console.WriteLine($"FFmpeg version info: {ffmpeg.av_version_info()}");

        SetupLogging();
        ConfigureHWDecoder(out var deviceType);

        Directory.CreateDirectory("frames");
        
        Console.WriteLine("Decoding...");
        DecodeAllFramesToImages(deviceType);

        Console.WriteLine("Encoding...");
        EncodeImagesToH264();
    }

    private static void ConfigureHWDecoder(out AVHWDeviceType HWtype)
    {
        HWtype = AVHWDeviceType.AV_HWDEVICE_TYPE_NONE;
        Console.WriteLine("Use hardware acceleration for decoding?[n]");
        var key = Console.ReadLine();
        var availableHWDecoders = new Dictionary<int, AVHWDeviceType>();

        if (key == "y")
        {
            Console.WriteLine("Select hardware decoder:");
            var type = AVHWDeviceType.AV_HWDEVICE_TYPE_NONE;
            var number = 0;

            while ((type = ffmpeg.av_hwdevice_iterate_types(type)) != AVHWDeviceType.AV_HWDEVICE_TYPE_NONE)
            {
                Console.WriteLine($"{++number}. {type}");
                availableHWDecoders.Add(number, type);
            }

            if (availableHWDecoders.Count == 0)
            {
                Console.WriteLine("Your system have no hardware decoders.");
                HWtype = AVHWDeviceType.AV_HWDEVICE_TYPE_NONE;
                return;
            }

            var decoderNumber = availableHWDecoders
                .SingleOrDefault(t => t.Value == AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2).Key;
            if (decoderNumber == 0)
                decoderNumber = availableHWDecoders.First().Key;
            Console.WriteLine($"Selected [{decoderNumber}]");
            int.TryParse(Console.ReadLine(), out var inputDecoderNumber);
            availableHWDecoders.TryGetValue(inputDecoderNumber == 0 ? decoderNumber : inputDecoderNumber,
                out HWtype);
        }
    }

    private static unsafe void SetupLogging()
    {
        ffmpeg.av_log_set_level(ffmpeg.AV_LOG_VERBOSE);

        // do not convert to local function
        av_log_set_callback_callback logCallback = (p0, level, format, vl) =>
        {
            if (level > ffmpeg.av_log_get_level()) return;

            var lineSize = 1024;
            var lineBuffer = stackalloc byte[lineSize];
            var printPrefix = 1;
            ffmpeg.av_log_format_line(p0, level, format, vl, lineBuffer, lineSize, &printPrefix);
            var line = Marshal.PtrToStringAnsi((IntPtr)lineBuffer);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(line);
            Console.ResetColor();
        };

        ffmpeg.av_log_set_callback(logCallback);
    }

    private static unsafe void DecodeAllFramesToImages(AVHWDeviceType HWDevice)
    {
        // decode all frames from url, please not it might local resorce, e.g. string url = "../../sample_mpeg4.mp4";
        
        var url = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"; // be advised this file holds 1440 frames
        using var vsd = new VideoStreamDecoder(url, HWDevice);

        Console.WriteLine($"codec name: {vsd.CodecName}");

        var info = vsd.GetContextInfo();
        info.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

        var sourceSize = vsd.FrameSize;
        var sourcePixelFormat = HWDevice == AVHWDeviceType.AV_HWDEVICE_TYPE_NONE
            ? vsd.PixelFormat
            : GetHWPixelFormat(HWDevice);
        var destinationSize = sourceSize;
        var destinationPixelFormat = AVPixelFormat.@AV_PIX_FMT_BGRA;
        using var vfc = new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat);

        var frameNumber = 0;

        while (vsd.TryDecodeNextFrame(out var frame))
        {
            var convertedFrame = vfc.Convert(frame);
            WriteFrame(convertedFrame, frameNumber);

            Console.WriteLine($"frame: {frameNumber}");
            frameNumber++;
            if (frameNumber > 1000) break;
        }
    }

    private static AVPixelFormat GetHWPixelFormat(AVHWDeviceType hWDevice)
    {
        return hWDevice switch
        {
            AVHWDeviceType.AV_HWDEVICE_TYPE_NONE => AVPixelFormat.AV_PIX_FMT_NONE,
            AVHWDeviceType.AV_HWDEVICE_TYPE_VDPAU => AVPixelFormat.AV_PIX_FMT_VDPAU,
            AVHWDeviceType.AV_HWDEVICE_TYPE_CUDA => AVPixelFormat.AV_PIX_FMT_CUDA,
            AVHWDeviceType.AV_HWDEVICE_TYPE_VAAPI => AVPixelFormat.AV_PIX_FMT_VAAPI,
            AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2 => AVPixelFormat.AV_PIX_FMT_NV12,
            AVHWDeviceType.AV_HWDEVICE_TYPE_QSV => AVPixelFormat.AV_PIX_FMT_QSV,
            AVHWDeviceType.AV_HWDEVICE_TYPE_VIDEOTOOLBOX => AVPixelFormat.AV_PIX_FMT_VIDEOTOOLBOX,
            AVHWDeviceType.AV_HWDEVICE_TYPE_D3D11VA => AVPixelFormat.AV_PIX_FMT_NV12,
            AVHWDeviceType.AV_HWDEVICE_TYPE_DRM => AVPixelFormat.AV_PIX_FMT_DRM_PRIME,
            AVHWDeviceType.AV_HWDEVICE_TYPE_OPENCL => AVPixelFormat.AV_PIX_FMT_OPENCL,
            AVHWDeviceType.AV_HWDEVICE_TYPE_MEDIACODEC => AVPixelFormat.AV_PIX_FMT_MEDIACODEC,
            _ => AVPixelFormat.AV_PIX_FMT_NONE
        };
    }

    private static unsafe void EncodeImagesToH264()
    {
        var frameFiles = Directory.GetFiles("./frames", "frame.*.jpg").OrderBy(x => x).ToArray();
        using var fistFrameImage = ReadFrame(frameFiles.First());

        var outputFileName = "frames/out.h264";
        var fps = 25;
        var sourceSize = new Size(fistFrameImage.Width, fistFrameImage.Height);
        var sourcePixelFormat = AVPixelFormat.@AV_PIX_FMT_BGRA;
        var destinationSize = sourceSize;
        var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_YUV420P;
        using var vfc = new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat);

        using var fs = File.Open(outputFileName, FileMode.Create);

        using var vse = new H264VideoStreamEncoder(fs, fps, destinationSize);

        var frameNumber = 0;

        foreach (var frameFile in frameFiles)
        {
            using var bitmap = ReadFrame(frameFile);
            var bitmapData = bitmap.Bytes;
            fixed (byte* pBitmapData = bitmapData)
            {
                var data = new byte_ptr8 { [0] = pBitmapData };
                var linesize = new int8 { [0] = bitmapData.Length / sourceSize.Height };
                var frame = new AVFrame
                {
                    data = data,
                    linesize = linesize,
                    height = sourceSize.Height
                };
                var convertedFrame = vfc.Convert(frame);
                convertedFrame.pts = frameNumber * fps;
                vse.Encode(convertedFrame);
            }

            Console.WriteLine($"frame: {frameNumber}");
            frameNumber++;
        }

        vse.Drain();
    }

    private static unsafe void WriteFrame(AVFrame convertedFrame, int frameNumber)
    {
        var imageInfo = new SKImageInfo(convertedFrame.width, convertedFrame.height, SKColorType.Bgra8888, SKAlphaType.Opaque);
        using var bitmap = new SKBitmap();
        bitmap.InstallPixels(imageInfo, (IntPtr)convertedFrame.data[0]);
        using var stream = File.Create($"frames/frame.{frameNumber:D8}.jpg");
        bitmap.Encode(stream, SKEncodedImageFormat.Jpeg, 90);
    }

    private static unsafe SKBitmap ReadFrame(string frameFile)
    {
        using var codec = SKCodec.Create(frameFile);
        return SKBitmap.Decode(codec);
    }
}
