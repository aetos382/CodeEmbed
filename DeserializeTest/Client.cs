namespace DeserializeTest
{
    using System;
    using System.Linq;

    using CodeEmbed.GitHubClient.Serialization;

    using Newtonsoft.Json;
    
    using IGist = IGist<IGistFileContent, IGistFork<IRepositoryUser>, IRepositoryUser>;
    using IGistSummary = IGistSummary<IGistFile>;
    using IGistFork = IGistFork<IRepositoryUser>;

    class Client
    {
        public static Repository GetRepository()
        {
            string json =
@"{
    ""name"": ""RepoA"",
    ""user"": {
        ""name"": ""Alice""
    },
    ""parent"": {
        ""name"": ""RepoB"",
        ""user"": {
            ""name"": ""Bob""
        }
    }
}";

            var resolver = new TypeResolver();

            resolver.Map<IRepositoryUser, SerializableRepositoryUser>();
            resolver.Map<IRepository<SerializableRepository, SerializableRepositoryUser>, SerializableRepository>();

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = resolver;

            var deserialized = JsonConvert.DeserializeObject<IRepository<SerializableRepository, SerializableRepositoryUser>>(json, settings);
            var result = new Repository(deserialized);

            return result;
        }

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
            resolver.Map<IGistFork, SerializableGistFork>();
            resolver.Map<IRepositoryUser, SerializableRepositoryUser>();

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
    ""files"": {
        ""foo.txt"": {
            ""file_name"": ""foo.txt"",
            ""content"": ""FOOOOOOOOOOOOOOOOOOO""
        },
        ""bar.txt"": {
            ""file_name"": ""bar.txt"",
            ""content"": ""BARRRRRRRRRRRRRRRRRR""
        }
    },
    ""forks"": [
        {
            ""user"": {
                ""name"": ""Alice""
            }
        },
        {
            ""user"": {
                ""name"": ""Bob""
            }
        }
    ]
}";

            var resolver = new TypeResolver();

            resolver.Map<IGistFile, SerializableGistFile>();
            resolver.Map<IGistFileContent, SerializableGistFileContent>();
            resolver.Map<IGistSummary, SerializableGistSummary>();
            resolver.Map<IGist, SerializableGist>();
            resolver.Map<IGistFork, SerializableGistFork>();
            resolver.Map<IRepositoryUser, SerializableRepositoryUser>();

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = resolver;
            settings.Converters.Add(new OutputDictionaryCoverter());

            var deserialized = JsonConvert.DeserializeObject<IGist>(json, settings);
            var result = new Gist(deserialized);

            var serialized = JsonConvert.SerializeObject(deserialized, Formatting.Indented, settings);

            return result;
        }
    }
}
