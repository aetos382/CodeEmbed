namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGistHistory
    {
        string Version { [Pure] get; }

        DateTime CommittedAt { [Pure] get; }

        Uri Uri { [Pure] get; }
    }
}
