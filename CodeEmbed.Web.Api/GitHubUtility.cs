namespace CodeEmbed.Web.Api
{
    using System;
    using System.Configuration;
    using System.Linq;

    using Octokit;
    using Octokit.Internal;

    public static class GitHubUtility
    {
        public static IGitHubClient GetClient()
        {
            string userAgent = ConfigurationManager.AppSettings["UserAgent"];
            string accessToken = ConfigurationManager.AppSettings["OAuthToken"];

            var credentialStore = new InMemoryCredentialStore(new Credentials(accessToken));

            var client = new GitHubClient(
                new ProductHeaderValue(userAgent), credentialStore);

            return client;
        }
    }
}
