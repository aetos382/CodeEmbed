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
    public static partial class UserExtension
    {
		public static User Wrap(
			this IUser user,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(user != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<User>() != null);

			return new User(user, client);
		}

		public static async Task<User> Wrap(
			this Task<IUser> user,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(user != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new User(await user.ConfigureAwait(false), client);
		}
	}
}
