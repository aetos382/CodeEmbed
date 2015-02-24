namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepository :
        IRepository<SerializableRepositoryUser>
    {
        private readonly int _id;

        private readonly string _name;

        private readonly SerializableRepositoryUser _user;

        [JsonConstructor]
        public SerializableRepository(
            int id,
            string name,
            SerializableRepositoryUser user)
        {
            this._id = id;
            this._name = name;
            this._user = user;
        }

        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return this._id;
            }
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
    }
}
