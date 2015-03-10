﻿namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
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

            var result = client.GetData<T>(uri, CancellationToken.None);
            return result;
        }

        public static Task<string> GetString(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = client.GetString(uri, CancellationToken.None);
            return result;
        }

        public static Task<string> GetString(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = client.Connection.GetString(uri, cancellationToken);
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
            var result = await client.GetData<IRepository>(relUri).Wrap(client).ConfigureAwait(false);

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
            var result = await client.GetData<IGitReference>(relUri).Wrap(client).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitReference> GetGitBranch(
            this IGitHubClient client,
            string user,
            string repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.GitBranch(user, repository, branch);
            var result = await client.GetData<IGitReference>(relUri).Wrap(client).ConfigureAwait(false);

            return result;
        }

        public static async Task<GitReference> GetGitTag(
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
            var result = await client.GetData<IGitReference>(relUri).Wrap(client).ConfigureAwait(false);

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
                var result = await client.GetData<IGist>(relUri).Wrap(client).ConfigureAwait(false);

                return result;
            }
            catch (GitHubNotFoundException ex)
            {
                throw new GistNotFoundException(id, null, null, ex);
            }
        }
    }
}
