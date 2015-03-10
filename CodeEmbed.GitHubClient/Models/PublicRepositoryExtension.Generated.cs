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
    public static partial class PublicRepositoryExtension
    {
		public static PublicRepository Wrap(
			this IPublicRepository publicRepository,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(publicRepository != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<PublicRepository>() != null);

			return new PublicRepository(publicRepository, client);
		}

		public static async Task<PublicRepository> Wrap(
			this Task<IPublicRepository> publicRepository,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(publicRepository != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new PublicRepository(await publicRepository.ConfigureAwait(false), client);
		}
	}
}
