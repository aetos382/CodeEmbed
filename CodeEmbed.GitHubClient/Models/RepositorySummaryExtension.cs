namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class RepositorySummaryExtension
    {
        public static Task<IBranch> GetBranch(
            this RepositorySummary repositorySummary,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(repositorySummary != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.Branch(repositorySummary.Owner.Login, repositorySummary.Name, branch);
            var result = repositorySummary.Client.GetData<IBranch>(relUri);

            return result;
        }
    }
}
