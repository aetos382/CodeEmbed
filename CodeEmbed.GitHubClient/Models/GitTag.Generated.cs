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
    public partial class GitTag :
        IGitTag
    {
        private readonly IGitTag _gitTag = null;

        [ContractPublicPropertyName("Tagger")]
        private readonly Signature _tagger = null;

        [ContractPublicPropertyName("Target")]
        private readonly GitObject _target = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitTag.</summary>
        public GitTag(
            IGitTag gitTag,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTag != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitTag = gitTag;

            if (gitTag.Tagger != null)
            {
                this._tagger = new Signature(gitTag.Tagger, client);
            }

            if (gitTag.Target != null)
            {
                this._target = new GitObject(gitTag.Target, client);
            }

            this._client = client;
        }

        /// <summary>Map to "tag"</summary>
        public String Tag
        {
            get
            {
                return this._gitTag.Tag;
            }
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitTag.Hash;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitTag.Uri;
            }
        }

        /// <summary>Map to "message"</summary>
        public String Message
        {
            get
            {
                return this._gitTag.Message;
            }
        }

        /// <summary>Map to "tagger"</summary>
        public Signature Tagger
        {
            get
            {
                return this._tagger;
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

        /// <summary>Map to "tagger"</summary>
        ISignature IGitTag.Tagger
        {
            get
            {
                return this._gitTag.Tagger;
            }
        }

        /// <summary>Map to "object"</summary>
        IGitObject IGitTag.Target
        {
            get
            {
                return this._gitTag.Target;
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
            Contract.Invariant(this._gitTag != null);
            Contract.Invariant(this._client != null);
        }
    }
}
