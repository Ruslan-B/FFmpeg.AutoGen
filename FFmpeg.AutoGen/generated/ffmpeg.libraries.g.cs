using System.Collections.Generic;

namespace FFmpeg.AutoGen;

public static unsafe partial class ffmpeg
{
    public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
    {
        {"avcodec", 63},
        {"avdevice", 63},
        {"avfilter", 12},
        {"avformat", 63},
        {"avutil", 61},
        {"swresample", 7},
        {"swscale", 10},
    };
}
