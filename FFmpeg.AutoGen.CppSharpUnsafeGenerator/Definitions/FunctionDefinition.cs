namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionDefinition : ICanGenerateDefinition, ICanGenerateSummary
    {
        public string Name { get; set; }
        public string ReturnTypeName { get; set; }
        public string Summary { get; set; }
        public FunctionArgument[] Arguments { get; set; }
    }
}