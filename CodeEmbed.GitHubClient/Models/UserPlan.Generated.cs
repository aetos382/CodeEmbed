








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
    public partial class UserPlan :
        IUserPlan
    {
        private readonly IUserPlan _userPlan = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of UserPlan.</summary>
        public UserPlan(
            IUserPlan userPlan,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(userPlan != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._userPlan = userPlan;

            this._client = client;
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                return this._userPlan.Name;
            }
        }

        /// <summary>Map to "space"</summary>
        public Int64 Space
        {
            get
            {
                return this._userPlan.Space;
            }
        }

        /// <summary>Map to "private_repos"</summary>
        public Int32 PrivateRepositories
        {
            get
            {
                return this._userPlan.PrivateRepositories;
            }
        }

        /// <summary>Map to "collaborators"</summary>
        public Int32 Collaborators
        {
            get
            {
                return this._userPlan.Collaborators;
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
            Contract.Invariant(this._userPlan != null);

            Contract.Invariant(this._client != null);
        }
    }
}
