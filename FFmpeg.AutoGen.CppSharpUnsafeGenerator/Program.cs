using System;
using System.IO;
using System.Linq;

using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CliOptions options = CliOptions.ParseArgumentsStrict(args);

            if (options.Verbose)
            {
                Console.WriteLine("Working dir: " + Environment.CurrentDirectory);
                Console.WriteLine("Output dir: " + options.OutputDir);
                Console.WriteLine("FFmpeg headers dir: " + options.FFmpegIncludesDir);
                Console.WriteLine("FFmpeg bin dir: " + options.FFmpegBinDir);
                Console.WriteLine("Namespace name: " + options.Namespace);
                Console.WriteLine("Class name: " + options.ClassName);
            }

            var defines = new[] {"__STDC_CONSTANT_MACROS"};

            FunctionExport[] exports = FunctionExportHelper.LoadFunctionExports(options.FFmpegBinDir).ToArray();

            var astProcessor = new ASTProcessor
            {
                FunctionExportMap = exports
                    .GroupBy(x => x.Name).Select(x => x.First())    // Eliminate duplicated names
                    .ToDictionary(x => x.Name)
            };
            astProcessor.IgnoreUnitNames.Add("__NSConstantString_tag");
            astProcessor.TypeAliases.Add("int64_t", typeof(long));
            astProcessor.WellKnownMaros.Add("FFERRTAG", typeof(int));
            astProcessor.WellKnownMaros.Add("MKTAG", typeof(int));
            astProcessor.WellKnownMaros.Add("UINT64_C", typeof(ulong));
            astProcessor.WellKnownMaros.Add("AV_VERSION_INT", typeof(int));
            astProcessor.WellKnownMaros.Add("AV_VERSION", typeof(string));

            var g = new Generator(astProcessor)
            {
                IncludeDirs = new[] {options.FFmpegIncludesDir},
                Defines = defines,
                Exports = exports,
                Namespace = options.Namespace,
                ClassName = options.ClassName,
                SuppressUnmanagedCodeSecurity = options.SuppressUnmanagedCodeSecurity
            };

            g.Parse("libavutil/avutil.h");
            g.Parse("libavutil/audio_fifo.h");
            g.Parse("libavutil/channel_layout.h");
            g.Parse("libavutil/cpu.h");
            g.Parse("libavutil/frame.h");
            g.Parse("libavutil/opt.h");
            g.Parse("libavutil/imgutils.h");
            g.Parse("libavutil/time.h");
            g.Parse("libavutil/timecode.h");
            g.Parse("libavutil/tree.h");
            g.Parse("libavutil/hwcontext.h");
            g.Parse("libavutil/hwcontext_dxva2.h");
            g.Parse("libavutil/hwcontext_d3d11va.h");
            
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

            g.WriteLibraries(Path.Combine(options.OutputDir, "FFmpeg.libraries.g.cs"));
            g.WriteMacros(Path.Combine(options.OutputDir, "FFmpeg.macros.g.cs"));
            g.WriteEnums(Path.Combine(options.OutputDir, "FFmpeg.enums.g.cs"));
            g.WriteDelegates(Path.Combine(options.OutputDir, "FFmpeg.delegates.g.cs"));
            g.WriteArrays(Path.Combine(options.OutputDir, "FFmpeg.arrays.g.cs"));
            g.WriteStructures(Path.Combine(options.OutputDir, "FFmpeg.structs.g.cs"));
            g.WriteIncompleteStructures(Path.Combine(options.OutputDir, "FFmpeg.structs.incomplete.g.cs"));
            g.WriteExportFunctions(Path.Combine(options.OutputDir, "FFmpeg.functions.export.g.cs"));
            g.WriteInlineFunctions(Path.Combine(options.OutputDir, "FFmpeg.functions.inline.g.cs"));
        }
    }
}