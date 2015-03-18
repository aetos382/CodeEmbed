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
    public partial class GitObject :
        IGitObject
    {
        private readonly IGitObject _gitObject = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitObject.</summary>
        public GitObject(
            IGitObject gitObject,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitObject != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitObject = gitObject;

            this._client = client;
        }

        /// <summary>Map to "type"</summary>
        public String ObjectType
        {
            get
            {
                return this._gitObject.ObjectType;
            }
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitObject.Hash;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitObject.Uri;
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
            Contract.Invariant(this._gitObject != null);
            Contract.Invariant(this._client != null);
        }
    }
}
