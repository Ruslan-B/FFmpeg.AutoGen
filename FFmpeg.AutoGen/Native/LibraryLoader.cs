// Copyright 2018 Baker Hughes. All rights reserved. Company proprietary and confidential.

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native
{
    public delegate PlatformID GetPlatformId();

    public delegate string GetNativeLibraryName(string libraryName, int version);

    public static class LibraryLoader
    {
        static LibraryLoader()
        {
            GetPlatformId = () =>
            {
#if NET45
                return Environment.OSVersion.Platform;
#else
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return PlatformID.Win32NT;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return PlatformID.Unix;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return PlatformID.MacOSX;
                throw new PlatformNotSupportedException();
#endif
            };

            GetNativeLibraryName = (libraryName, version) =>
            {
                switch (GetPlatformId())
                {
                    case PlatformID.MacOSX:
                        return $"lib{libraryName}.{version}.dylib";
                    case PlatformID.Unix:
                        return $"lib{libraryName}.so.{version}";
                    case PlatformID.Win32NT:
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                        return $"{libraryName}-{version}.dll";
                    default:
                        throw new PlatformNotSupportedException();
                }
            };
        }

        public static GetPlatformId GetPlatformId;

        public static GetNativeLibraryName GetNativeLibraryName;

        /// <summary>
        ///     Attempts to load a native library using platform nammig convention.
        /// </summary>
        /// <param name="path">Path of the library.</param>
        /// <param name="libraryName">Name of the library.</param>
        /// <param name="version">Version of the library.</param>
        /// <returns>
        ///     A handle to the library when found; otherwise, <see cref="IntPtr.Zero" />.
        /// </returns>
        /// <remarks>
        ///     This function may return a null handle. If it does, individual functions loaded from it will throw a
        ///     DllNotFoundException,
        ///     but not until an attempt is made to actually use the function (rather than load it). This matches how PInvokes
        ///     behave.
        /// </remarks>
        public static IntPtr LoadNativeLibrary(string path, string libraryName, int version)
        {
            var nativeLibraryName = GetNativeLibraryName(libraryName, version);
            var fullName = Path.Combine(path, nativeLibraryName);
            return LoadNativeLibrary(fullName);
        }

        /// <summary>
        ///     Attempts to load a native library.
        /// </summary>
        /// <param name="libraryName">Name of the library.</param>
        /// <returns>
        ///     A handle to the library when found; otherwise, <see cref="IntPtr.Zero" />.
        /// </returns>
        /// <remarks>
        ///     This function may return a null handle. If it does, individual functions loaded from it will throw a
        ///     DllNotFoundException,
        ///     but not until an attempt is made to actually use the function (rather than load it). This matches how PInvokes
        ///     behave.
        /// </remarks>
        public static IntPtr LoadNativeLibrary(string libraryName)
        {
            switch (GetPlatformId())
            {
                case PlatformID.MacOSX:
                    return MacNativeMethods.dlopen(libraryName, MacNativeMethods.RTLD_NOW);
                case PlatformID.Unix:
                    return LinuxNativeMethods.dlopen(libraryName, LinuxNativeMethods.RTLD_NOW);
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    return WindowsNativeMethods.LoadLibrary(libraryName);
                default:
                    throw new PlatformNotSupportedException();
            }
        }
    }
}