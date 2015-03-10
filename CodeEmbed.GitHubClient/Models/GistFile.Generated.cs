namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GistFile :
        IGistFile
    {
        private readonly IGistFile _gistFile = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GistFile.</summary>
        public GistFile(
            IGistFile gistFile,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFile != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._gistFile = gistFile;

            this._client = client;
        }

        /// <summary>Map to "size"</summary>
        public Int64 Size
        {
            get
            {
                return this._gistFile.Size;
            }
        }

        /// <summary>Map to "raw_url"</summary>
        public Uri RawUri
        {
            get
            {
                return this._gistFile.RawUri;
            }
        }

        /// <summary>Map to "type"</summary>
        public String ContentType
        {
            get
            {
                return this._gistFile.ContentType;
            }
        }

        /// <summary>Map to "truncated"</summary>
        public Boolean Truncated
        {
            get
            {
                return this._gistFile.Truncated;
            }
        }

        /// <summary>Map to "language"</summary>
        public String Language
        {
            get
            {
                return this._gistFile.Language;
            }
        }

        public IGitHubClient Client
        {
            get
            {
                Contract.Ensures(Contract.Result<IGitHubClient>() != null);

                return this._client;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gistFile != null);

            Contract.Invariant(this._client != null);
        }
    }
}
