namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/git/blobs/:sha
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GitBlob
    {
        public string Content { get; set; }

        public string Encoding { get; set; }

        public Uri Uri { get; set; }

        public string Hash { get; set; }

        public long Size { get; set; }
    }
}
