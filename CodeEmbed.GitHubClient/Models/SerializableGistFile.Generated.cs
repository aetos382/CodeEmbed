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
    public partial class SerializableGistFile :
        IGistFile
    {
        [ContractPublicPropertyName("Size")]
        private readonly Int64 _size;

        [ContractPublicPropertyName("RawUri")]
        private readonly Uri _rawUri;

        [ContractPublicPropertyName("ContentType")]
        private readonly String _contentType;

        [ContractPublicPropertyName("Truncated")]
        private readonly Boolean _truncated;

        [ContractPublicPropertyName("Language")]
        private readonly String _language;

        /// <summary>Create new instance of SerializableGistFile.</summary>
        [JsonConstructor]
        public SerializableGistFile(
            Int64 size,
            Uri rawUri,
            String contentType,
            Boolean truncated,
            String language)
        {

            this._size = size;
            this._rawUri = rawUri;
            this._contentType = contentType;
            this._truncated = truncated;
            this._language = language;
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

        /// <summary>Map to "raw_url"</summary>
        [JsonProperty("raw_url")]
        public Uri RawUri
        {
            get
            {
                return this._rawUri;
            }
        }

        /// <summary>Map to "type"</summary>
        [JsonProperty("type")]
        public String ContentType
        {
            get
            {
                return this._contentType;
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

        /// <summary>Map to "language"</summary>
        [JsonProperty("language")]
        public String Language
        {
            get
            {
                return this._language;
            }
        }
    }
}
