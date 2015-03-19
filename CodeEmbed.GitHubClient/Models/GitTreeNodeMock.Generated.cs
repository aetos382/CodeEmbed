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
    public partial class GitTreeNodeMock :
        IGitTreeNode
    {

        /// <summary>Map to "path"</summary>
        public String Path { get; set; }

        /// <summary>Map to "mode"</summary>
        public String Mode { get; set; }

        /// <summary>Map to "type"</summary>
        public String Type { get; set; }

        /// <summary>Map to "size"</summary>
        public Nullable<Int64> Size { get; set; }

        /// <summary>Map to "sha"</summary>
        public String Hash { get; set; }

        /// <summary>Map to "uri"</summary>
        public Uri Uri { get; set; }
    }
}

#endif
