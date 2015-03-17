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
    public partial class SerializableCommitTree :
        ICommitTree
    {
        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        /// <summary>Create new instance of SerializableCommitTree.</summary>
        [JsonConstructor]
        public SerializableCommitTree(
            Uri uri,
            String hash)
        {

            this._uri = uri;
            this._hash = hash;
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

        /// <summary>Map to "sha"</summary>
        [JsonProperty("sha")]
        public String Hash
        {
            get
            {
                return this._hash;
            }
        }
    }
}
