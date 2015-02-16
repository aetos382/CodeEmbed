namespace CodeEmbed.GitHubClient.Models.Serialization
{
using System;

using CodeEmbed.GitHubClient.Models.Internal;

using Newtonsoft.Json;

    [JsonObject]
    public class SerializableUserRepository :
        SerializableRepository,
        IUserRepository
    {
        [JsonProperty("permissions")]
        public IRepositoryPermissions Permissions { get; set; }
    }
}
