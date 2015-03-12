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

        public static async Task<UserPlan> GetUserPlan(
            this IGitHubClient client,
            Uri uri,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<IUserPlan>(uri, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<UserPlan> GetUserPlan(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetUserPlan(client, uri, CancellationToken.None);

            return result;
        }
    }
}
