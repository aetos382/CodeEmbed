using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    public interface IOutputDictionary<TKey, out TValue> :
        IReadOnlyCollection<IOutputKeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key] { get; }

        bool ContainsKey(TKey key);

        IOutputKeyValuePair<TKey, TValue> GetEntry(TKey key);
    }
}
