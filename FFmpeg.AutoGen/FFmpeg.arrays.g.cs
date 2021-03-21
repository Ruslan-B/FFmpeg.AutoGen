using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    #pragma warning disable 169
    
    public unsafe struct AVRational_array2
    {
        public static readonly int Size = 2;
        AVRational _0; AVRational _1;
        
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
    
    public unsafe struct double_array2x399
    {
        public static readonly int Size = 2;
        double_array399 _0; double_array399 _1;
        
        public double_array399 this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (double_array399* p0 = &_0) { return *(p0 + i); } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (double_array399* p0 = &_0) { *(p0 + i) = value;  } }
        }
        public double_array399[] ToArray()
        {
            fixed (double_array399* p0 = &_0) { var a = new double_array399[Size]; for (uint i = 0; i < Size; i++) a[i] = *(p0 + i); return a; }
        }
        public void UpdateFrom(double_array399[] array)
        {
            fixed (double_array399* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= Size) return; } }
        }
        public static implicit operator double_array399[](double_array2x399 @struct) => @struct.ToArray();
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
        public static implicit operator short[](short_array2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct void_ptrArray2
    {
        public static readonly int Size = 2;
        void* _0; void* _1;
        
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
        public static implicit operator void*[](void_ptrArray2 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVHDRPlusColorTransformParams_array3
    {
        public static readonly int Size = 3;
        AVHDRPlusColorTransformParams _0; AVHDRPlusColorTransformParams _1; AVHDRPlusColorTransformParams _2;
        
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
        AVRational _0; AVRational _1; AVRational _2;
        
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
        AVRational_array2 _0; AVRational_array2 _1; AVRational_array2 _2;
        
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
        byte* _0; byte* _1; byte* _2;
        
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
        public static implicit operator int[](int_array3 @struct) => @struct.ToArray();
    }
    
    public unsafe struct short_array3x2
    {
        public static readonly int Size = 3;
        short_array2 _0; short_array2 _1; short_array2 _2;
        
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
        AVComponentDescriptor _0; AVComponentDescriptor _1; AVComponentDescriptor _2; AVComponentDescriptor _3;
        
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
        byte* _0; byte* _1; byte* _2; byte* _3;
        
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
        public static implicit operator long[](long_array4 @struct) => @struct.ToArray();
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
        public static implicit operator int[](int_array5 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVBufferRef_ptrArray8
    {
        public static readonly int Size = 8;
        AVBufferRef* _0; AVBufferRef* _1; AVBufferRef* _2; AVBufferRef* _3; AVBufferRef* _4; AVBufferRef* _5; AVBufferRef* _6; AVBufferRef* _7;
        
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
        public static implicit operator byte[](byte_array8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct byte_ptrArray8
    {
        public static readonly int Size = 8;
        byte* _0; byte* _1; byte* _2; byte* _3; byte* _4; byte* _5; byte* _6; byte* _7;
        
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
        public static implicit operator ulong[](ulong_array8 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVHDRPlusPercentile_array15
    {
        public static readonly int Size = 15;
        AVHDRPlusPercentile _0; AVHDRPlusPercentile _1; AVHDRPlusPercentile _2; AVHDRPlusPercentile _3; AVHDRPlusPercentile _4; AVHDRPlusPercentile _5; AVHDRPlusPercentile _6; AVHDRPlusPercentile _7; AVHDRPlusPercentile _8; AVHDRPlusPercentile _9; AVHDRPlusPercentile _10; AVHDRPlusPercentile _11; AVHDRPlusPercentile _12; AVHDRPlusPercentile _13; AVHDRPlusPercentile _14;
        
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
        AVRational _0; AVRational _1; AVRational _2; AVRational _3; AVRational _4; AVRational _5; AVRational _6; AVRational _7; AVRational _8; AVRational _9; AVRational _10; AVRational _11; AVRational _12; AVRational _13; AVRational _14;
        
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
    
    public unsafe struct byte_array17
    {
        public static readonly int Size = 17;
        fixed byte _[17];
        
        public byte this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array17* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (byte_array17* p = &this) { p->_[i] = value; } }
        }
        public byte[] ToArray()
        {
            fixed (byte_array17* p = &this) { var a = new byte[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(byte[] array)
        {
            fixed (byte_array17* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator byte[](byte_array17 @struct) => @struct.ToArray();
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
        public static implicit operator long[](long_array17 @struct) => @struct.ToArray();
    }
    
    public unsafe struct AVRational_array25
    {
        public static readonly int Size = 25;
        AVRational _0; AVRational _1; AVRational _2; AVRational _3; AVRational _4; AVRational _5; AVRational _6; AVRational _7; AVRational _8; AVRational _9; AVRational _10; AVRational _11; AVRational _12; AVRational _13; AVRational _14; AVRational _15; AVRational _16; AVRational _17; AVRational _18; AVRational _19; AVRational _20; AVRational _21; AVRational _22; AVRational _23; AVRational _24;
        
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
        AVRational_array25 _0; AVRational_array25 _1; AVRational_array25 _2; AVRational_array25 _3; AVRational_array25 _4; AVRational_array25 _5; AVRational_array25 _6; AVRational_array25 _7; AVRational_array25 _8; AVRational_array25 _9; AVRational_array25 _10; AVRational_array25 _11; AVRational_array25 _12; AVRational_array25 _13; AVRational_array25 _14; AVRational_array25 _15; AVRational_array25 _16; AVRational_array25 _17; AVRational_array25 _18; AVRational_array25 _19; AVRational_array25 _20; AVRational_array25 _21; AVRational_array25 _22; AVRational_array25 _23; AVRational_array25 _24;
        
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
    
    public unsafe struct double_array399
    {
        public static readonly int Size = 399;
        fixed double _[399];
        
        public double this[uint i]
        {
            get { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (double_array399* p = &this) { return p->_[i]; } }
            set { if (i >= Size) throw new ArgumentOutOfRangeException(); fixed (double_array399* p = &this) { p->_[i] = value; } }
        }
        public double[] ToArray()
        {
            fixed (double_array399* p = &this) { var a = new double[Size]; for (uint i = 0; i < Size; i++) a[i] = p->_[i]; return a; }
        }
        public void UpdateFrom(double[] array)
        {
            fixed (double_array399* p = &this) { uint i = 0; foreach(var value in array) { p->_[i++] = value; if (i >= Size) return; } }
        }
        public static implicit operator double[](double_array399 @struct) => @struct.ToArray();
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
        public static implicit operator byte[](byte_array61440 @struct) => @struct.ToArray();
    }
    
}
