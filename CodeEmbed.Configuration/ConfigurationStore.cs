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
        [ContractPublicPropertyName("ConfigurationSources")]
        private readonly IList<IConfigurationSource> _configurationSources; 

        public ConfigurationStore()
        {
            this._configurationSources = new List<IConfigurationSource>()
                {
                    new AppSettingsConfigurationSource(),
                    new FileConfigurationSource(),
                    new EnvironmentVariableConfigurationSource()
                };
        }

        public ConfigurationStore(IEnumerable<IConfigurationSource> configurationSources)
        {
            Contract.Requires<ArgumentNullException>(configurationSources != null);

            this._configurationSources = new List<IConfigurationSource>(configurationSources);
        }

        public IList<IConfigurationSource> ConfigurationSources
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IList<IConfigurationSource>>() != null);

                return this._configurationSources;
            }
        }

        public string GetConfigurationValue(string valueName)
        {
            Contract.Requires<ArgumentNullException>(valueName != null);

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
        private void ObjectInvariant()
        {
            Contract.Invariant(this._configurationSources != null);
        }
    }
}
