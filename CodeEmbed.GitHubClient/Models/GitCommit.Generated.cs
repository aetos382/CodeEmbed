namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GitCommit :
        IGitCommit
    {
        private readonly IGitCommit _gitCommit = null;

        [ContractPublicPropertyName("Author")]
        private readonly Signature _author = null;

        [ContractPublicPropertyName("Committer")]
        private readonly Signature _committer = null;

        [ContractPublicPropertyName("Tree")]
        private readonly CommitLink _tree = null;

        [ContractPublicPropertyName("Parents")]
        private readonly IEnumerable<CommitLink> _parents = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitCommit.</summary>
        public GitCommit(
            IGitCommit gitCommit,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitCommit != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitCommit = gitCommit;

            if (gitCommit.Author != null)
            {
                this._author = new Signature(gitCommit.Author, client);
            }

            if (gitCommit.Committer != null)
            {
                this._committer = new Signature(gitCommit.Committer, client);
            }

            if (gitCommit.Tree != null)
            {
                this._tree = new CommitLink(gitCommit.Tree, client);
            }

            if (gitCommit.Parents != null)
            {
                this._parents = gitCommit.Parents.Select(x => new CommitLink(x, client));
            }

            this._client = client;
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitCommit.Hash;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitCommit.Uri;
            }
        }

        /// <summary>Map to "author"</summary>
        public Signature Author
        {
            get
            {
                return this._author;
            }
        }

        /// <summary>Map to "committer"</summary>
        public Signature Committer
        {
            get
            {
                return this._committer;
            }
        }

        /// <summary>Map to "message"</summary>
        public String Message
        {
            get
            {
                return this._gitCommit.Message;
            }
        }

        /// <summary>Map to "tree"</summary>
        public CommitLink Tree
        {
            get
            {
                return this._tree;
            }
        }

        /// <summary>Map to "parents"</summary>
        public IEnumerable<CommitLink> Parents
        {
            get
            {
                return this._parents;
            }
        }

        /// <summary>Map to "author"</summary>
        ISignature IGitCommit.Author
        {
            get
            {
                return this._gitCommit.Author;
            }
        }

        /// <summary>Map to "committer"</summary>
        ISignature IGitCommit.Committer
        {
            get
            {
                return this._gitCommit.Committer;
            }
        }

        /// <summary>Map to "tree"</summary>
        ICommitLink IGitCommit.Tree
        {
            get
            {
                return this._gitCommit.Tree;
            }
        }

        /// <summary>Map to "parents"</summary>
        IEnumerable<ICommitLink> IGitCommit.Parents
        {
            get
            {
                return this._gitCommit.Parents;
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
            Contract.Invariant(this._gitCommit != null);
            Contract.Invariant(this._client != null);
        }
    }
}
