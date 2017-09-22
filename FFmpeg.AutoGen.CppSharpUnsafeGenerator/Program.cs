using System;
using System.IO;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Program
    {
        private const string SolutionDir = "../../../../";
        private const string FfmpegDir = SolutionDir + "ffmpeg/";
        private const string FfmpegBinDir = FfmpegDir + "bin/x64";
        private const string FfmpegIncludeDir = FfmpegDir + "include";
        private const string Namespace = "FFmpeg.AutoGen";
        private const string OutputDir = SolutionDir + "FFmpeg.AutoGen/";
        public static string ClassName = "ffmpeg";

        private static readonly string[] IncludeDirs = {Path.GetFullPath(FfmpegIncludeDir)};
        private static readonly string[] Defines = {"__STDC_CONSTANT_MACROS"};
        private static readonly FunctionExport[] Exports = FunctionExportHelper.LoadFunctionExports(FfmpegBinDir).ToArray();

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

            g.WriteMacros(OutputDir + "FFmpeg.macros.g.cs");
            g.WriteEnums(OutputDir + "FFmpeg.enums.g.cs");
            g.WriteDelegates(OutputDir + "FFmpeg.delegates.g.cs");
            g.WriteArrays(OutputDir + "FFmpeg.arrays.g.cs");
            g.WriteStructures(OutputDir + "FFmpeg.structs.g.cs");
            g.WriteIncompleteStructures(OutputDir + "FFmpeg.structs.incomplete.g.cs");
            g.WriteFunctions(OutputDir + "FFmpeg.functions.g.cs");
        }
    }
}