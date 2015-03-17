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
    public static partial class GistFileContentExtension
    {
        public static GistFileContent Wrap(
            this IGistFileContent gistFileContent,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFileContent != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GistFileContent(gistFileContent, client);

            return wrapped;
        }

        public static async Task<GistFileContent> Wrap(
            this Task<IGistFileContent> gistFileContent,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFileContent != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gistFileContent.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistFileContent> GetGistFileContent(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistFileContent>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistFileContent> GetGistFileContent(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistFileContent(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
