namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface ICommitTree
    {
        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

    }
}
