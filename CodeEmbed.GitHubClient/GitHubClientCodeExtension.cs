namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.GitHubClient.Models.Internal;

    public static class GitHubClientCodeExtension
    {
        public static async Task<string> GetGitCode(
            this GitHubClient client,
            string user,
            string repository,
            string path)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(path != null);

            var repo = await client.GetRepository(user, repository).ConfigureAwait(false);

            var result = await GetGitCodeFromBranch(client, user, repository, repo.DefaultBranch, path).ConfigureAwait(false);

            return result;
        }

        public static async Task<string> GetGitCodeFromBranch(
            this GitHubClient client,
            string user,
            string repository,
            string branch,
            string path)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);
            Contract.Requires<ArgumentNullException>(path != null);

            var bra = await client.GetBranch(user, repository, branch).ConfigureAwait(false);

            var result = await GetGitCodeFromCommit(client, user, repository, bra.Commit.Hash, path).ConfigureAwait(false);

            return result;
        }

        public static async Task<string> GetGitCodeFromTag(
            this GitHubClient client,
            string user,
            string repository,
            string tag,
            string path)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);
            Contract.Requires<ArgumentNullException>(path != null);

            var repo = await client.GetRepository(user, repository).ConfigureAwait(false);

            throw new NotImplementedException();
        }

        public static async Task<string> GetGitCodeFromCommit(
            this GitHubClient client,
            string user,
            string repository,
            string commit,
            string path)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(commit != null);
            Contract.Requires<ArgumentNullException>(path != null);

            var repo = await client.GetRepository(user, repository).ConfigureAwait(false);

            throw new NotImplementedException();
        }

        public static Task<string> GetGistCode(
            this GitHubClient client,
            string id,
            string fileName)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(id != null);
            Contract.Requires<ArgumentNullException>(fileName != null);

            var task = GetGistCode(client, id, null, fileName);
            return task;
        }

        public static async Task<string> GetGistCode(
            this GitHubClient client,
            string id,
            string version,
            string fileName)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(id != null);
            Contract.Requires<ArgumentNullException>(fileName != null);

            var gist = await client.GetGist(id).ConfigureAwait(false);

            if (version != null)
            {
                var history = gist.Histories.SingleOrDefault(x => x.Version == version);
                if (history == null)
                {
                    throw new GistNotFoundException(id, version, fileName);
                }

                gist = await client.GetData<Gist>(history.Uri).ConfigureAwait(false);
            }

            GistFile file;
            if (!gist.Files.TryGetValue(fileName, out file))
            {
                throw new GistNotFoundException(id, version, fileName);
            }

            string result = file.Content;

            if (file.Truncated)
            {
                result = await client.GetString(file.RawUri).ConfigureAwait(false);
            }

            return result;
        }
    }
}
