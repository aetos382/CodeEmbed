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
    public static partial class GistExtension
    {
        public static Gist Wrap(
            this IGist gist,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gist != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Gist>() != null);

            return new Gist(gist, client);
        }

        public static async Task<Gist> Wrap(
            this Task<IGist> gist,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gist != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new Gist(await gist.ConfigureAwait(false), client);
        }

        public static async Task<Gist> GetGist(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGist>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<Gist> GetGist(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGist(client, uri, CancellationToken.None);

            return result;
        }
    }
}
