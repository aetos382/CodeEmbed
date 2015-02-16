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
    public class SerializableGistHistory :
        IGistHistory
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("committed_at")]
        public DateTime CommittedAt { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }
    }
}
