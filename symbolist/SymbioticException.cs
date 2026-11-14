using System;

namespace symbolist
{
    /// <summary>Thrown when a symbiotic-list-related error occurs</summary>
    /// <param name="message">Exception message</param>
    public class SymbioticException(string? message) : Exception(message)
    {
        #region init

        /// <summary>Initializer for <see cref="SymbioticException"/></summary>
        public SymbioticException() : this("A symbiotic-list-related error has occurred.")
        { }

        #endregion
    }
}