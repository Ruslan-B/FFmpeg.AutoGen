namespace FFmpeg.AutoGen.Example
{
    public class Program
    {
        private static void Main(string[] args)
        {
            FFmpegBinariesHelper.RegisterFFmpegBinaries();
            var transcoding = new Transcoding();
            transcoding.main(args.Length, args);
        }
    }
}