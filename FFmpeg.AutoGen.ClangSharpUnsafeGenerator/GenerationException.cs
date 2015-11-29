using System;

namespace FFmpeg.AutoGen.ClangSharpUnsafeGenerator
{
    internal class GenerationException : Exception
    {
        public GenerationException(string message) : base(message)
        {   
        }
    }
}