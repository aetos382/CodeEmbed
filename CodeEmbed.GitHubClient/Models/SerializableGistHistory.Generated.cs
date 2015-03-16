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
    public partial class SerializableGistHistory :
        IGistHistory
    {
        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("Version")]
        private readonly String _version;

        [ContractPublicPropertyName("User")]
        private readonly SerializableRepositoryUser _user;

        [ContractPublicPropertyName("ChangeStatus")]
        private readonly SerializableGistChangeStatus _changeStatus;

        [ContractPublicPropertyName("CommittedAt")]
        private readonly DateTime _committedAt;

        /// <summary>Create new instance of SerializableGistHistory.</summary>
        [JsonConstructor]
        public SerializableGistHistory(
            Uri uri,
            String version,
            SerializableRepositoryUser user,
            SerializableGistChangeStatus changeStatus,
            DateTime committedAt)
        {

            this._uri = uri;
            this._version = version;
            this._user = user;
            this._changeStatus = changeStatus;
            this._committedAt = committedAt;
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

        /// <summary>Map to "version"</summary>
        [JsonProperty("version")]
        public String Version
        {
            get
            {
                return this._version;
            }
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

        /// <summary>Map to "change_status"</summary>
        [JsonProperty("change_status")]
        public SerializableGistChangeStatus ChangeStatus
        {
            get
            {
                return this._changeStatus;
            }
        }

        /// <summary>Map to "committed_at"</summary>
        [JsonProperty("committed_at")]
        public DateTime CommittedAt
        {
            get
            {
                return this._committedAt;
            }
        }

        /// <summary>Map to "user"</summary>
        IRepositoryUser IGistHistory.User
        {
            get
            {
                return this.User;
            }
        }

        /// <summary>Map to "change_status"</summary>
        IGistChangeStatus IGistHistory.ChangeStatus
        {
            get
            {
                return this.ChangeStatus;
            }
        }
    }
}
