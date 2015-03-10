namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
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
	}
}
