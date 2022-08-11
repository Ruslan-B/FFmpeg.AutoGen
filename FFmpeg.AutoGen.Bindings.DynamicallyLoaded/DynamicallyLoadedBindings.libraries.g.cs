using System.Collections.Generic;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static Dictionary<string, int> LibraryVersionMap = new Dictionary<string, int>
    {
        {"avcodec", 59},
        {"avdevice", 59},
        {"avfilter", 8},
        {"avformat", 59},
        {"avutil", 57},
        {"postproc", 56},
        {"swresample", 4},
        {"swscale", 6},
    };
}
