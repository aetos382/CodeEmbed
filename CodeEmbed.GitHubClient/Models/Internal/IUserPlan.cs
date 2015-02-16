namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IUserPlan
    {
        string Name { [Pure] get; }

        long Space { [Pure] get; }

        int PrivateRepositories { [Pure] get; }

        int Collaborators { [Pure] get; }
    }
}
