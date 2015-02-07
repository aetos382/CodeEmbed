namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class RepositoryExtension
    {
        public static Task<Branch> GetBranch(
            this Repository repository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var result = repository.Client.GetBranch(repository.FullName, branch);

            return result;
        }

        public static Task<Branch> GetDefaultBranch(
            this Repository repository)
        {
            Contract.Requires<ArgumentNullException>(repository != null);

            var result = GetBranch(repository, repository.DefaultBranch);
            return result;
        }
    }
}
