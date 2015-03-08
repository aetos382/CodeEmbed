using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class Repository :
        IRepository
    {
        private readonly IRepository _repository;

        private readonly RepositoryUser _user;

        private readonly Repository _parent;

        public Repository(
            IRepository repository)
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

        IRepositoryUser IRepository.User
        {
            get
            {
                return this._repository.User;
            }
        }

        IRepository IRepository.Parent
        {
            get
            {
                return this._repository.Parent;
            }
        }
    }
}
