namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record NamedDefinition : ICanGenerateXmlDoc, IObsoletionAware
{
    public string Name { get; init; }
    public string TypeName { get; init; }
    public string Content { get; set; }
    public Obsoletion Obsoletion { get; init; }
}
