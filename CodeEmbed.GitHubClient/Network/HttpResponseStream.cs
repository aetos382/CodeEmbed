namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    internal class HttpResponseStream :
        Stream
    {
        private readonly HttpResponseMessage _response;

        private readonly Stream _stream;

        private bool _disposed = false;

        public static async Task<HttpResponseStream> Create(HttpResponseMessage response)
        {
            Contract.Requires<ArgumentNullException>(response != null);

            var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = new HttpResponseStream(response, stream);

            return result;
        }

        private HttpResponseStream(
            HttpResponseMessage response,
            Stream stream)
        {
            Contract.Requires<ArgumentNullException>(response != null);
            Contract.Requires<ArgumentNullException>(stream != null);

            this._response = response;
            this._stream = stream;
        }

        protected override void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                this._stream.Dispose();
                this._response.Dispose();
            }

            base.Dispose(disposing);
        }

        public override void Flush()
        {
            this._stream.Flush();
        }

        public override long Seek(
            long offset,
            SeekOrigin origin)
        {
            return this._stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            this._stream.SetLength(value);
        }

        public override int Read(
            byte[] buffer,
            int offset,
            int count)
        {
            return this._stream.Read(buffer, offset, count);
        }

        public override void Write(
            byte[] buffer,
            int offset,
            int count)
        {
            this._stream.Write(buffer, offset, count);
        }

        public override bool CanRead
        {
            get
            {
                return this._stream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return this._stream.CanSeek;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return this._stream.CanWrite;
            }
        }

        public override long Length
        {
            get
            {
                return this._stream.Length;
            }
        }

        public override long Position
        {
            get
            {
                return this._stream.Position;
            }

            set
            {
                this._stream.Position = value;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerStepThrough]
        [ContractInvariantMethod]
        private new void ObjectInvariant()
        {
            Contract.Invariant(this._response != null);
            Contract.Invariant(this._stream != Null);
        }
    }
}
