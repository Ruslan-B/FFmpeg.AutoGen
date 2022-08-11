using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal class Generator
{
    private readonly GenerationContext _context;

    public Generator(GenerationContext context) => _context = context;

    public void WriteExportFunctions(string outputFile)
    {
        WriteInternal(outputFile,
            (units, writer) =>
            {
                writer.WriteLine($"public unsafe static partial class {_context.TypeName}");
                using var _ = writer.BeginBlock();
                writer.WriteLine("private const string PlatformNotSupportedMessageFormat = \"{0} is not supported on this platform.\";");
                writer.WriteLine();
                units.OfType<ExportFunctionDefinition>()
                    .OrderBy(x => x.LibraryName)
                    .ThenBy(x => x.Name)
                    .ToList()
                    .ForEach(x =>
                    {
                        writer.WriteFunction(x);
                        writer.WriteLine();
                    });
            });
    }

    private void WriteInternal(string outputFile, Action<IReadOnlyList<IDefinition>, Writer> execute)
    {
        using var streamWriter = File.CreateText(outputFile);
        using var textWriter = new IndentedTextWriter(streamWriter);
        var writer = new Writer(textWriter)
        {
            SuppressUnmanagedCodeSecurity = _context.SuppressUnmanagedCodeSecurity
        };
        writer.WriteLine("using System;");
        writer.WriteLine("using System.Runtime.InteropServices;");
        if (_context.SuppressUnmanagedCodeSecurity) writer.WriteLine("using System.Security;");
        writer.WriteLine();
        writer.WriteLine($"namespace {_context.Namespace};");
        writer.WriteLine();
        execute(_context.Definitions, writer);
    }
}
