namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableGistFile :
        IGistFile
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("law_url")]
        public Uri RawUri { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
