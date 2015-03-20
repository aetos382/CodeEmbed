#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class PublicRepositoryMock :
        IPublicRepository
    {

        /// <summary>Map to "id"</summary>
        public Int64 Id { get; set; }

        /// <summary>Map to "name"</summary>
        public String Name { get; set; }

        /// <summary>Map to "full_name"</summary>
        public String FullName { get; set; }

        /// <summary>Map to "owner"</summary>
        public IRepositoryUser Owner { get; set; }

        /// <summary>Map to "private"</summary>
        public Boolean IsPrivate { get; set; }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri { get; set; }

        /// <summary>Map to "description"</summary>
        public String Description { get; set; }

        /// <summary>Map to "fork"</summary>
        public Boolean Fork { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "forks_url"</summary>
        public Uri ForksUri { get; set; }

        /// <summary>Map to "keys_url"</summary>
        public String KeysUri { get; set; }

        /// <summary>Map to "collaborators_url"</summary>
        public String CollaboratorsUri { get; set; }

        /// <summary>Map to "teams_url"</summary>
        public Uri TeamsUri { get; set; }

        /// <summary>Map to "hooks_url"</summary>
        public Uri HooksUri { get; set; }

        /// <summary>Map to "issue_events_url"</summary>
        public String IssueEventsUri { get; set; }

        /// <summary>Map to "events_url"</summary>
        public Uri EventsUri { get; set; }

        /// <summary>Map to "assignees_url"</summary>
        public String AssigneesUri { get; set; }

        /// <summary>Map to "branches_url"</summary>
        public String BranchesUri { get; set; }

        /// <summary>Map to "tags_url"</summary>
        public Uri TagsUri { get; set; }

        /// <summary>Map to "blobs_url"</summary>
        public String BlobsUri { get; set; }

        /// <summary>Map to "git_tags_url"</summary>
        public String GitTagsUri { get; set; }

        /// <summary>Map to "git_refs_url"</summary>
        public String GitReferenesUri { get; set; }

        /// <summary>Map to "trees_url"</summary>
        public String TreesUri { get; set; }

        /// <summary>Map to "statuses_url"</summary>
        public String StatusesUri { get; set; }

        /// <summary>Map to "languages_url"</summary>
        public Uri LanguagesUri { get; set; }

        /// <summary>Map to "stargazers_url"</summary>
        public Uri StargazersUri { get; set; }

        /// <summary>Map to "contributos_url"</summary>
        public Uri ContributorsUri { get; set; }

        /// <summary>Map to "subscribers_url"</summary>
        public Uri SubscribersUri { get; set; }

        /// <summary>Map to "subscription_url"</summary>
        public Uri SubscriptionUri { get; set; }

        /// <summary>Map to "commits_url"</summary>
        public String CommitsUri { get; set; }

        /// <summary>Map to "git_commits_url"</summary>
        public String GitCommitsUri { get; set; }

        /// <summary>Map to "comments_url"</summary>
        public string CommentsUri { get; set; }

        /// <summary>Map to "issue_comment_url"</summary>
        public String IssueCommentUri { get; set; }

        /// <summary>Map to "contents_url"</summary>
        public String ContentsUri { get; set; }

        /// <summary>Map to "compare_url"</summary>
        public String CompareUri { get; set; }

        /// <summary>Map to "merges_url"</summary>
        public Uri MergesUri { get; set; }

        /// <summary>Map to "archive_url"</summary>
        public String ArchiveUri { get; set; }

        /// <summary>Map to "downloads_url"</summary>
        public Uri DownloadsUri { get; set; }

        /// <summary>Map to "issues_url"</summary>
        public String IssuesUri { get; set; }

        /// <summary>Map to "pulls_url"</summary>
        public String PullsUri { get; set; }

        /// <summary>Map to "milestones_url"</summary>
        public String MilestonesUri { get; set; }

        /// <summary>Map to "notifications_url"</summary>
        public String NotificationsUri { get; set; }

        /// <summary>Map to "labels_url"</summary>
        public String LabelsUri { get; set; }

        /// <summary>Map to "releases_url"</summary>
        public String ReleasesUri { get; set; }
    }
}

#endif
