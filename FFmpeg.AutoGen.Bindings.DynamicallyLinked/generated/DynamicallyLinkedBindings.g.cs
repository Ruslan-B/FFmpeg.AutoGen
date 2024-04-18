using System;
using System.Runtime.InteropServices;
using FFmpeg.AutoGen.Abstractions;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLinked;

public static unsafe partial class DynamicallyLinkedBindings
{
    /// <summary>Add an index entry into a sorted list. Update the entry if the list already contains it.</summary>
    /// <param name="timestamp">timestamp in the time base of the given stream</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
    
    /// <summary>Add two rationals.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b+c</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_add_q(AVRational @b, AVRational @c);
    
    /// <summary>Add a value to a timestamp.</summary>
    /// <param name="ts_tb">Input timestamp time base</param>
    /// <param name="ts">Input timestamp</param>
    /// <param name="inc_tb">Time base of `inc`</param>
    /// <param name="inc">Value to be added</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
    
    /// <summary>Read data and append it to the current content of the AVPacket. If pkt-&gt;size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
    /// <param name="s">associated IO context</param>
    /// <param name="pkt">packet</param>
    /// <param name="size">amount of data to read</param>
    /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise, previous data will not be lost even if an error occurs.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
    
    /// <summary>Allocate an AVAudioFifo.</summary>
    /// <param name="sample_fmt">sample format</param>
    /// <param name="channels">number of channels</param>
    /// <param name="nb_samples">initial allocation size, in samples</param>
    /// <returns>newly allocated AVAudioFifo, or NULL on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
    
    /// <summary>Drain data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to drain</param>
    /// <param name="nb_samples">number of samples to drain</param>
    /// <returns>0 if OK, or negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples);
    
