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
    public static partial class RepositoryExtension
    {
		public static Repository Wrap(
			this IRepository repository,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(repository != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<Repository>() != null);

			return new Repository(repository, client);
		}

		public static async Task<Repository> Wrap(
			this Task<IRepository> repository,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(repository != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new Repository(await repository.ConfigureAwait(false), client);
		}
	}
}
