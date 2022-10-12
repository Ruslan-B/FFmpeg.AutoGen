using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record FunctionDefinitionBase : IDefinition, ICanGenerateXmlDoc, IObsoletionAware
{
    public TypeDefinition ReturnType { get; set; }
    public FunctionParameter[] Parameters { get; set; } = Array.Empty<FunctionParameter>();
    public string ReturnComment { get; set; }
    public string Content { get; set; }
    public string Name { get; set; }
    public Obsoletion Obsoletion { get; set; }
}
