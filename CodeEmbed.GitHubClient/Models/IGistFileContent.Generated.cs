namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistFileContent
        : IGistFile
    {
        /// <summary>Map to "content"</summary>
        String Content { [Pure] get; }

    }
}
