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
    public static partial class GistFileExtension
    {
        public static GistFile Wrap(
            this IGistFile gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new GistFile(gistFile, client);

            return wrapped;
        }

        public static async Task<GistFile> Wrap(
            this Task<IGistFile> gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await gistFile.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistFile> GetGistFile(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistFile>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistFile> GetGistFile(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistFile(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
