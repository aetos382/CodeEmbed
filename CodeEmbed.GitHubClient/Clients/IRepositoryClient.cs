namespace CodeEmbed.GitHub.Clients
{
    using System;
    using System.Linq;

    using CodeEmbed.GitHub.Models;

    public interface IRepositoryClient
    {
        Repository Get(
            string user,
            string repository);
    }
}
