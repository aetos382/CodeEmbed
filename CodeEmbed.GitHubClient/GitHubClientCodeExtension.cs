namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientCodeExtension
    {
        public static async Task<string> GetGitCode(
            this IGitHubClient client,
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
            this IGitHubClient client,
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

            var gitBranch = await client.GetGitBranch(user, repository, branch).ConfigureAwait(false);
            var result = await GetGitCodeFromCommit(client, user, repository, gitBranch.Target.Hash, path).ConfigureAwait(false);

            return result;
        }

        public static async Task<string> GetGitCodeFromTag(
            this IGitHubClient client,
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

            var gitTag = await client.GetGitTag(user, repository, tag).ConfigureAwait(false);
            var result = await GetGitCodeFromCommit(client, user, repository, gitTag.Target.Hash, path).ConfigureAwait(false);

            return result;
        }

        public static async Task<string> GetGitCodeFromCommit(
            this IGitHubClient client,
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

            string blobHash = null;

            var gitCommit = await client.GetGitCommit(user, repository, commit).ConfigureAwait(false);
            string treeHash = gitCommit.Tree.Hash;

            var pathComponents = path.Split('/');

            for (int i = 0; i < pathComponents.Length; ++i)
            {
                string pathRemaining = string.Join("/", pathComponents.Skip(i));

                var gitTree = await client.GetGitTree(user, repository, treeHash, true).ConfigureAwait(false);

                var matched = gitTree.Tree.SingleOrDefault(x => x.Path == pathRemaining);
                if (matched != null)
                {
                    if (matched.Type != "blob")
                    {
                        throw new NotSupportedException();
                    }

                    blobHash = matched.Hash;
                    break;
                }

                if (!gitTree.Truncated)
                {
                    throw new GitHubNotFoundException();
                }

                gitTree = await client.GetGitTree(user, repository, treeHash, false).ConfigureAwait(false);

                matched = gitTree.Tree.SingleOrDefault(x => x.Path == pathComponents[i]);
                if (matched != null)
                {
                    if (matched.Type == "blob")
                    {
                        if (i != pathComponents.Length - 1)
                        {
                            throw new GitHubNotFoundException();
                        }

                        blobHash = matched.Hash;
                        break;
                    }
                    else if (matched.Type == "tree")
                    {
                        treeHash = matched.Hash;
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
            }

            if (blobHash == null)
            {
                throw new GitHubNotFoundException();
            }

            var result = await GetGitCodeFromBlob(client, user, repository, blobHash).ConfigureAwait(false);
            return result;
        }

        public static async Task<string> GetGitCodeFromBlob(
            this IGitHubClient client,
            string user,
            string repository,
            string blob)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(blob != null);

            var gitBlob = await client.GetGitBlob(user, repository, blob).ConfigureAwait(false);

            Encoding encoding = null;

            try
            {
                encoding = Encoding.GetEncoding(gitBlob.Encoding);
            }
            catch
            {
            }

            string result = await client.GetString(gitBlob.Uri, encoding).ConfigureAwait(false);

            return result;
        }

        public static Task<string> GetGistCode(
            this IGitHubClient client,
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
            this IGitHubClient client,
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

                gist = await client.GetGist(history.Uri).ConfigureAwait(false);
            }

            GistFileContent file;
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
