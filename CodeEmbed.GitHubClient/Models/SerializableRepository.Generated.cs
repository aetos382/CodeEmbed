namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableRepository :
        SerializablePublicRepository,
        IRepository
    {
        [ContractPublicPropertyName("CreatedAt")]
        private readonly DateTime _createdAt;

        [ContractPublicPropertyName("UpdatedAt")]
        private readonly DateTime _updatedAt;

        [ContractPublicPropertyName("PushedAt")]
        private readonly DateTime _pushedAt;

        [ContractPublicPropertyName("GitUri")]
        private readonly Uri _gitUri;

        [ContractPublicPropertyName("SshUri")]
        private readonly String _sshUri;

        [ContractPublicPropertyName("CloneUri")]
        private readonly Uri _cloneUri;

        [ContractPublicPropertyName("SubversionUri")]
        private readonly Uri _subversionUri;

        [ContractPublicPropertyName("Homepage")]
        private readonly String _homepage;

        [ContractPublicPropertyName("Size")]
        private readonly Int64 _size;

        [ContractPublicPropertyName("StargazersCount")]
        private readonly Int32 _stargazersCount;

        [ContractPublicPropertyName("WatchersCount")]
        private readonly Int32 _watchersCount;

        [ContractPublicPropertyName("Language")]
        private readonly String _language;

        [ContractPublicPropertyName("HasIssues")]
        private readonly Boolean _hasIssues;

        [ContractPublicPropertyName("HasDownloads")]
        private readonly Boolean _hasDownloads;

        [ContractPublicPropertyName("HasWiki")]
        private readonly Boolean _hasWiki;

        [ContractPublicPropertyName("HasPages")]
        private readonly Boolean _hasPages;

        [ContractPublicPropertyName("ForksCount")]
        private readonly Int32 _forksCount;

        [ContractPublicPropertyName("MirrorUri")]
        private readonly Uri _mirrorUri;

        [ContractPublicPropertyName("OpenIssuesCount")]
        private readonly Int32 _openIssuesCount;

        [ContractPublicPropertyName("Forks")]
        private readonly Int32 _forks;

        [ContractPublicPropertyName("OpenIssues")]
        private readonly Int32 _openIssues;

        [ContractPublicPropertyName("Watchers")]
        private readonly Int32 _watchers;

        [ContractPublicPropertyName("DefaultBranch")]
        private readonly String _defaultBranch;

        [ContractPublicPropertyName("Permissions")]
        private readonly IPermissions _permissions;

        [ContractPublicPropertyName("Organization")]
        private readonly IRepositoryUser _organization;

        [ContractPublicPropertyName("Parent")]
        private readonly IRepository _parent;

        [ContractPublicPropertyName("Source")]
        private readonly IRepository _source;

        [ContractPublicPropertyName("NetworkCount")]
        private readonly Int32 _networkCount;

        [ContractPublicPropertyName("SubscribersCount")]
        private readonly Int32 _subscribersCount;

        /// <summary>Create new instance of SerializableRepository.</summary>
        [JsonConstructor]
        public SerializableRepository(
			Int64 id,
			String name,
			String fullName,
			IRepositoryUser owner,
			Boolean isPrivate,
			Uri htmlUri,
			String description,
			Boolean fork,
			Uri uri,
			Uri forksUri,
			String keysUri,
			String collaboratorsUri,
			Uri teamsUri,
			Uri hooksUri,
			String issueEventsUri,
			Uri eventsUri,
			String assigneesUri,
			String branchesUri,
			Uri tagsUri,
			String blobsUri,
			String gitTagsUri,
			String gitReferenesUri,
			String treesUri,
			String statusesUri,
			Uri languagesUri,
			Uri stargazersUri,
			Uri contributorsUri,
			Uri subscribersUri,
			Uri subscriptionUri,
			String commitsUri,
			String gitCommitsUri,
			string commentsUri,
			String issueCommentUri,
			String contentsUri,
			String compareUri,
			Uri mergesUri,
			String archiveUri,
			Uri downloadsUri,
			String issuesUri,
			String pullsUri,
			String milestonesUri,
			String notificationsUri,
			String labelsUri,
			String releasesUri,
			DateTime createdAt,
			DateTime updatedAt,
			DateTime pushedAt,
			Uri gitUri,
			String sshUri,
			Uri cloneUri,
			Uri subversionUri,
			String homepage,
			Int64 size,
			Int32 stargazersCount,
			Int32 watchersCount,
			String language,
			Boolean hasIssues,
			Boolean hasDownloads,
			Boolean hasWiki,
			Boolean hasPages,
			Int32 forksCount,
			Uri mirrorUri,
			Int32 openIssuesCount,
			Int32 forks,
			Int32 openIssues,
			Int32 watchers,
			String defaultBranch,
			IPermissions permissions,
			IRepositoryUser organization,
			IRepository parent,
			IRepository source,
			Int32 networkCount,
			Int32 subscribersCount)
            : base(
				id,
				name,
				fullName,
				owner,
				isPrivate,
				htmlUri,
				description,
				fork,
				uri,
				forksUri,
				keysUri,
				collaboratorsUri,
				teamsUri,
				hooksUri,
				issueEventsUri,
				eventsUri,
				assigneesUri,
				branchesUri,
				tagsUri,
				blobsUri,
				gitTagsUri,
				gitReferenesUri,
				treesUri,
				statusesUri,
				languagesUri,
				stargazersUri,
				contributorsUri,
				subscribersUri,
				subscriptionUri,
				commitsUri,
				gitCommitsUri,
				commentsUri,
				issueCommentUri,
				contentsUri,
				compareUri,
				mergesUri,
				archiveUri,
				downloadsUri,
				issuesUri,
				pullsUri,
				milestonesUri,
				notificationsUri,
				labelsUri,
				releasesUri)
        {
            Contract.Requires<ArgumentNullException>(name != null);
            Contract.Requires<ArgumentNullException>(owner != null);
            Contract.Requires<ArgumentNullException>(defaultBranch != null);

            this._createdAt = createdAt;
            this._updatedAt = updatedAt;
            this._pushedAt = pushedAt;
            this._gitUri = gitUri;
            this._sshUri = sshUri;
            this._cloneUri = cloneUri;
            this._subversionUri = subversionUri;
            this._homepage = homepage;
            this._size = size;
            this._stargazersCount = stargazersCount;
            this._watchersCount = watchersCount;
            this._language = language;
            this._hasIssues = hasIssues;
            this._hasDownloads = hasDownloads;
            this._hasWiki = hasWiki;
            this._hasPages = hasPages;
            this._forksCount = forksCount;
            this._mirrorUri = mirrorUri;
            this._openIssuesCount = openIssuesCount;
            this._forks = forks;
            this._openIssues = openIssues;
            this._watchers = watchers;
            this._defaultBranch = defaultBranch;
            this._permissions = permissions;
            this._organization = organization;
            this._parent = parent;
            this._source = source;
            this._networkCount = networkCount;
            this._subscribersCount = subscribersCount;
        }

        /// <summary>Map to "created_at"</summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get
            {
                return this._createdAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt
        {
            get
            {
                return this._updatedAt;
            }
        }

        /// <summary>Map to "pushed_at"</summary>
        [JsonProperty("pushed_at")]
        public DateTime PushedAt
        {
            get
            {
                return this._pushedAt;
            }
        }

        /// <summary>Map to "git_url"</summary>
        [JsonProperty("git_url")]
        public Uri GitUri
        {
            get
            {
                return this._gitUri;
            }
        }

        /// <summary>Map to "ssh_url"</summary>
        [JsonProperty("ssh_url")]
        public String SshUri
        {
            get
            {
                return this._sshUri;
            }
        }

        /// <summary>Map to "clone_uri"</summary>
        [JsonProperty("clone_uri")]
        public Uri CloneUri
        {
            get
            {
                return this._cloneUri;
            }
        }

        /// <summary>Map to "svn_url"</summary>
        [JsonProperty("svn_url")]
        public Uri SubversionUri
        {
            get
            {
                return this._subversionUri;
            }
        }

        /// <summary>Map to "homepage"</summary>
        [JsonProperty("homepage")]
        public String Homepage
        {
            get
            {
                return this._homepage;
            }
        }

        /// <summary>Map to "size"</summary>
        [JsonProperty("size")]
        public Int64 Size
        {
            get
            {
                return this._size;
            }
        }

        /// <summary>Map to "stargazers_count"</summary>
        [JsonProperty("stargazers_count")]
        public Int32 StargazersCount
        {
            get
            {
                return this._stargazersCount;
            }
        }

        /// <summary>Map to "watchers_count"</summary>
        [JsonProperty("watchers_count")]
        public Int32 WatchersCount
        {
            get
            {
                return this._watchersCount;
            }
        }

        /// <summary>Map to "language"</summary>
        [JsonProperty("language")]
        public String Language
        {
            get
            {
                return this._language;
            }
        }

        /// <summary>Map to "has_issues"</summary>
        [JsonProperty("has_issues")]
        public Boolean HasIssues
        {
            get
            {
                return this._hasIssues;
            }
        }

        /// <summary>Map to "has_downloads"</summary>
        [JsonProperty("has_downloads")]
        public Boolean HasDownloads
        {
            get
            {
                return this._hasDownloads;
            }
        }

        /// <summary>Map to "has_wiki"</summary>
        [JsonProperty("has_wiki")]
        public Boolean HasWiki
        {
            get
            {
                return this._hasWiki;
            }
        }

        /// <summary>Map to "has_pages"</summary>
        [JsonProperty("has_pages")]
        public Boolean HasPages
        {
            get
            {
                return this._hasPages;
            }
        }

        /// <summary>Map to "forks_count"</summary>
        [JsonProperty("forks_count")]
        public Int32 ForksCount
        {
            get
            {
                return this._forksCount;
            }
        }

        /// <summary>Map to "mirror_url"</summary>
        [JsonProperty("mirror_url")]
        public Uri MirrorUri
        {
            get
            {
                return this._mirrorUri;
            }
        }

        /// <summary>Map to "open_issues_count"</summary>
        [JsonProperty("open_issues_count")]
        public Int32 OpenIssuesCount
        {
            get
            {
                return this._openIssuesCount;
            }
        }

        /// <summary>Map to "forks"</summary>
        [JsonProperty("forks")]
        public Int32 Forks
        {
            get
            {
                return this._forks;
            }
        }

        /// <summary>Map to "open_issues"</summary>
        [JsonProperty("open_issues")]
        public Int32 OpenIssues
        {
            get
            {
                return this._openIssues;
            }
        }

        /// <summary>Map to "watchers"</summary>
        [JsonProperty("watchers")]
        public Int32 Watchers
        {
            get
            {
                return this._watchers;
            }
        }

        /// <summary>Map to "default_branch"</summary>
        [JsonProperty("default_branch")]
        public String DefaultBranch
        {
            get
            {
                return this._defaultBranch;
            }
        }

        /// <summary>Map to "permissions"</summary>
        [JsonProperty("permissions")]
        public IPermissions Permissions
        {
            get
            {
                return this._permissions;
            }
        }

        /// <summary>Map to "organization"</summary>
        [JsonProperty("organization")]
        public IRepositoryUser Organization
        {
            get
            {
                return this._organization;
            }
        }

        /// <summary>Map to "parent"</summary>
        [JsonProperty("parent")]
        public IRepository Parent
        {
            get
            {
                return this._parent;
            }
        }

        /// <summary>Map to "source"</summary>
        [JsonProperty("source")]
        public IRepository Source
        {
            get
            {
                return this._source;
            }
        }

        /// <summary>Map to "network_count"</summary>
        [JsonProperty("network_count")]
        public Int32 NetworkCount
        {
            get
            {
                return this._networkCount;
            }
        }

        /// <summary>Map to "subscribers_count"</summary>
        [JsonProperty("subscribers_count")]
        public Int32 SubscribersCount
        {
            get
            {
                return this._subscribersCount;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._defaultBranch != null);
        }
    }
}
