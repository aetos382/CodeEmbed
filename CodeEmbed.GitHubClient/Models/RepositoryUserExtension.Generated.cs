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
    public static partial class RepositoryUserExtension
    {
        public static RepositoryUser Wrap(
            this IRepositoryUser repositoryUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new RepositoryUser(repositoryUser, client);

            return wrapped;
        }

        public static async Task<RepositoryUser> Wrap(
            this Task<IRepositoryUser> repositoryUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await repositoryUser.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<RepositoryUser> GetRepositoryUser(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IRepositoryUser>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<RepositoryUser> GetRepositoryUser(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetRepositoryUser(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
