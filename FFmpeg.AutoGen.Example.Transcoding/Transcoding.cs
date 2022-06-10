using System;
using System.Collections.Generic;
using System.Text;

namespace FFmpeg.AutoGen.Example
{

    public sealed unsafe class Transcoding
    {
        unsafe struct FilteringContext
        {
            public AVFilterContext* buffersink_ctx;
            public AVFilterContext* buffersrc_ctx;
            public AVFilterGraph* filter_graph;
        }

        unsafe struct StreamContext
        {
            public AVCodecContext* dec_ctx;
            public AVCodecContext* enc_ctx;
        }


        AVFormatContext* ifmt_ctx;
        AVFormatContext* ofmt_ctx;

        FilteringContext* filter_ctx;

        StreamContext* stream_ctx;

        private AVRational av_inv_q(AVRational q) => new AVRational { num = q.den, den = q.num };

        int open_input_file(string filename)
        {
            int ret;
            uint i;

            AVFormatContext* ifmt_ctx_fixed = null;
            if ((ret = ffmpeg.avformat_open_input(&ifmt_ctx_fixed, filename, null, null)) < 0)
            {
                Console.WriteLine("Cannot open input file");
                return ret;
            }

            ifmt_ctx = ifmt_ctx_fixed;
            if ((ret = ffmpeg.avformat_find_stream_info(ifmt_ctx, null)) < 0)
            {
                Console.WriteLine("Cannot find stream information");
                return ret;
            }

            stream_ctx = (StreamContext*)ffmpeg.av_calloc(ifmt_ctx->nb_streams, (ulong)sizeof(StreamContext));
            if (stream_ctx == null)
                return ffmpeg.AVERROR(ffmpeg.ENOMEM);

            for (i = 0; i < ifmt_ctx->nb_streams; i++)
            {
                AVStream* stream = ifmt_ctx->streams[i];
                if (stream->codecpar->codec_id == AVCodecID.AV_CODEC_ID_NONE)
                    continue;

                AVCodec* dec = ffmpeg.avcodec_find_decoder(stream->codecpar->codec_id);
                if (dec == null)
                {
                    Console.WriteLine($"Failed to find decoder for stream #{i}");
                    return ffmpeg.AVERROR_DECODER_NOT_FOUND;
                }

                AVCodecContext* codec_ctx = ffmpeg.avcodec_alloc_context3(dec);
                if (codec_ctx == null)
                {
                    Console.WriteLine($"Failed to allocate the decoder context for stream #{i}");
                    return ffmpeg.AVERROR(ffmpeg.ENOMEM);
                }

                ret = ffmpeg.avcodec_parameters_to_context(codec_ctx, stream->codecpar);
                if (ret < 0)
                {
                    Console.WriteLine($"Failed to copy decoder parameters to input decoder context for stream #{i}");
                    return ret;
                }

                /* Reencode video & audio and remux subtitles etc. */
                if (codec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO
                    || codec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_AUDIO)
                {
                    if (codec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                        codec_ctx->framerate = ffmpeg.av_guess_frame_rate(ifmt_ctx, stream, null);
                    /* Open decoder */
                    ret = ffmpeg.avcodec_open2(codec_ctx, dec, null);
                    if (ret < 0)
                    {
                        Console.WriteLine($"Failed to open decoder for stream #{i}");
                        return ret;
                    }
                }

                stream_ctx[i].dec_ctx = codec_ctx;
            }

            ffmpeg.av_dump_format(ifmt_ctx, 0, filename, 0);
            return 0;
        }

        int open_output_file(string filename)
        {
            AVStream* out_stream;
            AVStream* in_stream;
            AVCodecContext* dec_ctx;
            AVCodecContext* enc_ctx;
            AVCodec* encoder;
            int ret;
            uint i;

            AVFormatContext* ofmt_ctx_fixed = null;
            ffmpeg.avformat_alloc_output_context2(&ofmt_ctx_fixed, null, null, filename);
            if (ofmt_ctx_fixed == null)
            {
                Console.WriteLine("Could not create output context");
                return ffmpeg.AVERROR_UNKNOWN;
            }
            ofmt_ctx = ofmt_ctx_fixed;

            for (i = 0; i < ifmt_ctx->nb_streams; i++)
            {
                in_stream = ifmt_ctx->streams[i];
                if (in_stream->codecpar->codec_id == AVCodecID.AV_CODEC_ID_NONE)
                    continue;

                out_stream = ffmpeg.avformat_new_stream(ofmt_ctx, null);
                if (out_stream == null)
                {
                    Console.WriteLine("Failed allocating output stream");
                    return ffmpeg.AVERROR_UNKNOWN;
                }

                dec_ctx = stream_ctx[i].dec_ctx;
                if (in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO
                    || in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_AUDIO)
                {
                    /* in this example, we choose transcoding to same codec */
                    encoder = ffmpeg.avcodec_find_encoder(dec_ctx->codec_id);
                    if (encoder == null)
                    {
                        Console.WriteLine("Necessary encoder not found");
                        return ffmpeg.AVERROR_INVALIDDATA;
                    }

                    enc_ctx = ffmpeg.avcodec_alloc_context3(encoder);
                    if (enc_ctx == null)
                    {
                        Console.WriteLine("Failed to allocate the encoder context");
                        return ffmpeg.AVERROR(ffmpeg.ENOMEM);
                    }

                    /* In this example, we transcode to same properties (picture size,
                     * sample rate etc.). These properties can be changed for output
                     * streams easily using filters */
                    if (dec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                    {
                        enc_ctx->width = dec_ctx->width;
                        enc_ctx->height = dec_ctx->height;
                        enc_ctx->sample_aspect_ratio = dec_ctx->sample_aspect_ratio;
                        /* take first format from list of supported formats */
                        if (encoder->pix_fmts != null)
                            enc_ctx->pix_fmt = encoder->pix_fmts[0];
                        else
                            enc_ctx->pix_fmt = dec_ctx->pix_fmt;
                        /* video time_base can be set to whatever is handy and supported by encoder */
                        enc_ctx->time_base = av_inv_q(dec_ctx->framerate);
                    }
                    else
                    {
                        enc_ctx->sample_rate = dec_ctx->sample_rate;
                        enc_ctx->channel_layout = dec_ctx->channel_layout;
                        enc_ctx->channels = ffmpeg.av_get_channel_layout_nb_channels(enc_ctx->channel_layout);
                        /* take first format from list of supported formats */
                        enc_ctx->sample_fmt = encoder->sample_fmts[0];
                        enc_ctx->time_base = new AVRational { num = 1, den = enc_ctx->sample_rate };
                    }

                    /* Third parameter can be used to pass settings to encoder */
                    ret = ffmpeg.avcodec_open2(enc_ctx, encoder, null);
                    if (ret < 0)
                    {
                        Console.WriteLine($"Cannot open video encoder for stream #{i}");
                        return ret;
                    }

                    ret = ffmpeg.avcodec_parameters_from_context(out_stream->codecpar, enc_ctx);
                    if (ret < 0)
                    {
                        Console.WriteLine($"Failed to copy encoder parameters to output stream #{i}");
                        return ret;
                    }

                    if ((ofmt_ctx->oformat->flags & ffmpeg.AVFMT_GLOBALHEADER) != 0)
                        enc_ctx->flags |= ffmpeg.AV_CODEC_FLAG_GLOBAL_HEADER;

                    out_stream->time_base = enc_ctx->time_base;
                    stream_ctx[i].enc_ctx = enc_ctx;
                }
                else if (in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_UNKNOWN)
                {
                    Console.WriteLine($"Elementary stream #{i} is of unknown type, cannot proceed");
                    return ffmpeg.AVERROR_INVALIDDATA;
                }
                else
                {
                    /* if this stream must be remuxed */
                    ret = ffmpeg.avcodec_parameters_copy(out_stream->codecpar, in_stream->codecpar);
                    if (ret < 0)
                    {
                        Console.WriteLine($"Copying parameters for stream {i} failed");
                        return ret;
                    }

                    out_stream->time_base = in_stream->time_base;
                }
            }

            ffmpeg.av_dump_format(ofmt_ctx, 0, filename, 1);

            if ((ofmt_ctx->oformat->flags & ffmpeg.AVFMT_NOFILE) == 0)
            {
                ret = ffmpeg.avio_open(&ofmt_ctx->pb, filename, ffmpeg.AVIO_FLAG_WRITE);
                if (ret < 0)
                {
                    Console.WriteLine($"Could not open output file '{filename}'");
                    return ret;
                }
            }

            /* init muxer, write output file header */
            ret = ffmpeg.avformat_write_header(ofmt_ctx, null);
            if (ret < 0)
            {
                Console.WriteLine("Error occurred when opening output file");
                return ret;
            }

            return 0;
        }

        int init_filter(FilteringContext* fctx, AVCodecContext* dec_ctx,
            AVCodecContext* enc_ctx, string filter_spec)
        {
            string args;
            int ret = 0;
            AVFilter* buffersrc = null;
            AVFilter* buffersink = null;
            AVFilterContext* buffersrc_ctx = null;
            AVFilterContext* buffersink_ctx = null;
            AVFilterInOut* outputs = ffmpeg.avfilter_inout_alloc();
            AVFilterInOut* inputs = ffmpeg.avfilter_inout_alloc();
            AVFilterGraph* filter_graph = ffmpeg.avfilter_graph_alloc();

            if (outputs == null || inputs == null || filter_graph == null)
            {
                ret = ffmpeg.AVERROR(ffmpeg.ENOMEM);
                goto end;
            }

            if (dec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
            {
                buffersrc = ffmpeg.avfilter_get_by_name("buffer");
                buffersink = ffmpeg.avfilter_get_by_name("buffersink");
                if (buffersrc == null || buffersink == null)
                {
                    Console.WriteLine("filtering source or sink element not found");
                    ret = ffmpeg.AVERROR_UNKNOWN;
                    goto end;
                }

                args = $"video_size={dec_ctx->width}x{dec_ctx->height}"
                       + $":pix_fmt={ffmpeg.av_get_pix_fmt_name(dec_ctx->pix_fmt)}"
                       + $":time_base={dec_ctx->time_base.num}/{dec_ctx->time_base.den}"
                       + $":pixel_aspect={dec_ctx->sample_aspect_ratio.num}/{dec_ctx->sample_aspect_ratio.den}";

                ret = ffmpeg.avfilter_graph_create_filter(&buffersrc_ctx, buffersrc, "in",
                    args, null, filter_graph);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot create buffer source");
                    goto end;
                }

                ret = ffmpeg.avfilter_graph_create_filter(&buffersink_ctx, buffersink, "out",
                    null, null, filter_graph);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot create buffer sink");
                    goto end;
                }

                ret = ffmpeg.av_opt_set_bin(buffersink_ctx, "pix_fmts",
                    (byte*)&enc_ctx->pix_fmt, sizeof(AVPixelFormat),
                    ffmpeg.AV_OPT_SEARCH_CHILDREN);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot set output pixel format");
                    goto end;
                }
            }
            else if (dec_ctx->codec_type == AVMediaType.AVMEDIA_TYPE_AUDIO)
            {
                buffersrc = ffmpeg.avfilter_get_by_name("abuffer");
                buffersink = ffmpeg.avfilter_get_by_name("abuffersink");
                if (buffersrc == null || buffersink == null)
                {
                    Console.WriteLine("filtering source or sink element not found");
                    ret = ffmpeg.AVERROR_UNKNOWN;
                    goto end;
                }

                if (dec_ctx->channel_layout == 0ul)
                    dec_ctx->channel_layout =
                        (ulong)ffmpeg.av_get_default_channel_layout(dec_ctx->channels);
                args =
                    string.Format("time_base={0}/{1}:sample_rate={2}:sample_fmt={3}:channel_layout=0x{4:X}",
                        dec_ctx->time_base.num, dec_ctx->time_base.den, dec_ctx->sample_rate,
                        ffmpeg.av_get_sample_fmt_name(dec_ctx->sample_fmt),
                        dec_ctx->channel_layout);
                ret = ffmpeg.avfilter_graph_create_filter(&buffersrc_ctx, buffersrc, "in",
                    args, null, filter_graph);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot create audio buffer source");
                    goto end;
                }

                ret = ffmpeg.avfilter_graph_create_filter(&buffersink_ctx, buffersink, "out",
                    null, null, filter_graph);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot create audio buffer sink");
                    goto end;
                }

