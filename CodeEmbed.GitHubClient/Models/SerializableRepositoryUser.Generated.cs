








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
	public partial class SerializableRepositoryUser :
		IRepositoryUser
	{
		[ContractPublicPropertyName("Login")]
		private readonly String _login;

		[ContractPublicPropertyName("Id")]
		private readonly Int64 _id;

		[ContractPublicPropertyName("AvatarUri")]
		private readonly Uri _avatarUri;

		[ContractPublicPropertyName("GravatarId")]
		private readonly String _gravatarId;

		[ContractPublicPropertyName("Uri")]
		private readonly Uri _uri;

		[ContractPublicPropertyName("HtmlUri")]
		private readonly Uri _htmlUri;

		[ContractPublicPropertyName("FollowersUri")]
		private readonly Uri _followersUri;

		[ContractPublicPropertyName("FollowingUri")]
		private readonly String _followingUri;

		[ContractPublicPropertyName("GistsUri")]
		private readonly String _gistsUri;

		[ContractPublicPropertyName("StarredUri")]
		private readonly String _starredUri;

		[ContractPublicPropertyName("SubscriptionsUri")]
		private readonly Uri _subscriptionsUri;

		[ContractPublicPropertyName("OrganizationsUri")]
		private readonly Uri _organizationsUri;

		[ContractPublicPropertyName("RepositoriesUri")]
		private readonly Uri _repositoriesUri;

		[ContractPublicPropertyName("EventUri")]
		private readonly String _eventUri;

		[ContractPublicPropertyName("ReceivedEventsUri")]
		private readonly Uri _receivedEventsUri;

		[ContractPublicPropertyName("Type")]
		private readonly String _type;

		[ContractPublicPropertyName("SiteAdministrator")]
		private readonly Boolean _siteAdministrator;

		/// <summary>Create new instance of SerializableRepositoryUser.</summary>
		[JsonConstructor]
		public SerializableRepositoryUser(
			String login,
			Int64 id,
			Uri avatarUri,
			String gravatarId,
			Uri uri,
			Uri htmlUri,
			Uri followersUri,
			String followingUri,
			String gistsUri,
			String starredUri,
			Uri subscriptionsUri,
			Uri organizationsUri,
			Uri repositoriesUri,
			String eventUri,
			Uri receivedEventsUri,
			String type,
			Boolean siteAdministrator)
		{
			Contract.Requires<ArgumentNullException>(login != null);

			this._login = login;
			this._id = id;
			this._avatarUri = avatarUri;
			this._gravatarId = gravatarId;
			this._uri = uri;
			this._htmlUri = htmlUri;
			this._followersUri = followersUri;
			this._followingUri = followingUri;
			this._gistsUri = gistsUri;
			this._starredUri = starredUri;
			this._subscriptionsUri = subscriptionsUri;
			this._organizationsUri = organizationsUri;
			this._repositoriesUri = repositoriesUri;
			this._eventUri = eventUri;
			this._receivedEventsUri = receivedEventsUri;
			this._type = type;
			this._siteAdministrator = siteAdministrator;
		}

		/// <summary>Map to "login"</summary>
		[JsonProperty("login")]
		public String Login
		{
			get
			{
				return this._login;
			}
		}

		/// <summary>Map to "id"</summary>
		[JsonProperty("id")]
		public Int64 Id
		{
			get
			{
				return this._id;
			}
		}

		/// <summary>Map to "avatar_url"</summary>
		[JsonProperty("avatar_url")]
		public Uri AvatarUri
		{
			get
			{
				return this._avatarUri;
			}
		}

		/// <summary>Map to "gravatar_id"</summary>
		[JsonProperty("gravatar_id")]
		public String GravatarId
		{
			get
			{
				return this._gravatarId;
			}
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

		/// <summary>Map to "html_url"</summary>
		[JsonProperty("html_url")]
		public Uri HtmlUri
		{
			get
			{
				return this._htmlUri;
			}
		}

		/// <summary>Map to "followers_url"</summary>
		[JsonProperty("followers_url")]
		public Uri FollowersUri
		{
			get
			{
				return this._followersUri;
			}
		}

		/// <summary>Map to "following_url"</summary>
		[JsonProperty("following_url")]
		public String FollowingUri
		{
			get
			{
				return this._followingUri;
			}
		}

		/// <summary>Map to "gists_url"</summary>
		[JsonProperty("gists_url")]
		public String GistsUri
		{
			get
			{
				return this._gistsUri;
			}
		}

		/// <summary>Map to "starred_url"</summary>
		[JsonProperty("starred_url")]
		public String StarredUri
		{
			get
			{
				return this._starredUri;
			}
		}

		/// <summary>Map to "subscriptions_url"</summary>
		[JsonProperty("subscriptions_url")]
		public Uri SubscriptionsUri
		{
			get
			{
				return this._subscriptionsUri;
			}
		}

		/// <summary>Map to "organizations_url"</summary>
		[JsonProperty("organizations_url")]
		public Uri OrganizationsUri
		{
			get
			{
				return this._organizationsUri;
			}
		}

		/// <summary>Map to "repos_url"</summary>
		[JsonProperty("repos_url")]
		public Uri RepositoriesUri
		{
			get
			{
				return this._repositoriesUri;
			}
		}

		/// <summary>Map to "events_url"</summary>
		[JsonProperty("events_url")]
		public String EventUri
		{
			get
			{
				return this._eventUri;
			}
		}

		/// <summary>Map to "received_events_url"</summary>
		[JsonProperty("received_events_url")]
		public Uri ReceivedEventsUri
		{
			get
			{
				return this._receivedEventsUri;
			}
		}

		/// <summary>Map to "type"</summary>
		[JsonProperty("type")]
		public String Type
		{
			get
			{
				return this._type;
			}
		}

		/// <summary>Map to "site_admin"</summary>
		[JsonProperty("site_admin")]
		public Boolean SiteAdministrator
		{
			get
			{
				return this._siteAdministrator;
			}
		}

		/// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
			Contract.Invariant(this._login != null);
        }
	}
}
