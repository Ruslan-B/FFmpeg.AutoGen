using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class MacrosGenerator : GeneratorBase<MacroDefinition>
{
    public MacrosGenerator(string path, GenerationContext context) : base(path, context) => IsTypeGenerationOn = true;

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new MacrosGenerator(path, context);
        g.Generate();
    }

    protected override void GenerateDefinition(MacroDefinition @enum)
    {
        if (@enum.IsValid)
        {
            this.WriteSummary(@enum);
            var constOrStatic = @enum.IsConst ? "const" : "static readonly";
            WriteLine($"public {constOrStatic} {@enum.TypeName} {@enum.Name} = {@enum.Expression};");
        }
        else
            WriteLine($"// public static {@enum.Name} = {@enum.Expression};");
    }
}
