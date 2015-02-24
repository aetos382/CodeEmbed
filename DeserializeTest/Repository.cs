namespace DeserializeTest
{
    using System;
    using System.Linq;

    public class Repository :
        IRepository<RepositoryUser>
    {
        private readonly IRepository<IRepositoryUser<IFoo>> _repository;
        private readonly RepositoryUser _user;

        public Repository(IRepository<IRepositoryUser<IFoo>> repository)
        {
            this._repository = repository;
            this._user = new RepositoryUser(repository.User);
        }

        public RepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        public int Id
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
    }
}
