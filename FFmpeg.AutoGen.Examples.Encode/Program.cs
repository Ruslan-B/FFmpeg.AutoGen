using System;
using System.IO;

namespace FFmpeg.AutoGen.Examples.Encode
{
    internal unsafe class Program
    {
        static int Main(string[] args)
        {
            AVFrame* frame;
            AVPacket* pkt;
            int i, j, k, ret;
            short* samples;
            float t, tincr;

            if (args.Length <= 0)
            {
                string executable = Environment.GetCommandLineArgs()[0];
                Console.Error.WriteLine($"Usage: {executable} <output file>");
                return 0;
            }

            var filename = args[0];

            /* find the MP2 encoder */
            AVCodec* codec = ffmpeg.avcodec_find_encoder(AVCodecID.Mp2);
            if (codec == null)
            {
                Console.Error.WriteLine("Codec not found");
                return 1;
            }

            AVCodecContext* c = ffmpeg.avcodec_alloc_context3(codec);
            if (c == null)
            {
                Console.Error.WriteLine("Could not allocate audio codec context");
                return 1;
            }

            /* put sample parameters */
            c->bit_rate = 64000;

            /* check that the encoder supports s16 pcm input */
            c->sample_fmt = AVSampleFormat.S16;
            if (!check_sample_fmt(codec, c->sample_fmt))
            {
                string sampleFormat = ffmpeg.av_get_sample_fmt_name(c->sample_fmt);
                Console.Error.WriteLine($"Encoder does not support sample format {sampleFormat}");
                return 1;
            }

            /* select other audio parameters supported by the encoder */
            c->sample_rate = select_sample_rate(codec);
            c->channel_layout = select_channel_layout(codec);
            c->channels = ffmpeg.av_get_channel_layout_nb_channels(c->channel_layout);

            /* open it */
            if (ffmpeg.avcodec_open2(c, codec, null) < 0)
            {
                Console.Error.WriteLine($"Could not open codec");
                return 1;
            }

            using BinaryWriter output = new BinaryWriter(new FileStream(filename, FileMode.Create));

            /* packet for holding encoded output */
            pkt = ffmpeg.av_packet_alloc();
            if (pkt == null)
            {
                Console.Error.WriteLine($"could not allocate the packet");
                return 1;
            }

            /* frame containing input raw audio */
            frame = ffmpeg.av_frame_alloc();
            if (frame == null)
            {
                Console.Error.WriteLine($"Could not allocate audio frame");
                return 1;
            }

            frame->nb_samples = c->frame_size;
            frame->format = (int)c->sample_fmt;
            frame->channel_layout = c->channel_layout;

            /* allocate the data buffers */
            ret = ffmpeg.av_frame_get_buffer(frame, 0);
            if (ret < 0)
            {
                Console.Error.WriteLine($"Could not allocate audio data buffers");
                return 1;
            }

            /* encode a single tone sound */
            t = 0.0f;
            tincr = (float)(2 * Math.PI * 440.0 / c->sample_rate);
            for (i = 0; i < 200; i++)
            {
                /* make sure the frame is writable -- makes a copy if the encoder
                 * kept a reference internally */
                ret = ffmpeg.av_frame_make_writable(frame);
                if (ret < 0)
                    return 1;
                samples = (short*)frame->data[0];

                for (j = 0; j < c->frame_size; j++)
                {
                    samples[2 * j] = (short)(Math.Sin(t) * 10000);

                    for (k = 1; k < c->channels; k++)
                        samples[2 * j + k] = samples[2 * j];
                    t += tincr;
                }
                encode(c, frame, pkt, output);
            }

            /* flush the encoder */
            encode(c, null, pkt, output);

            ffmpeg.av_frame_free(&frame);
            ffmpeg.av_packet_free(&pkt);
            ffmpeg.avcodec_free_context(&c);

            return 0;
        }

        static void encode(AVCodecContext* ctx, AVFrame* frame, AVPacket* pkt, BinaryWriter output)
        {
            int ret;

            /* send the frame for encoding */
            ret = ffmpeg.avcodec_send_frame(ctx, frame);
            if (ret < 0)
            {
                Console.Error.WriteLine($"Error sending the frame to the encoder");
                Environment.Exit(1);
            }

            /* read all the available output packets (in general there may be any
             * number of them */
            while (ret >= 0)
            {
                ret = ffmpeg.avcodec_receive_packet(ctx, pkt);
                if (ret == ffmpeg.AVERROR(ffmpeg.EAGAIN) || ret == ffmpeg.AVERROR_EOF)
                    return;
                else if (ret < 0)
                {
                    Console.Error.WriteLine($"Error encoding audio frame");
                    Environment.Exit(1);
                }

                output.Write(new ReadOnlySpan<byte>(pkt->data, pkt->size));
                ffmpeg.av_packet_unref(pkt);
            }
        }

        /* check that a given sample format is supported by the encoder */
        static bool check_sample_fmt(AVCodec *codec, AVSampleFormat sample_fmt)
        {
            AVSampleFormat *p = codec->sample_fmts;

            while (*p != AVSampleFormat.None) {
                if (*p == sample_fmt)
                    return true;
                p++;
            }
            return false;
        }

        /* just pick the highest supported samplerate */
        static int select_sample_rate(AVCodec* codec)
        {
            int best_samplerate = 0;

            if (codec->supported_samplerates == null)
                return 44100;

            int* p = codec->supported_samplerates;
            while (*p != 0) {
                if (best_samplerate != 0 || Math.Abs(44100 - *p) < Math.Abs(44100 - best_samplerate))
                    best_samplerate = *p;
                p++;
            }
            return best_samplerate;
        }

        /* select layout with the highest channel count */
        static ulong select_channel_layout(AVCodec* codec)
        {
            ulong* p;
            ulong best_ch_layout = 0;
            int best_nb_channels = 0;

            if (codec->channel_layouts == null)
                return ffmpeg.AV_CH_LAYOUT_STEREO;

            p = codec->channel_layouts;
            while (*p != 0) {
                int nb_channels = ffmpeg.av_get_channel_layout_nb_channels(*p);

                if (nb_channels > best_nb_channels) {
                    best_ch_layout    = *p;
                    best_nb_channels = nb_channels;
                }
                p++;
            }

            return best_ch_layout;
        }


    }
}
