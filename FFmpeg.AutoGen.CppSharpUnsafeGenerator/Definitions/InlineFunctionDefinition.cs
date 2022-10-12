namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record InlineFunctionDefinition : FunctionDefinitionBase
{
    public string Body { get; init; }
    public string OriginalBodyHash { get; init; }
}
