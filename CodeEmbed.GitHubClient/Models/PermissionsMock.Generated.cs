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
    public partial class PermissionsMock :
        IPermissions
    {

        /// <summary>Map to "admin"</summary>
        public Boolean Administration { get; set; }

        /// <summary>Map to "push"</summary>
        public Boolean Push { get; set; }

        /// <summary>Map to "pull"</summary>
        public Boolean Pull { get; set; }
    }
}

#endif
