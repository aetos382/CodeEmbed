namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo/branches[/:branch]
    
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class Branch :
        IBranch
    {
        private readonly IBranch _branch;

        public Branch(
            IBranch branch)
        {
            Contract.Requires<ArgumentNullException>(branch != null);

            this._branch = branch;
        }

        public string Name
        {
            get
            {
                return this._branch.Name;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._branch != null);
        }
    }
}
