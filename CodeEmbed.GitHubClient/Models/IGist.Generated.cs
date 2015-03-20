namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGist
        : IGistBase
    {
        /// <summary>Map to "files"</summary>
        IReadOnlyDictionary<String, IGistFileContent> Files { [Pure] get; }

        /// <summary>Map to "forks"</summary>
        IEnumerable<IGistFork> Forks { [Pure] get; }

        /// <summary>Map to "history"</summary>
        IEnumerable<IGistHistory> Histories { [Pure] get; }

    }
}
