namespace CodeEmbed.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class RepositoryCommitCore
    {
        public Uri Uri { get; set; }

        public string Hash { get; set; }

        public Uri HtmlUri { get; set; }

        public Uri CommentsUri { get; set; }

        public RepositoryUser Author { get; set; }

        public RepositoryUser Committer { get; set; }

        public IList<ReferenceWithHtml> Parents { get; set; }
    }
}
