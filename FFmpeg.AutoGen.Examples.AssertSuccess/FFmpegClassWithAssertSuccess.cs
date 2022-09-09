using System;
using FFmpeg.AutoGen;

public unsafe class FFmpegClassWithAssertSuccess : IDisposable
{
    public class FFmpegException : Exception
    {
        public FFmpegException(string message) : base(message) {}
    }

    public FFmpegClassWithAssertSuccess()
    {
        // ...

        AVFormatContext* outputContext;


        // Wrap all ffmpeg calls in AssertSuccess like so:
        AssertSuccess(
            ffmpeg.avformat_alloc_output_context2(&outputContext, null, null, null),
            "Could not allocate output format context"
        );

        // ...
    }
 
    protected void AssertSuccess(int assert, string message)
    {
        if (assert >= 0) return;

        // Try known non-FFERRTAG errors
        if (assert == -ffmpeg.EAGAIN) throw new FFmpegException("EAGAIN - " + message);
        if (assert == -ffmpeg.EINVAL) throw new FFmpegException("EINVAL - " + message);
        if (assert == -ffmpeg.ENOMEM) throw new FFmpegException("ENOMEM - " + message);
        if (assert == -ffmpeg.EPIPE) throw new FFmpegException("EPIPE - " + message);

        // Try known POSIX errors
        if (Enum.IsDefined(typeof(PosixError), -assert))
        {
            throw new FFmpegException($"{Enum.ToObject(typeof(PosixError), -assert)} – {message}");
        }

        // Assume FFERRTAG error and report
        var a = Char.ConvertFromUtf32(-assert & 0xFF);
        var b = Char.ConvertFromUtf32(-assert >> 8 & 0xFF);
        var c = Char.ConvertFromUtf32(-assert >> 16 & 0xFF);
        var d = Char.ConvertFromUtf32(-assert >> 24 & 0xFF);
        throw new FFmpegException($"{a}{b}{c}{d} – {message}");
    }

    // Culled from, appropriately enough, https://github.com/dotnet/runtime/issues/61351
    private enum PosixError
    {
        EPERM = 1,
        ENOENT = 2,
        ESRCH = 3,
        EINTR = 4,
        EIO = 5,
        ENXIO = 6,
        E2BIG = 7,
        ENOEXEC = 8,
        EBADF = 9,
        ECHILD = 10,
        EAGAIN = 11,
        ENOMEM = 12,
        EACCES = 13,
        EFAULT = 14,
        EBUSY = 16,
        EEXIST = 17,
        EXDEV = 18,
        ENODEV = 19,
        ENOTDIR = 20,
        EISDIR = 21,
        EINVAL = 22,
        ENFILE = 23,
        EMFILE = 24,
        ENOTTY = 25,
        EFBIG = 27,
        ENOSPC = 28,
        ESPIPE = 29,
        EROFS = 30,
        EMLINK = 31,
        EPIPE = 32,
        EDOM = 33,
        ERANGE = 34,
        EDEADLK = 36,
        ENAMETOOLONG = 38,
        ENOLCK = 39,
        ENOSYS = 40,
        ENOTEMPTY = 41,
        EILSEQ = 42,
        STRUNCATE = 80,
    }
}