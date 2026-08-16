#if !NET6_0_OR_GREATER
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

/// <summary>
/// Platform-specific C 'long' type.
/// On netstandard2.0/2.1, assumes 8 bytes (same as previous behavior).
/// C 'long' is 4 bytes on Windows — this is a known issue on older frameworks.
/// For correct cross-platform struct layout, upgrade to .NET 6+.
/// </summary>
[Obsolete("CLong has incorrect size on Windows. Upgrade to .NET 6+ for correct cross-platform behavior.")]
[StructLayout(LayoutKind.Sequential)]
public struct CLong
{
    public long Value;

    public CLong(long value) => Value = value;

    public static implicit operator long(CLong value) => value.Value;
    public static implicit operator CLong(long value) => new CLong(value);
}

/// <summary>
/// Platform-specific C 'unsigned long' type.
/// On netstandard2.0/2.1, assumes 8 bytes (same as previous behavior).
/// C 'unsigned long' is 4 bytes on Windows — this is a known issue on older frameworks.
/// For correct cross-platform struct layout, upgrade to .NET 6+.
/// </summary>
[Obsolete("CULong has incorrect size on Windows. Upgrade to .NET 6+ for correct cross-platform behavior.")]
[StructLayout(LayoutKind.Sequential)]
public struct CULong
{
    public ulong Value;

    public CULong(ulong value) => Value = value;

    public static implicit operator ulong(CULong value) => value.Value;
    public static implicit operator CULong(ulong value) => new CULong(value);
}
#endif
