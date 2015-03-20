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
    public partial class GistChangeStatus :
        IGistChangeStatus
    {
        private readonly IGistChangeStatus _gistChangeStatus = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GistChangeStatus.</summary>
        public GistChangeStatus(
            IGistChangeStatus gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gistChangeStatus = gistChangeStatus;

            this._client = client;
        }

        /// <summary>Map to "deletions"</summary>
        public Int32 Deletions
        {
            get
            {
                return this._gistChangeStatus.Deletions;
            }
        }

        /// <summary>Map to "additions"</summary>
        public Int32 Additions
        {
            get
            {
                return this._gistChangeStatus.Additions;
            }
        }

        /// <summary>Map to "total"</summary>
        public Int32 Total
        {
            get
            {
                return this._gistChangeStatus.Total;
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
            Contract.Invariant(this._gistChangeStatus != null);
            Contract.Invariant(this._client != null);
        }
    }
}
