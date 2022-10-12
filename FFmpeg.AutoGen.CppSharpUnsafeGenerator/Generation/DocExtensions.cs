using System.Security;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal static class DocExtensions
{
    public static void WriteParam(this GeneratorBase generator, ICanGenerateXmlDoc value, string name)
    {
        var content = value.Content?.Trim();

        if (!string.IsNullOrWhiteSpace(content)) generator.WriteLine($"/// <param name=\"{name}\">{EscapeXmlString(content)}</param>");
    }

    public static void WriteSummary(this GeneratorBase generator, ICanGenerateXmlDoc xmlDoc)
    {
        var content = xmlDoc.Content?.Trim();
        if (!string.IsNullOrWhiteSpace(content)) generator.WriteLine($"/// <summary>{EscapeXmlString(content)}</summary>");
    }

    public static void WriteReturnComment(this GeneratorBase generator, FunctionDefinitionBase function)
    {
        var content = function.ReturnComment?.Trim();
        if (!string.IsNullOrWhiteSpace(content)) generator.WriteLine($"/// <returns>{EscapeXmlString(content)}</returns>");
    }

    public static void WriteObsoletion(this GeneratorBase generator, IObsoletionAware obsoletionAware)
    {
        var obsoletion = obsoletionAware.Obsoletion;
        if (obsoletion.IsObsolete) generator.WriteLine(string.IsNullOrWhiteSpace(obsoletion.Message) ? "[Obsolete()]" : $"[Obsolete(\"{EscapeQuotes(obsoletion.Message)}\")]");
    }

    private static string EscapeXmlString(string content) => SecurityElement.Escape(content);
    private static string EscapeQuotes(string s) => s.Replace("\"", "\\\"");
}
