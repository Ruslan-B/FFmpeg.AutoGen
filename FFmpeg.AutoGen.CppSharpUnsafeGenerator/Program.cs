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
            "__STDC_CONSTANT_MACROS"
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
                ClassName = ClassName
            };

            g.Parse("libavutil/avutil.h",
                "libavutil/audio_fifo.h",
                "libavutil/channel_layout.h",
                "libavutil/cpu.h",
                "libavutil/frame.h",
                "libavutil/opt.h",
                "libavutil/imgutils.h",
                "libavutil/timecode.h",
                "libavutil/hwcontext.h",
                "libavutil/hwcontext_dxva2.h"
                //"libavutil/hwcontext_qsv.h",
            );

            g.Parse("libswresample/swresample.h");

            g.Parse("libpostproc/postprocess.h");

            g.Parse("libswscale/swscale.h");

            g.Parse("libavcodec/avcodec.h",
                "libavcodec/dxva2.h",
                "libavcodec/d3d11va.h");

            g.Parse("libavformat/avformat.h");

            g.Parse("libavfilter/avfilter.h",
                "libavfilter/buffersrc.h",
                "libavfilter/buffersink.h");

            g.Parse("libavdevice/avdevice.h");

            g.WriteMacros(OutputDirectory + "FFmpeg.macros.g.cs");
            g.WriteEnums(OutputDirectory + "FFmpeg.enums.g.cs");
            g.WriteDelegates(OutputDirectory + "FFmpeg.delegates.g.cs");
            g.WriteArrays(OutputDirectory + "FFmpeg.arrays.g.cs");
            g.WriteStructures(OutputDirectory + "FFmpeg.structs.g.cs");
            g.WriteIncompleteStructures(OutputDirectory + "FFmpeg.structs.incomplete.g.cs");
            g.WriteFunctions(OutputDirectory + "FFmpeg.functions.g.cs");
        }
    }
}