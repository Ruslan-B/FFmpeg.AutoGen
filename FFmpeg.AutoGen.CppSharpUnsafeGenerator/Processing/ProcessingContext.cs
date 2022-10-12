using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal sealed record ProcessingContext
{
    public HashSet<string> IgnoreUnitNames { get; init; } = new();
    public Dictionary<string, TypeOrAlias> TypeAliases { get; init; } = new();
    public Dictionary<string, TypeOrAlias> WellKnownMacros { get; init; } = new();
    public Dictionary<string, string> WellKnownEnumItems { get; init; } = new();
    public Dictionary<string, FunctionExport> FunctionExportMap { get; init; } = new();
    public List<IDefinition> Definitions { get; init; } = new();

    public void AddDefinition(IDefinition definition)
    {
        if (IgnoreUnitNames.Contains(definition.Name)) return;
        var existing = Definitions.FirstOrDefault(x => x.Name == definition.Name);

        if (existing != null)
            Definitions.Remove(existing);

        Definitions.Add(definition);
    }
}
