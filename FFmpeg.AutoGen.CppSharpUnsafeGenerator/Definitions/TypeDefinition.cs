namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class TypeDefinition
    {
        public string Name { get; set; }
        public bool IsFixed { get; set; }
        public int FixedSize { get; set; }
        public string[] Attributes { get; set; } = {};
    }
}