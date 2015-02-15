namespace CodeEmbed.GitHubClient
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IJsonSerializer
    {
        Task<T> Deserialize<T>(
            Stream stream,
            Encoding encoding,
            CancellationToken cancellationToken);
    }
}
