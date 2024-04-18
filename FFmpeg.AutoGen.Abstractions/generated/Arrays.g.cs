using System;

namespace FFmpeg.AutoGen.Abstractions;

public unsafe struct AVRational2 : IFixedArray<AVRational>
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    AVRational _0; AVRational _1;
    
    public AVRational this[uint i]
    {
        get { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational[] ToArray()
    {
        fixed (AVRational* p0 = &_0) { var a = new AVRational[2]; for (uint i = 0; i < 2; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational[] array)
    {
        fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 2) return; } }
    }
    public static implicit operator AVRational[](AVRational2 @struct) => @struct.ToArray();
}

public unsafe struct short2 : IFixedArray<short>
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    fixed short _[2];
    
    public short this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public short[] ToArray()
    {
        var a = new short[2]; for (uint i = 0; i < 2; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(short[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 2) return; }
    }
    public static implicit operator short[](short2 @struct) => @struct.ToArray();
}

public unsafe struct void_ptr2 : IFixedArray
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    void* _0; void* _1;
    
    public void* this[uint i]
    {
        get { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public void*[] ToArray()
    {
        fixed (void** p0 = &_0) { var a = new void*[2]; for (uint i = 0; i < 2; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(void*[] array)
    {
        fixed (void** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 2) return; } }
    }
    public static implicit operator void*[](void_ptr2 @struct) => @struct.ToArray();
}

public unsafe struct AVHDRPlusColorTransformParams3 : IFixedArray<AVHDRPlusColorTransformParams>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    AVHDRPlusColorTransformParams _0; AVHDRPlusColorTransformParams _1; AVHDRPlusColorTransformParams _2;
    
    public AVHDRPlusColorTransformParams this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusColorTransformParams* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusColorTransformParams* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVHDRPlusColorTransformParams[] ToArray()
    {
        fixed (AVHDRPlusColorTransformParams* p0 = &_0) { var a = new AVHDRPlusColorTransformParams[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVHDRPlusColorTransformParams[] array)
    {
        fixed (AVHDRPlusColorTransformParams* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator AVHDRPlusColorTransformParams[](AVHDRPlusColorTransformParams3 @struct) => @struct.ToArray();
}

public unsafe struct AVRational3 : IFixedArray<AVRational>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    AVRational _0; AVRational _1; AVRational _2;
    
    public AVRational this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational[] ToArray()
    {
        fixed (AVRational* p0 = &_0) { var a = new AVRational[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational[] array)
    {
        fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator AVRational[](AVRational3 @struct) => @struct.ToArray();
}

public unsafe struct AVRational3x2 : IFixedArray<AVRational2>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    AVRational2 _0; AVRational2 _1; AVRational2 _2;
    
    public AVRational2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVRational2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (AVRational2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational2[] ToArray()
    {
        fixed (AVRational2* p0 = &_0) { var a = new AVRational2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational2[] array)
    {
        fixed (AVRational2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator AVRational2[](AVRational3x2 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptr3 : IFixedArray
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    byte* _0; byte* _1; byte* _2;
    
    public byte* this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte*[] ToArray()
    {
        fixed (byte** p0 = &_0) { var a = new byte*[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte*[] array)
    {
        fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator byte*[](byte_ptr3 @struct) => @struct.ToArray();
}

public unsafe struct int3 : IFixedArray<int>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    fixed int _[3];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[3]; for (uint i = 0; i < 3; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 3) return; }
    }
    public static implicit operator int[](int3 @struct) => @struct.ToArray();
}

public unsafe struct short3x2 : IFixedArray<short2>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    short2 _0; short2 _1; short2 _2;
    
    public short2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public short2[] ToArray()
    {
        fixed (short2* p0 = &_0) { var a = new short2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(short2[] array)
    {
        fixed (short2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator short2[](short3x2 @struct) => @struct.ToArray();
}

public unsafe struct AVComponentDescriptor4 : IFixedArray<AVComponentDescriptor>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    AVComponentDescriptor _0; AVComponentDescriptor _1; AVComponentDescriptor _2; AVComponentDescriptor _3;
    
    public AVComponentDescriptor this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (AVComponentDescriptor* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (AVComponentDescriptor* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVComponentDescriptor[] ToArray()
    {
        fixed (AVComponentDescriptor* p0 = &_0) { var a = new AVComponentDescriptor[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVComponentDescriptor[] array)
    {
        fixed (AVComponentDescriptor* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator AVComponentDescriptor[](AVComponentDescriptor4 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptr4 : IFixedArray
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    byte* _0; byte* _1; byte* _2; byte* _3;
    
    public byte* this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte*[] ToArray()
    {
        fixed (byte** p0 = &_0) { var a = new byte*[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte*[] array)
    {
        fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator byte*[](byte_ptr4 @struct) => @struct.ToArray();
}

public unsafe struct byte4 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed byte _[4];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator byte[](byte4 @struct) => @struct.ToArray();
}

public unsafe struct int4 : IFixedArray<int>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed int _[4];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator int[](int4 @struct) => @struct.ToArray();
}

public unsafe struct long4 : IFixedArray<long>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed long _[4];
    
    public long this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public long[] ToArray()
    {
        var a = new long[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(long[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator long[](long4 @struct) => @struct.ToArray();
}

public unsafe struct uint4 : IFixedArray<uint>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed uint _[4];
    
    public uint this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public uint[] ToArray()
    {
        var a = new uint[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(uint[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator uint[](uint4 @struct) => @struct.ToArray();
}

public unsafe struct ulong4 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed ulong _[4];
    
    public ulong this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ulong[] ToArray()
    {
        var a = new ulong[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator ulong[](ulong4 @struct) => @struct.ToArray();
}

public unsafe struct int7 : IFixedArray<int>
{
    public static readonly int ArrayLength = 7;
    public int Length => 7;
    fixed int _[7];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[7]; for (uint i = 0; i < 7; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 7) return; }
    }
    public static implicit operator int[](int7 @struct) => @struct.ToArray();
}

public unsafe struct AVBufferRef_ptr8 : IFixedArray
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    AVBufferRef* _0; AVBufferRef* _1; AVBufferRef* _2; AVBufferRef* _3; AVBufferRef* _4; AVBufferRef* _5; AVBufferRef* _6; AVBufferRef* _7;
    
    public AVBufferRef* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (AVBufferRef** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (AVBufferRef** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVBufferRef*[] ToArray()
    {
        fixed (AVBufferRef** p0 = &_0) { var a = new AVBufferRef*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVBufferRef*[] array)
    {
        fixed (AVBufferRef** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator AVBufferRef*[](AVBufferRef_ptr8 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptr8 : IFixedArray
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    byte* _0; byte* _1; byte* _2; byte* _3; byte* _4; byte* _5; byte* _6; byte* _7;
    
    public byte* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte*[] ToArray()
    {
        fixed (byte** p0 = &_0) { var a = new byte*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte*[] array)
    {
        fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator byte*[](byte_ptr8 @struct) => @struct.ToArray();
}

public unsafe struct byte8 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed byte _[8];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator byte[](byte8 @struct) => @struct.ToArray();
}

public unsafe struct int8 : IFixedArray<int>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed int _[8];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator int[](int8 @struct) => @struct.ToArray();
}

public unsafe struct ulong8 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed ulong _[8];
    
    public ulong this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ulong[] ToArray()
    {
        var a = new ulong[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator ulong[](ulong8 @struct) => @struct.ToArray();
}

public unsafe struct int9 : IFixedArray<int>
{
    public static readonly int ArrayLength = 9;
    public int Length => 9;
    fixed int _[9];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[9]; for (uint i = 0; i < 9; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 9) return; }
    }
    public static implicit operator int[](int9 @struct) => @struct.ToArray();
}

public unsafe struct AVHDRPlusPercentile15 : IFixedArray<AVHDRPlusPercentile>
{
    public static readonly int ArrayLength = 15;
    public int Length => 15;
    AVHDRPlusPercentile _0; AVHDRPlusPercentile _1; AVHDRPlusPercentile _2; AVHDRPlusPercentile _3; AVHDRPlusPercentile _4; AVHDRPlusPercentile _5; AVHDRPlusPercentile _6; AVHDRPlusPercentile _7; AVHDRPlusPercentile _8; AVHDRPlusPercentile _9; AVHDRPlusPercentile _10; AVHDRPlusPercentile _11; AVHDRPlusPercentile _12; AVHDRPlusPercentile _13; AVHDRPlusPercentile _14;
    
    public AVHDRPlusPercentile this[uint i]
    {
        get { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusPercentile* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusPercentile* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVHDRPlusPercentile[] ToArray()
    {
        fixed (AVHDRPlusPercentile* p0 = &_0) { var a = new AVHDRPlusPercentile[15]; for (uint i = 0; i < 15; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVHDRPlusPercentile[] array)
    {
        fixed (AVHDRPlusPercentile* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 15) return; } }
    }
    public static implicit operator AVHDRPlusPercentile[](AVHDRPlusPercentile15 @struct) => @struct.ToArray();
}

public unsafe struct AVRational15 : IFixedArray<AVRational>
{
    public static readonly int ArrayLength = 15;
    public int Length => 15;
    AVRational _0; AVRational _1; AVRational _2; AVRational _3; AVRational _4; AVRational _5; AVRational _6; AVRational _7; AVRational _8; AVRational _9; AVRational _10; AVRational _11; AVRational _12; AVRational _13; AVRational _14;
    
    public AVRational this[uint i]
    {
        get { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational[] ToArray()
    {
        fixed (AVRational* p0 = &_0) { var a = new AVRational[15]; for (uint i = 0; i < 15; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational[] array)
    {
        fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 15) return; } }
    }
    public static implicit operator AVRational[](AVRational15 @struct) => @struct.ToArray();
}

public unsafe struct byte16 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 16;
    public int Length => 16;
    fixed byte _[16];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[16]; for (uint i = 0; i < 16; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 16) return; }
    }
    public static implicit operator byte[](byte16 @struct) => @struct.ToArray();
}

public unsafe struct AVRational25 : IFixedArray<AVRational>
{
    public static readonly int ArrayLength = 25;
    public int Length => 25;
    AVRational _0; AVRational _1; AVRational _2; AVRational _3; AVRational _4; AVRational _5; AVRational _6; AVRational _7; AVRational _8; AVRational _9; AVRational _10; AVRational _11; AVRational _12; AVRational _13; AVRational _14; AVRational _15; AVRational _16; AVRational _17; AVRational _18; AVRational _19; AVRational _20; AVRational _21; AVRational _22; AVRational _23; AVRational _24;
    
    public AVRational this[uint i]
    {
        get { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational[] ToArray()
    {
        fixed (AVRational* p0 = &_0) { var a = new AVRational[25]; for (uint i = 0; i < 25; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational[] array)
    {
        fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 25) return; } }
    }
    public static implicit operator AVRational[](AVRational25 @struct) => @struct.ToArray();
}

public unsafe struct AVRational25x25 : IFixedArray<AVRational25>
{
    public static readonly int ArrayLength = 25;
    public int Length => 25;
    AVRational25 _0; AVRational25 _1; AVRational25 _2; AVRational25 _3; AVRational25 _4; AVRational25 _5; AVRational25 _6; AVRational25 _7; AVRational25 _8; AVRational25 _9; AVRational25 _10; AVRational25 _11; AVRational25 _12; AVRational25 _13; AVRational25 _14; AVRational25 _15; AVRational25 _16; AVRational25 _17; AVRational25 _18; AVRational25 _19; AVRational25 _20; AVRational25 _21; AVRational25 _22; AVRational25 _23; AVRational25 _24;
    
    public AVRational25 this[uint i]
    {
        get { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (AVRational25* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (AVRational25* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public AVRational25[] ToArray()
    {
        fixed (AVRational25* p0 = &_0) { var a = new AVRational25[25]; for (uint i = 0; i < 25; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(AVRational25[] array)
    {
        fixed (AVRational25* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 25) return; } }
    }
    public static implicit operator AVRational25[](AVRational25x25 @struct) => @struct.ToArray();
}

