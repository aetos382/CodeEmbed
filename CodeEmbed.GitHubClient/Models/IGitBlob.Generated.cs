namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitBlob
    {
        /// <summary>Map to "content"</summary>
        String Content { [Pure] get; }

        /// <summary>Map to "encoding"</summary>
        String Encoding { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "size"</summary>
        Int64 Size { [Pure] get; }

    }
}
