using System;
using System.Collections.Generic;
using System.Text;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal static class StringHelper
{
    private static readonly HashSet<string> IgnoreWords = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) { "AV", "AVFilter" };

    public static string FindCommonPrefix(this IEnumerable<string> strs)
    {
        ReadOnlySpan<char> common = default;

        foreach (var str in strs)
        {
            if (common.IsEmpty)
            {
                common = str.AsSpan();

                if (common.IsEmpty)
                {
                    break;
                }

                continue;
            }

            int minLength = Math.Min(common.Length, str.Length);
            int commonLength = 0;
            for (; commonLength < minLength; commonLength++)
            {
                if (common[commonLength] != str[commonLength])
                {
                    break;
                }
            }

            common = common.Slice(0, commonLength);

            if (commonLength == 0)
            {
                break;
            }
        }

        return common.Length == 0 ? string.Empty : common.ToString();
    }

    public static string ToCamelCase(this string str)
    {
        int idx;
        var span = str.AsSpan();

        var sb = new StringBuilder(span.Length);
        while (span.Length > 0)
        {
            idx = span.IndexOf('_');
            ReadOnlySpan<char> word;

            if (idx == -1)
            {
                word = span;
                span = default;
            }
            else
            {
                word = span.Slice(0, idx);
                span = span.Slice(idx + 1);
            }

            if (word.Length > 0)
            {
                if (IgnoreWords.TryGetValue(word.ToString(), out string actual))
                {
                    sb.Append(actual);
                }
                else
                {
                    sb.Append(char.ToUpperInvariant(word[0]));
                    sb.Append(word[1..].ToString().ToLowerInvariant());
                }
            }
        }

        return sb.ToString();
    }
}
