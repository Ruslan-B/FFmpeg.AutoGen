using System.Runtime.InteropServices;
using System.Text;

namespace FFmpeg.AutoGen.Abstractions.Test
{
    /// <summary>
    /// Tests for <see cref="ConstCharPtrMarshaler"/>, the custom marshaler used for
    /// <c>const char*</c> return values coming from FFmpeg. It must decode the native
    /// UTF-8 string without ever freeing the (borrowed/static) native memory.
    ///
    /// This project multi-targets net9.0 and net48 so both compile-time branches of the
    /// marshaler are covered: net9.0 references the netstandard2.1 build
    /// (Marshal.PtrToStringUTF8) and net48 references the netstandard2.0 build
    /// (the manual UTF-8 decode fallback).
    /// </summary>
    [TestClass]
    public class ConstCharPtrMarshalerTest
    {
        private readonly List<IntPtr> _allocations = new();

        private static ICustomMarshaler Marshaler => ConstCharPtrMarshaler.GetInstance(null!);

        [TestCleanup]
        public void Cleanup()
        {
            foreach (var ptr in _allocations)
                Marshal.FreeHGlobal(ptr);
            _allocations.Clear();
        }

        /// <summary>Allocates a NUL-terminated UTF-8 C string in unmanaged memory.</summary>
        private IntPtr AllocUtf8(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            var ptr = Marshal.AllocHGlobal(bytes.Length + 1);
            _allocations.Add(ptr);
            Marshal.Copy(bytes, 0, ptr, bytes.Length);
            Marshal.WriteByte(ptr, bytes.Length, 0); // NUL terminator
            return ptr;
        }

        [TestMethod]
        public void GetInstance_ReturnsNonNullMarshaler()
        {
            Assert.IsNotNull(Marshaler);
        }

        [TestMethod]
        public void NullPointer_ReturnsNull()
        {
            var result = Marshaler.MarshalNativeToManaged(IntPtr.Zero);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void EmptyString_ReturnsEmptyString()
        {
            var ptr = AllocUtf8(string.Empty);
            var result = Marshaler.MarshalNativeToManaged(ptr);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void AsciiString_RoundTrips()
        {
            const string expected = "libavcodec 60.31.102";
            var ptr = AllocUtf8(expected);
            var result = Marshaler.MarshalNativeToManaged(ptr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Utf8MultiByteString_RoundTrips()
        {
            // Mix of 2-byte (é), 3-byte (日本語) and 4-byte (emoji) UTF-8 sequences.
            const string expected = "café — 日本語 🎬";
            var ptr = AllocUtf8(expected);
            var result = Marshaler.MarshalNativeToManaged(ptr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CleanUpNativeData_DoesNotInvalidatePointer()
        {
            const string expected = "av_version_info";
            var ptr = AllocUtf8(expected);

            // CleanUpNativeData must be a no-op for borrowed FFmpeg memory: it must not
            // free or mutate the buffer. So decoding again after it returns the same
            // value from the still-valid pointer.
            var first = Marshaler.MarshalNativeToManaged(ptr);
            Marshaler.CleanUpNativeData(ptr); // documented no-op for borrowed memory
            var second = Marshaler.MarshalNativeToManaged(ptr);

            Assert.AreEqual(expected, first);
            Assert.AreEqual(expected, second);
        }
    }
}
