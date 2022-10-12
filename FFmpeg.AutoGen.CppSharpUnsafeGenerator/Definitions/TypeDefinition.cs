using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record TypeDefinition : IDefinition
{
    public string[] Attributes { get; init; } = Array.Empty<string>();
    public bool ByReference { get; init; }
    public string Name { get; init; }
    public string LegacyName { get; init; }
}
