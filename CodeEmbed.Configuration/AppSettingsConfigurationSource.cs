namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppSettingsConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("Values")]
        private readonly IDictionary<string, string> _settings = new Dictionary<string, string>();

        public AppSettingsConfigurationSource()
        {
            this.Refresh();
        }

        public IDictionary<string, string> Values
        {
            get
            {
                return this._settings;
            }
        }

        public void Refresh()
        {
            this._settings.Clear();

            ConfigurationManager.RefreshSection("appSettings");

            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                this._settings[key] = ConfigurationManager.AppSettings[key];
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._settings != null);
        }
    }
}
