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
    public partial class SerializableGitCommit :
        IGitCommit
    {
        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Author")]
        private readonly SerializableCommitSignature _author;

        [ContractPublicPropertyName("Committer")]
        private readonly SerializableCommitSignature _committer;

        [ContractPublicPropertyName("Message")]
        private readonly String _message;

        [ContractPublicPropertyName("Tree")]
        private readonly SerializableCommitLink _tree;

        [ContractPublicPropertyName("Parents")]
        private readonly IEnumerable<SerializableCommitLink> _parents;

        /// <summary>Create new instance of SerializableGitCommit.</summary>
        [JsonConstructor]
        public SerializableGitCommit(
            String hash,
            Uri uri,
            SerializableCommitSignature author,
            SerializableCommitSignature committer,
            String message,
            SerializableCommitLink tree,
            IEnumerable<SerializableCommitLink> parents)
        {

            this._hash = hash;
            this._uri = uri;
            this._author = author;
            this._committer = committer;
            this._message = message;
            this._tree = tree;
            this._parents = parents;
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

        /// <summary>Map to "author"</summary>
        [JsonProperty("author")]
        public SerializableCommitSignature Author
        {
            get
            {
                return this._author;
            }
        }

        /// <summary>Map to "committer"</summary>
        [JsonProperty("committer")]
        public SerializableCommitSignature Committer
        {
            get
            {
                return this._committer;
            }
        }

        /// <summary>Map to "message"</summary>
        [JsonProperty("message")]
        public String Message
        {
            get
            {
                return this._message;
            }
        }

        /// <summary>Map to "tree"</summary>
        [JsonProperty("tree")]
        public SerializableCommitLink Tree
        {
            get
            {
                return this._tree;
            }
        }

        /// <summary>Map to "parents"</summary>
        [JsonProperty("parents")]
        public IEnumerable<SerializableCommitLink> Parents
        {
            get
            {
                return this._parents;
            }
        }

        /// <summary>Map to "author"</summary>
        ICommitSignature IGitCommit.Author
        {
            get
            {
                return this.Author;
            }
        }

        /// <summary>Map to "committer"</summary>
        ICommitSignature IGitCommit.Committer
        {
            get
            {
                return this.Committer;
            }
        }

        /// <summary>Map to "tree"</summary>
        ICommitLink IGitCommit.Tree
        {
            get
            {
                return this.Tree;
            }
        }

        /// <summary>Map to "parents"</summary>
        IEnumerable<ICommitLink> IGitCommit.Parents
        {
            get
            {
                return this.Parents;
            }
        }
    }
}
