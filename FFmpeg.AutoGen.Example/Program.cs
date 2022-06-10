using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Current directory: " + Environment.CurrentDirectory);
            Console.WriteLine("Running in {0}-bit mode.", Environment.Is64BitProcess ? "64" : "32");

            FFmpegBinariesHelper.RegisterFFmpegBinaries();

            Console.WriteLine($"FFmpeg version info: {ffmpeg.av_version_info()}");

            Console.WriteLine("SetupLogging...");
            SetupLogging();

            Console.WriteLine("ConfigureHWDecoder...");
            ConfigureHWDecoder(out var deviceType);

            Console.WriteLine("DecodeAllFramesToImages...");
            DecodeAllFramesToImages(deviceType);

            //Console.WriteLine("IterateCodecs...");
            //IterateCodecs();

            Console.WriteLine("EncodeImagesToH264...");
            EncodeImagesToH264();
        }

        private unsafe static void IterateCodecs()
        {
            void* opaque = null;
            AVCodec* codec = null;
            while ((codec = ffmpeg.av_codec_iterate(&opaque)) != null)
            {
                if (codec->type == AVMediaType.AVMEDIA_TYPE_VIDEO &&
                    codec->encode2.Pointer != IntPtr.Zero &&
                    codec->pix_fmts != null)
                {
                    var id = Enum.GetName(codec->id);
                    var name = Marshal.PtrToStringAnsi((IntPtr)codec->name);
                    var long_name = Marshal.PtrToStringAnsi((IntPtr)codec->long_name);

                    Console.WriteLine(id);
                    Console.WriteLine($"\t{name}");
                    Console.WriteLine($"\t{long_name}");

                    int i = 0;
                    AVPixelFormat pix_fmt;
                    while ((pix_fmt = codec->pix_fmts[i++]) != AVPixelFormat.AV_PIX_FMT_NONE)
                        Console.WriteLine($"\t\t{Enum.GetName(pix_fmt)}");

                    var supported_framerates = codec->supported_framerates;
                    LogRationals(supported_framerates, nameof(supported_framerates));
                }
            }
        }

        private static unsafe void LogRationals(AVRational* rationals, string name)
        {
            if (rationals != null)
            {
                Console.Write($"\t\t{name}");
                int i = 0;
                AVRational rational = rationals[i++];
                while (!(rational.num == 0 && rational.den == 0))
                {
                    Console.WriteLine($"\t\t\t[{rational.num} \\ {rational.den}]");
                    rational = rationals[i++];
                }
            }
            else
            {
                Console.WriteLine($"\t\tNo {name}");
            }
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
            var url = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4"; // be advised this file holds 1440 frames
            using var vsd = new VideoStreamDecoder(url, HWDevice);

            Console.WriteLine($"codec name: {vsd.CodecName}");

            var info = vsd.GetContextInfo();
            info.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

            var sourceSize = vsd.FrameSize;
            var sourcePixelFormat = HWDevice == AVHWDeviceType.AV_HWDEVICE_TYPE_NONE
                ? vsd.PixelFormat
                : GetHWPixelFormat(HWDevice);
            var destinationSize = sourceSize;
            var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;
            using var vfc =
                new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat);

            var frameNumber = 0;

            if (!Directory.Exists("./images"))
                Directory.CreateDirectory("./images");

            while (vsd.TryDecodeNextFrame(out var frame))
            {
                var convertedFrame = vfc.Convert(frame);

                using (var bitmap = new Bitmap(convertedFrame.width,
                    convertedFrame.height,
                    convertedFrame.linesize[0],
                    PixelFormat.Format24bppRgb,
                    (IntPtr)convertedFrame.data[0]))
                    bitmap.Save($"./images/frame.{frameNumber:D8}.jpg", ImageFormat.Jpeg);

                Console.WriteLine($"frame: {frameNumber}");
                frameNumber++;
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
            var frameFiles = Directory.GetFiles("./images", "frame.*.jpg").OrderBy(x => x).ToArray();
            var fistFrameImage = Image.FromFile(frameFiles.First());

            var outputFileName = "out.mp4";
            var fps = 24;
            var sourceSize = fistFrameImage.Size;
            var sourcePixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;
            var destinationSize = sourceSize;
            var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_YUV420P;
            using var vfc =
                new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat);

            using var vse = new H264VideoStreamEncoder(outputFileName, fps, destinationSize);

            var frameNumber = 0;
            foreach (var frameFile in frameFiles)
            {
                byte[] bitmapData;

                using (var frameImage = Image.FromFile(frameFile))
                using (var frameBitmap = frameImage is Bitmap bitmap ? bitmap : new Bitmap(frameImage))
                    bitmapData = GetBitmapData(frameBitmap);

                fixed (byte* pBitmapData = bitmapData)
                {
                    var data = new byte_ptrArray8 { [0] = pBitmapData };
                    var linesize = new int_array8 { [0] = bitmapData.Length / sourceSize.Height };
                    var frame = new AVFrame
                    {
                        data = data,
                        linesize = linesize,
                        height = sourceSize.Height
                    };
                    var convertedFrame = vfc.Convert(frame);
                    convertedFrame.pts = frameNumber;
                    convertedFrame.pkt_duration = 1;
                    vse.Encode(&convertedFrame);
                }

                //Console.WriteLine($"frame: {frameNumber}");
                frameNumber++;
            }
        }

        private static byte[] GetBitmapData(Bitmap frameBitmap)
        {
            var bitmapData = frameBitmap.LockBits(new Rectangle(Point.Empty, frameBitmap.Size),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            try
            {
                var length = bitmapData.Stride * bitmapData.Height;
                var data = new byte[length];
                Marshal.Copy(bitmapData.Scan0, data, 0, length);
                return data;
            }
            finally
            {
                frameBitmap.UnlockBits(bitmapData);
            }
        }
    }
}
