using System;
using System.Runtime.InteropServices;

#pragma warning disable 169
#pragma warning disable CS0649
#pragma warning disable CS0108
namespace FFmpeg.AutoGen
{
    
    public unsafe struct AVRational_array2
    {
        public static readonly int Size = 2;
        public AVRational _0; public AVRational _1;
        
        public AVRational this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational[] ToArray()
        {
            fixed (AVRational* p0 = &_0) { var a = new AVRational[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational[] array)
        {
            fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational[](AVRational_array2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct short_array2
    {
        public static readonly int Size = 2;
        fixed short _[2];
        
        public short this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (short_array2* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (short_array2* p = &this) { p->_[i] = value; } }
        }
        public short[] ToArray()
        {
            fixed (short_array2* p = &this) { var a = new short[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(short[] array)
        {
            fixed (short_array2* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator short*(short_array2 @struct) => (short*)@struct._;
        public static implicit operator short[](short_array2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct void_ptrArray2
    {
        public static readonly int Size = 2;
        public void* _0; public void* _1;
        
        public void* this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { *(p0 + i) = value;  } }
        }
        public void*[] ToArray()
        {
            fixed (void** p0 = &_0) { var a = new void*[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(void*[] array)
        {
            fixed (void** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public unsafe Span<IntPtr> GetPinnableReference()
        {
            fixed (void** p = &_0) return new Span<IntPtr>(p, Size); 
        }
        public static implicit operator void*[](void_ptrArray2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVHDRPlusColorTransformParams_array3
    {
        public static readonly int Size = 3;
        public AVHDRPlusColorTransformParams _0; public AVHDRPlusColorTransformParams _1; public AVHDRPlusColorTransformParams _2;
        
        public AVHDRPlusColorTransformParams this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusColorTransformParams* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusColorTransformParams* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVHDRPlusColorTransformParams[] ToArray()
        {
            fixed (AVHDRPlusColorTransformParams* p0 = &_0) { var a = new AVHDRPlusColorTransformParams[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVHDRPlusColorTransformParams[] array)
        {
            fixed (AVHDRPlusColorTransformParams* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVHDRPlusColorTransformParams[](AVHDRPlusColorTransformParams_array3 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array3
    {
        public static readonly int Size = 3;
        public AVRational _0; public AVRational _1; public AVRational _2;
        
        public AVRational this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational[] ToArray()
        {
            fixed (AVRational* p0 = &_0) { var a = new AVRational[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational[] array)
        {
            fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational[](AVRational_array3 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array3x2
    {
        public static readonly int Size = 3;
        public AVRational_array2 _0; public AVRational_array2 _1; public AVRational_array2 _2;
        
        public AVRational_array2 this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational_array2* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational_array2* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational_array2[] ToArray()
        {
            fixed (AVRational_array2* p0 = &_0) { var a = new AVRational_array2[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational_array2[] array)
        {
            fixed (AVRational_array2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational_array2[](AVRational_array3x2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_ptrArray3
    {
        public static readonly int Size = 3;
        public byte* _0; public byte* _1; public byte* _2;
        
        public byte* this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
        }
        public byte*[] ToArray()
        {
            fixed (byte** p0 = &_0) { var a = new byte*[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(byte*[] array)
        {
            fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public unsafe Span<IntPtr> GetPinnableReference()
        {
            fixed (byte** p = &_0) return new Span<IntPtr>(p, Size); 
        }
        public static implicit operator byte*[](byte_ptrArray3 @struct) => @struct.ToArray();
    }
    
    public unsafe struct int_array3
    {
        public static readonly int Size = 3;
        fixed int _[3];
        
        public int this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array3* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array3* p = &this) { p->_[i] = value; } }
        }
        public int[] ToArray()
        {
            fixed (int_array3* p = &this) { var a = new int[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(int[] array)
        {
            fixed (int_array3* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator int*(int_array3 @struct) => (int*)@struct._;
        public static implicit operator int[](int_array3 @struct) => @struct.ToArray();
    }
    
    public unsafe struct short_array3x2
    {
        public static readonly int Size = 3;
        public short_array2 _0; public short_array2 _1; public short_array2 _2;
        
        public short_array2 this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (short_array2* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (short_array2* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public short_array2[] ToArray()
        {
            fixed (short_array2* p0 = &_0) { var a = new short_array2[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(short_array2[] array)
        {
            fixed (short_array2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator short_array2[](short_array3x2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVComponentDescriptor_array4
    {
        public static readonly int Size = 4;
        public AVComponentDescriptor _0; public AVComponentDescriptor _1; public AVComponentDescriptor _2; public AVComponentDescriptor _3;
        
        public AVComponentDescriptor this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVComponentDescriptor* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVComponentDescriptor* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVComponentDescriptor[] ToArray()
        {
            fixed (AVComponentDescriptor* p0 = &_0) { var a = new AVComponentDescriptor[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVComponentDescriptor[] array)
        {
            fixed (AVComponentDescriptor* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVComponentDescriptor[](AVComponentDescriptor_array4 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_ptrArray4
    {
        public static readonly int Size = 4;
        public byte* _0; public byte* _1; public byte* _2; public byte* _3;
        
        public byte* this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
        }
        public byte*[] ToArray()
        {
            fixed (byte** p0 = &_0) { var a = new byte*[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(byte*[] array)
        {
            fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public unsafe Span<IntPtr> GetPinnableReference()
        {
            fixed (byte** p = &_0) return new Span<IntPtr>(p, Size); 
        }
        public static implicit operator byte*[](byte_ptrArray4 @struct) => @struct.ToArray();
    }
    
    public unsafe struct int_array4
    {
        public static readonly int Size = 4;
        fixed int _[4];
        
        public int this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array4* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array4* p = &this) { p->_[i] = value; } }
        }
        public int[] ToArray()
        {
            fixed (int_array4* p = &this) { var a = new int[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(int[] array)
        {
            fixed (int_array4* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator int*(int_array4 @struct) => (int*)@struct._;
        public static implicit operator int[](int_array4 @struct) => @struct.ToArray();
    }
    
    public unsafe struct long_array4
    {
        public static readonly int Size = 4;
        fixed long _[4];
        
        public long this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (long_array4* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (long_array4* p = &this) { p->_[i] = value; } }
        }
        public long[] ToArray()
        {
            fixed (long_array4* p = &this) { var a = new long[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(long[] array)
        {
            fixed (long_array4* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator long*(long_array4 @struct) => (long*)@struct._;
        public static implicit operator long[](long_array4 @struct) => @struct.ToArray();
    }
    
    public unsafe struct ulong_array4
    {
        public static readonly int Size = 4;
        fixed ulong _[4];
        
        public ulong this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (ulong_array4* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (ulong_array4* p = &this) { p->_[i] = value; } }
        }
        public ulong[] ToArray()
        {
            fixed (ulong_array4* p = &this) { var a = new ulong[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(ulong[] array)
        {
            fixed (ulong_array4* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator ulong*(ulong_array4 @struct) => (ulong*)@struct._;
        public static implicit operator ulong[](ulong_array4 @struct) => @struct.ToArray();
    }
    
    public unsafe struct int_array5
    {
        public static readonly int Size = 5;
        fixed int _[5];
        
        public int this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array5* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array5* p = &this) { p->_[i] = value; } }
        }
        public int[] ToArray()
        {
            fixed (int_array5* p = &this) { var a = new int[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(int[] array)
        {
            fixed (int_array5* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator int*(int_array5 @struct) => (int*)@struct._;
        public static implicit operator int[](int_array5 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVBufferRef_ptrArray8
    {
        public static readonly int Size = 8;
        public AVBufferRef* _0; public AVBufferRef* _1; public AVBufferRef* _2; public AVBufferRef* _3; public AVBufferRef* _4; public AVBufferRef* _5; public AVBufferRef* _6; public AVBufferRef* _7;
        
        public AVBufferRef* this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVBufferRef** p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVBufferRef** p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVBufferRef*[] ToArray()
        {
            fixed (AVBufferRef** p0 = &_0) { var a = new AVBufferRef*[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVBufferRef*[] array)
        {
            fixed (AVBufferRef** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVBufferRef*[](AVBufferRef_ptrArray8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_array8
    {
        public static readonly int Size = 8;
        fixed byte _[8];
        
        public byte this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array8* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array8* p = &this) { p->_[i] = value; } }
        }
        public byte[] ToArray()
        {
            fixed (byte_array8* p = &this) { var a = new byte[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(byte[] array)
        {
            fixed (byte_array8* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator byte*(byte_array8 @struct) => (byte*)@struct._;
        public static implicit operator byte[](byte_array8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_ptrArray8
    {
        public static readonly int Size = 8;
        public byte* _0; public byte* _1; public byte* _2; public byte* _3; public byte* _4; public byte* _5; public byte* _6; public byte* _7;
        
        public byte* this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
        }
        public byte*[] ToArray()
        {
            fixed (byte** p0 = &_0) { var a = new byte*[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(byte*[] array)
        {
            fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public unsafe Span<IntPtr> GetPinnableReference()
        {
            fixed (byte** p = &_0) return new Span<IntPtr>(p, Size); 
        }
        public static implicit operator byte*[](byte_ptrArray8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct int_array8
    {
        public static readonly int Size = 8;
        fixed int _[8];
        
        public int this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array8* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (int_array8* p = &this) { p->_[i] = value; } }
        }
        public int[] ToArray()
        {
            fixed (int_array8* p = &this) { var a = new int[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(int[] array)
        {
            fixed (int_array8* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator int*(int_array8 @struct) => (int*)@struct._;
        public static implicit operator int[](int_array8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct ulong_array8
    {
        public static readonly int Size = 8;
        fixed ulong _[8];
        
        public ulong this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (ulong_array8* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (ulong_array8* p = &this) { p->_[i] = value; } }
        }
        public ulong[] ToArray()
        {
            fixed (ulong_array8* p = &this) { var a = new ulong[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(ulong[] array)
        {
            fixed (ulong_array8* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator ulong*(ulong_array8 @struct) => (ulong*)@struct._;
        public static implicit operator ulong[](ulong_array8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVHDRPlusPercentile_array15
    {
        public static readonly int Size = 15;
        public AVHDRPlusPercentile _0; public AVHDRPlusPercentile _1; public AVHDRPlusPercentile _2; public AVHDRPlusPercentile _3; public AVHDRPlusPercentile _4; public AVHDRPlusPercentile _5; public AVHDRPlusPercentile _6; public AVHDRPlusPercentile _7; public AVHDRPlusPercentile _8; public AVHDRPlusPercentile _9; public AVHDRPlusPercentile _10; public AVHDRPlusPercentile _11; public AVHDRPlusPercentile _12; public AVHDRPlusPercentile _13; public AVHDRPlusPercentile _14;
        
        public AVHDRPlusPercentile this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusPercentile* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVHDRPlusPercentile* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVHDRPlusPercentile[] ToArray()
        {
            fixed (AVHDRPlusPercentile* p0 = &_0) { var a = new AVHDRPlusPercentile[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVHDRPlusPercentile[] array)
        {
            fixed (AVHDRPlusPercentile* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVHDRPlusPercentile[](AVHDRPlusPercentile_array15 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array15
    {
        public static readonly int Size = 15;
        public AVRational _0; public AVRational _1; public AVRational _2; public AVRational _3; public AVRational _4; public AVRational _5; public AVRational _6; public AVRational _7; public AVRational _8; public AVRational _9; public AVRational _10; public AVRational _11; public AVRational _12; public AVRational _13; public AVRational _14;
        
        public AVRational this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational[] ToArray()
        {
            fixed (AVRational* p0 = &_0) { var a = new AVRational[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational[] array)
        {
            fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational[](AVRational_array15 @struct) => @struct.ToArray();
    }
    
    public unsafe struct long_array17
    {
        public static readonly int Size = 17;
        fixed long _[17];
        
        public long this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (long_array17* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (long_array17* p = &this) { p->_[i] = value; } }
        }
        public long[] ToArray()
        {
            fixed (long_array17* p = &this) { var a = new long[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(long[] array)
        {
            fixed (long_array17* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator long*(long_array17 @struct) => (long*)@struct._;
        public static implicit operator long[](long_array17 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array25
    {
        public static readonly int Size = 25;
        public AVRational _0; public AVRational _1; public AVRational _2; public AVRational _3; public AVRational _4; public AVRational _5; public AVRational _6; public AVRational _7; public AVRational _8; public AVRational _9; public AVRational _10; public AVRational _11; public AVRational _12; public AVRational _13; public AVRational _14; public AVRational _15; public AVRational _16; public AVRational _17; public AVRational _18; public AVRational _19; public AVRational _20; public AVRational _21; public AVRational _22; public AVRational _23; public AVRational _24;
        
        public AVRational this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational[] ToArray()
        {
            fixed (AVRational* p0 = &_0) { var a = new AVRational[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational[] array)
        {
            fixed (AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational[](AVRational_array25 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array25x25
    {
        public static readonly int Size = 25;
        public AVRational_array25 _0; public AVRational_array25 _1; public AVRational_array25 _2; public AVRational_array25 _3; public AVRational_array25 _4; public AVRational_array25 _5; public AVRational_array25 _6; public AVRational_array25 _7; public AVRational_array25 _8; public AVRational_array25 _9; public AVRational_array25 _10; public AVRational_array25 _11; public AVRational_array25 _12; public AVRational_array25 _13; public AVRational_array25 _14; public AVRational_array25 _15; public AVRational_array25 _16; public AVRational_array25 _17; public AVRational_array25 _18; public AVRational_array25 _19; public AVRational_array25 _20; public AVRational_array25 _21; public AVRational_array25 _22; public AVRational_array25 _23; public AVRational_array25 _24;
        
        public AVRational_array25 this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational_array25* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (AVRational_array25* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public AVRational_array25[] ToArray()
        {
            fixed (AVRational_array25* p0 = &_0) { var a = new AVRational_array25[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(AVRational_array25[] array)
        {
            fixed (AVRational_array25* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator AVRational_array25[](AVRational_array25x25 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_array1024
    {
        public static readonly int Size = 1024;
        fixed byte _[1024];
        
        public byte this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array1024* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array1024* p = &this) { p->_[i] = value; } }
        }
        public byte[] ToArray()
        {
            fixed (byte_array1024* p = &this) { var a = new byte[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(byte[] array)
        {
            fixed (byte_array1024* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator byte*(byte_array1024 @struct) => (byte*)@struct._;
        public static implicit operator byte[](byte_array1024 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_array61440
    {
        public static readonly int Size = 61440;
        fixed byte _[61440];
        
        public byte this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array61440* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array61440* p = &this) { p->_[i] = value; } }
        }
        public byte[] ToArray()
        {
            fixed (byte_array61440* p = &this) { var a = new byte[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(byte[] array)
        {
            fixed (byte_array61440* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator byte*(byte_array61440 @struct) => (byte*)@struct._;
        public static implicit operator byte[](byte_array61440 @struct) => @struct.ToArray();
    }
    
}
