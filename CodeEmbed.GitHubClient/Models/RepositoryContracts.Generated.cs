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

        /// <summary>Map to "owner"</summary>
        public abstract IRepositoryUser Owner { get; }

        /// <summary>Map to "name"</summary>
        public abstract String Name { get; }

        /// <summary>Map to "full_name"</summary>
        public abstract String FullName { get; }

        /// <summary>Map to "description"</summary>
        public abstract String Description { get; }

        /// <summary>Map to "private"</summary>
        public abstract Boolean IsPrivate { get; }

        /// <summary>Map to "fork"</summary>
        public abstract Boolean Fork { get; }

        /// <summary>Map to "url"</summary>
        public abstract Uri Uri { get; }

        /// <summary>Map to "html_url"</summary>
        public abstract Uri HtmlUri { get; }

        /// <summary>Map to "clone_uri"</summary>
        public abstract Uri CloneUri { get; }

        /// <summary>Map to "git_url"</summary>
        public abstract Uri GitUri { get; }

        /// <summary>Map to "ssh_url"</summary>
        public abstract Uri SshUri { get; }

        /// <summary>Map to "svn_url"</summary>
        public abstract Uri SubversionUri { get; }

        /// <summary>Map to "mirror_url"</summary>
        public abstract Uri MirrorUri { get; }

        /// <summary>Map to "homepage"</summary>
        public abstract Uri Homepage { get; }

        /// <summary>Map to "language"</summary>
        public abstract String Language { get; }

        /// <summary>Map to "forks_count"</summary>
        public abstract Int32 ForksCount { get; }

        /// <summary>Map to "stargazers_count"</summary>
        public abstract Int32 StargazersCount { get; }

        /// <summary>Map to "watchers_count"</summary>
        public abstract Int32 WatchersCount { get; }

        /// <summary>Map to "size"</summary>
        public abstract Int64 Size { get; }

        /// <summary>Map to "default_branch"</summary>
        public String DefaultBranch
        {
            get
            {
                Contract.Ensures(Contract.Result<String>() != null);

                throw new NotImplementedException();
            }
        }

        /// <summary>Map to "open_issues_count"</summary>
        public abstract Int32 OpenIssuesCount { get; }

        /// <summary>Map to "has_issues"</summary>
        public abstract Boolean HasIssues { get; }

        /// <summary>Map to "has_wiki"</summary>
        public abstract Boolean HasWiki { get; }

        /// <summary>Map to "has_pages"</summary>
        public abstract Boolean HasPages { get; }

        /// <summary>Map to "has_downloads"</summary>
        public abstract Boolean HasDownloads { get; }

        /// <summary>Map to "pushed_at"</summary>
        public abstract DateTime PushedAt { get; }

        /// <summary>Map to "created_at"</summary>
        public abstract DateTime CreatedAt { get; }

        /// <summary>Map to "updated_at"</summary>
        public abstract DateTime UpdatedAt { get; }

        /// <summary>Map to "permissions"</summary>
        public abstract IPermissions Permissions { get; }

        /// <summary>Map to "subscribers_count"</summary>
        public abstract Int32 SubscribersCount { get; }

        /// <summary>Map to "organization"</summary>
        public abstract IRepositoryUser Organization { get; }

        /// <summary>Map to "parent"</summary>
        public abstract IRepository Parent { get; }

        /// <summary>Map to "source"</summary>
        public abstract IRepository Source { get; }

    }
}
