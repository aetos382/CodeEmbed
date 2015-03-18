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
    public partial class GitObjectMock :
        IGitObject
    {

        /// <summary>Map to "type"</summary>
        public String ObjectType { get; set; }

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }
    }
}

#endif
