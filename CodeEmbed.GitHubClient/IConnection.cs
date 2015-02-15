namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Contracts;

    [ContractClass(typeof(ConnectionContracts))]
    public interface IConnection
    {
        Uri BaseUri { get; }

        Task<GetDataResult> GetData(Uri uri, CancellationToken cancellationToken);
    }
}
