namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class GitHubClient :
        IDisposable
    {
        public static readonly Uri DefaultBaseUri = new Uri("https://api.github.com");

        private readonly string _userAgent;

        private readonly HttpClient _client;

        private Uri _baseUri = DefaultBaseUri;

        private bool _disposed = false;

        public GitHubClient(
            string userAgent)
            : this(userAgent, null)
        {
        }

        public GitHubClient(
            string userAgent,
            string oauthToken)
            : this(DefaultBaseUri, userAgent, oauthToken, null, true)
        {
        }

        public GitHubClient(
            Uri baseUri,
            string userAgent,
            string oauthToken,
            HttpClientHandler handler,
            bool disposeHandler)
        {
            this._baseUri = baseUri;
            this._client = CreateHttpClient(userAgent, oauthToken, handler, disposeHandler);
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
                return this._userAgent;
            }
        }

        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;

            if (this._client != null)
            {
                this._client.Dispose();
            }
        }

        public async Task<T> GetData<T>(Uri uri)
        {
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

                    return result;
                }
            }
        }

        public Task<byte[]> GetBinary(Uri uri)
        {
            uri = this.EnsureUriAbsolute(uri);

            var result = this._client.GetByteArrayAsync(uri);
            return result;
        }

        public Task<string> GetString(Uri uri)
        {
            uri = this.EnsureUriAbsolute(uri);

            var result = this._client.GetStringAsync(uri);
            return result;
        }

        private static HttpClient CreateHttpClient(
            string userAgent,
            string oauthToken,
            HttpClientHandler handler = null,
            bool disposeHandler = true)
        {
            HttpClient client = null;

            if (handler == null)
            {
                client = new HttpClient();
            }
            else
            {
                client = new HttpClient(handler, disposeHandler);
            }

            client.DefaultRequestHeaders.Add("User-Agent", userAgent);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            if (string.IsNullOrEmpty(oauthToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", oauthToken);
            }

            return client;
        }

        private Uri EnsureUriAbsolute(Uri uri)
        {
            Contract.Requires<ArgumentNullException>(uri != null);

            if (!uri.IsAbsoluteUri)
            {
                uri = new Uri(this._baseUri, uri);
            }

            return uri;
        }
    }
}
