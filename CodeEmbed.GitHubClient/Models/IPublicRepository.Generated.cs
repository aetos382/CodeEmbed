namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    [ContractClass(typeof(PublicRepositoryContract))]
    public partial interface IPublicRepository
    {
        /// <summary>Map to "id"</summary>
        Int64 Id { [Pure] get; }

        /// <summary>Map to "name"</summary>
        String Name { [Pure] get; }

        /// <summary>Map to "full_name"</summary>
        String FullName { [Pure] get; }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser Owner { [Pure] get; }

        /// <summary>Map to "private"</summary>
        Boolean IsPrivate { [Pure] get; }

        /// <summary>Map to "html_url"</summary>
        Uri HtmlUri { [Pure] get; }

        /// <summary>Map to "description"</summary>
        String Description { [Pure] get; }

        /// <summary>Map to "fork"</summary>
        Boolean Fork { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "forks_url"</summary>
        Uri ForksUri { [Pure] get; }

        /// <summary>Map to "keys_url"</summary>
        String KeysUri { [Pure] get; }

        /// <summary>Map to "collaborators_url"</summary>
        String CollaboratorsUri { [Pure] get; }

        /// <summary>Map to "teams_url"</summary>
        Uri TeamsUri { [Pure] get; }

        /// <summary>Map to "hooks_url"</summary>
        Uri HooksUri { [Pure] get; }

        /// <summary>Map to "issue_events_url"</summary>
        String IssueEventsUri { [Pure] get; }

        /// <summary>Map to "events_url"</summary>
        Uri EventsUri { [Pure] get; }

        /// <summary>Map to "assignees_url"</summary>
        String AssigneesUri { [Pure] get; }

        /// <summary>Map to "branches_url"</summary>
        String BranchesUri { [Pure] get; }

        /// <summary>Map to "tags_url"</summary>
        Uri TagsUri { [Pure] get; }

        /// <summary>Map to "blobs_url"</summary>
        String BlobsUri { [Pure] get; }

        /// <summary>Map to "git_tags_url"</summary>
        String GitTagsUri { [Pure] get; }

        /// <summary>Map to "git_refs_url"</summary>
        String GitReferenesUri { [Pure] get; }

        /// <summary>Map to "trees_url"</summary>
        String TreesUri { [Pure] get; }

        /// <summary>Map to "statuses_url"</summary>
        String StatusesUri { [Pure] get; }

        /// <summary>Map to "languages_url"</summary>
        Uri LanguagesUri { [Pure] get; }

        /// <summary>Map to "stargazers_url"</summary>
        Uri StargazersUri { [Pure] get; }

        /// <summary>Map to "contributos_url"</summary>
        Uri ContributorsUri { [Pure] get; }

        /// <summary>Map to "subscribers_url"</summary>
        Uri SubscribersUri { [Pure] get; }

        /// <summary>Map to "subscription_url"</summary>
        Uri SubscriptionUri { [Pure] get; }

        /// <summary>Map to "commits_url"</summary>
        String CommitsUri { [Pure] get; }

        /// <summary>Map to "git_commits_url"</summary>
        String GitCommitsUri { [Pure] get; }

        /// <summary>Map to "comments_url"</summary>
        string CommentsUri { [Pure] get; }

        /// <summary>Map to "issue_comment_url"</summary>
        String IssueCommentUri { [Pure] get; }

        /// <summary>Map to "contents_url"</summary>
        String ContentsUri { [Pure] get; }

        /// <summary>Map to "compare_url"</summary>
        String CompareUri { [Pure] get; }

        /// <summary>Map to "merges_url"</summary>
        Uri MergesUri { [Pure] get; }

        /// <summary>Map to "archive_url"</summary>
        String ArchiveUri { [Pure] get; }

        /// <summary>Map to "downloads_url"</summary>
        Uri DownloadsUri { [Pure] get; }

        /// <summary>Map to "issues_url"</summary>
        String IssuesUri { [Pure] get; }

        /// <summary>Map to "pulls_url"</summary>
        String PullsUri { [Pure] get; }

        /// <summary>Map to "milestones_url"</summary>
        String MilestonesUri { [Pure] get; }

        /// <summary>Map to "notifications_url"</summary>
        String NotificationsUri { [Pure] get; }

        /// <summary>Map to "labels_url"</summary>
        String LabelsUri { [Pure] get; }

        /// <summary>Map to "releases_url"</summary>
        String ReleasesUri { [Pure] get; }

    }
}
