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
    public partial class CommitTree :
        ICommitTree
    {
        private readonly ICommitTree _commitTree = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of CommitTree.</summary>
        public CommitTree(
            ICommitTree commitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitTree != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._commitTree = commitTree;

            this._client = client;
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._commitTree.Uri;
            }
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._commitTree.Hash;
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
            Contract.Invariant(this._commitTree != null);

            Contract.Invariant(this._client != null);
        }
    }
}
