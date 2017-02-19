namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FixedArrayDefinition : TypeDefinition, IDefinition
    {
        public TypeDefinition ElementType { get; set; }
        public int Size { get; set; }
        public bool IsPrimitive { get; set; }
    }
}