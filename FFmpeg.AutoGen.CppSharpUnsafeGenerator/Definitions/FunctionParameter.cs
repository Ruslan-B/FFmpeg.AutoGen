namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionParameter : ICanGenerateXmlDoc
    {
        public string Name { get; init; }
        public TypeDefinition Type { get; init; }
        public string Content { get; set; }
    }
}
