namespace CodeEmbed.GitHubClient.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class OutputDictionary<TKey, TValue> :
        IOutputDictionary<TKey, TValue>
    {
        private readonly IDictionary<TKey, TValue> _innerDictionary;

        [ContractPublicPropertyName("Comparer")]
        private readonly IEqualityComparer<TKey> _keyComparer;

        private static readonly IEqualityComparer<TKey> _defaultKeyComparer = EqualityComparer<TKey>.Default;

        public OutputDictionary(IDictionary<TKey, TValue> source)
            : this(source, null)
        {
            Contract.Requires<ArgumentNullException>(source != null);
        }

        public OutputDictionary(
            IDictionary<TKey, TValue> source,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            this._innerDictionary = new ReadOnlyDictionary<TKey, TValue>(source);
            this._keyComparer = keyComparer ?? _defaultKeyComparer;
        }

        public OutputDictionary(Dictionary<TKey, TValue> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            this._innerDictionary = new ReadOnlyDictionary<TKey, TValue>(source);
            this._keyComparer = source.Comparer;
        }

        public OutputDictionary(IEnumerable<IOutputKeyValuePair<TKey, TValue>> source)
            : this(source, null)
        {
            Contract.Requires<ArgumentNullException>(source != null);
        }

        public OutputDictionary(
            IEnumerable<IOutputKeyValuePair<TKey, TValue>> source,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            this._innerDictionary = source.ToDictionary(x => x.Key, x => x.Value, keyComparer);
            this._keyComparer = keyComparer ?? _defaultKeyComparer;
        }

        public OutputDictionary(IEnumerable<KeyValuePair<TKey, TValue>> source)
            : this(source, null)
        {
            Contract.Requires<ArgumentNullException>(source != null);
        }

        public OutputDictionary(
            IEnumerable<KeyValuePair<TKey, TValue>> source,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            this._innerDictionary = source.ToDictionary(x => x.Key, x => x.Value, keyComparer);
            this._keyComparer = keyComparer ?? _defaultKeyComparer;
        }

        public IEnumerator<IOutputKeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this._innerDictionary.Select(x => new OutputKeyValuePair<TKey, TValue>(x)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int Count
        {
            get
            {
                return this._innerDictionary.Count;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return this._innerDictionary[key];
            }
        }

        public bool ContainsKey(TKey key)
        {
            return this._innerDictionary.ContainsKey(key);
        }

        public IOutputKeyValuePair<TKey, TValue> GetEntry(TKey key)
        {
            TValue value;
            if (!this._innerDictionary.TryGetValue(key, out value))
            {
                return null;
            }

            return new OutputKeyValuePair<TKey, TValue>(key, value);
        }

        public IReadOnlyCollection<TKey> Keys
        {
            get
            {
                return new ReadOnlyCollection<TKey>(this._innerDictionary.Keys.ToList());
            }
        }

        public IReadOnlyCollection<TValue> Values
        {
            get
            {
                return new ReadOnlyCollection<TValue>(this._innerDictionary.Values.ToList());
            }
        }

        public IEqualityComparer<TKey> Comparer
        {
            get
            {
                return this._keyComparer;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_defaultKeyComparer != null);

            Contract.Invariant(this._innerDictionary != null);
            Contract.Invariant(this._keyComparer != null);
        }
    }
}
