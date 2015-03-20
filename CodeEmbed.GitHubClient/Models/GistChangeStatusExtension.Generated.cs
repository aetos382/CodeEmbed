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
    public static partial class GistChangeStatusExtension
    {
        public static GistChangeStatus Wrap(
            this IGistChangeStatus gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GistChangeStatus(gistChangeStatus, client);

            return wrapped;
        }

        public static async Task<GistChangeStatus> Wrap(
            this Task<IGistChangeStatus> gistChangeStatus,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gistChangeStatus.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistChangeStatus> GetGistChangeStatus(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistChangeStatus>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistChangeStatus> GetGistChangeStatus(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistChangeStatus(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
