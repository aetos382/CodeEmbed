namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    [ContractClass(typeof(RepositoryContract))]
    public partial interface IRepository
        : IPublicRepository
    {
        /// <summary>Map to "created_at"</summary>
        DateTime CreatedAt { [Pure] get; }

        /// <summary>Map to "updated_at"</summary>
        DateTime UpdatedAt { [Pure] get; }

        /// <summary>Map to "pushed_at"</summary>
        DateTime PushedAt { [Pure] get; }

        /// <summary>Map to "git_url"</summary>
        Uri GitUri { [Pure] get; }

        /// <summary>Map to "ssh_url"</summary>
        String SshUri { [Pure] get; }

        /// <summary>Map to "clone_uri"</summary>
        Uri CloneUri { [Pure] get; }

        /// <summary>Map to "svn_url"</summary>
        Uri SubversionUri { [Pure] get; }

        /// <summary>Map to "homepage"</summary>
        String Homepage { [Pure] get; }

        /// <summary>Map to "size"</summary>
        Int64 Size { [Pure] get; }

        /// <summary>Map to "stargazers_count"</summary>
        Int32 StargazersCount { [Pure] get; }

        /// <summary>Map to "watchers_count"</summary>
        Int32 WatchersCount { [Pure] get; }

        /// <summary>Map to "language"</summary>
        String Language { [Pure] get; }

        /// <summary>Map to "has_issues"</summary>
        Boolean HasIssues { [Pure] get; }

        /// <summary>Map to "has_downloads"</summary>
        Boolean HasDownloads { [Pure] get; }

        /// <summary>Map to "has_wiki"</summary>
        Boolean HasWiki { [Pure] get; }

        /// <summary>Map to "has_pages"</summary>
        Boolean HasPages { [Pure] get; }

        /// <summary>Map to "forks_count"</summary>
        Int32 ForksCount { [Pure] get; }

        /// <summary>Map to "mirror_url"</summary>
        Uri MirrorUri { [Pure] get; }

        /// <summary>Map to "open_issues_count"</summary>
        Int32 OpenIssuesCount { [Pure] get; }

        /// <summary>Map to "forks"</summary>
        Int32 Forks { [Pure] get; }

        /// <summary>Map to "open_issues"</summary>
        Int32 OpenIssues { [Pure] get; }

        /// <summary>Map to "watchers"</summary>
        Int32 Watchers { [Pure] get; }

        /// <summary>Map to "default_branch"</summary>
        String DefaultBranch { [Pure] get; }

        /// <summary>Map to "permissions"</summary>
        IPermissions Permissions { [Pure] get; }

        /// <summary>Map to "organization"</summary>
        IRepositoryUser Organization { [Pure] get; }

        /// <summary>Map to "parent"</summary>
        IRepository Parent { [Pure] get; }

        /// <summary>Map to "source"</summary>
        IRepository Source { [Pure] get; }

        /// <summary>Map to "network_count"</summary>
        Int32 NetworkCount { [Pure] get; }

        /// <summary>Map to "subscribers_count"</summary>
        Int32 SubscribersCount { [Pure] get; }

    }
}
