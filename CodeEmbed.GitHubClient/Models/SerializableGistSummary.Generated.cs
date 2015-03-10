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
    public partial class SerializableGistSummary :
        SerializableGistBase,
        IGistSummary
    {
        [ContractPublicPropertyName("Files")]
        private readonly IReadOnlyDictionary<String, IGistFile> _files;

        /// <summary>Create new instance of SerializableGistSummary.</summary>
        [JsonConstructor]
        public SerializableGistSummary(
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
			IReadOnlyDictionary<String, IGistFile> files)
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
        }

        /// <summary>Map to "files"</summary>
        [JsonProperty("files")]
        public IReadOnlyDictionary<String, IGistFile> Files
        {
            get
            {
                return this._files;
            }
        }
    }
}
