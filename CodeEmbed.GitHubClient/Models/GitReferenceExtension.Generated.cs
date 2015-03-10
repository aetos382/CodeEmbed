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
    public static partial class GitReferenceExtension
    {
		public static GitReference Wrap(
			this IGitReference gitReference,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gitReference != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GitReference>() != null);

			return new GitReference(gitReference, client);
		}

		public static async Task<GitReference> Wrap(
			this Task<IGitReference> gitReference,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gitReference != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GitReference(await gitReference.ConfigureAwait(false), client);
		}
	}
}
