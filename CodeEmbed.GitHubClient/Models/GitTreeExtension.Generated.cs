namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelExtension.tt", "1.0")]
    [DebuggerStepThrough]
    public static partial class GitTreeExtension
    {
        public static GitTree Wrap(
            this IGitTree gitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTree != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitTree(gitTree, client);

            return wrapped;
        }

        public static async Task<GitTree> Wrap(
            this Task<IGitTree> gitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTree != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitTree.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitTree> GetGitTree(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitTree>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitTree> GetGitTree(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitTree(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
