using System;
using System.IO;

using CommandLine;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    /// <summary>
    /// Command line options.
    /// </summary>
    public class CliOptions
    {
        [Option('n', "namespace", DefaultValue = "FFmpeg.AutoGen",
            HelpText = "The namespace that will contain the generated symbols.")]
        public string Namespace { get; set; }

        [Option('c', "class", DefaultValue = "ffmpeg",
            HelpText = "The name of the class that contains the FFmpeg unmanaged method calls.")]
        public string ClassName { get; set; }

        /// <summary>
        /// See http://ybeernet.blogspot.ro/2011/03/techniques-of-calling-unmanaged-code.html.
        /// </summary>
        [Option('f', "SuppressUnmanagedCodeSecurity",
            HelpText = "Add the [SuppressUnmanagedCodeSecurity] attribute to unmanaged method calls " +
                       "(faster invocation).")]
        public bool SuppressUnmanagedCodeSecurity { get; set; }

        [Option('i', "input", Required = false,
            HelpText = "The path to the directory that contains the FFmpeg header and binary files " +
                       "(must have the default structure).")]
        public string FFmpegDir { get; set; }

        [Option('h', "headers", Required = false,
            HelpText = "The path to the directory that contains the FFmpeg header files.")]
        public string FFmpegIncludesDir { get; set; }

        [Option('b', "bin", Required = false,
            HelpText = "The path to the directory that contains the FFmpeg binaries.")]
        public string FFmpegBinDir { get; set; }

        [Option('o', "output", Required = false,
            HelpText = "The path to the directory where to output the generated files.")]
        public string OutputDir { get; set; }

        [Option('v',
            HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }

        public static CliOptions ParseArgumentsStrict(string[] args)
        {
            var options = new CliOptions();
            Parser.Default.ParseArgumentsStrict(args, options);
            options.Normalize();
            return options;
        }

        private void Normalize()
        {
            // Support for the original path setup
            const string solutionDir = "../../../../";

            if (string.IsNullOrWhiteSpace(FFmpegDir) &&
                string.IsNullOrWhiteSpace(FFmpegIncludesDir) &&
                string.IsNullOrWhiteSpace(FFmpegBinDir))
            {
                FFmpegDir = Path.Combine(solutionDir, "ffmpeg");
            }

            if (string.IsNullOrWhiteSpace(OutputDir))
            {
                OutputDir = Path.Combine(solutionDir, "FFmpeg.AutoGen/");
            }

            // If the FFmpegDir option is specified, it will take precedence
            if (!string.IsNullOrWhiteSpace(FFmpegDir))
            {
                FFmpegIncludesDir = Path.Combine(FFmpegDir, "include");
                FFmpegBinDir = Path.Combine(FFmpegDir, "bin/x64");
                FFmpegDir = null;
            }

            // Fail if required options are not specified
            if (string.IsNullOrWhiteSpace(FFmpegBinDir))
            {
                Console.WriteLine("The path to the directory that contains " +
                                  "the FFmpeg binaries is missing (specify it using -b or --bin).");
                Environment.Exit(1);
            }

            if (string.IsNullOrWhiteSpace(FFmpegIncludesDir))
            {
                Console.WriteLine("The path to the directory that contains " +
                                  "the FFmpeg headers is missing (specify it using -h or --headers).");
                Environment.Exit(1);
            }

            // Check paths exist
            if (!Directory.Exists(FFmpegBinDir))
            {
                Console.WriteLine("The path to the directory that contains " +
                                  "the FFmpeg binaries does not exist.");
                Environment.Exit(1);
            }

            if (!Directory.Exists(FFmpegIncludesDir))
            {
                Console.WriteLine("The path to the directory that contains " +
                                  "the FFmpeg headers does not exist.");
                Environment.Exit(1);
            }

            if (!Directory.Exists(OutputDir))
            {
                Console.WriteLine("The output directory does not exist.");
                Environment.Exit(1);
            }

            // Resolve paths
            FFmpegIncludesDir = Path.GetFullPath(FFmpegIncludesDir);
            FFmpegBinDir = Path.GetFullPath(FFmpegBinDir);
            OutputDir = Path.GetFullPath(OutputDir);
        }
    }
}