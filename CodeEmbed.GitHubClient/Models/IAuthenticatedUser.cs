namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public interface IAuthenticatedUser :
        IDetailedUser
    {
        int TotalPrivateRepositories { [Pure] get; }

        int OwnedPrivateRepositories { [Pure] get; }

        int PrivateGists { [Pure] get; }

        long DiskUsage { [Pure] get; }

        int Collaborators { [Pure] get; }

        IUserPlan Plan { [Pure] get; }
    }
}
