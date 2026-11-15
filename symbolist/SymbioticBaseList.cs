using System;
using System.Collections;
using System.Collections.Generic;

namespace symbolist
{    
    /// <summary>Represents the base behavior for a symbiotic list</summary>
    public abstract class SymbioticBaseList<TList, TItem> : IReadOnlyList<TItem>
        where TList: SymbioticBaseList<TList, TItem>
        where TItem: SymbioticItem<TList, TItem>
    {
        #region init

        /// <summary>Initializer for <see cref="SymbioticBaseList{TList, TItem}"/></summary>
        public SymbioticBaseList()
        {
            f_Items = [];
        }

        /// <summary>Initializer for <see cref="SymbioticBaseList{TList, TItem}"/></summary>
        /// <param name="capacity">List inital capacity</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative
        /// </exception>
        public SymbioticBaseList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative");
            f_Items = new(capacity);
        }

        #endregion

        #region fields

        private readonly List<TItem> f_Items;

        #endregion

        #region properties

        /// <summary>List capacity</summary>
        public int Capacity => f_Items.Capacity;

        #endregion

        #region private methods

        private void MM_FixIndexes(int start)
        {
            for (int i = start; i < f_Items.Count; ++i)
                f_Items[i].f_Index = i;
        }

        #endregion

        #region protected methods

        /// <summary>Expands the list capacity to ensure it is at least the specified minimum</summary>
        /// <param name="capacity">Minimum list capacity</param>
        /// <returns>New list capacity</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative
        /// </exception>
        protected int EnsureCapacity(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative");
            return f_Items.EnsureCapacity(capacity);
        }

        /// <summary>Shrinks the list capacity to the actual number of items in the list</summary>
        protected void TrimExcess()
        {
            f_Items.TrimExcess();
        }

