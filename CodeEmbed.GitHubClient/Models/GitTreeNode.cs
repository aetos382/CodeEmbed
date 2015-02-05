namespace CodeEmbed.GitHubClient.Models
{
    using System;

    using Newtonsoft.Json;

    [JsonObject]
    public class GitTreeNode
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public long? Size { get; set; }

        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }
    }
}
