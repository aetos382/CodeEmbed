namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Contracts;

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
            Requires.ArgumentNotNull(configurationSources);

            this._configurationSources = new List<IConfigurationSource>(configurationSources);
        }

        public IList<IConfigurationSource> ConfigurationSources
        {
            [Pure]
            get
            {
                Ensures.ResultIsNotNull<IList<IConfigurationSource>>();

                return this._configurationSources;
            }
        }

        public string GetConfigurationValue(string valueName)
        {
            Requires.StringNotNullOrEmpty(valueName);

            var source = this._configurationSources.LastOrDefault(
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
            Contract.Invariant(this._configurationSources != null);
        }
    }
}
