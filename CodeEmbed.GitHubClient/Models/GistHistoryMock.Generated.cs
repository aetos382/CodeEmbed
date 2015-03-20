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
    public partial class GistHistoryMock :
        IGistHistory
    {

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "version"</summary>
        public String Version { get; set; }

        /// <summary>Map to "user"</summary>
        public IRepositoryUser User { get; set; }

        /// <summary>Map to "change_status"</summary>
        public IGistChangeStatus ChangeStatus { get; set; }

        /// <summary>Map to "committed_at"</summary>
        public DateTime CommittedAt { get; set; }
    }
}

#endif
