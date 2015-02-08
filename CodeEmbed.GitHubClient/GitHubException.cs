namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;

    [Serializable]
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

        protected GitHubException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
