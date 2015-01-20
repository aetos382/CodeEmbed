namespace CodeEmbed.Web.Api
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.Web.Api.Properties;

    using Octokit;
    using Octokit.Internal;

    public static class GitHubUtility
    {
        public static IGitHubClient GetClient()
        {
            string userAgent = Settings.Default.UserAgent;
            string accessToken = Settings.Default.AccessToken;

            var credentialStore = new InMemoryCredentialStore(new Credentials(accessToken));

            var client = new GitHubClient(
                new ProductHeaderValue(userAgent), credentialStore);

            return client;
        }
    }
}
