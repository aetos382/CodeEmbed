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

        UriTemplate KeysUri { [Pure] get; }

        UriTemplate CollaboratorsUri { [Pure] get; }

        Uri TeamsUri { [Pure] get; }

        Uri HooksUri { [Pure] get; }

        UriTemplate IssueEventsUri { [Pure] get; }

        Uri EventsUri { [Pure] get; }

        UriTemplate AssigneesUri { [Pure] get; }

        UriTemplate BranchesUri { [Pure] get; }

        Uri TagsUri { [Pure] get; }

        UriTemplate BlobsUri { [Pure] get; }

        UriTemplate GitTagsUri { [Pure] get; }

        UriTemplate GitReferencesUri { [Pure] get; }

        UriTemplate TreesUri { [Pure] get; }

        UriTemplate StatusesUri { [Pure] get; }

        Uri LanguagesUri { [Pure] get; }

        Uri StargazersUri { [Pure] get; }

        Uri ContributorsUri { [Pure] get; }

        Uri SubscribersUri { [Pure] get; }

        Uri SubscriptionUri { [Pure] get; }

        UriTemplate CommitsUri { [Pure] get; }

        UriTemplate GitCommitsUri { [Pure] get; }

        UriTemplate CommentsUri { [Pure] get; }

        UriTemplate IssueCommentUri { [Pure] get; }

        UriTemplate ContentsUri { [Pure] get; }

        UriTemplate CompareUri { [Pure] get; }

        Uri MergesUri { [Pure] get; }

        UriTemplate ArchiveUri { [Pure] get; }

        Uri DownloadsUri { [Pure] get; }

        UriTemplate IssuesUri { [Pure] get; }

        UriTemplate PullsUri { [Pure] get; }

        UriTemplate MilestonesUri { [Pure] get; }

        UriTemplate NotificationsUri { [Pure] get; }

        UriTemplate LabelsUri { [Pure] get; }

        UriTemplate ReleasesUri { [Pure] get; }
    }
}
