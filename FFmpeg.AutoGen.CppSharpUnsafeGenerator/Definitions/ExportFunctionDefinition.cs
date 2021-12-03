namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record ExportFunctionDefinition : FunctionDefinitionBase
    {
        public string LibraryName { get; set; }
        public int LibraryVersion { get; set; }
    }
}