namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableGitTree :
        IGitTree
    {
        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Tree")]
        private readonly IEnumerable<SerializableGitTreeNode> _tree;

        [ContractPublicPropertyName("Truncated")]
        private readonly Boolean _truncated;

        /// <summary>Create new instance of SerializableGitTree.</summary>
        [JsonConstructor]
        public SerializableGitTree(
            String hash,
            Uri uri,
            IEnumerable<SerializableGitTreeNode> tree,
            Boolean truncated)
        {

            this._hash = hash;
            this._uri = uri;
            this._tree = tree;
            this._truncated = truncated;
        }

        /// <summary>Map to "sha"</summary>
        [JsonProperty("sha")]
        public String Hash
        {
            get
            {
                return this._hash;
            }
        }

        /// <summary>Map to "url"</summary>
        [JsonProperty("url")]
        public Uri Uri
        {
            get
            {
                return this._uri;
            }
        }

        /// <summary>Map to "tree"</summary>
        [JsonProperty("tree")]
        public IEnumerable<SerializableGitTreeNode> Tree
        {
            get
            {
                return this._tree;
            }
        }

        /// <summary>Map to "truncated"</summary>
        [JsonProperty("truncated")]
        public Boolean Truncated
        {
            get
            {
                return this._truncated;
            }
        }

        /// <summary>Map to "tree"</summary>
        IEnumerable<IGitTreeNode> IGitTree.Tree
        {
            get
            {
                return this.Tree;
            }
        }
    }
}
