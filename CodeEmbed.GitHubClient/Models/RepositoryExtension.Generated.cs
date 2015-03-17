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
    public static partial class RepositoryExtension
    {
        public static Repository Wrap(
            this IRepository repository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new Repository(repository, client);

            return wrapped;
        }

        public static async Task<Repository> Wrap(
            this Task<IRepository> repository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await repository.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<Repository> GetRepository(
            this IGitHubClient client,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IRepository>(uri, encoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<Repository> GetRepository(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetRepository(client, uri, null, CancellationToken.None);

            return result;
        }
    }
}
