namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    //// GET /repos/:owner/:repo/git/refs[/:ref]
    
    public interface IGitReference
    {
        string Ref { [Pure] get; }

        Uri Url { [Pure] get; }

        IGitRefObject Object { [Pure] get; }
    }
}
