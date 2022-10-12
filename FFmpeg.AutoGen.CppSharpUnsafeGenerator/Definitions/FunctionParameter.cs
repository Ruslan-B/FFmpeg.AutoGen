namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record FunctionParameter : ICanGenerateXmlDoc
{
    public string Name { get; init; }
    public TypeDefinition Type { get; init; }
    public string Content { get; init; }
    public bool IsConstant { get; init; }
    public bool IsIndirect { get; init; }
    public bool ByReference { get; init; }
}
