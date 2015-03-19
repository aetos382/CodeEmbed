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
    public partial class GitTagMock :
        IGitTag
    {

        /// <summary>Map to "tag"</summary>
        public String Tag { get; set; }

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "message"</summary>
        public String Message { get; set; }

        /// <summary>Map to "tagger"</summary>
        public ISignature Tagger { get; set; }

        /// <summary>Map to "object"</summary>
        public IGitObject Target { get; set; }
    }
}

#endif
