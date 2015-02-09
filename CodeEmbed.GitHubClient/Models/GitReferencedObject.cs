using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmbed.GitHubClient.Models
{
    using Newtonsoft.Json;

    [JsonObject]
    public class GitReferencedObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }
    }
}
