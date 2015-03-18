namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GistSummary :
        GistBase,
        IGistSummary
    {
        private readonly IGistSummary _gistSummary = null;

        [ContractPublicPropertyName("Files")]
        private readonly IReadOnlyDictionary<String, GistFile> _files = null;

        /// <summary>Create new instance of GistSummary.</summary>
        public GistSummary(
            IGistSummary gistSummary,
            IGitHubClient client)
            : base(gistSummary, client)
        {
            Contract.Requires<ArgumentNullException>(gistSummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gistSummary = gistSummary;

            if (gistSummary.Files != null)
            {
                this._files = gistSummary.Files.ToDictionary(x => x.Key, x => new GistFile(x.Value, client));
            }
        }

        /// <summary>Map to "files"</summary>
        public IReadOnlyDictionary<String, GistFile> Files
        {
            get
            {
                return this._files;
            }
        }

        /// <summary>Map to "files"</summary>
        IReadOnlyDictionary<String, IGistFile> IGistSummary.Files
        {
            get
            {
                return this._gistSummary.Files;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gistSummary != null);
        }
    }
}
