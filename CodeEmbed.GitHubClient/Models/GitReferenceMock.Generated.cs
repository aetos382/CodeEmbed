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
    public partial class GitReferenceMock :
        IGitReference
    {

        /// <summary>Map to "ref"</summary>
        public String Reference { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "object"</summary>
        public IGitObject Target { get; set; }
    }
}

#endif
