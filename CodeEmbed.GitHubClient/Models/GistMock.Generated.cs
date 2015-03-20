#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GistMock :
        GistBaseMock,
        IGist
    {

        /// <summary>Map to "files"</summary>
        public IReadOnlyDictionary<String, IGistFileContent> Files { get; set; }

        /// <summary>Map to "forks"</summary>
        public IEnumerable<IGistFork> Forks { get; set; }

        /// <summary>Map to "history"</summary>
        public IEnumerable<IGistHistory> Histories { get; set; }
    }
}

#endif
