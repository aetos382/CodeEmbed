








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
    public partial class AuthorizedUser :
        User,
        IAuthorizedUser
    {
        private readonly IAuthorizedUser _authorizedUser = null;

		[ContractPublicPropertyName("Plan")]
		private readonly UserPlan _plan = null;

        /// <summary>Create new instance of AuthorizedUser.</summary>
        public AuthorizedUser(
            IAuthorizedUser authorizedUser,
            IGitHubClient client)
            : base(authorizedUser, client)
        {
            Contract.Requires<ArgumentNullException>(authorizedUser != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._authorizedUser = authorizedUser;

			if (authorizedUser.Plan != null)
			{
			    this._plan = new UserPlan(authorizedUser.Plan, client);
			}
        }

        /// <summary>Map to "total_private_repos"</summary>
        public Int32 TotalPrivateRepositories
        {
            get
            {
                return this._authorizedUser.TotalPrivateRepositories;
            }
        }

        /// <summary>Map to "owned_private_repos"</summary>
        public Int32 OwnedPrivateRepositories
        {
            get
            {
                return this._authorizedUser.OwnedPrivateRepositories;
            }
        }

        /// <summary>Map to "private_gists"</summary>
        public Int32 PrivateGists
        {
            get
            {
                return this._authorizedUser.PrivateGists;
            }
        }

        /// <summary>Map to "disk_usage"</summary>
        public Int64 DiskUsage
        {
            get
            {
                return this._authorizedUser.DiskUsage;
            }
        }

        /// <summary>Map to "collaborators"</summary>
        public Int32 Collaborators
        {
            get
            {
                return this._authorizedUser.Collaborators;
            }
        }

        /// <summary>Map to "plan"</summary>
        public UserPlan Plan
        {
            get
            {
				return this._plan;
            }
        }

        /// <summary>Map to "plan"</summary>
        IUserPlan IAuthorizedUser.Plan
        {
            get
            {
                return this._authorizedUser.Plan;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._authorizedUser != null);
        }
    }
}
