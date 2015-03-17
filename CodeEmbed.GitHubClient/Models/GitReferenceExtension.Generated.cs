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
    public static partial class GitReferenceExtension
    {
        public static GitReference Wrap(
            this IGitReference gitReference,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitReference != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitReference(gitReference, client);

            return wrapped;
        }

        public static async Task<GitReference> Wrap(
            this Task<IGitReference> gitReference,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitReference != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitReference.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitReference> GetGitReference(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitReference>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitReference> GetGitReference(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitReference(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
