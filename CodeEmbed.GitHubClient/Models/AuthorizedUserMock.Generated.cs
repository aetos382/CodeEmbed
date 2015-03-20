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
    public partial class AuthorizedUserMock :
        UserMock,
        IAuthorizedUser
    {

        /// <summary>Map to "total_private_repos"</summary>
        public Int32 TotalPrivateRepositories { get; set; }

        /// <summary>Map to "owned_private_repos"</summary>
        public Int32 OwnedPrivateRepositories { get; set; }

        /// <summary>Map to "private_gists"</summary>
        public Int32 PrivateGists { get; set; }

        /// <summary>Map to "disk_usage"</summary>
        public Int64 DiskUsage { get; set; }

        /// <summary>Map to "collaborators"</summary>
        public Int32 Collaborators { get; set; }

        /// <summary>Map to "plan"</summary>
        public IUserPlan Plan { get; set; }
    }
}

#endif
