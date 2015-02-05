namespace CodeEmbed.GitHubClient
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class GitHubClient :
        IDisposable
    {
        private readonly string _userAgent;

        private readonly HttpClient _client;

        public static readonly Uri DefaultBaseUri = new Uri("https://api.github.com");

        private Uri _baseUri = DefaultBaseUri;

        public GitHubClient(
            string userAgent)
        {
            this._userAgent = userAgent;
            this._client = CreateHttpClient(userAgent);
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

        public GitHubClient(
            Uri baseUri,
            string userAgent,
            HttpClientHandler handler,
            bool disposeHandler)
        {
            this._baseUri = baseUri;
            this._client = CreateHttpClient(userAgent, handler, disposeHandler);
        }

        private static HttpClient CreateHttpClient(
            string userAgent,
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

            return client;
        }

        #region Implementation of IDisposable

        private bool _disposed = false;

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

        #endregion

        public async Task<T> GetData<T>(Uri uri)
        {
            using (var response = await this._client.GetAsync(uri).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

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
            var result = this._client.GetByteArrayAsync(uri);
            return result;

        }

        public Task<string> GetString(Uri uri)
        {
            var result = this._client.GetStringAsync(uri);
            return result;
        }
    }
}
