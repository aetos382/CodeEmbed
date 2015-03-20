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
    public partial class GitReference :
        IGitReference
    {
        private readonly IGitReference _gitReference = null;

        [ContractPublicPropertyName("Target")]
        private readonly GitObject _target = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitReference.</summary>
        public GitReference(
            IGitReference gitReference,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitReference != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitReference = gitReference;

            if (gitReference.Target != null)
            {
                this._target = new GitObject(gitReference.Target, client);
            }

            this._client = client;
        }

        /// <summary>Map to "ref"</summary>
        public String Reference
        {
            get
            {
                return this._gitReference.Reference;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitReference.Uri;
            }
        }

        /// <summary>Map to "object"</summary>
        public GitObject Target
        {
            get
            {
                return this._target;
            }
        }

        /// <summary>Map to "object"</summary>
        IGitObject IGitReference.Target
        {
            get
            {
                return this._gitReference.Target;
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
            Contract.Invariant(this._gitReference != null);
            Contract.Invariant(this._client != null);
        }
    }
}
