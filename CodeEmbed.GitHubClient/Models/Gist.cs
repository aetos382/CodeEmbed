namespace CodeEmbed.GitHubClient.Models
{
    //// GET /gists/:id

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class Gist :
        IGist
    {
        private readonly IGist _gist;

        public Gist(IGist gist)
        {
            Contract.Requires<ArgumentNullException>(gist != null);

            this._gist = gist;
        }

        public Uri Uri
        {
            get
            {
                return this._gist.Uri;
            }
        }

        public string Id
        {
            get
            {
                return this._gist.Id;
            }
        }

        public string Description
        {
            get
            {
                return this._gist.Description;
            }
        }

        public IDictionary<string, IGistFile> Files
        {
            get
            {
                return this._gist.Files;
            }
        }

        public IList<IGistHistory> Histories
        {
            get
            {
                return this._gist.Histories;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gist != null);
        }
    }
}
