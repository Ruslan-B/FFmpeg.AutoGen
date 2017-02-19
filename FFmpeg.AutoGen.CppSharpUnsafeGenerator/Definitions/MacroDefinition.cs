namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class MacroDefinition : IDefinition
    {
        public string TypeName { get; set; }
        public string Expression { get; set; }
        public bool IsValid { get; set; }
        public string Name { get; set; }
    }
}