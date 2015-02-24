namespace DeserializeTest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OutputDictionary<TKey, TValue> :
        IOutputDictionary<TKey, TValue>
    {
        private readonly IDictionary<TKey, TValue> _innerDictionary; 

        public OutputDictionary(IDictionary<TKey, TValue> source)
        {
            this._innerDictionary = new ReadOnlyDictionary<TKey, TValue>(source);
        }

        public OutputDictionary(IEnumerable<IOutputKeyValuePair<TKey, TValue>> source)
        {
            this._innerDictionary = source.ToDictionary(x => x.Key, x => x.Value);
        }

        public OutputDictionary(IEnumerable<KeyValuePair<TKey, TValue>> source)
        {
            this._innerDictionary = source.ToDictionary(x => x.Key, x => x.Value);
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
    }
}
