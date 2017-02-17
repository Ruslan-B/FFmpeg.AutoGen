namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class DelegateDefinition : NamedDefinition, ICanGenerateDefinition
    {
        public string Name { get; set; }
        public TypeDefinition ReturnType { get; set; }
        public FunctionParameter[] Parameters { get; set; }
        public string Content { get; set; }
    }
}