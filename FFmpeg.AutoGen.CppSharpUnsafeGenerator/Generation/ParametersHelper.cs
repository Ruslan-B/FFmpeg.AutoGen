using System.Linq;
using System.Text;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal static class ParametersHelper
{
    public static string GetTypeName(TypeDefinition type, bool useLegacy) => useLegacy ? type.LegacyName ?? type.Name : type.Name;

    public static string GetParameters(FunctionParameter[] parameters, bool useLegacy, bool withAttributes = true)
    {
        return string.Join(", ", parameters.Select(GetParameter));

        string GetParameter(FunctionParameter parameter)
        {
            var sb = new StringBuilder();
            if (withAttributes && parameter.Type.Attributes.Length > 0) sb.Append($"{string.Join("", parameter.Type.Attributes)} ");
            if (parameter.IsConstant) sb.Append("in ");
            if (parameter.ByReference) sb.Append("ref ");
            sb.Append($"{GetTypeName(parameter.Type, useLegacy)} @{parameter.Name}");
            return sb.ToString();
        }
    }


    public static string GetParameterNames(FunctionParameter[] parameters)
    {
        return string.Join(", ",
            parameters.Select(x =>
            {
                var sb = new StringBuilder();
                if (x.ByReference) sb.Append("ref ");
                sb.Append($"@{x.Name}");
                return sb.ToString();
            }));
    }
}
