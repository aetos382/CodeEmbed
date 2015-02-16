namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Contracts;
    using CodeEmbed.GitHubClient.Network;

    [ContractClass(typeof(GitHubClientContracts))]
    public interface IGitHubClient
    {
        IConnection Connection { get; }

        Task<T> GetData<T>(
            Uri uri,
            CancellationToken cancellationToken);
    }
}
