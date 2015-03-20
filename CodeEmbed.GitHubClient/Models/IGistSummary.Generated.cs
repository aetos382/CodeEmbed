namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistSummary
        : IGistBase
    {
        /// <summary>Map to "files"</summary>
        IReadOnlyDictionary<String, IGistFile> Files { [Pure] get; }

    }
}
