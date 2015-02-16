namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class AuthenticatedUser :
        DetailedUser,
        IAuthenticatedUser
    {
        private readonly IAuthenticatedUser _authenticatedUser;

        public AuthenticatedUser(IAuthenticatedUser authenticatedUser)
            : base(authenticatedUser)
        {
            Contract.Requires<ArgumentNullException>(authenticatedUser != null);

            this._authenticatedUser = authenticatedUser;
        }

        public int TotalPrivateRepositories
        {
            get
            {
                return this._authenticatedUser.TotalPrivateRepositories;
            }
        }

        public int OwnedPrivateRepositories
        {
            get
            {
                return this._authenticatedUser.OwnedPrivateRepositories;
            }
        }

        public int PrivateGists
        {
            get
            {
                return this._authenticatedUser.PrivateGists;
            }
        }

        public long DiskUsage
        {
            get
            {
                return this._authenticatedUser.DiskUsage;
            }
        }

        public int Collaborators
        {
            get
            {
                return this._authenticatedUser.Collaborators;
            }
        }

        public IUserPlan Plan
        {
            get
            {
                return this._authenticatedUser.Plan;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._authenticatedUser != null);
        }
    }
}
