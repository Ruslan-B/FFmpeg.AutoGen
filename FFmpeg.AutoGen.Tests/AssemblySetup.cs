using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Tests
{
    [SetUpFixture]
    public class AssemblySetup
    {
        [OneTimeSetUp]
        public void Setup()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                ffmpeg.TrySetRootPath(
                    LibraryFlags.AVCodec,
                    AppDomain.CurrentDomain.BaseDirectory,
                    "/usr/lib",
                    "/lib/x86_64-linux-gnu"
                );
            }
        }
    }
}
