using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    /// <summary>
    /// Supports loading functions from native libraries. Provides a more flexible alternative to P/Invoke.
    /// </summary>
    public static class FunctionLoader
    {
        /// <summary>
        /// Attempts to load a native library.
        /// </summary>
        /// <param name="windowsNames">
        /// Possible names of the library on Windows. This can include full paths.
        /// </param>
        /// <param name="linuxNames">
        /// Possible names of the library on Linux.
        /// </param>
        /// <param name="osxNames">
        /// Possible names of the library on macOS.
        /// </param>
        /// <returns>
        /// A handle to the library when found; otherwise, <see cref="IntPtr.Zero"/>.
        /// </returns>
        public static IntPtr LoadNativeLibrary(IEnumerable<string> windowsNames, IEnumerable<string> linuxNames, IEnumerable<string> osxNames)
        {
            IntPtr lib = IntPtr.Zero;

#if NET45
            foreach (var name in windowsNames)
            {
                lib = WindowsNativeMethods.LoadLibrary(name);

                if (lib != IntPtr.Zero)
                {
                    break;
                }
            }
#else
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                foreach (var name in linuxNames)
                {
                    lib = LinuxNativeMethods.dlopen(name, LinuxNativeMethods.RTLD_NOW);

                    if (lib != IntPtr.Zero)
                    {
                        break;
                    }
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                foreach (var name in osxNames)
                {
                    lib = MacNativeMethods.dlopen(name, MacNativeMethods.RTLD_NOW);

                    if (lib != IntPtr.Zero)
                    {
                        break;
                    }
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                foreach (var name in windowsNames)
                {
                    lib = WindowsNativeMethods.LoadLibrary(name);

                    if (lib != IntPtr.Zero)
                    {
                        break;
                    }
                }
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
#endif

            // This function may return a null handle. If it does, individual functions loaded from it will throw a DllNotFoundException,
            // but not until an attempt is made to actually use the function (rather than load it). This matches how PInvokes behave.
            return lib;
        }

        /// <summary>
        /// Creates a delegate which invokes a native function.
        /// </summary>
        /// <typeparam name="T">
        /// The function delegate.
        /// </typeparam>
        /// <param name="nativeLibraryHandle">
        /// The native library which contains the function.
        /// </param>
        /// <param name="functionName">
        /// The name of the function for which to create the delegate.
        /// </param>
        /// <returns>
        /// A new delegate which points to the native function.
        /// </returns>
        internal static T LoadFunctionDelegate<T>(IntPtr nativeLibraryHandle, string functionName, bool throwOnError = true)
            where T : class
        {
            IntPtr ptr = LoadFunctionPointer(nativeLibraryHandle, functionName);

            if (ptr == IntPtr.Zero)
            {
                if (throwOnError)
                {
                    throw new EntryPointNotFoundException($"Could not find the entrypoint for {functionName}");
                }
                else
                {
                    return null;
                }
            }

#if NET45
            return (T)(object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(T));
#else
            return Marshal.GetDelegateForFunctionPointer<T>(ptr);
#endif
        }

        private static IntPtr LoadFunctionPointer(IntPtr nativeLibraryHandle, string functionName)
        {
#if NET45
            return WindowsNativeMethods.GetProcAddress(nativeLibraryHandle, functionName);
#else
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return LinuxNativeMethods.dlsym(nativeLibraryHandle, functionName);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return MacNativeMethods.dlsym(nativeLibraryHandle, functionName);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return WindowsNativeMethods.GetProcAddress(nativeLibraryHandle, functionName);
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
#endif
        }
    }
}