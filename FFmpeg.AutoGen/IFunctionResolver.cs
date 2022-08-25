using System;

namespace FFmpeg.AutoGen;

/// <summary>
///     Supports loading functions from native libraries. Provides a more flexible alternative to P/Invoke.
/// </summary>
public interface IFunctionResolver
{
    /// <summary>
    ///     Get a pointer to the native library
    /// </summary>
    /// <param name="libraryName">The native library name.</param>
    /// <returns></returns>
    IntPtr GetOrLoadLibrary(string libraryName, bool throwOnError);

    /// <summary>
    ///     Creates a delegate which invokes a native function.
    /// </summary>
    /// <typeparam name="T">
    ///     The function delegate.
    /// </typeparam>
    /// <param name="libraryName">
    ///     The native library which contains the function.
    /// </param>
    /// <param name="functionName">
    ///     The name of the function for which to create the delegate.
    /// </param>
    /// <returns>
    ///     A new delegate which points to the native function.
    /// </returns>
    T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true);

    /// <summary>
    ///     Creates a delegate which invokes a native function.
    /// </summary>
    /// <typeparam name="T">
    ///     The function delegate.
    /// </typeparam>
    /// <param name="nativeLibraryHandle">
    ///     Pointer to the native library which contains the function.
    /// </param>
    /// <param name="functionName">
    ///     The name of the function for which to create the delegate.
    /// </param>
    /// <returns>
    ///     A new delegate which points to the native function.
    /// </returns>
    T GetFunctionDelegate<T>(IntPtr nativeLibraryHandle, string functionName, bool throwOnError);
}
