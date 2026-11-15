namespace symbolist
{   
    /// <summary>Represents a symbiotic list item</summary>
    public abstract class SymbioticItem<TList, TItem>
        where TList: SymbioticBaseList<TList, TItem>
        where TItem: SymbioticItem<TList, TItem>
    {
        #region fields

        /// <remarks>Also accessed by <see cref="SymbioticBaseList{TList,TItem}"/></remarks>
        internal TList? f_List = null;

        /// <remarks>Also accessed by <see cref="SymbioticBaseList{TList,TItem}"/></remarks>
        internal int f_Index = -1;

        #endregion

        #region properties

        /// <summary>List that the item belongs to</summary>
        public TList? List => f_List;

        /// <summary>Index in the list (or -1 if the item is not part of a list)</summary>
        public int Index => f_Index;

        #endregion
    }
}