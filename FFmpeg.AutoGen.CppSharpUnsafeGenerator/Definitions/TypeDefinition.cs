namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record TypeDefinition : IDefinition
    {
        public string[] Attributes { get; init; } = System.Array.Empty<string>();
        public bool ByReference { get; init; }
        public string Name { get; init; }
    }
}