using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class RepositoryUser :
        IRepositoryUser
    {
        private readonly IRepositoryUser _user;

        public RepositoryUser(IRepositoryUser user)
        {
            this._user = user;
        }

        public string Name
        {
            get
            {
                return _user.Name;
            }
        }
    }
}
