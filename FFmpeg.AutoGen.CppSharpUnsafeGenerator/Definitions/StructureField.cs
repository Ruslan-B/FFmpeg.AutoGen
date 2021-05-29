namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureField : ICanGenerateXmlDoc, IObsoletionAware
    {
        public string Name { get; init; }
        public TypeDefinition FieldType { get; init; }
        public string Content { get; init; }
        public Obsoletion Obsoletion { get; init; }
    }
}
