﻿namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;
    using CodeEmbed.GitHubClient.Serialization;

    public class GitHubClient :
        IGitHubClient,
        IDisposable
    {
        private readonly string _userAgent;

        [ContractPublicPropertyName("Connection")]
        private readonly IConnection _connection;

        [ContractPublicPropertyName("Serializer")]
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
            : this(userAgent, oAuthToken, null, null)
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

            this._userAgent = userAgent;

            if (serializer != null)
            {
                this._serializer = serializer;
            }
            else
            {
                var defaultSerializer = new JsonNetSerializer();
                defaultSerializer.MapAllTypes();

                this._serializer = defaultSerializer;
            }

            if (connection != null)
            {
                this._connection = connection;
            }
            else
            {
                this._connection = new HttpClientConnection(userAgent, oAuthToken);
            }
        }

        public IConnection Connection
        {
            get
            {
                return this._connection;
            }
        }

        public IJsonSerializer Serializer
        {
            get
            {
                return this._serializer;
            }
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

        public async Task<T> GetData<T>(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            using (var reader = await this._connection.GetAsTextReader(
                uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false))
            {
                var data = await this._serializer.Deserialize<T>(reader, cancellationToken).ConfigureAwait(false);

                return data;
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
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._userAgent != null);
            Contract.Invariant(this._connection != null);
            Contract.Invariant(this._serializer != null);
        }
    }
}
