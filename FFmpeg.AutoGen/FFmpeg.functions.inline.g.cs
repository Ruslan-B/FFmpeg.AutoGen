using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe static partial class ffmpeg
    {
        /// <summary>Compute ceil(log2(x)).</summary>
        /// <param name="x">value used to compute ceil(log2(x))</param>
        /// <returns>computed ceiling of log2(x)</returns>
        public static int av_ceil_log2_c(int @x)
        {
            return av_log2((uint)(x - 1) << 1);
        }



        /// <summary>Clip a signed integer value into the amin-amax range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="amin">minimum value of the clip range</param>
        /// <param name="amax">maximum value of the clip range</param>
        /// <returns>clipped value</returns>
        public static int av_clip_c(int @a, int @amin, int @amax)
        {
            if (a < amin)
                return amin;
            else if (a > amax)
                return amax;
            else
                return a;
        }



        /// <summary>Clip a signed integer value into the -32768,32767 range.</summary>
        /// <param name="a">value to clip</param>
        /// <returns>clipped value</returns>
        public static short av_clip_int16_c(int @a)
        {
            if (((a + 32768U) & ~65535) != 0)
                return (short)((a >> 31) ^ 32767);
            else
                return (short)a;
        }



        /// <summary>Clip a signed integer value into the -128,127 range.</summary>
        /// <param name="a">value to clip</param>
        /// <returns>clipped value</returns>
        public static sbyte av_clip_int8_c(int @a)
        {
            if (((a + 128U) & ~255) != 0)
                return (sbyte)((a >> 31) ^ 127);
            else
                return (sbyte)a;
        }



        /// <summary>Clip a signed integer into the -(2^p),(2^p-1) range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="p">bit position to clip at</param>
        /// <returns>clipped value</returns>
        public static int av_clip_intp2_c(int @a, int @p)
        {
            if ((((uint)a + (1 << p)) & ~((2 << p) - 1)) != 0)
                return (a >> 31) ^ ((1 << p) - 1);
            else
                return a;
        }



        /// <summary>Clip a signed integer value into the 0-65535 range.</summary>
        /// <param name="a">value to clip</param>
        /// <returns>clipped value</returns>
        public static ushort av_clip_uint16_c(int @a)
        {
            if ((a & (~65535)) != 0)
                return (ushort)((~a) >> 31);
            else
                return (ushort)a;
        }



        /// <summary>Clip a signed integer value into the 0-255 range.</summary>
        /// <param name="a">value to clip</param>
        /// <returns>clipped value</returns>
        public static byte av_clip_uint8_c(int @a)
        {
            if ((a & (~255)) != 0)
                return (byte)((~a) >> 31);
            else
                return (byte)a;
        }



        /// <summary>Clip a signed integer to an unsigned power of two range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="p">bit position to clip at</param>
        /// <returns>clipped value</returns>
        public static uint av_clip_uintp2_c(int @a, int @p)
        {
            if ((a & ~((1 << p) - 1)) != 0)
                return (uint)((~a) >> 31 & ((1 << p) - 1));
            else
                return (uint)a;
        }



        /// <summary>Clip a signed 64bit integer value into the amin-amax range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="amin">minimum value of the clip range</param>
        /// <param name="amax">maximum value of the clip range</param>
        /// <returns>clipped value</returns>
        public static long av_clip64_c(long @a, long @amin, long @amax)
        {
            if (a < amin)
                return amin;
            else if (a > amax)
                return amax;
            else
                return a;
        }



        /// <summary>Clip a double value into the amin-amax range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="amin">minimum value of the clip range</param>
        /// <param name="amax">maximum value of the clip range</param>
        /// <returns>clipped value</returns>
        public static double av_clipd_c(double @a, double @amin, double @amax)
        {
            if (a < amin)
                return amin;
            else if (a > amax)
                return amax;
            else
                return a;
        }



        /// <summary>Clip a float value into the amin-amax range.</summary>
        /// <param name="a">value to clip</param>
        /// <param name="amin">minimum value of the clip range</param>
        /// <param name="amax">maximum value of the clip range</param>
        /// <returns>clipped value</returns>
        public static float av_clipf_c(float @a, float @amin, float @amax)
        {
            if (a < amin)
                return amin;
            else if (a > amax)
                return amax;
            else
                return a;
        }



        /// <summary>Clip a signed 64-bit integer value into the -2147483648,2147483647 range.</summary>
        /// <param name="a">value to clip</param>
        /// <returns>clipped value</returns>
        public static int av_clipl_int32_c(long @a)
        {
            if ((((ulong)a + 2147483648UL) & ~(4294967295UL)) != 0)
                return (int)((a >> 63) ^ 2147483647);
            else
                return (int)a;
        }



        /// <summary>Compare two rationals.</summary>
        /// <param name="a">First rational</param>
        /// <param name="b">Second rational</param>
        /// <returns>One of the following values: - 0 if `a == b` - 1 if `a &gt; b` - -1 if `a &lt; b` - `INT_MIN` if one of the values is of the form `0 / 0`</returns>
        public static int av_cmp_q(AVRational @a, AVRational @b)
        {
            long tmp = a.num * (long)b.den - b.num * (long)a.den;
            if (tmp != 0)
                return (int)((tmp ^ a.den ^ b.den) >> 63) | 1;
            else if (b.den != 0 && a.den != 0)
                return 0;
            else if (a.num != 0 && b.num != 0)
                return (a.num >> 31) - (b.num >> 31);
            else
                return (-2147483647 - 1);
        }



        /// <summary>Reinterpret a double as a 64-bit integer.</summary>
        public static ulong av_double2int(double @f)
        {
            return (ulong)@f;
        }



        /// <summary>Return a pointer to the data stored in a FIFO buffer at a certain offset. The FIFO buffer is not modified.</summary>
        /// <param name="f">AVFifoBuffer to peek at, f must be non-NULL</param>
        /// <param name="offs">an offset in bytes, its absolute value must be less than the used buffer size or the returned pointer will point outside to the buffer data. The used buffer size can be checked with av_fifo_size().</param>
        public static byte* av_fifo_peek2(AVFifoBuffer* @f, int @offs)
        {
            var ptr = f->rptr + offs;
            if (ptr >= f->end)
                ptr = f->buffer + (ptr - f->end);
            else if (ptr < f->buffer)
                ptr = f->end - (f->buffer - ptr);
            return ptr;
        }



        /// <summary>Reinterpret a float as a 32-bit integer.</summary>
        public static uint av_float2int(float @f)
        {
            return (uint)@f;
        }



        /// <summary>Reinterpret a 64-bit integer as a double.</summary>
        public static double av_int2double(ulong @i)
        {
            return (double)@i;
        }



        /// <summary>Reinterpret a 32-bit integer as a float.</summary>
        public static float av_int2float(uint @i)
        {
            return (float)@i;
        }



        /// <summary>Invert a rational.</summary>
        /// <param name="q">value</param>
        /// <returns>1 / q</returns>
        public static AVRational av_inv_q(AVRational @q)
        {
            var r = new AVRational { @num = q.den, @den = q.num };
            return r;
        }



        /// <summary>Fill the provided buffer with a string containing an error string corresponding to the AVERROR code errnum.</summary>
        /// <param name="errbuf">a buffer</param>
        /// <param name="errbuf_size">size in bytes of errbuf</param>
        /// <param name="errnum">error code to describe</param>
        /// <returns>the buffer in input, filled with the error description</returns>
        public static byte* av_make_error_string(byte* @errbuf, ulong @errbuf_size, int @errnum)
        {
            av_strerror(errnum, errbuf, errbuf_size);
            return errbuf;
        }



        /// <summary>Create an AVRational.</summary>
        public static AVRational av_make_q(int @num, int @den)
        {
            var r = new AVRational { @num = num, @den = den };
            return r;
        }



        /// <summary>Clear high bits from an unsigned integer starting with specific bit position</summary>
        /// <param name="a">value to clip</param>
        /// <param name="p">bit position to clip at</param>
        /// <returns>clipped value</returns>
        public static uint av_mod_uintp2_c(uint @a, uint @p)
        {
            return a & (uint)((1 << (int)p) - 1);
        }



        public static int av_parity_c(uint @v)
        {
            return av_popcount_c(v) & 1;
        }



        /// <summary>Count number of bits set to one in x</summary>
        /// <param name="x">value to count bits of</param>
        /// <returns>the number of bits set to one in x</returns>
        public static int av_popcount_c(uint @x)
        {
            x -= (x >> 1) & 1431655765;
            x = (x & 858993459) + ((x >> 2) & 858993459);
            x = (x + (x >> 4)) & 252645135;
            x += x >> 8;
            return (int)((x + (x >> 16)) & 63);
        }



        /// <summary>Count number of bits set to one in x</summary>
        /// <param name="x">value to count bits of</param>
        /// <returns>the number of bits set to one in x</returns>
        public static int av_popcount64_c(ulong @x)
        {
            return av_popcount_c((uint)x) + av_popcount_c((uint)(x >> 32));
        }



        /// <summary>Convert an AVRational to a `double`.</summary>
        /// <param name="a">AVRational to convert</param>
        /// <returns>`a` in floating-point form</returns>
        public static double av_q2d(AVRational @a)
        {
            return a.num / (double)a.den;
        }



        /// <summary>Add two signed 32-bit values with saturation.</summary>
        /// <param name="a">one value</param>
        /// <param name="b">another value</param>
        /// <returns>sum with signed saturation</returns>
        public static int av_sat_add32_c(int @a, int @b)
        {
            return av_clipl_int32_c((long)a + b);
        }



        /// <summary>Add a doubled value to another value with saturation at both stages.</summary>
        /// <param name="a">first value</param>
        /// <param name="b">value doubled and added to a</param>
        /// <returns>sum sat(a + sat(2*b)) with signed saturation</returns>
        public static int av_sat_dadd32_c(int @a, int @b)
        {
            return av_sat_add32_c(a, av_sat_add32_c(b, b));
        }



        /// <summary>Subtract a doubled value from another value with saturation at both stages.</summary>
        /// <param name="a">first value</param>
        /// <param name="b">value doubled and subtracted from a</param>
        /// <returns>difference sat(a - sat(2*b)) with signed saturation</returns>
        public static int av_sat_dsub32_c(int @a, int @b)
        {
            return av_sat_sub32_c(a, av_sat_add32_c(b, b));
        }



        /// <summary>Subtract two signed 32-bit values with saturation.</summary>
        /// <param name="a">one value</param>
        /// <param name="b">another value</param>
        /// <returns>difference with signed saturation</returns>
        public static int av_sat_sub32_c(int @a, int @b)
        {
            return av_clipl_int32_c((long)a - b);
        }



        /// <summary>Multiply two `size_t` values checking for overflow.</summary>
        /// <param name="r">Pointer to the result of the operation</param>
        /// <returns>0 on success, AVERROR(EINVAL) on overflow</returns>
        public static int av_size_mult(ulong @a, ulong @b, ulong* @r)
        {
            var t = (a * b);
            if ((a | b) >= (ulong)(1 << (sizeof(IntPtr) * 4)) && a != 0 && t / a != b)
                return (-(22));
            *r = t;
            return 0;
        }



        /// <summary>Return x default pointer in case p is NULL.</summary>
        public static void* av_x_if_null(void* @p, void* @x)
        {
            return (void*)(p != null ? p : x);
        }



        /// <summary>ftell() equivalent for AVIOContext.</summary>
        /// <returns>position or AVERROR.</returns>
        public static long avio_tell(AVIOContext* @s)
        {
            return avio_seek(s, 0, 1);
        }



    }
}
