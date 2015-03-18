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
    public partial class CommitSignatureMock :
        ICommitSignature
    {

        /// <summary>Map to "date"</summary>
        public DateTime Date { get; set; }

        /// <summary>Map to "name"</summary>
        public String Name { get; set; }

        /// <summary>Map to "email"</summary>
        public String Email { get; set; }
    }
}

#endif
