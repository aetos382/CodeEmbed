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
    public partial class GistSummaryMock :
        GistBaseMock,
        IGistSummary
    {

        /// <summary>Map to "files"</summary>
        public IReadOnlyDictionary<String, IGistFile> Files { get; set; }
    }
}

#endif
