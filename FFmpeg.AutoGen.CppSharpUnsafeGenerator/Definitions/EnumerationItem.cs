namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record EnumerationItem : ICanGenerateXmlDoc
{
    public string Name { get; init; }
    public string Value { get; init; }
    public string Content { get; set; }
}
