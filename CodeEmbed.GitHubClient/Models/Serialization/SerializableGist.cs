namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class SerializableGist :
        IGist
    {
        public Uri Uri { get; set; }

        public string Id { get; set; }

        public string Description { get; set; }

        public IDictionary<string, IGistFile> Files { get; set; }

        public IList<IGistHistory> Histories { get; set; }
    }
}
