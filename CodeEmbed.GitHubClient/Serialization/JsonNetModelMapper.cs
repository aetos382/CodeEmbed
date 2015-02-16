namespace CodeEmbed.GitHubClient.Serialization
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

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
            Contract.Requires<ArgumentNullException>(creator != null);

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

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._creator != null);
        }
    }
}
