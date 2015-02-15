namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Diagnostics.Contracts;

    public interface IGitRefObject
    {
        string Type { [Pure] get; }

        string Sha { [Pure] get; }

        Uri Url { [Pure] get; }
    }
}
