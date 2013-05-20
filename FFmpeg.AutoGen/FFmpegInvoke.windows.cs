using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    partial class FFmpegInvoke
    {
        internal const string LD_LIBRARY_PATH = "LD_LIBRARY_PATH";

        static FFmpegInvoke()
        {
            SetDllDirectoriesOnWindows();
        }

        private static void SetDllDirectoriesOnWindows()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    string path = Environment.GetEnvironmentVariable(LD_LIBRARY_PATH) ?? string.Empty;
                    SetDllDirectories(path);
                    break;
            }
        }

        internal static void SetDllDirectories(string path)
        {
            var parts = path.Split(Path.PathSeparator);
            foreach (string part in parts)
            {
                SetDllDirectory(part);
            }
        }

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);
    }
}

