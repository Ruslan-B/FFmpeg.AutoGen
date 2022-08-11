using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Security;
using System.Text;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal class Writer
{
    private readonly IndentedTextWriter _writer;

    public Writer(IndentedTextWriter writer) => _writer = writer;

    public bool SuppressUnmanagedCodeSecurity { get; init; }

    public void WriteFunction(ExportFunctionDefinition function)
    {
        var parameterNames = GetParameterNames(function.Parameters);
        var parameters = GetParameters(function.Parameters);
        var functionPtrName = function.Name + "_fptr";
        var functionDelegateName = function.Name + "_delegate";
        var returnCommand = function.ReturnType.Name == "void" ? string.Empty : "return ";

        if (SuppressUnmanagedCodeSecurity) WriteLine("[SuppressUnmanagedCodeSecurity]");
        WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]");
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);
        WriteLine($"private delegate {function.ReturnType.Name} {functionDelegateName}({parameters});");
        Write($"private static {functionDelegateName} {functionPtrName} = ");
        WriteDefaultFunctionDelegateExpression(function, parameterNames, functionDelegateName, functionPtrName, returnCommand);
        WriteLine(";");

        WriteSummary(function);
        function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
        WriteReturnComment(function.ReturnComment);

        WriteObsoletion(function);
        WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");
        using (BeginBlock()) WriteLine($"{returnCommand}{functionPtrName}({parameterNames});");
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

    private static string GetParameters(FunctionParameter[] parameters, bool withAttributes = true)
    {
        return string.Join(", ",
            parameters.Select(x =>
            {
                var sb = new StringBuilder();
                if (withAttributes && x.Type.Attributes.Length > 0) sb.Append($"{string.Join("", x.Type.Attributes)} ");
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
        if (obsoletion.IsObsolete) WriteLine($"[Obsolete(\"{EscapeQuotes(obsoletion.Message)}\")]");
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

    private void Write(string value)
    {
        _writer.Write(value);
    }

    private static string EscapeQuotes(string s) => s.Replace("\"", "\\\"");

    private class End : IDisposable
    {
        private readonly Action _action;

        public End(Action action) => _action = action;

        public void Dispose() => _action();
    }
}
