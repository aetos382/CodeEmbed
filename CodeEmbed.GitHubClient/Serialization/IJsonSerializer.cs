namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IJsonSerializer
    {
        Task<T> Deserialize<T>(
            TextReader reader,
            CancellationToken cancellationToken);
    }
}
