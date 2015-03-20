#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class UserMock :
        RepositoryUserMock,
        IUser
    {

        /// <summary>Map to "name"</summary>
        public String Name { get; set; }

        /// <summary>Map to "company"</summary>
        public String Company { get; set; }

        /// <summary>Map to "blog"</summary>
        public Uri Blog { get; set; }

        /// <summary>Map to "location"</summary>
        public String Location { get; set; }

        /// <summary>Map to "email"</summary>
        public String Email { get; set; }

        /// <summary>Map to "hireable"</summary>
        public Boolean Hireable { get; set; }

        /// <summary>Map to "bio"</summary>
        public String Bio { get; set; }

        /// <summary>Map to "public_repos"</summary>
        public Int32 PublicRepositories { get; set; }

        /// <summary>Map to "public_gists"</summary>
        public Int32 PublicGists { get; set; }

        /// <summary>Map to "followers"</summary>
        public Int32 Followers { get; set; }

        /// <summary>Map to "following"</summary>
        public Int32 Following { get; set; }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt { get; set; }
    }
}

#endif
