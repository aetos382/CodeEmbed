namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitTreeNode
    {
        /// <summary>Map to "path"</summary>
        String Path { [Pure] get; }

        /// <summary>Map to "mode"</summary>
        String Mode { [Pure] get; }

        /// <summary>Map to "type"</summary>
        String Type { [Pure] get; }

        /// <summary>Map to "size"</summary>
        Nullable<Int64> Size { [Pure] get; }

        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "uri"</summary>
        Uri Uri { [Pure] get; }

    }
}
