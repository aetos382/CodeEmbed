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
    public static partial class AuthorizedUserExtension
    {
		public static AuthorizedUser Wrap(
			this IAuthorizedUser authorizedUser,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(authorizedUser != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<AuthorizedUser>() != null);

			return new AuthorizedUser(authorizedUser, client);
		}

		public static async Task<AuthorizedUser> Wrap(
			this Task<IAuthorizedUser> authorizedUser,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(authorizedUser != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new AuthorizedUser(await authorizedUser.ConfigureAwait(false), client);
		}
	}
}
