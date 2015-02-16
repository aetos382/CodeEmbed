namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class JsonNetSerializer :
        IJsonSerializer
    {
        private static IEnumerable<JsonConverter> GetDefaultMappers()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                var jsonAttribute = type.GetCustomAttribute<JsonObjectAttribute>();
                if (jsonAttribute == null)
                {
                    continue;
                }

                if (!type.Name.StartsWith("Serializable"))
                {
                    continue;
                }

                var interfaces = type.GetInterfaces();
                if (interfaces.Count() != 1)
                {
                    continue;
                }

                var mapperType = typeof(JsonNetModelMapper<,>).MakeGenericType(interfaces.Single(), type);
                var mapper = (JsonConverter)Activator.CreateInstance(mapperType);

                yield return mapper;
            }
        }

        private static readonly IEnumerable<JsonConverter> _defaultConverters = GetDefaultMappers().ToArray();

        private readonly ICollection<JsonConverter> _converters = new List<JsonConverter>();

        public void MapType<TRequire, TImplement>()
            where TImplement : TRequire, new()
        {
            this._converters.Add(new JsonNetModelMapper<TRequire, TImplement>());
        }

        public Task<T> Deserialize<T>(
            TextReader reader,
            CancellationToken cancellationToken)
        {
            return Task.Run(
                () => {
                    using (var jsonReader = new JsonTextReader(reader))
                    {
                        var settings = new JsonSerializerSettings();

                        foreach (var converter in _converters)
                        {
                            settings.Converters.Add(converter);
                        }

                        foreach (var converter in _defaultConverters)
                        {
                            settings.Converters.Add(converter);
                        }

                        var serializer = JsonSerializer.CreateDefault(settings);
                        var result = serializer.Deserialize<T>(jsonReader);

                        return result;
                    }
                },
                cancellationToken);
        }
    }
}
