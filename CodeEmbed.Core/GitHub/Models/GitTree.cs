namespace CodeEmbed.Core.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using Newtonsoft.Json;

    [JsonObject]
    public class GitTree
    {
        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("tree")]
        public IList<GitTreeNode> Tree { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }
    }
}
