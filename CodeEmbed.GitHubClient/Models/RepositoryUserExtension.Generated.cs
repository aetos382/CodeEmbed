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
    public static partial class RepositoryUserExtension
    {
        public static RepositoryUser Wrap(
            this IRepositoryUser repositoryUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<RepositoryUser>() != null);

            return new RepositoryUser(repositoryUser, client);
        }

        public static async Task<RepositoryUser> Wrap(
            this Task<IRepositoryUser> repositoryUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(repositoryUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<RepositoryUser>>() != null);

            return new RepositoryUser(await repositoryUser.ConfigureAwait(false), client);
        }

        public static async Task<RepositoryUser> GetRepositoryUser(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<RepositoryUser>>() != null);

            var result = await client.GetData<IRepositoryUser>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<RepositoryUser> GetRepositoryUser(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<RepositoryUser>>() != null);

            var result = GetRepositoryUser(client, uri, CancellationToken.None);

            return result;
        }
    }
}
