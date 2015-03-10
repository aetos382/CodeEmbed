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
    public partial class SerializableAuthorizedUser :
        SerializableUser,
        IAuthorizedUser
    {
        [ContractPublicPropertyName("TotalPrivateRepositories")]
        private readonly Int32 _totalPrivateRepositories;

        [ContractPublicPropertyName("OwnedPrivateRepositories")]
        private readonly Int32 _ownedPrivateRepositories;

        [ContractPublicPropertyName("PrivateGists")]
        private readonly Int32 _privateGists;

        [ContractPublicPropertyName("DiskUsage")]
        private readonly Int64 _diskUsage;

        [ContractPublicPropertyName("Collaborators")]
        private readonly Int32 _collaborators;

        [ContractPublicPropertyName("Plan")]
        private readonly IUserPlan _plan;

        /// <summary>Create new instance of SerializableAuthorizedUser.</summary>
        [JsonConstructor]
        public SerializableAuthorizedUser(
			String login,
			Int64 id,
			Uri avatarUri,
			String gravatarId,
			Uri uri,
			Uri htmlUri,
			Uri followersUri,
			String followingUri,
			String gistsUri,
			String starredUri,
			Uri subscriptionsUri,
			Uri organizationsUri,
			Uri repositoriesUri,
			String eventUri,
			Uri receivedEventsUri,
			String type,
			Boolean siteAdministrator,
			String name,
			String company,
			Uri blog,
			String location,
			String email,
			Boolean hireable,
			String bio,
			Int32 publicRepositories,
			Int32 publicGists,
			Int32 followers,
			Int32 following,
			DateTime createdAt,
			DateTime updatedAt,
			Int32 totalPrivateRepositories,
			Int32 ownedPrivateRepositories,
			Int32 privateGists,
			Int64 diskUsage,
			Int32 collaborators,
			IUserPlan plan)
            : base(
				login,
				id,
				avatarUri,
				gravatarId,
				uri,
				htmlUri,
				followersUri,
				followingUri,
				gistsUri,
				starredUri,
				subscriptionsUri,
				organizationsUri,
				repositoriesUri,
				eventUri,
				receivedEventsUri,
				type,
				siteAdministrator,
				name,
				company,
				blog,
				location,
				email,
				hireable,
				bio,
				publicRepositories,
				publicGists,
				followers,
				following,
				createdAt,
				updatedAt)
        {
            Contract.Requires<ArgumentNullException>(login != null);

            this._totalPrivateRepositories = totalPrivateRepositories;
            this._ownedPrivateRepositories = ownedPrivateRepositories;
            this._privateGists = privateGists;
            this._diskUsage = diskUsage;
            this._collaborators = collaborators;
            this._plan = plan;
        }

        /// <summary>Map to "total_private_repos"</summary>
        [JsonProperty("total_private_repos")]
        public Int32 TotalPrivateRepositories
        {
            get
            {
                return this._totalPrivateRepositories;
            }
        }

        /// <summary>Map to "owned_private_repos"</summary>
        [JsonProperty("owned_private_repos")]
        public Int32 OwnedPrivateRepositories
        {
            get
            {
                return this._ownedPrivateRepositories;
            }
        }

        /// <summary>Map to "private_gists"</summary>
        [JsonProperty("private_gists")]
        public Int32 PrivateGists
        {
            get
            {
                return this._privateGists;
            }
        }

        /// <summary>Map to "disk_usage"</summary>
        [JsonProperty("disk_usage")]
        public Int64 DiskUsage
        {
            get
            {
                return this._diskUsage;
            }
        }

        /// <summary>Map to "collaborators"</summary>
        [JsonProperty("collaborators")]
        public Int32 Collaborators
        {
            get
            {
                return this._collaborators;
            }
        }

        /// <summary>Map to "plan"</summary>
        [JsonProperty("plan")]
        public IUserPlan Plan
        {
            get
            {
                return this._plan;
            }
        }
    }
}
