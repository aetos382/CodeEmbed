namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitTree
    {
        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "tree"</summary>
        IEnumerable<IGitTreeNode> Tree { [Pure] get; }

        /// <summary>Map to "truncated"</summary>
        Boolean Truncated { [Pure] get; }

    }
}
