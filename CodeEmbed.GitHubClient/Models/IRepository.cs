namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IRepository :
        IRepositorySummary
    {
        DateTime CreatedAt { [Pure] get; }

        DateTime UpdatedAt { [Pure] get; }

        DateTime PushedAt { [Pure] get; }

        Uri GitUri { [Pure] get; }

        string SshUri { [Pure] get; }

        Uri CloneUri { [Pure] get; }

        Uri SvnUri { [Pure] get; }

        string Homepage { [Pure] get; }

        long Size { [Pure] get; }

        int StargazersCount { [Pure] get; }

        int WatchersCount { [Pure] get; }

        string Language { [Pure] get; }

        bool HasIssues { [Pure] get; }

        bool HasDownloads { [Pure] get; }

        bool HasWiki { [Pure] get; }

        bool HasPages { [Pure] get; }

        int ForksCount { [Pure] get; }

        Uri MirrorUri { [Pure] get; }

        int OpenIssuesCount { [Pure] get; }

        int Forks { [Pure] get; }

        int OpenIssues { [Pure] get; }

        int Watchers { [Pure] get; }

        string DefaultBranch { [Pure] get; }
    }
}
