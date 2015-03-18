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
    public partial class GistForkMock :
        IGistFork
    {

        /// <summary>Map to "user"</summary>
        public IRepositoryUser User { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "id"</summary>
        public String Id { get; set; }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt { get; set; }
    }
}

#endif
