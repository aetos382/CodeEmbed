namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class DetailedUser :
        RepositoryUser,
        IDetailedUser
    {
        private readonly IDetailedUser _detailedUser;

        public DetailedUser(IDetailedUser detailedUser)
            : base(detailedUser)
        {
            Contract.Requires<ArgumentNullException>(detailedUser != null);

            this._detailedUser = detailedUser;
        }

        public string Name
        {
            get
            {
                return this._detailedUser.Name;
            }
        }

        public string Company
        {
            get
            {
                return this._detailedUser.Company;
            }
        }

        public Uri Blog
        {
            get
            {
                return this._detailedUser.Blog;
            }
        }

        public string Location
        {
            get
            {
                return this._detailedUser.Location;
            }
        }

        public string EMail
        {
            get
            {
                return this._detailedUser.EMail;
            }
        }

        public bool Hireable
        {
            get
            {
                return this._detailedUser.Hireable;
            }
        }

        public string Bio
        {
            get
            {
                return this._detailedUser.Bio;
            }
        }

        public int PublicRepositories
        {
            get
            {
                return this._detailedUser.PublicRepositories;
            }
        }

        public int PublicGists
        {
            get
            {
                return this._detailedUser.PublicGists;
            }
        }

        public int Followers
        {
            get
            {
                return this._detailedUser.Followers;
            }
        }

        public int Following
        {
            get
            {
                return this._detailedUser.Following;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return this._detailedUser.CreatedAt;
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                return this._detailedUser.UpdatedAt;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._detailedUser != null);
        }
    }
}
