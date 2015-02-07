﻿namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientGistExtension
    {
        public static async Task<Gist> GetGist(
            this GitHubClient client,
            string id)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(id != null);

            var relUriString = string.Format(CultureInfo.InvariantCulture, "/gists/{0}", id);
            var relUri = new Uri(relUriString, UriKind.Relative);

            try
            {
                var gist = await client.GetData<Gist>(relUri).ConfigureAwait(false);
                return gist;
            }
            catch (GitHubNotFoundException ex)
            {
                throw new GistNotFoundException(id, null, null, ex);
            }
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

            var gist = await GetGist(client, id).ConfigureAwait(false);

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
