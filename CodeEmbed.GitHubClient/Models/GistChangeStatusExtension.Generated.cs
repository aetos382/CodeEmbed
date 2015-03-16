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

            var wrapped = new GistChangeStatus(gistChangeStatus, client);

            return wrapped;
        }

        public static async Task<GistChangeStatus> Wrap(
            this Task<IGistChangeStatus> gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<GistChangeStatus>>() != null);

            var wrapped = Wrap(await gistChangeStatus.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistChangeStatus> GetGistChangeStatus(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GistChangeStatus>>() != null);

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

            Contract.Ensures(Contract.Result<Task<GistChangeStatus>>() != null);

            var result = GetGistChangeStatus(client, uri, CancellationToken.None);

            return result;
        }
    }
}
