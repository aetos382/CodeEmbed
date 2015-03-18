#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GistFileContentMock :
        GistFileMock,
        IGistFileContent
    {

        /// <summary>Map to "content"</summary>
        public String Content { get; set; }
    }
}

#endif
