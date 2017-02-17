namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureDefinition : NamedDefinition, ICanGenerateDefinition
    {
        public StructureField[] Fileds { get; set; }
        public StructureIndexer Indexer { get; set; }
    }
}