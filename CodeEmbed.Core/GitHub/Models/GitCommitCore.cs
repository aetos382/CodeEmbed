using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmbed.Core.GitHub.Models
{
    using Newtonsoft.Json;

    [JsonObject]
    public class GitCommitCore
    {
        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("author")]
        public Signature Author { get; set; }

        [JsonProperty("committer")]
        public Signature Committer { get; set; }

        [JsonProperty("tree")]
        public Reference Tree { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
