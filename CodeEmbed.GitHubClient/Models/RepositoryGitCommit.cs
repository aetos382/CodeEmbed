namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using Newtonsoft.Json;

    public class RepositoryGitCommit :
        GitCommitCore
    {
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }
    }
}
