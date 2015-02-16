namespace CodeEmbed.GitHubClient.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IGitHubClient))]
    public abstract class GitHubClientContracts :
        IGitHubClient
    {
        [DebuggerHidden]
        public Task<T> GetData<T>(
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            throw new NotImplementedException();
        }

        [DebuggerHidden]
        public IConnection Connection
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IConnection>() != null);

                throw new NotImplementedException();
            }
        }
    }
}
