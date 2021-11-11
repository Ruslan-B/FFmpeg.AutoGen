using System;
using System.Collections.Generic;

namespace FFmpeg.AutoGen
{
    [Flags]
    public enum LibraryFlags : byte
    {
        /// No library.
        None = 0,

        /// avcodec library.
        AVCodec = 1 << 0,
        /// avdevice library.
        AVDevice = 1 << 1,
        /// avfilter library.
        AVFilter = 1 << 2,
        /// avformat library.
        AVFormat = 1 << 3,
        /// avutil library.
        AVUtil = 1 << 4,
        /// postproc library.
        PostProc = 1 << 5,
        /// swresample library.
        SWResample = 1 << 6,
        /// swscale library.
        SWScale = 1 << 7,
        
        /// All libav libraries: avcodec, avdevice, avfilter, avformat and avutil.
        AVAll = AVCodec | AVDevice | AVFilter | AVFormat | AVUtil,
        /// All libsw libraries: swresample and swscale.
        SWAll = SWResample | SWScale,
        /// All libraries: all libav libraries, all libsw libraries, and postproc.
        All = AVCodec | AVDevice | AVFilter | AVFormat | AVUtil | PostProc | SWResample | SWScale,
    }
    
    public static class LibraryFlagsExtension
    {
        /// <summary>
        /// Gets the names of all the flagged libraries.
        /// </summary>
        /// <returns>A list of the names of all the flagged libraries.</returns>
        public static List<string> ToStrings(this LibraryFlags libraryFlags)
        {
            var strings = new List<string>();
            if (libraryFlags.HasFlag(LibraryFlags.AVCodec)) strings.Add("avcodec");
            if (libraryFlags.HasFlag(LibraryFlags.AVDevice)) strings.Add("avdevice");
            if (libraryFlags.HasFlag(LibraryFlags.AVFilter)) strings.Add("avfilter");
            if (libraryFlags.HasFlag(LibraryFlags.AVFormat)) strings.Add("avformat");
            if (libraryFlags.HasFlag(LibraryFlags.AVUtil)) strings.Add("avutil");
            if (libraryFlags.HasFlag(LibraryFlags.PostProc)) strings.Add("postproc");
            if (libraryFlags.HasFlag(LibraryFlags.SWResample)) strings.Add("swresample");
            if (libraryFlags.HasFlag(LibraryFlags.SWScale)) strings.Add("swscale");
            return strings;
        }
    }
}