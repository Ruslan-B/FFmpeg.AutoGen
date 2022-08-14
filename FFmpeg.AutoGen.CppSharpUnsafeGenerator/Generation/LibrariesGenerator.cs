using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class LibrariesGenerator : GeneratorBase
{
    private LibrariesGenerator(string path, GenerationContext context) : base(path, context) => IsTypeGenerationOn = true;

    public static void Generate(string path, GenerationContext options)
    {
        using var g = new LibrariesGenerator(path, options);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System.Collections.Generic";
    }

    protected override void GenerateBody()
    {
        WriteLine("public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>");

        using (BeginBlock(true))
            foreach (var pair in Context.LibraryVersionMap.OrderBy(x => x.Key))
                WriteLine($"{{\"{pair.Key}\", {pair.Value}}},");

        WriteLine(";");
    }
}
