using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class FunctionsGenerator : GeneratorBase<ExportFunctionDefinition>
{
    public FunctionsGenerator(string fileName, GenerationContext context) : base(fileName, context) => IsTypeGenerationOn = true;

    public bool IsFacadeGenerationOn { get; set; }
    public bool IsVectorsGenerationOn { get; set; }
    public bool IsStaticallyLinkedGenerationOn { get; set; }
    public bool IsDynamicallyLinkedGenerationOn { get; set; }
    public bool IsDynamicallyLoadedGenerationOn { get; set; }

    public static void GenerateFacade(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsFacadeGenerationOn = true;
        g.Generate();
    }

    public static void GenerateVectors(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsVectorsGenerationOn = true;
        g.Generate();
    }


    public static void GenerateStaticallyLinked(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsStaticallyLinkedGenerationOn = true;
        g.Generate();
    }

    public static void GenerateDynamicallyLinked(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsDynamicallyLinkedGenerationOn = true;
        g.Generate();
    }

    public static void GenerateDynamicallyLoaded(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsDynamicallyLoadedGenerationOn = true;
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.InteropServices";
        if (!Context.IsLegacyGenerationOn) yield return "FFmpeg.AutoGen.Abstractions";
    }

    protected override void GenerateDefinitions(ExportFunctionDefinition[] functions)
    {
        if (IsDynamicallyLoadedGenerationOn)
        {
            WriteLine("public static IFunctionLocator FunctionLoader;");
            WriteLine();
        }

        base.GenerateDefinitions(functions);

        if (IsStaticallyLinkedGenerationOn || IsDynamicallyLinkedGenerationOn || IsDynamicallyLoadedGenerationOn)
        {
            WriteLine("public unsafe static void Initialize()");

            using (BeginBlock())
                if (IsDynamicallyLoadedGenerationOn)
                {
                    WriteLine("FunctionLoader = FunctionLoaderFactory.Create();");
                    WriteLine();
                    functions.ToList().ForEach(f => Bind(f));

                    void Bind(ExportFunctionDefinition f)
                    {
                        var parms = ParametersHelper.GetParameters(f.Parameters, Context.IsLegacyGenerationOn, false);
                        var names = ParametersHelper.GetParameterNames(f.Parameters);
                        WriteLine($"vectors.{f.Name} = ({parms}) => {f.Name}({names});");
                    }
                }
                else
                    functions.ToList().ForEach(f => WriteLine($"vectors.{f.Name} = {f.Name};"));
        }
    }

    protected override void GenerateDefinition(ExportFunctionDefinition function)
    {
        if (IsFacadeGenerationOn) GenerateFacadeFunction(function);
        if (IsVectorsGenerationOn) GenerateVector(function);
        if (IsStaticallyLinkedGenerationOn) GenerateDllImport(function, "__Internal");
        if (IsDynamicallyLinkedGenerationOn) GenerateDllImport(function, $"{function.LibraryName}-{function.LibraryVersion}");
        if (IsDynamicallyLoadedGenerationOn) GenerateDynamicallyLoaded(function);
    }

    public void GenerateFacadeFunction(ExportFunctionDefinition function)
    {
        var parameterNames = ParametersHelper.GetParameterNames(function.Parameters);
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
        this.WriteReturnComment(function);
        this.WriteObsoletion(function);
        WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters}) => vectors.{function.Name}({parameterNames});");
        WriteLine();
    }

    public void GenerateVector(ExportFunctionDefinition function)
    {
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);
        var functionDelegateName = $"{function.Name}_delegate";
        WriteLine($"public delegate {function.ReturnType.Name} {functionDelegateName}({parameters});");
        WriteLine($"public static {functionDelegateName} {function.Name};"); // todo => throw new NotSupportedException();");
        WriteLine();
    }

    private void GenerateDllImport(ExportFunctionDefinition function, string libraryName)
    {
        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(x => this.WriteParam(x, x.Name));
        this.WriteReturnComment(function);

        this.WriteObsoletion(function);
        if (Context.SuppressUnmanagedCodeSecurity) WriteLine("[SuppressUnmanagedCodeSecurity]");

        WriteLine($"[DllImport(\"{libraryName}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]");
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);

        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn);
        WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({parameters});");
        WriteLine();
    }

    public void GenerateDynamicallyLoaded(ExportFunctionDefinition function)
    {
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn);
        var functionDelegateName = $"{function.Name}_delegate";

        if (Context.SuppressUnmanagedCodeSecurity) WriteLine("[SuppressUnmanagedCodeSecurity]");
        WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]");
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);
        WriteLine($"public delegate {function.ReturnType.Name} {functionDelegateName}({parameters});");
        Write($"public static {functionDelegateName} {function.Name} = ");
        WriteDefaultFunctionDelegateExpression();
        WriteLine(";");
        WriteLine();

        void WriteDefaultFunctionDelegateExpression()
        {
            var delegateParameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

            WriteLine($"({delegateParameters}) =>");

            using (BeginBlock(true))
            {
                var getDelegate = $"FunctionLoader.GetFunctionDelegate<{functionDelegateName}>(\"{function.LibraryName}\", \"{function.Name}\")";

                WriteLine($"{function.Name} = {getDelegate};");
                WriteLine($"if ({function.Name} == null)");

                using (BeginBlock())
                {
                    Write($"{function.Name} = ");
                    WriteLine("delegate ");
                    using (BeginBlock(true)) WriteLine("throw new NotSupportedException();");
                    WriteLine(";");
                }

                var returnCommand = function.ReturnType.Name == "void" ? string.Empty : "return ";
                var parameterNames = ParametersHelper.GetParameterNames(function.Parameters);
                WriteLine($"{returnCommand}{function.Name}({parameterNames});");
            }
        }
    }
}
