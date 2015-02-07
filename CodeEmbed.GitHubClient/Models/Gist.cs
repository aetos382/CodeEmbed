namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class Gist :
        ModelBase
    {
        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public RepositoryUser Owner { get; set; }

        [JsonProperty("files")]
        public IDictionary<string, GistFile> Files { get; set; } 

        [JsonProperty("history")]
        public IList<GistHistory> Histories { get; set; }
    }
}
