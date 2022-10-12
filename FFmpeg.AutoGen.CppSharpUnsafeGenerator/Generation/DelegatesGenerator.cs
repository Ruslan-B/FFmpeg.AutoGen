using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class DelegatesGenerator : GeneratorBase<DelegateDefinition>
{
    public DelegatesGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new DelegatesGenerator(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.InteropServices";
    }

    protected override void GenerateDefinition(DelegateDefinition @delegate)
    {
        @delegate.Parameters.ToList().ForEach(x => this.WriteParam(x, x.Name));

        var parameters = ParametersHelper.GetParameters(@delegate.Parameters, Context.IsLegacyGenerationOn);
        WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]");
        WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.FunctionName} ({parameters});");

        WriteLine($"public unsafe struct {@delegate.Name}");

        using (BeginBlock())
        {
            WriteLine("public IntPtr Pointer;");
            Write($"public static implicit operator {@delegate.Name}({@delegate.FunctionName} func) => ");
            Write($"new {@delegate.Name} {{ Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) }};");
            WriteLine();
        }

        WriteLine();
    }
}
