using System.Collections.Generic;

namespace FFmpeg.AutoGen;

public static unsafe partial class ffmpeg
{
    public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
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
