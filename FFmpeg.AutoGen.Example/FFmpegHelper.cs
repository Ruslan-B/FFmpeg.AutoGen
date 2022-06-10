using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Example
{
    internal static class FFmpegHelper
    {
        public static unsafe string av_strerror(int error)
        {
            var bufferSize = 1024;
            var buffer = stackalloc byte[bufferSize];
            ffmpeg.av_strerror(error, buffer, (ulong)bufferSize);
            var message = Marshal.PtrToStringAnsi((IntPtr)buffer);
            return message;
        }

        public static int ThrowExceptionIfError(this int error, string message = null)
        {
            if (error < 0)
            {
                if (string.IsNullOrWhiteSpace(message))
                    throw new ApplicationException(av_strerror(error));
                else
                    throw new ApplicationException(av_strerror(error) + ": " + message);
            }
            return error;
        }
    }
}
