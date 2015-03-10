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
    public static partial class GistFileContentExtension
    {
		public static GistFileContent Wrap(
			this IGistFileContent gistFileContent,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFileContent != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistFileContent>() != null);

			return new GistFileContent(gistFileContent, client);
		}

		public static async Task<GistFileContent> Wrap(
			this Task<IGistFileContent> gistFileContent,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFileContent != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistFileContent(await gistFileContent.ConfigureAwait(false), client);
		}
	}
}
