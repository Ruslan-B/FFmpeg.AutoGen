namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class DelegateDefinition : TypeDefinition, IDefinition, ICanGenerateXmlDoc
    {
        public string FunctionName { get; set; }
        public TypeDefinition ReturnType { get; set; }
        public FunctionParameter[] Parameters { get; set; }
        public string Content { get; set; }
    }
}