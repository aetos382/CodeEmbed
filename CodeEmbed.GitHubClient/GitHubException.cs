namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;

    public class GitHubException :
        Exception
    {
        public GitHubException()
        {
        }

        public GitHubException(string message)
            : base(message)
        {
        }

        public GitHubException(
            string message,
            Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
