using System;
using System.Collections.Generic;
using System.Text;

namespace FFmpeg.AutoGen
{

    /// <summary>
    ///     Supports loading functions from native libraries. Provides a more flexible alternative to P/Invoke.
    /// </summary>
    public interface IFunctionResolver
    {

        /// <summary>
        ///     Creates a delegate which invokes a native function.
        /// </summary>
        /// <typeparam name="T">
        ///     The function delegate.
        /// </typeparam>
        /// <param name="libraryName">
        ///     The platform independent library name which contains the function.
        /// </param>
        /// <param name="functionName">
        ///     The name of the function for which to create the delegate.
        /// </param>
        /// <returns>
        ///     A new delegate which points to the native function.
        /// </returns>

        T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true);
    }
}
