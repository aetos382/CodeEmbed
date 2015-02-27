namespace CodeEmbed.GitHubClient.Collections
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class OutputKeyValuePair<TKey, TValue> :
        IOutputKeyValuePair<TKey, TValue>
    {
        [ContractPublicPropertyName("Key")]
        private readonly TKey _key;

        [ContractPublicPropertyName("Value")]
        private readonly TValue _value;

        public OutputKeyValuePair(
            TKey key,
            TValue value)
        {
            Contract.Requires<ArgumentNullException>(key != null);

            this._key = key;
            this._value = value;
        }

        public OutputKeyValuePair(IOutputKeyValuePair<TKey, TValue> pair)
            : this(pair.Key, pair.Value)
        {
            Contract.Requires<ArgumentNullException>(pair != null);
        }

        public OutputKeyValuePair(KeyValuePair<TKey, TValue> pair)
            : this(pair.Key, pair.Value)
        {
            Contract.Requires<ArgumentNullException>(pair.Key != null);
        }

        public TKey Key
        {
            get
            {
                return this._key;
            }
        }

        public TValue Value
        {
            get
            {
                return this._value;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._key != null);
        }
    }
}
