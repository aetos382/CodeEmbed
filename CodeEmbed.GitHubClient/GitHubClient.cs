namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;
    using CodeEmbed.GitHubClient.Serialization;

    public class GitHubClient :
        IGitHubClient,
        IDisposable
    {
        private readonly string _userAgent;

        private readonly IConnection _connection;

        private readonly IJsonSerializer _serializer;

        private bool _disposed = false;

        public GitHubClient(
            string userAgent)
            : this(userAgent, null)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);
        }

        public GitHubClient(
            string userAgent,
            string oAuthToken)
            : this(userAgent, oAuthToken, new HttpClientConnection(userAgent, oAuthToken), new JsonNetSerializer())
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);
        }

        public GitHubClient(
            string userAgent,
            string oAuthToken,
            IConnection connection,
            IJsonSerializer serializer)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);
            Contract.Requires<ArgumentNullException>(oAuthToken != null);

            this._userAgent = userAgent;
            this._connection = connection;
            this._serializer = serializer;
        }

        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<T> GetData<T>(Uri uri, CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await this._connection.GetData(uri, cancellationToken).ConfigureAwait(false);

            var data = await this._serializer.Deserialize<T>(result, cancellationToken).ConfigureAwait(false);

            return data;
        }

        public IConnection Connection
        {
            get
            {
                return this._connection;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                var disposableConnection = this._connection as IDisposable;
                if (disposableConnection != null)
                {
                    disposableConnection.Dispose();
                }
            }

            this._disposed = true;
        }


        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._userAgent != null);
            Contract.Invariant(this._connection != null);
        }
    }
}
