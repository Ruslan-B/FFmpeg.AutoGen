using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal static class FunctionExportHelper
    {
        private static readonly Regex LibraryRegex = new Regex(@"Section contains the following exports for ([\w-]+).dll", RegexOptions.Compiled);
        private static readonly Regex FunctionRegex = new Regex(@"\d+\s+[a-fA-F0-9]+\s+[a-fA-F0-9]+\s+([\w]+)", RegexOptions.Compiled);

        public static IEnumerable<FunctionExport> LoadFromFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                string library = null;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lMatch = LibraryRegex.Match(line);
                    if (lMatch.Success)
                        library = lMatch.Groups[1].Value;
                    var fMatch = FunctionRegex.Match(line);
                    if (fMatch.Success)
                    {
                        var name = fMatch.Groups[1].Value;
                        yield return new FunctionExport {Name = name, Library = library};
                    }
                }
            }
        }
    }
}