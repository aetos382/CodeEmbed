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
    public partial class SerializableCommitLink :
        ICommitLink
    {
        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("HtmlUri")]
        private readonly Uri _htmlUri;

        /// <summary>Create new instance of SerializableCommitLink.</summary>
        [JsonConstructor]
        public SerializableCommitLink(
            String hash,
            Uri uri,
            Uri htmlUri)
        {

            this._hash = hash;
            this._uri = uri;
            this._htmlUri = htmlUri;
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

        /// <summary>Map to "html_url"</summary>
        [JsonProperty("html_url")]
        public Uri HtmlUri
        {
            get
            {
                return this._htmlUri;
            }
        }
    }
}
