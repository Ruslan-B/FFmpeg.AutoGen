namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureField : NamedDefinition
    {
        public bool IsFixed { get; set; }
        public long FixedSize { get; set; }
    }
}