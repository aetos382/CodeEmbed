namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGistHistory
    {
        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "version"</summary>
        String Version { [Pure] get; }

        /// <summary>Map to "user"</summary>
        IRepositoryUser User { [Pure] get; }

        /// <summary>Map to "change_status"</summary>
        IGistChangeStatus ChangeStatus { [Pure] get; }

        /// <summary>Map to "committed_at"</summary>
        DateTime CommittedAt { [Pure] get; }

    }
}
