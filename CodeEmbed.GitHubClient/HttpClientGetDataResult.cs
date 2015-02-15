namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class HttpClientGetDataResult :
        GetDataResult
    {
        private HttpResponseMessage _response;

        private HttpClientGetDataResult(
            HttpResponseMessage response,
            Stream stream,
            Encoding encoding)
            : base(stream, encoding)
        {
            this._response = response;
        }

        public static async Task<HttpClientGetDataResult> Create(
            HttpResponseMessage response)
        {
            Stream stream = null;

            try
            {
                var encoding = response.GetContentEncoding();
                stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var result = new HttpClientGetDataResult(response, stream, encoding);

                stream = null;

                return result;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                    stream = null;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            this._response.Dispose();

            base.Dispose(disposing);
        }
    }
}
