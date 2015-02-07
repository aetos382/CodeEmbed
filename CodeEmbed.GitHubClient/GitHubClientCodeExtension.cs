namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
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
