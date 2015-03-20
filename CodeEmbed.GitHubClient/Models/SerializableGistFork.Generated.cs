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
    public partial class SerializableGistFork :
        IGistFork
    {
        [ContractPublicPropertyName("User")]
        private readonly SerializableRepositoryUser _user;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Id")]
        private readonly String _id;

        [ContractPublicPropertyName("CreatedAt")]
        private readonly DateTime _createdAt;

        [ContractPublicPropertyName("UpdatedAt")]
        private readonly DateTime _updatedAt;

        /// <summary>Create new instance of SerializableGistFork.</summary>
        [JsonConstructor]
        public SerializableGistFork(
            SerializableRepositoryUser user,
            Uri uri,
            String id,
            DateTime createdAt,
            DateTime updatedAt)
        {

            this._user = user;
            this._uri = uri;
            this._id = id;
            this._createdAt = createdAt;
            this._updatedAt = updatedAt;
        }

        /// <summary>Map to "user"</summary>
        [JsonProperty("user")]
        public SerializableRepositoryUser User
        {
            get
            {
                return this._user;
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

        /// <summary>Map to "id"</summary>
        [JsonProperty("id")]
        public String Id
        {
            get
            {
                return this._id;
            }
        }

        /// <summary>Map to "created_at"</summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get
            {
                return this._createdAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt
        {
            get
            {
                return this._updatedAt;
            }
        }

        /// <summary>Map to "user"</summary>
        IRepositoryUser IGistFork.User
        {
            get
            {
                return this.User;
            }
        }
    }
}
