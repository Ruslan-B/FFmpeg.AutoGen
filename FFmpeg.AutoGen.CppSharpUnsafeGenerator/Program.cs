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
        private static readonly string[] IncludeDirs = { Path.GetFullPath("../../../../ffmpeg/include") };

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

            g.Parse("libavutil/avutil.h");
            g.Parse("libavutil/audio_fifo.h");
            g.Parse("libavutil/channel_layout.h");
            g.Parse("libavutil/cpu.h");
            g.Parse("libavutil/frame.h");
            g.Parse("libavutil/opt.h");
            g.Parse("libavutil/imgutils.h");
            g.Parse("libavutil/timecode.h");
            g.Parse("libavutil/hwcontext.h");
            g.Parse("libavutil/hwcontext_dxva2.h");

            g.Parse("libswresample/swresample.h");

            g.Parse("libpostproc/postprocess.h");

            g.Parse("libswscale/swscale.h");

            g.Parse("libavcodec/avcodec.h");
            g.Parse("libavcodec/dxva2.h");
            g.Parse("libavcodec/d3d11va.h");

            g.Parse("libavformat/avformat.h");

            g.Parse("libavfilter/avfilter.h");
            g.Parse("libavfilter/buffersrc.h");
            g.Parse("libavfilter/buffersink.h");

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