namespace CodeEmbed.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class GitBlob
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }
}
