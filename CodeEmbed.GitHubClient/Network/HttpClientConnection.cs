namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class HttpClientConnection :
        IConnection,
        IDisposable
    {
        public static readonly Uri DefaultBaseUri = new Uri("https://api.github.com");

        [ContractPublicPropertyName("BaseUri")]
        private readonly Uri _baseUri;

        [ContractPublicPropertyName("UserAgent")]
        private readonly string _userAgent;

        private readonly string _oauthToken;

        private readonly HttpMessageHandler _handler;

        private readonly bool _disposeHandler;

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

            this._userAgent = userAgent;
            this._oauthToken = oAuthToken;
            this._handler = handler;
            this._disposeHandler = disposeHandler;
        }

        public Uri BaseUri
        {
            get
            {
                return this._baseUri;
            }
        }

        public string UserAgent
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

                return this._userAgent;
            }
        }

        public async Task<TextReader> GetAsTextReader(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            uri = this.EnsureUriAbsolute(uri);

            using (var client = CreateHttpClient(
                this._userAgent, this._oauthToken, requestHeaders, this._handler, this._disposeHandler))
            {

                var response = await client.GetAsync(uri).ConfigureAwait(false);

                try
                {
                    response.EnsureSuccessStatusCode();

                    var result = await HttpResponseMessageReader.Create(response, responseEncoding).ConfigureAwait(false);

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
                if (this._handler != null && this._disposeHandler)
                {
                    this._handler.Dispose();
                }
            }

            this._disposed = true;
        }

        protected static HttpClient CreateHttpClient(
            string userAgent,
            string oAuthToken,
            IDictionary<string, string> requestHeaders,
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

                if (requestHeaders != null)
                {
                    SetRequestHeaders(client, requestHeaders);
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

        protected static void SetRequestHeaders(
            HttpClient client,
            IDictionary<string, string> requestHeaders)
        {
            var headers = client.DefaultRequestHeaders;

            var headerSetters = new Dictionary<string, Action<string>>
                {
                    { "Accept", value => headers.Accept.ParseAdd(value) },
                    { "Accept-Charset", value => headers.AcceptCharset.ParseAdd(value) },
                    { "Accept-Encoding", value => headers.AcceptEncoding.ParseAdd(value) },
                    { "Accept-Language", value => headers.AcceptLanguage.ParseAdd(value) },
                    { "Authorization", value => headers.Authorization = AuthenticationHeaderValue.Parse(value) },
                    { "Expect", value => headers.Expect.ParseAdd(value) },
                    { "From", value => headers.From = value },
                    { "Host", value => headers.Host = value },
                    { "If-Match", value => headers.IfMatch.ParseAdd(value) },
                    { "If-Modified-Since", value => headers.IfModifiedSince = DateTimeOffset.Parse(value) },
                    { "If-None-match", value => headers.IfNoneMatch.ParseAdd(value) },
                    { "If-Range", value => headers.IfRange = RangeConditionHeaderValue.Parse(value) },
                    { "If-Unmodified-Since", value => headers.IfUnmodifiedSince = DateTimeOffset.Parse(value) },
                    { "Max-Forwards", value => headers.MaxForwards = int.Parse(value) },
                    { "Proxy-Authorization", value => headers.ProxyAuthorization = AuthenticationHeaderValue.Parse(value) },
                    { "Range", value => headers.Range = RangeHeaderValue.Parse(value) },
                    { "Referer", value => headers.Referrer = new Uri(value) },
                    { "TE", value => headers.TE.ParseAdd(value) },
                    { "User-Agent", value => headers.UserAgent.ParseAdd(value) }
                };

            foreach (var entry in requestHeaders)
            {
                Action<string> action;

                if (headerSetters.TryGetValue(entry.Key, out action))
                {
                    action(entry.Value);
                }
                else
                {
                    headers.Add(entry.Key, entry.Value);
                }
            }
        }

        protected Uri EnsureUriAbsolute(Uri uri)
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
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._baseUri != null);
        }
    }
}
