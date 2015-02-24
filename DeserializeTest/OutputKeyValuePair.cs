using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    public class OutputKeyValuePair<TKey, TValue> :
        IOutputKeyValuePair<TKey, TValue>
    {
        private readonly TKey _key;
        private readonly TValue _value;

        public OutputKeyValuePair(
            TKey key,
            TValue value)
        {
            this._key = key;
            this._value = value;
        }

        public OutputKeyValuePair(IOutputKeyValuePair<TKey, TValue> pair)
            : this(pair.Key, pair.Value)
        {
        }

        public OutputKeyValuePair(KeyValuePair<TKey, TValue> pair)
            : this(pair.Key, pair.Value)
        {
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
    }
}
