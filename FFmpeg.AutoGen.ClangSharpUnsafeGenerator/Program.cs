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
                includeDirs: new[]
                {
                    @"FFmpeg/include"
                },
                definitions: new[]
                {
                    "__STDC_CONSTANT_MACROS",
                    "AVCODEC_D3D11VA_H",
                    "AVCODEC_DXVA2_H",
                    "AVCODEC_QSV_H",
                    "AVCODEC_VDA_H",
                    "AVCODEC_VDPAU_H",
                    "AVCODEC_VIDEOTOOLBOX_H",
                    "AVCODEC_XVMC_H"
                },
                @namespace: @"FFmpeg.AutoGen",
                methodClassName: @"ffmpeg",
                exports: exports
            );

            g.Generate(
                inputFiles: new[]
                {
                    @"FFmpeg/include/libavutil/avutil.h",
                    @"FFmpeg/include/libavutil/audio_fifo.h",
                    @"FFmpeg/include/libavutil/channel_layout.h",
                    @"FFmpeg/include/libavutil/cpu.h",
                    @"FFmpeg/include/libavutil/frame.h",
                    @"FFmpeg/include/libavutil/opt.h",
                    @"FFmpeg/include/libavutil/imgutils.h"
                },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avutil.g.cs",
                libraryVarName: @"libavutil", libraryName: @"avutil-55");

            g.Generate(
                inputFiles: new[]
                {
                    @"FFmpeg/include/libavutil/channel_layout.h",
                    @"FFmpeg/include/libswresample/swresample.h",
                },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.swresample.g.cs",
                libraryVarName: @"libswresample", libraryName: @"swresample-2");

            g.Generate(
                inputFiles: new[] {@"FFmpeg/include/libpostproc/postprocess.h"},
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.postprocess.g.cs",
                libraryVarName: @"libpostproc", libraryName: @"postproc-54");

            g.Generate(
                inputFiles: new[] {@"FFmpeg/include/libswscale/swscale.h"},
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.swscale.g.cs",
                libraryVarName: @"libswscale", libraryName: @"swscale-4");


            g.Generate(
                inputFiles: new[] {@"FFmpeg/include/libavcodec/avcodec.h"},
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avcodec.g.cs",
                libraryVarName: @"libavcodec", libraryName: @"avcodec-57");


            g.Generate(
                inputFiles: new[] {@"FFmpeg/include/libavformat/avformat.h"},
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avformat.g.cs",
                libraryVarName: @"libavformat", libraryName: @"avformat-57");

            g.Generate(
                inputFiles: new[]
                {
                    @"FFmpeg/include/libavfilter/avfilter.h",
                    @"FFmpeg/include/libavfilter/buffersrc.h",
                    @"FFmpeg/include/libavfilter/buffersink.h"
                },
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avfilter.g.cs",
                libraryVarName: @"libavfilter", libraryName: @"avfilter-6");

            g.Generate(
                inputFiles: new[] {@"FFmpeg/include/libavdevice/avdevice.h"},
                outputFile: @"./FFmpeg.AutoGen/FFmpeg.avdevice.g.cs",
                libraryVarName: @"libavdevice", libraryName: @"avdevice-57");

            g.OutputStatistic();
        }
    }
}