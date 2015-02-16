namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo
    
    using System;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Network;

    public partial class Repository :
        IRepository
    {
        private readonly IRepository _repository;

        private readonly IConnection _connection;

        public Repository(
            IRepository repository,
            IConnection connection)
        {
            this._repository = repository;

            this._connection = connection;
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

        public IConnection Connection
        {
            get
            {
                return this._connection;
            }
        }
    }
}
