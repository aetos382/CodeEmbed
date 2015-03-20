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
    public partial class SerializableGitBlob :
        IGitBlob
    {
        [ContractPublicPropertyName("Content")]
        private readonly String _content;

        [ContractPublicPropertyName("Encoding")]
        private readonly String _encoding;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Size")]
        private readonly Int64 _size;

        /// <summary>Create new instance of SerializableGitBlob.</summary>
        [JsonConstructor]
        public SerializableGitBlob(
            String content,
            String encoding,
            Uri uri,
            String hash,
            Int64 size)
        {

            this._content = content;
            this._encoding = encoding;
            this._uri = uri;
            this._hash = hash;
            this._size = size;
        }

        /// <summary>Map to "content"</summary>
        [JsonProperty("content")]
        public String Content
        {
            get
            {
                return this._content;
            }
        }

        /// <summary>Map to "encoding"</summary>
        [JsonProperty("encoding")]
        public String Encoding
        {
            get
            {
                return this._encoding;
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

        /// <summary>Map to "sha"</summary>
        [JsonProperty("sha")]
        public String Hash
        {
            get
            {
                return this._hash;
            }
        }

        /// <summary>Map to "size"</summary>
        [JsonProperty("size")]
        public Int64 Size
        {
            get
            {
                return this._size;
            }
        }
    }
}
