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
    public partial class Gist :
        GistBase,
        IGist
    {
        private readonly IGist _gist = null;

        [ContractPublicPropertyName("Files")]
        private readonly IReadOnlyDictionary<String, GistFileContent> _files = null;

        [ContractPublicPropertyName("Forks")]
        private readonly IEnumerable<GistFork> _forks = null;

        [ContractPublicPropertyName("Histories")]
        private readonly IEnumerable<GistHistory> _histories = null;

        /// <summary>Create new instance of Gist.</summary>
        public Gist(
            IGist gist,
            IGitHubClient client)
            : base(gist, client)
        {
            Contract.Requires<ArgumentNullException>(gist != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gist = gist;

            if (gist.Files != null)
            {
                this._files = gist.Files.ToDictionary(x => x.Key, x => new GistFileContent(x.Value, client));
            }

            if (gist.Forks != null)
            {
                this._forks = gist.Forks.Select(x => new GistFork(x, client));
            }

            if (gist.Histories != null)
            {
                this._histories = gist.Histories.Select(x => new GistHistory(x, client));
            }
        }

        /// <summary>Map to "files"</summary>
        public IReadOnlyDictionary<String, GistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        /// <summary>Map to "forks"</summary>
        public IEnumerable<GistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }

        /// <summary>Map to "histories"</summary>
        public IEnumerable<GistHistory> Histories
        {
            get
            {
                return this._histories;
            }
        }

        /// <summary>Map to "files"</summary>
        IReadOnlyDictionary<String, IGistFileContent> IGist.Files
        {
            get
            {
                return this._gist.Files;
            }
        }

        /// <summary>Map to "forks"</summary>
        IEnumerable<IGistFork> IGist.Forks
        {
            get
            {
                return this._gist.Forks;
            }
        }

        /// <summary>Map to "histories"</summary>
        IEnumerable<IGistHistory> IGist.Histories
        {
            get
            {
                return this._gist.Histories;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gist != null);
        }
    }
}
