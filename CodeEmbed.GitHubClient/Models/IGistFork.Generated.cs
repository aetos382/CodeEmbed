namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistFork
    {
        /// <summary>Map to "user"</summary>
        IRepositoryUser User { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "id"</summary>
        String Id { [Pure] get; }

        /// <summary>Map to "created_at"</summary>
        DateTime CreatedAt { [Pure] get; }

        /// <summary>Map to "updated_at"</summary>
        DateTime UpdatedAt { [Pure] get; }

    }
}
