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
    public static partial class GitObjectExtension
    {
        public static GitObject Wrap(
            this IGitObject gitObject,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitObject != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitObject(gitObject, client);

            return wrapped;
        }

        public static async Task<GitObject> Wrap(
            this Task<IGitObject> gitObject,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitObject != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitObject.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitObject> GetGitObject(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitObject>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitObject> GetGitObject(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitObject(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
