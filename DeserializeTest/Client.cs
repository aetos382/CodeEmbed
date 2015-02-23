namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    class Client
    {
        public static Repository GetRepository()
        {
            string json =
@"{

    ""id"": ""2769"",
    ""name"": ""FooBar"",
    ""user"": {
        ""name"": ""Alice""
    }
}";

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new JsonNetModelMapper<IRepositoryUser, SerializableRepositoryUser>());
            settings.Converters.Add(new JsonNetModelMapper<IRepository<IRepositoryUser>, SerializableRepository>());

            var deserialized = JsonConvert.DeserializeObject<IRepository<IRepositoryUser>>(json, settings);
            var result = new Repository(deserialized);

            return result;
        }
    }
}
