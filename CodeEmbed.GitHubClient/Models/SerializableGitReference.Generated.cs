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
    public partial class SerializableGitReference :
        IGitReference
    {
        [ContractPublicPropertyName("Reference")]
        private readonly String _reference;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Target")]
        private readonly IGitObject _target;

        /// <summary>Create new instance of SerializableGitReference.</summary>
        [JsonConstructor]
        public SerializableGitReference(
			String reference,
			Uri uri,
			IGitObject target)
        {

            this._reference = reference;
            this._uri = uri;
            this._target = target;
        }

        /// <summary>Map to "ref"</summary>
        [JsonProperty("ref")]
        public String Reference
        {
            get
            {
                return this._reference;
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

        /// <summary>Map to "object"</summary>
        [JsonProperty("object")]
        public IGitObject Target
        {
            get
            {
                return this._target;
            }
        }
    }
}
