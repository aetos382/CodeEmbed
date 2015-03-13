namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class Repository :
        PublicRepository,
        IRepository
    {
        private readonly IRepository _repository = null;

        [ContractPublicPropertyName("Permissions")]
        private readonly Permissions _permissions = null;

        [ContractPublicPropertyName("Organization")]
        private readonly RepositoryUser _organization = null;

        [ContractPublicPropertyName("Parent")]
        private readonly Repository _parent = null;

        [ContractPublicPropertyName("Source")]
        private readonly Repository _source = null;

        /// <summary>Create new instance of Repository.</summary>
        public Repository(
            IRepository repository,
            IGitHubClient client)
            : base(repository, client)
        {
            Contract.Requires<ArgumentNullException>(repository != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._repository = repository;

            if (repository.Permissions != null)
            {
                this._permissions = new Permissions(repository.Permissions, client);
            }

            if (repository.Organization != null)
            {
                this._organization = new RepositoryUser(repository.Organization, client);
            }

            if (repository.Parent != null)
            {
                this._parent = new Repository(repository.Parent, client);
            }

            if (repository.Source != null)
            {
                this._source = new Repository(repository.Source, client);
            }
        }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt
        {
            get
            {
                return this._repository.CreatedAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt
        {
            get
            {
                return this._repository.UpdatedAt;
            }
        }

        /// <summary>Map to "pushed_at"</summary>
        public DateTime PushedAt
        {
            get
            {
                return this._repository.PushedAt;
            }
        }

        /// <summary>Map to "git_url"</summary>
        public Uri GitUri
        {
            get
            {
                return this._repository.GitUri;
            }
        }

        /// <summary>Map to "ssh_url"</summary>
        public String SshUri
        {
            get
            {
                return this._repository.SshUri;
            }
        }

        /// <summary>Map to "clone_uri"</summary>
        public Uri CloneUri
        {
            get
            {
                return this._repository.CloneUri;
            }
        }

        /// <summary>Map to "svn_url"</summary>
        public Uri SubversionUri
        {
            get
            {
                return this._repository.SubversionUri;
            }
        }

        /// <summary>Map to "homepage"</summary>
        public String Homepage
        {
            get
            {
                return this._repository.Homepage;
            }
        }

        /// <summary>Map to "size"</summary>
        public Int64 Size
        {
            get
            {
                return this._repository.Size;
            }
        }

        /// <summary>Map to "stargazers_count"</summary>
        public Int32 StargazersCount
        {
            get
            {
                return this._repository.StargazersCount;
            }
        }

        /// <summary>Map to "watchers_count"</summary>
        public Int32 WatchersCount
        {
            get
            {
                return this._repository.WatchersCount;
            }
        }

        /// <summary>Map to "language"</summary>
        public String Language
        {
            get
            {
                return this._repository.Language;
            }
        }

        /// <summary>Map to "has_issues"</summary>
        public Boolean HasIssues
        {
            get
            {
                return this._repository.HasIssues;
            }
        }

        /// <summary>Map to "has_downloads"</summary>
        public Boolean HasDownloads
        {
            get
            {
                return this._repository.HasDownloads;
            }
        }

        /// <summary>Map to "has_wiki"</summary>
        public Boolean HasWiki
        {
            get
            {
                return this._repository.HasWiki;
            }
        }

        /// <summary>Map to "has_pages"</summary>
        public Boolean HasPages
        {
            get
            {
                return this._repository.HasPages;
            }
        }

        /// <summary>Map to "forks_count"</summary>
        public Int32 ForksCount
        {
            get
            {
                return this._repository.ForksCount;
            }
        }

        /// <summary>Map to "mirror_url"</summary>
        public Uri MirrorUri
        {
            get
            {
                return this._repository.MirrorUri;
            }
        }

        /// <summary>Map to "open_issues_count"</summary>
        public Int32 OpenIssuesCount
        {
            get
            {
                return this._repository.OpenIssuesCount;
            }
        }

        /// <summary>Map to "forks"</summary>
        public Int32 Forks
        {
            get
            {
                return this._repository.Forks;
            }
        }

        /// <summary>Map to "open_issues"</summary>
        public Int32 OpenIssues
        {
            get
            {
                return this._repository.OpenIssues;
            }
        }

        /// <summary>Map to "watchers"</summary>
        public Int32 Watchers
        {
            get
            {
                return this._repository.Watchers;
            }
        }

        /// <summary>Map to "default_branch"</summary>
        public String DefaultBranch
        {
            get
            {
                return this._repository.DefaultBranch;
            }
        }

        /// <summary>Map to "permissions"</summary>
        public Permissions Permissions
        {
            get
            {
                return this._permissions;
            }
        }

        /// <summary>Map to "organization"</summary>
        public RepositoryUser Organization
        {
            get
            {
                return this._organization;
            }
        }

        /// <summary>Map to "parent"</summary>
        public Repository Parent
        {
            get
            {
                return this._parent;
            }
        }

        /// <summary>Map to "source"</summary>
        public Repository Source
        {
            get
            {
                return this._source;
            }
        }

        /// <summary>Map to "network_count"</summary>
        public Int32 NetworkCount
        {
            get
            {
                return this._repository.NetworkCount;
            }
        }

        /// <summary>Map to "subscribers_count"</summary>
        public Int32 SubscribersCount
        {
            get
            {
                return this._repository.SubscribersCount;
            }
        }

        /// <summary>Map to "permissions"</summary>
        IPermissions IRepository.Permissions
        {
            get
            {
                return this._repository.Permissions;
            }
        }

        /// <summary>Map to "organization"</summary>
        IRepositoryUser IRepository.Organization
        {
            get
            {
                return this._repository.Organization;
            }
        }

        /// <summary>Map to "parent"</summary>
        IRepository IRepository.Parent
        {
            get
            {
                return this._repository.Parent;
            }
        }

        /// <summary>Map to "source"</summary>
        IRepository IRepository.Source
        {
            get
            {
                return this._repository.Source;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repository != null);
        }
    }
}
