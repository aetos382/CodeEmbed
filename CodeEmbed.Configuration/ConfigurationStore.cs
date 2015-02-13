namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConfigurationStore
    {
        private static readonly IConfigurationSource[] _defaultConfigurationSources =
            {
                new AppSettingsConfigurationSource(),
                new FileConfigurationSource(),
                new EnvironmentVariableConfigurationSource()
            };

        [ContractPublicPropertyName("ConfigurationSources")]
        private readonly IList<IConfigurationSource> _configurationSources;

        public ConfigurationStore()
            : this(_defaultConfigurationSources)
        {
        }

        public ConfigurationStore(params IConfigurationSource[] configurationSources)
            : this((IEnumerable<IConfigurationSource>)configurationSources)
        {
            Contract.Requires<ArgumentNullException>(configurationSources != null);
            Contract.Requires<ArgumentNullException>(Contract.ForAll(configurationSources, x => x != null));
        }

        public ConfigurationStore(
            IEnumerable<IConfigurationSource> configurationSources)
        {
            Contract.Requires<ArgumentNullException>(configurationSources != null);
            Contract.Requires<ArgumentNullException>(Contract.ForAll(configurationSources, x => x != null));

            this._configurationSources = configurationSources.ToArray();
        }

        public IEnumerable<IConfigurationSource> ConfigurationSources
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IEnumerable<IConfigurationSource>>() != null);
                Contract.Ensures(Contract.ForAll(Contract.Result<IEnumerable<IConfigurationSource>>(), x => x != null));

                return this._configurationSources.ToArray();
            }
        }

        [Pure]
        public string GetConfigurationValue(string valueName)
        {
            var source = this._configurationSources.FirstOrDefault(
                x => x.Values.ContainsKey(valueName));

            if (source == null)
            {
                return null;
            }

            return source.Values[valueName];
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(_defaultConfigurationSources != null);
            Contract.Invariant(Contract.ForAll(_defaultConfigurationSources, x => x != null));

            Contract.Invariant(this._configurationSources != null);
            Contract.Invariant(Contract.ForAll(this._configurationSources, x => x != null));
        }
    }
}
