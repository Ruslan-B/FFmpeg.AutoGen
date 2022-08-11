using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static IFunctionLocator FunctionLoader;
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVABufferSinkParams* av_abuffersink_params_alloc_delegate();
    public static av_abuffersink_params_alloc_delegate av_abuffersink_params_alloc = () =>
    {
        av_abuffersink_params_alloc = FunctionLoader.GetFunctionDelegate<av_abuffersink_params_alloc_delegate>("avfilter", "av_abuffersink_params_alloc");
        if (av_abuffersink_params_alloc == null)
        {
            av_abuffersink_params_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_abuffersink_params_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_add_index_entry_delegate(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
    public static av_add_index_entry_delegate av_add_index_entry = (AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags) =>
    {
        av_add_index_entry = FunctionLoader.GetFunctionDelegate<av_add_index_entry_delegate>("avformat", "av_add_index_entry");
        if (av_add_index_entry == null)
        {
            av_add_index_entry = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_add_index_entry(@st, @pos, @timestamp, @size, @distance, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_add_q_delegate(AVRational @b, AVRational @c);
    public static av_add_q_delegate av_add_q = (AVRational @b, AVRational @c) =>
    {
        av_add_q = FunctionLoader.GetFunctionDelegate<av_add_q_delegate>("avutil", "av_add_q");
        if (av_add_q == null)
        {
            av_add_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_add_q(@b, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_add_stable_delegate(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
    public static av_add_stable_delegate av_add_stable = (AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc) =>
    {
        av_add_stable = FunctionLoader.GetFunctionDelegate<av_add_stable_delegate>("avutil", "av_add_stable");
        if (av_add_stable == null)
        {
            av_add_stable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_add_stable(@ts_tb, @ts, @inc_tb, @inc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_append_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
    public static av_append_packet_delegate av_append_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
    {
        av_append_packet = FunctionLoader.GetFunctionDelegate<av_append_packet_delegate>("avformat", "av_append_packet");
        if (av_append_packet == null)
        {
            av_append_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_append_packet(@s, @pkt, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVAudioFifo* av_audio_fifo_alloc_delegate(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
    public static av_audio_fifo_alloc_delegate av_audio_fifo_alloc = (AVSampleFormat @sample_fmt, int @channels, int @nb_samples) =>
    {
        av_audio_fifo_alloc = FunctionLoader.GetFunctionDelegate<av_audio_fifo_alloc_delegate>("avutil", "av_audio_fifo_alloc");
        if (av_audio_fifo_alloc == null)
        {
            av_audio_fifo_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_alloc(@sample_fmt, @channels, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_drain_delegate(AVAudioFifo* @af, int @nb_samples);
    public static av_audio_fifo_drain_delegate av_audio_fifo_drain = (AVAudioFifo* @af, int @nb_samples) =>
    {
        av_audio_fifo_drain = FunctionLoader.GetFunctionDelegate<av_audio_fifo_drain_delegate>("avutil", "av_audio_fifo_drain");
        if (av_audio_fifo_drain == null)
        {
            av_audio_fifo_drain = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_drain(@af, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_audio_fifo_free_delegate(AVAudioFifo* @af);
    public static av_audio_fifo_free_delegate av_audio_fifo_free = (AVAudioFifo* @af) =>
    {
        av_audio_fifo_free = FunctionLoader.GetFunctionDelegate<av_audio_fifo_free_delegate>("avutil", "av_audio_fifo_free");
        if (av_audio_fifo_free == null)
        {
            av_audio_fifo_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_audio_fifo_free(@af);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_peek_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    public static av_audio_fifo_peek_delegate av_audio_fifo_peek = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
    {
        av_audio_fifo_peek = FunctionLoader.GetFunctionDelegate<av_audio_fifo_peek_delegate>("avutil", "av_audio_fifo_peek");
        if (av_audio_fifo_peek == null)
        {
            av_audio_fifo_peek = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_peek(@af, @data, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_peek_at_delegate(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
    public static av_audio_fifo_peek_at_delegate av_audio_fifo_peek_at = (AVAudioFifo* @af, void** @data, int @nb_samples, int @offset) =>
    {
        av_audio_fifo_peek_at = FunctionLoader.GetFunctionDelegate<av_audio_fifo_peek_at_delegate>("avutil", "av_audio_fifo_peek_at");
        if (av_audio_fifo_peek_at == null)
        {
            av_audio_fifo_peek_at = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_peek_at(@af, @data, @nb_samples, @offset);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_read_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    public static av_audio_fifo_read_delegate av_audio_fifo_read = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
    {
        av_audio_fifo_read = FunctionLoader.GetFunctionDelegate<av_audio_fifo_read_delegate>("avutil", "av_audio_fifo_read");
        if (av_audio_fifo_read == null)
        {
            av_audio_fifo_read = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_read(@af, @data, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_realloc_delegate(AVAudioFifo* @af, int @nb_samples);
    public static av_audio_fifo_realloc_delegate av_audio_fifo_realloc = (AVAudioFifo* @af, int @nb_samples) =>
    {
        av_audio_fifo_realloc = FunctionLoader.GetFunctionDelegate<av_audio_fifo_realloc_delegate>("avutil", "av_audio_fifo_realloc");
        if (av_audio_fifo_realloc == null)
        {
            av_audio_fifo_realloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_realloc(@af, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_audio_fifo_reset_delegate(AVAudioFifo* @af);
    public static av_audio_fifo_reset_delegate av_audio_fifo_reset = (AVAudioFifo* @af) =>
    {
        av_audio_fifo_reset = FunctionLoader.GetFunctionDelegate<av_audio_fifo_reset_delegate>("avutil", "av_audio_fifo_reset");
        if (av_audio_fifo_reset == null)
        {
            av_audio_fifo_reset = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_audio_fifo_reset(@af);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_size_delegate(AVAudioFifo* @af);
    public static av_audio_fifo_size_delegate av_audio_fifo_size = (AVAudioFifo* @af) =>
    {
        av_audio_fifo_size = FunctionLoader.GetFunctionDelegate<av_audio_fifo_size_delegate>("avutil", "av_audio_fifo_size");
        if (av_audio_fifo_size == null)
        {
            av_audio_fifo_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_size(@af);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_space_delegate(AVAudioFifo* @af);
    public static av_audio_fifo_space_delegate av_audio_fifo_space = (AVAudioFifo* @af) =>
    {
        av_audio_fifo_space = FunctionLoader.GetFunctionDelegate<av_audio_fifo_space_delegate>("avutil", "av_audio_fifo_space");
        if (av_audio_fifo_space == null)
        {
            av_audio_fifo_space = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_space(@af);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_audio_fifo_write_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    public static av_audio_fifo_write_delegate av_audio_fifo_write = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
    {
        av_audio_fifo_write = FunctionLoader.GetFunctionDelegate<av_audio_fifo_write_delegate>("avutil", "av_audio_fifo_write");
        if (av_audio_fifo_write == null)
        {
            av_audio_fifo_write = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_audio_fifo_write(@af, @data, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_bprint_channel_layout_delegate(AVBPrint* @bp, int @nb_channels, ulong @channel_layout);
    public static av_bprint_channel_layout_delegate av_bprint_channel_layout = (AVBPrint* @bp, int @nb_channels, ulong @channel_layout) =>
    {
        av_bprint_channel_layout = FunctionLoader.GetFunctionDelegate<av_bprint_channel_layout_delegate>("avutil", "av_bprint_channel_layout");
        if (av_bprint_channel_layout == null)
        {
            av_bprint_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_bprint_channel_layout(@bp, @nb_channels, @channel_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffer_alloc_delegate(ulong @size);
    public static av_buffer_alloc_delegate av_buffer_alloc = (ulong @size) =>
    {
        av_buffer_alloc = FunctionLoader.GetFunctionDelegate<av_buffer_alloc_delegate>("avutil", "av_buffer_alloc");
        if (av_buffer_alloc == null)
        {
            av_buffer_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_alloc(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffer_allocz_delegate(ulong @size);
    public static av_buffer_allocz_delegate av_buffer_allocz = (ulong @size) =>
    {
        av_buffer_allocz = FunctionLoader.GetFunctionDelegate<av_buffer_allocz_delegate>("avutil", "av_buffer_allocz");
        if (av_buffer_allocz == null)
        {
            av_buffer_allocz = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_allocz(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffer_create_delegate(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags);
    public static av_buffer_create_delegate av_buffer_create = (byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags) =>
    {
        av_buffer_create = FunctionLoader.GetFunctionDelegate<av_buffer_create_delegate>("avutil", "av_buffer_create");
        if (av_buffer_create == null)
        {
            av_buffer_create = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_create(@data, @size, @free, @opaque, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_buffer_default_free_delegate(void* @opaque, byte* @data);
    public static av_buffer_default_free_delegate av_buffer_default_free = (void* @opaque, byte* @data) =>
    {
        av_buffer_default_free = FunctionLoader.GetFunctionDelegate<av_buffer_default_free_delegate>("avutil", "av_buffer_default_free");
        if (av_buffer_default_free == null)
        {
            av_buffer_default_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_buffer_default_free(@opaque, @data);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_buffer_get_opaque_delegate(AVBufferRef* @buf);
    public static av_buffer_get_opaque_delegate av_buffer_get_opaque = (AVBufferRef* @buf) =>
    {
        av_buffer_get_opaque = FunctionLoader.GetFunctionDelegate<av_buffer_get_opaque_delegate>("avutil", "av_buffer_get_opaque");
        if (av_buffer_get_opaque == null)
        {
            av_buffer_get_opaque = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_get_opaque(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffer_get_ref_count_delegate(AVBufferRef* @buf);
    public static av_buffer_get_ref_count_delegate av_buffer_get_ref_count = (AVBufferRef* @buf) =>
    {
        av_buffer_get_ref_count = FunctionLoader.GetFunctionDelegate<av_buffer_get_ref_count_delegate>("avutil", "av_buffer_get_ref_count");
        if (av_buffer_get_ref_count == null)
        {
            av_buffer_get_ref_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_get_ref_count(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffer_is_writable_delegate(AVBufferRef* @buf);
    public static av_buffer_is_writable_delegate av_buffer_is_writable = (AVBufferRef* @buf) =>
    {
        av_buffer_is_writable = FunctionLoader.GetFunctionDelegate<av_buffer_is_writable_delegate>("avutil", "av_buffer_is_writable");
        if (av_buffer_is_writable == null)
        {
            av_buffer_is_writable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_is_writable(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffer_make_writable_delegate(AVBufferRef** @buf);
    public static av_buffer_make_writable_delegate av_buffer_make_writable = (AVBufferRef** @buf) =>
    {
        av_buffer_make_writable = FunctionLoader.GetFunctionDelegate<av_buffer_make_writable_delegate>("avutil", "av_buffer_make_writable");
        if (av_buffer_make_writable == null)
        {
            av_buffer_make_writable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_make_writable(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_buffer_pool_buffer_get_opaque_delegate(AVBufferRef* @ref);
    public static av_buffer_pool_buffer_get_opaque_delegate av_buffer_pool_buffer_get_opaque = (AVBufferRef* @ref) =>
    {
        av_buffer_pool_buffer_get_opaque = FunctionLoader.GetFunctionDelegate<av_buffer_pool_buffer_get_opaque_delegate>("avutil", "av_buffer_pool_buffer_get_opaque");
        if (av_buffer_pool_buffer_get_opaque == null)
        {
            av_buffer_pool_buffer_get_opaque = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_pool_buffer_get_opaque(@ref);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffer_pool_get_delegate(AVBufferPool* @pool);
    public static av_buffer_pool_get_delegate av_buffer_pool_get = (AVBufferPool* @pool) =>
    {
        av_buffer_pool_get = FunctionLoader.GetFunctionDelegate<av_buffer_pool_get_delegate>("avutil", "av_buffer_pool_get");
        if (av_buffer_pool_get == null)
        {
            av_buffer_pool_get = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_pool_get(@pool);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferPool* av_buffer_pool_init_delegate(ulong @size, av_buffer_pool_init_alloc_func @alloc);
    public static av_buffer_pool_init_delegate av_buffer_pool_init = (ulong @size, av_buffer_pool_init_alloc_func @alloc) =>
    {
        av_buffer_pool_init = FunctionLoader.GetFunctionDelegate<av_buffer_pool_init_delegate>("avutil", "av_buffer_pool_init");
        if (av_buffer_pool_init == null)
        {
            av_buffer_pool_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_pool_init(@size, @alloc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferPool* av_buffer_pool_init2_delegate(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);
    public static av_buffer_pool_init2_delegate av_buffer_pool_init2 = (ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free) =>
    {
        av_buffer_pool_init2 = FunctionLoader.GetFunctionDelegate<av_buffer_pool_init2_delegate>("avutil", "av_buffer_pool_init2");
        if (av_buffer_pool_init2 == null)
        {
            av_buffer_pool_init2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_pool_init2(@size, @opaque, @alloc, @pool_free);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_buffer_pool_uninit_delegate(AVBufferPool** @pool);
    public static av_buffer_pool_uninit_delegate av_buffer_pool_uninit = (AVBufferPool** @pool) =>
    {
        av_buffer_pool_uninit = FunctionLoader.GetFunctionDelegate<av_buffer_pool_uninit_delegate>("avutil", "av_buffer_pool_uninit");
        if (av_buffer_pool_uninit == null)
        {
            av_buffer_pool_uninit = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_buffer_pool_uninit(@pool);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffer_realloc_delegate(AVBufferRef** @buf, ulong @size);
    public static av_buffer_realloc_delegate av_buffer_realloc = (AVBufferRef** @buf, ulong @size) =>
    {
        av_buffer_realloc = FunctionLoader.GetFunctionDelegate<av_buffer_realloc_delegate>("avutil", "av_buffer_realloc");
        if (av_buffer_realloc == null)
        {
            av_buffer_realloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_realloc(@buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffer_ref_delegate(AVBufferRef* @buf);
    public static av_buffer_ref_delegate av_buffer_ref = (AVBufferRef* @buf) =>
    {
        av_buffer_ref = FunctionLoader.GetFunctionDelegate<av_buffer_ref_delegate>("avutil", "av_buffer_ref");
        if (av_buffer_ref == null)
        {
            av_buffer_ref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_ref(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffer_replace_delegate(AVBufferRef** @dst, AVBufferRef* @src);
    public static av_buffer_replace_delegate av_buffer_replace = (AVBufferRef** @dst, AVBufferRef* @src) =>
    {
        av_buffer_replace = FunctionLoader.GetFunctionDelegate<av_buffer_replace_delegate>("avutil", "av_buffer_replace");
        if (av_buffer_replace == null)
        {
            av_buffer_replace = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffer_replace(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_buffer_unref_delegate(AVBufferRef** @buf);
    public static av_buffer_unref_delegate av_buffer_unref = (AVBufferRef** @buf) =>
    {
        av_buffer_unref = FunctionLoader.GetFunctionDelegate<av_buffer_unref_delegate>("avutil", "av_buffer_unref");
        if (av_buffer_unref == null)
        {
            av_buffer_unref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_buffer_unref(@buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_ch_layout_delegate(AVFilterContext* @ctx, AVChannelLayout* @ch_layout);
    public static av_buffersink_get_ch_layout_delegate av_buffersink_get_ch_layout = (AVFilterContext* @ctx, AVChannelLayout* @ch_layout) =>
    {
        av_buffersink_get_ch_layout = FunctionLoader.GetFunctionDelegate<av_buffersink_get_ch_layout_delegate>("avfilter", "av_buffersink_get_ch_layout");
        if (av_buffersink_get_ch_layout == null)
        {
            av_buffersink_get_ch_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_ch_layout(@ctx, @ch_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong av_buffersink_get_channel_layout_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_channel_layout_delegate av_buffersink_get_channel_layout = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_channel_layout = FunctionLoader.GetFunctionDelegate<av_buffersink_get_channel_layout_delegate>("avfilter", "av_buffersink_get_channel_layout");
        if (av_buffersink_get_channel_layout == null)
        {
            av_buffersink_get_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_channel_layout(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_channels_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_channels_delegate av_buffersink_get_channels = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_channels = FunctionLoader.GetFunctionDelegate<av_buffersink_get_channels_delegate>("avfilter", "av_buffersink_get_channels");
        if (av_buffersink_get_channels == null)
        {
            av_buffersink_get_channels = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_channels(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_format_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_format_delegate av_buffersink_get_format = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_format = FunctionLoader.GetFunctionDelegate<av_buffersink_get_format_delegate>("avfilter", "av_buffersink_get_format");
        if (av_buffersink_get_format == null)
        {
            av_buffersink_get_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_format(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    public static av_buffersink_get_frame_delegate av_buffersink_get_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
    {
        av_buffersink_get_frame = FunctionLoader.GetFunctionDelegate<av_buffersink_get_frame_delegate>("avfilter", "av_buffersink_get_frame");
        if (av_buffersink_get_frame == null)
        {
            av_buffersink_get_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_frame(@ctx, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_frame_flags_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
    public static av_buffersink_get_frame_flags_delegate av_buffersink_get_frame_flags = (AVFilterContext* @ctx, AVFrame* @frame, int @flags) =>
    {
        av_buffersink_get_frame_flags = FunctionLoader.GetFunctionDelegate<av_buffersink_get_frame_flags_delegate>("avfilter", "av_buffersink_get_frame_flags");
        if (av_buffersink_get_frame_flags == null)
        {
            av_buffersink_get_frame_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_frame_flags(@ctx, @frame, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_buffersink_get_frame_rate_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_frame_rate_delegate av_buffersink_get_frame_rate = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_frame_rate = FunctionLoader.GetFunctionDelegate<av_buffersink_get_frame_rate_delegate>("avfilter", "av_buffersink_get_frame_rate");
        if (av_buffersink_get_frame_rate == null)
        {
            av_buffersink_get_frame_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_frame_rate(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_h_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_h_delegate av_buffersink_get_h = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_h = FunctionLoader.GetFunctionDelegate<av_buffersink_get_h_delegate>("avfilter", "av_buffersink_get_h");
        if (av_buffersink_get_h == null)
        {
            av_buffersink_get_h = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_h(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_buffersink_get_hw_frames_ctx_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_hw_frames_ctx_delegate av_buffersink_get_hw_frames_ctx = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_hw_frames_ctx = FunctionLoader.GetFunctionDelegate<av_buffersink_get_hw_frames_ctx_delegate>("avfilter", "av_buffersink_get_hw_frames_ctx");
        if (av_buffersink_get_hw_frames_ctx == null)
        {
            av_buffersink_get_hw_frames_ctx = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_hw_frames_ctx(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_buffersink_get_sample_aspect_ratio_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_sample_aspect_ratio_delegate av_buffersink_get_sample_aspect_ratio = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_sample_aspect_ratio = FunctionLoader.GetFunctionDelegate<av_buffersink_get_sample_aspect_ratio_delegate>("avfilter", "av_buffersink_get_sample_aspect_ratio");
        if (av_buffersink_get_sample_aspect_ratio == null)
        {
            av_buffersink_get_sample_aspect_ratio = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_sample_aspect_ratio(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_sample_rate_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_sample_rate_delegate av_buffersink_get_sample_rate = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_sample_rate = FunctionLoader.GetFunctionDelegate<av_buffersink_get_sample_rate_delegate>("avfilter", "av_buffersink_get_sample_rate");
        if (av_buffersink_get_sample_rate == null)
        {
            av_buffersink_get_sample_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_sample_rate(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_samples_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
    public static av_buffersink_get_samples_delegate av_buffersink_get_samples = (AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples) =>
    {
        av_buffersink_get_samples = FunctionLoader.GetFunctionDelegate<av_buffersink_get_samples_delegate>("avfilter", "av_buffersink_get_samples");
        if (av_buffersink_get_samples == null)
        {
            av_buffersink_get_samples = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_samples(@ctx, @frame, @nb_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_buffersink_get_time_base_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_time_base_delegate av_buffersink_get_time_base = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_time_base = FunctionLoader.GetFunctionDelegate<av_buffersink_get_time_base_delegate>("avfilter", "av_buffersink_get_time_base");
        if (av_buffersink_get_time_base == null)
        {
            av_buffersink_get_time_base = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_time_base(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVMediaType av_buffersink_get_type_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_type_delegate av_buffersink_get_type = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_type = FunctionLoader.GetFunctionDelegate<av_buffersink_get_type_delegate>("avfilter", "av_buffersink_get_type");
        if (av_buffersink_get_type == null)
        {
            av_buffersink_get_type = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_type(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersink_get_w_delegate(AVFilterContext* @ctx);
    public static av_buffersink_get_w_delegate av_buffersink_get_w = (AVFilterContext* @ctx) =>
    {
        av_buffersink_get_w = FunctionLoader.GetFunctionDelegate<av_buffersink_get_w_delegate>("avfilter", "av_buffersink_get_w");
        if (av_buffersink_get_w == null)
        {
            av_buffersink_get_w = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_get_w(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferSinkParams* av_buffersink_params_alloc_delegate();
    public static av_buffersink_params_alloc_delegate av_buffersink_params_alloc = () =>
    {
        av_buffersink_params_alloc = FunctionLoader.GetFunctionDelegate<av_buffersink_params_alloc_delegate>("avfilter", "av_buffersink_params_alloc");
        if (av_buffersink_params_alloc == null)
        {
            av_buffersink_params_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersink_params_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_buffersink_set_frame_size_delegate(AVFilterContext* @ctx, uint @frame_size);
    public static av_buffersink_set_frame_size_delegate av_buffersink_set_frame_size = (AVFilterContext* @ctx, uint @frame_size) =>
    {
        av_buffersink_set_frame_size = FunctionLoader.GetFunctionDelegate<av_buffersink_set_frame_size_delegate>("avfilter", "av_buffersink_set_frame_size");
        if (av_buffersink_set_frame_size == null)
        {
            av_buffersink_set_frame_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_buffersink_set_frame_size(@ctx, @frame_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersrc_add_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    public static av_buffersrc_add_frame_delegate av_buffersrc_add_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
    {
        av_buffersrc_add_frame = FunctionLoader.GetFunctionDelegate<av_buffersrc_add_frame_delegate>("avfilter", "av_buffersrc_add_frame");
        if (av_buffersrc_add_frame == null)
        {
            av_buffersrc_add_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_add_frame(@ctx, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersrc_add_frame_flags_delegate(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
    public static av_buffersrc_add_frame_flags_delegate av_buffersrc_add_frame_flags = (AVFilterContext* @buffer_src, AVFrame* @frame, int @flags) =>
    {
        av_buffersrc_add_frame_flags = FunctionLoader.GetFunctionDelegate<av_buffersrc_add_frame_flags_delegate>("avfilter", "av_buffersrc_add_frame_flags");
        if (av_buffersrc_add_frame_flags == null)
        {
            av_buffersrc_add_frame_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_add_frame_flags(@buffer_src, @frame, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersrc_close_delegate(AVFilterContext* @ctx, long @pts, uint @flags);
    public static av_buffersrc_close_delegate av_buffersrc_close = (AVFilterContext* @ctx, long @pts, uint @flags) =>
    {
        av_buffersrc_close = FunctionLoader.GetFunctionDelegate<av_buffersrc_close_delegate>("avfilter", "av_buffersrc_close");
        if (av_buffersrc_close == null)
        {
            av_buffersrc_close = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_close(@ctx, @pts, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_buffersrc_get_nb_failed_requests_delegate(AVFilterContext* @buffer_src);
    public static av_buffersrc_get_nb_failed_requests_delegate av_buffersrc_get_nb_failed_requests = (AVFilterContext* @buffer_src) =>
    {
        av_buffersrc_get_nb_failed_requests = FunctionLoader.GetFunctionDelegate<av_buffersrc_get_nb_failed_requests_delegate>("avfilter", "av_buffersrc_get_nb_failed_requests");
        if (av_buffersrc_get_nb_failed_requests == null)
        {
            av_buffersrc_get_nb_failed_requests = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_get_nb_failed_requests(@buffer_src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferSrcParameters* av_buffersrc_parameters_alloc_delegate();
    public static av_buffersrc_parameters_alloc_delegate av_buffersrc_parameters_alloc = () =>
    {
        av_buffersrc_parameters_alloc = FunctionLoader.GetFunctionDelegate<av_buffersrc_parameters_alloc_delegate>("avfilter", "av_buffersrc_parameters_alloc");
        if (av_buffersrc_parameters_alloc == null)
        {
            av_buffersrc_parameters_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_parameters_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersrc_parameters_set_delegate(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
    public static av_buffersrc_parameters_set_delegate av_buffersrc_parameters_set = (AVFilterContext* @ctx, AVBufferSrcParameters* @param) =>
    {
        av_buffersrc_parameters_set = FunctionLoader.GetFunctionDelegate<av_buffersrc_parameters_set_delegate>("avfilter", "av_buffersrc_parameters_set");
        if (av_buffersrc_parameters_set == null)
        {
            av_buffersrc_parameters_set = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_parameters_set(@ctx, @param);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_buffersrc_write_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    public static av_buffersrc_write_frame_delegate av_buffersrc_write_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
    {
        av_buffersrc_write_frame = FunctionLoader.GetFunctionDelegate<av_buffersrc_write_frame_delegate>("avfilter", "av_buffersrc_write_frame");
        if (av_buffersrc_write_frame == null)
        {
            av_buffersrc_write_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_buffersrc_write_frame(@ctx, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_calloc_delegate(ulong @nmemb, ulong @size);
    public static av_calloc_delegate av_calloc = (ulong @nmemb, ulong @size) =>
    {
        av_calloc = FunctionLoader.GetFunctionDelegate<av_calloc_delegate>("avutil", "av_calloc");
        if (av_calloc == null)
        {
            av_calloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_calloc(@nmemb, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_description_delegate(byte* @buf, ulong @buf_size, AVChannel @channel);
    public static av_channel_description_delegate av_channel_description = (byte* @buf, ulong @buf_size, AVChannel @channel) =>
    {
        av_channel_description = FunctionLoader.GetFunctionDelegate<av_channel_description_delegate>("avutil", "av_channel_description");
        if (av_channel_description == null)
        {
            av_channel_description = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_description(@buf, @buf_size, @channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_channel_description_bprint_delegate(AVBPrint* @bp, AVChannel @channel_id);
    public static av_channel_description_bprint_delegate av_channel_description_bprint = (AVBPrint* @bp, AVChannel @channel_id) =>
    {
        av_channel_description_bprint = FunctionLoader.GetFunctionDelegate<av_channel_description_bprint_delegate>("avutil", "av_channel_description_bprint");
        if (av_channel_description_bprint == null)
        {
            av_channel_description_bprint = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_channel_description_bprint(@bp, @channel_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVChannel av_channel_from_string_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_channel_from_string_delegate av_channel_from_string = (string @name) =>
    {
        av_channel_from_string = FunctionLoader.GetFunctionDelegate<av_channel_from_string_delegate>("avutil", "av_channel_from_string");
        if (av_channel_from_string == null)
        {
            av_channel_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_from_string(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVChannel av_channel_layout_channel_from_index_delegate(AVChannelLayout* @channel_layout, uint @idx);
    public static av_channel_layout_channel_from_index_delegate av_channel_layout_channel_from_index = (AVChannelLayout* @channel_layout, uint @idx) =>
    {
        av_channel_layout_channel_from_index = FunctionLoader.GetFunctionDelegate<av_channel_layout_channel_from_index_delegate>("avutil", "av_channel_layout_channel_from_index");
        if (av_channel_layout_channel_from_index == null)
        {
            av_channel_layout_channel_from_index = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_channel_from_index(@channel_layout, @idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVChannel av_channel_layout_channel_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_channel_layout_channel_from_string_delegate av_channel_layout_channel_from_string = (AVChannelLayout* @channel_layout, string @name) =>
    {
        av_channel_layout_channel_from_string = FunctionLoader.GetFunctionDelegate<av_channel_layout_channel_from_string_delegate>("avutil", "av_channel_layout_channel_from_string");
        if (av_channel_layout_channel_from_string == null)
        {
            av_channel_layout_channel_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_channel_from_string(@channel_layout, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_check_delegate(AVChannelLayout* @channel_layout);
    public static av_channel_layout_check_delegate av_channel_layout_check = (AVChannelLayout* @channel_layout) =>
    {
        av_channel_layout_check = FunctionLoader.GetFunctionDelegate<av_channel_layout_check_delegate>("avutil", "av_channel_layout_check");
        if (av_channel_layout_check == null)
        {
            av_channel_layout_check = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_check(@channel_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_compare_delegate(AVChannelLayout* @chl, AVChannelLayout* @chl1);
    public static av_channel_layout_compare_delegate av_channel_layout_compare = (AVChannelLayout* @chl, AVChannelLayout* @chl1) =>
    {
        av_channel_layout_compare = FunctionLoader.GetFunctionDelegate<av_channel_layout_compare_delegate>("avutil", "av_channel_layout_compare");
        if (av_channel_layout_compare == null)
        {
            av_channel_layout_compare = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_compare(@chl, @chl1);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_copy_delegate(AVChannelLayout* @dst, AVChannelLayout* @src);
    public static av_channel_layout_copy_delegate av_channel_layout_copy = (AVChannelLayout* @dst, AVChannelLayout* @src) =>
    {
        av_channel_layout_copy = FunctionLoader.GetFunctionDelegate<av_channel_layout_copy_delegate>("avutil", "av_channel_layout_copy");
        if (av_channel_layout_copy == null)
        {
            av_channel_layout_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_copy(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_channel_layout_default_delegate(AVChannelLayout* @ch_layout, int @nb_channels);
    public static av_channel_layout_default_delegate av_channel_layout_default = (AVChannelLayout* @ch_layout, int @nb_channels) =>
    {
        av_channel_layout_default = FunctionLoader.GetFunctionDelegate<av_channel_layout_default_delegate>("avutil", "av_channel_layout_default");
        if (av_channel_layout_default == null)
        {
            av_channel_layout_default = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_channel_layout_default(@ch_layout, @nb_channels);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_describe_delegate(AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size);
    public static av_channel_layout_describe_delegate av_channel_layout_describe = (AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size) =>
    {
        av_channel_layout_describe = FunctionLoader.GetFunctionDelegate<av_channel_layout_describe_delegate>("avutil", "av_channel_layout_describe");
        if (av_channel_layout_describe == null)
        {
            av_channel_layout_describe = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_describe(@channel_layout, @buf, @buf_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_describe_bprint_delegate(AVChannelLayout* @channel_layout, AVBPrint* @bp);
    public static av_channel_layout_describe_bprint_delegate av_channel_layout_describe_bprint = (AVChannelLayout* @channel_layout, AVBPrint* @bp) =>
    {
        av_channel_layout_describe_bprint = FunctionLoader.GetFunctionDelegate<av_channel_layout_describe_bprint_delegate>("avutil", "av_channel_layout_describe_bprint");
        if (av_channel_layout_describe_bprint == null)
        {
            av_channel_layout_describe_bprint = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_describe_bprint(@channel_layout, @bp);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong av_channel_layout_extract_channel_delegate(ulong @channel_layout, int @index);
    public static av_channel_layout_extract_channel_delegate av_channel_layout_extract_channel = (ulong @channel_layout, int @index) =>
    {
        av_channel_layout_extract_channel = FunctionLoader.GetFunctionDelegate<av_channel_layout_extract_channel_delegate>("avutil", "av_channel_layout_extract_channel");
        if (av_channel_layout_extract_channel == null)
        {
            av_channel_layout_extract_channel = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_extract_channel(@channel_layout, @index);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_from_mask_delegate(AVChannelLayout* @channel_layout, ulong @mask);
    public static av_channel_layout_from_mask_delegate av_channel_layout_from_mask = (AVChannelLayout* @channel_layout, ulong @mask) =>
    {
        av_channel_layout_from_mask = FunctionLoader.GetFunctionDelegate<av_channel_layout_from_mask_delegate>("avutil", "av_channel_layout_from_mask");
        if (av_channel_layout_from_mask == null)
        {
            av_channel_layout_from_mask = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_from_mask(@channel_layout, @mask);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    public static av_channel_layout_from_string_delegate av_channel_layout_from_string = (AVChannelLayout* @channel_layout, string @str) =>
    {
        av_channel_layout_from_string = FunctionLoader.GetFunctionDelegate<av_channel_layout_from_string_delegate>("avutil", "av_channel_layout_from_string");
        if (av_channel_layout_from_string == null)
        {
            av_channel_layout_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_from_string(@channel_layout, @str);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_index_from_channel_delegate(AVChannelLayout* @channel_layout, AVChannel @channel);
    public static av_channel_layout_index_from_channel_delegate av_channel_layout_index_from_channel = (AVChannelLayout* @channel_layout, AVChannel @channel) =>
    {
        av_channel_layout_index_from_channel = FunctionLoader.GetFunctionDelegate<av_channel_layout_index_from_channel_delegate>("avutil", "av_channel_layout_index_from_channel");
        if (av_channel_layout_index_from_channel == null)
        {
            av_channel_layout_index_from_channel = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_index_from_channel(@channel_layout, @channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_layout_index_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_channel_layout_index_from_string_delegate av_channel_layout_index_from_string = (AVChannelLayout* @channel_layout, string @name) =>
    {
        av_channel_layout_index_from_string = FunctionLoader.GetFunctionDelegate<av_channel_layout_index_from_string_delegate>("avutil", "av_channel_layout_index_from_string");
        if (av_channel_layout_index_from_string == null)
        {
            av_channel_layout_index_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_index_from_string(@channel_layout, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVChannelLayout* av_channel_layout_standard_delegate(void** @opaque);
    public static av_channel_layout_standard_delegate av_channel_layout_standard = (void** @opaque) =>
    {
        av_channel_layout_standard = FunctionLoader.GetFunctionDelegate<av_channel_layout_standard_delegate>("avutil", "av_channel_layout_standard");
        if (av_channel_layout_standard == null)
        {
            av_channel_layout_standard = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_standard(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong av_channel_layout_subset_delegate(AVChannelLayout* @channel_layout, ulong @mask);
    public static av_channel_layout_subset_delegate av_channel_layout_subset = (AVChannelLayout* @channel_layout, ulong @mask) =>
    {
        av_channel_layout_subset = FunctionLoader.GetFunctionDelegate<av_channel_layout_subset_delegate>("avutil", "av_channel_layout_subset");
        if (av_channel_layout_subset == null)
        {
            av_channel_layout_subset = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_layout_subset(@channel_layout, @mask);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_channel_layout_uninit_delegate(AVChannelLayout* @channel_layout);
    public static av_channel_layout_uninit_delegate av_channel_layout_uninit = (AVChannelLayout* @channel_layout) =>
    {
        av_channel_layout_uninit = FunctionLoader.GetFunctionDelegate<av_channel_layout_uninit_delegate>("avutil", "av_channel_layout_uninit");
        if (av_channel_layout_uninit == null)
        {
            av_channel_layout_uninit = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_channel_layout_uninit(@channel_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_channel_name_delegate(byte* @buf, ulong @buf_size, AVChannel @channel);
    public static av_channel_name_delegate av_channel_name = (byte* @buf, ulong @buf_size, AVChannel @channel) =>
    {
        av_channel_name = FunctionLoader.GetFunctionDelegate<av_channel_name_delegate>("avutil", "av_channel_name");
        if (av_channel_name == null)
        {
            av_channel_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_channel_name(@buf, @buf_size, @channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_channel_name_bprint_delegate(AVBPrint* @bp, AVChannel @channel_id);
    public static av_channel_name_bprint_delegate av_channel_name_bprint = (AVBPrint* @bp, AVChannel @channel_id) =>
    {
        av_channel_name_bprint = FunctionLoader.GetFunctionDelegate<av_channel_name_bprint_delegate>("avutil", "av_channel_name_bprint");
        if (av_channel_name_bprint == null)
        {
            av_channel_name_bprint = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_channel_name_bprint(@bp, @channel_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_chroma_location_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_chroma_location_from_name_delegate av_chroma_location_from_name = (string @name) =>
    {
        av_chroma_location_from_name = FunctionLoader.GetFunctionDelegate<av_chroma_location_from_name_delegate>("avutil", "av_chroma_location_from_name");
        if (av_chroma_location_from_name == null)
        {
            av_chroma_location_from_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_chroma_location_from_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_chroma_location_name_delegate(AVChromaLocation @location);
    public static av_chroma_location_name_delegate av_chroma_location_name = (AVChromaLocation @location) =>
    {
        av_chroma_location_name = FunctionLoader.GetFunctionDelegate<av_chroma_location_name_delegate>("avutil", "av_chroma_location_name");
        if (av_chroma_location_name == null)
        {
            av_chroma_location_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_chroma_location_name(@location);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecID av_codec_get_id_delegate(AVCodecTag** @tags, uint @tag);
    public static av_codec_get_id_delegate av_codec_get_id = (AVCodecTag** @tags, uint @tag) =>
    {
        av_codec_get_id = FunctionLoader.GetFunctionDelegate<av_codec_get_id_delegate>("avformat", "av_codec_get_id");
        if (av_codec_get_id == null)
        {
            av_codec_get_id = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_get_id(@tags, @tag);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_codec_get_tag_delegate(AVCodecTag** @tags, AVCodecID @id);
    public static av_codec_get_tag_delegate av_codec_get_tag = (AVCodecTag** @tags, AVCodecID @id) =>
    {
        av_codec_get_tag = FunctionLoader.GetFunctionDelegate<av_codec_get_tag_delegate>("avformat", "av_codec_get_tag");
        if (av_codec_get_tag == null)
        {
            av_codec_get_tag = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_get_tag(@tags, @id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_codec_get_tag2_delegate(AVCodecTag** @tags, AVCodecID @id, uint* @tag);
    public static av_codec_get_tag2_delegate av_codec_get_tag2 = (AVCodecTag** @tags, AVCodecID @id, uint* @tag) =>
    {
        av_codec_get_tag2 = FunctionLoader.GetFunctionDelegate<av_codec_get_tag2_delegate>("avformat", "av_codec_get_tag2");
        if (av_codec_get_tag2 == null)
        {
            av_codec_get_tag2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_get_tag2(@tags, @id, @tag);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_codec_is_decoder_delegate(AVCodec* @codec);
    public static av_codec_is_decoder_delegate av_codec_is_decoder = (AVCodec* @codec) =>
    {
        av_codec_is_decoder = FunctionLoader.GetFunctionDelegate<av_codec_is_decoder_delegate>("avcodec", "av_codec_is_decoder");
        if (av_codec_is_decoder == null)
        {
            av_codec_is_decoder = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_is_decoder(@codec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_codec_is_encoder_delegate(AVCodec* @codec);
    public static av_codec_is_encoder_delegate av_codec_is_encoder = (AVCodec* @codec) =>
    {
        av_codec_is_encoder = FunctionLoader.GetFunctionDelegate<av_codec_is_encoder_delegate>("avcodec", "av_codec_is_encoder");
        if (av_codec_is_encoder == null)
        {
            av_codec_is_encoder = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_is_encoder(@codec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodec* av_codec_iterate_delegate(void** @opaque);
    public static av_codec_iterate_delegate av_codec_iterate = (void** @opaque) =>
    {
        av_codec_iterate = FunctionLoader.GetFunctionDelegate<av_codec_iterate_delegate>("avcodec", "av_codec_iterate");
        if (av_codec_iterate == null)
        {
            av_codec_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_codec_iterate(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_color_primaries_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_color_primaries_from_name_delegate av_color_primaries_from_name = (string @name) =>
    {
        av_color_primaries_from_name = FunctionLoader.GetFunctionDelegate<av_color_primaries_from_name_delegate>("avutil", "av_color_primaries_from_name");
        if (av_color_primaries_from_name == null)
        {
            av_color_primaries_from_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_primaries_from_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_color_primaries_name_delegate(AVColorPrimaries @primaries);
    public static av_color_primaries_name_delegate av_color_primaries_name = (AVColorPrimaries @primaries) =>
    {
        av_color_primaries_name = FunctionLoader.GetFunctionDelegate<av_color_primaries_name_delegate>("avutil", "av_color_primaries_name");
        if (av_color_primaries_name == null)
        {
            av_color_primaries_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_primaries_name(@primaries);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_color_range_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_color_range_from_name_delegate av_color_range_from_name = (string @name) =>
    {
        av_color_range_from_name = FunctionLoader.GetFunctionDelegate<av_color_range_from_name_delegate>("avutil", "av_color_range_from_name");
        if (av_color_range_from_name == null)
        {
            av_color_range_from_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_range_from_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_color_range_name_delegate(AVColorRange @range);
    public static av_color_range_name_delegate av_color_range_name = (AVColorRange @range) =>
    {
        av_color_range_name = FunctionLoader.GetFunctionDelegate<av_color_range_name_delegate>("avutil", "av_color_range_name");
        if (av_color_range_name == null)
        {
            av_color_range_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_range_name(@range);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_color_space_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_color_space_from_name_delegate av_color_space_from_name = (string @name) =>
    {
        av_color_space_from_name = FunctionLoader.GetFunctionDelegate<av_color_space_from_name_delegate>("avutil", "av_color_space_from_name");
        if (av_color_space_from_name == null)
        {
            av_color_space_from_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_space_from_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_color_space_name_delegate(AVColorSpace @space);
    public static av_color_space_name_delegate av_color_space_name = (AVColorSpace @space) =>
    {
        av_color_space_name = FunctionLoader.GetFunctionDelegate<av_color_space_name_delegate>("avutil", "av_color_space_name");
        if (av_color_space_name == null)
        {
            av_color_space_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_space_name(@space);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_color_transfer_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_color_transfer_from_name_delegate av_color_transfer_from_name = (string @name) =>
    {
        av_color_transfer_from_name = FunctionLoader.GetFunctionDelegate<av_color_transfer_from_name_delegate>("avutil", "av_color_transfer_from_name");
        if (av_color_transfer_from_name == null)
        {
            av_color_transfer_from_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_transfer_from_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_color_transfer_name_delegate(AVColorTransferCharacteristic @transfer);
    public static av_color_transfer_name_delegate av_color_transfer_name = (AVColorTransferCharacteristic @transfer) =>
    {
        av_color_transfer_name = FunctionLoader.GetFunctionDelegate<av_color_transfer_name_delegate>("avutil", "av_color_transfer_name");
        if (av_color_transfer_name == null)
        {
            av_color_transfer_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_color_transfer_name(@transfer);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_compare_mod_delegate(ulong @a, ulong @b, ulong @mod);
    public static av_compare_mod_delegate av_compare_mod = (ulong @a, ulong @b, ulong @mod) =>
    {
        av_compare_mod = FunctionLoader.GetFunctionDelegate<av_compare_mod_delegate>("avutil", "av_compare_mod");
        if (av_compare_mod == null)
        {
            av_compare_mod = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_compare_mod(@a, @b, @mod);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_compare_ts_delegate(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
    public static av_compare_ts_delegate av_compare_ts = (long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b) =>
    {
        av_compare_ts = FunctionLoader.GetFunctionDelegate<av_compare_ts_delegate>("avutil", "av_compare_ts");
        if (av_compare_ts == null)
        {
            av_compare_ts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_compare_ts(@ts_a, @tb_a, @ts_b, @tb_b);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVContentLightMetadata* av_content_light_metadata_alloc_delegate(ulong* @size);
    public static av_content_light_metadata_alloc_delegate av_content_light_metadata_alloc = (ulong* @size) =>
    {
        av_content_light_metadata_alloc = FunctionLoader.GetFunctionDelegate<av_content_light_metadata_alloc_delegate>("avutil", "av_content_light_metadata_alloc");
        if (av_content_light_metadata_alloc == null)
        {
            av_content_light_metadata_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_content_light_metadata_alloc(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVContentLightMetadata* av_content_light_metadata_create_side_data_delegate(AVFrame* @frame);
    public static av_content_light_metadata_create_side_data_delegate av_content_light_metadata_create_side_data = (AVFrame* @frame) =>
    {
        av_content_light_metadata_create_side_data = FunctionLoader.GetFunctionDelegate<av_content_light_metadata_create_side_data_delegate>("avutil", "av_content_light_metadata_create_side_data");
        if (av_content_light_metadata_create_side_data == null)
        {
            av_content_light_metadata_create_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_content_light_metadata_create_side_data(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCPBProperties* av_cpb_properties_alloc_delegate(ulong* @size);
    public static av_cpb_properties_alloc_delegate av_cpb_properties_alloc = (ulong* @size) =>
    {
        av_cpb_properties_alloc = FunctionLoader.GetFunctionDelegate<av_cpb_properties_alloc_delegate>("avcodec", "av_cpb_properties_alloc");
        if (av_cpb_properties_alloc == null)
        {
            av_cpb_properties_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_cpb_properties_alloc(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_cpu_count_delegate();
    public static av_cpu_count_delegate av_cpu_count = () =>
    {
        av_cpu_count = FunctionLoader.GetFunctionDelegate<av_cpu_count_delegate>("avutil", "av_cpu_count");
        if (av_cpu_count == null)
        {
            av_cpu_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_cpu_count();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_cpu_force_count_delegate(int @count);
    public static av_cpu_force_count_delegate av_cpu_force_count = (int @count) =>
    {
        av_cpu_force_count = FunctionLoader.GetFunctionDelegate<av_cpu_force_count_delegate>("avutil", "av_cpu_force_count");
        if (av_cpu_force_count == null)
        {
            av_cpu_force_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_cpu_force_count(@count);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong av_cpu_max_align_delegate();
    public static av_cpu_max_align_delegate av_cpu_max_align = () =>
    {
        av_cpu_max_align = FunctionLoader.GetFunctionDelegate<av_cpu_max_align_delegate>("avutil", "av_cpu_max_align");
        if (av_cpu_max_align == null)
        {
            av_cpu_max_align = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_cpu_max_align();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_d2q_delegate(double @d, int @max);
    public static av_d2q_delegate av_d2q = (double @d, int @max) =>
    {
        av_d2q = FunctionLoader.GetFunctionDelegate<av_d2q_delegate>("avutil", "av_d2q");
        if (av_d2q == null)
        {
            av_d2q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_d2q(@d, @max);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVD3D11VAContext* av_d3d11va_alloc_context_delegate();
    public static av_d3d11va_alloc_context_delegate av_d3d11va_alloc_context = () =>
    {
        av_d3d11va_alloc_context = FunctionLoader.GetFunctionDelegate<av_d3d11va_alloc_context_delegate>("avcodec", "av_d3d11va_alloc_context");
        if (av_d3d11va_alloc_context == null)
        {
            av_d3d11va_alloc_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_d3d11va_alloc_context();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClassCategory av_default_get_category_delegate(void* @ptr);
    public static av_default_get_category_delegate av_default_get_category = (void* @ptr) =>
    {
        av_default_get_category = FunctionLoader.GetFunctionDelegate<av_default_get_category_delegate>("avutil", "av_default_get_category");
        if (av_default_get_category == null)
        {
            av_default_get_category = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_default_get_category(@ptr);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_default_item_name_delegate(void* @ctx);
    public static av_default_item_name_delegate av_default_item_name = (void* @ctx) =>
    {
        av_default_item_name = FunctionLoader.GetFunctionDelegate<av_default_item_name_delegate>("avutil", "av_default_item_name");
        if (av_default_item_name == null)
        {
            av_default_item_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_default_item_name(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_demuxer_iterate_delegate(void** @opaque);
    public static av_demuxer_iterate_delegate av_demuxer_iterate = (void** @opaque) =>
    {
        av_demuxer_iterate = FunctionLoader.GetFunctionDelegate<av_demuxer_iterate_delegate>("avformat", "av_demuxer_iterate");
        if (av_demuxer_iterate == null)
        {
            av_demuxer_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_demuxer_iterate(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_copy_delegate(AVDictionary** @dst, AVDictionary* @src, int @flags);
    public static av_dict_copy_delegate av_dict_copy = (AVDictionary** @dst, AVDictionary* @src, int @flags) =>
    {
        av_dict_copy = FunctionLoader.GetFunctionDelegate<av_dict_copy_delegate>("avutil", "av_dict_copy");
        if (av_dict_copy == null)
        {
            av_dict_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_copy(@dst, @src, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_count_delegate(AVDictionary* @m);
    public static av_dict_count_delegate av_dict_count = (AVDictionary* @m) =>
    {
        av_dict_count = FunctionLoader.GetFunctionDelegate<av_dict_count_delegate>("avutil", "av_dict_count");
        if (av_dict_count == null)
        {
            av_dict_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_count(@m);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_dict_free_delegate(AVDictionary** @m);
    public static av_dict_free_delegate av_dict_free = (AVDictionary** @m) =>
    {
        av_dict_free = FunctionLoader.GetFunctionDelegate<av_dict_free_delegate>("avutil", "av_dict_free");
        if (av_dict_free == null)
        {
            av_dict_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_dict_free(@m);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVDictionaryEntry* av_dict_get_delegate(AVDictionary* @m,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags);
    public static av_dict_get_delegate av_dict_get = (AVDictionary* @m, string @key, AVDictionaryEntry* @prev, int @flags) =>
    {
        av_dict_get = FunctionLoader.GetFunctionDelegate<av_dict_get_delegate>("avutil", "av_dict_get");
        if (av_dict_get == null)
        {
            av_dict_get = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_get(@m, @key, @prev, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_get_string_delegate(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    public static av_dict_get_string_delegate av_dict_get_string = (AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
    {
        av_dict_get_string = FunctionLoader.GetFunctionDelegate<av_dict_get_string_delegate>("avutil", "av_dict_get_string");
        if (av_dict_get_string == null)
        {
            av_dict_get_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_get_string(@m, @buffer, @key_val_sep, @pairs_sep);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_parse_string_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, int @flags);
    public static av_dict_parse_string_delegate av_dict_parse_string = (AVDictionary** @pm, string @str, string @key_val_sep, string @pairs_sep, int @flags) =>
    {
        av_dict_parse_string = FunctionLoader.GetFunctionDelegate<av_dict_parse_string_delegate>("avutil", "av_dict_parse_string");
        if (av_dict_parse_string == null)
        {
            av_dict_parse_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_parse_string(@pm, @str, @key_val_sep, @pairs_sep, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_set_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @value, int @flags);
    public static av_dict_set_delegate av_dict_set = (AVDictionary** @pm, string @key, string @value, int @flags) =>
    {
        av_dict_set = FunctionLoader.GetFunctionDelegate<av_dict_set_delegate>("avutil", "av_dict_set");
        if (av_dict_set == null)
        {
            av_dict_set = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_set(@pm, @key, @value, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dict_set_int_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, long @value, int @flags);
    public static av_dict_set_int_delegate av_dict_set_int = (AVDictionary** @pm, string @key, long @value, int @flags) =>
    {
        av_dict_set_int = FunctionLoader.GetFunctionDelegate<av_dict_set_int_delegate>("avutil", "av_dict_set_int");
        if (av_dict_set_int == null)
        {
            av_dict_set_int = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dict_set_int(@pm, @key, @value, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_disposition_from_string_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @disp);
    public static av_disposition_from_string_delegate av_disposition_from_string = (string @disp) =>
    {
        av_disposition_from_string = FunctionLoader.GetFunctionDelegate<av_disposition_from_string_delegate>("avformat", "av_disposition_from_string");
        if (av_disposition_from_string == null)
        {
            av_disposition_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_disposition_from_string(@disp);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_disposition_to_string_delegate(int @disposition);
    public static av_disposition_to_string_delegate av_disposition_to_string = (int @disposition) =>
    {
        av_disposition_to_string = FunctionLoader.GetFunctionDelegate<av_disposition_to_string_delegate>("avformat", "av_disposition_to_string");
        if (av_disposition_to_string == null)
        {
            av_disposition_to_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_disposition_to_string(@disposition);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_div_q_delegate(AVRational @b, AVRational @c);
    public static av_div_q_delegate av_div_q = (AVRational @b, AVRational @c) =>
    {
        av_div_q = FunctionLoader.GetFunctionDelegate<av_div_q_delegate>("avutil", "av_div_q");
        if (av_div_q == null)
        {
            av_div_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_div_q(@b, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_dump_format_delegate(AVFormatContext* @ic, int @index,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @is_output);
    public static av_dump_format_delegate av_dump_format = (AVFormatContext* @ic, int @index, string @url, int @is_output) =>
    {
        av_dump_format = FunctionLoader.GetFunctionDelegate<av_dump_format_delegate>("avformat", "av_dump_format");
        if (av_dump_format == null)
        {
            av_dump_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_dump_format(@ic, @index, @url, @is_output);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc_delegate(ulong* @size);
    public static av_dynamic_hdr_plus_alloc_delegate av_dynamic_hdr_plus_alloc = (ulong* @size) =>
    {
        av_dynamic_hdr_plus_alloc = FunctionLoader.GetFunctionDelegate<av_dynamic_hdr_plus_alloc_delegate>("avutil", "av_dynamic_hdr_plus_alloc");
        if (av_dynamic_hdr_plus_alloc == null)
        {
            av_dynamic_hdr_plus_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dynamic_hdr_plus_alloc(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data_delegate(AVFrame* @frame);
    public static av_dynamic_hdr_plus_create_side_data_delegate av_dynamic_hdr_plus_create_side_data = (AVFrame* @frame) =>
    {
        av_dynamic_hdr_plus_create_side_data = FunctionLoader.GetFunctionDelegate<av_dynamic_hdr_plus_create_side_data_delegate>("avutil", "av_dynamic_hdr_plus_create_side_data");
        if (av_dynamic_hdr_plus_create_side_data == null)
        {
            av_dynamic_hdr_plus_create_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dynamic_hdr_plus_create_side_data(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_dynarray_add_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
    public static av_dynarray_add_delegate av_dynarray_add = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
    {
        av_dynarray_add = FunctionLoader.GetFunctionDelegate<av_dynarray_add_delegate>("avutil", "av_dynarray_add");
        if (av_dynarray_add == null)
        {
            av_dynarray_add = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_dynarray_add(@tab_ptr, @nb_ptr, @elem);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_dynarray_add_nofree_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
    public static av_dynarray_add_nofree_delegate av_dynarray_add_nofree = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
    {
        av_dynarray_add_nofree = FunctionLoader.GetFunctionDelegate<av_dynarray_add_nofree_delegate>("avutil", "av_dynarray_add_nofree");
        if (av_dynarray_add_nofree == null)
        {
            av_dynarray_add_nofree = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dynarray_add_nofree(@tab_ptr, @nb_ptr, @elem);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_dynarray2_add_delegate(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
    public static av_dynarray2_add_delegate av_dynarray2_add = (void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data) =>
    {
        av_dynarray2_add = FunctionLoader.GetFunctionDelegate<av_dynarray2_add_delegate>("avutil", "av_dynarray2_add");
        if (av_dynarray2_add == null)
        {
            av_dynarray2_add = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_dynarray2_add(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_fast_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    public static av_fast_malloc_delegate av_fast_malloc = (void* @ptr, uint* @size, ulong @min_size) =>
    {
        av_fast_malloc = FunctionLoader.GetFunctionDelegate<av_fast_malloc_delegate>("avutil", "av_fast_malloc");
        if (av_fast_malloc == null)
        {
            av_fast_malloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_fast_malloc(@ptr, @size, @min_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_fast_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
    public static av_fast_mallocz_delegate av_fast_mallocz = (void* @ptr, uint* @size, ulong @min_size) =>
    {
        av_fast_mallocz = FunctionLoader.GetFunctionDelegate<av_fast_mallocz_delegate>("avutil", "av_fast_mallocz");
        if (av_fast_mallocz == null)
        {
            av_fast_mallocz = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_fast_mallocz(@ptr, @size, @min_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_fast_padded_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    public static av_fast_padded_malloc_delegate av_fast_padded_malloc = (void* @ptr, uint* @size, ulong @min_size) =>
    {
        av_fast_padded_malloc = FunctionLoader.GetFunctionDelegate<av_fast_padded_malloc_delegate>("avcodec", "av_fast_padded_malloc");
        if (av_fast_padded_malloc == null)
        {
            av_fast_padded_malloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_fast_padded_malloc(@ptr, @size, @min_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_fast_padded_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
    public static av_fast_padded_mallocz_delegate av_fast_padded_mallocz = (void* @ptr, uint* @size, ulong @min_size) =>
    {
        av_fast_padded_mallocz = FunctionLoader.GetFunctionDelegate<av_fast_padded_mallocz_delegate>("avcodec", "av_fast_padded_mallocz");
        if (av_fast_padded_mallocz == null)
        {
            av_fast_padded_mallocz = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_fast_padded_mallocz(@ptr, @size, @min_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_fast_realloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    public static av_fast_realloc_delegate av_fast_realloc = (void* @ptr, uint* @size, ulong @min_size) =>
    {
        av_fast_realloc = FunctionLoader.GetFunctionDelegate<av_fast_realloc_delegate>("avutil", "av_fast_realloc");
        if (av_fast_realloc == null)
        {
            av_fast_realloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_fast_realloc(@ptr, @size, @min_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_file_map_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx);
    public static av_file_map_delegate av_file_map = (string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx) =>
    {
        av_file_map = FunctionLoader.GetFunctionDelegate<av_file_map_delegate>("avutil", "av_file_map");
        if (av_file_map == null)
        {
            av_file_map = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_file_map(@filename, @bufptr, @size, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_file_unmap_delegate(byte* @bufptr, ulong @size);
    public static av_file_unmap_delegate av_file_unmap = (byte* @bufptr, ulong @size) =>
    {
        av_file_unmap = FunctionLoader.GetFunctionDelegate<av_file_unmap_delegate>("avutil", "av_file_unmap");
        if (av_file_unmap == null)
        {
            av_file_unmap = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_file_unmap(@bufptr, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_filename_number_test_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename);
    public static av_filename_number_test_delegate av_filename_number_test = (string @filename) =>
    {
        av_filename_number_test = FunctionLoader.GetFunctionDelegate<av_filename_number_test_delegate>("avformat", "av_filename_number_test");
        if (av_filename_number_test == null)
        {
            av_filename_number_test = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_filename_number_test(@filename);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilter* av_filter_iterate_delegate(void** @opaque);
    public static av_filter_iterate_delegate av_filter_iterate = (void** @opaque) =>
    {
        av_filter_iterate = FunctionLoader.GetFunctionDelegate<av_filter_iterate_delegate>("avfilter", "av_filter_iterate");
        if (av_filter_iterate == null)
        {
            av_filter_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_filter_iterate(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat av_find_best_pix_fmt_of_2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    public static av_find_best_pix_fmt_of_2_delegate av_find_best_pix_fmt_of_2 = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
    {
        av_find_best_pix_fmt_of_2 = FunctionLoader.GetFunctionDelegate<av_find_best_pix_fmt_of_2_delegate>("avutil", "av_find_best_pix_fmt_of_2");
        if (av_find_best_pix_fmt_of_2 == null)
        {
            av_find_best_pix_fmt_of_2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_best_pix_fmt_of_2(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_find_best_stream_delegate(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
    public static av_find_best_stream_delegate av_find_best_stream = (AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags) =>
    {
        av_find_best_stream = FunctionLoader.GetFunctionDelegate<av_find_best_stream_delegate>("avformat", "av_find_best_stream");
        if (av_find_best_stream == null)
        {
            av_find_best_stream = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_best_stream(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_find_default_stream_index_delegate(AVFormatContext* @s);
    public static av_find_default_stream_index_delegate av_find_default_stream_index = (AVFormatContext* @s) =>
    {
        av_find_default_stream_index = FunctionLoader.GetFunctionDelegate<av_find_default_stream_index_delegate>("avformat", "av_find_default_stream_index");
        if (av_find_default_stream_index == null)
        {
            av_find_default_stream_index = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_default_stream_index(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_find_input_format_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name);
    public static av_find_input_format_delegate av_find_input_format = (string @short_name) =>
    {
        av_find_input_format = FunctionLoader.GetFunctionDelegate<av_find_input_format_delegate>("avformat", "av_find_input_format");
        if (av_find_input_format == null)
        {
            av_find_input_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_input_format(@short_name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_find_nearest_q_idx_delegate(AVRational @q, AVRational* @q_list);
    public static av_find_nearest_q_idx_delegate av_find_nearest_q_idx = (AVRational @q, AVRational* @q_list) =>
    {
        av_find_nearest_q_idx = FunctionLoader.GetFunctionDelegate<av_find_nearest_q_idx_delegate>("avutil", "av_find_nearest_q_idx");
        if (av_find_nearest_q_idx == null)
        {
            av_find_nearest_q_idx = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_nearest_q_idx(@q, @q_list);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVProgram* av_find_program_from_stream_delegate(AVFormatContext* @ic, AVProgram* @last, int @s);
    public static av_find_program_from_stream_delegate av_find_program_from_stream = (AVFormatContext* @ic, AVProgram* @last, int @s) =>
    {
        av_find_program_from_stream = FunctionLoader.GetFunctionDelegate<av_find_program_from_stream_delegate>("avformat", "av_find_program_from_stream");
        if (av_find_program_from_stream == null)
        {
            av_find_program_from_stream = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_find_program_from_stream(@ic, @last, @s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method_delegate(AVFormatContext* @ctx);
    public static av_fmt_ctx_get_duration_estimation_method_delegate av_fmt_ctx_get_duration_estimation_method = (AVFormatContext* @ctx) =>
    {
        av_fmt_ctx_get_duration_estimation_method = FunctionLoader.GetFunctionDelegate<av_fmt_ctx_get_duration_estimation_method_delegate>("avformat", "av_fmt_ctx_get_duration_estimation_method");
        if (av_fmt_ctx_get_duration_estimation_method == null)
        {
            av_fmt_ctx_get_duration_estimation_method = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_fmt_ctx_get_duration_estimation_method(@ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate _iobuf* av_fopen_utf8_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mode);
    public static av_fopen_utf8_delegate av_fopen_utf8 = (string @path, string @mode) =>
    {
        av_fopen_utf8 = FunctionLoader.GetFunctionDelegate<av_fopen_utf8_delegate>("avutil", "av_fopen_utf8");
        if (av_fopen_utf8 == null)
        {
            av_fopen_utf8 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_fopen_utf8(@path, @mode);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_force_cpu_flags_delegate(int @flags);
    public static av_force_cpu_flags_delegate av_force_cpu_flags = (int @flags) =>
    {
        av_force_cpu_flags = FunctionLoader.GetFunctionDelegate<av_force_cpu_flags_delegate>("avutil", "av_force_cpu_flags");
        if (av_force_cpu_flags == null)
        {
            av_force_cpu_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_force_cpu_flags(@flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_format_inject_global_side_data_delegate(AVFormatContext* @s);
    public static av_format_inject_global_side_data_delegate av_format_inject_global_side_data = (AVFormatContext* @s) =>
    {
        av_format_inject_global_side_data = FunctionLoader.GetFunctionDelegate<av_format_inject_global_side_data_delegate>("avformat", "av_format_inject_global_side_data");
        if (av_format_inject_global_side_data == null)
        {
            av_format_inject_global_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_format_inject_global_side_data(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_fourcc_make_string_delegate(byte* @buf, uint @fourcc);
    public static av_fourcc_make_string_delegate av_fourcc_make_string = (byte* @buf, uint @fourcc) =>
    {
        av_fourcc_make_string = FunctionLoader.GetFunctionDelegate<av_fourcc_make_string_delegate>("avutil", "av_fourcc_make_string");
        if (av_fourcc_make_string == null)
        {
            av_fourcc_make_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_fourcc_make_string(@buf, @fourcc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFrame* av_frame_alloc_delegate();
    public static av_frame_alloc_delegate av_frame_alloc = () =>
    {
        av_frame_alloc = FunctionLoader.GetFunctionDelegate<av_frame_alloc_delegate>("avutil", "av_frame_alloc");
        if (av_frame_alloc == null)
        {
            av_frame_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_apply_cropping_delegate(AVFrame* @frame, int @flags);
    public static av_frame_apply_cropping_delegate av_frame_apply_cropping = (AVFrame* @frame, int @flags) =>
    {
        av_frame_apply_cropping = FunctionLoader.GetFunctionDelegate<av_frame_apply_cropping_delegate>("avutil", "av_frame_apply_cropping");
        if (av_frame_apply_cropping == null)
        {
            av_frame_apply_cropping = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_apply_cropping(@frame, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFrame* av_frame_clone_delegate(AVFrame* @src);
    public static av_frame_clone_delegate av_frame_clone = (AVFrame* @src) =>
    {
        av_frame_clone = FunctionLoader.GetFunctionDelegate<av_frame_clone_delegate>("avutil", "av_frame_clone");
        if (av_frame_clone == null)
        {
            av_frame_clone = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_clone(@src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_copy_delegate(AVFrame* @dst, AVFrame* @src);
    public static av_frame_copy_delegate av_frame_copy = (AVFrame* @dst, AVFrame* @src) =>
    {
        av_frame_copy = FunctionLoader.GetFunctionDelegate<av_frame_copy_delegate>("avutil", "av_frame_copy");
        if (av_frame_copy == null)
        {
            av_frame_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_copy(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_copy_props_delegate(AVFrame* @dst, AVFrame* @src);
    public static av_frame_copy_props_delegate av_frame_copy_props = (AVFrame* @dst, AVFrame* @src) =>
    {
        av_frame_copy_props = FunctionLoader.GetFunctionDelegate<av_frame_copy_props_delegate>("avutil", "av_frame_copy_props");
        if (av_frame_copy_props == null)
        {
            av_frame_copy_props = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_copy_props(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_frame_free_delegate(AVFrame** @frame);
    public static av_frame_free_delegate av_frame_free = (AVFrame** @frame) =>
    {
        av_frame_free = FunctionLoader.GetFunctionDelegate<av_frame_free_delegate>("avutil", "av_frame_free");
        if (av_frame_free == null)
        {
            av_frame_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_frame_free(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_get_buffer_delegate(AVFrame* @frame, int @align);
    public static av_frame_get_buffer_delegate av_frame_get_buffer = (AVFrame* @frame, int @align) =>
    {
        av_frame_get_buffer = FunctionLoader.GetFunctionDelegate<av_frame_get_buffer_delegate>("avutil", "av_frame_get_buffer");
        if (av_frame_get_buffer == null)
        {
            av_frame_get_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_get_buffer(@frame, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_frame_get_plane_buffer_delegate(AVFrame* @frame, int @plane);
    public static av_frame_get_plane_buffer_delegate av_frame_get_plane_buffer = (AVFrame* @frame, int @plane) =>
    {
        av_frame_get_plane_buffer = FunctionLoader.GetFunctionDelegate<av_frame_get_plane_buffer_delegate>("avutil", "av_frame_get_plane_buffer");
        if (av_frame_get_plane_buffer == null)
        {
            av_frame_get_plane_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_get_plane_buffer(@frame, @plane);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFrameSideData* av_frame_get_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
    public static av_frame_get_side_data_delegate av_frame_get_side_data = (AVFrame* @frame, AVFrameSideDataType @type) =>
    {
        av_frame_get_side_data = FunctionLoader.GetFunctionDelegate<av_frame_get_side_data_delegate>("avutil", "av_frame_get_side_data");
        if (av_frame_get_side_data == null)
        {
            av_frame_get_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_get_side_data(@frame, @type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_is_writable_delegate(AVFrame* @frame);
    public static av_frame_is_writable_delegate av_frame_is_writable = (AVFrame* @frame) =>
    {
        av_frame_is_writable = FunctionLoader.GetFunctionDelegate<av_frame_is_writable_delegate>("avutil", "av_frame_is_writable");
        if (av_frame_is_writable == null)
        {
            av_frame_is_writable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_is_writable(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_make_writable_delegate(AVFrame* @frame);
    public static av_frame_make_writable_delegate av_frame_make_writable = (AVFrame* @frame) =>
    {
        av_frame_make_writable = FunctionLoader.GetFunctionDelegate<av_frame_make_writable_delegate>("avutil", "av_frame_make_writable");
        if (av_frame_make_writable == null)
        {
            av_frame_make_writable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_make_writable(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_frame_move_ref_delegate(AVFrame* @dst, AVFrame* @src);
    public static av_frame_move_ref_delegate av_frame_move_ref = (AVFrame* @dst, AVFrame* @src) =>
    {
        av_frame_move_ref = FunctionLoader.GetFunctionDelegate<av_frame_move_ref_delegate>("avutil", "av_frame_move_ref");
        if (av_frame_move_ref == null)
        {
            av_frame_move_ref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_frame_move_ref(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFrameSideData* av_frame_new_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type, ulong @size);
    public static av_frame_new_side_data_delegate av_frame_new_side_data = (AVFrame* @frame, AVFrameSideDataType @type, ulong @size) =>
    {
        av_frame_new_side_data = FunctionLoader.GetFunctionDelegate<av_frame_new_side_data_delegate>("avutil", "av_frame_new_side_data");
        if (av_frame_new_side_data == null)
        {
            av_frame_new_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_new_side_data(@frame, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFrameSideData* av_frame_new_side_data_from_buf_delegate(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf);
    public static av_frame_new_side_data_from_buf_delegate av_frame_new_side_data_from_buf = (AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf) =>
    {
        av_frame_new_side_data_from_buf = FunctionLoader.GetFunctionDelegate<av_frame_new_side_data_from_buf_delegate>("avutil", "av_frame_new_side_data_from_buf");
        if (av_frame_new_side_data_from_buf == null)
        {
            av_frame_new_side_data_from_buf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_new_side_data_from_buf(@frame, @type, @buf);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_frame_ref_delegate(AVFrame* @dst, AVFrame* @src);
    public static av_frame_ref_delegate av_frame_ref = (AVFrame* @dst, AVFrame* @src) =>
    {
        av_frame_ref = FunctionLoader.GetFunctionDelegate<av_frame_ref_delegate>("avutil", "av_frame_ref");
        if (av_frame_ref == null)
        {
            av_frame_ref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_ref(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_frame_remove_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
    public static av_frame_remove_side_data_delegate av_frame_remove_side_data = (AVFrame* @frame, AVFrameSideDataType @type) =>
    {
        av_frame_remove_side_data = FunctionLoader.GetFunctionDelegate<av_frame_remove_side_data_delegate>("avutil", "av_frame_remove_side_data");
        if (av_frame_remove_side_data == null)
        {
            av_frame_remove_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_frame_remove_side_data(@frame, @type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_frame_side_data_name_delegate(AVFrameSideDataType @type);
    public static av_frame_side_data_name_delegate av_frame_side_data_name = (AVFrameSideDataType @type) =>
    {
        av_frame_side_data_name = FunctionLoader.GetFunctionDelegate<av_frame_side_data_name_delegate>("avutil", "av_frame_side_data_name");
        if (av_frame_side_data_name == null)
        {
            av_frame_side_data_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_frame_side_data_name(@type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_frame_unref_delegate(AVFrame* @frame);
    public static av_frame_unref_delegate av_frame_unref = (AVFrame* @frame) =>
    {
        av_frame_unref = FunctionLoader.GetFunctionDelegate<av_frame_unref_delegate>("avutil", "av_frame_unref");
        if (av_frame_unref == null)
        {
            av_frame_unref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_frame_unref(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_free_delegate(void* @ptr);
    public static av_free_delegate av_free = (void* @ptr) =>
    {
        av_free = FunctionLoader.GetFunctionDelegate<av_free_delegate>("avutil", "av_free");
        if (av_free == null)
        {
            av_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_free(@ptr);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_freep_delegate(void* @ptr);
    public static av_freep_delegate av_freep = (void* @ptr) =>
    {
        av_freep = FunctionLoader.GetFunctionDelegate<av_freep_delegate>("avutil", "av_freep");
        if (av_freep == null)
        {
            av_freep = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_freep(@ptr);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_gcd_delegate(long @a, long @b);
    public static av_gcd_delegate av_gcd = (long @a, long @b) =>
    {
        av_gcd = FunctionLoader.GetFunctionDelegate<av_gcd_delegate>("avutil", "av_gcd");
        if (av_gcd == null)
        {
            av_gcd = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_gcd(@a, @b);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_gcd_q_delegate(AVRational @a, AVRational @b, int @max_den, AVRational @def);
    public static av_gcd_q_delegate av_gcd_q = (AVRational @a, AVRational @b, int @max_den, AVRational @def) =>
    {
        av_gcd_q = FunctionLoader.GetFunctionDelegate<av_gcd_q_delegate>("avutil", "av_gcd_q");
        if (av_gcd_q == null)
        {
            av_gcd_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_gcd_q(@a, @b, @max_den, @def);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVSampleFormat av_get_alt_sample_fmt_delegate(AVSampleFormat @sample_fmt, int @planar);
    public static av_get_alt_sample_fmt_delegate av_get_alt_sample_fmt = (AVSampleFormat @sample_fmt, int @planar) =>
    {
        av_get_alt_sample_fmt = FunctionLoader.GetFunctionDelegate<av_get_alt_sample_fmt_delegate>("avutil", "av_get_alt_sample_fmt");
        if (av_get_alt_sample_fmt == null)
        {
            av_get_alt_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_alt_sample_fmt(@sample_fmt, @planar);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_audio_frame_duration_delegate(AVCodecContext* @avctx, int @frame_bytes);
    public static av_get_audio_frame_duration_delegate av_get_audio_frame_duration = (AVCodecContext* @avctx, int @frame_bytes) =>
    {
        av_get_audio_frame_duration = FunctionLoader.GetFunctionDelegate<av_get_audio_frame_duration_delegate>("avcodec", "av_get_audio_frame_duration");
        if (av_get_audio_frame_duration == null)
        {
            av_get_audio_frame_duration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_audio_frame_duration(@avctx, @frame_bytes);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_audio_frame_duration2_delegate(AVCodecParameters* @par, int @frame_bytes);
    public static av_get_audio_frame_duration2_delegate av_get_audio_frame_duration2 = (AVCodecParameters* @par, int @frame_bytes) =>
    {
        av_get_audio_frame_duration2 = FunctionLoader.GetFunctionDelegate<av_get_audio_frame_duration2_delegate>("avcodec", "av_get_audio_frame_duration2");
        if (av_get_audio_frame_duration2 == null)
        {
            av_get_audio_frame_duration2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_audio_frame_duration2(@par, @frame_bytes);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
    public static av_get_bits_per_pixel_delegate av_get_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) =>
    {
        av_get_bits_per_pixel = FunctionLoader.GetFunctionDelegate<av_get_bits_per_pixel_delegate>("avutil", "av_get_bits_per_pixel");
        if (av_get_bits_per_pixel == null)
        {
            av_get_bits_per_pixel = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_bits_per_pixel(@pixdesc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_bits_per_sample_delegate(AVCodecID @codec_id);
    public static av_get_bits_per_sample_delegate av_get_bits_per_sample = (AVCodecID @codec_id) =>
    {
        av_get_bits_per_sample = FunctionLoader.GetFunctionDelegate<av_get_bits_per_sample_delegate>("avcodec", "av_get_bits_per_sample");
        if (av_get_bits_per_sample == null)
        {
            av_get_bits_per_sample = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_bits_per_sample(@codec_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_bytes_per_sample_delegate(AVSampleFormat @sample_fmt);
    public static av_get_bytes_per_sample_delegate av_get_bytes_per_sample = (AVSampleFormat @sample_fmt) =>
    {
        av_get_bytes_per_sample = FunctionLoader.GetFunctionDelegate<av_get_bytes_per_sample_delegate>("avutil", "av_get_bytes_per_sample");
        if (av_get_bytes_per_sample == null)
        {
            av_get_bytes_per_sample = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_bytes_per_sample(@sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_channel_description_delegate(ulong @channel);
    public static av_get_channel_description_delegate av_get_channel_description = (ulong @channel) =>
    {
        av_get_channel_description = FunctionLoader.GetFunctionDelegate<av_get_channel_description_delegate>("avutil", "av_get_channel_description");
        if (av_get_channel_description == null)
        {
            av_get_channel_description = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_channel_description(@channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong av_get_channel_layout_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_get_channel_layout_delegate av_get_channel_layout = (string @name) =>
    {
        av_get_channel_layout = FunctionLoader.GetFunctionDelegate<av_get_channel_layout_delegate>("avutil", "av_get_channel_layout");
        if (av_get_channel_layout == null)
        {
            av_get_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_channel_layout(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_channel_layout_channel_index_delegate(ulong @channel_layout, ulong @channel);
    public static av_get_channel_layout_channel_index_delegate av_get_channel_layout_channel_index = (ulong @channel_layout, ulong @channel) =>
    {
        av_get_channel_layout_channel_index = FunctionLoader.GetFunctionDelegate<av_get_channel_layout_channel_index_delegate>("avutil", "av_get_channel_layout_channel_index");
        if (av_get_channel_layout_channel_index == null)
        {
            av_get_channel_layout_channel_index = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_channel_layout_channel_index(@channel_layout, @channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_channel_layout_nb_channels_delegate(ulong @channel_layout);
    public static av_get_channel_layout_nb_channels_delegate av_get_channel_layout_nb_channels = (ulong @channel_layout) =>
    {
        av_get_channel_layout_nb_channels = FunctionLoader.GetFunctionDelegate<av_get_channel_layout_nb_channels_delegate>("avutil", "av_get_channel_layout_nb_channels");
        if (av_get_channel_layout_nb_channels == null)
        {
            av_get_channel_layout_nb_channels = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_channel_layout_nb_channels(@channel_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_get_channel_layout_string_delegate(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout);
    public static av_get_channel_layout_string_delegate av_get_channel_layout_string = (byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout) =>
    {
        av_get_channel_layout_string = FunctionLoader.GetFunctionDelegate<av_get_channel_layout_string_delegate>("avutil", "av_get_channel_layout_string");
        if (av_get_channel_layout_string == null)
        {
            av_get_channel_layout_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_get_channel_layout_string(@buf, @buf_size, @nb_channels, @channel_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_channel_name_delegate(ulong @channel);
    public static av_get_channel_name_delegate av_get_channel_name = (ulong @channel) =>
    {
        av_get_channel_name = FunctionLoader.GetFunctionDelegate<av_get_channel_name_delegate>("avutil", "av_get_channel_name");
        if (av_get_channel_name == null)
        {
            av_get_channel_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_channel_name(@channel);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_colorspace_name_delegate(AVColorSpace @val);
    public static av_get_colorspace_name_delegate av_get_colorspace_name = (AVColorSpace @val) =>
    {
        av_get_colorspace_name = FunctionLoader.GetFunctionDelegate<av_get_colorspace_name_delegate>("avutil", "av_get_colorspace_name");
        if (av_get_colorspace_name == null)
        {
            av_get_colorspace_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_colorspace_name(@val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_cpu_flags_delegate();
    public static av_get_cpu_flags_delegate av_get_cpu_flags = () =>
    {
        av_get_cpu_flags = FunctionLoader.GetFunctionDelegate<av_get_cpu_flags_delegate>("avutil", "av_get_cpu_flags");
        if (av_get_cpu_flags == null)
        {
            av_get_cpu_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_cpu_flags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_get_default_channel_layout_delegate(int @nb_channels);
    public static av_get_default_channel_layout_delegate av_get_default_channel_layout = (int @nb_channels) =>
    {
        av_get_default_channel_layout = FunctionLoader.GetFunctionDelegate<av_get_default_channel_layout_delegate>("avutil", "av_get_default_channel_layout");
        if (av_get_default_channel_layout == null)
        {
            av_get_default_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_default_channel_layout(@nb_channels);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_exact_bits_per_sample_delegate(AVCodecID @codec_id);
    public static av_get_exact_bits_per_sample_delegate av_get_exact_bits_per_sample = (AVCodecID @codec_id) =>
    {
        av_get_exact_bits_per_sample = FunctionLoader.GetFunctionDelegate<av_get_exact_bits_per_sample_delegate>("avcodec", "av_get_exact_bits_per_sample");
        if (av_get_exact_bits_per_sample == null)
        {
            av_get_exact_bits_per_sample = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_exact_bits_per_sample(@codec_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_extended_channel_layout_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, ulong* @channel_layout, int* @nb_channels);
    public static av_get_extended_channel_layout_delegate av_get_extended_channel_layout = (string @name, ulong* @channel_layout, int* @nb_channels) =>
    {
        av_get_extended_channel_layout = FunctionLoader.GetFunctionDelegate<av_get_extended_channel_layout_delegate>("avutil", "av_get_extended_channel_layout");
        if (av_get_extended_channel_layout == null)
        {
            av_get_extended_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_extended_channel_layout(@name, @channel_layout, @nb_channels);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_frame_filename_delegate(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number);
    public static av_get_frame_filename_delegate av_get_frame_filename = (byte* @buf, int @buf_size, string @path, int @number) =>
    {
        av_get_frame_filename = FunctionLoader.GetFunctionDelegate<av_get_frame_filename_delegate>("avformat", "av_get_frame_filename");
        if (av_get_frame_filename == null)
        {
            av_get_frame_filename = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_frame_filename(@buf, @buf_size, @path, @number);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_frame_filename2_delegate(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number, int @flags);
    public static av_get_frame_filename2_delegate av_get_frame_filename2 = (byte* @buf, int @buf_size, string @path, int @number, int @flags) =>
    {
        av_get_frame_filename2 = FunctionLoader.GetFunctionDelegate<av_get_frame_filename2_delegate>("avformat", "av_get_frame_filename2");
        if (av_get_frame_filename2 == null)
        {
            av_get_frame_filename2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_frame_filename2(@buf, @buf_size, @path, @number, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_media_type_string_delegate(AVMediaType @media_type);
    public static av_get_media_type_string_delegate av_get_media_type_string = (AVMediaType @media_type) =>
    {
        av_get_media_type_string = FunctionLoader.GetFunctionDelegate<av_get_media_type_string_delegate>("avutil", "av_get_media_type_string");
        if (av_get_media_type_string == null)
        {
            av_get_media_type_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_media_type_string(@media_type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_output_timestamp_delegate(AVFormatContext* @s, int @stream, long* @dts, long* @wall);
    public static av_get_output_timestamp_delegate av_get_output_timestamp = (AVFormatContext* @s, int @stream, long* @dts, long* @wall) =>
    {
        av_get_output_timestamp = FunctionLoader.GetFunctionDelegate<av_get_output_timestamp_delegate>("avformat", "av_get_output_timestamp");
        if (av_get_output_timestamp == null)
        {
            av_get_output_timestamp = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_output_timestamp(@s, @stream, @dts, @wall);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVSampleFormat av_get_packed_sample_fmt_delegate(AVSampleFormat @sample_fmt);
    public static av_get_packed_sample_fmt_delegate av_get_packed_sample_fmt = (AVSampleFormat @sample_fmt) =>
    {
        av_get_packed_sample_fmt = FunctionLoader.GetFunctionDelegate<av_get_packed_sample_fmt_delegate>("avutil", "av_get_packed_sample_fmt");
        if (av_get_packed_sample_fmt == null)
        {
            av_get_packed_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_packed_sample_fmt(@sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
    public static av_get_packet_delegate av_get_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
    {
        av_get_packet = FunctionLoader.GetFunctionDelegate<av_get_packet_delegate>("avformat", "av_get_packet");
        if (av_get_packet == null)
        {
            av_get_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_packet(@s, @pkt, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_padded_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
    public static av_get_padded_bits_per_pixel_delegate av_get_padded_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) =>
    {
        av_get_padded_bits_per_pixel = FunctionLoader.GetFunctionDelegate<av_get_padded_bits_per_pixel_delegate>("avutil", "av_get_padded_bits_per_pixel");
        if (av_get_padded_bits_per_pixel == null)
        {
            av_get_padded_bits_per_pixel = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_padded_bits_per_pixel(@pixdesc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecID av_get_pcm_codec_delegate(AVSampleFormat @fmt, int @be);
    public static av_get_pcm_codec_delegate av_get_pcm_codec = (AVSampleFormat @fmt, int @be) =>
    {
        av_get_pcm_codec = FunctionLoader.GetFunctionDelegate<av_get_pcm_codec_delegate>("avcodec", "av_get_pcm_codec");
        if (av_get_pcm_codec == null)
        {
            av_get_pcm_codec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_pcm_codec(@fmt, @be);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte av_get_picture_type_char_delegate(AVPictureType @pict_type);
    public static av_get_picture_type_char_delegate av_get_picture_type_char = (AVPictureType @pict_type) =>
    {
        av_get_picture_type_char = FunctionLoader.GetFunctionDelegate<av_get_picture_type_char_delegate>("avutil", "av_get_picture_type_char");
        if (av_get_picture_type_char == null)
        {
            av_get_picture_type_char = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_picture_type_char(@pict_type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat av_get_pix_fmt_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_get_pix_fmt_delegate av_get_pix_fmt = (string @name) =>
    {
        av_get_pix_fmt = FunctionLoader.GetFunctionDelegate<av_get_pix_fmt_delegate>("avutil", "av_get_pix_fmt");
        if (av_get_pix_fmt == null)
        {
            av_get_pix_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_pix_fmt(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_pix_fmt_loss_delegate(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
    public static av_get_pix_fmt_loss_delegate av_get_pix_fmt_loss = (AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha) =>
    {
        av_get_pix_fmt_loss = FunctionLoader.GetFunctionDelegate<av_get_pix_fmt_loss_delegate>("avutil", "av_get_pix_fmt_loss");
        if (av_get_pix_fmt_loss == null)
        {
            av_get_pix_fmt_loss = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_pix_fmt_loss(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_pix_fmt_name_delegate(AVPixelFormat @pix_fmt);
    public static av_get_pix_fmt_name_delegate av_get_pix_fmt_name = (AVPixelFormat @pix_fmt) =>
    {
        av_get_pix_fmt_name = FunctionLoader.GetFunctionDelegate<av_get_pix_fmt_name_delegate>("avutil", "av_get_pix_fmt_name");
        if (av_get_pix_fmt_name == null)
        {
            av_get_pix_fmt_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_pix_fmt_name(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_get_pix_fmt_string_delegate(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
    public static av_get_pix_fmt_string_delegate av_get_pix_fmt_string = (byte* @buf, int @buf_size, AVPixelFormat @pix_fmt) =>
    {
        av_get_pix_fmt_string = FunctionLoader.GetFunctionDelegate<av_get_pix_fmt_string_delegate>("avutil", "av_get_pix_fmt_string");
        if (av_get_pix_fmt_string == null)
        {
            av_get_pix_fmt_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_pix_fmt_string(@buf, @buf_size, @pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVSampleFormat av_get_planar_sample_fmt_delegate(AVSampleFormat @sample_fmt);
    public static av_get_planar_sample_fmt_delegate av_get_planar_sample_fmt = (AVSampleFormat @sample_fmt) =>
    {
        av_get_planar_sample_fmt = FunctionLoader.GetFunctionDelegate<av_get_planar_sample_fmt_delegate>("avutil", "av_get_planar_sample_fmt");
        if (av_get_planar_sample_fmt == null)
        {
            av_get_planar_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_planar_sample_fmt(@sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_profile_name_delegate(AVCodec* @codec, int @profile);
    public static av_get_profile_name_delegate av_get_profile_name = (AVCodec* @codec, int @profile) =>
    {
        av_get_profile_name = FunctionLoader.GetFunctionDelegate<av_get_profile_name_delegate>("avcodec", "av_get_profile_name");
        if (av_get_profile_name == null)
        {
            av_get_profile_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_profile_name(@codec, @profile);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVSampleFormat av_get_sample_fmt_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_get_sample_fmt_delegate av_get_sample_fmt = (string @name) =>
    {
        av_get_sample_fmt = FunctionLoader.GetFunctionDelegate<av_get_sample_fmt_delegate>("avutil", "av_get_sample_fmt");
        if (av_get_sample_fmt == null)
        {
            av_get_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_sample_fmt(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_get_sample_fmt_name_delegate(AVSampleFormat @sample_fmt);
    public static av_get_sample_fmt_name_delegate av_get_sample_fmt_name = (AVSampleFormat @sample_fmt) =>
    {
        av_get_sample_fmt_name = FunctionLoader.GetFunctionDelegate<av_get_sample_fmt_name_delegate>("avutil", "av_get_sample_fmt_name");
        if (av_get_sample_fmt_name == null)
        {
            av_get_sample_fmt_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_sample_fmt_name(@sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_get_sample_fmt_string_delegate(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
    public static av_get_sample_fmt_string_delegate av_get_sample_fmt_string = (byte* @buf, int @buf_size, AVSampleFormat @sample_fmt) =>
    {
        av_get_sample_fmt_string = FunctionLoader.GetFunctionDelegate<av_get_sample_fmt_string_delegate>("avutil", "av_get_sample_fmt_string");
        if (av_get_sample_fmt_string == null)
        {
            av_get_sample_fmt_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_sample_fmt_string(@buf, @buf_size, @sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_get_standard_channel_layout_delegate(uint @index, ulong* @layout, byte** @name);
    public static av_get_standard_channel_layout_delegate av_get_standard_channel_layout = (uint @index, ulong* @layout, byte** @name) =>
    {
        av_get_standard_channel_layout = FunctionLoader.GetFunctionDelegate<av_get_standard_channel_layout_delegate>("avutil", "av_get_standard_channel_layout");
        if (av_get_standard_channel_layout == null)
        {
            av_get_standard_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_standard_channel_layout(@index, @layout, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_get_time_base_q_delegate();
    public static av_get_time_base_q_delegate av_get_time_base_q = () =>
    {
        av_get_time_base_q = FunctionLoader.GetFunctionDelegate<av_get_time_base_q_delegate>("avutil", "av_get_time_base_q");
        if (av_get_time_base_q == null)
        {
            av_get_time_base_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_get_time_base_q();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_gettime_delegate();
    public static av_gettime_delegate av_gettime = () =>
    {
        av_gettime = FunctionLoader.GetFunctionDelegate<av_gettime_delegate>("avutil", "av_gettime");
        if (av_gettime == null)
        {
            av_gettime = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_gettime();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_gettime_relative_delegate();
    public static av_gettime_relative_delegate av_gettime_relative = () =>
    {
        av_gettime_relative = FunctionLoader.GetFunctionDelegate<av_gettime_relative_delegate>("avutil", "av_gettime_relative");
        if (av_gettime_relative == null)
        {
            av_gettime_relative = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_gettime_relative();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_gettime_relative_is_monotonic_delegate();
    public static av_gettime_relative_is_monotonic_delegate av_gettime_relative_is_monotonic = () =>
    {
        av_gettime_relative_is_monotonic = FunctionLoader.GetFunctionDelegate<av_gettime_relative_is_monotonic_delegate>("avutil", "av_gettime_relative_is_monotonic");
        if (av_gettime_relative_is_monotonic == null)
        {
            av_gettime_relative_is_monotonic = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_gettime_relative_is_monotonic();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_grow_packet_delegate(AVPacket* @pkt, int @grow_by);
    public static av_grow_packet_delegate av_grow_packet = (AVPacket* @pkt, int @grow_by) =>
    {
        av_grow_packet = FunctionLoader.GetFunctionDelegate<av_grow_packet_delegate>("avcodec", "av_grow_packet");
        if (av_grow_packet == null)
        {
            av_grow_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_grow_packet(@pkt, @grow_by);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecID av_guess_codec_delegate(AVOutputFormat* @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type, AVMediaType @type);
    public static av_guess_codec_delegate av_guess_codec = (AVOutputFormat* @fmt, string @short_name, string @filename, string @mime_type, AVMediaType @type) =>
    {
        av_guess_codec = FunctionLoader.GetFunctionDelegate<av_guess_codec_delegate>("avformat", "av_guess_codec");
        if (av_guess_codec == null)
        {
            av_guess_codec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_guess_codec(@fmt, @short_name, @filename, @mime_type, @type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOutputFormat* av_guess_format_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type);
    public static av_guess_format_delegate av_guess_format = (string @short_name, string @filename, string @mime_type) =>
    {
        av_guess_format = FunctionLoader.GetFunctionDelegate<av_guess_format_delegate>("avformat", "av_guess_format");
        if (av_guess_format == null)
        {
            av_guess_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_guess_format(@short_name, @filename, @mime_type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_guess_frame_rate_delegate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
    public static av_guess_frame_rate_delegate av_guess_frame_rate = (AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame) =>
    {
        av_guess_frame_rate = FunctionLoader.GetFunctionDelegate<av_guess_frame_rate_delegate>("avformat", "av_guess_frame_rate");
        if (av_guess_frame_rate == null)
        {
            av_guess_frame_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_guess_frame_rate(@ctx, @stream, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_guess_sample_aspect_ratio_delegate(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
    public static av_guess_sample_aspect_ratio_delegate av_guess_sample_aspect_ratio = (AVFormatContext* @format, AVStream* @stream, AVFrame* @frame) =>
    {
        av_guess_sample_aspect_ratio = FunctionLoader.GetFunctionDelegate<av_guess_sample_aspect_ratio_delegate>("avformat", "av_guess_sample_aspect_ratio");
        if (av_guess_sample_aspect_ratio == null)
        {
            av_guess_sample_aspect_ratio = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_guess_sample_aspect_ratio(@format, @stream, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_hex_dump_delegate(_iobuf* @f, byte* @buf, int @size);
    public static av_hex_dump_delegate av_hex_dump = (_iobuf* @f, byte* @buf, int @size) =>
    {
        av_hex_dump = FunctionLoader.GetFunctionDelegate<av_hex_dump_delegate>("avformat", "av_hex_dump");
        if (av_hex_dump == null)
        {
            av_hex_dump = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_hex_dump(@f, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_hex_dump_log_delegate(void* @avcl, int @level, byte* @buf, int @size);
    public static av_hex_dump_log_delegate av_hex_dump_log = (void* @avcl, int @level, byte* @buf, int @size) =>
    {
        av_hex_dump_log = FunctionLoader.GetFunctionDelegate<av_hex_dump_log_delegate>("avformat", "av_hex_dump_log");
        if (av_hex_dump_log == null)
        {
            av_hex_dump_log = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_hex_dump_log(@avcl, @level, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_hwdevice_ctx_alloc_delegate(AVHWDeviceType @type);
    public static av_hwdevice_ctx_alloc_delegate av_hwdevice_ctx_alloc = (AVHWDeviceType @type) =>
    {
        av_hwdevice_ctx_alloc = FunctionLoader.GetFunctionDelegate<av_hwdevice_ctx_alloc_delegate>("avutil", "av_hwdevice_ctx_alloc");
        if (av_hwdevice_ctx_alloc == null)
        {
            av_hwdevice_ctx_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_ctx_alloc(@type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwdevice_ctx_create_delegate(AVBufferRef** @device_ctx, AVHWDeviceType @type,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device, AVDictionary* @opts, int @flags);
    public static av_hwdevice_ctx_create_delegate av_hwdevice_ctx_create = (AVBufferRef** @device_ctx, AVHWDeviceType @type, string @device, AVDictionary* @opts, int @flags) =>
    {
        av_hwdevice_ctx_create = FunctionLoader.GetFunctionDelegate<av_hwdevice_ctx_create_delegate>("avutil", "av_hwdevice_ctx_create");
        if (av_hwdevice_ctx_create == null)
        {
            av_hwdevice_ctx_create = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_ctx_create(@device_ctx, @type, @device, @opts, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwdevice_ctx_create_derived_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);
    public static av_hwdevice_ctx_create_derived_delegate av_hwdevice_ctx_create_derived = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags) =>
    {
        av_hwdevice_ctx_create_derived = FunctionLoader.GetFunctionDelegate<av_hwdevice_ctx_create_derived_delegate>("avutil", "av_hwdevice_ctx_create_derived");
        if (av_hwdevice_ctx_create_derived == null)
        {
            av_hwdevice_ctx_create_derived = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_ctx_create_derived(@dst_ctx, @type, @src_ctx, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwdevice_ctx_create_derived_opts_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags);
    public static av_hwdevice_ctx_create_derived_opts_delegate av_hwdevice_ctx_create_derived_opts = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags) =>
    {
        av_hwdevice_ctx_create_derived_opts = FunctionLoader.GetFunctionDelegate<av_hwdevice_ctx_create_derived_opts_delegate>("avutil", "av_hwdevice_ctx_create_derived_opts");
        if (av_hwdevice_ctx_create_derived_opts == null)
        {
            av_hwdevice_ctx_create_derived_opts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_ctx_create_derived_opts(@dst_ctx, @type, @src_ctx, @options, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwdevice_ctx_init_delegate(AVBufferRef* @ref);
    public static av_hwdevice_ctx_init_delegate av_hwdevice_ctx_init = (AVBufferRef* @ref) =>
    {
        av_hwdevice_ctx_init = FunctionLoader.GetFunctionDelegate<av_hwdevice_ctx_init_delegate>("avutil", "av_hwdevice_ctx_init");
        if (av_hwdevice_ctx_init == null)
        {
            av_hwdevice_ctx_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_ctx_init(@ref);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVHWDeviceType av_hwdevice_find_type_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_hwdevice_find_type_by_name_delegate av_hwdevice_find_type_by_name = (string @name) =>
    {
        av_hwdevice_find_type_by_name = FunctionLoader.GetFunctionDelegate<av_hwdevice_find_type_by_name_delegate>("avutil", "av_hwdevice_find_type_by_name");
        if (av_hwdevice_find_type_by_name == null)
        {
            av_hwdevice_find_type_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_find_type_by_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints_delegate(AVBufferRef* @ref, void* @hwconfig);
    public static av_hwdevice_get_hwframe_constraints_delegate av_hwdevice_get_hwframe_constraints = (AVBufferRef* @ref, void* @hwconfig) =>
    {
        av_hwdevice_get_hwframe_constraints = FunctionLoader.GetFunctionDelegate<av_hwdevice_get_hwframe_constraints_delegate>("avutil", "av_hwdevice_get_hwframe_constraints");
        if (av_hwdevice_get_hwframe_constraints == null)
        {
            av_hwdevice_get_hwframe_constraints = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_get_hwframe_constraints(@ref, @hwconfig);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_hwdevice_get_type_name_delegate(AVHWDeviceType @type);
    public static av_hwdevice_get_type_name_delegate av_hwdevice_get_type_name = (AVHWDeviceType @type) =>
    {
        av_hwdevice_get_type_name = FunctionLoader.GetFunctionDelegate<av_hwdevice_get_type_name_delegate>("avutil", "av_hwdevice_get_type_name");
        if (av_hwdevice_get_type_name == null)
        {
            av_hwdevice_get_type_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_get_type_name(@type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_hwdevice_hwconfig_alloc_delegate(AVBufferRef* @device_ctx);
    public static av_hwdevice_hwconfig_alloc_delegate av_hwdevice_hwconfig_alloc = (AVBufferRef* @device_ctx) =>
    {
        av_hwdevice_hwconfig_alloc = FunctionLoader.GetFunctionDelegate<av_hwdevice_hwconfig_alloc_delegate>("avutil", "av_hwdevice_hwconfig_alloc");
        if (av_hwdevice_hwconfig_alloc == null)
        {
            av_hwdevice_hwconfig_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_hwconfig_alloc(@device_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVHWDeviceType av_hwdevice_iterate_types_delegate(AVHWDeviceType @prev);
    public static av_hwdevice_iterate_types_delegate av_hwdevice_iterate_types = (AVHWDeviceType @prev) =>
    {
        av_hwdevice_iterate_types = FunctionLoader.GetFunctionDelegate<av_hwdevice_iterate_types_delegate>("avutil", "av_hwdevice_iterate_types");
        if (av_hwdevice_iterate_types == null)
        {
            av_hwdevice_iterate_types = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwdevice_iterate_types(@prev);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_hwframe_constraints_free_delegate(AVHWFramesConstraints** @constraints);
    public static av_hwframe_constraints_free_delegate av_hwframe_constraints_free = (AVHWFramesConstraints** @constraints) =>
    {
        av_hwframe_constraints_free = FunctionLoader.GetFunctionDelegate<av_hwframe_constraints_free_delegate>("avutil", "av_hwframe_constraints_free");
        if (av_hwframe_constraints_free == null)
        {
            av_hwframe_constraints_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_hwframe_constraints_free(@constraints);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVBufferRef* av_hwframe_ctx_alloc_delegate(AVBufferRef* @device_ctx);
    public static av_hwframe_ctx_alloc_delegate av_hwframe_ctx_alloc = (AVBufferRef* @device_ctx) =>
    {
        av_hwframe_ctx_alloc = FunctionLoader.GetFunctionDelegate<av_hwframe_ctx_alloc_delegate>("avutil", "av_hwframe_ctx_alloc");
        if (av_hwframe_ctx_alloc == null)
        {
            av_hwframe_ctx_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_ctx_alloc(@device_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_ctx_create_derived_delegate(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);
    public static av_hwframe_ctx_create_derived_delegate av_hwframe_ctx_create_derived = (AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags) =>
    {
        av_hwframe_ctx_create_derived = FunctionLoader.GetFunctionDelegate<av_hwframe_ctx_create_derived_delegate>("avutil", "av_hwframe_ctx_create_derived");
        if (av_hwframe_ctx_create_derived == null)
        {
            av_hwframe_ctx_create_derived = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_ctx_create_derived(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_ctx_init_delegate(AVBufferRef* @ref);
    public static av_hwframe_ctx_init_delegate av_hwframe_ctx_init = (AVBufferRef* @ref) =>
    {
        av_hwframe_ctx_init = FunctionLoader.GetFunctionDelegate<av_hwframe_ctx_init_delegate>("avutil", "av_hwframe_ctx_init");
        if (av_hwframe_ctx_init == null)
        {
            av_hwframe_ctx_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_ctx_init(@ref);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_get_buffer_delegate(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);
    public static av_hwframe_get_buffer_delegate av_hwframe_get_buffer = (AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags) =>
    {
        av_hwframe_get_buffer = FunctionLoader.GetFunctionDelegate<av_hwframe_get_buffer_delegate>("avutil", "av_hwframe_get_buffer");
        if (av_hwframe_get_buffer == null)
        {
            av_hwframe_get_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_get_buffer(@hwframe_ctx, @frame, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_map_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
    public static av_hwframe_map_delegate av_hwframe_map = (AVFrame* @dst, AVFrame* @src, int @flags) =>
    {
        av_hwframe_map = FunctionLoader.GetFunctionDelegate<av_hwframe_map_delegate>("avutil", "av_hwframe_map");
        if (av_hwframe_map == null)
        {
            av_hwframe_map = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_map(@dst, @src, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_transfer_data_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
    public static av_hwframe_transfer_data_delegate av_hwframe_transfer_data = (AVFrame* @dst, AVFrame* @src, int @flags) =>
    {
        av_hwframe_transfer_data = FunctionLoader.GetFunctionDelegate<av_hwframe_transfer_data_delegate>("avutil", "av_hwframe_transfer_data");
        if (av_hwframe_transfer_data == null)
        {
            av_hwframe_transfer_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_transfer_data(@dst, @src, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_hwframe_transfer_get_formats_delegate(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);
    public static av_hwframe_transfer_get_formats_delegate av_hwframe_transfer_get_formats = (AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags) =>
    {
        av_hwframe_transfer_get_formats = FunctionLoader.GetFunctionDelegate<av_hwframe_transfer_get_formats_delegate>("avutil", "av_hwframe_transfer_get_formats");
        if (av_hwframe_transfer_get_formats == null)
        {
            av_hwframe_transfer_get_formats = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_hwframe_transfer_get_formats(@hwframe_ctx, @dir, @formats, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_alloc_delegate(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
    public static av_image_alloc_delegate av_image_alloc = (ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align) =>
    {
        av_image_alloc = FunctionLoader.GetFunctionDelegate<av_image_alloc_delegate>("avutil", "av_image_alloc");
        if (av_image_alloc == null)
        {
            av_image_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_alloc(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_check_sar_delegate(uint @w, uint @h, AVRational @sar);
    public static av_image_check_sar_delegate av_image_check_sar = (uint @w, uint @h, AVRational @sar) =>
    {
        av_image_check_sar = FunctionLoader.GetFunctionDelegate<av_image_check_sar_delegate>("avutil", "av_image_check_sar");
        if (av_image_check_sar == null)
        {
            av_image_check_sar = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_check_sar(@w, @h, @sar);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_check_size_delegate(uint @w, uint @h, int @log_offset, void* @log_ctx);
    public static av_image_check_size_delegate av_image_check_size = (uint @w, uint @h, int @log_offset, void* @log_ctx) =>
    {
        av_image_check_size = FunctionLoader.GetFunctionDelegate<av_image_check_size_delegate>("avutil", "av_image_check_size");
        if (av_image_check_size == null)
        {
            av_image_check_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_check_size(@w, @h, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_check_size2_delegate(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);
    public static av_image_check_size2_delegate av_image_check_size2 = (uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx) =>
    {
        av_image_check_size2 = FunctionLoader.GetFunctionDelegate<av_image_check_size2_delegate>("avutil", "av_image_check_size2");
        if (av_image_check_size2 == null)
        {
            av_image_check_size2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_check_size2(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_image_copy_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    public static av_image_copy_delegate av_image_copy = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
    {
        av_image_copy = FunctionLoader.GetFunctionDelegate<av_image_copy_delegate>("avutil", "av_image_copy");
        if (av_image_copy == null)
        {
            av_image_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_image_copy(ref @dst_data, ref @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_image_copy_plane_delegate(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
    public static av_image_copy_plane_delegate av_image_copy_plane = (byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height) =>
    {
        av_image_copy_plane = FunctionLoader.GetFunctionDelegate<av_image_copy_plane_delegate>("avutil", "av_image_copy_plane");
        if (av_image_copy_plane == null)
        {
            av_image_copy_plane = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_image_copy_plane(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_image_copy_plane_uc_from_delegate(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height);
    public static av_image_copy_plane_uc_from_delegate av_image_copy_plane_uc_from = (byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height) =>
    {
        av_image_copy_plane_uc_from = FunctionLoader.GetFunctionDelegate<av_image_copy_plane_uc_from_delegate>("avutil", "av_image_copy_plane_uc_from");
        if (av_image_copy_plane_uc_from == null)
        {
            av_image_copy_plane_uc_from = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_image_copy_plane_uc_from(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_copy_to_buffer_delegate(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    public static av_image_copy_to_buffer_delegate av_image_copy_to_buffer = (byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
    {
        av_image_copy_to_buffer = FunctionLoader.GetFunctionDelegate<av_image_copy_to_buffer_delegate>("avutil", "av_image_copy_to_buffer");
        if (av_image_copy_to_buffer == null)
        {
            av_image_copy_to_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_copy_to_buffer(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_image_copy_uc_from_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    public static av_image_copy_uc_from_delegate av_image_copy_uc_from = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
    {
        av_image_copy_uc_from = FunctionLoader.GetFunctionDelegate<av_image_copy_uc_from_delegate>("avutil", "av_image_copy_uc_from");
        if (av_image_copy_uc_from == null)
        {
            av_image_copy_uc_from = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_image_copy_uc_from(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_fill_arrays_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    public static av_image_fill_arrays_delegate av_image_fill_arrays = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
    {
        av_image_fill_arrays = FunctionLoader.GetFunctionDelegate<av_image_fill_arrays_delegate>("avutil", "av_image_fill_arrays");
        if (av_image_fill_arrays == null)
        {
            av_image_fill_arrays = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_fill_arrays(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_fill_black_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);
    public static av_image_fill_black_delegate av_image_fill_black = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height) =>
    {
        av_image_fill_black = FunctionLoader.GetFunctionDelegate<av_image_fill_black_delegate>("avutil", "av_image_fill_black");
        if (av_image_fill_black == null)
        {
            av_image_fill_black = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_fill_black(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_fill_linesizes_delegate(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width);
    public static av_image_fill_linesizes_delegate av_image_fill_linesizes = (ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width) =>
    {
        av_image_fill_linesizes = FunctionLoader.GetFunctionDelegate<av_image_fill_linesizes_delegate>("avutil", "av_image_fill_linesizes");
        if (av_image_fill_linesizes == null)
        {
            av_image_fill_linesizes = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_fill_linesizes(ref @linesizes, @pix_fmt, @width);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_image_fill_max_pixsteps_delegate(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
    public static av_image_fill_max_pixsteps_delegate av_image_fill_max_pixsteps = (ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc) =>
    {
        av_image_fill_max_pixsteps = FunctionLoader.GetFunctionDelegate<av_image_fill_max_pixsteps_delegate>("avutil", "av_image_fill_max_pixsteps");
        if (av_image_fill_max_pixsteps == null)
        {
            av_image_fill_max_pixsteps = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_image_fill_max_pixsteps(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_fill_plane_sizes_delegate(ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, long_array4 @linesizes);
    public static av_image_fill_plane_sizes_delegate av_image_fill_plane_sizes = (ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, long_array4 @linesizes) =>
    {
        av_image_fill_plane_sizes = FunctionLoader.GetFunctionDelegate<av_image_fill_plane_sizes_delegate>("avutil", "av_image_fill_plane_sizes");
        if (av_image_fill_plane_sizes == null)
        {
            av_image_fill_plane_sizes = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_fill_plane_sizes(ref @size, @pix_fmt, @height, @linesizes);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_fill_pointers_delegate(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes);
    public static av_image_fill_pointers_delegate av_image_fill_pointers = (ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes) =>
    {
        av_image_fill_pointers = FunctionLoader.GetFunctionDelegate<av_image_fill_pointers_delegate>("avutil", "av_image_fill_pointers");
        if (av_image_fill_pointers == null)
        {
            av_image_fill_pointers = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_fill_pointers(ref @data, @pix_fmt, @height, @ptr, @linesizes);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_get_buffer_size_delegate(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    public static av_image_get_buffer_size_delegate av_image_get_buffer_size = (AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
    {
        av_image_get_buffer_size = FunctionLoader.GetFunctionDelegate<av_image_get_buffer_size_delegate>("avutil", "av_image_get_buffer_size");
        if (av_image_get_buffer_size == null)
        {
            av_image_get_buffer_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_get_buffer_size(@pix_fmt, @width, @height, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_image_get_linesize_delegate(AVPixelFormat @pix_fmt, int @width, int @plane);
    public static av_image_get_linesize_delegate av_image_get_linesize = (AVPixelFormat @pix_fmt, int @width, int @plane) =>
    {
        av_image_get_linesize = FunctionLoader.GetFunctionDelegate<av_image_get_linesize_delegate>("avutil", "av_image_get_linesize");
        if (av_image_get_linesize == null)
        {
            av_image_get_linesize = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_image_get_linesize(@pix_fmt, @width, @plane);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_index_search_timestamp_delegate(AVStream* @st, long @timestamp, int @flags);
    public static av_index_search_timestamp_delegate av_index_search_timestamp = (AVStream* @st, long @timestamp, int @flags) =>
    {
        av_index_search_timestamp = FunctionLoader.GetFunctionDelegate<av_index_search_timestamp_delegate>("avformat", "av_index_search_timestamp");
        if (av_index_search_timestamp == null)
        {
            av_index_search_timestamp = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_index_search_timestamp(@st, @timestamp, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_init_packet_delegate(AVPacket* @pkt);
    public static av_init_packet_delegate av_init_packet = (AVPacket* @pkt) =>
    {
        av_init_packet = FunctionLoader.GetFunctionDelegate<av_init_packet_delegate>("avcodec", "av_init_packet");
        if (av_init_packet == null)
        {
            av_init_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_init_packet(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_input_audio_device_next_delegate(AVInputFormat* @d);
    public static av_input_audio_device_next_delegate av_input_audio_device_next = (AVInputFormat* @d) =>
    {
        av_input_audio_device_next = FunctionLoader.GetFunctionDelegate<av_input_audio_device_next_delegate>("avdevice", "av_input_audio_device_next");
        if (av_input_audio_device_next == null)
        {
            av_input_audio_device_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_input_audio_device_next(@d);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_input_video_device_next_delegate(AVInputFormat* @d);
    public static av_input_video_device_next_delegate av_input_video_device_next = (AVInputFormat* @d) =>
    {
        av_input_video_device_next = FunctionLoader.GetFunctionDelegate<av_input_video_device_next_delegate>("avdevice", "av_input_video_device_next");
        if (av_input_video_device_next == null)
        {
            av_input_video_device_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_input_video_device_next(@d);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_int_list_length_for_size_delegate(uint @elsize, void* @list, ulong @term);
    public static av_int_list_length_for_size_delegate av_int_list_length_for_size = (uint @elsize, void* @list, ulong @term) =>
    {
        av_int_list_length_for_size = FunctionLoader.GetFunctionDelegate<av_int_list_length_for_size_delegate>("avutil", "av_int_list_length_for_size");
        if (av_int_list_length_for_size == null)
        {
            av_int_list_length_for_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_int_list_length_for_size(@elsize, @list, @term);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_interleaved_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    public static av_interleaved_write_frame_delegate av_interleaved_write_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
    {
        av_interleaved_write_frame = FunctionLoader.GetFunctionDelegate<av_interleaved_write_frame_delegate>("avformat", "av_interleaved_write_frame");
        if (av_interleaved_write_frame == null)
        {
            av_interleaved_write_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_interleaved_write_frame(@s, @pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_interleaved_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    public static av_interleaved_write_uncoded_frame_delegate av_interleaved_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
    {
        av_interleaved_write_uncoded_frame = FunctionLoader.GetFunctionDelegate<av_interleaved_write_uncoded_frame_delegate>("avformat", "av_interleaved_write_uncoded_frame");
        if (av_interleaved_write_uncoded_frame == null)
        {
            av_interleaved_write_uncoded_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_interleaved_write_uncoded_frame(@s, @stream_index, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    public static av_log_delegate av_log = (void* @avcl, int @level, string @fmt) =>
    {
        av_log = FunctionLoader.GetFunctionDelegate<av_log_delegate>("avutil", "av_log");
        if (av_log == null)
        {
            av_log = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log(@avcl, @level, @fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_default_callback_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    public static av_log_default_callback_delegate av_log_default_callback = (void* @avcl, int @level, string @fmt, byte* @vl) =>
    {
        av_log_default_callback = FunctionLoader.GetFunctionDelegate<av_log_default_callback_delegate>("avutil", "av_log_default_callback");
        if (av_log_default_callback == null)
        {
            av_log_default_callback = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_default_callback(@avcl, @level, @fmt, @vl);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_format_line_delegate(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    public static av_log_format_line_delegate av_log_format_line = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
    {
        av_log_format_line = FunctionLoader.GetFunctionDelegate<av_log_format_line_delegate>("avutil", "av_log_format_line");
        if (av_log_format_line == null)
        {
            av_log_format_line = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_format_line(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_log_format_line2_delegate(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    public static av_log_format_line2_delegate av_log_format_line2 = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
    {
        av_log_format_line2 = FunctionLoader.GetFunctionDelegate<av_log_format_line2_delegate>("avutil", "av_log_format_line2");
        if (av_log_format_line2 == null)
        {
            av_log_format_line2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_log_format_line2(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_log_get_flags_delegate();
    public static av_log_get_flags_delegate av_log_get_flags = () =>
    {
        av_log_get_flags = FunctionLoader.GetFunctionDelegate<av_log_get_flags_delegate>("avutil", "av_log_get_flags");
        if (av_log_get_flags == null)
        {
            av_log_get_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_log_get_flags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_log_get_level_delegate();
    public static av_log_get_level_delegate av_log_get_level = () =>
    {
        av_log_get_level = FunctionLoader.GetFunctionDelegate<av_log_get_level_delegate>("avutil", "av_log_get_level");
        if (av_log_get_level == null)
        {
            av_log_get_level = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_log_get_level();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_once_delegate(void* @avcl, int @initial_level, int @subsequent_level, int* @state,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    public static av_log_once_delegate av_log_once = (void* @avcl, int @initial_level, int @subsequent_level, int* @state, string @fmt) =>
    {
        av_log_once = FunctionLoader.GetFunctionDelegate<av_log_once_delegate>("avutil", "av_log_once");
        if (av_log_once == null)
        {
            av_log_once = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_once(@avcl, @initial_level, @subsequent_level, @state, @fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_set_callback_delegate(av_log_set_callback_callback_func @callback);
    public static av_log_set_callback_delegate av_log_set_callback = (av_log_set_callback_callback_func @callback) =>
    {
        av_log_set_callback = FunctionLoader.GetFunctionDelegate<av_log_set_callback_delegate>("avutil", "av_log_set_callback");
        if (av_log_set_callback == null)
        {
            av_log_set_callback = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_set_callback(@callback);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_set_flags_delegate(int @arg);
    public static av_log_set_flags_delegate av_log_set_flags = (int @arg) =>
    {
        av_log_set_flags = FunctionLoader.GetFunctionDelegate<av_log_set_flags_delegate>("avutil", "av_log_set_flags");
        if (av_log_set_flags == null)
        {
            av_log_set_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_set_flags(@arg);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_log_set_level_delegate(int @level);
    public static av_log_set_level_delegate av_log_set_level = (int @level) =>
    {
        av_log_set_level = FunctionLoader.GetFunctionDelegate<av_log_set_level_delegate>("avutil", "av_log_set_level");
        if (av_log_set_level == null)
        {
            av_log_set_level = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_log_set_level(@level);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_log2_delegate(uint @v);
    public static av_log2_delegate av_log2 = (uint @v) =>
    {
        av_log2 = FunctionLoader.GetFunctionDelegate<av_log2_delegate>("avutil", "av_log2");
        if (av_log2 == null)
        {
            av_log2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_log2(@v);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_log2_16bit_delegate(uint @v);
    public static av_log2_16bit_delegate av_log2_16bit = (uint @v) =>
    {
        av_log2_16bit = FunctionLoader.GetFunctionDelegate<av_log2_16bit_delegate>("avutil", "av_log2_16bit");
        if (av_log2_16bit == null)
        {
            av_log2_16bit = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_log2_16bit(@v);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_malloc_delegate(ulong @size);
    public static av_malloc_delegate av_malloc = (ulong @size) =>
    {
        av_malloc = FunctionLoader.GetFunctionDelegate<av_malloc_delegate>("avutil", "av_malloc");
        if (av_malloc == null)
        {
            av_malloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_malloc(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_malloc_array_delegate(ulong @nmemb, ulong @size);
    public static av_malloc_array_delegate av_malloc_array = (ulong @nmemb, ulong @size) =>
    {
        av_malloc_array = FunctionLoader.GetFunctionDelegate<av_malloc_array_delegate>("avutil", "av_malloc_array");
        if (av_malloc_array == null)
        {
            av_malloc_array = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_malloc_array(@nmemb, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_mallocz_delegate(ulong @size);
    public static av_mallocz_delegate av_mallocz = (ulong @size) =>
    {
        av_mallocz = FunctionLoader.GetFunctionDelegate<av_mallocz_delegate>("avutil", "av_mallocz");
        if (av_mallocz == null)
        {
            av_mallocz = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_mallocz(@size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_mallocz_array_delegate(ulong @nmemb, ulong @size);
    public static av_mallocz_array_delegate av_mallocz_array = (ulong @nmemb, ulong @size) =>
    {
        av_mallocz_array = FunctionLoader.GetFunctionDelegate<av_mallocz_array_delegate>("avutil", "av_mallocz_array");
        if (av_mallocz_array == null)
        {
            av_mallocz_array = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_mallocz_array(@nmemb, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc_delegate();
    public static av_mastering_display_metadata_alloc_delegate av_mastering_display_metadata_alloc = () =>
    {
        av_mastering_display_metadata_alloc = FunctionLoader.GetFunctionDelegate<av_mastering_display_metadata_alloc_delegate>("avutil", "av_mastering_display_metadata_alloc");
        if (av_mastering_display_metadata_alloc == null)
        {
            av_mastering_display_metadata_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_mastering_display_metadata_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data_delegate(AVFrame* @frame);
    public static av_mastering_display_metadata_create_side_data_delegate av_mastering_display_metadata_create_side_data = (AVFrame* @frame) =>
    {
        av_mastering_display_metadata_create_side_data = FunctionLoader.GetFunctionDelegate<av_mastering_display_metadata_create_side_data_delegate>("avutil", "av_mastering_display_metadata_create_side_data");
        if (av_mastering_display_metadata_create_side_data == null)
        {
            av_mastering_display_metadata_create_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_mastering_display_metadata_create_side_data(@frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_match_ext_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @extensions);
    public static av_match_ext_delegate av_match_ext = (string @filename, string @extensions) =>
    {
        av_match_ext = FunctionLoader.GetFunctionDelegate<av_match_ext_delegate>("avformat", "av_match_ext");
        if (av_match_ext == null)
        {
            av_match_ext = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_match_ext(@filename, @extensions);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_max_alloc_delegate(ulong @max);
    public static av_max_alloc_delegate av_max_alloc = (ulong @max) =>
    {
        av_max_alloc = FunctionLoader.GetFunctionDelegate<av_max_alloc_delegate>("avutil", "av_max_alloc");
        if (av_max_alloc == null)
        {
            av_max_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_max_alloc(@max);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_memcpy_backptr_delegate(byte* @dst, int @back, int @cnt);
    public static av_memcpy_backptr_delegate av_memcpy_backptr = (byte* @dst, int @back, int @cnt) =>
    {
        av_memcpy_backptr = FunctionLoader.GetFunctionDelegate<av_memcpy_backptr_delegate>("avutil", "av_memcpy_backptr");
        if (av_memcpy_backptr == null)
        {
            av_memcpy_backptr = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_memcpy_backptr(@dst, @back, @cnt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_memdup_delegate(void* @p, ulong @size);
    public static av_memdup_delegate av_memdup = (void* @p, ulong @size) =>
    {
        av_memdup = FunctionLoader.GetFunctionDelegate<av_memdup_delegate>("avutil", "av_memdup");
        if (av_memdup == null)
        {
            av_memdup = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_memdup(@p, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_mul_q_delegate(AVRational @b, AVRational @c);
    public static av_mul_q_delegate av_mul_q = (AVRational @b, AVRational @c) =>
    {
        av_mul_q = FunctionLoader.GetFunctionDelegate<av_mul_q_delegate>("avutil", "av_mul_q");
        if (av_mul_q == null)
        {
            av_mul_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_mul_q(@b, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOutputFormat* av_muxer_iterate_delegate(void** @opaque);
    public static av_muxer_iterate_delegate av_muxer_iterate = (void** @opaque) =>
    {
        av_muxer_iterate = FunctionLoader.GetFunctionDelegate<av_muxer_iterate_delegate>("avformat", "av_muxer_iterate");
        if (av_muxer_iterate == null)
        {
            av_muxer_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_muxer_iterate(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_nearer_q_delegate(AVRational @q, AVRational @q1, AVRational @q2);
    public static av_nearer_q_delegate av_nearer_q = (AVRational @q, AVRational @q1, AVRational @q2) =>
    {
        av_nearer_q = FunctionLoader.GetFunctionDelegate<av_nearer_q_delegate>("avutil", "av_nearer_q");
        if (av_nearer_q == null)
        {
            av_nearer_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_nearer_q(@q, @q1, @q2);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_new_packet_delegate(AVPacket* @pkt, int @size);
    public static av_new_packet_delegate av_new_packet = (AVPacket* @pkt, int @size) =>
    {
        av_new_packet = FunctionLoader.GetFunctionDelegate<av_new_packet_delegate>("avcodec", "av_new_packet");
        if (av_new_packet == null)
        {
            av_new_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_new_packet(@pkt, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVProgram* av_new_program_delegate(AVFormatContext* @s, int @id);
    public static av_new_program_delegate av_new_program = (AVFormatContext* @s, int @id) =>
    {
        av_new_program = FunctionLoader.GetFunctionDelegate<av_new_program_delegate>("avformat", "av_new_program");
        if (av_new_program == null)
        {
            av_new_program = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_new_program(@s, @id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* av_opt_child_class_iterate_delegate(AVClass* @parent, void** @iter);
    public static av_opt_child_class_iterate_delegate av_opt_child_class_iterate = (AVClass* @parent, void** @iter) =>
    {
        av_opt_child_class_iterate = FunctionLoader.GetFunctionDelegate<av_opt_child_class_iterate_delegate>("avutil", "av_opt_child_class_iterate");
        if (av_opt_child_class_iterate == null)
        {
            av_opt_child_class_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_child_class_iterate(@parent, @iter);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_opt_child_next_delegate(void* @obj, void* @prev);
    public static av_opt_child_next_delegate av_opt_child_next = (void* @obj, void* @prev) =>
    {
        av_opt_child_next = FunctionLoader.GetFunctionDelegate<av_opt_child_next_delegate>("avutil", "av_opt_child_next");
        if (av_opt_child_next == null)
        {
            av_opt_child_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_child_next(@obj, @prev);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_copy_delegate(void* @dest, void* @src);
    public static av_opt_copy_delegate av_opt_copy = (void* @dest, void* @src) =>
    {
        av_opt_copy = FunctionLoader.GetFunctionDelegate<av_opt_copy_delegate>("avutil", "av_opt_copy");
        if (av_opt_copy == null)
        {
            av_opt_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_copy(@dest, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_double_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, double* @double_out);
    public static av_opt_eval_double_delegate av_opt_eval_double = (void* @obj, AVOption* @o, string @val, double* @double_out) =>
    {
        av_opt_eval_double = FunctionLoader.GetFunctionDelegate<av_opt_eval_double_delegate>("avutil", "av_opt_eval_double");
        if (av_opt_eval_double == null)
        {
            av_opt_eval_double = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_double(@obj, @o, @val, @double_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_flags_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @flags_out);
    public static av_opt_eval_flags_delegate av_opt_eval_flags = (void* @obj, AVOption* @o, string @val, int* @flags_out) =>
    {
        av_opt_eval_flags = FunctionLoader.GetFunctionDelegate<av_opt_eval_flags_delegate>("avutil", "av_opt_eval_flags");
        if (av_opt_eval_flags == null)
        {
            av_opt_eval_flags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_flags(@obj, @o, @val, @flags_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_float_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, float* @float_out);
    public static av_opt_eval_float_delegate av_opt_eval_float = (void* @obj, AVOption* @o, string @val, float* @float_out) =>
    {
        av_opt_eval_float = FunctionLoader.GetFunctionDelegate<av_opt_eval_float_delegate>("avutil", "av_opt_eval_float");
        if (av_opt_eval_float == null)
        {
            av_opt_eval_float = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_float(@obj, @o, @val, @float_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_int_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @int_out);
    public static av_opt_eval_int_delegate av_opt_eval_int = (void* @obj, AVOption* @o, string @val, int* @int_out) =>
    {
        av_opt_eval_int = FunctionLoader.GetFunctionDelegate<av_opt_eval_int_delegate>("avutil", "av_opt_eval_int");
        if (av_opt_eval_int == null)
        {
            av_opt_eval_int = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_int(@obj, @o, @val, @int_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_int64_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, long* @int64_out);
    public static av_opt_eval_int64_delegate av_opt_eval_int64 = (void* @obj, AVOption* @o, string @val, long* @int64_out) =>
    {
        av_opt_eval_int64 = FunctionLoader.GetFunctionDelegate<av_opt_eval_int64_delegate>("avutil", "av_opt_eval_int64");
        if (av_opt_eval_int64 == null)
        {
            av_opt_eval_int64 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_int64(@obj, @o, @val, @int64_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_eval_q_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, AVRational* @q_out);
    public static av_opt_eval_q_delegate av_opt_eval_q = (void* @obj, AVOption* @o, string @val, AVRational* @q_out) =>
    {
        av_opt_eval_q = FunctionLoader.GetFunctionDelegate<av_opt_eval_q_delegate>("avutil", "av_opt_eval_q");
        if (av_opt_eval_q == null)
        {
            av_opt_eval_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_eval_q(@obj, @o, @val, @q_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOption* av_opt_find_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags);
    public static av_opt_find_delegate av_opt_find = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags) =>
    {
        av_opt_find = FunctionLoader.GetFunctionDelegate<av_opt_find_delegate>("avutil", "av_opt_find");
        if (av_opt_find == null)
        {
            av_opt_find = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_find(@obj, @name, @unit, @opt_flags, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOption* av_opt_find2_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags, void** @target_obj);
    public static av_opt_find2_delegate av_opt_find2 = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags, void** @target_obj) =>
    {
        av_opt_find2 = FunctionLoader.GetFunctionDelegate<av_opt_find2_delegate>("avutil", "av_opt_find2");
        if (av_opt_find2 == null)
        {
            av_opt_find2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_find2(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_flag_is_set_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @field_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @flag_name);
    public static av_opt_flag_is_set_delegate av_opt_flag_is_set = (void* @obj, string @field_name, string @flag_name) =>
    {
        av_opt_flag_is_set = FunctionLoader.GetFunctionDelegate<av_opt_flag_is_set_delegate>("avutil", "av_opt_flag_is_set");
        if (av_opt_flag_is_set == null)
        {
            av_opt_flag_is_set = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_flag_is_set(@obj, @field_name, @flag_name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_opt_free_delegate(void* @obj);
    public static av_opt_free_delegate av_opt_free = (void* @obj) =>
    {
        av_opt_free = FunctionLoader.GetFunctionDelegate<av_opt_free_delegate>("avutil", "av_opt_free");
        if (av_opt_free == null)
        {
            av_opt_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_opt_free(@obj);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_opt_freep_ranges_delegate(AVOptionRanges** @ranges);
    public static av_opt_freep_ranges_delegate av_opt_freep_ranges = (AVOptionRanges** @ranges) =>
    {
        av_opt_freep_ranges = FunctionLoader.GetFunctionDelegate<av_opt_freep_ranges_delegate>("avutil", "av_opt_freep_ranges");
        if (av_opt_freep_ranges == null)
        {
            av_opt_freep_ranges = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_opt_freep_ranges(@ranges);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, byte** @out_val);
    public static av_opt_get_delegate av_opt_get = (void* @obj, string @name, int @search_flags, byte** @out_val) =>
    {
        av_opt_get = FunctionLoader.GetFunctionDelegate<av_opt_get_delegate>("avutil", "av_opt_get");
        if (av_opt_get == null)
        {
            av_opt_get = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_channel_layout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, long* @ch_layout);
    public static av_opt_get_channel_layout_delegate av_opt_get_channel_layout = (void* @obj, string @name, int @search_flags, long* @ch_layout) =>
    {
        av_opt_get_channel_layout = FunctionLoader.GetFunctionDelegate<av_opt_get_channel_layout_delegate>("avutil", "av_opt_get_channel_layout");
        if (av_opt_get_channel_layout == null)
        {
            av_opt_get_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_channel_layout(@obj, @name, @search_flags, @ch_layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_chlayout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVChannelLayout* @layout);
    public static av_opt_get_chlayout_delegate av_opt_get_chlayout = (void* @obj, string @name, int @search_flags, AVChannelLayout* @layout) =>
    {
        av_opt_get_chlayout = FunctionLoader.GetFunctionDelegate<av_opt_get_chlayout_delegate>("avutil", "av_opt_get_chlayout");
        if (av_opt_get_chlayout == null)
        {
            av_opt_get_chlayout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_chlayout(@obj, @name, @search_flags, @layout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_dict_val_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val);
    public static av_opt_get_dict_val_delegate av_opt_get_dict_val = (void* @obj, string @name, int @search_flags, AVDictionary** @out_val) =>
    {
        av_opt_get_dict_val = FunctionLoader.GetFunctionDelegate<av_opt_get_dict_val_delegate>("avutil", "av_opt_get_dict_val");
        if (av_opt_get_dict_val == null)
        {
            av_opt_get_dict_val = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_dict_val(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_double_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, double* @out_val);
    public static av_opt_get_double_delegate av_opt_get_double = (void* @obj, string @name, int @search_flags, double* @out_val) =>
    {
        av_opt_get_double = FunctionLoader.GetFunctionDelegate<av_opt_get_double_delegate>("avutil", "av_opt_get_double");
        if (av_opt_get_double == null)
        {
            av_opt_get_double = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_double(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_image_size_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out);
    public static av_opt_get_image_size_delegate av_opt_get_image_size = (void* @obj, string @name, int @search_flags, int* @w_out, int* @h_out) =>
    {
        av_opt_get_image_size = FunctionLoader.GetFunctionDelegate<av_opt_get_image_size_delegate>("avutil", "av_opt_get_image_size");
        if (av_opt_get_image_size == null)
        {
            av_opt_get_image_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_image_size(@obj, @name, @search_flags, @w_out, @h_out);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_int_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, long* @out_val);
    public static av_opt_get_int_delegate av_opt_get_int = (void* @obj, string @name, int @search_flags, long* @out_val) =>
    {
        av_opt_get_int = FunctionLoader.GetFunctionDelegate<av_opt_get_int_delegate>("avutil", "av_opt_get_int");
        if (av_opt_get_int == null)
        {
            av_opt_get_int = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_int(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_key_value_delegate(byte** @ropts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);
    public static av_opt_get_key_value_delegate av_opt_get_key_value = (byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, byte** @rval) =>
    {
        av_opt_get_key_value = FunctionLoader.GetFunctionDelegate<av_opt_get_key_value_delegate>("avutil", "av_opt_get_key_value");
        if (av_opt_get_key_value == null)
        {
            av_opt_get_key_value = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_pixel_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt);
    public static av_opt_get_pixel_fmt_delegate av_opt_get_pixel_fmt = (void* @obj, string @name, int @search_flags, AVPixelFormat* @out_fmt) =>
    {
        av_opt_get_pixel_fmt = FunctionLoader.GetFunctionDelegate<av_opt_get_pixel_fmt_delegate>("avutil", "av_opt_get_pixel_fmt");
        if (av_opt_get_pixel_fmt == null)
        {
            av_opt_get_pixel_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_pixel_fmt(@obj, @name, @search_flags, @out_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_q_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    public static av_opt_get_q_delegate av_opt_get_q = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
    {
        av_opt_get_q = FunctionLoader.GetFunctionDelegate<av_opt_get_q_delegate>("avutil", "av_opt_get_q");
        if (av_opt_get_q == null)
        {
            av_opt_get_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_q(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_sample_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt);
    public static av_opt_get_sample_fmt_delegate av_opt_get_sample_fmt = (void* @obj, string @name, int @search_flags, AVSampleFormat* @out_fmt) =>
    {
        av_opt_get_sample_fmt = FunctionLoader.GetFunctionDelegate<av_opt_get_sample_fmt_delegate>("avutil", "av_opt_get_sample_fmt");
        if (av_opt_get_sample_fmt == null)
        {
            av_opt_get_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_sample_fmt(@obj, @name, @search_flags, @out_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_get_video_rate_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    public static av_opt_get_video_rate_delegate av_opt_get_video_rate = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
    {
        av_opt_get_video_rate = FunctionLoader.GetFunctionDelegate<av_opt_get_video_rate_delegate>("avutil", "av_opt_get_video_rate");
        if (av_opt_get_video_rate == null)
        {
            av_opt_get_video_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_get_video_rate(@obj, @name, @search_flags, @out_val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_is_set_to_default_delegate(void* @obj, AVOption* @o);
    public static av_opt_is_set_to_default_delegate av_opt_is_set_to_default = (void* @obj, AVOption* @o) =>
    {
        av_opt_is_set_to_default = FunctionLoader.GetFunctionDelegate<av_opt_is_set_to_default_delegate>("avutil", "av_opt_is_set_to_default");
        if (av_opt_is_set_to_default == null)
        {
            av_opt_is_set_to_default = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_is_set_to_default(@obj, @o);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_is_set_to_default_by_name_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags);
    public static av_opt_is_set_to_default_by_name_delegate av_opt_is_set_to_default_by_name = (void* @obj, string @name, int @search_flags) =>
    {
        av_opt_is_set_to_default_by_name = FunctionLoader.GetFunctionDelegate<av_opt_is_set_to_default_by_name_delegate>("avutil", "av_opt_is_set_to_default_by_name");
        if (av_opt_is_set_to_default_by_name == null)
        {
            av_opt_is_set_to_default_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_is_set_to_default_by_name(@obj, @name, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOption* av_opt_next_delegate(void* @obj, AVOption* @prev);
    public static av_opt_next_delegate av_opt_next = (void* @obj, AVOption* @prev) =>
    {
        av_opt_next = FunctionLoader.GetFunctionDelegate<av_opt_next_delegate>("avutil", "av_opt_next");
        if (av_opt_next == null)
        {
            av_opt_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_next(@obj, @prev);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_opt_ptr_delegate(AVClass* @avclass, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static av_opt_ptr_delegate av_opt_ptr = (AVClass* @avclass, void* @obj, string @name) =>
    {
        av_opt_ptr = FunctionLoader.GetFunctionDelegate<av_opt_ptr_delegate>("avutil", "av_opt_ptr");
        if (av_opt_ptr == null)
        {
            av_opt_ptr = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_ptr(@avclass, @obj, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_query_ranges_delegate(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    public static av_opt_query_ranges_delegate av_opt_query_ranges = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
    {
        av_opt_query_ranges = FunctionLoader.GetFunctionDelegate<av_opt_query_ranges_delegate>("avutil", "av_opt_query_ranges");
        if (av_opt_query_ranges == null)
        {
            av_opt_query_ranges = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_query_ranges(@p0, @obj, @key, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_query_ranges_default_delegate(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    public static av_opt_query_ranges_default_delegate av_opt_query_ranges_default = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
    {
        av_opt_query_ranges_default = FunctionLoader.GetFunctionDelegate<av_opt_query_ranges_default_delegate>("avutil", "av_opt_query_ranges_default");
        if (av_opt_query_ranges_default == null)
        {
            av_opt_query_ranges_default = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_query_ranges_default(@p0, @obj, @key, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_serialize_delegate(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    public static av_opt_serialize_delegate av_opt_serialize = (void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
    {
        av_opt_serialize = FunctionLoader.GetFunctionDelegate<av_opt_serialize_delegate>("avutil", "av_opt_serialize");
        if (av_opt_serialize == null)
        {
            av_opt_serialize = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_serialize(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int @search_flags);
    public static av_opt_set_delegate av_opt_set = (void* @obj, string @name, string @val, int @search_flags) =>
    {
        av_opt_set = FunctionLoader.GetFunctionDelegate<av_opt_set_delegate>("avutil", "av_opt_set");
        if (av_opt_set == null)
        {
            av_opt_set = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_bin_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, byte* @val, int @size, int @search_flags);
    public static av_opt_set_bin_delegate av_opt_set_bin = (void* @obj, string @name, byte* @val, int @size, int @search_flags) =>
    {
        av_opt_set_bin = FunctionLoader.GetFunctionDelegate<av_opt_set_bin_delegate>("avutil", "av_opt_set_bin");
        if (av_opt_set_bin == null)
        {
            av_opt_set_bin = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_bin(@obj, @name, @val, @size, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_channel_layout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, long @ch_layout, int @search_flags);
    public static av_opt_set_channel_layout_delegate av_opt_set_channel_layout = (void* @obj, string @name, long @ch_layout, int @search_flags) =>
    {
        av_opt_set_channel_layout = FunctionLoader.GetFunctionDelegate<av_opt_set_channel_layout_delegate>("avutil", "av_opt_set_channel_layout");
        if (av_opt_set_channel_layout == null)
        {
            av_opt_set_channel_layout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_channel_layout(@obj, @name, @ch_layout, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_chlayout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVChannelLayout* @layout, int @search_flags);
    public static av_opt_set_chlayout_delegate av_opt_set_chlayout = (void* @obj, string @name, AVChannelLayout* @layout, int @search_flags) =>
    {
        av_opt_set_chlayout = FunctionLoader.GetFunctionDelegate<av_opt_set_chlayout_delegate>("avutil", "av_opt_set_chlayout");
        if (av_opt_set_chlayout == null)
        {
            av_opt_set_chlayout = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_chlayout(@obj, @name, @layout, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_opt_set_defaults_delegate(void* @s);
    public static av_opt_set_defaults_delegate av_opt_set_defaults = (void* @s) =>
    {
        av_opt_set_defaults = FunctionLoader.GetFunctionDelegate<av_opt_set_defaults_delegate>("avutil", "av_opt_set_defaults");
        if (av_opt_set_defaults == null)
        {
            av_opt_set_defaults = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_opt_set_defaults(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_opt_set_defaults2_delegate(void* @s, int @mask, int @flags);
    public static av_opt_set_defaults2_delegate av_opt_set_defaults2 = (void* @s, int @mask, int @flags) =>
    {
        av_opt_set_defaults2 = FunctionLoader.GetFunctionDelegate<av_opt_set_defaults2_delegate>("avutil", "av_opt_set_defaults2");
        if (av_opt_set_defaults2 == null)
        {
            av_opt_set_defaults2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_opt_set_defaults2(@s, @mask, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_dict_delegate(void* @obj, AVDictionary** @options);
    public static av_opt_set_dict_delegate av_opt_set_dict = (void* @obj, AVDictionary** @options) =>
    {
        av_opt_set_dict = FunctionLoader.GetFunctionDelegate<av_opt_set_dict_delegate>("avutil", "av_opt_set_dict");
        if (av_opt_set_dict == null)
        {
            av_opt_set_dict = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_dict(@obj, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_dict_val_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVDictionary* @val, int @search_flags);
    public static av_opt_set_dict_val_delegate av_opt_set_dict_val = (void* @obj, string @name, AVDictionary* @val, int @search_flags) =>
    {
        av_opt_set_dict_val = FunctionLoader.GetFunctionDelegate<av_opt_set_dict_val_delegate>("avutil", "av_opt_set_dict_val");
        if (av_opt_set_dict_val == null)
        {
            av_opt_set_dict_val = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_dict_val(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_dict2_delegate(void* @obj, AVDictionary** @options, int @search_flags);
    public static av_opt_set_dict2_delegate av_opt_set_dict2 = (void* @obj, AVDictionary** @options, int @search_flags) =>
    {
        av_opt_set_dict2 = FunctionLoader.GetFunctionDelegate<av_opt_set_dict2_delegate>("avutil", "av_opt_set_dict2");
        if (av_opt_set_dict2 == null)
        {
            av_opt_set_dict2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_dict2(@obj, @options, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_double_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, double @val, int @search_flags);
    public static av_opt_set_double_delegate av_opt_set_double = (void* @obj, string @name, double @val, int @search_flags) =>
    {
        av_opt_set_double = FunctionLoader.GetFunctionDelegate<av_opt_set_double_delegate>("avutil", "av_opt_set_double");
        if (av_opt_set_double == null)
        {
            av_opt_set_double = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_double(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_from_string_delegate(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts, byte** @shorthand,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep);
    public static av_opt_set_from_string_delegate av_opt_set_from_string = (void* @ctx, string @opts, byte** @shorthand, string @key_val_sep, string @pairs_sep) =>
    {
        av_opt_set_from_string = FunctionLoader.GetFunctionDelegate<av_opt_set_from_string_delegate>("avutil", "av_opt_set_from_string");
        if (av_opt_set_from_string == null)
        {
            av_opt_set_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_from_string(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_image_size_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @w, int @h, int @search_flags);
    public static av_opt_set_image_size_delegate av_opt_set_image_size = (void* @obj, string @name, int @w, int @h, int @search_flags) =>
    {
        av_opt_set_image_size = FunctionLoader.GetFunctionDelegate<av_opt_set_image_size_delegate>("avutil", "av_opt_set_image_size");
        if (av_opt_set_image_size == null)
        {
            av_opt_set_image_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_image_size(@obj, @name, @w, @h, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_int_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, long @val, int @search_flags);
    public static av_opt_set_int_delegate av_opt_set_int = (void* @obj, string @name, long @val, int @search_flags) =>
    {
        av_opt_set_int = FunctionLoader.GetFunctionDelegate<av_opt_set_int_delegate>("avutil", "av_opt_set_int");
        if (av_opt_set_int == null)
        {
            av_opt_set_int = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_int(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_pixel_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags);
    public static av_opt_set_pixel_fmt_delegate av_opt_set_pixel_fmt = (void* @obj, string @name, AVPixelFormat @fmt, int @search_flags) =>
    {
        av_opt_set_pixel_fmt = FunctionLoader.GetFunctionDelegate<av_opt_set_pixel_fmt_delegate>("avutil", "av_opt_set_pixel_fmt");
        if (av_opt_set_pixel_fmt == null)
        {
            av_opt_set_pixel_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_pixel_fmt(@obj, @name, @fmt, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_q_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    public static av_opt_set_q_delegate av_opt_set_q = (void* @obj, string @name, AVRational @val, int @search_flags) =>
    {
        av_opt_set_q = FunctionLoader.GetFunctionDelegate<av_opt_set_q_delegate>("avutil", "av_opt_set_q");
        if (av_opt_set_q == null)
        {
            av_opt_set_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_q(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_sample_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags);
    public static av_opt_set_sample_fmt_delegate av_opt_set_sample_fmt = (void* @obj, string @name, AVSampleFormat @fmt, int @search_flags) =>
    {
        av_opt_set_sample_fmt = FunctionLoader.GetFunctionDelegate<av_opt_set_sample_fmt_delegate>("avutil", "av_opt_set_sample_fmt");
        if (av_opt_set_sample_fmt == null)
        {
            av_opt_set_sample_fmt = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_sample_fmt(@obj, @name, @fmt, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_set_video_rate_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    public static av_opt_set_video_rate_delegate av_opt_set_video_rate = (void* @obj, string @name, AVRational @val, int @search_flags) =>
    {
        av_opt_set_video_rate = FunctionLoader.GetFunctionDelegate<av_opt_set_video_rate_delegate>("avutil", "av_opt_set_video_rate");
        if (av_opt_set_video_rate == null)
        {
            av_opt_set_video_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_set_video_rate(@obj, @name, @val, @search_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_opt_show2_delegate(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
    public static av_opt_show2_delegate av_opt_show2 = (void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags) =>
    {
        av_opt_show2 = FunctionLoader.GetFunctionDelegate<av_opt_show2_delegate>("avutil", "av_opt_show2");
        if (av_opt_show2 == null)
        {
            av_opt_show2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_opt_show2(@obj, @av_log_obj, @req_flags, @rej_flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOutputFormat* av_output_audio_device_next_delegate(AVOutputFormat* @d);
    public static av_output_audio_device_next_delegate av_output_audio_device_next = (AVOutputFormat* @d) =>
    {
        av_output_audio_device_next = FunctionLoader.GetFunctionDelegate<av_output_audio_device_next_delegate>("avdevice", "av_output_audio_device_next");
        if (av_output_audio_device_next == null)
        {
            av_output_audio_device_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_output_audio_device_next(@d);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVOutputFormat* av_output_video_device_next_delegate(AVOutputFormat* @d);
    public static av_output_video_device_next_delegate av_output_video_device_next = (AVOutputFormat* @d) =>
    {
        av_output_video_device_next = FunctionLoader.GetFunctionDelegate<av_output_video_device_next_delegate>("avdevice", "av_output_video_device_next");
        if (av_output_video_device_next == null)
        {
            av_output_video_device_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_output_video_device_next(@d);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_add_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
    public static av_packet_add_side_data_delegate av_packet_add_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size) =>
    {
        av_packet_add_side_data = FunctionLoader.GetFunctionDelegate<av_packet_add_side_data_delegate>("avcodec", "av_packet_add_side_data");
        if (av_packet_add_side_data == null)
        {
            av_packet_add_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_add_side_data(@pkt, @type, @data, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPacket* av_packet_alloc_delegate();
    public static av_packet_alloc_delegate av_packet_alloc = () =>
    {
        av_packet_alloc = FunctionLoader.GetFunctionDelegate<av_packet_alloc_delegate>("avcodec", "av_packet_alloc");
        if (av_packet_alloc == null)
        {
            av_packet_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPacket* av_packet_clone_delegate(AVPacket* @src);
    public static av_packet_clone_delegate av_packet_clone = (AVPacket* @src) =>
    {
        av_packet_clone = FunctionLoader.GetFunctionDelegate<av_packet_clone_delegate>("avcodec", "av_packet_clone");
        if (av_packet_clone == null)
        {
            av_packet_clone = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_clone(@src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_copy_props_delegate(AVPacket* @dst, AVPacket* @src);
    public static av_packet_copy_props_delegate av_packet_copy_props = (AVPacket* @dst, AVPacket* @src) =>
    {
        av_packet_copy_props = FunctionLoader.GetFunctionDelegate<av_packet_copy_props_delegate>("avcodec", "av_packet_copy_props");
        if (av_packet_copy_props == null)
        {
            av_packet_copy_props = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_copy_props(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_packet_free_delegate(AVPacket** @pkt);
    public static av_packet_free_delegate av_packet_free = (AVPacket** @pkt) =>
    {
        av_packet_free = FunctionLoader.GetFunctionDelegate<av_packet_free_delegate>("avcodec", "av_packet_free");
        if (av_packet_free == null)
        {
            av_packet_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_packet_free(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_packet_free_side_data_delegate(AVPacket* @pkt);
    public static av_packet_free_side_data_delegate av_packet_free_side_data = (AVPacket* @pkt) =>
    {
        av_packet_free_side_data = FunctionLoader.GetFunctionDelegate<av_packet_free_side_data_delegate>("avcodec", "av_packet_free_side_data");
        if (av_packet_free_side_data == null)
        {
            av_packet_free_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_packet_free_side_data(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_from_data_delegate(AVPacket* @pkt, byte* @data, int @size);
    public static av_packet_from_data_delegate av_packet_from_data = (AVPacket* @pkt, byte* @data, int @size) =>
    {
        av_packet_from_data = FunctionLoader.GetFunctionDelegate<av_packet_from_data_delegate>("avcodec", "av_packet_from_data");
        if (av_packet_from_data == null)
        {
            av_packet_from_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_from_data(@pkt, @data, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_packet_get_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size);
    public static av_packet_get_side_data_delegate av_packet_get_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size) =>
    {
        av_packet_get_side_data = FunctionLoader.GetFunctionDelegate<av_packet_get_side_data_delegate>("avcodec", "av_packet_get_side_data");
        if (av_packet_get_side_data == null)
        {
            av_packet_get_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_get_side_data(@pkt, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_make_refcounted_delegate(AVPacket* @pkt);
    public static av_packet_make_refcounted_delegate av_packet_make_refcounted = (AVPacket* @pkt) =>
    {
        av_packet_make_refcounted = FunctionLoader.GetFunctionDelegate<av_packet_make_refcounted_delegate>("avcodec", "av_packet_make_refcounted");
        if (av_packet_make_refcounted == null)
        {
            av_packet_make_refcounted = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_make_refcounted(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_make_writable_delegate(AVPacket* @pkt);
    public static av_packet_make_writable_delegate av_packet_make_writable = (AVPacket* @pkt) =>
    {
        av_packet_make_writable = FunctionLoader.GetFunctionDelegate<av_packet_make_writable_delegate>("avcodec", "av_packet_make_writable");
        if (av_packet_make_writable == null)
        {
            av_packet_make_writable = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_make_writable(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_packet_move_ref_delegate(AVPacket* @dst, AVPacket* @src);
    public static av_packet_move_ref_delegate av_packet_move_ref = (AVPacket* @dst, AVPacket* @src) =>
    {
        av_packet_move_ref = FunctionLoader.GetFunctionDelegate<av_packet_move_ref_delegate>("avcodec", "av_packet_move_ref");
        if (av_packet_move_ref == null)
        {
            av_packet_move_ref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_packet_move_ref(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_packet_new_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    public static av_packet_new_side_data_delegate av_packet_new_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) =>
    {
        av_packet_new_side_data = FunctionLoader.GetFunctionDelegate<av_packet_new_side_data_delegate>("avcodec", "av_packet_new_side_data");
        if (av_packet_new_side_data == null)
        {
            av_packet_new_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_new_side_data(@pkt, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_packet_pack_dictionary_delegate(AVDictionary* @dict, ulong* @size);
    public static av_packet_pack_dictionary_delegate av_packet_pack_dictionary = (AVDictionary* @dict, ulong* @size) =>
    {
        av_packet_pack_dictionary = FunctionLoader.GetFunctionDelegate<av_packet_pack_dictionary_delegate>("avcodec", "av_packet_pack_dictionary");
        if (av_packet_pack_dictionary == null)
        {
            av_packet_pack_dictionary = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_pack_dictionary(@dict, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_ref_delegate(AVPacket* @dst, AVPacket* @src);
    public static av_packet_ref_delegate av_packet_ref = (AVPacket* @dst, AVPacket* @src) =>
    {
        av_packet_ref = FunctionLoader.GetFunctionDelegate<av_packet_ref_delegate>("avcodec", "av_packet_ref");
        if (av_packet_ref == null)
        {
            av_packet_ref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_ref(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_packet_rescale_ts_delegate(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
    public static av_packet_rescale_ts_delegate av_packet_rescale_ts = (AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst) =>
    {
        av_packet_rescale_ts = FunctionLoader.GetFunctionDelegate<av_packet_rescale_ts_delegate>("avcodec", "av_packet_rescale_ts");
        if (av_packet_rescale_ts == null)
        {
            av_packet_rescale_ts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_packet_rescale_ts(@pkt, @tb_src, @tb_dst);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_shrink_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    public static av_packet_shrink_side_data_delegate av_packet_shrink_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) =>
    {
        av_packet_shrink_side_data = FunctionLoader.GetFunctionDelegate<av_packet_shrink_side_data_delegate>("avcodec", "av_packet_shrink_side_data");
        if (av_packet_shrink_side_data == null)
        {
            av_packet_shrink_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_shrink_side_data(@pkt, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_packet_side_data_name_delegate(AVPacketSideDataType @type);
    public static av_packet_side_data_name_delegate av_packet_side_data_name = (AVPacketSideDataType @type) =>
    {
        av_packet_side_data_name = FunctionLoader.GetFunctionDelegate<av_packet_side_data_name_delegate>("avcodec", "av_packet_side_data_name");
        if (av_packet_side_data_name == null)
        {
            av_packet_side_data_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_side_data_name(@type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_packet_unpack_dictionary_delegate(byte* @data, ulong @size, AVDictionary** @dict);
    public static av_packet_unpack_dictionary_delegate av_packet_unpack_dictionary = (byte* @data, ulong @size, AVDictionary** @dict) =>
    {
        av_packet_unpack_dictionary = FunctionLoader.GetFunctionDelegate<av_packet_unpack_dictionary_delegate>("avcodec", "av_packet_unpack_dictionary");
        if (av_packet_unpack_dictionary == null)
        {
            av_packet_unpack_dictionary = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_packet_unpack_dictionary(@data, @size, @dict);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_packet_unref_delegate(AVPacket* @pkt);
    public static av_packet_unref_delegate av_packet_unref = (AVPacket* @pkt) =>
    {
        av_packet_unref = FunctionLoader.GetFunctionDelegate<av_packet_unref_delegate>("avcodec", "av_packet_unref");
        if (av_packet_unref == null)
        {
            av_packet_unref = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_packet_unref(@pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_parse_cpu_caps_delegate(uint* @flags,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    public static av_parse_cpu_caps_delegate av_parse_cpu_caps = (uint* @flags, string @s) =>
    {
        av_parse_cpu_caps = FunctionLoader.GetFunctionDelegate<av_parse_cpu_caps_delegate>("avutil", "av_parse_cpu_caps");
        if (av_parse_cpu_caps == null)
        {
            av_parse_cpu_caps = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_parse_cpu_caps(@flags, @s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_parser_close_delegate(AVCodecParserContext* @s);
    public static av_parser_close_delegate av_parser_close = (AVCodecParserContext* @s) =>
    {
        av_parser_close = FunctionLoader.GetFunctionDelegate<av_parser_close_delegate>("avcodec", "av_parser_close");
        if (av_parser_close == null)
        {
            av_parser_close = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_parser_close(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecParserContext* av_parser_init_delegate(int @codec_id);
    public static av_parser_init_delegate av_parser_init = (int @codec_id) =>
    {
        av_parser_init = FunctionLoader.GetFunctionDelegate<av_parser_init_delegate>("avcodec", "av_parser_init");
        if (av_parser_init == null)
        {
            av_parser_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_parser_init(@codec_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecParser* av_parser_iterate_delegate(void** @opaque);
    public static av_parser_iterate_delegate av_parser_iterate = (void** @opaque) =>
    {
        av_parser_iterate = FunctionLoader.GetFunctionDelegate<av_parser_iterate_delegate>("avcodec", "av_parser_iterate");
        if (av_parser_iterate == null)
        {
            av_parser_iterate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_parser_iterate(@opaque);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_parser_parse2_delegate(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
    public static av_parser_parse2_delegate av_parser_parse2 = (AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos) =>
    {
        av_parser_parse2 = FunctionLoader.GetFunctionDelegate<av_parser_parse2_delegate>("avcodec", "av_parser_parse2");
        if (av_parser_parse2 == null)
        {
            av_parser_parse2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_parser_parse2(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_pix_fmt_count_planes_delegate(AVPixelFormat @pix_fmt);
    public static av_pix_fmt_count_planes_delegate av_pix_fmt_count_planes = (AVPixelFormat @pix_fmt) =>
    {
        av_pix_fmt_count_planes = FunctionLoader.GetFunctionDelegate<av_pix_fmt_count_planes_delegate>("avutil", "av_pix_fmt_count_planes");
        if (av_pix_fmt_count_planes == null)
        {
            av_pix_fmt_count_planes = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_count_planes(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixFmtDescriptor* av_pix_fmt_desc_get_delegate(AVPixelFormat @pix_fmt);
    public static av_pix_fmt_desc_get_delegate av_pix_fmt_desc_get = (AVPixelFormat @pix_fmt) =>
    {
        av_pix_fmt_desc_get = FunctionLoader.GetFunctionDelegate<av_pix_fmt_desc_get_delegate>("avutil", "av_pix_fmt_desc_get");
        if (av_pix_fmt_desc_get == null)
        {
            av_pix_fmt_desc_get = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_desc_get(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat av_pix_fmt_desc_get_id_delegate(AVPixFmtDescriptor* @desc);
    public static av_pix_fmt_desc_get_id_delegate av_pix_fmt_desc_get_id = (AVPixFmtDescriptor* @desc) =>
    {
        av_pix_fmt_desc_get_id = FunctionLoader.GetFunctionDelegate<av_pix_fmt_desc_get_id_delegate>("avutil", "av_pix_fmt_desc_get_id");
        if (av_pix_fmt_desc_get_id == null)
        {
            av_pix_fmt_desc_get_id = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_desc_get_id(@desc);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixFmtDescriptor* av_pix_fmt_desc_next_delegate(AVPixFmtDescriptor* @prev);
    public static av_pix_fmt_desc_next_delegate av_pix_fmt_desc_next = (AVPixFmtDescriptor* @prev) =>
    {
        av_pix_fmt_desc_next = FunctionLoader.GetFunctionDelegate<av_pix_fmt_desc_next_delegate>("avutil", "av_pix_fmt_desc_next");
        if (av_pix_fmt_desc_next == null)
        {
            av_pix_fmt_desc_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_desc_next(@prev);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_pix_fmt_get_chroma_sub_sample_delegate(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
    public static av_pix_fmt_get_chroma_sub_sample_delegate av_pix_fmt_get_chroma_sub_sample = (AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift) =>
    {
        av_pix_fmt_get_chroma_sub_sample = FunctionLoader.GetFunctionDelegate<av_pix_fmt_get_chroma_sub_sample_delegate>("avutil", "av_pix_fmt_get_chroma_sub_sample");
        if (av_pix_fmt_get_chroma_sub_sample == null)
        {
            av_pix_fmt_get_chroma_sub_sample = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_get_chroma_sub_sample(@pix_fmt, @h_shift, @v_shift);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat av_pix_fmt_swap_endianness_delegate(AVPixelFormat @pix_fmt);
    public static av_pix_fmt_swap_endianness_delegate av_pix_fmt_swap_endianness = (AVPixelFormat @pix_fmt) =>
    {
        av_pix_fmt_swap_endianness = FunctionLoader.GetFunctionDelegate<av_pix_fmt_swap_endianness_delegate>("avutil", "av_pix_fmt_swap_endianness");
        if (av_pix_fmt_swap_endianness == null)
        {
            av_pix_fmt_swap_endianness = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_pix_fmt_swap_endianness(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_pkt_dump_log2_delegate(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    public static av_pkt_dump_log2_delegate av_pkt_dump_log2 = (void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
    {
        av_pkt_dump_log2 = FunctionLoader.GetFunctionDelegate<av_pkt_dump_log2_delegate>("avformat", "av_pkt_dump_log2");
        if (av_pkt_dump_log2 == null)
        {
            av_pkt_dump_log2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_pkt_dump_log2(@avcl, @level, @pkt, @dump_payload, @st);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_pkt_dump2_delegate(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    public static av_pkt_dump2_delegate av_pkt_dump2 = (_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
    {
        av_pkt_dump2 = FunctionLoader.GetFunctionDelegate<av_pkt_dump2_delegate>("avformat", "av_pkt_dump2");
        if (av_pkt_dump2 == null)
        {
            av_pkt_dump2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_pkt_dump2(@f, @pkt, @dump_payload, @st);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_probe_input_buffer_delegate(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    public static av_probe_input_buffer_delegate av_probe_input_buffer = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
    {
        av_probe_input_buffer = FunctionLoader.GetFunctionDelegate<av_probe_input_buffer_delegate>("avformat", "av_probe_input_buffer");
        if (av_probe_input_buffer == null)
        {
            av_probe_input_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_probe_input_buffer(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_probe_input_buffer2_delegate(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    public static av_probe_input_buffer2_delegate av_probe_input_buffer2 = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
    {
        av_probe_input_buffer2 = FunctionLoader.GetFunctionDelegate<av_probe_input_buffer2_delegate>("avformat", "av_probe_input_buffer2");
        if (av_probe_input_buffer2 == null)
        {
            av_probe_input_buffer2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_probe_input_buffer2(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_probe_input_format_delegate(AVProbeData* @pd, int @is_opened);
    public static av_probe_input_format_delegate av_probe_input_format = (AVProbeData* @pd, int @is_opened) =>
    {
        av_probe_input_format = FunctionLoader.GetFunctionDelegate<av_probe_input_format_delegate>("avformat", "av_probe_input_format");
        if (av_probe_input_format == null)
        {
            av_probe_input_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_probe_input_format(@pd, @is_opened);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_probe_input_format2_delegate(AVProbeData* @pd, int @is_opened, int* @score_max);
    public static av_probe_input_format2_delegate av_probe_input_format2 = (AVProbeData* @pd, int @is_opened, int* @score_max) =>
    {
        av_probe_input_format2 = FunctionLoader.GetFunctionDelegate<av_probe_input_format2_delegate>("avformat", "av_probe_input_format2");
        if (av_probe_input_format2 == null)
        {
            av_probe_input_format2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_probe_input_format2(@pd, @is_opened, @score_max);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVInputFormat* av_probe_input_format3_delegate(AVProbeData* @pd, int @is_opened, int* @score_ret);
    public static av_probe_input_format3_delegate av_probe_input_format3 = (AVProbeData* @pd, int @is_opened, int* @score_ret) =>
    {
        av_probe_input_format3 = FunctionLoader.GetFunctionDelegate<av_probe_input_format3_delegate>("avformat", "av_probe_input_format3");
        if (av_probe_input_format3 == null)
        {
            av_probe_input_format3 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_probe_input_format3(@pd, @is_opened, @score_ret);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_program_add_stream_index_delegate(AVFormatContext* @ac, int @progid, uint @idx);
    public static av_program_add_stream_index_delegate av_program_add_stream_index = (AVFormatContext* @ac, int @progid, uint @idx) =>
    {
        av_program_add_stream_index = FunctionLoader.GetFunctionDelegate<av_program_add_stream_index_delegate>("avformat", "av_program_add_stream_index");
        if (av_program_add_stream_index == null)
        {
            av_program_add_stream_index = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_program_add_stream_index(@ac, @progid, @idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_q2intfloat_delegate(AVRational @q);
    public static av_q2intfloat_delegate av_q2intfloat = (AVRational @q) =>
    {
        av_q2intfloat = FunctionLoader.GetFunctionDelegate<av_q2intfloat_delegate>("avutil", "av_q2intfloat");
        if (av_q2intfloat == null)
        {
            av_q2intfloat = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_q2intfloat(@q);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_read_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    public static av_read_frame_delegate av_read_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
    {
        av_read_frame = FunctionLoader.GetFunctionDelegate<av_read_frame_delegate>("avformat", "av_read_frame");
        if (av_read_frame == null)
        {
            av_read_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_read_frame(@s, @pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_read_image_line_delegate(ushort* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
    public static av_read_image_line_delegate av_read_image_line = (ushort* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component) =>
    {
        av_read_image_line = FunctionLoader.GetFunctionDelegate<av_read_image_line_delegate>("avutil", "av_read_image_line");
        if (av_read_image_line == null)
        {
            av_read_image_line = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_read_image_line(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_read_image_line2_delegate(void* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size);
    public static av_read_image_line2_delegate av_read_image_line2 = (void* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size) =>
    {
        av_read_image_line2 = FunctionLoader.GetFunctionDelegate<av_read_image_line2_delegate>("avutil", "av_read_image_line2");
        if (av_read_image_line2 == null)
        {
            av_read_image_line2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_read_image_line2(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component, @dst_element_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_read_pause_delegate(AVFormatContext* @s);
    public static av_read_pause_delegate av_read_pause = (AVFormatContext* @s) =>
    {
        av_read_pause = FunctionLoader.GetFunctionDelegate<av_read_pause_delegate>("avformat", "av_read_pause");
        if (av_read_pause == null)
        {
            av_read_pause = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_read_pause(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_read_play_delegate(AVFormatContext* @s);
    public static av_read_play_delegate av_read_play = (AVFormatContext* @s) =>
    {
        av_read_play = FunctionLoader.GetFunctionDelegate<av_read_play_delegate>("avformat", "av_read_play");
        if (av_read_play == null)
        {
            av_read_play = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_read_play(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_realloc_delegate(void* @ptr, ulong @size);
    public static av_realloc_delegate av_realloc = (void* @ptr, ulong @size) =>
    {
        av_realloc = FunctionLoader.GetFunctionDelegate<av_realloc_delegate>("avutil", "av_realloc");
        if (av_realloc == null)
        {
            av_realloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_realloc(@ptr, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_realloc_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
    public static av_realloc_array_delegate av_realloc_array = (void* @ptr, ulong @nmemb, ulong @size) =>
    {
        av_realloc_array = FunctionLoader.GetFunctionDelegate<av_realloc_array_delegate>("avutil", "av_realloc_array");
        if (av_realloc_array == null)
        {
            av_realloc_array = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_realloc_array(@ptr, @nmemb, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_realloc_f_delegate(void* @ptr, ulong @nelem, ulong @elsize);
    public static av_realloc_f_delegate av_realloc_f = (void* @ptr, ulong @nelem, ulong @elsize) =>
    {
        av_realloc_f = FunctionLoader.GetFunctionDelegate<av_realloc_f_delegate>("avutil", "av_realloc_f");
        if (av_realloc_f == null)
        {
            av_realloc_f = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_realloc_f(@ptr, @nelem, @elsize);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_reallocp_delegate(void* @ptr, ulong @size);
    public static av_reallocp_delegate av_reallocp = (void* @ptr, ulong @size) =>
    {
        av_reallocp = FunctionLoader.GetFunctionDelegate<av_reallocp_delegate>("avutil", "av_reallocp");
        if (av_reallocp == null)
        {
            av_reallocp = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_reallocp(@ptr, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_reallocp_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
    public static av_reallocp_array_delegate av_reallocp_array = (void* @ptr, ulong @nmemb, ulong @size) =>
    {
        av_reallocp_array = FunctionLoader.GetFunctionDelegate<av_reallocp_array_delegate>("avutil", "av_reallocp_array");
        if (av_reallocp_array == null)
        {
            av_reallocp_array = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_reallocp_array(@ptr, @nmemb, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_reduce_delegate(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
    public static av_reduce_delegate av_reduce = (int* @dst_num, int* @dst_den, long @num, long @den, long @max) =>
    {
        av_reduce = FunctionLoader.GetFunctionDelegate<av_reduce_delegate>("avutil", "av_reduce");
        if (av_reduce == null)
        {
            av_reduce = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_reduce(@dst_num, @dst_den, @num, @den, @max);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_rescale_delegate(long @a, long @b, long @c);
    public static av_rescale_delegate av_rescale = (long @a, long @b, long @c) =>
    {
        av_rescale = FunctionLoader.GetFunctionDelegate<av_rescale_delegate>("avutil", "av_rescale");
        if (av_rescale == null)
        {
            av_rescale = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_rescale(@a, @b, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_rescale_delta_delegate(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
    public static av_rescale_delta_delegate av_rescale_delta = (AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb) =>
    {
        av_rescale_delta = FunctionLoader.GetFunctionDelegate<av_rescale_delta_delegate>("avutil", "av_rescale_delta");
        if (av_rescale_delta == null)
        {
            av_rescale_delta = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_rescale_delta(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_rescale_q_delegate(long @a, AVRational @bq, AVRational @cq);
    public static av_rescale_q_delegate av_rescale_q = (long @a, AVRational @bq, AVRational @cq) =>
    {
        av_rescale_q = FunctionLoader.GetFunctionDelegate<av_rescale_q_delegate>("avutil", "av_rescale_q");
        if (av_rescale_q == null)
        {
            av_rescale_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_rescale_q(@a, @bq, @cq);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_rescale_q_rnd_delegate(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
    public static av_rescale_q_rnd_delegate av_rescale_q_rnd = (long @a, AVRational @bq, AVRational @cq, AVRounding @rnd) =>
    {
        av_rescale_q_rnd = FunctionLoader.GetFunctionDelegate<av_rescale_q_rnd_delegate>("avutil", "av_rescale_q_rnd");
        if (av_rescale_q_rnd == null)
        {
            av_rescale_q_rnd = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_rescale_q_rnd(@a, @bq, @cq, @rnd);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_rescale_rnd_delegate(long @a, long @b, long @c, AVRounding @rnd);
    public static av_rescale_rnd_delegate av_rescale_rnd = (long @a, long @b, long @c, AVRounding @rnd) =>
    {
        av_rescale_rnd = FunctionLoader.GetFunctionDelegate<av_rescale_rnd_delegate>("avutil", "av_rescale_rnd");
        if (av_rescale_rnd == null)
        {
            av_rescale_rnd = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_rescale_rnd(@a, @b, @c, @rnd);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_sample_fmt_is_planar_delegate(AVSampleFormat @sample_fmt);
    public static av_sample_fmt_is_planar_delegate av_sample_fmt_is_planar = (AVSampleFormat @sample_fmt) =>
    {
        av_sample_fmt_is_planar = FunctionLoader.GetFunctionDelegate<av_sample_fmt_is_planar_delegate>("avutil", "av_sample_fmt_is_planar");
        if (av_sample_fmt_is_planar == null)
        {
            av_sample_fmt_is_planar = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_sample_fmt_is_planar(@sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_alloc_delegate(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    public static av_samples_alloc_delegate av_samples_alloc = (byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
    {
        av_samples_alloc = FunctionLoader.GetFunctionDelegate<av_samples_alloc_delegate>("avutil", "av_samples_alloc");
        if (av_samples_alloc == null)
        {
            av_samples_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_alloc(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_alloc_array_and_samples_delegate(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    public static av_samples_alloc_array_and_samples_delegate av_samples_alloc_array_and_samples = (byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
    {
        av_samples_alloc_array_and_samples = FunctionLoader.GetFunctionDelegate<av_samples_alloc_array_and_samples_delegate>("avutil", "av_samples_alloc_array_and_samples");
        if (av_samples_alloc_array_and_samples == null)
        {
            av_samples_alloc_array_and_samples = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_alloc_array_and_samples(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_copy_delegate(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    public static av_samples_copy_delegate av_samples_copy = (byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
    {
        av_samples_copy = FunctionLoader.GetFunctionDelegate<av_samples_copy_delegate>("avutil", "av_samples_copy");
        if (av_samples_copy == null)
        {
            av_samples_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_copy(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_fill_arrays_delegate(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    public static av_samples_fill_arrays_delegate av_samples_fill_arrays = (byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
    {
        av_samples_fill_arrays = FunctionLoader.GetFunctionDelegate<av_samples_fill_arrays_delegate>("avutil", "av_samples_fill_arrays");
        if (av_samples_fill_arrays == null)
        {
            av_samples_fill_arrays = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_fill_arrays(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_get_buffer_size_delegate(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    public static av_samples_get_buffer_size_delegate av_samples_get_buffer_size = (int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
    {
        av_samples_get_buffer_size = FunctionLoader.GetFunctionDelegate<av_samples_get_buffer_size_delegate>("avutil", "av_samples_get_buffer_size");
        if (av_samples_get_buffer_size == null)
        {
            av_samples_get_buffer_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_get_buffer_size(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_samples_set_silence_delegate(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    public static av_samples_set_silence_delegate av_samples_set_silence = (byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
    {
        av_samples_set_silence = FunctionLoader.GetFunctionDelegate<av_samples_set_silence_delegate>("avutil", "av_samples_set_silence");
        if (av_samples_set_silence == null)
        {
            av_samples_set_silence = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_samples_set_silence(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_sdp_create_delegate(AVFormatContext** @ac, int @n_files, byte* @buf, int @size);
    public static av_sdp_create_delegate av_sdp_create = (AVFormatContext** @ac, int @n_files, byte* @buf, int @size) =>
    {
        av_sdp_create = FunctionLoader.GetFunctionDelegate<av_sdp_create_delegate>("avformat", "av_sdp_create");
        if (av_sdp_create == null)
        {
            av_sdp_create = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_sdp_create(@ac, @n_files, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_seek_frame_delegate(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
    public static av_seek_frame_delegate av_seek_frame = (AVFormatContext* @s, int @stream_index, long @timestamp, int @flags) =>
    {
        av_seek_frame = FunctionLoader.GetFunctionDelegate<av_seek_frame_delegate>("avformat", "av_seek_frame");
        if (av_seek_frame == null)
        {
            av_seek_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_seek_frame(@s, @stream_index, @timestamp, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_set_options_string_delegate(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep);
    public static av_set_options_string_delegate av_set_options_string = (void* @ctx, string @opts, string @key_val_sep, string @pairs_sep) =>
    {
        av_set_options_string = FunctionLoader.GetFunctionDelegate<av_set_options_string_delegate>("avutil", "av_set_options_string");
        if (av_set_options_string == null)
        {
            av_set_options_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_set_options_string(@ctx, @opts, @key_val_sep, @pairs_sep);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_shrink_packet_delegate(AVPacket* @pkt, int @size);
    public static av_shrink_packet_delegate av_shrink_packet = (AVPacket* @pkt, int @size) =>
    {
        av_shrink_packet = FunctionLoader.GetFunctionDelegate<av_shrink_packet_delegate>("avcodec", "av_shrink_packet");
        if (av_shrink_packet == null)
        {
            av_shrink_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_shrink_packet(@pkt, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_size_mult_delegate(ulong @a, ulong @b, ulong* @r);
    public static av_size_mult_delegate av_size_mult = (ulong @a, ulong @b, ulong* @r) =>
    {
        av_size_mult = FunctionLoader.GetFunctionDelegate<av_size_mult_delegate>("avutil", "av_size_mult");
        if (av_size_mult == null)
        {
            av_size_mult = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_size_mult(@a, @b, @r);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_strdup_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    public static av_strdup_delegate av_strdup = (string @s) =>
    {
        av_strdup = FunctionLoader.GetFunctionDelegate<av_strdup_delegate>("avutil", "av_strdup");
        if (av_strdup == null)
        {
            av_strdup = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_strdup(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_stream_add_side_data_delegate(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);
    public static av_stream_add_side_data_delegate av_stream_add_side_data = (AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size) =>
    {
        av_stream_add_side_data = FunctionLoader.GetFunctionDelegate<av_stream_add_side_data_delegate>("avformat", "av_stream_add_side_data");
        if (av_stream_add_side_data == null)
        {
            av_stream_add_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_add_side_data(@st, @type, @data, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* av_stream_get_class_delegate();
    public static av_stream_get_class_delegate av_stream_get_class = () =>
    {
        av_stream_get_class = FunctionLoader.GetFunctionDelegate<av_stream_get_class_delegate>("avformat", "av_stream_get_class");
        if (av_stream_get_class == null)
        {
            av_stream_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_stream_get_codec_timebase_delegate(AVStream* @st);
    public static av_stream_get_codec_timebase_delegate av_stream_get_codec_timebase = (AVStream* @st) =>
    {
        av_stream_get_codec_timebase = FunctionLoader.GetFunctionDelegate<av_stream_get_codec_timebase_delegate>("avformat", "av_stream_get_codec_timebase");
        if (av_stream_get_codec_timebase == null)
        {
            av_stream_get_codec_timebase = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_get_codec_timebase(@st);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long av_stream_get_end_pts_delegate(AVStream* @st);
    public static av_stream_get_end_pts_delegate av_stream_get_end_pts = (AVStream* @st) =>
    {
        av_stream_get_end_pts = FunctionLoader.GetFunctionDelegate<av_stream_get_end_pts_delegate>("avformat", "av_stream_get_end_pts");
        if (av_stream_get_end_pts == null)
        {
            av_stream_get_end_pts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_get_end_pts(@st);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecParserContext* av_stream_get_parser_delegate(AVStream* @s);
    public static av_stream_get_parser_delegate av_stream_get_parser = (AVStream* @s) =>
    {
        av_stream_get_parser = FunctionLoader.GetFunctionDelegate<av_stream_get_parser_delegate>("avformat", "av_stream_get_parser");
        if (av_stream_get_parser == null)
        {
            av_stream_get_parser = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_get_parser(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_stream_get_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong* @size);
    public static av_stream_get_side_data_delegate av_stream_get_side_data = (AVStream* @stream, AVPacketSideDataType @type, ulong* @size) =>
    {
        av_stream_get_side_data = FunctionLoader.GetFunctionDelegate<av_stream_get_side_data_delegate>("avformat", "av_stream_get_side_data");
        if (av_stream_get_side_data == null)
        {
            av_stream_get_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_get_side_data(@stream, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_stream_new_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong @size);
    public static av_stream_new_side_data_delegate av_stream_new_side_data = (AVStream* @stream, AVPacketSideDataType @type, ulong @size) =>
    {
        av_stream_new_side_data = FunctionLoader.GetFunctionDelegate<av_stream_new_side_data_delegate>("avformat", "av_stream_new_side_data");
        if (av_stream_new_side_data == null)
        {
            av_stream_new_side_data = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_stream_new_side_data(@stream, @type, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_strerror_delegate(int @errnum, byte* @errbuf, ulong @errbuf_size);
    public static av_strerror_delegate av_strerror = (int @errnum, byte* @errbuf, ulong @errbuf_size) =>
    {
        av_strerror = FunctionLoader.GetFunctionDelegate<av_strerror_delegate>("avutil", "av_strerror");
        if (av_strerror == null)
        {
            av_strerror = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_strerror(@errnum, @errbuf, @errbuf_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_strndup_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s, ulong @len);
    public static av_strndup_delegate av_strndup = (string @s, ulong @len) =>
    {
        av_strndup = FunctionLoader.GetFunctionDelegate<av_strndup_delegate>("avutil", "av_strndup");
        if (av_strndup == null)
        {
            av_strndup = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_strndup(@s, @len);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVRational av_sub_q_delegate(AVRational @b, AVRational @c);
    public static av_sub_q_delegate av_sub_q = (AVRational @b, AVRational @c) =>
    {
        av_sub_q = FunctionLoader.GetFunctionDelegate<av_sub_q_delegate>("avutil", "av_sub_q");
        if (av_sub_q == null)
        {
            av_sub_q = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_sub_q(@b, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_tempfile_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @prefix, byte** @filename, int @log_offset, void* @log_ctx);
    public static av_tempfile_delegate av_tempfile = (string @prefix, byte** @filename, int @log_offset, void* @log_ctx) =>
    {
        av_tempfile = FunctionLoader.GetFunctionDelegate<av_tempfile_delegate>("avutil", "av_tempfile");
        if (av_tempfile == null)
        {
            av_tempfile = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_tempfile(@prefix, @filename, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_timecode_adjust_ntsc_framenum2_delegate(int @framenum, int @fps);
    public static av_timecode_adjust_ntsc_framenum2_delegate av_timecode_adjust_ntsc_framenum2 = (int @framenum, int @fps) =>
    {
        av_timecode_adjust_ntsc_framenum2 = FunctionLoader.GetFunctionDelegate<av_timecode_adjust_ntsc_framenum2_delegate>("avutil", "av_timecode_adjust_ntsc_framenum2");
        if (av_timecode_adjust_ntsc_framenum2 == null)
        {
            av_timecode_adjust_ntsc_framenum2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_adjust_ntsc_framenum2(@framenum, @fps);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_timecode_check_frame_rate_delegate(AVRational @rate);
    public static av_timecode_check_frame_rate_delegate av_timecode_check_frame_rate = (AVRational @rate) =>
    {
        av_timecode_check_frame_rate = FunctionLoader.GetFunctionDelegate<av_timecode_check_frame_rate_delegate>("avutil", "av_timecode_check_frame_rate");
        if (av_timecode_check_frame_rate == null)
        {
            av_timecode_check_frame_rate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_check_frame_rate(@rate);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_timecode_get_smpte_delegate(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff);
    public static av_timecode_get_smpte_delegate av_timecode_get_smpte = (AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff) =>
    {
        av_timecode_get_smpte = FunctionLoader.GetFunctionDelegate<av_timecode_get_smpte_delegate>("avutil", "av_timecode_get_smpte");
        if (av_timecode_get_smpte == null)
        {
            av_timecode_get_smpte = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_get_smpte(@rate, @drop, @hh, @mm, @ss, @ff);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_timecode_get_smpte_from_framenum_delegate(AVTimecode* @tc, int @framenum);
    public static av_timecode_get_smpte_from_framenum_delegate av_timecode_get_smpte_from_framenum = (AVTimecode* @tc, int @framenum) =>
    {
        av_timecode_get_smpte_from_framenum = FunctionLoader.GetFunctionDelegate<av_timecode_get_smpte_from_framenum_delegate>("avutil", "av_timecode_get_smpte_from_framenum");
        if (av_timecode_get_smpte_from_framenum == null)
        {
            av_timecode_get_smpte_from_framenum = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_get_smpte_from_framenum(@tc, @framenum);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_timecode_init_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);
    public static av_timecode_init_delegate av_timecode_init = (AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx) =>
    {
        av_timecode_init = FunctionLoader.GetFunctionDelegate<av_timecode_init_delegate>("avutil", "av_timecode_init");
        if (av_timecode_init == null)
        {
            av_timecode_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_init(@tc, @rate, @flags, @frame_start, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_timecode_init_from_components_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx);
    public static av_timecode_init_from_components_delegate av_timecode_init_from_components = (AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx) =>
    {
        av_timecode_init_from_components = FunctionLoader.GetFunctionDelegate<av_timecode_init_from_components_delegate>("avutil", "av_timecode_init_from_components");
        if (av_timecode_init_from_components == null)
        {
            av_timecode_init_from_components = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_init_from_components(@tc, @rate, @flags, @hh, @mm, @ss, @ff, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_timecode_init_from_string_delegate(AVTimecode* @tc, AVRational @rate,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, void* @log_ctx);
    public static av_timecode_init_from_string_delegate av_timecode_init_from_string = (AVTimecode* @tc, AVRational @rate, string @str, void* @log_ctx) =>
    {
        av_timecode_init_from_string = FunctionLoader.GetFunctionDelegate<av_timecode_init_from_string_delegate>("avutil", "av_timecode_init_from_string");
        if (av_timecode_init_from_string == null)
        {
            av_timecode_init_from_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_init_from_string(@tc, @rate, @str, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_timecode_make_mpeg_tc_string_delegate(byte* @buf, uint @tc25bit);
    public static av_timecode_make_mpeg_tc_string_delegate av_timecode_make_mpeg_tc_string = (byte* @buf, uint @tc25bit) =>
    {
        av_timecode_make_mpeg_tc_string = FunctionLoader.GetFunctionDelegate<av_timecode_make_mpeg_tc_string_delegate>("avutil", "av_timecode_make_mpeg_tc_string");
        if (av_timecode_make_mpeg_tc_string == null)
        {
            av_timecode_make_mpeg_tc_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_make_mpeg_tc_string(@buf, @tc25bit);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_timecode_make_smpte_tc_string_delegate(byte* @buf, uint @tcsmpte, int @prevent_df);
    public static av_timecode_make_smpte_tc_string_delegate av_timecode_make_smpte_tc_string = (byte* @buf, uint @tcsmpte, int @prevent_df) =>
    {
        av_timecode_make_smpte_tc_string = FunctionLoader.GetFunctionDelegate<av_timecode_make_smpte_tc_string_delegate>("avutil", "av_timecode_make_smpte_tc_string");
        if (av_timecode_make_smpte_tc_string == null)
        {
            av_timecode_make_smpte_tc_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_make_smpte_tc_string(@buf, @tcsmpte, @prevent_df);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_timecode_make_smpte_tc_string2_delegate(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field);
    public static av_timecode_make_smpte_tc_string2_delegate av_timecode_make_smpte_tc_string2 = (byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field) =>
    {
        av_timecode_make_smpte_tc_string2 = FunctionLoader.GetFunctionDelegate<av_timecode_make_smpte_tc_string2_delegate>("avutil", "av_timecode_make_smpte_tc_string2");
        if (av_timecode_make_smpte_tc_string2 == null)
        {
            av_timecode_make_smpte_tc_string2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_make_smpte_tc_string2(@buf, @rate, @tcsmpte, @prevent_df, @skip_field);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* av_timecode_make_string_delegate(AVTimecode* @tc, byte* @buf, int @framenum);
    public static av_timecode_make_string_delegate av_timecode_make_string = (AVTimecode* @tc, byte* @buf, int @framenum) =>
    {
        av_timecode_make_string = FunctionLoader.GetFunctionDelegate<av_timecode_make_string_delegate>("avutil", "av_timecode_make_string");
        if (av_timecode_make_string == null)
        {
            av_timecode_make_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_timecode_make_string(@tc, @buf, @framenum);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_tree_destroy_delegate(AVTreeNode* @t);
    public static av_tree_destroy_delegate av_tree_destroy = (AVTreeNode* @t) =>
    {
        av_tree_destroy = FunctionLoader.GetFunctionDelegate<av_tree_destroy_delegate>("avutil", "av_tree_destroy");
        if (av_tree_destroy == null)
        {
            av_tree_destroy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_tree_destroy(@t);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_tree_enumerate_delegate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu);
    public static av_tree_enumerate_delegate av_tree_enumerate = (AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu) =>
    {
        av_tree_enumerate = FunctionLoader.GetFunctionDelegate<av_tree_enumerate_delegate>("avutil", "av_tree_enumerate");
        if (av_tree_enumerate == null)
        {
            av_tree_enumerate = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_tree_enumerate(@t, @opaque, @cmp, @enu);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_tree_find_delegate(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next);
    public static av_tree_find_delegate av_tree_find = (AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next) =>
    {
        av_tree_find = FunctionLoader.GetFunctionDelegate<av_tree_find_delegate>("avutil", "av_tree_find");
        if (av_tree_find == null)
        {
            av_tree_find = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_tree_find(@root, @key, @cmp, ref @next);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* av_tree_insert_delegate(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next);
    public static av_tree_insert_delegate av_tree_insert = (AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next) =>
    {
        av_tree_insert = FunctionLoader.GetFunctionDelegate<av_tree_insert_delegate>("avutil", "av_tree_insert");
        if (av_tree_insert == null)
        {
            av_tree_insert = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_tree_insert(@rootp, @key, @cmp, @next);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVTreeNode* av_tree_node_alloc_delegate();
    public static av_tree_node_alloc_delegate av_tree_node_alloc = () =>
    {
        av_tree_node_alloc = FunctionLoader.GetFunctionDelegate<av_tree_node_alloc_delegate>("avutil", "av_tree_node_alloc");
        if (av_tree_node_alloc == null)
        {
            av_tree_node_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_tree_node_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_url_split_delegate(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    public static av_url_split_delegate av_url_split = (byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, string @url) =>
    {
        av_url_split = FunctionLoader.GetFunctionDelegate<av_url_split_delegate>("avformat", "av_url_split");
        if (av_url_split == null)
        {
            av_url_split = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_url_split(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_usleep_delegate(uint @usec);
    public static av_usleep_delegate av_usleep = (uint @usec) =>
    {
        av_usleep = FunctionLoader.GetFunctionDelegate<av_usleep_delegate>("avutil", "av_usleep");
        if (av_usleep == null)
        {
            av_usleep = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_usleep(@usec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string av_version_info_delegate();
    public static av_version_info_delegate av_version_info = () =>
    {
        av_version_info = FunctionLoader.GetFunctionDelegate<av_version_info_delegate>("avutil", "av_version_info");
        if (av_version_info == null)
        {
            av_version_info = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_version_info();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_vlog_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    public static av_vlog_delegate av_vlog = (void* @avcl, int @level, string @fmt, byte* @vl) =>
    {
        av_vlog = FunctionLoader.GetFunctionDelegate<av_vlog_delegate>("avutil", "av_vlog");
        if (av_vlog == null)
        {
            av_vlog = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_vlog(@avcl, @level, @fmt, @vl);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    public static av_write_frame_delegate av_write_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
    {
        av_write_frame = FunctionLoader.GetFunctionDelegate<av_write_frame_delegate>("avformat", "av_write_frame");
        if (av_write_frame == null)
        {
            av_write_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_write_frame(@s, @pkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_write_image_line_delegate(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
    public static av_write_image_line_delegate av_write_image_line = (ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w) =>
    {
        av_write_image_line = FunctionLoader.GetFunctionDelegate<av_write_image_line_delegate>("avutil", "av_write_image_line");
        if (av_write_image_line == null)
        {
            av_write_image_line = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_write_image_line(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void av_write_image_line2_delegate(void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size);
    public static av_write_image_line2_delegate av_write_image_line2 = (void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size) =>
    {
        av_write_image_line2 = FunctionLoader.GetFunctionDelegate<av_write_image_line2_delegate>("avutil", "av_write_image_line2");
        if (av_write_image_line2 == null)
        {
            av_write_image_line2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        av_write_image_line2(@src, ref @data, @linesize, @desc, @x, @y, @c, @w, @src_element_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_write_trailer_delegate(AVFormatContext* @s);
    public static av_write_trailer_delegate av_write_trailer = (AVFormatContext* @s) =>
    {
        av_write_trailer = FunctionLoader.GetFunctionDelegate<av_write_trailer_delegate>("avformat", "av_write_trailer");
        if (av_write_trailer == null)
        {
            av_write_trailer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_write_trailer(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    public static av_write_uncoded_frame_delegate av_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
    {
        av_write_uncoded_frame = FunctionLoader.GetFunctionDelegate<av_write_uncoded_frame_delegate>("avformat", "av_write_uncoded_frame");
        if (av_write_uncoded_frame == null)
        {
            av_write_uncoded_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_write_uncoded_frame(@s, @stream_index, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int av_write_uncoded_frame_query_delegate(AVFormatContext* @s, int @stream_index);
    public static av_write_uncoded_frame_query_delegate av_write_uncoded_frame_query = (AVFormatContext* @s, int @stream_index) =>
    {
        av_write_uncoded_frame_query = FunctionLoader.GetFunctionDelegate<av_write_uncoded_frame_query_delegate>("avformat", "av_write_uncoded_frame_query");
        if (av_write_uncoded_frame_query == null)
        {
            av_write_uncoded_frame_query = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_write_uncoded_frame_query(@s, @stream_index);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint av_xiphlacing_delegate(byte* @s, uint @v);
    public static av_xiphlacing_delegate av_xiphlacing = (byte* @s, uint @v) =>
    {
        av_xiphlacing = FunctionLoader.GetFunctionDelegate<av_xiphlacing_delegate>("avcodec", "av_xiphlacing");
        if (av_xiphlacing == null)
        {
            av_xiphlacing = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return av_xiphlacing(@s, @v);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_align_dimensions_delegate(AVCodecContext* @s, int* @width, int* @height);
    public static avcodec_align_dimensions_delegate avcodec_align_dimensions = (AVCodecContext* @s, int* @width, int* @height) =>
    {
        avcodec_align_dimensions = FunctionLoader.GetFunctionDelegate<avcodec_align_dimensions_delegate>("avcodec", "avcodec_align_dimensions");
        if (avcodec_align_dimensions == null)
        {
            avcodec_align_dimensions = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_align_dimensions(@s, @width, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_align_dimensions2_delegate(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align);
    public static avcodec_align_dimensions2_delegate avcodec_align_dimensions2 = (AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align) =>
    {
        avcodec_align_dimensions2 = FunctionLoader.GetFunctionDelegate<avcodec_align_dimensions2_delegate>("avcodec", "avcodec_align_dimensions2");
        if (avcodec_align_dimensions2 == null)
        {
            avcodec_align_dimensions2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_align_dimensions2(@s, @width, @height, ref @linesize_align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecContext* avcodec_alloc_context3_delegate(AVCodec* @codec);
    public static avcodec_alloc_context3_delegate avcodec_alloc_context3 = (AVCodec* @codec) =>
    {
        avcodec_alloc_context3 = FunctionLoader.GetFunctionDelegate<avcodec_alloc_context3_delegate>("avcodec", "avcodec_alloc_context3");
        if (avcodec_alloc_context3 == null)
        {
            avcodec_alloc_context3 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_alloc_context3(@codec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVChromaLocation avcodec_chroma_pos_to_enum_delegate(int @xpos, int @ypos);
    public static avcodec_chroma_pos_to_enum_delegate avcodec_chroma_pos_to_enum = (int @xpos, int @ypos) =>
    {
        avcodec_chroma_pos_to_enum = FunctionLoader.GetFunctionDelegate<avcodec_chroma_pos_to_enum_delegate>("avcodec", "avcodec_chroma_pos_to_enum");
        if (avcodec_chroma_pos_to_enum == null)
        {
            avcodec_chroma_pos_to_enum = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_chroma_pos_to_enum(@xpos, @ypos);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_close_delegate(AVCodecContext* @avctx);
    public static avcodec_close_delegate avcodec_close = (AVCodecContext* @avctx) =>
    {
        avcodec_close = FunctionLoader.GetFunctionDelegate<avcodec_close_delegate>("avcodec", "avcodec_close");
        if (avcodec_close == null)
        {
            avcodec_close = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_close(@avctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avcodec_configuration_delegate();
    public static avcodec_configuration_delegate avcodec_configuration = () =>
    {
        avcodec_configuration = FunctionLoader.GetFunctionDelegate<avcodec_configuration_delegate>("avcodec", "avcodec_configuration");
        if (avcodec_configuration == null)
        {
            avcodec_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_decode_subtitle2_delegate(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
    public static avcodec_decode_subtitle2_delegate avcodec_decode_subtitle2 = (AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt) =>
    {
        avcodec_decode_subtitle2 = FunctionLoader.GetFunctionDelegate<avcodec_decode_subtitle2_delegate>("avcodec", "avcodec_decode_subtitle2");
        if (avcodec_decode_subtitle2 == null)
        {
            avcodec_decode_subtitle2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_decode_subtitle2(@avctx, @sub, @got_sub_ptr, @avpkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_default_execute_delegate(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);
    public static avcodec_default_execute_delegate avcodec_default_execute = (AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size) =>
    {
        avcodec_default_execute = FunctionLoader.GetFunctionDelegate<avcodec_default_execute_delegate>("avcodec", "avcodec_default_execute");
        if (avcodec_default_execute == null)
        {
            avcodec_default_execute = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_default_execute(@c, @func, @arg, @ret, @count, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_default_execute2_delegate(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);
    public static avcodec_default_execute2_delegate avcodec_default_execute2 = (AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count) =>
    {
        avcodec_default_execute2 = FunctionLoader.GetFunctionDelegate<avcodec_default_execute2_delegate>("avcodec", "avcodec_default_execute2");
        if (avcodec_default_execute2 == null)
        {
            avcodec_default_execute2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_default_execute2(@c, @func, @arg, @ret, @count);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_default_get_buffer2_delegate(AVCodecContext* @s, AVFrame* @frame, int @flags);
    public static avcodec_default_get_buffer2_delegate avcodec_default_get_buffer2 = (AVCodecContext* @s, AVFrame* @frame, int @flags) =>
    {
        avcodec_default_get_buffer2 = FunctionLoader.GetFunctionDelegate<avcodec_default_get_buffer2_delegate>("avcodec", "avcodec_default_get_buffer2");
        if (avcodec_default_get_buffer2 == null)
        {
            avcodec_default_get_buffer2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_default_get_buffer2(@s, @frame, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_default_get_encode_buffer_delegate(AVCodecContext* @s, AVPacket* @pkt, int @flags);
    public static avcodec_default_get_encode_buffer_delegate avcodec_default_get_encode_buffer = (AVCodecContext* @s, AVPacket* @pkt, int @flags) =>
    {
        avcodec_default_get_encode_buffer = FunctionLoader.GetFunctionDelegate<avcodec_default_get_encode_buffer_delegate>("avcodec", "avcodec_default_get_encode_buffer");
        if (avcodec_default_get_encode_buffer == null)
        {
            avcodec_default_get_encode_buffer = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_default_get_encode_buffer(@s, @pkt, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat avcodec_default_get_format_delegate(AVCodecContext* @s, AVPixelFormat* @fmt);
    public static avcodec_default_get_format_delegate avcodec_default_get_format = (AVCodecContext* @s, AVPixelFormat* @fmt) =>
    {
        avcodec_default_get_format = FunctionLoader.GetFunctionDelegate<avcodec_default_get_format_delegate>("avcodec", "avcodec_default_get_format");
        if (avcodec_default_get_format == null)
        {
            avcodec_default_get_format = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_default_get_format(@s, @fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecDescriptor* avcodec_descriptor_get_delegate(AVCodecID @id);
    public static avcodec_descriptor_get_delegate avcodec_descriptor_get = (AVCodecID @id) =>
    {
        avcodec_descriptor_get = FunctionLoader.GetFunctionDelegate<avcodec_descriptor_get_delegate>("avcodec", "avcodec_descriptor_get");
        if (avcodec_descriptor_get == null)
        {
            avcodec_descriptor_get = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_descriptor_get(@id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecDescriptor* avcodec_descriptor_get_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avcodec_descriptor_get_by_name_delegate avcodec_descriptor_get_by_name = (string @name) =>
    {
        avcodec_descriptor_get_by_name = FunctionLoader.GetFunctionDelegate<avcodec_descriptor_get_by_name_delegate>("avcodec", "avcodec_descriptor_get_by_name");
        if (avcodec_descriptor_get_by_name == null)
        {
            avcodec_descriptor_get_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_descriptor_get_by_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecDescriptor* avcodec_descriptor_next_delegate(AVCodecDescriptor* @prev);
    public static avcodec_descriptor_next_delegate avcodec_descriptor_next = (AVCodecDescriptor* @prev) =>
    {
        avcodec_descriptor_next = FunctionLoader.GetFunctionDelegate<avcodec_descriptor_next_delegate>("avcodec", "avcodec_descriptor_next");
        if (avcodec_descriptor_next == null)
        {
            avcodec_descriptor_next = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_descriptor_next(@prev);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_encode_subtitle_delegate(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
    public static avcodec_encode_subtitle_delegate avcodec_encode_subtitle = (AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub) =>
    {
        avcodec_encode_subtitle = FunctionLoader.GetFunctionDelegate<avcodec_encode_subtitle_delegate>("avcodec", "avcodec_encode_subtitle");
        if (avcodec_encode_subtitle == null)
        {
            avcodec_encode_subtitle = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_encode_subtitle(@avctx, @buf, @buf_size, @sub);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_enum_to_chroma_pos_delegate(int* @xpos, int* @ypos, AVChromaLocation @pos);
    public static avcodec_enum_to_chroma_pos_delegate avcodec_enum_to_chroma_pos = (int* @xpos, int* @ypos, AVChromaLocation @pos) =>
    {
        avcodec_enum_to_chroma_pos = FunctionLoader.GetFunctionDelegate<avcodec_enum_to_chroma_pos_delegate>("avcodec", "avcodec_enum_to_chroma_pos");
        if (avcodec_enum_to_chroma_pos == null)
        {
            avcodec_enum_to_chroma_pos = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_enum_to_chroma_pos(@xpos, @ypos, @pos);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_fill_audio_frame_delegate(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
    public static avcodec_fill_audio_frame_delegate avcodec_fill_audio_frame = (AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align) =>
    {
        avcodec_fill_audio_frame = FunctionLoader.GetFunctionDelegate<avcodec_fill_audio_frame_delegate>("avcodec", "avcodec_fill_audio_frame");
        if (avcodec_fill_audio_frame == null)
        {
            avcodec_fill_audio_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_fill_audio_frame(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVPixelFormat avcodec_find_best_pix_fmt_of_list_delegate(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    public static avcodec_find_best_pix_fmt_of_list_delegate avcodec_find_best_pix_fmt_of_list = (AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
    {
        avcodec_find_best_pix_fmt_of_list = FunctionLoader.GetFunctionDelegate<avcodec_find_best_pix_fmt_of_list_delegate>("avcodec", "avcodec_find_best_pix_fmt_of_list");
        if (avcodec_find_best_pix_fmt_of_list == null)
        {
            avcodec_find_best_pix_fmt_of_list = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_find_best_pix_fmt_of_list(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodec* avcodec_find_decoder_delegate(AVCodecID @id);
    public static avcodec_find_decoder_delegate avcodec_find_decoder = (AVCodecID @id) =>
    {
        avcodec_find_decoder = FunctionLoader.GetFunctionDelegate<avcodec_find_decoder_delegate>("avcodec", "avcodec_find_decoder");
        if (avcodec_find_decoder == null)
        {
            avcodec_find_decoder = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_find_decoder(@id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodec* avcodec_find_decoder_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avcodec_find_decoder_by_name_delegate avcodec_find_decoder_by_name = (string @name) =>
    {
        avcodec_find_decoder_by_name = FunctionLoader.GetFunctionDelegate<avcodec_find_decoder_by_name_delegate>("avcodec", "avcodec_find_decoder_by_name");
        if (avcodec_find_decoder_by_name == null)
        {
            avcodec_find_decoder_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_find_decoder_by_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodec* avcodec_find_encoder_delegate(AVCodecID @id);
    public static avcodec_find_encoder_delegate avcodec_find_encoder = (AVCodecID @id) =>
    {
        avcodec_find_encoder = FunctionLoader.GetFunctionDelegate<avcodec_find_encoder_delegate>("avcodec", "avcodec_find_encoder");
        if (avcodec_find_encoder == null)
        {
            avcodec_find_encoder = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_find_encoder(@id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodec* avcodec_find_encoder_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avcodec_find_encoder_by_name_delegate avcodec_find_encoder_by_name = (string @name) =>
    {
        avcodec_find_encoder_by_name = FunctionLoader.GetFunctionDelegate<avcodec_find_encoder_by_name_delegate>("avcodec", "avcodec_find_encoder_by_name");
        if (avcodec_find_encoder_by_name == null)
        {
            avcodec_find_encoder_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_find_encoder_by_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_flush_buffers_delegate(AVCodecContext* @avctx);
    public static avcodec_flush_buffers_delegate avcodec_flush_buffers = (AVCodecContext* @avctx) =>
    {
        avcodec_flush_buffers = FunctionLoader.GetFunctionDelegate<avcodec_flush_buffers_delegate>("avcodec", "avcodec_flush_buffers");
        if (avcodec_flush_buffers == null)
        {
            avcodec_flush_buffers = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_flush_buffers(@avctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_free_context_delegate(AVCodecContext** @avctx);
    public static avcodec_free_context_delegate avcodec_free_context = (AVCodecContext** @avctx) =>
    {
        avcodec_free_context = FunctionLoader.GetFunctionDelegate<avcodec_free_context_delegate>("avcodec", "avcodec_free_context");
        if (avcodec_free_context == null)
        {
            avcodec_free_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_free_context(@avctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avcodec_get_class_delegate();
    public static avcodec_get_class_delegate avcodec_get_class = () =>
    {
        avcodec_get_class = FunctionLoader.GetFunctionDelegate<avcodec_get_class_delegate>("avcodec", "avcodec_get_class");
        if (avcodec_get_class == null)
        {
            avcodec_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avcodec_get_frame_class_delegate();
    public static avcodec_get_frame_class_delegate avcodec_get_frame_class = () =>
    {
        avcodec_get_frame_class = FunctionLoader.GetFunctionDelegate<avcodec_get_frame_class_delegate>("avcodec", "avcodec_get_frame_class");
        if (avcodec_get_frame_class == null)
        {
            avcodec_get_frame_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_frame_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecHWConfig* avcodec_get_hw_config_delegate(AVCodec* @codec, int @index);
    public static avcodec_get_hw_config_delegate avcodec_get_hw_config = (AVCodec* @codec, int @index) =>
    {
        avcodec_get_hw_config = FunctionLoader.GetFunctionDelegate<avcodec_get_hw_config_delegate>("avcodec", "avcodec_get_hw_config");
        if (avcodec_get_hw_config == null)
        {
            avcodec_get_hw_config = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_hw_config(@codec, @index);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_get_hw_frames_parameters_delegate(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref);
    public static avcodec_get_hw_frames_parameters_delegate avcodec_get_hw_frames_parameters = (AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref) =>
    {
        avcodec_get_hw_frames_parameters = FunctionLoader.GetFunctionDelegate<avcodec_get_hw_frames_parameters_delegate>("avcodec", "avcodec_get_hw_frames_parameters");
        if (avcodec_get_hw_frames_parameters == null)
        {
            avcodec_get_hw_frames_parameters = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_hw_frames_parameters(@avctx, @device_ref, @hw_pix_fmt, @out_frames_ref);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avcodec_get_name_delegate(AVCodecID @id);
    public static avcodec_get_name_delegate avcodec_get_name = (AVCodecID @id) =>
    {
        avcodec_get_name = FunctionLoader.GetFunctionDelegate<avcodec_get_name_delegate>("avcodec", "avcodec_get_name");
        if (avcodec_get_name == null)
        {
            avcodec_get_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_name(@id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avcodec_get_subtitle_rect_class_delegate();
    public static avcodec_get_subtitle_rect_class_delegate avcodec_get_subtitle_rect_class = () =>
    {
        avcodec_get_subtitle_rect_class = FunctionLoader.GetFunctionDelegate<avcodec_get_subtitle_rect_class_delegate>("avcodec", "avcodec_get_subtitle_rect_class");
        if (avcodec_get_subtitle_rect_class == null)
        {
            avcodec_get_subtitle_rect_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_subtitle_rect_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVMediaType avcodec_get_type_delegate(AVCodecID @codec_id);
    public static avcodec_get_type_delegate avcodec_get_type = (AVCodecID @codec_id) =>
    {
        avcodec_get_type = FunctionLoader.GetFunctionDelegate<avcodec_get_type_delegate>("avcodec", "avcodec_get_type");
        if (avcodec_get_type == null)
        {
            avcodec_get_type = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_get_type(@codec_id);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_is_open_delegate(AVCodecContext* @s);
    public static avcodec_is_open_delegate avcodec_is_open = (AVCodecContext* @s) =>
    {
        avcodec_is_open = FunctionLoader.GetFunctionDelegate<avcodec_is_open_delegate>("avcodec", "avcodec_is_open");
        if (avcodec_is_open == null)
        {
            avcodec_is_open = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_is_open(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avcodec_license_delegate();
    public static avcodec_license_delegate avcodec_license = () =>
    {
        avcodec_license = FunctionLoader.GetFunctionDelegate<avcodec_license_delegate>("avcodec", "avcodec_license");
        if (avcodec_license == null)
        {
            avcodec_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_open2_delegate(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
    public static avcodec_open2_delegate avcodec_open2 = (AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options) =>
    {
        avcodec_open2 = FunctionLoader.GetFunctionDelegate<avcodec_open2_delegate>("avcodec", "avcodec_open2");
        if (avcodec_open2 == null)
        {
            avcodec_open2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_open2(@avctx, @codec, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecParameters* avcodec_parameters_alloc_delegate();
    public static avcodec_parameters_alloc_delegate avcodec_parameters_alloc = () =>
    {
        avcodec_parameters_alloc = FunctionLoader.GetFunctionDelegate<avcodec_parameters_alloc_delegate>("avcodec", "avcodec_parameters_alloc");
        if (avcodec_parameters_alloc == null)
        {
            avcodec_parameters_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_parameters_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_parameters_copy_delegate(AVCodecParameters* @dst, AVCodecParameters* @src);
    public static avcodec_parameters_copy_delegate avcodec_parameters_copy = (AVCodecParameters* @dst, AVCodecParameters* @src) =>
    {
        avcodec_parameters_copy = FunctionLoader.GetFunctionDelegate<avcodec_parameters_copy_delegate>("avcodec", "avcodec_parameters_copy");
        if (avcodec_parameters_copy == null)
        {
            avcodec_parameters_copy = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_parameters_copy(@dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_parameters_free_delegate(AVCodecParameters** @par);
    public static avcodec_parameters_free_delegate avcodec_parameters_free = (AVCodecParameters** @par) =>
    {
        avcodec_parameters_free = FunctionLoader.GetFunctionDelegate<avcodec_parameters_free_delegate>("avcodec", "avcodec_parameters_free");
        if (avcodec_parameters_free == null)
        {
            avcodec_parameters_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_parameters_free(@par);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_parameters_from_context_delegate(AVCodecParameters* @par, AVCodecContext* @codec);
    public static avcodec_parameters_from_context_delegate avcodec_parameters_from_context = (AVCodecParameters* @par, AVCodecContext* @codec) =>
    {
        avcodec_parameters_from_context = FunctionLoader.GetFunctionDelegate<avcodec_parameters_from_context_delegate>("avcodec", "avcodec_parameters_from_context");
        if (avcodec_parameters_from_context == null)
        {
            avcodec_parameters_from_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_parameters_from_context(@par, @codec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_parameters_to_context_delegate(AVCodecContext* @codec, AVCodecParameters* @par);
    public static avcodec_parameters_to_context_delegate avcodec_parameters_to_context = (AVCodecContext* @codec, AVCodecParameters* @par) =>
    {
        avcodec_parameters_to_context = FunctionLoader.GetFunctionDelegate<avcodec_parameters_to_context_delegate>("avcodec", "avcodec_parameters_to_context");
        if (avcodec_parameters_to_context == null)
        {
            avcodec_parameters_to_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_parameters_to_context(@codec, @par);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avcodec_pix_fmt_to_codec_tag_delegate(AVPixelFormat @pix_fmt);
    public static avcodec_pix_fmt_to_codec_tag_delegate avcodec_pix_fmt_to_codec_tag = (AVPixelFormat @pix_fmt) =>
    {
        avcodec_pix_fmt_to_codec_tag = FunctionLoader.GetFunctionDelegate<avcodec_pix_fmt_to_codec_tag_delegate>("avcodec", "avcodec_pix_fmt_to_codec_tag");
        if (avcodec_pix_fmt_to_codec_tag == null)
        {
            avcodec_pix_fmt_to_codec_tag = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_pix_fmt_to_codec_tag(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avcodec_profile_name_delegate(AVCodecID @codec_id, int @profile);
    public static avcodec_profile_name_delegate avcodec_profile_name = (AVCodecID @codec_id, int @profile) =>
    {
        avcodec_profile_name = FunctionLoader.GetFunctionDelegate<avcodec_profile_name_delegate>("avcodec", "avcodec_profile_name");
        if (avcodec_profile_name == null)
        {
            avcodec_profile_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_profile_name(@codec_id, @profile);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_receive_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
    public static avcodec_receive_frame_delegate avcodec_receive_frame = (AVCodecContext* @avctx, AVFrame* @frame) =>
    {
        avcodec_receive_frame = FunctionLoader.GetFunctionDelegate<avcodec_receive_frame_delegate>("avcodec", "avcodec_receive_frame");
        if (avcodec_receive_frame == null)
        {
            avcodec_receive_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_receive_frame(@avctx, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_receive_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
    public static avcodec_receive_packet_delegate avcodec_receive_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
    {
        avcodec_receive_packet = FunctionLoader.GetFunctionDelegate<avcodec_receive_packet_delegate>("avcodec", "avcodec_receive_packet");
        if (avcodec_receive_packet == null)
        {
            avcodec_receive_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_receive_packet(@avctx, @avpkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_send_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
    public static avcodec_send_frame_delegate avcodec_send_frame = (AVCodecContext* @avctx, AVFrame* @frame) =>
    {
        avcodec_send_frame = FunctionLoader.GetFunctionDelegate<avcodec_send_frame_delegate>("avcodec", "avcodec_send_frame");
        if (avcodec_send_frame == null)
        {
            avcodec_send_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_send_frame(@avctx, @frame);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avcodec_send_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
    public static avcodec_send_packet_delegate avcodec_send_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
    {
        avcodec_send_packet = FunctionLoader.GetFunctionDelegate<avcodec_send_packet_delegate>("avcodec", "avcodec_send_packet");
        if (avcodec_send_packet == null)
        {
            avcodec_send_packet = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_send_packet(@avctx, @avpkt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avcodec_string_delegate(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
    public static avcodec_string_delegate avcodec_string = (byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode) =>
    {
        avcodec_string = FunctionLoader.GetFunctionDelegate<avcodec_string_delegate>("avcodec", "avcodec_string");
        if (avcodec_string == null)
        {
            avcodec_string = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avcodec_string(@buf, @buf_size, @enc, @encode);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avcodec_version_delegate();
    public static avcodec_version_delegate avcodec_version = () =>
    {
        avcodec_version = FunctionLoader.GetFunctionDelegate<avcodec_version_delegate>("avcodec", "avcodec_version");
        if (avcodec_version == null)
        {
            avcodec_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avcodec_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_app_to_dev_control_message_delegate(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
    public static avdevice_app_to_dev_control_message_delegate avdevice_app_to_dev_control_message = (AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size) =>
    {
        avdevice_app_to_dev_control_message = FunctionLoader.GetFunctionDelegate<avdevice_app_to_dev_control_message_delegate>("avdevice", "avdevice_app_to_dev_control_message");
        if (avdevice_app_to_dev_control_message == null)
        {
            avdevice_app_to_dev_control_message = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_app_to_dev_control_message(@s, @type, @data, @data_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_capabilities_create_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);
    public static avdevice_capabilities_create_delegate avdevice_capabilities_create = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options) =>
    {
        avdevice_capabilities_create = FunctionLoader.GetFunctionDelegate<avdevice_capabilities_create_delegate>("avdevice", "avdevice_capabilities_create");
        if (avdevice_capabilities_create == null)
        {
            avdevice_capabilities_create = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_capabilities_create(@caps, @s, @device_options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avdevice_capabilities_free_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);
    public static avdevice_capabilities_free_delegate avdevice_capabilities_free = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s) =>
    {
        avdevice_capabilities_free = FunctionLoader.GetFunctionDelegate<avdevice_capabilities_free_delegate>("avdevice", "avdevice_capabilities_free");
        if (avdevice_capabilities_free == null)
        {
            avdevice_capabilities_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avdevice_capabilities_free(@caps, @s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avdevice_configuration_delegate();
    public static avdevice_configuration_delegate avdevice_configuration = () =>
    {
        avdevice_configuration = FunctionLoader.GetFunctionDelegate<avdevice_configuration_delegate>("avdevice", "avdevice_configuration");
        if (avdevice_configuration == null)
        {
            avdevice_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_dev_to_app_control_message_delegate(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
    public static avdevice_dev_to_app_control_message_delegate avdevice_dev_to_app_control_message = (AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size) =>
    {
        avdevice_dev_to_app_control_message = FunctionLoader.GetFunctionDelegate<avdevice_dev_to_app_control_message_delegate>("avdevice", "avdevice_dev_to_app_control_message");
        if (avdevice_dev_to_app_control_message == null)
        {
            avdevice_dev_to_app_control_message = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_dev_to_app_control_message(@s, @type, @data, @data_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avdevice_free_list_devices_delegate(AVDeviceInfoList** @device_list);
    public static avdevice_free_list_devices_delegate avdevice_free_list_devices = (AVDeviceInfoList** @device_list) =>
    {
        avdevice_free_list_devices = FunctionLoader.GetFunctionDelegate<avdevice_free_list_devices_delegate>("avdevice", "avdevice_free_list_devices");
        if (avdevice_free_list_devices == null)
        {
            avdevice_free_list_devices = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avdevice_free_list_devices(@device_list);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avdevice_license_delegate();
    public static avdevice_license_delegate avdevice_license = () =>
    {
        avdevice_license = FunctionLoader.GetFunctionDelegate<avdevice_license_delegate>("avdevice", "avdevice_license");
        if (avdevice_license == null)
        {
            avdevice_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_list_devices_delegate(AVFormatContext* @s, AVDeviceInfoList** @device_list);
    public static avdevice_list_devices_delegate avdevice_list_devices = (AVFormatContext* @s, AVDeviceInfoList** @device_list) =>
    {
        avdevice_list_devices = FunctionLoader.GetFunctionDelegate<avdevice_list_devices_delegate>("avdevice", "avdevice_list_devices");
        if (avdevice_list_devices == null)
        {
            avdevice_list_devices = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_list_devices(@s, @device_list);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_list_input_sources_delegate(AVInputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    public static avdevice_list_input_sources_delegate avdevice_list_input_sources = (AVInputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
    {
        avdevice_list_input_sources = FunctionLoader.GetFunctionDelegate<avdevice_list_input_sources_delegate>("avdevice", "avdevice_list_input_sources");
        if (avdevice_list_input_sources == null)
        {
            avdevice_list_input_sources = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_list_input_sources(@device, @device_name, @device_options, @device_list);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avdevice_list_output_sinks_delegate(AVOutputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    public static avdevice_list_output_sinks_delegate avdevice_list_output_sinks = (AVOutputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
    {
        avdevice_list_output_sinks = FunctionLoader.GetFunctionDelegate<avdevice_list_output_sinks_delegate>("avdevice", "avdevice_list_output_sinks");
        if (avdevice_list_output_sinks == null)
        {
            avdevice_list_output_sinks = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_list_output_sinks(@device, @device_name, @device_options, @device_list);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avdevice_register_all_delegate();
    public static avdevice_register_all_delegate avdevice_register_all = () =>
    {
        avdevice_register_all = FunctionLoader.GetFunctionDelegate<avdevice_register_all_delegate>("avdevice", "avdevice_register_all");
        if (avdevice_register_all == null)
        {
            avdevice_register_all = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avdevice_register_all();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avdevice_version_delegate();
    public static avdevice_version_delegate avdevice_version = () =>
    {
        avdevice_version = FunctionLoader.GetFunctionDelegate<avdevice_version_delegate>("avdevice", "avdevice_version");
        if (avdevice_version == null)
        {
            avdevice_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avdevice_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_config_links_delegate(AVFilterContext* @filter);
    public static avfilter_config_links_delegate avfilter_config_links = (AVFilterContext* @filter) =>
    {
        avfilter_config_links = FunctionLoader.GetFunctionDelegate<avfilter_config_links_delegate>("avfilter", "avfilter_config_links");
        if (avfilter_config_links == null)
        {
            avfilter_config_links = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_config_links(@filter);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avfilter_configuration_delegate();
    public static avfilter_configuration_delegate avfilter_configuration = () =>
    {
        avfilter_configuration = FunctionLoader.GetFunctionDelegate<avfilter_configuration_delegate>("avfilter", "avfilter_configuration");
        if (avfilter_configuration == null)
        {
            avfilter_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avfilter_filter_pad_count_delegate(AVFilter* @filter, int @is_output);
    public static avfilter_filter_pad_count_delegate avfilter_filter_pad_count = (AVFilter* @filter, int @is_output) =>
    {
        avfilter_filter_pad_count = FunctionLoader.GetFunctionDelegate<avfilter_filter_pad_count_delegate>("avfilter", "avfilter_filter_pad_count");
        if (avfilter_filter_pad_count == null)
        {
            avfilter_filter_pad_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_filter_pad_count(@filter, @is_output);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avfilter_free_delegate(AVFilterContext* @filter);
    public static avfilter_free_delegate avfilter_free = (AVFilterContext* @filter) =>
    {
        avfilter_free = FunctionLoader.GetFunctionDelegate<avfilter_free_delegate>("avfilter", "avfilter_free");
        if (avfilter_free == null)
        {
            avfilter_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avfilter_free(@filter);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilter* avfilter_get_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avfilter_get_by_name_delegate avfilter_get_by_name = (string @name) =>
    {
        avfilter_get_by_name = FunctionLoader.GetFunctionDelegate<avfilter_get_by_name_delegate>("avfilter", "avfilter_get_by_name");
        if (avfilter_get_by_name == null)
        {
            avfilter_get_by_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_get_by_name(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avfilter_get_class_delegate();
    public static avfilter_get_class_delegate avfilter_get_class = () =>
    {
        avfilter_get_class = FunctionLoader.GetFunctionDelegate<avfilter_get_class_delegate>("avfilter", "avfilter_get_class");
        if (avfilter_get_class == null)
        {
            avfilter_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilterGraph* avfilter_graph_alloc_delegate();
    public static avfilter_graph_alloc_delegate avfilter_graph_alloc = () =>
    {
        avfilter_graph_alloc = FunctionLoader.GetFunctionDelegate<avfilter_graph_alloc_delegate>("avfilter", "avfilter_graph_alloc");
        if (avfilter_graph_alloc == null)
        {
            avfilter_graph_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilterContext* avfilter_graph_alloc_filter_delegate(AVFilterGraph* @graph, AVFilter* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avfilter_graph_alloc_filter_delegate avfilter_graph_alloc_filter = (AVFilterGraph* @graph, AVFilter* @filter, string @name) =>
    {
        avfilter_graph_alloc_filter = FunctionLoader.GetFunctionDelegate<avfilter_graph_alloc_filter_delegate>("avfilter", "avfilter_graph_alloc_filter");
        if (avfilter_graph_alloc_filter == null)
        {
            avfilter_graph_alloc_filter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_alloc_filter(@graph, @filter, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_config_delegate(AVFilterGraph* @graphctx, void* @log_ctx);
    public static avfilter_graph_config_delegate avfilter_graph_config = (AVFilterGraph* @graphctx, void* @log_ctx) =>
    {
        avfilter_graph_config = FunctionLoader.GetFunctionDelegate<avfilter_graph_config_delegate>("avfilter", "avfilter_graph_config");
        if (avfilter_graph_config == null)
        {
            avfilter_graph_config = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_config(@graphctx, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_create_filter_delegate(AVFilterContext** @filt_ctx, AVFilter* @filt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args, void* @opaque, AVFilterGraph* @graph_ctx);
    public static avfilter_graph_create_filter_delegate avfilter_graph_create_filter = (AVFilterContext** @filt_ctx, AVFilter* @filt, string @name, string @args, void* @opaque, AVFilterGraph* @graph_ctx) =>
    {
        avfilter_graph_create_filter = FunctionLoader.GetFunctionDelegate<avfilter_graph_create_filter_delegate>("avfilter", "avfilter_graph_create_filter");
        if (avfilter_graph_create_filter == null)
        {
            avfilter_graph_create_filter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_create_filter(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate byte* avfilter_graph_dump_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @options);
    public static avfilter_graph_dump_delegate avfilter_graph_dump = (AVFilterGraph* @graph, string @options) =>
    {
        avfilter_graph_dump = FunctionLoader.GetFunctionDelegate<avfilter_graph_dump_delegate>("avfilter", "avfilter_graph_dump");
        if (avfilter_graph_dump == null)
        {
            avfilter_graph_dump = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_dump(@graph, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avfilter_graph_free_delegate(AVFilterGraph** @graph);
    public static avfilter_graph_free_delegate avfilter_graph_free = (AVFilterGraph** @graph) =>
    {
        avfilter_graph_free = FunctionLoader.GetFunctionDelegate<avfilter_graph_free_delegate>("avfilter", "avfilter_graph_free");
        if (avfilter_graph_free == null)
        {
            avfilter_graph_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avfilter_graph_free(@graph);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilterContext* avfilter_graph_get_filter_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avfilter_graph_get_filter_delegate avfilter_graph_get_filter = (AVFilterGraph* @graph, string @name) =>
    {
        avfilter_graph_get_filter = FunctionLoader.GetFunctionDelegate<avfilter_graph_get_filter_delegate>("avfilter", "avfilter_graph_get_filter");
        if (avfilter_graph_get_filter == null)
        {
            avfilter_graph_get_filter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_get_filter(@graph, @name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_parse_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
    public static avfilter_graph_parse_delegate avfilter_graph_parse = (AVFilterGraph* @graph, string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx) =>
    {
        avfilter_graph_parse = FunctionLoader.GetFunctionDelegate<avfilter_graph_parse_delegate>("avfilter", "avfilter_graph_parse");
        if (avfilter_graph_parse == null)
        {
            avfilter_graph_parse = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_parse(@graph, @filters, @inputs, @outputs, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_parse_ptr_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
    public static avfilter_graph_parse_ptr_delegate avfilter_graph_parse_ptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx) =>
    {
        avfilter_graph_parse_ptr = FunctionLoader.GetFunctionDelegate<avfilter_graph_parse_ptr_delegate>("avfilter", "avfilter_graph_parse_ptr");
        if (avfilter_graph_parse_ptr == null)
        {
            avfilter_graph_parse_ptr = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_parse_ptr(@graph, @filters, @inputs, @outputs, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_parse2_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    public static avfilter_graph_parse2_delegate avfilter_graph_parse2 = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs) =>
    {
        avfilter_graph_parse2 = FunctionLoader.GetFunctionDelegate<avfilter_graph_parse2_delegate>("avfilter", "avfilter_graph_parse2");
        if (avfilter_graph_parse2 == null)
        {
            avfilter_graph_parse2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_parse2(@graph, @filters, @inputs, @outputs);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_queue_command_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, int @flags, double @ts);
    public static avfilter_graph_queue_command_delegate avfilter_graph_queue_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, int @flags, double @ts) =>
    {
        avfilter_graph_queue_command = FunctionLoader.GetFunctionDelegate<avfilter_graph_queue_command_delegate>("avfilter", "avfilter_graph_queue_command");
        if (avfilter_graph_queue_command == null)
        {
            avfilter_graph_queue_command = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_queue_command(@graph, @target, @cmd, @arg, @flags, @ts);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_request_oldest_delegate(AVFilterGraph* @graph);
    public static avfilter_graph_request_oldest_delegate avfilter_graph_request_oldest = (AVFilterGraph* @graph) =>
    {
        avfilter_graph_request_oldest = FunctionLoader.GetFunctionDelegate<avfilter_graph_request_oldest_delegate>("avfilter", "avfilter_graph_request_oldest");
        if (avfilter_graph_request_oldest == null)
        {
            avfilter_graph_request_oldest = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_request_oldest(@graph);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_graph_send_command_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
    public static avfilter_graph_send_command_delegate avfilter_graph_send_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
    {
        avfilter_graph_send_command = FunctionLoader.GetFunctionDelegate<avfilter_graph_send_command_delegate>("avfilter", "avfilter_graph_send_command");
        if (avfilter_graph_send_command == null)
        {
            avfilter_graph_send_command = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_graph_send_command(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avfilter_graph_set_auto_convert_delegate(AVFilterGraph* @graph, uint @flags);
    public static avfilter_graph_set_auto_convert_delegate avfilter_graph_set_auto_convert = (AVFilterGraph* @graph, uint @flags) =>
    {
        avfilter_graph_set_auto_convert = FunctionLoader.GetFunctionDelegate<avfilter_graph_set_auto_convert_delegate>("avfilter", "avfilter_graph_set_auto_convert");
        if (avfilter_graph_set_auto_convert == null)
        {
            avfilter_graph_set_auto_convert = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avfilter_graph_set_auto_convert(@graph, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_init_dict_delegate(AVFilterContext* @ctx, AVDictionary** @options);
    public static avfilter_init_dict_delegate avfilter_init_dict = (AVFilterContext* @ctx, AVDictionary** @options) =>
    {
        avfilter_init_dict = FunctionLoader.GetFunctionDelegate<avfilter_init_dict_delegate>("avfilter", "avfilter_init_dict");
        if (avfilter_init_dict == null)
        {
            avfilter_init_dict = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_init_dict(@ctx, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_init_str_delegate(AVFilterContext* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args);
    public static avfilter_init_str_delegate avfilter_init_str = (AVFilterContext* @ctx, string @args) =>
    {
        avfilter_init_str = FunctionLoader.GetFunctionDelegate<avfilter_init_str_delegate>("avfilter", "avfilter_init_str");
        if (avfilter_init_str == null)
        {
            avfilter_init_str = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_init_str(@ctx, @args);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFilterInOut* avfilter_inout_alloc_delegate();
    public static avfilter_inout_alloc_delegate avfilter_inout_alloc = () =>
    {
        avfilter_inout_alloc = FunctionLoader.GetFunctionDelegate<avfilter_inout_alloc_delegate>("avfilter", "avfilter_inout_alloc");
        if (avfilter_inout_alloc == null)
        {
            avfilter_inout_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_inout_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avfilter_inout_free_delegate(AVFilterInOut** @inout);
    public static avfilter_inout_free_delegate avfilter_inout_free = (AVFilterInOut** @inout) =>
    {
        avfilter_inout_free = FunctionLoader.GetFunctionDelegate<avfilter_inout_free_delegate>("avfilter", "avfilter_inout_free");
        if (avfilter_inout_free == null)
        {
            avfilter_inout_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avfilter_inout_free(@inout);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_insert_filter_delegate(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
    public static avfilter_insert_filter_delegate avfilter_insert_filter = (AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx) =>
    {
        avfilter_insert_filter = FunctionLoader.GetFunctionDelegate<avfilter_insert_filter_delegate>("avfilter", "avfilter_insert_filter");
        if (avfilter_insert_filter == null)
        {
            avfilter_insert_filter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_insert_filter(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avfilter_license_delegate();
    public static avfilter_license_delegate avfilter_license = () =>
    {
        avfilter_license = FunctionLoader.GetFunctionDelegate<avfilter_license_delegate>("avfilter", "avfilter_license");
        if (avfilter_license == null)
        {
            avfilter_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_link_delegate(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
    public static avfilter_link_delegate avfilter_link = (AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad) =>
    {
        avfilter_link = FunctionLoader.GetFunctionDelegate<avfilter_link_delegate>("avfilter", "avfilter_link");
        if (avfilter_link == null)
        {
            avfilter_link = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_link(@src, @srcpad, @dst, @dstpad);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avfilter_link_free_delegate(AVFilterLink** @link);
    public static avfilter_link_free_delegate avfilter_link_free = (AVFilterLink** @link) =>
    {
        avfilter_link_free = FunctionLoader.GetFunctionDelegate<avfilter_link_free_delegate>("avfilter", "avfilter_link_free");
        if (avfilter_link_free == null)
        {
            avfilter_link_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avfilter_link_free(@link);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_pad_count_delegate(AVFilterPad* @pads);
    public static avfilter_pad_count_delegate avfilter_pad_count = (AVFilterPad* @pads) =>
    {
        avfilter_pad_count = FunctionLoader.GetFunctionDelegate<avfilter_pad_count_delegate>("avfilter", "avfilter_pad_count");
        if (avfilter_pad_count == null)
        {
            avfilter_pad_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_pad_count(@pads);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avfilter_pad_get_name_delegate(AVFilterPad* @pads, int @pad_idx);
    public static avfilter_pad_get_name_delegate avfilter_pad_get_name = (AVFilterPad* @pads, int @pad_idx) =>
    {
        avfilter_pad_get_name = FunctionLoader.GetFunctionDelegate<avfilter_pad_get_name_delegate>("avfilter", "avfilter_pad_get_name");
        if (avfilter_pad_get_name == null)
        {
            avfilter_pad_get_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_pad_get_name(@pads, @pad_idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVMediaType avfilter_pad_get_type_delegate(AVFilterPad* @pads, int @pad_idx);
    public static avfilter_pad_get_type_delegate avfilter_pad_get_type = (AVFilterPad* @pads, int @pad_idx) =>
    {
        avfilter_pad_get_type = FunctionLoader.GetFunctionDelegate<avfilter_pad_get_type_delegate>("avfilter", "avfilter_pad_get_type");
        if (avfilter_pad_get_type == null)
        {
            avfilter_pad_get_type = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_pad_get_type(@pads, @pad_idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avfilter_process_command_delegate(AVFilterContext* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
    public static avfilter_process_command_delegate avfilter_process_command = (AVFilterContext* @filter, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
    {
        avfilter_process_command = FunctionLoader.GetFunctionDelegate<avfilter_process_command_delegate>("avfilter", "avfilter_process_command");
        if (avfilter_process_command == null)
        {
            avfilter_process_command = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_process_command(@filter, @cmd, @arg, @res, @res_len, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avfilter_version_delegate();
    public static avfilter_version_delegate avfilter_version = () =>
    {
        avfilter_version = FunctionLoader.GetFunctionDelegate<avfilter_version_delegate>("avfilter", "avfilter_version");
        if (avfilter_version == null)
        {
            avfilter_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avfilter_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVFormatContext* avformat_alloc_context_delegate();
    public static avformat_alloc_context_delegate avformat_alloc_context = () =>
    {
        avformat_alloc_context = FunctionLoader.GetFunctionDelegate<avformat_alloc_context_delegate>("avformat", "avformat_alloc_context");
        if (avformat_alloc_context == null)
        {
            avformat_alloc_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_alloc_context();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_alloc_output_context2_delegate(AVFormatContext** @ctx, AVOutputFormat* @oformat,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @format_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename);
    public static avformat_alloc_output_context2_delegate avformat_alloc_output_context2 = (AVFormatContext** @ctx, AVOutputFormat* @oformat, string @format_name, string @filename) =>
    {
        avformat_alloc_output_context2 = FunctionLoader.GetFunctionDelegate<avformat_alloc_output_context2_delegate>("avformat", "avformat_alloc_output_context2");
        if (avformat_alloc_output_context2 == null)
        {
            avformat_alloc_output_context2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_alloc_output_context2(@ctx, @oformat, @format_name, @filename);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avformat_close_input_delegate(AVFormatContext** @s);
    public static avformat_close_input_delegate avformat_close_input = (AVFormatContext** @s) =>
    {
        avformat_close_input = FunctionLoader.GetFunctionDelegate<avformat_close_input_delegate>("avformat", "avformat_close_input");
        if (avformat_close_input == null)
        {
            avformat_close_input = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avformat_close_input(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avformat_configuration_delegate();
    public static avformat_configuration_delegate avformat_configuration = () =>
    {
        avformat_configuration = FunctionLoader.GetFunctionDelegate<avformat_configuration_delegate>("avformat", "avformat_configuration");
        if (avformat_configuration == null)
        {
            avformat_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_find_stream_info_delegate(AVFormatContext* @ic, AVDictionary** @options);
    public static avformat_find_stream_info_delegate avformat_find_stream_info = (AVFormatContext* @ic, AVDictionary** @options) =>
    {
        avformat_find_stream_info = FunctionLoader.GetFunctionDelegate<avformat_find_stream_info_delegate>("avformat", "avformat_find_stream_info");
        if (avformat_find_stream_info == null)
        {
            avformat_find_stream_info = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_find_stream_info(@ic, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_flush_delegate(AVFormatContext* @s);
    public static avformat_flush_delegate avformat_flush = (AVFormatContext* @s) =>
    {
        avformat_flush = FunctionLoader.GetFunctionDelegate<avformat_flush_delegate>("avformat", "avformat_flush");
        if (avformat_flush == null)
        {
            avformat_flush = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_flush(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avformat_free_context_delegate(AVFormatContext* @s);
    public static avformat_free_context_delegate avformat_free_context = (AVFormatContext* @s) =>
    {
        avformat_free_context = FunctionLoader.GetFunctionDelegate<avformat_free_context_delegate>("avformat", "avformat_free_context");
        if (avformat_free_context == null)
        {
            avformat_free_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avformat_free_context(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avformat_get_class_delegate();
    public static avformat_get_class_delegate avformat_get_class = () =>
    {
        avformat_get_class = FunctionLoader.GetFunctionDelegate<avformat_get_class_delegate>("avformat", "avformat_get_class");
        if (avformat_get_class == null)
        {
            avformat_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecTag* avformat_get_mov_audio_tags_delegate();
    public static avformat_get_mov_audio_tags_delegate avformat_get_mov_audio_tags = () =>
    {
        avformat_get_mov_audio_tags = FunctionLoader.GetFunctionDelegate<avformat_get_mov_audio_tags_delegate>("avformat", "avformat_get_mov_audio_tags");
        if (avformat_get_mov_audio_tags == null)
        {
            avformat_get_mov_audio_tags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_get_mov_audio_tags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecTag* avformat_get_mov_video_tags_delegate();
    public static avformat_get_mov_video_tags_delegate avformat_get_mov_video_tags = () =>
    {
        avformat_get_mov_video_tags = FunctionLoader.GetFunctionDelegate<avformat_get_mov_video_tags_delegate>("avformat", "avformat_get_mov_video_tags");
        if (avformat_get_mov_video_tags == null)
        {
            avformat_get_mov_video_tags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_get_mov_video_tags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecTag* avformat_get_riff_audio_tags_delegate();
    public static avformat_get_riff_audio_tags_delegate avformat_get_riff_audio_tags = () =>
    {
        avformat_get_riff_audio_tags = FunctionLoader.GetFunctionDelegate<avformat_get_riff_audio_tags_delegate>("avformat", "avformat_get_riff_audio_tags");
        if (avformat_get_riff_audio_tags == null)
        {
            avformat_get_riff_audio_tags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_get_riff_audio_tags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVCodecTag* avformat_get_riff_video_tags_delegate();
    public static avformat_get_riff_video_tags_delegate avformat_get_riff_video_tags = () =>
    {
        avformat_get_riff_video_tags = FunctionLoader.GetFunctionDelegate<avformat_get_riff_video_tags_delegate>("avformat", "avformat_get_riff_video_tags");
        if (avformat_get_riff_video_tags == null)
        {
            avformat_get_riff_video_tags = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_get_riff_video_tags();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_index_get_entries_count_delegate(AVStream* @st);
    public static avformat_index_get_entries_count_delegate avformat_index_get_entries_count = (AVStream* @st) =>
    {
        avformat_index_get_entries_count = FunctionLoader.GetFunctionDelegate<avformat_index_get_entries_count_delegate>("avformat", "avformat_index_get_entries_count");
        if (avformat_index_get_entries_count == null)
        {
            avformat_index_get_entries_count = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_index_get_entries_count(@st);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVIndexEntry* avformat_index_get_entry_delegate(AVStream* @st, int @idx);
    public static avformat_index_get_entry_delegate avformat_index_get_entry = (AVStream* @st, int @idx) =>
    {
        avformat_index_get_entry = FunctionLoader.GetFunctionDelegate<avformat_index_get_entry_delegate>("avformat", "avformat_index_get_entry");
        if (avformat_index_get_entry == null)
        {
            avformat_index_get_entry = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_index_get_entry(@st, @idx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVIndexEntry* avformat_index_get_entry_from_timestamp_delegate(AVStream* @st, long @wanted_timestamp, int @flags);
    public static avformat_index_get_entry_from_timestamp_delegate avformat_index_get_entry_from_timestamp = (AVStream* @st, long @wanted_timestamp, int @flags) =>
    {
        avformat_index_get_entry_from_timestamp = FunctionLoader.GetFunctionDelegate<avformat_index_get_entry_from_timestamp_delegate>("avformat", "avformat_index_get_entry_from_timestamp");
        if (avformat_index_get_entry_from_timestamp == null)
        {
            avformat_index_get_entry_from_timestamp = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_index_get_entry_from_timestamp(@st, @wanted_timestamp, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_init_output_delegate(AVFormatContext* @s, AVDictionary** @options);
    public static avformat_init_output_delegate avformat_init_output = (AVFormatContext* @s, AVDictionary** @options) =>
    {
        avformat_init_output = FunctionLoader.GetFunctionDelegate<avformat_init_output_delegate>("avformat", "avformat_init_output");
        if (avformat_init_output == null)
        {
            avformat_init_output = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_init_output(@s, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avformat_license_delegate();
    public static avformat_license_delegate avformat_license = () =>
    {
        avformat_license = FunctionLoader.GetFunctionDelegate<avformat_license_delegate>("avformat", "avformat_license");
        if (avformat_license == null)
        {
            avformat_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_match_stream_specifier_delegate(AVFormatContext* @s, AVStream* @st,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @spec);
    public static avformat_match_stream_specifier_delegate avformat_match_stream_specifier = (AVFormatContext* @s, AVStream* @st, string @spec) =>
    {
        avformat_match_stream_specifier = FunctionLoader.GetFunctionDelegate<avformat_match_stream_specifier_delegate>("avformat", "avformat_match_stream_specifier");
        if (avformat_match_stream_specifier == null)
        {
            avformat_match_stream_specifier = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_match_stream_specifier(@s, @st, @spec);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_network_deinit_delegate();
    public static avformat_network_deinit_delegate avformat_network_deinit = () =>
    {
        avformat_network_deinit = FunctionLoader.GetFunctionDelegate<avformat_network_deinit_delegate>("avformat", "avformat_network_deinit");
        if (avformat_network_deinit == null)
        {
            avformat_network_deinit = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_network_deinit();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_network_init_delegate();
    public static avformat_network_init_delegate avformat_network_init = () =>
    {
        avformat_network_init = FunctionLoader.GetFunctionDelegate<avformat_network_init_delegate>("avformat", "avformat_network_init");
        if (avformat_network_init == null)
        {
            avformat_network_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_network_init();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVStream* avformat_new_stream_delegate(AVFormatContext* @s, AVCodec* @c);
    public static avformat_new_stream_delegate avformat_new_stream = (AVFormatContext* @s, AVCodec* @c) =>
    {
        avformat_new_stream = FunctionLoader.GetFunctionDelegate<avformat_new_stream_delegate>("avformat", "avformat_new_stream");
        if (avformat_new_stream == null)
        {
            avformat_new_stream = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_new_stream(@s, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_open_input_delegate(AVFormatContext** @ps,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options);
    public static avformat_open_input_delegate avformat_open_input = (AVFormatContext** @ps, string @url, AVInputFormat* @fmt, AVDictionary** @options) =>
    {
        avformat_open_input = FunctionLoader.GetFunctionDelegate<avformat_open_input_delegate>("avformat", "avformat_open_input");
        if (avformat_open_input == null)
        {
            avformat_open_input = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_open_input(@ps, @url, @fmt, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_query_codec_delegate(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
    public static avformat_query_codec_delegate avformat_query_codec = (AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance) =>
    {
        avformat_query_codec = FunctionLoader.GetFunctionDelegate<avformat_query_codec_delegate>("avformat", "avformat_query_codec");
        if (avformat_query_codec == null)
        {
            avformat_query_codec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_query_codec(@ofmt, @codec_id, @std_compliance);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_queue_attached_pictures_delegate(AVFormatContext* @s);
    public static avformat_queue_attached_pictures_delegate avformat_queue_attached_pictures = (AVFormatContext* @s) =>
    {
        avformat_queue_attached_pictures = FunctionLoader.GetFunctionDelegate<avformat_queue_attached_pictures_delegate>("avformat", "avformat_queue_attached_pictures");
        if (avformat_queue_attached_pictures == null)
        {
            avformat_queue_attached_pictures = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_queue_attached_pictures(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_seek_file_delegate(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
    public static avformat_seek_file_delegate avformat_seek_file = (AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags) =>
    {
        avformat_seek_file = FunctionLoader.GetFunctionDelegate<avformat_seek_file_delegate>("avformat", "avformat_seek_file");
        if (avformat_seek_file == null)
        {
            avformat_seek_file = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_seek_file(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_transfer_internal_stream_timing_info_delegate(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
    public static avformat_transfer_internal_stream_timing_info_delegate avformat_transfer_internal_stream_timing_info = (AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb) =>
    {
        avformat_transfer_internal_stream_timing_info = FunctionLoader.GetFunctionDelegate<avformat_transfer_internal_stream_timing_info_delegate>("avformat", "avformat_transfer_internal_stream_timing_info");
        if (avformat_transfer_internal_stream_timing_info == null)
        {
            avformat_transfer_internal_stream_timing_info = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_transfer_internal_stream_timing_info(@ofmt, @ost, @ist, @copy_tb);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avformat_version_delegate();
    public static avformat_version_delegate avformat_version = () =>
    {
        avformat_version = FunctionLoader.GetFunctionDelegate<avformat_version_delegate>("avformat", "avformat_version");
        if (avformat_version == null)
        {
            avformat_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avformat_write_header_delegate(AVFormatContext* @s, AVDictionary** @options);
    public static avformat_write_header_delegate avformat_write_header = (AVFormatContext* @s, AVDictionary** @options) =>
    {
        avformat_write_header = FunctionLoader.GetFunctionDelegate<avformat_write_header_delegate>("avformat", "avformat_write_header");
        if (avformat_write_header == null)
        {
            avformat_write_header = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avformat_write_header(@s, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_accept_delegate(AVIOContext* @s, AVIOContext** @c);
    public static avio_accept_delegate avio_accept = (AVIOContext* @s, AVIOContext** @c) =>
    {
        avio_accept = FunctionLoader.GetFunctionDelegate<avio_accept_delegate>("avformat", "avio_accept");
        if (avio_accept == null)
        {
            avio_accept = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_accept(@s, @c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVIOContext* avio_alloc_context_delegate(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);
    public static avio_alloc_context_delegate avio_alloc_context = (byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek) =>
    {
        avio_alloc_context = FunctionLoader.GetFunctionDelegate<avio_alloc_context_delegate>("avformat", "avio_alloc_context");
        if (avio_alloc_context == null)
        {
            avio_alloc_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_alloc_context(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_check_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    public static avio_check_delegate avio_check = (string @url, int @flags) =>
    {
        avio_check = FunctionLoader.GetFunctionDelegate<avio_check_delegate>("avformat", "avio_check");
        if (avio_check == null)
        {
            avio_check = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_check(@url, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_close_delegate(AVIOContext* @s);
    public static avio_close_delegate avio_close = (AVIOContext* @s) =>
    {
        avio_close = FunctionLoader.GetFunctionDelegate<avio_close_delegate>("avformat", "avio_close");
        if (avio_close == null)
        {
            avio_close = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_close(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_close_dir_delegate(AVIODirContext** @s);
    public static avio_close_dir_delegate avio_close_dir = (AVIODirContext** @s) =>
    {
        avio_close_dir = FunctionLoader.GetFunctionDelegate<avio_close_dir_delegate>("avformat", "avio_close_dir");
        if (avio_close_dir == null)
        {
            avio_close_dir = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_close_dir(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_close_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
    public static avio_close_dyn_buf_delegate avio_close_dyn_buf = (AVIOContext* @s, byte** @pbuffer) =>
    {
        avio_close_dyn_buf = FunctionLoader.GetFunctionDelegate<avio_close_dyn_buf_delegate>("avformat", "avio_close_dyn_buf");
        if (avio_close_dyn_buf == null)
        {
            avio_close_dyn_buf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_close_dyn_buf(@s, @pbuffer);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_closep_delegate(AVIOContext** @s);
    public static avio_closep_delegate avio_closep = (AVIOContext** @s) =>
    {
        avio_closep = FunctionLoader.GetFunctionDelegate<avio_closep_delegate>("avformat", "avio_closep");
        if (avio_closep == null)
        {
            avio_closep = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_closep(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_context_free_delegate(AVIOContext** @s);
    public static avio_context_free_delegate avio_context_free = (AVIOContext** @s) =>
    {
        avio_context_free = FunctionLoader.GetFunctionDelegate<avio_context_free_delegate>("avformat", "avio_context_free");
        if (avio_context_free == null)
        {
            avio_context_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_context_free(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avio_enum_protocols_delegate(void** @opaque, int @output);
    public static avio_enum_protocols_delegate avio_enum_protocols = (void** @opaque, int @output) =>
    {
        avio_enum_protocols = FunctionLoader.GetFunctionDelegate<avio_enum_protocols_delegate>("avformat", "avio_enum_protocols");
        if (avio_enum_protocols == null)
        {
            avio_enum_protocols = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_enum_protocols(@opaque, @output);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_feof_delegate(AVIOContext* @s);
    public static avio_feof_delegate avio_feof = (AVIOContext* @s) =>
    {
        avio_feof = FunctionLoader.GetFunctionDelegate<avio_feof_delegate>("avformat", "avio_feof");
        if (avio_feof == null)
        {
            avio_feof = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_feof(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avio_find_protocol_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    public static avio_find_protocol_name_delegate avio_find_protocol_name = (string @url) =>
    {
        avio_find_protocol_name = FunctionLoader.GetFunctionDelegate<avio_find_protocol_name_delegate>("avformat", "avio_find_protocol_name");
        if (avio_find_protocol_name == null)
        {
            avio_find_protocol_name = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_find_protocol_name(@url);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_flush_delegate(AVIOContext* @s);
    public static avio_flush_delegate avio_flush = (AVIOContext* @s) =>
    {
        avio_flush = FunctionLoader.GetFunctionDelegate<avio_flush_delegate>("avformat", "avio_flush");
        if (avio_flush == null)
        {
            avio_flush = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_flush(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_free_directory_entry_delegate(AVIODirEntry** @entry);
    public static avio_free_directory_entry_delegate avio_free_directory_entry = (AVIODirEntry** @entry) =>
    {
        avio_free_directory_entry = FunctionLoader.GetFunctionDelegate<avio_free_directory_entry_delegate>("avformat", "avio_free_directory_entry");
        if (avio_free_directory_entry == null)
        {
            avio_free_directory_entry = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_free_directory_entry(@entry);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_get_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
    public static avio_get_dyn_buf_delegate avio_get_dyn_buf = (AVIOContext* @s, byte** @pbuffer) =>
    {
        avio_get_dyn_buf = FunctionLoader.GetFunctionDelegate<avio_get_dyn_buf_delegate>("avformat", "avio_get_dyn_buf");
        if (avio_get_dyn_buf == null)
        {
            avio_get_dyn_buf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_get_dyn_buf(@s, @pbuffer);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_get_str_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    public static avio_get_str_delegate avio_get_str = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
    {
        avio_get_str = FunctionLoader.GetFunctionDelegate<avio_get_str_delegate>("avformat", "avio_get_str");
        if (avio_get_str == null)
        {
            avio_get_str = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_get_str(@pb, @maxlen, @buf, @buflen);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_get_str16be_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    public static avio_get_str16be_delegate avio_get_str16be = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
    {
        avio_get_str16be = FunctionLoader.GetFunctionDelegate<avio_get_str16be_delegate>("avformat", "avio_get_str16be");
        if (avio_get_str16be == null)
        {
            avio_get_str16be = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_get_str16be(@pb, @maxlen, @buf, @buflen);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_get_str16le_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    public static avio_get_str16le_delegate avio_get_str16le = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
    {
        avio_get_str16le = FunctionLoader.GetFunctionDelegate<avio_get_str16le_delegate>("avformat", "avio_get_str16le");
        if (avio_get_str16le == null)
        {
            avio_get_str16le = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_get_str16le(@pb, @maxlen, @buf, @buflen);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_handshake_delegate(AVIOContext* @c);
    public static avio_handshake_delegate avio_handshake = (AVIOContext* @c) =>
    {
        avio_handshake = FunctionLoader.GetFunctionDelegate<avio_handshake_delegate>("avformat", "avio_handshake");
        if (avio_handshake == null)
        {
            avio_handshake = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_handshake(@c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_open_delegate(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    public static avio_open_delegate avio_open = (AVIOContext** @s, string @url, int @flags) =>
    {
        avio_open = FunctionLoader.GetFunctionDelegate<avio_open_delegate>("avformat", "avio_open");
        if (avio_open == null)
        {
            avio_open = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_open(@s, @url, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_open_dir_delegate(AVIODirContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVDictionary** @options);
    public static avio_open_dir_delegate avio_open_dir = (AVIODirContext** @s, string @url, AVDictionary** @options) =>
    {
        avio_open_dir = FunctionLoader.GetFunctionDelegate<avio_open_dir_delegate>("avformat", "avio_open_dir");
        if (avio_open_dir == null)
        {
            avio_open_dir = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_open_dir(@s, @url, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_open_dyn_buf_delegate(AVIOContext** @s);
    public static avio_open_dyn_buf_delegate avio_open_dyn_buf = (AVIOContext** @s) =>
    {
        avio_open_dyn_buf = FunctionLoader.GetFunctionDelegate<avio_open_dyn_buf_delegate>("avformat", "avio_open_dyn_buf");
        if (avio_open_dyn_buf == null)
        {
            avio_open_dyn_buf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_open_dyn_buf(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_open2_delegate(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
    public static avio_open2_delegate avio_open2 = (AVIOContext** @s, string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options) =>
    {
        avio_open2 = FunctionLoader.GetFunctionDelegate<avio_open2_delegate>("avformat", "avio_open2");
        if (avio_open2 == null)
        {
            avio_open2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_open2(@s, @url, @flags, @int_cb, @options);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_pause_delegate(AVIOContext* @h, int @pause);
    public static avio_pause_delegate avio_pause = (AVIOContext* @h, int @pause) =>
    {
        avio_pause = FunctionLoader.GetFunctionDelegate<avio_pause_delegate>("avformat", "avio_pause");
        if (avio_pause == null)
        {
            avio_pause = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_pause(@h, @pause);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_print_string_array_delegate(AVIOContext* @s, byte*[] @strings);
    public static avio_print_string_array_delegate avio_print_string_array = (AVIOContext* @s, byte*[] @strings) =>
    {
        avio_print_string_array = FunctionLoader.GetFunctionDelegate<avio_print_string_array_delegate>("avformat", "avio_print_string_array");
        if (avio_print_string_array == null)
        {
            avio_print_string_array = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_print_string_array(@s, @strings);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_printf_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    public static avio_printf_delegate avio_printf = (AVIOContext* @s, string @fmt) =>
    {
        avio_printf = FunctionLoader.GetFunctionDelegate<avio_printf_delegate>("avformat", "avio_printf");
        if (avio_printf == null)
        {
            avio_printf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_printf(@s, @fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* avio_protocol_get_class_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    public static avio_protocol_get_class_delegate avio_protocol_get_class = (string @name) =>
    {
        avio_protocol_get_class = FunctionLoader.GetFunctionDelegate<avio_protocol_get_class_delegate>("avformat", "avio_protocol_get_class");
        if (avio_protocol_get_class == null)
        {
            avio_protocol_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_protocol_get_class(@name);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_put_str_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    public static avio_put_str_delegate avio_put_str = (AVIOContext* @s, string @str) =>
    {
        avio_put_str = FunctionLoader.GetFunctionDelegate<avio_put_str_delegate>("avformat", "avio_put_str");
        if (avio_put_str == null)
        {
            avio_put_str = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_put_str(@s, @str);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_put_str16be_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    public static avio_put_str16be_delegate avio_put_str16be = (AVIOContext* @s, string @str) =>
    {
        avio_put_str16be = FunctionLoader.GetFunctionDelegate<avio_put_str16be_delegate>("avformat", "avio_put_str16be");
        if (avio_put_str16be == null)
        {
            avio_put_str16be = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_put_str16be(@s, @str);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_put_str16le_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    public static avio_put_str16le_delegate avio_put_str16le = (AVIOContext* @s, string @str) =>
    {
        avio_put_str16le = FunctionLoader.GetFunctionDelegate<avio_put_str16le_delegate>("avformat", "avio_put_str16le");
        if (avio_put_str16le == null)
        {
            avio_put_str16le = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_put_str16le(@s, @str);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_r8_delegate(AVIOContext* @s);
    public static avio_r8_delegate avio_r8 = (AVIOContext* @s) =>
    {
        avio_r8 = FunctionLoader.GetFunctionDelegate<avio_r8_delegate>("avformat", "avio_r8");
        if (avio_r8 == null)
        {
            avio_r8 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_r8(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rb16_delegate(AVIOContext* @s);
    public static avio_rb16_delegate avio_rb16 = (AVIOContext* @s) =>
    {
        avio_rb16 = FunctionLoader.GetFunctionDelegate<avio_rb16_delegate>("avformat", "avio_rb16");
        if (avio_rb16 == null)
        {
            avio_rb16 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rb16(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rb24_delegate(AVIOContext* @s);
    public static avio_rb24_delegate avio_rb24 = (AVIOContext* @s) =>
    {
        avio_rb24 = FunctionLoader.GetFunctionDelegate<avio_rb24_delegate>("avformat", "avio_rb24");
        if (avio_rb24 == null)
        {
            avio_rb24 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rb24(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rb32_delegate(AVIOContext* @s);
    public static avio_rb32_delegate avio_rb32 = (AVIOContext* @s) =>
    {
        avio_rb32 = FunctionLoader.GetFunctionDelegate<avio_rb32_delegate>("avformat", "avio_rb32");
        if (avio_rb32 == null)
        {
            avio_rb32 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rb32(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong avio_rb64_delegate(AVIOContext* @s);
    public static avio_rb64_delegate avio_rb64 = (AVIOContext* @s) =>
    {
        avio_rb64 = FunctionLoader.GetFunctionDelegate<avio_rb64_delegate>("avformat", "avio_rb64");
        if (avio_rb64 == null)
        {
            avio_rb64 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rb64(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_read_delegate(AVIOContext* @s, byte* @buf, int @size);
    public static avio_read_delegate avio_read = (AVIOContext* @s, byte* @buf, int @size) =>
    {
        avio_read = FunctionLoader.GetFunctionDelegate<avio_read_delegate>("avformat", "avio_read");
        if (avio_read == null)
        {
            avio_read = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_read(@s, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_read_dir_delegate(AVIODirContext* @s, AVIODirEntry** @next);
    public static avio_read_dir_delegate avio_read_dir = (AVIODirContext* @s, AVIODirEntry** @next) =>
    {
        avio_read_dir = FunctionLoader.GetFunctionDelegate<avio_read_dir_delegate>("avformat", "avio_read_dir");
        if (avio_read_dir == null)
        {
            avio_read_dir = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_read_dir(@s, @next);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_read_partial_delegate(AVIOContext* @s, byte* @buf, int @size);
    public static avio_read_partial_delegate avio_read_partial = (AVIOContext* @s, byte* @buf, int @size) =>
    {
        avio_read_partial = FunctionLoader.GetFunctionDelegate<avio_read_partial_delegate>("avformat", "avio_read_partial");
        if (avio_read_partial == null)
        {
            avio_read_partial = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_read_partial(@s, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_read_to_bprint_delegate(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);
    public static avio_read_to_bprint_delegate avio_read_to_bprint = (AVIOContext* @h, AVBPrint* @pb, ulong @max_size) =>
    {
        avio_read_to_bprint = FunctionLoader.GetFunctionDelegate<avio_read_to_bprint_delegate>("avformat", "avio_read_to_bprint");
        if (avio_read_to_bprint == null)
        {
            avio_read_to_bprint = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_read_to_bprint(@h, @pb, @max_size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rl16_delegate(AVIOContext* @s);
    public static avio_rl16_delegate avio_rl16 = (AVIOContext* @s) =>
    {
        avio_rl16 = FunctionLoader.GetFunctionDelegate<avio_rl16_delegate>("avformat", "avio_rl16");
        if (avio_rl16 == null)
        {
            avio_rl16 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rl16(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rl24_delegate(AVIOContext* @s);
    public static avio_rl24_delegate avio_rl24 = (AVIOContext* @s) =>
    {
        avio_rl24 = FunctionLoader.GetFunctionDelegate<avio_rl24_delegate>("avformat", "avio_rl24");
        if (avio_rl24 == null)
        {
            avio_rl24 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rl24(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avio_rl32_delegate(AVIOContext* @s);
    public static avio_rl32_delegate avio_rl32 = (AVIOContext* @s) =>
    {
        avio_rl32 = FunctionLoader.GetFunctionDelegate<avio_rl32_delegate>("avformat", "avio_rl32");
        if (avio_rl32 == null)
        {
            avio_rl32 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rl32(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate ulong avio_rl64_delegate(AVIOContext* @s);
    public static avio_rl64_delegate avio_rl64 = (AVIOContext* @s) =>
    {
        avio_rl64 = FunctionLoader.GetFunctionDelegate<avio_rl64_delegate>("avformat", "avio_rl64");
        if (avio_rl64 == null)
        {
            avio_rl64 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_rl64(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long avio_seek_delegate(AVIOContext* @s, long @offset, int @whence);
    public static avio_seek_delegate avio_seek = (AVIOContext* @s, long @offset, int @whence) =>
    {
        avio_seek = FunctionLoader.GetFunctionDelegate<avio_seek_delegate>("avformat", "avio_seek");
        if (avio_seek == null)
        {
            avio_seek = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_seek(@s, @offset, @whence);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long avio_seek_time_delegate(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
    public static avio_seek_time_delegate avio_seek_time = (AVIOContext* @h, int @stream_index, long @timestamp, int @flags) =>
    {
        avio_seek_time = FunctionLoader.GetFunctionDelegate<avio_seek_time_delegate>("avformat", "avio_seek_time");
        if (avio_seek_time == null)
        {
            avio_seek_time = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_seek_time(@h, @stream_index, @timestamp, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long avio_size_delegate(AVIOContext* @s);
    public static avio_size_delegate avio_size = (AVIOContext* @s) =>
    {
        avio_size = FunctionLoader.GetFunctionDelegate<avio_size_delegate>("avformat", "avio_size");
        if (avio_size == null)
        {
            avio_size = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_size(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long avio_skip_delegate(AVIOContext* @s, long @offset);
    public static avio_skip_delegate avio_skip = (AVIOContext* @s, long @offset) =>
    {
        avio_skip = FunctionLoader.GetFunctionDelegate<avio_skip_delegate>("avformat", "avio_skip");
        if (avio_skip == null)
        {
            avio_skip = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_skip(@s, @offset);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int avio_vprintf_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @ap);
    public static avio_vprintf_delegate avio_vprintf = (AVIOContext* @s, string @fmt, byte* @ap) =>
    {
        avio_vprintf = FunctionLoader.GetFunctionDelegate<avio_vprintf_delegate>("avformat", "avio_vprintf");
        if (avio_vprintf == null)
        {
            avio_vprintf = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avio_vprintf(@s, @fmt, @ap);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_w8_delegate(AVIOContext* @s, int @b);
    public static avio_w8_delegate avio_w8 = (AVIOContext* @s, int @b) =>
    {
        avio_w8 = FunctionLoader.GetFunctionDelegate<avio_w8_delegate>("avformat", "avio_w8");
        if (avio_w8 == null)
        {
            avio_w8 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_w8(@s, @b);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wb16_delegate(AVIOContext* @s, uint @val);
    public static avio_wb16_delegate avio_wb16 = (AVIOContext* @s, uint @val) =>
    {
        avio_wb16 = FunctionLoader.GetFunctionDelegate<avio_wb16_delegate>("avformat", "avio_wb16");
        if (avio_wb16 == null)
        {
            avio_wb16 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wb16(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wb24_delegate(AVIOContext* @s, uint @val);
    public static avio_wb24_delegate avio_wb24 = (AVIOContext* @s, uint @val) =>
    {
        avio_wb24 = FunctionLoader.GetFunctionDelegate<avio_wb24_delegate>("avformat", "avio_wb24");
        if (avio_wb24 == null)
        {
            avio_wb24 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wb24(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wb32_delegate(AVIOContext* @s, uint @val);
    public static avio_wb32_delegate avio_wb32 = (AVIOContext* @s, uint @val) =>
    {
        avio_wb32 = FunctionLoader.GetFunctionDelegate<avio_wb32_delegate>("avformat", "avio_wb32");
        if (avio_wb32 == null)
        {
            avio_wb32 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wb32(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wb64_delegate(AVIOContext* @s, ulong @val);
    public static avio_wb64_delegate avio_wb64 = (AVIOContext* @s, ulong @val) =>
    {
        avio_wb64 = FunctionLoader.GetFunctionDelegate<avio_wb64_delegate>("avformat", "avio_wb64");
        if (avio_wb64 == null)
        {
            avio_wb64 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wb64(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wl16_delegate(AVIOContext* @s, uint @val);
    public static avio_wl16_delegate avio_wl16 = (AVIOContext* @s, uint @val) =>
    {
        avio_wl16 = FunctionLoader.GetFunctionDelegate<avio_wl16_delegate>("avformat", "avio_wl16");
        if (avio_wl16 == null)
        {
            avio_wl16 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wl16(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wl24_delegate(AVIOContext* @s, uint @val);
    public static avio_wl24_delegate avio_wl24 = (AVIOContext* @s, uint @val) =>
    {
        avio_wl24 = FunctionLoader.GetFunctionDelegate<avio_wl24_delegate>("avformat", "avio_wl24");
        if (avio_wl24 == null)
        {
            avio_wl24 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wl24(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wl32_delegate(AVIOContext* @s, uint @val);
    public static avio_wl32_delegate avio_wl32 = (AVIOContext* @s, uint @val) =>
    {
        avio_wl32 = FunctionLoader.GetFunctionDelegate<avio_wl32_delegate>("avformat", "avio_wl32");
        if (avio_wl32 == null)
        {
            avio_wl32 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wl32(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_wl64_delegate(AVIOContext* @s, ulong @val);
    public static avio_wl64_delegate avio_wl64 = (AVIOContext* @s, ulong @val) =>
    {
        avio_wl64 = FunctionLoader.GetFunctionDelegate<avio_wl64_delegate>("avformat", "avio_wl64");
        if (avio_wl64 == null)
        {
            avio_wl64 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_wl64(@s, @val);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_write_delegate(AVIOContext* @s, byte* @buf, int @size);
    public static avio_write_delegate avio_write = (AVIOContext* @s, byte* @buf, int @size) =>
    {
        avio_write = FunctionLoader.GetFunctionDelegate<avio_write_delegate>("avformat", "avio_write");
        if (avio_write == null)
        {
            avio_write = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_write(@s, @buf, @size);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avio_write_marker_delegate(AVIOContext* @s, long @time, AVIODataMarkerType @type);
    public static avio_write_marker_delegate avio_write_marker = (AVIOContext* @s, long @time, AVIODataMarkerType @type) =>
    {
        avio_write_marker = FunctionLoader.GetFunctionDelegate<avio_write_marker_delegate>("avformat", "avio_write_marker");
        if (avio_write_marker == null)
        {
            avio_write_marker = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avio_write_marker(@s, @time, @type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void avsubtitle_free_delegate(AVSubtitle* @sub);
    public static avsubtitle_free_delegate avsubtitle_free = (AVSubtitle* @sub) =>
    {
        avsubtitle_free = FunctionLoader.GetFunctionDelegate<avsubtitle_free_delegate>("avcodec", "avsubtitle_free");
        if (avsubtitle_free == null)
        {
            avsubtitle_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        avsubtitle_free(@sub);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avutil_configuration_delegate();
    public static avutil_configuration_delegate avutil_configuration = () =>
    {
        avutil_configuration = FunctionLoader.GetFunctionDelegate<avutil_configuration_delegate>("avutil", "avutil_configuration");
        if (avutil_configuration == null)
        {
            avutil_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avutil_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string avutil_license_delegate();
    public static avutil_license_delegate avutil_license = () =>
    {
        avutil_license = FunctionLoader.GetFunctionDelegate<avutil_license_delegate>("avutil", "avutil_license");
        if (avutil_license == null)
        {
            avutil_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avutil_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint avutil_version_delegate();
    public static avutil_version_delegate avutil_version = () =>
    {
        avutil_version = FunctionLoader.GetFunctionDelegate<avutil_version_delegate>("avutil", "avutil_version");
        if (avutil_version == null)
        {
            avutil_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return avutil_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string postproc_configuration_delegate();
    public static postproc_configuration_delegate postproc_configuration = () =>
    {
        postproc_configuration = FunctionLoader.GetFunctionDelegate<postproc_configuration_delegate>("postproc", "postproc_configuration");
        if (postproc_configuration == null)
        {
            postproc_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return postproc_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string postproc_license_delegate();
    public static postproc_license_delegate postproc_license = () =>
    {
        postproc_license = FunctionLoader.GetFunctionDelegate<postproc_license_delegate>("postproc", "postproc_license");
        if (postproc_license == null)
        {
            postproc_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return postproc_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint postproc_version_delegate();
    public static postproc_version_delegate postproc_version = () =>
    {
        postproc_version = FunctionLoader.GetFunctionDelegate<postproc_version_delegate>("postproc", "postproc_version");
        if (postproc_version == null)
        {
            postproc_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return postproc_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void pp_free_context_delegate(void* @ppContext);
    public static pp_free_context_delegate pp_free_context = (void* @ppContext) =>
    {
        pp_free_context = FunctionLoader.GetFunctionDelegate<pp_free_context_delegate>("postproc", "pp_free_context");
        if (pp_free_context == null)
        {
            pp_free_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        pp_free_context(@ppContext);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void pp_free_mode_delegate(void* @mode);
    public static pp_free_mode_delegate pp_free_mode = (void* @mode) =>
    {
        pp_free_mode = FunctionLoader.GetFunctionDelegate<pp_free_mode_delegate>("postproc", "pp_free_mode");
        if (pp_free_mode == null)
        {
            pp_free_mode = delegate 
            {
                throw new NotSupportedException();
            };
        }
        pp_free_mode(@mode);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* pp_get_context_delegate(int @width, int @height, int @flags);
    public static pp_get_context_delegate pp_get_context = (int @width, int @height, int @flags) =>
    {
        pp_get_context = FunctionLoader.GetFunctionDelegate<pp_get_context_delegate>("postproc", "pp_get_context");
        if (pp_get_context == null)
        {
            pp_get_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return pp_get_context(@width, @height, @flags);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void* pp_get_mode_by_name_and_quality_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @quality);
    public static pp_get_mode_by_name_and_quality_delegate pp_get_mode_by_name_and_quality = (string @name, int @quality) =>
    {
        pp_get_mode_by_name_and_quality = FunctionLoader.GetFunctionDelegate<pp_get_mode_by_name_and_quality_delegate>("postproc", "pp_get_mode_by_name_and_quality");
        if (pp_get_mode_by_name_and_quality == null)
        {
            pp_get_mode_by_name_and_quality = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return pp_get_mode_by_name_and_quality(@name, @quality);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void pp_postprocess_delegate(byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
    public static pp_postprocess_delegate pp_postprocess = (byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type) =>
    {
        pp_postprocess = FunctionLoader.GetFunctionDelegate<pp_postprocess_delegate>("postproc", "pp_postprocess");
        if (pp_postprocess == null)
        {
            pp_postprocess = delegate 
            {
                throw new NotSupportedException();
            };
        }
        pp_postprocess(@src, @srcStride, ref @dst, @dstStride, @horizontalSize, @verticalSize, @QP_store, @QP_stride, @mode, @ppContext, @pict_type);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwrContext* swr_alloc_delegate();
    public static swr_alloc_delegate swr_alloc = () =>
    {
        swr_alloc = FunctionLoader.GetFunctionDelegate<swr_alloc_delegate>("swresample", "swr_alloc");
        if (swr_alloc == null)
        {
            swr_alloc = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_alloc();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwrContext* swr_alloc_set_opts_delegate(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
    public static swr_alloc_set_opts_delegate swr_alloc_set_opts = (SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) =>
    {
        swr_alloc_set_opts = FunctionLoader.GetFunctionDelegate<swr_alloc_set_opts_delegate>("swresample", "swr_alloc_set_opts");
        if (swr_alloc_set_opts == null)
        {
            swr_alloc_set_opts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_alloc_set_opts(@s, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_alloc_set_opts2_delegate(SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
    public static swr_alloc_set_opts2_delegate swr_alloc_set_opts2 = (SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) =>
    {
        swr_alloc_set_opts2 = FunctionLoader.GetFunctionDelegate<swr_alloc_set_opts2_delegate>("swresample", "swr_alloc_set_opts2");
        if (swr_alloc_set_opts2 == null)
        {
            swr_alloc_set_opts2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_alloc_set_opts2(@ps, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_build_matrix_delegate(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx);
    public static swr_build_matrix_delegate swr_build_matrix = (ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx) =>
    {
        swr_build_matrix = FunctionLoader.GetFunctionDelegate<swr_build_matrix_delegate>("swresample", "swr_build_matrix");
        if (swr_build_matrix == null)
        {
            swr_build_matrix = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_build_matrix(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @rematrix_maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_ctx);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_build_matrix2_delegate(AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context);
    public static swr_build_matrix2_delegate swr_build_matrix2 = (AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context) =>
    {
        swr_build_matrix2 = FunctionLoader.GetFunctionDelegate<swr_build_matrix2_delegate>("swresample", "swr_build_matrix2");
        if (swr_build_matrix2 == null)
        {
            swr_build_matrix2 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_build_matrix2(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_context);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void swr_close_delegate(SwrContext* @s);
    public static swr_close_delegate swr_close = (SwrContext* @s) =>
    {
        swr_close = FunctionLoader.GetFunctionDelegate<swr_close_delegate>("swresample", "swr_close");
        if (swr_close == null)
        {
            swr_close = delegate 
            {
                throw new NotSupportedException();
            };
        }
        swr_close(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_config_frame_delegate(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
    public static swr_config_frame_delegate swr_config_frame = (SwrContext* @swr, AVFrame* @out, AVFrame* @in) =>
    {
        swr_config_frame = FunctionLoader.GetFunctionDelegate<swr_config_frame_delegate>("swresample", "swr_config_frame");
        if (swr_config_frame == null)
        {
            swr_config_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_config_frame(@swr, @out, @in);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_convert_delegate(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);
    public static swr_convert_delegate swr_convert = (SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count) =>
    {
        swr_convert = FunctionLoader.GetFunctionDelegate<swr_convert_delegate>("swresample", "swr_convert");
        if (swr_convert == null)
        {
            swr_convert = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_convert(@s, @out, @out_count, @in, @in_count);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_convert_frame_delegate(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
    public static swr_convert_frame_delegate swr_convert_frame = (SwrContext* @swr, AVFrame* @output, AVFrame* @input) =>
    {
        swr_convert_frame = FunctionLoader.GetFunctionDelegate<swr_convert_frame_delegate>("swresample", "swr_convert_frame");
        if (swr_convert_frame == null)
        {
            swr_convert_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_convert_frame(@swr, @output, @input);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_drop_output_delegate(SwrContext* @s, int @count);
    public static swr_drop_output_delegate swr_drop_output = (SwrContext* @s, int @count) =>
    {
        swr_drop_output = FunctionLoader.GetFunctionDelegate<swr_drop_output_delegate>("swresample", "swr_drop_output");
        if (swr_drop_output == null)
        {
            swr_drop_output = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_drop_output(@s, @count);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void swr_free_delegate(SwrContext** @s);
    public static swr_free_delegate swr_free = (SwrContext** @s) =>
    {
        swr_free = FunctionLoader.GetFunctionDelegate<swr_free_delegate>("swresample", "swr_free");
        if (swr_free == null)
        {
            swr_free = delegate 
            {
                throw new NotSupportedException();
            };
        }
        swr_free(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* swr_get_class_delegate();
    public static swr_get_class_delegate swr_get_class = () =>
    {
        swr_get_class = FunctionLoader.GetFunctionDelegate<swr_get_class_delegate>("swresample", "swr_get_class");
        if (swr_get_class == null)
        {
            swr_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long swr_get_delay_delegate(SwrContext* @s, long @base);
    public static swr_get_delay_delegate swr_get_delay = (SwrContext* @s, long @base) =>
    {
        swr_get_delay = FunctionLoader.GetFunctionDelegate<swr_get_delay_delegate>("swresample", "swr_get_delay");
        if (swr_get_delay == null)
        {
            swr_get_delay = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_get_delay(@s, @base);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_get_out_samples_delegate(SwrContext* @s, int @in_samples);
    public static swr_get_out_samples_delegate swr_get_out_samples = (SwrContext* @s, int @in_samples) =>
    {
        swr_get_out_samples = FunctionLoader.GetFunctionDelegate<swr_get_out_samples_delegate>("swresample", "swr_get_out_samples");
        if (swr_get_out_samples == null)
        {
            swr_get_out_samples = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_get_out_samples(@s, @in_samples);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_init_delegate(SwrContext* @s);
    public static swr_init_delegate swr_init = (SwrContext* @s) =>
    {
        swr_init = FunctionLoader.GetFunctionDelegate<swr_init_delegate>("swresample", "swr_init");
        if (swr_init == null)
        {
            swr_init = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_init(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_inject_silence_delegate(SwrContext* @s, int @count);
    public static swr_inject_silence_delegate swr_inject_silence = (SwrContext* @s, int @count) =>
    {
        swr_inject_silence = FunctionLoader.GetFunctionDelegate<swr_inject_silence_delegate>("swresample", "swr_inject_silence");
        if (swr_inject_silence == null)
        {
            swr_inject_silence = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_inject_silence(@s, @count);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_is_initialized_delegate(SwrContext* @s);
    public static swr_is_initialized_delegate swr_is_initialized = (SwrContext* @s) =>
    {
        swr_is_initialized = FunctionLoader.GetFunctionDelegate<swr_is_initialized_delegate>("swresample", "swr_is_initialized");
        if (swr_is_initialized == null)
        {
            swr_is_initialized = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_is_initialized(@s);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate long swr_next_pts_delegate(SwrContext* @s, long @pts);
    public static swr_next_pts_delegate swr_next_pts = (SwrContext* @s, long @pts) =>
    {
        swr_next_pts = FunctionLoader.GetFunctionDelegate<swr_next_pts_delegate>("swresample", "swr_next_pts");
        if (swr_next_pts == null)
        {
            swr_next_pts = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_next_pts(@s, @pts);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_set_channel_mapping_delegate(SwrContext* @s, int* @channel_map);
    public static swr_set_channel_mapping_delegate swr_set_channel_mapping = (SwrContext* @s, int* @channel_map) =>
    {
        swr_set_channel_mapping = FunctionLoader.GetFunctionDelegate<swr_set_channel_mapping_delegate>("swresample", "swr_set_channel_mapping");
        if (swr_set_channel_mapping == null)
        {
            swr_set_channel_mapping = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_set_channel_mapping(@s, @channel_map);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_set_compensation_delegate(SwrContext* @s, int @sample_delta, int @compensation_distance);
    public static swr_set_compensation_delegate swr_set_compensation = (SwrContext* @s, int @sample_delta, int @compensation_distance) =>
    {
        swr_set_compensation = FunctionLoader.GetFunctionDelegate<swr_set_compensation_delegate>("swresample", "swr_set_compensation");
        if (swr_set_compensation == null)
        {
            swr_set_compensation = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_set_compensation(@s, @sample_delta, @compensation_distance);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int swr_set_matrix_delegate(SwrContext* @s, double* @matrix, int @stride);
    public static swr_set_matrix_delegate swr_set_matrix = (SwrContext* @s, double* @matrix, int @stride) =>
    {
        swr_set_matrix = FunctionLoader.GetFunctionDelegate<swr_set_matrix_delegate>("swresample", "swr_set_matrix");
        if (swr_set_matrix == null)
        {
            swr_set_matrix = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swr_set_matrix(@s, @matrix, @stride);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string swresample_configuration_delegate();
    public static swresample_configuration_delegate swresample_configuration = () =>
    {
        swresample_configuration = FunctionLoader.GetFunctionDelegate<swresample_configuration_delegate>("swresample", "swresample_configuration");
        if (swresample_configuration == null)
        {
            swresample_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swresample_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string swresample_license_delegate();
    public static swresample_license_delegate swresample_license = () =>
    {
        swresample_license = FunctionLoader.GetFunctionDelegate<swresample_license_delegate>("swresample", "swresample_license");
        if (swresample_license == null)
        {
            swresample_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swresample_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint swresample_version_delegate();
    public static swresample_version_delegate swresample_version = () =>
    {
        swresample_version = FunctionLoader.GetFunctionDelegate<swresample_version_delegate>("swresample", "swresample_version");
        if (swresample_version == null)
        {
            swresample_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swresample_version();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsContext* sws_alloc_context_delegate();
    public static sws_alloc_context_delegate sws_alloc_context = () =>
    {
        sws_alloc_context = FunctionLoader.GetFunctionDelegate<sws_alloc_context_delegate>("swscale", "sws_alloc_context");
        if (sws_alloc_context == null)
        {
            sws_alloc_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_alloc_context();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsVector* sws_allocVec_delegate(int @length);
    public static sws_allocVec_delegate sws_allocVec = (int @length) =>
    {
        sws_allocVec = FunctionLoader.GetFunctionDelegate<sws_allocVec_delegate>("swscale", "sws_allocVec");
        if (sws_allocVec == null)
        {
            sws_allocVec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_allocVec(@length);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_convertPalette8ToPacked24_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    public static sws_convertPalette8ToPacked24_delegate sws_convertPalette8ToPacked24 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
    {
        sws_convertPalette8ToPacked24 = FunctionLoader.GetFunctionDelegate<sws_convertPalette8ToPacked24_delegate>("swscale", "sws_convertPalette8ToPacked24");
        if (sws_convertPalette8ToPacked24 == null)
        {
            sws_convertPalette8ToPacked24 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_convertPalette8ToPacked24(@src, @dst, @num_pixels, @palette);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_convertPalette8ToPacked32_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    public static sws_convertPalette8ToPacked32_delegate sws_convertPalette8ToPacked32 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
    {
        sws_convertPalette8ToPacked32 = FunctionLoader.GetFunctionDelegate<sws_convertPalette8ToPacked32_delegate>("swscale", "sws_convertPalette8ToPacked32");
        if (sws_convertPalette8ToPacked32 == null)
        {
            sws_convertPalette8ToPacked32 = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_convertPalette8ToPacked32(@src, @dst, @num_pixels, @palette);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_frame_end_delegate(SwsContext* @c);
    public static sws_frame_end_delegate sws_frame_end = (SwsContext* @c) =>
    {
        sws_frame_end = FunctionLoader.GetFunctionDelegate<sws_frame_end_delegate>("swscale", "sws_frame_end");
        if (sws_frame_end == null)
        {
            sws_frame_end = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_frame_end(@c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_frame_start_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    public static sws_frame_start_delegate sws_frame_start = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) =>
    {
        sws_frame_start = FunctionLoader.GetFunctionDelegate<sws_frame_start_delegate>("swscale", "sws_frame_start");
        if (sws_frame_start == null)
        {
            sws_frame_start = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_frame_start(@c, @dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_freeContext_delegate(SwsContext* @swsContext);
    public static sws_freeContext_delegate sws_freeContext = (SwsContext* @swsContext) =>
    {
        sws_freeContext = FunctionLoader.GetFunctionDelegate<sws_freeContext_delegate>("swscale", "sws_freeContext");
        if (sws_freeContext == null)
        {
            sws_freeContext = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_freeContext(@swsContext);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_freeFilter_delegate(SwsFilter* @filter);
    public static sws_freeFilter_delegate sws_freeFilter = (SwsFilter* @filter) =>
    {
        sws_freeFilter = FunctionLoader.GetFunctionDelegate<sws_freeFilter_delegate>("swscale", "sws_freeFilter");
        if (sws_freeFilter == null)
        {
            sws_freeFilter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_freeFilter(@filter);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_freeVec_delegate(SwsVector* @a);
    public static sws_freeVec_delegate sws_freeVec = (SwsVector* @a) =>
    {
        sws_freeVec = FunctionLoader.GetFunctionDelegate<sws_freeVec_delegate>("swscale", "sws_freeVec");
        if (sws_freeVec == null)
        {
            sws_freeVec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_freeVec(@a);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate AVClass* sws_get_class_delegate();
    public static sws_get_class_delegate sws_get_class = () =>
    {
        sws_get_class = FunctionLoader.GetFunctionDelegate<sws_get_class_delegate>("swscale", "sws_get_class");
        if (sws_get_class == null)
        {
            sws_get_class = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_get_class();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsContext* sws_getCachedContext_delegate(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    public static sws_getCachedContext_delegate sws_getCachedContext = (SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
    {
        sws_getCachedContext = FunctionLoader.GetFunctionDelegate<sws_getCachedContext_delegate>("swscale", "sws_getCachedContext");
        if (sws_getCachedContext == null)
        {
            sws_getCachedContext = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getCachedContext(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int* sws_getCoefficients_delegate(int @colorspace);
    public static sws_getCoefficients_delegate sws_getCoefficients = (int @colorspace) =>
    {
        sws_getCoefficients = FunctionLoader.GetFunctionDelegate<sws_getCoefficients_delegate>("swscale", "sws_getCoefficients");
        if (sws_getCoefficients == null)
        {
            sws_getCoefficients = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getCoefficients(@colorspace);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_getColorspaceDetails_delegate(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
    public static sws_getColorspaceDetails_delegate sws_getColorspaceDetails = (SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation) =>
    {
        sws_getColorspaceDetails = FunctionLoader.GetFunctionDelegate<sws_getColorspaceDetails_delegate>("swscale", "sws_getColorspaceDetails");
        if (sws_getColorspaceDetails == null)
        {
            sws_getColorspaceDetails = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsContext* sws_getContext_delegate(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    public static sws_getContext_delegate sws_getContext = (int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
    {
        sws_getContext = FunctionLoader.GetFunctionDelegate<sws_getContext_delegate>("swscale", "sws_getContext");
        if (sws_getContext == null)
        {
            sws_getContext = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getContext(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsFilter* sws_getDefaultFilter_delegate(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
    public static sws_getDefaultFilter_delegate sws_getDefaultFilter = (float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose) =>
    {
        sws_getDefaultFilter = FunctionLoader.GetFunctionDelegate<sws_getDefaultFilter_delegate>("swscale", "sws_getDefaultFilter");
        if (sws_getDefaultFilter == null)
        {
            sws_getDefaultFilter = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getDefaultFilter(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate SwsVector* sws_getGaussianVec_delegate(double @variance, double @quality);
    public static sws_getGaussianVec_delegate sws_getGaussianVec = (double @variance, double @quality) =>
    {
        sws_getGaussianVec = FunctionLoader.GetFunctionDelegate<sws_getGaussianVec_delegate>("swscale", "sws_getGaussianVec");
        if (sws_getGaussianVec == null)
        {
            sws_getGaussianVec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_getGaussianVec(@variance, @quality);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_init_context_delegate(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
    public static sws_init_context_delegate sws_init_context = (SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter) =>
    {
        sws_init_context = FunctionLoader.GetFunctionDelegate<sws_init_context_delegate>("swscale", "sws_init_context");
        if (sws_init_context == null)
        {
            sws_init_context = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_init_context(@sws_context, @srcFilter, @dstFilter);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_isSupportedEndiannessConversion_delegate(AVPixelFormat @pix_fmt);
    public static sws_isSupportedEndiannessConversion_delegate sws_isSupportedEndiannessConversion = (AVPixelFormat @pix_fmt) =>
    {
        sws_isSupportedEndiannessConversion = FunctionLoader.GetFunctionDelegate<sws_isSupportedEndiannessConversion_delegate>("swscale", "sws_isSupportedEndiannessConversion");
        if (sws_isSupportedEndiannessConversion == null)
        {
            sws_isSupportedEndiannessConversion = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_isSupportedEndiannessConversion(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_isSupportedInput_delegate(AVPixelFormat @pix_fmt);
    public static sws_isSupportedInput_delegate sws_isSupportedInput = (AVPixelFormat @pix_fmt) =>
    {
        sws_isSupportedInput = FunctionLoader.GetFunctionDelegate<sws_isSupportedInput_delegate>("swscale", "sws_isSupportedInput");
        if (sws_isSupportedInput == null)
        {
            sws_isSupportedInput = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_isSupportedInput(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_isSupportedOutput_delegate(AVPixelFormat @pix_fmt);
    public static sws_isSupportedOutput_delegate sws_isSupportedOutput = (AVPixelFormat @pix_fmt) =>
    {
        sws_isSupportedOutput = FunctionLoader.GetFunctionDelegate<sws_isSupportedOutput_delegate>("swscale", "sws_isSupportedOutput");
        if (sws_isSupportedOutput == null)
        {
            sws_isSupportedOutput = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_isSupportedOutput(@pix_fmt);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_normalizeVec_delegate(SwsVector* @a, double @height);
    public static sws_normalizeVec_delegate sws_normalizeVec = (SwsVector* @a, double @height) =>
    {
        sws_normalizeVec = FunctionLoader.GetFunctionDelegate<sws_normalizeVec_delegate>("swscale", "sws_normalizeVec");
        if (sws_normalizeVec == null)
        {
            sws_normalizeVec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_normalizeVec(@a, @height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_receive_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);
    public static sws_receive_slice_delegate sws_receive_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) =>
    {
        sws_receive_slice = FunctionLoader.GetFunctionDelegate<sws_receive_slice_delegate>("swscale", "sws_receive_slice");
        if (sws_receive_slice == null)
        {
            sws_receive_slice = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_receive_slice(@c, @slice_start, @slice_height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint sws_receive_slice_alignment_delegate(SwsContext* @c);
    public static sws_receive_slice_alignment_delegate sws_receive_slice_alignment = (SwsContext* @c) =>
    {
        sws_receive_slice_alignment = FunctionLoader.GetFunctionDelegate<sws_receive_slice_alignment_delegate>("swscale", "sws_receive_slice_alignment");
        if (sws_receive_slice_alignment == null)
        {
            sws_receive_slice_alignment = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_receive_slice_alignment(@c);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_scale_delegate(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
    public static sws_scale_delegate sws_scale = (SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride) =>
    {
        sws_scale = FunctionLoader.GetFunctionDelegate<sws_scale_delegate>("swscale", "sws_scale");
        if (sws_scale == null)
        {
            sws_scale = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_scale(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_scale_frame_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    public static sws_scale_frame_delegate sws_scale_frame = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) =>
    {
        sws_scale_frame = FunctionLoader.GetFunctionDelegate<sws_scale_frame_delegate>("swscale", "sws_scale_frame");
        if (sws_scale_frame == null)
        {
            sws_scale_frame = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_scale_frame(@c, @dst, @src);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate void sws_scaleVec_delegate(SwsVector* @a, double @scalar);
    public static sws_scaleVec_delegate sws_scaleVec = (SwsVector* @a, double @scalar) =>
    {
        sws_scaleVec = FunctionLoader.GetFunctionDelegate<sws_scaleVec_delegate>("swscale", "sws_scaleVec");
        if (sws_scaleVec == null)
        {
            sws_scaleVec = delegate 
            {
                throw new NotSupportedException();
            };
        }
        sws_scaleVec(@a, @scalar);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_send_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);
    public static sws_send_slice_delegate sws_send_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) =>
    {
        sws_send_slice = FunctionLoader.GetFunctionDelegate<sws_send_slice_delegate>("swscale", "sws_send_slice");
        if (sws_send_slice == null)
        {
            sws_send_slice = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_send_slice(@c, @slice_start, @slice_height);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate int sws_setColorspaceDetails_delegate(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);
    public static sws_setColorspaceDetails_delegate sws_setColorspaceDetails = (SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation) =>
    {
        sws_setColorspaceDetails = FunctionLoader.GetFunctionDelegate<sws_setColorspaceDetails_delegate>("swscale", "sws_setColorspaceDetails");
        if (sws_setColorspaceDetails == null)
        {
            sws_setColorspaceDetails = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return sws_setColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string swscale_configuration_delegate();
    public static swscale_configuration_delegate swscale_configuration = () =>
    {
        swscale_configuration = FunctionLoader.GetFunctionDelegate<swscale_configuration_delegate>("swscale", "swscale_configuration");
        if (swscale_configuration == null)
        {
            swscale_configuration = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swscale_configuration();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    public delegate string swscale_license_delegate();
    public static swscale_license_delegate swscale_license = () =>
    {
        swscale_license = FunctionLoader.GetFunctionDelegate<swscale_license_delegate>("swscale", "swscale_license");
        if (swscale_license == null)
        {
            swscale_license = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swscale_license();
    };
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    public delegate uint swscale_version_delegate();
    public static swscale_version_delegate swscale_version = () =>
    {
        swscale_version = FunctionLoader.GetFunctionDelegate<swscale_version_delegate>("swscale", "swscale_version");
        if (swscale_version == null)
        {
            swscale_version = delegate 
            {
                throw new NotSupportedException();
            };
        }
        return swscale_version();
    };
    
    public unsafe static void Initialize()
    {
        FunctionLoader = FunctionLoaderFactory.Create();
        
        vectors.av_abuffersink_params_alloc = () => av_abuffersink_params_alloc();
        vectors.av_add_index_entry = (AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags) => av_add_index_entry(@st, @pos, @timestamp, @size, @distance, @flags);
        vectors.av_add_q = (AVRational @b, AVRational @c) => av_add_q(@b, @c);
        vectors.av_add_stable = (AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc) => av_add_stable(@ts_tb, @ts, @inc_tb, @inc);
        vectors.av_append_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) => av_append_packet(@s, @pkt, @size);
        vectors.av_audio_fifo_alloc = (AVSampleFormat @sample_fmt, int @channels, int @nb_samples) => av_audio_fifo_alloc(@sample_fmt, @channels, @nb_samples);
        vectors.av_audio_fifo_drain = (AVAudioFifo* @af, int @nb_samples) => av_audio_fifo_drain(@af, @nb_samples);
        vectors.av_audio_fifo_free = (AVAudioFifo* @af) => av_audio_fifo_free(@af);
        vectors.av_audio_fifo_peek = (AVAudioFifo* @af, void** @data, int @nb_samples) => av_audio_fifo_peek(@af, @data, @nb_samples);
        vectors.av_audio_fifo_peek_at = (AVAudioFifo* @af, void** @data, int @nb_samples, int @offset) => av_audio_fifo_peek_at(@af, @data, @nb_samples, @offset);
        vectors.av_audio_fifo_read = (AVAudioFifo* @af, void** @data, int @nb_samples) => av_audio_fifo_read(@af, @data, @nb_samples);
        vectors.av_audio_fifo_realloc = (AVAudioFifo* @af, int @nb_samples) => av_audio_fifo_realloc(@af, @nb_samples);
        vectors.av_audio_fifo_reset = (AVAudioFifo* @af) => av_audio_fifo_reset(@af);
        vectors.av_audio_fifo_size = (AVAudioFifo* @af) => av_audio_fifo_size(@af);
        vectors.av_audio_fifo_space = (AVAudioFifo* @af) => av_audio_fifo_space(@af);
        vectors.av_audio_fifo_write = (AVAudioFifo* @af, void** @data, int @nb_samples) => av_audio_fifo_write(@af, @data, @nb_samples);
        vectors.av_bprint_channel_layout = (AVBPrint* @bp, int @nb_channels, ulong @channel_layout) => av_bprint_channel_layout(@bp, @nb_channels, @channel_layout);
        vectors.av_buffer_alloc = (ulong @size) => av_buffer_alloc(@size);
        vectors.av_buffer_allocz = (ulong @size) => av_buffer_allocz(@size);
        vectors.av_buffer_create = (byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags) => av_buffer_create(@data, @size, @free, @opaque, @flags);
        vectors.av_buffer_default_free = (void* @opaque, byte* @data) => av_buffer_default_free(@opaque, @data);
        vectors.av_buffer_get_opaque = (AVBufferRef* @buf) => av_buffer_get_opaque(@buf);
        vectors.av_buffer_get_ref_count = (AVBufferRef* @buf) => av_buffer_get_ref_count(@buf);
        vectors.av_buffer_is_writable = (AVBufferRef* @buf) => av_buffer_is_writable(@buf);
        vectors.av_buffer_make_writable = (AVBufferRef** @buf) => av_buffer_make_writable(@buf);
        vectors.av_buffer_pool_buffer_get_opaque = (AVBufferRef* @ref) => av_buffer_pool_buffer_get_opaque(@ref);
        vectors.av_buffer_pool_get = (AVBufferPool* @pool) => av_buffer_pool_get(@pool);
        vectors.av_buffer_pool_init = (ulong @size, av_buffer_pool_init_alloc_func @alloc) => av_buffer_pool_init(@size, @alloc);
        vectors.av_buffer_pool_init2 = (ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free) => av_buffer_pool_init2(@size, @opaque, @alloc, @pool_free);
        vectors.av_buffer_pool_uninit = (AVBufferPool** @pool) => av_buffer_pool_uninit(@pool);
        vectors.av_buffer_realloc = (AVBufferRef** @buf, ulong @size) => av_buffer_realloc(@buf, @size);
        vectors.av_buffer_ref = (AVBufferRef* @buf) => av_buffer_ref(@buf);
        vectors.av_buffer_replace = (AVBufferRef** @dst, AVBufferRef* @src) => av_buffer_replace(@dst, @src);
        vectors.av_buffer_unref = (AVBufferRef** @buf) => av_buffer_unref(@buf);
        vectors.av_buffersink_get_ch_layout = (AVFilterContext* @ctx, AVChannelLayout* @ch_layout) => av_buffersink_get_ch_layout(@ctx, @ch_layout);
        vectors.av_buffersink_get_channel_layout = (AVFilterContext* @ctx) => av_buffersink_get_channel_layout(@ctx);
        vectors.av_buffersink_get_channels = (AVFilterContext* @ctx) => av_buffersink_get_channels(@ctx);
        vectors.av_buffersink_get_format = (AVFilterContext* @ctx) => av_buffersink_get_format(@ctx);
        vectors.av_buffersink_get_frame = (AVFilterContext* @ctx, AVFrame* @frame) => av_buffersink_get_frame(@ctx, @frame);
        vectors.av_buffersink_get_frame_flags = (AVFilterContext* @ctx, AVFrame* @frame, int @flags) => av_buffersink_get_frame_flags(@ctx, @frame, @flags);
        vectors.av_buffersink_get_frame_rate = (AVFilterContext* @ctx) => av_buffersink_get_frame_rate(@ctx);
        vectors.av_buffersink_get_h = (AVFilterContext* @ctx) => av_buffersink_get_h(@ctx);
        vectors.av_buffersink_get_hw_frames_ctx = (AVFilterContext* @ctx) => av_buffersink_get_hw_frames_ctx(@ctx);
        vectors.av_buffersink_get_sample_aspect_ratio = (AVFilterContext* @ctx) => av_buffersink_get_sample_aspect_ratio(@ctx);
        vectors.av_buffersink_get_sample_rate = (AVFilterContext* @ctx) => av_buffersink_get_sample_rate(@ctx);
        vectors.av_buffersink_get_samples = (AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples) => av_buffersink_get_samples(@ctx, @frame, @nb_samples);
        vectors.av_buffersink_get_time_base = (AVFilterContext* @ctx) => av_buffersink_get_time_base(@ctx);
        vectors.av_buffersink_get_type = (AVFilterContext* @ctx) => av_buffersink_get_type(@ctx);
        vectors.av_buffersink_get_w = (AVFilterContext* @ctx) => av_buffersink_get_w(@ctx);
        vectors.av_buffersink_params_alloc = () => av_buffersink_params_alloc();
        vectors.av_buffersink_set_frame_size = (AVFilterContext* @ctx, uint @frame_size) => av_buffersink_set_frame_size(@ctx, @frame_size);
        vectors.av_buffersrc_add_frame = (AVFilterContext* @ctx, AVFrame* @frame) => av_buffersrc_add_frame(@ctx, @frame);
        vectors.av_buffersrc_add_frame_flags = (AVFilterContext* @buffer_src, AVFrame* @frame, int @flags) => av_buffersrc_add_frame_flags(@buffer_src, @frame, @flags);
        vectors.av_buffersrc_close = (AVFilterContext* @ctx, long @pts, uint @flags) => av_buffersrc_close(@ctx, @pts, @flags);
        vectors.av_buffersrc_get_nb_failed_requests = (AVFilterContext* @buffer_src) => av_buffersrc_get_nb_failed_requests(@buffer_src);
        vectors.av_buffersrc_parameters_alloc = () => av_buffersrc_parameters_alloc();
        vectors.av_buffersrc_parameters_set = (AVFilterContext* @ctx, AVBufferSrcParameters* @param) => av_buffersrc_parameters_set(@ctx, @param);
        vectors.av_buffersrc_write_frame = (AVFilterContext* @ctx, AVFrame* @frame) => av_buffersrc_write_frame(@ctx, @frame);
        vectors.av_calloc = (ulong @nmemb, ulong @size) => av_calloc(@nmemb, @size);
        vectors.av_channel_description = (byte* @buf, ulong @buf_size, AVChannel @channel) => av_channel_description(@buf, @buf_size, @channel);
        vectors.av_channel_description_bprint = (AVBPrint* @bp, AVChannel @channel_id) => av_channel_description_bprint(@bp, @channel_id);
        vectors.av_channel_from_string = (string @name) => av_channel_from_string(@name);
        vectors.av_channel_layout_channel_from_index = (AVChannelLayout* @channel_layout, uint @idx) => av_channel_layout_channel_from_index(@channel_layout, @idx);
        vectors.av_channel_layout_channel_from_string = (AVChannelLayout* @channel_layout, string @name) => av_channel_layout_channel_from_string(@channel_layout, @name);
        vectors.av_channel_layout_check = (AVChannelLayout* @channel_layout) => av_channel_layout_check(@channel_layout);
        vectors.av_channel_layout_compare = (AVChannelLayout* @chl, AVChannelLayout* @chl1) => av_channel_layout_compare(@chl, @chl1);
        vectors.av_channel_layout_copy = (AVChannelLayout* @dst, AVChannelLayout* @src) => av_channel_layout_copy(@dst, @src);
        vectors.av_channel_layout_default = (AVChannelLayout* @ch_layout, int @nb_channels) => av_channel_layout_default(@ch_layout, @nb_channels);
        vectors.av_channel_layout_describe = (AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size) => av_channel_layout_describe(@channel_layout, @buf, @buf_size);
        vectors.av_channel_layout_describe_bprint = (AVChannelLayout* @channel_layout, AVBPrint* @bp) => av_channel_layout_describe_bprint(@channel_layout, @bp);
        vectors.av_channel_layout_extract_channel = (ulong @channel_layout, int @index) => av_channel_layout_extract_channel(@channel_layout, @index);
        vectors.av_channel_layout_from_mask = (AVChannelLayout* @channel_layout, ulong @mask) => av_channel_layout_from_mask(@channel_layout, @mask);
        vectors.av_channel_layout_from_string = (AVChannelLayout* @channel_layout, string @str) => av_channel_layout_from_string(@channel_layout, @str);
        vectors.av_channel_layout_index_from_channel = (AVChannelLayout* @channel_layout, AVChannel @channel) => av_channel_layout_index_from_channel(@channel_layout, @channel);
        vectors.av_channel_layout_index_from_string = (AVChannelLayout* @channel_layout, string @name) => av_channel_layout_index_from_string(@channel_layout, @name);
        vectors.av_channel_layout_standard = (void** @opaque) => av_channel_layout_standard(@opaque);
        vectors.av_channel_layout_subset = (AVChannelLayout* @channel_layout, ulong @mask) => av_channel_layout_subset(@channel_layout, @mask);
        vectors.av_channel_layout_uninit = (AVChannelLayout* @channel_layout) => av_channel_layout_uninit(@channel_layout);
        vectors.av_channel_name = (byte* @buf, ulong @buf_size, AVChannel @channel) => av_channel_name(@buf, @buf_size, @channel);
        vectors.av_channel_name_bprint = (AVBPrint* @bp, AVChannel @channel_id) => av_channel_name_bprint(@bp, @channel_id);
        vectors.av_chroma_location_from_name = (string @name) => av_chroma_location_from_name(@name);
        vectors.av_chroma_location_name = (AVChromaLocation @location) => av_chroma_location_name(@location);
        vectors.av_codec_get_id = (AVCodecTag** @tags, uint @tag) => av_codec_get_id(@tags, @tag);
        vectors.av_codec_get_tag = (AVCodecTag** @tags, AVCodecID @id) => av_codec_get_tag(@tags, @id);
        vectors.av_codec_get_tag2 = (AVCodecTag** @tags, AVCodecID @id, uint* @tag) => av_codec_get_tag2(@tags, @id, @tag);
        vectors.av_codec_is_decoder = (AVCodec* @codec) => av_codec_is_decoder(@codec);
        vectors.av_codec_is_encoder = (AVCodec* @codec) => av_codec_is_encoder(@codec);
        vectors.av_codec_iterate = (void** @opaque) => av_codec_iterate(@opaque);
        vectors.av_color_primaries_from_name = (string @name) => av_color_primaries_from_name(@name);
        vectors.av_color_primaries_name = (AVColorPrimaries @primaries) => av_color_primaries_name(@primaries);
        vectors.av_color_range_from_name = (string @name) => av_color_range_from_name(@name);
        vectors.av_color_range_name = (AVColorRange @range) => av_color_range_name(@range);
        vectors.av_color_space_from_name = (string @name) => av_color_space_from_name(@name);
        vectors.av_color_space_name = (AVColorSpace @space) => av_color_space_name(@space);
        vectors.av_color_transfer_from_name = (string @name) => av_color_transfer_from_name(@name);
        vectors.av_color_transfer_name = (AVColorTransferCharacteristic @transfer) => av_color_transfer_name(@transfer);
        vectors.av_compare_mod = (ulong @a, ulong @b, ulong @mod) => av_compare_mod(@a, @b, @mod);
        vectors.av_compare_ts = (long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b) => av_compare_ts(@ts_a, @tb_a, @ts_b, @tb_b);
        vectors.av_content_light_metadata_alloc = (ulong* @size) => av_content_light_metadata_alloc(@size);
        vectors.av_content_light_metadata_create_side_data = (AVFrame* @frame) => av_content_light_metadata_create_side_data(@frame);
        vectors.av_cpb_properties_alloc = (ulong* @size) => av_cpb_properties_alloc(@size);
        vectors.av_cpu_count = () => av_cpu_count();
        vectors.av_cpu_force_count = (int @count) => av_cpu_force_count(@count);
        vectors.av_cpu_max_align = () => av_cpu_max_align();
        vectors.av_d2q = (double @d, int @max) => av_d2q(@d, @max);
        vectors.av_d3d11va_alloc_context = () => av_d3d11va_alloc_context();
        vectors.av_default_get_category = (void* @ptr) => av_default_get_category(@ptr);
        vectors.av_default_item_name = (void* @ctx) => av_default_item_name(@ctx);
        vectors.av_demuxer_iterate = (void** @opaque) => av_demuxer_iterate(@opaque);
        vectors.av_dict_copy = (AVDictionary** @dst, AVDictionary* @src, int @flags) => av_dict_copy(@dst, @src, @flags);
        vectors.av_dict_count = (AVDictionary* @m) => av_dict_count(@m);
        vectors.av_dict_free = (AVDictionary** @m) => av_dict_free(@m);
        vectors.av_dict_get = (AVDictionary* @m, string @key, AVDictionaryEntry* @prev, int @flags) => av_dict_get(@m, @key, @prev, @flags);
        vectors.av_dict_get_string = (AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep) => av_dict_get_string(@m, @buffer, @key_val_sep, @pairs_sep);
        vectors.av_dict_parse_string = (AVDictionary** @pm, string @str, string @key_val_sep, string @pairs_sep, int @flags) => av_dict_parse_string(@pm, @str, @key_val_sep, @pairs_sep, @flags);
        vectors.av_dict_set = (AVDictionary** @pm, string @key, string @value, int @flags) => av_dict_set(@pm, @key, @value, @flags);
        vectors.av_dict_set_int = (AVDictionary** @pm, string @key, long @value, int @flags) => av_dict_set_int(@pm, @key, @value, @flags);
        vectors.av_disposition_from_string = (string @disp) => av_disposition_from_string(@disp);
        vectors.av_disposition_to_string = (int @disposition) => av_disposition_to_string(@disposition);
        vectors.av_div_q = (AVRational @b, AVRational @c) => av_div_q(@b, @c);
        vectors.av_dump_format = (AVFormatContext* @ic, int @index, string @url, int @is_output) => av_dump_format(@ic, @index, @url, @is_output);
        vectors.av_dynamic_hdr_plus_alloc = (ulong* @size) => av_dynamic_hdr_plus_alloc(@size);
        vectors.av_dynamic_hdr_plus_create_side_data = (AVFrame* @frame) => av_dynamic_hdr_plus_create_side_data(@frame);
        vectors.av_dynarray_add = (void* @tab_ptr, int* @nb_ptr, void* @elem) => av_dynarray_add(@tab_ptr, @nb_ptr, @elem);
        vectors.av_dynarray_add_nofree = (void* @tab_ptr, int* @nb_ptr, void* @elem) => av_dynarray_add_nofree(@tab_ptr, @nb_ptr, @elem);
        vectors.av_dynarray2_add = (void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data) => av_dynarray2_add(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
        vectors.av_fast_malloc = (void* @ptr, uint* @size, ulong @min_size) => av_fast_malloc(@ptr, @size, @min_size);
        vectors.av_fast_mallocz = (void* @ptr, uint* @size, ulong @min_size) => av_fast_mallocz(@ptr, @size, @min_size);
        vectors.av_fast_padded_malloc = (void* @ptr, uint* @size, ulong @min_size) => av_fast_padded_malloc(@ptr, @size, @min_size);
        vectors.av_fast_padded_mallocz = (void* @ptr, uint* @size, ulong @min_size) => av_fast_padded_mallocz(@ptr, @size, @min_size);
        vectors.av_fast_realloc = (void* @ptr, uint* @size, ulong @min_size) => av_fast_realloc(@ptr, @size, @min_size);
        vectors.av_file_map = (string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx) => av_file_map(@filename, @bufptr, @size, @log_offset, @log_ctx);
        vectors.av_file_unmap = (byte* @bufptr, ulong @size) => av_file_unmap(@bufptr, @size);
        vectors.av_filename_number_test = (string @filename) => av_filename_number_test(@filename);
        vectors.av_filter_iterate = (void** @opaque) => av_filter_iterate(@opaque);
        vectors.av_find_best_pix_fmt_of_2 = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) => av_find_best_pix_fmt_of_2(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        vectors.av_find_best_stream = (AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags) => av_find_best_stream(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
        vectors.av_find_default_stream_index = (AVFormatContext* @s) => av_find_default_stream_index(@s);
        vectors.av_find_input_format = (string @short_name) => av_find_input_format(@short_name);
        vectors.av_find_nearest_q_idx = (AVRational @q, AVRational* @q_list) => av_find_nearest_q_idx(@q, @q_list);
        vectors.av_find_program_from_stream = (AVFormatContext* @ic, AVProgram* @last, int @s) => av_find_program_from_stream(@ic, @last, @s);
        vectors.av_fmt_ctx_get_duration_estimation_method = (AVFormatContext* @ctx) => av_fmt_ctx_get_duration_estimation_method(@ctx);
        vectors.av_fopen_utf8 = (string @path, string @mode) => av_fopen_utf8(@path, @mode);
        vectors.av_force_cpu_flags = (int @flags) => av_force_cpu_flags(@flags);
        vectors.av_format_inject_global_side_data = (AVFormatContext* @s) => av_format_inject_global_side_data(@s);
        vectors.av_fourcc_make_string = (byte* @buf, uint @fourcc) => av_fourcc_make_string(@buf, @fourcc);
        vectors.av_frame_alloc = () => av_frame_alloc();
        vectors.av_frame_apply_cropping = (AVFrame* @frame, int @flags) => av_frame_apply_cropping(@frame, @flags);
        vectors.av_frame_clone = (AVFrame* @src) => av_frame_clone(@src);
        vectors.av_frame_copy = (AVFrame* @dst, AVFrame* @src) => av_frame_copy(@dst, @src);
        vectors.av_frame_copy_props = (AVFrame* @dst, AVFrame* @src) => av_frame_copy_props(@dst, @src);
        vectors.av_frame_free = (AVFrame** @frame) => av_frame_free(@frame);
        vectors.av_frame_get_buffer = (AVFrame* @frame, int @align) => av_frame_get_buffer(@frame, @align);
        vectors.av_frame_get_plane_buffer = (AVFrame* @frame, int @plane) => av_frame_get_plane_buffer(@frame, @plane);
        vectors.av_frame_get_side_data = (AVFrame* @frame, AVFrameSideDataType @type) => av_frame_get_side_data(@frame, @type);
        vectors.av_frame_is_writable = (AVFrame* @frame) => av_frame_is_writable(@frame);
        vectors.av_frame_make_writable = (AVFrame* @frame) => av_frame_make_writable(@frame);
        vectors.av_frame_move_ref = (AVFrame* @dst, AVFrame* @src) => av_frame_move_ref(@dst, @src);
        vectors.av_frame_new_side_data = (AVFrame* @frame, AVFrameSideDataType @type, ulong @size) => av_frame_new_side_data(@frame, @type, @size);
        vectors.av_frame_new_side_data_from_buf = (AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf) => av_frame_new_side_data_from_buf(@frame, @type, @buf);
        vectors.av_frame_ref = (AVFrame* @dst, AVFrame* @src) => av_frame_ref(@dst, @src);
        vectors.av_frame_remove_side_data = (AVFrame* @frame, AVFrameSideDataType @type) => av_frame_remove_side_data(@frame, @type);
        vectors.av_frame_side_data_name = (AVFrameSideDataType @type) => av_frame_side_data_name(@type);
        vectors.av_frame_unref = (AVFrame* @frame) => av_frame_unref(@frame);
        vectors.av_free = (void* @ptr) => av_free(@ptr);
        vectors.av_freep = (void* @ptr) => av_freep(@ptr);
        vectors.av_gcd = (long @a, long @b) => av_gcd(@a, @b);
        vectors.av_gcd_q = (AVRational @a, AVRational @b, int @max_den, AVRational @def) => av_gcd_q(@a, @b, @max_den, @def);
        vectors.av_get_alt_sample_fmt = (AVSampleFormat @sample_fmt, int @planar) => av_get_alt_sample_fmt(@sample_fmt, @planar);
        vectors.av_get_audio_frame_duration = (AVCodecContext* @avctx, int @frame_bytes) => av_get_audio_frame_duration(@avctx, @frame_bytes);
        vectors.av_get_audio_frame_duration2 = (AVCodecParameters* @par, int @frame_bytes) => av_get_audio_frame_duration2(@par, @frame_bytes);
        vectors.av_get_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) => av_get_bits_per_pixel(@pixdesc);
        vectors.av_get_bits_per_sample = (AVCodecID @codec_id) => av_get_bits_per_sample(@codec_id);
        vectors.av_get_bytes_per_sample = (AVSampleFormat @sample_fmt) => av_get_bytes_per_sample(@sample_fmt);
        vectors.av_get_channel_description = (ulong @channel) => av_get_channel_description(@channel);
        vectors.av_get_channel_layout = (string @name) => av_get_channel_layout(@name);
        vectors.av_get_channel_layout_channel_index = (ulong @channel_layout, ulong @channel) => av_get_channel_layout_channel_index(@channel_layout, @channel);
        vectors.av_get_channel_layout_nb_channels = (ulong @channel_layout) => av_get_channel_layout_nb_channels(@channel_layout);
        vectors.av_get_channel_layout_string = (byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout) => av_get_channel_layout_string(@buf, @buf_size, @nb_channels, @channel_layout);
        vectors.av_get_channel_name = (ulong @channel) => av_get_channel_name(@channel);
        vectors.av_get_colorspace_name = (AVColorSpace @val) => av_get_colorspace_name(@val);
        vectors.av_get_cpu_flags = () => av_get_cpu_flags();
        vectors.av_get_default_channel_layout = (int @nb_channels) => av_get_default_channel_layout(@nb_channels);
        vectors.av_get_exact_bits_per_sample = (AVCodecID @codec_id) => av_get_exact_bits_per_sample(@codec_id);
        vectors.av_get_extended_channel_layout = (string @name, ulong* @channel_layout, int* @nb_channels) => av_get_extended_channel_layout(@name, @channel_layout, @nb_channels);
        vectors.av_get_frame_filename = (byte* @buf, int @buf_size, string @path, int @number) => av_get_frame_filename(@buf, @buf_size, @path, @number);
        vectors.av_get_frame_filename2 = (byte* @buf, int @buf_size, string @path, int @number, int @flags) => av_get_frame_filename2(@buf, @buf_size, @path, @number, @flags);
        vectors.av_get_media_type_string = (AVMediaType @media_type) => av_get_media_type_string(@media_type);
        vectors.av_get_output_timestamp = (AVFormatContext* @s, int @stream, long* @dts, long* @wall) => av_get_output_timestamp(@s, @stream, @dts, @wall);
        vectors.av_get_packed_sample_fmt = (AVSampleFormat @sample_fmt) => av_get_packed_sample_fmt(@sample_fmt);
        vectors.av_get_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) => av_get_packet(@s, @pkt, @size);
        vectors.av_get_padded_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) => av_get_padded_bits_per_pixel(@pixdesc);
        vectors.av_get_pcm_codec = (AVSampleFormat @fmt, int @be) => av_get_pcm_codec(@fmt, @be);
        vectors.av_get_picture_type_char = (AVPictureType @pict_type) => av_get_picture_type_char(@pict_type);
        vectors.av_get_pix_fmt = (string @name) => av_get_pix_fmt(@name);
        vectors.av_get_pix_fmt_loss = (AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha) => av_get_pix_fmt_loss(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        vectors.av_get_pix_fmt_name = (AVPixelFormat @pix_fmt) => av_get_pix_fmt_name(@pix_fmt);
        vectors.av_get_pix_fmt_string = (byte* @buf, int @buf_size, AVPixelFormat @pix_fmt) => av_get_pix_fmt_string(@buf, @buf_size, @pix_fmt);
        vectors.av_get_planar_sample_fmt = (AVSampleFormat @sample_fmt) => av_get_planar_sample_fmt(@sample_fmt);
        vectors.av_get_profile_name = (AVCodec* @codec, int @profile) => av_get_profile_name(@codec, @profile);
        vectors.av_get_sample_fmt = (string @name) => av_get_sample_fmt(@name);
        vectors.av_get_sample_fmt_name = (AVSampleFormat @sample_fmt) => av_get_sample_fmt_name(@sample_fmt);
        vectors.av_get_sample_fmt_string = (byte* @buf, int @buf_size, AVSampleFormat @sample_fmt) => av_get_sample_fmt_string(@buf, @buf_size, @sample_fmt);
        vectors.av_get_standard_channel_layout = (uint @index, ulong* @layout, byte** @name) => av_get_standard_channel_layout(@index, @layout, @name);
        vectors.av_get_time_base_q = () => av_get_time_base_q();
        vectors.av_gettime = () => av_gettime();
        vectors.av_gettime_relative = () => av_gettime_relative();
        vectors.av_gettime_relative_is_monotonic = () => av_gettime_relative_is_monotonic();
        vectors.av_grow_packet = (AVPacket* @pkt, int @grow_by) => av_grow_packet(@pkt, @grow_by);
        vectors.av_guess_codec = (AVOutputFormat* @fmt, string @short_name, string @filename, string @mime_type, AVMediaType @type) => av_guess_codec(@fmt, @short_name, @filename, @mime_type, @type);
        vectors.av_guess_format = (string @short_name, string @filename, string @mime_type) => av_guess_format(@short_name, @filename, @mime_type);
        vectors.av_guess_frame_rate = (AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame) => av_guess_frame_rate(@ctx, @stream, @frame);
        vectors.av_guess_sample_aspect_ratio = (AVFormatContext* @format, AVStream* @stream, AVFrame* @frame) => av_guess_sample_aspect_ratio(@format, @stream, @frame);
        vectors.av_hex_dump = (_iobuf* @f, byte* @buf, int @size) => av_hex_dump(@f, @buf, @size);
        vectors.av_hex_dump_log = (void* @avcl, int @level, byte* @buf, int @size) => av_hex_dump_log(@avcl, @level, @buf, @size);
        vectors.av_hwdevice_ctx_alloc = (AVHWDeviceType @type) => av_hwdevice_ctx_alloc(@type);
        vectors.av_hwdevice_ctx_create = (AVBufferRef** @device_ctx, AVHWDeviceType @type, string @device, AVDictionary* @opts, int @flags) => av_hwdevice_ctx_create(@device_ctx, @type, @device, @opts, @flags);
        vectors.av_hwdevice_ctx_create_derived = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags) => av_hwdevice_ctx_create_derived(@dst_ctx, @type, @src_ctx, @flags);
        vectors.av_hwdevice_ctx_create_derived_opts = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags) => av_hwdevice_ctx_create_derived_opts(@dst_ctx, @type, @src_ctx, @options, @flags);
        vectors.av_hwdevice_ctx_init = (AVBufferRef* @ref) => av_hwdevice_ctx_init(@ref);
        vectors.av_hwdevice_find_type_by_name = (string @name) => av_hwdevice_find_type_by_name(@name);
        vectors.av_hwdevice_get_hwframe_constraints = (AVBufferRef* @ref, void* @hwconfig) => av_hwdevice_get_hwframe_constraints(@ref, @hwconfig);
        vectors.av_hwdevice_get_type_name = (AVHWDeviceType @type) => av_hwdevice_get_type_name(@type);
        vectors.av_hwdevice_hwconfig_alloc = (AVBufferRef* @device_ctx) => av_hwdevice_hwconfig_alloc(@device_ctx);
        vectors.av_hwdevice_iterate_types = (AVHWDeviceType @prev) => av_hwdevice_iterate_types(@prev);
        vectors.av_hwframe_constraints_free = (AVHWFramesConstraints** @constraints) => av_hwframe_constraints_free(@constraints);
        vectors.av_hwframe_ctx_alloc = (AVBufferRef* @device_ctx) => av_hwframe_ctx_alloc(@device_ctx);
        vectors.av_hwframe_ctx_create_derived = (AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags) => av_hwframe_ctx_create_derived(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        vectors.av_hwframe_ctx_init = (AVBufferRef* @ref) => av_hwframe_ctx_init(@ref);
        vectors.av_hwframe_get_buffer = (AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags) => av_hwframe_get_buffer(@hwframe_ctx, @frame, @flags);
        vectors.av_hwframe_map = (AVFrame* @dst, AVFrame* @src, int @flags) => av_hwframe_map(@dst, @src, @flags);
        vectors.av_hwframe_transfer_data = (AVFrame* @dst, AVFrame* @src, int @flags) => av_hwframe_transfer_data(@dst, @src, @flags);
        vectors.av_hwframe_transfer_get_formats = (AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags) => av_hwframe_transfer_get_formats(@hwframe_ctx, @dir, @formats, @flags);
        vectors.av_image_alloc = (ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align) => av_image_alloc(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
        vectors.av_image_check_sar = (uint @w, uint @h, AVRational @sar) => av_image_check_sar(@w, @h, @sar);
        vectors.av_image_check_size = (uint @w, uint @h, int @log_offset, void* @log_ctx) => av_image_check_size(@w, @h, @log_offset, @log_ctx);
        vectors.av_image_check_size2 = (uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx) => av_image_check_size2(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
        vectors.av_image_copy = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) => av_image_copy(ref @dst_data, ref @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
        vectors.av_image_copy_plane = (byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height) => av_image_copy_plane(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        vectors.av_image_copy_plane_uc_from = (byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height) => av_image_copy_plane_uc_from(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        vectors.av_image_copy_to_buffer = (byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align) => av_image_copy_to_buffer(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
        vectors.av_image_copy_uc_from = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) => av_image_copy_uc_from(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
        vectors.av_image_fill_arrays = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align) => av_image_fill_arrays(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
        vectors.av_image_fill_black = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height) => av_image_fill_black(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
        vectors.av_image_fill_linesizes = (ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width) => av_image_fill_linesizes(ref @linesizes, @pix_fmt, @width);
        vectors.av_image_fill_max_pixsteps = (ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc) => av_image_fill_max_pixsteps(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
        vectors.av_image_fill_plane_sizes = (ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, long_array4 @linesizes) => av_image_fill_plane_sizes(ref @size, @pix_fmt, @height, @linesizes);
        vectors.av_image_fill_pointers = (ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes) => av_image_fill_pointers(ref @data, @pix_fmt, @height, @ptr, @linesizes);
        vectors.av_image_get_buffer_size = (AVPixelFormat @pix_fmt, int @width, int @height, int @align) => av_image_get_buffer_size(@pix_fmt, @width, @height, @align);
        vectors.av_image_get_linesize = (AVPixelFormat @pix_fmt, int @width, int @plane) => av_image_get_linesize(@pix_fmt, @width, @plane);
        vectors.av_index_search_timestamp = (AVStream* @st, long @timestamp, int @flags) => av_index_search_timestamp(@st, @timestamp, @flags);
        vectors.av_init_packet = (AVPacket* @pkt) => av_init_packet(@pkt);
        vectors.av_input_audio_device_next = (AVInputFormat* @d) => av_input_audio_device_next(@d);
        vectors.av_input_video_device_next = (AVInputFormat* @d) => av_input_video_device_next(@d);
        vectors.av_int_list_length_for_size = (uint @elsize, void* @list, ulong @term) => av_int_list_length_for_size(@elsize, @list, @term);
        vectors.av_interleaved_write_frame = (AVFormatContext* @s, AVPacket* @pkt) => av_interleaved_write_frame(@s, @pkt);
        vectors.av_interleaved_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) => av_interleaved_write_uncoded_frame(@s, @stream_index, @frame);
        vectors.av_log = (void* @avcl, int @level, string @fmt) => av_log(@avcl, @level, @fmt);
        vectors.av_log_default_callback = (void* @avcl, int @level, string @fmt, byte* @vl) => av_log_default_callback(@avcl, @level, @fmt, @vl);
        vectors.av_log_format_line = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) => av_log_format_line(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        vectors.av_log_format_line2 = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) => av_log_format_line2(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        vectors.av_log_get_flags = () => av_log_get_flags();
        vectors.av_log_get_level = () => av_log_get_level();
        vectors.av_log_once = (void* @avcl, int @initial_level, int @subsequent_level, int* @state, string @fmt) => av_log_once(@avcl, @initial_level, @subsequent_level, @state, @fmt);
        vectors.av_log_set_callback = (av_log_set_callback_callback_func @callback) => av_log_set_callback(@callback);
        vectors.av_log_set_flags = (int @arg) => av_log_set_flags(@arg);
        vectors.av_log_set_level = (int @level) => av_log_set_level(@level);
        vectors.av_log2 = (uint @v) => av_log2(@v);
        vectors.av_log2_16bit = (uint @v) => av_log2_16bit(@v);
        vectors.av_malloc = (ulong @size) => av_malloc(@size);
        vectors.av_malloc_array = (ulong @nmemb, ulong @size) => av_malloc_array(@nmemb, @size);
        vectors.av_mallocz = (ulong @size) => av_mallocz(@size);
        vectors.av_mallocz_array = (ulong @nmemb, ulong @size) => av_mallocz_array(@nmemb, @size);
        vectors.av_mastering_display_metadata_alloc = () => av_mastering_display_metadata_alloc();
        vectors.av_mastering_display_metadata_create_side_data = (AVFrame* @frame) => av_mastering_display_metadata_create_side_data(@frame);
        vectors.av_match_ext = (string @filename, string @extensions) => av_match_ext(@filename, @extensions);
        vectors.av_max_alloc = (ulong @max) => av_max_alloc(@max);
        vectors.av_memcpy_backptr = (byte* @dst, int @back, int @cnt) => av_memcpy_backptr(@dst, @back, @cnt);
        vectors.av_memdup = (void* @p, ulong @size) => av_memdup(@p, @size);
        vectors.av_mul_q = (AVRational @b, AVRational @c) => av_mul_q(@b, @c);
        vectors.av_muxer_iterate = (void** @opaque) => av_muxer_iterate(@opaque);
        vectors.av_nearer_q = (AVRational @q, AVRational @q1, AVRational @q2) => av_nearer_q(@q, @q1, @q2);
        vectors.av_new_packet = (AVPacket* @pkt, int @size) => av_new_packet(@pkt, @size);
        vectors.av_new_program = (AVFormatContext* @s, int @id) => av_new_program(@s, @id);
        vectors.av_opt_child_class_iterate = (AVClass* @parent, void** @iter) => av_opt_child_class_iterate(@parent, @iter);
        vectors.av_opt_child_next = (void* @obj, void* @prev) => av_opt_child_next(@obj, @prev);
        vectors.av_opt_copy = (void* @dest, void* @src) => av_opt_copy(@dest, @src);
        vectors.av_opt_eval_double = (void* @obj, AVOption* @o, string @val, double* @double_out) => av_opt_eval_double(@obj, @o, @val, @double_out);
        vectors.av_opt_eval_flags = (void* @obj, AVOption* @o, string @val, int* @flags_out) => av_opt_eval_flags(@obj, @o, @val, @flags_out);
        vectors.av_opt_eval_float = (void* @obj, AVOption* @o, string @val, float* @float_out) => av_opt_eval_float(@obj, @o, @val, @float_out);
        vectors.av_opt_eval_int = (void* @obj, AVOption* @o, string @val, int* @int_out) => av_opt_eval_int(@obj, @o, @val, @int_out);
        vectors.av_opt_eval_int64 = (void* @obj, AVOption* @o, string @val, long* @int64_out) => av_opt_eval_int64(@obj, @o, @val, @int64_out);
        vectors.av_opt_eval_q = (void* @obj, AVOption* @o, string @val, AVRational* @q_out) => av_opt_eval_q(@obj, @o, @val, @q_out);
        vectors.av_opt_find = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags) => av_opt_find(@obj, @name, @unit, @opt_flags, @search_flags);
        vectors.av_opt_find2 = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags, void** @target_obj) => av_opt_find2(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
        vectors.av_opt_flag_is_set = (void* @obj, string @field_name, string @flag_name) => av_opt_flag_is_set(@obj, @field_name, @flag_name);
        vectors.av_opt_free = (void* @obj) => av_opt_free(@obj);
        vectors.av_opt_freep_ranges = (AVOptionRanges** @ranges) => av_opt_freep_ranges(@ranges);
        vectors.av_opt_get = (void* @obj, string @name, int @search_flags, byte** @out_val) => av_opt_get(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_get_channel_layout = (void* @obj, string @name, int @search_flags, long* @ch_layout) => av_opt_get_channel_layout(@obj, @name, @search_flags, @ch_layout);
        vectors.av_opt_get_chlayout = (void* @obj, string @name, int @search_flags, AVChannelLayout* @layout) => av_opt_get_chlayout(@obj, @name, @search_flags, @layout);
        vectors.av_opt_get_dict_val = (void* @obj, string @name, int @search_flags, AVDictionary** @out_val) => av_opt_get_dict_val(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_get_double = (void* @obj, string @name, int @search_flags, double* @out_val) => av_opt_get_double(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_get_image_size = (void* @obj, string @name, int @search_flags, int* @w_out, int* @h_out) => av_opt_get_image_size(@obj, @name, @search_flags, @w_out, @h_out);
        vectors.av_opt_get_int = (void* @obj, string @name, int @search_flags, long* @out_val) => av_opt_get_int(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_get_key_value = (byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, byte** @rval) => av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        vectors.av_opt_get_pixel_fmt = (void* @obj, string @name, int @search_flags, AVPixelFormat* @out_fmt) => av_opt_get_pixel_fmt(@obj, @name, @search_flags, @out_fmt);
        vectors.av_opt_get_q = (void* @obj, string @name, int @search_flags, AVRational* @out_val) => av_opt_get_q(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_get_sample_fmt = (void* @obj, string @name, int @search_flags, AVSampleFormat* @out_fmt) => av_opt_get_sample_fmt(@obj, @name, @search_flags, @out_fmt);
        vectors.av_opt_get_video_rate = (void* @obj, string @name, int @search_flags, AVRational* @out_val) => av_opt_get_video_rate(@obj, @name, @search_flags, @out_val);
        vectors.av_opt_is_set_to_default = (void* @obj, AVOption* @o) => av_opt_is_set_to_default(@obj, @o);
        vectors.av_opt_is_set_to_default_by_name = (void* @obj, string @name, int @search_flags) => av_opt_is_set_to_default_by_name(@obj, @name, @search_flags);
        vectors.av_opt_next = (void* @obj, AVOption* @prev) => av_opt_next(@obj, @prev);
        vectors.av_opt_ptr = (AVClass* @avclass, void* @obj, string @name) => av_opt_ptr(@avclass, @obj, @name);
        vectors.av_opt_query_ranges = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) => av_opt_query_ranges(@p0, @obj, @key, @flags);
        vectors.av_opt_query_ranges_default = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) => av_opt_query_ranges_default(@p0, @obj, @key, @flags);
        vectors.av_opt_serialize = (void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep) => av_opt_serialize(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
        vectors.av_opt_set = (void* @obj, string @name, string @val, int @search_flags) => av_opt_set(@obj, @name, @val, @search_flags);
        vectors.av_opt_set_bin = (void* @obj, string @name, byte* @val, int @size, int @search_flags) => av_opt_set_bin(@obj, @name, @val, @size, @search_flags);
        vectors.av_opt_set_channel_layout = (void* @obj, string @name, long @ch_layout, int @search_flags) => av_opt_set_channel_layout(@obj, @name, @ch_layout, @search_flags);
        vectors.av_opt_set_chlayout = (void* @obj, string @name, AVChannelLayout* @layout, int @search_flags) => av_opt_set_chlayout(@obj, @name, @layout, @search_flags);
        vectors.av_opt_set_defaults = (void* @s) => av_opt_set_defaults(@s);
        vectors.av_opt_set_defaults2 = (void* @s, int @mask, int @flags) => av_opt_set_defaults2(@s, @mask, @flags);
        vectors.av_opt_set_dict = (void* @obj, AVDictionary** @options) => av_opt_set_dict(@obj, @options);
        vectors.av_opt_set_dict_val = (void* @obj, string @name, AVDictionary* @val, int @search_flags) => av_opt_set_dict_val(@obj, @name, @val, @search_flags);
        vectors.av_opt_set_dict2 = (void* @obj, AVDictionary** @options, int @search_flags) => av_opt_set_dict2(@obj, @options, @search_flags);
        vectors.av_opt_set_double = (void* @obj, string @name, double @val, int @search_flags) => av_opt_set_double(@obj, @name, @val, @search_flags);
        vectors.av_opt_set_from_string = (void* @ctx, string @opts, byte** @shorthand, string @key_val_sep, string @pairs_sep) => av_opt_set_from_string(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
        vectors.av_opt_set_image_size = (void* @obj, string @name, int @w, int @h, int @search_flags) => av_opt_set_image_size(@obj, @name, @w, @h, @search_flags);
        vectors.av_opt_set_int = (void* @obj, string @name, long @val, int @search_flags) => av_opt_set_int(@obj, @name, @val, @search_flags);
        vectors.av_opt_set_pixel_fmt = (void* @obj, string @name, AVPixelFormat @fmt, int @search_flags) => av_opt_set_pixel_fmt(@obj, @name, @fmt, @search_flags);
        vectors.av_opt_set_q = (void* @obj, string @name, AVRational @val, int @search_flags) => av_opt_set_q(@obj, @name, @val, @search_flags);
        vectors.av_opt_set_sample_fmt = (void* @obj, string @name, AVSampleFormat @fmt, int @search_flags) => av_opt_set_sample_fmt(@obj, @name, @fmt, @search_flags);
        vectors.av_opt_set_video_rate = (void* @obj, string @name, AVRational @val, int @search_flags) => av_opt_set_video_rate(@obj, @name, @val, @search_flags);
        vectors.av_opt_show2 = (void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags) => av_opt_show2(@obj, @av_log_obj, @req_flags, @rej_flags);
        vectors.av_output_audio_device_next = (AVOutputFormat* @d) => av_output_audio_device_next(@d);
        vectors.av_output_video_device_next = (AVOutputFormat* @d) => av_output_video_device_next(@d);
        vectors.av_packet_add_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size) => av_packet_add_side_data(@pkt, @type, @data, @size);
        vectors.av_packet_alloc = () => av_packet_alloc();
        vectors.av_packet_clone = (AVPacket* @src) => av_packet_clone(@src);
        vectors.av_packet_copy_props = (AVPacket* @dst, AVPacket* @src) => av_packet_copy_props(@dst, @src);
        vectors.av_packet_free = (AVPacket** @pkt) => av_packet_free(@pkt);
        vectors.av_packet_free_side_data = (AVPacket* @pkt) => av_packet_free_side_data(@pkt);
        vectors.av_packet_from_data = (AVPacket* @pkt, byte* @data, int @size) => av_packet_from_data(@pkt, @data, @size);
        vectors.av_packet_get_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size) => av_packet_get_side_data(@pkt, @type, @size);
        vectors.av_packet_make_refcounted = (AVPacket* @pkt) => av_packet_make_refcounted(@pkt);
        vectors.av_packet_make_writable = (AVPacket* @pkt) => av_packet_make_writable(@pkt);
        vectors.av_packet_move_ref = (AVPacket* @dst, AVPacket* @src) => av_packet_move_ref(@dst, @src);
        vectors.av_packet_new_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) => av_packet_new_side_data(@pkt, @type, @size);
        vectors.av_packet_pack_dictionary = (AVDictionary* @dict, ulong* @size) => av_packet_pack_dictionary(@dict, @size);
        vectors.av_packet_ref = (AVPacket* @dst, AVPacket* @src) => av_packet_ref(@dst, @src);
        vectors.av_packet_rescale_ts = (AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst) => av_packet_rescale_ts(@pkt, @tb_src, @tb_dst);
        vectors.av_packet_shrink_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) => av_packet_shrink_side_data(@pkt, @type, @size);
        vectors.av_packet_side_data_name = (AVPacketSideDataType @type) => av_packet_side_data_name(@type);
        vectors.av_packet_unpack_dictionary = (byte* @data, ulong @size, AVDictionary** @dict) => av_packet_unpack_dictionary(@data, @size, @dict);
        vectors.av_packet_unref = (AVPacket* @pkt) => av_packet_unref(@pkt);
        vectors.av_parse_cpu_caps = (uint* @flags, string @s) => av_parse_cpu_caps(@flags, @s);
        vectors.av_parser_close = (AVCodecParserContext* @s) => av_parser_close(@s);
        vectors.av_parser_init = (int @codec_id) => av_parser_init(@codec_id);
        vectors.av_parser_iterate = (void** @opaque) => av_parser_iterate(@opaque);
        vectors.av_parser_parse2 = (AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos) => av_parser_parse2(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        vectors.av_pix_fmt_count_planes = (AVPixelFormat @pix_fmt) => av_pix_fmt_count_planes(@pix_fmt);
        vectors.av_pix_fmt_desc_get = (AVPixelFormat @pix_fmt) => av_pix_fmt_desc_get(@pix_fmt);
        vectors.av_pix_fmt_desc_get_id = (AVPixFmtDescriptor* @desc) => av_pix_fmt_desc_get_id(@desc);
        vectors.av_pix_fmt_desc_next = (AVPixFmtDescriptor* @prev) => av_pix_fmt_desc_next(@prev);
        vectors.av_pix_fmt_get_chroma_sub_sample = (AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift) => av_pix_fmt_get_chroma_sub_sample(@pix_fmt, @h_shift, @v_shift);
        vectors.av_pix_fmt_swap_endianness = (AVPixelFormat @pix_fmt) => av_pix_fmt_swap_endianness(@pix_fmt);
        vectors.av_pkt_dump_log2 = (void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st) => av_pkt_dump_log2(@avcl, @level, @pkt, @dump_payload, @st);
        vectors.av_pkt_dump2 = (_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st) => av_pkt_dump2(@f, @pkt, @dump_payload, @st);
        vectors.av_probe_input_buffer = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) => av_probe_input_buffer(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        vectors.av_probe_input_buffer2 = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) => av_probe_input_buffer2(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        vectors.av_probe_input_format = (AVProbeData* @pd, int @is_opened) => av_probe_input_format(@pd, @is_opened);
        vectors.av_probe_input_format2 = (AVProbeData* @pd, int @is_opened, int* @score_max) => av_probe_input_format2(@pd, @is_opened, @score_max);
        vectors.av_probe_input_format3 = (AVProbeData* @pd, int @is_opened, int* @score_ret) => av_probe_input_format3(@pd, @is_opened, @score_ret);
        vectors.av_program_add_stream_index = (AVFormatContext* @ac, int @progid, uint @idx) => av_program_add_stream_index(@ac, @progid, @idx);
        vectors.av_q2intfloat = (AVRational @q) => av_q2intfloat(@q);
        vectors.av_read_frame = (AVFormatContext* @s, AVPacket* @pkt) => av_read_frame(@s, @pkt);
        vectors.av_read_image_line = (ushort* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component) => av_read_image_line(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
        vectors.av_read_image_line2 = (void* @dst, byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size) => av_read_image_line2(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component, @dst_element_size);
        vectors.av_read_pause = (AVFormatContext* @s) => av_read_pause(@s);
        vectors.av_read_play = (AVFormatContext* @s) => av_read_play(@s);
        vectors.av_realloc = (void* @ptr, ulong @size) => av_realloc(@ptr, @size);
        vectors.av_realloc_array = (void* @ptr, ulong @nmemb, ulong @size) => av_realloc_array(@ptr, @nmemb, @size);
        vectors.av_realloc_f = (void* @ptr, ulong @nelem, ulong @elsize) => av_realloc_f(@ptr, @nelem, @elsize);
        vectors.av_reallocp = (void* @ptr, ulong @size) => av_reallocp(@ptr, @size);
        vectors.av_reallocp_array = (void* @ptr, ulong @nmemb, ulong @size) => av_reallocp_array(@ptr, @nmemb, @size);
        vectors.av_reduce = (int* @dst_num, int* @dst_den, long @num, long @den, long @max) => av_reduce(@dst_num, @dst_den, @num, @den, @max);
        vectors.av_rescale = (long @a, long @b, long @c) => av_rescale(@a, @b, @c);
        vectors.av_rescale_delta = (AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb) => av_rescale_delta(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
        vectors.av_rescale_q = (long @a, AVRational @bq, AVRational @cq) => av_rescale_q(@a, @bq, @cq);
        vectors.av_rescale_q_rnd = (long @a, AVRational @bq, AVRational @cq, AVRounding @rnd) => av_rescale_q_rnd(@a, @bq, @cq, @rnd);
        vectors.av_rescale_rnd = (long @a, long @b, long @c, AVRounding @rnd) => av_rescale_rnd(@a, @b, @c, @rnd);
        vectors.av_sample_fmt_is_planar = (AVSampleFormat @sample_fmt) => av_sample_fmt_is_planar(@sample_fmt);
        vectors.av_samples_alloc = (byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) => av_samples_alloc(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        vectors.av_samples_alloc_array_and_samples = (byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) => av_samples_alloc_array_and_samples(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        vectors.av_samples_copy = (byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) => av_samples_copy(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        vectors.av_samples_fill_arrays = (byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) => av_samples_fill_arrays(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        vectors.av_samples_get_buffer_size = (int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) => av_samples_get_buffer_size(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        vectors.av_samples_set_silence = (byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) => av_samples_set_silence(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
        vectors.av_sdp_create = (AVFormatContext** @ac, int @n_files, byte* @buf, int @size) => av_sdp_create(@ac, @n_files, @buf, @size);
        vectors.av_seek_frame = (AVFormatContext* @s, int @stream_index, long @timestamp, int @flags) => av_seek_frame(@s, @stream_index, @timestamp, @flags);
        vectors.av_set_options_string = (void* @ctx, string @opts, string @key_val_sep, string @pairs_sep) => av_set_options_string(@ctx, @opts, @key_val_sep, @pairs_sep);
        vectors.av_shrink_packet = (AVPacket* @pkt, int @size) => av_shrink_packet(@pkt, @size);
        vectors.av_size_mult = (ulong @a, ulong @b, ulong* @r) => av_size_mult(@a, @b, @r);
        vectors.av_strdup = (string @s) => av_strdup(@s);
        vectors.av_stream_add_side_data = (AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size) => av_stream_add_side_data(@st, @type, @data, @size);
        vectors.av_stream_get_class = () => av_stream_get_class();
        vectors.av_stream_get_codec_timebase = (AVStream* @st) => av_stream_get_codec_timebase(@st);
        vectors.av_stream_get_end_pts = (AVStream* @st) => av_stream_get_end_pts(@st);
        vectors.av_stream_get_parser = (AVStream* @s) => av_stream_get_parser(@s);
        vectors.av_stream_get_side_data = (AVStream* @stream, AVPacketSideDataType @type, ulong* @size) => av_stream_get_side_data(@stream, @type, @size);
        vectors.av_stream_new_side_data = (AVStream* @stream, AVPacketSideDataType @type, ulong @size) => av_stream_new_side_data(@stream, @type, @size);
        vectors.av_strerror = (int @errnum, byte* @errbuf, ulong @errbuf_size) => av_strerror(@errnum, @errbuf, @errbuf_size);
        vectors.av_strndup = (string @s, ulong @len) => av_strndup(@s, @len);
        vectors.av_sub_q = (AVRational @b, AVRational @c) => av_sub_q(@b, @c);
        vectors.av_tempfile = (string @prefix, byte** @filename, int @log_offset, void* @log_ctx) => av_tempfile(@prefix, @filename, @log_offset, @log_ctx);
        vectors.av_timecode_adjust_ntsc_framenum2 = (int @framenum, int @fps) => av_timecode_adjust_ntsc_framenum2(@framenum, @fps);
        vectors.av_timecode_check_frame_rate = (AVRational @rate) => av_timecode_check_frame_rate(@rate);
        vectors.av_timecode_get_smpte = (AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff) => av_timecode_get_smpte(@rate, @drop, @hh, @mm, @ss, @ff);
        vectors.av_timecode_get_smpte_from_framenum = (AVTimecode* @tc, int @framenum) => av_timecode_get_smpte_from_framenum(@tc, @framenum);
        vectors.av_timecode_init = (AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx) => av_timecode_init(@tc, @rate, @flags, @frame_start, @log_ctx);
        vectors.av_timecode_init_from_components = (AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx) => av_timecode_init_from_components(@tc, @rate, @flags, @hh, @mm, @ss, @ff, @log_ctx);
        vectors.av_timecode_init_from_string = (AVTimecode* @tc, AVRational @rate, string @str, void* @log_ctx) => av_timecode_init_from_string(@tc, @rate, @str, @log_ctx);
        vectors.av_timecode_make_mpeg_tc_string = (byte* @buf, uint @tc25bit) => av_timecode_make_mpeg_tc_string(@buf, @tc25bit);
        vectors.av_timecode_make_smpte_tc_string = (byte* @buf, uint @tcsmpte, int @prevent_df) => av_timecode_make_smpte_tc_string(@buf, @tcsmpte, @prevent_df);
        vectors.av_timecode_make_smpte_tc_string2 = (byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field) => av_timecode_make_smpte_tc_string2(@buf, @rate, @tcsmpte, @prevent_df, @skip_field);
        vectors.av_timecode_make_string = (AVTimecode* @tc, byte* @buf, int @framenum) => av_timecode_make_string(@tc, @buf, @framenum);
        vectors.av_tree_destroy = (AVTreeNode* @t) => av_tree_destroy(@t);
        vectors.av_tree_enumerate = (AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu) => av_tree_enumerate(@t, @opaque, @cmp, @enu);
        vectors.av_tree_find = (AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next) => av_tree_find(@root, @key, @cmp, ref @next);
        vectors.av_tree_insert = (AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next) => av_tree_insert(@rootp, @key, @cmp, @next);
        vectors.av_tree_node_alloc = () => av_tree_node_alloc();
        vectors.av_url_split = (byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, string @url) => av_url_split(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
        vectors.av_usleep = (uint @usec) => av_usleep(@usec);
        vectors.av_version_info = () => av_version_info();
        vectors.av_vlog = (void* @avcl, int @level, string @fmt, byte* @vl) => av_vlog(@avcl, @level, @fmt, @vl);
        vectors.av_write_frame = (AVFormatContext* @s, AVPacket* @pkt) => av_write_frame(@s, @pkt);
        vectors.av_write_image_line = (ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w) => av_write_image_line(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
        vectors.av_write_image_line2 = (void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size) => av_write_image_line2(@src, ref @data, @linesize, @desc, @x, @y, @c, @w, @src_element_size);
        vectors.av_write_trailer = (AVFormatContext* @s) => av_write_trailer(@s);
        vectors.av_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) => av_write_uncoded_frame(@s, @stream_index, @frame);
        vectors.av_write_uncoded_frame_query = (AVFormatContext* @s, int @stream_index) => av_write_uncoded_frame_query(@s, @stream_index);
        vectors.av_xiphlacing = (byte* @s, uint @v) => av_xiphlacing(@s, @v);
        vectors.avcodec_align_dimensions = (AVCodecContext* @s, int* @width, int* @height) => avcodec_align_dimensions(@s, @width, @height);
        vectors.avcodec_align_dimensions2 = (AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align) => avcodec_align_dimensions2(@s, @width, @height, ref @linesize_align);
        vectors.avcodec_alloc_context3 = (AVCodec* @codec) => avcodec_alloc_context3(@codec);
        vectors.avcodec_chroma_pos_to_enum = (int @xpos, int @ypos) => avcodec_chroma_pos_to_enum(@xpos, @ypos);
        vectors.avcodec_close = (AVCodecContext* @avctx) => avcodec_close(@avctx);
        vectors.avcodec_configuration = () => avcodec_configuration();
        vectors.avcodec_decode_subtitle2 = (AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt) => avcodec_decode_subtitle2(@avctx, @sub, @got_sub_ptr, @avpkt);
        vectors.avcodec_default_execute = (AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size) => avcodec_default_execute(@c, @func, @arg, @ret, @count, @size);
        vectors.avcodec_default_execute2 = (AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count) => avcodec_default_execute2(@c, @func, @arg, @ret, @count);
        vectors.avcodec_default_get_buffer2 = (AVCodecContext* @s, AVFrame* @frame, int @flags) => avcodec_default_get_buffer2(@s, @frame, @flags);
        vectors.avcodec_default_get_encode_buffer = (AVCodecContext* @s, AVPacket* @pkt, int @flags) => avcodec_default_get_encode_buffer(@s, @pkt, @flags);
        vectors.avcodec_default_get_format = (AVCodecContext* @s, AVPixelFormat* @fmt) => avcodec_default_get_format(@s, @fmt);
        vectors.avcodec_descriptor_get = (AVCodecID @id) => avcodec_descriptor_get(@id);
        vectors.avcodec_descriptor_get_by_name = (string @name) => avcodec_descriptor_get_by_name(@name);
        vectors.avcodec_descriptor_next = (AVCodecDescriptor* @prev) => avcodec_descriptor_next(@prev);
        vectors.avcodec_encode_subtitle = (AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub) => avcodec_encode_subtitle(@avctx, @buf, @buf_size, @sub);
        vectors.avcodec_enum_to_chroma_pos = (int* @xpos, int* @ypos, AVChromaLocation @pos) => avcodec_enum_to_chroma_pos(@xpos, @ypos, @pos);
        vectors.avcodec_fill_audio_frame = (AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align) => avcodec_fill_audio_frame(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
        vectors.avcodec_find_best_pix_fmt_of_list = (AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) => avcodec_find_best_pix_fmt_of_list(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
        vectors.avcodec_find_decoder = (AVCodecID @id) => avcodec_find_decoder(@id);
        vectors.avcodec_find_decoder_by_name = (string @name) => avcodec_find_decoder_by_name(@name);
        vectors.avcodec_find_encoder = (AVCodecID @id) => avcodec_find_encoder(@id);
        vectors.avcodec_find_encoder_by_name = (string @name) => avcodec_find_encoder_by_name(@name);
        vectors.avcodec_flush_buffers = (AVCodecContext* @avctx) => avcodec_flush_buffers(@avctx);
        vectors.avcodec_free_context = (AVCodecContext** @avctx) => avcodec_free_context(@avctx);
        vectors.avcodec_get_class = () => avcodec_get_class();
        vectors.avcodec_get_frame_class = () => avcodec_get_frame_class();
        vectors.avcodec_get_hw_config = (AVCodec* @codec, int @index) => avcodec_get_hw_config(@codec, @index);
        vectors.avcodec_get_hw_frames_parameters = (AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref) => avcodec_get_hw_frames_parameters(@avctx, @device_ref, @hw_pix_fmt, @out_frames_ref);
        vectors.avcodec_get_name = (AVCodecID @id) => avcodec_get_name(@id);
        vectors.avcodec_get_subtitle_rect_class = () => avcodec_get_subtitle_rect_class();
        vectors.avcodec_get_type = (AVCodecID @codec_id) => avcodec_get_type(@codec_id);
        vectors.avcodec_is_open = (AVCodecContext* @s) => avcodec_is_open(@s);
        vectors.avcodec_license = () => avcodec_license();
        vectors.avcodec_open2 = (AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options) => avcodec_open2(@avctx, @codec, @options);
        vectors.avcodec_parameters_alloc = () => avcodec_parameters_alloc();
        vectors.avcodec_parameters_copy = (AVCodecParameters* @dst, AVCodecParameters* @src) => avcodec_parameters_copy(@dst, @src);
        vectors.avcodec_parameters_free = (AVCodecParameters** @par) => avcodec_parameters_free(@par);
        vectors.avcodec_parameters_from_context = (AVCodecParameters* @par, AVCodecContext* @codec) => avcodec_parameters_from_context(@par, @codec);
        vectors.avcodec_parameters_to_context = (AVCodecContext* @codec, AVCodecParameters* @par) => avcodec_parameters_to_context(@codec, @par);
        vectors.avcodec_pix_fmt_to_codec_tag = (AVPixelFormat @pix_fmt) => avcodec_pix_fmt_to_codec_tag(@pix_fmt);
        vectors.avcodec_profile_name = (AVCodecID @codec_id, int @profile) => avcodec_profile_name(@codec_id, @profile);
        vectors.avcodec_receive_frame = (AVCodecContext* @avctx, AVFrame* @frame) => avcodec_receive_frame(@avctx, @frame);
        vectors.avcodec_receive_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) => avcodec_receive_packet(@avctx, @avpkt);
        vectors.avcodec_send_frame = (AVCodecContext* @avctx, AVFrame* @frame) => avcodec_send_frame(@avctx, @frame);
        vectors.avcodec_send_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) => avcodec_send_packet(@avctx, @avpkt);
        vectors.avcodec_string = (byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode) => avcodec_string(@buf, @buf_size, @enc, @encode);
        vectors.avcodec_version = () => avcodec_version();
        vectors.avdevice_app_to_dev_control_message = (AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size) => avdevice_app_to_dev_control_message(@s, @type, @data, @data_size);
        vectors.avdevice_capabilities_create = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options) => avdevice_capabilities_create(@caps, @s, @device_options);
        vectors.avdevice_capabilities_free = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s) => avdevice_capabilities_free(@caps, @s);
        vectors.avdevice_configuration = () => avdevice_configuration();
        vectors.avdevice_dev_to_app_control_message = (AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size) => avdevice_dev_to_app_control_message(@s, @type, @data, @data_size);
        vectors.avdevice_free_list_devices = (AVDeviceInfoList** @device_list) => avdevice_free_list_devices(@device_list);
        vectors.avdevice_license = () => avdevice_license();
        vectors.avdevice_list_devices = (AVFormatContext* @s, AVDeviceInfoList** @device_list) => avdevice_list_devices(@s, @device_list);
        vectors.avdevice_list_input_sources = (AVInputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) => avdevice_list_input_sources(@device, @device_name, @device_options, @device_list);
        vectors.avdevice_list_output_sinks = (AVOutputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) => avdevice_list_output_sinks(@device, @device_name, @device_options, @device_list);
        vectors.avdevice_register_all = () => avdevice_register_all();
        vectors.avdevice_version = () => avdevice_version();
        vectors.avfilter_config_links = (AVFilterContext* @filter) => avfilter_config_links(@filter);
        vectors.avfilter_configuration = () => avfilter_configuration();
        vectors.avfilter_filter_pad_count = (AVFilter* @filter, int @is_output) => avfilter_filter_pad_count(@filter, @is_output);
        vectors.avfilter_free = (AVFilterContext* @filter) => avfilter_free(@filter);
        vectors.avfilter_get_by_name = (string @name) => avfilter_get_by_name(@name);
        vectors.avfilter_get_class = () => avfilter_get_class();
        vectors.avfilter_graph_alloc = () => avfilter_graph_alloc();
        vectors.avfilter_graph_alloc_filter = (AVFilterGraph* @graph, AVFilter* @filter, string @name) => avfilter_graph_alloc_filter(@graph, @filter, @name);
        vectors.avfilter_graph_config = (AVFilterGraph* @graphctx, void* @log_ctx) => avfilter_graph_config(@graphctx, @log_ctx);
        vectors.avfilter_graph_create_filter = (AVFilterContext** @filt_ctx, AVFilter* @filt, string @name, string @args, void* @opaque, AVFilterGraph* @graph_ctx) => avfilter_graph_create_filter(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
        vectors.avfilter_graph_dump = (AVFilterGraph* @graph, string @options) => avfilter_graph_dump(@graph, @options);
        vectors.avfilter_graph_free = (AVFilterGraph** @graph) => avfilter_graph_free(@graph);
        vectors.avfilter_graph_get_filter = (AVFilterGraph* @graph, string @name) => avfilter_graph_get_filter(@graph, @name);
        vectors.avfilter_graph_parse = (AVFilterGraph* @graph, string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx) => avfilter_graph_parse(@graph, @filters, @inputs, @outputs, @log_ctx);
        vectors.avfilter_graph_parse_ptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx) => avfilter_graph_parse_ptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        vectors.avfilter_graph_parse2 = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs) => avfilter_graph_parse2(@graph, @filters, @inputs, @outputs);
        vectors.avfilter_graph_queue_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, int @flags, double @ts) => avfilter_graph_queue_command(@graph, @target, @cmd, @arg, @flags, @ts);
        vectors.avfilter_graph_request_oldest = (AVFilterGraph* @graph) => avfilter_graph_request_oldest(@graph);
        vectors.avfilter_graph_send_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, byte* @res, int @res_len, int @flags) => avfilter_graph_send_command(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
        vectors.avfilter_graph_set_auto_convert = (AVFilterGraph* @graph, uint @flags) => avfilter_graph_set_auto_convert(@graph, @flags);
        vectors.avfilter_init_dict = (AVFilterContext* @ctx, AVDictionary** @options) => avfilter_init_dict(@ctx, @options);
        vectors.avfilter_init_str = (AVFilterContext* @ctx, string @args) => avfilter_init_str(@ctx, @args);
        vectors.avfilter_inout_alloc = () => avfilter_inout_alloc();
        vectors.avfilter_inout_free = (AVFilterInOut** @inout) => avfilter_inout_free(@inout);
        vectors.avfilter_insert_filter = (AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx) => avfilter_insert_filter(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
        vectors.avfilter_license = () => avfilter_license();
        vectors.avfilter_link = (AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad) => avfilter_link(@src, @srcpad, @dst, @dstpad);
        vectors.avfilter_link_free = (AVFilterLink** @link) => avfilter_link_free(@link);
        vectors.avfilter_pad_count = (AVFilterPad* @pads) => avfilter_pad_count(@pads);
        vectors.avfilter_pad_get_name = (AVFilterPad* @pads, int @pad_idx) => avfilter_pad_get_name(@pads, @pad_idx);
        vectors.avfilter_pad_get_type = (AVFilterPad* @pads, int @pad_idx) => avfilter_pad_get_type(@pads, @pad_idx);
        vectors.avfilter_process_command = (AVFilterContext* @filter, string @cmd, string @arg, byte* @res, int @res_len, int @flags) => avfilter_process_command(@filter, @cmd, @arg, @res, @res_len, @flags);
        vectors.avfilter_version = () => avfilter_version();
        vectors.avformat_alloc_context = () => avformat_alloc_context();
        vectors.avformat_alloc_output_context2 = (AVFormatContext** @ctx, AVOutputFormat* @oformat, string @format_name, string @filename) => avformat_alloc_output_context2(@ctx, @oformat, @format_name, @filename);
        vectors.avformat_close_input = (AVFormatContext** @s) => avformat_close_input(@s);
        vectors.avformat_configuration = () => avformat_configuration();
        vectors.avformat_find_stream_info = (AVFormatContext* @ic, AVDictionary** @options) => avformat_find_stream_info(@ic, @options);
        vectors.avformat_flush = (AVFormatContext* @s) => avformat_flush(@s);
        vectors.avformat_free_context = (AVFormatContext* @s) => avformat_free_context(@s);
        vectors.avformat_get_class = () => avformat_get_class();
        vectors.avformat_get_mov_audio_tags = () => avformat_get_mov_audio_tags();
        vectors.avformat_get_mov_video_tags = () => avformat_get_mov_video_tags();
        vectors.avformat_get_riff_audio_tags = () => avformat_get_riff_audio_tags();
        vectors.avformat_get_riff_video_tags = () => avformat_get_riff_video_tags();
        vectors.avformat_index_get_entries_count = (AVStream* @st) => avformat_index_get_entries_count(@st);
        vectors.avformat_index_get_entry = (AVStream* @st, int @idx) => avformat_index_get_entry(@st, @idx);
        vectors.avformat_index_get_entry_from_timestamp = (AVStream* @st, long @wanted_timestamp, int @flags) => avformat_index_get_entry_from_timestamp(@st, @wanted_timestamp, @flags);
        vectors.avformat_init_output = (AVFormatContext* @s, AVDictionary** @options) => avformat_init_output(@s, @options);
        vectors.avformat_license = () => avformat_license();
        vectors.avformat_match_stream_specifier = (AVFormatContext* @s, AVStream* @st, string @spec) => avformat_match_stream_specifier(@s, @st, @spec);
        vectors.avformat_network_deinit = () => avformat_network_deinit();
        vectors.avformat_network_init = () => avformat_network_init();
        vectors.avformat_new_stream = (AVFormatContext* @s, AVCodec* @c) => avformat_new_stream(@s, @c);
        vectors.avformat_open_input = (AVFormatContext** @ps, string @url, AVInputFormat* @fmt, AVDictionary** @options) => avformat_open_input(@ps, @url, @fmt, @options);
        vectors.avformat_query_codec = (AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance) => avformat_query_codec(@ofmt, @codec_id, @std_compliance);
        vectors.avformat_queue_attached_pictures = (AVFormatContext* @s) => avformat_queue_attached_pictures(@s);
        vectors.avformat_seek_file = (AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags) => avformat_seek_file(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
        vectors.avformat_transfer_internal_stream_timing_info = (AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb) => avformat_transfer_internal_stream_timing_info(@ofmt, @ost, @ist, @copy_tb);
        vectors.avformat_version = () => avformat_version();
        vectors.avformat_write_header = (AVFormatContext* @s, AVDictionary** @options) => avformat_write_header(@s, @options);
        vectors.avio_accept = (AVIOContext* @s, AVIOContext** @c) => avio_accept(@s, @c);
        vectors.avio_alloc_context = (byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek) => avio_alloc_context(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
        vectors.avio_check = (string @url, int @flags) => avio_check(@url, @flags);
        vectors.avio_close = (AVIOContext* @s) => avio_close(@s);
        vectors.avio_close_dir = (AVIODirContext** @s) => avio_close_dir(@s);
        vectors.avio_close_dyn_buf = (AVIOContext* @s, byte** @pbuffer) => avio_close_dyn_buf(@s, @pbuffer);
        vectors.avio_closep = (AVIOContext** @s) => avio_closep(@s);
        vectors.avio_context_free = (AVIOContext** @s) => avio_context_free(@s);
        vectors.avio_enum_protocols = (void** @opaque, int @output) => avio_enum_protocols(@opaque, @output);
        vectors.avio_feof = (AVIOContext* @s) => avio_feof(@s);
        vectors.avio_find_protocol_name = (string @url) => avio_find_protocol_name(@url);
        vectors.avio_flush = (AVIOContext* @s) => avio_flush(@s);
        vectors.avio_free_directory_entry = (AVIODirEntry** @entry) => avio_free_directory_entry(@entry);
        vectors.avio_get_dyn_buf = (AVIOContext* @s, byte** @pbuffer) => avio_get_dyn_buf(@s, @pbuffer);
        vectors.avio_get_str = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) => avio_get_str(@pb, @maxlen, @buf, @buflen);
        vectors.avio_get_str16be = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) => avio_get_str16be(@pb, @maxlen, @buf, @buflen);
        vectors.avio_get_str16le = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) => avio_get_str16le(@pb, @maxlen, @buf, @buflen);
        vectors.avio_handshake = (AVIOContext* @c) => avio_handshake(@c);
        vectors.avio_open = (AVIOContext** @s, string @url, int @flags) => avio_open(@s, @url, @flags);
        vectors.avio_open_dir = (AVIODirContext** @s, string @url, AVDictionary** @options) => avio_open_dir(@s, @url, @options);
        vectors.avio_open_dyn_buf = (AVIOContext** @s) => avio_open_dyn_buf(@s);
        vectors.avio_open2 = (AVIOContext** @s, string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options) => avio_open2(@s, @url, @flags, @int_cb, @options);
        vectors.avio_pause = (AVIOContext* @h, int @pause) => avio_pause(@h, @pause);
        vectors.avio_print_string_array = (AVIOContext* @s, byte*[] @strings) => avio_print_string_array(@s, @strings);
        vectors.avio_printf = (AVIOContext* @s, string @fmt) => avio_printf(@s, @fmt);
        vectors.avio_protocol_get_class = (string @name) => avio_protocol_get_class(@name);
        vectors.avio_put_str = (AVIOContext* @s, string @str) => avio_put_str(@s, @str);
        vectors.avio_put_str16be = (AVIOContext* @s, string @str) => avio_put_str16be(@s, @str);
        vectors.avio_put_str16le = (AVIOContext* @s, string @str) => avio_put_str16le(@s, @str);
        vectors.avio_r8 = (AVIOContext* @s) => avio_r8(@s);
        vectors.avio_rb16 = (AVIOContext* @s) => avio_rb16(@s);
        vectors.avio_rb24 = (AVIOContext* @s) => avio_rb24(@s);
        vectors.avio_rb32 = (AVIOContext* @s) => avio_rb32(@s);
        vectors.avio_rb64 = (AVIOContext* @s) => avio_rb64(@s);
        vectors.avio_read = (AVIOContext* @s, byte* @buf, int @size) => avio_read(@s, @buf, @size);
        vectors.avio_read_dir = (AVIODirContext* @s, AVIODirEntry** @next) => avio_read_dir(@s, @next);
        vectors.avio_read_partial = (AVIOContext* @s, byte* @buf, int @size) => avio_read_partial(@s, @buf, @size);
        vectors.avio_read_to_bprint = (AVIOContext* @h, AVBPrint* @pb, ulong @max_size) => avio_read_to_bprint(@h, @pb, @max_size);
        vectors.avio_rl16 = (AVIOContext* @s) => avio_rl16(@s);
        vectors.avio_rl24 = (AVIOContext* @s) => avio_rl24(@s);
        vectors.avio_rl32 = (AVIOContext* @s) => avio_rl32(@s);
        vectors.avio_rl64 = (AVIOContext* @s) => avio_rl64(@s);
        vectors.avio_seek = (AVIOContext* @s, long @offset, int @whence) => avio_seek(@s, @offset, @whence);
        vectors.avio_seek_time = (AVIOContext* @h, int @stream_index, long @timestamp, int @flags) => avio_seek_time(@h, @stream_index, @timestamp, @flags);
        vectors.avio_size = (AVIOContext* @s) => avio_size(@s);
        vectors.avio_skip = (AVIOContext* @s, long @offset) => avio_skip(@s, @offset);
        vectors.avio_vprintf = (AVIOContext* @s, string @fmt, byte* @ap) => avio_vprintf(@s, @fmt, @ap);
        vectors.avio_w8 = (AVIOContext* @s, int @b) => avio_w8(@s, @b);
        vectors.avio_wb16 = (AVIOContext* @s, uint @val) => avio_wb16(@s, @val);
        vectors.avio_wb24 = (AVIOContext* @s, uint @val) => avio_wb24(@s, @val);
        vectors.avio_wb32 = (AVIOContext* @s, uint @val) => avio_wb32(@s, @val);
        vectors.avio_wb64 = (AVIOContext* @s, ulong @val) => avio_wb64(@s, @val);
        vectors.avio_wl16 = (AVIOContext* @s, uint @val) => avio_wl16(@s, @val);
        vectors.avio_wl24 = (AVIOContext* @s, uint @val) => avio_wl24(@s, @val);
        vectors.avio_wl32 = (AVIOContext* @s, uint @val) => avio_wl32(@s, @val);
        vectors.avio_wl64 = (AVIOContext* @s, ulong @val) => avio_wl64(@s, @val);
        vectors.avio_write = (AVIOContext* @s, byte* @buf, int @size) => avio_write(@s, @buf, @size);
        vectors.avio_write_marker = (AVIOContext* @s, long @time, AVIODataMarkerType @type) => avio_write_marker(@s, @time, @type);
        vectors.avsubtitle_free = (AVSubtitle* @sub) => avsubtitle_free(@sub);
        vectors.avutil_configuration = () => avutil_configuration();
        vectors.avutil_license = () => avutil_license();
        vectors.avutil_version = () => avutil_version();
        vectors.postproc_configuration = () => postproc_configuration();
        vectors.postproc_license = () => postproc_license();
        vectors.postproc_version = () => postproc_version();
        vectors.pp_free_context = (void* @ppContext) => pp_free_context(@ppContext);
        vectors.pp_free_mode = (void* @mode) => pp_free_mode(@mode);
        vectors.pp_get_context = (int @width, int @height, int @flags) => pp_get_context(@width, @height, @flags);
        vectors.pp_get_mode_by_name_and_quality = (string @name, int @quality) => pp_get_mode_by_name_and_quality(@name, @quality);
        vectors.pp_postprocess = (byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type) => pp_postprocess(@src, @srcStride, ref @dst, @dstStride, @horizontalSize, @verticalSize, @QP_store, @QP_stride, @mode, @ppContext, @pict_type);
        vectors.swr_alloc = () => swr_alloc();
        vectors.swr_alloc_set_opts = (SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) => swr_alloc_set_opts(@s, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        vectors.swr_alloc_set_opts2 = (SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) => swr_alloc_set_opts2(@ps, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        vectors.swr_build_matrix = (ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx) => swr_build_matrix(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @rematrix_maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_ctx);
        vectors.swr_build_matrix2 = (AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context) => swr_build_matrix2(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_context);
        vectors.swr_close = (SwrContext* @s) => swr_close(@s);
        vectors.swr_config_frame = (SwrContext* @swr, AVFrame* @out, AVFrame* @in) => swr_config_frame(@swr, @out, @in);
        vectors.swr_convert = (SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count) => swr_convert(@s, @out, @out_count, @in, @in_count);
        vectors.swr_convert_frame = (SwrContext* @swr, AVFrame* @output, AVFrame* @input) => swr_convert_frame(@swr, @output, @input);
        vectors.swr_drop_output = (SwrContext* @s, int @count) => swr_drop_output(@s, @count);
        vectors.swr_free = (SwrContext** @s) => swr_free(@s);
        vectors.swr_get_class = () => swr_get_class();
        vectors.swr_get_delay = (SwrContext* @s, long @base) => swr_get_delay(@s, @base);
        vectors.swr_get_out_samples = (SwrContext* @s, int @in_samples) => swr_get_out_samples(@s, @in_samples);
        vectors.swr_init = (SwrContext* @s) => swr_init(@s);
        vectors.swr_inject_silence = (SwrContext* @s, int @count) => swr_inject_silence(@s, @count);
        vectors.swr_is_initialized = (SwrContext* @s) => swr_is_initialized(@s);
        vectors.swr_next_pts = (SwrContext* @s, long @pts) => swr_next_pts(@s, @pts);
        vectors.swr_set_channel_mapping = (SwrContext* @s, int* @channel_map) => swr_set_channel_mapping(@s, @channel_map);
        vectors.swr_set_compensation = (SwrContext* @s, int @sample_delta, int @compensation_distance) => swr_set_compensation(@s, @sample_delta, @compensation_distance);
        vectors.swr_set_matrix = (SwrContext* @s, double* @matrix, int @stride) => swr_set_matrix(@s, @matrix, @stride);
        vectors.swresample_configuration = () => swresample_configuration();
        vectors.swresample_license = () => swresample_license();
        vectors.swresample_version = () => swresample_version();
        vectors.sws_alloc_context = () => sws_alloc_context();
        vectors.sws_allocVec = (int @length) => sws_allocVec(@length);
        vectors.sws_convertPalette8ToPacked24 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) => sws_convertPalette8ToPacked24(@src, @dst, @num_pixels, @palette);
        vectors.sws_convertPalette8ToPacked32 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) => sws_convertPalette8ToPacked32(@src, @dst, @num_pixels, @palette);
        vectors.sws_frame_end = (SwsContext* @c) => sws_frame_end(@c);
        vectors.sws_frame_start = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) => sws_frame_start(@c, @dst, @src);
        vectors.sws_freeContext = (SwsContext* @swsContext) => sws_freeContext(@swsContext);
        vectors.sws_freeFilter = (SwsFilter* @filter) => sws_freeFilter(@filter);
        vectors.sws_freeVec = (SwsVector* @a) => sws_freeVec(@a);
        vectors.sws_get_class = () => sws_get_class();
        vectors.sws_getCachedContext = (SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) => sws_getCachedContext(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        vectors.sws_getCoefficients = (int @colorspace) => sws_getCoefficients(@colorspace);
        vectors.sws_getColorspaceDetails = (SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation) => sws_getColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        vectors.sws_getContext = (int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) => sws_getContext(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        vectors.sws_getDefaultFilter = (float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose) => sws_getDefaultFilter(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
        vectors.sws_getGaussianVec = (double @variance, double @quality) => sws_getGaussianVec(@variance, @quality);
        vectors.sws_init_context = (SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter) => sws_init_context(@sws_context, @srcFilter, @dstFilter);
        vectors.sws_isSupportedEndiannessConversion = (AVPixelFormat @pix_fmt) => sws_isSupportedEndiannessConversion(@pix_fmt);
        vectors.sws_isSupportedInput = (AVPixelFormat @pix_fmt) => sws_isSupportedInput(@pix_fmt);
        vectors.sws_isSupportedOutput = (AVPixelFormat @pix_fmt) => sws_isSupportedOutput(@pix_fmt);
        vectors.sws_normalizeVec = (SwsVector* @a, double @height) => sws_normalizeVec(@a, @height);
        vectors.sws_receive_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) => sws_receive_slice(@c, @slice_start, @slice_height);
        vectors.sws_receive_slice_alignment = (SwsContext* @c) => sws_receive_slice_alignment(@c);
        vectors.sws_scale = (SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride) => sws_scale(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
        vectors.sws_scale_frame = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) => sws_scale_frame(@c, @dst, @src);
        vectors.sws_scaleVec = (SwsVector* @a, double @scalar) => sws_scaleVec(@a, @scalar);
        vectors.sws_send_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) => sws_send_slice(@c, @slice_start, @slice_height);
        vectors.sws_setColorspaceDetails = (SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation) => sws_setColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        vectors.swscale_configuration = () => swscale_configuration();
        vectors.swscale_license = () => swscale_license();
        vectors.swscale_version = () => swscale_version();
    }
}
