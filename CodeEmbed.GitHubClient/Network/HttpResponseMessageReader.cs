namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class HttpResponseMessageReader :
        StreamReader
    {
        private readonly HttpResponseMessage _response;

        private bool _disposed = false;

        public HttpResponseMessageReader(HttpResponseMessage response)
            : base(response.Content.ReadAsStreamAsync().Result, response.GetContentEncoding())
        {
            this._response = response;
        }

        private HttpResponseMessageReader(
            Stream stream,
            Encoding encoding)
            : base(stream, encoding)
        {
        }

        public static async Task<HttpResponseMessageReader> Create(HttpResponseMessage response)
        {
            var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var encoding = response.GetContentEncoding();

            return new HttpResponseMessageReader(stream, encoding);
        }

        protected override void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                this._response.Dispose();
            }

            base.Dispose(disposing);

            this._disposed = true;
        }
    }
}
