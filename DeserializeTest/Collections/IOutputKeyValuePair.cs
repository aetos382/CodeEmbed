namespace CodeEmbed.GitHubClient.Collections
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient.Collections.Contracts;

    [ContractClass(typeof(OutputKeyValuePairContract<,>))]
    public interface IOutputKeyValuePair<out TKey, out TValue>
    {
        TKey Key { [Pure] get; }

        TValue Value { [Pure] get; }
    }
}
