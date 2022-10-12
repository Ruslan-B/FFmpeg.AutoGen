namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record FixedArrayDefinition : TypeDefinition
{
    public TypeDefinition ElementType { get; init; }
    public int Length { get; init; }
    public bool IsPrimitive { get; init; }
    public bool IsPointer { get; init; }
}
