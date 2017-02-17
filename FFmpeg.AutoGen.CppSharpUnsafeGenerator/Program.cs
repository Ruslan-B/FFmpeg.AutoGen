using System;
using System.IO;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Program
    {
        private static readonly string Namespace = "FFmpeg.AutoGen";
        public static string ClassName = "ffmpeg";
        private static readonly string OutputDirectory = "../../../../FFmpeg.AutoGen/";

        private static readonly FunctionExport[] Exports = FunctionExportHelper.LoadFromFile("../../../../ffmpeg/exports.txt").ToArray();
        private static readonly string[] IncludeDirs = {Path.GetFullPath("../../../../ffmpeg/include")};

        private static readonly string[] Defines =
        {
            "__STDC_CONSTANT_MACROS",
            "AVCODEC_D3D11VA_H",
            "AVCODEC_DXVA2_H",
            "AVCODEC_QSV_H",
            "AVCODEC_VDA_H",
            "AVCODEC_VDPAU_H",
            "AVCODEC_VIDEOTOOLBOX_H",
            "AVCODEC_XVMC_H"
        };

        private static void Main(string[] args)
        {
            Console.WriteLine("Current directory: " + Environment.CurrentDirectory);
            
            var g = new Generator
            {
                IncludeDirs = IncludeDirs,
                Defines = Defines,
                Exports = Exports,
                Namespace = Namespace,
                ClassName = ClassName,
            };

            g.OutputFile = OutputDirectory + "FFmpeg.avutil.g.cs";
            g.SourceFiles = new[]
            {
                "libavutil/avutil.h",
                "libavutil/audio_fifo.h",
                "libavutil/channel_layout.h",
                "libavutil/cpu.h",
                "libavutil/frame.h",
                "libavutil/opt.h",
                "libavutil/imgutils.h",
            };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.swresample.g.cs";
            g.SourceFiles = new[] { "libswresample/swresample.h" };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.postprocess.g.cs";
            g.SourceFiles = new[] {"libpostproc/postprocess.h"};
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.swscale.g.cs";
            g.SourceFiles = new[] { "libswscale/swscale.h" };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.avcodec.g.cs";
            g.SourceFiles = new[] { "libavcodec/avcodec.h" };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.avformat.g.cs";
            g.SourceFiles = new[] { "libavformat/avformat.h" };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.avfilter.g.cs";
            g.SourceFiles = new[]
            {
                "libavfilter/avfilter.h",
                "libavfilter/buffersrc.h",
                "libavfilter/buffersink.h",
            };
            g.Run();

            g.OutputFile = OutputDirectory + "FFmpeg.avdevice.g.cs";
            g.SourceFiles = new[] {"libavdevice/avdevice.h"};
            g.Run();

            //    new Generator
            //    {
            //        IncludeDirs = IncludeDirs,
            //        Defines = Defines,
            //        Exports = Exports,
            //        Namespace = Namespace,
            //        ClassName = ClassName,
            //        LibraryName = "swresample-2",
            //        LibraryConstantName = "libswresample",
            //        OutputFile = OutputDirectory + "FFmpeg.swresample.g.cs",
            //        SourceFiles = new[]
            //        {
            //            @"libswresample/swresample.h"
            //        }
            //    }.Run();
            //}
        }
    }
}