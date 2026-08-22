using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public class ConstCharPtrMarshaler : ICustomMarshaler
{
    private static readonly ConstCharPtrMarshaler Instance = new();

    public object MarshalNativeToManaged(IntPtr pNativeData)
    {
#if NETSTANDARD2_1_OR_GREATER
        return Marshal.PtrToStringUTF8(pNativeData);
#else
        if (pNativeData == IntPtr.Zero)
            return null;

        var length = 0;
        while (Marshal.ReadByte(pNativeData, length) != 0)
            length++;

        if (length == 0)
            return string.Empty;

        var buffer = new byte[length];
        Marshal.Copy(pNativeData, buffer, 0, length);
        return System.Text.Encoding.UTF8.GetString(buffer);
#endif
    }

    public IntPtr MarshalManagedToNative(object managedObj) => IntPtr.Zero;

    public void CleanUpNativeData(IntPtr pNativeData)
    {
    }

    public void CleanUpManagedData(object managedObj)
    {
    }

    public int GetNativeDataSize() => IntPtr.Size;

    public static ICustomMarshaler GetInstance(string cookie) => Instance;
}
