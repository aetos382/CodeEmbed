namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IAuthorizedUser
        : IUser
    {
        /// <summary>Map to "total_private_repos"</summary>
        Int32 TotalPrivateRepositories { [Pure] get; }

        /// <summary>Map to "owned_private_repos"</summary>
        Int32 OwnedPrivateRepositories { [Pure] get; }

        /// <summary>Map to "private_gists"</summary>
        Int32 PrivateGists { [Pure] get; }

        /// <summary>Map to "disk_usage"</summary>
        Int64 DiskUsage { [Pure] get; }

        /// <summary>Map to "collaborators"</summary>
        Int32 Collaborators { [Pure] get; }

        /// <summary>Map to "plan"</summary>
        IUserPlan Plan { [Pure] get; }

    }
}
