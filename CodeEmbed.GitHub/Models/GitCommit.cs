namespace CodeEmbed.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class GitCommit :
        GitCommitCore
    {
        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUri { get; set; }

        [JsonProperty("parents")]
        public IList<ReferenceWithHtml> Parents { get; set; }
    }
}
