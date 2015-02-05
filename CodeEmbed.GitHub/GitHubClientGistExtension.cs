﻿namespace CodeEmbed.GitHub
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHub.Models;

    public static class GitHubClientGistExtension
    {
        public static async Task<Gist> GetGist(
            this GitHubClient client,
            string id)
        {
            var uri = GitHubUri.Gist(client.BaseUri, id);

            var gist = await client.GetData<Gist>(uri).ConfigureAwait(false);

            return gist;
        }
    }
}