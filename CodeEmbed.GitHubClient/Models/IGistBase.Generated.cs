








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistBase
    {
        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "forks_url"</summary>
        Uri ForksUri { [Pure] get; }

        /// <summary>Map to "commits_url"</summary>
        Uri CommitsUri { [Pure] get; }

        /// <summary>Map to "id"</summary>
        String Id { [Pure] get; }

        /// <summary>Map to "description"</summary>
        String Description { [Pure] get; }

        /// <summary>Map to "public"</summary>
        Boolean IsPublic { [Pure] get; }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser Owner { [Pure] get; }

        /// <summary>Map to "user"</summary>
        String User { [Pure] get; }

        /// <summary>Map to "comments"</summary>
        Int32 Comments { [Pure] get; }

        /// <summary>Map to "comments_url"</summary>
        Uri CommentsUri { [Pure] get; }

        /// <summary>Map to "html_url"</summary>
        Uri HtmlUri { [Pure] get; }

        /// <summary>Map to "git_pull_url"</summary>
        Uri GitPullUri { [Pure] get; }

        /// <summary>Map to "git_push_url"</summary>
        Uri GitPushUri { [Pure] get; }

        /// <summary>Map to "created_at"</summary>
        DateTime CreatedAt { [Pure] get; }

        /// <summary>Map to "updated_at"</summary>
        DateTime UpdatedAt { [Pure] get; }

    }
}
