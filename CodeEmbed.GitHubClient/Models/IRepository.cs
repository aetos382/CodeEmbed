namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IRepository
    {
        long Id { [Pure] get; }

        string Name { [Pure] get; }

        string FullName { [Pure] get; }

        string Description { [Pure] get; }

        Uri Uri { [Pure] get; }

        string DefaultBranch { [Pure] get; }
    }
}
