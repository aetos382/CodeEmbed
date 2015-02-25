namespace DeserializeTest
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;
    
    using IRepository = IRepository<IRepositoryUser<IFoo>>;
    using IRepositoryUser = IRepositoryUser<IFoo>;

    using IGist = IGist<IGistFileContent>;
    using IGistSummary = IGistSummary<IGistFile>;

    class Client
    {
        public static GistSummary GetGistSummary()
        {
            string json =
@"{

    ""id"": ""gist1"",
    ""files"": {
        ""foo.txt"": {
            ""file_name"": ""foo.txt""
        },
        ""bar.txt"": {
            ""file_name"": ""bar.txt""
        }
    }
}";

            var resolver = new TypeResolver();

            resolver.Map<IGistFile, SerializableGistFile>();
            resolver.Map<IGistFileContent, SerializableGistFileContent>();
            resolver.Map<IGistSummary, SerializableGistSummary>();
            resolver.Map<IGist, SerializableGist>();

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = resolver;
            settings.Converters.Add(new OutputDictionaryCoverter());

            var deserialized = JsonConvert.DeserializeObject<IGistSummary>(json, settings);
            var result = new GistSummary(deserialized);

            return result;
        }
        
        public static Gist GetGist()
        {
            string json =
@"{

    ""id"": ""gist1"",
    ""created_at"": ""2015-02-24"",
    ""files"": {
        ""foo.txt"": {
            ""file_name"": ""foo.txt"",
            ""content"": ""FOOOOOOOOOOOOOOOOOOO""
        },
        ""bar.txt"": {
            ""file_name"": ""bar.txt"",
            ""content"": ""BARRRRRRRRRRRRRRRRRR""
        }
    }
}";

            var resolver = new TypeResolver();

            resolver.Map<IGistFile, SerializableGistFile>();
            resolver.Map<IGistFileContent, SerializableGistFileContent>();
            resolver.Map<IGistSummary, SerializableGistSummary>();
            resolver.Map<IGist, SerializableGist>();

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = resolver;
            settings.Converters.Add(new OutputDictionaryCoverter());

            var deserialized = JsonConvert.DeserializeObject<IGist>(json, settings);
            var result = new Gist(deserialized);

            var serialized = JsonConvert.SerializeObject(deserialized, Formatting.Indented, settings);

            return result;
        }

        public static Repository GetRepository()
        {
            string json =
@"{

    ""id"": ""2769"",
    ""name"": ""FooBar"",
    ""user"": {
        ""name"": ""Alice"",
        ""foo"": {}
    }
}";

            var resolver = new TypeResolver();

            resolver.Map<IRepository, SerializableRepository>();
            resolver.Map<IRepositoryUser, SerializableRepositoryUser>();
            resolver.Map<IFoo, SerializableFoo>();

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = resolver;

            var deserialized = JsonConvert.DeserializeObject<IRepository>(json, settings);
            var result = new Repository(deserialized);

            return result;
        }
    }
}
