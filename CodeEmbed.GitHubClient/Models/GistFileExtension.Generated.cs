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
    public static partial class GistFileExtension
    {
        public static GistFile Wrap(
            this IGistFile gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<GistFile>() != null);

            return new GistFile(gistFile, client);
        }

        public static async Task<GistFile> Wrap(
            this Task<IGistFile> gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new GistFile(await gistFile.ConfigureAwait(false), client);
        }

        public static async Task<GistFile> GetGistFile(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IGistFile>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<GistFile> GetGistFile(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetGistFile(client, uri, CancellationToken.None);

            return result;
        }
    }
}
