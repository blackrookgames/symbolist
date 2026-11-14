using System;
using System.Collections;
using System.Collections.Generic;

namespace symbolist
{    
    /// <summary>Represents a symbiotic list</summary>
    public abstract class SymbioticList<TList, TItem> : SymbioticBaseList<TList, TItem>
        where TList: SymbioticList<TList, TItem>
        where TItem: SymbioticItem<TList, TItem>
    {
        #region init

        /// <summary>Initializer for <see cref="SymbioticList{TList, TItem}"/></summary>
        public SymbioticList() : base() { }

        /// <summary>Initializer for <see cref="SymbioticList{TList, TItem}"/></summary>
        /// <param name="capacity">List inital capacity</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative
        /// </exception>
        public SymbioticList(int capacity) : base(capacity) { }

        #endregion

        #region methods

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.EnsureCapacity(int)"/>
        public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TrimExcess()"/>
        public new void TrimExcess() => base.TrimExcess();

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.CanAdd(TItem)"/>
        public new bool CanAdd(TItem item) => base.CanAdd(item);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.CanRemove(TItem)"/>
        public new bool CanRemove(TItem item) => base.CanRemove(item);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TryAdd(TItem)"/>
        public new bool TryAdd(TItem item) => base.TryAdd(item);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TryInsert(int, TItem)"/>
        public new bool TryInsert(int index, TItem item) => base.TryInsert(index, item);
        
        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TryRemove(TItem)"/>
        public new bool TryRemove(TItem item) => base.TryRemove(item);
        
        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TryRemove(int)"/>
        public new bool TryRemove(int index) => base.TryRemove(index);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.TryClear()"/>
        public new bool TryClear() => base.TryClear();

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.Add(TItem)"/>
        public new void Add(TItem item) => base.Add(item);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.Insert(int, TItem)"/>
        public new void Insert(int index, TItem item) => base.Insert(index, item);
        
        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.Remove(TItem)"/>
        public new void Remove(TItem item) => base.Remove(item);
        
        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.Remove(int)"/>
        public new void Remove(int index) => base.Remove(index);

        /// <inheritdoc cref="SymbioticBaseList{TList, TItem}.Clear()"/>
        public new void Clear() => base.Clear();

        #endregion
    }
}