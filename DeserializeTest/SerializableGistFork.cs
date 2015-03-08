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
        IGistFork
    {
        private IRepositoryUser _user;

        [JsonConstructor]
        public SerializableGistFork(
            IRepositoryUser user)
        {
            this._user = user;
        }

        [JsonProperty("user")]
        public IRepositoryUser User
        {
            get
            {
                return this._user;
            }
        }
    }
}
