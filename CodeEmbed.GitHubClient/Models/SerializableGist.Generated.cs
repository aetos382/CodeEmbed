namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableGist :
        SerializableGistBase,
        IGist
    {
        [ContractPublicPropertyName("Files")]
        private readonly IReadOnlyDictionary<String, SerializableGistFileContent> _files;

        [ContractPublicPropertyName("Forks")]
        private readonly IEnumerable<SerializableGistFork> _forks;

        [ContractPublicPropertyName("Histories")]
        private readonly IEnumerable<SerializableGistHistory> _histories;

        /// <summary>Create new instance of SerializableGist.</summary>
        [JsonConstructor]
        public SerializableGist(
            Uri uri,
            Uri forksUri,
            Uri commitsUri,
            String id,
            String description,
            Boolean isPublic,
            SerializableRepositoryUser owner,
            String user,
            Int32 comments,
            Uri commentsUri,
            Uri htmlUri,
            Uri gitPullUri,
            Uri gitPushUri,
            DateTime createdAt,
            DateTime updatedAt,
            IReadOnlyDictionary<String, SerializableGistFileContent> files,
            IEnumerable<SerializableGistFork> forks,
            IEnumerable<SerializableGistHistory> histories)
            : base(
                uri,
                forksUri,
                commitsUri,
                id,
                description,
                isPublic,
                owner,
                user,
                comments,
                commentsUri,
                htmlUri,
                gitPullUri,
                gitPushUri,
                createdAt,
                updatedAt)
        {

            this._files = files;
            this._forks = forks;
            this._histories = histories;
        }

        /// <summary>Map to "files"</summary>
        [JsonProperty("files")]
        public IReadOnlyDictionary<String, SerializableGistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        /// <summary>Map to "forks"</summary>
        [JsonProperty("forks")]
        public IEnumerable<SerializableGistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }

        /// <summary>Map to "history"</summary>
        [JsonProperty("history")]
        public IEnumerable<SerializableGistHistory> Histories
        {
            get
            {
                return this._histories;
            }
        }

        /// <summary>Map to "files"</summary>
        IReadOnlyDictionary<String, IGistFileContent> IGist.Files
        {
            get
            {
                return this._files.ToDictionary(x => x.Key, x => (IGistFileContent)x.Value);
            }
        }

        /// <summary>Map to "forks"</summary>
        IEnumerable<IGistFork> IGist.Forks
        {
            get
            {
                return this.Forks;
            }
        }

        /// <summary>Map to "history"</summary>
        IEnumerable<IGistHistory> IGist.Histories
        {
            get
            {
                return this.Histories;
            }
        }
    }
}
