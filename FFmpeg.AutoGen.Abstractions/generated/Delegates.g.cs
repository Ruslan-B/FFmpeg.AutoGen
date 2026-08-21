using System;
using System.Runtime.InteropServices;

#if NET6_0_OR_GREATER
using CLong = System.Runtime.InteropServices.CLong;
using CULong = System.Runtime.InteropServices.CULong;
#endif

namespace FFmpeg.AutoGen.Abstractions;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_buffer_create_free (void* @opaque, byte* @data);
public unsafe struct av_buffer_create_free_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_create_free_func(av_buffer_create_free func) => new av_buffer_create_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate AVBufferRef* av_buffer_pool_init_alloc (ulong @size);
public unsafe struct av_buffer_pool_init_alloc_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init_alloc_func(av_buffer_pool_init_alloc func) => new av_buffer_pool_init_alloc_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate AVBufferRef* av_buffer_pool_init2_alloc (void* @opaque, ulong @size);
public unsafe struct av_buffer_pool_init2_alloc_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init2_alloc_func(av_buffer_pool_init2_alloc func) => new av_buffer_pool_init2_alloc_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_buffer_pool_init2_pool_free (void* @opaque);
public unsafe struct av_buffer_pool_init2_pool_free_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init2_pool_free_func(av_buffer_pool_init2_pool_free func) => new av_buffer_pool_init2_pool_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate double av_expr_parse_and_eval_funcs1 (void* @p0, double @p1);
public unsafe struct av_expr_parse_and_eval_funcs1_func
{
    public IntPtr Pointer;
    public static implicit operator av_expr_parse_and_eval_funcs1_func(av_expr_parse_and_eval_funcs1 func) => new av_expr_parse_and_eval_funcs1_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate double av_expr_parse_and_eval_funcs2 (void* @p0, double @p1, double @p2);
public unsafe struct av_expr_parse_and_eval_funcs2_func
{
    public IntPtr Pointer;
    public static implicit operator av_expr_parse_and_eval_funcs2_func(av_expr_parse_and_eval_funcs2 func) => new av_expr_parse_and_eval_funcs2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate double av_expr_parse_funcs1 (void* @p0, double @p1);
public unsafe struct av_expr_parse_funcs1_func
{
    public IntPtr Pointer;
    public static implicit operator av_expr_parse_funcs1_func(av_expr_parse_funcs1 func) => new av_expr_parse_funcs1_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate double av_expr_parse_funcs2 (void* @p0, double @p1, double @p2);
public unsafe struct av_expr_parse_funcs2_func
{
    public IntPtr Pointer;
    public static implicit operator av_expr_parse_funcs2_func(av_expr_parse_funcs2 func) => new av_expr_parse_funcs2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_log_set_callback_callback (void* @p0, int @p1,     
    #if NETSTANDARD2_1_OR_GREATER || NET
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @p2, byte* @p3);
public unsafe struct av_log_set_callback_callback_func
{
    public IntPtr Pointer;
    public static implicit operator av_log_set_callback_callback_func(av_log_set_callback_callback func) => new av_log_set_callback_callback_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_enumerate_cmp (void* @opaque, void* @elem);
public unsafe struct av_tree_enumerate_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_enumerate_cmp_func(av_tree_enumerate_cmp func) => new av_tree_enumerate_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_enumerate_enu (void* @opaque, void* @elem);
public unsafe struct av_tree_enumerate_enu_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_enumerate_enu_func(av_tree_enumerate_enu func) => new av_tree_enumerate_enu_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_find_cmp (void* @key, void* @b);
public unsafe struct av_tree_find_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_find_cmp_func(av_tree_find_cmp func) => new av_tree_find_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_insert_cmp (void* @key, void* @b);
public unsafe struct av_tree_insert_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_insert_cmp_func(av_tree_insert_cmp func) => new av_tree_insert_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_tx_init_tx (AVTXContext* @s, void* @out, void* @in, long @stride);
public unsafe struct av_tx_init_tx_func
{
    public IntPtr Pointer;
    public static implicit operator av_tx_init_tx_func(av_tx_init_tx func) => new av_tx_init_tx_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate AVClass* AVClass_child_class_iterate (void** @iter);
public unsafe struct AVClass_child_class_iterate_func
{
    public IntPtr Pointer;
    public static implicit operator AVClass_child_class_iterate_func(AVClass_child_class_iterate func) => new AVClass_child_class_iterate_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* AVClass_child_next (void* @obj, void* @prev);
public unsafe struct AVClass_child_next_func
{
    public IntPtr Pointer;
    public static implicit operator AVClass_child_next_func(AVClass_child_next func) => new AVClass_child_next_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate AVClassCategory AVClass_get_category (void* @ctx);
public unsafe struct AVClass_get_category_func
{
    public IntPtr Pointer;
    public static implicit operator AVClass_get_category_func(AVClass_get_category func) => new AVClass_get_category_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate byte* AVClass_item_name (void* @ctx);
public unsafe struct AVClass_item_name_func
{
    public IntPtr Pointer;
    public static implicit operator AVClass_item_name_func(AVClass_item_name func) => new AVClass_item_name_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVClass_query_ranges (AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER || NET
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
public unsafe struct AVClass_query_ranges_func
{
    public IntPtr Pointer;
    public static implicit operator AVClass_query_ranges_func(AVClass_query_ranges func) => new AVClass_query_ranges_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avcodec_default_execute_func (AVCodecContext* @c2, void* @arg2);
public unsafe struct avcodec_default_execute_func_func
{
    public IntPtr Pointer;
    public static implicit operator avcodec_default_execute_func_func(avcodec_default_execute_func func) => new avcodec_default_execute_func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avcodec_default_execute2_func (AVCodecContext* @c2, void* @arg2, int @p2, int @p3);
public unsafe struct avcodec_default_execute2_func_func
{
    public IntPtr Pointer;
    public static implicit operator avcodec_default_execute2_func_func(avcodec_default_execute2_func func) => new avcodec_default_execute2_func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void AVCodecContext_draw_horiz_band (AVCodecContext* @s, AVFrame* @src, ref int8 @offset, int @y, int @type, int @height);
public unsafe struct AVCodecContext_draw_horiz_band_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_draw_horiz_band_func(AVCodecContext_draw_horiz_band func) => new AVCodecContext_draw_horiz_band_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVCodecContext_execute (AVCodecContext* @c, func_func @func, void* @arg2, int* @ret, int @count, int @size);
public unsafe struct AVCodecContext_execute_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_execute_func(AVCodecContext_execute func) => new AVCodecContext_execute_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVCodecContext_execute2 (AVCodecContext* @c, func_func @func, void* @arg2, int* @ret, int @count);
public unsafe struct AVCodecContext_execute2_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_execute2_func(AVCodecContext_execute2 func) => new AVCodecContext_execute2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVCodecContext_get_buffer2 (AVCodecContext* @s, AVFrame* @frame, int @flags);
public unsafe struct AVCodecContext_get_buffer2_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_get_buffer2_func(AVCodecContext_get_buffer2 func) => new AVCodecContext_get_buffer2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVCodecContext_get_encode_buffer (AVCodecContext* @s, AVPacket* @pkt, int @flags);
public unsafe struct AVCodecContext_get_encode_buffer_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_get_encode_buffer_func(AVCodecContext_get_encode_buffer func) => new AVCodecContext_get_encode_buffer_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate AVPixelFormat AVCodecContext_get_format (AVCodecContext* @s, AVPixelFormat* @fmt);
public unsafe struct AVCodecContext_get_format_func
{
    public IntPtr Pointer;
    public static implicit operator AVCodecContext_get_format_func(AVCodecContext_get_format func) => new AVCodecContext_get_format_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void AVD3D11VADeviceContext_lock (void* @lock_ctx);
public unsafe struct AVD3D11VADeviceContext_lock_func
{
    public IntPtr Pointer;
    public static implicit operator AVD3D11VADeviceContext_lock_func(AVD3D11VADeviceContext_lock func) => new AVD3D11VADeviceContext_lock_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void AVD3D11VADeviceContext_unlock (void* @lock_ctx);
public unsafe struct AVD3D11VADeviceContext_unlock_func
{
    public IntPtr Pointer;
    public static implicit operator AVD3D11VADeviceContext_unlock_func(AVD3D11VADeviceContext_unlock func) => new AVD3D11VADeviceContext_unlock_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVFilterGraph_execute (AVFilterContext* @ctx, func_func @func, void* @arg, int* @ret, int @nb_jobs);
public unsafe struct AVFilterGraph_execute_func
{
    public IntPtr Pointer;
    public static implicit operator AVFilterGraph_execute_func(AVFilterGraph_execute func) => new AVFilterGraph_execute_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVFormatContext_control_message_cb (AVFormatContext* @s, int @type, void* @data, ulong @data_size);
public unsafe struct AVFormatContext_control_message_cb_func
{
    public IntPtr Pointer;
    public static implicit operator AVFormatContext_control_message_cb_func(AVFormatContext_control_message_cb func) => new AVFormatContext_control_message_cb_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVFormatContext_io_close2 (AVFormatContext* @s, AVIOContext* @pb);
public unsafe struct AVFormatContext_io_close2_func
{
    public IntPtr Pointer;
    public static implicit operator AVFormatContext_io_close2_func(AVFormatContext_io_close2 func) => new AVFormatContext_io_close2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVFormatContext_io_open (AVFormatContext* @s, AVIOContext** @pb,     
    #if NETSTANDARD2_1_OR_GREATER || NET
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, AVDictionary** @options);
public unsafe struct AVFormatContext_io_open_func
{
    public IntPtr Pointer;
    public static implicit operator AVFormatContext_io_open_func(AVFormatContext_io_open func) => new AVFormatContext_io_open_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void AVHWDeviceContext_free (AVHWDeviceContext* @ctx);
public unsafe struct AVHWDeviceContext_free_func
{
    public IntPtr Pointer;
    public static implicit operator AVHWDeviceContext_free_func(AVHWDeviceContext_free func) => new AVHWDeviceContext_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void AVHWFramesContext_free (AVHWFramesContext* @ctx);
public unsafe struct AVHWFramesContext_free_func
{
    public IntPtr Pointer;
    public static implicit operator AVHWFramesContext_free_func(AVHWFramesContext_free func) => new AVHWFramesContext_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avio_alloc_context_read_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct avio_alloc_context_read_packet_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_read_packet_func(avio_alloc_context_read_packet func) => new avio_alloc_context_read_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long avio_alloc_context_seek (void* @opaque, long @offset, int @whence);
public unsafe struct avio_alloc_context_seek_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_seek_func(avio_alloc_context_seek func) => new avio_alloc_context_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avio_alloc_context_write_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct avio_alloc_context_write_packet_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_write_packet_func(avio_alloc_context_write_packet func) => new avio_alloc_context_write_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVIOContext_read_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct AVIOContext_read_packet_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_read_packet_func(AVIOContext_read_packet func) => new AVIOContext_read_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVIOContext_read_pause (void* @opaque, int @pause);
public unsafe struct AVIOContext_read_pause_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_read_pause_func(AVIOContext_read_pause func) => new AVIOContext_read_pause_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long AVIOContext_read_seek (void* @opaque, int @stream_index, long @timestamp, int @flags);
public unsafe struct AVIOContext_read_seek_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_read_seek_func(AVIOContext_read_seek func) => new AVIOContext_read_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long AVIOContext_seek (void* @opaque, long @offset, int @whence);
public unsafe struct AVIOContext_seek_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_seek_func(AVIOContext_seek func) => new AVIOContext_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate CULong AVIOContext_update_checksum (CULong @checksum, byte* @buf, uint @size);
public unsafe struct AVIOContext_update_checksum_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_update_checksum_func(AVIOContext_update_checksum func) => new AVIOContext_update_checksum_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVIOContext_write_data_type (void* @opaque, byte* @buf, int @buf_size, AVIODataMarkerType @type, long @time);
public unsafe struct AVIOContext_write_data_type_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_write_data_type_func(AVIOContext_write_data_type func) => new AVIOContext_write_data_type_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVIOContext_write_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct AVIOContext_write_packet_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOContext_write_packet_func(AVIOContext_write_packet func) => new AVIOContext_write_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int AVIOInterruptCB_callback (void* @p0);
public unsafe struct AVIOInterruptCB_callback_func
{
    public IntPtr Pointer;
    public static implicit operator AVIOInterruptCB_callback_func(AVIOInterruptCB_callback func) => new AVIOInterruptCB_callback_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int func (AVFilterContext* @ctx, void* @arg, int @jobnr, int @nb_jobs);
public unsafe struct func_func
{
    public IntPtr Pointer;
    public static implicit operator func_func(func func) => new func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

