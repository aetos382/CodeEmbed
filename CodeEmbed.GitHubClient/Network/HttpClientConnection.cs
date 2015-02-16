namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    public class HttpClientConnection :
        IConnection,
        IDisposable
    {
        public static readonly Uri DefaultBaseUri = new Uri("https://api.github.com");

        [ContractPublicPropertyName("BaseUri")]
        private readonly Uri _baseUri;

        private readonly HttpClient _client;

        private bool _disposed = false;

        public HttpClientConnection(
            string userAgent,
            string oAuthToken)
            : this(DefaultBaseUri, userAgent, oAuthToken, null, false)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);
        }

        public HttpClientConnection(
            Uri baseUri,
            string userAgent,
            string oAuthToken,
            HttpMessageHandler handler,
            bool disposeHandler)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);

            this._baseUri = baseUri ?? DefaultBaseUri;
            this._client = CreateHttpClient(userAgent, oAuthToken, handler, disposeHandler);
        }

        public Uri BaseUri
        {
            get
            {
                return this._baseUri;
            }
        }

        public async Task<TextReader> GetData(
            Uri uri,
            CancellationToken cancellationToken)
        {
            uri = this.EnsureUriAbsolute(uri);

            var response = await this._client.GetAsync(uri).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();

                var result = await HttpResponseMessageReader.Create(response).ConfigureAwait(false);

                response = null;
                return result;
            }
            catch (HttpRequestException ex)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new GitHubNotFoundException(uri, ex);
                }

                throw;
            }
            finally
            {
                if (response != null)
                {
                    response.Dispose();
                    response = null;
                }
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

        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                this._client.Dispose();
            }

            this._disposed = true;
        }

        private static HttpClient CreateHttpClient(
            string userAgent,
            string oAuthToken,
            HttpMessageHandler handler,
            bool disposeHandler)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);

            Contract.Ensures(Contract.Result<HttpClient>() != null);

            HttpClient client = null;

            try
            {
                if (handler == null)
                {
                    client = new HttpClient();
                }
                else
                {
                    client = new HttpClient(handler, disposeHandler);
                }

                var headers = client.DefaultRequestHeaders;

                headers.Add("User-Agent", userAgent);
                headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

                if (!string.IsNullOrEmpty(oAuthToken))
                {
                    headers.Authorization = new AuthenticationHeaderValue("Token", oAuthToken);
                }

                return client;
            }
            catch
            {
                if (client != null)
                {
                    client.Dispose();
                }

                throw;
            }
        }

        private Uri EnsureUriAbsolute(Uri uri)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Uri>() != null);

            if (!uri.IsAbsoluteUri)
            {
                uri = new Uri(this._baseUri, uri);
            }

            return uri;
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._baseUri != null);
            Contract.Invariant(this._client != null);
        }
    }
}
