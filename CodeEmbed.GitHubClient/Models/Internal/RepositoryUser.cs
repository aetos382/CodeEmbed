namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    public class RepositoryUser :
        IRepositoryUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public RepositoryUser(IRepositoryUser repositoryUser)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);

            this._repositoryUser = repositoryUser;
        }

        public string Login
        {
            get
            {
                return this._repositoryUser.Login;
            }
        }

        public long Id
        {
            get
            {
                return this._repositoryUser.Id;
            }
        }

        public Uri AvatarUri
        {
            get
            {
                return this._repositoryUser.AvatarUri;
            }
        }

        public string GravatarId
        {
            get
            {
                return this._repositoryUser.GravatarId;
            }
        }

        public Uri Uri
        {
            get
            {
                return this._repositoryUser.Uri;
            }
        }

        public Uri HtmlUri
        {
            get
            {
                return this._repositoryUser.HtmlUri;
            }
        }

        public Uri FollowersUri
        {
            get
            {
                return this._repositoryUser.FollowersUri;
            }
        }

        public string FollowingUri
        {
            get
            {
                return this._repositoryUser.FollowingUri;
            }
        }

        public string GistsUri
        {
            get
            {
                return this._repositoryUser.GistsUri;
            }
        }

        public string StarredUri
        {
            get
            {
                return this._repositoryUser.StarredUri;
            }
        }

        public string SubscriptionsUri
        {
            get
            {
                return this._repositoryUser.SubscriptionsUri;
            }
        }

        public Uri OrganizationsUri
        {
            get
            {
                return this._repositoryUser.OrganizationsUri;
            }
        }

        public Uri RepositoriesUri
        {
            get
            {
                return this._repositoryUser.RepositoriesUri;
            }
        }

        public string EventsUri
        {
            get
            {
                return this._repositoryUser.EventsUri;
            }
        }

        public Uri ReceiedEventsUri
        {
            get
            {
                return this._repositoryUser.ReceiedEventsUri;
            }
        }

        public string Type
        {
            get
            {
                return this._repositoryUser.Type;
            }
        }

        public bool SiteAdmin
        {
            get
            {
                return this._repositoryUser.SiteAdmin;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repositoryUser != null);
        }
    }
}
