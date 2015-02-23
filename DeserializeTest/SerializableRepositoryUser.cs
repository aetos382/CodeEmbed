namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepositoryUser :
        IRepositoryUser
    {
        public SerializableRepositoryUser()
        {
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
