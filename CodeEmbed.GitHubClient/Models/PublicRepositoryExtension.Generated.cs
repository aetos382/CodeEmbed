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
    public static partial class PublicRepositoryExtension
    {
        public static PublicRepository Wrap(
            this IPublicRepository publicRepository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new PublicRepository(publicRepository, client);

            return wrapped;
        }

        public static async Task<PublicRepository> Wrap(
            this Task<IPublicRepository> publicRepository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await publicRepository.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<PublicRepository> GetPublicRepository(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IPublicRepository>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<PublicRepository> GetPublicRepository(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetPublicRepository(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
