using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class EnumsGenerator : GeneratorBase<EnumerationDefinition>
{
    public EnumsGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new EnumsGenerator(path, context);
        g.Generate();
    }

    protected override void GenerateDefinition(EnumerationDefinition @enum)
    {
        this.WriteSummary(@enum);
        this.WriteObsoletion(@enum);
        WriteLine($"public enum {@enum.Name} : {@enum.TypeName}");

        using (BeginBlock())
            foreach (var item in @enum.Items)
            {
                this.WriteSummary(item);
                WriteLine($"@{item.Name} = {item.Value},");
            }

        WriteLine();
    }
}
