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
    public partial class Permissions :
        IPermissions
    {
        private readonly IPermissions _permissions = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of Permissions.</summary>
        public Permissions(
            IPermissions permissions,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(permissions != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._permissions = permissions;

            this._client = client;
        }

        /// <summary>Map to "admin"</summary>
        public Boolean Administration
        {
            get
            {
                return this._permissions.Administration;
            }
        }

        /// <summary>Map to "push"</summary>
        public Boolean Push
        {
            get
            {
                return this._permissions.Push;
            }
        }

        /// <summary>Map to "pull"</summary>
        public Boolean Pull
        {
            get
            {
                return this._permissions.Pull;
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
            Contract.Invariant(this._permissions != null);
            Contract.Invariant(this._client != null);
        }
    }
}
