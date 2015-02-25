namespace CodeEmbed.GitHubClient.Network.Contracts
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IConnection))]
    public abstract class ConnectionContract :
        IConnection
    {
        public Uri BaseUri
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<Uri>() != null);

                throw new NotImplementedException();
            }
        }

        public Task<TextReader> GetData(
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            throw new NotImplementedException();
        }
    }
}
