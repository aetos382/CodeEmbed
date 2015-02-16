namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepository :
        SerializableRepositorySummary,
        IRepository
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("pushed_at")]
        public DateTime PushedAt { get; set; }

        [JsonProperty("git_url")]
        public Uri GitUri { get; set; }

        [JsonProperty("ssh_url")]
        public string SshUri { get; set; }

        [JsonProperty("clone_url")]
        public Uri CloneUri { get; set; }

        [JsonProperty("svn_url")]
        public Uri SvnUri { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [JsonProperty("mirror_url")]
        public Uri MirrorUri { get; set; }

        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [JsonProperty("forks")]
        public int Forks { get; set; }

        [JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }
}
