








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    
	/// <summary>Contract class for IRepositoryUser.</summary>
	[GeneratedCode("ModelContract.tt", "1.0")]
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
	[ContractClassFor(typeof(IRepositoryUser))]
	public abstract partial class RepositoryUserContract :
		IRepositoryUser
	{
		/// <summary>Map to "login"</summary>
		public String Login
		{
			get
			{
				Contract.Ensures(Contract.Result<String>() != null);

				throw new NotImplementedException();
			}
		}
		
		/// <summary>Map to "id"</summary>
		public abstract Int64 Id { get; }
		
		/// <summary>Map to "avatar_url"</summary>
		public abstract Uri AvatarUri { get; }
		
		/// <summary>Map to "gravatar_id"</summary>
		public abstract String GravatarId { get; }
		
		/// <summary>Map to "url"</summary>
		public abstract Uri Uri { get; }
		
		/// <summary>Map to "html_url"</summary>
		public abstract Uri HtmlUri { get; }
		
		/// <summary>Map to "followers_url"</summary>
		public abstract Uri FollowersUri { get; }
		
		/// <summary>Map to "following_url"</summary>
		public abstract String FollowingUri { get; }
		
		/// <summary>Map to "gists_url"</summary>
		public abstract String GistsUri { get; }
		
		/// <summary>Map to "starred_url"</summary>
		public abstract String StarredUri { get; }
		
		/// <summary>Map to "subscriptions_url"</summary>
		public abstract Uri SubscriptionsUri { get; }
		
		/// <summary>Map to "organizations_url"</summary>
		public abstract Uri OrganizationsUri { get; }
		
		/// <summary>Map to "repos_url"</summary>
		public abstract Uri RepositoriesUri { get; }
		
		/// <summary>Map to "events_url"</summary>
		public abstract String EventUri { get; }
		
		/// <summary>Map to "received_events_url"</summary>
		public abstract Uri ReceivedEventsUri { get; }
		
		/// <summary>Map to "type"</summary>
		public abstract String Type { get; }
		
		/// <summary>Map to "site_admin"</summary>
		public abstract Boolean SiteAdministrator { get; }
		
	}
}
