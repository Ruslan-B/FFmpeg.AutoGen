using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal abstract class GeneratorBase<TDefinition> : GeneratorBase where TDefinition : IDefinition
{
    protected GeneratorBase(string path, GenerationContext context) : base(path, context)
    {
    }

    protected override void GenerateBody() => GenerateDefinitions(Query(Context.Definitions.OfType<TDefinition>()).ToArray());

    protected virtual IEnumerable<TDefinition> Query(IEnumerable<TDefinition> definitions) => definitions.OrderBy(d => d.Name);

    protected virtual void GenerateDefinitions(TDefinition[] definitions) => definitions.ToList().ForEach(GenerateDefinition);

    protected abstract void GenerateDefinition(TDefinition definition);
}

internal abstract class GeneratorBase : IDisposable
{
    private readonly IndentedTextWriter _indentedTextWriter;
    private readonly StreamWriter _streamWriter;

    protected GeneratorBase(string path, GenerationContext context)
    {
        Context = context;
        var fullPath = Path.Combine(Context.OutputDir, path);
        var outputDir = Path.GetDirectoryName(fullPath);
        if (!Directory.Exists(outputDir)) Directory.CreateDirectory(outputDir);
        _streamWriter = File.CreateText(fullPath);
        _indentedTextWriter = new IndentedTextWriter(_streamWriter);
    }

    protected GenerationContext Context { get; }

    protected bool IsTypeGenerationOn { get; set; }


    void IDisposable.Dispose()
    {
        _streamWriter?.Dispose();
        _indentedTextWriter?.Dispose();
    }

    public virtual IEnumerable<string> Usings() => Array.Empty<string>();

    public virtual void Generate()
    {
        var usings = Usings().ToList();
        usings.ForEach(ns => WriteLine($"using {ns};"));
        if (usings.Count > 0) WriteLine();

        WriteLine($"namespace {Context.Namespace};");
        WriteLine();

        if (IsTypeGenerationOn)
        {
            WriteLine($"public static unsafe partial class {Context.TypeName}");

            using (BeginBlock()) GenerateBody();
        }
        else
            GenerateBody();
    }

    protected abstract void GenerateBody();

    protected internal void Write(string value) => _indentedTextWriter.Write(value);

    protected internal void WriteLine() => _indentedTextWriter.WriteLine();

    protected internal void WriteLine(string line) => _indentedTextWriter.WriteLine(line);

    protected void WriteLineWithoutIntent(string line) => _indentedTextWriter.WriteLineNoTabs(line);

    protected IDisposable BeginBlock(bool inline = false)
    {
        WriteLine("{");
        _indentedTextWriter.Indent++;
        return new Disposable(() =>
        {
            _indentedTextWriter.Indent--;

            if (inline)
                Write("}");
            else
                WriteLine("}");
        });
    }

    private sealed class Disposable : IDisposable
    {
        private readonly Action _action;

        public Disposable(Action action) => _action = action;

        public void Dispose() => _action();
    }
}
