namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network.Contracts;

    [ContractClass(typeof(ConnectionContract))]
    public interface IConnection
    {
        Uri BaseUri { get; }

        Task<Stream> GetAsStream(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            CancellationToken cancellationToken);

        Task<TextReader> GetAsTextReader(
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken);
    }
}
