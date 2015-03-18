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
    public static partial class CommitLinkExtension
    {
        public static CommitLink Wrap(
            this ICommitLink commitLink,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitLink != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new CommitLink(commitLink, client);

            return wrapped;
        }

        public static async Task<CommitLink> Wrap(
            this Task<ICommitLink> commitLink,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitLink != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await commitLink.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<CommitLink> GetCommitLink(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<ICommitLink>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<CommitLink> GetCommitLink(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetCommitLink(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
