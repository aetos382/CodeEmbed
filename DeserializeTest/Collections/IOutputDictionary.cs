namespace CodeEmbed.GitHubClient.Collections
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient.Collections.Contracts;

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
