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
    public static partial class GitTagExtension
    {
        public static GitTag Wrap(
            this IGitTag gitTag,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTag != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GitTag(gitTag, client);

            return wrapped;
        }

        public static async Task<GitTag> Wrap(
            this Task<IGitTag> gitTag,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gitTag != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gitTag.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GitTag> GetGitTag(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGitTag>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GitTag> GetGitTag(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGitTag(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
