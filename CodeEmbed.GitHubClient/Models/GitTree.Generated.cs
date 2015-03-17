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
    public partial class GitTree :
        IGitTree
    {
        private readonly IGitTree _gitTree = null;

        [ContractPublicPropertyName("Tree")]
        private readonly IEnumerable<GitTreeNode> _tree = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitTree.</summary>
        public GitTree(
            IGitTree gitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTree != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._gitTree = gitTree;

            if (gitTree.Tree != null)
            {
                this._tree = gitTree.Tree.Select(x => new GitTreeNode(x, client));
            }

            this._client = client;
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitTree.Hash;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitTree.Uri;
            }
        }

        /// <summary>Map to "tree"</summary>
        public IEnumerable<GitTreeNode> Tree
        {
            get
            {
                return this._tree;
            }
        }

        /// <summary>Map to "truncated"</summary>
        public Boolean Truncated
        {
            get
            {
                return this._gitTree.Truncated;
            }
        }

        /// <summary>Map to "tree"</summary>
        IEnumerable<IGitTreeNode> IGitTree.Tree
        {
            get
            {
                return this._gitTree.Tree;
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
            Contract.Invariant(this._gitTree != null);

            Contract.Invariant(this._client != null);
        }
    }
}
