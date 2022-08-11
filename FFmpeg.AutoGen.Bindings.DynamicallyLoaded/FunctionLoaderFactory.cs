using FFmpeg.AutoGen.Bindings.DynamicallyLoaded.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static class FunctionLoaderFactory
{
    public static PlatformID GetPlatformId()
    {
#if NETSTANDARD2_0_OR_GREATER
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return PlatformID.Win32NT;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return PlatformID.MacOSX;
        throw new PlatformNotSupportedException();
#else
        return Environment.OSVersion.Platform;

#endif
    }

    public static IFunctionLocator Create()
    {
        switch (GetPlatformId())
        {
            case PlatformID.MacOSX:
                return new MacFunctionLocator();
            case PlatformID.Unix:
                return new LinuxFunctionLocator();
            case PlatformID.Win32NT:
                return new WindowsFunctionLocator();
            default:
                throw new PlatformNotSupportedException();
        }
    }
}
