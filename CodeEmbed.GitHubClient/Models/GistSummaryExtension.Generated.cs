namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelExtension.tt", "1.0")]
    [DebuggerStepThrough]
    public static partial class GistSummaryExtension
    {
		public static GistSummary Wrap(
			this IGistSummary gistSummary,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistSummary != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistSummary>() != null);

			return new GistSummary(gistSummary, client);
		}

		public static async Task<GistSummary> Wrap(
			this Task<IGistSummary> gistSummary,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistSummary != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistSummary(await gistSummary.ConfigureAwait(false), client);
		}
	}
}
