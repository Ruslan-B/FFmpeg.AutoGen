namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureField : ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public TypeDefinition FieldType { get; set; }
        public string Content { get; set; }
        public bool IsObsolete { get; set; }
        public string ObsoleteMessage { get; set; }
    }
}