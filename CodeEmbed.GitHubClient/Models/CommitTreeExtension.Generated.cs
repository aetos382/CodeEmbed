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
    public static partial class CommitTreeExtension
    {
        public static CommitTree Wrap(
            this ICommitTree commitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitTree != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new CommitTree(commitTree, client);

            return wrapped;
        }

        public static async Task<CommitTree> Wrap(
            this Task<ICommitTree> commitTree,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitTree != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await commitTree.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<CommitTree> GetCommitTree(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<ICommitTree>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<CommitTree> GetCommitTree(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetCommitTree(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