        /// <summary>Checks whether or not the specified item can be added to the list</summary>
        /// <param name="item">Item to add</param>
        /// <returns>Whether or not the specified item can be added to the list</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        protected bool CanAdd(TItem item)
        {
            try
            {
                if (item.f_List is null)
                    return MM_CanBeAdded(item) && CanBeAdded(item);
                return false;
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }

        /// <summary>Checks whether or not the specified item can be removed from the list</summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Whether or not the specified item can be removed from the list</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        protected bool CanRemove(TItem item)
        {
            try
            {
                if (item.f_List == this)
                    return MM_CanBeRemoved(item) && CanBeRemoved(item);
                return false;
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }

        /// <summary>Attempts to add the specified item to the list</summary>
        /// <param name="item">Item to add</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        protected bool TryAdd(TItem item)
        {
            try
            {
                if (CanAdd(item))
                {
                    MM_PreAdd(item);
                    PreAdd(item);
                    item.f_List = (TList)this;
                    item.f_Index = f_Items.Count;
                    f_Items.Add(item);
                    MM_PostAdd(item);
                    PostAdd(item);
                    return true;
                }
                return false;
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }

        /// <summary>Attempts to insert the specified item into the list</summary>
        /// <param name="index">Index to insert item</param>
        /// <param name="item">Item to insert</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        protected bool TryInsert(int index, TItem item)
        {
            if (index < 0 || index > f_Items.Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            try
            {
                if (CanAdd(item))
                {
                    MM_PreAdd(item);
                    PreAdd(item);
                    item.f_List = (TList)this;
                    item.f_Index = index;
                    f_Items.Insert(index, item);
                    MM_FixIndexes(index + 1);
                    MM_PostAdd(item);
                    PostAdd(item);
                    return true;
                }
                return false;
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }
        
        /// <summary>Attempts to remove the specified item from the list</summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        protected bool TryRemove(TItem item)
        {
            try
            {
                if (CanRemove(item))
                {
                    MM_PreRemove(item);
                    PreRemove(item);
                    f_Items.RemoveAt(item.f_Index);
                    MM_FixIndexes(item.f_Index);
                    item.f_List = null;
                    item.f_Index = -1;
                    MM_PostRemove(item);
                    PostRemove(item);
                    return true;
                }
                return false;
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }
        
        /// <summary>Attempts to remove the item at the specified index from the list</summary>
        /// <param name="index">Index of item</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        protected bool TryRemove(int index)
        {
            try
            { return TryRemove(f_Items[index]); }
            catch when (index < 0 || index >= f_Items.Count)
            { throw new ArgumentOutOfRangeException(nameof(index)); }
        }

        /// <summary>Attempts to remove all items from the list</summary>
        /// <returns>Whether or not all items were removed from the list</returns>
        protected bool TryClear()
        {
            for (int i = f_Items.Count - 1; i >= 0; --i)
                TryRemove(i);
            return f_Items.Count == 0;
        }

        /// <summary>Adds the specified item to the list</summary>
        /// <param name="item">Item to add</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        /// <exception cref="SymbioticException">
        ///     <paramref name="item"/> could not be added to list
        /// </exception>
        protected void Add(TItem item)
        {
            try
            {
                if (TryAdd(item)) return;
                throw new SymbioticException("Item could not be added to the list.");
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }

        /// <summary>Inserts the specified item into the list</summary>
        /// <param name="index">Index to insert item</param>
        /// <param name="item">Item to insert</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        /// <exception cref="SymbioticException">
        ///     <paramref name="item"/> could not be added to list
        /// </exception>
        protected void Insert(int index, TItem item)
        {
            try
            {
                if (TryInsert(index, item)) return;
                throw new SymbioticException("Item could not be added to the list.");
            }
            catch when (index < 0 || index > f_Items.Count)
            { throw new ArgumentOutOfRangeException(nameof(index)); }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }

        /// <summary>Removes the specified item from the list</summary>
        /// <param name="item">Item to remove</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="item"/> is null
        /// </exception>
        /// <exception cref="SymbioticException">
        ///     <paramref name="item"/> could not be removed from list
        /// </exception>
        protected void Remove(TItem item)
        {
            try
            {
                if (TryRemove(item)) return;
                throw new SymbioticException("Item could not be removed from the list.");
            }
            catch when (item is null)
            { throw new ArgumentNullException(nameof(item)); }
        }
        
        /// <summary>Removes the item at the specified index from the list</summary>
        /// <param name="index">Index of item to remove</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is null
        /// </exception>
        /// <exception cref="SymbioticException">
        ///     Item at <paramref name="index"/> could not be removed from list
        /// </exception>
        protected void Remove(int index)
        {
            try
            {
                if (TryRemove(index)) return;
                throw new SymbioticException("Item could not be removed from the list.");
            }
            catch when (index < 0 || index >= f_Items.Count)
            { throw new ArgumentOutOfRangeException(nameof(index)); }
        }

        /// <summary>Removes all items from the list</summary>
        /// <exception cref="SymbioticException">
        ///     One or more items could not be removed from the list
        /// </exception>
        protected void Clear()
        {
            if (TryClear()) return;
            throw new SymbioticException("One or more items could not be removed from the list.");
        }

        #endregion

        #region virtual

        private protected virtual bool MM_CanBeAdded(TItem item) => true;
        private protected virtual bool MM_CanBeRemoved(TItem item) => true;
        private protected virtual void MM_PreAdd(TItem item) { }
        private protected virtual void MM_PostAdd(TItem item) { }
        private protected virtual void MM_PreRemove(TItem item) { }
        private protected virtual void MM_PostRemove(TItem item) { }

        /// <summary>Implementer-defined checks on whether or not the specified item can be added to the list</summary>
        /// <param name="item">Item to add</param>
        /// <returns>Whether or not the specified item can be added to the list</returns>
        protected virtual bool CanBeAdded(TItem item) => true;

        /// <summary>Implementer-defined checks on whether or not the specified item can be removed from the list</summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Whether or not the specified item can be removed to the list</returns>
        protected virtual bool CanBeRemoved(TItem item) => true;

        /// <summary>Called before the specified item is added to the list</summary>
        /// <param name="item">Item to add</param>
        protected virtual void PreAdd(TItem item) { }

        /// <summary>Called after the specified item is added to the list</summary>
        /// <param name="item">Added item</param>
        protected virtual void PostAdd(TItem item) { }

        /// <summary>Called before the specified item is removed from the list</summary>
        /// <param name="item">Item to remove</param>
        protected virtual void PreRemove(TItem item) { }

        /// <summary>Called after the specified item is removed from the list</summary>
        /// <param name="item">Removed item</param>
        protected virtual void PostRemove(TItem item) { }

        #endregion

        #region IReadOnlyList

        /// <summary>Number of items in list</summary>
        public int Count => f_Items.Count;

        /// <summary>Gets the item at the specified index</summary>
        /// <param name="index">Index of item</param>
        /// <returns>Item at the specified index</returns>
        /// <exception cref="IndexOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        public TItem this[int index]
        {
            get
            {
                try
                { return f_Items[index]; }
                catch when (index < 0 || index >= f_Items.Count)
                { throw new IndexOutOfRangeException(); }
            }
        }

        /// <summary>Gets an enumerator thru the list items</summary>
        /// <returns>Enumerator thru the list items</returns>
        public IEnumerator<TItem> GetEnumerator() => f_Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => f_Items.GetEnumerator();

        #endregion
    }
}