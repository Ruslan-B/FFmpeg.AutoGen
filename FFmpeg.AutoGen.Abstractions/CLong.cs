#if !NET6_0_OR_GREATER
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Abstractions;

/// <summary>
/// Platform-specific C 'long' type.
/// Always 8 bytes here, which is correct on Linux and macOS x64 but wrong on Windows,
/// where C 'long' is 4 bytes. A netstandard assembly has one fixed layout and cannot
/// differ per platform, so this preserves the historical behaviour rather than fixing it.
/// Target net8.0 or newer to get the runtime's own CLong, which is sized per platform.
/// </summary>
[Obsolete("CLong is 8 bytes here, which is wrong on Windows and shifts every field after it. Target net8.0 or newer for a correct struct layout.")]
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
/// Always 8 bytes here, which is correct on Linux and macOS x64 but wrong on Windows,
/// where C 'unsigned long' is 4 bytes. A netstandard assembly has one fixed layout and
/// cannot differ per platform, so this preserves the historical behaviour rather than
/// fixing it. Target net8.0 or newer to get the runtime's own CULong, sized per platform.
/// </summary>
[Obsolete("CULong is 8 bytes here, which is wrong on Windows and shifts every field after it. Target net8.0 or newer for a correct struct layout.")]
[StructLayout(LayoutKind.Sequential)]
public struct CULong
{
    public ulong Value;

    public CULong(ulong value) => Value = value;

    public static implicit operator ulong(CULong value) => value.Value;
    public static implicit operator CULong(ulong value) => new CULong(value);
}
#endif
