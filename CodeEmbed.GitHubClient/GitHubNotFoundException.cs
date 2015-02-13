namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Text;

    [Serializable]
    public class GitHubNotFoundException :
        GitHubException
    {
        private const string DefaultMessage = "リソースが見つかりません。";

        [ContractPublicPropertyName("ResourceUri")]
        private readonly Uri _resourceUri;

        public GitHubNotFoundException()
            : base(BuildMessage())
        {
        }

        public GitHubNotFoundException(string message)
            : base(BuildMessage(message: message))
        {
        }

        public GitHubNotFoundException(
            string message,
            Exception innerException)
            : base(BuildMessage(message: message), innerException)
        {
        }

        public GitHubNotFoundException(Uri resourceUri)
            : base(BuildMessage(resourceUri))
        {
            this._resourceUri = resourceUri;
        }

        public GitHubNotFoundException(Uri resourceUri, string message)
            : base(BuildMessage(resourceUri, message))
        {
            this._resourceUri = resourceUri;
        }

        public GitHubNotFoundException(
            Uri resourceUri,
            Exception innerException)
            : base(BuildMessage(resourceUri), innerException)
        {
            this._resourceUri = resourceUri;
        }

        public GitHubNotFoundException(
            Uri resourceUri,
            string message,
            Exception innerException)
            : base(BuildMessage(resourceUri, message), innerException)
        {
            this._resourceUri = resourceUri;
        }

        protected GitHubNotFoundException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            this._resourceUri = (Uri)serializationInfo.GetValue("ResourceUri", typeof(Uri));
        }

        public Uri ResourceUri
        {
            [Pure]
            get
            {
                return this._resourceUri;
            }
        }

        public override void GetObjectData(
            SerializationInfo info,
            StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("ResourceUri", this._resourceUri);
        }

        private static string BuildMessage(
            Uri resourceUri = null,
            string message = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);

            var builder = new StringBuilder(DefaultMessage);

            if (resourceUri != null)
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, "：Uri = {0}", resourceUri);
            }

            if (message != null)
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, "：{0}", message);
            }

            return builder.ToString();
        }
    }
}
