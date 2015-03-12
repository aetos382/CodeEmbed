namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
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

            Contract.Ensures(Contract.Result<GitReference>() != null);

            return new GitReference(gitReference, client);
        }

        public static async Task<GitReference> Wrap(
            this Task<IGitReference> gitReference,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitReference != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<GitReference>>() != null);

            return new GitReference(await gitReference.ConfigureAwait(false), client);
        }

        public static async Task<GitReference> GetGitReference(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GitReference>>() != null);

            var result = await client.GetData<IGitReference>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitReference> GetGitReference(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GitReference>>() != null);

            var result = GetGitReference(client, uri, CancellationToken.None);

            return result;
        }
    }
}
