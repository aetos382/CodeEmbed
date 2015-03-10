








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    
    using Newtonsoft.Json;
    
	[GeneratedCode("SerializableClass.tt", "1.0")]
	[DebuggerStepThrough]
	[JsonObject]
	public abstract partial class SerializableGistBase :
		IGistBase
	{
		[ContractPublicPropertyName("Uri")]
		private readonly Uri _uri;

		[ContractPublicPropertyName("ForksUri")]
		private readonly Uri _forksUri;

		[ContractPublicPropertyName("CommitsUri")]
		private readonly Uri _commitsUri;

		[ContractPublicPropertyName("Id")]
		private readonly String _id;

		[ContractPublicPropertyName("Description")]
		private readonly String _description;

		[ContractPublicPropertyName("IsPublic")]
		private readonly Boolean _isPublic;

		[ContractPublicPropertyName("Owner")]
		private readonly IRepositoryUser _owner;

		[ContractPublicPropertyName("User")]
		private readonly String _user;

		[ContractPublicPropertyName("Comments")]
		private readonly Int32 _comments;

		[ContractPublicPropertyName("CommentsUri")]
		private readonly Uri _commentsUri;

		[ContractPublicPropertyName("HtmlUri")]
		private readonly Uri _htmlUri;

		[ContractPublicPropertyName("GitPullUri")]
		private readonly Uri _gitPullUri;

		[ContractPublicPropertyName("GitPushUri")]
		private readonly Uri _gitPushUri;

		[ContractPublicPropertyName("CreatedAt")]
		private readonly DateTime _createdAt;

		[ContractPublicPropertyName("UpdatedAt")]
		private readonly DateTime _updatedAt;

		/// <summary>Create new instance of SerializableGistBase.</summary>
		[JsonConstructor]
		protected SerializableGistBase(
			Uri uri,
			Uri forksUri,
			Uri commitsUri,
			String id,
			String description,
			Boolean isPublic,
			IRepositoryUser owner,
			String user,
			Int32 comments,
			Uri commentsUri,
			Uri htmlUri,
			Uri gitPullUri,
			Uri gitPushUri,
			DateTime createdAt,
			DateTime updatedAt)
		{

			this._uri = uri;
			this._forksUri = forksUri;
			this._commitsUri = commitsUri;
			this._id = id;
			this._description = description;
			this._isPublic = isPublic;
			this._owner = owner;
			this._user = user;
			this._comments = comments;
			this._commentsUri = commentsUri;
			this._htmlUri = htmlUri;
			this._gitPullUri = gitPullUri;
			this._gitPushUri = gitPushUri;
			this._createdAt = createdAt;
			this._updatedAt = updatedAt;
		}

		/// <summary>Map to "url"</summary>
		[JsonProperty("url")]
		public Uri Uri
		{
			get
			{
				return this._uri;
			}
		}

		/// <summary>Map to "forks_url"</summary>
		[JsonProperty("forks_url")]
		public Uri ForksUri
		{
			get
			{
				return this._forksUri;
			}
		}

		/// <summary>Map to "commits_url"</summary>
		[JsonProperty("commits_url")]
		public Uri CommitsUri
		{
			get
			{
				return this._commitsUri;
			}
		}

		/// <summary>Map to "id"</summary>
		[JsonProperty("id")]
		public String Id
		{
			get
			{
				return this._id;
			}
		}

		/// <summary>Map to "description"</summary>
		[JsonProperty("description")]
		public String Description
		{
			get
			{
				return this._description;
			}
		}

		/// <summary>Map to "public"</summary>
		[JsonProperty("public")]
		public Boolean IsPublic
		{
			get
			{
				return this._isPublic;
			}
		}

		/// <summary>Map to "owner"</summary>
		[JsonProperty("owner")]
		public IRepositoryUser Owner
		{
			get
			{
				return this._owner;
			}
		}

		/// <summary>Map to "user"</summary>
		[JsonProperty("user")]
		public String User
		{
			get
			{
				return this._user;
			}
		}

		/// <summary>Map to "comments"</summary>
		[JsonProperty("comments")]
		public Int32 Comments
		{
			get
			{
				return this._comments;
			}
		}

		/// <summary>Map to "comments_url"</summary>
		[JsonProperty("comments_url")]
		public Uri CommentsUri
		{
			get
			{
				return this._commentsUri;
			}
		}

		/// <summary>Map to "html_url"</summary>
		[JsonProperty("html_url")]
		public Uri HtmlUri
		{
			get
			{
				return this._htmlUri;
			}
		}

		/// <summary>Map to "git_pull_url"</summary>
		[JsonProperty("git_pull_url")]
		public Uri GitPullUri
		{
			get
			{
				return this._gitPullUri;
			}
		}

		/// <summary>Map to "git_push_url"</summary>
		[JsonProperty("git_push_url")]
		public Uri GitPushUri
		{
			get
			{
				return this._gitPushUri;
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
	}
}
