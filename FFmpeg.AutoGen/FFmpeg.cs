using System;
using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.Native;

namespace FFmpeg.AutoGen
{
    public delegate IntPtr GetOrLoadLibrary(string libraryName);

    public static partial class ffmpeg
    {
        public static readonly int EAGAIN;

        public static readonly int ENOMEM = 12;

        public static readonly int EINVAL = 22;

        private static readonly object SyncRoot = new();

        public static readonly Dictionary<string, string[]> LibraryDependenciesMap =
            new()
            {
                { "avcodec", new[] { "avutil", "swresample" } },
                { "avdevice", new[] { "avcodec", "avfilter", "avformat", "avutil" } },
                { "avfilter", new[] { "avcodec", "avformat", "avutil", "postproc", "swresample", "swscale" } },
                { "avformat", new[] { "avcodec", "avutil" } },
                { "avutil", new string[0] },
                { "postproc", new[] { "avutil" } },
                { "swresample", new[] { "avutil" } },
                { "swscale", new[] { "avutil" } }
            };

        public static readonly Dictionary<string, IntPtr> LoadedLibraries = new();

        static ffmpeg()
        {
            GetOrLoadLibrary = libraryName => LoadLibrary(libraryName, true);

            EAGAIN = LibraryLoader.GetPlatformId() switch
            {
                PlatformID.MacOSX => 35,
                _ => 11
            };
        }

        /// <summary>
        ///     Gets or sets the root path for loading libraries.
        ///     Work out of box with companion ffmpeg distribution package like FFmpeg.AutoGen.Redist.windows.x64
        /// </summary>
        /// <value>The root path.</value>
        public static string RootPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        public static GetOrLoadLibrary GetOrLoadLibrary { get; set; }

        private static IntPtr LoadLibrary(string libraryName, bool throwException)
        {
            if (LoadedLibraries.TryGetValue(libraryName, out var ptr)) return ptr;

            lock (SyncRoot)
            {
                if (LoadedLibraries.TryGetValue(libraryName, out ptr)) return ptr;

                var dependencies = LibraryDependenciesMap[libraryName];
                dependencies.Where(n => !LoadedLibraries.ContainsKey(n) && !n.Equals(libraryName))
                    .ToList()
                    .ForEach(n => LoadLibrary(n, false));

                var version = LibraryVersionMap[libraryName];
                ptr = LibraryLoader.LoadNativeLibrary(RootPath, libraryName, version);

                if (ptr != IntPtr.Zero) LoadedLibraries.Add(libraryName, ptr);
                else if (throwException)
                {
                    throw new DllNotFoundException(
                        $"Unable to load DLL '{libraryName}.{version} under {RootPath}': The specified module could not be found.");
                }

                return ptr;
            }
        }

        public static T GetFunctionDelegate<T>(IntPtr libraryHandle, string functionName)
            => FunctionLoader.GetFunctionDelegate<T>(libraryHandle, functionName);

        public static ulong UINT64_C<T>(T a)
            => Convert.ToUInt64(a);

        public static int AVERROR<T1>(T1 a)
            => -Convert.ToInt32(a);

        public static int MKTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
            => (int)(Convert.ToUInt32(a) | (Convert.ToUInt32(b) << 8) | (Convert.ToUInt32(c) << 16) |
                      (Convert.ToUInt32(d) << 24));

        public static int FFERRTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
            => -MKTAG(a, b, c, d);

        public static int AV_VERSION_INT<T1, T2, T3>(T1 a, T2 b, T3 c) =>
            (Convert.ToInt32(a) << 16) | (Convert.ToInt32(b) << 8) | Convert.ToInt32(c);

        public static string AV_VERSION_DOT<T1, T2, T3>(T1 a, T2 b, T3 c)
            => $"{a}.{b}.{c}";

        public static string AV_VERSION<T1, T2, T3>(T1 a, T2 b, T3 c)
            => AV_VERSION_DOT(a, b, c);
    }
}