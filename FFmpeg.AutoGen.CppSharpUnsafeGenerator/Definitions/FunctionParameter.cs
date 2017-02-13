namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionParameter : ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public TypeDefinition Type { get; set; }
        public string Content { get; set; }
    }
}