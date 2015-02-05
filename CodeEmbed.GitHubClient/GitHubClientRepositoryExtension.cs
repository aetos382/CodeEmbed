namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientRepositoryExtension
    {
        public static async Task<Repository> GetRepository(
            this GitHubClient client,
            string user,
            string repository)
        {
            var uri = GitHubUri.Repository(client.BaseUri, user, repository);

            var result = await client.GetData<Repository>(uri).ConfigureAwait(false);

            return result;
        }
    }
}
