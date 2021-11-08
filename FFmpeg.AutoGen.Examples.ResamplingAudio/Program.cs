using System;
using System.IO;

namespace FFmpeg.AutoGen.Examples.ResamplingAudio
{
    internal unsafe class Program
    {
        static int Main(string[] args)
        {
            int sourceChannelLayout = ffmpeg.AV_CH_LAYOUT_STEREO;
            int destinationChannelLayout = ffmpeg.AV_CH_LAYOUT_SURROUND;
            int sourceSampleRate = 48000;
            int destinationSampleRate = 44100;
            byte** sourceData = null;
            byte** destinationData = null;
            int sourceSamplesCount = 1024;
            AVSampleFormat sourceSampleFormat = AVSampleFormat.AV_SAMPLE_FMT_DBL;
            AVSampleFormat destinationSampleFormat = AVSampleFormat.AV_SAMPLE_FMT_S16;
            int ret;

            if (args.Length != 1)
            {
                string executable = Environment.GetCommandLineArgs()[0];
                Console.Error.Write($"Usage: {executable} output_file\n"
                        + "API example program to show how to resample an audio stream with libswresample.\n"
                        + "This program generates a series of audio frames, resamples them to a specified "
                        + "output format and rate and saves them to an output file named output_file.\n");
                return 1;
            }

            var filename = args[0];
            using var stream = File.Open(filename, FileMode.Create);

            /* Create resampler context */
            var resampleContext = ffmpeg.swr_alloc();
            if (resampleContext == null)
            {
                Console.Error.Write("Could not allocate resampler context\n");
                ret = ffmpeg.AVERROR(ffmpeg.ENOMEM);
                goto end;
            }

            /* Set options */
            ffmpeg.av_opt_set_int(resampleContext,        "in_channel_layout",    sourceChannelLayout, 0);
            ffmpeg.av_opt_set_int(resampleContext,        "in_sample_rate",       sourceSampleRate, 0);
            ffmpeg.av_opt_set_sample_fmt(resampleContext, "in_sample_fmt", sourceSampleFormat, 0);

            ffmpeg.av_opt_set_int(resampleContext,        "out_channel_layout",    destinationChannelLayout, 0);
            ffmpeg.av_opt_set_int(resampleContext,        "out_sample_rate",       destinationSampleRate, 0);
            ffmpeg.av_opt_set_sample_fmt(resampleContext, "out_sample_fmt", destinationSampleFormat, 0);

            /* Initialize the resampling context */
            ret = ffmpeg.swr_init(resampleContext);
            if (ret < 0)
            {
                Console.Error.Write("Failed to initialize the resampling context\n");
                goto end;
            }

            /* Allocate source and destination samples buffers */
            int sourceLinesize;
            int sourceChannelsCount = ffmpeg.av_get_channel_layout_nb_channels((ulong)sourceChannelLayout);
            ret = ffmpeg.av_samples_alloc_array_and_samples(&sourceData, &sourceLinesize, sourceChannelsCount,
                                                     sourceSamplesCount, sourceSampleFormat, 0);
            if (ret < 0)
            {
                Console.Error.Write("Could not allocate source samples\n");
                goto end;
            }

            /* Compute the number of converted samples: buffering is avoided
             * ensuring that the output buffer will contain at least all the
             * converted input samples */
            int destinationSampleCount =
                (int)ffmpeg.av_rescale_rnd(sourceSamplesCount, destinationSampleRate, sourceSampleRate, AVRounding.AV_ROUND_UP);
            int maxDestinationSampleCount = destinationSampleCount;

            /* Buffer is going to be directly written to a rawaudio file, no alignment */
            int destinationLinesize;
            int destinationChanelsCount = ffmpeg.av_get_channel_layout_nb_channels((ulong)destinationChannelLayout);
            ret = ffmpeg.av_samples_alloc_array_and_samples(&destinationData, &destinationLinesize, destinationChanelsCount,
                                                     destinationSampleCount, destinationSampleFormat, 0);
            if (ret < 0)
            {
                Console.Error.Write("Could not allocate destination samples\n");
                goto end;
            }

            double toneLevel = 0;
            do
            {
                /* Generate synthetic audio */
                FillSamples((double *)sourceData[0], sourceSamplesCount, sourceChannelsCount, sourceSampleRate, &toneLevel);

                /* Compute destination number of samples */
                destinationSampleCount = (int)ffmpeg.av_rescale_rnd(ffmpeg.swr_get_delay(resampleContext, sourceSampleRate) +
                                                sourceSamplesCount, destinationSampleRate, sourceSampleRate, AVRounding.AV_ROUND_UP);
                if (destinationSampleCount > maxDestinationSampleCount)
                {
                    ffmpeg.av_freep(&destinationData[0]);
                    ret = ffmpeg.av_samples_alloc(destinationData, &destinationLinesize, destinationChanelsCount,
                                           destinationSampleCount, destinationSampleFormat, 1);
                    if (ret < 0)
                    {
                        break;
                    }

                    maxDestinationSampleCount = destinationSampleCount;
                }

                /* Convert to destination format */
                ret = ffmpeg.swr_convert(resampleContext, destinationData, destinationSampleCount, sourceData, sourceSamplesCount);
                if (ret < 0)
                {
                    Console.Error.Write("Error while converting\n");
                    goto end;
                }

                int destinationBufferSize = ffmpeg.av_samples_get_buffer_size(&destinationLinesize, destinationChanelsCount,
                                                         ret, destinationSampleFormat, 1);
                if (destinationBufferSize < 0)
                {
                    Console.Error.Write("Could not get sample buffer size\n");
                    goto end;
                }

                Console.WriteLine($"t:{toneLevel} in:{sourceSamplesCount} out:{ret}");
                stream.Write(new Span<byte>(destinationData[0], destinationBufferSize));
            }
            while (toneLevel < 10);

            if ((ret = getFormatFromSampleFormat(out var fmt, destinationSampleFormat)) < 0)
                goto end;
            Console.Error.Write("Resampling succeeded. Play the output file with the command:\n"
                    + $"ffplay -f {fmt} -channel_layout {destinationChannelLayout} -channels {destinationChanelsCount} -ar {destinationSampleRate} {filename}\n",
                    fmt, destinationChannelLayout, destinationChanelsCount, destinationSampleRate, filename);

        end:
            if (sourceData != null)
                ffmpeg.av_freep(&sourceData[0]);
            ffmpeg.av_freep(&sourceData);

            if (destinationData != null)
                ffmpeg.av_freep(&destinationData[0]);
            ffmpeg.av_freep(&destinationData);

            ffmpeg.swr_free(&resampleContext);
            return ret;
        }

