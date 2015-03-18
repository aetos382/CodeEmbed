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
    public partial class CommitLink :
        ICommitLink
    {
        private readonly ICommitLink _commitLink = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of CommitLink.</summary>
        public CommitLink(
            ICommitLink commitLink,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitLink != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._commitLink = commitLink;

            this._client = client;
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._commitLink.Hash;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._commitLink.Uri;
            }
        }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri
        {
            get
            {
                return this._commitLink.HtmlUri;
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
            Contract.Invariant(this._commitLink != null);
            Contract.Invariant(this._client != null);
        }
    }
}
