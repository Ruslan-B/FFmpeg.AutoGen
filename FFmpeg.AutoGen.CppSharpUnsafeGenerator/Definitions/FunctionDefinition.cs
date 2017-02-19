namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionDefinition : IDefinition, ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public TypeDefinition ReturnType { get; set; }
        public string LibraryName { get; set; }
        public FunctionParameter[] Parameters { get; set; }
        public string Content { get; set; }
        public bool IsObsolete { get; set; }
        public string ObsoleteMessage { get; set; }
    }
}