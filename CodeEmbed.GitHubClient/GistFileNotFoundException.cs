namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Linq;

    public class GistFileNotFoundException :
        GitHubException
    {
        private readonly string _id;

        private readonly string _version;

        private readonly string _fileName;

        private const string _messageFormat = "Gist ファイルが見つかりません。Id = {0}, Version = {1}, FileName = {2}";

        public GistFileNotFoundException(
            string id,
            string fileName)
            : base(BuildMessage(id, fileName))
        {
            this._id = id;
            this._fileName = fileName;
        }

        public GistFileNotFoundException(
            string id,
            string version,
            string fileName)
            : base(BuildMessage(id, version, fileName))
        {
            this._id = id;
            this._version = version;
            this._fileName = fileName;
        }

        public string Id
        {
            get
            {
                return this._id;
            }
        }

        public string Version
        {
            get
            {
                return this._version;
            }
        }

        public string FileName
        {
            get
            {
                return this._fileName;
            }
        }

        private static string BuildMessage(
            string id,
            string fileName)
        {
            return BuildMessage(id, "(null)", fileName);
        }

        private static string BuildMessage(
            string id,
            string version,
            string fileName)
        {
            return string.Format(_messageFormat, id, version ?? "(null)", fileName);
        }
    }
}
