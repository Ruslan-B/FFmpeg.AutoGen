using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Writer
    {
        private readonly IndentedTextWriter _writer;

        public Writer(IndentedTextWriter writer) => _writer = writer;

        public bool SuppressUnmanagedCodeSecurity { get; init; }

        public void WriteMacro(MacroDefinition macro)
        {
            if (macro.IsValid)
            {
                WriteSummary(macro);
                var constOrStatic = macro.IsConst ? "const" : "static readonly";
                WriteLine($"public {constOrStatic} {macro.TypeName} {macro.Name} = {macro.Expression};");
            }
            else
                WriteLine($"// public static {macro.Name} = {macro.Expression};");
        }

        private HashSet<string> _csharpKeywords = ("abstract,as,base,bool,break,byte,case," +
                    "catch,char,checked,class,const,continue,decimal,default,delegate,do," +
                    "double,else,enum,event,explicit,extern,false,finally,fixed,float,for," +
                    "foreach,goto,if,implicit,in,int,interface,internal,is,lock,long,namespace," +
                    "new,null,object,operator,out,override,params,private,protected,public," +
                    "readonly,ref,return,sbyte,sealed,short,sizeof,stackalloc,static,string," +
                    "struct,switch,this,throw,true,try,typeof,uint,ulong,unchecked,unsafe," +
                    "ushort,using,virtual,void,volatile,while").Split(',').ToHashSet();
        private bool IsCSharpKeyword(string key) => _csharpKeywords.Contains(key);

        public void WriteEnumeration(EnumerationDefinition enumeration)
        {
            WriteSummary(enumeration);
            WriteObsoletion(enumeration);
            WriteLine($"public enum {enumeration.Name} : {enumeration.TypeName}");

            using (BeginBlock())
            {
                string commonPrefix = CommonPrefixOf(enumeration.Items.Select(i => i.Name));

                foreach (var item in enumeration.Items)
                {
                    WriteSummary(item);
                    string key = string.Concat(item.Name.Substring(commonPrefix.Length)
                        .Split('_')
                        .Select(x => x switch
                        {
                            var _ when char.IsDigit(x[0]) => $"_{x}", 
                            _ => char.ToUpper(x[0]) + x[1..].ToLower(), 
                        }));
                    string prefix = IsCSharpKeyword(key) ? "@" : "";
                    WriteLine($"{prefix}{key} = {item.Value},");
                }
            }
        }

        public static string CommonPrefixOf(IEnumerable<string> strings)
        {
            string commonPrefix = strings.FirstOrDefault() ?? "";

            foreach (var s in strings)
            {
                var potentialMatchLength = Math.Min(s.Length, commonPrefix.Length);

                if (potentialMatchLength < commonPrefix.Length)
                    commonPrefix = commonPrefix.Substring(0, potentialMatchLength);

                for (var i = 0; i < potentialMatchLength; i++)
                {
                    if (s[i] != commonPrefix[i])
                    {
                        commonPrefix = commonPrefix.Substring(0, i);
                        break;
                    }
                }
            }

            return commonPrefix;
        }

        public void WriteStructure(StructureDefinition structure)
        {
            WriteSummary(structure);
            if (!structure.IsComplete) WriteLine("/// <remarks>This struct is incomplete.</remarks>");
            WriteObsoletion(structure);
            if (structure.IsUnion) WriteLine("[StructLayout(LayoutKind.Explicit)]");
            WriteLine($"public unsafe struct {structure.Name}");

            using (BeginBlock())
                foreach (var field in structure.Fields)
                {
                    WriteSummary(field);
                    WriteObsoletion(field);
                    if (structure.IsUnion) WriteLine("[FieldOffset(0)]");
                    WriteLine($"public {field.FieldType.Name} @{field.Name};");
                }
        }

        public void WriteFixedArray(FixedArrayDefinition array)
        {
            WriteLine($"public unsafe struct {array.Name}");
            using var _ = BeginBlock();
            var prefix = "_";
            var size = array.Size;
            var elementType = array.ElementType.Name;

            WriteLine($"public const int Size = {size};");

            if (array.IsPrimitive) WritePrimitiveFixedArray(array.Name, elementType, size, prefix);
            else WriteComplexFixedArray(elementType, size, prefix);
        }

        public void WriteFunction(ExportFunctionDefinition function)
        {
            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteObsoletion(function);
            if (SuppressUnmanagedCodeSecurity)
                WriteLine("[SuppressUnmanagedCodeSecurity]");

            WriteLine($"[DllImport(\"{function.LibraryName}-{function.LibraryVersion}\", EntryPoint = \"{function.Name}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameters = GetParameters(function.Parameters);
            WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({parameters});");
        }

        public void WriteFunction(InlineFunctionDefinition function)
        {
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameters = GetParameters(function.Parameters);

            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteReturnComment(function.ReturnComment);

            WriteObsoletion(function);
            WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");

            var lines = function.Body.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines.ForEach(WriteLineWithoutIntent);
            WriteLine($"// original body hash: {function.OriginalBodyHash}");
            WriteLine();
        }


        private void WriteDefaultFunctionDelegateExpression(ExportFunctionDefinition function,
            string parameterNames, string functionDelegateName, string functionPtrName, string returnCommand)
        {
            var delegateParameters = GetParameters(function.Parameters, false);

            WriteLine($"({delegateParameters}) =>");

            using (BeginBlock(true))
            {
                var getOrLoadLibrary = $"GetOrLoadLibrary(\"{function.LibraryName}\")";
                var getDelegate = $"GetFunctionDelegate<{functionDelegateName}>({getOrLoadLibrary}, \"{function.Name}\")";

                WriteLine($"{functionPtrName} = {getDelegate};");
                WriteLine($"if ({functionPtrName} == null)");

                using (BeginBlock())
                {
                    Write($"{functionPtrName} = ");
                    WriteNotSupportedFunctionDelegateExpression(function);
                    WriteLine(";");
                }

                WriteLine($"{returnCommand}{functionPtrName}({parameterNames});");
            }
        }

        private void WriteNotSupportedFunctionDelegateExpression(ExportFunctionDefinition function)
        {
            WriteLine("delegate ");
            using var _ = BeginBlock(true);
            WriteLine($"throw new PlatformNotSupportedException(string.Format(PlatformNotSupportedMessageFormat, \"{function.Name}\"));");
        }

        public void WriteDelegate(DelegateDefinition @delegate)
        {
            WriteSummary(@delegate);
            @delegate.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));

            var parameters = GetParameters(@delegate.Parameters);
            WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]");
            WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.FunctionName} ({parameters});");

            WriteLine($"public unsafe struct {@delegate.Name}");
            using var _ = BeginBlock();
            WriteLine("public IntPtr Pointer;");
            Write($"public static implicit operator {@delegate.Name}({@delegate.FunctionName} func) => ");
            Write($"new {@delegate.Name} {{ Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) }};");
            WriteLine();
        }

        public void WriteLine()
        {
            _writer.WriteLine();
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
        }

        public void WriteLineWithoutIntent(string line)
        {
            _writer.WriteLineNoTabs(line);
        }

        public IDisposable BeginBlock(bool inline = false)
        {
            WriteLine("{");
            _writer.Indent++;
            return new End(() =>
            {
                _writer.Indent--;

                if (inline)
                    _writer.Write("}");
                else
                    _writer.WriteLine("}");
            });
        }

        private void WritePrimitiveFixedArray(string arrayName, string elementType, int size, string prefix)
        {
            WriteLine($"public fixed {elementType} {prefix}[{size}];");
            WriteLine();

            // indexer
            WriteLine($"public {elementType} this[uint i]");
            using (BeginBlock())
            {
                string outOfRange = $"throw new ArgumentOutOfRangeException($\"i({{i}}) should < {{Size}}\")";

                WriteLine($"get => i switch");
                using (BeginBlock(inline: true))
                {
                    WriteLine($"< Size => {prefix}[i],");
                    WriteLine($"_ => {outOfRange},");
                }
                WriteLine(";");

                WriteLine($"set => {prefix}[i] = i switch");
                using (BeginBlock(inline: true))
                {
                    WriteLine("< Size => value,");
                    WriteLine($"_ => {outOfRange},");
                }
                WriteLine(";");
            }
            WriteLine();

            // ToArray
            if (size <= 64)
            {
                string seq = string.Join(", ", Enumerable.Range(0, size).Select(i => $"{prefix}[{i}]"));
                WriteLine($"public {elementType}[] ToArray() => new [] {{ {seq} }};");
                WriteLine();
            }
            else
            {
                var @fixed = $"fixed ({arrayName}* p = &this)";
                WriteLine($"public {elementType}[] ToArray()");
                using (BeginBlock())
                {
                    WriteLine(@fixed);
                    using (BeginBlock())
                    {
                        WriteLine($"var a = new {elementType}[Size];");
                        WriteLine($"for (uint i = 0; i < Size; i++)");
                        using (BeginBlock())
                        {
                            WriteLine($"a[i] = p->{prefix}[i];");
                        }
                        WriteLine("return a;");
                    }

                }
            }
            WriteLine();

            // UpdateFrom
            WriteLine($"public void UpdateFrom({elementType}[] array)");
            using (BeginBlock())
            {
                WriteLine("if (array.Length != Size)");
                using (BeginBlock())
                {
                    WriteLine($"throw new ArgumentOutOfRangeException($\"array size({{array.Length}}) should == {{Size}}\");");
                }
                WriteLine();

                WriteLine($"fixed ({elementType}* p = array)");
                using (BeginBlock())
                {
                    if (size <= 64)
                    {
                        for (int i = 0; i < size; ++i)
                        {
                            WriteLine($"{prefix}[{i}] = p[{i}];");
                        }
                    }
                    else
                    {
                        WriteLine($"for (int i = 0; i < Size; ++i)");
                        using (BeginBlock())
                        {
                            WriteLine($"{prefix}[i] = p[i];");
                        }
                    }
                }
            }
        }

        private void WriteComplexFixedArray(string elementType, int size, string prefix)
        {
            string seq = string.Join(", ", Enumerable.Range(0, size).Select(i => prefix + i));
            WriteLine($"public {elementType} {seq};");
            WriteLine();

            // indexer
            WriteLine($"public {elementType} this[uint i]");
            using (BeginBlock())
            {
                var @fixed = $"fixed ({elementType}* p0 = &{prefix}0)";

                WriteLine($"get");
                using (BeginBlock())
                {
                    WriteLine($"if (i >= Size) throw new ArgumentOutOfRangeException($\"i({{i}}) should < {{Size}}\");");
                    WriteLine(@fixed);
                    using (BeginBlock())
                    {
                        WriteLine(@"return *(p0 + i);");
                    }
                }
                WriteLine($"set");
                using (BeginBlock())
                {
                    WriteLine($"if (i >= Size) throw new ArgumentOutOfRangeException($\"i({{i}}) should < {{Size}}\");");
                    WriteLine(@fixed);
                    using (BeginBlock())
                    {
                        WriteLine(@"*(p0 + i) = value;");
                    }
                }
            }
            WriteLine();

            // ToArray
            WriteLine($"public {elementType}[] ToArray() => new [] {{ {seq} }};");
            WriteLine();

            // UpdateFrom
            WriteLine($"public void UpdateFrom({elementType}[] array)");
            using (BeginBlock())
            {
                WriteLine("if (array.Length != Size)");
                using (BeginBlock())
                {
                    WriteLine($"throw new ArgumentOutOfRangeException($\"array size({{array.Length}}) should == {{Size}}\");");
                }
                WriteLine();

                WriteLine($"fixed ({elementType}* p = array)");
                using (BeginBlock())
                {
                    for (int i = 0; i < size; ++i)
                    {
                        WriteLine($"{prefix}{i} = p[{i}];");
                    }
                }
            }

            if (elementType == "void*")
            {
                WriteLine();
                WriteLineWithoutIntent("#if NET45_OR_GREATER");
                WriteLine($"public unsafe Span<IntPtr> GetPinnableReference()");
                using (BeginBlock())
                    WriteLine($"fixed (void** p = &_0) return new Span<IntPtr>(p, Size); ");
                WriteLineWithoutIntent("#endif");
            }
            if (elementType == "byte*")
            {
                WriteLine();
                WriteLineWithoutIntent("#if NET45_OR_GREATER");
                WriteLine($"public unsafe Span<IntPtr> GetPinnableReference()");
                using (BeginBlock())
                    WriteLine($"fixed (byte** p = &_0) return new Span<IntPtr>(p, Size); ");
                WriteLineWithoutIntent("#endif");
            }
        }

        private static string GetParameters(FunctionParameter[] parameters, bool withAttributes = true)
        {
            return string.Join(", ",
                parameters.Select(x =>
                {
                    var sb = new StringBuilder();
                    if (withAttributes && x.Type.Attributes.Any()) sb.Append($"{string.Join("", x.Type.Attributes)} ");
                    if (x.Type.ByReference) sb.Append("ref ");
                    sb.Append($"{x.Type.Name} @{x.Name}");
                    return sb.ToString();
                }));
        }

        private static string GetParameterNames(FunctionParameter[] parameters)
        {
            return string.Join(", ",
                parameters.Select(x =>
                {
                    var sb = new StringBuilder();
                    if (x.Type.ByReference) sb.Append("ref ");
                    sb.Append($"@{x.Name}");
                    return sb.ToString();
                }));
        }

        private void WriteSummary(ICanGenerateXmlDoc value)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <summary>{SecurityElement.Escape(value.Content.Trim())}</summary>");
        }

        private void WriteParam(ICanGenerateXmlDoc value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <param name=\"{name}\">{SecurityElement.Escape(value.Content.Trim())}</param>");
        }

        private void WriteReturnComment(string content)
        {
            if (!string.IsNullOrWhiteSpace(content)) WriteLine($"/// <returns>{SecurityElement.Escape(content.Trim())}</returns>");
        }

        private void WriteObsoletion(IObsoletionAware obsoletionAware)
        {
            var obsoletion = obsoletionAware.Obsoletion;
            if (obsoletion.IsObsolete) WriteLine($"[Obsolete(\"{obsoletion.Message}\")]");
        }

        private void Write(string value)
        {
            _writer.Write(value);
        }

        private class End : IDisposable
        {
            private readonly Action _action;

            public End(Action action) => _action = action;

            public void Dispose() => _action();
        }
    }
}