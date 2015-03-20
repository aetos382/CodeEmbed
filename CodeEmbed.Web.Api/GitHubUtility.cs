namespace CodeEmbed.Web.Api
{
    using System;
    using System.Configuration;
    using System.Linq;

    using CodeEmbed.GitHubClient;

    public static class GitHubUtility
    {
        public static IGitHubClient GetClient()
        {
            string userAgent = ConfigurationManager.AppSettings["UserAgent"] ?? "CodeEmbed.v1";
            string accessToken = ConfigurationManager.AppSettings["OAuthToken"];

            if (accessToken == null)
            {
                // TODO: Use derived exception.
                throw new InvalidOperationException();
            }

            var client = new GitHubClient(userAgent, accessToken);

            return client;
        }
    }
}
