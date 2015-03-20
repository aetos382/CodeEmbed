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
    public partial class GitBlobMock :
        IGitBlob
    {

        /// <summary>Map to "content"</summary>
        public String Content { get; set; }

        /// <summary>Map to "encoding"</summary>
        public String Encoding { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "size"</summary>
        public Int64 Size { get; set; }
    }
}

#endif
