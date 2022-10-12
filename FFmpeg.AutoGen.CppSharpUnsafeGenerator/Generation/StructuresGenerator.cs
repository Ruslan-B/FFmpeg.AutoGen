using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class StructuresGenerator : GeneratorBase<StructureDefinition>
{
    public StructuresGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new StructuresGenerator(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.InteropServices";
    }

    protected override IEnumerable<StructureDefinition> Query(IEnumerable<StructureDefinition> arrays)
        => arrays.OrderBy(s => s.IsComplete ? 0 : 1).ThenBy(s => s.Name);

    protected override void GenerateDefinition(StructureDefinition structure)
    {
         this.WriteSummary(structure);
        if (!structure.IsComplete) WriteLine("/// <remarks>This struct is incomplete.</remarks>");
        this.WriteObsoletion(structure);
        if (structure.IsUnion) WriteLine("[StructLayout(LayoutKind.Explicit)]");
        WriteLine($"public unsafe partial struct {structure.Name}");

        using (BeginBlock())
            foreach (var field in structure.Fields)
            {
                this.WriteSummary(field);
                this.WriteObsoletion(field);
                if (structure.IsUnion) WriteLine("[FieldOffset(0)]");
                var typeName = ParametersHelper.GetTypeName(field.FieldType, Context.IsLegacyGenerationOn);

                if (!Context.IsLegacyGenerationOn && typeName.Contains("_array"))
                {

                }
                WriteLine($"public {typeName} @{field.Name};");
            }

        WriteLine();
    }
}
