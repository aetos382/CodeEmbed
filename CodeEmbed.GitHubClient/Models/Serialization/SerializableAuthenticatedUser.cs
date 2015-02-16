namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableAuthenticatedUser :
        SerializableDetailedUser,
        IAuthenticatedUser
    {
        [JsonProperty("total_private_repos")]
        public int TotalPrivateRepositories { get; set; }

        [JsonProperty("owned_private_repos")]
        public int OwnedPrivateRepositories { get; set; }

        [JsonProperty("private_gists")]
        public int PrivateGists { get; set; }

        [JsonProperty("disk_usage")]
        public long DiskUsage { get; set; }

        [JsonProperty("collaborators")]
        public int Collaborators { get; set; }

        [JsonProperty("plan")]
        public IUserPlan Plan { get; set; }
    }
}
