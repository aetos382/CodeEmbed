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
    public partial class SerializableUser :
        SerializableRepositoryUser,
        IUser
    {
        [ContractPublicPropertyName("Name")]
        private readonly String _name;

        [ContractPublicPropertyName("Company")]
        private readonly String _company;

        [ContractPublicPropertyName("Blog")]
        private readonly Uri _blog;

        [ContractPublicPropertyName("Location")]
        private readonly String _location;

        [ContractPublicPropertyName("Email")]
        private readonly String _email;

        [ContractPublicPropertyName("Hireable")]
        private readonly Boolean _hireable;

        [ContractPublicPropertyName("Bio")]
        private readonly String _bio;

        [ContractPublicPropertyName("PublicRepositories")]
        private readonly Int32 _publicRepositories;

        [ContractPublicPropertyName("PublicGists")]
        private readonly Int32 _publicGists;

        [ContractPublicPropertyName("Followers")]
        private readonly Int32 _followers;

        [ContractPublicPropertyName("Following")]
        private readonly Int32 _following;

        [ContractPublicPropertyName("CreatedAt")]
        private readonly DateTime _createdAt;

        [ContractPublicPropertyName("UpdatedAt")]
        private readonly DateTime _updatedAt;

        /// <summary>Create new instance of SerializableUser.</summary>
        [JsonConstructor]
        public SerializableUser(
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
            String eventsUri,
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
            DateTime updatedAt)
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
                eventsUri,
                receivedEventsUri,
                type,
                siteAdministrator)
        {
            Contract.Requires<ArgumentNullException>(login != null);

            this._name = name;
            this._company = company;
            this._blog = blog;
            this._location = location;
            this._email = email;
            this._hireable = hireable;
            this._bio = bio;
            this._publicRepositories = publicRepositories;
            this._publicGists = publicGists;
            this._followers = followers;
            this._following = following;
            this._createdAt = createdAt;
            this._updatedAt = updatedAt;
        }

        /// <summary>Map to "name"</summary>
        [JsonProperty("name")]
        public String Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>Map to "company"</summary>
        [JsonProperty("company")]
        public String Company
        {
            get
            {
                return this._company;
            }
        }

        /// <summary>Map to "blog"</summary>
        [JsonProperty("blog")]
        public Uri Blog
        {
            get
            {
                return this._blog;
            }
        }

        /// <summary>Map to "location"</summary>
        [JsonProperty("location")]
        public String Location
        {
            get
            {
                return this._location;
            }
        }

        /// <summary>Map to "email"</summary>
        [JsonProperty("email")]
        public String Email
        {
            get
            {
                return this._email;
            }
        }

        /// <summary>Map to "hireable"</summary>
        [JsonProperty("hireable")]
        public Boolean Hireable
        {
            get
            {
                return this._hireable;
            }
        }

        /// <summary>Map to "bio"</summary>
        [JsonProperty("bio")]
        public String Bio
        {
            get
            {
                return this._bio;
            }
        }

        /// <summary>Map to "public_repos"</summary>
        [JsonProperty("public_repos")]
        public Int32 PublicRepositories
        {
            get
            {
                return this._publicRepositories;
            }
        }

        /// <summary>Map to "public_gists"</summary>
        [JsonProperty("public_gists")]
        public Int32 PublicGists
        {
            get
            {
                return this._publicGists;
            }
        }

        /// <summary>Map to "followers"</summary>
        [JsonProperty("followers")]
        public Int32 Followers
        {
            get
            {
                return this._followers;
            }
        }

        /// <summary>Map to "following"</summary>
        [JsonProperty("following")]
        public Int32 Following
        {
            get
            {
                return this._following;
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
    }
}
