using System;

namespace FFmpeg.AutoGen;

public static partial class ffmpeg
{
    public static readonly int EAGAIN;

    public static readonly int ENOMEM = 12;

    public static readonly int EINVAL = 22;

    public static readonly int EPIPE = 32;
    
    static ffmpeg()
    {
        EAGAIN = FunctionResolverFactory.GetPlatformId() switch
        {
            PlatformID.MacOSX => 35,
            _ => 11
        };

        DynamicallyLoadedBindings.Initialize();
    }


    /// <summary>
    ///     Gets or sets the directory the native FFmpeg libraries are loaded from. Defaults to the
    ///     application's base directory. This project neither builds nor distributes the binaries,
    ///     so they can come from anywhere - a native NuGet package, a system install, or a folder
    ///     the application ships. What has to match is the ABI the bindings were generated against,
    ///     since the libraries are resolved by versioned name.
    /// </summary>
    /// <value>The root path.</value>
    public static string RootPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

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
