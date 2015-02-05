namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;

    public static class GitHubUri
    {
        public static Uri Repository(
            Uri baseUri,
            string user,
            string repository)
        {
            var uri = new Uri(baseUri, string.Format("repos/{0}/{1}", user, repository));
            return uri;
        }

        public static Uri RepositoryCommits(
            Uri baseUri,
            string user,
            string repository)
        {
            var uri = new Uri(baseUri, string.Format("repos/{0}/{1}/commits", user, repository));
            return uri;
        }

        public static Uri Gist(
            Uri baseUri,
            string id)
        {
            var uri = new Uri(baseUri, string.Format("gists/{0}", id));
            return uri;
        }
    }
}
