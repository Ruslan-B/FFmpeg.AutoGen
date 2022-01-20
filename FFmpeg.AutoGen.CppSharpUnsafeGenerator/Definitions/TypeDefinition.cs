namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal class TypeDefinition : IDefinition
{
    public string[] Attributes { get; init; } = { };
    public bool ByReference { get; init; }
    public string Name { get; init; }
}
