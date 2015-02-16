namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    public class RepositoryPermissions :
        IRepositoryPermissions
    {
        private readonly IRepositoryPermissions _repositoryPermissions;

        public RepositoryPermissions(
            IRepositoryPermissions repositoryPermissions)
        {
            Contract.Requires<ArgumentNullException>(repositoryPermissions != null);

            this._repositoryPermissions = repositoryPermissions;
        }

        public bool Administration
        {
            get
            {
                return this._repositoryPermissions.Administration;
            }
        }

        public bool Push
        {
            get
            {
                return this._repositoryPermissions.Push;
            }
        }

        public bool Pull
        {
            get
            {
                return this._repositoryPermissions.Pull;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repositoryPermissions != null);
        }
    }
}
