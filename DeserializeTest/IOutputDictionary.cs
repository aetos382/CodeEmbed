﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using System.Diagnostics.Contracts;

    using DeserializeTest.Contracts;

    [ContractClass(typeof(OutputDictionaryContract<,>))]
    public interface IOutputDictionary<TKey, out TValue> :
        IReadOnlyCollection<IOutputKeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key] { [Pure] get; }

        [Pure]
        bool ContainsKey(TKey key);

        [Pure]
        IOutputKeyValuePair<TKey, TValue> GetEntry(TKey key);

        IReadOnlyCollection<TKey> Keys { [Pure] get; }

        IReadOnlyCollection<TValue> Values { [Pure] get; }

        IEqualityComparer<TKey> Comparer { [Pure] get; }
    }
}
