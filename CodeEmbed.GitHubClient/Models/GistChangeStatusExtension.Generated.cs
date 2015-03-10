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
    public static partial class GistChangeStatusExtension
    {
		public static GistChangeStatus Wrap(
			this IGistChangeStatus gistChangeStatus,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistChangeStatus>() != null);

			return new GistChangeStatus(gistChangeStatus, client);
		}

		public static async Task<GistChangeStatus> Wrap(
			this Task<IGistChangeStatus> gistChangeStatus,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistChangeStatus != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistChangeStatus(await gistChangeStatus.ConfigureAwait(false), client);
		}
	}
}
