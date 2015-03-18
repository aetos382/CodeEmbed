#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GitCommitMock :
        IGitCommit
    {

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "author"</summary>
        public ICommitSignature Author { get; set; }

        /// <summary>Map to "committer"</summary>
        public ICommitSignature Committer { get; set; }

        /// <summary>Map to "message"</summary>
        public String Message { get; set; }

        /// <summary>Map to "tree"</summary>
        public ICommitLink Tree { get; set; }

        /// <summary>Map to "parents"</summary>
        public IEnumerable<ICommitLink> Parents { get; set; }
    }
}

#endif
