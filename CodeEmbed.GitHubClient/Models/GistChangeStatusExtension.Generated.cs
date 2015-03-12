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
    public static partial class GistChangeStatusExtension
    {
        public static GistChangeStatus Wrap(
            this IGistChangeStatus gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistChangeStatus>() != null);

            return new GistChangeStatus(gistChangeStatus, client);
        }

        public static async Task<GistChangeStatus> Wrap(
            this Task<IGistChangeStatus> gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new GistChangeStatus(await gistChangeStatus.ConfigureAwait(false), client);
        }

        public static async Task<GistChangeStatus> GetGistChangeStatus(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistChangeStatus>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistChangeStatus> GetGistChangeStatus(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistChangeStatus(client, uri, CancellationToken.None);

            return result;
        }
    }
}
