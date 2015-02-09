namespace CodeEmbed.Web.Api
{
    using System;
    using System.Configuration;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using Octokit;
    using Octokit.Internal;

    public static class GitHubUtility
    {
        public static IGitHubClient GetClient()
        {
            Contract.Ensures(Contract.Result<IGitHubClient>() != null);

            string userAgent = ConfigurationManager.AppSettings["UserAgent"] ?? "CodeEmbed.v1";
            string accessToken = ConfigurationManager.AppSettings["OAuthToken"];

            if (accessToken == null)
            {
                // TODO: Use derived exception.
                throw new InvalidOperationException();
            }

            var credentialStore = new InMemoryCredentialStore(new Credentials(accessToken));

            var client = new GitHubClient(
                new ProductHeaderValue(userAgent), credentialStore);

            return client;
        }
    }
}
