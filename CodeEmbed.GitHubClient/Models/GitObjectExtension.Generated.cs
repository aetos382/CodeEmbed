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
    public static partial class GitObjectExtension
    {
        public static GitObject Wrap(
            this IGitObject gitObject,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitObject != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GitObject>() != null);

            return new GitObject(gitObject, client);
        }

        public static async Task<GitObject> Wrap(
            this Task<IGitObject> gitObject,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitObject != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new GitObject(await gitObject.ConfigureAwait(false), client);
        }

        public static async Task<GitObject> GetGitObject(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitObject>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitObject> GetGitObject(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitObject(client, uri, CancellationToken.None);

            return result;
        }
    }
}
