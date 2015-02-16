namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientExtension
    {
        public static Task<IRepository> GetRepository(
            this GitHubClient client,
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            var relUri = GitHubUri.Repository(user, repository);
            var result = client.GetData<IRepository>(relUri);

            return result;
        }

        public static Task<IBranch> GetBranch(
            this GitHubClient client,
            string repositoryFullName,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(repositoryFullName != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.Branch(repositoryFullName, branch);
            var result = client.GetData<IBranch>(relUri);

            return result;
        }

        public static Task<IBranch> GetBranch(
            this GitHubClient client,
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.Branch(user, repository, branch);
            var result = client.GetData<IBranch>(relUri);

            return result;
        }

        public static Task<IGitReference> GetGitReference(
            this GitHubClient client,
            string user,
            string repository,
            string reference)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(reference != null);

            var relUri = GitHubUri.GitReference(user, repository, reference);
            var result = client.GetData<IGitReference>(relUri);

            return result;
        }

        public static Task<IGitReference> GetGitBranch(
            this GitHubClient client,
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.GitBranch(user, repository, branch);
            var result = client.GetData<IGitReference>(relUri);

            return result;
        }

        public static Task<IGitReference> GetGitTag(
            this GitHubClient client,
            string user,
            string repository,
            string tag)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);

            var relUri = GitHubUri.GitTag(user, repository, tag);
            var result = client.GetData<IGitReference>(relUri);

            return result;
        }

        public static async Task<IGist> GetGist(
            this GitHubClient client,
            string id)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(id != null);

            var relUri = GitHubUri.Gist(id);

            try
            {
                var result = await client.GetData<IGist>(relUri).ConfigureAwait(false);
                return result;
            }
            catch (GitHubNotFoundException ex)
            {
                throw new GistNotFoundException(id, null, null, ex);
            }
        }
    }
}
