namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class JsonNetSerializer :
        IJsonSerializer
    {
        private readonly TypeResolver _resolver = new TypeResolver();

        public void MapType<TRequire, TImplement>()
            where TImplement : TRequire
        {
            this.MapType(typeof(TRequire), typeof(TImplement));
        }

        public void MapType(Type requiredType, Type impmenentType)
        {
            this._resolver[requiredType] = impmenentType;
        }

        private static string GetInterfaceName(string className)
        {
            Contract.Requires<ArgumentNullException>(className != null);

            Contract.Ensures(Contract.Result<string>() != null);

            if (className.StartsWith("Serializable"))
            {
                className = className.Substring("Serializable".Length);
            }

            return "I" + className;
        }

        private static readonly Lazy<IDictionary<Type, Type>> _instance = new Lazy<IDictionary<Type, Type>>(
            () => {
                var typePairs =
                                Assembly.GetExecutingAssembly()
                            .GetTypes()
                            .Where(x => x.GetCustomAttributes<JsonObjectAttribute>().Any())
                            .ToDictionary(x => x.GetInterface(GetInterfaceName(x.Name)), x => x);

                return typePairs;
            });


        public void MapAllTypes()
        {
            foreach (var types in _instance.Value)
            {
                this.MapType(types.Key, types.Value);
            }
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
