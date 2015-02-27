using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class GistFork :
        IGistFork<RepositoryUser>
    {
        private readonly IGistFork<IRepositoryUser> _fork;

        private readonly RepositoryUser _user;

        public GistFork(IGistFork<IRepositoryUser> fork)
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
    }
}
