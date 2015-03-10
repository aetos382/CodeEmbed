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
    public static partial class GistForkExtension
    {
		public static GistFork Wrap(
			this IGistFork gistFork,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFork != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistFork>() != null);

			return new GistFork(gistFork, client);
		}

		public static async Task<GistFork> Wrap(
			this Task<IGistFork> gistFork,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFork != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistFork(await gistFork.ConfigureAwait(false), client);
		}
	}
}
