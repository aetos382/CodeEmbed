namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;

    public interface IGist
    {
        Uri Uri { [Pure] get; }

        string Id { [Pure] get; }

        string Description { [Pure] get; }

        IDictionary<string, IGistFile> Files { [Pure] get; }

        IList<IGistHistory> Histories { [Pure] get; }
    }
}
