








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
    public partial class User :
        RepositoryUser,
        IUser
    {
        private readonly IUser _user = null;

        /// <summary>Create new instance of User.</summary>
        public User(
            IUser user,
            IGitHubClient client)
            : base(user, client)
        {
            Contract.Requires<ArgumentNullException>(user != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._user = user;
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                return this._user.Name;
            }
        }

        /// <summary>Map to "company"</summary>
        public String Company
        {
            get
            {
                return this._user.Company;
            }
        }

        /// <summary>Map to "blog"</summary>
        public Uri Blog
        {
            get
            {
                return this._user.Blog;
            }
        }

        /// <summary>Map to "location"</summary>
        public String Location
        {
            get
            {
                return this._user.Location;
            }
        }

        /// <summary>Map to "email"</summary>
        public String Email
        {
            get
            {
                return this._user.Email;
            }
        }

        /// <summary>Map to "hireable"</summary>
        public Boolean Hireable
        {
            get
            {
                return this._user.Hireable;
            }
        }

        /// <summary>Map to "bio"</summary>
        public String Bio
        {
            get
            {
                return this._user.Bio;
            }
        }

        /// <summary>Map to "public_repos"</summary>
        public Int32 PublicRepositories
        {
            get
            {
                return this._user.PublicRepositories;
            }
        }

        /// <summary>Map to "public_gists"</summary>
        public Int32 PublicGists
        {
            get
            {
                return this._user.PublicGists;
            }
        }

        /// <summary>Map to "followers"</summary>
        public Int32 Followers
        {
            get
            {
                return this._user.Followers;
            }
        }

        /// <summary>Map to "following"</summary>
        public Int32 Following
        {
            get
            {
                return this._user.Following;
            }
        }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt
        {
            get
            {
                return this._user.CreatedAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt
        {
            get
            {
                return this._user.UpdatedAt;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._user != null);
        }
    }
}
