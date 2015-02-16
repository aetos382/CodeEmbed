namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public interface IUserRepository :
        IRepository
    {
        IRepositoryPermissions Permissions { [Pure] get; }
    }
}
