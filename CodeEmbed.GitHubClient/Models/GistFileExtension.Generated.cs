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

            var wrapped = new GistFile(gistFile, client);

            return wrapped;
        }

        public static async Task<GistFile> Wrap(
            this Task<IGistFile> gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<GistFile>>() != null);

            var wrapped = Wrap(await gistFile.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<GistFile> GetGistFile(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<GistFile>>() != null);

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

            Contract.Ensures(Contract.Result<Task<GistFile>>() != null);

            var result = GetGistFile(client, uri, CancellationToken.None);

            return result;
        }
    }
}
