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
    public partial class UserPlanMock :
        IUserPlan
    {

        /// <summary>Map to "name"</summary>
        public String Name { get; set; }

        /// <summary>Map to "space"</summary>
        public Int64 Space { get; set; }

        /// <summary>Map to "private_repos"</summary>
        public Int32 PrivateRepositories { get; set; }

        /// <summary>Map to "collaborators"</summary>
        public Int32 Collaborators { get; set; }
    }
}

#endif
