namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static partial class PublicRepositoryExtension
    {
        public static async Task<GitReference> GetBranchReference(
            this PublicRepository publicRepository,
            string branch)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);
            Contract.Requires<ArgumentNullException>(branch != null);

            var relUri = GitHubUri.GitBranch(publicRepository.Owner.Login, publicRepository.Name, branch);

            var result = await publicRepository.Client.GetGitReference(relUri).ConfigureAwait(false);

            return result;
        }
    }
}
