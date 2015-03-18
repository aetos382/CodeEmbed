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
    public partial class RepositoryUser :
        IRepositoryUser
    {
        private readonly IRepositoryUser _repositoryUser = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of RepositoryUser.</summary>
        public RepositoryUser(
            IRepositoryUser repositoryUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._repositoryUser = repositoryUser;

            this._client = client;
        }

        /// <summary>Map to "login"</summary>
        public String Login
        {
            get
            {
                return this._repositoryUser.Login;
            }
        }

        /// <summary>Map to "id"</summary>
        public Int64 Id
        {
            get
            {
                return this._repositoryUser.Id;
            }
        }

        /// <summary>Map to "avatar_url"</summary>
        public Uri AvatarUri
        {
            get
            {
                return this._repositoryUser.AvatarUri;
            }
        }

        /// <summary>Map to "gravatar_id"</summary>
        public String GravatarId
        {
            get
            {
                return this._repositoryUser.GravatarId;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._repositoryUser.Uri;
            }
        }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri
        {
            get
            {
                return this._repositoryUser.HtmlUri;
            }
        }

        /// <summary>Map to "followers_url"</summary>
        public Uri FollowersUri
        {
            get
            {
                return this._repositoryUser.FollowersUri;
            }
        }

        /// <summary>Map to "following_url"</summary>
        public String FollowingUri
        {
            get
            {
                return this._repositoryUser.FollowingUri;
            }
        }

        /// <summary>Map to "gists_url"</summary>
        public String GistsUri
        {
            get
            {
                return this._repositoryUser.GistsUri;
            }
        }

        /// <summary>Map to "starred_url"</summary>
        public String StarredUri
        {
            get
            {
                return this._repositoryUser.StarredUri;
            }
        }

        /// <summary>Map to "subscriptions_url"</summary>
        public Uri SubscriptionsUri
        {
            get
            {
                return this._repositoryUser.SubscriptionsUri;
            }
        }

        /// <summary>Map to "organizations_url"</summary>
        public Uri OrganizationsUri
        {
            get
            {
                return this._repositoryUser.OrganizationsUri;
            }
        }

        /// <summary>Map to "repos_url"</summary>
        public Uri RepositoriesUri
        {
            get
            {
                return this._repositoryUser.RepositoriesUri;
            }
        }

        /// <summary>Map to "events_url"</summary>
        public String EventsUri
        {
            get
            {
                return this._repositoryUser.EventsUri;
            }
        }

        /// <summary>Map to "received_events_url"</summary>
        public Uri ReceivedEventsUri
        {
            get
            {
                return this._repositoryUser.ReceivedEventsUri;
            }
        }

        /// <summary>Map to "type"</summary>
        public String Type
        {
            get
            {
                return this._repositoryUser.Type;
            }
        }

        /// <summary>Map to "site_admin"</summary>
        public Boolean SiteAdministrator
        {
            get
            {
                return this._repositoryUser.SiteAdministrator;
            }
        }

        public IGitHubClient Client
        {
            get
            {
                Contract.Ensures(Contract.Result<IGitHubClient>() != null);

                return this._client;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repositoryUser != null);
            Contract.Invariant(this._client != null);
        }
    }
}
