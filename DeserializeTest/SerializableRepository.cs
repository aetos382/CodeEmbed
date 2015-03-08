namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    class SerializableRepository :
        IRepository
    {
        private readonly string _name;

        private readonly IRepositoryUser _user;

        private readonly IRepository _parent;

        [JsonConstructor]
        public SerializableRepository(
            string name,
            IRepositoryUser user,
            IRepository parent)
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
        public IRepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        [JsonProperty("parent")]
        public IRepository Parent
        {
            get
            {
                return this._parent;
            }
        }
    }
}
