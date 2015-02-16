namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    public class UserPlan :
        IUserPlan
    {
        private readonly IUserPlan _userPlan;

        public UserPlan(IUserPlan userPlan)
        {
            Contract.Requires<ArgumentNullException>(userPlan != null);

            this._userPlan = userPlan;
        }

        public string Name
        {
            get
            {
                return this._userPlan.Name;
            }
        }

        public long Space
        {
            get
            {
                return this._userPlan.Space;
            }
        }

        public int PrivateRepositories
        {
            get
            {
                return this._userPlan.PrivateRepositories;
            }
        }

        public int Collaborators
        {
            get
            {
                return this._userPlan.Collaborators;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._userPlan != null);
        }
    }
}
