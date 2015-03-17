namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableGitTreeNode :
        IGitTreeNode
    {
        [ContractPublicPropertyName("Path")]
        private readonly String _path;

        [ContractPublicPropertyName("Mode")]
        private readonly String _mode;

        [ContractPublicPropertyName("Type")]
        private readonly String _type;

        [ContractPublicPropertyName("Size")]
        private readonly Nullable<Int64> _size;

        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        /// <summary>Create new instance of SerializableGitTreeNode.</summary>
        [JsonConstructor]
        public SerializableGitTreeNode(
            String path,
            String mode,
            String type,
            Nullable<Int64> size,
            String hash,
            Uri uri)
        {

            this._path = path;
            this._mode = mode;
            this._type = type;
            this._size = size;
            this._hash = hash;
            this._uri = uri;
        }

        /// <summary>Map to "path"</summary>
        [JsonProperty("path")]
        public String Path
        {
            get
            {
                return this._path;
            }
        }

        /// <summary>Map to "mode"</summary>
        [JsonProperty("mode")]
        public String Mode
        {
            get
            {
                return this._mode;
            }
        }

        /// <summary>Map to "type"</summary>
        [JsonProperty("type")]
        public String Type
        {
            get
            {
                return this._type;
            }
        }

        /// <summary>Map to "size"</summary>
        [JsonProperty("size")]
        public Nullable<Int64> Size
        {
            get
            {
                return this._size;
            }
        }

        /// <summary>Map to "hash"</summary>
        [JsonProperty("hash")]
        public String Hash
        {
            get
            {
                return this._hash;
            }
        }

        /// <summary>Map to "uri"</summary>
        [JsonProperty("uri")]
        public Uri Uri
        {
            get
            {
                return this._uri;
            }
        }
    }
}
