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
    public partial class GitBlob :
        IGitBlob
    {
        private readonly IGitBlob _gitBlob = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitBlob.</summary>
        public GitBlob(
            IGitBlob gitBlob,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitBlob != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitBlob = gitBlob;

            this._client = client;
        }

        /// <summary>Map to "content"</summary>
        public String Content
        {
            get
            {
                return this._gitBlob.Content;
            }
        }

        /// <summary>Map to "encoding"</summary>
        public String Encoding
        {
            get
            {
                return this._gitBlob.Encoding;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitBlob.Uri;
            }
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitBlob.Hash;
            }
        }

        /// <summary>Map to "size"</summary>
        public Int64 Size
        {
            get
            {
                return this._gitBlob.Size;
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
            Contract.Invariant(this._gitBlob != null);
            Contract.Invariant(this._client != null);
        }
    }
}
