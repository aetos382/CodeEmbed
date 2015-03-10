namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializableGist :
        SerializableGistBase,
        IGist
    {
        [ContractPublicPropertyName("Files")]
        private readonly IReadOnlyDictionary<String, IGistFileContent> _files;

        [ContractPublicPropertyName("Forks")]
        private readonly IEnumerable<IGistFork> _forks;

        [ContractPublicPropertyName("Histories")]
        private readonly IEnumerable<IGistHistory> _histories;

        /// <summary>Create new instance of SerializableGist.</summary>
        [JsonConstructor]
        public SerializableGist(
			Uri uri,
			Uri forksUri,
			Uri commitsUri,
			String id,
			String description,
			Boolean isPublic,
			IRepositoryUser owner,
			String user,
			Int32 comments,
			Uri commentsUri,
			Uri htmlUri,
			Uri gitPullUri,
			Uri gitPushUri,
			DateTime createdAt,
			DateTime updatedAt,
			IReadOnlyDictionary<String, IGistFileContent> files,
			IEnumerable<IGistFork> forks,
			IEnumerable<IGistHistory> histories)
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
        public IReadOnlyDictionary<String, IGistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        /// <summary>Map to "forks"</summary>
        [JsonProperty("forks")]
        public IEnumerable<IGistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }

        /// <summary>Map to "histories"</summary>
        [JsonProperty("histories")]
        public IEnumerable<IGistHistory> Histories
        {
            get
            {
                return this._histories;
            }
        }
    }
}
