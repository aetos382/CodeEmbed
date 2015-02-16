namespace CodeEmbed.GitHubClient.Serialization
{
    using System;

    using Newtonsoft.Json.Converters;

    public class JsonNetModelMapper<TRequire, TImplement> :
        CustomCreationConverter<TRequire>
        where TImplement : TRequire, new()
    {
        private readonly Func<TRequire> _creator;

        public JsonNetModelMapper()
            : this(() => new TImplement())
        {
        }

        public JsonNetModelMapper(Func<TRequire> creator)
        {
            this._creator = creator;
        }

        public override TRequire Create(Type objectType)
        {
            if (!typeof(TRequire).IsAssignableFrom(objectType))
            {
                throw new NotSupportedException();
            }

            return this._creator();
        }
    }
}
