namespace CodeEmbed.GitHub
{
    using System;
    using System.Linq;

    public class GitHubException :
        Exception
    {
        public GitHubException()
            : base()
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
