using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record EnumerationDefinition : NamedDefinition, IDefinition
{
    public EnumerationItem[] Items { get; init; } = Array.Empty<EnumerationItem>();

    /// <summary>The members describe a bitmask rather than a sequence, so the enum gets [Flags].</summary>
    public bool IsFlags { get; init; }
}
