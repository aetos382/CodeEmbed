namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network.Contracts;

    [ContractClass(typeof(ConnectionContract))]
    public interface IConnection
    {
        Uri BaseUri { get; }

        Task<TextReader> GetData(Uri uri, CancellationToken cancellationToken);
    }
}
