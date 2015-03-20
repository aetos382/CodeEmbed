namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistFile
    {
        /// <summary>Map to "size"</summary>
        Int64 Size { [Pure] get; }

        /// <summary>Map to "raw_url"</summary>
        Uri RawUri { [Pure] get; }

        /// <summary>Map to "type"</summary>
        String ContentType { [Pure] get; }

        /// <summary>Map to "truncated"</summary>
        Boolean Truncated { [Pure] get; }

        /// <summary>Map to "language"</summary>
        String Language { [Pure] get; }

    }
}
