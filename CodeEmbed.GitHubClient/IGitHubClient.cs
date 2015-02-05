namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;

    public interface IGitHubClient
    {
        Uri RootUri { get; set; }
    }
}
