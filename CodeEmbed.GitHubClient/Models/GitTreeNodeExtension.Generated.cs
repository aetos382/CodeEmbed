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
    public static partial class GitTreeNodeExtension
    {
        public static GitTreeNode Wrap(
            this IGitTreeNode gitTreeNode,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTreeNode != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitTreeNode(gitTreeNode, client);

            return wrapped;
        }

        public static async Task<GitTreeNode> Wrap(
            this Task<IGitTreeNode> gitTreeNode,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTreeNode != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitTreeNode.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitTreeNode> GetGitTreeNode(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitTreeNode>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitTreeNode> GetGitTreeNode(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitTreeNode(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
