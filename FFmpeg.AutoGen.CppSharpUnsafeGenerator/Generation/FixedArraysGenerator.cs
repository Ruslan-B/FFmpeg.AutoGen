using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class FixedArraysGenerator : GeneratorBase<FixedArrayDefinition>
{
    public FixedArraysGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new FixedArraysGenerator(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
    }

    protected override IEnumerable<FixedArrayDefinition> Query(IEnumerable<FixedArrayDefinition> arrays) =>
        arrays.OrderBy(a => a.Length).ThenBy(a => a.Name);

    protected override void GenerateDefinition(FixedArrayDefinition array)
    {
        var useLegacy = Context.IsLegacyGenerationOn;
        var length = array.Length;
        var elementType = array.ElementType;
        var elementTypeName = ParametersHelper.GetTypeName(elementType, useLegacy);
        var arrayName = useLegacy ? array.LegacyName : array.Name;

        WriteLine(array.IsPointer ? $"public unsafe struct {arrayName} : IFixedArray" : $"public unsafe struct {arrayName} : IFixedArray<{elementTypeName}>");

        using (BeginBlock())
        {
            var lengthPropertyName = useLegacy ? "Size" : "ArrayLength";
            WriteLine($"public static readonly int {lengthPropertyName} = {length};");
            WriteLine($"public int Length => {length};");

            if (array.IsPrimitive) WritePrimitiveFixedArray(elementTypeName, length);
            else WriteComplexFixedArray(elementTypeName, length);

            WriteLine($"public static implicit operator {elementTypeName}[]({arrayName} @struct) => @struct.ToArray();");
        }

        WriteLine();
    }


    private void WritePrimitiveFixedArray(string elementType, int length)
    {
        WriteLine($"fixed {elementType} _[{length}];");
        WriteLine();

        WriteLine($"public {elementType} this[uint i]");

        using (BeginBlock())
        {
            WriteLine("get => _[i];");
            WriteLine("set => _[i] = value;");
        }

        WriteLine($"public {elementType}[] ToArray()");
        using (BeginBlock())
            WriteLine($"var a = new {elementType}[{length}]; for (uint i = 0; i < {length}; i++) a[i] = _[i]; return a;");

        WriteLine($"public void UpdateFrom({elementType}[] array)");
        using (BeginBlock())
            WriteLine($"uint i = 0; foreach(var value in array) {{ _[i++] = value; if (i >= {length}) return; }}");
    }

    private void WriteComplexFixedArray(string elementType, int length)
    {
        WriteLine(string.Join(" ", Enumerable.Range(0, length).Select(i => $"{elementType} _{i};")));
        WriteLine();
        
        var @fixed = $"fixed ({elementType}* p0 = &_0)";
        WriteLine($"public {elementType} this[uint i]");

        using (BeginBlock())
        {
            WriteLine($"get {{ if (i >= {length}) throw new ArgumentOutOfRangeException(); {@fixed} {{ return *(p0 + i); }} }}");
            WriteLine($"set {{ if (i >= {length}) throw new ArgumentOutOfRangeException(); {@fixed} {{ *(p0 + i) = value;  }} }}");
        }

        WriteLine($"public {elementType}[] ToArray()");
        using (BeginBlock())
            WriteLine($"{@fixed} {{ var a = new {elementType}[{length}]; for (uint i = 0; i < {length}; i++) a[i] = *(p0 + i); return a; }}");

        WriteLine($"public void UpdateFrom({elementType}[] array)");
        using (BeginBlock())
            WriteLine($"{@fixed} {{ uint i = 0; foreach(var value in array) {{ *(p0 + i++) = value; if (i >= {length}) return; }} }}");
    }
}
