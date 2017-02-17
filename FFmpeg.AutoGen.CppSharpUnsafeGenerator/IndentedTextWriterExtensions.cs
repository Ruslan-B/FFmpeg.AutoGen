using System;
using System.CodeDom.Compiler;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    public static class IndentedTextWriterExtensions
    {

        public static IDisposable BeginBlock(this IndentedTextWriter @this)
        {
            @this.WriteLine("{");
            @this.Indent++;
            return new Disposable(() =>
            {
                @this.Indent--;
                @this.WriteLine("}");

            });
        }

        private class Disposable : IDisposable
        {
            private readonly Action _action;

            public Disposable(Action action)
            {
                _action = action;
            }

            public void Dispose() => _action();
        }
           
    }
}