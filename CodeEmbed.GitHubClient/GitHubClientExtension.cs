namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.GitHubClient.Network;

    public static class GitHubClientExtension
    {
        public static Task<T> GetData<T>(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = client.GetData<T>(uri, null, null, CancellationToken.None);
            return result;
        }

        public static Task<string> GetString(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetString(client, uri, null, null, CancellationToken.None);
            return result;
        }

        public static Task<string> GetString(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = client.Connection.GetString(uri, requestHeaders, responseEncoding, cancellationToken);
            return result;
        }

        public static async Task<Repository> GetRepository(
            this IGitHubClient client,
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            var relUri = GitHubUri.Repository(user, repository);
            var result = await client.GetRepository(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitReference> GetGitReference(
            this IGitHubClient client,
            string user,
            string repository,
            string reference)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(reference != null);

            var relUri = GitHubUri.GitReference(user, repository, reference);
            var result = await client.GetGitReference(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitReference> GetGitBranchReference(
            this IGitHubClient client,
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.GitBranchReferenece(user, repository, branch);
            var result = await client.GetGitReference(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitReference> GetGitTagReference(
            this IGitHubClient client,
            string user,
            string repository,
            string tag)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);

            var relUri = GitHubUri.GitTagReference(user, repository, tag);
            var result = await client.GetGitReference(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitTag> GetGitTag(
            this IGitHubClient client,
            string user,
            string repository,
            string tag)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tag != null);

            var relUri = GitHubUri.GitTag(user, repository, tag);
            var result = await client.GetGitTag(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitCommit> GetGitCommit(
            this IGitHubClient client,
            string user,
            string repository,
            string commit)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(commit != null);

            var relUri = GitHubUri.GitCommit(user, repository, commit);
            var result = await client.GetGitCommit(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitBlob> GetGitBlob(
            this IGitHubClient client,
            string user,
            string repository,
            string blob)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(blob != null);

            var relUri = GitHubUri.GitBlob(user, repository, blob);
            var result = await client.GetGitBlob(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitTree> GetGitTree(
            this IGitHubClient client,
            string user,
            string repository,
            string tree,
            bool recursive)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(tree != null);

            var relUri = GitHubUri.GitTree(user, repository, tree, recursive);
            var result = await client.GetGitTree(relUri).ConfigureAwait(false);

            return result;
        }

        public static async Task<Gist> GetGist(
            this IGitHubClient client,
            string id)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(id != null);

            var relUri = GitHubUri.Gist(id);

            try
            {
                var result = await client.GetGist(relUri).ConfigureAwait(false);

                return result;
            }
            catch (GitHubNotFoundException ex)
            {
                throw new GistNotFoundException(id, null, null, ex);
            }
        }
    }
}
