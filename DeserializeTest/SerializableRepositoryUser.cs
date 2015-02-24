namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepositoryUser :
        IRepositoryUser<SerializableFoo>
    {
        private readonly string _name;

        private readonly SerializableFoo _foo;

        [JsonConstructor]
        public SerializableRepositoryUser(
            string name,
            SerializableFoo foo)
        {
            this._name = name;
            this._foo = foo;
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public SerializableFoo Foo
        {
            get
            {
                return this._foo;
            }
        }
    }
}
