using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record DelegateDefinition : TypeDefinition
{
    public string FunctionName { get; init; }
    public TypeDefinition ReturnType { get; init; }
    public FunctionParameter[] Parameters { get; init; } = Array.Empty<FunctionParameter>();
}
