using System.Diagnostics;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

[DebuggerDisplay("{Name}, {LibraryName}-{LibraryVersion}")]
internal record FunctionExport
{
    public string Name { get; init; }
    public string LibraryName { get; init; }
    public int LibraryVersion { get; init; }
}
