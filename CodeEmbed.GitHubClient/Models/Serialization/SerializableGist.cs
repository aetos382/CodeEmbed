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
    public class SerializableGist :
        IGist
    {
        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("files")]
        public IDictionary<string, IGistFile> Files { get; set; }

        [JsonProperty("histories")]
        public IList<IGistHistory> Histories { get; set; }
    }
}
