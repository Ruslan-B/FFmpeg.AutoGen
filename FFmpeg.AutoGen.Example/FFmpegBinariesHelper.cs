using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Example
{
    public class FFmpegBinariesHelper
    {
        internal static void RegisterFFmpegBinaries()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var probe = Path.Combine("FFmpeg", "bin", Environment.Is64BitProcess ? "x64" : "x86");
                var current = Environment.CurrentDirectory;
                while (current != null)
                {
                    var ffmpegBinaryPath = Path.Combine(current, probe);
                    if (ffmpeg.CanLoadLibraries(LibraryFlags.AVCodec, ffmpegBinaryPath))
                        break;

                    current = Directory.GetParent(current)?.FullName;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                ffmpeg.TrySetRootPath(
                    LibraryFlags.AVCodec,
                    AppDomain.CurrentDomain.BaseDirectory,
                    "/usr/lib",
                    "/lib/x86_64-linux-gnu"
                );
            }
            else
                throw new NotSupportedException(); // fell free add support for platform of your choose
            
            Console.WriteLine($"Root path set to {ffmpeg.RootPath}");
        }
    }
}
