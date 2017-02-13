namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionDefinition : ICanGenerateDefinition, ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public string ReturnTypeName { get; set; }
        public string Content { get; set; }
        public FunctionParameter[] Parameters { get; set; }
    }
}