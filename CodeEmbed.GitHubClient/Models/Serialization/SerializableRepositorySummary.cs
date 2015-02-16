namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepositorySummary :
        IRepositorySummary
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("owner")]
        public IRepositoryUser Owner { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUri { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("forks_url")]
        public Uri ForksUri { get; set; }

        [JsonProperty("keys_url")]
        public string KeysUri { get; set; }

        [JsonProperty("collaborators_url")]
        public string CollaboratorsUri { get; set; }

        [JsonProperty("teams_url")]
        public Uri TeamsUri { get; set; }

        [JsonProperty("hooks_url")]
        public Uri HooksUri { get; set; }

        [JsonProperty("issue_events_url")]
        public string IssueEventsUri { get; set; }

        [JsonProperty("events_url")]
        public Uri EventsUri { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesUri { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesUri { get; set; }

        [JsonProperty("tags_url")]
        public Uri TagsUri { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsUri { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsUri { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitReferencesUri { get; set; }

        [JsonProperty("trees_url")]
        public string TreesUri { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesUri { get; set; }

        [JsonProperty("labels_url")]
        public Uri LanguagesUri { get; set; }

        [JsonProperty("stargazers_url")]
        public Uri StargazersUri { get; set; }

        [JsonProperty("contributors_url")]
        public Uri ContributorsUri { get; set; }

        [JsonProperty("subscribers_url")]
        public Uri SubscribersUri { get; set; }

        [JsonProperty("subscription_url")]
        public Uri SubscriptionUri { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUri { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsUri { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUri { get; set; }

        [JsonProperty("issue_comment_url")]
        public string IssueCommentUri { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUri { get; set; }

        [JsonProperty("compare_url")]
        public string CompareUri { get; set; }

        [JsonProperty("merges_url")]
        public Uri MergesUri { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUri { get; set; }

        [JsonProperty("downloads_url")]
        public Uri DownloadsUri { get; set; }

        [JsonProperty("issues_url")]
        public string IssuesUri { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsUri { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesUri { get; set; }

        [JsonProperty("notofications_url")]
        public string NotificationsUri { get; set; }

        [JsonProperty("labels_url")]
        public string LabelsUri { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUri { get; set; }
    }
}
