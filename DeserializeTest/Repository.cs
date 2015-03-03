using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class Repository<TRepository, TRepositoryUser> :
        IRepository<Repository<TRepository, TRepositoryUser>, RepositoryUser>
        where TRepository : IRepository<TRepository, TRepositoryUser>
        where TRepositoryUser : IRepositoryUser
    {
        private readonly IRepository<TRepository, TRepositoryUser> _repository;

        private readonly RepositoryUser _user;

        private readonly Repository<TRepository, TRepositoryUser> _parent;

        public Repository(
            IRepository<TRepository, TRepositoryUser> repository)
        {
            this._repository = repository;

            this._user = new RepositoryUser(repository.User);

            if (repository.Parent != null)
            {
                this._parent = new Repository<TRepository, TRepositoryUser>(repository.Parent);
            }
        }

        public RepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        public Repository<TRepository, TRepositoryUser> Parent
        {
            get
            {
                return this._parent;
            }
        }
    }
}
