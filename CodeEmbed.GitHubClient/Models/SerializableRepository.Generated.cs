








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
		[ContractPublicPropertyName("CloneUri")]
		private readonly Uri _cloneUri;

		[ContractPublicPropertyName("GitUri")]
		private readonly Uri _gitUri;

		[ContractPublicPropertyName("SshUri")]
		private readonly Uri _sshUri;

		[ContractPublicPropertyName("SubversionUri")]
		private readonly Uri _subversionUri;

		[ContractPublicPropertyName("MirrorUri")]
		private readonly Uri _mirrorUri;

		[ContractPublicPropertyName("Homepage")]
		private readonly Uri _homepage;

		[ContractPublicPropertyName("Language")]
		private readonly String _language;

		[ContractPublicPropertyName("ForksCount")]
		private readonly Int32 _forksCount;

		[ContractPublicPropertyName("StargazersCount")]
		private readonly Int32 _stargazersCount;

		[ContractPublicPropertyName("WatchersCount")]
		private readonly Int32 _watchersCount;

		[ContractPublicPropertyName("Size")]
		private readonly Int64 _size;

		[ContractPublicPropertyName("DefaultBranch")]
		private readonly String _defaultBranch;

		[ContractPublicPropertyName("OpenIssuesCount")]
		private readonly Int32 _openIssuesCount;

		[ContractPublicPropertyName("HasIssues")]
		private readonly Boolean _hasIssues;

		[ContractPublicPropertyName("HasWiki")]
		private readonly Boolean _hasWiki;

		[ContractPublicPropertyName("HasPages")]
		private readonly Boolean _hasPages;

		[ContractPublicPropertyName("HasDownloads")]
		private readonly Boolean _hasDownloads;

		[ContractPublicPropertyName("PushedAt")]
		private readonly DateTime _pushedAt;

		[ContractPublicPropertyName("CreatedAt")]
		private readonly DateTime _createdAt;

		[ContractPublicPropertyName("UpdatedAt")]
		private readonly DateTime _updatedAt;

		[ContractPublicPropertyName("Permissions")]
		private readonly IPermissions _permissions;

		[ContractPublicPropertyName("SubscribersCount")]
		private readonly Int32 _subscribersCount;

		[ContractPublicPropertyName("Organization")]
		private readonly IRepositoryUser _organization;

		[ContractPublicPropertyName("Parent")]
		private readonly IRepository _parent;

		[ContractPublicPropertyName("Source")]
		private readonly IRepository _source;

		/// <summary>Create new instance of SerializableRepository.</summary>
		[JsonConstructor]
		public SerializableRepository(
			Int64 id,
			IRepositoryUser owner,
			String name,
			String fullName,
			String description,
			Boolean isPrivate,
			Boolean fork,
			Uri uri,
			Uri htmlUri,
			Uri cloneUri,
			Uri gitUri,
			Uri sshUri,
			Uri subversionUri,
			Uri mirrorUri,
			Uri homepage,
			String language,
			Int32 forksCount,
			Int32 stargazersCount,
			Int32 watchersCount,
			Int64 size,
			String defaultBranch,
			Int32 openIssuesCount,
			Boolean hasIssues,
			Boolean hasWiki,
			Boolean hasPages,
			Boolean hasDownloads,
			DateTime pushedAt,
			DateTime createdAt,
			DateTime updatedAt,
			IPermissions permissions,
			Int32 subscribersCount,
			IRepositoryUser organization,
			IRepository parent,
			IRepository source)
			: base(
				id,
				owner,
				name,
				fullName,
				description,
				isPrivate,
				fork,
				uri,
				htmlUri)
		{
			Contract.Requires<ArgumentNullException>(owner != null);
			Contract.Requires<ArgumentNullException>(name != null);
			Contract.Requires<ArgumentNullException>(defaultBranch != null);

			this._cloneUri = cloneUri;
			this._gitUri = gitUri;
			this._sshUri = sshUri;
			this._subversionUri = subversionUri;
			this._mirrorUri = mirrorUri;
			this._homepage = homepage;
			this._language = language;
			this._forksCount = forksCount;
			this._stargazersCount = stargazersCount;
			this._watchersCount = watchersCount;
			this._size = size;
			this._defaultBranch = defaultBranch;
			this._openIssuesCount = openIssuesCount;
			this._hasIssues = hasIssues;
			this._hasWiki = hasWiki;
			this._hasPages = hasPages;
			this._hasDownloads = hasDownloads;
			this._pushedAt = pushedAt;
			this._createdAt = createdAt;
			this._updatedAt = updatedAt;
			this._permissions = permissions;
			this._subscribersCount = subscribersCount;
			this._organization = organization;
			this._parent = parent;
			this._source = source;
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
		public Uri SshUri
		{
			get
			{
				return this._sshUri;
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

		/// <summary>Map to "mirror_url"</summary>
		[JsonProperty("mirror_url")]
		public Uri MirrorUri
		{
			get
			{
				return this._mirrorUri;
			}
		}

		/// <summary>Map to "homepage"</summary>
		[JsonProperty("homepage")]
		public Uri Homepage
		{
			get
			{
				return this._homepage;
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

		/// <summary>Map to "forks_count"</summary>
		[JsonProperty("forks_count")]
		public Int32 ForksCount
		{
			get
			{
				return this._forksCount;
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

		/// <summary>Map to "size"</summary>
		[JsonProperty("size")]
		public Int64 Size
		{
			get
			{
				return this._size;
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

		/// <summary>Map to "open_issues_count"</summary>
		[JsonProperty("open_issues_count")]
		public Int32 OpenIssuesCount
		{
			get
			{
				return this._openIssuesCount;
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

		/// <summary>Map to "has_downloads"</summary>
		[JsonProperty("has_downloads")]
		public Boolean HasDownloads
		{
			get
			{
				return this._hasDownloads;
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

		/// <summary>Map to "permissions"</summary>
		[JsonProperty("permissions")]
		public IPermissions Permissions
		{
			get
			{
				return this._permissions;
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
