using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmbed.GitHubClient.Models
{
    using Newtonsoft.Json;

    [JsonObject]
    public class GitReference :
        ModelBase
    {
        [JsonProperty("ref")]
        public string Reference { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("object")]
        public GitReferencedObject Object { get; set; }
    }
}
