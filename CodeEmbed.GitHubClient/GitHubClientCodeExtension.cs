namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientCodeExtension
    {
        public static async Task<string> GetGitCode(
            this GitHubClient client,
            string user,
            string repository,
            string path)
        {
            var repo = await client.GetRepository(user, repository).ConfigureAwait(false);

            throw new NotImplementedException();
        }
    }
}
