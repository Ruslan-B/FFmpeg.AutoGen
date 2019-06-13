using System;
using System.Collections.Generic;
using FFmpeg.AutoGen.Native;

namespace FFmpeg.AutoGen
{
    public delegate IntPtr GetOrLoadLibrary(string libraryName);

    public static partial class ffmpeg
    {
        public const int EAGAIN = 11;

        public const int ENOMEM = 12;

        public const int EINVAL = 22;

        private static readonly object SyncRoot = new object();

        public static readonly Dictionary<string, List<string>> LibraryDependenciesMap = new Dictionary<string, List<string>>
        {
            {"avcodec", new List<string> {"avutil", "swresample"}},
            {"avdevice", new List<string> {"avcodec", "avfilter", "avformat", "avutil"}},
            {"avfilter", new List<string> {"avcodec", "avformat", "avutil", "postproc", "swresample", "swscale"}},
            {"avformat", new List<string> {"avcodec", "avutil"}},
            {"avutil", new List<string>()},
            {"postproc", new List<string> {"avutil"}},
            {"swresample", new List<string> {"avutil"}},
            {"swscale", new List<string> {"avutil"}}
        };

        static ffmpeg()
        {
            var loadedLibraries = new Dictionary<string, IntPtr>();

            GetOrLoadLibrary = name =>
            {
                if (loadedLibraries.TryGetValue(name, out var ptr)) return ptr;

                lock (SyncRoot)
                {
                    if (loadedLibraries.TryGetValue(name, out ptr)) return ptr;
                    ptr = LoadLibrary(name);
                    loadedLibraries.Add(name, ptr);
                }

                return ptr;
            };
        }

        /// <summary>
        ///     Gets or sets the root path for loading libraries.
        /// </summary>
        /// <value>The root path.</value>
        public static string RootPath { get; set; } = string.Empty;

        public static GetOrLoadLibrary GetOrLoadLibrary { get; set; }

        private static IntPtr LoadLibrary(string libraryName)
        {
            var dependencies = LibraryDependenciesMap[libraryName];
            dependencies.ForEach(x => GetOrLoadLibrary(x));
            var version = LibraryVersionMap[libraryName];
            var ptr = LibraryLoader.LoadNativeLibrary(RootPath, libraryName, version);
            if (ptr == IntPtr.Zero) throw new DllNotFoundException($"Unable to load DLL '{libraryName}.{version}': The specified module could not be found.");
            return ptr;
        }

        public static T GetFunctionDelegate<T>(IntPtr libraryHandle, string functionName)
            => FunctionLoader.GetFunctionDelegate<T>(libraryHandle, functionName);

        public static ulong UINT64_C<T>(T a)
            => Convert.ToUInt64(a);

        public static int AVERROR<T1>(T1 a)
            => -Convert.ToInt32(a);

        public static int MKTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
            => (int) (Convert.ToUInt32(a) | (Convert.ToUInt32(b) << 8) | (Convert.ToUInt32(c) << 16) | (Convert.ToUInt32(d) << 24));

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