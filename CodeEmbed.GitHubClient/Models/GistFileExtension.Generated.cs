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
    public static partial class GistFileExtension
    {
		public static GistFile Wrap(
			this IGistFile gistFile,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFile != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GistFile>() != null);

			return new GistFile(gistFile, client);
		}

		public static async Task<GistFile> Wrap(
			this Task<IGistFile> gistFile,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gistFile != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GistFile(await gistFile.ConfigureAwait(false), client);
		}
	}
}
