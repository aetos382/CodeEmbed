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
    public static partial class GistForkExtension
    {
        public static GistFork Wrap(
            this IGistFork gistFork,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFork != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistFork>() != null);

            var wrapped = new GistFork(gistFork, client);

            return wrapped;
        }

        public static async Task<GistFork> Wrap(
            this Task<IGistFork> gistFork,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFork != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<GistFork>>() != null);

            var wrapped = Wrap(await gistFork.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistFork> GetGistFork(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GistFork>>() != null);

            var result = await client.GetData<IGistFork>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistFork> GetGistFork(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GistFork>>() != null);

            var result = GetGistFork(client, uri, CancellationToken.None);

            return result;
        }
    }
}
