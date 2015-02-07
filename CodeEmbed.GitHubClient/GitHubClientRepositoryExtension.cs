namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    public static class GitHubClientRepositoryExtension
    {
        public static Task<Repository> GetRepository(
            this GitHubClient client,
            string user,
            string repository)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(user != null);
            Contract.Requires<ArgumentNullException>(repository != null);

            string relUriString = string.Format(CultureInfo.InvariantCulture, "/repos/{0}/{1}", user, repository);
            var relUri = new Uri(relUriString, UriKind.Relative);

            return client.GetData<Repository>(relUri);
        }
    }
}
