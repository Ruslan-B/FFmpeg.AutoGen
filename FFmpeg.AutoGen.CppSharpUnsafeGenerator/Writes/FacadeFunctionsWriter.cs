using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Writes
{
    internal sealed class FacadeFunctionsWriter : Writer
    {
        public FacadeFunctionsWriter(IndentedTextWriter writer) : base(writer)
        {
        }
    }
}
