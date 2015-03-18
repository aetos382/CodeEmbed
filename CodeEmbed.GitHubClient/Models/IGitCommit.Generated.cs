namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitCommit
    {
        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "author"</summary>
        ICommitSignature Author { [Pure] get; }

        /// <summary>Map to "committer"</summary>
        ICommitSignature Committer { [Pure] get; }

        /// <summary>Map to "message"</summary>
        String Message { [Pure] get; }

        /// <summary>Map to "tree"</summary>
        ICommitLink Tree { [Pure] get; }

        /// <summary>Map to "parents"</summary>
        IEnumerable<ICommitLink> Parents { [Pure] get; }

    }
}
