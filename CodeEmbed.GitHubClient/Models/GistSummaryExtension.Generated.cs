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
    public static partial class GistSummaryExtension
    {
        public static GistSummary Wrap(
            this IGistSummary gistSummary,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistSummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistSummary>() != null);

            var wrapped = new GistSummary(gistSummary, client);

            return wrapped;
        }

        public static async Task<GistSummary> Wrap(
            this Task<IGistSummary> gistSummary,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistSummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<GistSummary>>() != null);

            var wrapped = Wrap(await gistSummary.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistSummary> GetGistSummary(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GistSummary>>() != null);

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

            Contract.Ensures(Contract.Result<Task<GistSummary>>() != null);

            var result = GetGistSummary(client, uri, CancellationToken.None);

            return result;
        }
    }
}
