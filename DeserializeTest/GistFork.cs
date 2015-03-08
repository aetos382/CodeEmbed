namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GistFork :
        IGistFork
    {
        private readonly IGistFork _fork;

        private readonly RepositoryUser _user;

        public GistFork(IGistFork fork)
        {
            this._fork = fork;
            this._user = new RepositoryUser(fork.User);
        }

        public RepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        IRepositoryUser IGistFork.User
        {
            get
            {
                return this._fork.User;
            }
        }
    }
}
