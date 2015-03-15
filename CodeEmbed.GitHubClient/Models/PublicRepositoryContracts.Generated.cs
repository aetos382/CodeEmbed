namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    /// <summary>Contract class for IPublicRepository.</summary>
    [GeneratedCode("ModelContract.tt", "1.0")]
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IPublicRepository))]
    public abstract partial class PublicRepositoryContract :
        IPublicRepository
    {
        /// <summary>Map to "id"</summary>
        public abstract Int64 Id { get; }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                Contract.Ensures(Contract.Result<String>() != null);

                throw new NotImplementedException();
            }
        }

        /// <summary>Map to "full_name"</summary>
        public abstract String FullName { get; }

        /// <summary>Map to "owner"</summary>
        public IRepositoryUser Owner
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepositoryUser>() != null);

                throw new NotImplementedException();
            }
        }

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

        /// <summary>Map to "assignees_url"</summary>
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

        /// <summary>Map to "trees_url"</summary>
        public abstract String TreesUri { get; }

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

    }
}
