namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class GitHubUri
    {
        public static Uri Repository(
            string user,
            string repository)
        {
            string relUriString = string.Format(CultureInfo.InvariantCulture, "/repos/{0}/{1}", user, repository);
            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri Branch(
            string user,
            string repository,
            string branch)
        {
            string relUriString = string.Format(CultureInfo.InvariantCulture,
                "/repos/{0}/{1}/branches/{2}", user, repository, branch);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri Branch(
            string repositoryFullName,
            string branch)
        {
            string relUriString = string.Format(CultureInfo.InvariantCulture,
                "/repos/{0}/branches/{1}", repositoryFullName, branch);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }

        public static Uri Gist(
            string id)
        {
            string relUriString = string.Format(CultureInfo.InvariantCulture,
                "/gists/{0}", id);

            var relUri = new Uri(relUriString, UriKind.Relative);

            return relUri;
        }
    }
}
