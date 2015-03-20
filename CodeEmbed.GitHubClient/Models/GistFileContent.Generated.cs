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
    public partial class GistFileContent :
        GistFile,
        IGistFileContent
    {
        private readonly IGistFileContent _gistFileContent = null;

        /// <summary>Create new instance of GistFileContent.</summary>
        public GistFileContent(
            IGistFileContent gistFileContent,
            IGitHubClient client)
            : base(gistFileContent, client)
        {
            Contract.Requires<ArgumentNullException>(gistFileContent != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gistFileContent = gistFileContent;
        }

        /// <summary>Map to "content"</summary>
        public String Content
        {
            get
            {
                return this._gistFileContent.Content;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gistFileContent != null);
        }
    }
}
