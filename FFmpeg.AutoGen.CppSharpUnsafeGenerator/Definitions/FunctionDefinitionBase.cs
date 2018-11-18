namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionDefinitionBase : IDefinition, ICanGenerateXmlDoc
    {
        public TypeDefinition ReturnType { get; set; }
        public FunctionParameter[] Parameters { get; set; }
        public string ReturnComment { get; set; }
        public bool IsObsolete { get; set; }
        public string ObsoleteMessage { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}