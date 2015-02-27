namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using CodeEmbed.GitHubClient.Collections;

    using Newtonsoft.Json;

    public class OutputDictionaryCoverter :
        JsonConverter
    {
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer)
        {
            var objectType = value.GetType();

            if (!IsOutputDictionary(objectType))
            {
                throw new NotSupportedException();
            }

            var arguments = objectType.GetGenericArguments();

            var method = typeof(OutputDictionaryExtension).GetMethod("ToDictionary").MakeGenericMethod(arguments);
            var result = method.Invoke(null, new[] { value });

            serializer.Serialize(writer, result);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            if (!IsOutputDictionary(objectType))
            {
                throw new NotSupportedException();
            }

            var arguments = objectType.GetGenericArguments();
            var dictionaryType = typeof(IDictionary<,>).MakeGenericType(arguments);

            object deserialized = serializer.Deserialize(reader, dictionaryType);

            var concreteType = typeof(OutputDictionary<,>).MakeGenericType(arguments);
            var constructor = concreteType.GetConstructor(new[] { dictionaryType });

            var result = constructor.Invoke(new[] { deserialized });

            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return IsOutputDictionary(objectType);
        }

        [Pure]
        private static bool IsOutputDictionary(Type type)
        {
            Contract.Requires<ArgumentNullException>(type != null);

            if (!type.IsConstructedGenericType)
            {
                return false;
            }

            var genericTypeDef = type.GetGenericTypeDefinition();
            if (genericTypeDef != typeof(IOutputDictionary<,>) && genericTypeDef != typeof(OutputDictionary<,>))
            {
                return false;
            }

            return true;
        }
    }
}
