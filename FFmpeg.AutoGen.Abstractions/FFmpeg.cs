using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Abstractions;

public static partial class ffmpeg
{
    /// <summary>EAGAIN is 35 on Darwin and 11 everywhere else, so it cannot be a constant.</summary>
    public static readonly int EAGAIN = IsDarwin ? 35 : 11;

    // Deliberately not const: these are part of the public surface, and a literal would be
    // baked into every consumer, so an assembly-only upgrade would throw MissingFieldException.
    public static readonly int ENOMEM = 12;

    public static readonly int EINVAL = 22;

    public static readonly int EPIPE = 32;

    private static bool IsDarwin =>
#if NET
        OperatingSystem.IsMacOS() || OperatingSystem.IsIOS() ||
        OperatingSystem.IsTvOS() || OperatingSystem.IsWatchOS();
#else
        RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
#endif

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
