namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class GistHistory
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }
    }
}
