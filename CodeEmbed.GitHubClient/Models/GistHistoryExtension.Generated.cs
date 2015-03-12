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
    public static partial class GistHistoryExtension
    {
        public static GistHistory Wrap(
            this IGistHistory gistHistory,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistHistory != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistHistory>() != null);

            return new GistHistory(gistHistory, client);
        }

        public static async Task<GistHistory> Wrap(
            this Task<IGistHistory> gistHistory,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistHistory != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new GistHistory(await gistHistory.ConfigureAwait(false), client);
        }

        public static async Task<GistHistory> GetGistHistory(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistHistory>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistHistory> GetGistHistory(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistHistory(client, uri, CancellationToken.None);

            return result;
        }
    }
}
