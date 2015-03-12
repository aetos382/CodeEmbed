namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelExtension.tt", "1.0")]
    [DebuggerStepThrough]
    public static partial class GistSummaryExtension
    {
        public static GistSummary Wrap(
            this IGistSummary gistSummary,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistSummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistSummary>() != null);

            return new GistSummary(gistSummary, client);
        }

        public static async Task<GistSummary> Wrap(
            this Task<IGistSummary> gistSummary,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistSummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new GistSummary(await gistSummary.ConfigureAwait(false), client);
        }

        public static async Task<GistSummary> GetGistSummary(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistSummary>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistSummary> GetGistSummary(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistSummary(client, uri, CancellationToken.None);

            return result;
        }
    }
}
