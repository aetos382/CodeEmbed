namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IBranch
    {
        string Name { [Pure] get; }
    }
}
