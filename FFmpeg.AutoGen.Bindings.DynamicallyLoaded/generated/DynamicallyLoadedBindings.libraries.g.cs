using System.Collections.Generic;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
    {
        {"avcodec", 60},
        {"avdevice", 60},
        {"avfilter", 9},
        {"avformat", 60},
        {"avutil", 58},
        {"postproc", 57},
        {"swresample", 4},
        {"swscale", 7},
    };
}
