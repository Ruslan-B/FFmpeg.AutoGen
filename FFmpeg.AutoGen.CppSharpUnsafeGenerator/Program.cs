using System;
using System.IO;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Program
    {
        private static readonly string Namespace = "FFmpeg.AutoGen.New";
        public static string ClassName = "ffmpeg";
        private static readonly string OutputDirectory = "../../../../FFmpeg.AutoGen/New/";

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

            //new Generator
            //{
            //    IncludeDirs = IncludeDirs,
            //    Defines = Defines,
            //    Exports = Exports,
            //    Namespace = Namespace,
            //    ClassName = ClassName,
            //    LibraryName = "avutil-55",
            //    LibraryConstantName = "libavutil",
            //    OutputFile = OutputDirectory + "FFmpeg.avutil.g.cs",
            //    SourceFiles = new[]
            //    {
            //        "libavutil/avutil.h",
            //        "libavutil/audio_fifo.h",
            //        "libavutil/channel_layout.h",
            //        "libavutil/cpu.h",
            //        "libavutil/frame.h",
            //        "libavutil/opt.h",
            //        "libavutil/imgutils.h"
            //    }
            //}.Run();

            new Generator
            {
                IncludeDirs = IncludeDirs,
                Defines = Defines,
                Exports = Exports,
                Namespace = Namespace,
                ClassName = ClassName,
                LibraryName = "avutil-55",
                LibraryConstantName = "libavutil",
                OutputFile = OutputDirectory + "FFmpeg.g.cs",
                SourceFiles = new[]
                {
                    //libavutil
                    "libavutil/avutil.h",
                    "libavutil/audio_fifo.h",
                    "libavutil/channel_layout.h",
                    "libavutil/cpu.h",
                    "libavutil/frame.h",
                    "libavutil/opt.h",
                    "libavutil/imgutils.h",
                    //libswresample
                    "libswresample/swresample.h",
                    //libpostproc
                    "libpostproc/postprocess.h",
                    //libswscale
                    "libswscale/swscale.h",
                    //libavcodec
                    "libavcodec/avcodec.h",
                    //libavformat
                    "libavformat/avformat.h",
                    // libavfilter
                    "libavfilter/avfilter.h",
                    "libavfilter/buffersrc.h",
                    "libavfilter/buffersink.h",
                    //libavdevice
                    "libavdevice/avdevice.h"
                }
            }.Run();

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