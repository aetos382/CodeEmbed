namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    /// <summary>Contract class for IRepository.</summary>
    [GeneratedCode("ModelContract.tt", "1.0")]
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IRepository))]
    public abstract partial class RepositoryContract :
        IRepository
    {
        /// <summary>Map to "id"</summary>
        public abstract Int64 Id { get; }

        /// <summary>Map to "name"</summary>
        public abstract String Name { get; }

        /// <summary>Map to "full_name"</summary>
        public abstract String FullName { get; }

        /// <summary>Map to "owner"</summary>
        public abstract IRepositoryUser Owner { get; }

        /// <summary>Map to "private"</summary>
        public abstract Boolean IsPrivate { get; }

        /// <summary>Map to "html_url"</summary>
        public abstract Uri HtmlUri { get; }

        /// <summary>Map to "description"</summary>
        public abstract String Description { get; }

        /// <summary>Map to "fork"</summary>
        public abstract Boolean Fork { get; }

        /// <summary>Map to "url"</summary>
        public abstract Uri Uri { get; }

        /// <summary>Map to "forks_url"</summary>
        public abstract Uri ForksUri { get; }

        /// <summary>Map to "keys_url"</summary>
        public abstract String KeysUri { get; }

        /// <summary>Map to "collaborators_url"</summary>
        public abstract String CollaboratorsUri { get; }

        /// <summary>Map to "teams_url"</summary>
        public abstract Uri TeamsUri { get; }

        /// <summary>Map to "hooks_url"</summary>
        public abstract Uri HooksUri { get; }

        /// <summary>Map to "issue_events_url"</summary>
        public abstract String IssueEventsUri { get; }

        /// <summary>Map to "events_url"</summary>
        public abstract Uri EventsUri { get; }

        /// <summary>Map to "assignee_url"</summary>
        public abstract String AssigneesUri { get; }

        /// <summary>Map to "branches_url"</summary>
        public abstract String BranchesUri { get; }

        /// <summary>Map to "tags_url"</summary>
        public abstract Uri TagsUri { get; }

        /// <summary>Map to "blobs_url"</summary>
        public abstract String BlobsUri { get; }

        /// <summary>Map to "git_tags_url"</summary>
        public abstract String GitTagsUri { get; }

        /// <summary>Map to "git_refs_url"</summary>
        public abstract String GitReferenesUri { get; }

        /// <summary>Map to "statuses_url"</summary>
        public abstract String StatusesUri { get; }

        /// <summary>Map to "languages_url"</summary>
        public abstract Uri LanguagesUri { get; }

        /// <summary>Map to "stargazers_url"</summary>
        public abstract Uri StargazersUri { get; }

        /// <summary>Map to "contributos_url"</summary>
        public abstract Uri ContributorsUri { get; }

        /// <summary>Map to "subscribers_url"</summary>
        public abstract Uri SubscribersUri { get; }

        /// <summary>Map to "subscription_url"</summary>
        public abstract Uri SubscriptionUri { get; }

        /// <summary>Map to "commits_url"</summary>
        public abstract String CommitsUri { get; }

        /// <summary>Map to "git_commits_url"</summary>
        public abstract String GitCommitsUri { get; }

        /// <summary>Map to "comments_url"</summary>
        public abstract string CommentsUri { get; }

        /// <summary>Map to "issue_comment_url"</summary>
        public abstract String IssueCommentUri { get; }

        /// <summary>Map to "contents_url"</summary>
        public abstract String ContentsUri { get; }

        /// <summary>Map to "compare_url"</summary>
        public abstract String CompareUri { get; }

        /// <summary>Map to "merges_url"</summary>
        public abstract Uri MergesUri { get; }

        /// <summary>Map to "archive_url"</summary>
        public abstract String ArchiveUri { get; }

        /// <summary>Map to "downloads_url"</summary>
        public abstract Uri DownloadsUri { get; }

        /// <summary>Map to "issues_url"</summary>
        public abstract String IssuesUri { get; }

        /// <summary>Map to "pulls_url"</summary>
        public abstract String PullsUri { get; }

        /// <summary>Map to "milestones_url"</summary>
        public abstract String MilestonesUri { get; }

        /// <summary>Map to "notifications_url"</summary>
        public abstract String NotificationsUri { get; }

        /// <summary>Map to "labels_url"</summary>
        public abstract String LabelsUri { get; }

        /// <summary>Map to "releases_url"</summary>
        public abstract String ReleasesUri { get; }

        /// <summary>Map to "created_at"</summary>
        public abstract DateTime CreatedAt { get; }

        /// <summary>Map to "updated_at"</summary>
        public abstract DateTime UpdatedAt { get; }

        /// <summary>Map to "pushed_at"</summary>
        public abstract DateTime PushedAt { get; }

        /// <summary>Map to "git_url"</summary>
        public abstract Uri GitUri { get; }

        /// <summary>Map to "ssh_url"</summary>
        public abstract String SshUri { get; }

        /// <summary>Map to "clone_uri"</summary>
        public abstract Uri CloneUri { get; }

        /// <summary>Map to "svn_url"</summary>
        public abstract Uri SubversionUri { get; }

        /// <summary>Map to "homepage"</summary>
        public abstract String Homepage { get; }

        /// <summary>Map to "size"</summary>
        public abstract Int64 Size { get; }

        /// <summary>Map to "stargazers_count"</summary>
        public abstract Int32 StargazersCount { get; }

        /// <summary>Map to "watchers_count"</summary>
        public abstract Int32 WatchersCount { get; }

        /// <summary>Map to "language"</summary>
        public abstract String Language { get; }

        /// <summary>Map to "has_issues"</summary>
        public abstract Boolean HasIssues { get; }

        /// <summary>Map to "has_downloads"</summary>
        public abstract Boolean HasDownloads { get; }

        /// <summary>Map to "has_wiki"</summary>
        public abstract Boolean HasWiki { get; }

        /// <summary>Map to "has_pages"</summary>
        public abstract Boolean HasPages { get; }

        /// <summary>Map to "forks_count"</summary>
        public abstract Int32 ForksCount { get; }

        /// <summary>Map to "mirror_url"</summary>
        public abstract Uri MirrorUri { get; }

        /// <summary>Map to "open_issues_count"</summary>
        public abstract Int32 OpenIssuesCount { get; }

        /// <summary>Map to "forks"</summary>
        public abstract Int32 Forks { get; }

        /// <summary>Map to "open_issues"</summary>
        public abstract Int32 OpenIssues { get; }

        /// <summary>Map to "watchers"</summary>
        public abstract Int32 Watchers { get; }

        /// <summary>Map to "default_branch"</summary>
        public String DefaultBranch
        {
            get
            {
                Contract.Ensures(Contract.Result<String>() != null);

                throw new NotImplementedException();
            }
        }

        /// <summary>Map to "permissions"</summary>
        public abstract IPermissions Permissions { get; }

        /// <summary>Map to "organization"</summary>
        public abstract IRepositoryUser Organization { get; }

        /// <summary>Map to "parent"</summary>
        public abstract IRepository Parent { get; }

        /// <summary>Map to "source"</summary>
        public abstract IRepository Source { get; }

        /// <summary>Map to "network_count"</summary>
        public abstract Int32 NetworkCount { get; }

        /// <summary>Map to "subscribers_count"</summary>
        public abstract Int32 SubscribersCount { get; }

    }
}
