namespace CodeEmbed.GitHub.Models
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class RepositoryBranch
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("commit")]
        public RepositoryCommitCore Commit { get; set; }
    }
}
