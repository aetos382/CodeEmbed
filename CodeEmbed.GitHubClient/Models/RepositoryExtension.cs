namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;

    public static partial class RepositoryExtension
    {
        public static Task<GitReference> GetDefaultBranchReference(
            this Repository repository)
        {
            Contract.Requires<ArgumentNullException>(repository != null);

            var result = repository.GetBranchReference(repository.DefaultBranch);

            return result;
        }
    }
}