        struct sample_fmt_entry
        {
            public AVSampleFormat sample_fmt; 
            public string fmt_be, fmt_le;
        }

        static int getFormatFromSampleFormat(out string fmt, AVSampleFormat sample_fmt)
        {            
            var sample_fmt_entries = new[]{
                new sample_fmt_entry{ sample_fmt = AVSampleFormat.AV_SAMPLE_FMT_U8,  fmt_be = "u8",    fmt_le = "u8"    },
                new sample_fmt_entry{ sample_fmt = AVSampleFormat.AV_SAMPLE_FMT_S16, fmt_be = "s16be", fmt_le = "s16le" },
                new sample_fmt_entry{ sample_fmt = AVSampleFormat.AV_SAMPLE_FMT_S32, fmt_be = "s32be", fmt_le = "s32le" },
                new sample_fmt_entry{ sample_fmt = AVSampleFormat.AV_SAMPLE_FMT_FLT, fmt_be = "f32be", fmt_le = "f32le" },
                new sample_fmt_entry{ sample_fmt = AVSampleFormat.AV_SAMPLE_FMT_DBL, fmt_be = "f64be", fmt_le = "f64le" },
            };
            fmt = null;
            for (var i = 0; i < sample_fmt_entries.Length; i++)
            {
                var entry = sample_fmt_entries[i];
                if (sample_fmt == entry.sample_fmt)
                {
                    fmt = ffmpeg.AV_HAVE_BIGENDIAN != 0 ? entry.fmt_be : entry.fmt_le;
                    return 0;
                }
            }

            Console.Error.WriteLine($"Sample format {ffmpeg.av_get_sample_fmt_name(sample_fmt)} not supported as output format");
            return ffmpeg.AVERROR(ffmpeg.EINVAL);
        }

        /**
         * Fill dst buffer with nb_samples, generated starting from t.
         */
        static void FillSamples(double* dst, int samplesCount, int channelsCount, int sampleRate, double* toneLevel)
        {
            int i, j;
            double toneIncrement = 1.0 / sampleRate;
            double *dstp = dst;
            const double c = 2 * Math.PI * 440.0;

            /* generate sin tone with 440Hz frequency and duplicated channels */
            for (i = 0; i < samplesCount; i++)
            {
                *dstp = Math.Sin(c * *toneLevel);
                for (j = 1; j < channelsCount; j++)
                    dstp[j] = dstp[0];
                dstp += channelsCount;
                *toneLevel += toneIncrement;
            }
        }
    }
}
