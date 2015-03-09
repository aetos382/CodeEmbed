








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistSummary
        : IGistBase
    {
        /// <summary>Map to "files"</summary>
        IDictionary<String, IGistFile> Files { [Pure] get; }

    }
}
