namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class GistFile
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("raw_url")]
        public Uri RawUri { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
