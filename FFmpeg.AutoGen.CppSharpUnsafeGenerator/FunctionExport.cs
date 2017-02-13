using System.Diagnostics;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    [DebuggerDisplay("{Name}, {Library}")]
    internal class FunctionExport
    {
        public string Name { get; set; }
        public string Library { get; set; }
    }
}