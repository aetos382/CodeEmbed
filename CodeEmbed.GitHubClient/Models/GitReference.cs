namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/git/refs[/:ref]

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;
    using CodeEmbed.GitHubClient.Network;

    public class GitReference :
        IGitReference
    {
        private readonly IGitReference _reference;

        public GitReference(
            IGitReference reference)
        {
            Contract.Requires<ArgumentNullException>(reference != null);

            this._reference = reference;
        }

        public string Ref
        {
            get
            {
                return this._reference.Ref;
            }
        }

        public Uri Url
        {
            get
            {
                return this._reference.Url;
            }
        }

        public IGitRefObject Object
        {
            get
            {
                return this._reference.Object;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._reference != null);
        }
    }
}
