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
        public UriTemplate KeysUri { get; set; }

        [JsonProperty("collaborators_url")]
        public UriTemplate CollaboratorsUri { get; set; }

        [JsonProperty("teams_url")]
        public Uri TeamsUri { get; set; }

        [JsonProperty("hooks_url")]
        public Uri HooksUri { get; set; }

        [JsonProperty("issue_events_url")]
        public UriTemplate IssueEventsUri { get; set; }

        [JsonProperty("events_url")]
        public Uri EventsUri { get; set; }

        [JsonProperty("assignees_url")]
        public UriTemplate AssigneesUri { get; set; }

        [JsonProperty("branches_url")]
        public UriTemplate BranchesUri { get; set; }

        [JsonProperty("tags_url")]
        public Uri TagsUri { get; set; }

        [JsonProperty("blobs_url")]
        public UriTemplate BlobsUri { get; set; }

        [JsonProperty("git_tags_url")]
        public UriTemplate GitTagsUri { get; set; }

        [JsonProperty("git_refs_url")]
        public UriTemplate GitReferencesUri { get; set; }

        [JsonProperty("trees_url")]
        public UriTemplate TreesUri { get; set; }

        [JsonProperty("statuses_url")]
        public UriTemplate StatusesUri { get; set; }

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
        public UriTemplate CommitsUri { get; set; }

        [JsonProperty("git_commits_url")]
        public UriTemplate GitCommitsUri { get; set; }

        [JsonProperty("comments_url")]
        public UriTemplate CommentsUri { get; set; }

        [JsonProperty("issue_comment_url")]
        public UriTemplate IssueCommentUri { get; set; }

        [JsonProperty("contents_url")]
        public UriTemplate ContentsUri { get; set; }

        [JsonProperty("compare_url")]
        public UriTemplate CompareUri { get; set; }

        [JsonProperty("merges_url")]
        public Uri MergesUri { get; set; }

        [JsonProperty("archive_url")]
        public UriTemplate ArchiveUri { get; set; }

        [JsonProperty("downloads_url")]
        public Uri DownloadsUri { get; set; }

        [JsonProperty("issues_url")]
        public UriTemplate IssuesUri { get; set; }

        [JsonProperty("pulls_url")]
        public UriTemplate PullsUri { get; set; }

        [JsonProperty("milestones_url")]
        public UriTemplate MilestonesUri { get; set; }

        [JsonProperty("notofications_url")]
        public UriTemplate NotificationsUri { get; set; }

        [JsonProperty("labels_url")]
        public UriTemplate LabelsUri { get; set; }

        [JsonProperty("releases_url")]
        public UriTemplate ReleasesUri { get; set; }
    }
}
