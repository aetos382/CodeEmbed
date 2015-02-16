namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepositoryPermissions :
        IRepositoryPermissions
    {
        [JsonProperty("admin")]
        public bool Administration { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }
    }
}
