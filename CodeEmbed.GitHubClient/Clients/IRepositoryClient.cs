namespace CodeEmbed.GitHubClient.Clients
{
    using System;
    using System.Linq;

    using CodeEmbed.GitHubClient.Models;

    public interface IRepositoryClient
    {
        Repository Get(
            string user,
            string repository);
    }
}
