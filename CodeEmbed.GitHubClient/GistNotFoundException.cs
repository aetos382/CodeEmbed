namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    [Serializable]
    public class GistNotFoundException :
        GitHubNotFoundException
    {
        private const string DefaultMessage = "Gist ファイルが見つかりません。";

        [ContractPublicPropertyName("Id")]
        private readonly string _id;

        [ContractPublicPropertyName("Version")]
        private readonly string _version;

        [ContractPublicPropertyName("FileName")]
        private readonly string _fileName;

        public GistNotFoundException()
            : base(DefaultMessage)
        {
        }

        public GistNotFoundException(string message)
            : base(message)
        {
        }

        public GistNotFoundException(
            string message,
            Exception innerException)
            : base(GetUri(null, innerException), message, innerException)
        {
        }

        public GistNotFoundException(
            string id,
            string version = null,
            string fileName = null,
            Exception innerException = null)
            : base(GetUri(id, innerException), BuildMessage(id, version, fileName), innerException)
        {
            Contract.Requires<ArgumentNullException>(id != null);

            this._id = id;
            this._version = version;
            this._fileName = fileName;
        }

        protected GistNotFoundException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            this._id = serializationInfo.GetString("Id");
            this._version = serializationInfo.GetString("Version");
            this._fileName = serializationInfo.GetString("FileName");
        }

        public string Id
        {
            [Pure]
            get
            {
                return this._id;
            }
        }

        public string Version
        {
            [Pure]
            get
            {
                return this._version;
            }
        }

        public string FileName
        {
            [Pure]
            get
            {
                return this._fileName;
            }
        }

        public override void GetObjectData(
            SerializationInfo info,
            StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("Id", this._id);
            info.AddValue("Version", this._version);
            info.AddValue("FileName", this._fileName);
        }

        private static string BuildMessage(
            string id,
            string version,
            string fileName)
        {
            Contract.Requires<ArgumentNullException>(id != null);

            Contract.Ensures(Contract.Result<string>() != null);

            var builder = new StringBuilder(DefaultMessage);

            builder.AppendFormat(CultureInfo.InvariantCulture, "Id = {0}", id);

            if (version != null)
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, ", Version = {0}", version);
            }

            if (fileName != null)
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, ", FileName = {0}", fileName);
            }

            return builder.ToString();
        }

        private static Uri GetUri(
            string id,
            Exception ex)
        {
            var nfe = ex as GitHubNotFoundException;
            if (nfe != null)
            {
                return nfe.ResourceUri;
            }

            if (id != null)
            {
                return GitHubUri.Gist(id);
            }

            return null;
        }
    }
}
