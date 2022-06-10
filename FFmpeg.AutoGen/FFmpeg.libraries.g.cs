using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    using System.Collections.Generic;
    
    public unsafe static partial class ffmpeg
    {
        public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
        {
            {"avcodec", 59},
            {"avdevice", 59},
            {"avfilter", 8},
            {"avformat", 59},
            {"avutil", 57},
            {"swresample", 4},
            {"swscale", 6},
        };
    }
}
