using System;
using System.IO;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal class Program
{
    internal static void Main(string[] args)
    {
        var options = CliOptions.ParseArgumentsStrict(args);

        if (options.Verbose)
        {
            Console.WriteLine($"Working dir: {Environment.CurrentDirectory}");
            Console.WriteLine($"Output dir: {options.OutputDir}");
            Console.WriteLine($"FFmpeg headers dir: {options.FFmpegIncludesDir}");
            Console.WriteLine($"FFmpeg bin dir: {options.FFmpegBinDir}");
            Console.WriteLine($"Namespace name: {options.Namespace}");
            Console.WriteLine($"Class name: {options.ClassName}");
        }

        var existingInlineFunctions =
            ExistingInlineFunctionsHelper.LoadInlineFunctions(Path.Combine(options.OutputDir, "FFmpeg.functions.inline.g.cs"));

        var exports = FunctionExportHelper.LoadFunctionExports(options.FFmpegBinDir).ToArray();

        var astProcessor = new ASTProcessor
        {
            FunctionExportMap = exports
                .GroupBy(x => x.Name).Select(x => x.First()) // Eliminate duplicated names
                .ToDictionary(x => x.Name)
        };
        astProcessor.IgnoreUnitNames.Add("__NSConstantString_tag");
        astProcessor.TypeAliases.Add("int64_t", typeof(long));
        astProcessor.WellKnownMacros.Add("FFERRTAG", typeof(int));
        astProcessor.WellKnownMacros.Add("MKTAG", typeof(int));
        astProcessor.WellKnownMacros.Add("UINT64_C", typeof(ulong));
        astProcessor.WellKnownMacros.Add("AV_VERSION_INT", typeof(int));
        astProcessor.WellKnownMacros.Add("AV_VERSION", typeof(string));
        astProcessor.WellKnownMacros.Add("_DHUGE_EXP", typeof(int));
        astProcessor.WellKnownMacros.Add("_DMAX", typeof(long));
        astProcessor.WellKnownMacros.Add("_FMAX", typeof(long));
        astProcessor.WellKnownMacros.Add("_LMAX", typeof(long));

        var defines = new[] { "__STDC_CONSTANT_MACROS" };

        var g = new Generator(astProcessor)
        {
            IncludeDirs = new[] { options.FFmpegIncludesDir },
            Defines = defines,
            Exports = exports,
            Namespace = options.Namespace,
            ClassName = options.ClassName,
            ExistingInlineFunctions = existingInlineFunctions,
            SuppressUnmanagedCodeSecurity = options.SuppressUnmanagedCodeSecurity
        };

        Parse(g);

        WriteFFmpegAutoGen(g, options.OutputDir);
        
        var solutionDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../"));

        WriteAbstractions(g, Path.Combine(solutionDir, "FFmpeg.AutoGen.Abstractions/"));

        WriteStaticallyLinkedBindings(g, Path.Combine(solutionDir, "FFmpeg.AutoGen.Bindings.StaticallyLinked/"));
        WriteDynamicallyLinkedBindings(g, Path.Combine(solutionDir, "FFmpeg.AutoGen.Bindings.DynamicallyLinked/"));
    }
    private static void Parse(Generator g)
    {
        // libavutil
        g.Parse("libavutil/avutil.h");
        g.Parse("libavutil/audio_fifo.h");
        g.Parse("libavutil/channel_layout.h");
        g.Parse("libavutil/cpu.h");
        g.Parse("libavutil/file.h");
        g.Parse("libavutil/frame.h");
        g.Parse("libavutil/opt.h");
        g.Parse("libavutil/imgutils.h");
        g.Parse("libavutil/time.h");
        g.Parse("libavutil/timecode.h");
        g.Parse("libavutil/tree.h");
        g.Parse("libavutil/hwcontext.h");
        g.Parse("libavutil/hwcontext_dxva2.h");
        g.Parse("libavutil/hwcontext_d3d11va.h");
        g.Parse("libavutil/hdr_dynamic_metadata.h");
        g.Parse("libavutil/mastering_display_metadata.h");

        // libswresample
        g.Parse("libswresample/swresample.h");

        // libpostproc
        g.Parse("libpostproc/postprocess.h");

        // libswscale
        g.Parse("libswscale/swscale.h");

        // libavcodec
        g.Parse("libavcodec/avcodec.h");
        g.Parse("libavcodec/dxva2.h");
        g.Parse("libavcodec/d3d11va.h");

        // libavformat
        g.Parse("libavformat/avformat.h");

        // libavfilter
        g.Parse("libavfilter/avfilter.h");
        g.Parse("libavfilter/buffersrc.h");
        g.Parse("libavfilter/buffersink.h");

        // libavdevice
        g.Parse("libavdevice/avdevice.h");
    }
    
    private static void WriteFFmpegAutoGen(Generator g, string outputDir)
    {
        g.WriteLibraries(Path.Combine(outputDir, "FFmpeg.libraries.g.cs"));
        g.WriteMacros(Path.Combine(outputDir, "FFmpeg.macros.g.cs"));
        g.WriteEnums(Path.Combine(outputDir, "FFmpeg.enums.g.cs"));
        g.WriteDelegates(Path.Combine(outputDir, "FFmpeg.delegates.g.cs"));
        g.WriteFixedArrays(Path.Combine(outputDir, "FFmpeg.arrays.g.cs"));
        g.WriteStructures(Path.Combine(outputDir, "FFmpeg.structs.g.cs"));
        g.WriteIncompleteStructures(Path.Combine(outputDir, "FFmpeg.structs.incomplete.g.cs"));
        g.WriteExportFunctions(Path.Combine(outputDir, "FFmpeg.functions.export.g.cs"));
        g.WriteInlineFunctions(Path.Combine(outputDir, "FFmpeg.functions.inline.g.cs"));
    }
    private static void WriteAbstractions(Generator g, string outputDir)
    {
        g.WriteMacros(Path.Combine(outputDir, "FFmpeg.macros.g.cs"));
        g.WriteEnums(Path.Combine(outputDir, "FFmpeg.enums.g.cs"));
        g.WriteDelegates(Path.Combine(outputDir, "FFmpeg.delegates.g.cs"));
        g.WriteFixedArrays(Path.Combine(outputDir, "FFmpeg.arrays.g.cs"));
        g.WriteStructures(Path.Combine(outputDir, "FFmpeg.structs.g.cs"));
        g.WriteIncompleteStructures(Path.Combine(outputDir, "FFmpeg.structs.incomplete.g.cs"));
        g.WriteFacadeFunctions(Path.Combine(outputDir, "FFmpeg.functions.g.cs"));
        g.WriteFacadeDelegates(Path.Combine(outputDir, "FFmpeg.functions.delegates.g.cs"));
        g.WriteInlineFunctions(Path.Combine(outputDir, "FFmpeg.functions.inline.g.cs"));
    }
    
    private static void WriteStaticallyLinkedBindings(Generator g, string outputDir)
    {
        g.WriteWriteStaticallyLinkedFunctions(Path.Combine(outputDir, "StaticallyLinkedBindings.g.cs"));
    } 
    
    private static void WriteDynamicallyLinkedBindings(Generator g, string outputDir)
    {
        g.WriteWriteDynamicallyLinkedFunctions(Path.Combine(outputDir, "DynamicallyLinkedBindings.g.cs"));
    }
}
