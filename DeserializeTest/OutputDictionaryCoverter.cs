using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json.Converters;

    public class OutputDictionaryCoverter<TKey, TValue> :
        CustomCreationConverter<IOutputDictionary<TKey, TValue>>
    {
        public override IOutputDictionary<TKey, TValue> Create(Type objectType)
        {
            Type genericType = typeof(IOutputDictionary<,>);

            if (!objectType.IsConstructedGenericType
                || objectType.GetGenericTypeDefinition() != genericType)
            {
                throw new NotSupportedException();
            }

            var genericArguments = objectType.GetGenericArguments();
            var constructedType = genericType.MakeGenericType(genericArguments);
        }
    }
}
