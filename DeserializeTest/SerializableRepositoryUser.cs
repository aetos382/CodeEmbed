using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    [JsonObject]
    class SerializableRepositoryUser :
        IRepositoryUser
    {
        private readonly string _name;

        [JsonConstructor]
        public SerializableRepositoryUser(
            string name)
        {
            this._name = name;
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
        }
    }
}
