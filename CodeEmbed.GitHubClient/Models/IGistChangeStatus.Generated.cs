








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistChangeStatus
    {
        /// <summary>Map to "deletions"</summary>
        Int32 Deletions { [Pure] get; }

        /// <summary>Map to "additions"</summary>
        Int32 Additions { [Pure] get; }

        /// <summary>Map to "total"</summary>
        Int32 Total { [Pure] get; }

    }
}
