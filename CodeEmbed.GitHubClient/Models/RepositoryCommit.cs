namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class RepositoryCommit :
        RepositoryCommitCore
    {
        [JsonProperty("commit")]
        public RepositoryGitCommit Commit { get; set; }

        [JsonProperty("stats")]
        public RepositoryCommitStat Stats { get; set; }

        [JsonProperty("files")]
        public IList<RepositoryCommitFile> Files { get; set; }
    }
}
