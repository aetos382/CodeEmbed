namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public interface IDetailedUser :
        IRepositoryUser
    {
        string Name { [Pure] get; }

        string Company { [Pure] get; }

        Uri Blog { [Pure] get; }

        string Location { [Pure] get; }

        string EMail { [Pure] get; }

        bool Hireable { [Pure] get; }

        string Bio { [Pure] get; }

        int PublicRepositories { [Pure] get; }

        int PublicGists { [Pure] get; }

        int Followers { [Pure] get; }

        int Following { [Pure] get; }

        DateTime CreatedAt { [Pure] get; }

        DateTime UpdatedAt { [Pure] get; }
    }
}
