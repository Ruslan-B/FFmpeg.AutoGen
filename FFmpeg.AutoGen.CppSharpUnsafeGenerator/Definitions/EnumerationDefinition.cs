namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record EnumerationDefinition : NamedDefinition, IDefinition
    {
        public EnumerationItem[] Items { get; set; }
    }
}