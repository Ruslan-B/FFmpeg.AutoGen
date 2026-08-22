using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

/// <summary>
///     Reports FFmpeg headers the parser never saw. The list in <see cref="Program" /> names entry
///     points, not files: clang follows the includes, so a root brings its whole closure along. What
///     it cannot bring is a leaf nothing includes - most of libavutil is like that, and a new one
///     arriving with an FFmpeg release is otherwise only noticed when somebody asks for it.
/// </summary>
internal static partial class HeaderCoverage
{
    // Headers a public FFmpeg header may include without anything being installed.
    private static readonly HashSet<string> CStandardLibrary = new(StringComparer.OrdinalIgnoreCase)
    {
        "assert.h", "errno.h", "float.h", "inttypes.h", "limits.h", "math.h", "stdarg.h", "stdbool.h",
        "stddef.h", "stdint.h", "stdio.h", "stdlib.h", "string.h", "time.h", "wchar.h"
    };

    [GeneratedRegex(@"^\s*#\s*include\s+<(?<header>[^>]+)>", RegexOptions.Multiline)]
    private static partial Regex AngledInclude();

    public static void Report(string includesDir, IEnumerable<string> parsedFilePaths)
    {
        var parsed = new HashSet<string>(
            parsedFilePaths.Where(x => !string.IsNullOrEmpty(x)).Select(Path.GetFullPath),
            StringComparer.OrdinalIgnoreCase);

        var unparsed = Directory
            .EnumerateFiles(includesDir, "*.h", SearchOption.AllDirectories)
            .Select(Path.GetFullPath)
            .Where(x => !parsed.Contains(x))
            .OrderBy(x => x, StringComparer.Ordinal)
            .ToArray();

        if (unparsed.Length == 0) return;

        var groups = unparsed.ToLookup(x => ExternalIncludes(x).Length > 0);
        var selfContained = groups[false].ToArray();
        var needsSdk = groups[true].ToArray();

        Console.WriteLine();
        Console.WriteLine($"{unparsed.Length} header(s) under {includesDir} were never parsed.");

        if (needsSdk.Length > 0)
        {
            Console.WriteLine($"  {needsSdk.Length} need headers this build does not have, so they cannot be added as they are:");
            foreach (var path in needsSdk)
                Console.WriteLine($"    {Relative(includesDir, path)} <- {string.Join(", ", ExternalIncludes(path))}");
        }

        if (selfContained.Length > 0)
        {
            Console.WriteLine($"  {selfContained.Length} include nothing beyond FFmpeg and the C standard library, so adding");
            Console.WriteLine($"  any of them to the list in Program.Parse would bind it:");
            foreach (var path in selfContained)
                Console.WriteLine($"    {Relative(includesDir, path)}");
        }

        Console.WriteLine();
    }

    private static string[] ExternalIncludes(string path)
        => AngledInclude()
            .Matches(File.ReadAllText(path))
            .Select(x => x.Groups["header"].Value)
            .Where(x => !CStandardLibrary.Contains(x) && !x.StartsWith("lib", StringComparison.OrdinalIgnoreCase))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(x => x, StringComparer.Ordinal)
            .ToArray();

    private static string Relative(string includesDir, string path)
        => Path.GetRelativePath(includesDir, path).Replace(Path.DirectorySeparatorChar, '/');
}
