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
    public partial class GistChangeStatusMock :
        IGistChangeStatus
    {

        /// <summary>Map to "deletions"</summary>
        public Int32 Deletions { get; set; }

        /// <summary>Map to "additions"</summary>
        public Int32 Additions { get; set; }

        /// <summary>Map to "total"</summary>
        public Int32 Total { get; set; }
    }
}

#endif
