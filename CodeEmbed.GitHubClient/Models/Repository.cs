namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo
    
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    public class Repository :
        ModelBase, IRepository
    {
        private readonly IRepository _repository;

        public Repository(
            IRepository repository,
            IConnection connection)
            : base(connection)
        {
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(connection != null);

            this._repository = repository;
        }

        public long Id
        {
            get
            {
                return this._repository.Id;
            }
        }

        public string Name
        {
            get
            {
                return this._repository.Name;
            }
        }

        public string FullName
        {
            get
            {
                return this._repository.FullName;
            }
        }

        public string Description
        {
            get
            {
                return this._repository.Description;
            }
        }

        public Uri Uri
        {
            get
            {
                return this._repository.Uri;
            }
        }

        public string DefaultBranch
        {
            get
            {
                return this._repository.DefaultBranch;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repository != null);
        }
    }
}
