namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;

    public static class RepositoryExtension
    {
        public static Task<IBranch> GetDefaultBranch(
            this Repository repository)
        {
            Contract.Requires<ArgumentNullException>(repository != null);

            var result = repository.GetBranch(repository.DefaultBranch);
            return result;
        }
    }
}
