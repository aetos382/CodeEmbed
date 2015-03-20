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
    public partial class GitTreeMock :
        IGitTree
    {

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "tree"</summary>
        public IEnumerable<IGitTreeNode> Tree { get; set; }

        /// <summary>Map to "truncated"</summary>
        public Boolean Truncated { get; set; }
    }
}

#endif
