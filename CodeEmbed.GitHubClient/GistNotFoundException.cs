namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class GistNotFoundException :
        GitHubNotFoundException
    {
        private const string MessageFormat = "Gist ファイルが見つかりません。Id = {0}, Version = {1}, FileName = {2}";

        [ContractPublicPropertyName("Id")]
        private readonly string _id;

        [ContractPublicPropertyName("Version")]
        private readonly string _version;

        [ContractPublicPropertyName("FileName")]
        private readonly string _fileName;

        public GistNotFoundException(
            string id,
            string version = null,
            string fileName = null,
            Exception innerException = null)
            : base(BuildMessage(id, version, fileName), innerException)
        {
            Contract.Requires<ArgumentNullException>(id != null);

            this._id = id;
            this._version = version;
            this._fileName = fileName;
        }

        public string Id
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

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

        private static string BuildMessage(
            string id,
            string version,
            string fileName)
        {
            Contract.Requires<ArgumentNullException>(id != null);

            Contract.Ensures(Contract.Result<string>() != null);

            return string.Format(MessageFormat, id, version ?? "(null)", fileName ?? "(null)");
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._id != null);
        }
    }
}
