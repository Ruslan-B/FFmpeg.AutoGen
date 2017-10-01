namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class MacroDefinition : IDefinition, ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public string Expression { get; set; }
        public string TypeName { get; set; }
        public bool IsValid { get; set; }
        public bool IsConst { get; set; }
        public string Content { get; set; }
    }
}