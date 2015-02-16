namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.GitHubClient.Models.Serialization;

    using Newtonsoft.Json;

    public class JsonNetSerializer :
        IJsonSerializer
    {
        private static readonly IEnumerable<JsonConverter> _defaultConverters = new JsonConverter[]
            {
                new JsonNetModelMapper<IRepository, SerializableRepository>()
            };

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

                        settings.ContractResolver = new SneakCaseContractResolver();

                        var serializer = JsonSerializer.CreateDefault(settings);
                        var result = serializer.Deserialize<T>(jsonReader);

                        return result;
                    }
                },
                cancellationToken);
        }
    }
}
