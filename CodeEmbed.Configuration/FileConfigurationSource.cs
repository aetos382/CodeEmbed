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

    using CodeEmbed.Contracts;

    using Newtonsoft.Json;

    public class FileConfigurationSource :
        IConfigurationSource
    {
        [ContractPublicPropertyName("DefaultConfigurationFilePath")]
        private static string _defaultConfigurationFilePath;

        [ContractPublicPropertyName("Values")]
        private IDictionary<string, string> _settings = new Dictionary<string, string>();

        [ContractPublicPropertyName("ConfigurationFilePath")]
        private string _configurationFilePath;

        public FileConfigurationSource()
            : this(DefaultConfigurationFilePath)
        {
        }

        public FileConfigurationSource(
            string configurationFilePath)
        {
            Requires.StringNotNullOrEmpty(configurationFilePath);

            this._configurationFilePath = configurationFilePath;

            this.Refresh();
        }

        public static string DefaultConfigurationFilePath
        {
            [Pure]
            get
            {
                Ensures.StringIsNotNullOrEmpty();

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
                Ensures.StringIsNotNullOrEmpty();

                return this._configurationFilePath;
            }

            set
            {
                Requires.StringNotNullOrEmpty(value);

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
            this._settings.Clear();

            if (!File.Exists(this._configurationFilePath))
            {
                return;
            }

            string json = File.ReadAllText(this._configurationFilePath);
            var settings = JsonConvert.DeserializeObject<IDictionary<string, string>>(json);
            if (settings != null)
            {
                this._settings = settings;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(_defaultConfigurationFilePath != null);
            Contract.Invariant(!string.IsNullOrEmpty(_defaultConfigurationFilePath));

            Contract.Invariant(this._configurationFilePath != null);
            Contract.Invariant(!string.IsNullOrEmpty(this._configurationFilePath));

            Contract.Invariant(this._settings != null);
        }
    }
}
