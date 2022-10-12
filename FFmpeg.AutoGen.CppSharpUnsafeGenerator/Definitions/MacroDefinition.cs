namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record MacroDefinition : IDefinition, ICanGenerateXmlDoc
{
    public string Expression { get; set; }
    public string TypeName { get; set; }
    public bool IsValid { get; set; }
    public bool IsConst { get; set; }
    public string Content { get; set; }
    public string Name { get; init; }
}
