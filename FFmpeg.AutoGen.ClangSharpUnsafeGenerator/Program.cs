using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(@"Current directory: " + Environment.CurrentDirectory);


            var exports = FunctionExportHelper.LoadFromFile(@"./ffmpeg/exports.txt");

            var g = new Generator(
                includeDirs: new[] { @"./ffmpeg/include" },
                @namespace: @"FFmpeg.AutoGen",
                methodClassName: @"ffmpeg",
                exports: exports
                );

            g.Generate(
                inputFiles: new[]
                {
                    @"./ffmpeg/include/libavutil/avutil.h",
                    @"./ffmpeg/include/libavutil/audio_fifo.h",
                    @"./ffmpeg/include/libavutil/channel_layout.h",
                    @"./ffmpeg/include/libavutil/cpu.h",
                    @"./ffmpeg/include/libavutil/frame.h",
                    @"./ffmpeg/include/libavutil/opt.h",
                    @"./ffmpeg/include/libavutil/imgutils.h"
                },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avutil.g.cs",
                libraryVarName: @"libavutil", libraryName: @"avutil-55");

            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libswresample/swresample.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.swresample.g.cs",
                libraryVarName: @"libswresample", libraryName: @"swresample-2");

            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libpostproc/postprocess.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.postprocess.g.cs",
                libraryVarName: @"libpostproc", libraryName: @"postproc-54");

            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libswscale/swscale.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.swscale.g.cs",
                libraryVarName: @"libswscale", libraryName: @"swscale-4");


            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libavcodec/avcodec.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avcodec.g.cs",
                libraryVarName: @"libavcodec", libraryName: @"avcodec-57");


            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libavformat/avformat.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avformat.g.cs",
                libraryVarName: @"libavformat", libraryName: @"avformat-57");

            g.Generate(
                inputFiles: new[]
                {
                    @"./ffmpeg/include/libavfilter/avfilter.h",
                    @"./ffmpeg/include/libavfilter/buffersrc.h",
                    @"./ffmpeg/include/libavfilter/buffersink.h"
                },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avfilter.g.cs",
                libraryVarName: @"libavfilter", libraryName: @"avfilter-6");

            g.Generate(
                inputFiles: new[] { @"./ffmpeg/include/libavdevice/avdevice.h" },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avdevice.g.cs",
                libraryVarName: @"libavdevice", libraryName: @"avdevice-57");

            g.OutputStatistic();
        }
    }
}