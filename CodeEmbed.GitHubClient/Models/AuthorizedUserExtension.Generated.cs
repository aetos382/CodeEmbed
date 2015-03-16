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
    public static partial class AuthorizedUserExtension
    {
        public static AuthorizedUser Wrap(
            this IAuthorizedUser authorizedUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(authorizedUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<AuthorizedUser>() != null);

            var wrapped = new AuthorizedUser(authorizedUser, client);

            return wrapped;
        }

        public static async Task<AuthorizedUser> Wrap(
            this Task<IAuthorizedUser> authorizedUser,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(authorizedUser != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Task<AuthorizedUser>>() != null);

            var wrapped = Wrap(await authorizedUser.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<AuthorizedUser> GetAuthorizedUser(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<AuthorizedUser>>() != null);

            var result = await client.GetData<IAuthorizedUser>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<AuthorizedUser> GetAuthorizedUser(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            Contract.Ensures(Contract.Result<Task<AuthorizedUser>>() != null);

            var result = GetAuthorizedUser(client, uri, CancellationToken.None);

            return result;
        }
    }
}
