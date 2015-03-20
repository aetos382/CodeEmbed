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
    public partial class RepositoryMock :
        PublicRepositoryMock,
        IRepository
    {

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>Map to "pushed_at"</summary>
        public DateTime PushedAt { get; set; }

        /// <summary>Map to "git_url"</summary>
        public Uri GitUri { get; set; }

        /// <summary>Map to "ssh_url"</summary>
        public String SshUri { get; set; }

        /// <summary>Map to "clone_uri"</summary>
        public Uri CloneUri { get; set; }

        /// <summary>Map to "svn_url"</summary>
        public Uri SubversionUri { get; set; }

        /// <summary>Map to "homepage"</summary>
        public String Homepage { get; set; }

        /// <summary>Map to "size"</summary>
        public Int64 Size { get; set; }

        /// <summary>Map to "stargazers_count"</summary>
        public Int32 StargazersCount { get; set; }

        /// <summary>Map to "watchers_count"</summary>
        public Int32 WatchersCount { get; set; }

        /// <summary>Map to "language"</summary>
        public String Language { get; set; }

        /// <summary>Map to "has_issues"</summary>
        public Boolean HasIssues { get; set; }

        /// <summary>Map to "has_downloads"</summary>
        public Boolean HasDownloads { get; set; }

        /// <summary>Map to "has_wiki"</summary>
        public Boolean HasWiki { get; set; }

        /// <summary>Map to "has_pages"</summary>
        public Boolean HasPages { get; set; }

        /// <summary>Map to "forks_count"</summary>
        public Int32 ForksCount { get; set; }

        /// <summary>Map to "mirror_url"</summary>
        public Uri MirrorUri { get; set; }

        /// <summary>Map to "open_issues_count"</summary>
        public Int32 OpenIssuesCount { get; set; }

        /// <summary>Map to "forks"</summary>
        public Int32 Forks { get; set; }

        /// <summary>Map to "open_issues"</summary>
        public Int32 OpenIssues { get; set; }

        /// <summary>Map to "watchers"</summary>
        public Int32 Watchers { get; set; }

        /// <summary>Map to "default_branch"</summary>
        public String DefaultBranch { get; set; }

        /// <summary>Map to "permissions"</summary>
        public IPermissions Permissions { get; set; }

        /// <summary>Map to "organization"</summary>
        public IRepositoryUser Organization { get; set; }

        /// <summary>Map to "parent"</summary>
        public IRepository Parent { get; set; }

        /// <summary>Map to "source"</summary>
        public IRepository Source { get; set; }

        /// <summary>Map to "network_count"</summary>
        public Int32 NetworkCount { get; set; }

        /// <summary>Map to "subscribers_count"</summary>
        public Int32 SubscribersCount { get; set; }
    }
}

#endif