    /// <summary>Free an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to free</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_audio_fifo_free(AVAudioFifo* @af);
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples);
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <param name="offset">offset from current read position</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
    
    /// <summary>Read data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to read</param>
    /// <returns>number of samples actually read, or negative AVERROR code on failure. The number of samples actually read will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples);
    
    /// <summary>Reallocate an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to reallocate</param>
    /// <param name="nb_samples">new allocation size, in samples</param>
    /// <returns>0 if OK, or negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples);
    
    /// <summary>Reset the AVAudioFifo buffer.</summary>
    /// <param name="af">AVAudioFifo to reset</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_audio_fifo_reset(AVAudioFifo* @af);
    
    /// <summary>Get the current number of samples in the AVAudioFifo available for reading.</summary>
    /// <param name="af">the AVAudioFifo to query</param>
    /// <returns>number of samples available for reading</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_size(AVAudioFifo* @af);
    
    /// <summary>Get the current number of samples in the AVAudioFifo available for writing.</summary>
    /// <param name="af">the AVAudioFifo to query</param>
    /// <returns>number of samples available for writing</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_space(AVAudioFifo* @af);
    
    /// <summary>Write data to an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to write to</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to write</param>
    /// <returns>number of samples actually written, or negative AVERROR code on failure. If successful, the number of samples actually written will always be nb_samples.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples);
    
    /// <summary>0th order modified bessel function of the first kind.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern double av_bessel_i0(double @x);
    
    /// <summary>Allocate a context for a given bitstream filter. The caller must fill in the context parameters as described in the documentation and then call av_bsf_init() before sending any data to the filter.</summary>
    /// <param name="filter">the filter for which to allocate an instance.</param>
    /// <param name="ctx">a pointer into which the pointer to the newly-allocated context will be written. It must be freed with av_bsf_free() after the filtering is done.</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_alloc(AVBitStreamFilter* @filter, AVBSFContext** @ctx);
    
    /// <summary>Reset the internal bitstream filter state. Should be called e.g. when seeking.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_bsf_flush(AVBSFContext* @ctx);
    
    /// <summary>Free a bitstream filter context and everything associated with it; write NULL into the supplied pointer.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_bsf_free(AVBSFContext** @ctx);
    
    /// <summary>Returns a bitstream filter with the specified name or NULL if no such bitstream filter exists.</summary>
    /// <returns>a bitstream filter with the specified name or NULL if no such bitstream filter exists.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBitStreamFilter* av_bsf_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Get the AVClass for AVBSFContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* av_bsf_get_class();
    
    /// <summary>Get null/pass-through bitstream filter.</summary>
    /// <param name="bsf">Pointer to be set to new instance of pass-through bitstream filter</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_get_null_filter(AVBSFContext** @bsf);
    
    /// <summary>Prepare the filter for use, after all the parameters and options have been set.</summary>
    /// <param name="ctx">a AVBSFContext previously allocated with av_bsf_alloc()</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_init(AVBSFContext* @ctx);
    
    /// <summary>Iterate over all registered bitstream filters.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered bitstream filter or NULL when the iteration is finished</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBitStreamFilter* av_bsf_iterate(void** @opaque);
    
    /// <summary>Allocate empty list of bitstream filters. The list must be later freed by av_bsf_list_free() or finalized by av_bsf_list_finalize().</summary>
    /// <returns>Pointer to on success, NULL in case of failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBSFList* av_bsf_list_alloc();
    
    /// <summary>Append bitstream filter to the list of bitstream filters.</summary>
    /// <param name="lst">List to append to</param>
    /// <param name="bsf">Filter context to be appended</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_list_append(AVBSFList* @lst, AVBSFContext* @bsf);
    
    /// <summary>Construct new bitstream filter context given it&apos;s name and options and append it to the list of bitstream filters.</summary>
    /// <param name="lst">List to append to</param>
    /// <param name="bsf_name">Name of the bitstream filter</param>
    /// <param name="options">Options for the bitstream filter, can be set to NULL</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_list_append2(AVBSFList* @lst,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @bsf_name, AVDictionary** @options);
    
    /// <summary>Finalize list of bitstream filters.</summary>
    /// <param name="lst">Filter list structure to be transformed</param>
    /// <param name="bsf">Pointer to be set to newly created structure representing the chain of bitstream filters</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_list_finalize(AVBSFList** @lst, AVBSFContext** @bsf);
    
    /// <summary>Free list of bitstream filters.</summary>
    /// <param name="lst">Pointer to pointer returned by av_bsf_list_alloc()</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_bsf_list_free(AVBSFList** @lst);
    
    /// <summary>Parse string describing list of bitstream filters and create single AVBSFContext describing the whole chain of bitstream filters. Resulting AVBSFContext can be treated as any other AVBSFContext freshly allocated by av_bsf_alloc().</summary>
    /// <param name="str">String describing chain of bitstream filters in format `bsf1[=opt1=val1:opt2=val2][,bsf2]`</param>
    /// <param name="bsf">Pointer to be set to newly created structure representing the chain of bitstream filters</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_list_parse_str(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, AVBSFContext** @bsf);
    
    /// <summary>Retrieve a filtered packet.</summary>
    /// <param name="ctx">an initialized AVBSFContext</param>
    /// <param name="pkt">this struct will be filled with the contents of the filtered packet. It is owned by the caller and must be freed using av_packet_unref() when it is no longer needed. This parameter should be &quot;clean&quot; (i.e. freshly allocated with av_packet_alloc() or unreffed with av_packet_unref()) when this function is called. If this function returns successfully, the contents of pkt will be completely overwritten by the returned data. On failure, pkt is not touched.</param>
    /// <returns>- 0 on success. - AVERROR(EAGAIN) if more packets need to be sent to the filter (using av_bsf_send_packet()) to get more output. - AVERROR_EOF if there will be no further output from the filter. - Another negative AVERROR value if an error occurs.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_receive_packet(AVBSFContext* @ctx, AVPacket* @pkt);
    
    /// <summary>Submit a packet for filtering.</summary>
    /// <param name="ctx">an initialized AVBSFContext</param>
    /// <param name="pkt">the packet to filter. The bitstream filter will take ownership of the packet and reset the contents of pkt. pkt is not touched if an error occurs. If pkt is empty (i.e. NULL, or pkt-&gt;data is NULL and pkt-&gt;side_data_elems zero), it signals the end of the stream (i.e. no more non-empty packets will be sent; sending more empty packets does nothing) and will cause the filter to output any packets it may have buffered internally.</param>
    /// <returns>- 0 on success. - AVERROR(EAGAIN) if packets need to be retrieved from the filter (using av_bsf_receive_packet()) before new input can be consumed. - Another negative AVERROR value if an error occurs.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_bsf_send_packet(AVBSFContext* @ctx, AVPacket* @pkt);
    
    /// <summary>Allocate an AVBuffer of the given size using av_malloc().</summary>
    /// <returns>an AVBufferRef of given size or NULL when out of memory</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffer_alloc(ulong @size);
    
    /// <summary>Same as av_buffer_alloc(), except the returned buffer will be initialized to zero.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffer_allocz(ulong @size);
    
    /// <summary>Create an AVBuffer from an existing array.</summary>
    /// <param name="data">data array</param>
    /// <param name="size">size of data in bytes</param>
    /// <param name="free">a callback for freeing this buffer&apos;s data</param>
    /// <param name="opaque">parameter to be got for processing or passed to free</param>
    /// <param name="flags">a combination of AV_BUFFER_FLAG_*</param>
    /// <returns>an AVBufferRef referring to data on success, NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffer_create(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags);
    
    /// <summary>Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_buffer_default_free(void* @opaque, byte* @data);
    
    /// <summary>Returns the opaque parameter set by av_buffer_create.</summary>
    /// <returns>the opaque parameter set by av_buffer_create.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_buffer_get_opaque(AVBufferRef* @buf);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffer_get_ref_count(AVBufferRef* @buf);
    
    /// <summary>Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</summary>
    /// <returns>1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffer_is_writable(AVBufferRef* @buf);
    
    /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
    /// <param name="buf">buffer reference to make writable. On success, buf is either left untouched, or it is unreferenced and a new writable AVBufferRef is written in its place. On failure, buf is left untouched.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffer_make_writable(AVBufferRef** @buf);
    
    /// <summary>Query the original opaque parameter of an allocated buffer in the pool.</summary>
    /// <param name="ref">a buffer reference to a buffer returned by av_buffer_pool_get.</param>
    /// <returns>the opaque parameter set by the buffer allocator function of the buffer pool.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref);
    
    /// <summary>Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads.</summary>
    /// <returns>a reference to the new buffer on success, NULL on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool);
    
    /// <summary>Allocate and initialize a buffer pool.</summary>
    /// <param name="size">size of each buffer in this pool</param>
    /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
    /// <returns>newly created buffer pool on success, NULL on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferPool* av_buffer_pool_init(ulong @size, av_buffer_pool_init_alloc_func @alloc);
    
    /// <summary>Allocate and initialize a buffer pool with a more complex allocator.</summary>
    /// <param name="size">size of each buffer in this pool</param>
    /// <param name="opaque">arbitrary user data used by the allocator</param>
    /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
    /// <param name="pool_free">a function that will be called immediately before the pool is freed. I.e. after av_buffer_pool_uninit() is called by the caller and all the frames are returned to the pool and freed. It is intended to uninitialize the user opaque data. May be NULL.</param>
    /// <returns>newly created buffer pool on success, NULL on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferPool* av_buffer_pool_init2(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);
    
    /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
    /// <param name="pool">pointer to the pool to be freed. It will be set to NULL.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_buffer_pool_uninit(AVBufferPool** @pool);
    
    /// <summary>Reallocate a given buffer.</summary>
    /// <param name="buf">a buffer reference to reallocate. On success, buf will be unreferenced and a new reference with the required size will be written in its place. On failure buf will be left untouched. *buf may be NULL, then a new buffer is allocated.</param>
    /// <param name="size">required new buffer size.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffer_realloc(AVBufferRef** @buf, ulong @size);
    
    /// <summary>Create a new reference to an AVBuffer.</summary>
    /// <returns>a new AVBufferRef referring to the same AVBuffer as buf or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffer_ref(AVBufferRef* @buf);
    
    /// <summary>Ensure dst refers to the same data as src.</summary>
    /// <param name="dst">Pointer to either a valid buffer reference or NULL. On success, this will point to a buffer reference equivalent to src. On failure, dst will be left untouched.</param>
    /// <param name="src">A buffer reference to replace dst with. May be NULL, then this function is equivalent to av_buffer_unref(dst).</param>
    /// <returns>0 on success AVERROR(ENOMEM) on memory allocation failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffer_replace(AVBufferRef** @dst, AVBufferRef* @src);
    
    /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
    /// <param name="buf">the reference to be freed. The pointer is set to NULL on return.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_buffer_unref(AVBufferRef** @buf);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_ch_layout(AVFilterContext* @ctx, AVChannelLayout* @ch_layout);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_channels(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVColorRange av_buffersink_get_color_range(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVColorSpace av_buffersink_get_colorspace(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_format(AVFilterContext* @ctx);
    
    /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
    /// <param name="ctx">pointer to a context of a buffersink or abuffersink AVFilter.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
    /// <returns>- &gt;= 0 if a frame was successfully returned. - AVERROR(EAGAIN) if no frames are available at this point; more input frames must be added to the filtergraph to get more output. - AVERROR_EOF if there will be no more output frames on this sink. - A different negative AVERROR code in other failure cases.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame);
    
    /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
    /// <param name="ctx">pointer to a buffersink or abuffersink filter context.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
    /// <param name="flags">a combination of AV_BUFFERSINK_FLAG_* flags</param>
    /// <returns>&gt;= 0 in for success, a negative AVERROR code for failure.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_h(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_sample_rate(AVFilterContext* @ctx);
    
    /// <summary>Same as av_buffersink_get_frame(), but with the ability to specify the number of samples read. This function is less efficient than av_buffersink_get_frame(), because it copies the data around.</summary>
    /// <param name="ctx">pointer to a context of the abuffersink AVFilter.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free() frame will contain exactly nb_samples audio samples, except at the end of stream, when it can contain less than nb_samples.</param>
    /// <returns>The return codes have the same meaning as for av_buffersink_get_frame().</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_buffersink_get_time_base(AVFilterContext* @ctx);
    
    /// <summary>Get the properties of the stream @{</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVMediaType av_buffersink_get_type(AVFilterContext* @ctx);
    
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersink_get_w(AVFilterContext* @ctx);
    
    /// <summary>Set the frame size for an audio buffer sink.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size);
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="ctx">an instance of the buffersrc filter</param>
    /// <param name="frame">frame to be added. If the frame is reference counted, this function will take ownership of the reference(s) and reset the frame. Otherwise the frame data will be copied. If this function returns an error, the input frame is not touched.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame);
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="buffer_src">pointer to a buffer source context</param>
    /// <param name="frame">a frame, or NULL to mark EOF</param>
    /// <param name="flags">a combination of AV_BUFFERSRC_FLAG_*</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
    
    /// <summary>Close the buffer source after EOF.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersrc_close(AVFilterContext* @ctx, long @pts, uint @flags);
    
    /// <summary>Get the number of failed requests.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src);
    
    /// <summary>Allocate a new AVBufferSrcParameters instance. It should be freed by the caller with av_free().</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferSrcParameters* av_buffersrc_parameters_alloc();
    
    /// <summary>Initialize the buffersrc or abuffersrc filter with the provided parameters. This function may be called multiple times, the later calls override the previous ones. Some of the parameters may also be set through AVOptions, then whatever method is used last takes precedence.</summary>
    /// <param name="ctx">an instance of the buffersrc or abuffersrc filter</param>
    /// <param name="param">the stream parameters. The frames later passed to this filter must conform to those parameters. All the allocated fields in param remain owned by the caller, libavfilter will make internal copies or references when necessary.</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="ctx">an instance of the buffersrc filter</param>
    /// <param name="frame">frame to be added. If the frame is reference counted, this function will make a new reference to it. Otherwise the frame data will be copied.</param>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame);
    
    /// <summary>Allocate a memory block for an array with av_mallocz().</summary>
    /// <param name="nmemb">Number of elements</param>
    /// <param name="size">Size of the single element</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_calloc(ulong @nmemb, ulong @size);
    
    /// <summary>Get a human readable string describing a given channel.</summary>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <param name="channel">the AVChannel whose description to get</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_description(byte* @buf, ulong @buf_size, AVChannel @channel);
    
    /// <summary>bprint variant of av_channel_description().</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_channel_description_bprint(AVBPrint* @bp, AVChannel @channel_id);
    
    /// <summary>This is the inverse function of av_channel_name().</summary>
    /// <returns>the channel with the given name AV_CHAN_NONE when name does not identify a known channel</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVChannel av_channel_from_string(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Get the channel with the given index in a channel layout.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="idx">index of the channel</param>
    /// <returns>channel with the index idx in channel_layout on success or AV_CHAN_NONE on failure (if idx is not valid or the channel order is unspecified)</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVChannel av_channel_layout_channel_from_index(AVChannelLayout* @channel_layout, uint @idx);
    
    /// <summary>Get a channel described by the given string.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="name">string describing the channel to obtain</param>
    /// <returns>a channel described by the given string in channel_layout on success or AV_CHAN_NONE on failure (if the string is not valid or the channel order is unspecified)</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVChannel av_channel_layout_channel_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Check whether a channel layout is valid, i.e. can possibly describe audio data.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <returns>1 if channel_layout is valid, 0 otherwise.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_check(AVChannelLayout* @channel_layout);
    
    /// <summary>Check whether two channel layouts are semantically the same, i.e. the same channels are present on the same positions in both.</summary>
    /// <param name="chl">input channel layout</param>
    /// <param name="chl1">input channel layout</param>
    /// <returns>0 if chl and chl1 are equal, 1 if they are not equal. A negative AVERROR code if one or both are invalid.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_compare(AVChannelLayout* @chl, AVChannelLayout* @chl1);
    
    /// <summary>Make a copy of a channel layout. This differs from just assigning src to dst in that it allocates and copies the map for AV_CHANNEL_ORDER_CUSTOM.</summary>
    /// <param name="dst">destination channel layout</param>
    /// <param name="src">source channel layout</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_copy(AVChannelLayout* @dst, AVChannelLayout* @src);
    
    /// <summary>Initialize a custom channel layout with the specified number of channels. The channel map will be allocated and the designation of all channels will be set to AV_CHAN_UNKNOWN.</summary>
    /// <param name="channel_layout">the layout structure to be initialized</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <returns>0 on success AVERROR(EINVAL) if the number of channels &lt; = 0 AVERROR(ENOMEM) if the channel map could not be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_custom_init(AVChannelLayout* @channel_layout, int @nb_channels);
    
    /// <summary>Get the default channel layout for a given number of channels.</summary>
    /// <param name="ch_layout">the layout structure to be initialized</param>
    /// <param name="nb_channels">number of channels</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_channel_layout_default(AVChannelLayout* @ch_layout, int @nb_channels);
    
    /// <summary>Get a human-readable string describing the channel layout properties. The string will be in the same format that is accepted by av_channel_layout_from_string(), allowing to rebuild the same channel layout, except for opaque pointers.</summary>
    /// <param name="channel_layout">channel layout to be described</param>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_describe(AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size);
    
    /// <summary>bprint variant of av_channel_layout_describe().</summary>
    /// <returns>0 on success, or a negative AVERROR value on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_describe_bprint(AVChannelLayout* @channel_layout, AVBPrint* @bp);
    
    /// <summary>Initialize a native channel layout from a bitmask indicating which channels are present.</summary>
    /// <param name="channel_layout">the layout structure to be initialized</param>
    /// <param name="mask">bitmask describing the channel layout</param>
    /// <returns>0 on success AVERROR(EINVAL) for invalid mask values</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_from_mask(AVChannelLayout* @channel_layout, ulong @mask);
    
    /// <summary>Initialize a channel layout from a given string description. The input string can be represented by: - the formal channel layout name (returned by av_channel_layout_describe()) - single or multiple channel names (returned by av_channel_name(), eg. &quot;FL&quot;, or concatenated with &quot;+&quot;, each optionally containing a custom name after a &quot;&quot;, eg. &quot;FL+FR+LFE&quot;) - a decimal or hexadecimal value of a native channel layout (eg. &quot;4&quot; or &quot;0x4&quot;) - the number of channels with default layout (eg. &quot;4c&quot;) - the number of unordered channels (eg. &quot;4C&quot; or &quot;4 channels&quot;) - the ambisonic order followed by optional non-diegetic channels (eg. &quot;ambisonic 2+stereo&quot;) On error, the channel layout will remain uninitialized, but not necessarily untouched.</summary>
    /// <param name="channel_layout">uninitialized channel layout for the result</param>
    /// <param name="str">string describing the channel layout</param>
    /// <returns>0 on success parsing the channel layout AVERROR(EINVAL) if an invalid channel layout string was provided AVERROR(ENOMEM) if there was not enough memory</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    
    /// <summary>Get the index of a given channel in a channel layout. In case multiple channels are found, only the first match will be returned.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="channel">the channel whose index to obtain</param>
    /// <returns>index of channel in channel_layout on success or a negative number if channel is not present in channel_layout.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_index_from_channel(AVChannelLayout* @channel_layout, AVChannel @channel);
    
    /// <summary>Get the index in a channel layout of a channel described by the given string. In case multiple channels are found, only the first match will be returned.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="name">string describing the channel whose index to obtain</param>
    /// <returns>a channel index described by the given string, or a negative AVERROR value.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_index_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Change the AVChannelOrder of a channel layout.</summary>
    /// <param name="channel_layout">channel layout which will be changed</param>
    /// <param name="order">the desired channel layout order</param>
    /// <param name="flags">a combination of AV_CHANNEL_LAYOUT_RETYPE_FLAG_* constants</param>
    /// <returns>0 if the conversion was successful and lossless or if the channel layout was already in the desired order &gt;0 if the conversion was successful but lossy AVERROR(ENOSYS) if the conversion was not possible (or would be lossy and AV_CHANNEL_LAYOUT_RETYPE_FLAG_LOSSLESS was specified) AVERROR(EINVAL), AVERROR(ENOMEM) on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_layout_retype(AVChannelLayout* @channel_layout, AVChannelOrder @order, int @flags);
    
    /// <summary>Iterate over all standard channel layouts.</summary>
    /// <param name="opaque">a pointer where libavutil will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the standard channel layout or NULL when the iteration is finished</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVChannelLayout* av_channel_layout_standard(void** @opaque);
    
    /// <summary>Find out what channels from a given set are present in a channel layout, without regard for their positions.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="mask">a combination of AV_CH_* representing a set of channels</param>
    /// <returns>a bitfield representing all the channels from mask that are present in channel_layout</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong av_channel_layout_subset(AVChannelLayout* @channel_layout, ulong @mask);
    
    /// <summary>Free any allocated data in the channel layout and reset the channel count to 0.</summary>
    /// <param name="channel_layout">the layout structure to be uninitialized</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_channel_layout_uninit(AVChannelLayout* @channel_layout);
    
    /// <summary>Get a human readable string in an abbreviated form describing a given channel. This is the inverse function of av_channel_from_string().</summary>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <param name="channel">the AVChannel whose name to get</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_channel_name(byte* @buf, ulong @buf_size, AVChannel @channel);
    
    /// <summary>bprint variant of av_channel_name().</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_channel_name_bprint(AVBPrint* @bp, AVChannel @channel_id);
    
    /// <summary>Converts AVChromaLocation to swscale x/y chroma position.</summary>
    /// <param name="xpos">horizontal chroma sample position</param>
    /// <param name="ypos">vertical   chroma sample position</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_chroma_location_enum_to_pos(int* @xpos, int* @ypos, AVChromaLocation @pos);
    
    /// <summary>Returns the AVChromaLocation value for name or an AVError if not found.</summary>
    /// <returns>the AVChromaLocation value for name or an AVError if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_chroma_location_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns the name for provided chroma location or NULL if unknown.</summary>
    /// <returns>the name for provided chroma location or NULL if unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_chroma_location_name(AVChromaLocation @location);
    
    /// <summary>Converts swscale x/y chroma position to AVChromaLocation.</summary>
    /// <param name="xpos">horizontal chroma sample position</param>
    /// <param name="ypos">vertical   chroma sample position</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVChromaLocation av_chroma_location_pos_to_enum(int @xpos, int @ypos);
    
    /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
    /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="tag">codec tag to match to a codec ID</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecID av_codec_get_id(AVCodecTag** @tags, uint @tag);
    
    /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
    /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="id">codec ID to match to a codec tag</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_codec_get_tag(AVCodecTag** @tags, AVCodecID @id);
    
    /// <summary>Get the codec tag for the given codec id.</summary>
    /// <param name="tags">list of supported codec_id - codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="id">codec id that should be searched for in the list</param>
    /// <param name="tag">A pointer to the found tag</param>
    /// <returns>0 if id was not found in tags, &gt; 0 if it was found</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_codec_get_tag2(AVCodecTag** @tags, AVCodecID @id, uint* @tag);
    
    /// <summary>Returns a non-zero number if codec is a decoder, zero otherwise</summary>
    /// <returns>a non-zero number if codec is a decoder, zero otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_codec_is_decoder(AVCodec* @codec);
    
    /// <summary>Returns a non-zero number if codec is an encoder, zero otherwise</summary>
    /// <returns>a non-zero number if codec is an encoder, zero otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_codec_is_encoder(AVCodec* @codec);
    
    /// <summary>Iterate over all registered codecs.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered codec or NULL when the iteration is finished</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodec* av_codec_iterate(void** @opaque);
    
    /// <summary>Returns the AVColorPrimaries value for name or an AVError if not found.</summary>
    /// <returns>the AVColorPrimaries value for name or an AVError if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_color_primaries_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns the name for provided color primaries or NULL if unknown.</summary>
    /// <returns>the name for provided color primaries or NULL if unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_color_primaries_name(AVColorPrimaries @primaries);
    
    /// <summary>Returns the AVColorRange value for name or an AVError if not found.</summary>
    /// <returns>the AVColorRange value for name or an AVError if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_color_range_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns the name for provided color range or NULL if unknown.</summary>
    /// <returns>the name for provided color range or NULL if unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_color_range_name(AVColorRange @range);
    
    /// <summary>Returns the AVColorSpace value for name or an AVError if not found.</summary>
    /// <returns>the AVColorSpace value for name or an AVError if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_color_space_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns the name for provided color space or NULL if unknown.</summary>
    /// <returns>the name for provided color space or NULL if unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_color_space_name(AVColorSpace @space);
    
    /// <summary>Returns the AVColorTransferCharacteristic value for name or an AVError if not found.</summary>
    /// <returns>the AVColorTransferCharacteristic value for name or an AVError if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_color_transfer_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns the name for provided color transfer or NULL if unknown.</summary>
    /// <returns>the name for provided color transfer or NULL if unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_color_transfer_name(AVColorTransferCharacteristic @transfer);
    
    /// <summary>Compare the remainders of two integer operands divided by a common divisor.</summary>
    /// <param name="a">Operand</param>
    /// <param name="b">Operand</param>
    /// <param name="mod">Divisor; must be a power of 2</param>
    /// <returns>- a negative value if `a % mod &lt; b % mod` - a positive value if `a % mod &gt; b % mod` - zero             if `a % mod == b % mod`</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_compare_mod(ulong @a, ulong @b, ulong @mod);
    
    /// <summary>Compare two timestamps each in its own time base.</summary>
    /// <returns>One of the following values: - -1 if `ts_a` is before `ts_b` - 1 if `ts_a` is after `ts_b` - 0 if they represent the same position</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
    
    /// <summary>Allocate an AVContentLightMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVContentLightMetadata filled with default values or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVContentLightMetadata* av_content_light_metadata_alloc(ulong* @size);
    
    /// <summary>Allocate a complete AVContentLightMetadata and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVContentLightMetadata structure to be filled by caller.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVContentLightMetadata* av_content_light_metadata_create_side_data(AVFrame* @frame);
    
    /// <summary>Allocate a CPB properties structure and initialize its fields to default values.</summary>
    /// <param name="size">if non-NULL, the size of the allocated struct will be written here. This is useful for embedding it in side data.</param>
    /// <returns>the newly allocated struct or NULL on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCPBProperties* av_cpb_properties_alloc(ulong* @size);
    
    /// <summary>Returns the number of logical CPU cores present.</summary>
    /// <returns>the number of logical CPU cores present.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_cpu_count();
    
    /// <summary>Overrides cpu count detection and forces the specified count. Count &lt; 1 disables forcing of specific count.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_cpu_force_count(int @count);
    
    /// <summary>Get the maximum data alignment that may be required by FFmpeg.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong av_cpu_max_align();
    
    /// <summary>Convert a double precision floating point number to a rational.</summary>
    /// <param name="d">`double` to convert</param>
    /// <param name="max">Maximum allowed numerator and denominator</param>
    /// <returns>`d` in AVRational form</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_d2q(double @d, int @max);
    
    /// <summary>Allocate an AVD3D11VAContext.</summary>
    /// <returns>Newly-allocated AVD3D11VAContext or NULL on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVD3D11VAContext* av_d3d11va_alloc_context();
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClassCategory av_default_get_category(void* @ptr);
    
    /// <summary>Return the context name</summary>
    /// <param name="ctx">The AVClass context</param>
    /// <returns>The AVClass class_name</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_default_item_name(void* @ctx);
    
    /// <summary>Iterate over all registered demuxers.</summary>
    /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered demuxer or NULL when the iteration is finished</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_demuxer_iterate(void** @opaque);
    
    /// <summary>Copy entries from one AVDictionary struct into another.</summary>
    /// <param name="dst">Pointer to a pointer to a AVDictionary struct to copy into. If *dst is NULL, this function will allocate a struct for you and put it in *dst</param>
    /// <param name="src">Pointer to the source AVDictionary struct to copy items from.</param>
    /// <param name="flags">Flags to use when setting entries in *dst</param>
    /// <returns>0 on success, negative AVERROR code on failure. If dst was allocated by this function, callers should free the associated memory.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags);
    
    /// <summary>Get number of entries in dictionary.</summary>
    /// <param name="m">dictionary</param>
    /// <returns>number of entries in dictionary</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_count(AVDictionary* @m);
    
    /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_dict_free(AVDictionary** @m);
    
    /// <summary>Get a dictionary entry with matching key.</summary>
    /// <param name="key">Matching key</param>
    /// <param name="prev">Set to the previous matching element to find the next. If set to NULL the first matching element is returned.</param>
    /// <param name="flags">A collection of AV_DICT_* flags controlling how the entry is retrieved</param>
    /// <returns>Found entry or NULL in case no matching entry was found in the dictionary</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVDictionaryEntry* av_dict_get(AVDictionary* @m,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags);
    
    /// <summary>Get dictionary entries as a string.</summary>
    /// <param name="m">The dictionary</param>
    /// <param name="buffer">Pointer to buffer that will be allocated with string containg entries. Buffer must be freed by the caller when is no longer needed.</param>
    /// <param name="key_val_sep">Character used to separate key from value</param>
    /// <param name="pairs_sep">Character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    
    /// <summary>Iterate over a dictionary</summary>
    /// <param name="m">The dictionary to iterate over</param>
    /// <param name="prev">Pointer to the previous AVDictionaryEntry, NULL initially</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVDictionaryEntry* av_dict_iterate(AVDictionary* @m, AVDictionaryEntry* @prev);
    
    /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
    /// <param name="key_val_sep">A 0-terminated list of characters used to separate key from value</param>
    /// <param name="pairs_sep">A 0-terminated list of characters used to separate two pairs from each other</param>
    /// <param name="flags">Flags to use when adding to the dictionary. ::AV_DICT_DONT_STRDUP_KEY and ::AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
    /// <returns>0 on success, negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_parse_string(AVDictionary** @pm,     
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
    
    /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
    /// <param name="pm">Pointer to a pointer to a dictionary struct. If *pm is NULL a dictionary struct is allocated and put in *pm.</param>
    /// <param name="key">Entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
    /// <param name="value">Entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
    /// <returns>&gt;= 0 on success otherwise an error code &lt; 0</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_set(AVDictionary** @pm,     
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
    
    /// <summary>Convenience wrapper for av_dict_set() that converts the value to a string and stores it.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dict_set_int(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, long @value, int @flags);
    
    /// <summary>Flip the input matrix horizontally and/or vertically.</summary>
    /// <param name="matrix">a transformation matrix</param>
    /// <param name="hflip">whether the matrix should be flipped horizontally</param>
    /// <param name="vflip">whether the matrix should be flipped vertically</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_display_matrix_flip(ref int9 @matrix, int @hflip, int @vflip);
    
    /// <summary>Extract the rotation component of the transformation matrix.</summary>
    /// <param name="matrix">the transformation matrix</param>
    /// <returns>the angle (in degrees) by which the transformation rotates the frame counterclockwise. The angle will be in range [-180.0, 180.0], or NaN if the matrix is singular.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern double av_display_rotation_get(in int9 @matrix);
    
    /// <summary>Initialize a transformation matrix describing a pure clockwise rotation by the specified angle (in degrees).</summary>
    /// <param name="matrix">a transformation matrix (will be fully overwritten by this function)</param>
    /// <param name="angle">rotation angle in degrees.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_display_rotation_set(ref int9 @matrix, double @angle);
    
    /// <summary>Returns The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</summary>
    /// <returns>The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_disposition_from_string(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @disp);
    
    /// <summary>Returns The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</summary>
    /// <param name="disposition">a combination of AV_DISPOSITION_* values</param>
    /// <returns>The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_disposition_to_string(int @disposition);
    
    /// <summary>Divide one rational by another.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b/c</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_div_q(AVRational @b, AVRational @c);
    
    /// <summary>Print detailed information about the input or output format, such as duration, bitrate, streams, container, programs, metadata, side data, codec and time base.</summary>
    /// <param name="ic">the context to analyze</param>
    /// <param name="index">index of the stream to dump information about</param>
    /// <param name="url">the URL to print, such as source or destination file</param>
    /// <param name="is_output">Select whether the specified context is an input(0) or output(1)</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_dump_format(AVFormatContext* @ic, int @index,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @is_output);
    
    /// <summary>Allocate an AVDynamicHDRPlus structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVDynamicHDRPlus filled with default values or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc(ulong* @size);
    
    /// <summary>Allocate a complete AVDynamicHDRPlus and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVDynamicHDRPlus structure to be filled by caller or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data(AVFrame* @frame);
    
    /// <summary>Parse the user data registered ITU-T T.35 to AVbuffer (AVDynamicHDRPlus). The T.35 buffer must begin with the application mode, skipping the country code, terminal provider codes, and application identifier.</summary>
    /// <param name="s">A pointer containing the decoded AVDynamicHDRPlus structure.</param>
    /// <param name="data">The byte array containing the raw ITU-T T.35 data.</param>
    /// <param name="size">Size of the data array in bytes.</param>
    /// <returns>&gt;= 0 on success. Otherwise, returns the appropriate AVERROR.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dynamic_hdr_plus_from_t35(AVDynamicHDRPlus* @s, byte* @data, ulong @size);
    
    /// <summary>Serialize dynamic HDR10+ metadata to a user data registered ITU-T T.35 buffer, excluding the first 48 bytes of the header, and beginning with the application mode.</summary>
    /// <param name="s">A pointer containing the decoded AVDynamicHDRPlus structure.</param>
    /// <param name="data">A pointer to pointer to a byte buffer to be filled with the serialized metadata. If *data is NULL, a buffer be will be allocated and a pointer to it stored in its place. The caller assumes ownership of the buffer. May be NULL, in which case the function will only store the required buffer size in *size.</param>
    /// <param name="size">A pointer to a size to be set to the returned buffer&apos;s size. If *data is not NULL, *size must contain the size of the input buffer. May be NULL only if *data is NULL.</param>
    /// <returns>&gt;= 0 on success. Otherwise, returns the appropriate AVERROR.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dynamic_hdr_plus_to_t35(AVDynamicHDRPlus* @s, byte** @data, ulong* @size);
    
    /// <summary>Add the pointer to an element to a dynamic array.</summary>
    /// <param name="tab_ptr">Pointer to the array to grow</param>
    /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
    /// <param name="elem">Element to add</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem);
    
    /// <summary>Add an element to a dynamic array.</summary>
    /// <returns>&gt;=0 on success, negative otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem);
    
    /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
    /// <param name="tab_ptr">Pointer to the array to grow</param>
    /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
    /// <param name="elem_size">Size in bytes of an element in the array</param>
    /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
    /// <returns>Pointer to the data of the element to copy in the newly allocated space</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
    
    /// <summary>Allocate a buffer, reusing the given one if large enough.</summary>
    /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
    /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size);
    
    /// <summary>Allocate and clear a buffer, reusing the given one if large enough.</summary>
    /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
    /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size);
    
    /// <summary>Same behaviour av_fast_malloc but the buffer has additional AV_INPUT_BUFFER_PADDING_SIZE at the end which will always be 0.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size);
    
    /// <summary>Same behaviour av_fast_padded_malloc except that buffer will always be 0-initialized after call.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size);
    
    /// <summary>Reallocate the given buffer if it is not large enough, otherwise do nothing.</summary>
    /// <param name="ptr">Already allocated buffer, or `NULL`</param>
    /// <param name="size">Pointer to the size of buffer `ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `ptr`</param>
    /// <returns>`ptr` if the buffer is large enough, a pointer to newly reallocated buffer if the buffer was not large enough, or `NULL` in case of error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size);
    
    /// <summary>Read the file with name filename, and put its content in a newly allocated buffer or map it with mmap() when available. In case of success set *bufptr to the read or mmapped buffer, and *size to the size in bytes of the buffer in *bufptr. Unlike mmap this function succeeds with zero sized files, in this case *bufptr will be set to NULL and *size will be set to 0. The returned buffer must be released with av_file_unmap().</summary>
    /// <param name="filename">path to the file</param>
    /// <param name="bufptr">pointee is set to the mapped or allocated buffer</param>
    /// <param name="size">pointee is set to the size in bytes of the buffer</param>
    /// <param name="log_offset">loglevel offset used for logging</param>
    /// <param name="log_ctx">context used for logging</param>
    /// <returns>a non negative number in case of success, a negative value corresponding to an AVERROR error code in case of failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_file_map(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx);
    
    /// <summary>Unmap or free the buffer bufptr created by av_file_map().</summary>
    /// <param name="bufptr">the buffer previously created with av_file_map()</param>
    /// <param name="size">size in bytes of bufptr, must be the same as returned by av_file_map()</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_file_unmap(byte* @bufptr, ulong @size);
    
    /// <summary>Check whether filename actually is a numbered sequence generator.</summary>
    /// <param name="filename">possible numbered sequence string</param>
    /// <returns>1 if a valid numbered sequence string, 0 otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_filename_number_test(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename);
    
    /// <summary>Iterate over all registered filters.</summary>
    /// <param name="opaque">a pointer where libavfilter will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered filter or NULL when the iteration is finished</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilter* av_filter_iterate(void** @opaque);
    
    /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    
    /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="type">stream type: video, audio, subtitles, etc.</param>
    /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
    /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
    /// <param name="decoder_ret">if non-NULL, returns the decoder for the selected stream</param>
    /// <param name="flags">flags; none are currently defined</param>
    /// <returns>the non-negative stream number in case of success, AVERROR_STREAM_NOT_FOUND if no stream with the requested type could be found, AVERROR_DECODER_NOT_FOUND if streams were found but no decoder</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_find_default_stream_index(AVFormatContext* @s);
    
    /// <summary>Find AVInputFormat based on the short name of the input format.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_find_input_format(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name);
    
    /// <summary>Find the value in a list of rationals nearest a given reference rational.</summary>
    /// <param name="q">Reference rational</param>
    /// <param name="q_list">Array of rationals terminated by `{0, 0}`</param>
    /// <returns>Index of the nearest value found in the array</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list);
    
    /// <summary>Find the programs which belong to a given stream.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="last">the last found program, the search will start after this program, or from the beginning if it is NULL</param>
    /// <param name="s">stream index</param>
    /// <returns>the next program which belongs to s, NULL if no program is found or the last program is not among the programs of ic.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s);
    
    /// <summary>Returns the method used to set ctx-&gt;duration.</summary>
    /// <returns>AVFMT_DURATION_FROM_PTS, AVFMT_DURATION_FROM_STREAM, or AVFMT_DURATION_FROM_BITRATE.</returns>
    [Obsolete("duration_estimation_method is public and can be read directly.")]
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx);
    
    /// <summary>Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_force_cpu_flags(int @flags);
    
    /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_format_inject_global_side_data(AVFormatContext* @s);
    
    /// <summary>Fill the provided buffer with a string containing a FourCC (four-character code) representation.</summary>
    /// <param name="buf">a buffer with size in bytes of at least AV_FOURCC_MAX_STRING_SIZE</param>
    /// <param name="fourcc">the fourcc to represent</param>
    /// <returns>the buffer in input</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_fourcc_make_string(byte* @buf, uint @fourcc);
    
    /// <summary>Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free().</summary>
    /// <returns>An AVFrame filled with default values or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrame* av_frame_alloc();
    
    /// <summary>Crop the given video AVFrame according to its crop_left/crop_top/crop_right/ crop_bottom fields. If cropping is successful, the function will adjust the data pointers and the width/height fields, and set the crop fields to 0.</summary>
    /// <param name="frame">the frame which should be cropped</param>
    /// <param name="flags">Some combination of AV_FRAME_CROP_* flags, or 0.</param>
    /// <returns>&gt;= 0 on success, a negative AVERROR on error. If the cropping fields were invalid, AVERROR(ERANGE) is returned, and nothing is changed.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_apply_cropping(AVFrame* @frame, int @flags);
    
    /// <summary>Create a new frame that references the same data as src.</summary>
    /// <returns>newly created AVFrame on success, NULL on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrame* av_frame_clone(AVFrame* @src);
    
    /// <summary>Copy the frame data from src to dst.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_copy(AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Copy only &quot;metadata&quot; fields from src to dst.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_copy_props(AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
    /// <param name="frame">frame to be freed. The pointer will be set to NULL.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_frame_free(AVFrame** @frame);
    
    /// <summary>Allocate new buffer(s) for audio or video data.</summary>
    /// <param name="frame">frame in which to store the new buffers.</param>
    /// <param name="align">Required buffer size alignment. If equal to 0, alignment will be chosen automatically for the current CPU. It is highly recommended to pass 0 here unless you know what you are doing.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_get_buffer(AVFrame* @frame, int @align);
    
    /// <summary>Get the buffer reference a given data plane is stored in.</summary>
    /// <param name="frame">the frame to get the plane&apos;s buffer from</param>
    /// <param name="plane">index of the data plane of interest in frame-&gt;extended_data.</param>
    /// <returns>the buffer reference that contains the plane or NULL if the input frame is not valid.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane);
    
    /// <summary>Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</summary>
    /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type);
    
    /// <summary>Check if the frame data is writable.</summary>
    /// <returns>A positive value if the frame data is writable (which is true if and only if each of the underlying buffers has only one reference, namely the one stored in this frame). Return 0 otherwise.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_is_writable(AVFrame* @frame);
    
    /// <summary>Ensure that the frame data is writable, avoiding data copy if possible.</summary>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_make_writable(AVFrame* @frame);
    
    /// <summary>Move everything contained in src to dst and reset src.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_frame_move_ref(AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Add a new side data to a frame.</summary>
    /// <param name="frame">a frame to which the side data should be added</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="size">size of the side data</param>
    /// <returns>newly added side data on success, NULL on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, ulong @size);
    
    /// <summary>Add a new side data to a frame from an existing AVBufferRef</summary>
    /// <param name="frame">a frame to which the side data should be added</param>
    /// <param name="type">the type of the added side data</param>
    /// <param name="buf">an AVBufferRef to add as side data. The ownership of the reference is transferred to the frame.</param>
    /// <returns>newly added side data on success, NULL on error. On failure the frame is unchanged and the AVBufferRef remains owned by the caller.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf);
    
    /// <summary>Set up a new reference to the data described by the source frame.</summary>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_ref(AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Remove and free all side data instances of the given type.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type);
    
    /// <summary>Ensure the destination frame refers to the same data described by the source frame, either by creating a new reference for each AVBufferRef from src if they differ from those in dst, by allocating new buffers and copying data if src is not reference counted, or by unrefencing it if src is empty.</summary>
    /// <returns>0 on success, a negative AVERROR on error. On error, dst is unreferenced.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_replace(AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Add a new side data entry to an array based on existing side data, taking a reference towards the contained AVBufferRef.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="src">side data to be cloned, with a new reference utilized for the buffer.</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>negative error code on failure, &gt;=0 on success. In case of AV_FRAME_SIDE_DATA_FLAG_UNIQUE being set, entries of matching AVFrameSideDataType will be removed before the addition is attempted.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_frame_side_data_clone(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags);
    
    /// <summary>Free all side data entries and their contents, then zeroes out the values which the pointers are pointing to.</summary>
    /// <param name="sd">pointer to array of side data to free. Will be set to NULL upon return.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_frame_side_data_free(AVFrameSideData*** @sd, int* @nb_sd);
    
    /// <summary>Get a side data entry of a specific type from an array.</summary>
    /// <param name="sd">array of side data.</param>
    /// <param name="nb_sd">integer containing the number of entries in the array.</param>
    /// <param name="type">type of side data to be queried</param>
    /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this set.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrameSideData* av_frame_side_data_get_c(AVFrameSideData** @sd, int @nb_sd, AVFrameSideDataType @type);
    
    /// <summary>Returns a string identifying the side data type</summary>
    /// <returns>a string identifying the side data type</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_frame_side_data_name(AVFrameSideDataType @type);
    
    /// <summary>Add new side data entry to an array.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="size">size of the side data</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error. In case of AV_FRAME_SIDE_DATA_FLAG_UNIQUE being set, entries of matching AVFrameSideDataType will be removed before the addition is attempted.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFrameSideData* av_frame_side_data_new(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, ulong @size, uint @flags);
    
    /// <summary>Unreference all the buffers referenced by frame and reset the frame fields.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_frame_unref(AVFrame* @frame);
    
    /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family.</summary>
    /// <param name="ptr">Pointer to the memory block which should be freed.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_free(void* @ptr);
    
    /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`.</summary>
    /// <param name="ptr">Pointer to the pointer to the memory block which should be freed</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_freep(void* @ptr);
    
    /// <summary>Compute the greatest common divisor of two integer operands.</summary>
    /// <param name="a">Operand</param>
    /// <param name="b">Operand</param>
    /// <returns>GCD of a and b up to sign; if a &gt;= 0 and b &gt;= 0, return value is &gt;= 0; if a == 0 and b == 0, returns 0.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_gcd(long @a, long @b);
    
    /// <summary>Return the best rational so that a and b are multiple of it. If the resulting denominator is larger than max_den, return def.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_gcd_q(AVRational @a, AVRational @b, int @max_den, AVRational @def);
    
    /// <summary>Return the planar&lt;-&gt;packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar);
    
    /// <summary>Return audio frame duration.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame_bytes">size of the frame, or 0 if unknown</param>
    /// <returns>frame duration, in samples, if known. 0 if not able to determine.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes);
    
    /// <summary>This function is the same as av_get_audio_frame_duration(), except it works with AVCodecParameters instead of an AVCodecContext.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes);
    
    /// <summary>Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
    
    /// <summary>Return codec bits per sample.</summary>
    /// <param name="codec_id">the codec</param>
    /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_bits_per_sample(AVCodecID @codec_id);
    
    /// <summary>Return number of bytes per sample.</summary>
    /// <param name="sample_fmt">the sample format</param>
    /// <returns>number of bytes per sample or zero if unknown for the given sample format</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_bytes_per_sample(AVSampleFormat @sample_fmt);
    
    /// <summary>Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_cpu_flags();
    
    /// <summary>Return codec bits per sample. Only return non-zero if the bits per sample is exactly correct, not an approximation.</summary>
    /// <param name="codec_id">the codec</param>
    /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_exact_bits_per_sample(AVCodecID @codec_id);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_frame_filename(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number);
    
    /// <summary>Return in &apos;buf&apos; the path with &apos;%d&apos; replaced by a number.</summary>
    /// <param name="buf">destination buffer</param>
    /// <param name="buf_size">destination buffer size</param>
    /// <param name="path">numbered sequence string</param>
    /// <param name="number">frame number</param>
    /// <param name="flags">AV_FRAME_FILENAME_FLAGS_*</param>
    /// <returns>0 if OK, -1 on format error</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_frame_filename2(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number, int @flags);
    
    /// <summary>Return a string describing the media_type enum, NULL if media_type is unknown.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_get_media_type_string(AVMediaType @media_type);
    
    /// <summary>Get timing information for the data currently output. The exact meaning of &quot;currently output&quot; depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream">stream in the media file</param>
    /// <param name="dts">DTS of the last packet output for the stream, in stream time_base units</param>
    /// <param name="wall">absolute time when that packet whas output, in microsecond</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_output_timestamp(AVFormatContext* @s, int @stream, long* @dts, long* @wall);
    
    /// <summary>Get the packed alternative form of the given sample format.</summary>
    /// <returns>the packed alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt);
    
    /// <summary>Allocate and read the payload of a packet and initialize its fields with default values.</summary>
    /// <param name="s">associated IO context</param>
    /// <param name="pkt">packet</param>
    /// <param name="size">desired payload size</param>
    /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
    
    /// <summary>Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
    
    /// <summary>Return the PCM codec associated with a sample format.</summary>
    /// <param name="be">endianness, 0 for little, 1 for big, -1 (or anything else) for native</param>
    /// <returns>AV_CODEC_ID_PCM_* or AV_CODEC_ID_NONE</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be);
    
    /// <summary>Return a single letter to describe the given picture type pict_type.</summary>
    /// <param name="pict_type">the picture type</param>
    /// <returns>a single character representing the picture type, &apos;?&apos; if pict_type is unknown</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte av_get_picture_type_char(AVPictureType @pict_type);
    
    /// <summary>Return the pixel format corresponding to name.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat av_get_pix_fmt(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
    /// <param name="dst_pix_fmt">destination pixel format</param>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
    
    /// <summary>Return the short name for a pixel format, NULL in case pix_fmt is unknown.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_get_pix_fmt_name(AVPixelFormat @pix_fmt);
    
    /// <summary>Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative.</summary>
    /// <param name="buf">the buffer where to write the string</param>
    /// <param name="buf_size">the size of buf</param>
    /// <param name="pix_fmt">the number of the pixel format to print the corresponding info string, or a negative value to print the corresponding header.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
    
    /// <summary>Get the planar alternative form of the given sample format.</summary>
    /// <returns>the planar alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt);
    
    /// <summary>Return a name for the specified profile, if available.</summary>
    /// <param name="codec">the codec that is searched for the given profile</param>
    /// <param name="profile">the profile value for which a name is requested</param>
    /// <returns>A name for the profile if found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_get_profile_name(AVCodec* @codec, int @profile);
    
    /// <summary>Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVSampleFormat av_get_sample_fmt(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Return the name of sample_fmt, or NULL if sample_fmt is not recognized.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_get_sample_fmt_name(AVSampleFormat @sample_fmt);
    
    /// <summary>Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative.</summary>
    /// <param name="buf">the buffer where to write the string</param>
    /// <param name="buf_size">the size of buf</param>
    /// <param name="sample_fmt">the number of the sample format to print the corresponding info string, or a negative value to print the corresponding header.</param>
    /// <returns>the pointer to the filled buffer or NULL if sample_fmt is unknown or in case of other errors</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
    
    /// <summary>Return the fractional representation of the internal time base.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_get_time_base_q();
    
    /// <summary>Get the current time in microseconds.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_gettime();
    
    /// <summary>Get the current time in microseconds since some unspecified starting point. On platforms that support it, the time comes from a monotonic clock This property makes this time source ideal for measuring relative time. The returned values may not be monotonic on platforms where a monotonic clock is not available.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_gettime_relative();
    
    /// <summary>Indicates with a boolean result if the av_gettime_relative() time source is monotonic.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_gettime_relative_is_monotonic();
    
    /// <summary>Increase packet size, correctly zeroing padding</summary>
    /// <param name="pkt">packet</param>
    /// <param name="grow_by">number of bytes by which to increase the size of the packet</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_grow_packet(AVPacket* @pkt, int @grow_by);
    
    /// <summary>Guess the codec ID based upon muxer and filename.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecID av_guess_codec(AVOutputFormat* @fmt,     
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
    
    /// <summary>Return the output format in the list of registered output formats which best matches the provided parameters, or return NULL if there is no match.</summary>
    /// <param name="short_name">if non-NULL checks if short_name matches with the names of the registered formats</param>
    /// <param name="filename">if non-NULL checks if filename terminates with the extensions of the registered formats</param>
    /// <param name="mime_type">if non-NULL checks if mime_type matches with the MIME type of the registered formats</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOutputFormat* av_guess_format(    
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
    
    /// <summary>Guess the frame rate, based on both the container and codec information.</summary>
    /// <param name="ctx">the format context which the stream is part of</param>
    /// <param name="stream">the stream which the frame is part of</param>
    /// <param name="frame">the frame for which the frame rate should be determined, may be NULL</param>
    /// <returns>the guessed (valid) frame rate, 0/1 if no idea</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
    
    /// <summary>Guess the sample aspect ratio of a frame, based on both the stream and the frame aspect ratio.</summary>
    /// <param name="format">the format context which the stream is part of</param>
    /// <param name="stream">the stream which the frame is part of</param>
    /// <param name="frame">the frame with the aspect ratio to be determined</param>
    /// <returns>the guessed (valid) sample_aspect_ratio, 0/1 if no idea</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
    
    /// <summary>Send a nice hexadecimal dump of a buffer to the specified file stream.</summary>
    /// <param name="f">The file stream pointer where the dump should be sent to.</param>
    /// <param name="buf">buffer</param>
    /// <param name="size">buffer size</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_hex_dump(_iobuf* @f, byte* @buf, int @size);
    
    /// <summary>Send a nice hexadecimal dump of a buffer to the log.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
    /// <param name="buf">buffer</param>
    /// <param name="size">buffer size</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size);
    
    /// <summary>Allocate an AVHWDeviceContext for a given hardware type.</summary>
    /// <param name="type">the type of the hardware device to allocate.</param>
    /// <returns>a reference to the newly created AVHWDeviceContext on success or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType @type);
    
    /// <summary>Open a device of the specified type and create an AVHWDeviceContext for it.</summary>
    /// <param name="device_ctx">On success, a reference to the newly-created device context will be written here. The reference is owned by the caller and must be released with av_buffer_unref() when no longer needed. On failure, NULL will be written to this pointer.</param>
    /// <param name="type">The type of the device to create.</param>
    /// <param name="device">A type-specific string identifying the device to open.</param>
    /// <param name="opts">A dictionary of additional (type-specific) options to use in opening the device. The dictionary remains owned by the caller.</param>
    /// <param name="flags">currently unused</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwdevice_ctx_create(AVBufferRef** @device_ctx, AVHWDeviceType @type,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device, AVDictionary* @opts, int @flags);
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwdevice_ctx_create_derived(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="options">Options for the new device to create, same format as in av_hwdevice_ctx_create.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwdevice_ctx_create_derived_opts(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags);
    
    /// <summary>Finalize the device context before use. This function must be called after the context is filled with all the required information and before it is used in any way.</summary>
    /// <param name="ref">a reference to the AVHWDeviceContext</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwdevice_ctx_init(AVBufferRef* @ref);
    
    /// <summary>Look up an AVHWDeviceType by name.</summary>
    /// <param name="name">String name of the device type (case-insensitive).</param>
    /// <returns>The type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if not found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVHWDeviceType av_hwdevice_find_type_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Get the constraints on HW frames given a device and the HW-specific configuration to be used with that device. If no HW-specific configuration is provided, returns the maximum possible capabilities of the device.</summary>
    /// <param name="ref">a reference to the associated AVHWDeviceContext.</param>
    /// <param name="hwconfig">a filled HW-specific configuration structure, or NULL to return the maximum possible capabilities of the device.</param>
    /// <returns>AVHWFramesConstraints structure describing the constraints on the device, or NULL if not available.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* @hwconfig);
    
    /// <summary>Get the string name of an AVHWDeviceType.</summary>
    /// <param name="type">Type from enum AVHWDeviceType.</param>
    /// <returns>Pointer to a static string containing the name, or NULL if the type is not valid.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_hwdevice_get_type_name(AVHWDeviceType @type);
    
    /// <summary>Allocate a HW-specific configuration structure for a given HW device. After use, the user must free all members as required by the specific hardware structure being used, then free the structure itself with av_free().</summary>
    /// <param name="device_ctx">a reference to the associated AVHWDeviceContext.</param>
    /// <returns>The newly created HW-specific configuration structure on success or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_hwdevice_hwconfig_alloc(AVBufferRef* @device_ctx);
    
    /// <summary>Iterate over supported device types.</summary>
    /// <param name="prev">AV_HWDEVICE_TYPE_NONE initially, then the previous type returned by this function in subsequent iterations.</param>
    /// <returns>The next usable device type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if there are no more.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType @prev);
    
    /// <summary>Free an AVHWFrameConstraints structure.</summary>
    /// <param name="constraints">The (filled or unfilled) AVHWFrameConstraints structure.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_hwframe_constraints_free(AVHWFramesConstraints** @constraints);
    
    /// <summary>Allocate an AVHWFramesContext tied to a given device context.</summary>
    /// <param name="device_ctx">a reference to a AVHWDeviceContext. This function will make a new reference for internal use, the one passed to the function remains owned by the caller.</param>
    /// <returns>a reference to the newly created AVHWFramesContext on success or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* @device_ctx);
    
    /// <summary>Create and initialise an AVHWFramesContext as a mapping of another existing AVHWFramesContext on a different device.</summary>
    /// <param name="derived_frame_ctx">On success, a reference to the newly created AVHWFramesContext.</param>
    /// <param name="format">The AVPixelFormat for the derived context.</param>
    /// <param name="derived_device_ctx">A reference to the device to create the new AVHWFramesContext on.</param>
    /// <param name="source_frame_ctx">A reference to an existing AVHWFramesContext which will be mapped to the derived context.</param>
    /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags, defining the mapping parameters to apply to frames which are allocated in the derived device.</param>
    /// <returns>Zero on success, negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_ctx_create_derived(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);
    
    /// <summary>Finalize the context before use. This function must be called after the context is filled with all the required information and before it is attached to any frames.</summary>
    /// <param name="ref">a reference to the AVHWFramesContext</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_ctx_init(AVBufferRef* @ref);
    
    /// <summary>Allocate a new frame attached to the given AVHWFramesContext.</summary>
    /// <param name="hwframe_ctx">a reference to an AVHWFramesContext</param>
    /// <param name="frame">an empty (freshly allocated or unreffed) frame to be filled with newly allocated buffers.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_get_buffer(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);
    
    /// <summary>Map a hardware frame.</summary>
    /// <param name="dst">Destination frame, to contain the mapping.</param>
    /// <param name="src">Source frame, to be mapped.</param>
    /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags.</param>
    /// <returns>Zero on success, negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_map(AVFrame* @dst, AVFrame* @src, int @flags);
    
    /// <summary>Copy data to or from a hw surface. At least one of dst/src must have an AVHWFramesContext attached.</summary>
    /// <param name="dst">the destination frame. dst is not touched on failure.</param>
    /// <param name="src">the source frame.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR error code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_transfer_data(AVFrame* @dst, AVFrame* @src, int @flags);
    
    /// <summary>Get a list of possible source or target formats usable in av_hwframe_transfer_data().</summary>
    /// <param name="hwframe_ctx">the frame context to obtain the information for</param>
    /// <param name="dir">the direction of the transfer</param>
    /// <param name="formats">the pointer to the output format list will be written here. The list is terminated with AV_PIX_FMT_NONE and must be freed by the caller when no longer needed using av_free(). If this function returns successfully, the format list will have at least one item (not counting the terminator). On failure, the contents of this pointer are unspecified.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);
    
    /// <summary>Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&amp;pointers[0]).</summary>
    /// <param name="pointers">array to be filled with the pointer for each image plane</param>
    /// <param name="linesizes">the array filled with the linesize for each plane</param>
    /// <param name="w">width of the image in pixels</param>
    /// <param name="h">height of the image in pixels</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="align">the value to use for buffer size alignment</param>
    /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_alloc(ref byte_ptr4 @pointers, ref int4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
    
    /// <summary>Check if the given sample aspect ratio of an image is valid.</summary>
    /// <param name="w">width of the image</param>
    /// <param name="h">height of the image</param>
    /// <param name="sar">sample aspect ratio of the image</param>
    /// <returns>0 if valid, a negative AVERROR code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_check_sar(uint @w, uint @h, AVRational @sar);
    
    /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int.</summary>
    /// <param name="w">the width of the picture</param>
    /// <param name="h">the height of the picture</param>
    /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
    /// <param name="log_ctx">the parent logging context, it may be NULL</param>
    /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx);
    
    /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of a plane of an image with the specified pix_fmt can be addressed with a signed int.</summary>
    /// <param name="w">the width of the picture</param>
    /// <param name="h">the height of the picture</param>
    /// <param name="max_pixels">the maximum number of pixels the user wants to accept</param>
    /// <param name="pix_fmt">the pixel format, can be AV_PIX_FMT_NONE if unknown.</param>
    /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
    /// <param name="log_ctx">the parent logging context, it may be NULL</param>
    /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_check_size2(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);
    
    /// <summary>Copy image in src_data to dst_data.</summary>
    /// <param name="dst_data">destination image data buffer to copy to</param>
    /// <param name="dst_linesizes">linesizes for the image in dst_data</param>
    /// <param name="src_data">source image data buffer to copy from</param>
    /// <param name="src_linesizes">linesizes for the image in src_data</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="width">width of the image in pixels</param>
    /// <param name="height">height of the image in pixels</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_image_copy(ref byte_ptr4 @dst_data, in int4 @dst_linesizes, in byte_ptr4 @src_data, in int4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    
    /// <summary>Copy image plane from src to dst. That is, copy &quot;height&quot; number of lines of &quot;bytewidth&quot; bytes each. The first byte of each successive line is separated by *_linesize bytes.</summary>
    /// <param name="dst">destination plane to copy to</param>
    /// <param name="dst_linesize">linesize for the image plane in dst</param>
    /// <param name="src">source plane to copy from</param>
    /// <param name="src_linesize">linesize for the image plane in src</param>
    /// <param name="height">height (number of lines) of the plane</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
    
    /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy_plane().</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_image_copy_plane_uc_from(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height);
    
    /// <summary>Copy image data from an image into a buffer.</summary>
    /// <param name="dst">a buffer into which picture data will be copied</param>
    /// <param name="dst_size">the size in bytes of dst</param>
    /// <param name="src_data">pointers containing the source image data</param>
    /// <param name="src_linesize">linesizes for the image in src_data</param>
    /// <param name="pix_fmt">the pixel format of the source image</param>
    /// <param name="width">the width of the source image in pixels</param>
    /// <param name="height">the height of the source image in pixels</param>
    /// <param name="align">the assumed linesize alignment for dst</param>
    /// <returns>the number of bytes written to dst, or a negative value (error code) on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_copy_to_buffer(byte* @dst, int @dst_size, in byte_ptr4 @src_data, in int4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    
    /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy().</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_image_copy_uc_from(ref byte_ptr4 @dst_data, in long4 @dst_linesizes, in byte_ptr4 @src_data, in long4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    
    /// <summary>Setup the data pointers and linesizes based on the specified image parameters and the provided array.</summary>
    /// <param name="dst_data">data pointers to be filled in</param>
    /// <param name="dst_linesize">linesizes for the image in dst_data to be filled in</param>
    /// <param name="src">buffer which will contain or contains the actual image data, can be NULL</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="align">the value used in src for linesize alignment</param>
    /// <returns>the size in bytes required for src, a negative error code in case of failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_arrays(ref byte_ptr4 @dst_data, ref int4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    
    /// <summary>Overwrite the image data with black. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
    /// <param name="dst_data">data pointers to destination image</param>
    /// <param name="dst_linesize">linesizes for the destination image</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="range">the color range of the image (important for colorspaces such as YUV)</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <returns>0 if the image data was cleared, a negative AVERROR code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_black(ref byte_ptr4 @dst_data, in long4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);
    
    /// <summary>Overwrite the image data with a color. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
    /// <param name="dst_data">data pointers to destination image</param>
    /// <param name="dst_linesize">linesizes for the destination image</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="color">the color components to be used for the fill</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="flags">currently unused</param>
    /// <returns>0 if the image data was filled, a negative AVERROR code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_color(ref byte_ptr4 @dst_data, in long4 @dst_linesize, AVPixelFormat @pix_fmt, in uint4 @color, int @width, int @height, int @flags);
    
    /// <summary>Fill plane linesizes for an image with pixel format pix_fmt and width width.</summary>
    /// <param name="linesizes">array to be filled with the linesize for each plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="width">width of the image in pixels</param>
    /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_linesizes(ref int4 @linesizes, AVPixelFormat @pix_fmt, int @width);
    
    /// <summary>Compute the max pixel step for each plane of an image with a format described by pixdesc.</summary>
    /// <param name="max_pixsteps">an array which is filled with the max pixel step for each plane. Since a plane may contain different pixel components, the computed max_pixsteps[plane] is relative to the component in the plane with the max pixel step.</param>
    /// <param name="max_pixstep_comps">an array which is filled with the component for each plane which has the max pixel step. May be NULL.</param>
    /// <param name="pixdesc">the AVPixFmtDescriptor for the image, describing its format</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_image_fill_max_pixsteps(ref int4 @max_pixsteps, ref int4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
    
    /// <summary>Fill plane sizes for an image with pixel format pix_fmt and height height.</summary>
    /// <param name="size">the array to be filled with the size of each image plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="height">height of the image in pixels</param>
    /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
    /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_plane_sizes(ref ulong4 @size, AVPixelFormat @pix_fmt, int @height, in long4 @linesizes);
    
    /// <summary>Fill plane data pointers for an image with pixel format pix_fmt and height height.</summary>
    /// <param name="data">pointers array to be filled with the pointer for each image plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="height">height of the image in pixels</param>
    /// <param name="ptr">the pointer to a buffer which will contain the image</param>
    /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
    /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_fill_pointers(ref byte_ptr4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, in int4 @linesizes);
    
    /// <summary>Return the size in bytes of the amount of data required to store an image with the given parameters.</summary>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="align">the assumed linesize alignment</param>
    /// <returns>the buffer size in bytes, a negative error code in case of failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    
    /// <summary>Compute the size of an image line with format pix_fmt and width width for the plane plane.</summary>
    /// <returns>the computed size in bytes</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane);
    
    /// <summary>Get the index for a specific timestamp.</summary>
    /// <param name="st">stream that the timestamp belongs to</param>
    /// <param name="timestamp">timestamp to retrieve the index for</param>
    /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
    /// <returns>&lt; 0 if no such timestamp could be found</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags);
    
    /// <summary>Initialize optional fields of a packet with default values.</summary>
    /// <param name="pkt">packet</param>
    [Obsolete("This function is deprecated. Once it's removed, sizeof(AVPacket) will not be a part of the ABI anymore.")]
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_init_packet(AVPacket* @pkt);
    
    /// <summary>Audio input devices iterator.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_input_audio_device_next(AVInputFormat* @d);
    
    /// <summary>Video input devices iterator.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_input_video_device_next(AVInputFormat* @d);
    
    /// <summary>Compute the length of an integer list.</summary>
    /// <param name="elsize">size in bytes of each list element (only 1, 2, 4 or 8)</param>
    /// <param name="list">pointer to the list</param>
    /// <param name="term">list terminator (usually 0 or -1)</param>
    /// <returns>length of the list, in elements, not counting the terminator</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term);
    
    /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="pkt">The packet containing the data to be written. If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. If the packet is not reference-counted, libavformat will make a copy. The returned packet will be blank (as if returned from av_packet_alloc()), even on error. This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues. Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;. The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets in one stream must be strictly increasing (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing). &quot;duration&quot; should also be set if known.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt);
    
    /// <summary>Write an uncoded frame to an output media file.</summary>
    /// <returns>&gt;=0 for success, a negative code on error</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    
    /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    
    /// <summary>Default logging callback</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    /// <param name="vl">The arguments referenced by the format string.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_default_callback(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    
    /// <summary>Format a line of log the same way as the default callback.</summary>
    /// <param name="line">buffer to receive the formatted line</param>
    /// <param name="line_size">size of the buffer</param>
    /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_format_line(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    
    /// <summary>Format a line of log the same way as the default callback.</summary>
    /// <param name="line">buffer to receive the formatted line; may be NULL if line_size is 0</param>
    /// <param name="line_size">size of the buffer; at most line_size-1 characters will be written to the buffer, plus one null terminator</param>
    /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
    /// <returns>Returns a negative value if an error occurred, otherwise returns the number of characters that would have been written for a sufficiently large buffer, not including the terminating null character. If the return value is not less than line_size, it means that the log message was truncated to fit the buffer.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_log_format_line2(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_log_get_flags();
    
    /// <summary>Get the current log level</summary>
    /// <returns>Current log level</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_log_get_level();
    
    /// <summary>Send the specified message to the log once with the initial_level and then with the subsequent_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
    /// <param name="initial_level">importance level of the message expressed using a &quot;Logging Constant&quot; for the first occurance.</param>
    /// <param name="subsequent_level">importance level of the message expressed using a &quot;Logging Constant&quot; after the first occurance.</param>
    /// <param name="state">a variable to keep trak of if a message has already been printed this must be initialized to 0 before the first use. The same state must not be accessed by 2 Threads simultaneously.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_once(void* @avcl, int @initial_level, int @subsequent_level, int* @state,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    
    /// <summary>Set the logging callback</summary>
    /// <param name="callback">A logging function with a compatible signature.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_set_callback(av_log_set_callback_callback_func @callback);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_set_flags(int @arg);
    
    /// <summary>Set the log level</summary>
    /// <param name="level">Logging level</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_log_set_level(int @level);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_log2(uint @v);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_log2_16bit(uint @v);
    
    /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU).</summary>
    /// <param name="size">Size in bytes for the memory block to be allocated</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_malloc(ulong @size);
    
    /// <summary>Allocate a memory block for an array with av_malloc().</summary>
    /// <param name="nmemb">Number of element</param>
    /// <param name="size">Size of a single element</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_malloc_array(ulong @nmemb, ulong @size);
    
    /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block.</summary>
    /// <param name="size">Size in bytes for the memory block to be allocated</param>
    /// <returns>Pointer to the allocated block, or `NULL` if it cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_mallocz(ulong @size);
    
    /// <summary>Allocate an AVMasteringDisplayMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVMasteringDisplayMetadata filled with default values or NULL on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc();
    
    /// <summary>Allocate a complete AVMasteringDisplayMetadata and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVMasteringDisplayMetadata structure to be filled by caller.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data(AVFrame* @frame);
    
    /// <summary>Return a positive value if the given filename has one of the given extensions, 0 otherwise.</summary>
    /// <param name="filename">file name to check against the given extensions</param>
    /// <param name="extensions">a comma-separated list of filename extensions</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_match_ext(    
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
    
    /// <summary>Set the maximum size that may be allocated in one block.</summary>
    /// <param name="max">Value to be set as the new maximum size</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_max_alloc(ulong @max);
    
    /// <summary>Overlapping memcpy() implementation.</summary>
    /// <param name="dst">Destination buffer</param>
    /// <param name="back">Number of bytes back to start copying (i.e. the initial size of the overlapping window); must be &gt; 0</param>
    /// <param name="cnt">Number of bytes to copy; must be &gt;= 0</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_memcpy_backptr(byte* @dst, int @back, int @cnt);
    
    /// <summary>Duplicate a buffer with av_malloc().</summary>
    /// <param name="p">Buffer to be duplicated</param>
    /// <param name="size">Size in bytes of the buffer copied</param>
    /// <returns>Pointer to a newly allocated buffer containing a copy of `p` or `NULL` if the buffer cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_memdup(void* @p, ulong @size);
    
    /// <summary>Multiply two rationals.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b*c</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_mul_q(AVRational @b, AVRational @c);
    
    /// <summary>Iterate over all registered muxers.</summary>
    /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered muxer or NULL when the iteration is finished</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOutputFormat* av_muxer_iterate(void** @opaque);
    
    /// <summary>Find which of the two rationals is closer to another rational.</summary>
    /// <param name="q">Rational to be compared against</param>
    /// <param name="q1">Rational to be tested</param>
    /// <param name="q2">Rational to be tested</param>
    /// <returns>One of the following values: - 1 if `q1` is nearer to `q` than `q2` - -1 if `q2` is nearer to `q` than `q1` - 0 if they have the same distance</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2);
    
    /// <summary>Allocate the payload of a packet and initialize its fields with default values.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="size">wanted payload size</param>
    /// <returns>0 if OK, AVERROR_xxx otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_new_packet(AVPacket* @pkt, int @size);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVProgram* av_new_program(AVFormatContext* @s, int @id);
    
    /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
    /// <param name="iter">a pointer where iteration state is stored.</param>
    /// <returns>AVClass corresponding to next potential child or NULL</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* av_opt_child_class_iterate(AVClass* @parent, void** @iter);
    
    /// <summary>Iterate over AVOptions-enabled children of obj.</summary>
    /// <param name="prev">result of a previous call to this function or NULL</param>
    /// <returns>next AVOptions-enabled child or NULL</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_opt_child_next(void* @obj, void* @prev);
    
    /// <summary>Copy options from src object into dest object.</summary>
    /// <param name="dest">Object to copy from</param>
    /// <param name="src">Object to copy into</param>
    /// <returns>0 on success, negative on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_copy(void* @dest, void* @src);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_double(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, double* @double_out);
    
    /// <summary>@{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass.</param>
    /// <param name="o">an option for which the string is to be evaluated.</param>
    /// <param name="val">string to be evaluated.</param>
    /// <returns>0 on success, a negative number on failure.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_flags(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @flags_out);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_float(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, float* @float_out);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_int(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @int_out);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_int64(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, long* @int64_out);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_eval_q(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, AVRational* @q_out);
    
    /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
    /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
    /// <param name="name">The name of the option to look for.</param>
    /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
    /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOption* av_opt_find(void* @obj,     
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
    
    /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
    /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
    /// <param name="name">The name of the option to look for.</param>
    /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
    /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <param name="target_obj">if non-NULL, an object to which the option belongs will be written here. It may be different from obj if AV_OPT_SEARCH_CHILDREN is present in search_flags. This parameter is ignored if search_flags contain AV_OPT_SEARCH_FAKE_OBJ.</param>
    /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOption* av_opt_find2(void* @obj,     
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
    
    /// <summary>Check whether a particular flag is set in a flags field.</summary>
    /// <param name="field_name">the name of the flag field option</param>
    /// <param name="flag_name">the name of the flag to check</param>
    /// <returns>non-zero if the flag is set, zero if the flag isn&apos;t set, isn&apos;t of the right type, or the flags field doesn&apos;t exist.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_flag_is_set(void* @obj,     
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
    
    /// <summary>Free all allocated objects in obj.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_opt_free(void* @obj);
    
    /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_opt_freep_ranges(AVOptionRanges** @ranges);
    
    /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
    /// <param name="name">name of the option to get.</param>
    /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
    /// <param name="out_val">value of the option will be written here</param>
    /// <returns>&gt;=0 on success, a negative error code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, byte** @out_val);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_chlayout(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVChannelLayout* @layout);
    
    /// <param name="out_val">The returned dictionary is a copy of the actual value and must be freed with av_dict_free() by the caller</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_dict_val(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_double(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, double* @out_val);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_image_size(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_int(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, long* @out_val);
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rkey">parsed key; must be freed using av_free()</param>
    /// <param name="rval">parsed value; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_key_value(byte** @ropts,     
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
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_pixel_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_q(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_sample_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_get_video_rate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    
    /// <summary>Check if given option is set to its default value.</summary>
    /// <param name="obj">AVClass object to check option on</param>
    /// <param name="o">option to be checked</param>
    /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default, &lt; 0 on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_is_set_to_default(void* @obj, AVOption* @o);
    
    /// <summary>Check if given option is set to its default value.</summary>
    /// <param name="obj">AVClass object to check option on</param>
    /// <param name="name">option name</param>
    /// <param name="search_flags">combination of AV_OPT_SEARCH_*</param>
    /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default, &lt; 0 on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_is_set_to_default_by_name(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags);
    
    /// <summary>Iterate over all AVOptions belonging to obj.</summary>
    /// <param name="obj">an AVOptions-enabled struct or a double pointer to an AVClass describing it.</param>
    /// <param name="prev">result of the previous call to av_opt_next() on this object or NULL</param>
    /// <returns>next AVOption or NULL</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOption* av_opt_next(void* @obj, AVOption* @prev);
    
    /// <summary>Gets a pointer to the requested field in a struct. This function allows accessing a struct even when its fields are moved or renamed since the application making the access has been compiled,</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_opt_ptr(AVClass* @avclass, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Get a list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_query_ranges(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    
    /// <summary>Get a default list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_query_ranges_default(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    
    /// <summary>Serialize object&apos;s options.</summary>
    /// <param name="obj">AVClass object to serialize</param>
    /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
    /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
    /// <param name="buffer">Pointer to buffer that will be allocated with string containg serialized options. Buffer must be freed by the caller when is no longer needed.</param>
    /// <param name="key_val_sep">character used to separate key from value</param>
    /// <param name="pairs_sep">character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    
    /// <summary>@{ Those functions set the field of obj with the given name to value.</summary>
    /// <param name="obj">A struct whose first element is a pointer to an AVClass.</param>
    /// <param name="name">the name of the field to set</param>
    /// <param name="val">The value to set. In case of av_opt_set() if the field is not of a string type, then the given string is parsed. SI postfixes and some named scalars are supported. If the field is of a numeric type, it has to be a numeric or named scalar. Behavior with more than one scalar and +- infix operators is undefined. If the field is of a flags type, it has to be a sequence of numeric scalars or named flags separated by &apos;+&apos; or &apos;-&apos;. Prefixing a flag with &apos;+&apos; causes it to be set without affecting the other flags; similarly, &apos;-&apos; unsets a flag. If the field is of a dictionary type, it has to be a &apos;:&apos; separated list of key=value parameters. Values containing &apos;:&apos; special characters must be escaped.</param>
    /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be set on a child of obj.</param>
    /// <returns>0 if the value has been set, or an AVERROR code in case of error: AVERROR_OPTION_NOT_FOUND if no matching option exists AVERROR(ERANGE) if the value is out of range AVERROR(EINVAL) if the value is not valid</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set(void* @obj,     
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
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_bin(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, byte* @val, int @size, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_chlayout(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVChannelLayout* @layout, int @search_flags);
    
    /// <summary>Set the values of all AVOption fields to their default values.</summary>
    /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_opt_set_defaults(void* @s);
    
    /// <summary>Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt-&gt;flags &amp; mask) == flags will have their default applied to s.</summary>
    /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
    /// <param name="mask">combination of AV_OPT_FLAG_*</param>
    /// <param name="flags">combination of AV_OPT_FLAG_*</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_opt_set_defaults2(void* @s, int @mask, int @flags);
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_dict(void* @obj, AVDictionary** @options);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_dict_val(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVDictionary* @val, int @search_flags);
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_double(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, double @val, int @search_flags);
    
    /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
    /// <param name="ctx">the AVClass object to set options on</param>
    /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
    /// <param name="shorthand">a NULL-terminated array of options names for shorthand notation: if the first field in opts has no key part, the key is taken from the first element of shorthand; then again for the second, etc., until either opts is finished, shorthand is finished or a named option is found; after that, all options must be named</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <returns>the number of successfully set key=value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_set_string3() if a key/value pair cannot be set</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_from_string(void* @ctx,     
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
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_image_size(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @w, int @h, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_int(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, long @val, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_pixel_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_q(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_sample_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_set_video_rate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    
    /// <summary>Show the obj options.</summary>
    /// <param name="av_log_obj">log context to use for showing the options</param>
    /// <param name="req_flags">requested flags for the options to show. Show only the options for which it is opt-&gt;flags &amp; req_flags.</param>
    /// <param name="rej_flags">rejected flags for the options to show. Show only the options for which it is !(opt-&gt;flags &amp; req_flags).</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
    
    /// <summary>Audio output devices iterator.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d);
    
    /// <summary>Video output devices iterator.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d);
    
    /// <summary>Wrap an existing array as a packet side data.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to pkt.</param>
    /// <param name="size">side information size</param>
    /// <returns>a non-negative number on success, a negative AVERROR code on failure. On failure, the packet is unchanged and the data remains owned by the caller.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
    
    /// <summary>Allocate an AVPacket and set its fields to default values. The resulting struct must be freed using av_packet_free().</summary>
    /// <returns>An AVPacket filled with default values or NULL on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPacket* av_packet_alloc();
    
    /// <summary>Create a new packet that references the same data as src.</summary>
    /// <returns>newly created AVPacket on success, NULL on error.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPacket* av_packet_clone(AVPacket* @src);
    
    /// <summary>Copy only &quot;properties&quot; fields from src to dst.</summary>
    /// <param name="dst">Destination packet</param>
    /// <param name="src">Source packet</param>
    /// <returns>0 on success AVERROR on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_copy_props(AVPacket* @dst, AVPacket* @src);
    
    /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
    /// <param name="pkt">packet to be freed. The pointer will be set to NULL.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_free(AVPacket** @pkt);
    
    /// <summary>Convenience function to free all the side data stored. All the other fields stay untouched.</summary>
    /// <param name="pkt">packet</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_free_side_data(AVPacket* @pkt);
    
    /// <summary>Initialize a reference-counted packet from av_malloc()ed data.</summary>
    /// <param name="pkt">packet to be initialized. This function will set the data, size, and buf fields, all others are left untouched.</param>
    /// <param name="data">Data allocated by av_malloc() to be used as packet data. If this function returns successfully, the data is owned by the underlying AVBuffer. The caller may not access the data through other means.</param>
    /// <param name="size">size of data in bytes, without the padding. I.e. the full buffer size is assumed to be size + AV_INPUT_BUFFER_PADDING_SIZE.</param>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size);
    
    /// <summary>Get side information from packet.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
    /// <returns>pointer to data if present or NULL otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size);
    
    /// <summary>Ensure the data described by a given packet is reference counted.</summary>
    /// <param name="pkt">packet whose data should be made reference counted.</param>
    /// <returns>0 on success, a negative AVERROR on error. On failure, the packet is unchanged.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_make_refcounted(AVPacket* @pkt);
    
    /// <summary>Create a writable reference for the data described by a given packet, avoiding data copy if possible.</summary>
    /// <param name="pkt">Packet whose data should be made writable.</param>
    /// <returns>0 on success, a negative AVERROR on failure. On failure, the packet is unchanged.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_make_writable(AVPacket* @pkt);
    
    /// <summary>Move every field in src to dst and reset src.</summary>
    /// <param name="dst">Destination packet</param>
    /// <param name="src">Source packet, will be reset</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_move_ref(AVPacket* @dst, AVPacket* @src);
    
    /// <summary>Allocate new information of a packet.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="size">side information size</param>
    /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    
    /// <summary>Pack a dictionary for use in side_data.</summary>
    /// <param name="dict">The dictionary to pack.</param>
    /// <param name="size">pointer to store the size of the returned data</param>
    /// <returns>pointer to data if successful, NULL otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_packet_pack_dictionary(AVDictionary* @dict, ulong* @size);
    
    /// <summary>Setup a new reference to the data described by a given packet</summary>
    /// <param name="dst">Destination packet. Will be completely overwritten.</param>
    /// <param name="src">Source packet</param>
    /// <returns>0 on success, a negative AVERROR on error. On error, dst will be blank (as if returned by av_packet_alloc()).</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_ref(AVPacket* @dst, AVPacket* @src);
    
    /// <summary>Convert valid timing fields (timestamps / durations) in a packet from one timebase to another. Timestamps with unknown values (AV_NOPTS_VALUE) will be ignored.</summary>
    /// <param name="pkt">packet on which the conversion will be performed</param>
    /// <param name="tb_src">source timebase, in which the timing fields in pkt are expressed</param>
    /// <param name="tb_dst">destination timebase, to which the timing fields will be converted</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
    
    /// <summary>Shrink the already allocated side data buffer</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="size">new side information size</param>
    /// <returns>0 on success, &lt; 0 on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    
    /// <summary>Wrap existing data as packet side data.</summary>
    /// <param name="sd">pointer to an array of side data to which the side data should be added. *sd may be NULL, in which case the array will be initialized</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. The integer value will be increased by 1 on success.</param>
    /// <param name="type">side data type</param>
    /// <param name="data">a data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to the side data array on success</param>
    /// <param name="size">size of the data array</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise On failure, the side data array is unchanged and the data remains owned by the caller.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPacketSideData* av_packet_side_data_add(AVPacketSideData** @sd, int* @nb_sd, AVPacketSideDataType @type, void* @data, ulong @size, int @flags);
    
    /// <summary>Convenience function to free all the side data stored in an array, and the array itself.</summary>
    /// <param name="sd">pointer to array of side data to free. Will be set to NULL upon return.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_side_data_free(AVPacketSideData** @sd, int* @nb_sd);
    
    /// <summary>Get side information from a side data array.</summary>
    /// <param name="sd">the array from which the side data should be fetched</param>
    /// <param name="nb_sd">value containing the number of entries in the array.</param>
    /// <param name="type">desired side information type</param>
    /// <returns>pointer to side data if present or NULL otherwise</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPacketSideData* av_packet_side_data_get(AVPacketSideData* @sd, int @nb_sd, AVPacketSideDataType @type);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_packet_side_data_name(AVPacketSideDataType @type);
    
    /// <summary>Allocate a new packet side data.</summary>
    /// <param name="type">side data type</param>
    /// <param name="size">desired side data size</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPacketSideData* av_packet_side_data_new(AVPacketSideData** @psd, int* @pnb_sd, AVPacketSideDataType @type, ulong @size, int @flags);
    
    /// <summary>Remove side data of the given type from a side data array.</summary>
    /// <param name="sd">the array from which the side data should be removed</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be reduced by the amount of entries removed upon return</param>
    /// <param name="type">side information type</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_side_data_remove(AVPacketSideData* @sd, int* @nb_sd, AVPacketSideDataType @type);
    
    /// <summary>Unpack a dictionary from side_data.</summary>
    /// <param name="data">data from side_data</param>
    /// <param name="size">size of the data</param>
    /// <param name="dict">the metadata storage dictionary</param>
    /// <returns>0 on success, &lt; 0 on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_packet_unpack_dictionary(byte* @data, ulong @size, AVDictionary** @dict);
    
    /// <summary>Wipe the packet.</summary>
    /// <param name="pkt">The packet to be unreferenced.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_packet_unref(AVPacket* @pkt);
    
    /// <summary>Parse CPU caps from a string and update the given AV_CPU_* flags based on that.</summary>
    /// <returns>negative on error.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_parse_cpu_caps(uint* @flags,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_parser_close(AVCodecParserContext* @s);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecParserContext* av_parser_init(int @codec_id);
    
    /// <summary>Iterate over all registered codec parsers.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered codec parser or NULL when the iteration is finished</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecParser* av_parser_iterate(void** @opaque);
    
    /// <summary>Parse a packet.</summary>
    /// <param name="s">parser context.</param>
    /// <param name="avctx">codec context.</param>
    /// <param name="poutbuf">set to pointer to parsed buffer or NULL if not yet finished.</param>
    /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
    /// <param name="buf">input buffer.</param>
    /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
    /// <param name="pts">input presentation timestamp.</param>
    /// <param name="dts">input decoding timestamp.</param>
    /// <param name="pos">input byte position in stream.</param>
    /// <returns>the number of bytes of the input bitstream used.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
    
    /// <summary>Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</summary>
    /// <returns>number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt);
    
    /// <summary>Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</summary>
    /// <returns>a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt);
    
    /// <summary>Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</summary>
    /// <returns>an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc);
    
    /// <summary>Iterate over all pixel format descriptors known to libavutil.</summary>
    /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
    /// <returns>next descriptor or NULL after the last descriptor</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev);
    
    /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <param name="h_shift">store log2_chroma_w (horizontal/width shift)</param>
    /// <param name="v_shift">store log2_chroma_h (vertical/height shift)</param>
    /// <returns>0 on success, AVERROR(ENOSYS) on invalid or unknown pixel format</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
    
    /// <summary>Utility function to swap the endianness of a pixel format.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <returns>pixel format with swapped endianness if it exists, otherwise AV_PIX_FMT_NONE</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt);
    
    /// <summary>Send a nice dump of a packet to the log.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
    /// <param name="pkt">packet to dump</param>
    /// <param name="dump_payload">True if the payload must be displayed, too.</param>
    /// <param name="st">AVStream that the packet belongs to</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    
    /// <summary>Send a nice dump of a packet to the specified file stream.</summary>
    /// <param name="f">The file stream pointer where the dump should be sent to.</param>
    /// <param name="pkt">packet to dump</param>
    /// <param name="dump_payload">True if the payload must be displayed, too.</param>
    /// <param name="st">AVStream that the packet belongs to</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_pkt_dump2(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    
    /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    
    /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
    /// <param name="pb">the bytestream to probe</param>
    /// <param name="fmt">the input format is put here</param>
    /// <param name="url">the url of the stream</param>
    /// <param name="logctx">the log context</param>
    /// <param name="offset">the offset within the bytestream to probe from</param>
    /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
    /// <returns>the score in case of success, a negative value corresponding to an the maximal score is AVPROBE_SCORE_MAX AVERROR code otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    
    /// <summary>Guess the file format.</summary>
    /// <param name="pd">data to be probed</param>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened);
    
    /// <summary>Guess the file format.</summary>
    /// <param name="pd">data to be probed</param>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is &lt; = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max);
    
    /// <summary>Guess the file format.</summary>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    /// <param name="score_ret">The score of the best detection.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx);
    
    /// <summary>Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format.</summary>
    /// <param name="q">Rational to be converted</param>
    /// <returns>Equivalent floating-point value, expressed as an unsigned 32-bit integer.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_q2intfloat(AVRational @q);
    
    /// <summary>Return the next frame of a stream. This function returns what is stored in the file, and does not validate that what is there are valid frames for the decoder. It will split what is stored in the file into frames and return one for each call. It will not omit invalid data between valid frames so as to give the decoder the maximum information possible for decoding.</summary>
    /// <returns>0 if OK, &lt; 0 on error or end of file. On error, pkt will be blank (as if it came from av_packet_alloc()).</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_read_frame(AVFormatContext* @s, AVPacket* @pkt);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_read_image_line(ushort* @dst, in byte_ptr4 @data, in int4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
    
    /// <summary>Read a line from an image, and write the values of the pixel format component c to dst.</summary>
    /// <param name="data">the array containing the pointers to the planes of the image</param>
    /// <param name="linesize">the array containing the linesizes of the image</param>
    /// <param name="desc">the pixel format descriptor for the image</param>
    /// <param name="x">the horizontal coordinate of the first pixel to read</param>
    /// <param name="y">the vertical coordinate of the first pixel to read</param>
    /// <param name="w">the width of the line to read, that is the number of values to write to dst</param>
    /// <param name="read_pal_component">if not zero and the format is a paletted format writes the values corresponding to the palette component c in data[1] to dst, rather than the palette indexes in data[0]. The behavior is undefined if the format is not paletted.</param>
    /// <param name="dst_element_size">size of elements in dst array (2 or 4 byte)</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_read_image_line2(void* @dst, in byte_ptr4 @data, in int4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size);
    
    /// <summary>Pause a network-based stream (e.g. RTSP stream).</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_read_pause(AVFormatContext* @s);
    
    /// <summary>Start playing a network-based stream (e.g. RTSP stream) at the current position.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_read_play(AVFormatContext* @s);
    
    /// <summary>Allocate, reallocate, or free a block of memory.</summary>
    /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
    /// <param name="size">Size in bytes of the memory block to be allocated or reallocated</param>
    /// <returns>Pointer to a newly-reallocated block or `NULL` if the block cannot be reallocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_realloc(void* @ptr, ulong @size);
    
    /// <summary>Allocate, reallocate, or free an array.</summary>
    /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
    /// <param name="nmemb">Number of elements in the array</param>
    /// <param name="size">Size of the single element of the array</param>
    /// <returns>Pointer to a newly-reallocated block or NULL if the block cannot be reallocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size);
    
    /// <summary>Allocate, reallocate, or free a block of memory.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize);
    
    /// <summary>Allocate, reallocate, or free a block of memory through a pointer to a pointer.</summary>
    /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
    /// <param name="size">Size in bytes for the memory block to be allocated or reallocated</param>
    /// <returns>Zero on success, an AVERROR error code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_reallocp(void* @ptr, ulong @size);
    
    /// <summary>Allocate, reallocate an array through a pointer to a pointer.</summary>
    /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
    /// <param name="nmemb">Number of elements</param>
    /// <param name="size">Size of the single element</param>
    /// <returns>Zero on success, an AVERROR error code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size);
    
    /// <summary>Reduce a fraction.</summary>
    /// <param name="dst_num">Destination numerator</param>
    /// <param name="dst_den">Destination denominator</param>
    /// <param name="num">Source numerator</param>
    /// <param name="den">Source denominator</param>
    /// <param name="max">Maximum allowed values for `dst_num` &amp; `dst_den`</param>
    /// <returns>1 if the operation is exact, 0 otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
    
    /// <summary>Rescale a 64-bit integer with rounding to nearest.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_rescale(long @a, long @b, long @c);
    
    /// <summary>Rescale a timestamp while preserving known durations.</summary>
    /// <param name="in_tb">Input time base</param>
    /// <param name="in_ts">Input timestamp</param>
    /// <param name="fs_tb">Duration time base; typically this is finer-grained (greater) than `in_tb` and `out_tb`</param>
    /// <param name="duration">Duration till the next call to this function (i.e. duration of the current packet/frame)</param>
    /// <param name="last">Pointer to a timestamp expressed in terms of `fs_tb`, acting as a state variable</param>
    /// <param name="out_tb">Output timebase</param>
    /// <returns>Timestamp expressed in terms of `out_tb`</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
    
    /// <summary>Rescale a 64-bit integer by 2 rational numbers.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_rescale_q(long @a, AVRational @bq, AVRational @cq);
    
    /// <summary>Rescale a 64-bit integer by 2 rational numbers with specified rounding.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
    
    /// <summary>Rescale a 64-bit integer with specified rounding.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd);
    
    /// <summary>Check if the sample format is planar.</summary>
    /// <param name="sample_fmt">the sample format to inspect</param>
    /// <returns>1 if the sample format is planar, 0 if it is interleaved</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt);
    
    /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&amp;audio_data[0]) Allocated data will be initialized to silence.</summary>
    /// <param name="audio_data">array to be filled with the pointer for each channel</param>
    /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="nb_samples">number of samples per channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>&gt;=0 on success or a negative error code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    
    /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    
    /// <summary>Copy samples from src to dst.</summary>
    /// <param name="dst">destination array of pointers to data planes</param>
    /// <param name="src">source array of pointers to data planes</param>
    /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
    /// <param name="src_offset">offset in samples at which the data will be read from src</param>
    /// <param name="nb_samples">number of samples to be copied</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    
    /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
    /// <param name="audio_data">array to be filled with the pointer for each channel</param>
    /// <param name="linesize">calculated linesize, may be NULL</param>
    /// <param name="buf">the pointer to a buffer containing the samples</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <param name="nb_samples">the number of samples in a single channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>minimum size in bytes required for the buffer on success, or a negative error code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    
    /// <summary>Get the required buffer size for the given audio parameters.</summary>
    /// <param name="linesize">calculated linesize, may be NULL</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <param name="nb_samples">the number of samples in a single channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>required buffer size, or negative error code on failure</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    
    /// <summary>Fill an audio buffer with silence.</summary>
    /// <param name="audio_data">array of pointers to data planes</param>
    /// <param name="offset">offset in samples at which to start filling</param>
    /// <param name="nb_samples">number of samples to fill</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    
    /// <summary>Generate an SDP for an RTP session.</summary>
    /// <param name="ac">array of AVFormatContexts describing the RTP streams. If the array is composed by only one context, such context can contain multiple AVStreams (one AVStream per RTP stream). Otherwise, all the contexts in the array (an AVCodecContext per RTP stream) must contain only one AVStream.</param>
    /// <param name="n_files">number of AVCodecContexts contained in ac</param>
    /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
    /// <param name="size">the size of the buffer</param>
    /// <returns>0 if OK, AVERROR_xxx on error</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_sdp_create(AVFormatContext** @ac, int @n_files, byte* @buf, int @size);
    
    /// <summary>Seek to the keyframe at timestamp. &apos;timestamp&apos; in &apos;stream_index&apos;.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
    /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
    /// <param name="flags">flags which select direction and seeking mode</param>
    /// <returns>&gt;= 0 on success</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
    
    /// <summary>Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions.</summary>
    /// <param name="opts">options string to parse, may be NULL</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
    /// <returns>the number of successfully set key/value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_opt_set() if a key/value pair cannot be set</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_set_options_string(void* @ctx,     
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
    
    /// <summary>Reduce packet size, correctly zeroing padding</summary>
    /// <param name="pkt">packet</param>
    /// <param name="size">new size</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_shrink_packet(AVPacket* @pkt, int @size);
    
    /// <summary>Multiply two `size_t` values checking for overflow.</summary>
    /// <param name="a">Operand of multiplication</param>
    /// <param name="b">Operand of multiplication</param>
    /// <param name="r">Pointer to the result of the operation</param>
    /// <returns>0 on success, AVERROR(EINVAL) on overflow</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_size_mult(ulong @a, ulong @b, ulong* @r);
    
    /// <summary>Duplicate a string.</summary>
    /// <param name="s">String to be duplicated</param>
    /// <returns>Pointer to a newly-allocated string containing a copy of `s` or `NULL` if the string cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_strdup(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    
    /// <summary>Wrap an existing array as stream side data.</summary>
    /// <param name="st">stream</param>
    /// <param name="type">side information type</param>
    /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to st.</param>
    /// <param name="size">side information size</param>
    /// <returns>zero on success, a negative AVERROR code on failure. On failure, the stream is unchanged and the data remains owned by the caller.</returns>
    [Obsolete("use av_packet_side_data_add() with the stream's  \"codecpar side data\"")]
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_stream_add_side_data(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);
    
    /// <summary>Get the AVClass for AVStream. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* av_stream_get_class();
    
    /// <summary>Get the internal codec timebase from a stream.</summary>
    /// <param name="st">input stream to extract the timebase from</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_stream_get_codec_timebase(AVStream* @st);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecParserContext* av_stream_get_parser(AVStream* @s);
    
    /// <summary>Get side information from stream.</summary>
    /// <param name="stream">stream</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
    /// <returns>pointer to data if present or NULL otherwise</returns>
    [Obsolete("use av_packet_side_data_get() with the stream's  \"codecpar side data\"")]
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong* @size);
    
    /// <summary>Get the AVClass for AVStreamGroup. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* av_stream_group_get_class();
    
    /// <summary>Allocate new information from stream.</summary>
    /// <param name="stream">stream</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">side information size</param>
    /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
    [Obsolete("use av_packet_side_data_new() with the stream's  \"codecpar side data\"")]
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong @size);
    
    /// <summary>Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf.</summary>
    /// <param name="errnum">error code to describe</param>
    /// <param name="errbuf">buffer to which description is written</param>
    /// <param name="errbuf_size">the size in bytes of errbuf</param>
    /// <returns>0 on success, a negative value if a description for errnum cannot be found</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size);
    
    /// <summary>Duplicate a substring of a string.</summary>
    /// <param name="s">String to be duplicated</param>
    /// <param name="len">Maximum length of the resulting string (not counting the terminating byte)</param>
    /// <returns>Pointer to a newly-allocated string containing a substring of `s` or `NULL` if the string cannot be allocated</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_strndup(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s, ulong @len);
    
    /// <summary>Subtract one rational from another.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b-c</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVRational av_sub_q(AVRational @b, AVRational @c);
    
    /// <summary>Adjust frame number for NTSC drop frame time code.</summary>
    /// <param name="framenum">frame number to adjust</param>
    /// <param name="fps">frame per second, multiples of 30</param>
    /// <returns>adjusted frame number</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_timecode_adjust_ntsc_framenum2(int @framenum, int @fps);
    
    /// <summary>Check if the timecode feature is available for the given frame rate</summary>
    /// <returns>0 if supported, &lt; 0 otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_timecode_check_frame_rate(AVRational @rate);
    
    /// <summary>Convert sei info to SMPTE 12M binary representation.</summary>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="drop">drop flag</param>
    /// <param name="hh">hour</param>
    /// <param name="mm">minute</param>
    /// <param name="ss">second</param>
    /// <param name="ff">frame number</param>
    /// <returns>the SMPTE binary representation</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_timecode_get_smpte(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff);
    
    /// <summary>Convert frame number to SMPTE 12M binary representation.</summary>
    /// <param name="tc">timecode data correctly initialized</param>
    /// <param name="framenum">frame number</param>
    /// <returns>the SMPTE binary representation</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_timecode_get_smpte_from_framenum(AVTimecode* @tc, int @framenum);
    
    /// <summary>Init a timecode struct with the passed parameters.</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
    /// <param name="frame_start">the first frame number</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_timecode_init(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);
    
    /// <summary>Init a timecode struct from the passed timecode components.</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
    /// <param name="hh">hours</param>
    /// <param name="mm">minutes</param>
    /// <param name="ss">seconds</param>
    /// <param name="ff">frames</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_timecode_init_from_components(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx);
    
    /// <summary>Parse timecode representation (hh:mm:ss[:;.]ff).</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="str">timecode string which will determine the frame start</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log).</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_timecode_init_from_string(AVTimecode* @tc, AVRational @rate,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, void* @log_ctx);
    
    /// <summary>Get the timecode string from the 25-bit timecode format (MPEG GOP format).</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="tc25bit">the 25-bits timecode</param>
    /// <returns>the buf parameter</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_timecode_make_mpeg_tc_string(byte* @buf, uint @tc25bit);
    
    /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
    /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
    /// <returns>the buf parameter</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_timecode_make_smpte_tc_string(byte* @buf, uint @tcsmpte, int @prevent_df);
    
    /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="rate">frame rate of the timecode</param>
    /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
    /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
    /// <param name="skip_field">prevent the use of a field flag when it is known the field bit is arbitrary (e.g. because it is used as PC flag)</param>
    /// <returns>the buf parameter</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_timecode_make_smpte_tc_string2(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field);
    
    /// <summary>Load timecode string in buf.</summary>
    /// <param name="tc">timecode data correctly initialized</param>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="framenum">frame number</param>
    /// <returns>the buf parameter</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* av_timecode_make_string(AVTimecode* @tc, byte* @buf, int @framenum);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_tree_destroy(AVTreeNode* @t);
    
    /// <summary>Apply enu(opaque, &amp;elem) to all the elements in the tree in a given range.</summary>
    /// <param name="cmp">a comparison function that returns &lt; 0 for an element below the range, &gt; 0 for an element above the range and == 0 for an element inside the range</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_tree_enumerate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu);
    
    /// <summary>Find an element.</summary>
    /// <param name="root">a pointer to the root node of the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort It is guaranteed that the first and only the first argument to cmp() will be the key parameter to av_tree_find(), thus it could if the user wants, be a different type (like an opaque context).</param>
    /// <param name="next">If next is not NULL, then next[0] will contain the previous element and next[1] the next element. If either does not exist, then the corresponding entry in next is unchanged.</param>
    /// <returns>An element with cmp(key, elem) == 0 or NULL if no such element exists in the tree.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_tree_find(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptr2 @next);
    
    /// <summary>Insert or remove an element.</summary>
    /// <param name="rootp">A pointer to a pointer to the root node of the tree; note that the root node can change during insertions, this is required to keep the tree balanced.</param>
    /// <param name="key">pointer to the element key to insert in the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
    /// <param name="next">Used to allocate and free AVTreeNodes. For insertion the user must set it to an allocated and zeroed object of at least av_tree_node_size bytes size. av_tree_insert() will set it to NULL if it has been consumed. For deleting elements *next is set to NULL by the user and av_tree_insert() will set it to the AVTreeNode which was used for the removed element. This allows the use of flat arrays, which have lower overhead compared to many malloced elements. You might want to define a function like:</param>
    /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* av_tree_insert(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next);
    
    /// <summary>Allocate an AVTreeNode.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVTreeNode* av_tree_node_alloc();
    
    /// <summary>Split a URL string into components.</summary>
    /// <param name="proto">the buffer for the protocol</param>
    /// <param name="proto_size">the size of the proto buffer</param>
    /// <param name="authorization">the buffer for the authorization</param>
    /// <param name="authorization_size">the size of the authorization buffer</param>
    /// <param name="hostname">the buffer for the host name</param>
    /// <param name="hostname_size">the size of the hostname buffer</param>
    /// <param name="port_ptr">a pointer to store the port number in</param>
    /// <param name="path">the buffer for the path</param>
    /// <param name="path_size">the size of the path buffer</param>
    /// <param name="url">the URL to split</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    
    /// <summary>Sleep for a period of time. Although the duration is expressed in microseconds, the actual delay may be rounded to the precision of the system timer.</summary>
    /// <param name="usec">Number of microseconds to sleep.</param>
    /// <returns>zero on success or (negative) error code.</returns>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_usleep(uint @usec);
    
    /// <summary>Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string av_version_info();
    
    /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    /// <param name="vl">The arguments referenced by the format string.</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_vlog(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    
    /// <summary>Write a packet to an output media file.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet). This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output. Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;. The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets passed to this function must be strictly increasing when compared in their respective timebases (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing). &quot;duration&quot;) should also be set if known.</param>
    /// <returns>&lt; 0 on error, = 0 if OK, 1 if flushed and there is no more data to flush</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_write_frame(AVFormatContext* @s, AVPacket* @pkt);
    
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_write_image_line(ushort* @src, ref byte_ptr4 @data, in int4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
    
    /// <summary>Write the values from src to the pixel format component c of an image line.</summary>
    /// <param name="src">array containing the values to write</param>
    /// <param name="data">the array containing the pointers to the planes of the image to write into. It is supposed to be zeroed.</param>
    /// <param name="linesize">the array containing the linesizes of the image</param>
    /// <param name="desc">the pixel format descriptor for the image</param>
    /// <param name="x">the horizontal coordinate of the first pixel to write</param>
    /// <param name="y">the vertical coordinate of the first pixel to write</param>
    /// <param name="w">the width of the line to write, that is the number of values to write to the image line</param>
    /// <param name="src_element_size">size of elements in src array (2 or 4 byte)</param>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern void av_write_image_line2(void* @src, ref byte_ptr4 @data, in int4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size);
    
    /// <summary>Write the stream trailer to an output media file and free the file private data.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>0 if OK, AVERROR_xxx on error</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_write_trailer(AVFormatContext* @s);
    
    /// <summary>Write an uncoded frame to an output media file.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    
    /// <summary>Test whether a muxer supports uncoded frame.</summary>
    /// <returns>&gt;=0 if an uncoded frame can be written to that muxer and stream, &lt; 0 if not</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index);
    
    /// <summary>Encode extradata length to a buffer. Used by xiph codecs.</summary>
    /// <param name="s">buffer to write to; must be at least (v/255+1) bytes long</param>
    /// <param name="v">size of extradata in bytes</param>
    /// <returns>number of bytes written to the buffer.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint av_xiphlacing(byte* @s, uint @v);
    
    /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you do not use any horizontal padding.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height);
    
    /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you also ensure that all line sizes are a multiple of the respective linesize_align[i].</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, ref int8 @linesize_align);
    
    /// <summary>Allocate an AVCodecContext and set its fields to default values. The resulting struct should be freed with avcodec_free_context().</summary>
    /// <param name="codec">if non-NULL, allocate private data and initialize defaults for the given codec. It is illegal to then call avcodec_open2() with a different codec. If NULL, then the codec-specific defaults won&apos;t be initialized, which may result in suboptimal default settings (this is important mainly for encoders, e.g. libx264).</param>
    /// <returns>An AVCodecContext filled with default values or NULL on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* @codec);
    
    /// <summary>Close a given AVCodecContext and free all the data associated with it (but not the AVCodecContext itself).</summary>
    [Obsolete("Do not use this function. Use avcodec_free_context() to destroy a codec context (either open or closed). Opening and closing a codec context multiple times is not supported anymore -- use multiple codec contexts instead.")]
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_close(AVCodecContext* @avctx);
    
    /// <summary>Return the libavcodec build-time configuration.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avcodec_configuration();
    
    /// <summary>Decode a subtitle message. Return a negative value on error, otherwise return the number of bytes used. If no subtitle could be decompressed, got_sub_ptr is zero. Otherwise, the subtitle is stored in *sub. Note that AV_CODEC_CAP_DR1 is not available for subtitle codecs. This is for simplicity, because the performance difference is expected to be negligible and reusing a get_buffer written for video codecs would probably perform badly due to a potentially very different allocation pattern.</summary>
    /// <param name="avctx">the codec context</param>
    /// <param name="sub">The preallocated AVSubtitle in which the decoded subtitle will be stored, must be freed with avsubtitle_free if *got_sub_ptr is set.</param>
    /// <param name="got_sub_ptr">Zero if no subtitle could be decompressed, otherwise, it is nonzero.</param>
    /// <param name="avpkt">The input AVPacket containing the input buffer.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_default_execute(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_default_execute2(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);
    
    /// <summary>The default callback for AVCodecContext.get_buffer2(). It is made public so it can be called by custom get_buffer2() implementations for decoders without AV_CODEC_CAP_DR1 set.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags);
    
    /// <summary>The default callback for AVCodecContext.get_encode_buffer(). It is made public so it can be called by custom get_encode_buffer() implementations for encoders without AV_CODEC_CAP_DR1 set.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_default_get_encode_buffer(AVCodecContext* @s, AVPacket* @pkt, int @flags);
    
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt);
    
    /// <summary>Returns descriptor for given codec ID or NULL if no descriptor exists.</summary>
    /// <returns>descriptor for given codec ID or NULL if no descriptor exists.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id);
    
    /// <summary>Returns codec descriptor with the given name or NULL if no such descriptor exists.</summary>
    /// <returns>codec descriptor with the given name or NULL if no such descriptor exists.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Iterate over all codec descriptors known to libavcodec.</summary>
    /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
    /// <returns>next descriptor or NULL after the last descriptor</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev);
    
    /// <summary>@{</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
    
    /// <summary>Fill AVFrame audio data and linesize pointers.</summary>
    /// <param name="frame">the AVFrame frame-&gt;nb_samples must be set prior to calling the function. This function fills in frame-&gt;data, frame-&gt;extended_data, frame-&gt;linesize[0].</param>
    /// <param name="nb_channels">channel count</param>
    /// <param name="sample_fmt">sample format</param>
    /// <param name="buf">buffer to use for frame data</param>
    /// <param name="buf_size">size of buffer</param>
    /// <param name="align">plane size sample alignment (0 = default)</param>
    /// <returns>&gt;=0 on success, negative error code on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
    
    /// <summary>Find the best pixel format to convert to given a certain source pixel format. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. avcodec_find_best_pix_fmt_of_2() searches which of the given pixel formats should be used to suffer the least amount of loss. The pixel formats from which it chooses one, are determined by the pix_fmt_list parameter.</summary>
    /// <param name="pix_fmt_list">AV_PIX_FMT_NONE terminated array of pixel formats to choose from</param>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <param name="loss_ptr">Combination of flags informing you what kind of losses will occur.</param>
    /// <returns>The best pixel format to convert to or -1 if none was found.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    
    /// <summary>Find a registered decoder with a matching codec ID.</summary>
    /// <param name="id">AVCodecID of the requested decoder</param>
    /// <returns>A decoder if one was found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodec* avcodec_find_decoder(AVCodecID @id);
    
    /// <summary>Find a registered decoder with the specified name.</summary>
    /// <param name="name">name of the requested decoder</param>
    /// <returns>A decoder if one was found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodec* avcodec_find_decoder_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Find a registered encoder with a matching codec ID.</summary>
    /// <param name="id">AVCodecID of the requested encoder</param>
    /// <returns>An encoder if one was found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodec* avcodec_find_encoder(AVCodecID @id);
    
    /// <summary>Find a registered encoder with the specified name.</summary>
    /// <param name="name">name of the requested encoder</param>
    /// <returns>An encoder if one was found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodec* avcodec_find_encoder_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Reset the internal codec state / flush internal buffers. Should be called e.g. when seeking or when switching to a different stream.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_flush_buffers(AVCodecContext* @avctx);
    
    /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_free_context(AVCodecContext** @avctx);
    
    /// <summary>Get the AVClass for AVCodecContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* avcodec_get_class();
    
    /// <summary>Retrieve supported hardware configurations for a codec.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecHWConfig* avcodec_get_hw_config(AVCodec* @codec, int @index);
    
    /// <summary>Create and return a AVHWFramesContext with values adequate for hardware decoding. This is meant to get called from the get_format callback, and is a helper for preparing a AVHWFramesContext for AVCodecContext.hw_frames_ctx. This API is for decoding with certain hardware acceleration modes/APIs only.</summary>
    /// <param name="avctx">The context which is currently calling get_format, and which implicitly contains all state needed for filling the returned AVHWFramesContext properly.</param>
    /// <param name="device_ref">A reference to the AVHWDeviceContext describing the device which will be used by the hardware decoder.</param>
    /// <param name="hw_pix_fmt">The hwaccel format you are going to return from get_format.</param>
    /// <param name="out_frames_ref">On success, set to a reference to an _uninitialized_ AVHWFramesContext, created from the given device_ref. Fields will be set to values required for decoding. Not changed if an error is returned.</param>
    /// <returns>zero on success, a negative value on error. The following error codes have special semantics: AVERROR(ENOENT): the decoder does not support this functionality. Setup is always manual, or it is a decoder which does not support setting AVCodecContext.hw_frames_ctx at all, or it is a software format. AVERROR(EINVAL): it is known that hardware decoding is not supported for this configuration, or the device_ref is not supported for the hwaccel referenced by hw_pix_fmt.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_get_hw_frames_parameters(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref);
    
    /// <summary>Get the name of a codec.</summary>
    /// <returns>a static string identifying the codec; never NULL</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avcodec_get_name(AVCodecID @id);
    
    /// <summary>Get the AVClass for AVSubtitleRect. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* avcodec_get_subtitle_rect_class();
    
    /// <summary>Get the type of the given codec.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVMediaType avcodec_get_type(AVCodecID @codec_id);
    
    /// <summary>Returns a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</summary>
    /// <returns>a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_is_open(AVCodecContext* @s);
    
    /// <summary>Return the libavcodec license.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avcodec_license();
    
    /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
    /// <param name="avctx">The context to initialize.</param>
    /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
    /// <param name="options">A dictionary filled with AVCodecContext and codec-private options, which are set on top of the options already set in avctx, can be NULL. On return this object will be filled with options that were not found in the avctx codec context.</param>
    /// <returns>zero on success, a negative value on error</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
    
    /// <summary>Allocate a new AVCodecParameters and set its fields to default values (unknown/invalid/0). The returned struct must be freed with avcodec_parameters_free().</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecParameters* avcodec_parameters_alloc();
    
    /// <summary>Copy the contents of src to dst. Any allocated fields in dst are freed and replaced with newly allocated duplicates of the corresponding fields in src.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src);
    
    /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_parameters_free(AVCodecParameters** @par);
    
    /// <summary>Fill the parameters struct based on the values from the supplied codec context. Any allocated fields in par are freed and replaced with duplicates of the corresponding fields in codec.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec);
    
    /// <summary>Fill the codec context based on the values from the supplied codec parameters. Any allocated fields in codec that have a corresponding field in par are freed and replaced with duplicates of the corresponding field in par. Fields in codec that do not have a counterpart in par are not touched.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par);
    
    /// <summary>Return a value representing the fourCC code associated to the pixel format pix_fmt, or 0 if no associated fourCC code can be found.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt);
    
    /// <summary>Return a name for the specified profile, if available.</summary>
    /// <param name="codec_id">the ID of the codec to which the requested profile belongs</param>
    /// <param name="profile">the profile value for which a name is requested</param>
    /// <returns>A name for the profile if found, NULL otherwise.</returns>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avcodec_profile_name(AVCodecID @codec_id, int @profile);
    
    /// <summary>Return decoded output data from a decoder or encoder (when the AV_CODEC_FLAG_RECON_FRAME flag is used).</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame">This will be set to a reference-counted video or audio frame (depending on the decoder type) allocated by the codec. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame);
    
    /// <summary>Read encoded data from the encoder.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="avpkt">This will be set to a reference-counted packet allocated by the encoder. Note that the function will always call av_packet_unref(avpkt) before doing anything else.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
    
    /// <summary>Supply a raw video or audio frame to the encoder. Use avcodec_receive_packet() to retrieve buffered output packets.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame">AVFrame containing the raw audio or video frame to be encoded. Ownership of the frame remains with the caller, and the encoder will not write to the frame. The encoder may create a reference to the frame data (or copy it if the frame is not reference-counted). It can be NULL, in which case it is considered a flush packet.  This signals the end of the stream. If the encoder still has packets buffered, it will return them after this call. Once flushing mode has been entered, additional flush packets are ignored, and sending frames will return AVERROR_EOF.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame);
    
    /// <summary>Supply raw packet data as input to a decoder.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="avpkt">The input AVPacket. Usually, this will be a single video frame, or several complete audio frames. Ownership of the packet remains with the caller, and the decoder will not write to the packet. The decoder may create a reference to the packet data (or copy it if the packet is not reference-counted). Unlike with older APIs, the packet is always fully consumed, and if it contains multiple frames (e.g. some audio codecs), will require you to call avcodec_receive_frame() multiple times afterwards before you can send a new packet. It can be NULL (or an AVPacket with data set to NULL and size set to 0); in this case, it is considered a flush packet, which signals the end of the stream. Sending the first flush packet will return success. Subsequent ones are unnecessary and will return AVERROR_EOF. If the decoder still has frames buffered, it will return them after sending a flush packet.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
    
    /// <summary>@}</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
    
    /// <summary>Return the LIBAVCODEC_VERSION_INT constant.</summary>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avcodec_version();
    
    /// <summary>Send control message from application to device.</summary>
    /// <param name="s">device context.</param>
    /// <param name="type">message type.</param>
    /// <param name="data">message data. Exact type depends on message type.</param>
    /// <param name="data_size">size of message data.</param>
    /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when device doesn&apos;t implement handler of the message.</returns>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
    
    /// <summary>Return the libavdevice build-time configuration.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avdevice_configuration();
    
    /// <summary>Send control message from device to application.</summary>
    /// <param name="s">device context.</param>
    /// <param name="type">message type.</param>
    /// <param name="data">message data. Can be NULL.</param>
    /// <param name="data_size">size of message data.</param>
    /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when application doesn&apos;t implement handler of the message.</returns>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
    
    /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
    /// <param name="device_list">device list to be freed.</param>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avdevice_free_list_devices(AVDeviceInfoList** @device_list);
    
    /// <summary>Return the libavdevice license.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avdevice_license();
    
    /// <summary>List devices.</summary>
    /// <param name="s">device context.</param>
    /// <param name="device_list">list of autodetected devices.</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list);
    
    /// <summary>List devices.</summary>
    /// <param name="device">device format. May be NULL if device name is set.</param>
    /// <param name="device_name">device name. May be NULL if device format is set.</param>
    /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
    /// <param name="device_list">list of autodetected devices</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avdevice_list_input_sources(AVInputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avdevice_list_output_sinks(AVOutputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    
    /// <summary>Initialize libavdevice and register all the input and output devices.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avdevice_register_all();
    
    /// <summary>Return the LIBAVDEVICE_VERSION_INT constant.</summary>
    [DllImport("avdevice-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avdevice_version();
    
    [Obsolete("this function should never be called by users")]
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_config_links(AVFilterContext* @filter);
    
    /// <summary>Return the libavfilter build-time configuration.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avfilter_configuration();
    
    /// <summary>Get the number of elements in an AVFilter&apos;s inputs or outputs array.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avfilter_filter_pad_count(AVFilter* @filter, int @is_output);
    
    /// <summary>Free a filter context. This will also remove the filter from its filtergraph&apos;s list of filters.</summary>
    /// <param name="filter">the filter to free</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_free(AVFilterContext* @filter);
    
    /// <summary>Get a filter definition matching the given name.</summary>
    /// <param name="name">the filter name to find</param>
    /// <returns>the filter definition, if any matching one is registered. NULL if none found.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilter* avfilter_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Returns AVClass for AVFilterContext.</summary>
    /// <returns>AVClass for AVFilterContext.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* avfilter_get_class();
    
    /// <summary>Allocate a filter graph.</summary>
    /// <returns>the allocated filter graph on success or NULL.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilterGraph* avfilter_graph_alloc();
    
    /// <summary>Create a new filter instance in a filter graph.</summary>
    /// <param name="graph">graph in which the new filter will be used</param>
    /// <param name="filter">the filter to create an instance of</param>
    /// <param name="name">Name to give to the new instance (will be copied to AVFilterContext.name). This may be used by the caller to identify different filters, libavfilter itself assigns no semantics to this parameter. May be NULL.</param>
    /// <returns>the context of the newly created filter instance (note that it is also retrievable directly through AVFilterGraph.filters or with avfilter_graph_get_filter()) on success or NULL on failure.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Check validity and configure all the links and formats in the graph.</summary>
    /// <param name="graphctx">the filter graph</param>
    /// <param name="log_ctx">context used for logging</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code otherwise</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx);
    
    /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameter args. opaque is currently ignored.</summary>
    /// <param name="name">the instance name to give to the created filter instance</param>
    /// <param name="graph_ctx">the filter graph</param>
    /// <returns>a negative AVERROR error code in case of failure, a non negative value otherwise</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt,     
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
    
    /// <summary>Dump a graph into a human-readable string representation.</summary>
    /// <param name="graph">the graph to dump</param>
    /// <param name="options">formatting options; currently ignored</param>
    /// <returns>a string, or NULL in case of memory allocation failure; the string must be freed using av_free</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* avfilter_graph_dump(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @options);
    
    /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_graph_free(AVFilterGraph** @graph);
    
    /// <summary>Get a filter instance identified by instance name from graph.</summary>
    /// <param name="graph">filter graph to search through.</param>
    /// <param name="name">filter instance name (should be unique in the graph).</param>
    /// <returns>the pointer to the found filter instance or NULL if it cannot be found.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">linked list to the inputs of the graph</param>
    /// <param name="outputs">linked list to the outputs of the graph</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_parse(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <returns>non negative on success, a negative AVERROR code on error</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_parse_ptr(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_parse2(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    
    /// <summary>Queue a command for one or more filter instances.</summary>
    /// <param name="graph">the filter graph</param>
    /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
    /// <param name="cmd">the command to sent, for handling simplicity all commands must be alphanumeric only</param>
    /// <param name="arg">the argument for the command</param>
    /// <param name="ts">time at which the command should be sent to the filter</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_queue_command(AVFilterGraph* @graph,     
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
    
    /// <summary>Request a frame on the oldest sink link.</summary>
    /// <returns>the return value of ff_request_frame(), or AVERROR_EOF if all links returned AVERROR_EOF</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_request_oldest(AVFilterGraph* @graph);
    
    /// <summary>Apply all filter/link descriptions from a graph segment to the associated filtergraph.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">passed to avfilter_graph_segment_link()</param>
    /// <param name="outputs">passed to avfilter_graph_segment_link()</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_apply(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    
    /// <summary>Apply parsed options to filter instances in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_apply_opts(AVFilterGraphSegment* @seg, int @flags);
    
    /// <summary>Create filters specified in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_create_filters(AVFilterGraphSegment* @seg, int @flags);
    
    /// <summary>Free the provided AVFilterGraphSegment and everything associated with it.</summary>
    /// <param name="seg">double pointer to the AVFilterGraphSegment to be freed. NULL will be written to this pointer on exit from this function.</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_graph_segment_free(AVFilterGraphSegment** @seg);
    
    /// <summary>Initialize all filter instances in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_init(AVFilterGraphSegment* @seg, int @flags);
    
    /// <summary>Link filters in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_link(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    
    /// <summary>Parse a textual filtergraph description into an intermediate form.</summary>
    /// <param name="graph">Filter graph the parsed segment is associated with. Will only be used for logging and similar auxiliary purposes. The graph will not be actually modified by this function - the parsing results are instead stored in seg for further processing.</param>
    /// <param name="graph_str">a string describing the filtergraph segment</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="seg">A pointer to the newly-created AVFilterGraphSegment is written here on success. The graph segment is owned by the caller and must be freed with avfilter_graph_segment_free() before graph itself is freed.</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_segment_parse(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @graph_str, int @flags, AVFilterGraphSegment** @seg);
    
    /// <summary>Send a command to one or more filter instances.</summary>
    /// <param name="graph">the filter graph</param>
    /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
    /// <param name="cmd">the command to send, for handling simplicity all commands must be alphanumeric only</param>
    /// <param name="arg">the argument for the command</param>
    /// <param name="res">a buffer with size res_size where the filter(s) can return a response.</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_graph_send_command(AVFilterGraph* @graph,     
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
    
    /// <summary>Enable or disable automatic format conversion inside the graph.</summary>
    /// <param name="flags">any of the AVFILTER_AUTO_CONVERT_* constants</param>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags);
    
    /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
    /// <param name="ctx">uninitialized filter context to initialize</param>
    /// <param name="options">An AVDictionary filled with options for this filter. On return this parameter will be destroyed and replaced with a dict containing options that were not found. This dictionary must be freed by the caller. May be NULL, then this function is equivalent to avfilter_init_str() with the second parameter set to NULL.</param>
    /// <returns>0 on success, a negative AVERROR on failure</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options);
    
    /// <summary>Initialize a filter with the supplied parameters.</summary>
    /// <param name="ctx">uninitialized filter context to initialize</param>
    /// <param name="args">Options to initialize the filter with. This must be a &apos;:&apos;-separated list of options in the &apos;key=value&apos; form. May be NULL if the options have been set directly using the AVOptions API or there are no options that need to be set.</param>
    /// <returns>0 on success, a negative AVERROR on failure</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_init_str(AVFilterContext* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args);
    
    /// <summary>Allocate a single AVFilterInOut entry. Must be freed with avfilter_inout_free().</summary>
    /// <returns>allocated AVFilterInOut on success, NULL on failure.</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFilterInOut* avfilter_inout_alloc();
    
    /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_inout_free(AVFilterInOut** @inout);
    
    /// <summary>Insert a filter in the middle of an existing link.</summary>
    /// <param name="link">the link into which the filter should be inserted</param>
    /// <param name="filt">the filter to be inserted</param>
    /// <param name="filt_srcpad_idx">the input pad on the filter to connect</param>
    /// <param name="filt_dstpad_idx">the output pad on the filter to connect</param>
    /// <returns>zero on success</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
    
    /// <summary>Return the libavfilter license.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avfilter_license();
    
    /// <summary>Link two filters together.</summary>
    /// <param name="src">the source filter</param>
    /// <param name="srcpad">index of the output pad on the source filter</param>
    /// <param name="dst">the destination filter</param>
    /// <param name="dstpad">index of the input pad on the destination filter</param>
    /// <returns>zero on success</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
    
    [Obsolete("this function should never be called by users")]
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avfilter_link_free(AVFilterLink** @link);
    
    /// <summary>Get the name of an AVFilterPad.</summary>
    /// <param name="pads">an array of AVFilterPads</param>
    /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
    /// <returns>name of the pad_idx&apos;th pad in pads</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx);
    
    /// <summary>Get the type of an AVFilterPad.</summary>
    /// <param name="pads">an array of AVFilterPads</param>
    /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
    /// <returns>type of the pad_idx&apos;th pad in pads</returns>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx);
    
    /// <summary>Make the filter instance process a command. It is recommended to use avfilter_graph_send_command().</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avfilter_process_command(AVFilterContext* @filter,     
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
    
    /// <summary>Return the LIBAVFILTER_VERSION_INT constant.</summary>
    [DllImport("avfilter-10", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avfilter_version();
    
    /// <summary>Allocate an AVFormatContext. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVFormatContext* avformat_alloc_context();
    
    /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
    /// <param name="ctx">pointee is set to the created format context, or to NULL in case of failure</param>
    /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
    /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
    /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat,     
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
    
    /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avformat_close_input(AVFormatContext** @s);
    
    /// <summary>Return the libavformat build-time configuration.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avformat_configuration();
    
    /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="options">If non-NULL, an ic.nb_streams long array of pointers to dictionaries, where i-th member contains options for codec corresponding to i-th stream. On return each dictionary will be filled with options that were not found.</param>
    /// <returns>&gt;=0 if OK, AVERROR_xxx on error</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options);
    
    /// <summary>Discard all internally buffered data. This can be useful when dealing with discontinuities in the byte stream. Generally works only with formats that can resync. This includes headerless formats like MPEG-TS/TS but should also work with NUT, Ogg and in a limited way AVI for example.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>&gt;=0 on success, error code otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_flush(AVFormatContext* @s);
    
    /// <summary>Free an AVFormatContext and all its streams.</summary>
    /// <param name="s">context to free</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avformat_free_context(AVFormatContext* @s);
    
    /// <summary>Get the AVClass for AVFormatContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* avformat_get_class();
    
    /// <summary>Returns the table mapping MOV FourCCs for audio to AVCodecID.</summary>
    /// <returns>the table mapping MOV FourCCs for audio to AVCodecID.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecTag* avformat_get_mov_audio_tags();
    
    /// <summary>Returns the table mapping MOV FourCCs for video to libavcodec AVCodecID.</summary>
    /// <returns>the table mapping MOV FourCCs for video to libavcodec AVCodecID.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecTag* avformat_get_mov_video_tags();
    
    /// <summary>Returns the table mapping RIFF FourCCs for audio to AVCodecID.</summary>
    /// <returns>the table mapping RIFF FourCCs for audio to AVCodecID.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecTag* avformat_get_riff_audio_tags();
    
    /// <summary>@{ Get the tables mapping RIFF FourCCs to libavcodec AVCodecIDs. The tables are meant to be passed to av_codec_get_id()/av_codec_get_tag() as in the following code:</summary>
    /// <returns>the table mapping RIFF FourCCs for video to libavcodec AVCodecID.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVCodecTag* avformat_get_riff_video_tags();
    
    /// <summary>Get the index entry count for the given AVStream.</summary>
    /// <param name="st">stream</param>
    /// <returns>the number of index entries in the stream</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_index_get_entries_count(AVStream* @st);
    
    /// <summary>Get the AVIndexEntry corresponding to the given index.</summary>
    /// <param name="st">Stream containing the requested AVIndexEntry.</param>
    /// <param name="idx">The desired index.</param>
    /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVIndexEntry* avformat_index_get_entry(AVStream* @st, int @idx);
    
    /// <summary>Get the AVIndexEntry corresponding to the given timestamp.</summary>
    /// <param name="st">Stream containing the requested AVIndexEntry.</param>
    /// <param name="wanted_timestamp">Timestamp to retrieve the index entry for.</param>
    /// <param name="flags">If AVSEEK_FLAG_BACKWARD then the returned entry will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise.</param>
    /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVIndexEntry* avformat_index_get_entry_from_timestamp(AVStream* @st, long @wanted_timestamp, int @flags);
    
    /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header() to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header().</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    /// <param name="options">An ::AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_init_output(AVFormatContext* @s, AVDictionary** @options);
    
    /// <summary>Return the libavformat license.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avformat_license();
    
    /// <summary>Check if the stream st contained in s is matched by the stream specifier spec.</summary>
    /// <returns>&gt;0 if st is matched by spec; 0  if st is not matched by spec; AVERROR code if spec is invalid</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @spec);
    
    /// <summary>Undo the initialization done by avformat_network_init. Call it only once for each time you called avformat_network_init.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_network_deinit();
    
    /// <summary>Do global initialization of network libraries. This is optional, and not recommended anymore.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_network_init();
    
    /// <summary>Add a new stream to a media file.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="c">unused, does nothing</param>
    /// <returns>newly created stream or NULL on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c);
    
    /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
    /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
    /// <param name="url">URL of the stream to open.</param>
    /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
    /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_open_input(AVFormatContext** @ps,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options);
    
    /// <summary>Test if the given container can store a codec.</summary>
    /// <param name="ofmt">container to check for compatibility</param>
    /// <param name="codec_id">codec to potentially store in container</param>
    /// <param name="std_compliance">standards compliance level, one of FF_COMPLIANCE_*</param>
    /// <returns>1 if codec with ID codec_id can be stored in ofmt, 0 if it cannot. A negative number if this information is not available.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_queue_attached_pictures(AVFormatContext* @s);
    
    /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream_index">index of the stream which is used as time base reference</param>
    /// <param name="min_ts">smallest acceptable timestamp</param>
    /// <param name="ts">target timestamp</param>
    /// <param name="max_ts">largest acceptable timestamp</param>
    /// <param name="flags">flags</param>
    /// <returns>&gt;=0 on success, error code otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
    
    /// <summary>Add an already allocated stream to a stream group.</summary>
    /// <param name="stg">stream group belonging to a media file.</param>
    /// <param name="st">stream in the media file to add to the group.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_stream_group_add_stream(AVStreamGroup* @stg, AVStream* @st);
    
    /// <summary>Add a new empty stream group to a media file.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>newly created group or NULL on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVStreamGroup* avformat_stream_group_create(AVFormatContext* @s, AVStreamGroupParamsType @type, AVDictionary** @options);
    
    /// <summary>Returns a string identifying the stream group type, or NULL if unknown</summary>
    /// <returns>a string identifying the stream group type, or NULL if unknown</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avformat_stream_group_name(AVStreamGroupParamsType @type);
    
    /// <summary>Transfer internal timing information from one stream to another.</summary>
    /// <param name="ofmt">target output format for ost</param>
    /// <param name="ost">output stream which needs timings copy and adjustments</param>
    /// <param name="ist">reference input stream to copy timings from</param>
    /// <param name="copy_tb">define from where the stream codec timebase needs to be imported</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
    
    /// <summary>Return the LIBAVFORMAT_VERSION_INT constant.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avformat_version();
    
    /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    /// <param name="options">An ::AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avformat_write_header(AVFormatContext* @s, AVDictionary** @options);
    
    /// <summary>Accept and allocate a client context on a server context.</summary>
    /// <param name="s">the server context</param>
    /// <param name="c">the client context, must be unallocated</param>
    /// <returns>&gt;= 0 on success or a negative value corresponding to an AVERROR on failure</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_accept(AVIOContext* @s, AVIOContext** @c);
    
    /// <summary>Allocate and initialize an AVIOContext for buffered I/O. It must be later freed with avio_context_free().</summary>
    /// <param name="buffer">Memory block for input/output operations via AVIOContext. The buffer must be allocated with av_malloc() and friends. It may be freed and replaced with a new buffer by libavformat. AVIOContext.buffer holds the buffer currently in use, which must be later freed with av_free().</param>
    /// <param name="buffer_size">The buffer size is very important for performance. For protocols with fixed blocksize it should be set to this blocksize. For others a typical size is a cache page, e.g. 4kb.</param>
    /// <param name="write_flag">Set to 1 if the buffer should be writable, 0 otherwise.</param>
    /// <param name="opaque">An opaque pointer to user-specific data.</param>
    /// <param name="read_packet">A function for refilling the buffer, may be NULL. For stream protocols, must never return 0 but rather a proper AVERROR code.</param>
    /// <param name="write_packet">A function for writing the buffer contents, may be NULL. The function may not change the input buffers content.</param>
    /// <param name="seek">A function for seeking to specified byte position, may be NULL.</param>
    /// <returns>Allocated AVIOContext or NULL on failure.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);
    
    /// <summary>Return AVIO_FLAG_* access flags corresponding to the access permissions of the resource in url, or a negative value corresponding to an AVERROR code in case of failure. The returned access flags are masked by the value in flags.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_check(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    
    /// <summary>Close the resource accessed by the AVIOContext s and free it. This function can only be used if s was opened by avio_open().</summary>
    /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_close(AVIOContext* @s);
    
    /// <summary>Close directory.</summary>
    /// <param name="s">directory read context.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_close_dir(AVIODirContext** @s);
    
    /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <param name="pbuffer">pointer to a byte buffer</param>
    /// <returns>the length of the byte buffer</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer);
    
    /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
    /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_closep(AVIOContext** @s);
    
    /// <summary>Free the supplied IO context and everything associated with it.</summary>
    /// <param name="s">Double pointer to the IO context. This function will write NULL into s.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_context_free(AVIOContext** @s);
    
    /// <summary>Iterate through names of available protocols.</summary>
    /// <param name="opaque">A private pointer representing current protocol. It must be a pointer to NULL on first iteration and will be updated by successive calls to avio_enum_protocols.</param>
    /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
    /// <returns>A static string containing the name of current protocol or NULL</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avio_enum_protocols(void** @opaque, int @output);
    
    /// <summary>Similar to feof() but also returns nonzero on read errors.</summary>
    /// <returns>non zero if and only if at end of file or a read error happened when reading.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_feof(AVIOContext* @s);
    
    /// <summary>Return the name of the protocol that will handle the passed URL.</summary>
    /// <returns>Name of the protocol or NULL.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avio_find_protocol_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    
    /// <summary>Force flushing of buffered data.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_flush(AVIOContext* @s);
    
    /// <summary>Free entry allocated by avio_read_dir().</summary>
    /// <param name="entry">entry to be freed.</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_free_directory_entry(AVIODirEntry** @entry);
    
    /// <summary>Return the written size and a pointer to the buffer. The AVIOContext stream is left intact. The buffer must NOT be freed. No padding is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <param name="pbuffer">pointer to a byte buffer</param>
    /// <returns>the length of the byte buffer</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_get_dyn_buf(AVIOContext* @s, byte** @pbuffer);
    
    /// <summary>Read a string from pb into buf. The reading will terminate when either a NULL character was encountered, maxlen bytes have been read, or nothing more can be read from pb. The result is guaranteed to be NULL-terminated, it will be truncated if buf is too small. Note that the string is not interpreted or validated in any way, it might get truncated in the middle of a sequence for multi-byte encodings.</summary>
    /// <returns>number of bytes read (is always &lt; = maxlen). If reading ends on EOF or error, the return value will be one more than bytes actually read.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    
    /// <summary>Read a UTF-16 string from pb and convert it to UTF-8. The reading will terminate when either a null or invalid character was encountered or maxlen bytes have been read.</summary>
    /// <returns>number of bytes read (is always &lt; = maxlen)</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    
    /// <summary>Perform one step of the protocol handshake to accept a new client. This function must be called on a client returned by avio_accept() before using it as a read/write context. It is separate from avio_accept() because it may block. A step of the handshake is defined by places where the application may decide to change the proceedings. For example, on a protocol with a request header and a reply header, each one can constitute a step because the application may use the parameters from the request to change parameters in the reply; or each individual chunk of the request can constitute a step. If the handshake is already finished, avio_handshake() does nothing and returns 0 immediately.</summary>
    /// <param name="c">the client context to perform the handshake on</param>
    /// <returns>0   on a complete and successful handshake &gt; 0 if the handshake progressed, but is not complete &lt; 0 for an AVERROR code</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_handshake(AVIOContext* @c);
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_open(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    
    /// <summary>Open directory for reading.</summary>
    /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
    /// <param name="url">directory to be listed.</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_open_dir(AVIODirContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVDictionary** @options);
    
    /// <summary>Open a write only memory stream.</summary>
    /// <param name="s">new IO context</param>
    /// <returns>zero if no error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_open_dyn_buf(AVIOContext** @s);
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_open2(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
    
    /// <summary>Pause and resume playing - only meaningful if using a network streaming protocol (e.g. MMS).</summary>
    /// <param name="h">IO context from which to call the read_pause function pointer</param>
    /// <param name="pause">1 for pause, 0 for resume</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_pause(AVIOContext* @h, int @pause);
    
    /// <summary>Write a NULL terminated array of strings to the context. Usually you don&apos;t need to use this function directly but its macro wrapper, avio_print.</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_print_string_array(AVIOContext* @s, byte*[] @strings);
    
    /// <summary>Writes a formatted string to the context.</summary>
    /// <returns>number of bytes written, &lt; 0 on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_printf(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    
    /// <summary>Get AVClass by names of available protocols.</summary>
    /// <returns>A AVClass of input protocol name or NULL</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* avio_protocol_get_class(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    
    /// <summary>Write a NULL-terminated string.</summary>
    /// <returns>number of bytes written.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_put_str(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    
    /// <summary>Convert an UTF-8 string to UTF-16BE and write it.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="str">NULL-terminated UTF-8 string</param>
    /// <returns>number of bytes written.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_put_str16be(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    
    /// <summary>Convert an UTF-8 string to UTF-16LE and write it.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="str">NULL-terminated UTF-8 string</param>
    /// <returns>number of bytes written.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_put_str16le(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    
    /// <summary>@{</summary>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_r8(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rb16(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rb24(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rb32(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong avio_rb64(AVIOContext* @s);
    
    /// <summary>Read size bytes from AVIOContext into buf.</summary>
    /// <returns>number of bytes read or AVERROR</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_read(AVIOContext* @s, byte* @buf, int @size);
    
    /// <summary>Get next directory entry.</summary>
    /// <param name="s">directory read context.</param>
    /// <param name="next">next entry or NULL when no more entries.</param>
    /// <returns>&gt;=0 on success or negative on error. End of list is not considered an error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next);
    
    /// <summary>Read size bytes from AVIOContext into buf. Unlike avio_read(), this is allowed to read fewer bytes than requested. The missing bytes can be read in the next call. This always tries to read at least 1 byte. Useful to reduce latency in certain cases.</summary>
    /// <returns>number of bytes read or AVERROR</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_read_partial(AVIOContext* @s, byte* @buf, int @size);
    
    /// <summary>Read contents of h into print buffer, up to max_size bytes, or up to EOF.</summary>
    /// <returns>0 for success (max_size bytes read or EOF reached), negative error code otherwise</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_read_to_bprint(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rl16(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rl24(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avio_rl32(AVIOContext* @s);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong avio_rl64(AVIOContext* @s);
    
    /// <summary>fseek() equivalent for AVIOContext.</summary>
    /// <returns>new position or AVERROR.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern long avio_seek(AVIOContext* @s, long @offset, int @whence);
    
    /// <summary>Seek to a given timestamp relative to some component stream. Only meaningful if using a network streaming protocol (e.g. MMS.).</summary>
    /// <param name="h">IO context from which to call the seek function pointers</param>
    /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index &gt;= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
    /// <param name="timestamp">timestamp in AVStream.time_base units or if there is no stream specified then in AV_TIME_BASE units.</param>
    /// <param name="flags">Optional combination of AVSEEK_FLAG_BACKWARD, AVSEEK_FLAG_BYTE and AVSEEK_FLAG_ANY. The protocol may silently ignore AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will fail if used and not supported.</param>
    /// <returns>&gt;= 0 on success</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
    
    /// <summary>Get the filesize.</summary>
    /// <returns>filesize or AVERROR</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern long avio_size(AVIOContext* @s);
    
    /// <summary>Skip given number of bytes forward</summary>
    /// <returns>new position or AVERROR.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern long avio_skip(AVIOContext* @s, long @offset);
    
    /// <summary>Writes a formatted string to the context taking a va_list.</summary>
    /// <returns>number of bytes written, &lt; 0 on error.</returns>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern int avio_vprintf(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @ap);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_w8(AVIOContext* @s, int @b);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wb16(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wb24(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wb32(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wb64(AVIOContext* @s, ulong @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wl16(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wl24(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wl32(AVIOContext* @s, uint @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_wl64(AVIOContext* @s, ulong @val);
    
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_write(AVIOContext* @s, byte* @buf, int @size);
    
    /// <summary>Mark the written bytestream as a specific type.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="time">the stream time the current bytestream pos corresponds to (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
    /// <param name="type">the kind of data written starting at the current pos</param>
    [DllImport("avformat-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type);
    
    /// <summary>Free all allocated data in the given subtitle struct.</summary>
    /// <param name="sub">AVSubtitle to free.</param>
    [DllImport("avcodec-61", CallingConvention = CallingConvention.Cdecl)]
    public static extern void avsubtitle_free(AVSubtitle* @sub);
    
    /// <summary>Return the libavutil build-time configuration.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avutil_configuration();
    
    /// <summary>Return the libavutil license.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string avutil_license();
    
    /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
    [DllImport("avutil-59", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint avutil_version();
    
    /// <summary>Return the libpostproc build-time configuration.</summary>
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string postproc_configuration();
    
    /// <summary>Return the libpostproc license.</summary>
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string postproc_license();
    
    /// <summary>Return the LIBPOSTPROC_VERSION_INT constant.</summary>
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint postproc_version();
    
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern void pp_free_context(void* @ppContext);
    
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern void pp_free_mode(void* @mode);
    
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* pp_get_context(int @width, int @height, int @flags);
    
    /// <summary>Return a pp_mode or NULL if an error occurred.</summary>
    /// <param name="name">the string after &quot;-pp&quot; on the command line</param>
    /// <param name="quality">a number from 0 to PP_QUALITY_MAX</param>
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* pp_get_mode_by_name_and_quality(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @quality);
    
    [DllImport("postproc-58", CallingConvention = CallingConvention.Cdecl)]
    public static extern void pp_postprocess(in byte_ptr3 @src, in int3 @srcStride, ref byte_ptr3 @dst, in int3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
    
    /// <summary>Allocate SwrContext.</summary>
    /// <returns>NULL on error, allocated context otherwise</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwrContext* swr_alloc();
    
    /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
    /// <param name="ps">Pointer to an existing Swr context if available, or to NULL if not. On success, *ps will be set to the allocated context.</param>
    /// <param name="out_ch_layout">output channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
    /// <param name="in_ch_layout">input channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
    /// <param name="log_offset">logging level offset</param>
    /// <param name="log_ctx">parent logging context, can be NULL</param>
    /// <returns>0 on success, a negative AVERROR code on error. On error, the Swr context is freed and *ps set to NULL.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_alloc_set_opts2(SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
    
    /// <summary>Generate a channel mixing matrix.</summary>
    /// <param name="in_layout">input channel layout</param>
    /// <param name="out_layout">output channel layout</param>
    /// <param name="center_mix_level">mix level for the center channel</param>
    /// <param name="surround_mix_level">mix level for the surround channel(s)</param>
    /// <param name="lfe_mix_level">mix level for the low-frequency effects channel</param>
    /// <param name="matrix">mixing coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o.</param>
    /// <param name="stride">distance between adjacent input channels in the matrix array</param>
    /// <param name="matrix_encoding">matrixed stereo downmix mode (e.g. dplii)</param>
    /// <returns>0 on success, negative AVERROR code on failure</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_build_matrix2(AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context);
    
    /// <summary>Closes the context so that swr_is_initialized() returns 0.</summary>
    /// <param name="s">Swr context to be closed</param>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern void swr_close(SwrContext* @s);
    
    /// <summary>Configure or reconfigure the SwrContext using the information provided by the AVFrames.</summary>
    /// <param name="swr">audio resample context</param>
    /// <param name="out">output AVFrame</param>
    /// <param name="in">input AVFrame</param>
    /// <returns>0 on success, AVERROR on failure.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
    
    /// <summary>Convert audio.</summary>
    /// <param name="s">allocated Swr context, with parameters set</param>
    /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
    /// <param name="out_count">amount of space available for output in samples per channel</param>
    /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
    /// <param name="in_count">number of input samples available in one channel</param>
    /// <returns>number of samples output per channel, negative value on error</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_convert(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);
    
    /// <summary>Convert the samples in the input AVFrame and write them to the output AVFrame.</summary>
    /// <param name="swr">audio resample context</param>
    /// <param name="output">output AVFrame</param>
    /// <param name="input">input AVFrame</param>
    /// <returns>0 on success, AVERROR on failure or nonmatching configuration.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
    
    /// <summary>Drops the specified number of output samples.</summary>
    /// <param name="s">allocated Swr context</param>
    /// <param name="count">number of samples to be dropped</param>
    /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_drop_output(SwrContext* @s, int @count);
    
    /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
    /// <param name="s">a pointer to a pointer to Swr context</param>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern void swr_free(SwrContext** @s);
    
    /// <summary>Get the AVClass for SwrContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    /// <returns>the AVClass of SwrContext</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* swr_get_class();
    
    /// <summary>Gets the delay the next input sample will experience relative to the next output sample.</summary>
    /// <param name="s">swr context</param>
    /// <param name="base">timebase in which the returned delay will be:</param>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern long swr_get_delay(SwrContext* @s, long @base);
    
    /// <summary>Find an upper bound on the number of samples that the next swr_convert call will output, if called with in_samples of input samples. This depends on the internal state, and anything changing the internal state (like further swr_convert() calls) will may change the number of samples swr_get_out_samples() returns for the same number of input samples.</summary>
    /// <param name="in_samples">number of input samples.</param>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_get_out_samples(SwrContext* @s, int @in_samples);
    
    /// <summary>Initialize context after user parameters have been set.</summary>
    /// <param name="s">Swr context to initialize</param>
    /// <returns>AVERROR error code in case of failure.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_init(SwrContext* @s);
    
    /// <summary>Injects the specified number of silence samples.</summary>
    /// <param name="s">allocated Swr context</param>
    /// <param name="count">number of samples to be dropped</param>
    /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_inject_silence(SwrContext* @s, int @count);
    
    /// <summary>Check whether an swr context has been initialized or not.</summary>
    /// <param name="s">Swr context to check</param>
    /// <returns>positive if it has been initialized, 0 if not initialized</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_is_initialized(SwrContext* @s);
    
    /// <summary>Convert the next timestamp from input to output timestamps are in 1/(in_sample_rate * out_sample_rate) units.</summary>
    /// <param name="s">initialized Swr context</param>
    /// <param name="pts">timestamp for the next input sample, INT64_MIN if unknown</param>
    /// <returns>the output timestamp for the next output sample</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern long swr_next_pts(SwrContext* @s, long @pts);
    
    /// <summary>Set a customized input channel mapping.</summary>
    /// <param name="s">allocated Swr context, not yet initialized</param>
    /// <param name="channel_map">customized input channel mapping (array of channel indexes, -1 for a muted channel)</param>
    /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_set_channel_mapping(SwrContext* @s, int* @channel_map);
    
    /// <summary>Activate resampling compensation (&quot;soft&quot; compensation). This function is internally called when needed in swr_next_pts().</summary>
    /// <param name="s">allocated Swr context. If it is not initialized, or SWR_FLAG_RESAMPLE is not set, swr_init() is called with the flag set.</param>
    /// <param name="sample_delta">delta in PTS per sample</param>
    /// <param name="compensation_distance">number of samples to compensate for</param>
    /// <returns>&gt;= 0 on success, AVERROR error codes if:</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_set_compensation(SwrContext* @s, int @sample_delta, int @compensation_distance);
    
    /// <summary>Set a customized remix matrix.</summary>
    /// <param name="s">allocated Swr context, not yet initialized</param>
    /// <param name="matrix">remix coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o</param>
    /// <param name="stride">offset between lines of the matrix</param>
    /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern int swr_set_matrix(SwrContext* @s, double* @matrix, int @stride);
    
    /// <summary>Return the swr build-time configuration.</summary>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string swresample_configuration();
    
    /// <summary>Return the swr license.</summary>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string swresample_license();
    
    /// <summary>Return the LIBSWRESAMPLE_VERSION_INT constant.</summary>
    [DllImport("swresample-5", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint swresample_version();
    
    /// <summary>Allocate an empty SwsContext. This must be filled and passed to sws_init_context(). For filling see AVOptions, options.c and sws_setColorspaceDetails().</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsContext* sws_alloc_context();
    
    /// <summary>Allocate and return an uninitialized vector with length coefficients.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsVector* sws_allocVec(int @length);
    
    /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 24 bits.</summary>
    /// <param name="src">source frame buffer</param>
    /// <param name="dst">destination frame buffer</param>
    /// <param name="num_pixels">number of pixels to convert</param>
    /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    
    /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 32 bits.</summary>
    /// <param name="src">source frame buffer</param>
    /// <param name="dst">destination frame buffer</param>
    /// <param name="num_pixels">number of pixels to convert</param>
    /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    
    /// <summary>Finish the scaling process for a pair of source/destination frames previously submitted with sws_frame_start(). Must be called after all sws_send_slice() and sws_receive_slice() calls are done, before any new sws_frame_start() calls.</summary>
    /// <param name="c">The scaling context</param>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_frame_end(SwsContext* @c);
    
    /// <summary>Initialize the scaling process for a given pair of source/destination frames. Must be called before any calls to sws_send_slice() and sws_receive_slice().</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="dst">The destination frame.</param>
    /// <param name="src">The source frame. The data buffers must be allocated, but the frame data does not have to be ready at this point. Data availability is then signalled by sws_send_slice().</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_frame_start(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Free the swscaler context swsContext. If swsContext is NULL, then does nothing.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_freeContext(SwsContext* @swsContext);
    
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_freeFilter(SwsFilter* @filter);
    
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_freeVec(SwsVector* @a);
    
    /// <summary>Get the AVClass for swsContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern AVClass* sws_get_class();
    
    /// <summary>Check if context can be reused, otherwise reallocate a new one.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsContext* sws_getCachedContext(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    
    /// <summary>Return a pointer to yuv&lt;-&gt;rgb coefficients for the given colorspace suitable for sws_setColorspaceDetails().</summary>
    /// <param name="colorspace">One of the SWS_CS_* macros. If invalid, SWS_CS_DEFAULT is used.</param>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int* sws_getCoefficients(int @colorspace);
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
    
    /// <summary>Allocate and return an SwsContext. You need it to perform scaling/conversion operations using sws_scale().</summary>
    /// <param name="srcW">the width of the source image</param>
    /// <param name="srcH">the height of the source image</param>
    /// <param name="srcFormat">the source image format</param>
    /// <param name="dstW">the width of the destination image</param>
    /// <param name="dstH">the height of the destination image</param>
    /// <param name="dstFormat">the destination image format</param>
    /// <param name="flags">specify which algorithm and options to use for rescaling</param>
    /// <param name="param">extra parameters to tune the used scaler For SWS_BICUBIC param[0] and [1] tune the shape of the basis function, param[0] tunes f(1) and param[1] f´(1) For SWS_GAUSS param[0] tunes the exponent and thus cutoff frequency For SWS_LANCZOS param[0] tunes the width of the window function</param>
    /// <returns>a pointer to an allocated context, or NULL in case of error</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsContext* sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
    
    /// <summary>Return a normalized Gaussian curve used to filter stuff quality = 3 is high quality, lower is lower quality.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern SwsVector* sws_getGaussianVec(double @variance, double @quality);
    
    /// <summary>Initialize the swscaler context sws_context.</summary>
    /// <returns>zero or positive value on success, a negative value on error</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_init_context(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
    
    /// <summary>Returns a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <returns>a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt);
    
    /// <summary>Return a positive value if pix_fmt is a supported input format, 0 otherwise.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_isSupportedInput(AVPixelFormat @pix_fmt);
    
    /// <summary>Return a positive value if pix_fmt is a supported output format, 0 otherwise.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_isSupportedOutput(AVPixelFormat @pix_fmt);
    
    /// <summary>Scale all the coefficients of a so that their sum equals height.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_normalizeVec(SwsVector* @a, double @height);
    
    /// <summary>Request a horizontal slice of the output data to be written into the frame previously provided to sws_frame_start().</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="slice_start">first row of the slice; must be a multiple of sws_receive_slice_alignment()</param>
    /// <param name="slice_height">number of rows in the slice; must be a multiple of sws_receive_slice_alignment(), except for the last slice (i.e. when slice_start+slice_height is equal to output frame height)</param>
    /// <returns>a non-negative number if the data was successfully written into the output AVERROR(EAGAIN) if more input data needs to be provided before the output can be produced another negative AVERROR code on other kinds of scaling failure</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_receive_slice(SwsContext* @c, uint @slice_start, uint @slice_height);
    
    /// <summary>Get the alignment required for slices</summary>
    /// <param name="c">The scaling context</param>
    /// <returns>alignment required for output slices requested with sws_receive_slice(). Slice offsets and sizes passed to sws_receive_slice() must be multiples of the value returned from this function.</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint sws_receive_slice_alignment(SwsContext* @c);
    
    /// <summary>Scale the image slice in srcSlice and put the resulting scaled slice in the image in dst. A slice is a sequence of consecutive rows in an image.</summary>
    /// <param name="c">the scaling context previously created with sws_getContext()</param>
    /// <param name="srcSlice">the array containing the pointers to the planes of the source slice</param>
    /// <param name="srcStride">the array containing the strides for each plane of the source image</param>
    /// <param name="srcSliceY">the position in the source image of the slice to process, that is the number (counted starting from zero) in the image of the first row of the slice</param>
    /// <param name="srcSliceH">the height of the source slice, that is the number of rows in the slice</param>
    /// <param name="dst">the array containing the pointers to the planes of the destination image</param>
    /// <param name="dstStride">the array containing the strides for each plane of the destination image</param>
    /// <returns>the height of the output slice</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_scale(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
    
    /// <summary>Scale source data from src and write the output to dst.</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="dst">The destination frame. See documentation for sws_frame_start() for more details.</param>
    /// <param name="src">The source frame.</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_scale_frame(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    
    /// <summary>Scale all the coefficients of a by the scalar value.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sws_scaleVec(SwsVector* @a, double @scalar);
    
    /// <summary>Indicate that a horizontal slice of input data is available in the source frame previously provided to sws_frame_start(). The slices may be provided in any order, but may not overlap. For vertically subsampled pixel formats, the slices must be aligned according to subsampling.</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="slice_start">first row of the slice</param>
    /// <param name="slice_height">number of rows in the slice</param>
    /// <returns>a non-negative number on success, a negative AVERROR code on failure.</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_send_slice(SwsContext* @c, uint @slice_start, uint @slice_height);
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <param name="c">the scaling context</param>
    /// <param name="inv_table">the yuv2rgb coefficients describing the input yuv space, normally ff_yuv2rgb_coeffs[x]</param>
    /// <param name="srcRange">flag indicating the while-black range of the input (1=jpeg / 0=mpeg)</param>
    /// <param name="table">the yuv2rgb coefficients describing the output yuv space, normally ff_yuv2rgb_coeffs[x]</param>
    /// <param name="dstRange">flag indicating the while-black range of the output (1=jpeg / 0=mpeg)</param>
    /// <param name="brightness">16.16 fixed point brightness correction</param>
    /// <param name="contrast">16.16 fixed point contrast correction</param>
    /// <param name="saturation">16.16 fixed point saturation correction</param>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern int sws_setColorspaceDetails(SwsContext* @c, in int4 @inv_table, int @srcRange, in int4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);
    
    /// <summary>Return the libswscale build-time configuration.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string swscale_configuration();
    
    /// <summary>Return the libswscale license.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string swscale_license();
    
    /// <summary>Color conversion and scaling library.</summary>
    [DllImport("swscale-8", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint swscale_version();
    
    public unsafe static void Initialize()
    {
        vectors.av_add_index_entry = av_add_index_entry;
        vectors.av_add_q = av_add_q;
        vectors.av_add_stable = av_add_stable;
        vectors.av_append_packet = av_append_packet;
        vectors.av_audio_fifo_alloc = av_audio_fifo_alloc;
        vectors.av_audio_fifo_drain = av_audio_fifo_drain;
        vectors.av_audio_fifo_free = av_audio_fifo_free;
        vectors.av_audio_fifo_peek = av_audio_fifo_peek;
        vectors.av_audio_fifo_peek_at = av_audio_fifo_peek_at;
        vectors.av_audio_fifo_read = av_audio_fifo_read;
        vectors.av_audio_fifo_realloc = av_audio_fifo_realloc;
        vectors.av_audio_fifo_reset = av_audio_fifo_reset;
        vectors.av_audio_fifo_size = av_audio_fifo_size;
        vectors.av_audio_fifo_space = av_audio_fifo_space;
        vectors.av_audio_fifo_write = av_audio_fifo_write;
        vectors.av_bessel_i0 = av_bessel_i0;
        vectors.av_bsf_alloc = av_bsf_alloc;
        vectors.av_bsf_flush = av_bsf_flush;
        vectors.av_bsf_free = av_bsf_free;
        vectors.av_bsf_get_by_name = av_bsf_get_by_name;
        vectors.av_bsf_get_class = av_bsf_get_class;
        vectors.av_bsf_get_null_filter = av_bsf_get_null_filter;
        vectors.av_bsf_init = av_bsf_init;
        vectors.av_bsf_iterate = av_bsf_iterate;
        vectors.av_bsf_list_alloc = av_bsf_list_alloc;
        vectors.av_bsf_list_append = av_bsf_list_append;
        vectors.av_bsf_list_append2 = av_bsf_list_append2;
        vectors.av_bsf_list_finalize = av_bsf_list_finalize;
        vectors.av_bsf_list_free = av_bsf_list_free;
        vectors.av_bsf_list_parse_str = av_bsf_list_parse_str;
        vectors.av_bsf_receive_packet = av_bsf_receive_packet;
        vectors.av_bsf_send_packet = av_bsf_send_packet;
        vectors.av_buffer_alloc = av_buffer_alloc;
        vectors.av_buffer_allocz = av_buffer_allocz;
        vectors.av_buffer_create = av_buffer_create;
        vectors.av_buffer_default_free = av_buffer_default_free;
        vectors.av_buffer_get_opaque = av_buffer_get_opaque;
        vectors.av_buffer_get_ref_count = av_buffer_get_ref_count;
        vectors.av_buffer_is_writable = av_buffer_is_writable;
        vectors.av_buffer_make_writable = av_buffer_make_writable;
        vectors.av_buffer_pool_buffer_get_opaque = av_buffer_pool_buffer_get_opaque;
        vectors.av_buffer_pool_get = av_buffer_pool_get;
        vectors.av_buffer_pool_init = av_buffer_pool_init;
        vectors.av_buffer_pool_init2 = av_buffer_pool_init2;
        vectors.av_buffer_pool_uninit = av_buffer_pool_uninit;
        vectors.av_buffer_realloc = av_buffer_realloc;
        vectors.av_buffer_ref = av_buffer_ref;
        vectors.av_buffer_replace = av_buffer_replace;
        vectors.av_buffer_unref = av_buffer_unref;
        vectors.av_buffersink_get_ch_layout = av_buffersink_get_ch_layout;
        vectors.av_buffersink_get_channels = av_buffersink_get_channels;
        vectors.av_buffersink_get_color_range = av_buffersink_get_color_range;
        vectors.av_buffersink_get_colorspace = av_buffersink_get_colorspace;
        vectors.av_buffersink_get_format = av_buffersink_get_format;
        vectors.av_buffersink_get_frame = av_buffersink_get_frame;
        vectors.av_buffersink_get_frame_flags = av_buffersink_get_frame_flags;
        vectors.av_buffersink_get_frame_rate = av_buffersink_get_frame_rate;
        vectors.av_buffersink_get_h = av_buffersink_get_h;
        vectors.av_buffersink_get_hw_frames_ctx = av_buffersink_get_hw_frames_ctx;
        vectors.av_buffersink_get_sample_aspect_ratio = av_buffersink_get_sample_aspect_ratio;
        vectors.av_buffersink_get_sample_rate = av_buffersink_get_sample_rate;
        vectors.av_buffersink_get_samples = av_buffersink_get_samples;
        vectors.av_buffersink_get_time_base = av_buffersink_get_time_base;
        vectors.av_buffersink_get_type = av_buffersink_get_type;
        vectors.av_buffersink_get_w = av_buffersink_get_w;
        vectors.av_buffersink_set_frame_size = av_buffersink_set_frame_size;
        vectors.av_buffersrc_add_frame = av_buffersrc_add_frame;
        vectors.av_buffersrc_add_frame_flags = av_buffersrc_add_frame_flags;
        vectors.av_buffersrc_close = av_buffersrc_close;
        vectors.av_buffersrc_get_nb_failed_requests = av_buffersrc_get_nb_failed_requests;
        vectors.av_buffersrc_parameters_alloc = av_buffersrc_parameters_alloc;
        vectors.av_buffersrc_parameters_set = av_buffersrc_parameters_set;
        vectors.av_buffersrc_write_frame = av_buffersrc_write_frame;
        vectors.av_calloc = av_calloc;
        vectors.av_channel_description = av_channel_description;
        vectors.av_channel_description_bprint = av_channel_description_bprint;
        vectors.av_channel_from_string = av_channel_from_string;
        vectors.av_channel_layout_channel_from_index = av_channel_layout_channel_from_index;
        vectors.av_channel_layout_channel_from_string = av_channel_layout_channel_from_string;
        vectors.av_channel_layout_check = av_channel_layout_check;
        vectors.av_channel_layout_compare = av_channel_layout_compare;
        vectors.av_channel_layout_copy = av_channel_layout_copy;
        vectors.av_channel_layout_custom_init = av_channel_layout_custom_init;
        vectors.av_channel_layout_default = av_channel_layout_default;
        vectors.av_channel_layout_describe = av_channel_layout_describe;
        vectors.av_channel_layout_describe_bprint = av_channel_layout_describe_bprint;
        vectors.av_channel_layout_from_mask = av_channel_layout_from_mask;
        vectors.av_channel_layout_from_string = av_channel_layout_from_string;
        vectors.av_channel_layout_index_from_channel = av_channel_layout_index_from_channel;
        vectors.av_channel_layout_index_from_string = av_channel_layout_index_from_string;
        vectors.av_channel_layout_retype = av_channel_layout_retype;
        vectors.av_channel_layout_standard = av_channel_layout_standard;
        vectors.av_channel_layout_subset = av_channel_layout_subset;
        vectors.av_channel_layout_uninit = av_channel_layout_uninit;
        vectors.av_channel_name = av_channel_name;
        vectors.av_channel_name_bprint = av_channel_name_bprint;
        vectors.av_chroma_location_enum_to_pos = av_chroma_location_enum_to_pos;
        vectors.av_chroma_location_from_name = av_chroma_location_from_name;
        vectors.av_chroma_location_name = av_chroma_location_name;
        vectors.av_chroma_location_pos_to_enum = av_chroma_location_pos_to_enum;
        vectors.av_codec_get_id = av_codec_get_id;
        vectors.av_codec_get_tag = av_codec_get_tag;
        vectors.av_codec_get_tag2 = av_codec_get_tag2;
        vectors.av_codec_is_decoder = av_codec_is_decoder;
        vectors.av_codec_is_encoder = av_codec_is_encoder;
        vectors.av_codec_iterate = av_codec_iterate;
        vectors.av_color_primaries_from_name = av_color_primaries_from_name;
        vectors.av_color_primaries_name = av_color_primaries_name;
        vectors.av_color_range_from_name = av_color_range_from_name;
        vectors.av_color_range_name = av_color_range_name;
        vectors.av_color_space_from_name = av_color_space_from_name;
        vectors.av_color_space_name = av_color_space_name;
        vectors.av_color_transfer_from_name = av_color_transfer_from_name;
        vectors.av_color_transfer_name = av_color_transfer_name;
        vectors.av_compare_mod = av_compare_mod;
        vectors.av_compare_ts = av_compare_ts;
        vectors.av_content_light_metadata_alloc = av_content_light_metadata_alloc;
        vectors.av_content_light_metadata_create_side_data = av_content_light_metadata_create_side_data;
        vectors.av_cpb_properties_alloc = av_cpb_properties_alloc;
        vectors.av_cpu_count = av_cpu_count;
        vectors.av_cpu_force_count = av_cpu_force_count;
        vectors.av_cpu_max_align = av_cpu_max_align;
        vectors.av_d2q = av_d2q;
        vectors.av_d3d11va_alloc_context = av_d3d11va_alloc_context;
        vectors.av_default_get_category = av_default_get_category;
        vectors.av_default_item_name = av_default_item_name;
        vectors.av_demuxer_iterate = av_demuxer_iterate;
        vectors.av_dict_copy = av_dict_copy;
        vectors.av_dict_count = av_dict_count;
        vectors.av_dict_free = av_dict_free;
        vectors.av_dict_get = av_dict_get;
        vectors.av_dict_get_string = av_dict_get_string;
        vectors.av_dict_iterate = av_dict_iterate;
        vectors.av_dict_parse_string = av_dict_parse_string;
        vectors.av_dict_set = av_dict_set;
        vectors.av_dict_set_int = av_dict_set_int;
        vectors.av_display_matrix_flip = av_display_matrix_flip;
        vectors.av_display_rotation_get = av_display_rotation_get;
        vectors.av_display_rotation_set = av_display_rotation_set;
        vectors.av_disposition_from_string = av_disposition_from_string;
        vectors.av_disposition_to_string = av_disposition_to_string;
        vectors.av_div_q = av_div_q;
        vectors.av_dump_format = av_dump_format;
        vectors.av_dynamic_hdr_plus_alloc = av_dynamic_hdr_plus_alloc;
        vectors.av_dynamic_hdr_plus_create_side_data = av_dynamic_hdr_plus_create_side_data;
        vectors.av_dynamic_hdr_plus_from_t35 = av_dynamic_hdr_plus_from_t35;
        vectors.av_dynamic_hdr_plus_to_t35 = av_dynamic_hdr_plus_to_t35;
        vectors.av_dynarray_add = av_dynarray_add;
        vectors.av_dynarray_add_nofree = av_dynarray_add_nofree;
        vectors.av_dynarray2_add = av_dynarray2_add;
        vectors.av_fast_malloc = av_fast_malloc;
        vectors.av_fast_mallocz = av_fast_mallocz;
        vectors.av_fast_padded_malloc = av_fast_padded_malloc;
        vectors.av_fast_padded_mallocz = av_fast_padded_mallocz;
        vectors.av_fast_realloc = av_fast_realloc;
        vectors.av_file_map = av_file_map;
        vectors.av_file_unmap = av_file_unmap;
        vectors.av_filename_number_test = av_filename_number_test;
        vectors.av_filter_iterate = av_filter_iterate;
        vectors.av_find_best_pix_fmt_of_2 = av_find_best_pix_fmt_of_2;
        vectors.av_find_best_stream = av_find_best_stream;
        vectors.av_find_default_stream_index = av_find_default_stream_index;
        vectors.av_find_input_format = av_find_input_format;
        vectors.av_find_nearest_q_idx = av_find_nearest_q_idx;
        vectors.av_find_program_from_stream = av_find_program_from_stream;
        vectors.av_fmt_ctx_get_duration_estimation_method = av_fmt_ctx_get_duration_estimation_method;
        vectors.av_force_cpu_flags = av_force_cpu_flags;
        vectors.av_format_inject_global_side_data = av_format_inject_global_side_data;
        vectors.av_fourcc_make_string = av_fourcc_make_string;
        vectors.av_frame_alloc = av_frame_alloc;
        vectors.av_frame_apply_cropping = av_frame_apply_cropping;
        vectors.av_frame_clone = av_frame_clone;
        vectors.av_frame_copy = av_frame_copy;
        vectors.av_frame_copy_props = av_frame_copy_props;
        vectors.av_frame_free = av_frame_free;
        vectors.av_frame_get_buffer = av_frame_get_buffer;
        vectors.av_frame_get_plane_buffer = av_frame_get_plane_buffer;
        vectors.av_frame_get_side_data = av_frame_get_side_data;
        vectors.av_frame_is_writable = av_frame_is_writable;
        vectors.av_frame_make_writable = av_frame_make_writable;
        vectors.av_frame_move_ref = av_frame_move_ref;
        vectors.av_frame_new_side_data = av_frame_new_side_data;
        vectors.av_frame_new_side_data_from_buf = av_frame_new_side_data_from_buf;
        vectors.av_frame_ref = av_frame_ref;
        vectors.av_frame_remove_side_data = av_frame_remove_side_data;
        vectors.av_frame_replace = av_frame_replace;
        vectors.av_frame_side_data_clone = av_frame_side_data_clone;
        vectors.av_frame_side_data_free = av_frame_side_data_free;
        vectors.av_frame_side_data_get_c = av_frame_side_data_get_c;
        vectors.av_frame_side_data_name = av_frame_side_data_name;
        vectors.av_frame_side_data_new = av_frame_side_data_new;
        vectors.av_frame_unref = av_frame_unref;
        vectors.av_free = av_free;
        vectors.av_freep = av_freep;
        vectors.av_gcd = av_gcd;
        vectors.av_gcd_q = av_gcd_q;
        vectors.av_get_alt_sample_fmt = av_get_alt_sample_fmt;
        vectors.av_get_audio_frame_duration = av_get_audio_frame_duration;
        vectors.av_get_audio_frame_duration2 = av_get_audio_frame_duration2;
        vectors.av_get_bits_per_pixel = av_get_bits_per_pixel;
        vectors.av_get_bits_per_sample = av_get_bits_per_sample;
        vectors.av_get_bytes_per_sample = av_get_bytes_per_sample;
        vectors.av_get_cpu_flags = av_get_cpu_flags;
        vectors.av_get_exact_bits_per_sample = av_get_exact_bits_per_sample;
        vectors.av_get_frame_filename = av_get_frame_filename;
        vectors.av_get_frame_filename2 = av_get_frame_filename2;
        vectors.av_get_media_type_string = av_get_media_type_string;
        vectors.av_get_output_timestamp = av_get_output_timestamp;
        vectors.av_get_packed_sample_fmt = av_get_packed_sample_fmt;
        vectors.av_get_packet = av_get_packet;
        vectors.av_get_padded_bits_per_pixel = av_get_padded_bits_per_pixel;
        vectors.av_get_pcm_codec = av_get_pcm_codec;
        vectors.av_get_picture_type_char = av_get_picture_type_char;
        vectors.av_get_pix_fmt = av_get_pix_fmt;
        vectors.av_get_pix_fmt_loss = av_get_pix_fmt_loss;
        vectors.av_get_pix_fmt_name = av_get_pix_fmt_name;
        vectors.av_get_pix_fmt_string = av_get_pix_fmt_string;
        vectors.av_get_planar_sample_fmt = av_get_planar_sample_fmt;
        vectors.av_get_profile_name = av_get_profile_name;
        vectors.av_get_sample_fmt = av_get_sample_fmt;
        vectors.av_get_sample_fmt_name = av_get_sample_fmt_name;
        vectors.av_get_sample_fmt_string = av_get_sample_fmt_string;
        vectors.av_get_time_base_q = av_get_time_base_q;
        vectors.av_gettime = av_gettime;
        vectors.av_gettime_relative = av_gettime_relative;
        vectors.av_gettime_relative_is_monotonic = av_gettime_relative_is_monotonic;
        vectors.av_grow_packet = av_grow_packet;
        vectors.av_guess_codec = av_guess_codec;
        vectors.av_guess_format = av_guess_format;
        vectors.av_guess_frame_rate = av_guess_frame_rate;
        vectors.av_guess_sample_aspect_ratio = av_guess_sample_aspect_ratio;
        vectors.av_hex_dump = av_hex_dump;
        vectors.av_hex_dump_log = av_hex_dump_log;
        vectors.av_hwdevice_ctx_alloc = av_hwdevice_ctx_alloc;
        vectors.av_hwdevice_ctx_create = av_hwdevice_ctx_create;
        vectors.av_hwdevice_ctx_create_derived = av_hwdevice_ctx_create_derived;
        vectors.av_hwdevice_ctx_create_derived_opts = av_hwdevice_ctx_create_derived_opts;
        vectors.av_hwdevice_ctx_init = av_hwdevice_ctx_init;
        vectors.av_hwdevice_find_type_by_name = av_hwdevice_find_type_by_name;
        vectors.av_hwdevice_get_hwframe_constraints = av_hwdevice_get_hwframe_constraints;
        vectors.av_hwdevice_get_type_name = av_hwdevice_get_type_name;
        vectors.av_hwdevice_hwconfig_alloc = av_hwdevice_hwconfig_alloc;
        vectors.av_hwdevice_iterate_types = av_hwdevice_iterate_types;
        vectors.av_hwframe_constraints_free = av_hwframe_constraints_free;
        vectors.av_hwframe_ctx_alloc = av_hwframe_ctx_alloc;
        vectors.av_hwframe_ctx_create_derived = av_hwframe_ctx_create_derived;
        vectors.av_hwframe_ctx_init = av_hwframe_ctx_init;
        vectors.av_hwframe_get_buffer = av_hwframe_get_buffer;
        vectors.av_hwframe_map = av_hwframe_map;
        vectors.av_hwframe_transfer_data = av_hwframe_transfer_data;
        vectors.av_hwframe_transfer_get_formats = av_hwframe_transfer_get_formats;
        vectors.av_image_alloc = av_image_alloc;
        vectors.av_image_check_sar = av_image_check_sar;
        vectors.av_image_check_size = av_image_check_size;
        vectors.av_image_check_size2 = av_image_check_size2;
        vectors.av_image_copy = av_image_copy;
        vectors.av_image_copy_plane = av_image_copy_plane;
        vectors.av_image_copy_plane_uc_from = av_image_copy_plane_uc_from;
        vectors.av_image_copy_to_buffer = av_image_copy_to_buffer;
        vectors.av_image_copy_uc_from = av_image_copy_uc_from;
        vectors.av_image_fill_arrays = av_image_fill_arrays;
        vectors.av_image_fill_black = av_image_fill_black;
        vectors.av_image_fill_color = av_image_fill_color;
        vectors.av_image_fill_linesizes = av_image_fill_linesizes;
        vectors.av_image_fill_max_pixsteps = av_image_fill_max_pixsteps;
        vectors.av_image_fill_plane_sizes = av_image_fill_plane_sizes;
        vectors.av_image_fill_pointers = av_image_fill_pointers;
        vectors.av_image_get_buffer_size = av_image_get_buffer_size;
        vectors.av_image_get_linesize = av_image_get_linesize;
        vectors.av_index_search_timestamp = av_index_search_timestamp;
        vectors.av_init_packet = av_init_packet;
        vectors.av_input_audio_device_next = av_input_audio_device_next;
        vectors.av_input_video_device_next = av_input_video_device_next;
        vectors.av_int_list_length_for_size = av_int_list_length_for_size;
        vectors.av_interleaved_write_frame = av_interleaved_write_frame;
        vectors.av_interleaved_write_uncoded_frame = av_interleaved_write_uncoded_frame;
        vectors.av_log = av_log;
        vectors.av_log_default_callback = av_log_default_callback;
        vectors.av_log_format_line = av_log_format_line;
        vectors.av_log_format_line2 = av_log_format_line2;
        vectors.av_log_get_flags = av_log_get_flags;
        vectors.av_log_get_level = av_log_get_level;
        vectors.av_log_once = av_log_once;
        vectors.av_log_set_callback = av_log_set_callback;
        vectors.av_log_set_flags = av_log_set_flags;
        vectors.av_log_set_level = av_log_set_level;
        vectors.av_log2 = av_log2;
        vectors.av_log2_16bit = av_log2_16bit;
        vectors.av_malloc = av_malloc;
        vectors.av_malloc_array = av_malloc_array;
        vectors.av_mallocz = av_mallocz;
        vectors.av_mastering_display_metadata_alloc = av_mastering_display_metadata_alloc;
        vectors.av_mastering_display_metadata_create_side_data = av_mastering_display_metadata_create_side_data;
        vectors.av_match_ext = av_match_ext;
        vectors.av_max_alloc = av_max_alloc;
        vectors.av_memcpy_backptr = av_memcpy_backptr;
        vectors.av_memdup = av_memdup;
        vectors.av_mul_q = av_mul_q;
        vectors.av_muxer_iterate = av_muxer_iterate;
        vectors.av_nearer_q = av_nearer_q;
        vectors.av_new_packet = av_new_packet;
        vectors.av_new_program = av_new_program;
        vectors.av_opt_child_class_iterate = av_opt_child_class_iterate;
        vectors.av_opt_child_next = av_opt_child_next;
        vectors.av_opt_copy = av_opt_copy;
        vectors.av_opt_eval_double = av_opt_eval_double;
        vectors.av_opt_eval_flags = av_opt_eval_flags;
        vectors.av_opt_eval_float = av_opt_eval_float;
        vectors.av_opt_eval_int = av_opt_eval_int;
        vectors.av_opt_eval_int64 = av_opt_eval_int64;
        vectors.av_opt_eval_q = av_opt_eval_q;
        vectors.av_opt_find = av_opt_find;
        vectors.av_opt_find2 = av_opt_find2;
        vectors.av_opt_flag_is_set = av_opt_flag_is_set;
        vectors.av_opt_free = av_opt_free;
        vectors.av_opt_freep_ranges = av_opt_freep_ranges;
        vectors.av_opt_get = av_opt_get;
        vectors.av_opt_get_chlayout = av_opt_get_chlayout;
        vectors.av_opt_get_dict_val = av_opt_get_dict_val;
        vectors.av_opt_get_double = av_opt_get_double;
        vectors.av_opt_get_image_size = av_opt_get_image_size;
        vectors.av_opt_get_int = av_opt_get_int;
        vectors.av_opt_get_key_value = av_opt_get_key_value;
        vectors.av_opt_get_pixel_fmt = av_opt_get_pixel_fmt;
        vectors.av_opt_get_q = av_opt_get_q;
        vectors.av_opt_get_sample_fmt = av_opt_get_sample_fmt;
        vectors.av_opt_get_video_rate = av_opt_get_video_rate;
        vectors.av_opt_is_set_to_default = av_opt_is_set_to_default;
        vectors.av_opt_is_set_to_default_by_name = av_opt_is_set_to_default_by_name;
        vectors.av_opt_next = av_opt_next;
        vectors.av_opt_ptr = av_opt_ptr;
        vectors.av_opt_query_ranges = av_opt_query_ranges;
        vectors.av_opt_query_ranges_default = av_opt_query_ranges_default;
        vectors.av_opt_serialize = av_opt_serialize;
        vectors.av_opt_set = av_opt_set;
        vectors.av_opt_set_bin = av_opt_set_bin;
        vectors.av_opt_set_chlayout = av_opt_set_chlayout;
        vectors.av_opt_set_defaults = av_opt_set_defaults;
        vectors.av_opt_set_defaults2 = av_opt_set_defaults2;
        vectors.av_opt_set_dict = av_opt_set_dict;
        vectors.av_opt_set_dict_val = av_opt_set_dict_val;
        vectors.av_opt_set_dict2 = av_opt_set_dict2;
        vectors.av_opt_set_double = av_opt_set_double;
        vectors.av_opt_set_from_string = av_opt_set_from_string;
        vectors.av_opt_set_image_size = av_opt_set_image_size;
        vectors.av_opt_set_int = av_opt_set_int;
        vectors.av_opt_set_pixel_fmt = av_opt_set_pixel_fmt;
        vectors.av_opt_set_q = av_opt_set_q;
        vectors.av_opt_set_sample_fmt = av_opt_set_sample_fmt;
        vectors.av_opt_set_video_rate = av_opt_set_video_rate;
        vectors.av_opt_show2 = av_opt_show2;
        vectors.av_output_audio_device_next = av_output_audio_device_next;
        vectors.av_output_video_device_next = av_output_video_device_next;
        vectors.av_packet_add_side_data = av_packet_add_side_data;
        vectors.av_packet_alloc = av_packet_alloc;
        vectors.av_packet_clone = av_packet_clone;
        vectors.av_packet_copy_props = av_packet_copy_props;
        vectors.av_packet_free = av_packet_free;
        vectors.av_packet_free_side_data = av_packet_free_side_data;
        vectors.av_packet_from_data = av_packet_from_data;
        vectors.av_packet_get_side_data = av_packet_get_side_data;
        vectors.av_packet_make_refcounted = av_packet_make_refcounted;
        vectors.av_packet_make_writable = av_packet_make_writable;
        vectors.av_packet_move_ref = av_packet_move_ref;
        vectors.av_packet_new_side_data = av_packet_new_side_data;
        vectors.av_packet_pack_dictionary = av_packet_pack_dictionary;
        vectors.av_packet_ref = av_packet_ref;
        vectors.av_packet_rescale_ts = av_packet_rescale_ts;
        vectors.av_packet_shrink_side_data = av_packet_shrink_side_data;
        vectors.av_packet_side_data_add = av_packet_side_data_add;
        vectors.av_packet_side_data_free = av_packet_side_data_free;
        vectors.av_packet_side_data_get = av_packet_side_data_get;
        vectors.av_packet_side_data_name = av_packet_side_data_name;
        vectors.av_packet_side_data_new = av_packet_side_data_new;
        vectors.av_packet_side_data_remove = av_packet_side_data_remove;
        vectors.av_packet_unpack_dictionary = av_packet_unpack_dictionary;
        vectors.av_packet_unref = av_packet_unref;
        vectors.av_parse_cpu_caps = av_parse_cpu_caps;
        vectors.av_parser_close = av_parser_close;
        vectors.av_parser_init = av_parser_init;
        vectors.av_parser_iterate = av_parser_iterate;
        vectors.av_parser_parse2 = av_parser_parse2;
        vectors.av_pix_fmt_count_planes = av_pix_fmt_count_planes;
        vectors.av_pix_fmt_desc_get = av_pix_fmt_desc_get;
        vectors.av_pix_fmt_desc_get_id = av_pix_fmt_desc_get_id;
        vectors.av_pix_fmt_desc_next = av_pix_fmt_desc_next;
        vectors.av_pix_fmt_get_chroma_sub_sample = av_pix_fmt_get_chroma_sub_sample;
        vectors.av_pix_fmt_swap_endianness = av_pix_fmt_swap_endianness;
        vectors.av_pkt_dump_log2 = av_pkt_dump_log2;
        vectors.av_pkt_dump2 = av_pkt_dump2;
        vectors.av_probe_input_buffer = av_probe_input_buffer;
        vectors.av_probe_input_buffer2 = av_probe_input_buffer2;
        vectors.av_probe_input_format = av_probe_input_format;
        vectors.av_probe_input_format2 = av_probe_input_format2;
        vectors.av_probe_input_format3 = av_probe_input_format3;
        vectors.av_program_add_stream_index = av_program_add_stream_index;
        vectors.av_q2intfloat = av_q2intfloat;
        vectors.av_read_frame = av_read_frame;
        vectors.av_read_image_line = av_read_image_line;
        vectors.av_read_image_line2 = av_read_image_line2;
        vectors.av_read_pause = av_read_pause;
        vectors.av_read_play = av_read_play;
        vectors.av_realloc = av_realloc;
        vectors.av_realloc_array = av_realloc_array;
        vectors.av_realloc_f = av_realloc_f;
        vectors.av_reallocp = av_reallocp;
        vectors.av_reallocp_array = av_reallocp_array;
        vectors.av_reduce = av_reduce;
        vectors.av_rescale = av_rescale;
        vectors.av_rescale_delta = av_rescale_delta;
        vectors.av_rescale_q = av_rescale_q;
        vectors.av_rescale_q_rnd = av_rescale_q_rnd;
        vectors.av_rescale_rnd = av_rescale_rnd;
        vectors.av_sample_fmt_is_planar = av_sample_fmt_is_planar;
        vectors.av_samples_alloc = av_samples_alloc;
        vectors.av_samples_alloc_array_and_samples = av_samples_alloc_array_and_samples;
        vectors.av_samples_copy = av_samples_copy;
        vectors.av_samples_fill_arrays = av_samples_fill_arrays;
        vectors.av_samples_get_buffer_size = av_samples_get_buffer_size;
        vectors.av_samples_set_silence = av_samples_set_silence;
        vectors.av_sdp_create = av_sdp_create;
        vectors.av_seek_frame = av_seek_frame;
        vectors.av_set_options_string = av_set_options_string;
        vectors.av_shrink_packet = av_shrink_packet;
        vectors.av_size_mult = av_size_mult;
        vectors.av_strdup = av_strdup;
        vectors.av_stream_add_side_data = av_stream_add_side_data;
        vectors.av_stream_get_class = av_stream_get_class;
        vectors.av_stream_get_codec_timebase = av_stream_get_codec_timebase;
        vectors.av_stream_get_parser = av_stream_get_parser;
        vectors.av_stream_get_side_data = av_stream_get_side_data;
        vectors.av_stream_group_get_class = av_stream_group_get_class;
        vectors.av_stream_new_side_data = av_stream_new_side_data;
        vectors.av_strerror = av_strerror;
        vectors.av_strndup = av_strndup;
        vectors.av_sub_q = av_sub_q;
        vectors.av_timecode_adjust_ntsc_framenum2 = av_timecode_adjust_ntsc_framenum2;
        vectors.av_timecode_check_frame_rate = av_timecode_check_frame_rate;
        vectors.av_timecode_get_smpte = av_timecode_get_smpte;
        vectors.av_timecode_get_smpte_from_framenum = av_timecode_get_smpte_from_framenum;
        vectors.av_timecode_init = av_timecode_init;
        vectors.av_timecode_init_from_components = av_timecode_init_from_components;
        vectors.av_timecode_init_from_string = av_timecode_init_from_string;
        vectors.av_timecode_make_mpeg_tc_string = av_timecode_make_mpeg_tc_string;
        vectors.av_timecode_make_smpte_tc_string = av_timecode_make_smpte_tc_string;
        vectors.av_timecode_make_smpte_tc_string2 = av_timecode_make_smpte_tc_string2;
        vectors.av_timecode_make_string = av_timecode_make_string;
        vectors.av_tree_destroy = av_tree_destroy;
        vectors.av_tree_enumerate = av_tree_enumerate;
        vectors.av_tree_find = av_tree_find;
        vectors.av_tree_insert = av_tree_insert;
        vectors.av_tree_node_alloc = av_tree_node_alloc;
        vectors.av_url_split = av_url_split;
        vectors.av_usleep = av_usleep;
        vectors.av_version_info = av_version_info;
        vectors.av_vlog = av_vlog;
        vectors.av_write_frame = av_write_frame;
        vectors.av_write_image_line = av_write_image_line;
        vectors.av_write_image_line2 = av_write_image_line2;
        vectors.av_write_trailer = av_write_trailer;
        vectors.av_write_uncoded_frame = av_write_uncoded_frame;
        vectors.av_write_uncoded_frame_query = av_write_uncoded_frame_query;
        vectors.av_xiphlacing = av_xiphlacing;
        vectors.avcodec_align_dimensions = avcodec_align_dimensions;
        vectors.avcodec_align_dimensions2 = avcodec_align_dimensions2;
        vectors.avcodec_alloc_context3 = avcodec_alloc_context3;
        vectors.avcodec_close = avcodec_close;
        vectors.avcodec_configuration = avcodec_configuration;
        vectors.avcodec_decode_subtitle2 = avcodec_decode_subtitle2;
        vectors.avcodec_default_execute = avcodec_default_execute;
        vectors.avcodec_default_execute2 = avcodec_default_execute2;
        vectors.avcodec_default_get_buffer2 = avcodec_default_get_buffer2;
        vectors.avcodec_default_get_encode_buffer = avcodec_default_get_encode_buffer;
        vectors.avcodec_default_get_format = avcodec_default_get_format;
        vectors.avcodec_descriptor_get = avcodec_descriptor_get;
        vectors.avcodec_descriptor_get_by_name = avcodec_descriptor_get_by_name;
        vectors.avcodec_descriptor_next = avcodec_descriptor_next;
        vectors.avcodec_encode_subtitle = avcodec_encode_subtitle;
        vectors.avcodec_fill_audio_frame = avcodec_fill_audio_frame;
        vectors.avcodec_find_best_pix_fmt_of_list = avcodec_find_best_pix_fmt_of_list;
        vectors.avcodec_find_decoder = avcodec_find_decoder;
        vectors.avcodec_find_decoder_by_name = avcodec_find_decoder_by_name;
        vectors.avcodec_find_encoder = avcodec_find_encoder;
        vectors.avcodec_find_encoder_by_name = avcodec_find_encoder_by_name;
        vectors.avcodec_flush_buffers = avcodec_flush_buffers;
        vectors.avcodec_free_context = avcodec_free_context;
        vectors.avcodec_get_class = avcodec_get_class;
        vectors.avcodec_get_hw_config = avcodec_get_hw_config;
        vectors.avcodec_get_hw_frames_parameters = avcodec_get_hw_frames_parameters;
        vectors.avcodec_get_name = avcodec_get_name;
        vectors.avcodec_get_subtitle_rect_class = avcodec_get_subtitle_rect_class;
        vectors.avcodec_get_type = avcodec_get_type;
        vectors.avcodec_is_open = avcodec_is_open;
        vectors.avcodec_license = avcodec_license;
        vectors.avcodec_open2 = avcodec_open2;
        vectors.avcodec_parameters_alloc = avcodec_parameters_alloc;
        vectors.avcodec_parameters_copy = avcodec_parameters_copy;
        vectors.avcodec_parameters_free = avcodec_parameters_free;
        vectors.avcodec_parameters_from_context = avcodec_parameters_from_context;
        vectors.avcodec_parameters_to_context = avcodec_parameters_to_context;
        vectors.avcodec_pix_fmt_to_codec_tag = avcodec_pix_fmt_to_codec_tag;
        vectors.avcodec_profile_name = avcodec_profile_name;
        vectors.avcodec_receive_frame = avcodec_receive_frame;
        vectors.avcodec_receive_packet = avcodec_receive_packet;
        vectors.avcodec_send_frame = avcodec_send_frame;
        vectors.avcodec_send_packet = avcodec_send_packet;
        vectors.avcodec_string = avcodec_string;
        vectors.avcodec_version = avcodec_version;
        vectors.avdevice_app_to_dev_control_message = avdevice_app_to_dev_control_message;
        vectors.avdevice_configuration = avdevice_configuration;
        vectors.avdevice_dev_to_app_control_message = avdevice_dev_to_app_control_message;
        vectors.avdevice_free_list_devices = avdevice_free_list_devices;
        vectors.avdevice_license = avdevice_license;
        vectors.avdevice_list_devices = avdevice_list_devices;
        vectors.avdevice_list_input_sources = avdevice_list_input_sources;
        vectors.avdevice_list_output_sinks = avdevice_list_output_sinks;
        vectors.avdevice_register_all = avdevice_register_all;
        vectors.avdevice_version = avdevice_version;
        vectors.avfilter_config_links = avfilter_config_links;
        vectors.avfilter_configuration = avfilter_configuration;
        vectors.avfilter_filter_pad_count = avfilter_filter_pad_count;
        vectors.avfilter_free = avfilter_free;
        vectors.avfilter_get_by_name = avfilter_get_by_name;
        vectors.avfilter_get_class = avfilter_get_class;
        vectors.avfilter_graph_alloc = avfilter_graph_alloc;
        vectors.avfilter_graph_alloc_filter = avfilter_graph_alloc_filter;
        vectors.avfilter_graph_config = avfilter_graph_config;
        vectors.avfilter_graph_create_filter = avfilter_graph_create_filter;
        vectors.avfilter_graph_dump = avfilter_graph_dump;
        vectors.avfilter_graph_free = avfilter_graph_free;
        vectors.avfilter_graph_get_filter = avfilter_graph_get_filter;
        vectors.avfilter_graph_parse = avfilter_graph_parse;
        vectors.avfilter_graph_parse_ptr = avfilter_graph_parse_ptr;
        vectors.avfilter_graph_parse2 = avfilter_graph_parse2;
        vectors.avfilter_graph_queue_command = avfilter_graph_queue_command;
        vectors.avfilter_graph_request_oldest = avfilter_graph_request_oldest;
        vectors.avfilter_graph_segment_apply = avfilter_graph_segment_apply;
        vectors.avfilter_graph_segment_apply_opts = avfilter_graph_segment_apply_opts;
        vectors.avfilter_graph_segment_create_filters = avfilter_graph_segment_create_filters;
        vectors.avfilter_graph_segment_free = avfilter_graph_segment_free;
        vectors.avfilter_graph_segment_init = avfilter_graph_segment_init;
        vectors.avfilter_graph_segment_link = avfilter_graph_segment_link;
        vectors.avfilter_graph_segment_parse = avfilter_graph_segment_parse;
        vectors.avfilter_graph_send_command = avfilter_graph_send_command;
        vectors.avfilter_graph_set_auto_convert = avfilter_graph_set_auto_convert;
        vectors.avfilter_init_dict = avfilter_init_dict;
        vectors.avfilter_init_str = avfilter_init_str;
        vectors.avfilter_inout_alloc = avfilter_inout_alloc;
        vectors.avfilter_inout_free = avfilter_inout_free;
        vectors.avfilter_insert_filter = avfilter_insert_filter;
        vectors.avfilter_license = avfilter_license;
        vectors.avfilter_link = avfilter_link;
        vectors.avfilter_link_free = avfilter_link_free;
        vectors.avfilter_pad_get_name = avfilter_pad_get_name;
        vectors.avfilter_pad_get_type = avfilter_pad_get_type;
        vectors.avfilter_process_command = avfilter_process_command;
        vectors.avfilter_version = avfilter_version;
        vectors.avformat_alloc_context = avformat_alloc_context;
        vectors.avformat_alloc_output_context2 = avformat_alloc_output_context2;
        vectors.avformat_close_input = avformat_close_input;
        vectors.avformat_configuration = avformat_configuration;
        vectors.avformat_find_stream_info = avformat_find_stream_info;
        vectors.avformat_flush = avformat_flush;
        vectors.avformat_free_context = avformat_free_context;
        vectors.avformat_get_class = avformat_get_class;
        vectors.avformat_get_mov_audio_tags = avformat_get_mov_audio_tags;
        vectors.avformat_get_mov_video_tags = avformat_get_mov_video_tags;
        vectors.avformat_get_riff_audio_tags = avformat_get_riff_audio_tags;
        vectors.avformat_get_riff_video_tags = avformat_get_riff_video_tags;
        vectors.avformat_index_get_entries_count = avformat_index_get_entries_count;
        vectors.avformat_index_get_entry = avformat_index_get_entry;
        vectors.avformat_index_get_entry_from_timestamp = avformat_index_get_entry_from_timestamp;
        vectors.avformat_init_output = avformat_init_output;
        vectors.avformat_license = avformat_license;
        vectors.avformat_match_stream_specifier = avformat_match_stream_specifier;
        vectors.avformat_network_deinit = avformat_network_deinit;
        vectors.avformat_network_init = avformat_network_init;
        vectors.avformat_new_stream = avformat_new_stream;
        vectors.avformat_open_input = avformat_open_input;
        vectors.avformat_query_codec = avformat_query_codec;
        vectors.avformat_queue_attached_pictures = avformat_queue_attached_pictures;
        vectors.avformat_seek_file = avformat_seek_file;
        vectors.avformat_stream_group_add_stream = avformat_stream_group_add_stream;
        vectors.avformat_stream_group_create = avformat_stream_group_create;
        vectors.avformat_stream_group_name = avformat_stream_group_name;
        vectors.avformat_transfer_internal_stream_timing_info = avformat_transfer_internal_stream_timing_info;
        vectors.avformat_version = avformat_version;
        vectors.avformat_write_header = avformat_write_header;
        vectors.avio_accept = avio_accept;
        vectors.avio_alloc_context = avio_alloc_context;
        vectors.avio_check = avio_check;
        vectors.avio_close = avio_close;
        vectors.avio_close_dir = avio_close_dir;
        vectors.avio_close_dyn_buf = avio_close_dyn_buf;
        vectors.avio_closep = avio_closep;
        vectors.avio_context_free = avio_context_free;
        vectors.avio_enum_protocols = avio_enum_protocols;
        vectors.avio_feof = avio_feof;
        vectors.avio_find_protocol_name = avio_find_protocol_name;
        vectors.avio_flush = avio_flush;
        vectors.avio_free_directory_entry = avio_free_directory_entry;
        vectors.avio_get_dyn_buf = avio_get_dyn_buf;
        vectors.avio_get_str = avio_get_str;
        vectors.avio_get_str16be = avio_get_str16be;
        vectors.avio_get_str16le = avio_get_str16le;
        vectors.avio_handshake = avio_handshake;
        vectors.avio_open = avio_open;
        vectors.avio_open_dir = avio_open_dir;
        vectors.avio_open_dyn_buf = avio_open_dyn_buf;
        vectors.avio_open2 = avio_open2;
        vectors.avio_pause = avio_pause;
        vectors.avio_print_string_array = avio_print_string_array;
        vectors.avio_printf = avio_printf;
        vectors.avio_protocol_get_class = avio_protocol_get_class;
        vectors.avio_put_str = avio_put_str;
        vectors.avio_put_str16be = avio_put_str16be;
        vectors.avio_put_str16le = avio_put_str16le;
        vectors.avio_r8 = avio_r8;
        vectors.avio_rb16 = avio_rb16;
        vectors.avio_rb24 = avio_rb24;
        vectors.avio_rb32 = avio_rb32;
        vectors.avio_rb64 = avio_rb64;
        vectors.avio_read = avio_read;
        vectors.avio_read_dir = avio_read_dir;
        vectors.avio_read_partial = avio_read_partial;
        vectors.avio_read_to_bprint = avio_read_to_bprint;
        vectors.avio_rl16 = avio_rl16;
        vectors.avio_rl24 = avio_rl24;
        vectors.avio_rl32 = avio_rl32;
        vectors.avio_rl64 = avio_rl64;
        vectors.avio_seek = avio_seek;
        vectors.avio_seek_time = avio_seek_time;
        vectors.avio_size = avio_size;
        vectors.avio_skip = avio_skip;
        vectors.avio_vprintf = avio_vprintf;
        vectors.avio_w8 = avio_w8;
        vectors.avio_wb16 = avio_wb16;
        vectors.avio_wb24 = avio_wb24;
        vectors.avio_wb32 = avio_wb32;
        vectors.avio_wb64 = avio_wb64;
        vectors.avio_wl16 = avio_wl16;
        vectors.avio_wl24 = avio_wl24;
        vectors.avio_wl32 = avio_wl32;
        vectors.avio_wl64 = avio_wl64;
        vectors.avio_write = avio_write;
        vectors.avio_write_marker = avio_write_marker;
        vectors.avsubtitle_free = avsubtitle_free;
        vectors.avutil_configuration = avutil_configuration;
        vectors.avutil_license = avutil_license;
        vectors.avutil_version = avutil_version;
        vectors.postproc_configuration = postproc_configuration;
        vectors.postproc_license = postproc_license;
        vectors.postproc_version = postproc_version;
        vectors.pp_free_context = pp_free_context;
        vectors.pp_free_mode = pp_free_mode;
        vectors.pp_get_context = pp_get_context;
        vectors.pp_get_mode_by_name_and_quality = pp_get_mode_by_name_and_quality;
        vectors.pp_postprocess = pp_postprocess;
        vectors.swr_alloc = swr_alloc;
        vectors.swr_alloc_set_opts2 = swr_alloc_set_opts2;
        vectors.swr_build_matrix2 = swr_build_matrix2;
        vectors.swr_close = swr_close;
        vectors.swr_config_frame = swr_config_frame;
        vectors.swr_convert = swr_convert;
        vectors.swr_convert_frame = swr_convert_frame;
        vectors.swr_drop_output = swr_drop_output;
        vectors.swr_free = swr_free;
        vectors.swr_get_class = swr_get_class;
        vectors.swr_get_delay = swr_get_delay;
        vectors.swr_get_out_samples = swr_get_out_samples;
        vectors.swr_init = swr_init;
        vectors.swr_inject_silence = swr_inject_silence;
        vectors.swr_is_initialized = swr_is_initialized;
        vectors.swr_next_pts = swr_next_pts;
        vectors.swr_set_channel_mapping = swr_set_channel_mapping;
        vectors.swr_set_compensation = swr_set_compensation;
        vectors.swr_set_matrix = swr_set_matrix;
        vectors.swresample_configuration = swresample_configuration;
        vectors.swresample_license = swresample_license;
        vectors.swresample_version = swresample_version;
        vectors.sws_alloc_context = sws_alloc_context;
        vectors.sws_allocVec = sws_allocVec;
        vectors.sws_convertPalette8ToPacked24 = sws_convertPalette8ToPacked24;
        vectors.sws_convertPalette8ToPacked32 = sws_convertPalette8ToPacked32;
        vectors.sws_frame_end = sws_frame_end;
        vectors.sws_frame_start = sws_frame_start;
        vectors.sws_freeContext = sws_freeContext;
        vectors.sws_freeFilter = sws_freeFilter;
        vectors.sws_freeVec = sws_freeVec;
        vectors.sws_get_class = sws_get_class;
        vectors.sws_getCachedContext = sws_getCachedContext;
        vectors.sws_getCoefficients = sws_getCoefficients;
        vectors.sws_getColorspaceDetails = sws_getColorspaceDetails;
        vectors.sws_getContext = sws_getContext;
        vectors.sws_getDefaultFilter = sws_getDefaultFilter;
        vectors.sws_getGaussianVec = sws_getGaussianVec;
        vectors.sws_init_context = sws_init_context;
        vectors.sws_isSupportedEndiannessConversion = sws_isSupportedEndiannessConversion;
        vectors.sws_isSupportedInput = sws_isSupportedInput;
        vectors.sws_isSupportedOutput = sws_isSupportedOutput;
        vectors.sws_normalizeVec = sws_normalizeVec;
        vectors.sws_receive_slice = sws_receive_slice;
        vectors.sws_receive_slice_alignment = sws_receive_slice_alignment;
        vectors.sws_scale = sws_scale;
        vectors.sws_scale_frame = sws_scale_frame;
        vectors.sws_scaleVec = sws_scaleVec;
        vectors.sws_send_slice = sws_send_slice;
        vectors.sws_setColorspaceDetails = sws_setColorspaceDetails;
        vectors.swscale_configuration = swscale_configuration;
        vectors.swscale_license = swscale_license;
        vectors.swscale_version = swscale_version;
    }
}
