namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class SerializableGistHistory :
        IGistHistory
    {
        public string Version { get; set; }

        public DateTime CommittedAt { get; set; }

        public Uri Uri { get; set; }
    }
}
