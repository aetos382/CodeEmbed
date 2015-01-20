namespace CodeEmbed.Core.GitHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Core.GitHub.Models;

    public class RepositoryClient
    {
        private readonly GitHubClient _client;

        internal RepositoryClient(GitHubClient client)
        {
            this._client = client;
        }

        public async Task<Repository> GetRepository(
            string user,
            string repository)
        {
            var uri = GitHubUri.Repository(this._client.BaseUri, user, repository);

            var result = await this._client.GetData<Repository>(uri).ConfigureAwait(false);

            return result;
        }
    }
}
