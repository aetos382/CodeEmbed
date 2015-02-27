using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    [JsonObject]
    class SerializableGistFork :
        IGistFork<SerializableRepositoryUser>
    {
        private SerializableRepositoryUser _user;

        [JsonConstructor]
        public SerializableGistFork(
            SerializableRepositoryUser user)
        {
            this._user = user;
        }

        [JsonProperty("user")]
        public SerializableRepositoryUser User
        {
            get
            {
                return this._user;
            }
        }
    }
}
