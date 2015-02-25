namespace DeserializeTest.Contracts
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ContractClassFor(typeof(IOutputDictionary<,>))]
    public abstract class OutputDictionaryContract<TKey, TValue> :
        IOutputDictionary<TKey, TValue>
    {
        public abstract IEnumerator<IOutputKeyValuePair<TKey, TValue>> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public abstract int Count { get; }

        public TValue this[TKey key]
        {
            get
            {
                Contract.Requires<ArgumentNullException>(key != null);

                throw new NotImplementedException();
            }
        }

        public bool ContainsKey(TKey key)
        {
            Contract.Requires<ArgumentNullException>(key != null);

            throw new NotImplementedException();
        }

        public IOutputKeyValuePair<TKey, TValue> GetEntry(TKey key)
        {
            Contract.Requires<ArgumentNullException>(key != null);

            throw new NotImplementedException();
        }

        public IReadOnlyCollection<TKey> Keys
        {
            get
            {
                Contract.Ensures(Contract.Result<IReadOnlyCollection<TKey>>() != null);

                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<TValue> Values
        {
            get
            {
                Contract.Ensures(Contract.Result<IReadOnlyCollection<TValue>>() != null);

                throw new NotImplementedException();
            }
        }

        public IEqualityComparer<TKey> Comparer
        {
            get
            {
                Contract.Ensures(Contract.Result<IEqualityComparer<TKey>>() != null);

                throw new NotImplementedException();
            }
        }
    }
}
