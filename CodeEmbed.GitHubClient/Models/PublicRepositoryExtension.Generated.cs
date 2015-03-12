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
    public static partial class PublicRepositoryExtension
    {
        public static PublicRepository Wrap(
            this IPublicRepository publicRepository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<PublicRepository>() != null);

            return new PublicRepository(publicRepository, client);
        }

        public static async Task<PublicRepository> Wrap(
            this Task<IPublicRepository> publicRepository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<PublicRepository>>() != null);

            return new PublicRepository(await publicRepository.ConfigureAwait(false), client);
        }

        public static async Task<PublicRepository> GetPublicRepository(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<PublicRepository>>() != null);

            var result = await client.GetData<IPublicRepository>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<PublicRepository> GetPublicRepository(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<PublicRepository>>() != null);

            var result = GetPublicRepository(client, uri, CancellationToken.None);

            return result;
        }
    }
}
