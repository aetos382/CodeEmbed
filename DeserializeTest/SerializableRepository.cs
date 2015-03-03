using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class SerializableRepository :
        IRepository<SerializableRepository, SerializableRepositoryUser>
    {
        private readonly SerializableRepositoryUser _user;

        private readonly SerializableRepository _parent;

        public SerializableRepository(
            SerializableRepositoryUser user,
            SerializableRepository parent)
        {
            this._user = user;
            this._parent = parent;
        }

        public SerializableRepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        public SerializableRepository Parent
        {
            get
            {
                return this._parent;
            }
        }
    }
}
