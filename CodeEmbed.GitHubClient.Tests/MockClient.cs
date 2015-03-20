namespace CodeEmbed.GitHubClient.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;
    using CodeEmbed.GitHubClient.Serialization;

    internal class MockClient :
        IGitHubClient
    {
        public Func<IConnection> ConnectionFactory { get; set; }

        public Func<IJsonSerializer> SerializerFactory { get; set; }

        public Func<Uri, object> ModelFactory { get; set; } 

        public IConnection Connection
        {
            get
            {
                if (this.ConnectionFactory == null)
                {
                    return null;
                }

                return this.ConnectionFactory();
            }
        }

        public IJsonSerializer Serializer
        {
            get
            {
                if (this.SerializerFactory == null)
                {
                    return null;
                }

                return this.SerializerFactory();
            }
        }

        public Task<T> GetData<T>(
            Uri uri,
            IDictionary<string, string> requestHeader,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            var result = this.ModelFactory(uri);

            return Task.FromResult((T)result);
        }
    }
}
