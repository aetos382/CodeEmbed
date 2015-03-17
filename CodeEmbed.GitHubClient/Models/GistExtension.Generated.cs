namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Text;
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

            var wrapped = new Gist(gist, client);

            return wrapped;
        }

        public static async Task<Gist> Wrap(
            this Task<IGist> gist,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gist != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gist.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<Gist> GetGist(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGist>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<Gist> GetGist(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGist(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
