using System.Collections.Generic;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
    {
        {"avcodec", 61},
        {"avdevice", 61},
        {"avfilter", 10},
        {"avformat", 61},
        {"avutil", 59},
        {"postproc", 58},
        {"swresample", 5},
        {"swscale", 8},
    };
}
