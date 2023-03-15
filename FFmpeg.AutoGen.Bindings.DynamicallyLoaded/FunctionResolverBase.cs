using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public abstract class FunctionResolverBase : IFunctionResolver
{
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

    private readonly Dictionary<string, IntPtr> _loadedLibraries = new();

    private readonly object _syncRoot = new();

    public T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true)
    {
        lock (_syncRoot)
        {
            var nativeLibraryHandle = GetOrLoadLibrary(libraryName, throwOnError);
            var ptr = GetFunctionPointer(nativeLibraryHandle, functionName);

            if (ptr == IntPtr.Zero)
            {
                if (throwOnError) throw new EntryPointNotFoundException($"Could not find the entrypoint for {functionName}.");
                return default;
            }

#if NETSTANDARD2_0_OR_GREATER
            try
            {
                return Marshal.GetDelegateForFunctionPointer<T>(ptr);
            }
            catch (MarshalDirectiveException)
            {
                if (throwOnError)
                    throw;
                return default;
            }
#else
        return (T)(object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(T));
#endif
        }
    }

    protected abstract string GetNativeLibraryName(string libraryName, int version);
    protected abstract IntPtr LoadNativeLibrary(string libraryName);
    protected abstract IntPtr GetFunctionPointer(IntPtr nativeLibraryHandle, string functionName);

    private IntPtr GetOrLoadLibrary(string libraryName, bool throwOnError)
    {
        if (_loadedLibraries.TryGetValue(libraryName, out var ptr)) return ptr;

        lock (_syncRoot)
        {
            if (_loadedLibraries.TryGetValue(libraryName, out ptr)) return ptr;

            var dependencies = LibraryDependenciesMap[libraryName];
            dependencies.Where(n => !_loadedLibraries.ContainsKey(n) && !n.Equals(libraryName))
                .ToList()
                .ForEach(n => GetOrLoadLibrary(n, false));

            var version = DynamicallyLoadedBindings.LibraryVersionMap[libraryName];
            var nativeLibraryName = GetNativeLibraryName(libraryName, version);
            var libraryPath = Path.Combine(DynamicallyLoadedBindings.LibrariesPath, nativeLibraryName);
            ptr = LoadNativeLibrary(libraryPath);

            if (ptr != IntPtr.Zero) _loadedLibraries.Add(libraryName, ptr);
            else if (throwOnError)
                throw new DllNotFoundException(
                    $"Unable to load DLL '{libraryName}.{version} under {DynamicallyLoadedBindings.LibrariesPath}': The specified module could not be found.");

            return ptr;
        }
    }
}
