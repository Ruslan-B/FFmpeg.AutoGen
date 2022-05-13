using System;
using System.Runtime.InteropServices;

#pragma warning disable 169
#pragma warning disable CS0649
#pragma warning disable CS0108
namespace FFmpeg.AutoGen
{
    using System.Collections.Generic;
    
    public unsafe static partial class ffmpeg
    {
        public static Dictionary<string, int> LibraryVersionMap =  new Dictionary<string, int>
        {
            {"avcodec", 58},
            {"avdevice", 58},
            {"avfilter", 7},
            {"avformat", 58},
            {"avutil", 56},
            {"postproc", 55},
            {"swresample", 3},
            {"swscale", 5},
        };
    }
}
