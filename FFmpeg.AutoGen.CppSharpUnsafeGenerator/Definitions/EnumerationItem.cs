namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record EnumerationItem : ICanGenerateXmlDoc
{
    public string Name { get; init; }

    /// <summary>The numeric value, as computed by the compiler. Macro bodies are built from this.</summary>
    public string Value { get; init; }

    /// <summary>
    ///     What the generated C# spells out. Same as <see cref="Value" /> unless the header wrote the
    ///     member as a bit shift, which is kept as-is so the binding reads like the header.
    /// </summary>
    public string Literal { get; init; }

    public string Content { get; set; }
}
