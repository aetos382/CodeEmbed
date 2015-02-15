namespace CodeEmbed.GitHubClient.JsonNet
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.JsonNet.Models;
    using CodeEmbed.GitHubClient.Models;

    using Newtonsoft.Json;

    public class JsonNetSerializer :
        IJsonSerializer
    {
        private static readonly IEnumerable<JsonConverter> _defaultConverters = new JsonConverter[]
            {
                new ModelMapper<IRepository, JsonNetRepository>(),
                new ModelMapper<IBranch, JsonNetBranch>()
            };

        private readonly ICollection<JsonConverter> _converters = new List<JsonConverter>();

        public void MapType<TRequire, TImplement>()
            where TImplement : TRequire, new()
        {
            this._converters.Add(new ModelMapper<TRequire, TImplement>());
        }

        public Task<T> Deserialize<T>(
            Stream stream,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            return Task.Run(() =>
                {
                    using (var streamReader = new StreamReader(stream, encoding))
                    using (var jsonReader = new JsonTextReader(streamReader))
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

                        var serializer = JsonSerializer.CreateDefault();
                        var result = serializer.Deserialize<T>(jsonReader);

                        return result;
                    }
                },
                cancellationToken);
        }
    }
}
