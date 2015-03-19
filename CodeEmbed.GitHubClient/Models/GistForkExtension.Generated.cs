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
    public static partial class GistForkExtension
    {
        public static GistFork Wrap(
            this IGistFork gistFork,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFork != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GistFork(gistFork, client);

            return wrapped;
        }

        public static async Task<GistFork> Wrap(
            this Task<IGistFork> gistFork,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFork != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gistFork.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistFork> GetGistFork(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistFork>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistFork> GetGistFork(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistFork(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
