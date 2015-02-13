﻿namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    using Newtonsoft.Json;

    public class GitHubClient :
        IDisposable
    {
        public static readonly Uri DefaultBaseUri = new Uri("https://api.github.com");

        [ContractPublicPropertyName("UserAgent")]
        private readonly string _userAgent;

        [ContractPublicPropertyName("BaseUri")]
        private readonly Uri _baseUri = DefaultBaseUri;

        private readonly HttpClient _client;

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
            : this(DefaultBaseUri, userAgent, oAuthToken, null, true)
        {
            Contract.Requires<ArgumentNullException>(userAgent != null);
        }

        public GitHubClient(
            Uri baseUri,
            string userAgent,
            string oAuthToken,
            HttpClientHandler handler,
            bool disposeHandler)
        {
            Contract.Requires<ArgumentNullException>(baseUri != null);
            Contract.Requires<ArgumentNullException>(userAgent != null);

            this._baseUri = baseUri;
            this._userAgent = userAgent;

            this._client = CreateHttpClient(userAgent, oAuthToken, handler, disposeHandler);
        }

        public Uri BaseUri
        {
            [Pure]
            get
            {
                return this._baseUri;
            }
        }

        public string UserAgent
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

                return this._userAgent;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<T> GetData<T>(Uri uri)
            where T : ModelBase
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            uri = this.EnsureUriAbsolute(uri);

            using (var response = await this._client.GetAsync(uri).ConfigureAwait(false))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException ex)
                {
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new GitHubNotFoundException(uri, ex);
                    }

                    throw;
                }

                string charSet = response.Content.Headers.ContentType.CharSet;

                Encoding encoding;

                try
                {
                    encoding = Encoding.GetEncoding(charSet);
                }
                catch (Exception)
                {
                    encoding = Encoding.UTF8;
                }

                using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new StreamReader(stream, encoding))
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    var serializer = new JsonSerializer();
                    var result = serializer.Deserialize<T>(jsonReader);

                    result.Client = this;

                    return result;
                }
            }
        }

        public Task<byte[]> GetBinary(Uri uri)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            uri = this.EnsureUriAbsolute(uri);

            var result = this._client.GetByteArrayAsync(uri);
            return result;
        }

        public Task<string> GetString(Uri uri)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            uri = this.EnsureUriAbsolute(uri);

            var result = this._client.GetStringAsync(uri);
            return result;
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
            HttpClientHandler handler = null,
            bool disposeHandler = true)
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

                if (string.IsNullOrEmpty(oAuthToken))
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
        private void ObjectInvariant()
        {
            Contract.Invariant(this._userAgent != null);
            Contract.Invariant(this._client != null);
        }
    }
}
