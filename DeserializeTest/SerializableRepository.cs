namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepository :
        IRepository<SerializableRepositoryUser>
    {
        public SerializableRepository()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("user")]
        public SerializableRepositoryUser User { get; set; }
    }
}
