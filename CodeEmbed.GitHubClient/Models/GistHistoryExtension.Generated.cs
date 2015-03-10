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
    public static partial class GistHistoryExtension
    {
		public static GistHistory Wrap(
			this IGistHistory gistHistory,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistHistory != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistHistory>() != null);

			return new GistHistory(gistHistory, client);
		}

		public static async Task<GistHistory> Wrap(
			this Task<IGistHistory> gistHistory,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistHistory != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistHistory(await gistHistory.ConfigureAwait(false), client);
		}
	}
}
