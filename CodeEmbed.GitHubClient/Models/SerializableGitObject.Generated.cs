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
    public partial class SerializableGitObject :
        IGitObject
    {
        [ContractPublicPropertyName("Type")]
        private readonly String _type;

        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        /// <summary>Create new instance of SerializableGitObject.</summary>
        [JsonConstructor]
        public SerializableGitObject(
            String type,
            String hash,
            Uri uri)
        {

            this._type = type;
            this._hash = hash;
            this._uri = uri;
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
    }
}
