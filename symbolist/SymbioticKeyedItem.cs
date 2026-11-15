using System;

namespace symbolist
{   
    /// <summary>Represents a keyed symbiotic list item</summary>
    public abstract class SymbioticKeyedItem<TList, TItem, TKey> : SymbioticKeyedBaseItem<TList, TItem, TKey>
        where TList: SymbioticKeyedBaseList<TList, TItem, TKey>
        where TItem: SymbioticKeyedItem<TList, TItem, TKey>
    {
        #region methods

        /// <inheritdoc cref="SymbioticKeyedBaseItem{TList, TItem, TKey}.SetKey(TKey)"/>
        public new void SetKey(TKey? key) => base.SetKey(key);

        #endregion
    }
}