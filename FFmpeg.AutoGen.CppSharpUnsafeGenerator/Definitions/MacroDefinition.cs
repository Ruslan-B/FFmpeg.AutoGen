namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class MacroDefinition : ICanGenerateDefinition
    {
        public string TypeName { get; set; }
        public string Expression { get; set; }
        public object Value { get; set; }
        public bool IsEvaluated { get; set; }
        public bool IsValid { get; set; }
        public string Name { get; set; }
    }
}