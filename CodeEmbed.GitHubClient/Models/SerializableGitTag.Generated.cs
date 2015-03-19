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
    public partial class SerializableGitTag :
        IGitTag
    {
        [ContractPublicPropertyName("Tag")]
        private readonly String _tag;

        [ContractPublicPropertyName("Hash")]
        private readonly String _hash;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Message")]
        private readonly String _message;

        [ContractPublicPropertyName("Tagger")]
        private readonly SerializableSignature _tagger;

        [ContractPublicPropertyName("Target")]
        private readonly SerializableGitObject _target;

        /// <summary>Create new instance of SerializableGitTag.</summary>
        [JsonConstructor]
        public SerializableGitTag(
            String tag,
            String hash,
            Uri uri,
            String message,
            SerializableSignature tagger,
            SerializableGitObject target)
        {

            this._tag = tag;
            this._hash = hash;
            this._uri = uri;
            this._message = message;
            this._tagger = tagger;
            this._target = target;
        }

        /// <summary>Map to "tag"</summary>
        [JsonProperty("tag")]
        public String Tag
        {
            get
            {
                return this._tag;
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

        /// <summary>Map to "message"</summary>
        [JsonProperty("message")]
        public String Message
        {
            get
            {
                return this._message;
            }
        }

        /// <summary>Map to "tagger"</summary>
        [JsonProperty("tagger")]
        public SerializableSignature Tagger
        {
            get
            {
                return this._tagger;
            }
        }

        /// <summary>Map to "object"</summary>
        [JsonProperty("object")]
        public SerializableGitObject Target
        {
            get
            {
                return this._target;
            }
        }

        /// <summary>Map to "tagger"</summary>
        ISignature IGitTag.Tagger
        {
            get
            {
                return this.Tagger;
            }
        }

        /// <summary>Map to "object"</summary>
        IGitObject IGitTag.Target
        {
            get
            {
                return this.Target;
            }
        }
    }
}
