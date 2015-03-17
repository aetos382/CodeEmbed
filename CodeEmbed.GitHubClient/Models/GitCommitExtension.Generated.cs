namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelExtension.tt", "1.0")]
    [DebuggerStepThrough]
    public static partial class GitCommitExtension
    {
        public static GitCommit Wrap(
            this IGitCommit gitCommit,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitCommit != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitCommit(gitCommit, client);

            return wrapped;
        }

        public static async Task<GitCommit> Wrap(
            this Task<IGitCommit> gitCommit,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitCommit != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitCommit.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitCommit> GetGitCommit(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitCommit>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitCommit> GetGitCommit(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitCommit(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
