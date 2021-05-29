namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FixedArrayDefinition : TypeDefinition
    {
        public TypeDefinition ElementType { get; init; }
        public int Size { get; init; }
        public bool IsPrimitive { get; init; }
    }
}
