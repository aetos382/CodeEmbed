namespace CodeEmbed.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class FileConfigurationSource :
        IConfigurationSource
    {
        private static string _defaultConfigurationFilePath;

        private IDictionary<string, string> _settings;

        private string _configurationFilePath;

        public FileConfigurationSource()
            : this(DefaultConfigurationFilePath)
        {
        }

        public FileConfigurationSource(
            string configurationFilePath)
        {
            Contract.Requires<ArgumentNullException>(configurationFilePath != null);

            this._configurationFilePath = configurationFilePath;

            this.Refresh();
        }

        public static string DefaultConfigurationFilePath
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

                if (_defaultConfigurationFilePath == null)
                {
                    string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    _defaultConfigurationFilePath = Path.Combine(dir, "CodeEmbed.config.json");
                }

                return _defaultConfigurationFilePath;
            }
        }

        public string ConfigurationFilePath
        {
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);

                return this._configurationFilePath;
            }

            set
            {
                Contract.Requires<ArgumentNullException>(value != null);

                if (string.Equals(this._configurationFilePath, value, StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                this._configurationFilePath = value;

                this.Refresh();
            }
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
            string json = File.ReadAllText(this._configurationFilePath);
            this._settings = JsonConvert.DeserializeObject<IDictionary<string, string>>(json);
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._configurationFilePath != null);
            Contract.Invariant(this._settings != null);
        }
    }
}
