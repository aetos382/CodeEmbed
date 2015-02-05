namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientCodeExtension
    {
        public static Task<string> GetGistCode(
            this GitHubClient client,
            string id,
            string fileName)
        {
            return GetGistCode(client, id, null, fileName);
        }

        public static async Task<string> GetGistCode(
            this GitHubClient client,
            string id,
            string version,
            string fileName)
        {
            var gist = await client.GetGist(id).ConfigureAwait(false);

            if (version != null)
            {
                var history = gist.Histories.SingleOrDefault(x => x.Version == version);
                if (history == null)
                {
                    throw new GistFileNotFoundException(id, version, fileName);
                }

                gist = await client.GetData<Gist>(history.Uri).ConfigureAwait(false);
            }

            GistFile file;
            if (!gist.Files.TryGetValue(fileName, out file))
            {
                throw new GistFileNotFoundException(id, version, fileName);
            }

            string result = file.Content;

            if (file.Truncated)
            {
                result = await client.GetString(file.RawUri).ConfigureAwait(false);
            }

            return result;
        }

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
