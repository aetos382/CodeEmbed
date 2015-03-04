using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class Repository :
        IRepository<Repository, RepositoryUser>
    {
        private readonly IRepository<IRepository, IRepositoryUser> _repository;

        private readonly RepositoryUser _user;

        private readonly Repository _parent;

        public Repository(
            IRepository<IRepository, IRepositoryUser> repository)
        {
            this._repository = repository;

            this._user = new RepositoryUser(repository.User);

            if (repository.Parent != null)
            {
                this._parent = new Repository(repository.Parent);
            }
        }

        public string Name
        {
            get
            {
                return this._repository.Name;
            }
        }

        public RepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        public Repository Parent
        {
            get
            {
                return this._parent;
            }
        }
    }
}
