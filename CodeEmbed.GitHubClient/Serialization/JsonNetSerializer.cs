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
        private readonly TypeResolver _resolver = new DefaultModelResolver();

        public void MapType<TRequire, TImplement>()
            where TImplement : TRequire, new()
        {
            this.MapType(typeof(TRequire), typeof(TImplement));
        }

        public void MapType(Type requiredType, Type impmenentType)
        {
            this._resolver[requiredType] = impmenentType;
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
                        settings.ContractResolver = this._resolver;

                        var serializer = JsonSerializer.CreateDefault(settings);
                        var result = serializer.Deserialize<T>(jsonReader);

                        return result;
                    }
                },
                cancellationToken);
        }
    }
}
