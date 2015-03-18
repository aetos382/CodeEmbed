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
    public partial class CommitSignature :
        ICommitSignature
    {
        private readonly ICommitSignature _commitSignature = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of CommitSignature.</summary>
        public CommitSignature(
            ICommitSignature commitSignature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitSignature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._commitSignature = commitSignature;

            this._client = client;
        }

        /// <summary>Map to "date"</summary>
        public DateTime Date
        {
            get
            {
                return this._commitSignature.Date;
            }
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                return this._commitSignature.Name;
            }
        }

        /// <summary>Map to "email"</summary>
        public String Email
        {
            get
            {
                return this._commitSignature.Email;
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
            Contract.Invariant(this._commitSignature != null);
            Contract.Invariant(this._client != null);
        }
    }
}
