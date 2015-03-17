namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
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

        private HttpResponseMessageReader(
            HttpResponseMessage response,
            Stream stream,
            Encoding encoding)
            : base(stream, encoding)
        {
            Contract.Requires<ArgumentNullException>(response != null);
            Contract.Requires<ArgumentNullException>(stream != null);
            Contract.Requires<ArgumentNullException>(encoding != null);

            this._response = response;
        }

        public static async Task<HttpResponseMessageReader> Create(
            HttpResponseMessage response,
            Encoding encoding)
        {
            Contract.Requires<ArgumentNullException>(response != null);

            var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            if (encoding == null)
            {
                encoding = response.GetContentEncoding();
            }

            return new HttpResponseMessageReader(response, stream, encoding);
        }

        public static Task<HttpResponseMessageReader> Create(
            HttpResponseMessage response)
        {
            Contract.Requires<ArgumentNullException>(response != null);

            return Create(response, null);
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

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._response != null);
        }
    }
}
