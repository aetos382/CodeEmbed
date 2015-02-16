namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableUserPlan :
        IUserPlan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("space")]
        public long Space { get; set; }

        [JsonProperty("private_repos")]
        public int PrivateRepositories { get; set; }

        [JsonProperty("collaborators")]
        public int Collaborators { get; set; }
    }
}
