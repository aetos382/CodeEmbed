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
    public static partial class UserPlanExtension
    {
		public static UserPlan Wrap(
			this IUserPlan userPlan,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(userPlan != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<UserPlan>() != null);

			return new UserPlan(userPlan, client);
		}

		public static async Task<UserPlan> Wrap(
			this Task<IUserPlan> userPlan,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(userPlan != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new UserPlan(await userPlan.ConfigureAwait(false), client);
		}
	}
}
