namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class DefaultModelResolver :
        TypeResolver
    {
        private static readonly Lazy<IDictionary<Type, Type>> _instance = new Lazy<IDictionary<Type, Type>>(
            () =>
                {
                    var typePairs =
                        Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .Where(x => x.GetCustomAttributes<JsonObjectAttribute>().Any())
                                .ToDictionary(x => x.GetInterfaces()[0], x => x);

                    return typePairs;
                });

        public DefaultModelResolver()
        {
            foreach (var entry in _instance.Value)
            {
                this.Map(entry.Key, entry.Value);
            }
        }
    }
}
