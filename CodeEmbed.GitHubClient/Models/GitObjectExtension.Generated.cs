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
    public static partial class GitObjectExtension
    {
		public static GitObject Wrap(
			this IGitObject gitObject,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gitObject != null);
			Contract.Requires<ArgumentNullException>(client != null);

			Contract.Ensures(Contract.Result<GitObject>() != null);

			return new GitObject(gitObject, client);
		}

		public static async Task<GitObject> Wrap(
			this Task<IGitObject> gitObject,
			IGitHubClient client)
		{
			Contract.Requires<ArgumentNullException>(gitObject != null);
			Contract.Requires<ArgumentNullException>(client != null);

			return new GitObject(await gitObject.ConfigureAwait(false), client);
		}
	}
}