                ret = ffmpeg.av_opt_set_bin(buffersink_ctx, "sample_fmts",
                    (byte*)&enc_ctx->sample_fmt, sizeof(AVSampleFormat),
                    ffmpeg.AV_OPT_SEARCH_CHILDREN);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot set output sample format");
                    goto end;
                }

                ret = ffmpeg.av_opt_set_bin(buffersink_ctx, "channel_layouts",
                    (byte*)&enc_ctx->channel_layout,
                    sizeof(ulong), ffmpeg.AV_OPT_SEARCH_CHILDREN);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot set output channel layout");
                    goto end;
                }

                ret = ffmpeg.av_opt_set_bin(buffersink_ctx, "sample_rates",
                    (byte*)&enc_ctx->sample_rate, sizeof(int),
                    ffmpeg.AV_OPT_SEARCH_CHILDREN);
                if (ret < 0)
                {
                    Console.WriteLine("Cannot set output sample rate");
                    goto end;
                }
            }
            else
            {
                ret = ffmpeg.AVERROR_UNKNOWN;
                goto end;
            }

            /* Endpoints for the filter graph. */
            outputs->name = ffmpeg.av_strdup("in");
            outputs->filter_ctx = buffersrc_ctx;
            outputs->pad_idx = 0;
            outputs->next = null;

            inputs->name = ffmpeg.av_strdup("out");
            inputs->filter_ctx = buffersink_ctx;
            inputs->pad_idx = 0;
            inputs->next = null;

            if (outputs->name == null || inputs->name == null)
            {
                ret = ffmpeg.AVERROR(ffmpeg.ENOMEM);
                goto end;
            }

            if ((ret = ffmpeg.avfilter_graph_parse_ptr(filter_graph, filter_spec,
                    &inputs, &outputs, null)) < 0)
                goto end;

            if ((ret = ffmpeg.avfilter_graph_config(filter_graph, null)) < 0)
                goto end;

            /* Fill FilteringContext */
            fctx->buffersrc_ctx = buffersrc_ctx;
            fctx->buffersink_ctx = buffersink_ctx;
            fctx->filter_graph = filter_graph;

        end:
            ffmpeg.avfilter_inout_free(&inputs);
            ffmpeg.avfilter_inout_free(&outputs);

            return ret;
        }

        int init_filters()
        {
            string filter_spec;
            uint i;
            int ret;
            filter_ctx = (FilteringContext*)ffmpeg.av_malloc_array(ifmt_ctx->nb_streams, (ulong)sizeof(FilteringContext));
            if (filter_ctx == null)
                return ffmpeg.AVERROR(ffmpeg.ENOMEM);

            for (i = 0; i < ifmt_ctx->nb_streams; i++)
            {
                filter_ctx[i].buffersrc_ctx = null;
                filter_ctx[i].buffersink_ctx = null;
                filter_ctx[i].filter_graph = null;

                AVStream* in_stream = ifmt_ctx->streams[i];
                if (!(in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_AUDIO
                      || in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO))
                    continue;


                if (in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                    filter_spec = "null"; /* passthrough (dummy) filter for video */
                else
                    filter_spec = "anull"; /* passthrough (dummy) filter for audio */

                ret = init_filter(&filter_ctx[i], stream_ctx[i].dec_ctx, stream_ctx[i].enc_ctx, filter_spec);
                if (ret != 0)
                    return ret;
            }

            return 0;
        }

        int encode_write_frame(AVFrame* filt_frame, uint stream_index)
        {
            int ret;
            AVPacket* enc_pkt = ffmpeg.av_packet_alloc();

            int test = 0;
            var in_stream = ifmt_ctx->streams[stream_index];
            if (in_stream->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                test = 10;

            Console.WriteLine($"Test {test}");

            do
            {
                ffmpeg.avcodec_send_frame(stream_ctx[stream_index].enc_ctx, filt_frame);
                ret = ffmpeg.avcodec_receive_packet(stream_ctx[stream_index].enc_ctx, enc_pkt);
            } while (ret == ffmpeg.AVERROR(ffmpeg.EAGAIN));

            ffmpeg.av_frame_free(&filt_frame);

            if (ret < 0)
                return ret;

            /* prepare packet for muxing */
            enc_pkt->stream_index = (int)stream_index;
            ffmpeg.av_packet_rescale_ts(enc_pkt,
                stream_ctx[stream_index].enc_ctx->time_base,
                ofmt_ctx->streams[stream_index]->time_base);

            /* mux encoded frame */
            ret = ffmpeg.av_interleaved_write_frame(ofmt_ctx, enc_pkt);
            return ret;
        }

        int filter_encode_write_frame(AVFrame* frame, uint stream_index)
        {
            int ret;
            AVFrame* filt_frame;

            /* push the decoded frame into the filtergraph */
            ret = ffmpeg.av_buffersrc_add_frame_flags(filter_ctx[stream_index].buffersrc_ctx, frame, 0);
            if (ret < 0)
            {
                Console.WriteLine("Error while feeding the filtergraph");
                return ret;
            }

            /* pull filtered frames from the filtergraph */
            while (true)
            {
                filt_frame = ffmpeg.av_frame_alloc();
                if (filt_frame == null)
                {
                    ret = ffmpeg.AVERROR(ffmpeg.ENOMEM);
                    break;
                }

                ret = ffmpeg.av_buffersink_get_frame(filter_ctx[stream_index].buffersink_ctx, filt_frame);
                if (ret < 0)
                {
                    /* if no more frames for output - returns AVERROR(EAGAIN)
                     * if flushed and no more frames for output - returns AVERROR_EOF
                     * rewrite retcode to 0 to show it as normal procedure completion
                     */
                    if (ret == ffmpeg.AVERROR(ffmpeg.EAGAIN) ||
                        ret == ffmpeg.AVERROR_EOF)
                        ret = 0;

                    ffmpeg.av_frame_free(&filt_frame);
                    break;
                }

                filt_frame->pict_type = AVPictureType.AV_PICTURE_TYPE_NONE;
                ret = encode_write_frame(filt_frame, stream_index);
                if (ret < 0)
                    break;
            }

            return ret;
        }

        int flush_encoder(uint stream_index)
        {
            int ret;

            if ((stream_ctx[stream_index].enc_ctx->codec->capabilities &
                 ffmpeg.AV_CODEC_CAP_DELAY) == 0)
                return 0;

            while (true)
            {
                ret = encode_write_frame(null, stream_index);
                if (ret < 0)
                {
                    /* if flushed and no more packets for output - returns AVERROR_EOF
                    * rewrite retcode to 0 to show it as normal procedure completion 
                    */
                    if (ret == ffmpeg.AVERROR_EOF)
                        ret = 0;

                    break;
                }
            }

            return ret;
        }

        public int main(int argc, string[] argv)
        {
            int ret;
            AVPacket* packet = ffmpeg.av_packet_alloc();
            AVFrame* frame;
            uint stream_index;
            uint i;

            if (argc != 3)
            {
                Console.WriteLine($"Usage: {argv[0]} <input file> <output file>");
                return 1;
            }

            if ((ret = open_input_file(argv[1])) < 0)
                goto end;
            if ((ret = open_output_file(argv[2])) < 0)
                goto end;
            if ((ret = init_filters()) < 0)
                goto end;

            /* read all packets */
            while (true)
            {
                if ((ret = ffmpeg.av_read_frame(ifmt_ctx, packet)) < 0)
                    break;

                stream_index = (uint)packet->stream_index;
                if (filter_ctx[stream_index].filter_graph != null)
                {
                    frame = ffmpeg.av_frame_alloc();
                    if (frame == null)
                    {
                        ret = ffmpeg.AVERROR(ffmpeg.ENOMEM);
                        break;
                    }

                    ffmpeg.av_packet_rescale_ts(packet,
                        ifmt_ctx->streams[stream_index]->time_base,
                        stream_ctx[stream_index].dec_ctx->time_base);

                    do
                    {
                        ffmpeg.avcodec_send_packet(stream_ctx[stream_index].dec_ctx, packet);
                        ret = ffmpeg.avcodec_receive_frame(stream_ctx[stream_index].dec_ctx, frame);
                    } while (ret == ffmpeg.AVERROR(ffmpeg.EAGAIN));

                    if (ret < 0)
                    {
                        ffmpeg.av_frame_free(&frame);
                        Console.WriteLine("Decoding failed");
                        break;
                    }

                    if (frame != null)
                    {
                        if (frame->best_effort_timestamp > frame->pts)
                            frame->pts = frame->best_effort_timestamp;

                        ret = filter_encode_write_frame(frame, stream_index);
                        ffmpeg.av_frame_free(&frame);
                        if (ret < 0)
                            goto end;
                    }
                    else
                    {
                        ffmpeg.av_frame_free(&frame);
                    }
                }
                else
                {
                    if (stream_index >= ofmt_ctx->nb_streams)
                        continue;

                    /* remux this frame without reencoding */
                    //ffmpeg.av_packet_rescale_ts(packet,
                    //    ifmt_ctx->streams[stream_index]->time_base,
                    //    ofmt_ctx->streams[stream_index]->time_base);

                    ret = ffmpeg.av_interleaved_write_frame(ofmt_ctx, packet);
                    if (ret < 0)
                        goto end;
                }

                ffmpeg.av_packet_unref(packet);
            }

            /* flush filters and encoders */
            for (i = 0; i < ifmt_ctx->nb_streams; i++)
            {
                /* flush filter */
                if (filter_ctx[i].filter_graph == null)
                    continue;
                ret = filter_encode_write_frame(null, i);
                if (ret < 0)
                {
                    Console.WriteLine("Flushing filter failed");
                    goto end;
                }

                /* flush encoder */
                ret = flush_encoder(i);
                if (ret < 0)
                {
                    Console.WriteLine("Flushing encoder failed");
                    goto end;
                }
            }

            ffmpeg.av_write_trailer(ofmt_ctx);

        end:
            ffmpeg.av_packet_unref(packet);
            ffmpeg.av_packet_free(&packet);
            ffmpeg.av_frame_free(&frame);
            for (i = 0; i < ifmt_ctx->nb_streams; i++)
            {
                ffmpeg.avcodec_free_context(&stream_ctx[i].dec_ctx);
                if (ofmt_ctx != null && (ofmt_ctx->nb_streams > i) && ofmt_ctx->streams[i] != null && stream_ctx[i].enc_ctx != null)
                    ffmpeg.avcodec_free_context(&stream_ctx[i].enc_ctx);
                if (filter_ctx != null && filter_ctx[i].filter_graph != null)
                    ffmpeg.avfilter_graph_free(&filter_ctx[i].filter_graph);
            }

            ffmpeg.av_free(filter_ctx);
            ffmpeg.av_free(stream_ctx);

            AVFormatContext* ifmt_ctx_fixed = ifmt_ctx;
            ffmpeg.avformat_close_input(&ifmt_ctx_fixed);

            if (ofmt_ctx != null && (ofmt_ctx->oformat->flags & ffmpeg.AVFMT_NOFILE) == 0)
                ffmpeg.avio_closep(&ofmt_ctx->pb);
            ffmpeg.avformat_free_context(ofmt_ctx);

            if (ret < 0)
                Console.WriteLine($"Error occurred: {FFmpegHelper.av_strerror(ret)}");

            return ret != 0 ? 1 : 0;
        }
    }
}