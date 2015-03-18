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
    public partial class GistFileMock :
        IGistFile
    {

        /// <summary>Map to "size"</summary>
        public Int64 Size { get; set; }

        /// <summary>Map to "raw_url"</summary>
        public Uri RawUri { get; set; }

        /// <summary>Map to "type"</summary>
        public String ContentType { get; set; }

        /// <summary>Map to "truncated"</summary>
        public Boolean Truncated { get; set; }

        /// <summary>Map to "language"</summary>
        public String Language { get; set; }
    }
}

#endif
