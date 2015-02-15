namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SerializableRepository :
        IRepository
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public Uri Uri { get; set; }

        public string DefaultBranch { get; set; }
    }
}
