using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace symbolist
{    
    /// <summary>Represents the base behavior for a keyed symbiotic list</summary>
    public abstract class SymbioticKeyedBaseList<TList, TItem, TKey> : SymbioticBaseList<TList, TItem>
        where TList: SymbioticKeyedBaseList<TList, TItem, TKey>
        where TItem: SymbioticKeyedBaseItem<TList, TItem, TKey>
    {
        #region nested

        private readonly struct KeyWrapper(TKey? _key) : IEquatable<KeyWrapper>
        {
            #region properties

            public TKey? Key { get; } = _key;

            #endregion

            #region private methods

            private bool MM_Equals(KeyWrapper other)
            {
                if (Key is null)
                    return other.Key is null;
                return Key.Equals(other.Key);
            }

            #endregion

            #region object
            
            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                if (obj is null) return false;
                if (obj is not KeyWrapper other) return false;
                return MM_Equals(other);
            }

            public override int GetHashCode()
            {
                if (Key is null) return 0;
                return Key.GetHashCode();
            }
            
            #endregion

            #region IEquatable

            public bool Equals(KeyWrapper other) => MM_Equals(other);

            #endregion
        }

        #endregion

        #region init

        /// <summary>Initializer for <see cref="SymbioticKeyedBaseList{TList, TItem, TKey}"/></summary>
        public SymbioticKeyedBaseList() : base()
        {
            f_ItemsByKey = [];
        }

        /// <summary>Initializer for <see cref="SymbioticKeyedBaseList{TList, TItem, TKey}"/></summary>
        /// <param name="capacity">List inital capacity</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative
        /// </exception>
        public SymbioticKeyedBaseList(int capacity) : base(capacity)
        {
            f_ItemsByKey = new(capacity);
        }

        #endregion

        #region fields

        private readonly Dictionary<KeyWrapper, TItem> f_ItemsByKey;

        #endregion

        #region methods

        /// <summary>Attempts to find an item with the specified key</summary>
        /// <param name="key">Key</param>
        /// <param name="item">Found item</param>
        /// <returns>Whether or not successful</returns>
        public bool TryGet(TKey? key, [MaybeNullWhen(false)] out TItem item)
        {
            return f_ItemsByKey.TryGetValue(new(key), out item);
        }

        #endregion

        #region operators
        
        /// <summary>Retrieves the item with the specified key</summary>
        /// <param name="key">Key</param>
        /// <returns>Found item</returns>
        /// <exception cref="KeyNotFoundException">
        ///     Could not find an item with the specified key
        /// </exception>
        public TItem this[TKey? key]
        {
            get
            {
                if (TryGet(key, out var item)) return item;
                throw new KeyNotFoundException("Could not find an item with the specified key.");
            }
        }

        #endregion

        #region SymbioticBaseList

        private protected override bool MM_CanBeAdded(TItem item)
        {
            if (base.MM_CanBeAdded(item))
            {
                if (item.Key is not null)
                    return !f_ItemsByKey.ContainsKey(new(item.Key));
            }
            return false;
        }

        private protected override void MM_PostAdd(TItem item)
        {
            base.MM_PostAdd(item);
            f_ItemsByKey.Add(new(item.Key!), item);
        }

        private protected override void MM_PostRemove(TItem item)
        {
            base.MM_PostAdd(item);
            f_ItemsByKey.Remove(new(item.Key!));
        }

        #endregion
    }
}