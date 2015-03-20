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
    using CodeEmbed.GitHubClient.Serialization;

    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IGitHubClient))]
    public abstract class GitHubClientContract :
        IGitHubClient
    {
        public IConnection Connection
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IConnection>() != null);

                throw new NotImplementedException();
            }
        }

        public IJsonSerializer Serializer
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IJsonSerializer>() != null);

                throw new NotImplementedException();
            }
        }

        public Task<T> GetData<T>(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            throw new NotImplementedException();
        }
    }
}
