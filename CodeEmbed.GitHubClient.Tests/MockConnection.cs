namespace CodeEmbed.GitHubClient.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    internal class MockConnection :
        IConnection
    {
        public Func<Uri, string> DataFactory { get; set; }

        public Func<Uri, Stream> StreamFactory { get; set; } 

        public Uri BaseUri
        {
            get
            {
                return new Uri("http://www.example.com");
            }
        }

        public Task<Stream> GetAsStream(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            CancellationToken cancellationToken)
        {
            var stream = this.StreamFactory(uri);
            return Task.FromResult(stream);
        }

        public Task<TextReader> GetAsTextReader(
            Uri uri,
            IDictionary<string, string> requestHeader,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            string data = this.DataFactory(uri);

            var reader = new StringReader(data);
            return Task.FromResult((TextReader)reader);
        }
    }
}
