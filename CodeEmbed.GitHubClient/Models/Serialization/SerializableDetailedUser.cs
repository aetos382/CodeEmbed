namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableDetailedUser :
        SerializableRepositoryUser,
        IDetailedUser
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public Uri Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("hireable")]
        public bool Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("public_repos")]
        public int PublicRepositories { get; set; }

        [JsonProperty("public_gists")]
        public int PublicGists { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
