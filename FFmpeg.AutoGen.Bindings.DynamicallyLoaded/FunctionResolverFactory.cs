using FFmpeg.AutoGen.Bindings.DynamicallyLoaded.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static class FunctionResolverFactory
{
    public static PlatformID GetPlatformId()
    {
        // Every shipped target framework has RuntimeInformation, and Environment.OSVersion
        // never reports PlatformID.MacOSX on .NET Core, so there is nothing to fall back to.
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return PlatformID.Win32NT;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return PlatformID.MacOSX;
        return PlatformID.Unix; // Android, iOS, and other Unix-like platforms
    }

    public static IFunctionResolver Create()
    {
        switch (GetPlatformId())
        {
            case PlatformID.MacOSX:
                return new MacFunctionResolver();
            case PlatformID.Unix:
                return new LinuxFunctionResolver();
            case PlatformID.Win32NT:
                return new WindowsFunctionResolver();
            default:
                return new LinuxFunctionResolver();
        }
    }
}
