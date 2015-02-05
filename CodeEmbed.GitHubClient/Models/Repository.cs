namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public partial class Repository
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("owner")]
        public RepositoryUser Owner { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }
}
