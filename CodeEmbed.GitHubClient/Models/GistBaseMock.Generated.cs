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
    public abstract partial class GistBaseMock :
        IGistBase
    {

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "forks_url"</summary>
        public Uri ForksUri { get; set; }

        /// <summary>Map to "commits_url"</summary>
        public Uri CommitsUri { get; set; }

        /// <summary>Map to "id"</summary>
        public String Id { get; set; }

        /// <summary>Map to "description"</summary>
        public String Description { get; set; }

        /// <summary>Map to "public"</summary>
        public Boolean IsPublic { get; set; }

        /// <summary>Map to "owner"</summary>
        public IRepositoryUser Owner { get; set; }

        /// <summary>Map to "user"</summary>
        public String User { get; set; }

        /// <summary>Map to "comments"</summary>
        public Int32 Comments { get; set; }

        /// <summary>Map to "comments_url"</summary>
        public Uri CommentsUri { get; set; }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri { get; set; }

        /// <summary>Map to "git_pull_url"</summary>
        public Uri GitPullUri { get; set; }

        /// <summary>Map to "git_push_url"</summary>
        public Uri GitPushUri { get; set; }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt { get; set; }
    }
}

#endif
