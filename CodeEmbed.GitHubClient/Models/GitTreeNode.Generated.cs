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
    public partial class GitTreeNode :
        IGitTreeNode
    {
        private readonly IGitTreeNode _gitTreeNode = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GitTreeNode.</summary>
        public GitTreeNode(
            IGitTreeNode gitTreeNode,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTreeNode != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gitTreeNode = gitTreeNode;

            this._client = client;
        }

        /// <summary>Map to "path"</summary>
        public String Path
        {
            get
            {
                return this._gitTreeNode.Path;
            }
        }

        /// <summary>Map to "mode"</summary>
        public String Mode
        {
            get
            {
                return this._gitTreeNode.Mode;
            }
        }

        /// <summary>Map to "type"</summary>
        public String Type
        {
            get
            {
                return this._gitTreeNode.Type;
            }
        }

        /// <summary>Map to "size"</summary>
        public Nullable<Int64> Size
        {
            get
            {
                return this._gitTreeNode.Size;
            }
        }

        /// <summary>Map to "sha"</summary>
        public String Hash
        {
            get
            {
                return this._gitTreeNode.Hash;
            }
        }

        /// <summary>Map to "uri"</summary>
        public Uri Uri
        {
            get
            {
                return this._gitTreeNode.Uri;
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
            Contract.Invariant(this._gitTreeNode != null);
            Contract.Invariant(this._client != null);
        }
    }
}
