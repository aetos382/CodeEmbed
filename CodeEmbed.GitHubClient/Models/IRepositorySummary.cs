namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public interface IRepositorySummary
    {
        long Id { [Pure] get; }

        string Name { [Pure] get; }

        string FullName { [Pure] get; }

        IRepositoryUser Owner { [Pure] get; }

        bool Private { [Pure] get; }

        Uri HtmlUri { [Pure] get; }

        string Description { [Pure] get; }

        bool Fork { [Pure] get; }

        Uri Uri { [Pure] get; }

        Uri ForksUri { [Pure] get; }

        string KeysUri { [Pure] get; }

        string CollaboratorsUri { [Pure] get; }

        Uri TeamsUri { [Pure] get; }

        Uri HooksUri { [Pure] get; }

        string IssueEventsUri { [Pure] get; }

        Uri EventsUri { [Pure] get; }

        string AssigneesUri { [Pure] get; }

        string BranchesUri { [Pure] get; }

        Uri TagsUri { [Pure] get; }

        string BlobsUri { [Pure] get; }

        string GitTagsUri { [Pure] get; }

        string GitReferencesUri { [Pure] get; }

        string TreesUri { [Pure] get; }

        string StatusesUri { [Pure] get; }

        Uri LanguagesUri { [Pure] get; }

        Uri StargazersUri { [Pure] get; }

        Uri ContributorsUri { [Pure] get; }

        Uri SubscribersUri { [Pure] get; }

        Uri SubscriptionUri { [Pure] get; }

        string CommitsUri { [Pure] get; }

        string GitCommitsUri { [Pure] get; }

        string CommentsUri { [Pure] get; }

        string IssueCommentUri { [Pure] get; }

        string ContentsUri { [Pure] get; }

        string CompareUri { [Pure] get; }

        Uri MergesUri { [Pure] get; }

        string ArchiveUri { [Pure] get; }

        Uri DownloadsUri { [Pure] get; }

        string IssuesUri { [Pure] get; }

        string PullsUri { [Pure] get; }

        string MilestonesUri { [Pure] get; }

        string NotificationsUri { [Pure] get; }

        string LabelsUri { [Pure] get; }

        string ReleasesUri { [Pure] get; }
    }
}
