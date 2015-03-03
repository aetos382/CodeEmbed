using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    [JsonObject]
    class SerializableRepository :
        IRepository<SerializableRepository, SerializableRepositoryUser>
    {
        private readonly string _name;

        private readonly SerializableRepositoryUser _user;

        private readonly SerializableRepository _parent;

        [JsonConstructor]
        public SerializableRepository(
            string name,
            SerializableRepositoryUser user,
            SerializableRepository parent)
        {
            this._name = name;
            this._user = user;
            this._parent = parent;
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        [JsonProperty("user")]
        public SerializableRepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        [JsonProperty("parent")]
        public SerializableRepository Parent
        {
            get
            {
                return this._parent;
            }
        }
    }
}
