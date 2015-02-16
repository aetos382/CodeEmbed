namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IRepositoryPermissions
    {
        bool Administration { [Pure] get; }

        bool Push { [Pure] get; }

        bool Pull { [Pure] get; }
    }
}
