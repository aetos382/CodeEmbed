namespace CodeEmbed.GitHubClient.JsonNet
{
    using System;

    using Newtonsoft.Json.Converters;

    public class ModelMapper<TRequire, TImplement> :
        CustomCreationConverter<TRequire>
        where TImplement : TRequire, new()
    {
        public override TRequire Create(Type objectType)
        {
            if (!typeof(TRequire).IsAssignableFrom(objectType))
            {
                throw new ArgumentException();
            }

            return new TImplement();
        }
    }
}
