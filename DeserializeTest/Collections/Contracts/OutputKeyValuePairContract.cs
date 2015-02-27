namespace CodeEmbed.GitHubClient.Collections.Contracts
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IOutputKeyValuePair<,>))]
    public abstract class OutputKeyValuePairContract<TKey, TValue> :
        IOutputKeyValuePair<TKey, TValue>
    {
        public TKey Key
        {
            get
            {
                Contract.Ensures(Contract.Result<TKey>() != null);

                throw new NotImplementedException();
            }
        }

        public abstract TValue Value { get; }
    }
}
