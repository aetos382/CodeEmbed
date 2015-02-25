namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Newtonsoft.Json.Serialization;

    [ContractClass(typeof(JsonISerializableContract))]
    public interface IJsonSerializer
    {
        Task<T> Deserialize<T>(
            TextReader reader,
            CancellationToken cancellationToken);
    }
}
