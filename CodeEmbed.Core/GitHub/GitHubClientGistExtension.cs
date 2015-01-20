namespace CodeEmbed.Core.GitHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Core.GitHub.Models;

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
