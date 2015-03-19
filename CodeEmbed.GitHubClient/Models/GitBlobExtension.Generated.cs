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
    public static partial class GitBlobExtension
    {
        public static GitBlob Wrap(
            this IGitBlob gitBlob,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitBlob != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitBlob(gitBlob, client);

            return wrapped;
        }

        public static async Task<GitBlob> Wrap(
            this Task<IGitBlob> gitBlob,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitBlob != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitBlob.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitBlob> GetGitBlob(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitBlob>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitBlob> GetGitBlob(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitBlob(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
