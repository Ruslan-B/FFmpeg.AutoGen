namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureField : ICanGenerateXmlDoc, IObsoletionAware
    {
        public string Name { get; set; }
        public TypeDefinition FieldType { get; set; }
        public Obsoletion Obsoletion { get; set; }
        public string Content { get; set; }
    }
}