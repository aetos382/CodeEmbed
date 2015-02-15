using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmbed.GitHubClient
{
    using System.IO;

    public class GetDataResult :
        IDisposable
    {
        private readonly Stream _stream;

        private readonly Encoding _encoding;

        private bool _disposed;

        public GetDataResult(
            Stream stream,
            Encoding encoding)
        {
            this._stream = stream;
            this._encoding = encoding;
        }

        public Stream Stream
        {
            get
            {
                return this._stream;
            }
        }

        public Encoding Encoding
        {
            get
            {
                return this._encoding;
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

            this._stream.Dispose();

            this._disposed = true;
        }
    }
}
