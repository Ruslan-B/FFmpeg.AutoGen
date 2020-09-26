namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class NamedDefinition : ICanGenerateXmlDoc, IObsoletionAware
    {
        public string Name { get; set; }
        public string TypeName { get; set; }
        public string Content { get; set; }
        public Obsoletion Obsoletion { get; set; }
    }
}