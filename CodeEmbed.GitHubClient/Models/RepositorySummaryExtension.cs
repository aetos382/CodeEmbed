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
            this PublicRepository publicRepository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.Branch(publicRepository.Owner.Login, publicRepository.Name, branch);
            var result = publicRepository.Client.GetData<IBranch>(relUri);

            return result;
        }
    }
}
