namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record DelegateDefinition : TypeDefinition, ICanGenerateXmlDoc
    {
        public string FunctionName { get; init; }
        public TypeDefinition ReturnType { get; init; }
        public FunctionParameter[] Parameters { get; init; }
        public string Content { get; set; }
    }
}