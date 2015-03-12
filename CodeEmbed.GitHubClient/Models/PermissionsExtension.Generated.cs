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
    public static partial class PermissionsExtension
    {
        public static Permissions Wrap(
            this IPermissions permissions,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(permissions != null);
            Contract.Requires<ArgumentNullException>(client != null);

            Contract.Ensures(Contract.Result<Permissions>() != null);

            return new Permissions(permissions, client);
        }

        public static async Task<Permissions> Wrap(
            this Task<IPermissions> permissions,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(permissions != null);
            Contract.Requires<ArgumentNullException>(client != null);

            return new Permissions(await permissions.ConfigureAwait(false), client);
        }

        public static async Task<Permissions> GetPermissions(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IPermissions>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<Permissions> GetPermissions(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetPermissions(client, uri, CancellationToken.None);

            return result;
        }
    }
}
