using System;

namespace symbolist
{   
    /// <summary>Represents the base behavior for a keyed symbiotic list item</summary>
    public abstract class SymbioticKeyedBaseItem<TList, TItem, TKey> : SymbioticItem<TList, TItem>
        where TList: SymbioticKeyedBaseList<TList, TItem, TKey>
        where TItem: SymbioticKeyedBaseItem<TList, TItem, TKey>
    {
        #region fields

        private TKey? f_Key;

        #endregion

        #region properties

        /// <summary>Key</summary>
        public TKey? Key => f_Key;

        #endregion

        #region protected methods

        /// <summary>Sets the key</summary>
        /// <param name="key">Key</param>
        /// <remarks>
        ///     Only unlisted items can have their keys changed<br/>
        ///     Items with null keys cannot be added to lists
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        ///     Item is already part of a list
        /// </exception>
        protected void SetKey(TKey? key)
        {
            if (List is not null)
                throw new InvalidOperationException("Cannot change the key of a listed item.");
            f_Key = key;
        }

        #endregion
    }
}